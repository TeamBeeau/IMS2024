using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [StandardModule]
    [HideModuleName]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal sealed class MySettingsProperty
    {
        [HelpKeyword("My.Settings")]
        internal static MySettings Settings
        {
            get
            {
                return MySettings.Default;
            }
        }
    }
}
