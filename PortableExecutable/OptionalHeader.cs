﻿namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Every image file has an optional header that provides information to the loader.
    /// This header is optional in the sense that some files (specifically, object files)
    /// do not have it. For image files, this header is required. An object file can have
    /// an optional header, but generally this header has no function in an object file
    /// except to increase its size.
    /// 
    /// Note that the size of the optional header is not fixed. The SizeOfOptionalHeader
    /// field in the COFF header must be used to validate that a probe into the file for
    /// a particular data directory does not go beyond SizeOfOptionalHeader.
    /// 
    /// The NumberOfRvaAndSizes field of the optional header should also be used to ensure
    /// that no probe for a particular data directory entry goes beyond the optional header.
    /// In addition, it is important to validate the optional header magic number for format
    /// compatibility.
    /// 
    /// The optional header magic number determines whether an image is a PE32 or
    /// PE32+ executable.
    /// 
    /// PE32+ images allow for a 64-bit address space while limiting the image size to
    /// 2 gigabytes. Other PE32+ modifications are addressed in their respective sections.
    /// 
    /// The first eight fields of the optional header are standard fields that are defined
    /// for every implementation of COFF. These fields contain general information that is
    /// useful for loading and running an executable file. They are unchanged for the
    /// PE32+ format.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/debug/pe-format"/>
    public sealed class OptionalHeader
    {
        #region Standard Fields (Image Only)

        /// <summary>
        /// The unsigned integer that identifies the state of the image file. The most
        /// common number is 0x10B, which identifies it as a normal executable file.
        /// 0x107 identifies it as a ROM image, and 0x20B identifies it as a PE32+ executable. 
        /// </summary>
        public OptionalHeaderMagicNumber Magic { get; set; }

        /// <summary>
        /// The linker major version number.
        /// </summary>
        public byte MajorLinkerVersion { get; set; }

        /// <summary>
        /// The linker minor version number.
        /// </summary>
        public byte MinorLinkerVersion { get; set; }

        /// <summary>
        /// The size of the code (text) section, or the sum of all code sections if there
        /// are multiple sections.
        /// </summary>
        public uint SizeOfCode { get; set; }

        /// <summary>
        /// The size of the initialized data section, or the sum of all such sections if
        /// there are multiple data sections.
        /// </summary>
        public uint SizeOfInitializedData { get; set; }

        /// <summary>
        /// The size of the uninitialized data section (BSS), or the sum of all such sections
        /// if there are multiple BSS sections.
        /// </summary>
        public uint SizeOfUninitializedData { get; set; }

        /// <summary>
        /// The address of the entry point relative to the image base when the executable file
        /// is loaded into memory. For program images, this is the starting address. For
        /// device drivers, this is the address of the initialization function. An entry point
        /// is optional for DLLs. When no entry point is present, this field must be zero.
        /// </summary>
        public uint AddressOfEntryPoint { get; set; }

        /// <summary>
        /// The address that is relative to the image base of the beginning-of-code section when
        /// it is loaded into memory. 
        /// </summary>
        public uint BaseOfCode { get; set; }

        #region PE32-Only

        /// <summary>
        /// The address that is relative to the image base of the beginning-of-data section when
        /// it is loaded into memory. 
        /// </summary>
        public uint BaseOfData { get; set; }

        #endregion

        #endregion

        #region Windows-Specific Fields (Image Only)

        #region ImageBase

        /// <summary>
        /// The preferred address of the first byte of image when loaded into memory { get; set; }
        /// must be a multiple of 64 K. The default for DLLs is 0x10000000. The default
        /// for Windows CE EXEs is 0x00010000. The default for Windows NT, Windows 2000,
        /// Windows XP, Windows 95, Windows 98, and Windows Me is 0x00400000.
        /// </summary>
        public uint ImageBase_PE32 { get; set; }

        /// <summary>
        /// The preferred address of the first byte of image when loaded into memory { get; set; }
        /// must be a multiple of 64 K. The default for DLLs is 0x10000000. The default
        /// for Windows CE EXEs is 0x00010000. The default for Windows NT, Windows 2000,
        /// Windows XP, Windows 95, Windows 98, and Windows Me is 0x00400000.
        /// </summary>
        public ulong ImageBase_PE32Plus { get; set; }

        #endregion

        /// <summary>
        /// The alignment (in bytes) of sections when they are loaded into memory. It must
        /// be greater than or equal to FileAlignment. The default is the page size for
        /// the architecture.
        /// </summary>
        public uint SectionAlignment { get; set; }

        /// <summary>
        /// The alignment factor (in bytes) that is used to align the raw data of sections
        /// in the image file. The value should be a power of 2 between 512 and 64 K,
        /// inclusive. The default is 512. If the SectionAlignment is less than the
        /// architecture's page size, then FileAlignment must match SectionAlignment.
        /// </summary>
        public uint FileAlignment { get; set; }

        /// <summary>
        /// The major version number of the required operating system.
        /// </summary>
        public ushort MajorOperatingSystemVersion { get; set; }

        /// <summary>
        /// The minor version number of the required operating system.
        /// </summary>
        public ushort MinorOperatingSystemVersion { get; set; }

        /// <summary>
        /// The major version number of the image.
        /// </summary>
        public ushort MajorImageVersion { get; set; }

        /// <summary>
        /// The minor version number of the image.
        /// </summary>
        public ushort MinorImageVersion { get; set; }

        /// <summary>
        /// The major version number of the subsystem.
        /// </summary>
        public ushort MajorSubsystemVersion { get; set; }

        /// <summary>
        /// The minor version number of the subsystem.
        /// </summary>
        public ushort MinorSubsystemVersion { get; set; }

        /// <summary>
        /// Reserved, must be zero.
        /// </summary>
        public uint Win32VersionValue { get; set; }

        /// <summary>
        /// The size (in bytes) of the image, including all headers, as the image
        /// is loaded in memory. It must be a multiple of SectionAlignment.
        /// </summary>
        public uint SizeOfImage { get; set; }

        /// <summary>
        /// The combined size of an MS-DOS stub, PE header, and section headers rounded
        /// up to a multiple of FileAlignment.
        /// </summary>
        public uint SizeOfHeaders { get; set; }

        /// <summary>
        /// The image file checksum. The algorithm for computing the checksum is
        /// incorporated into IMAGHELP.DLL. The following are checked for validation at
        /// load time: all drivers, any DLL loaded at boot time, and any DLL that is
        /// loaded into a critical Windows process.
        /// </summary>
        public uint CheckSum { get; set; }

        /// <summary>
        /// The subsystem that is required to run this image.
        /// </summary>
        public WindowsSubsystem Subsystem { get; set; }

        /// <summary>
        /// DLL characteristics
        /// </summary>
        public DllCharacteristics DllCharacteristics { get; set; }

        #region SizeOfStackReserve

        /// <summary>
        /// The size of the stack to reserve. Only SizeOfStackCommit is committed; the rest
        /// is made available one page at a time until the reserve size is reached.
        /// </summary>
        public uint SizeOfStackReserve_PE32 { get; set; }

        /// <summary>
        /// The size of the stack to reserve. Only SizeOfStackCommit is committed; the rest
        /// is made available one page at a time until the reserve size is reached.
        /// </summary>
        public ulong SizeOfStackReserve_PE32Plus { get; set; }

        #endregion

        #region SizeOfStackCommit

        /// <summary>
        /// The size of the stack to commit. 
        /// </summary>
        public uint SizeOfStackCommit_PE32 { get; set; }

        /// <summary>
        /// The size of the stack to commit. 
        /// </summary>
        public ulong SizeOfStackCommit_PE32Plus { get; set; }

        #endregion

        #region SizeOfHeapReserve

        /// <summary>
        /// The size of the local heap space to reserve. Only SizeOfHeapCommit is
        /// committed; the rest is made available one page at a time until the reserve
        /// size is reached.
        /// </summary>
        public uint SizeOfHeapReserve_PE32 { get; set; }

        /// <summary>
        /// The size of the local heap space to reserve. Only SizeOfHeapCommit is
        /// committed; the rest is made available one page at a time until the reserve
        /// size is reached.
        /// </summary>
        public ulong SizeOfHeapReserve_PE32Plus { get; set; }

        #endregion

        #region SizeOfHeapCommit

        /// <summary>
        /// The size of the local heap space to commit.
        /// </summary>
        public uint SizeOfHeapCommit_PE32 { get; set; }

        /// <summary>
        /// The size of the local heap space to commit.
        /// </summary>
        public ulong SizeOfHeapCommit_PE32Plus { get; set; }

        #endregion

        /// <summary>
        /// Reserved, must be zero.
        /// </summary>
        public uint LoaderFlags { get; set; }

        /// <summary>
        /// The number of data-directory entries in the remainder of the optional header.
        /// Each describes a location and size.
        /// </summary>
        public uint NumberOfRvaAndSizes { get; set; }

        #endregion

        #region Data Directories (Image Only)

        /// <summary>
        /// The export table address and size.
        /// </summary>
#if NET48
        public DataDirectory ExportTable { get; set; }
#else
        public DataDirectory? ExportTable { get; set; }
#endif

        /// <summary>
        /// The import table address and size.
        /// </summary>
#if NET48
        public DataDirectory ImportTable { get; set; }
#else
        public DataDirectory? ImportTable { get; set; }
#endif

        /// <summary>
        /// The resource table address and size.
        /// </summary>
#if NET48
        public DataDirectory ResourceTable { get; set; }
#else
        public DataDirectory? ResourceTable { get; set; }
#endif

        /// <summary>
        /// The exception table address and size.
        /// </summary>
#if NET48
        public DataDirectory ExceptionTable { get; set; }
#else
        public DataDirectory? ExceptionTable { get; set; }
#endif

        /// <summary>
        /// The attribute certificate table address and size.
        /// </summary>
#if NET48
        public DataDirectory CertificateTable { get; set; }
#else
        public DataDirectory? CertificateTable { get; set; }
#endif

        /// <summary>
        /// The base relocation table address and size.
        /// </summary>
#if NET48
        public DataDirectory BaseRelocationTable { get; set; }
#else
        public DataDirectory? BaseRelocationTable { get; set; }
#endif

        /// <summary>
        /// The debug data starting address and size.
        /// </summary>
#if NET48
        public DataDirectory Debug { get; set; }
#else
        public DataDirectory? Debug { get; set; }
#endif

        /// <summary>
        /// Reserved, must be 0
        /// </summary>
        public ulong Architecture { get; set; }

        /// <summary>
        /// The RVA of the value to be stored in the global pointer register.
        /// The size member of this structure must be set to zero.
        /// </summary>
#if NET48
        public DataDirectory GlobalPtr { get; set; }
#else
        public DataDirectory? GlobalPtr { get; set; }
#endif

        /// <summary>
        /// The thread local storage (TLS) table address and size.
        /// </summary>
#if NET48
        public DataDirectory ThreadLocalStorageTable { get; set; }
#else
        public DataDirectory? ThreadLocalStorageTable { get; set; }
#endif

        /// <summary>
        /// The load configuration table address and size.
        /// </summary>
#if NET48
        public DataDirectory LoadConfigTable { get; set; }
#else
        public DataDirectory? LoadConfigTable { get; set; }
#endif

        /// <summary>
        /// The bound import table address and size.
        /// </summary>
#if NET48
        public DataDirectory BoundImport { get; set; }
#else
        public DataDirectory? BoundImport { get; set; }
#endif

        /// <summary>
        /// The import address table address and size
        /// </summary>
#if NET48
        public DataDirectory ImportAddressTable { get; set; }
#else
        public DataDirectory? ImportAddressTable { get; set; }
#endif

        /// <summary>
        /// The delay import descriptor address and size.
        /// </summary>
#if NET48
        public DataDirectory DelayImportDescriptor { get; set; }
#else
        public DataDirectory? DelayImportDescriptor { get; set; }
#endif

        /// <summary>
        /// The CLR runtime header address and size.
        /// </summary>
#if NET48
        public DataDirectory CLRRuntimeHeader { get; set; }
#else
        public DataDirectory? CLRRuntimeHeader { get; set; }
#endif

        /// <summary>
        /// Reserved, must be zero
        /// </summary>
        public ulong Reserved { get; set; }

        #endregion
    }
}
