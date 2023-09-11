﻿namespace SabreTools.Models.N3DS
{
    /// <summary>
    /// Offset and Length partition table, in media units
    /// </summary>
    /// <see href="https://www.3dbrew.org/wiki/NCSD#NCSD_header"/>
    public sealed class PartitionTableEntry
    {
        /// <summary>
        /// Offset
        /// </summary>
        public uint Offset { get; set; }

        /// <summary>
        /// Length
        /// </summary>
        public uint Length { get; set; }
    }
}
