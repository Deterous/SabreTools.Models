namespace SabreTools.Models.Compression.LZX
{
    /// <summary>
    /// An aligned offset block is identical to the verbatim block except for the presence of the aligned offset
    /// tree preceding the other trees.
    /// </summary>
    /// <see href="https://interoperability.blob.core.windows.net/files/MS-PATCH/%5bMS-PATCH%5d.pdf"/>
    public class AlignedOffsetBlock
    {
        /// <summary>
        /// Generic block header
        /// </summary>
#if NET48
        public BlockHeader Header { get; set; }
#else
        public BlockHeader? Header { get; set; }
#endif

        /// <summary>
        /// Aligned offset tree
        /// </summary>
        /// <remarks>8 elements, 3 bits each</remarks>
#if NET48
        public byte[] AlignedOffsetTree { get; set; }
#else
        public byte[]? AlignedOffsetTree { get; set; }
#endif

        /// <summary>
        /// Pretree for first 256 elements of main tree
        /// </summary>
        /// <remarks>20 elements, 4 bits each</remarks>
#if NET48
        public byte[] PretreeFirst256 { get; set; }
#else
        public byte[]? PretreeFirst256 { get; set; }
#endif

        /// <summary>
        /// Path lengths of first 256 elements of main tree
        /// </summary>
        /// <remarks>Encoded using pretree</remarks>
#if NET48
        public int[] PathLengthsFirst256 { get; set; }
#else
        public int[]? PathLengthsFirst256 { get; set; }
#endif

        /// <summary>
        /// Pretree for remainder of main tree
        /// </summary>
        /// <remarks>20 elements, 4 bits each</remarks>
#if NET48
        public byte[] PretreeRemainder { get; set; }
#else
        public byte[]? PretreeRemainder { get; set; }
#endif

        /// <summary>
        /// Path lengths of remaining elements of main tree
        /// </summary>
        /// <remarks>Encoded using pretree</remarks>
#if NET48
        public int[] PathLengthsRemainder { get; set; }
#else
        public int[]? PathLengthsRemainder { get; set; }
#endif

        /// <summary>
        /// Pretree for length tree
        /// </summary>
        /// <remarks>20 elements, 4 bits each</remarks>
#if NET48
        public byte[] PretreeLengthTree { get; set; }
#else
        public byte[]? PretreeLengthTree { get; set; }
#endif

        /// <summary>
        /// Path lengths of elements in length tree
        /// </summary>
        /// <remarks>Encoded using pretree</remarks>
#if NET48
        public int[] PathLengthsLengthTree { get; set; }
#else
        public int[]? PathLengthsLengthTree { get; set; }
#endif

        // Entry                                    Comments                    Size
        // ---------------------------------------------------------------------------------------
        // Token sequence (matches and literals)    Specified in section 2.6    Variable
    }
}