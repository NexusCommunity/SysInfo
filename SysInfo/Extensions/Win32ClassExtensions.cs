using SysInfo.Enums;

using System.IO;

namespace SysInfo.Extensions
{
    internal static class Win32ClassExtensions
    {
        internal static string GetLinuxValue(this Win32Class name)
        {
            switch (name)
            {
                case Win32Class.Win32_PhysicalMemory:
                    {
                        return "meminfo";
                    }

                case Win32Class.Win32_Processor:
                    {
                        return "cpuinfo";
                    }

                case Win32Class.Win32_VideoController:
                    {
                        if (Directory.Exists($"/proc/drivers/amd"))
                            return "/proc/drivers/amd/gpus/0";

                        if (Directory.Exists("/proc/drivers/nvidia"))
                            return "/proc/drivers/nvidia/gpus/0";

                        if (Directory.Exists("/proc/drivers/intel"))
                            return "/proc/drivers/intel/gpus/0";

                        return null;
                    }

                default:
                    return null;
            }
        }

        internal static string GetLinuxKey(this string name, Win32Class cl)
        {
            switch (name)
            {
                case "Description" when cl == Win32Class.Win32_Processor:
                    return "model name";

                case "Stepping":
                    return "stepping";

                case "Family":
                    return "cpu family";

                case "Vendor":
                    return "vendor_id";

                case "L2CacheSize":
                case "L3CacheSize":
                    return "cache size";

                case "NumberOfCores":
                    return "cpu cores";

                case "Capacity":
                    return "MemTotal";

                default:
                    return null;
            }
        }
    }
}
