﻿// Copyright (C) 2015, Codeplex user AlphaCentaury
// All rights reserved, except those granted by the governing license of this software. See 'license.txt' file in the project root for complete license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IpTviewr.UiServices.Discovery;
using IpTviewr.Services.EpgDiscovery;

namespace IpTviewr.Core.IpTvProvider.EPG
{
    public class ProgramEpgInfo
    {
        public UiBroadcastService Service
        {
            get;
            set;
        } // Service

        public EpgProgram Base
        {
            get;
            set;
        } // Base

        public EpgProgramExtended Extended
        {
            get;
            set;
        } // Extended
    } // ProgramEpgInfo
} // namespace
