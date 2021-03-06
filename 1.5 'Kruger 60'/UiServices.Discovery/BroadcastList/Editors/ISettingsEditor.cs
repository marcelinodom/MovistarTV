﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IpTviewr.UiServices.Discovery.BroadcastList.Editors
{
    internal interface ISettingsEditor
    {
        void SetContainer(ISettingsEditorContainer container);

        bool IsDataChanged
        {
            get;
        } // IsDataChanged            
    } // internal interface ISettingsEditor
} // namespace
