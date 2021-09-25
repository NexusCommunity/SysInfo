using System;

namespace SysInfo
{
    public struct Resolution
    {
        public UInt32 Horizontal { get; internal set; }
        public UInt32 Vertical { get; internal set; }
        public UInt32 RefreshRate { get; internal set; }
        public UInt16 MinRefreshRate { get; internal set; }
        public UInt16 MaxRefreshRate { get; internal set; }

        public string Description { get; internal set; }
    }
}