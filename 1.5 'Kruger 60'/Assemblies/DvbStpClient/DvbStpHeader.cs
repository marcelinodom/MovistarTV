﻿// Copyright (C) 2014-2016, Codeplex/GitHub user AlphaCentaury
// All rights reserved, except those granted by the governing license of this software. See 'license.txt' file in the project root for complete license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpTviewr.DvbStp.Client
{
    public class DvbStpHeader
    {
        public byte Version;
        public byte Reserved;
        public byte Encription;
        public bool HasCRC;
        public int TotalSegmentSize;
        public byte PayloadId;
        public int SegmentId;
        public byte SegmentIdNetworkLo;
        public byte SegmentIdNetworkHi;
        public byte SegmentVersion;
        public int SectionNumber;
        public int LastSectionNumber;
        public CompressionMethod Compression;
        public bool HasServiceProviderId;
        public byte PrivateHeaderLength;
        public int ServiceProviderId;
        public int PrivateHeaderOffset;
        public int PayloadOffset;
        public int PayloadSize;
        public int CRC;

        public enum CompressionMethod: byte
        {
            None = 0,
            BiM = 1,
            GZip = 2,
            Reserved1 = 3,
            Reserved2 = 4,
            Reserved3 = 5,
            Reserved4 = 6,
            User = 7,
        } // enum CompressionMethod

        public DvbStpHeader Clone()
        {
            return MemberwiseClone() as DvbStpHeader;
        } // Clone

        public override string ToString()
        {
            return string.Format("p{0:X2}s{1:X4}v{2:X2}-{3}", PayloadId, SegmentId, SegmentVersion, SectionNumber);
        } // ToString
    } // class DvbStpHeader
} // namespace
