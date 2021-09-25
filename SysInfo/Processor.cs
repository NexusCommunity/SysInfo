using System;

using SysInfo.Enums;
using SysInfo.Extensions;

namespace SysInfo
{
    public class Processor
    {
        internal ValueGetter _get;

        public Processor()
        {
            _get = new ValueGetter();

            Description = _get.GetValue<string>(Win32Class.Win32_Processor, "Description");
            Socket = _get.GetValue<string>(Win32Class.Win32_Processor, "SocketDesignation");
            Stepping = _get.GetValue<string>(Win32Class.Win32_Processor, "Stepping");
            InstallationDate = _get.GetValue<DateTime>(Win32Class.Win32_Processor, "InstallDate");
            Architecture = (CpuArchitecture)_get.GetValue<UInt16>(Win32Class.Win32_Processor, "Architecture");
            Family = (CpuFamily)_get.GetValue<UInt16>(Win32Class.Win32_Processor, "Family");
            Type = (CpuType)_get.GetValue<UInt16>(Win32Class.Win32_Processor, "ProcessorType");
            UpgradeMethod = (CpuUpgradeMethod)_get.GetValue<UInt16>(Win32Class.Win32_Processor, "UpgradeMethod");
            L2Cache = _get.GetValue<UInt32>(Win32Class.Win32_Processor, "L2CacheSize");
            L3Cache = _get.GetValue<UInt32>(Win32Class.Win32_Processor, "L3CacheSize");
            MaxClock = _get.GetValue<UInt32>(Win32Class.Win32_Processor, "MaxClockSpeed");
            VoltageCapability = (CpuVoltageCapability)_get.GetValue<UInt32>(Win32Class.Win32_Processor, "VoltageCaps");
            Cores = _get.GetValue<UInt32>(Win32Class.Win32_Processor, "NumberOfCores");
            ActiveCores = _get.GetValue<UInt32>(Win32Class.Win32_Processor, "NumberOfEnabledCores");
            Threads = _get.GetValue<UInt32>(Win32Class.Win32_Processor, "ThreadCount");

            if (_get._sys)
                Manufacturer = _get.GetValue<string>(Win32Class.Win32_Processor, "Vendor").GetManufacturer();
            else
                Manufacturer = Family.GetManufacturer();

            Refresh();
        }

        public string Description { get; }
        public CpuManufacturer Manufacturer { get; }
        public string Socket { get; }
        public string Stepping { get; }

        public DateTime InstallationDate { get; }

        public CpuArchitecture Architecture { get; }
        public CpuFamily Family { get; }
        public CpuType Type { get; }
        public CpuUpgradeMethod UpgradeMethod { get; }

        public UInt32 L2Cache { get; }
        public UInt32 L3Cache { get; }
        public UInt32 MaxClock { get; }
        public CpuVoltageCapability VoltageCapability { get; }
        public UInt32 Cores { get; }
        public UInt32 ActiveCores { get; }
        public UInt32 Threads { get; }

        public UInt16 Load { get; internal set; }
        public UInt16 Voltage { get; internal set; }
        public UInt32 Clock { get; internal set; }
        public CpuStatus Status { get; internal set; }
        public Availability Availability { get; internal set; }

        public void Refresh()
        {
            Load = _get.GetValue<UInt16>(Win32Class.Win32_Processor, "LoadPercentage");
            Voltage = _get.GetValue<UInt16>(Win32Class.Win32_Processor, "VoltageCaps");
            Clock = _get.GetValue<UInt16>(Win32Class.Win32_Processor, "CurrentClockSpeed");
            Status = (CpuStatus)_get.GetValue<UInt16>(Win32Class.Win32_Processor, "CpuStatus");
            Availability = (Availability)_get.GetValue<UInt16>(Win32Class.Win32_Processor, "Availability");
        }
    }
}
