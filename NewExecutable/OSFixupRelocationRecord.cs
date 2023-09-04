﻿using System.Runtime.InteropServices;

namespace BinaryObjectScanner.Models.NewExecutable
{
    /// <see href="http://bytepointer.com/resources/win16_ne_exe_format_win3.0.htm"/>
    [StructLayout(LayoutKind.Sequential)]
    public sealed class OSFixupRelocationRecord
    {
        /// <summary>
        /// Operating system fixup type.
        /// Floating-point fixups.
        /// </summary>
        public OSFixupType FixupType;

        /// <summary>
        /// 0
        /// </summary>
        public ushort Reserved;
    }
}
