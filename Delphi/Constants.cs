/// <remarks>
/// Information sourced from https://stackoverflow.com/questions/18720045/what-are-the-list-of-all-possible-values-for-dvclal
/// </remarks>
namespace SabreTools.Models.Delphi
{
    public static class Constants
    {
        public static readonly byte[] DVCLALStandard = [0x23, 0x78, 0x5D, 0x23, 0xB6, 0xA5, 0xF3, 0x19, 0x43, 0xF3, 0x40, 0x02, 0x26, 0xD1, 0x11, 0xC7];

        public static readonly byte[] DVCLALProfessional = [0xA2, 0x8C, 0xDF, 0x98, 0x7B, 0x3C, 0x3A, 0x79, 0x26, 0x71, 0x3F, 0x09, 0x0F, 0x2A, 0x25, 0x17];

        public static readonly byte[] DVCLALEnterprise = [0x26, 0x3D, 0x4F, 0x38, 0xC2, 0x82, 0x37, 0xB8, 0xF3, 0x24, 0x42, 0x03, 0x17, 0x9B, 0x3A, 0x83];
    }
}