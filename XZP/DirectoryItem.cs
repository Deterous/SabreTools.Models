namespace BinaryObjectScanner.Models.XZP
{
    /// <see href="https://github.com/RavuAlHemio/hllib/blob/master/HLLib/XZPFile.h"/>
    public sealed class DirectoryItem
    {
        public uint FileNameCRC;

        public uint NameOffset;

        public string Name;

        public uint TimeCreated;
    }
}
