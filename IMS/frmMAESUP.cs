using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmMAESUP : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPrint")]
		private Button _btnPrint;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPrintfr")]
		private Button _btnPrintfr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMASUP")]
		private DataGridView _dgvMASUP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbSUPIDFR")]
		private ComboboxControl _cbSUPIDFR;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblADDR1")]
		internal virtual Label lblADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSUPID")]
		internal virtual Label lblSUPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSUPNM")]
		internal virtual Label lblSUPNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblFAXNO1")]
		internal virtual Label lblFAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTEL02")]
		internal virtual Label lblTEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTEL01")]
		internal virtual Label lblTEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTACD")]
		internal virtual Label lblSTACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCNTRY")]
		internal virtual Label lblCNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCNTPS")]
		internal virtual Label lblCNTPS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCNTPS")]
		internal virtual TextBox txtCNTPS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtFAXNO1")]
		internal virtual TextBox txtFAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTEL02")]
		internal virtual TextBox txtTEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTEL01")]
		internal virtual TextBox txtTEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR4")]
		internal virtual TextBox txtADDR4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR3")]
		internal virtual TextBox txtADDR3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR2")]
		internal virtual TextBox txtADDR2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR1")]
		internal virtual TextBox txtADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSUPNM")]
		internal virtual TextBox txtSUPNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSUPID")]
		internal virtual TextBox txtSUPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSAVE
		{
			[CompilerGenerated]
			get
			{
				return _btnSAVE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSAVE_Click;
				Button button = _btnSAVE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSAVE = value;
				button = _btnSAVE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lblREMRK")]
		internal virtual Label lblREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblEMAIL")]
		internal virtual Label lblEMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtEMAIL")]
		internal virtual TextBox txtEMAIL
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

		internal virtual Button btnBack
		{
			[CompilerGenerated]
			get
			{
				return _btnBack;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnBack_Click;
				Button button = _btnBack;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnBack = value;
				button = _btnBack;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		internal virtual Button btnDelete
		{
			[CompilerGenerated]
			get
			{
				return _btnDelete;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDelete_Click;
				Button button = _btnDelete;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDelete = value;
				button = _btnDelete;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtGSTID")]
		internal virtual TextBox txtGSTID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtACCNO")]
		internal virtual TextBox txtACCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtFAXNO2")]
		internal virtual TextBox txtFAXNO2
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

		internal virtual Button btnPrint
		{
			[CompilerGenerated]
			get
			{
				return _btnPrint;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPrint_Click;
				Button button = _btnPrint;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPrint = value;
				button = _btnPrint;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("chkSCFG")]
		internal virtual CheckBox chkSCFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkINTFG")]
		internal virtual CheckBox chkINTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSEARCH
		{
			[CompilerGenerated]
			get
			{
				return _btnSEARCH;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSEARCH_Click;
				Button button = _btnSEARCH;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSEARCH = value;
				button = _btnSEARCH;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnPrintfr
		{
			[CompilerGenerated]
			get
			{
				return _btnPrintfr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPrintfr_Click;
				Button button = _btnPrintfr;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPrintfr = value;
				button = _btnPrintfr;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual DataGridView dgvMASUP
		{
			[CompilerGenerated]
			get
			{
				return _dgvMASUP;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMASUP_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMASUP;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMASUP = value;
				dataGridView = _dgvMASUP;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		internal virtual Button btnNew
		{
			[CompilerGenerated]
			get
			{
				return _btnNew;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnNew_Click;
				Button button = _btnNew;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnNew = value;
				button = _btnNew;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSUPIDTO")]
		internal virtual Label lblSUPIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSUPIDFR")]
		internal virtual Label lblSUPIDFR
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

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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
				EventHandler value2 = btnClose_Click;
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

		[field: AccessedThroughProperty("numLTIME")]
		internal virtual NumControl numLTIME
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkEXCSYSTAX")]
		internal virtual CheckBox chkEXCSYSTAX
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbPAYTM")]
		internal virtual ComboBox cbPAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSUPIDTO")]
		internal virtual ComboboxControl cbSUPIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbSUPIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbSUPIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbSUPIDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbSUPIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbSUPIDFR = value;
				comboboxControl = _cbSUPIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbCURCD")]
		internal virtual ComboBox cbCURCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbTAXCD")]
		internal virtual ComboBox cbTAXCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSUPTY")]
		internal virtual ComboBox cbSUPTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSTACD")]
		internal virtual ComboBox cbSTACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCNTRY")]
		internal virtual ComboBox cbCNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSHORT")]
		internal virtual TextBox txtSHORT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_SUPID")]
		internal virtual DataGridViewTextBoxColumn MASUP_SUPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_SUPNM")]
		internal virtual DataGridViewTextBoxColumn MASUP_SUPNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_SHORT")]
		internal virtual DataGridViewTextBoxColumn MASUP_SHORT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("ADDRNM")]
		internal virtual DataGridViewTextBoxColumn ADDRNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_REMRK")]
		internal virtual DataGridViewTextBoxColumn MASUP_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_ADDR1")]
		internal virtual DataGridViewTextBoxColumn MASUP_ADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_ADDR2")]
		internal virtual DataGridViewTextBoxColumn MASUP_ADDR2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_ADDR3")]
		internal virtual DataGridViewTextBoxColumn MASUP_ADDR3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_ADDR4")]
		internal virtual DataGridViewTextBoxColumn MASUP_ADDR4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_CNTRY")]
		internal virtual DataGridViewTextBoxColumn MASUP_CNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_STACD")]
		internal virtual DataGridViewTextBoxColumn MASUP_STACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_TEL01")]
		internal virtual DataGridViewTextBoxColumn MASUP_TEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_TEL02")]
		internal virtual DataGridViewTextBoxColumn MASUP_TEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_FAXNO1")]
		internal virtual DataGridViewTextBoxColumn MASUP_FAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_FAXNO2")]
		internal virtual DataGridViewTextBoxColumn MASUP_FAXNO2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_CNTPS")]
		internal virtual DataGridViewTextBoxColumn MASUP_CNTPS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_EMAIL")]
		internal virtual DataGridViewTextBoxColumn MASUP_EMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_PAYTM")]
		internal virtual DataGridViewTextBoxColumn MASUP_PAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_SUPTY")]
		internal virtual DataGridViewTextBoxColumn MASUP_SUPTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_EXCSYSTAX")]
		internal virtual DataGridViewTextBoxColumn MASUP_EXCSYSTAX
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_SCFG")]
		internal virtual DataGridViewTextBoxColumn MASUP_SCFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_INTFG")]
		internal virtual DataGridViewTextBoxColumn MASUP_INTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_TAXCD")]
		internal virtual DataGridViewTextBoxColumn MASUP_TAXCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_GSTID")]
		internal virtual DataGridViewTextBoxColumn MASUP_GSTID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_LTIME")]
		internal virtual DataGridViewTextBoxColumn MASUP_LTIME
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_ACCNO")]
		internal virtual DataGridViewTextBoxColumn MASUP_ACCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MASUP_CURCD")]
		internal virtual DataGridViewTextBoxColumn MASUP_CURCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAESUP()
		{
			base.FormClosing += frmMAESUP_FormClosing;
			base.Shown += frmMAESUP_Shown;
			base.KeyDown += frmMAESUP_KeyDown;
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbCURCD = new System.Windows.Forms.ComboBox();
			this.cbTAXCD = new System.Windows.Forms.ComboBox();
			this.cbPAYTM = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.cbSUPTY = new System.Windows.Forms.ComboBox();
			this.chkEXCSYSTAX = new System.Windows.Forms.CheckBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.cbSTACD = new System.Windows.Forms.ComboBox();
			this.numLTIME = new IMS.NumControl();
			this.cbCNTRY = new System.Windows.Forms.ComboBox();
			this.chkSCFG = new System.Windows.Forms.CheckBox();
			this.chkINTFG = new System.Windows.Forms.CheckBox();
			this.txtACCNO = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtFAXNO2 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.txtEMAIL = new System.Windows.Forms.TextBox();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblEMAIL = new System.Windows.Forms.Label();
			this.txtCNTPS = new System.Windows.Forms.TextBox();
			this.txtFAXNO1 = new System.Windows.Forms.TextBox();
			this.txtTEL02 = new System.Windows.Forms.TextBox();
			this.txtTEL01 = new System.Windows.Forms.TextBox();
			this.txtADDR4 = new System.Windows.Forms.TextBox();
			this.txtADDR3 = new System.Windows.Forms.TextBox();
			this.txtADDR2 = new System.Windows.Forms.TextBox();
			this.txtADDR1 = new System.Windows.Forms.TextBox();
			this.txtSUPNM = new System.Windows.Forms.TextBox();
			this.lblFAXNO1 = new System.Windows.Forms.Label();
			this.lblTEL02 = new System.Windows.Forms.Label();
			this.lblTEL01 = new System.Windows.Forms.Label();
			this.lblCNTRY = new System.Windows.Forms.Label();
			this.txtSUPID = new System.Windows.Forms.TextBox();
			this.lblADDR1 = new System.Windows.Forms.Label();
			this.lblSUPID = new System.Windows.Forms.Label();
			this.lblSUPNM = new System.Windows.Forms.Label();
			this.lblCNTPS = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.lblSTACD = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtGSTID = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtSHORT = new System.Windows.Forms.TextBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPrintfr = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbSUPIDTO = new IMS.ComboboxControl();
			this.lblSUPIDTO = new System.Windows.Forms.Label();
			this.cbSUPIDFR = new IMS.ComboboxControl();
			this.lblSUPIDFR = new System.Windows.Forms.Label();
			this.dgvMASUP = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.MASUP_SUPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_SUPNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_SHORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ADDRNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_ADDR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_ADDR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_ADDR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_ADDR4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_CNTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_STACD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_TEL01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_TEL02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_FAXNO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_FAXNO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_CNTPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_PAYTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_SUPTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_EXCSYSTAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_SCFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_INTFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_TAXCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_GSTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_LTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_ACCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MASUP_CURCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMASUP).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbCURCD, 3, 15);
			this.TableLayoutPanel1.Controls.Add(this.cbTAXCD, 1, 16);
			this.TableLayoutPanel1.Controls.Add(this.cbPAYTM, 3, 14);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 2, 14);
			this.TableLayoutPanel1.Controls.Add(this.cbSUPTY, 1, 15);
			this.TableLayoutPanel1.Controls.Add(this.chkEXCSYSTAX, 2, 8);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 20);
			this.TableLayoutPanel1.Controls.Add(this.cbSTACD, 3, 7);
			this.TableLayoutPanel1.Controls.Add(this.numLTIME, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.cbCNTRY, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.chkSCFG, 2, 9);
			this.TableLayoutPanel1.Controls.Add(this.chkINTFG, 2, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtACCNO, 1, 17);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 15);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 17);
			this.TableLayoutPanel1.Controls.Add(this.txtFAXNO2, 1, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 12);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 18);
			this.TableLayoutPanel1.Controls.Add(this.txtEMAIL, 1, 14);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 18);
			this.TableLayoutPanel1.Controls.Add(this.lblEMAIL, 0, 14);
			this.TableLayoutPanel1.Controls.Add(this.txtCNTPS, 1, 13);
			this.TableLayoutPanel1.Controls.Add(this.txtFAXNO1, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.txtTEL02, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtTEL01, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR4, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR3, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR2, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR1, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtSUPNM, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblFAXNO1, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.lblTEL02, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.lblTEL01, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.lblCNTRY, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtSUPID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblADDR1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblSUPID, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblSUPNM, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblCNTPS, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.lblSTACD, 2, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 15);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 2, 16);
			this.TableLayoutPanel1.Controls.Add(this.txtGSTID, 3, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtSHORT, 1, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(11, 11);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 21;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(856, 674);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbCURCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCURCD.FormattingEnabled = true;
			this.cbCURCD.Location = new System.Drawing.Point(639, 458);
			this.cbCURCD.Name = "cbCURCD";
			this.cbCURCD.Size = new System.Drawing.Size(200, 28);
			this.cbCURCD.TabIndex = 19;
			this.cbTAXCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTAXCD.FormattingEnabled = true;
			this.cbTAXCD.Location = new System.Drawing.Point(154, 489);
			this.cbTAXCD.Name = "cbTAXCD";
			this.cbTAXCD.Size = new System.Drawing.Size(200, 28);
			this.cbTAXCD.TabIndex = 20;
			this.cbPAYTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPAYTM.FormattingEnabled = true;
			this.cbPAYTM.Location = new System.Drawing.Point(639, 427);
			this.cbPAYTM.Name = "cbPAYTM";
			this.cbPAYTM.Size = new System.Drawing.Size(150, 28);
			this.cbPAYTM.TabIndex = 17;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(441, 429);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(118, 20);
			this.Label8.TabIndex = 17;
			this.Label8.Text = "Payment Term";
			this.cbSUPTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPTY.FormattingEnabled = true;
			this.cbSUPTY.Location = new System.Drawing.Point(154, 458);
			this.cbSUPTY.Name = "cbSUPTY";
			this.cbSUPTY.Size = new System.Drawing.Size(200, 28);
			this.cbSUPTY.TabIndex = 18;
			this.chkEXCSYSTAX.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.chkEXCSYSTAX, 2);
			this.chkEXCSYSTAX.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkEXCSYSTAX.Location = new System.Drawing.Point(441, 247);
			this.chkEXCSYSTAX.Name = "chkEXCSYSTAX";
			this.chkEXCSYSTAX.Size = new System.Drawing.Size(183, 24);
			this.chkEXCSYSTAX.TabIndex = 24;
			this.chkEXCSYSTAX.Text = "Exclude System Tax";
			this.chkEXCSYSTAX.UseVisualStyleBackColor = true;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 5;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 3);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnPrint, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnBack, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 618);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel3.TabIndex = 16;
			this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Image = IMS.My.Resources.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(507, 2);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(120, 50);
			this.btnPrint.TabIndex = 31;
			this.btnPrint.Text = "Print";
			this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(381, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 30;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 29;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(129, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 28;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(3, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 27;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.cbSTACD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTACD.FormattingEnabled = true;
			this.cbSTACD.Location = new System.Drawing.Point(639, 213);
			this.cbSTACD.Name = "cbSTACD";
			this.cbSTACD.Size = new System.Drawing.Size(214, 28);
			this.cbSTACD.TabIndex = 9;
			this.numLTIME.AllowNegative = false;
			this.numLTIME.DataChanged = false;
			this.numLTIME.Location = new System.Drawing.Point(154, 246);
			this.numLTIME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numLTIME.Name = "numLTIME";
			this.numLTIME.NumberFormat = "8.0";
			this.numLTIME.Size = new System.Drawing.Size(42, 26);
			this.numLTIME.TabIndex = 10;
			this.numLTIME.Text = "0";
			this.numLTIME.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numLTIME.ThousandSeperator = false;
			this.numLTIME.Value = 0.0;
			this.cbCNTRY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCNTRY.FormattingEnabled = true;
			this.cbCNTRY.Location = new System.Drawing.Point(154, 213);
			this.cbCNTRY.Name = "cbCNTRY";
			this.cbCNTRY.Size = new System.Drawing.Size(214, 28);
			this.cbCNTRY.TabIndex = 8;
			this.chkSCFG.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.chkSCFG, 2);
			this.chkSCFG.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkSCFG.Location = new System.Drawing.Point(441, 277);
			this.chkSCFG.Name = "chkSCFG";
			this.chkSCFG.Size = new System.Drawing.Size(87, 24);
			this.chkSCFG.TabIndex = 25;
			this.chkSCFG.Text = "Subcon";
			this.chkSCFG.UseVisualStyleBackColor = true;
			this.chkINTFG.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.chkINTFG, 2);
			this.chkINTFG.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkINTFG.Location = new System.Drawing.Point(441, 307);
			this.chkINTFG.Name = "chkINTFG";
			this.chkINTFG.Size = new System.Drawing.Size(137, 24);
			this.chkINTFG.TabIndex = 26;
			this.chkINTFG.Text = "Data Interface";
			this.chkINTFG.UseVisualStyleBackColor = true;
			this.txtACCNO.Location = new System.Drawing.Point(154, 519);
			this.txtACCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtACCNO.Name = "txtACCNO";
			this.txtACCNO.Size = new System.Drawing.Size(125, 26);
			this.txtACCNO.TabIndex = 22;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 460);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(111, 20);
			this.Label2.TabIndex = 19;
			this.Label2.Text = "Supplier Type";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 491);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(80, 20);
			this.Label3.TabIndex = 20;
			this.Label3.Text = "Tax Code";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 522);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(96, 20);
			this.Label5.TabIndex = 22;
			this.Label5.Text = "Account No";
			this.txtFAXNO2.Location = new System.Drawing.Point(154, 366);
			this.txtFAXNO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFAXNO2.Name = "txtFAXNO2";
			this.txtFAXNO2.Size = new System.Drawing.Size(125, 26);
			this.txtFAXNO2.TabIndex = 14;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 369);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(76, 20);
			this.Label1.TabIndex = 17;
			this.Label1.Text = "Fax No 2";
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 2);
			this.txtREMRK.Location = new System.Drawing.Point(154, 549);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(460, 45);
			this.txtREMRK.TabIndex = 23;
			this.txtEMAIL.Location = new System.Drawing.Point(154, 426);
			this.txtEMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEMAIL.Name = "txtEMAIL";
			this.txtEMAIL.Size = new System.Drawing.Size(281, 26);
			this.txtEMAIL.TabIndex = 16;
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 561);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(67, 20);
			this.lblREMRK.TabIndex = 19;
			this.lblREMRK.Text = "Remark";
			this.lblEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEMAIL.AutoSize = true;
			this.lblEMAIL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEMAIL.Location = new System.Drawing.Point(3, 429);
			this.lblEMAIL.Name = "lblEMAIL";
			this.lblEMAIL.Size = new System.Drawing.Size(51, 20);
			this.lblEMAIL.TabIndex = 18;
			this.lblEMAIL.Text = "Email";
			this.txtCNTPS.Location = new System.Drawing.Point(154, 396);
			this.txtCNTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCNTPS.Name = "txtCNTPS";
			this.txtCNTPS.Size = new System.Drawing.Size(281, 26);
			this.txtCNTPS.TabIndex = 15;
			this.txtFAXNO1.Location = new System.Drawing.Point(154, 336);
			this.txtFAXNO1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFAXNO1.Name = "txtFAXNO1";
			this.txtFAXNO1.Size = new System.Drawing.Size(125, 26);
			this.txtFAXNO1.TabIndex = 13;
			this.txtTEL02.Location = new System.Drawing.Point(154, 306);
			this.txtTEL02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTEL02.Name = "txtTEL02";
			this.txtTEL02.Size = new System.Drawing.Size(125, 26);
			this.txtTEL02.TabIndex = 12;
			this.txtTEL01.Location = new System.Drawing.Point(154, 276);
			this.txtTEL01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTEL01.Name = "txtTEL01";
			this.txtTEL01.Size = new System.Drawing.Size(125, 26);
			this.txtTEL01.TabIndex = 11;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR4, 2);
			this.txtADDR4.Location = new System.Drawing.Point(154, 182);
			this.txtADDR4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR4.Name = "txtADDR4";
			this.txtADDR4.Size = new System.Drawing.Size(460, 26);
			this.txtADDR4.TabIndex = 7;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR3, 2);
			this.txtADDR3.Location = new System.Drawing.Point(154, 152);
			this.txtADDR3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR3.Name = "txtADDR3";
			this.txtADDR3.Size = new System.Drawing.Size(460, 26);
			this.txtADDR3.TabIndex = 6;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR2, 2);
			this.txtADDR2.Location = new System.Drawing.Point(154, 122);
			this.txtADDR2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR2.Name = "txtADDR2";
			this.txtADDR2.Size = new System.Drawing.Size(460, 26);
			this.txtADDR2.TabIndex = 5;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR1, 2);
			this.txtADDR1.Location = new System.Drawing.Point(154, 92);
			this.txtADDR1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR1.Name = "txtADDR1";
			this.txtADDR1.Size = new System.Drawing.Size(460, 26);
			this.txtADDR1.TabIndex = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.txtSUPNM, 2);
			this.txtSUPNM.Location = new System.Drawing.Point(154, 32);
			this.txtSUPNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSUPNM.Name = "txtSUPNM";
			this.txtSUPNM.Size = new System.Drawing.Size(460, 26);
			this.txtSUPNM.TabIndex = 2;
			this.lblFAXNO1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFAXNO1.AutoSize = true;
			this.lblFAXNO1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFAXNO1.Location = new System.Drawing.Point(3, 339);
			this.lblFAXNO1.Name = "lblFAXNO1";
			this.lblFAXNO1.Size = new System.Drawing.Size(62, 20);
			this.lblFAXNO1.TabIndex = 8;
			this.lblFAXNO1.Text = "Fax No";
			this.lblTEL02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL02.AutoSize = true;
			this.lblTEL02.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL02.Location = new System.Drawing.Point(3, 309);
			this.lblTEL02.Name = "lblTEL02";
			this.lblTEL02.Size = new System.Drawing.Size(46, 20);
			this.lblTEL02.TabIndex = 9;
			this.lblTEL02.Text = "Tel 2";
			this.lblTEL01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL01.AutoSize = true;
			this.lblTEL01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL01.Location = new System.Drawing.Point(3, 279);
			this.lblTEL01.Name = "lblTEL01";
			this.lblTEL01.Size = new System.Drawing.Size(46, 20);
			this.lblTEL01.TabIndex = 10;
			this.lblTEL01.Text = "Tel 1";
			this.lblCNTRY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTRY.AutoSize = true;
			this.lblCNTRY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTRY.Location = new System.Drawing.Point(3, 217);
			this.lblCNTRY.Name = "lblCNTRY";
			this.lblCNTRY.Size = new System.Drawing.Size(67, 20);
			this.lblCNTRY.TabIndex = 12;
			this.lblCNTRY.Text = "Country";
			this.txtSUPID.Location = new System.Drawing.Point(154, 2);
			this.txtSUPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSUPID.Name = "txtSUPID";
			this.txtSUPID.Size = new System.Drawing.Size(125, 26);
			this.txtSUPID.TabIndex = 1;
			this.lblADDR1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblADDR1.AutoSize = true;
			this.lblADDR1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblADDR1.Location = new System.Drawing.Point(3, 95);
			this.lblADDR1.Name = "lblADDR1";
			this.lblADDR1.Size = new System.Drawing.Size(85, 20);
			this.lblADDR1.TabIndex = 16;
			this.lblADDR1.Text = "Address 1";
			this.lblSUPID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSUPID.AutoSize = true;
			this.lblSUPID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSUPID.Location = new System.Drawing.Point(3, 5);
			this.lblSUPID.Name = "lblSUPID";
			this.lblSUPID.Size = new System.Drawing.Size(92, 20);
			this.lblSUPID.TabIndex = 8;
			this.lblSUPID.Text = "Supplier ID";
			this.lblSUPNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSUPNM.AutoSize = true;
			this.lblSUPNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSUPNM.Location = new System.Drawing.Point(3, 35);
			this.lblSUPNM.Name = "lblSUPNM";
			this.lblSUPNM.Size = new System.Drawing.Size(119, 20);
			this.lblSUPNM.TabIndex = 9;
			this.lblSUPNM.Text = "Supplier Name";
			this.lblCNTPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTPS.AutoSize = true;
			this.lblCNTPS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTPS.Location = new System.Drawing.Point(3, 399);
			this.lblCNTPS.Name = "lblCNTPS";
			this.lblCNTPS.Size = new System.Drawing.Size(99, 20);
			this.lblCNTPS.TabIndex = 17;
			this.lblCNTPS.Text = "Attention To";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 249);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(145, 20);
			this.Label6.TabIndex = 22;
			this.Label6.Text = "Lead Time (day/s)";
			this.lblSTACD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTACD.AutoSize = true;
			this.lblSTACD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTACD.Location = new System.Drawing.Point(441, 217);
			this.lblSTACD.Name = "lblSTACD";
			this.lblSTACD.Size = new System.Drawing.Size(48, 20);
			this.lblSTACD.TabIndex = 11;
			this.lblSTACD.Text = "State";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(441, 460);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(77, 20);
			this.Label7.TabIndex = 20;
			this.Label7.Text = "Currency";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(441, 491);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(65, 20);
			this.Label4.TabIndex = 21;
			this.Label4.Text = "GST ID";
			this.txtGSTID.Location = new System.Drawing.Point(639, 488);
			this.txtGSTID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGSTID.Name = "txtGSTID";
			this.txtGSTID.Size = new System.Drawing.Size(125, 26);
			this.txtGSTID.TabIndex = 21;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 65);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(98, 20);
			this.Label9.TabIndex = 39;
			this.Label9.Text = "Short Name";
			this.txtSHORT.Location = new System.Drawing.Point(154, 62);
			this.txtSHORT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSHORT.Name = "txtSHORT";
			this.txtSHORT.Size = new System.Drawing.Size(281, 26);
			this.txtSHORT.TabIndex = 3;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvMASUP);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 630);
			this.Panel2.TabIndex = 2;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPrintfr, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 56);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel4.TabIndex = 26;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(381, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnPrintfr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPrintfr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPrintfr.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPrintfr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPrintfr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintfr.Image = IMS.My.Resources.Resources.Print;
			this.btnPrintfr.Location = new System.Drawing.Point(255, 2);
			this.btnPrintfr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPrintfr.Name = "btnPrintfr";
			this.btnPrintfr.Size = new System.Drawing.Size(120, 50);
			this.btnPrintfr.TabIndex = 5;
			this.btnPrintfr.Text = "Print";
			this.btnPrintfr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrintfr.UseVisualStyleBackColor = false;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(3, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 50);
			this.btnSEARCH.TabIndex = 3;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(129, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 50);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbSUPIDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblSUPIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbSUPIDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblSUPIDFR, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(809, 30);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbSUPIDTO.BlankValue = null;
			this.cbSUPIDTO.ComboboxWidth = 170;
			this.cbSUPIDTO.DataTable = null;
			this.cbSUPIDTO.DisplayMember = null;
			this.cbSUPIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDTO.HasBlankValue = true;
			this.cbSUPIDTO.Location = new System.Drawing.Point(478, 2);
			this.cbSUPIDTO.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
			this.cbSUPIDTO.Name = "cbSUPIDTO";
			this.cbSUPIDTO.SelectedIndex = -1;
			this.cbSUPIDTO.SelectedItem = null;
			this.cbSUPIDTO.SelectedValue = null;
			this.cbSUPIDTO.Size = new System.Drawing.Size(324, 26);
			this.cbSUPIDTO.TabIndex = 28;
			this.cbSUPIDTO.TextMultiline = true;
			this.cbSUPIDTO.ValueMember = null;
			this.cbSUPIDTO.WhereClause = null;
			this.lblSUPIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSUPIDTO.AutoSize = true;
			this.lblSUPIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSUPIDTO.Location = new System.Drawing.Point(440, 5);
			this.lblSUPIDTO.Name = "lblSUPIDTO";
			this.lblSUPIDTO.Size = new System.Drawing.Size(28, 20);
			this.lblSUPIDTO.TabIndex = 3;
			this.lblSUPIDTO.Text = "To";
			this.cbSUPIDFR.BlankValue = null;
			this.cbSUPIDFR.ComboboxWidth = 170;
			this.cbSUPIDFR.DataTable = null;
			this.cbSUPIDFR.DisplayMember = null;
			this.cbSUPIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDFR.HasBlankValue = true;
			this.cbSUPIDFR.Location = new System.Drawing.Point(108, 2);
			this.cbSUPIDFR.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbSUPIDFR.Name = "cbSUPIDFR";
			this.cbSUPIDFR.SelectedIndex = -1;
			this.cbSUPIDFR.SelectedItem = null;
			this.cbSUPIDFR.SelectedValue = null;
			this.cbSUPIDFR.Size = new System.Drawing.Size(324, 26);
			this.cbSUPIDFR.TabIndex = 27;
			this.cbSUPIDFR.TextMultiline = true;
			this.cbSUPIDFR.ValueMember = null;
			this.cbSUPIDFR.WhereClause = null;
			this.lblSUPIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSUPIDFR.AutoSize = true;
			this.lblSUPIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSUPIDFR.Location = new System.Drawing.Point(3, 5);
			this.lblSUPIDFR.Name = "lblSUPIDFR";
			this.lblSUPIDFR.Size = new System.Drawing.Size(97, 20);
			this.lblSUPIDFR.TabIndex = 2;
			this.lblSUPIDFR.Text = "Supplier ID ";
			this.dgvMASUP.AllowUserToAddRows = false;
			this.dgvMASUP.AllowUserToDeleteRows = false;
			this.dgvMASUP.AllowUserToResizeRows = false;
			this.dgvMASUP.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMASUP.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMASUP.ColumnHeadersHeight = 30;
			this.dgvMASUP.Columns.AddRange(this.MASUP_SUPID, this.MASUP_SUPNM, this.MASUP_SHORT, this.ADDRNM, this.MASUP_REMRK, this.MASUP_ADDR1, this.MASUP_ADDR2, this.MASUP_ADDR3, this.MASUP_ADDR4, this.MASUP_CNTRY, this.MASUP_STACD, this.MASUP_TEL01, this.MASUP_TEL02, this.MASUP_FAXNO1, this.MASUP_FAXNO2, this.MASUP_CNTPS, this.MASUP_EMAIL, this.MASUP_PAYTM, this.MASUP_SUPTY, this.MASUP_EXCSYSTAX, this.MASUP_SCFG, this.MASUP_INTFG, this.MASUP_TAXCD, this.MASUP_GSTID, this.MASUP_LTIME, this.MASUP_ACCNO, this.MASUP_CURCD);
			this.dgvMASUP.Location = new System.Drawing.Point(5, 118);
			this.dgvMASUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMASUP.MultiSelect = false;
			this.dgvMASUP.Name = "dgvMASUP";
			this.dgvMASUP.ReadOnly = true;
			this.dgvMASUP.RowHeadersVisible = false;
			this.dgvMASUP.RowHeadersWidth = 51;
			this.dgvMASUP.RowTemplate.Height = 24;
			this.dgvMASUP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMASUP.Size = new System.Drawing.Size(1332, 503);
			this.dgvMASUP.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 17;
			this.MASUP_SUPID.HeaderText = "Supplier ID";
			this.MASUP_SUPID.MinimumWidth = 6;
			this.MASUP_SUPID.Name = "MASUP_SUPID";
			this.MASUP_SUPID.ReadOnly = true;
			this.MASUP_SUPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_SUPID.Width = 125;
			this.MASUP_SUPNM.HeaderText = "Supplier Name";
			this.MASUP_SUPNM.MinimumWidth = 6;
			this.MASUP_SUPNM.Name = "MASUP_SUPNM";
			this.MASUP_SUPNM.ReadOnly = true;
			this.MASUP_SUPNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_SUPNM.Width = 200;
			this.MASUP_SHORT.HeaderText = "Short Name";
			this.MASUP_SHORT.MinimumWidth = 6;
			this.MASUP_SHORT.Name = "MASUP_SHORT";
			this.MASUP_SHORT.ReadOnly = true;
			this.MASUP_SHORT.Width = 125;
			this.ADDRNM.HeaderText = "Address";
			this.ADDRNM.MinimumWidth = 6;
			this.ADDRNM.Name = "ADDRNM";
			this.ADDRNM.ReadOnly = true;
			this.ADDRNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ADDRNM.Width = 300;
			this.MASUP_REMRK.HeaderText = "Remark";
			this.MASUP_REMRK.MinimumWidth = 6;
			this.MASUP_REMRK.Name = "MASUP_REMRK";
			this.MASUP_REMRK.ReadOnly = true;
			this.MASUP_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_REMRK.Width = 300;
			this.MASUP_ADDR1.HeaderText = "Address 1";
			this.MASUP_ADDR1.MinimumWidth = 6;
			this.MASUP_ADDR1.Name = "MASUP_ADDR1";
			this.MASUP_ADDR1.ReadOnly = true;
			this.MASUP_ADDR1.Visible = false;
			this.MASUP_ADDR1.Width = 125;
			this.MASUP_ADDR2.HeaderText = "Address 2";
			this.MASUP_ADDR2.MinimumWidth = 6;
			this.MASUP_ADDR2.Name = "MASUP_ADDR2";
			this.MASUP_ADDR2.ReadOnly = true;
			this.MASUP_ADDR2.Visible = false;
			this.MASUP_ADDR2.Width = 125;
			this.MASUP_ADDR3.HeaderText = "Address 3";
			this.MASUP_ADDR3.MinimumWidth = 6;
			this.MASUP_ADDR3.Name = "MASUP_ADDR3";
			this.MASUP_ADDR3.ReadOnly = true;
			this.MASUP_ADDR3.Visible = false;
			this.MASUP_ADDR3.Width = 125;
			this.MASUP_ADDR4.HeaderText = "Address 4";
			this.MASUP_ADDR4.MinimumWidth = 6;
			this.MASUP_ADDR4.Name = "MASUP_ADDR4";
			this.MASUP_ADDR4.ReadOnly = true;
			this.MASUP_ADDR4.Visible = false;
			this.MASUP_ADDR4.Width = 125;
			this.MASUP_CNTRY.HeaderText = "Country";
			this.MASUP_CNTRY.MinimumWidth = 6;
			this.MASUP_CNTRY.Name = "MASUP_CNTRY";
			this.MASUP_CNTRY.ReadOnly = true;
			this.MASUP_CNTRY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_CNTRY.Visible = false;
			this.MASUP_CNTRY.Width = 125;
			this.MASUP_STACD.HeaderText = "State";
			this.MASUP_STACD.MinimumWidth = 6;
			this.MASUP_STACD.Name = "MASUP_STACD";
			this.MASUP_STACD.ReadOnly = true;
			this.MASUP_STACD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_STACD.Visible = false;
			this.MASUP_STACD.Width = 125;
			this.MASUP_TEL01.HeaderText = "Tel No";
			this.MASUP_TEL01.MinimumWidth = 6;
			this.MASUP_TEL01.Name = "MASUP_TEL01";
			this.MASUP_TEL01.ReadOnly = true;
			this.MASUP_TEL01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_TEL01.Width = 125;
			this.MASUP_TEL02.HeaderText = "Tel No 2";
			this.MASUP_TEL02.MinimumWidth = 6;
			this.MASUP_TEL02.Name = "MASUP_TEL02";
			this.MASUP_TEL02.ReadOnly = true;
			this.MASUP_TEL02.Visible = false;
			this.MASUP_TEL02.Width = 125;
			this.MASUP_FAXNO1.HeaderText = "Fax No";
			this.MASUP_FAXNO1.MinimumWidth = 6;
			this.MASUP_FAXNO1.Name = "MASUP_FAXNO1";
			this.MASUP_FAXNO1.ReadOnly = true;
			this.MASUP_FAXNO1.Visible = false;
			this.MASUP_FAXNO1.Width = 125;
			this.MASUP_FAXNO2.HeaderText = "Fax No 2";
			this.MASUP_FAXNO2.MinimumWidth = 6;
			this.MASUP_FAXNO2.Name = "MASUP_FAXNO2";
			this.MASUP_FAXNO2.ReadOnly = true;
			this.MASUP_FAXNO2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_FAXNO2.Visible = false;
			this.MASUP_FAXNO2.Width = 125;
			this.MASUP_CNTPS.FillWeight = 150f;
			this.MASUP_CNTPS.HeaderText = "Contact Person";
			this.MASUP_CNTPS.MinimumWidth = 6;
			this.MASUP_CNTPS.Name = "MASUP_CNTPS";
			this.MASUP_CNTPS.ReadOnly = true;
			this.MASUP_CNTPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_CNTPS.Visible = false;
			this.MASUP_CNTPS.Width = 125;
			this.MASUP_EMAIL.HeaderText = "Email";
			this.MASUP_EMAIL.MinimumWidth = 6;
			this.MASUP_EMAIL.Name = "MASUP_EMAIL";
			this.MASUP_EMAIL.ReadOnly = true;
			this.MASUP_EMAIL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_EMAIL.Visible = false;
			this.MASUP_EMAIL.Width = 150;
			this.MASUP_PAYTM.HeaderText = "Payment Term";
			this.MASUP_PAYTM.MinimumWidth = 6;
			this.MASUP_PAYTM.Name = "MASUP_PAYTM";
			this.MASUP_PAYTM.ReadOnly = true;
			this.MASUP_PAYTM.Visible = false;
			this.MASUP_PAYTM.Width = 125;
			this.MASUP_SUPTY.HeaderText = "Supplier Type";
			this.MASUP_SUPTY.MinimumWidth = 6;
			this.MASUP_SUPTY.Name = "MASUP_SUPTY";
			this.MASUP_SUPTY.ReadOnly = true;
			this.MASUP_SUPTY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_SUPTY.Width = 125;
			this.MASUP_EXCSYSTAX.HeaderText = "Exclude System Tax";
			this.MASUP_EXCSYSTAX.MinimumWidth = 6;
			this.MASUP_EXCSYSTAX.Name = "MASUP_EXCSYSTAX";
			this.MASUP_EXCSYSTAX.ReadOnly = true;
			this.MASUP_EXCSYSTAX.Visible = false;
			this.MASUP_EXCSYSTAX.Width = 125;
			this.MASUP_SCFG.HeaderText = "Subcon Flag";
			this.MASUP_SCFG.MinimumWidth = 6;
			this.MASUP_SCFG.Name = "MASUP_SCFG";
			this.MASUP_SCFG.ReadOnly = true;
			this.MASUP_SCFG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_SCFG.Visible = false;
			this.MASUP_SCFG.Width = 125;
			this.MASUP_INTFG.HeaderText = "Interface Flag";
			this.MASUP_INTFG.MinimumWidth = 6;
			this.MASUP_INTFG.Name = "MASUP_INTFG";
			this.MASUP_INTFG.ReadOnly = true;
			this.MASUP_INTFG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_INTFG.Visible = false;
			this.MASUP_INTFG.Width = 125;
			this.MASUP_TAXCD.HeaderText = "Tax Code";
			this.MASUP_TAXCD.MinimumWidth = 6;
			this.MASUP_TAXCD.Name = "MASUP_TAXCD";
			this.MASUP_TAXCD.ReadOnly = true;
			this.MASUP_TAXCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_TAXCD.Visible = false;
			this.MASUP_TAXCD.Width = 125;
			this.MASUP_GSTID.HeaderText = "GST ID";
			this.MASUP_GSTID.MinimumWidth = 6;
			this.MASUP_GSTID.Name = "MASUP_GSTID";
			this.MASUP_GSTID.ReadOnly = true;
			this.MASUP_GSTID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_GSTID.Visible = false;
			this.MASUP_GSTID.Width = 125;
			this.MASUP_LTIME.HeaderText = "Lead Time";
			this.MASUP_LTIME.MinimumWidth = 6;
			this.MASUP_LTIME.Name = "MASUP_LTIME";
			this.MASUP_LTIME.ReadOnly = true;
			this.MASUP_LTIME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_LTIME.Visible = false;
			this.MASUP_LTIME.Width = 125;
			this.MASUP_ACCNO.HeaderText = "Account No";
			this.MASUP_ACCNO.MinimumWidth = 6;
			this.MASUP_ACCNO.Name = "MASUP_ACCNO";
			this.MASUP_ACCNO.ReadOnly = true;
			this.MASUP_ACCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MASUP_ACCNO.Visible = false;
			this.MASUP_ACCNO.Width = 125;
			this.MASUP_CURCD.HeaderText = "Currency";
			this.MASUP_CURCD.MinimumWidth = 6;
			this.MASUP_CURCD.Name = "MASUP_CURCD";
			this.MASUP_CURCD.ReadOnly = true;
			this.MASUP_CURCD.Width = 125;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAESUP";
			base.Tag = "MAESUP";
			this.Text = "Supplier";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMASUP).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void BindComboHeader()
		{
			cbSUPIDFR.DataTable = "MASUP_TBL WITH (NOLOCK) ";
			cbSUPIDFR.ValueMember = "MASUP_SUPID";
			cbSUPIDFR.DisplayMember = "MASUP_SHORT";
			cbSUPIDFR.LoadData();
			cbSUPIDTO.DataTable = "MASUP_TBL WITH (NOLOCK) ";
			cbSUPIDTO.ValueMember = "MASUP_SUPID";
			cbSUPIDTO.DisplayMember = "MASUP_SHORT";
			cbSUPIDTO.LoadData();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			BindComboBox();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = false;
			btnCancel.Enabled = false;
			btnPrint.Enabled = false;
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'PAYTM' ORDER BY MACOD_CODID";
			cbPAYTM.ValueMember = "MACOD_CODID";
			cbPAYTM.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbPAYTM);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CURCD' ";
			strSQL += " ORDER BY MACOD_CODID ";
			cbCURCD.ValueMember = "MACOD_CODID";
			cbCURCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCURCD);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CNTRY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbCNTRY.ValueMember = "MACOD_CODID";
			cbCNTRY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCNTRY);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'STACD' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbSTACD.ValueMember = "MACOD_CODID";
			cbSTACD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbSTACD);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'SUPTY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbSUPTY.ValueMember = "MACOD_CODID";
			cbSUPTY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbSUPTY);
			strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'TAXCD' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbTAXCD.ValueMember = "MACOD_CODID";
			cbTAXCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbTAXCD);
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			spMAESUP("1");
		}

		public bool spMAESUP(string strPRO)
		{
			bool spMAESUP = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAESUP ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = strSQL + "'" + txtSUPID.Text + "', ";
				strSQL = strSQL + "N'" + txtSUPNM.Text + "', ";
				strSQL = strSQL + "N'" + txtSHORT.Text + "', ";
				strSQL = strSQL + "N'" + txtADDR1.Text + "', ";
				strSQL = strSQL + "N'" + txtADDR2.Text + "', ";
				strSQL = strSQL + "N'" + txtADDR3.Text + "', ";
				strSQL = strSQL + "N'" + txtADDR4.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCNTRY.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSTACD.SelectedValue), "', ")));
				strSQL = strSQL + "'" + Conversions.ToString(numLTIME.Value) + "', ";
				strSQL = strSQL + "'" + txtTEL01.Text + "', ";
				strSQL = strSQL + "'" + txtTEL02.Text + "', ";
				strSQL = strSQL + "'" + txtFAXNO1.Text + "', ";
				strSQL = strSQL + "'" + txtFAXNO2.Text + "', ";
				strSQL = strSQL + "'" + txtCNTPS.Text + "', ";
				strSQL = strSQL + "'" + txtEMAIL.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPAYTM.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPTY.SelectedValue), "',")));
				strSQL = strSQL + Conversions.ToString(0 - (chkSCFG.Checked ? 1 : 0)) + ", ";
				strSQL = strSQL + Conversions.ToString(0 - (chkINTFG.Checked ? 1 : 0)) + ", ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCURCD.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbTAXCD.SelectedValue), "', ")));
				strSQL = strSQL + "'" + txtGSTID.Text + "', ";
				strSQL = strSQL + "'" + txtACCNO.Text + "', ";
				strSQL = strSQL + Conversions.ToString(0 - (chkEXCSYSTAX.Checked ? 1 : 0)) + ", ";
				strSQL = strSQL + "N'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), Conversions.ToString(Interaction.IIf(Operators.CompareString(strPRO, "1", false) == 0, "Record saved!", "Record deleted!"))), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMAESUP = false;
					ProjectData.ClearProjectError();
					goto IL_0439;
				}
				BindComboHeader();
				Header();
				ClearDetails();
			}
			goto IL_0439;
			IL_0439:
			return spMAESUP;
		}

		private void frmMAESUP_FormClosing(object sender, FormClosingEventArgs e)
		{
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

		private void frmMAESUP_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Header();
		}

		private bool BindDatafromDB()
		{
			string strSQL = "MASUP_SUPID, MASUP_SUPNM, MASUP_SHORT, MASUP_ADDR1, MASUP_ADDR2, MASUP_ADDR3, ";
			strSQL += "MASUP_ADDR4, MASUP_CNTRY, MASUP_STACD, MASUP_TEL01, MASUP_TEL02, ";
			strSQL += "MASUP_FAXNO1, MASUP_FAXNO2, MASUP_CNTPS, MASUP_EMAIL, MASUP_PAYTM, ";
			strSQL += "MASUP_LTIME, MASUP_SUPTY, MASUP_SCFG, MASUP_INTFG, MASUP_CURCD, MASUP_TAXCD, MASUP_GSTID, MASUP_ACCNO, ";
			strSQL += "MASUP_EXCSYSTAX, MASUP_REMRK, MASUP_ENTDT, MASUP_ENTBY, MASUP_LUPDT, MASUP_LUPBY ";
			DataTable dt = DB.GetTable(strSQL, "MASUP_TBL", "MASUP_SUPID = '" + txtSUPID.Text + "'", "");
			bool BindDatafromDB;
			try
			{
				if (dt.Rows.Count > 0)
				{
					txtSUPID.Text = dt.Rows[0]["MASUP_SUPID"].ToString();
					txtSUPNM.Text = dt.Rows[0]["MASUP_SUPNM"].ToString();
					txtSHORT.Text = dt.Rows[0]["MASUP_SHORT"].ToString();
					txtADDR1.Text = dt.Rows[0]["MASUP_ADDR1"].ToString();
					txtADDR2.Text = dt.Rows[0]["MASUP_ADDR2"].ToString();
					txtADDR3.Text = dt.Rows[0]["MASUP_ADDR3"].ToString();
					txtADDR4.Text = dt.Rows[0]["MASUP_ADDR4"].ToString();
					cbCNTRY.SelectedValue = dt.Rows[0]["MASUP_CNTRY"].ToString();
					cbSTACD.SelectedValue = dt.Rows[0]["MASUP_STACD"].ToString();
					txtTEL01.Text = dt.Rows[0]["MASUP_TEL01"].ToString();
					txtTEL02.Text = dt.Rows[0]["MASUP_TEL02"].ToString();
					txtFAXNO1.Text = dt.Rows[0]["MASUP_FAXNO1"].ToString();
					txtFAXNO2.Text = dt.Rows[0]["MASUP_FAXNO2"].ToString();
					txtCNTPS.Text = dt.Rows[0]["MASUP_CNTPS"].ToString();
					txtEMAIL.Text = dt.Rows[0]["MASUP_EMAIL"].ToString();
					cbPAYTM.SelectedValue = dt.Rows[0]["MASUP_PAYTM"].ToString();
					cbSUPTY.SelectedValue = dt.Rows[0]["MASUP_SUPTY"].ToString();
					chkEXCSYSTAX.Checked = Conversions.ToBoolean(dt.Rows[0]["MASUP_EXCSYSTAX"].ToString());
					chkSCFG.Checked = Conversions.ToBoolean(dt.Rows[0]["MASUP_SCFG"].ToString());
					chkINTFG.Checked = Conversions.ToBoolean(dt.Rows[0]["MASUP_INTFG"].ToString());
					cbCURCD.SelectedValue = dt.Rows[0]["MASUP_CURCD"].ToString();
					cbTAXCD.SelectedValue = dt.Rows[0]["MASUP_TAXCD"].ToString();
					txtGSTID.Text = dt.Rows[0]["MASUP_GSTID"].ToString();
					txtACCNO.Text = dt.Rows[0]["MASUP_ACCNO"].ToString();
					txtREMRK.Text = dt.Rows[0]["MASUP_REMRK"].ToString();
					numLTIME.Value = Conversions.ToDouble(dt.Rows[0]["MASUP_LTIME"].ToString());
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				BindDatafromDB = false;
				ProjectData.ClearProjectError();
				goto IL_04b7;
			}
			BindDatafromDB = true;
			goto IL_04b7;
			IL_04b7:
			return BindDatafromDB;
		}

		private void Header()
		{
			int count = dgvMASUP.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvMASUP.Rows.Remove(dgvMASUP.Rows[0]);
				}
				string strSQL = "EXEC spMASUP '0', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDTO.SelectedValue), "'")));
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvMASUP.ClearSelection();
						dgvMASUP.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvMASUP.Rows[dgvMASUP.Rows.Count - 1];
						dataGridViewRow.Cells["MASUP_SUPID"].Value = dt.Rows[i]["MASUP_SUPID"].ToString();
						dataGridViewRow.Cells["MASUP_SUPNM"].Value = dt.Rows[i]["MASUP_SUPNM"].ToString();
						dataGridViewRow.Cells["MASUP_SHORT"].Value = dt.Rows[i]["MASUP_SHORT"].ToString();
						dataGridViewRow.Cells["ADDRNM"].Value = dt.Rows[i]["ADDRNM"].ToString();
						dataGridViewRow.Cells["MASUP_ADDR1"].Value = dt.Rows[i]["MASUP_ADDR1"].ToString();
						dataGridViewRow.Cells["MASUP_ADDR2"].Value = dt.Rows[i]["MASUP_ADDR2"].ToString();
						dataGridViewRow.Cells["MASUP_ADDR3"].Value = dt.Rows[i]["MASUP_ADDR3"].ToString();
						dataGridViewRow.Cells["MASUP_ADDR4"].Value = dt.Rows[i]["MASUP_ADDR4"].ToString();
						dataGridViewRow.Cells["MASUP_CNTRY"].Value = dt.Rows[i]["MASUP_CNTRY"].ToString();
						dataGridViewRow.Cells["MASUP_STACD"].Value = dt.Rows[i]["MASUP_STACD"].ToString();
						dataGridViewRow.Cells["MASUP_TEL01"].Value = dt.Rows[i]["MASUP_TEL01"].ToString();
						dataGridViewRow.Cells["MASUP_TEL02"].Value = dt.Rows[i]["MASUP_TEL02"].ToString();
						dataGridViewRow.Cells["MASUP_FAXNO1"].Value = dt.Rows[i]["MASUP_FAXNO1"].ToString();
						dataGridViewRow.Cells["MASUP_FAXNO2"].Value = dt.Rows[i]["MASUP_FAXNO2"].ToString();
						dataGridViewRow.Cells["MASUP_CNTPS"].Value = dt.Rows[i]["MASUP_CNTPS"].ToString();
						dataGridViewRow.Cells["MASUP_EMAIL"].Value = dt.Rows[i]["MASUP_EMAIL"].ToString();
						dataGridViewRow.Cells["MASUP_PAYTM"].Value = dt.Rows[i]["MASUP_PAYTM"].ToString();
						dataGridViewRow.Cells["MASUP_SUPTY"].Value = dt.Rows[i]["MASUP_SUPTY"].ToString();
						dataGridViewRow.Cells["MASUP_EXCSYSTAX"].Value = dt.Rows[i]["MASUP_EXCSYSTAX"].ToString();
						dataGridViewRow.Cells["MASUP_SCFG"].Value = dt.Rows[i]["MASUP_SCFG"].ToString();
						dataGridViewRow.Cells["MASUP_INTFG"].Value = dt.Rows[i]["MASUP_INTFG"].ToString();
						dataGridViewRow.Cells["MASUP_CURCD"].Value = dt.Rows[i]["MASUP_CURCD"].ToString();
						dataGridViewRow.Cells["MASUP_TAXCD"].Value = dt.Rows[i]["MASUP_TAXCD"].ToString();
						dataGridViewRow.Cells["MASUP_GSTID"].Value = dt.Rows[i]["MASUP_GSTID"].ToString();
						dataGridViewRow.Cells["MASUP_ACCNO"].Value = dt.Rows[i]["MASUP_ACCNO"].ToString();
						dataGridViewRow.Cells["MASUP_REMRK"].Value = dt.Rows[i]["MASUP_REMRK"].ToString();
						dataGridViewRow.Cells["MASUP_LTIME"].Value = dt.Rows[i]["MASUP_LTIME"].ToString();
						dataGridViewRow = null;
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void BindGridToControls()
		{
			txtSUPID.Text = dgvMASUP.CurrentRow.Cells["MASUP_SUPID"].Value.ToString();
			txtSUPNM.Text = dgvMASUP.CurrentRow.Cells["MASUP_SUPNM"].Value.ToString();
			txtSHORT.Text = dgvMASUP.CurrentRow.Cells["MASUP_SHORT"].Value.ToString();
			txtADDR1.Text = dgvMASUP.CurrentRow.Cells["MASUP_ADDR1"].Value.ToString();
			txtADDR2.Text = dgvMASUP.CurrentRow.Cells["MASUP_ADDR2"].Value.ToString();
			txtADDR3.Text = dgvMASUP.CurrentRow.Cells["MASUP_ADDR3"].Value.ToString();
			txtADDR4.Text = dgvMASUP.CurrentRow.Cells["MASUP_ADDR4"].Value.ToString();
			cbCNTRY.SelectedValue = dgvMASUP.CurrentRow.Cells["MASUP_CNTRY"].Value.ToString();
			cbSTACD.SelectedValue = dgvMASUP.CurrentRow.Cells["MASUP_STACD"].Value.ToString();
			txtTEL01.Text = dgvMASUP.CurrentRow.Cells["MASUP_TEL01"].Value.ToString();
			txtTEL02.Text = dgvMASUP.CurrentRow.Cells["MASUP_TEL02"].Value.ToString();
			txtFAXNO1.Text = dgvMASUP.CurrentRow.Cells["MASUP_FAXNO1"].Value.ToString();
			txtFAXNO2.Text = dgvMASUP.CurrentRow.Cells["MASUP_FAXNO2"].Value.ToString();
			txtCNTPS.Text = dgvMASUP.CurrentRow.Cells["MASUP_CNTPS"].Value.ToString();
			txtEMAIL.Text = dgvMASUP.CurrentRow.Cells["MASUP_EMAIL"].Value.ToString();
			cbPAYTM.SelectedValue = dgvMASUP.CurrentRow.Cells["MASUP_PAYTM"].Value.ToString();
			cbSUPTY.SelectedValue = dgvMASUP.CurrentRow.Cells["MASUP_SUPTY"].Value.ToString();
			chkEXCSYSTAX.Checked = Conversions.ToBoolean(dgvMASUP.CurrentRow.Cells["MASUP_EXCSYSTAX"].Value);
			chkSCFG.Checked = Conversions.ToBoolean(dgvMASUP.CurrentRow.Cells["MASUP_SCFG"].Value);
			chkINTFG.Checked = Conversions.ToBoolean(dgvMASUP.CurrentRow.Cells["MASUP_INTFG"].Value);
			cbCURCD.SelectedValue = dgvMASUP.CurrentRow.Cells["MASUP_CURCD"].Value.ToString();
			cbTAXCD.SelectedValue = dgvMASUP.CurrentRow.Cells["MASUP_TAXCD"].Value.ToString();
			txtGSTID.Text = dgvMASUP.CurrentRow.Cells["MASUP_GSTID"].Value.ToString();
			txtACCNO.Text = dgvMASUP.CurrentRow.Cells["MASUP_ACCNO"].Value.ToString();
			txtREMRK.Text = dgvMASUP.CurrentRow.Cells["MASUP_REMRK"].Value.ToString();
			numLTIME.Value = Conversions.ToDouble(dgvMASUP.CurrentRow.Cells["MASUP_LTIME"].Value.ToString());
		}

		private void dgvMASUP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Panel2.Visible = false;
			Panel1.Visible = true;
			btnSAVE.Tag = "Update";
			btnDelete.Enabled = true;
			btnCancel.Enabled = true;
			btnPrint.Enabled = true;
			txtSUPID.Enabled = false;
			BindComboBox();
			BindGridToControls();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID");
			strMSG = strMSG + " : " + txtSUPID.Text + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Name");
			strMSG = strMSG + " : " + txtSUPNM.Text;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spMAESUP("2");
				ClearDetails();
				BindComboHeader();
				Header();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			Header();
			btnCancel.Enabled = true;
			btnDelete.Enabled = true;
			btnPrint.Enabled = true;
		}

		public void ClearDetails()
		{
			txtSUPID.Enabled = true;
			txtSUPID.Text = string.Empty;
			txtSUPNM.Text = string.Empty;
			txtSHORT.Text = string.Empty;
			txtADDR1.Text = string.Empty;
			txtADDR2.Text = string.Empty;
			txtADDR3.Text = string.Empty;
			txtADDR4.Text = string.Empty;
			cbCNTRY.SelectedIndex = -1;
			cbSTACD.SelectedIndex = -1;
			txtTEL01.Text = string.Empty;
			txtTEL02.Text = string.Empty;
			txtFAXNO1.Text = string.Empty;
			txtFAXNO2.Text = string.Empty;
			txtCNTPS.Text = string.Empty;
			txtEMAIL.Text = string.Empty;
			cbPAYTM.SelectedIndex = -1;
			cbSUPTY.SelectedIndex = -1;
			chkEXCSYSTAX.Checked = false;
			chkSCFG.Checked = false;
			chkINTFG.Checked = false;
			cbCURCD.SelectedIndex = -1;
			cbTAXCD.SelectedIndex = -1;
			txtGSTID.Text = string.Empty;
			txtACCNO.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			numLTIME.Value = 0.0;
			btnSAVE.Tag = "Save";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			BindDatafromDB();
		}

		public bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtSUPID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtSUPID.Focus();
				return false;
			}
			if (Operators.CompareString(txtSUPNM.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Name cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtSUPNM.Focus();
				return false;
			}
			string strSQL = "SELECT MASUP_SUPID FROM MASUP_TBL WHERE MASUP_SUPID = '" + txtSUPID.Text + "'";
			if (Operators.ConditionalCompareObjectEqual(btnSAVE.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtSUPID.Focus();
				return false;
			}
			return true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		public void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "SUPPLIER MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMASUP.rpt";
			if (Operators.CompareString(txtSUPID.Text.Trim(), "", false) != 0)
			{
				frmRPT.Params = ("@PAR=1 ,@SUPIDFR=" + txtSUPID.Text + ",@SUPIDTO=" + txtSUPID.Text) ?? "";
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1 ,@SUPIDFR=", cbSUPIDFR.SelectedValue), ",@SUPIDTO="), cbSUPIDTO.SelectedValue), ""));
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='SUPPLIER MASTER'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPrintfr_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAESUP_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbSUPIDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbSUPIDFR.SelectedIndex != -1)
			{
				cbSUPIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbSUPIDFR.SelectedValue);
			}
		}
	}
}
