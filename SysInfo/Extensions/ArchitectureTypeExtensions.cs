using SysInfo.Enums;

namespace SysInfo.Extensions
{
    public static class ArchitectureTypeExtensions
    {
        public static bool IsARM(this ArchitectureType type)
            => type == ArchitectureType.ARM || type == ArchitectureType.ARM64;

        public static bool Is64Bit(this ArchitectureType type)
            => type == ArchitectureType.ARM64 || type == ArchitectureType.x64bit ||
               type == ArchitectureType.x86bit;

        public static bool Is32Bit(this ArchitectureType type)
            => type == ArchitectureType.x32bit || type == ArchitectureType.x86bit ||
               type == ArchitectureType.ARM;
    }
}
