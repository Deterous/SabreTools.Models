namespace SabreTools.Models.BSP
{
    /// <summary>
    /// Half-Life Level
    /// </summary>
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/BSPFile.h"/>
    /// <see href="https://developer.valvesoftware.com/wiki/BSP_(GoldSrc)"/>
    public sealed class File
    {
        /// <summary>
        /// Header data
        /// </summary>
        public Header? Header { get; set; }

        /// <summary>
        /// Lump data
        /// </summary>
        /// <remarks>15 entries</remarks>
        public Lump[]? Lumps { get; set; } = new Lump[Constants.HEADER_LUMPS];
    }
}