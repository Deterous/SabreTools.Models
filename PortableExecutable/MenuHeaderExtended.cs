﻿namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Defines the header for an extended menu template. This structure definition is for
    /// explanation only; it is not present in any standard header file.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/menuex-template-header"/>
    public sealed class MenuHeaderExtended
    {
        /// <summary>
        /// The template version number. This member must be 1 for extended menu templates.
        /// </summary>
        public ushort Version { get; set; }

        /// <summary>
        /// The offset to the first MENUEX_TEMPLATE_ITEM structure, relative to the end of
        /// this structure member. If the first item definition immediately follows the
        /// dwHelpId member, this member should be 4.
        /// </summary>
        public ushort Offset { get; set; }

        /// <summary>
        /// The help identifier of menu bar.
        /// </summary>
        public uint HelpID { get; set; }
    }
}
