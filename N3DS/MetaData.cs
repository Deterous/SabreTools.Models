namespace BinaryObjectScanner.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/CIA#Meta"/>
    public sealed class MetaData
    {
        /// <summary>
        /// Title ID dependency list - Taken from the application's ExHeader
        /// </summary>
        /// TODO: Determine numeric format of each entry
        public byte[] TitleIDDependencyList;

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[] Reserved1;

        /// <summary>
        /// Core Version
        /// </summary>
        public uint CoreVersion;

        /// <summary>
        /// Reserved
        /// </summary>
        public byte[] Reserved2;

        /// <summary>
        /// Icon Data(.ICN) - Taken from the application's ExeFS
        /// </summary>
        public byte[] IconData;
    }
}