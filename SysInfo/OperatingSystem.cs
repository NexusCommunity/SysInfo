using SysInfo.Enums;
using SysInfo.Extensions;

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace SysInfo
{
    public class OperatingSystem
    {
        public OperatingSystem()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Platform = OSPlatform.Windows;

                if (RuntimeInformation.OSArchitecture == System.Runtime.InteropServices.Architecture.X64)
                {
                    Type = OperatingSystemType.Windows64;
                    Architecture = ArchitectureType.x64bit;
                }
                else if (RuntimeInformation.OSArchitecture == System.Runtime.InteropServices.Architecture.Arm64)
                {
                    Type = OperatingSystemType.WindowsARM;
                    Architecture = ArchitectureType.ARM64;
                }
                else if (RuntimeInformation.OSArchitecture == System.Runtime.InteropServices.Architecture.Arm)
                {
                    Type = OperatingSystemType.WindowsARM;
                    Architecture = ArchitectureType.ARM;
                }
                else if (RuntimeInformation.OSArchitecture == System.Runtime.InteropServices.Architecture.X86)
                {
                    Type = OperatingSystemType.Windows86;
                    Architecture = ArchitectureType.x86bit;
                }
                else
                {
                    Type = OperatingSystemType.Windows32;
                    Architecture = ArchitectureType.x32bit;
                }
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                Platform = OSPlatform.Linux;

                if (RuntimeInformation.OSArchitecture == System.Runtime.InteropServices.Architecture.X64)
                {
                    Type = OperatingSystemType.Linux64;
                    Architecture = ArchitectureType.x64bit;
                }
                else if (RuntimeInformation.OSArchitecture == System.Runtime.InteropServices.Architecture.Arm64)
                {
                    Type = OperatingSystemType.LinuxARM;
                    Architecture = ArchitectureType.ARM64;
                }
                else if (RuntimeInformation.OSArchitecture == System.Runtime.InteropServices.Architecture.Arm)
                {
                    Type = OperatingSystemType.LinuxARM;
                    Architecture = ArchitectureType.ARM;
                }
                else if (RuntimeInformation.OSArchitecture == System.Runtime.InteropServices.Architecture.X86)
                {
                    Type = OperatingSystemType.Linux86;
                    Architecture = ArchitectureType.x86bit;
                }
                else
                {
                    Type = OperatingSystemType.Linux32;
                    Architecture = ArchitectureType.x32bit;
                }
            }

            if (IsLinux)
                VersionString = File.ReadAllText("/proc/version");
            else
                VersionString = Environment.OSVersion.VersionString;
        }

        public ArchitectureType Architecture { get; }
        public OperatingSystemType Type { get; }

        public OSPlatform Platform { get; }

        public bool Is64Bit => Architecture.Is64Bit();
        public bool Is32Bit => Architecture.Is32Bit();
        public bool IsARM => Architecture.IsARM();

        public bool IsWindows => Type.IsWindows();
        public bool IsLinux => Type.IsLinux();

        public Version Version => Environment.OSVersion.Version;

        public string VersionString { get; }
        public string ServicePack => Environment.OSVersion.ServicePack;
        public string NewLine => Environment.NewLine;
        public string NetBIOSName => Environment.MachineName;
        public string Directory => Environment.SystemDirectory;
        public string Description => RuntimeInformation.OSDescription;

        public long PageSize => Environment.SystemPageSize;

        public string GetVariable(string variable)
            => Environment.GetEnvironmentVariable(variable);

        public void SetVariable(string variable, string value)
            => Environment.SetEnvironmentVariable(variable, value); 
    }
}
