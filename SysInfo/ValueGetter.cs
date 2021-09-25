using SysInfo.Enums;
using SysInfo.Extensions;

using System;
using System.Management;
using System.ComponentModel;
using System.IO;

namespace SysInfo
{
    internal class ValueGetter
    {
        internal readonly bool _sys;

        internal ValueGetter()
            => _sys = Environment.OSVersion.Platform.IsLinux();

        internal T GetValue<T>(Win32Class name, string key)
        {
            T value = default;

            if (!_sys)
            {
                var searcher = new ManagementObjectSearcher($"select * from {name}");

                foreach (var result in searcher.Get())
                {
                    try
                    {
                        return (T)result[key];
                    }
                    catch
                    {
                        return value;
                    }
                }
            }
            else
            {
                string linuxValue = name.GetLinuxValue();

                key = key.GetLinuxKey(name);

                if (linuxValue == null || key == null)
                    return default;

                string[] lines = File.ReadAllLines("/proc/" + linuxValue);

                if (lines == null || lines.Length < 1)
                    return default;

                RegexMatch<T> match = new RegexMatch<T>("^" + key + @":\s+(\d+)", val => value = ChangeType<T>(val));

                foreach (string line in lines)
                {
                    var m = match.Regex.Match(line);

                    if (m.Groups[1].Success)
                    {
                        string str = m.Groups[1].Value;

                        match.Update(str);
                    }
                }
            }

            return value;
        }

        internal T ChangeType<T>(object value)
            => (T)ChangeType(typeof(T), value);

        internal object ChangeType(Type t, object value)
        {
            TypeConverter tc = TypeDescriptor.GetConverter(t);

            return tc.ConvertFrom(value);
        }
    }
}
