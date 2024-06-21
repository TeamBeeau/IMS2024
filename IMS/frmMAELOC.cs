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
	public class frmMAELOC : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMALOC")]
		private DataGridView _dgvMALOC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNEW")]
		private Button _btnNEW;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

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
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINFR")]
		private Button _btnPRINFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbLOCIDFR")]
		private ComboBox _cbLOCIDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbHLOCTY")]
		private ComboBox _cbHLOCTY;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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

		[field: AccessedThroughProperty("lblADDR1")]
		internal virtual Label lblADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLOCID")]
		internal virtual Label lblLOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLOCNM")]
		internal virtual Label lblLOCNM
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

		[field: AccessedThroughProperty("txtLOCNM")]
		internal virtual TextBox txtLOCNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtLOCID")]
		internal virtual TextBox txtLOCID
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

		[field: AccessedThroughProperty("lblTEL01")]
		internal virtual Label lblTEL01
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

		[field: AccessedThroughProperty("lblCNTPS")]
		internal virtual Label lblCNTPS
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

		internal virtual DataGridView dgvMALOC
		{
			[CompilerGenerated]
			get
			{
				return _dgvMALOC;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMALOC_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMALOC;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMALOC = value;
				dataGridView = _dgvMALOC;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLOCIDTO")]
		internal virtual Label lblLOCIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLOCIDFR")]
		internal virtual Label lblLOCIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnNEW
		{
			[CompilerGenerated]
			get
			{
				return _btnNEW;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnNEW_Click;
				Button button = _btnNEW;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnNEW = value;
				button = _btnNEW;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
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

		[field: AccessedThroughProperty("lblFAXNO1")]
		internal virtual Label lblFAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnPRINT
		{
			[CompilerGenerated]
			get
			{
				return _btnPRINT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPRINT_Click;
				Button button = _btnPRINT;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPRINT = value;
				button = _btnPRINT;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnPRINFR
		{
			[CompilerGenerated]
			get
			{
				return _btnPRINFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPRINFR_Click;
				Button button = _btnPRINFR;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPRINFR = value;
				button = _btnPRINFR;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("chkACTFG")]
		internal virtual CheckBox chkACTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbLOCIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbLOCIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbLOCIDFR_SelectedIndexChanged;
				ComboBox comboBox = _cbLOCIDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbLOCIDFR = value;
				comboBox = _cbLOCIDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbLOCIDTO")]
		internal virtual ComboBox cbLOCIDTO
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

		[field: AccessedThroughProperty("cbSTACD")]
		internal virtual ComboBox cbSTACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cboMRPFG")]
		internal virtual ComboBox cboMRPFG
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

		internal virtual ComboBox cbHLOCTY
		{
			[CompilerGenerated]
			get
			{
				return _cbHLOCTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbHLOCTY_SelectedIndexChanged;
				ComboBox comboBox = _cbHLOCTY;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbHLOCTY = value;
				comboBox = _cbHLOCTY;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
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

		[field: AccessedThroughProperty("cbLOCTY")]
		internal virtual ComboBox cbLOCTY
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

		[field: AccessedThroughProperty("cbROUCD")]
		internal virtual ComboBox cbROUCD
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

		[field: AccessedThroughProperty("cbMCHID")]
		internal virtual ComboBox cbMCHID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_LOCID")]
		internal virtual DataGridViewTextBoxColumn MALOC_LOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_LOCNM")]
		internal virtual DataGridViewTextBoxColumn MALOC_LOCNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_LOCTY")]
		internal virtual DataGridViewTextBoxColumn MALOC_LOCTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_ADDR1")]
		internal virtual DataGridViewTextBoxColumn MALOC_ADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_ADDR2")]
		internal virtual DataGridViewTextBoxColumn MALOC_ADDR2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_ADDR3")]
		internal virtual DataGridViewTextBoxColumn MALOC_ADDR3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_ADDR4")]
		internal virtual DataGridViewTextBoxColumn MALOC_ADDR4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_CNTRY")]
		internal virtual DataGridViewTextBoxColumn MALOC_CNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_STACD")]
		internal virtual DataGridViewTextBoxColumn MALOC_STACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_TEL01")]
		internal virtual DataGridViewTextBoxColumn MALOC_TEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_TEL02")]
		internal virtual DataGridViewTextBoxColumn MALOC_TEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_FAXNO1")]
		internal virtual DataGridViewTextBoxColumn MALOC_FAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_FAXNO2")]
		internal virtual DataGridViewTextBoxColumn MALOC_FAXNO2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_CNTPS")]
		internal virtual DataGridViewTextBoxColumn MALOC_CNTPS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_EMAIL")]
		internal virtual DataGridViewTextBoxColumn MALOC_EMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_MRPFG")]
		internal virtual DataGridViewTextBoxColumn MALOC_MRPFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_ROUCD")]
		internal virtual DataGridViewTextBoxColumn MALOC_ROUCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_MCHID")]
		internal virtual DataGridViewTextBoxColumn MALOC_MCHID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_REMRK")]
		internal virtual DataGridViewTextBoxColumn MALOC_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MALOC_ACTFG")]
		internal virtual DataGridViewTextBoxColumn MALOC_ACTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("ACTFG")]
		internal virtual DataGridViewTextBoxColumn ACTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAELOC()
		{
			base.FormClosing += frmMAELOC_FormClosing;
			base.Shown += frmMAELOC_Shown;
			base.KeyDown += frmMAELOC_KeyDown;
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
			this.Label4 = new System.Windows.Forms.Label();
			this.cbLOCTY = new System.Windows.Forms.ComboBox();
			this.cboMRPFG = new System.Windows.Forms.ComboBox();
			this.cbSTACD = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbCNTRY = new System.Windows.Forms.ComboBox();
			this.chkACTFG = new System.Windows.Forms.CheckBox();
			this.txtEMAIL = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtFAXNO2 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.txtFAXNO1 = new System.Windows.Forms.TextBox();
			this.txtTEL02 = new System.Windows.Forms.TextBox();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblEMAIL = new System.Windows.Forms.Label();
			this.lblCNTPS = new System.Windows.Forms.Label();
			this.lblFAXNO1 = new System.Windows.Forms.Label();
			this.lblTEL02 = new System.Windows.Forms.Label();
			this.lblTEL01 = new System.Windows.Forms.Label();
			this.txtADDR4 = new System.Windows.Forms.TextBox();
			this.txtADDR3 = new System.Windows.Forms.TextBox();
			this.txtADDR2 = new System.Windows.Forms.TextBox();
			this.txtADDR1 = new System.Windows.Forms.TextBox();
			this.txtLOCNM = new System.Windows.Forms.TextBox();
			this.txtLOCID = new System.Windows.Forms.TextBox();
			this.lblSTACD = new System.Windows.Forms.Label();
			this.lblCNTRY = new System.Windows.Forms.Label();
			this.lblADDR1 = new System.Windows.Forms.Label();
			this.lblLOCNM = new System.Windows.Forms.Label();
			this.lblLOCID = new System.Windows.Forms.Label();
			this.txtTEL01 = new System.Windows.Forms.TextBox();
			this.txtCNTPS = new System.Windows.Forms.TextBox();
			this.btnPRINFR = new System.Windows.Forms.Button();
			this.btnNEW = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbHLOCTY = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cbLOCIDTO = new System.Windows.Forms.ComboBox();
			this.cbLOCIDFR = new System.Windows.Forms.ComboBox();
			this.lblLOCIDTO = new System.Windows.Forms.Label();
			this.lblLOCIDFR = new System.Windows.Forms.Label();
			this.dgvMALOC = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.cbROUCD = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.cbMCHID = new System.Windows.Forms.ComboBox();
			this.MALOC_LOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_LOCNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_LOCTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_ADDR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_ADDR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_ADDR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_ADDR4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_CNTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_STACD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_TEL01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_TEL02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_FAXNO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_FAXNO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_CNTPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_MRPFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_ROUCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_MCHID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MALOC_ACTFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ACTFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMALOC).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbMCHID, 3, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbLOCTY, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.cboMRPFG, 1, 15);
			this.TableLayoutPanel1.Controls.Add(this.cbSTACD, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 15);
			this.TableLayoutPanel1.Controls.Add(this.cbCNTRY, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.chkACTFG, 1, 18);
			this.TableLayoutPanel1.Controls.Add(this.txtEMAIL, 1, 14);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 20);
			this.TableLayoutPanel1.Controls.Add(this.txtFAXNO2, 1, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 12);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 17);
			this.TableLayoutPanel1.Controls.Add(this.txtFAXNO1, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.txtTEL02, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 17);
			this.TableLayoutPanel1.Controls.Add(this.lblEMAIL, 0, 14);
			this.TableLayoutPanel1.Controls.Add(this.lblCNTPS, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.lblFAXNO1, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.lblTEL02, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.lblTEL01, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR4, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR3, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR2, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR1, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtLOCNM, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtLOCID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblSTACD, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.lblCNTRY, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.lblADDR1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblLOCNM, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblLOCID, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtTEL01, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtCNTPS, 1, 13);
			this.TableLayoutPanel1.Controls.Add(this.cbROUCD, 1, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 2, 16);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 7);
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(754, 694);
			this.TableLayoutPanel1.TabIndex = 0;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 71);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(114, 20);
			this.Label4.TabIndex = 30;
			this.Label4.Text = "Location Type";
			this.cbLOCTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCTY.FormattingEnabled = true;
			this.cbLOCTY.Location = new System.Drawing.Point(134, 67);
			this.cbLOCTY.Name = "cbLOCTY";
			this.cbLOCTY.Size = new System.Drawing.Size(214, 28);
			this.cbLOCTY.TabIndex = 29;
			this.cboMRPFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cboMRPFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMRPFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cboMRPFG.FormattingEnabled = true;
			this.cboMRPFG.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cboMRPFG.Location = new System.Drawing.Point(134, 489);
			this.cboMRPFG.Name = "cboMRPFG";
			this.cboMRPFG.Size = new System.Drawing.Size(120, 28);
			this.cboMRPFG.TabIndex = 15;
			this.cbSTACD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTACD.FormattingEnabled = true;
			this.cbSTACD.Location = new System.Drawing.Point(134, 263);
			this.cbSTACD.Name = "cbSTACD";
			this.cbSTACD.Size = new System.Drawing.Size(214, 28);
			this.cbSTACD.TabIndex = 27;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(4, 493);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(46, 20);
			this.Label2.TabIndex = 16;
			this.Label2.Text = "MRP";
			this.cbCNTRY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCNTRY.FormattingEnabled = true;
			this.cbCNTRY.Location = new System.Drawing.Point(134, 229);
			this.cbCNTRY.Name = "cbCNTRY";
			this.cbCNTRY.Size = new System.Drawing.Size(214, 28);
			this.cbCNTRY.TabIndex = 26;
			this.chkACTFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkACTFG.AutoSize = true;
			this.chkACTFG.Checked = true;
			this.chkACTFG.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkACTFG.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkACTFG.Location = new System.Drawing.Point(134, 589);
			this.chkACTFG.Name = "chkACTFG";
			this.chkACTFG.Size = new System.Drawing.Size(146, 24);
			this.chkACTFG.TabIndex = 1;
			this.chkACTFG.Text = "Active Location";
			this.chkACTFG.UseVisualStyleBackColor = true;
			this.txtEMAIL.Location = new System.Drawing.Point(134, 457);
			this.txtEMAIL.Name = "txtEMAIL";
			this.txtEMAIL.Size = new System.Drawing.Size(236, 26);
			this.txtEMAIL.TabIndex = 13;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 5;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnBack, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 638);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel3.TabIndex = 19;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(507, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 20;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(3, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 16;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 18;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(381, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 19;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(129, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.txtFAXNO2.Location = new System.Drawing.Point(134, 393);
			this.txtFAXNO2.Name = "txtFAXNO2";
			this.txtFAXNO2.Size = new System.Drawing.Size(236, 26);
			this.txtFAXNO2.TabIndex = 12;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 396);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(76, 20);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "Fax No 2";
			this.txtREMRK.Location = new System.Drawing.Point(134, 557);
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(236, 26);
			this.txtREMRK.TabIndex = 15;
			this.txtFAXNO1.Location = new System.Drawing.Point(134, 361);
			this.txtFAXNO1.Name = "txtFAXNO1";
			this.txtFAXNO1.Size = new System.Drawing.Size(236, 26);
			this.txtFAXNO1.TabIndex = 11;
			this.txtTEL02.Location = new System.Drawing.Point(134, 329);
			this.txtTEL02.Name = "txtTEL02";
			this.txtTEL02.Size = new System.Drawing.Size(236, 26);
			this.txtTEL02.TabIndex = 10;
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 560);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(67, 20);
			this.lblREMRK.TabIndex = 18;
			this.lblREMRK.Text = "Remark";
			this.lblEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEMAIL.AutoSize = true;
			this.lblEMAIL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEMAIL.Location = new System.Drawing.Point(3, 460);
			this.lblEMAIL.Name = "lblEMAIL";
			this.lblEMAIL.Size = new System.Drawing.Size(51, 20);
			this.lblEMAIL.TabIndex = 19;
			this.lblEMAIL.Text = "Email";
			this.lblCNTPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTPS.AutoSize = true;
			this.lblCNTPS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTPS.Location = new System.Drawing.Point(3, 428);
			this.lblCNTPS.Name = "lblCNTPS";
			this.lblCNTPS.Size = new System.Drawing.Size(125, 20);
			this.lblCNTPS.TabIndex = 20;
			this.lblCNTPS.Text = "Contact Person";
			this.lblFAXNO1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFAXNO1.AutoSize = true;
			this.lblFAXNO1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFAXNO1.Location = new System.Drawing.Point(3, 364);
			this.lblFAXNO1.Name = "lblFAXNO1";
			this.lblFAXNO1.Size = new System.Drawing.Size(76, 20);
			this.lblFAXNO1.TabIndex = 21;
			this.lblFAXNO1.Text = "Fax No 1";
			this.lblTEL02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL02.AutoSize = true;
			this.lblTEL02.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL02.Location = new System.Drawing.Point(3, 332);
			this.lblTEL02.Name = "lblTEL02";
			this.lblTEL02.Size = new System.Drawing.Size(46, 20);
			this.lblTEL02.TabIndex = 22;
			this.lblTEL02.Text = "Tel 2";
			this.lblTEL01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL01.AutoSize = true;
			this.lblTEL01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL01.Location = new System.Drawing.Point(3, 300);
			this.lblTEL01.Name = "lblTEL01";
			this.lblTEL01.Size = new System.Drawing.Size(46, 20);
			this.lblTEL01.TabIndex = 15;
			this.lblTEL01.Text = "Tel 1";
			this.txtADDR4.Location = new System.Drawing.Point(134, 197);
			this.txtADDR4.Name = "txtADDR4";
			this.txtADDR4.Size = new System.Drawing.Size(236, 26);
			this.txtADDR4.TabIndex = 6;
			this.txtADDR3.Location = new System.Drawing.Point(134, 165);
			this.txtADDR3.Name = "txtADDR3";
			this.txtADDR3.Size = new System.Drawing.Size(236, 26);
			this.txtADDR3.TabIndex = 5;
			this.txtADDR2.Location = new System.Drawing.Point(134, 133);
			this.txtADDR2.Name = "txtADDR2";
			this.txtADDR2.Size = new System.Drawing.Size(236, 26);
			this.txtADDR2.TabIndex = 4;
			this.txtADDR1.Location = new System.Drawing.Point(134, 101);
			this.txtADDR1.Name = "txtADDR1";
			this.txtADDR1.Size = new System.Drawing.Size(236, 26);
			this.txtADDR1.TabIndex = 3;
			this.txtLOCNM.Location = new System.Drawing.Point(134, 35);
			this.txtLOCNM.Name = "txtLOCNM";
			this.txtLOCNM.Size = new System.Drawing.Size(236, 26);
			this.txtLOCNM.TabIndex = 2;
			this.txtLOCID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtLOCID.Location = new System.Drawing.Point(134, 3);
			this.txtLOCID.Name = "txtLOCID";
			this.txtLOCID.Size = new System.Drawing.Size(236, 26);
			this.txtLOCID.TabIndex = 1;
			this.lblSTACD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTACD.AutoSize = true;
			this.lblSTACD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTACD.Location = new System.Drawing.Point(3, 267);
			this.lblSTACD.Name = "lblSTACD";
			this.lblSTACD.Size = new System.Drawing.Size(48, 20);
			this.lblSTACD.TabIndex = 4;
			this.lblSTACD.Text = "State";
			this.lblCNTRY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTRY.AutoSize = true;
			this.lblCNTRY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTRY.Location = new System.Drawing.Point(3, 233);
			this.lblCNTRY.Name = "lblCNTRY";
			this.lblCNTRY.Size = new System.Drawing.Size(67, 20);
			this.lblCNTRY.TabIndex = 3;
			this.lblCNTRY.Text = "Country";
			this.lblADDR1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblADDR1.AutoSize = true;
			this.lblADDR1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblADDR1.Location = new System.Drawing.Point(3, 104);
			this.lblADDR1.Name = "lblADDR1";
			this.lblADDR1.Size = new System.Drawing.Size(85, 20);
			this.lblADDR1.TabIndex = 6;
			this.lblADDR1.Text = "Address 1";
			this.lblLOCNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLOCNM.AutoSize = true;
			this.lblLOCNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLOCNM.Location = new System.Drawing.Point(3, 38);
			this.lblLOCNM.Name = "lblLOCNM";
			this.lblLOCNM.Size = new System.Drawing.Size(122, 20);
			this.lblLOCNM.TabIndex = 7;
			this.lblLOCNM.Text = "Location Name";
			this.lblLOCID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLOCID.AutoSize = true;
			this.lblLOCID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLOCID.Location = new System.Drawing.Point(3, 6);
			this.lblLOCID.Name = "lblLOCID";
			this.lblLOCID.Size = new System.Drawing.Size(95, 20);
			this.lblLOCID.TabIndex = 1;
			this.lblLOCID.Text = "Location ID";
			this.txtTEL01.Location = new System.Drawing.Point(134, 297);
			this.txtTEL01.Name = "txtTEL01";
			this.txtTEL01.Size = new System.Drawing.Size(236, 26);
			this.txtTEL01.TabIndex = 9;
			this.txtCNTPS.Location = new System.Drawing.Point(134, 425);
			this.txtCNTPS.Name = "txtCNTPS";
			this.txtCNTPS.Size = new System.Drawing.Size(236, 26);
			this.txtCNTPS.TabIndex = 14;
			this.btnPRINFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINFR.Location = new System.Drawing.Point(255, 2);
			this.btnPRINFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINFR.Name = "btnPRINFR";
			this.btnPRINFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINFR.TabIndex = 5;
			this.btnPRINFR.Text = "Print";
			this.btnPRINFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINFR.UseVisualStyleBackColor = false;
			this.btnNEW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNEW.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNEW.Image = IMS.My.Resources.Resources._New;
			this.btnNEW.Location = new System.Drawing.Point(129, 2);
			this.btnNEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNEW.Name = "btnNEW";
			this.btnNEW.Size = new System.Drawing.Size(120, 50);
			this.btnNEW.TabIndex = 4;
			this.btnNEW.Text = "New";
			this.btnNEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNEW.UseVisualStyleBackColor = false;
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
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbHLOCTY, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label3, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCIDTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblLOCIDTO, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblLOCIDFR, 0, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 2;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(594, 68);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbHLOCTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHLOCTY.FormattingEnabled = true;
			this.cbHLOCTY.Location = new System.Drawing.Point(123, 3);
			this.cbHLOCTY.Name = "cbHLOCTY";
			this.cbHLOCTY.Size = new System.Drawing.Size(214, 28);
			this.cbHLOCTY.TabIndex = 28;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 7);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(114, 20);
			this.Label3.TabIndex = 27;
			this.Label3.Text = "Location Type";
			this.cbLOCIDTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCIDTO.FormattingEnabled = true;
			this.cbLOCIDTO.Location = new System.Drawing.Point(377, 37);
			this.cbLOCIDTO.Name = "cbLOCIDTO";
			this.cbLOCIDTO.Size = new System.Drawing.Size(214, 28);
			this.cbLOCIDTO.TabIndex = 26;
			this.cbLOCIDFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCIDFR.FormattingEnabled = true;
			this.cbLOCIDFR.Location = new System.Drawing.Point(123, 37);
			this.cbLOCIDFR.Name = "cbLOCIDFR";
			this.cbLOCIDFR.Size = new System.Drawing.Size(214, 28);
			this.cbLOCIDFR.TabIndex = 25;
			this.lblLOCIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLOCIDTO.AutoSize = true;
			this.lblLOCIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLOCIDTO.Location = new System.Drawing.Point(343, 41);
			this.lblLOCIDTO.Name = "lblLOCIDTO";
			this.lblLOCIDTO.Size = new System.Drawing.Size(28, 20);
			this.lblLOCIDTO.TabIndex = 4;
			this.lblLOCIDTO.Text = "To";
			this.lblLOCIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLOCIDFR.AutoSize = true;
			this.lblLOCIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLOCIDFR.Location = new System.Drawing.Point(3, 41);
			this.lblLOCIDFR.Name = "lblLOCIDFR";
			this.lblLOCIDFR.Size = new System.Drawing.Size(95, 20);
			this.lblLOCIDFR.TabIndex = 2;
			this.lblLOCIDFR.Text = "Location ID";
			this.dgvMALOC.AllowUserToAddRows = false;
			this.dgvMALOC.AllowUserToDeleteRows = false;
			this.dgvMALOC.AllowUserToResizeRows = false;
			this.dgvMALOC.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMALOC.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMALOC.ColumnHeadersHeight = 29;
			this.dgvMALOC.Columns.AddRange(this.MALOC_LOCID, this.MALOC_LOCNM, this.MALOC_LOCTY, this.MALOC_ADDR1, this.MALOC_ADDR2, this.MALOC_ADDR3, this.MALOC_ADDR4, this.MALOC_CNTRY, this.MALOC_STACD, this.MALOC_TEL01, this.MALOC_TEL02, this.MALOC_FAXNO1, this.MALOC_FAXNO2, this.MALOC_CNTPS, this.MALOC_EMAIL, this.MALOC_MRPFG, this.MALOC_ROUCD, this.MALOC_MCHID, this.MALOC_REMRK, this.MALOC_ACTFG, this.ACTFG);
			this.dgvMALOC.Location = new System.Drawing.Point(5, 126);
			this.dgvMALOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMALOC.MultiSelect = false;
			this.dgvMALOC.Name = "dgvMALOC";
			this.dgvMALOC.ReadOnly = true;
			this.dgvMALOC.RowHeadersVisible = false;
			this.dgvMALOC.RowHeadersWidth = 10;
			this.dgvMALOC.RowTemplate.Height = 24;
			this.dgvMALOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMALOC.Size = new System.Drawing.Size(1318, 494);
			this.dgvMALOC.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 713);
			this.Panel1.TabIndex = 20;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvMALOC);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 713);
			this.Panel2.TabIndex = 21;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNEW, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINFR, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(4, 69);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel4.TabIndex = 6;
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
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(377, 527);
			this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(131, 20);
			this.Label5.TabIndex = 31;
			this.Label5.Text = "Default Machine";
			this.cbROUCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbROUCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbROUCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbROUCD.FormattingEnabled = true;
			this.cbROUCD.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cbROUCD.Location = new System.Drawing.Point(134, 523);
			this.cbROUCD.Name = "cbROUCD";
			this.cbROUCD.Size = new System.Drawing.Size(236, 28);
			this.cbROUCD.TabIndex = 32;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(4, 527);
			this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(112, 20);
			this.Label6.TabIndex = 33;
			this.Label6.Text = "Default Route";
			this.cbMCHID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbMCHID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMCHID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbMCHID.FormattingEnabled = true;
			this.cbMCHID.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cbMCHID.Location = new System.Drawing.Point(515, 523);
			this.cbMCHID.Name = "cbMCHID";
			this.cbMCHID.Size = new System.Drawing.Size(236, 28);
			this.cbMCHID.TabIndex = 34;
			this.MALOC_LOCID.HeaderText = "Location ID";
			this.MALOC_LOCID.MinimumWidth = 6;
			this.MALOC_LOCID.Name = "MALOC_LOCID";
			this.MALOC_LOCID.ReadOnly = true;
			this.MALOC_LOCID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_LOCID.Width = 109;
			this.MALOC_LOCNM.HeaderText = "Location Name";
			this.MALOC_LOCNM.MinimumWidth = 6;
			this.MALOC_LOCNM.Name = "MALOC_LOCNM";
			this.MALOC_LOCNM.ReadOnly = true;
			this.MALOC_LOCNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_LOCNM.Width = 200;
			this.MALOC_LOCTY.HeaderText = "Type";
			this.MALOC_LOCTY.MinimumWidth = 6;
			this.MALOC_LOCTY.Name = "MALOC_LOCTY";
			this.MALOC_LOCTY.ReadOnly = true;
			this.MALOC_LOCTY.Width = 80;
			this.MALOC_ADDR1.HeaderText = "Address 1";
			this.MALOC_ADDR1.MinimumWidth = 6;
			this.MALOC_ADDR1.Name = "MALOC_ADDR1";
			this.MALOC_ADDR1.ReadOnly = true;
			this.MALOC_ADDR1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_ADDR1.Width = 200;
			this.MALOC_ADDR2.HeaderText = "Address 2";
			this.MALOC_ADDR2.MinimumWidth = 6;
			this.MALOC_ADDR2.Name = "MALOC_ADDR2";
			this.MALOC_ADDR2.ReadOnly = true;
			this.MALOC_ADDR2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_ADDR2.Width = 200;
			this.MALOC_ADDR3.HeaderText = "Address 3";
			this.MALOC_ADDR3.MinimumWidth = 6;
			this.MALOC_ADDR3.Name = "MALOC_ADDR3";
			this.MALOC_ADDR3.ReadOnly = true;
			this.MALOC_ADDR3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_ADDR3.Width = 200;
			this.MALOC_ADDR4.HeaderText = "Address 4";
			this.MALOC_ADDR4.MinimumWidth = 6;
			this.MALOC_ADDR4.Name = "MALOC_ADDR4";
			this.MALOC_ADDR4.ReadOnly = true;
			this.MALOC_ADDR4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_ADDR4.Width = 200;
			this.MALOC_CNTRY.HeaderText = "Country";
			this.MALOC_CNTRY.MinimumWidth = 6;
			this.MALOC_CNTRY.Name = "MALOC_CNTRY";
			this.MALOC_CNTRY.ReadOnly = true;
			this.MALOC_CNTRY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_CNTRY.Width = 125;
			this.MALOC_STACD.HeaderText = "State";
			this.MALOC_STACD.MinimumWidth = 6;
			this.MALOC_STACD.Name = "MALOC_STACD";
			this.MALOC_STACD.ReadOnly = true;
			this.MALOC_STACD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_STACD.Width = 125;
			this.MALOC_TEL01.HeaderText = "Tel 01";
			this.MALOC_TEL01.MinimumWidth = 6;
			this.MALOC_TEL01.Name = "MALOC_TEL01";
			this.MALOC_TEL01.ReadOnly = true;
			this.MALOC_TEL01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_TEL01.Width = 125;
			this.MALOC_TEL02.HeaderText = "Tel 02";
			this.MALOC_TEL02.MinimumWidth = 6;
			this.MALOC_TEL02.Name = "MALOC_TEL02";
			this.MALOC_TEL02.ReadOnly = true;
			this.MALOC_TEL02.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_TEL02.Width = 125;
			this.MALOC_FAXNO1.HeaderText = "Fax No 1";
			this.MALOC_FAXNO1.MinimumWidth = 6;
			this.MALOC_FAXNO1.Name = "MALOC_FAXNO1";
			this.MALOC_FAXNO1.ReadOnly = true;
			this.MALOC_FAXNO1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_FAXNO1.Width = 125;
			this.MALOC_FAXNO2.HeaderText = "Fax No 2";
			this.MALOC_FAXNO2.MinimumWidth = 6;
			this.MALOC_FAXNO2.Name = "MALOC_FAXNO2";
			this.MALOC_FAXNO2.ReadOnly = true;
			this.MALOC_FAXNO2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_FAXNO2.Width = 125;
			this.MALOC_CNTPS.HeaderText = "Contact Person";
			this.MALOC_CNTPS.MinimumWidth = 6;
			this.MALOC_CNTPS.Name = "MALOC_CNTPS";
			this.MALOC_CNTPS.ReadOnly = true;
			this.MALOC_CNTPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_CNTPS.Width = 125;
			this.MALOC_EMAIL.HeaderText = "Email";
			this.MALOC_EMAIL.MinimumWidth = 6;
			this.MALOC_EMAIL.Name = "MALOC_EMAIL";
			this.MALOC_EMAIL.ReadOnly = true;
			this.MALOC_EMAIL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_EMAIL.Width = 125;
			this.MALOC_MRPFG.HeaderText = "MRPFG";
			this.MALOC_MRPFG.MinimumWidth = 6;
			this.MALOC_MRPFG.Name = "MALOC_MRPFG";
			this.MALOC_MRPFG.ReadOnly = true;
			this.MALOC_MRPFG.Visible = false;
			this.MALOC_MRPFG.Width = 125;
			this.MALOC_ROUCD.HeaderText = "Route";
			this.MALOC_ROUCD.MinimumWidth = 6;
			this.MALOC_ROUCD.Name = "MALOC_ROUCD";
			this.MALOC_ROUCD.ReadOnly = true;
			this.MALOC_ROUCD.Visible = false;
			this.MALOC_ROUCD.Width = 125;
			this.MALOC_MCHID.HeaderText = "Machine ID";
			this.MALOC_MCHID.MinimumWidth = 6;
			this.MALOC_MCHID.Name = "MALOC_MCHID";
			this.MALOC_MCHID.ReadOnly = true;
			this.MALOC_MCHID.Visible = false;
			this.MALOC_MCHID.Width = 125;
			this.MALOC_REMRK.HeaderText = "Remarks";
			this.MALOC_REMRK.MinimumWidth = 6;
			this.MALOC_REMRK.Name = "MALOC_REMRK";
			this.MALOC_REMRK.ReadOnly = true;
			this.MALOC_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MALOC_REMRK.Width = 200;
			this.MALOC_ACTFG.HeaderText = "MALOC_ACTFG";
			this.MALOC_ACTFG.MinimumWidth = 6;
			this.MALOC_ACTFG.Name = "MALOC_ACTFG";
			this.MALOC_ACTFG.ReadOnly = true;
			this.MALOC_ACTFG.Visible = false;
			this.MALOC_ACTFG.Width = 125;
			this.ACTFG.HeaderText = "Active?";
			this.ACTFG.MinimumWidth = 6;
			this.ACTFG.Name = "ACTFG";
			this.ACTFG.ReadOnly = true;
			this.ACTFG.Width = 125;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 714);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAELOC";
			base.Tag = "MAELOC";
			this.Text = "Location";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMALOC).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void frmMAELOC_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAELOC_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			BindComboBox();
			Header();
		}

		private void BindComboHeader()
		{
			string strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'LOCTY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbHLOCTY.ValueMember = "MACOD_CODID";
			cbHLOCTY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbHLOCTY);
			strSQL = "SELECT '' as MALOC_LOCID, '' as MALOC_LOCNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCIDFR.ValueMember = "MALOC_LOCID";
			cbLOCIDFR.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCIDFR);
			cbLOCIDTO.ValueMember = "MALOC_LOCID";
			cbLOCIDTO.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCIDTO);
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'LOCTY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbLOCTY.ValueMember = "MACOD_CODID";
			cbLOCTY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCTY);
			strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CNTRY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbCNTRY.ValueMember = "MACOD_CODID";
			cbCNTRY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCNTRY);
			strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'STACD' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbSTACD.ValueMember = "MACOD_CODID";
			cbSTACD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbSTACD);
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'MRPFG' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cboMRPFG.ValueMember = "MACOD_CODID";
			cboMRPFG.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cboMRPFG);
			strSQL = "SELECT DISTINCT MAROU_ROUCD, MAROU_ROUNM ";
			strSQL += "FROM MAROU_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MAROU_ROUCD ";
			cbROUCD.ValueMember = "MAROU_ROUCD";
			cbROUCD.DisplayMember = "MAROU_ROUNM";
			Common.RetriveComboItembySQL(strSQL, cbROUCD);
			strSQL = "SELECT DISTINCT MAMCH_MCHID, MAMCH_MCHNM ";
			strSQL += "FROM MAMCH_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MAMCH_MCHNM";
			cbMCHID.ValueMember = "MAMCH_MCHID";
			cbMCHID.DisplayMember = "MAMCH_MCHNM";
			Common.RetriveComboItembySQL(strSQL, cbMCHID);
		}

		private void Header()
		{
			int count = dgvMALOC.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvMALOC.Rows.Remove(dgvMALOC.Rows[0]);
				}
				string strSQL = "EXEC spMALOC 0, ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbHLOCTY.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCIDFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCIDTO.SelectedValue), "'")));
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvMALOC.ClearSelection();
						dgvMALOC.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvMALOC.Rows[dgvMALOC.Rows.Count - 1];
						dataGridViewRow.Cells["MALOC_LOCID"].Value = dt.Rows[i]["MALOC_LOCID"].ToString();
						dataGridViewRow.Cells["MALOC_LOCNM"].Value = dt.Rows[i]["MALOC_LOCNM"].ToString();
						dataGridViewRow.Cells["MALOC_LOCTY"].Value = dt.Rows[i]["MALOC_LOCTY"].ToString();
						dataGridViewRow.Cells["MALOC_ADDR1"].Value = dt.Rows[i]["MALOC_ADDR1"].ToString();
						dataGridViewRow.Cells["MALOC_ADDR2"].Value = dt.Rows[i]["MALOC_ADDR2"].ToString();
						dataGridViewRow.Cells["MALOC_ADDR3"].Value = dt.Rows[i]["MALOC_ADDR3"].ToString();
						dataGridViewRow.Cells["MALOC_ADDR4"].Value = dt.Rows[i]["MALOC_ADDR4"].ToString();
						dataGridViewRow.Cells["MALOC_CNTRY"].Value = dt.Rows[i]["MALOC_CNTRY"].ToString();
						dataGridViewRow.Cells["MALOC_STACD"].Value = dt.Rows[i]["MALOC_STACD"].ToString();
						dataGridViewRow.Cells["MALOC_TEL01"].Value = dt.Rows[i]["MALOC_TEL01"].ToString();
						dataGridViewRow.Cells["MALOC_TEL02"].Value = dt.Rows[i]["MALOC_TEL02"].ToString();
						dataGridViewRow.Cells["MALOC_FAXNO1"].Value = dt.Rows[i]["MALOC_FAXNO1"].ToString();
						dataGridViewRow.Cells["MALOC_FAXNO2"].Value = dt.Rows[i]["MALOC_FAXNO2"].ToString();
						dataGridViewRow.Cells["MALOC_CNTPS"].Value = dt.Rows[i]["MALOC_CNTPS"].ToString();
						dataGridViewRow.Cells["MALOC_EMAIL"].Value = dt.Rows[i]["MALOC_EMAIL"].ToString();
						dataGridViewRow.Cells["MALOC_MRPFG"].Value = dt.Rows[i]["MALOC_MRPFG"].ToString();
						dataGridViewRow.Cells["MALOC_ROUCD"].Value = dt.Rows[i]["MALOC_ROUCD"].ToString();
						dataGridViewRow.Cells["MALOC_MCHID"].Value = dt.Rows[i]["MALOC_MCHID"].ToString();
						dataGridViewRow.Cells["MALOC_REMRK"].Value = dt.Rows[i]["MALOC_REMRK"].ToString();
						dataGridViewRow.Cells["MALOC_ACTFG"].Value = dt.Rows[i]["MALOC_ACTFG"].ToString();
						dataGridViewRow.Cells["ACTFG"].Value = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dt.Rows[i]["MALOC_ACTFG"], -1, false), "Yes", "No"));
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

		private void btnNEW_Click(object sender, EventArgs e)
		{
			ClearDetails();
			Panel1.Visible = true;
			Panel2.Visible = false;
			cbLOCTY.SelectedValue = RuntimeHelpers.GetObjectValue(cbHLOCTY.SelectedValue);
			btnDelete.Enabled = false;
			btnCancel.Enabled = false;
			btnPRINT.Enabled = false;
		}

		private bool spMAELOC(string strPRO)
		{
			bool spMAELOC = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAELOC ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = strSQL + "'" + txtLOCID.Text + "', ";
				strSQL = strSQL + "'" + txtLOCNM.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCTY.SelectedValue), "', ")));
				strSQL = strSQL + "'" + txtADDR1.Text + "', ";
				strSQL = strSQL + "'" + txtADDR2.Text + "', ";
				strSQL = strSQL + "'" + txtADDR3.Text + "', ";
				strSQL = strSQL + "'" + txtADDR4.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCNTRY.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSTACD.SelectedValue), "', ")));
				strSQL = strSQL + "'" + txtTEL01.Text + "', ";
				strSQL = strSQL + "'" + txtTEL02.Text + "', ";
				strSQL = strSQL + "'" + txtFAXNO1.Text + "', ";
				strSQL = strSQL + "'" + txtFAXNO2.Text + "', ";
				strSQL = strSQL + "'" + txtCNTPS.Text + "', ";
				strSQL = strSQL + "'" + txtEMAIL.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cboMRPFG.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbROUCD.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMCHID.SelectedValue), "', ")));
				strSQL = strSQL + "'" + txtREMRK.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("", Interaction.IIf(chkACTFG.Checked, -1, 0)), ", ")));
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), Conversions.ToString(Interaction.IIf(Operators.CompareString(strPRO, "0", false) == 0, "Record updated!", "Record deleted!"))), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMAELOC = false;
					ProjectData.ClearProjectError();
					goto IL_039d;
				}
				Header();
				ClearDetails();
				spMAELOC = true;
			}
			goto IL_039d;
			IL_039d:
			return spMAELOC;
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			spMAELOC("0");
		}

		public void BindGridtoControl()
		{
			txtLOCID.Text = dgvMALOC.CurrentRow.Cells["MALOC_LOCID"].Value.ToString();
			txtLOCNM.Text = dgvMALOC.CurrentRow.Cells["MALOC_LOCNM"].Value.ToString();
			cbLOCTY.SelectedValue = dgvMALOC.CurrentRow.Cells["MALOC_LOCTY"].Value.ToString();
			txtADDR1.Text = dgvMALOC.CurrentRow.Cells["MALOC_ADDR1"].Value.ToString();
			txtADDR2.Text = dgvMALOC.CurrentRow.Cells["MALOC_ADDR2"].Value.ToString();
			txtADDR3.Text = dgvMALOC.CurrentRow.Cells["MALOC_ADDR3"].Value.ToString();
			txtADDR4.Text = dgvMALOC.CurrentRow.Cells["MALOC_ADDR4"].Value.ToString();
			cbCNTRY.SelectedValue = dgvMALOC.CurrentRow.Cells["MALOC_CNTRY"].Value.ToString();
			cbSTACD.SelectedValue = dgvMALOC.CurrentRow.Cells["MALOC_STACD"].Value.ToString();
			txtTEL01.Text = dgvMALOC.CurrentRow.Cells["MALOC_TEL01"].Value.ToString();
			txtTEL02.Text = dgvMALOC.CurrentRow.Cells["MALOC_TEL02"].Value.ToString();
			txtFAXNO1.Text = dgvMALOC.CurrentRow.Cells["MALOC_FAXNO1"].Value.ToString();
			txtFAXNO2.Text = dgvMALOC.CurrentRow.Cells["MALOC_FAXNO2"].Value.ToString();
			txtCNTPS.Text = dgvMALOC.CurrentRow.Cells["MALOC_CNTPS"].Value.ToString();
			txtEMAIL.Text = dgvMALOC.CurrentRow.Cells["MALOC_EMAIL"].Value.ToString();
			txtREMRK.Text = dgvMALOC.CurrentRow.Cells["MALOC_REMRK"].Value.ToString();
			cboMRPFG.SelectedValue = dgvMALOC.CurrentRow.Cells["MALOC_MRPFG"].Value.ToString();
			cbROUCD.SelectedValue = dgvMALOC.CurrentRow.Cells["MALOC_ROUCD"].Value.ToString();
			cbMCHID.SelectedValue = dgvMALOC.CurrentRow.Cells["MALOC_MCHID"].Value.ToString();
			chkACTFG.Checked = Conversions.ToBoolean(dgvMALOC.CurrentRow.Cells["MALOC_ACTFG"].Value);
		}

		public void EditRecord()
		{
			BindComboBox();
			BindGridtoControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnSAVE.Tag = "Update";
			txtLOCID.Enabled = false;
		}

		private void dgvMALOC_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			EditRecord();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Header();
			ClearDetails();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spMAELOC("1");
				ClearDetails();
				Header();
			}
		}

		public void BindDataFromDB()
		{
			string strSQL = "MALOC_LOCID, MALOC_LOCNM, MALOC_ADDR1, MALOC_ADDR2, MALOC_ADDR3, ";
			strSQL += "MALOC_ADDR4, MALOC_CNTRY, MALOC_STACD, MALOC_TEL01, MALOC_TEL02, ";
			strSQL += "MALOC_FAXNO1, MALOC_FAXNO2, MALOC_CNTPS, MALOC_EMAIL, MALOC_MRPFG, ";
			strSQL += "MALOC_ROUCD, MALOC_MCHID, MALOC_REMRK, MALOC_ACTFG ";
			DataTable dt = DB.GetTable(strSQL, "MALOC_TBL", "MALOC_LOCID = '" + txtLOCID.Text + "'", "");
			if (dt.Rows.Count > 0)
			{
				txtLOCID.Text = dt.Rows[0]["MALOC_LOCID"].ToString();
				txtLOCNM.Text = dt.Rows[0]["MALOC_LOCNM"].ToString();
				cbLOCTY.SelectedValue = dt.Rows[0]["MALOC_LOCTY"].ToString();
				txtADDR1.Text = dt.Rows[0]["MALOC_ADDR1"].ToString();
				txtADDR2.Text = dt.Rows[0]["MALOC_ADDR2"].ToString();
				txtADDR3.Text = dt.Rows[0]["MALOC_ADDR3"].ToString();
				txtADDR4.Text = dt.Rows[0]["MALOC_ADDR4"].ToString();
				cbCNTRY.SelectedValue = dt.Rows[0]["MALOC_CNTRY"].ToString();
				cbSTACD.SelectedValue = dt.Rows[0]["MALOC_STACD"].ToString();
				txtTEL01.Text = dt.Rows[0]["MALOC_TEL01"].ToString();
				txtTEL02.Text = dt.Rows[0]["MALOC_TEL02"].ToString();
				txtFAXNO1.Text = dt.Rows[0]["MALOC_FAXNO1"].ToString();
				txtFAXNO2.Text = dt.Rows[0]["MALOC_FAXNO2"].ToString();
				txtCNTPS.Text = dt.Rows[0]["MALOC_CNTPS"].ToString();
				txtEMAIL.Text = dt.Rows[0]["MALOC_EMAIL"].ToString();
				txtREMRK.Text = dt.Rows[0]["MALOC_REMRK"].ToString();
				cboMRPFG.SelectedValue = dt.Rows[0]["MALOC_MRPFG"].ToString();
				cbROUCD.SelectedValue = dt.Rows[0]["MALOC_ROUCD"].ToString();
				cbMCHID.SelectedValue = dt.Rows[0]["MALOC_MCHID"].ToString();
				chkACTFG.Checked = Conversions.ToBoolean(dt.Rows[0]["MALOC_REMRK"]);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			BindDataFromDB();
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		public void ClearDetails()
		{
			txtLOCID.Text = string.Empty;
			txtLOCNM.Text = string.Empty;
			txtADDR1.Text = string.Empty;
			txtADDR2.Text = string.Empty;
			txtADDR3.Text = string.Empty;
			txtADDR4.Text = string.Empty;
			cbCNTRY.SelectedIndex = -1;
			cbSTACD.SelectedIndex = -1;
			cboMRPFG.SelectedIndex = 1;
			cbROUCD.SelectedIndex = -1;
			cbMCHID.SelectedIndex = -1;
			txtTEL01.Text = string.Empty;
			txtTEL02.Text = string.Empty;
			txtFAXNO1.Text = string.Empty;
			txtFAXNO2.Text = string.Empty;
			txtCNTPS.Text = string.Empty;
			txtEMAIL.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			chkACTFG.Checked = true;
			btnSAVE.Tag = "Save";
			btnSAVE.Enabled = true;
			btnBack.Enabled = true;
			btnDelete.Enabled = true;
			btnCancel.Enabled = true;
			btnPRINT.Enabled = true;
			txtLOCID.Enabled = true;
		}

		public bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtLOCID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtLOCID.Focus();
				return false;
			}
			if (Operators.CompareString(txtLOCNM.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location Name cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtLOCNM.Focus();
				return false;
			}
			string strSQL = "SELECT MALOC_LOCID FROM MALOC_TBL WHERE MALOC_LOCID = '" + txtLOCID.Text + "'";
			if (Operators.ConditionalCompareObjectEqual(btnSAVE.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location ID already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtLOCID.Focus();
				return false;
			}
			return true;
		}

		public void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "LOCATION MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMALOC.rpt";
			if (Operators.CompareString(txtLOCID.Text.Trim(), "", false) != 0)
			{
				frmRPT.Params = ("@Par=1 ,@LOCTY=,@LOCIDfr=" + txtLOCID.Text + ",@LOCIDto=" + txtLOCID.Text) ?? "";
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@Par=1 ,@LOCTY=,@LOCIDfr=", cbLOCIDFR.SelectedValue), ",@LOCIDto="), cbLOCIDTO.SelectedValue), ""));
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='LOCATION MASTER'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAELOC_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbLOCIDFR_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbLOCIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbLOCIDFR.SelectedValue);
		}

		private void cbHLOCTY_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT '' as MALOC_LOCID, '' as MALOC_LOCNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE MALOC_LOCTY = '" + Common.gfValidSQLStr(Conversions.ToString(cbHLOCTY.SelectedValue)) + "' ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCIDFR.ValueMember = "MALOC_LOCID";
			cbLOCIDFR.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCIDFR);
			cbLOCIDTO.ValueMember = "MALOC_LOCID";
			cbLOCIDTO.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCIDTO);
		}
	}
}
