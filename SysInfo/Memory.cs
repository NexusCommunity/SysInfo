using System;

namespace SysInfo
{
    public class Memory
    {
        internal ValueGetter _get;

        public Memory()
        {
            _get = new ValueGetter();

            Bank = _get.GetValue<string>(Enums.Win32Class.Win32_PhysicalMemory, "BankLabel");
            Manufacturer = _get.GetValue<string>(Enums.Win32Class.Win32_PhysicalMemory, "Manufacturer");
            Model = _get.GetValue<string>(Enums.Win32Class.Win32_PhysicalMemory, "Model");
            InstallationDate = _get.GetValue<DateTime>(Enums.Win32Class.Win32_PhysicalMemory, "InstallDate");
            Capacity = _get.GetValue<UInt64>(Enums.Win32Class.Win32_PhysicalMemory, "Capacity");
            Clock = _get.GetValue<UInt32>(Enums.Win32Class.Win32_PhysicalMemory, "ConfiguredClockSpeed");
            Speed = _get.GetValue<UInt32>(Enums.Win32Class.Win32_PhysicalMemory, "Speed");
            Voltage = _get.GetValue<UInt32>(Enums.Win32Class.Win32_PhysicalMemory, "ConfiguredVoltage");
            MinVoltage = _get.GetValue<UInt32>(Enums.Win32Class.Win32_PhysicalMemory, "MinVoltage");
            MaxVoltage = _get.GetValue<UInt32>(Enums.Win32Class.Win32_PhysicalMemory, "MaxVoltage");
        }

        public string Bank { get; }
        public string Manufacturer { get; }
        public string Model { get; }

        public DateTime InstallationDate { get; }

        public UInt64 Capacity { get; }
        public UInt32 Clock { get; }
        public UInt32 Speed { get; }
        public UInt32 Voltage { get; }
        public UInt32 MinVoltage { get; }
        public UInt32 MaxVoltage { get; }
    }
}
