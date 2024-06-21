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
	public class frmMAENUM : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtPREFIX")]
		private TextBox _txtPREFIX;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtRUNNO")]
		private TextBox _txtRUNNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMANUM")]
		private DataGridView _dgvMANUM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkICLYR")]
		private CheckBox _chkICLYR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoYRDGT2")]
		private RadioButton _rdoYRDGT2;

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
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNEW")]
		private Button _btnNEW;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtRUNNOLEN")]
		private TextBox _txtRUNNOLEN;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoYRLOC2")]
		private RadioButton _rdoYRLOC2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoYRLOC1")]
		private RadioButton _rdoYRLOC1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoYRDGT1")]
		private RadioButton _rdoYRDGT1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cboSPCLPREF")]
		private ComboBox _cboSPCLPREF;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbPRGIDFR")]
		private ComboBox _cbPRGIDFR;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		private SqlTransaction Trn;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtPREFIX
		{
			[CompilerGenerated]
			get
			{
				return _txtPREFIX;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtPREFIX_TextChanged;
				TextBox textBox = _txtPREFIX;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				_txtPREFIX = value;
				textBox = _txtPREFIX;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
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

		[field: AccessedThroughProperty("txtNUMNM")]
		internal virtual TextBox txtNUMNM
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

		[field: AccessedThroughProperty("lblMDLCD")]
		internal virtual Label lblMDLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblREVNO")]
		internal virtual Label lblREVNO
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

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtRUNNO
		{
			[CompilerGenerated]
			get
			{
				return _txtRUNNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtRUNNO_TextChanged;
				TextBox textBox = _txtRUNNO;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				_txtRUNNO = value;
				textBox = _txtRUNNO;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual DataGridView dgvMANUM
		{
			[CompilerGenerated]
			get
			{
				return _dgvMANUM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMANUM_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMANUM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMANUM = value;
				dataGridView = _dgvMANUM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
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

		internal virtual CheckBox chkICLYR
		{
			[CompilerGenerated]
			get
			{
				return _chkICLYR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = chkICLYR_CheckedChanged;
				CheckBox checkBox = _chkICLYR;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_chkICLYR = value;
				checkBox = _chkICLYR;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rdoYRDGT2
		{
			[CompilerGenerated]
			get
			{
				return _rdoYRDGT2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoYRDGT2_CheckedChanged;
				RadioButton radioButton = _rdoYRDGT2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoYRDGT2 = value;
				radioButton = _rdoYRDGT2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtSMPL")]
		internal virtual TextBox txtSMPL
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
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

		[field: AccessedThroughProperty("rdoCNTRLNO2")]
		internal virtual RadioButton rdoCNTRLNO2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoCNTRLNO1")]
		internal virtual RadioButton rdoCNTRLNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtRUNNOLEN
		{
			[CompilerGenerated]
			get
			{
				return _txtRUNNOLEN;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtRUNNOLEN_TextChanged;
				TextBox textBox = _txtRUNNOLEN;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				_txtRUNNOLEN = value;
				textBox = _txtRUNNOLEN;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("GroupBox3")]
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual RadioButton rdoYRLOC2
		{
			[CompilerGenerated]
			get
			{
				return _rdoYRLOC2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoYRLOC2_Click;
				RadioButton radioButton = _rdoYRLOC2;
				if (radioButton != null)
				{
					radioButton.Click -= value2;
				}
				_rdoYRLOC2 = value;
				radioButton = _rdoYRLOC2;
				if (radioButton != null)
				{
					radioButton.Click += value2;
				}
			}
		}

		internal virtual RadioButton rdoYRLOC1
		{
			[CompilerGenerated]
			get
			{
				return _rdoYRLOC1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoYRLOC1_CheckedChanged;
				RadioButton radioButton = _rdoYRLOC1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoYRLOC1 = value;
				radioButton = _rdoYRLOC1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("GroupBox5")]
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual RadioButton rdoYRDGT1
		{
			[CompilerGenerated]
			get
			{
				return _rdoYRDGT1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoYRDGT1_CheckedChanged;
				RadioButton radioButton = _rdoYRDGT1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoYRDGT1 = value;
				radioButton = _rdoYRDGT1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("GroupBox4")]
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("btnPRINT")]
		internal virtual Button btnPRINT
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

		internal virtual ComboBox cboSPCLPREF
		{
			[CompilerGenerated]
			get
			{
				return _cboSPCLPREF;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cboSPCLPREF_TextChanged;
				ComboBox comboBox = _cboSPCLPREF;
				if (comboBox != null)
				{
					comboBox.TextChanged -= value2;
				}
				_cboSPCLPREF = value;
				comboBox = _cboSPCLPREF;
				if (comboBox != null)
				{
					comboBox.TextChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDOCID")]
		internal virtual TextBox txtDOCID
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

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
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

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_PRGID")]
		internal virtual DataGridViewTextBoxColumn MANUM_PRGID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_DOCID")]
		internal virtual DataGridViewTextBoxColumn MANUM_DOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_NUMNM")]
		internal virtual DataGridViewTextBoxColumn MANUM_NUMNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_CNTRLNO")]
		internal virtual DataGridViewTextBoxColumn MANUM_CNTRLNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_PREFIX")]
		internal virtual DataGridViewTextBoxColumn MANUM_PREFIX
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_SPCLPREF")]
		internal virtual DataGridViewTextBoxColumn MANUM_SPCLPREF
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_ICLYR")]
		internal virtual DataGridViewCheckBoxColumn MANUM_ICLYR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_YRLOC")]
		internal virtual DataGridViewTextBoxColumn MANUM_YRLOC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("YRLOC")]
		internal virtual DataGridViewTextBoxColumn YRLOC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_YRDGT")]
		internal virtual DataGridViewTextBoxColumn MANUM_YRDGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("YRDGT")]
		internal virtual DataGridViewTextBoxColumn YRDGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_RUNNO")]
		internal virtual DataGridViewTextBoxColumn MANUM_RUNNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_RUNNOLEN")]
		internal virtual DataGridViewTextBoxColumn MANUM_RUNNOLEN
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MANUM_REMRK")]
		internal virtual DataGridViewTextBoxColumn MANUM_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbPRGIDTO")]
		internal virtual ComboBox cbPRGIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbPRGIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbPRGIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbPRGIDFR_SelectedIndexChanged;
				ComboBox comboBox = _cbPRGIDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbPRGIDFR = value;
				comboBox = _cbPRGIDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbPRGID")]
		internal virtual ComboBox cbPRGID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAENUM()
		{
			base.FormClosing += frmMAENUM_FormClosing;
			base.Shown += frmMAENUM_Shown;
			base.KeyDown += frmMAENUM_KeyDown;
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
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbPRGID = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.cboSPCLPREF = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.rdoYRLOC2 = new System.Windows.Forms.RadioButton();
			this.rdoYRLOC1 = new System.Windows.Forms.RadioButton();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.rdoCNTRLNO1 = new System.Windows.Forms.RadioButton();
			this.rdoCNTRLNO2 = new System.Windows.Forms.RadioButton();
			this.Label10 = new System.Windows.Forms.Label();
			this.txtSMPL = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtPREFIX = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtNUMNM = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblMDLCD = new System.Windows.Forms.Label();
			this.lblREVNO = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.txtRUNNO = new System.Windows.Forms.TextBox();
			this.chkICLYR = new System.Windows.Forms.CheckBox();
			this.txtRUNNOLEN = new System.Windows.Forms.TextBox();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.txtDOCID = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.rdoYRDGT1 = new System.Windows.Forms.RadioButton();
			this.rdoYRDGT2 = new System.Windows.Forms.RadioButton();
			this.btnNEW = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbPRGIDTO = new System.Windows.Forms.ComboBox();
			this.cbPRGIDFR = new System.Windows.Forms.ComboBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.dgvMANUM = new System.Windows.Forms.DataGridView();
			this.MANUM_PRGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_DOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_NUMNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_CNTRLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_PREFIX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_SPCLPREF = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_ICLYR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.MANUM_YRLOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YRLOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_YRDGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.YRDGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_RUNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_RUNNOLEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MANUM_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.GroupBox3.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMANUM).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 2);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 397);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel3.TabIndex = 21;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(381, 2);
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
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(3, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 17;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(255, 2);
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
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(129, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbPRGID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.cboSPCLPREF, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.GroupBox3, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.GroupBox4, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.txtSMPL, 1, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.txtPREFIX, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtNUMNM, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblMDLCD, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblREVNO, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.txtRUNNO, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.chkICLYR, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtRUNNOLEN, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 13);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 15);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 2, 8);
			this.TableLayoutPanel1.Controls.Add(this.GroupBox5, 3, 8);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 16;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
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
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(853, 453);
			this.TableLayoutPanel1.TabIndex = 1;
			this.cbPRGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPRGID.FormattingEnabled = true;
			this.cbPRGID.Location = new System.Drawing.Point(150, 3);
			this.cbPRGID.Name = "cbPRGID";
			this.cbPRGID.Size = new System.Drawing.Size(272, 24);
			this.cbPRGID.TabIndex = 9;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 35);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(85, 16);
			this.Label11.TabIndex = 22;
			this.Label11.Text = "Document ID";
			this.cboSPCLPREF.FormattingEnabled = true;
			this.cboSPCLPREF.Items.AddRange(new object[2] { "-", "/" });
			this.cboSPCLPREF.Location = new System.Drawing.Point(150, 156);
			this.cboSPCLPREF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cboSPCLPREF.Name = "cboSPCLPREF";
			this.cboSPCLPREF.Size = new System.Drawing.Size(121, 24);
			this.cboSPCLPREF.TabIndex = 7;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 160);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(90, 16);
			this.Label8.TabIndex = 22;
			this.Label8.Text = "Special Prefix";
			this.GroupBox3.Controls.Add(this.rdoYRLOC2);
			this.GroupBox3.Controls.Add(this.rdoYRLOC1);
			this.GroupBox3.Location = new System.Drawing.Point(150, 202);
			this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroupBox3.Size = new System.Drawing.Size(207, 32);
			this.GroupBox3.TabIndex = 22;
			this.GroupBox3.TabStop = false;
			this.rdoYRLOC2.AutoSize = true;
			this.rdoYRLOC2.Location = new System.Drawing.Point(97, 9);
			this.rdoYRLOC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdoYRLOC2.Name = "rdoYRLOC2";
			this.rdoYRLOC2.Size = new System.Drawing.Size(71, 20);
			this.rdoYRLOC2.TabIndex = 10;
			this.rdoYRLOC2.Text = "Trailing";
			this.rdoYRLOC2.UseVisualStyleBackColor = true;
			this.rdoYRLOC1.AutoSize = true;
			this.rdoYRLOC1.Checked = true;
			this.rdoYRLOC1.Location = new System.Drawing.Point(5, 9);
			this.rdoYRLOC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdoYRLOC1.Name = "rdoYRLOC1";
			this.rdoYRLOC1.Size = new System.Drawing.Size(75, 20);
			this.rdoYRLOC1.TabIndex = 9;
			this.rdoYRLOC1.TabStop = true;
			this.rdoYRLOC1.Text = "Leading";
			this.rdoYRLOC1.UseVisualStyleBackColor = true;
			this.GroupBox4.Controls.Add(this.rdoCNTRLNO1);
			this.GroupBox4.Controls.Add(this.rdoCNTRLNO2);
			this.GroupBox4.Location = new System.Drawing.Point(150, 94);
			this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroupBox4.Size = new System.Drawing.Size(207, 32);
			this.GroupBox4.TabIndex = 4;
			this.GroupBox4.TabStop = false;
			this.rdoCNTRLNO1.AutoSize = true;
			this.rdoCNTRLNO1.Checked = true;
			this.rdoCNTRLNO1.Location = new System.Drawing.Point(5, 9);
			this.rdoCNTRLNO1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdoCNTRLNO1.Name = "rdoCNTRLNO1";
			this.rdoCNTRLNO1.Size = new System.Drawing.Size(53, 20);
			this.rdoCNTRLNO1.TabIndex = 4;
			this.rdoCNTRLNO1.TabStop = true;
			this.rdoCNTRLNO1.Text = "Auto";
			this.rdoCNTRLNO1.UseVisualStyleBackColor = true;
			this.rdoCNTRLNO2.AutoSize = true;
			this.rdoCNTRLNO2.Location = new System.Drawing.Point(97, 9);
			this.rdoCNTRLNO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdoCNTRLNO2.Name = "rdoCNTRLNO2";
			this.rdoCNTRLNO2.Size = new System.Drawing.Size(70, 20);
			this.rdoCNTRLNO2.TabIndex = 5;
			this.rdoCNTRLNO2.Text = "Manual";
			this.rdoCNTRLNO2.UseVisualStyleBackColor = true;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 272);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(121, 16);
			this.Label10.TabIndex = 22;
			this.Label10.Text = "Running No Length";
			this.txtSMPL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtSMPL.BackColor = System.Drawing.SystemColors.Window;
			this.txtSMPL.Enabled = false;
			this.txtSMPL.Location = new System.Drawing.Point(150, 295);
			this.txtSMPL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSMPL.Name = "txtSMPL";
			this.txtSMPL.Size = new System.Drawing.Size(272, 22);
			this.txtSMPL.TabIndex = 15;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 298);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(91, 16);
			this.Label7.TabIndex = 6;
			this.Label7.Text = "Sample Prefix";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 183);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(138, 16);
			this.Label4.TabIndex = 4;
			this.Label4.Text = "Include Date As Prefix";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 212);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(141, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Location of Date Prefix";
			this.txtPREFIX.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtPREFIX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPREFIX.Location = new System.Drawing.Point(150, 130);
			this.txtPREFIX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPREFIX.Name = "txtPREFIX";
			this.txtPREFIX.Size = new System.Drawing.Size(121, 22);
			this.txtPREFIX.TabIndex = 6;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 246);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(108, 16);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Next Running No";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 133);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(41, 16);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Prefix";
			this.txtNUMNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtNUMNM.Location = new System.Drawing.Point(150, 68);
			this.txtNUMNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNUMNM.Name = "txtNUMNM";
			this.txtNUMNM.Size = new System.Drawing.Size(399, 22);
			this.txtNUMNM.TabIndex = 3;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 71);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(141, 16);
			this.Label1.TabIndex = 14;
			this.Label1.Text = "Control Number Name";
			this.lblMDLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMDLCD.AutoSize = true;
			this.lblMDLCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMDLCD.Location = new System.Drawing.Point(3, 7);
			this.lblMDLCD.Name = "lblMDLCD";
			this.lblMDLCD.Size = new System.Drawing.Size(76, 16);
			this.lblMDLCD.TabIndex = 1;
			this.lblMDLCD.Text = "Program ID";
			this.lblREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREVNO.AutoSize = true;
			this.lblREVNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREVNO.Location = new System.Drawing.Point(3, 102);
			this.lblREVNO.Name = "lblREVNO";
			this.lblREVNO.Size = new System.Drawing.Size(138, 16);
			this.lblREVNO.TabIndex = 2;
			this.lblREVNO.Text = "Document No Control ";
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 339);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(56, 16);
			this.lblREMRK.TabIndex = 4;
			this.lblREMRK.Text = "Remark";
			this.txtRUNNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRUNNO.Location = new System.Drawing.Point(150, 243);
			this.txtRUNNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRUNNO.Name = "txtRUNNO";
			this.txtRUNNO.Size = new System.Drawing.Size(121, 22);
			this.txtRUNNO.TabIndex = 13;
			this.chkICLYR.AutoSize = true;
			this.chkICLYR.Location = new System.Drawing.Point(150, 184);
			this.chkICLYR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chkICLYR.Name = "chkICLYR";
			this.chkICLYR.Size = new System.Drawing.Size(15, 14);
			this.chkICLYR.TabIndex = 8;
			this.chkICLYR.UseVisualStyleBackColor = true;
			this.txtRUNNOLEN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRUNNOLEN.Location = new System.Drawing.Point(150, 269);
			this.txtRUNNOLEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRUNNOLEN.Name = "txtRUNNOLEN";
			this.txtRUNNOLEN.Size = new System.Drawing.Size(58, 22);
			this.txtRUNNOLEN.TabIndex = 14;
			this.txtREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 3);
			this.txtREMRK.Location = new System.Drawing.Point(150, 321);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(655, 52);
			this.txtREMRK.TabIndex = 16;
			this.txtDOCID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtDOCID.Location = new System.Drawing.Point(150, 32);
			this.txtDOCID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOCID.Name = "txtDOCID";
			this.txtDOCID.Size = new System.Drawing.Size(272, 22);
			this.txtDOCID.TabIndex = 2;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(555, 212);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(82, 16);
			this.Label6.TabIndex = 5;
			this.Label6.Text = "Date Format";
			this.GroupBox5.Controls.Add(this.rdoYRDGT1);
			this.GroupBox5.Controls.Add(this.rdoYRDGT2);
			this.GroupBox5.Location = new System.Drawing.Point(643, 202);
			this.GroupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroupBox5.Size = new System.Drawing.Size(207, 37);
			this.GroupBox5.TabIndex = 23;
			this.GroupBox5.TabStop = false;
			this.rdoYRDGT1.AutoSize = true;
			this.rdoYRDGT1.Checked = true;
			this.rdoYRDGT1.Location = new System.Drawing.Point(5, 9);
			this.rdoYRDGT1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdoYRDGT1.Name = "rdoYRDGT1";
			this.rdoYRDGT1.Size = new System.Drawing.Size(44, 20);
			this.rdoYRDGT1.TabIndex = 11;
			this.rdoYRDGT1.TabStop = true;
			this.rdoYRDGT1.Text = "YY";
			this.rdoYRDGT1.UseVisualStyleBackColor = true;
			this.rdoYRDGT2.AutoSize = true;
			this.rdoYRDGT2.Location = new System.Drawing.Point(97, 9);
			this.rdoYRDGT2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdoYRDGT2.Name = "rdoYRDGT2";
			this.rdoYRDGT2.Size = new System.Drawing.Size(66, 20);
			this.rdoYRDGT2.TabIndex = 12;
			this.rdoYRDGT2.Text = "YYMM";
			this.rdoYRDGT2.UseVisualStyleBackColor = true;
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
			this.TableLayoutPanel2.Controls.Add(this.cbPRGIDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbPRGIDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label9, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label15, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(553, 30);
			this.TableLayoutPanel2.TabIndex = 3;
			this.cbPRGIDTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPRGIDTO.FormattingEnabled = true;
			this.cbPRGIDTO.Location = new System.Drawing.Point(336, 3);
			this.cbPRGIDTO.Name = "cbPRGIDTO";
			this.cbPRGIDTO.Size = new System.Drawing.Size(214, 24);
			this.cbPRGIDTO.TabIndex = 26;
			this.cbPRGIDFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPRGIDFR.FormattingEnabled = true;
			this.cbPRGIDFR.Location = new System.Drawing.Point(85, 3);
			this.cbPRGIDFR.Name = "cbPRGIDFR";
			this.cbPRGIDFR.Size = new System.Drawing.Size(214, 24);
			this.cbPRGIDFR.TabIndex = 25;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(305, 7);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(25, 16);
			this.Label9.TabIndex = 5;
			this.Label9.Text = "To";
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 7);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(76, 16);
			this.Label15.TabIndex = 1;
			this.Label15.Text = "Program ID";
			this.dgvMANUM.AllowUserToAddRows = false;
			this.dgvMANUM.AllowUserToDeleteRows = false;
			this.dgvMANUM.AllowUserToResizeRows = false;
			this.dgvMANUM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMANUM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMANUM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMANUM.Columns.AddRange(this.MANUM_PRGID, this.MANUM_DOCID, this.MANUM_NUMNM, this.MANUM_CNTRLNO, this.MANUM_PREFIX, this.MANUM_SPCLPREF, this.MANUM_ICLYR, this.MANUM_YRLOC, this.YRLOC, this.MANUM_YRDGT, this.YRDGT, this.MANUM_RUNNO, this.MANUM_RUNNOLEN, this.MANUM_REMRK);
			this.dgvMANUM.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvMANUM.Location = new System.Drawing.Point(5, 118);
			this.dgvMANUM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMANUM.MultiSelect = false;
			this.dgvMANUM.Name = "dgvMANUM";
			this.dgvMANUM.ReadOnly = true;
			this.dgvMANUM.RowHeadersVisible = false;
			this.dgvMANUM.RowHeadersWidth = 10;
			this.dgvMANUM.RowTemplate.Height = 24;
			this.dgvMANUM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMANUM.Size = new System.Drawing.Size(1329, 503);
			this.dgvMANUM.TabIndex = 2;
			this.MANUM_PRGID.HeaderText = "Program ID";
			this.MANUM_PRGID.Name = "MANUM_PRGID";
			this.MANUM_PRGID.ReadOnly = true;
			this.MANUM_PRGID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_DOCID.DataPropertyName = "MANUM_DOCID";
			this.MANUM_DOCID.HeaderText = "Document ID";
			this.MANUM_DOCID.Name = "MANUM_DOCID";
			this.MANUM_DOCID.ReadOnly = true;
			this.MANUM_DOCID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_NUMNM.HeaderText = "Control Number Name";
			this.MANUM_NUMNM.Name = "MANUM_NUMNM";
			this.MANUM_NUMNM.ReadOnly = true;
			this.MANUM_NUMNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_NUMNM.Width = 200;
			this.MANUM_CNTRLNO.HeaderText = "Document No Control";
			this.MANUM_CNTRLNO.Name = "MANUM_CNTRLNO";
			this.MANUM_CNTRLNO.ReadOnly = true;
			this.MANUM_CNTRLNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_CNTRLNO.Width = 150;
			this.MANUM_PREFIX.HeaderText = "Prefix";
			this.MANUM_PREFIX.Name = "MANUM_PREFIX";
			this.MANUM_PREFIX.ReadOnly = true;
			this.MANUM_PREFIX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_PREFIX.Width = 90;
			this.MANUM_SPCLPREF.DataPropertyName = "MANUM_SPCLPREF";
			this.MANUM_SPCLPREF.HeaderText = "Special Prefix";
			this.MANUM_SPCLPREF.Name = "MANUM_SPCLPREF";
			this.MANUM_SPCLPREF.ReadOnly = true;
			this.MANUM_SPCLPREF.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_ICLYR.HeaderText = "Include Year";
			this.MANUM_ICLYR.Name = "MANUM_ICLYR";
			this.MANUM_ICLYR.ReadOnly = true;
			this.MANUM_ICLYR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.MANUM_YRLOC.HeaderText = "MANUM_YRLOC";
			this.MANUM_YRLOC.Name = "MANUM_YRLOC";
			this.MANUM_YRLOC.ReadOnly = true;
			this.MANUM_YRLOC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.MANUM_YRLOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_YRLOC.Visible = false;
			this.MANUM_YRLOC.Width = 150;
			this.YRLOC.HeaderText = "Year Location";
			this.YRLOC.Name = "YRLOC";
			this.YRLOC.ReadOnly = true;
			this.YRLOC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_YRDGT.HeaderText = "MANUM_YRDGT";
			this.MANUM_YRDGT.Name = "MANUM_YRDGT";
			this.MANUM_YRDGT.ReadOnly = true;
			this.MANUM_YRDGT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_YRDGT.Visible = false;
			this.YRDGT.HeaderText = "Year Format";
			this.YRDGT.Name = "YRDGT";
			this.YRDGT.ReadOnly = true;
			this.YRDGT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_RUNNO.HeaderText = "Running No";
			this.MANUM_RUNNO.Name = "MANUM_RUNNO";
			this.MANUM_RUNNO.ReadOnly = true;
			this.MANUM_RUNNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_RUNNOLEN.HeaderText = "Running No Length";
			this.MANUM_RUNNOLEN.Name = "MANUM_RUNNOLEN";
			this.MANUM_RUNNOLEN.ReadOnly = true;
			this.MANUM_RUNNOLEN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_RUNNOLEN.Width = 140;
			this.MANUM_REMRK.HeaderText = "Remark";
			this.MANUM_REMRK.Name = "MANUM_REMRK";
			this.MANUM_REMRK.ReadOnly = true;
			this.MANUM_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MANUM_REMRK.Width = 250;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 22;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvMANUM);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 630);
			this.Panel2.TabIndex = 23;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNEW, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 56);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel4.TabIndex = 20;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(255, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmMAENUM";
			base.Tag = "MAENUM";
			this.Text = "Document Number Control";
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox5.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMANUM).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			if (ValidateDetails())
			{
				spMAENUM("0");
			}
		}

		private void txtPREFIX_TextChanged(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT LPRG_PRGID, LPRG_DESC ";
			strSQL += "FROM LPRG_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY LPRG_DESC ";
			cbPRGID.ValueMember = "LPRG_PRGID";
			cbPRGID.DisplayMember = "LPRG_DESC";
			Common.RetriveComboItembySQL(strSQL, cbPRGID);
		}

		public void DisplaySample()
		{
			string strSPECIAL = cboSPCLPREF.Text;
			checked
			{
				int value = (int)Math.Round(Conversion.Val(txtRUNNO.Text));
				string strFORMAT = value.ToString("D" + (int)Math.Round((double)value.ToString("D").Length + Conversion.Val(txtRUNNOLEN.Text)));
				string strRUNNO = Strings.Right(strFORMAT, (int)Math.Round(Conversion.Val(txtRUNNOLEN.Text)));
				if (chkICLYR.Checked)
				{
					string strYRLOC = ((!rdoYRLOC1.Checked) ? "2" : "1");
					string strYRDGT = ((!rdoYRDGT1.Checked) ? (DateAndTime.Now.ToString("yy") + DateAndTime.Now.ToString("MM")) : DateAndTime.Now.ToString("yy"));
					if (Operators.CompareString(strYRLOC, "1", false) == 0)
					{
						txtSMPL.Text = strYRDGT + txtPREFIX.Text + strSPECIAL + strRUNNO;
					}
					else
					{
						txtSMPL.Text = txtPREFIX.Text + strYRDGT + strSPECIAL + strRUNNO;
					}
				}
				else
				{
					txtSMPL.Text = txtPREFIX.Text + strSPECIAL + strRUNNO;
				}
			}
		}

		public bool spMAENUM(string strPRO)
		{
			int intCNTRLNO = (rdoCNTRLNO1.Checked ? 1 : 2);
			int intYRLOC = (rdoYRLOC1.Checked ? 1 : 2);
			int intYRDGT = (rdoYRDGT1.Checked ? 1 : 2);
			string strSQL = "EXEC spMAENUM ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPRGID.SelectedValue), "', ")));
			strSQL = strSQL + "'" + txtDOCID.Text + "', ";
			strSQL = strSQL + "'" + txtNUMNM.Text + "', ";
			strSQL = strSQL + Conversions.ToString(intCNTRLNO) + ", ";
			strSQL = strSQL + "'" + txtPREFIX.Text + "', ";
			strSQL = strSQL + "'" + cboSPCLPREF.Text + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(chkICLYR.Checked) * -1.0) + ", ";
			strSQL = strSQL + Conversions.ToString(intYRLOC) + ", ";
			strSQL = strSQL + Conversions.ToString(intYRDGT) + ", ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(txtRUNNO.Text)) + ", ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(txtRUNNOLEN.Text)) + ", ";
			strSQL = strSQL + "'" + txtREMRK.Text + "', ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
			bool spMAENUM;
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), Conversions.ToString(Interaction.IIf(Operators.CompareString(strPRO, "0", false) == 0, "Record saved!", "Record deleted!"))), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				spMAENUM = false;
				ProjectData.ClearProjectError();
				goto IL_0292;
			}
			ClearDetails();
			Header();
			spMAENUM = true;
			goto IL_0292;
			IL_0292:
			return spMAENUM;
		}

		public void ClearDetails()
		{
			cbPRGID.SelectedIndex = -1;
			txtDOCID.Text = string.Empty;
			txtNUMNM.Text = string.Empty;
			rdoCNTRLNO1.Checked = true;
			rdoCNTRLNO2.Checked = false;
			txtPREFIX.Text = string.Empty;
			cboSPCLPREF.SelectedIndex = 0;
			chkICLYR.Checked = false;
			rdoYRLOC1.Checked = true;
			rdoYRLOC2.Checked = false;
			rdoYRDGT1.Checked = true;
			rdoYRDGT2.Checked = false;
			txtRUNNO.Text = string.Empty;
			txtRUNNOLEN.Text = string.Empty;
			txtSMPL.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
			cbPRGID.Enabled = true;
			txtDOCID.Enabled = true;
			btnSAVE.Tag = "Save";
		}

		private void BindComboHeader()
		{
			string strSQL = "SELECT '' as MANUM_PRGID, '' as LPRG_DESC ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MANUM_PRGID, LPRG_DESC ";
			strSQL += "FROM MANUM_TBL WITH(NOLOCK) ";
			strSQL += "LEFT JOIN LPRG_TBL ON LPRG_PRGID = MANUM_PRGID  ";
			strSQL += "ORDER BY MANUM_PRGID ";
			cbPRGIDFR.ValueMember = "MANUM_PRGID";
			cbPRGIDFR.DisplayMember = "LPRG_DESC";
			Common.RetriveComboItembySQL(strSQL, cbPRGIDFR);
			cbPRGIDTO.ValueMember = "MANUM_PRGID";
			cbPRGIDTO.DisplayMember = "LPRG_DESC";
			Common.RetriveComboItembySQL(strSQL, cbPRGIDTO);
		}

		public void Header()
		{
			int count = dgvMANUM.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvMANUM.Rows.Remove(dgvMANUM.Rows[0]);
				}
				string strSQL = "EXEC spMANUM '0', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPRGIDFR.SelectedValue)) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPRGIDTO.SelectedValue)) + "'";
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvMANUM.ClearSelection();
						dgvMANUM.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvMANUM.Rows[dgvMANUM.Rows.Count - 1];
						dataGridViewRow.Cells["MANUM_PRGID"].Value = dt.Rows[i]["MANUM_PRGID"].ToString();
						dataGridViewRow.Cells["MANUM_DOCID"].Value = dt.Rows[i]["MANUM_DOCID"].ToString();
						dataGridViewRow.Cells["MANUM_NUMNM"].Value = dt.Rows[i]["MANUM_NUMNM"].ToString();
						dataGridViewRow.Cells["MANUM_CNTRLNO"].Value = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MANUM_CNTRLNO"]);
						dataGridViewRow.Cells["MANUM_PREFIX"].Value = dt.Rows[i]["MANUM_PREFIX"].ToString();
						dataGridViewRow.Cells["MANUM_ICLYR"].Value = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MANUM_ICLYR"]);
						dataGridViewRow.Cells["MANUM_YRLOC"].Value = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MANUM_YRLOC"]);
						dataGridViewRow.Cells["YRLOC"].Value = dt.Rows[i]["YRLOC"].ToString();
						dataGridViewRow.Cells["MANUM_YRDGT"].Value = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MANUM_YRDGT"]);
						dataGridViewRow.Cells["YRDGT"].Value = dt.Rows[i]["YRDGT"].ToString();
						dataGridViewRow.Cells["MANUM_RUNNO"].Value = dt.Rows[i]["MANUM_RUNNO"].ToString();
						dataGridViewRow.Cells["MANUM_RUNNOLEN"].Value = dt.Rows[i]["MANUM_RUNNOLEN"].ToString();
						dataGridViewRow.Cells["MANUM_REMRK"].Value = dt.Rows[i]["MANUM_REMRK"].ToString();
						dataGridViewRow.Cells["MANUM_SPCLPREF"].Value = dt.Rows[i]["MANUM_SPCLPREF"].ToString();
						dataGridViewRow = null;
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), ex.Message), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void chkICLYR_CheckedChanged(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void rdoYRDGT2_CheckedChanged(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void frmMAENUM_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAENUM_Shown(object sender, EventArgs e)
		{
			SetMaxLength();
			BindComboHeader();
			Header();
		}

		private void txtRUNNO_TextChanged(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void txtRUNNOLEN_TextChanged(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void rdoYRDGT1_CheckedChanged(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void rdoYRLOC1_CheckedChanged(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void rdoYRLOC2_Click(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnNEW_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			ClearDetails();
			BindComboBox();
		}

		private void SetMaxLength()
		{
			txtDOCID.MaxLength = DB.CharColumnMaxLength("MANUM_TBL", "MANUM_DOCID");
			txtNUMNM.MaxLength = DB.CharColumnMaxLength("MANUM_TBL", "MANUM_NUMNM");
			txtPREFIX.MaxLength = DB.CharColumnMaxLength("MANUM_TBL", "MANUM_PREFIX");
			txtREMRK.MaxLength = DB.CharColumnMaxLength("MANUM_TBL", "MANUM_REMRK");
		}

		public void BindHeadertoControl()
		{
			cbPRGID.SelectedValue = dgvMANUM.CurrentRow.Cells["MANUM_PRGID"].Value.ToString();
			txtDOCID.Text = dgvMANUM.CurrentRow.Cells["MANUM_DOCID"].Value.ToString();
			txtNUMNM.Text = dgvMANUM.CurrentRow.Cells["MANUM_NUMNM"].Value.ToString();
			object value = dgvMANUM.CurrentRow.Cells["MANUM_CNTRLNO"].Value;
			if (Operators.ConditionalCompareObjectEqual(value, 1, false))
			{
				rdoCNTRLNO1.Checked = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(value, 2, false))
			{
				rdoCNTRLNO2.Checked = true;
			}
			else
			{
				rdoCNTRLNO1.Checked = false;
				rdoCNTRLNO2.Checked = false;
			}
			txtPREFIX.Text = dgvMANUM.CurrentRow.Cells["MANUM_PREFIX"].Value.ToString();
			if (Operators.CompareString(dgvMANUM.CurrentRow.Cells["MANUM_SPCLPREF"].Value.ToString(), "-", false) == 0)
			{
				cboSPCLPREF.SelectedIndex = 0;
			}
			else
			{
				cboSPCLPREF.SelectedIndex = 1;
			}
			chkICLYR.Checked = Conversions.ToBoolean(dgvMANUM.CurrentRow.Cells["MANUM_ICLYR"].Value.ToString());
			object value2 = dgvMANUM.CurrentRow.Cells["MANUM_YRLOC"].Value;
			if (Operators.ConditionalCompareObjectEqual(value2, 1, false))
			{
				rdoYRLOC1.Checked = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(value2, 2, false))
			{
				rdoYRLOC2.Checked = true;
			}
			else
			{
				rdoYRLOC1.Checked = false;
				rdoYRLOC2.Checked = false;
			}
			object value3 = dgvMANUM.CurrentRow.Cells["MANUM_YRDGT"].Value;
			if (Operators.ConditionalCompareObjectEqual(value3, 1, false))
			{
				rdoYRDGT1.Checked = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(value3, 2, false))
			{
				rdoYRDGT2.Checked = true;
			}
			else
			{
				rdoYRDGT1.Checked = false;
				rdoYRDGT2.Checked = false;
			}
			txtRUNNO.Text = dgvMANUM.CurrentRow.Cells["MANUM_RUNNO"].Value.ToString();
			txtRUNNOLEN.Text = dgvMANUM.CurrentRow.Cells["MANUM_RUNNOLEN"].Value.ToString();
			txtREMRK.Text = dgvMANUM.CurrentRow.Cells["MANUM_REMRK"].Value.ToString();
			NewLateBinding.LateIndexSetComplex(cbPRGID.SelectedItem, new object[2]
			{
				1,
				DB.GetColumnValue("LPRG_DESC", "LPRG_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("LPRG_PRGID = '", cbPRGID.SelectedValue), "'")))
			}, null, false, true);
		}

		private void dgvMANUM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			BindComboBox();
			BindHeadertoControl();
			cbPRGID.Enabled = false;
			txtDOCID.Enabled = false;
			btnDelete.Enabled = true;
			btnPRINT.Enabled = true;
			btnSAVE.Tag = "Update";
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			BindComboHeader();
			Header();
			ClearDetails();
		}

		private bool ValidateDetails()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbPRGID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Program ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbPRGID.Select();
				return false;
			}
			if (Operators.CompareString(txtDOCID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtDOCID.Select();
				return false;
			}
			if (Operators.CompareString(txtNUMNM.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Control Number Name cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtNUMNM.Select();
				return false;
			}
			if (Operators.CompareString(txtPREFIX.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Prefix cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtPREFIX.Select();
				return false;
			}
			if (Conversion.Val(txtRUNNO.Text.Trim()) <= 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Running No must be more than 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtRUNNO.Select();
				return false;
			}
			if (Conversion.Val(txtRUNNOLEN.Text.Trim()) <= 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total Length of Running No must more than 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtRUNNOLEN.Select();
				return false;
			}
			if (Conversion.Val(txtRUNNOLEN.Text.Trim()) > 15.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total Length of Running No must less than 15!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtRUNNOLEN.Select();
				return false;
			}
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT MANUM_PRGID FROM MANUM_TBL WHERE MANUM_PRGID = '", cbPRGID.SelectedValue), "'AND MANUM_DOCID = '"), txtDOCID.Text), "'"));
			if (Operators.ConditionalCompareObjectEqual(btnSAVE.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Program ID and Document ID already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbPRGID.Select();
				return false;
			}
			return true;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spMAENUM("1");
				ClearDetails();
				Header();
			}
		}

		private void cboSPCLPREF_TextChanged(object sender, EventArgs e)
		{
			DisplaySample();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAENUM_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbPRGIDFR_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbPRGIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbPRGIDFR.SelectedValue);
		}
	}
}
