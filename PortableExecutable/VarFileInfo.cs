﻿namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Represents the organization of data in a file-version resource. It contains version
    /// information not dependent on a particular language and code page combination.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/varfileinfo"/>
    public sealed class VarFileInfo
    {
        /// <summary>
        /// The length, in bytes, of the entire VarFileInfo block, including all structures
        /// indicated by the Children member.
        /// </summary>
        public ushort Length { get; set; }

        /// <summary>
        /// This member is always equal to zero.
        /// </summary>
        public ushort ValueLength { get; set; }

        /// <summary>
        /// The type of data in the version resource.
        /// </summary>
        public VersionResourceType ResourceType { get; set; }

        /// <summary>
        /// The Unicode string L"VarFileInfo".
        /// </summary>
#if NET48
        public string Key { get; set; }
#else
        public string? Key { get; set; }
#endif

        /// <summary>
        /// As many zero words as necessary to align the Children member on a 32-bit boundary.
        /// </summary>
        public ushort Padding { get; set; }

        /// <summary>
        /// Typically contains a list of languages that the application or DLL supports.
        /// </summary>
#if NET48
        public VarData[] Children { get; set; }
#else
        public VarData?[]? Children { get; set; }
#endif
    }
}
