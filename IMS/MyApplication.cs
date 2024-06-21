using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace IMS
{
    [GeneratedCode("MyTemplate", "11.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class MyApplication : WindowsFormsApplicationBase
    {
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        [STAThread]
        [DebuggerHidden]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static void Main(string[] Args)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(UseCompatibleTextRendering);
            }
            finally
            {
            }
            MyProject.Application.Run(Args);
        }

        [DebuggerStepThrough]
        public MyApplication()
            : base(AuthenticationMode.Windows)
        {
            IsSingleInstance = true;
            EnableVisualStyles = true;
            SaveMySettingsOnExit = true;
            ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            MainForm = MyProject.Forms.MDIParent;
        }
    }
}
