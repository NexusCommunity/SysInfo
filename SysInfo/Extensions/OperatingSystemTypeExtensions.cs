using SysInfo.Enums;

namespace SysInfo.Extensions
{
    public static class OperatingSystemTypeExtensions
    {
        public static bool IsLinux(this System.PlatformID type)
            => type == System.PlatformID.Unix;

        public static bool IsLinux(this OperatingSystemType type)
            => type == OperatingSystemType.Linux32 || type == OperatingSystemType.Linux64 ||
               type == OperatingSystemType.Linux86 || type == OperatingSystemType.LinuxARM;

        public static bool IsWindows(this OperatingSystemType type)
            => !type.IsLinux();

        public static bool IsWindows(this System.PlatformID type)
            => type == System.PlatformID.Win32NT || type == System.PlatformID.Win32S ||
               type == System.PlatformID.Win32Windows || type == System.PlatformID.Win32NT ||
               type == System.PlatformID.WinCE;
    }
}