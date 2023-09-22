namespace SabreTools.Models.Compression.MSZIP
{
    /// <summary>
    /// Non-compressed blocks (BTYPE=00)
    /// </summary>
    /// <see href="https://www.rfc-editor.org/rfc/rfc1951"/>
    public class NonCompressedBlockHeader : DataHeader
    {
        /// <summary>
        /// The number of data bytes in the block
        /// </summary>
        /// <remarks>Bytes 0-1</remarks>
        public ushort LEN { get; set; }

        /// <summary>
        /// The one's complement of LEN
        /// </summary>
        /// <remarks>Bytes 2-3</remarks>
        public ushort NLEN { get; set; }
    }
}