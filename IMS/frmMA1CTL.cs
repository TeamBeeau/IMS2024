using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;

namespace IMS
{
	[DesignerGenerated]
	public class frmMA1CTL : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDELETE")]
		private Button _btnDELETE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		private OleDbCommand cmd;

		private string strMessage;

		[field: AccessedThroughProperty("dtpFSDT")]
		internal virtual DateTimePicker dtpFSDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblPRJCD")]
		internal virtual Label lblPRJCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblPRJNM")]
		internal virtual Label lblPRJNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCURDT")]
		internal virtual Label lblCURDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblFSDT")]
		internal virtual Label lblFSDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPRJCD")]
		internal virtual TextBox txtPRJCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPRJNM")]
		internal virtual TextBox txtPRJNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpCURDT")]
		internal virtual DateTimePicker dtpCURDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabPage1")]
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabControl1")]
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDOCD")]
		internal virtual TextBox txtDOCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSOCD")]
		internal virtual TextBox txtSOCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblGRNCD")]
		internal virtual Label lblGRNCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblPOCD")]
		internal virtual Label lblPOCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDOCD")]
		internal virtual Label lblDOCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSOCD")]
		internal virtual Label lblSOCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTKCD")]
		internal virtual Label lblSTKCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblGRLCD")]
		internal virtual Label lblGRLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblIGNCD")]
		internal virtual Label lblIGNCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSIVCD")]
		internal virtual TextBox txtSIVCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtGRNCD")]
		internal virtual TextBox txtGRNCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPOLCD")]
		internal virtual TextBox txtPOLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDOLCD")]
		internal virtual TextBox txtDOLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSOLCD")]
		internal virtual TextBox txtSOLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSIVCD")]
		internal virtual Label lblSIVCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblPOLCD")]
		internal virtual Label lblPOLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDOLCD")]
		internal virtual Label lblDOLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSOLCD")]
		internal virtual Label lblSOLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblWHSCD")]
		internal virtual Label lblWHSCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPOCD")]
		internal virtual TextBox txtPOCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtIGNCD")]
		internal virtual TextBox txtIGNCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtGRLCD")]
		internal virtual TextBox txtGRLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSTKCD")]
		internal virtual TextBox txtSTKCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtWHSCD")]
		internal virtual TextBox txtWHSCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLINE1")]
		internal virtual Label lblLINE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtWGTDS")]
		internal virtual TextBox txtWGTDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtAMTDS")]
		internal virtual TextBox txtAMTDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblWGTDS")]
		internal virtual Label lblWGTDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblAMTDS")]
		internal virtual Label lblAMTDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPRCDS")]
		internal virtual TextBox txtPRCDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDTFMT")]
		internal virtual TextBox txtDTFMT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblPRCDS")]
		internal virtual Label lblPRCDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDTFMT")]
		internal virtual Label lblDTFMT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblXRTDS")]
		internal virtual Label lblXRTDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblQTYDS")]
		internal virtual Label lblQTYDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtXRTDS")]
		internal virtual TextBox txtXRTDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtQTYDS")]
		internal virtual TextBox txtQTYDS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLINE2")]
		internal virtual Label lblLINE2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTAX2")]
		internal virtual Label lblTAX2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTAX")]
		internal virtual Label lblTAX
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTAXRATE")]
		internal virtual Label lblTAXRATE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblGST")]
		internal virtual Label lblGST
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTAXDESC")]
		internal virtual Label lblTAXDESC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTAX1")]
		internal virtual Label lblTAX1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTAXRATE2")]
		internal virtual TextBox txtTAXRATE2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTAXRATE1")]
		internal virtual TextBox txtTAXRATE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTAXDESC2")]
		internal virtual TextBox txtTAXDESC2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTAXDESC1")]
		internal virtual TextBox txtTAXDESC1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkTAX1")]
		internal virtual CheckBox chkTAX1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkTAX2")]
		internal virtual CheckBox chkTAX2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtGSTDESC")]
		internal virtual TextBox txtGSTDESC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtGSTRT")]
		internal virtual TextBox txtGSTRT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkGSTINC")]
		internal virtual CheckBox chkGSTINC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpGSTST")]
		internal virtual DateTimePicker dtpGSTST
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblGSTST")]
		internal virtual Label lblGSTST
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLINE3")]
		internal virtual Label lblLINE3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtLANGUAGE")]
		internal virtual TextBox txtLANGUAGE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkAUITM")]
		internal virtual CheckBox chkAUITM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSYSLK")]
		internal virtual Label lblSYSLK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLANGUAGE")]
		internal virtual Label lblLANGUAGE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkNEGSTK")]
		internal virtual CheckBox chkNEGSTK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkEODFG")]
		internal virtual CheckBox chkEODFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSYSDT")]
		internal virtual Label lblSYSDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpSYSLK")]
		internal virtual DateTimePicker dtpSYSLK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpSYSDT")]
		internal virtual DateTimePicker dtpSYSDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnCancel
		{
			[CompilerGenerated]
			get
			{
				return _btnCancel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCancel_Click;
				Button button = _btnCancel;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCancel = value;
				button = _btnCancel;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel7")]
		internal virtual TableLayoutPanel TableLayoutPanel7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSave
		{
			[CompilerGenerated]
			get
			{
				return _btnSave;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSave_Click;
				Button button = _btnSave;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSave = value;
				button = _btnSave;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnDELETE
		{
			[CompilerGenerated]
			get
			{
				return _btnDELETE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDELETE_Click;
				Button button = _btnDELETE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDELETE = value;
				button = _btnDELETE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnClose
		{
			[CompilerGenerated]
			get
			{
				return _btnClose;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdClose_Click;
				Button button = _btnClose;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnClose = value;
				button = _btnClose;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel8")]
		internal virtual TableLayoutPanel TableLayoutPanel8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoVIWBYSV")]
		internal virtual RadioButton rdoVIWBYSV
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoVIWBYALL")]
		internal virtual RadioButton rdoVIWBYALL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel9")]
		internal virtual TableLayoutPanel TableLayoutPanel9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoEDTBYSV")]
		internal virtual RadioButton rdoEDTBYSV
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoEDTBYALL")]
		internal virtual RadioButton rdoEDTBYALL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtJobFolder")]
		internal virtual TextBox txtJobFolder
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMA1CTL()
		{
			base.FormClosing += frmMA1CTL_FormClosing;
			base.Shown += frmMCTL_Shown;
			cmd = new OleDbCommand();
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMS.frmMA1CTL));
			this.dtpFSDT = new System.Windows.Forms.DateTimePicker();
			this.lblPRJCD = new System.Windows.Forms.Label();
			this.lblPRJNM = new System.Windows.Forms.Label();
			this.lblCURDT = new System.Windows.Forms.Label();
			this.lblFSDT = new System.Windows.Forms.Label();
			this.txtPRJCD = new System.Windows.Forms.TextBox();
			this.txtPRJNM = new System.Windows.Forms.TextBox();
			this.dtpCURDT = new System.Windows.Forms.DateTimePicker();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDELETE = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.rdoVIWBYSV = new System.Windows.Forms.RadioButton();
			this.rdoVIWBYALL = new System.Windows.Forms.RadioButton();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblSYSDT = new System.Windows.Forms.Label();
			this.dtpSYSLK = new System.Windows.Forms.DateTimePicker();
			this.txtLANGUAGE = new System.Windows.Forms.TextBox();
			this.lblSYSLK = new System.Windows.Forms.Label();
			this.lblLANGUAGE = new System.Windows.Forms.Label();
			this.chkAUITM = new System.Windows.Forms.CheckBox();
			this.chkNEGSTK = new System.Windows.Forms.CheckBox();
			this.chkEODFG = new System.Windows.Forms.CheckBox();
			this.dtpSYSDT = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.TableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.rdoEDTBYSV = new System.Windows.Forms.RadioButton();
			this.rdoEDTBYALL = new System.Windows.Forms.RadioButton();
			this.lblLINE3 = new System.Windows.Forms.Label();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.dtpGSTST = new System.Windows.Forms.DateTimePicker();
			this.txtTAXRATE2 = new System.Windows.Forms.TextBox();
			this.txtTAXRATE1 = new System.Windows.Forms.TextBox();
			this.txtTAXDESC2 = new System.Windows.Forms.TextBox();
			this.txtTAXDESC1 = new System.Windows.Forms.TextBox();
			this.chkTAX1 = new System.Windows.Forms.CheckBox();
			this.lblGST = new System.Windows.Forms.Label();
			this.lblTAXDESC = new System.Windows.Forms.Label();
			this.lblTAX = new System.Windows.Forms.Label();
			this.lblTAXRATE = new System.Windows.Forms.Label();
			this.lblTAX1 = new System.Windows.Forms.Label();
			this.lblTAX2 = new System.Windows.Forms.Label();
			this.chkTAX2 = new System.Windows.Forms.CheckBox();
			this.txtGSTDESC = new System.Windows.Forms.TextBox();
			this.txtGSTRT = new System.Windows.Forms.TextBox();
			this.lblGSTST = new System.Windows.Forms.Label();
			this.chkGSTINC = new System.Windows.Forms.CheckBox();
			this.lblLINE2 = new System.Windows.Forms.Label();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.txtXRTDS = new System.Windows.Forms.TextBox();
			this.txtQTYDS = new System.Windows.Forms.TextBox();
			this.lblXRTDS = new System.Windows.Forms.Label();
			this.txtWGTDS = new System.Windows.Forms.TextBox();
			this.txtAMTDS = new System.Windows.Forms.TextBox();
			this.lblWGTDS = new System.Windows.Forms.Label();
			this.lblAMTDS = new System.Windows.Forms.Label();
			this.txtPRCDS = new System.Windows.Forms.TextBox();
			this.txtDTFMT = new System.Windows.Forms.TextBox();
			this.lblPRCDS = new System.Windows.Forms.Label();
			this.lblDTFMT = new System.Windows.Forms.Label();
			this.lblQTYDS = new System.Windows.Forms.Label();
			this.lblLINE1 = new System.Windows.Forms.Label();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtGRNCD = new System.Windows.Forms.TextBox();
			this.txtPOLCD = new System.Windows.Forms.TextBox();
			this.txtDOLCD = new System.Windows.Forms.TextBox();
			this.txtSOLCD = new System.Windows.Forms.TextBox();
			this.lblPOLCD = new System.Windows.Forms.Label();
			this.lblDOLCD = new System.Windows.Forms.Label();
			this.lblSOLCD = new System.Windows.Forms.Label();
			this.txtDOCD = new System.Windows.Forms.TextBox();
			this.lblIGNCD = new System.Windows.Forms.Label();
			this.txtSOCD = new System.Windows.Forms.TextBox();
			this.lblPOCD = new System.Windows.Forms.Label();
			this.lblDOCD = new System.Windows.Forms.Label();
			this.lblSOCD = new System.Windows.Forms.Label();
			this.lblGRNCD = new System.Windows.Forms.Label();
			this.txtPOCD = new System.Windows.Forms.TextBox();
			this.txtIGNCD = new System.Windows.Forms.TextBox();
			this.txtGRLCD = new System.Windows.Forms.TextBox();
			this.lblGRLCD = new System.Windows.Forms.Label();
			this.lblSIVCD = new System.Windows.Forms.Label();
			this.txtSIVCD = new System.Windows.Forms.TextBox();
			this.lblSTKCD = new System.Windows.Forms.Label();
			this.txtSTKCD = new System.Windows.Forms.TextBox();
			this.lblWHSCD = new System.Windows.Forms.Label();
			this.txtWHSCD = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtJobFolder = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TableLayoutPanel7.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.TableLayoutPanel8.SuspendLayout();
			this.TableLayoutPanel9.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.dtpFSDT.CustomFormat = "MMM/yyyy";
			this.dtpFSDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFSDT.Location = new System.Drawing.Point(584, 28);
			this.dtpFSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFSDT.Name = "dtpFSDT";
			this.dtpFSDT.Size = new System.Drawing.Size(103, 22);
			this.dtpFSDT.TabIndex = 4;
			this.lblPRJCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPRJCD.AutoSize = true;
			this.lblPRJCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPRJCD.Location = new System.Drawing.Point(3, 5);
			this.lblPRJCD.Name = "lblPRJCD";
			this.lblPRJCD.Size = new System.Drawing.Size(86, 16);
			this.lblPRJCD.TabIndex = 1;
			this.lblPRJCD.Text = "Project Code";
			this.lblPRJNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPRJNM.AutoSize = true;
			this.lblPRJNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPRJNM.Location = new System.Drawing.Point(420, 5);
			this.lblPRJNM.Name = "lblPRJNM";
			this.lblPRJNM.Size = new System.Drawing.Size(90, 16);
			this.lblPRJNM.TabIndex = 2;
			this.lblPRJNM.Text = "Project Name";
			this.lblCURDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCURDT.AutoSize = true;
			this.lblCURDT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCURDT.Location = new System.Drawing.Point(3, 31);
			this.lblCURDT.Name = "lblCURDT";
			this.lblCURDT.Size = new System.Drawing.Size(164, 16);
			this.lblCURDT.TabIndex = 2;
			this.lblCURDT.Text = "Current Processing Period";
			this.lblFSDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFSDT.AutoSize = true;
			this.lblFSDT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFSDT.Location = new System.Drawing.Point(420, 31);
			this.lblFSDT.Name = "lblFSDT";
			this.lblFSDT.Size = new System.Drawing.Size(158, 16);
			this.lblFSDT.TabIndex = 2;
			this.lblFSDT.Text = "Fiscal Processing Period";
			this.txtPRJCD.Location = new System.Drawing.Point(173, 2);
			this.txtPRJCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPRJCD.Name = "txtPRJCD";
			this.txtPRJCD.Size = new System.Drawing.Size(200, 22);
			this.txtPRJCD.TabIndex = 1;
			this.txtPRJNM.Location = new System.Drawing.Point(584, 2);
			this.txtPRJNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPRJNM.Name = "txtPRJNM";
			this.txtPRJNM.Size = new System.Drawing.Size(389, 22);
			this.txtPRJNM.TabIndex = 2;
			this.dtpCURDT.CustomFormat = "MMM/yyyy";
			this.dtpCURDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCURDT.Location = new System.Drawing.Point(173, 28);
			this.dtpCURDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpCURDT.Name = "dtpCURDT";
			this.dtpCURDT.Size = new System.Drawing.Size(103, 22);
			this.dtpCURDT.TabIndex = 3;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 5;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.dtpCURDT, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtPRJNM, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.TabControl1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtPRJCD, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblFSDT, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblCURDT, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblPRJCD, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpFSDT, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblPRJNM, 3, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 4;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(976, 619);
			this.TableLayoutPanel1.TabIndex = 0;
			this.TableLayoutPanel1.SetColumnSpan(this.TabControl1, 5);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Location = new System.Drawing.Point(3, 64);
			this.TabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(970, 553);
			this.TabControl1.TabIndex = 1;
			this.TabPage1.BackColor = System.Drawing.Color.White;
			this.TabPage1.Controls.Add(this.TableLayoutPanel7);
			this.TabPage1.Controls.Add(this.TableLayoutPanel6);
			this.TabPage1.Controls.Add(this.TableLayoutPanel5);
			this.TabPage1.Controls.Add(this.lblLINE3);
			this.TabPage1.Controls.Add(this.TableLayoutPanel4);
			this.TabPage1.Controls.Add(this.lblLINE2);
			this.TabPage1.Controls.Add(this.TableLayoutPanel3);
			this.TabPage1.Controls.Add(this.lblLINE1);
			this.TabPage1.Controls.Add(this.TableLayoutPanel2);
			this.TabPage1.Location = new System.Drawing.Point(4, 25);
			this.TabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TabPage1.Size = new System.Drawing.Size(962, 524);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Systems";
			this.TableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel7.AutoSize = true;
			this.TableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel7.ColumnCount = 4;
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel7.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel7.Controls.Add(this.btnDELETE, 1, 0);
			this.TableLayoutPanel7.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel7.Location = new System.Drawing.Point(5, 462);
			this.TableLayoutPanel7.Name = "TableLayoutPanel7";
			this.TableLayoutPanel7.RowCount = 1;
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.Size = new System.Drawing.Size(510, 54);
			this.TableLayoutPanel7.TabIndex = 42;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(386, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 45;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(4, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 50);
			this.btnSave.TabIndex = 42;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnDELETE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDELETE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDELETE.Image = IMS.My.Resources.Resources.Delete;
			this.btnDELETE.Location = new System.Drawing.Point(132, 2);
			this.btnDELETE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnDELETE.Name = "btnDELETE";
			this.btnDELETE.Size = new System.Drawing.Size(120, 50);
			this.btnDELETE.TabIndex = 43;
			this.btnDELETE.TabStop = false;
			this.btnDELETE.Text = "Delete";
			this.btnDELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDELETE.UseVisualStyleBackColor = false;
			this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(259, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 44;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.TableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25f));
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25f));
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25f));
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25f));
			this.TableLayoutPanel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(-294, 515);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(0, 0);
			this.TableLayoutPanel6.TabIndex = 2;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 4;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.txtJobFolder, 3, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label3, 2, 2);
			this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel8, 1, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label1, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.lblSYSDT, 2, 1);
			this.TableLayoutPanel5.Controls.Add(this.dtpSYSLK, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.txtLANGUAGE, 1, 2);
			this.TableLayoutPanel5.Controls.Add(this.lblSYSLK, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.lblLANGUAGE, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.chkAUITM, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.chkNEGSTK, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.chkEODFG, 3, 0);
			this.TableLayoutPanel5.Controls.Add(this.dtpSYSDT, 3, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label2, 2, 3);
			this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel9, 3, 3);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(5, 316);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 4;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(881, 137);
			this.TableLayoutPanel5.TabIndex = 20;
			this.TableLayoutPanel8.AutoSize = true;
			this.TableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.TableLayoutPanel8.ColumnCount = 1;
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel8.Controls.Add(this.rdoVIWBYSV, 0, 0);
			this.TableLayoutPanel8.Controls.Add(this.rdoVIWBYALL, 0, 1);
			this.TableLayoutPanel8.Location = new System.Drawing.Point(134, 79);
			this.TableLayoutPanel8.Name = "TableLayoutPanel8";
			this.TableLayoutPanel8.RowCount = 2;
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.Size = new System.Drawing.Size(202, 55);
			this.TableLayoutPanel8.TabIndex = 40;
			this.rdoVIWBYSV.AutoSize = true;
			this.rdoVIWBYSV.Location = new System.Drawing.Point(4, 4);
			this.rdoVIWBYSV.Name = "rdoVIWBYSV";
			this.rdoVIWBYSV.Size = new System.Drawing.Size(194, 20);
			this.rdoVIWBYSV.TabIndex = 0;
			this.rdoVIWBYSV.Text = "Creator and Supervisor Only";
			this.rdoVIWBYSV.UseVisualStyleBackColor = true;
			this.rdoVIWBYALL.AutoSize = true;
			this.rdoVIWBYALL.Checked = true;
			this.rdoVIWBYALL.Location = new System.Drawing.Point(4, 31);
			this.rdoVIWBYALL.Name = "rdoVIWBYALL";
			this.rdoVIWBYALL.Size = new System.Drawing.Size(41, 20);
			this.rdoVIWBYALL.TabIndex = 1;
			this.rdoVIWBYALL.TabStop = true;
			this.rdoVIWBYALL.Text = "All";
			this.rdoVIWBYALL.UseVisualStyleBackColor = true;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 98);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(125, 16);
			this.Label1.TabIndex = 43;
			this.Label1.Text = "Document Read By";
			this.lblSYSDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSYSDT.AutoSize = true;
			this.lblSYSDT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSYSDT.Location = new System.Drawing.Point(435, 29);
			this.lblSYSDT.Name = "lblSYSDT";
			this.lblSYSDT.Size = new System.Drawing.Size(85, 16);
			this.lblSYSDT.TabIndex = 21;
			this.lblSYSDT.Text = "System Date";
			this.dtpSYSLK.CustomFormat = "dd MMM yyyy";
			this.dtpSYSLK.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSYSLK.Location = new System.Drawing.Point(134, 26);
			this.dtpSYSLK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpSYSLK.Name = "dtpSYSLK";
			this.dtpSYSLK.Size = new System.Drawing.Size(117, 22);
			this.dtpSYSLK.TabIndex = 36;
			this.txtLANGUAGE.Location = new System.Drawing.Point(134, 52);
			this.txtLANGUAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLANGUAGE.Name = "txtLANGUAGE";
			this.txtLANGUAGE.Size = new System.Drawing.Size(295, 22);
			this.txtLANGUAGE.TabIndex = 38;
			this.lblSYSLK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSYSLK.AutoSize = true;
			this.lblSYSLK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSYSLK.Location = new System.Drawing.Point(3, 29);
			this.lblSYSLK.Name = "lblSYSLK";
			this.lblSYSLK.Size = new System.Drawing.Size(117, 16);
			this.lblSYSLK.TabIndex = 20;
			this.lblSYSLK.Text = "System Lock Date";
			this.lblLANGUAGE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLANGUAGE.AutoSize = true;
			this.lblLANGUAGE.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLANGUAGE.Location = new System.Drawing.Point(3, 55);
			this.lblLANGUAGE.Name = "lblLANGUAGE";
			this.lblLANGUAGE.Size = new System.Drawing.Size(117, 16);
			this.lblLANGUAGE.TabIndex = 2;
			this.lblLANGUAGE.Text = "System Language";
			this.chkAUITM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkAUITM.AutoSize = true;
			this.chkAUITM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAUITM.Location = new System.Drawing.Point(134, 2);
			this.chkAUITM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkAUITM.Name = "chkAUITM";
			this.chkAUITM.Size = new System.Drawing.Size(174, 20);
			this.chkAUITM.TabIndex = 33;
			this.chkAUITM.Text = "Allow Create Item Master";
			this.chkAUITM.UseVisualStyleBackColor = true;
			this.chkNEGSTK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkNEGSTK.AutoSize = true;
			this.chkNEGSTK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkNEGSTK.Location = new System.Drawing.Point(435, 2);
			this.chkNEGSTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkNEGSTK.Name = "chkNEGSTK";
			this.chkNEGSTK.Size = new System.Drawing.Size(154, 20);
			this.chkNEGSTK.TabIndex = 34;
			this.chkNEGSTK.Text = "Allow Negative Stock";
			this.chkNEGSTK.UseVisualStyleBackColor = true;
			this.chkEODFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkEODFG.AutoSize = true;
			this.chkEODFG.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkEODFG.Location = new System.Drawing.Point(595, 2);
			this.chkEODFG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkEODFG.Name = "chkEODFG";
			this.chkEODFG.Size = new System.Drawing.Size(110, 20);
			this.chkEODFG.TabIndex = 35;
			this.chkEODFG.Text = "EOD Interface";
			this.chkEODFG.UseVisualStyleBackColor = true;
			this.dtpSYSDT.CustomFormat = "dd MMM yyyy";
			this.dtpSYSDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSYSDT.Location = new System.Drawing.Point(595, 26);
			this.dtpSYSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpSYSDT.Name = "dtpSYSDT";
			this.dtpSYSDT.Size = new System.Drawing.Size(117, 22);
			this.dtpSYSDT.TabIndex = 37;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(435, 98);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(130, 16);
			this.Label2.TabIndex = 44;
			this.Label2.Text = "Document Edited By";
			this.TableLayoutPanel9.AutoSize = true;
			this.TableLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel9.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.TableLayoutPanel9.ColumnCount = 1;
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel9.Controls.Add(this.rdoEDTBYSV, 0, 0);
			this.TableLayoutPanel9.Controls.Add(this.rdoEDTBYALL, 0, 1);
			this.TableLayoutPanel9.Location = new System.Drawing.Point(595, 79);
			this.TableLayoutPanel9.Name = "TableLayoutPanel9";
			this.TableLayoutPanel9.RowCount = 2;
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.Size = new System.Drawing.Size(202, 55);
			this.TableLayoutPanel9.TabIndex = 41;
			this.rdoEDTBYSV.AutoSize = true;
			this.rdoEDTBYSV.Location = new System.Drawing.Point(4, 4);
			this.rdoEDTBYSV.Name = "rdoEDTBYSV";
			this.rdoEDTBYSV.Size = new System.Drawing.Size(194, 20);
			this.rdoEDTBYSV.TabIndex = 0;
			this.rdoEDTBYSV.Text = "Creator and Supervisor Only";
			this.rdoEDTBYSV.UseVisualStyleBackColor = true;
			this.rdoEDTBYALL.AutoSize = true;
			this.rdoEDTBYALL.Checked = true;
			this.rdoEDTBYALL.Location = new System.Drawing.Point(4, 31);
			this.rdoEDTBYALL.Name = "rdoEDTBYALL";
			this.rdoEDTBYALL.Size = new System.Drawing.Size(41, 20);
			this.rdoEDTBYALL.TabIndex = 1;
			this.rdoEDTBYALL.TabStop = true;
			this.rdoEDTBYALL.Text = "All";
			this.rdoEDTBYALL.UseVisualStyleBackColor = true;
			this.lblLINE3.AutoSize = true;
			this.lblLINE3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLINE3.ForeColor = System.Drawing.Color.Red;
			this.lblLINE3.Location = new System.Drawing.Point(4, 303);
			this.lblLINE3.Name = "lblLINE3";
			this.lblLINE3.Size = new System.Drawing.Size(903, 13);
			this.lblLINE3.TabIndex = 19;
			this.lblLINE3.Text = resources.GetString("lblLINE3.Text");
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 9;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29f));
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29f));
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.dtpGSTST, 7, 3);
			this.TableLayoutPanel4.Controls.Add(this.txtTAXRATE2, 4, 2);
			this.TableLayoutPanel4.Controls.Add(this.txtTAXRATE1, 4, 1);
			this.TableLayoutPanel4.Controls.Add(this.txtTAXDESC2, 2, 2);
			this.TableLayoutPanel4.Controls.Add(this.txtTAXDESC1, 2, 1);
			this.TableLayoutPanel4.Controls.Add(this.chkTAX1, 1, 1);
			this.TableLayoutPanel4.Controls.Add(this.lblGST, 0, 3);
			this.TableLayoutPanel4.Controls.Add(this.lblTAXDESC, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.lblTAX, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.lblTAXRATE, 4, 0);
			this.TableLayoutPanel4.Controls.Add(this.lblTAX1, 0, 1);
			this.TableLayoutPanel4.Controls.Add(this.lblTAX2, 0, 2);
			this.TableLayoutPanel4.Controls.Add(this.chkTAX2, 1, 2);
			this.TableLayoutPanel4.Controls.Add(this.txtGSTDESC, 2, 3);
			this.TableLayoutPanel4.Controls.Add(this.txtGSTRT, 4, 3);
			this.TableLayoutPanel4.Controls.Add(this.lblGSTST, 6, 3);
			this.TableLayoutPanel4.Controls.Add(this.chkGSTINC, 8, 3);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 203);
			this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 4;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(881, 94);
			this.TableLayoutPanel4.TabIndex = 18;
			this.dtpGSTST.CustomFormat = "dd MMM yyyy";
			this.dtpGSTST.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpGSTST.Location = new System.Drawing.Point(676, 70);
			this.dtpGSTST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpGSTST.Name = "dtpGSTST";
			this.dtpGSTST.Size = new System.Drawing.Size(117, 22);
			this.dtpGSTST.TabIndex = 31;
			this.txtTAXRATE2.Location = new System.Drawing.Point(434, 44);
			this.txtTAXRATE2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTAXRATE2.Name = "txtTAXRATE2";
			this.txtTAXRATE2.Size = new System.Drawing.Size(103, 22);
			this.txtTAXRATE2.TabIndex = 28;
			this.txtTAXRATE1.Location = new System.Drawing.Point(434, 18);
			this.txtTAXRATE1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTAXRATE1.Name = "txtTAXRATE1";
			this.txtTAXRATE1.Size = new System.Drawing.Size(103, 22);
			this.txtTAXRATE1.TabIndex = 25;
			this.txtTAXDESC2.Location = new System.Drawing.Point(71, 44);
			this.txtTAXDESC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTAXDESC2.Name = "txtTAXDESC2";
			this.txtTAXDESC2.Size = new System.Drawing.Size(328, 22);
			this.txtTAXDESC2.TabIndex = 27;
			this.txtTAXDESC1.Location = new System.Drawing.Point(71, 18);
			this.txtTAXDESC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTAXDESC1.Name = "txtTAXDESC1";
			this.txtTAXDESC1.Size = new System.Drawing.Size(328, 22);
			this.txtTAXDESC1.TabIndex = 24;
			this.chkTAX1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkTAX1.AutoSize = true;
			this.chkTAX1.Location = new System.Drawing.Point(50, 22);
			this.chkTAX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkTAX1.Name = "chkTAX1";
			this.chkTAX1.Size = new System.Drawing.Size(15, 14);
			this.chkTAX1.TabIndex = 23;
			this.chkTAX1.UseVisualStyleBackColor = true;
			this.lblGST.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblGST.AutoSize = true;
			this.lblGST.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblGST.Location = new System.Drawing.Point(3, 73);
			this.lblGST.Name = "lblGST";
			this.lblGST.Size = new System.Drawing.Size(36, 16);
			this.lblGST.TabIndex = 19;
			this.lblGST.Text = "GST";
			this.lblTAXDESC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTAXDESC.AutoSize = true;
			this.lblTAXDESC.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTAXDESC.Location = new System.Drawing.Point(71, 0);
			this.lblTAXDESC.Name = "lblTAXDESC";
			this.lblTAXDESC.Size = new System.Drawing.Size(102, 16);
			this.lblTAXDESC.TabIndex = 19;
			this.lblTAXDESC.Text = "Tax Description";
			this.lblTAX.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTAX.AutoSize = true;
			this.lblTAX.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTAX.Location = new System.Drawing.Point(3, 0);
			this.lblTAX.Name = "lblTAX";
			this.lblTAX.Size = new System.Drawing.Size(41, 16);
			this.lblTAX.TabIndex = 1;
			this.lblTAX.Text = "Tax #";
			this.lblTAXRATE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTAXRATE.AutoSize = true;
			this.lblTAXRATE.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTAXRATE.Location = new System.Drawing.Point(434, 0);
			this.lblTAXRATE.Name = "lblTAXRATE";
			this.lblTAXRATE.Size = new System.Drawing.Size(46, 16);
			this.lblTAXRATE.TabIndex = 18;
			this.lblTAXRATE.Text = "Tax %";
			this.lblTAX1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTAX1.AutoSize = true;
			this.lblTAX1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTAX1.Location = new System.Drawing.Point(3, 21);
			this.lblTAX1.Name = "lblTAX1";
			this.lblTAX1.Size = new System.Drawing.Size(41, 16);
			this.lblTAX1.TabIndex = 20;
			this.lblTAX1.Text = "Tax 1";
			this.lblTAX2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTAX2.AutoSize = true;
			this.lblTAX2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTAX2.Location = new System.Drawing.Point(3, 47);
			this.lblTAX2.Name = "lblTAX2";
			this.lblTAX2.Size = new System.Drawing.Size(41, 16);
			this.lblTAX2.TabIndex = 2;
			this.lblTAX2.Text = "Tax 2";
			this.chkTAX2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkTAX2.AutoSize = true;
			this.chkTAX2.Location = new System.Drawing.Point(50, 48);
			this.chkTAX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkTAX2.Name = "chkTAX2";
			this.chkTAX2.Size = new System.Drawing.Size(15, 14);
			this.chkTAX2.TabIndex = 26;
			this.chkTAX2.UseVisualStyleBackColor = true;
			this.txtGSTDESC.Location = new System.Drawing.Point(71, 70);
			this.txtGSTDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGSTDESC.Name = "txtGSTDESC";
			this.txtGSTDESC.Size = new System.Drawing.Size(328, 22);
			this.txtGSTDESC.TabIndex = 29;
			this.txtGSTRT.Location = new System.Drawing.Point(434, 70);
			this.txtGSTRT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGSTRT.Name = "txtGSTRT";
			this.txtGSTRT.Size = new System.Drawing.Size(103, 22);
			this.txtGSTRT.TabIndex = 30;
			this.lblGSTST.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblGSTST.AutoSize = true;
			this.lblGSTST.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblGSTST.Location = new System.Drawing.Point(572, 73);
			this.lblGSTST.Name = "lblGSTST";
			this.lblGSTST.Size = new System.Drawing.Size(98, 16);
			this.lblGSTST.TabIndex = 20;
			this.lblGSTST.Text = "GST Start Date";
			this.chkGSTINC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkGSTINC.AutoSize = true;
			this.chkGSTINC.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkGSTINC.Location = new System.Drawing.Point(799, 71);
			this.chkGSTINC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkGSTINC.Name = "chkGSTINC";
			this.chkGSTINC.Size = new System.Drawing.Size(79, 20);
			this.chkGSTINC.TabIndex = 32;
			this.chkGSTINC.Text = "Inclusive";
			this.chkGSTINC.UseVisualStyleBackColor = true;
			this.lblLINE2.AutoSize = true;
			this.lblLINE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLINE2.ForeColor = System.Drawing.Color.Red;
			this.lblLINE2.Location = new System.Drawing.Point(4, 190);
			this.lblLINE2.Name = "lblLINE2";
			this.lblLINE2.Size = new System.Drawing.Size(903, 13);
			this.lblLINE2.TabIndex = 17;
			this.lblLINE2.Text = resources.GetString("lblLINE2.Text");
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 8;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.txtXRTDS, 7, 1);
			this.TableLayoutPanel3.Controls.Add(this.txtQTYDS, 7, 0);
			this.TableLayoutPanel3.Controls.Add(this.lblXRTDS, 6, 1);
			this.TableLayoutPanel3.Controls.Add(this.txtWGTDS, 4, 1);
			this.TableLayoutPanel3.Controls.Add(this.txtAMTDS, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.lblWGTDS, 3, 1);
			this.TableLayoutPanel3.Controls.Add(this.lblAMTDS, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.txtPRCDS, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.txtDTFMT, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.lblPRCDS, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.lblDTFMT, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.lblQTYDS, 6, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(5, 132);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 2;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(910, 52);
			this.TableLayoutPanel3.TabIndex = 16;
			this.txtXRTDS.Location = new System.Drawing.Point(804, 28);
			this.txtXRTDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtXRTDS.Name = "txtXRTDS";
			this.txtXRTDS.Size = new System.Drawing.Size(103, 22);
			this.txtXRTDS.TabIndex = 22;
			this.txtQTYDS.Location = new System.Drawing.Point(804, 2);
			this.txtQTYDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtQTYDS.Name = "txtQTYDS";
			this.txtQTYDS.Size = new System.Drawing.Size(103, 22);
			this.txtQTYDS.TabIndex = 19;
			this.lblXRTDS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblXRTDS.AutoSize = true;
			this.lblXRTDS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblXRTDS.Location = new System.Drawing.Point(639, 31);
			this.lblXRTDS.Name = "lblXRTDS";
			this.lblXRTDS.Size = new System.Drawing.Size(131, 16);
			this.lblXRTDS.TabIndex = 17;
			this.lblXRTDS.Text = "XRate Decimal Point";
			this.txtWGTDS.Location = new System.Drawing.Point(479, 28);
			this.txtWGTDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtWGTDS.Name = "txtWGTDS";
			this.txtWGTDS.Size = new System.Drawing.Size(103, 22);
			this.txtWGTDS.TabIndex = 21;
			this.txtAMTDS.Location = new System.Drawing.Point(479, 2);
			this.txtAMTDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtAMTDS.Name = "txtAMTDS";
			this.txtAMTDS.Size = new System.Drawing.Size(103, 22);
			this.txtAMTDS.TabIndex = 18;
			this.lblWGTDS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblWGTDS.AutoSize = true;
			this.lblWGTDS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblWGTDS.Location = new System.Drawing.Point(307, 31);
			this.lblWGTDS.Name = "lblWGTDS";
			this.lblWGTDS.Size = new System.Drawing.Size(136, 16);
			this.lblWGTDS.TabIndex = 8;
			this.lblWGTDS.Text = "Weight Decimal Point";
			this.lblAMTDS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblAMTDS.AutoSize = true;
			this.lblAMTDS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblAMTDS.Location = new System.Drawing.Point(307, 5);
			this.lblAMTDS.Name = "lblAMTDS";
			this.lblAMTDS.Size = new System.Drawing.Size(139, 16);
			this.lblAMTDS.TabIndex = 9;
			this.lblAMTDS.Text = "Amount Decimal Point";
			this.txtPRCDS.Location = new System.Drawing.Point(147, 28);
			this.txtPRCDS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPRCDS.Name = "txtPRCDS";
			this.txtPRCDS.Size = new System.Drawing.Size(103, 22);
			this.txtPRCDS.TabIndex = 20;
			this.txtDTFMT.Location = new System.Drawing.Point(147, 2);
			this.txtDTFMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDTFMT.Name = "txtDTFMT";
			this.txtDTFMT.Size = new System.Drawing.Size(103, 22);
			this.txtDTFMT.TabIndex = 17;
			this.lblPRCDS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPRCDS.AutoSize = true;
			this.lblPRCDS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPRCDS.Location = new System.Drawing.Point(3, 31);
			this.lblPRCDS.Name = "lblPRCDS";
			this.lblPRCDS.Size = new System.Drawing.Size(125, 16);
			this.lblPRCDS.TabIndex = 2;
			this.lblPRCDS.Text = "Price Decimal Point";
			this.lblDTFMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDTFMT.AutoSize = true;
			this.lblDTFMT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDTFMT.Location = new System.Drawing.Point(3, 5);
			this.lblDTFMT.Name = "lblDTFMT";
			this.lblDTFMT.Size = new System.Drawing.Size(82, 16);
			this.lblDTFMT.TabIndex = 1;
			this.lblDTFMT.Text = "Date Format";
			this.lblQTYDS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblQTYDS.AutoSize = true;
			this.lblQTYDS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQTYDS.Location = new System.Drawing.Point(639, 5);
			this.lblQTYDS.Name = "lblQTYDS";
			this.lblQTYDS.Size = new System.Drawing.Size(142, 16);
			this.lblQTYDS.TabIndex = 18;
			this.lblQTYDS.Text = "Quantity Decimal Point";
			this.lblLINE1.AutoSize = true;
			this.lblLINE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLINE1.ForeColor = System.Drawing.Color.Red;
			this.lblLINE1.Location = new System.Drawing.Point(4, 119);
			this.lblLINE1.Name = "lblLINE1";
			this.lblLINE1.Size = new System.Drawing.Size(903, 13);
			this.lblLINE1.TabIndex = 6;
			this.lblLINE1.Text = resources.GetString("lblLINE1.Text");
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 8;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51f));
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51f));
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.txtGRNCD, 4, 3);
			this.TableLayoutPanel2.Controls.Add(this.txtPOLCD, 4, 2);
			this.TableLayoutPanel2.Controls.Add(this.txtDOLCD, 4, 1);
			this.TableLayoutPanel2.Controls.Add(this.txtSOLCD, 4, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblPOLCD, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblDOLCD, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblSOLCD, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.txtDOCD, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblIGNCD, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.txtSOCD, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblPOCD, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblDOCD, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblSOCD, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblGRNCD, 3, 3);
			this.TableLayoutPanel2.Controls.Add(this.txtPOCD, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.txtIGNCD, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.txtGRLCD, 7, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblGRLCD, 6, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblSIVCD, 6, 1);
			this.TableLayoutPanel2.Controls.Add(this.txtSIVCD, 7, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblSTKCD, 6, 2);
			this.TableLayoutPanel2.Controls.Add(this.txtSTKCD, 7, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblWHSCD, 6, 3);
			this.TableLayoutPanel2.Controls.Add(this.txtWHSCD, 7, 3);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 9);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 4;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(910, 104);
			this.TableLayoutPanel2.TabIndex = 5;
			this.txtGRNCD.Location = new System.Drawing.Point(479, 80);
			this.txtGRNCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGRNCD.Name = "txtGRNCD";
			this.txtGRNCD.Size = new System.Drawing.Size(103, 22);
			this.txtGRNCD.TabIndex = 12;
			this.txtPOLCD.Location = new System.Drawing.Point(479, 54);
			this.txtPOLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPOLCD.Name = "txtPOLCD";
			this.txtPOLCD.Size = new System.Drawing.Size(103, 22);
			this.txtPOLCD.TabIndex = 10;
			this.txtDOLCD.Location = new System.Drawing.Point(479, 28);
			this.txtDOLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOLCD.Name = "txtDOLCD";
			this.txtDOLCD.Size = new System.Drawing.Size(103, 22);
			this.txtDOLCD.TabIndex = 8;
			this.txtSOLCD.Location = new System.Drawing.Point(479, 2);
			this.txtSOLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSOLCD.Name = "txtSOLCD";
			this.txtSOLCD.Size = new System.Drawing.Size(103, 22);
			this.txtSOLCD.TabIndex = 6;
			this.lblPOLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPOLCD.AutoSize = true;
			this.lblPOLCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPOLCD.Location = new System.Drawing.Point(307, 57);
			this.lblPOLCD.Name = "lblPOLCD";
			this.lblPOLCD.Size = new System.Drawing.Size(166, 16);
			this.lblPOLCD.TabIndex = 7;
			this.lblPOLCD.Text = "Purchase Order Line Code";
			this.lblDOLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDOLCD.AutoSize = true;
			this.lblDOLCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDOLCD.Location = new System.Drawing.Point(307, 31);
			this.lblDOLCD.Name = "lblDOLCD";
			this.lblDOLCD.Size = new System.Drawing.Size(159, 16);
			this.lblDOLCD.TabIndex = 8;
			this.lblDOLCD.Text = "Delivery Order Line Code";
			this.lblSOLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSOLCD.AutoSize = true;
			this.lblSOLCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSOLCD.Location = new System.Drawing.Point(307, 5);
			this.lblSOLCD.Name = "lblSOLCD";
			this.lblSOLCD.Size = new System.Drawing.Size(144, 16);
			this.lblSOLCD.TabIndex = 9;
			this.lblSOLCD.Text = "Sales Order Line Code";
			this.txtDOCD.Location = new System.Drawing.Point(147, 28);
			this.txtDOCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOCD.Name = "txtDOCD";
			this.txtDOCD.Size = new System.Drawing.Size(103, 22);
			this.txtDOCD.TabIndex = 7;
			this.lblIGNCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblIGNCD.AutoSize = true;
			this.lblIGNCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblIGNCD.Location = new System.Drawing.Point(3, 83);
			this.lblIGNCD.Name = "lblIGNCD";
			this.lblIGNCD.Size = new System.Drawing.Size(131, 16);
			this.lblIGNCD.TabIndex = 6;
			this.lblIGNCD.Text = "Incoming GRN Code";
			this.txtSOCD.Location = new System.Drawing.Point(147, 2);
			this.txtSOCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSOCD.Name = "txtSOCD";
			this.txtSOCD.Size = new System.Drawing.Size(103, 22);
			this.txtSOCD.TabIndex = 5;
			this.lblPOCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPOCD.AutoSize = true;
			this.lblPOCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPOCD.Location = new System.Drawing.Point(3, 57);
			this.lblPOCD.Name = "lblPOCD";
			this.lblPOCD.Size = new System.Drawing.Size(138, 16);
			this.lblPOCD.TabIndex = 2;
			this.lblPOCD.Text = "Purchase Order Code";
			this.lblDOCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDOCD.AutoSize = true;
			this.lblDOCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDOCD.Location = new System.Drawing.Point(3, 31);
			this.lblDOCD.Name = "lblDOCD";
			this.lblDOCD.Size = new System.Drawing.Size(131, 16);
			this.lblDOCD.TabIndex = 2;
			this.lblDOCD.Text = "Delivery Order Code";
			this.lblSOCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSOCD.AutoSize = true;
			this.lblSOCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSOCD.Location = new System.Drawing.Point(3, 5);
			this.lblSOCD.Name = "lblSOCD";
			this.lblSOCD.Size = new System.Drawing.Size(116, 16);
			this.lblSOCD.TabIndex = 1;
			this.lblSOCD.Text = "Sales Order Code";
			this.lblGRNCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblGRNCD.AutoSize = true;
			this.lblGRNCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblGRNCD.Location = new System.Drawing.Point(307, 83);
			this.lblGRNCD.Name = "lblGRNCD";
			this.lblGRNCD.Size = new System.Drawing.Size(74, 16);
			this.lblGRNCD.TabIndex = 2;
			this.lblGRNCD.Text = "GRN Code";
			this.txtPOCD.Location = new System.Drawing.Point(147, 54);
			this.txtPOCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPOCD.Name = "txtPOCD";
			this.txtPOCD.Size = new System.Drawing.Size(103, 22);
			this.txtPOCD.TabIndex = 9;
			this.txtIGNCD.Location = new System.Drawing.Point(147, 80);
			this.txtIGNCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtIGNCD.Name = "txtIGNCD";
			this.txtIGNCD.Size = new System.Drawing.Size(103, 22);
			this.txtIGNCD.TabIndex = 11;
			this.txtGRLCD.Location = new System.Drawing.Point(804, 2);
			this.txtGRLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGRLCD.Name = "txtGRLCD";
			this.txtGRLCD.Size = new System.Drawing.Size(103, 22);
			this.txtGRLCD.TabIndex = 13;
			this.lblGRLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblGRLCD.AutoSize = true;
			this.lblGRLCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblGRLCD.Location = new System.Drawing.Point(639, 5);
			this.lblGRLCD.Name = "lblGRLCD";
			this.lblGRLCD.Size = new System.Drawing.Size(102, 16);
			this.lblGRLCD.TabIndex = 7;
			this.lblGRLCD.Text = "GRN Line Code";
			this.lblSIVCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSIVCD.AutoSize = true;
			this.lblSIVCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSIVCD.Location = new System.Drawing.Point(639, 31);
			this.lblSIVCD.Name = "lblSIVCD";
			this.lblSIVCD.Size = new System.Drawing.Size(125, 16);
			this.lblSIVCD.TabIndex = 7;
			this.lblSIVCD.Text = "Sales Invoice Code";
			this.txtSIVCD.Location = new System.Drawing.Point(804, 28);
			this.txtSIVCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSIVCD.Name = "txtSIVCD";
			this.txtSIVCD.Size = new System.Drawing.Size(103, 22);
			this.txtSIVCD.TabIndex = 14;
			this.lblSTKCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTKCD.AutoSize = true;
			this.lblSTKCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTKCD.Location = new System.Drawing.Point(639, 57);
			this.lblSTKCD.Name = "lblSTKCD";
			this.lblSTKCD.Size = new System.Drawing.Size(113, 16);
			this.lblSTKCD.TabIndex = 8;
			this.lblSTKCD.Text = "Stock Take Code";
			this.txtSTKCD.Location = new System.Drawing.Point(804, 54);
			this.txtSTKCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSTKCD.Name = "txtSTKCD";
			this.txtSTKCD.Size = new System.Drawing.Size(103, 22);
			this.txtSTKCD.TabIndex = 15;
			this.lblWHSCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblWHSCD.AutoSize = true;
			this.lblWHSCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblWHSCD.Location = new System.Drawing.Point(639, 83);
			this.lblWHSCD.Name = "lblWHSCD";
			this.lblWHSCD.Size = new System.Drawing.Size(159, 16);
			this.lblWHSCD.TabIndex = 10;
			this.lblWHSCD.Text = "Default Warehouse Code";
			this.txtWHSCD.Location = new System.Drawing.Point(804, 80);
			this.txtWHSCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtWHSCD.Name = "txtWHSCD";
			this.txtWHSCD.Size = new System.Drawing.Size(103, 22);
			this.txtWHSCD.TabIndex = 16;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(1, 1);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 628);
			this.Panel1.TabIndex = 2;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(435, 55);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(73, 16);
			this.Label3.TabIndex = 43;
			this.Label3.Text = "Job Folder";
			this.txtJobFolder.Location = new System.Drawing.Point(595, 52);
			this.txtJobFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtJobFolder.Name = "txtJobFolder";
			this.txtJobFolder.Size = new System.Drawing.Size(283, 22);
			this.txtJobFolder.TabIndex = 39;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMA1CTL";
			this.Text = "System Control";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TableLayoutPanel7.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.TableLayoutPanel8.ResumeLayout(false);
			this.TableLayoutPanel8.PerformLayout();
			this.TableLayoutPanel9.ResumeLayout(false);
			this.TableLayoutPanel9.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel4.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmMA1CTL_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.Owner != null)
			{
				return;
			}
			Form[] mdiChildren = base.ParentForm.MdiChildren;
			bool blnChildFormExists = default(bool);
			foreach (Form ChildForm in mdiChildren)
			{
				if (Operators.CompareString(ChildForm.Name, base.Name, false) != 0)
				{
					blnChildFormExists = true;
					break;
				}
			}
			if (!blnChildFormExists)
			{
				base.ParentForm.Controls["Panel1"].Visible = true;
			}
		}

		private void frmMCTL_Shown(object sender, EventArgs e)
		{
			BindDatafromDB();
		}

		private bool BindDatafromDB()
		{
			string strSQL = "MACTL_PRJCD, MACTL_PRJNM, MACTL_CYEAR, MACTL_CMTH, MACTL_FYEAR, ";
			strSQL += "MACTL_FMTH, MACTL_SOCD, MACTL_SOLCD, MACTL_DOCD, MACTL_DOLCD, ";
			strSQL += "MACTL_POCD, MACTL_POLCD, MACTL_IGNCD, MACTL_GRNCD, MACTL_GRLCD, ";
			strSQL += "MACTL_SIVCD, MACTL_STKCD, MACTL_WHSCD, MACTL_DTFMT, MACTL_AMTDS, ";
			strSQL += "MACTL_QTYDS, MACTL_PRCDS, MACTL_WGTDS, MACTL_XRTDS, MACTL_TAX1, ";
			strSQL += "MACTL_TAXDESC1, MACTL_TAXRATE1, MACTL_TAX2, MACTL_TAXDESC2, MACTL_TAXRATE2, ";
			strSQL += "MACTL_GSTDESC, MACTL_GSTRT, MACTL_GSTST, MACTL_GSTINC, MACTL_SYSLK, ";
			strSQL += "MACTL_SYSDT, MACTL_LANGUAGE, MACTL_JFOLDER, MACTL_AUITM, MACTL_NEGSTK, MACTL_EODFG, ";
			strSQL += "MACTL_ENTDT, MACTL_ENTBY, MACTL_LUPDT, MACTL_LUPBY, MACTL_VIWBY, MACTL_EDTBY ";
			DataTable DT = DB.GetTable(strSQL, "MACTL_TBL", "", "");
			if (DT.Rows.Count > 0)
			{
				txtPRJCD.Text = DT.Rows[0]["MACTL_PRJCD"].ToString();
				txtPRJNM.Text = DT.Rows[0]["MACTL_PRJNM"].ToString();
				int intYEARCUR = Conversions.ToInteger(DT.Rows[0]["MACTL_CYEAR"].ToString());
				int intMONTHCUR = Conversions.ToInteger(DT.Rows[0]["MACTL_CMTH"].ToString());
				int intYEARFS = Conversions.ToInteger(DT.Rows[0]["MACTL_FYEAR"].ToString());
				int intMONTHFS = Conversions.ToInteger(DT.Rows[0]["MACTL_FMTH"].ToString());
				dtpCURDT.Value = DateAndTime.DateSerial(intYEARCUR, intMONTHCUR, 1);
				dtpFSDT.Value = DateAndTime.DateSerial(intYEARFS, intMONTHFS, 1);
				txtSOCD.Text = DT.Rows[0]["MACTL_SOCD"].ToString();
				txtSOLCD.Text = DT.Rows[0]["MACTL_SOLCD"].ToString();
				txtDOCD.Text = DT.Rows[0]["MACTL_DOCD"].ToString();
				txtDOLCD.Text = DT.Rows[0]["MACTL_DOLCD"].ToString();
				txtPOCD.Text = DT.Rows[0]["MACTL_POCD"].ToString();
				txtPOLCD.Text = DT.Rows[0]["MACTL_POLCD"].ToString();
				txtIGNCD.Text = DT.Rows[0]["MACTL_IGNCD"].ToString();
				txtGRNCD.Text = DT.Rows[0]["MACTL_GRNCD"].ToString();
				txtGRLCD.Text = DT.Rows[0]["MACTL_GRLCD"].ToString();
				txtSIVCD.Text = DT.Rows[0]["MACTL_SIVCD"].ToString();
				txtSTKCD.Text = DT.Rows[0]["MACTL_STKCD"].ToString();
				txtWHSCD.Text = DT.Rows[0]["MACTL_WHSCD"].ToString();
				txtDTFMT.Text = DT.Rows[0]["MACTL_DTFMT"].ToString();
				txtAMTDS.Text = DT.Rows[0]["MACTL_AMTDS"].ToString();
				txtQTYDS.Text = DT.Rows[0]["MACTL_QTYDS"].ToString();
				txtPRCDS.Text = DT.Rows[0]["MACTL_PRCDS"].ToString();
				txtWGTDS.Text = DT.Rows[0]["MACTL_WGTDS"].ToString();
				txtXRTDS.Text = DT.Rows[0]["MACTL_XRTDS"].ToString();
				string strTAX1 = DT.Rows[0]["MACTL_TAX1"].ToString();
				if (Operators.CompareString(strTAX1, "1", false) == 0)
				{
					chkTAX1.Checked = true;
				}
				txtTAXDESC1.Text = DT.Rows[0]["MACTL_TAXDESC1"].ToString();
				txtTAXRATE1.Text = DT.Rows[0]["MACTL_TAXRATE1"].ToString();
				string strTAX2 = DT.Rows[0]["MACTL_TAX2"].ToString();
				if (Operators.CompareString(strTAX2, "1", false) == 0)
				{
					chkTAX2.Checked = true;
				}
				txtTAXDESC2.Text = DT.Rows[0]["MACTL_TAXDESC2"].ToString();
				txtTAXRATE2.Text = DT.Rows[0]["MACTL_TAXRATE2"].ToString();
				txtGSTDESC.Text = DT.Rows[0]["MACTL_GSTDESC"].ToString();
				txtGSTRT.Text = DT.Rows[0]["MACTL_GSTRT"].ToString();
				dtpGSTST.Value = Conversions.ToDate(DT.Rows[0]["MACTL_GSTST"].ToString());
				string strGSTINC = DT.Rows[0]["MACTL_GSTINC"].ToString();
				if (Operators.CompareString(strGSTINC, "1", false) == 0)
				{
					chkGSTINC.Checked = true;
				}
				dtpSYSLK.Value = Conversions.ToDate(DT.Rows[0]["MACTL_SYSLK"].ToString());
				dtpSYSDT.Value = Conversions.ToDate(DT.Rows[0]["MACTL_SYSDT"].ToString());
				txtLANGUAGE.Text = DT.Rows[0]["MACTL_LANGUAGE"].ToString();
				txtJobFolder.Text = DT.Rows[0]["MACTL_JFOLDER"].ToString();
				string strAUITM = DT.Rows[0]["MACTL_AUITM"].ToString();
				if (Operators.CompareString(strAUITM, "1", false) == 0)
				{
					chkAUITM.Checked = true;
				}
				string strNEGSTK = DT.Rows[0]["MACTL_NEGSTK"].ToString();
				if (Operators.CompareString(strNEGSTK, "1", false) == 0)
				{
					chkNEGSTK.Checked = true;
				}
				string strEODFG = DT.Rows[0]["MACTL_EODFG"].ToString();
				if (Operators.CompareString(strEODFG, "1", false) == 0)
				{
					chkEODFG.Checked = true;
				}
				string strVIWBY = DT.Rows[0]["MACTL_VIWBY"].ToString();
				if (Operators.CompareString(strVIWBY, "1", false) == 0)
				{
					rdoVIWBYALL.Checked = true;
				}
				else
				{
					rdoVIWBYSV.Checked = true;
				}
				string strEDTBY = DT.Rows[0]["MACTL_EDTBY"].ToString();
				if (Operators.CompareString(strEDTBY, "1", false) == 0)
				{
					rdoEDTBYALL.Checked = true;
				}
				else
				{
					rdoEDTBYSV.Checked = true;
				}
				txtPRJCD.Enabled = false;
				btnSave.Text = "Update";
				btnDELETE.Enabled = true;
			}
			else
			{
				ClearDetails();
				txtPRJCD.Enabled = true;
				btnSave.Text = "Save";
				btnDELETE.Enabled = false;
			}
			bool BindDatafromDB = default(bool);
			return BindDatafromDB;
		}

		public void ClearDetails()
		{
			txtPRJCD.Text = string.Empty;
			txtPRJNM.Text = string.Empty;
			dtpCURDT.Value = DateTime.Now;
			dtpFSDT.Value = DateTime.Now;
			txtSOCD.Text = string.Empty;
			txtSOLCD.Text = string.Empty;
			txtDOCD.Text = string.Empty;
			txtDOLCD.Text = string.Empty;
			txtPOCD.Text = string.Empty;
			txtPOLCD.Text = string.Empty;
			txtIGNCD.Text = string.Empty;
			txtGRNCD.Text = string.Empty;
			txtGRLCD.Text = string.Empty;
			txtSIVCD.Text = string.Empty;
			txtSTKCD.Text = string.Empty;
			txtWHSCD.Text = string.Empty;
			txtDTFMT.Text = string.Empty;
			txtAMTDS.Text = string.Empty;
			txtQTYDS.Text = string.Empty;
			txtPRCDS.Text = string.Empty;
			txtWGTDS.Text = string.Empty;
			txtXRTDS.Text = string.Empty;
			chkTAX1.Checked = false;
			txtTAXDESC1.Text = string.Empty;
			txtTAXRATE1.Text = string.Empty;
			chkTAX2.Checked = false;
			txtTAXDESC2.Text = string.Empty;
			txtTAXRATE2.Text = string.Empty;
			txtGSTDESC.Text = string.Empty;
			txtGSTRT.Text = string.Empty;
			dtpGSTST.Value = DateTime.Now;
			chkGSTINC.Checked = false;
			dtpSYSLK.Value = DateTime.Now;
			dtpSYSDT.Value = DateTime.Now;
			txtLANGUAGE.Text = string.Empty;
			txtJobFolder.Text = string.Empty;
			chkAUITM.Checked = false;
			chkNEGSTK.Checked = false;
			chkEODFG.Checked = false;
			rdoVIWBYALL.Checked = true;
			rdoEDTBYALL.Checked = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
			BindDatafromDB();
		}

		private bool spMCTL(string strPRO)
		{
			int strTAX1 = (chkTAX1.Checked ? 1 : 0);
			int strTAX2 = (chkTAX2.Checked ? 1 : 0);
			int strGSTINC = (chkGSTINC.Checked ? 1 : 0);
			int strAUITM = (chkAUITM.Checked ? 1 : 0);
			int strNEGSTK = (chkNEGSTK.Checked ? 1 : 0);
			int strEODFG = (chkEODFG.Checked ? 1 : 0);
			int strVIWBY = (rdoVIWBYALL.Checked ? 1 : ((!rdoVIWBYSV.Checked) ? 0 : 0));
			int strEDTBY = (rdoEDTBYALL.Checked ? 1 : ((!rdoEDTBYSV.Checked) ? 0 : 0));
			bool spMCTL;
			if (!ValidateDetailControl())
			{
				spMCTL = false;
			}
			else
			{
				string strCMD = "EXEC spMACTL ";
				strCMD = strCMD + "'" + strPRO + "', ";
				strCMD = strCMD + "'" + txtPRJCD.Text + "', ";
				strCMD = strCMD + "'" + txtPRJNM.Text + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(dtpCURDT.Value.Year)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(dtpCURDT.Value.Month)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(dtpFSDT.Value.Year)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(dtpFSDT.Value.Month)) + "', ";
				strCMD = strCMD + "'" + txtSOCD.Text + "', ";
				strCMD = strCMD + "'" + txtSOLCD.Text + "', ";
				strCMD = strCMD + "'" + txtDOCD.Text + "', ";
				strCMD = strCMD + "'" + txtDOLCD.Text + "', ";
				strCMD = strCMD + "'" + txtPOCD.Text + "', ";
				strCMD = strCMD + "'" + txtPOLCD.Text + "', ";
				strCMD = strCMD + "'" + txtIGNCD.Text + "', ";
				strCMD = strCMD + "'" + txtGRNCD.Text + "', ";
				strCMD = strCMD + "'" + txtGRLCD.Text + "', ";
				strCMD = strCMD + "'" + txtSIVCD.Text + "', ";
				strCMD = strCMD + "'" + txtSTKCD.Text + "', ";
				strCMD = strCMD + "'" + txtWHSCD.Text + "', ";
				strCMD = strCMD + "'" + txtDTFMT.Text + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(txtAMTDS.Text)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(txtQTYDS.Text)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(txtPRCDS.Text)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(txtWGTDS.Text)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(txtXRTDS.Text)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(strTAX1) + "', ";
				strCMD = strCMD + "'" + txtTAXDESC1.Text + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(txtTAXRATE1.Text)) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(strTAX2) + "', ";
				strCMD = strCMD + "'" + txtTAXDESC2.Text + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(txtTAXRATE2.Text)) + "', ";
				strCMD = strCMD + "'" + txtGSTDESC.Text + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(Conversion.Val(txtGSTRT.Text)) + "', ";
				strCMD = strCMD + "'" + Common.gfSQLDate(dtpGSTST.Value) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(strGSTINC) + "', ";
				strCMD = strCMD + "'" + Common.gfSQLDate(dtpSYSLK.Value) + "', ";
				strCMD = strCMD + "'" + Common.gfSQLDate(dtpSYSDT.Value) + "', ";
				strCMD = strCMD + "'" + txtLANGUAGE.Text + "', ";
				strCMD = strCMD + "'" + txtJobFolder.Text + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(strAUITM) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(strNEGSTK) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(strEODFG) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(strVIWBY) + "', ";
				strCMD = strCMD + "'" + Conversions.ToString(strEDTBY) + "', ";
				strCMD = strCMD + "'" + Common.gfSQLDate(DateTime.Now) + "', ";
				strCMD = strCMD + "'" + PublicVar.gstrLogonID + "', ";
				strCMD = strCMD + "'" + Common.gfSQLDate(DateTime.Now) + "', ";
				strCMD = strCMD + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strCMD;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(strMessage, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMCTL = false;
					ProjectData.ClearProjectError();
					goto IL_0767;
				}
				BindDatafromDB();
				spMCTL = true;
			}
			goto IL_0767;
			IL_0767:
			return spMCTL;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			strMessage = ("Record " + btnSave.Text) ?? "";
			spMCTL("1");
		}

		private void btnDELETE_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(("Are you sure want to delete this record?\r\nProject Code : " + txtPRJCD.Text + "\r\nProject Name : " + txtPRJNM.Text) ?? "", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				strMessage = "Record Deleted!";
				spMCTL("2");
			}
		}

		public bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtPRJCD.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Project code cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPRJCD.Focus();
				return false;
			}
			if (Operators.CompareString(txtPRJNM.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Project name cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPRJNM.Focus();
				return false;
			}
			if (!Microsoft.VisualBasic.FileIO.FileSystem.DirectoryExists(txtJobFolder.Text))
			{
				MessageBox.Show("Job Folder not exists!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtJobFolder.Focus();
				return false;
			}
			return true;
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
