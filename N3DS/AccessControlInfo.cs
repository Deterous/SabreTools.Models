﻿namespace SabreTools.Models.N3DS
{
    /// <see href="https://www.3dbrew.org/wiki/NCCH/Extended_Header#Access_Control_Info"/>
    public sealed class AccessControlInfo
    {
        /// <summary>
        /// ARM11 local system capabilities
        /// </summary>
        public ARM11LocalSystemCapabilities? ARM11LocalSystemCapabilities { get; set; }

        /// <summary>
        /// ARM11 kernel capabilities
        /// </summary>
        public ARM11KernelCapabilities? ARM11KernelCapabilities { get; set; }

        /// <summary>
        /// ARM9 access control
        /// </summary>
        public ARM9AccessControl? ARM9AccessControl { get; set; }
    }
}
