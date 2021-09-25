using System;

namespace SysInfo
{
    public struct Driver
    {
        public DateTime Date { get; }
        public string Version { get; }
        public string Name { get; }

        public Driver(DateTime date, string version, string name)
        {
            Date = date;
            Version = version;
            Name = name;
        }
    }
}
