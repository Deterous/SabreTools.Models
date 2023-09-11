﻿namespace SabreTools.Models.PortableExecutable
{
    /// <summary>
    /// Contains information about each item in a menu resource that does not open a menu
    /// or a submenu. The structure definition provided here is for explanation only; it
    /// is not present in any standard header file.
    /// 
    /// Contains information about the menu items in a menu resource that open a menu
    /// or a submenu. The structure definition provided here is for explanation only;
    /// it is not present in any standard header file.
    /// </summary>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/normalmenuitem"/>
    /// <see href="https://learn.microsoft.com/en-us/windows/win32/menurc/popupmenuitem"/>
    public sealed class MenuItem
    {
        #region NORMALMENUITEM

        /// <summary>
        /// The type of menu item.
        /// </summary>
        public MenuFlags NormalResInfo { get; set; }

        /// <summary>
        /// A null-terminated Unicode string that contains the text for this menu item.
        /// There is no fixed limit on the size of this string.
        /// </summary>
#if NET48
        public string NormalMenuText { get; set; }
#else
        public string? NormalMenuText { get; set; }
#endif

        #endregion

        #region POPUPMENUITEM

        /// <summary>
        /// Describes the menu item.
        /// </summary>
        public MenuFlags PopupItemType { get; set; }

        /// <summary>
        /// Describes the menu item.
        /// </summary>
        public MenuFlags PopupState { get; set; }

        /// <summary>
        /// A numeric expression that identifies the menu item that is passed in the
        /// WM_COMMAND message.
        /// </summary>
        public uint PopupID { get; set; }

        /// <summary>
        /// A set of bit flags that specify the type of menu item.
        /// </summary>
        public MenuFlags PopupResInfo { get; set; }

        /// <summary>
        /// A null-terminated Unicode string that contains the text for this menu item.
        /// There is no fixed limit on the size of this string.
        /// </summary>
#if NET48
        public string PopupMenuText { get; set; }
#else
        public string? PopupMenuText { get; set; }
#endif

        #endregion
    }
}
