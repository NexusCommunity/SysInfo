using System;

using SysInfo.Enums;

namespace SysInfo
{
    public class GraphicsCard
    {
        internal ValueGetter _get;

        public GraphicsCard()
        {
            _get = new ValueGetter();

            Description = _get.GetValue<string>(Win32Class.Win32_VideoController, "Description");
            Processor = _get.GetValue<string>(Win32Class.Win32_VideoController, "VideoProcessor");
            Availability = (Availability)_get.GetValue<UInt16>(Win32Class.Win32_VideoController, "Availability");
            VRAM = _get.GetValue<UInt32>(Win32Class.Win32_VideoController, "AdapterRAM");
            BitsPerPixel = _get.GetValue<UInt32>(Win32Class.Win32_VideoController, "CurrentBitsPerPixel");

            Drivers = new Driver(_get.GetValue<DateTime>(Win32Class.Win32_VideoController, "DriverDate"),
                _get.GetValue<string>(Win32Class.Win32_VideoController, "DriverVersion"), _get.GetValue<string>(Win32Class.Win32_VideoController,
                "InstalledDisplayDrivers"));

            Resolution = new Resolution
            {
                Description = _get.GetValue<string>(Win32Class.Win32_VideoController, "VideoModeDescription"),
                Horizontal = _get.GetValue<UInt32>(Win32Class.Win32_VideoController, "CurrentHorizontalResolution"),
                MaxRefreshRate = _get.GetValue<UInt16>(Win32Class.Win32_VideoController, "MaxRefreshRate"),
                MinRefreshRate = _get.GetValue<UInt16>(Win32Class.Win32_VideoController, "MinRefreshRate"),
                RefreshRate = _get.GetValue<UInt32>(Win32Class.Win32_VideoController, "CurrentRefreshRate"),
                Vertical = _get.GetValue<UInt32>(Win32Class.Win32_VideoController, "CurrentVerticalResolution")
            };
        }

        public string Description { get; }
        public string Processor { get; }

        public Availability Availability { get; internal set; }

        public Resolution Resolution { get; }
        public Driver Drivers { get; }

        public UInt32 VRAM { get; }
        public UInt32 BitsPerPixel { get; internal set; }
    }
}
