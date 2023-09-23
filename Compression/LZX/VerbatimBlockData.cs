namespace SabreTools.Models.Compression.LZX
{
    /// <summary>
    /// The fields of a verbatim block that follow the generic block header
    /// </summary>
    /// <see href="https://interoperability.blob.core.windows.net/files/MS-PATCH/%5bMS-PATCH%5d.pdf"/>
    public class VerbatimBlockData : BlockData
    {
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

        /// <summary>
        /// Token sequence (matches and literals)
        /// </summary>
        /// <remarks>Variable</remarks>
#if NET48
        public byte[] TokenSequence { get; set; }
#else
        public byte[]? TokenSequence { get; set; }
#endif
    }
}