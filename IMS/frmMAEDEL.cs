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
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmMAEDEL : Form
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
		[AccessedThroughProperty("dgvMADEL")]
		private DataGridView _dgvMADEL;

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
		[AccessedThroughProperty("cbDELIDFR")]
		private ComboBox _cbDELIDFR;

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

		[field: AccessedThroughProperty("lblDELID")]
		internal virtual Label lblDELID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDELNM")]
		internal virtual Label lblDELNM
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

		[field: AccessedThroughProperty("txtDELNM")]
		internal virtual TextBox txtDELNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDELID")]
		internal virtual TextBox txtDELID
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

		internal virtual DataGridView dgvMADEL
		{
			[CompilerGenerated]
			get
			{
				return _dgvMADEL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMADEL_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMADEL;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMADEL = value;
				dataGridView = _dgvMADEL;
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

		[field: AccessedThroughProperty("lblDELIDTO")]
		internal virtual Label lblDELIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDELIDFR")]
		internal virtual Label lblDELIDFR
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

		[field: AccessedThroughProperty("cbDELIDTO")]
		internal virtual ComboBox cbDELIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbDELIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbDELIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbDELIDFR_SelectedIndexChanged;
				ComboBox comboBox = _cbDELIDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbDELIDFR = value;
				comboBox = _cbDELIDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCUSID")]
		internal virtual ComboboxControl cbCUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_SHORT")]
		internal virtual DataGridViewTextBoxColumn MACUS_SHORT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_DELID")]
		internal virtual DataGridViewTextBoxColumn MADEL_DELID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_DELNM")]
		internal virtual DataGridViewTextBoxColumn MADEL_DELNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_ADDR1")]
		internal virtual DataGridViewTextBoxColumn MADEL_ADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_ADDR2")]
		internal virtual DataGridViewTextBoxColumn MADEL_ADDR2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_ADDR3")]
		internal virtual DataGridViewTextBoxColumn MADEL_ADDR3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_ADDR4")]
		internal virtual DataGridViewTextBoxColumn MADEL_ADDR4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_CNTRY")]
		internal virtual DataGridViewTextBoxColumn MADEL_CNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_STACD")]
		internal virtual DataGridViewTextBoxColumn MADEL_STACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_CUSID")]
		internal virtual DataGridViewTextBoxColumn MADEL_CUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_TEL01")]
		internal virtual DataGridViewTextBoxColumn MADEL_TEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_TEL02")]
		internal virtual DataGridViewTextBoxColumn MADEL_TEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_FAXNO1")]
		internal virtual DataGridViewTextBoxColumn MADEL_FAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_FAXNO2")]
		internal virtual DataGridViewTextBoxColumn MADEL_FAXNO2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_CNTPS")]
		internal virtual DataGridViewTextBoxColumn MADEL_CNTPS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_EMAIL")]
		internal virtual DataGridViewTextBoxColumn MADEL_EMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MADEL_REMRK")]
		internal virtual DataGridViewTextBoxColumn MADEL_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAEDEL()
		{
			base.FormClosing += frmMAEDEL_FormClosing;
			base.Shown += frmMAEDEL_Shown;
			base.KeyDown += frmMAEDEL_KeyDown;
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
			this.cbSTACD = new System.Windows.Forms.ComboBox();
			this.cbCNTRY = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
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
			this.txtDELNM = new System.Windows.Forms.TextBox();
			this.lblFAXNO1 = new System.Windows.Forms.Label();
			this.lblTEL02 = new System.Windows.Forms.Label();
			this.lblTEL01 = new System.Windows.Forms.Label();
			this.lblCNTRY = new System.Windows.Forms.Label();
			this.txtDELID = new System.Windows.Forms.TextBox();
			this.lblADDR1 = new System.Windows.Forms.Label();
			this.lblDELID = new System.Windows.Forms.Label();
			this.lblDELNM = new System.Windows.Forms.Label();
			this.lblCNTPS = new System.Windows.Forms.Label();
			this.lblSTACD = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbCUSID = new IMS.ComboboxControl();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPrintfr = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbDELIDTO = new System.Windows.Forms.ComboBox();
			this.cbDELIDFR = new System.Windows.Forms.ComboBox();
			this.lblDELIDTO = new System.Windows.Forms.Label();
			this.lblDELIDFR = new System.Windows.Forms.Label();
			this.dgvMADEL = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.MACUS_SHORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_DELID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_DELNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_ADDR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_ADDR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_ADDR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_ADDR4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_CNTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_STACD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_CUSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_TEL01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_TEL02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_FAXNO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_FAXNO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_CNTPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MADEL_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMADEL).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbSTACD, 3, 6);
			this.TableLayoutPanel1.Controls.Add(this.cbCNTRY, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 15);
			this.TableLayoutPanel1.Controls.Add(this.txtFAXNO2, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 13);
			this.TableLayoutPanel1.Controls.Add(this.txtEMAIL, 1, 12);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.lblEMAIL, 0, 12);
			this.TableLayoutPanel1.Controls.Add(this.txtCNTPS, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.txtFAXNO1, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtTEL02, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.txtTEL01, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR4, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR3, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR2, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR1, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtDELNM, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblFAXNO1, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.lblTEL02, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.lblTEL01, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.lblCNTRY, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtDELID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblADDR1, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblDELID, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblDELNM, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblCNTPS, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.lblSTACD, 2, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbCUSID, 3, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(11, 11);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 16;
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(970, 521);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbSTACD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTACD.FormattingEnabled = true;
			this.cbSTACD.Location = new System.Drawing.Point(639, 183);
			this.cbSTACD.Name = "cbSTACD";
			this.cbSTACD.Size = new System.Drawing.Size(214, 28);
			this.cbSTACD.TabIndex = 28;
			this.cbCNTRY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCNTRY.FormattingEnabled = true;
			this.cbCNTRY.Location = new System.Drawing.Point(128, 183);
			this.cbCNTRY.Name = "cbCNTRY";
			this.cbCNTRY.Size = new System.Drawing.Size(214, 28);
			this.cbCNTRY.TabIndex = 27;
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
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 465);
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
			this.btnPrint.TabIndex = 28;
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
			this.btnBack.TabIndex = 27;
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
			this.btnCancel.TabIndex = 26;
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
			this.btnDelete.TabIndex = 25;
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
			this.btnSAVE.TabIndex = 24;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.txtFAXNO2.Location = new System.Drawing.Point(128, 306);
			this.txtFAXNO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFAXNO2.Name = "txtFAXNO2";
			this.txtFAXNO2.Size = new System.Drawing.Size(125, 26);
			this.txtFAXNO2.TabIndex = 13;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 309);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(76, 20);
			this.Label1.TabIndex = 17;
			this.Label1.Text = "Fax No 2";
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 2);
			this.txtREMRK.Location = new System.Drawing.Point(128, 396);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(460, 45);
			this.txtREMRK.TabIndex = 21;
			this.txtEMAIL.Location = new System.Drawing.Point(128, 366);
			this.txtEMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEMAIL.Name = "txtEMAIL";
			this.txtEMAIL.Size = new System.Drawing.Size(281, 26);
			this.txtEMAIL.TabIndex = 15;
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 408);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(67, 20);
			this.lblREMRK.TabIndex = 19;
			this.lblREMRK.Text = "Remark";
			this.lblEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEMAIL.AutoSize = true;
			this.lblEMAIL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEMAIL.Location = new System.Drawing.Point(3, 369);
			this.lblEMAIL.Name = "lblEMAIL";
			this.lblEMAIL.Size = new System.Drawing.Size(51, 20);
			this.lblEMAIL.TabIndex = 18;
			this.lblEMAIL.Text = "Email";
			this.txtCNTPS.Location = new System.Drawing.Point(128, 336);
			this.txtCNTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCNTPS.Name = "txtCNTPS";
			this.txtCNTPS.Size = new System.Drawing.Size(281, 26);
			this.txtCNTPS.TabIndex = 14;
			this.txtFAXNO1.Location = new System.Drawing.Point(128, 276);
			this.txtFAXNO1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFAXNO1.Name = "txtFAXNO1";
			this.txtFAXNO1.Size = new System.Drawing.Size(125, 26);
			this.txtFAXNO1.TabIndex = 12;
			this.txtTEL02.Location = new System.Drawing.Point(128, 246);
			this.txtTEL02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTEL02.Name = "txtTEL02";
			this.txtTEL02.Size = new System.Drawing.Size(125, 26);
			this.txtTEL02.TabIndex = 11;
			this.txtTEL01.Location = new System.Drawing.Point(128, 216);
			this.txtTEL01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTEL01.Name = "txtTEL01";
			this.txtTEL01.Size = new System.Drawing.Size(125, 26);
			this.txtTEL01.TabIndex = 10;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR4, 2);
			this.txtADDR4.Location = new System.Drawing.Point(128, 152);
			this.txtADDR4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR4.Name = "txtADDR4";
			this.txtADDR4.Size = new System.Drawing.Size(460, 26);
			this.txtADDR4.TabIndex = 6;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR3, 2);
			this.txtADDR3.Location = new System.Drawing.Point(128, 122);
			this.txtADDR3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR3.Name = "txtADDR3";
			this.txtADDR3.Size = new System.Drawing.Size(460, 26);
			this.txtADDR3.TabIndex = 5;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR2, 2);
			this.txtADDR2.Location = new System.Drawing.Point(128, 92);
			this.txtADDR2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR2.Name = "txtADDR2";
			this.txtADDR2.Size = new System.Drawing.Size(460, 26);
			this.txtADDR2.TabIndex = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR1, 2);
			this.txtADDR1.Location = new System.Drawing.Point(128, 62);
			this.txtADDR1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR1.Name = "txtADDR1";
			this.txtADDR1.Size = new System.Drawing.Size(460, 26);
			this.txtADDR1.TabIndex = 3;
			this.txtDELNM.Location = new System.Drawing.Point(128, 32);
			this.txtDELNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDELNM.Name = "txtDELNM";
			this.txtDELNM.Size = new System.Drawing.Size(281, 26);
			this.txtDELNM.TabIndex = 2;
			this.lblFAXNO1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFAXNO1.AutoSize = true;
			this.lblFAXNO1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFAXNO1.Location = new System.Drawing.Point(3, 279);
			this.lblFAXNO1.Name = "lblFAXNO1";
			this.lblFAXNO1.Size = new System.Drawing.Size(62, 20);
			this.lblFAXNO1.TabIndex = 8;
			this.lblFAXNO1.Text = "Fax No";
			this.lblTEL02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL02.AutoSize = true;
			this.lblTEL02.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL02.Location = new System.Drawing.Point(3, 249);
			this.lblTEL02.Name = "lblTEL02";
			this.lblTEL02.Size = new System.Drawing.Size(46, 20);
			this.lblTEL02.TabIndex = 9;
			this.lblTEL02.Text = "Tel 2";
			this.lblTEL01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL01.AutoSize = true;
			this.lblTEL01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL01.Location = new System.Drawing.Point(3, 219);
			this.lblTEL01.Name = "lblTEL01";
			this.lblTEL01.Size = new System.Drawing.Size(46, 20);
			this.lblTEL01.TabIndex = 10;
			this.lblTEL01.Text = "Tel 1";
			this.lblCNTRY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTRY.AutoSize = true;
			this.lblCNTRY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTRY.Location = new System.Drawing.Point(3, 187);
			this.lblCNTRY.Name = "lblCNTRY";
			this.lblCNTRY.Size = new System.Drawing.Size(67, 20);
			this.lblCNTRY.TabIndex = 12;
			this.lblCNTRY.Text = "Country";
			this.txtDELID.Location = new System.Drawing.Point(128, 2);
			this.txtDELID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDELID.Name = "txtDELID";
			this.txtDELID.Size = new System.Drawing.Size(125, 26);
			this.txtDELID.TabIndex = 1;
			this.lblADDR1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblADDR1.AutoSize = true;
			this.lblADDR1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblADDR1.Location = new System.Drawing.Point(3, 65);
			this.lblADDR1.Name = "lblADDR1";
			this.lblADDR1.Size = new System.Drawing.Size(85, 20);
			this.lblADDR1.TabIndex = 16;
			this.lblADDR1.Text = "Address 1";
			this.lblDELID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDELID.AutoSize = true;
			this.lblDELID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDELID.Location = new System.Drawing.Point(3, 5);
			this.lblDELID.Name = "lblDELID";
			this.lblDELID.Size = new System.Drawing.Size(92, 20);
			this.lblDELID.TabIndex = 8;
			this.lblDELID.Text = "Delivery ID";
			this.lblDELNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDELNM.AutoSize = true;
			this.lblDELNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDELNM.Location = new System.Drawing.Point(3, 35);
			this.lblDELNM.Name = "lblDELNM";
			this.lblDELNM.Size = new System.Drawing.Size(119, 20);
			this.lblDELNM.TabIndex = 9;
			this.lblDELNM.Text = "Delivery Name";
			this.lblCNTPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTPS.AutoSize = true;
			this.lblCNTPS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTPS.Location = new System.Drawing.Point(3, 339);
			this.lblCNTPS.Name = "lblCNTPS";
			this.lblCNTPS.Size = new System.Drawing.Size(99, 20);
			this.lblCNTPS.TabIndex = 17;
			this.lblCNTPS.Text = "Attention To";
			this.lblSTACD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTACD.AutoSize = true;
			this.lblSTACD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTACD.Location = new System.Drawing.Point(415, 187);
			this.lblSTACD.Name = "lblSTACD";
			this.lblSTACD.Size = new System.Drawing.Size(48, 20);
			this.lblSTACD.TabIndex = 11;
			this.lblSTACD.Text = "State";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(415, 35);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(82, 20);
			this.Label2.TabIndex = 12;
			this.Label2.Text = "Customer";
			this.cbCUSID.BlankValue = null;
			this.cbCUSID.ComboboxWidth = 170;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = true;
			this.cbCUSID.Location = new System.Drawing.Point(641, 32);
			this.cbCUSID.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(324, 25);
			this.cbCUSID.TabIndex = 11;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvMADEL);
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
			this.TableLayoutPanel2.Controls.Add(this.cbDELIDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbDELIDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblDELIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblDELIDFR, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(577, 31);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbDELIDTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDELIDTO.FormattingEnabled = true;
			this.cbDELIDTO.Location = new System.Drawing.Point(360, 3);
			this.cbDELIDTO.Name = "cbDELIDTO";
			this.cbDELIDTO.Size = new System.Drawing.Size(214, 28);
			this.cbDELIDTO.TabIndex = 28;
			this.cbDELIDFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDELIDFR.FormattingEnabled = true;
			this.cbDELIDFR.Location = new System.Drawing.Point(106, 3);
			this.cbDELIDFR.Name = "cbDELIDFR";
			this.cbDELIDFR.Size = new System.Drawing.Size(214, 28);
			this.cbDELIDFR.TabIndex = 28;
			this.lblDELIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDELIDTO.AutoSize = true;
			this.lblDELIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDELIDTO.Location = new System.Drawing.Point(326, 5);
			this.lblDELIDTO.Name = "lblDELIDTO";
			this.lblDELIDTO.Size = new System.Drawing.Size(28, 20);
			this.lblDELIDTO.TabIndex = 3;
			this.lblDELIDTO.Text = "To";
			this.lblDELIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDELIDFR.AutoSize = true;
			this.lblDELIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDELIDFR.Location = new System.Drawing.Point(3, 5);
			this.lblDELIDFR.Name = "lblDELIDFR";
			this.lblDELIDFR.Size = new System.Drawing.Size(97, 20);
			this.lblDELIDFR.TabIndex = 2;
			this.lblDELIDFR.Text = "Delivery ID ";
			this.dgvMADEL.AllowUserToAddRows = false;
			this.dgvMADEL.AllowUserToDeleteRows = false;
			this.dgvMADEL.AllowUserToResizeRows = false;
			this.dgvMADEL.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMADEL.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMADEL.ColumnHeadersHeight = 30;
			this.dgvMADEL.Columns.AddRange(this.MACUS_SHORT, this.MADEL_DELID, this.MADEL_DELNM, this.MADEL_ADDR1, this.MADEL_ADDR2, this.MADEL_ADDR3, this.MADEL_ADDR4, this.MADEL_CNTRY, this.MADEL_STACD, this.MADEL_CUSID, this.MADEL_TEL01, this.MADEL_TEL02, this.MADEL_FAXNO1, this.MADEL_FAXNO2, this.MADEL_CNTPS, this.MADEL_EMAIL, this.MADEL_REMRK);
			this.dgvMADEL.Location = new System.Drawing.Point(5, 118);
			this.dgvMADEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMADEL.MultiSelect = false;
			this.dgvMADEL.Name = "dgvMADEL";
			this.dgvMADEL.ReadOnly = true;
			this.dgvMADEL.RowHeadersVisible = false;
			this.dgvMADEL.RowHeadersWidth = 51;
			this.dgvMADEL.RowTemplate.Height = 24;
			this.dgvMADEL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMADEL.Size = new System.Drawing.Size(1318, 503);
			this.dgvMADEL.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 17;
			this.MACUS_SHORT.HeaderText = "Customer";
			this.MACUS_SHORT.MinimumWidth = 6;
			this.MACUS_SHORT.Name = "MACUS_SHORT";
			this.MACUS_SHORT.ReadOnly = true;
			this.MACUS_SHORT.Width = 150;
			this.MADEL_DELID.HeaderText = "Delivery ID";
			this.MADEL_DELID.MinimumWidth = 6;
			this.MADEL_DELID.Name = "MADEL_DELID";
			this.MADEL_DELID.ReadOnly = true;
			this.MADEL_DELID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_DELID.Width = 150;
			this.MADEL_DELNM.HeaderText = "Delivery Name";
			this.MADEL_DELNM.MinimumWidth = 6;
			this.MADEL_DELNM.Name = "MADEL_DELNM";
			this.MADEL_DELNM.ReadOnly = true;
			this.MADEL_DELNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_DELNM.Width = 300;
			this.MADEL_ADDR1.HeaderText = "Address 1";
			this.MADEL_ADDR1.MinimumWidth = 6;
			this.MADEL_ADDR1.Name = "MADEL_ADDR1";
			this.MADEL_ADDR1.ReadOnly = true;
			this.MADEL_ADDR1.Width = 300;
			this.MADEL_ADDR2.HeaderText = "Address 2";
			this.MADEL_ADDR2.MinimumWidth = 6;
			this.MADEL_ADDR2.Name = "MADEL_ADDR2";
			this.MADEL_ADDR2.ReadOnly = true;
			this.MADEL_ADDR2.Width = 300;
			this.MADEL_ADDR3.HeaderText = "Address 3";
			this.MADEL_ADDR3.MinimumWidth = 6;
			this.MADEL_ADDR3.Name = "MADEL_ADDR3";
			this.MADEL_ADDR3.ReadOnly = true;
			this.MADEL_ADDR3.Width = 300;
			this.MADEL_ADDR4.HeaderText = "Address 4";
			this.MADEL_ADDR4.MinimumWidth = 6;
			this.MADEL_ADDR4.Name = "MADEL_ADDR4";
			this.MADEL_ADDR4.ReadOnly = true;
			this.MADEL_ADDR4.Width = 300;
			this.MADEL_CNTRY.HeaderText = "Country";
			this.MADEL_CNTRY.MinimumWidth = 6;
			this.MADEL_CNTRY.Name = "MADEL_CNTRY";
			this.MADEL_CNTRY.ReadOnly = true;
			this.MADEL_CNTRY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_CNTRY.Visible = false;
			this.MADEL_CNTRY.Width = 125;
			this.MADEL_STACD.HeaderText = "State";
			this.MADEL_STACD.MinimumWidth = 6;
			this.MADEL_STACD.Name = "MADEL_STACD";
			this.MADEL_STACD.ReadOnly = true;
			this.MADEL_STACD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_STACD.Visible = false;
			this.MADEL_STACD.Width = 125;
			this.MADEL_CUSID.HeaderText = "Customer";
			this.MADEL_CUSID.MinimumWidth = 6;
			this.MADEL_CUSID.Name = "MADEL_CUSID";
			this.MADEL_CUSID.ReadOnly = true;
			this.MADEL_CUSID.Width = 125;
			this.MADEL_TEL01.HeaderText = "Tel No";
			this.MADEL_TEL01.MinimumWidth = 6;
			this.MADEL_TEL01.Name = "MADEL_TEL01";
			this.MADEL_TEL01.ReadOnly = true;
			this.MADEL_TEL01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_TEL01.Width = 125;
			this.MADEL_TEL02.HeaderText = "Tel No 2";
			this.MADEL_TEL02.MinimumWidth = 6;
			this.MADEL_TEL02.Name = "MADEL_TEL02";
			this.MADEL_TEL02.ReadOnly = true;
			this.MADEL_TEL02.Visible = false;
			this.MADEL_TEL02.Width = 125;
			this.MADEL_FAXNO1.HeaderText = "Fax No";
			this.MADEL_FAXNO1.MinimumWidth = 6;
			this.MADEL_FAXNO1.Name = "MADEL_FAXNO1";
			this.MADEL_FAXNO1.ReadOnly = true;
			this.MADEL_FAXNO1.Visible = false;
			this.MADEL_FAXNO1.Width = 125;
			this.MADEL_FAXNO2.HeaderText = "Fax No 2";
			this.MADEL_FAXNO2.MinimumWidth = 6;
			this.MADEL_FAXNO2.Name = "MADEL_FAXNO2";
			this.MADEL_FAXNO2.ReadOnly = true;
			this.MADEL_FAXNO2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_FAXNO2.Visible = false;
			this.MADEL_FAXNO2.Width = 125;
			this.MADEL_CNTPS.FillWeight = 150f;
			this.MADEL_CNTPS.HeaderText = "Contact Person";
			this.MADEL_CNTPS.MinimumWidth = 6;
			this.MADEL_CNTPS.Name = "MADEL_CNTPS";
			this.MADEL_CNTPS.ReadOnly = true;
			this.MADEL_CNTPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_CNTPS.Visible = false;
			this.MADEL_CNTPS.Width = 125;
			this.MADEL_EMAIL.HeaderText = "Email";
			this.MADEL_EMAIL.MinimumWidth = 6;
			this.MADEL_EMAIL.Name = "MADEL_EMAIL";
			this.MADEL_EMAIL.ReadOnly = true;
			this.MADEL_EMAIL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_EMAIL.Visible = false;
			this.MADEL_EMAIL.Width = 150;
			this.MADEL_REMRK.HeaderText = "Remark";
			this.MADEL_REMRK.MinimumWidth = 6;
			this.MADEL_REMRK.Name = "MADEL_REMRK";
			this.MADEL_REMRK.ReadOnly = true;
			this.MADEL_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MADEL_REMRK.Width = 300;
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
			base.Name = "frmMAEDEL";
			base.Tag = "MAEDEL";
			this.Text = "Delivery Address";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMADEL).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = false;
			btnCancel.Enabled = false;
			btnPrint.Enabled = false;
			BindComboBox();
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			spMAEDEL("1");
		}

		private void BindComboHeader()
		{
			string strSQL = "SELECT '' as MADEL_DELID, '' as MADEL_DELNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MADEL_DELID, MADEL_DELNM ";
			strSQL += "FROM MADEL_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MADEL_DELID ";
			cbDELIDFR.ValueMember = "MADEL_DELID";
			cbDELIDFR.DisplayMember = "MADEL_DELNM";
			Common.RetriveComboItembySQL(strSQL, cbDELIDFR);
			cbDELIDTO.ValueMember = "MADEL_DELID";
			cbDELIDTO.DisplayMember = "MADEL_DELID";
			Common.RetriveComboItembySQL(strSQL, cbDELIDTO);
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
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
			cbCUSID.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSID.ValueMember = "MACUS_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			cbCUSID.LoadData();
		}

		public bool spMAEDEL(string strPRO)
		{
			bool spMAEDEL = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAEDEL ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = strSQL + "'" + txtDELID.Text + "', ";
				strSQL = strSQL + "N'" + txtDELNM.Text + "', ";
				strSQL = strSQL + "N'" + txtADDR1.Text + "', ";
				strSQL = strSQL + "N'" + txtADDR2.Text + "', ";
				strSQL = strSQL + "N'" + txtADDR3.Text + "', ";
				strSQL = strSQL + "N'" + txtADDR4.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCNTRY.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSTACD.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
				strSQL = strSQL + "'" + txtTEL01.Text + "', ";
				strSQL = strSQL + "'" + txtTEL02.Text + "', ";
				strSQL = strSQL + "'" + txtFAXNO1.Text + "', ";
				strSQL = strSQL + "'" + txtFAXNO2.Text + "', ";
				strSQL = strSQL + "'" + txtCNTPS.Text + "', ";
				strSQL = strSQL + "'" + txtEMAIL.Text + "', ";
				strSQL = strSQL + "N'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record saved!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMAEDEL = false;
					ProjectData.ClearProjectError();
					goto IL_02be;
				}
				Header();
				ClearDetails();
			}
			goto IL_02be;
			IL_02be:
			return spMAEDEL;
		}

		private void frmMAEDEL_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAEDEL_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Header();
		}

		private bool BindDatafromDB()
		{
			string strSQL = "MADEL_DELID, MADEL_DELNM, MADEL_ADDR1, MADEL_ADDR2, MADEL_ADDR3, ";
			strSQL += "MADEL_ADDR4, MADEL_CNTRY, MADEL_STACD, MADEL_CUSID, MADEL_TEL01, MADEL_TEL02, ";
			strSQL += "MADEL_FAXNO1, MADEL_FAXNO2, MADEL_CNTPS, MADEL_EMAIL, ";
			strSQL += "MADEL_REMRK, MADEL_ENTDT, MADEL_ENTBY, MADEL_LUPDT, MADEL_LUPBY ";
			DataTable dt = DB.GetTable(strSQL, "MADEL_TBL", "MADEL_DELID = '" + txtDELID.Text + "'", "");
			bool BindDatafromDB;
			try
			{
				if (dt.Rows.Count > 0)
				{
					txtDELID.Text = dt.Rows[0]["MADEL_DELID"].ToString();
					txtDELNM.Text = dt.Rows[0]["MADEL_DELNM"].ToString();
					txtADDR1.Text = dt.Rows[0]["MADEL_ADDR1"].ToString();
					txtADDR2.Text = dt.Rows[0]["MADEL_ADDR2"].ToString();
					txtADDR3.Text = dt.Rows[0]["MADEL_ADDR3"].ToString();
					txtADDR4.Text = dt.Rows[0]["MADEL_ADDR4"].ToString();
					cbCNTRY.SelectedValue = dt.Rows[0]["MADEL_CNTRY"].ToString();
					cbSTACD.SelectedValue = dt.Rows[0]["MADEL_STACD"].ToString();
					cbCUSID.SelectedValue = dt.Rows[0]["MADEL_CUSID"].ToString();
					txtTEL01.Text = dt.Rows[0]["MADEL_TEL01"].ToString();
					txtTEL02.Text = dt.Rows[0]["MADEL_TEL02"].ToString();
					txtFAXNO1.Text = dt.Rows[0]["MADEL_FAXNO1"].ToString();
					txtFAXNO2.Text = dt.Rows[0]["MADEL_FAXNO2"].ToString();
					txtCNTPS.Text = dt.Rows[0]["MADEL_CNTPS"].ToString();
					txtEMAIL.Text = dt.Rows[0]["MADEL_EMAIL"].ToString();
					txtREMRK.Text = dt.Rows[0]["MADEL_REMRK"].ToString();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				BindDatafromDB = false;
				ProjectData.ClearProjectError();
				goto IL_0311;
			}
			BindDatafromDB = true;
			goto IL_0311;
			IL_0311:
			return BindDatafromDB;
		}

		private void Header()
		{
			int count = dgvMADEL.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvMADEL.Rows.Remove(dgvMADEL.Rows[0]);
				}
				string strSQL = "EXEC spMADEL '0', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDELIDFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDELIDTO.SelectedValue), "'")));
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvMADEL.ClearSelection();
						dgvMADEL.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvMADEL.Rows[dgvMADEL.Rows.Count - 1];
						dataGridViewRow.Cells["MACUS_SHORT"].Value = dt.Rows[i]["MACUS_SHORT"].ToString();
						dataGridViewRow.Cells["MADEL_DELID"].Value = dt.Rows[i]["MADEL_DELID"].ToString();
						dataGridViewRow.Cells["MADEL_DELNM"].Value = dt.Rows[i]["MADEL_DELNM"].ToString();
						dataGridViewRow.Cells["MADEL_ADDR1"].Value = dt.Rows[i]["MADEL_ADDR1"].ToString();
						dataGridViewRow.Cells["MADEL_ADDR2"].Value = dt.Rows[i]["MADEL_ADDR2"].ToString();
						dataGridViewRow.Cells["MADEL_ADDR3"].Value = dt.Rows[i]["MADEL_ADDR3"].ToString();
						dataGridViewRow.Cells["MADEL_ADDR4"].Value = dt.Rows[i]["MADEL_ADDR4"].ToString();
						dataGridViewRow.Cells["MADEL_CNTRY"].Value = dt.Rows[i]["MADEL_CNTRY"].ToString();
						dataGridViewRow.Cells["MADEL_STACD"].Value = dt.Rows[i]["MADEL_STACD"].ToString();
						dataGridViewRow.Cells["MADEL_CUSID"].Value = dt.Rows[i]["MADEL_CUSID"].ToString();
						dataGridViewRow.Cells["MADEL_TEL01"].Value = dt.Rows[i]["MADEL_TEL01"].ToString();
						dataGridViewRow.Cells["MADEL_TEL02"].Value = dt.Rows[i]["MADEL_TEL02"].ToString();
						dataGridViewRow.Cells["MADEL_FAXNO1"].Value = dt.Rows[i]["MADEL_FAXNO1"].ToString();
						dataGridViewRow.Cells["MADEL_FAXNO2"].Value = dt.Rows[i]["MADEL_FAXNO2"].ToString();
						dataGridViewRow.Cells["MADEL_CNTPS"].Value = dt.Rows[i]["MADEL_CNTPS"].ToString();
						dataGridViewRow.Cells["MADEL_EMAIL"].Value = dt.Rows[i]["MADEL_EMAIL"].ToString();
						dataGridViewRow.Cells["MADEL_REMRK"].Value = dt.Rows[i]["MADEL_REMRK"].ToString();
						dataGridViewRow = null;
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
					return;
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void BindGridToControls()
		{
			txtDELID.Text = dgvMADEL.CurrentRow.Cells["MADEL_DELID"].Value.ToString();
			txtDELNM.Text = dgvMADEL.CurrentRow.Cells["MADEL_DELNM"].Value.ToString();
			txtADDR1.Text = dgvMADEL.CurrentRow.Cells["MADEL_ADDR1"].Value.ToString();
			txtADDR2.Text = dgvMADEL.CurrentRow.Cells["MADEL_ADDR2"].Value.ToString();
			txtADDR3.Text = dgvMADEL.CurrentRow.Cells["MADEL_ADDR3"].Value.ToString();
			txtADDR4.Text = dgvMADEL.CurrentRow.Cells["MADEL_ADDR4"].Value.ToString();
			cbCNTRY.SelectedValue = dgvMADEL.CurrentRow.Cells["MADEL_CNTRY"].Value.ToString();
			cbSTACD.SelectedValue = dgvMADEL.CurrentRow.Cells["MADEL_STACD"].Value.ToString();
			cbCUSID.SelectedValue = dgvMADEL.CurrentRow.Cells["MADEL_CUSID"].Value.ToString();
			txtTEL01.Text = dgvMADEL.CurrentRow.Cells["MADEL_TEL01"].Value.ToString();
			txtTEL02.Text = dgvMADEL.CurrentRow.Cells["MADEL_TEL02"].Value.ToString();
			txtFAXNO1.Text = dgvMADEL.CurrentRow.Cells["MADEL_FAXNO1"].Value.ToString();
			txtFAXNO2.Text = dgvMADEL.CurrentRow.Cells["MADEL_FAXNO2"].Value.ToString();
			txtCNTPS.Text = dgvMADEL.CurrentRow.Cells["MADEL_CNTPS"].Value.ToString();
			txtEMAIL.Text = dgvMADEL.CurrentRow.Cells["MADEL_EMAIL"].Value.ToString();
			txtREMRK.Text = dgvMADEL.CurrentRow.Cells["MADEL_REMRK"].Value.ToString();
		}

		private void dgvMADEL_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Panel2.Visible = false;
			Panel1.Visible = true;
			btnSAVE.Tag = "Update";
			btnDelete.Enabled = true;
			btnCancel.Enabled = true;
			btnPrint.Enabled = true;
			txtDELID.Enabled = false;
			BindComboBox();
			BindGridToControls();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery ID");
			strMSG = strMSG + " : " + txtDELID.Text + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery Name");
			strMSG = strMSG + " : " + txtDELNM.Text;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spMAEDEL("2");
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
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
			txtDELID.Enabled = true;
			txtDELID.Text = string.Empty;
			txtDELNM.Text = string.Empty;
			txtADDR1.Text = string.Empty;
			txtADDR2.Text = string.Empty;
			txtADDR3.Text = string.Empty;
			txtADDR4.Text = string.Empty;
			cbCNTRY.SelectedIndex = -1;
			cbSTACD.SelectedIndex = -1;
			cbCUSID.SelectedIndex = -1;
			txtTEL01.Text = string.Empty;
			txtTEL02.Text = string.Empty;
			txtFAXNO1.Text = string.Empty;
			txtFAXNO2.Text = string.Empty;
			txtCNTPS.Text = string.Empty;
			txtEMAIL.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			btnSAVE.Tag = "Save";
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			BindDatafromDB();
		}

		public bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtDELID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtDELID.Focus();
				return false;
			}
			if (Operators.CompareString(txtDELNM.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery Name cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtDELNM.Focus();
				return false;
			}
			string strSQL = "SELECT MADEL_DELID FROM MADEL_TBL WHERE MADEL_DELID = '" + txtDELID.Text + "'";
			if (Operators.ConditionalCompareObjectEqual(btnSAVE.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery ID already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtDELID.Focus();
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
			frmRPT.ReportName = "DELIVERY ADDRESS MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMALDEL.rpt";
			if (Operators.CompareString(txtDELID.Text, "", false) != 0)
			{
				frmRPT.Params = ("@DELIDFR=" + txtDELID.Text + ",@DELIDTO=" + txtDELID.Text) ?? "";
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@DELIDFR=", cbDELIDFR.SelectedValue), ",@DELIDTO="), cbDELIDTO.SelectedValue), ""));
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='DELIVERY ADDRESS MASTER'";
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

		private void frmMAEDEL_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbDELIDFR_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbDELIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbDELIDFR.SelectedValue);
		}
	}
}
