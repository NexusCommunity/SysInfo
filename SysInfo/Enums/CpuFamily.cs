namespace SysInfo.Enums
{
    public enum CpuFamily
    {
        Other = 1,
        Unknown,

        Intel_8086,
        Intel_80286,
        Intel_80386,
        Intel_80486,
        Intel_8087,
        Intel_80287,
        Intel_80387,
        Intel_80487,

        Intel_Pentium,
        Intel_Pentium_Pro,
        Intel_Pentium_II,
        Intel_Pentium_MMX,
        Intel_Celeron,
        Intel_Pentium_II_Xeon,
        Intel_Pentium_III,

        Apple_M1,
        Apple_M2,

        Intel_Celeron_M,
        Intel_Pentium4_HT,

        AMD_K5 = 24,
        AMD_K6,
        AMD_K6_2,
        AMD_K6_3,
        AMD_Athlon,
        AMD_Duron,
        AMD_29000,
        AMD_K6_2Plus,

        IBM_PowerPC,
        IBM_PowerPC_601,
        IBM_PowerPC_603,
        IBM_PowerPC_603Plus,
        IBM_PowerPC_604,
        IBM_PowerPC_620,
        IBM_PowerPC_X704,
        IBM_PowerPC_750,

        Intel_Core_Duo,
        Intel_Core_Duo_Mobile,
        Intel_Core_Solo_Mobile,
        Intel_Atom,

        DE_Alpha = 48,
        DE_Alpha_21064,
        DE_Alpha_21066,
        DE_Alpha_21164,
        DE_Alpha_21164_PC,
        DE_Alpha_21164a,
        DE_Alpha_21264,
        DE_Alpha_21364,

        AMD_Turion_II_Ultra_MobileM,
        AMD_Turion_II_MobileM,
        AMD_Athlon_II_MobileM,
        AMD_Opteron_6100,
        AMD_Opteron_4100 = 60,

        MIPS = 64,
        MIPS_R4000,
        MIPS_R4200,
        MIPS_R4400,
        MIPS_R4600,
        MIPS_R10000,

        Sun_SPARC = 80,
        Sun_SuperSPARC,
        Sun_microSPARC_II,
        Sun_microSPARC_IIep,
        Sun_UltraSPARC,
        Sun_UltraSPARC_II,
        Sun_UltraSPARC_IIi,
        Sun_UltraSPARC_III,
        Sun_UltraSPARC_IIIi,

        Motorola_68040 = 96,
        Motorola_68xxx,
        Motorola_68000,
        Motorola_68010,
        Motorola_68020,
        Motorola_68030,

        AT_T_Hobbit = 112,

        Transmeta_Crusoe_TM5000 = 120,
        Transmeta_Crusoe_TM3000,
        Transmeta_Efficeon_TM8000,

        Weitek = 128,

        Intel_Itanium = 130,

        AMD_Athlon_64,
        AMD_Opteron,
        AMD_Sempron,
        AMD_Turion_64,
        AMD_Opteron_DualCore,
        AMD_Athlon_64_X2,
        AMD_Turion_64_X2,
        AMD_Opteron_QuadCore,
        AMD_Opteron_3rd_Generation,
        AMD_Phenom_FX,
        AMD_Phenom_X4,
        AMD_Phenom_X2,
        AMD_Athlon_X2,

        HP_PA_RISC,
        HP_PA_RISC_8500,
        HP_PA_RISC_8000,
        HP_PA_RISC_7300LC,
        HP_PA_RISC_7200,
        HP_PA_RISC_7100LC,
        HP_PA_RISC_7100,

        NEC_V30 = 160,

        Intel_Xeon_3200,
        Intel_Xeon_3000,
        Intel_Xeon_5300,
        Intel_Xeon_5100,
        Intel_Xeon_5000,
        Intel_Xeon_LV,
        Intel_Xeon_ULV,
        Intel_Xeon_7100,
        Intel_Xeon_5400,
        Intel_Xeon_QuadCore,
        Intel_Xeon_5200,
        Intel_Xeon_7200,
        Intel_Xeon_7300,
        Intel_Xeon_7400_QuadCore,
        Intel_Xeon_7400_MultiCore,
        Intel_PentiumIII_Xeon,
        Intel_PentiumIII_SpeedStep,
        Intel_Pentium4,
        Intel_Xeon,

        IBM_AS400,

        Intel_Xeon_MP,

        AMD_Athlon_XP,
        AMD_Athlon_MP,

        Intel_Itanium_2,
        Intel_Pentium_M,
        Intel_Celeron_D,
        Intel_Pentium_D,
        Intel_Pentium_Extreme,
        Intel_Core_Solo,

        AMD_K7,

        Intel_Core2_Duo,
        Intel_Core2_Solo,
        Intel_Core2_Extreme,
        Intel_Core2_Quad,
        Intel_Core2_Extreme_Mobile,
        Intel_Core2_Duo_Mobile,
        Intel_Core2_Solo_Mobile,
        Intel_Core_i7,
        Intel_Celeron_DualCore,
        
        IBM_S390,
        IBM_S390_G4,
        IBM_ESA390_G5,
        IBM_ESA390_G6,

        IBM_z,

        Intel_Core_i5,
        Intel_Core_i3,
        Intel_Core_i9,

        VIA_C7_M = 210,
        VIA_C7_D,
        VIA_Eden,

        Intel_Xeon_MultiCore,
        Intel_Xeon_3xxx_DualCore,
        Intel_Xeon_3xxx_QuadCore,

        VIA_Nano,

        Intel_Xeon_5xxx_DualCore,
        Intel_Xeon_5xxx_QuadCore,
        Intel_Xeon_7xxx_DualCore = 221,
        Intel_Xeon_7xxx_QuadCore,
        Intel_Xeon_7xxx_MultiCore,
        Intel_Xeon_3400,

        AMD_Opteron_Embedded = 230,
        AMD_Phenom_X3,
        AMD_Turion_Ultra_Mobile,
        AMD_Turion_Mobile,
        AMD_Athlon_DualCore,
        AMD_Sempron_SI,
        AMD_Phenom_II,
        AMD_Athlon_II,
        AMD_Opteron_SixCore,
        AMD_Sempron_M,

        Intel_i860 = 250,
        Intel_i960,

        Reserved_SMBIOS = 254,
        Reserved_Uninitialized_Flash_Content_Lo,

        Hitachi_SH_3 = 260,
        Hitachi_SH_4,

        ARM = 280,
        StrongARM,

        Cyrix_6x86 = 300,
        Cyrix_MediaGX,
        Cyrix_MII,

        Centaur_WinChip = 320,

        DigitalSignalProcessor = 350,

        VideoProcessor = 500,

        Reserved_Future_Special_Purpose_Assignment = 65534,
        Reserved_Uninitialized_Flash_Content_Hi = 65535
    }
}