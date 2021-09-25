using SysInfo.Enums;

namespace SysInfo.Extensions
{
    public static class CpuExtensions
    {
        public static CpuManufacturer GetManufacturer(this string str)
        {
            if (str.Contains("Intel"))
                return CpuManufacturer.Intel;
            else
                return CpuManufacturer.AMD;
        }

        public static CpuManufacturer GetManufacturer(this CpuFamily cpuFamily)
        {
            if (cpuFamily == CpuFamily.Other || cpuFamily == CpuFamily.Unknown ||
                cpuFamily == CpuFamily.Reserved_Future_Special_Purpose_Assignment ||
                cpuFamily == CpuFamily.Reserved_SMBIOS ||
                cpuFamily == CpuFamily.Reserved_Uninitialized_Flash_Content_Hi ||
                cpuFamily == CpuFamily.Reserved_Uninitialized_Flash_Content_Lo ||
                cpuFamily == CpuFamily.DigitalSignalProcessor ||
                cpuFamily == CpuFamily.VideoProcessor)
                return CpuManufacturer.Other;

            string str = cpuFamily.ToString();

            if (str.StartsWith("AMD"))
                return CpuManufacturer.AMD;

            if (str.StartsWith("Intel"))
                return CpuManufacturer.Intel;

            if (str.StartsWith("Apple"))
                return CpuManufacturer.Apple;

            if (str.StartsWith("IBM"))
                return CpuManufacturer.IBM;

            if (str.StartsWith("DE"))
                return CpuManufacturer.Digital_Equipment;

            if (str.StartsWith("MIPS"))
                return CpuManufacturer.MIPS;

            if (str.StartsWith("Sun"))
                return CpuManufacturer.Sun;

            if (str.StartsWith("Motorola"))
                return CpuManufacturer.Motorola;

            if (str.StartsWith("AT_T"))
                return CpuManufacturer.AT_T;

            if (str.StartsWith("Transmeta"))
                return CpuManufacturer.Transmeta;

            if (str.StartsWith("Weitek"))
                return CpuManufacturer.Weitek;

            if (str.StartsWith("HP"))
                return CpuManufacturer.Hewlett_Packard;

            if (str.StartsWith("NEC"))
                return CpuManufacturer.NEC;

            if (str.StartsWith("VIA"))
                return CpuManufacturer.VIA;

            if (str.StartsWith("Hitachi"))
                return CpuManufacturer.Hitachi;

            if (str.Contains("ARM"))
                return CpuManufacturer.ARM;

            if (str.StartsWith("Cyrix"))
                return CpuManufacturer.Cyrix;

            if (str.StartsWith("Centaur"))
                return CpuManufacturer.Centaur;

            return CpuManufacturer.Other;
        }

        public static string GetVendor(this CpuManufacturer manufacturer)
        {
            string str = manufacturer.ToString();

            if (manufacturer == CpuManufacturer.AMD)
                return "Advanced Micro Devices";

            if (manufacturer == CpuManufacturer.AT_T)
                return "AT & T";

            if (manufacturer == CpuManufacturer.IBM)
                return "International Business Machines";

            if (manufacturer == CpuManufacturer.MIPS)
                return "Microprocessor without Interlocked Pipeline Stages";

            if (manufacturer == CpuManufacturer.NEC)
                return "Nippon Electric Corporation";

            if (manufacturer == CpuManufacturer.VIA)
                return "VIA Technologies";

            return str.Replace("_", "");
        }

        public static string GetSeries(this CpuFamily family, CpuManufacturer manufacturer)
        {
            string str = family.ToString();

            if (manufacturer == CpuManufacturer.Other)
                return str;

            str = str.Replace(manufacturer.ToString(), "");

            return str.Replace("_", "");
        }
    }
}
