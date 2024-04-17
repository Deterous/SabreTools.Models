namespace SabreTools.Models.PKZIP
{
    /// <summary>
    /// Zip64 end of central directory locator
    /// </summary>
    /// <see href="https://pkwaredownloads.blob.core.windows.net/pkware-general/Documentation/APPNOTE-6.3.9.TXT"/> 
    public class EndOfCentralDirectoryLocator64
    {
        /// <summary>
        /// ZIP64 end of central directory locator signature (0x07064B50)
        /// </summary>
        public uint Signature { get; set; }

        /// <summary>
        /// Number of the disk with the start of the end of central directory
        /// </summary>
        public uint StartDiskNumber { get; set; }

        /// <summary>
        /// Relative offset of start of central directory record
        /// </summary>
        public ulong CentralDirectoryOffset { get; set; }

        /// <summary>
        /// Total number of disks
        /// </summary>
        public uint TotalDisks { get; set; }
    }
}