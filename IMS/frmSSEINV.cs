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
	public class frmSSEINV : Form
	{
		private IContainer components;

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
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDOHeader")]
		private DataGridView _dgvDOHeader;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDELETEFR")]
		private Button _btnDELETEFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnInvoice")]
		private Button _btnInvoice;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSIDFR")]
		private ComboboxControl _cbCUSIDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbDOCNOFR")]
		private ComboboxControl _cbDOCNOFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSID")]
		private ComboboxControl _cbCUSID;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("txtDOCNO")]
		internal virtual TextBox txtDOCNO
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

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvHEADER
		{
			[CompilerGenerated]
			get
			{
				return _dgvHEADER;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvHEADER_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvHEADER;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvHEADER = value;
				dataGridView = _dgvHEADER;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
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

		[field: AccessedThroughProperty("dtpDOCDTTO")]
		internal virtual DateTimePicker dtpDOCDTTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpDOCDTFR")]
		internal virtual DateTimePicker dtpDOCDTFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCUSIDTO")]
		internal virtual Label lblCUSIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCUSIDFR")]
		internal virtual Label lblCUSIDFR
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpDOCDT")]
		internal virtual DateTimePicker dtpDOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvDOHeader
		{
			[CompilerGenerated]
			get
			{
				return _dgvDOHeader;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDOHeader_CellMouseClick;
				DataGridView dataGridView = _dgvDOHeader;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvDOHeader = value;
				dataGridView = _dgvDOHeader;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
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

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numAMT")]
		internal virtual NumControl numAMT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numUPRICE")]
		internal virtual NumControl numUPRICE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtRECID")]
		internal virtual TextBox txtRECID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label16")]
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label17")]
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnDELETEFR
		{
			[CompilerGenerated]
			get
			{
				return _btnDELETEFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDELETEFR_Click;
				Button button = _btnDELETEFR;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDELETEFR = value;
				button = _btnDELETEFR;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtCURCD")]
		internal virtual TextBox txtCURCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label19")]
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numDOQTY")]
		internal virtual NumControl numDOQTY
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

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnInvoice
		{
			[CompilerGenerated]
			get
			{
				return _btnInvoice;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnInvoice_Click;
				Button button = _btnInvoice;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnInvoice = value;
				button = _btnInvoice;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSSHP_DOCNO")]
		internal virtual DataGridViewTextBoxColumn SSSHP_DOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSSHP_CUSID")]
		internal virtual DataGridViewTextBoxColumn SSSHP_CUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSSHP_PAYTM")]
		internal virtual DataGridViewTextBoxColumn SSSHP_PAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSSHP_DELID")]
		internal virtual DataGridViewTextBoxColumn SSSHP_DELID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSSHP_LOCID")]
		internal virtual DataGridViewTextBoxColumn SSSHP_LOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSSHP_STSFG")]
		internal virtual DataGridViewTextBoxColumn SSSHP_STSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSSHP_REMRK")]
		internal virtual DataGridViewTextBoxColumn SSSHP_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSSHP_DOCDT")]
		internal virtual DataGridViewTextBoxColumn SSSHP_DOCDT
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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREFNO")]
		internal virtual TextBox txtREFNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numINSURANCE")]
		internal virtual NumControl numINSURANCE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numFREIGHT")]
		internal virtual NumControl numFREIGHT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvDODetail")]
		internal virtual DataGridView dgvDODetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSINV_DOCNO")]
		internal virtual DataGridViewTextBoxColumn SSINV_DOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("DOCDT")]
		internal virtual DataGridViewTextBoxColumn DOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSINV_CUSID")]
		internal virtual DataGridViewTextBoxColumn SSINV_CUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSINV_PAYTM")]
		internal virtual DataGridViewTextBoxColumn SSINV_PAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("DODOCNO")]
		internal virtual DataGridViewTextBoxColumn DODOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSINV_FREIGHT")]
		internal virtual DataGridViewTextBoxColumn SSINV_FREIGHT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSINV_INSURANCE")]
		internal virtual DataGridViewTextBoxColumn SSINV_INSURANCE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSINV_REFNO")]
		internal virtual DataGridViewTextBoxColumn SSINV_REFNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSINV_REMRK")]
		internal virtual DataGridViewTextBoxColumn SSINV_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("SSINV_DOCDT")]
		internal virtual DataGridViewTextBoxColumn SSINV_DOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCUSIDTO")]
		internal virtual ComboboxControl cbCUSIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbCUSIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbCUSIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbCUSIDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbCUSIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbCUSIDFR = value;
				comboboxControl = _cbCUSIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbDOCNOTO")]
		internal virtual ComboboxControl cbDOCNOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbDOCNOFR
		{
			[CompilerGenerated]
			get
			{
				return _cbDOCNOFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbDOCNOFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbDOCNOFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbDOCNOFR = value;
				comboboxControl = _cbDOCNOFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		internal virtual ComboboxControl cbCUSID
		{
			[CompilerGenerated]
			get
			{
				return _cbCUSID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbCUSID_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbCUSID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbCUSID = value;
				comboboxControl = _cbCUSID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbPAYTM")]
		internal virtual ComboBox cbPAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmSSEINV()
		{
			base.Load += frmSSEINV_Load;
			base.FormClosing += frmSSESHP_FormClosing;
			base.KeyDown += frmSSESHP_KeyDown;
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnInvoice = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.cbPAYTM = new System.Windows.Forms.ComboBox();
			this.cbCUSID = new IMS.ComboboxControl();
			this.dgvDODetail = new System.Windows.Forms.DataGridView();
			this.numINSURANCE = new IMS.NumControl();
			this.numFREIGHT = new IMS.NumControl();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtREFNO = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtCURCD = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.dgvDOHeader = new System.Windows.Forms.DataGridView();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.SSINV_DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SSINV_CUSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SSINV_PAYTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DODOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SSINV_FREIGHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SSINV_INSURANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SSINV_REFNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SSINV_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SSINV_DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDELETEFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbCUSIDTO = new IMS.ComboboxControl();
			this.cbCUSIDFR = new IMS.ComboboxControl();
			this.Label17 = new System.Windows.Forms.Label();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDODetail).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvDOHeader).BeginInit();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel6);
			this.Panel1.Controls.Add(this.TableLayoutPanel5);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 638);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnInvoice, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel6.TabIndex = 0;
			this.btnInvoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnInvoice.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInvoice.Image = IMS.My.Resources.Resources.Print;
			this.btnInvoice.Location = new System.Drawing.Point(381, 2);
			this.btnInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnInvoice.Name = "btnInvoice";
			this.btnInvoice.Size = new System.Drawing.Size(120, 50);
			this.btnInvoice.TabIndex = 15;
			this.btnInvoice.Text = "Print Invoice";
			this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnInvoice.UseVisualStyleBackColor = false;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Confirm;
			this.btnSave.Location = new System.Drawing.Point(3, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 50);
			this.btnSave.TabIndex = 12;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
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
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
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
			this.btnBack.TabIndex = 14;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 4;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.cbPAYTM, 3, 2);
			this.TableLayoutPanel5.Controls.Add(this.cbCUSID, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.dgvDODetail, 2, 6);
			this.TableLayoutPanel5.Controls.Add(this.numINSURANCE, 3, 4);
			this.TableLayoutPanel5.Controls.Add(this.numFREIGHT, 3, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label15, 2, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label13, 2, 3);
			this.TableLayoutPanel5.Controls.Add(this.txtREFNO, 1, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label3, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.dtpDOCDT, 3, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label19, 2, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label11, 2, 2);
			this.TableLayoutPanel5.Controls.Add(this.txtCURCD, 3, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label12, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label9, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.txtREMRK, 1, 3);
			this.TableLayoutPanel5.Controls.Add(this.dgvDOHeader, 1, 6);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 7;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(1217, 550);
			this.TableLayoutPanel5.TabIndex = 0;
			this.cbPAYTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPAYTM.FormattingEnabled = true;
			this.cbPAYTM.Location = new System.Drawing.Point(660, 59);
			this.cbPAYTM.Name = "cbPAYTM";
			this.cbPAYTM.Size = new System.Drawing.Size(150, 24);
			this.cbPAYTM.TabIndex = 39;
			this.cbCUSID.BlankValue = null;
			this.cbCUSID.ComboboxWidth = 170;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = true;
			this.cbCUSID.Location = new System.Drawing.Point(104, 28);
			this.cbCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(334, 26);
			this.cbCUSID.TabIndex = 1;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
			this.dgvDODetail.AllowUserToAddRows = false;
			this.dgvDODetail.AllowUserToDeleteRows = false;
			this.dgvDODetail.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDODetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvDODetail, 2);
			this.dgvDODetail.Location = new System.Drawing.Point(544, 158);
			this.dgvDODetail.MultiSelect = false;
			this.dgvDODetail.Name = "dgvDODetail";
			this.dgvDODetail.ReadOnly = true;
			this.dgvDODetail.RowHeadersVisible = false;
			this.dgvDODetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDODetail.Size = new System.Drawing.Size(670, 389);
			this.dgvDODetail.TabIndex = 11;
			this.dgvDODetail.TabStop = false;
			this.numINSURANCE.AllowNegative = false;
			this.numINSURANCE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numINSURANCE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numINSURANCE.DataChanged = false;
			this.numINSURANCE.Location = new System.Drawing.Point(660, 118);
			this.numINSURANCE.Name = "numINSURANCE";
			this.numINSURANCE.NumberFormat = "8.2";
			this.numINSURANCE.Size = new System.Drawing.Size(75, 22);
			this.numINSURANCE.TabIndex = 8;
			this.numINSURANCE.Text = "0.00";
			this.numINSURANCE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numINSURANCE.ThousandSeperator = false;
			this.numINSURANCE.Value = 0.0;
			this.numFREIGHT.AllowNegative = false;
			this.numFREIGHT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numFREIGHT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numFREIGHT.DataChanged = false;
			this.numFREIGHT.Location = new System.Drawing.Point(660, 89);
			this.numFREIGHT.Name = "numFREIGHT";
			this.numFREIGHT.NumberFormat = "8.2";
			this.numFREIGHT.Size = new System.Drawing.Size(75, 22);
			this.numFREIGHT.TabIndex = 7;
			this.numFREIGHT.Text = "0.00";
			this.numFREIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFREIGHT.ThousandSeperator = false;
			this.numFREIGHT.Value = 0.0;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(544, 121);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(110, 16);
			this.Label15.TabIndex = 8;
			this.Label15.Text = "Freight Insurance";
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(544, 92);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(96, 16);
			this.Label13.TabIndex = 7;
			this.Label13.Text = "Freight Charge";
			this.txtREFNO.Location = new System.Drawing.Point(104, 58);
			this.txtREFNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREFNO.Name = "txtREFNO";
			this.txtREFNO.Size = new System.Drawing.Size(180, 22);
			this.txtREFNO.TabIndex = 5;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 5);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.txtDOCNO.Location = new System.Drawing.Point(104, 2);
			this.txtDOCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(544, 5);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(660, 2);
			this.dtpDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(544, 33);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(61, 16);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "Currency";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(544, 63);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(96, 16);
			this.Label11.TabIndex = 10;
			this.Label11.Text = "Payment Term";
			this.txtCURCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCURCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCURCD.Enabled = false;
			this.txtCURCD.Location = new System.Drawing.Point(660, 30);
			this.txtCURCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCURCD.Name = "txtCURCD";
			this.txtCURCD.Size = new System.Drawing.Size(87, 22);
			this.txtCURCD.TabIndex = 4;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 33);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(81, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Customer ID";
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(3, 63);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(95, 16);
			this.Label12.TabIndex = 6;
			this.Label12.Text = "Reference No.";
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 92);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.txtREMRK.Location = new System.Drawing.Point(104, 88);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.TableLayoutPanel5.SetRowSpan(this.txtREMRK, 2);
			this.txtREMRK.Size = new System.Drawing.Size(434, 55);
			this.txtREMRK.TabIndex = 9;
			this.dgvDOHeader.AllowUserToAddRows = false;
			this.dgvDOHeader.AllowUserToDeleteRows = false;
			this.dgvDOHeader.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDOHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDOHeader.Location = new System.Drawing.Point(104, 158);
			this.dgvDOHeader.MultiSelect = false;
			this.dgvDOHeader.Name = "dgvDOHeader";
			this.dgvDOHeader.RowHeadersVisible = false;
			this.dgvDOHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDOHeader.Size = new System.Drawing.Size(434, 389);
			this.dgvDOHeader.TabIndex = 10;
			this.dgvDOHeader.TabStop = false;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 638);
			this.Panel2.TabIndex = 2;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Columns.AddRange(this.SSINV_DOCNO, this.DOCDT, this.SSINV_CUSID, this.SSINV_PAYTM, this.DODOCNO, this.SSINV_FREIGHT, this.SSINV_INSURANCE, this.SSINV_REFNO, this.SSINV_REMRK, this.SSINV_DOCDT);
			this.dgvHEADER.Location = new System.Drawing.Point(5, 179);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1258, 441);
			this.dgvHEADER.TabIndex = 0;
			this.SSINV_DOCNO.HeaderText = "Document No";
			this.SSINV_DOCNO.Name = "SSINV_DOCNO";
			this.SSINV_DOCNO.ReadOnly = true;
			this.SSINV_DOCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DOCDT.HeaderText = "Document Date";
			this.DOCDT.Name = "DOCDT";
			this.DOCDT.ReadOnly = true;
			this.DOCDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DOCDT.Width = 110;
			this.SSINV_CUSID.HeaderText = "Customer ID";
			this.SSINV_CUSID.Name = "SSINV_CUSID";
			this.SSINV_CUSID.ReadOnly = true;
			this.SSINV_CUSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.SSINV_PAYTM.HeaderText = "Payment Term";
			this.SSINV_PAYTM.Name = "SSINV_PAYTM";
			this.SSINV_PAYTM.ReadOnly = true;
			this.SSINV_PAYTM.Width = 120;
			this.DODOCNO.HeaderText = "DO No.";
			this.DODOCNO.Name = "DODOCNO";
			this.DODOCNO.ReadOnly = true;
			this.DODOCNO.Width = 300;
			this.SSINV_FREIGHT.HeaderText = "SSINV_FREIGHT";
			this.SSINV_FREIGHT.Name = "SSINV_FREIGHT";
			this.SSINV_FREIGHT.ReadOnly = true;
			this.SSINV_FREIGHT.Visible = false;
			this.SSINV_INSURANCE.HeaderText = "SSINV_INSURANCE";
			this.SSINV_INSURANCE.Name = "SSINV_INSURANCE";
			this.SSINV_INSURANCE.ReadOnly = true;
			this.SSINV_INSURANCE.Visible = false;
			this.SSINV_REFNO.HeaderText = "SSINV_REFNO";
			this.SSINV_REFNO.Name = "SSINV_REFNO";
			this.SSINV_REFNO.ReadOnly = true;
			this.SSINV_REFNO.Visible = false;
			this.SSINV_REMRK.HeaderText = "Remark";
			this.SSINV_REMRK.Name = "SSINV_REMRK";
			this.SSINV_REMRK.ReadOnly = true;
			this.SSINV_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.SSINV_REMRK.Width = 500;
			this.SSINV_DOCDT.HeaderText = "SSSHP_DOCDT";
			this.SSINV_DOCDT.Name = "SSINV_DOCDT";
			this.SSINV_DOCDT.ReadOnly = true;
			this.SSINV_DOCDT.Visible = false;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.Controls.Add(this.btnDELETEFR, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 117);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel4.TabIndex = 9;
			this.btnDELETEFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDELETEFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDELETEFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDELETEFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDELETEFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDELETEFR.Image = IMS.My.Resources.Resources.Delete;
			this.btnDELETEFR.Location = new System.Drawing.Point(255, 2);
			this.btnDELETEFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDELETEFR.Name = "btnDELETEFR";
			this.btnDELETEFR.Size = new System.Drawing.Size(120, 50);
			this.btnDELETEFR.TabIndex = 10;
			this.btnDELETEFR.Text = "Delete";
			this.btnDELETEFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDELETEFR.UseVisualStyleBackColor = false;
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
			this.btnSEARCH.TabIndex = 8;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
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
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
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
			this.btnNew.TabIndex = 9;
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
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(808, 86);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbCUSIDTO.BlankValue = null;
			this.cbCUSIDTO.ComboboxWidth = 170;
			this.cbCUSIDTO.DataTable = null;
			this.cbCUSIDTO.DisplayMember = null;
			this.cbCUSIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDTO.HasBlankValue = true;
			this.cbCUSIDTO.Location = new System.Drawing.Point(477, 32);
			this.cbCUSIDTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbCUSIDTO.Name = "cbCUSIDTO";
			this.cbCUSIDTO.SelectedIndex = -1;
			this.cbCUSIDTO.SelectedItem = null;
			this.cbCUSIDTO.SelectedValue = null;
			this.cbCUSIDTO.Size = new System.Drawing.Size(327, 26);
			this.cbCUSIDTO.TabIndex = 52;
			this.cbCUSIDTO.TextMultiline = true;
			this.cbCUSIDTO.ValueMember = null;
			this.cbCUSIDTO.WhereClause = null;
			this.cbCUSIDFR.BlankValue = null;
			this.cbCUSIDFR.ComboboxWidth = 170;
			this.cbCUSIDFR.DataTable = null;
			this.cbCUSIDFR.DisplayMember = null;
			this.cbCUSIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDFR.HasBlankValue = true;
			this.cbCUSIDFR.Location = new System.Drawing.Point(111, 32);
			this.cbCUSIDFR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbCUSIDFR.Name = "cbCUSIDFR";
			this.cbCUSIDFR.SelectedIndex = -1;
			this.cbCUSIDFR.SelectedItem = null;
			this.cbCUSIDFR.SelectedValue = null;
			this.cbCUSIDFR.Size = new System.Drawing.Size(327, 26);
			this.cbCUSIDFR.TabIndex = 49;
			this.cbCUSIDFR.TextMultiline = true;
			this.cbCUSIDFR.ValueMember = null;
			this.cbCUSIDFR.WhereClause = null;
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 37);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(81, 16);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Customer ID";
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(477, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(327, 26);
			this.cbDOCNOTO.TabIndex = 50;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(111, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(327, 26);
			this.cbDOCNOFR.TabIndex = 51;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(445, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(476, 62);
			this.dtpDOCDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 6;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(110, 62);
			this.dtpDOCDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 5;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(445, 7);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(25, 16);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 7);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(90, 16);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Document No";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(445, 37);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 16);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 641);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmSSEINV";
			base.Tag = "SSEINV";
			this.Text = "Invoice Entry";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDODetail).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvDOHeader).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			RetrieveDOData("", "");
			ClearControl();
			BindComboBox();
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void ManageDOCNO()
		{
			txtDOCNO.Enabled = Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'SSEINV'"), 1, false)));
		}

		private void Header()
		{
			int count = dgvHEADER.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvHEADER.Rows.Remove(dgvHEADER.Rows[0]);
				}
				string strSQL = "EXEC spSSINV ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDTO.SelectedValue), "', ")));
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "'";
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvHEADER.ClearSelection();
						dgvHEADER.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvHEADER.Rows[dgvHEADER.Rows.Count - 1];
						dataGridViewRow.Cells["SSINV_DOCNO"].Value = dt.Rows[i]["SSINV_DOCNO"].ToString();
						dataGridViewRow.Cells["SSINV_DOCDT"].Value = dt.Rows[i]["SSINV_DOCDT"].ToString();
						dataGridViewRow.Cells["SSINV_CUSID"].Value = dt.Rows[i]["SSINV_CUSID"].ToString();
						dataGridViewRow.Cells["SSINV_PAYTM"].Value = dt.Rows[i]["SSINV_PAYTM"].ToString();
						dataGridViewRow.Cells["DODOCNO"].Value = dt.Rows[i]["DODOCNO"].ToString();
						dataGridViewRow.Cells["SSINV_FREIGHT"].Value = dt.Rows[i]["SSINV_FREIGHT"].ToString();
						dataGridViewRow.Cells["SSINV_INSURANCE"].Value = dt.Rows[i]["SSINV_INSURANCE"].ToString();
						dataGridViewRow.Cells["SSINV_REFNO"].Value = dt.Rows[i]["SSINV_REFNO"].ToString();
						dataGridViewRow.Cells["SSINV_REMRK"].Value = dt.Rows[i]["SSINV_REMRK"].ToString();
						dataGridViewRow.Cells["DOCDT"].Value = dt.Rows[i]["DOCDT"].ToString();
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

		private void ClearControl()
		{
			txtDOCNO.Text = string.Empty;
			dtpDOCDT.Value = DateAndTime.Today;
			cbCUSID.SelectedIndex = -1;
			txtCURCD.Text = string.Empty;
			txtREFNO.Text = string.Empty;
			cbPAYTM.SelectedIndex = -1;
			numFREIGHT.Value = 0.0;
			numINSURANCE.Value = 0.0;
			txtREMRK.Text = string.Empty;
			int count = dgvDOHeader.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvDOHeader.Rows.Remove(dgvDOHeader.Rows[0]);
				}
				int count2 = dgvDODetail.Rows.Count;
				for (int i = 1; i <= count2; i++)
				{
					dgvDODetail.Rows.Remove(dgvDODetail.Rows[0]);
				}
				cbCUSID.Enabled = true;
				dtpDOCDT.Enabled = true;
				btnDelete.Enabled = false;
				btnInvoice.Enabled = false;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			BindComboHeader();
			Header();
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindHeadertoControl();
			RetrieveDOData(dgvHEADER.CurrentRow.Cells["SSINV_CUSID"].Value.ToString(), dgvHEADER.CurrentRow.Cells["SSINV_DOCNO"].Value.ToString());
			RefreshDOGrid();
			Panel1.Visible = true;
			Panel2.Visible = false;
			cbCUSID.Enabled = false;
			dtpDOCDT.Enabled = false;
			btnDelete.Enabled = true;
			btnInvoice.Enabled = true;
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["SSINV_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["SSINV_DOCDT"].Value);
			cbCUSID.SelectedValue = dgvHEADER.CurrentRow.Cells["SSINV_CUSID"].Value.ToString();
			txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MACUS_CURCD", "MACUS_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CUSID = '", cbCUSID.SelectedValue), "'"))));
			cbPAYTM.SelectedValue = dgvHEADER.CurrentRow.Cells["SSINV_PAYTM"].Value.ToString();
			numFREIGHT.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["SSINV_FREIGHT"].Value.ToString());
			numINSURANCE.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["SSINV_INSURANCE"].Value.ToString());
			txtREFNO.Text = dgvHEADER.CurrentRow.Cells["SSINV_REFNO"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["SSINV_REMRK"].Value.ToString();
		}

		private void RetrieveDOData(string strCUSID, string strDOCNO)
		{
			string strSQL = "EXEC spSSEINV1 '" + MyProject.Computer.Name + "', '" + strCUSID + "', '" + strDOCNO + "'";
			cmd.Connection = DB.GetDBConnection();
			cmd.CommandText = strSQL;
			cmd.ExecuteNonQuery();
		}

		private void RefreshDOGrid()
		{
			int count = dgvDOHeader.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvDOHeader.Rows.Remove(dgvDOHeader.Rows[0]);
				}
				int count2 = dgvDODetail.Rows.Count;
				for (int i = 1; i <= count2; i++)
				{
					dgvDODetail.Rows.Remove(dgvDODetail.Rows[0]);
				}
				RefreshDOGrid1();
			}
		}

		private void RefreshDOGrid1()
		{
			int count = dgvDOHeader.Rows.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				dgvDOHeader.Rows.Remove(dgvDOHeader.Rows[0]);
			}
			string strSQL = "SELECT WRK_SELFG, CONVERT(VARCHAR, WRK_DOCDT, 103) AS WRK_DOCDT, WRK_DOCNO, WRK_DOAMT ";
			strSQL += "FROM SSINV_WRK1 ";
			strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "ORDER BY WRK_DOCDT, WRK_DOCNO";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDOHeader;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 30;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = "";
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].ReadOnly = true;
			dataGridView.Columns[1].Width = 100;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DO Date");
			dataGridView.Columns[2].Visible = true;
			dataGridView.Columns[2].ReadOnly = true;
			dataGridView.Columns[2].Width = 130;
			dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DO No");
			dataGridView.Columns[3].Visible = true;
			dataGridView.Columns[3].ReadOnly = true;
			dataGridView.Columns[3].Width = 90;
			dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total Amount");
			dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[3].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void RefreshDOGrid2(string strCUSID, string strDODOCNO)
		{
			int count = dgvDODetail.Rows.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				dgvDODetail.Rows.Remove(dgvDODetail.Rows[0]);
			}
			string strSQL = "SELECT SSSHP_ITMCD, MAITM_DESC, SSSHP_DOQTY, SSSHP_UPRICE, SSSHP_AMT, SSSHP_SODOCNO ";
			strSQL += "FROM SSSHP_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL ";
			strSQL += "ON MAITM_ITMCD = SSSHP_ITMCD ";
			strSQL = strSQL + "WHERE SSSHP_CUSID = '" + strCUSID + "' ";
			strSQL = strSQL + "AND SSSHP_DOCNO = '" + strDODOCNO + "' ";
			strSQL += "ORDER BY SSSHP_RECID";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDODetail;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 90;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 250;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
			dataGridView.Columns[2].Visible = true;
			dataGridView.Columns[2].Width = 60;
			dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DO Qty");
			dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[2].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
			dataGridView.Columns[3].Visible = true;
			dataGridView.Columns[3].Width = 70;
			dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Price");
			dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[3].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
			dataGridView.Columns[4].Visible = true;
			dataGridView.Columns[4].Width = 70;
			dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount");
			dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[4].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
			dataGridView.Columns[5].Visible = true;
			dataGridView.Columns[5].Width = 100;
			dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sales Order");
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void dgvDOHeader_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			RefreshDOGrid2(Conversions.ToString(cbCUSID.SelectedValue), Conversions.ToString(dgvDOHeader.CurrentRow.Cells["WRK_DOCNO"].Value));
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strCUSID = Conversions.ToString(cbCUSID.SelectedValue);
			string strDOCNO = txtDOCNO.Text;
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID");
			strMSG = strMSG + " : " + strCUSID + "\r\n";
			strMSG = strMSG + " " + Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + strDOCNO;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}
			string strSQL = "UPDATE SSSHP_TBL ";
			strSQL += "SET SSSHP_INVFG = 0 ";
			strSQL += "FROM SSINV_TBL ";
			strSQL = strSQL + "WHERE SSINV_CUSID = '" + strCUSID + "' ";
			strSQL = strSQL + "AND SSINV_DOCNO = '" + strDOCNO + "' ";
			strSQL += "AND SSINV_CUSID = SSSHP_CUSID ";
			strSQL += "AND SSINV_DODOCNO = SSSHP_DOCNO";
			if (DB.DBExecute(strSQL))
			{
				strSQL = "DELETE SSINV_TBL ";
				strSQL = strSQL + "WHERE SSINV_CUSID = '" + strCUSID + "' ";
				strSQL = strSQL + "AND SSINV_DOCNO = '" + strDOCNO + "'";
				if (DB.DBExecute(strSQL))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					BindComboHeader();
					Header();
				}
			}
		}

		private bool ValidateControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbCUSID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID cannot blank!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbCUSID.Focus();
				return false;
			}
			int count = dgvDOHeader.Rows.Count;
			for (int i = 1; i <= count && !Operators.ConditionalCompareObjectNotEqual(dgvDOHeader.Rows[i].Cells["SELFG"].Value, 0, false); i = checked(i + 1))
			{
				if (i == dgvDOHeader.Rows.Count)
				{
					string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Please select a DO!");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
			}
			return true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "SSSHP_TBL  WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "SSSHP_DOCNO";
			cbDOCNOFR.DisplayMember = "SSSHP_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "SSSHP_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "SSSHP_DOCNO";
			cbDOCNOTO.DisplayMember = "SSSHP_DOCNO";
			cbDOCNOTO.LoadData();
			cbCUSIDFR.DataTable = "MACUS_TBL  WITH (NOLOCK) ";
			cbCUSIDFR.ValueMember = "MACUS_CUSID";
			cbCUSIDFR.DisplayMember = "MACUS_CUSNM";
			cbCUSIDFR.LoadData();
			cbCUSIDTO.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSIDTO.ValueMember = "MACUS_CUSID";
			cbCUSIDTO.DisplayMember = "MACUS_CUSNM";
			cbCUSIDTO.LoadData();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'PAYTM' ORDER BY MACOD_CODID";
			cbPAYTM.ValueMember = "MACOD_CODID";
			cbPAYTM.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbPAYTM);
			cbCUSID.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSID.ValueMember = "MACUS_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			cbCUSID.LoadData();
		}

		private void btnDELETEFR_Click(object sender, EventArgs e)
		{
			if (dgvHEADER.RowCount == 0)
			{
				return;
			}
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID");
			strMSG = Conversions.ToString(Operators.ConcatenateObject(strMSG, Operators.ConcatenateObject(Operators.ConcatenateObject(" : ", dgvHEADER.CurrentRow.Cells["SSINV_CUSID"].Value), "\r\n")));
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = Conversions.ToString(Operators.ConcatenateObject(strMSG, Operators.ConcatenateObject(" : ", dgvHEADER.CurrentRow.Cells["SSINV_DOCNO"].Value)));
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}
			string strSQL = "UPDATE SSSHP_TBL ";
			strSQL += "SET SSSHP_INVFG = 0 ";
			strSQL += "FROM SSINV_TBL ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE SSINV_CUSID = '", dgvHEADER.CurrentRow.Cells["SSINV_CUSID"].Value), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND SSINV_DOCNO = '", dgvHEADER.CurrentRow.Cells["SSINV_DOCNO"].Value), "' ")));
			strSQL += "AND SSINV_CUSID = SSSHP_CUSID ";
			strSQL += "AND SSINV_DODOCNO = SSSHP_DOCNO";
			if (DB.DBExecute(strSQL))
			{
				strSQL = "DELETE SSINV_TBL ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE SSINV_CUSID = '", dgvHEADER.CurrentRow.Cells["SSINV_CUSID"].Value), "' ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND SSINV_DOCNO = '", dgvHEADER.CurrentRow.Cells["SSINV_DOCNO"].Value), "'")));
				if (DB.DBExecute(strSQL))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Header();
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string strNextNo = string.Empty;
			if (!ValidateDetailControl())
			{
				return;
			}
			try
			{
				if (Operators.ConditionalCompareObjectEqual(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'SSEINV'"), 1, false))
				{
					if (Operators.CompareString(txtDOCNO.Text.Trim(), string.Empty, false) == 0)
					{
						if (!Common.gfAutoNum("SSEINV", "SSINV", ref strNextNo))
						{
							string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control.");
							MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txtDOCNO.Focus();
							return;
						}
						txtDOCNO.Text = strNextNo;
					}
				}
				else if (Operators.CompareString(txtDOCNO.Text.Trim(), string.Empty, false) == 0)
				{
					string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank!");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtDOCNO.Focus();
					return;
				}
				if (DB.RecordExists("SELECT SSINV_ENTBY FROM SSINV_TBL WHERE SSINV_DOCNO = '" + txtDOCNO.Text + "'"))
				{
					string strENTBY = Conversions.ToString(DB.GetColumnValue("SSINV_ENTBY", "SSINV_TBL", "SSINV_DOCNO = '" + txtDOCNO.Text + "'"));
					if (!Common.gfAllowEdit(strENTBY))
					{
						MessageBox.Show("This document is view only!\r\nOnly Supervisor user or document creator is allowed to amend.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
				}
				string strSQL = "EXEC spSSEINV2 '" + MyProject.Computer.Name + "', '" + txtDOCNO.Text + "', '" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', '"), cbPAYTM.SelectedValue), "', "), numFREIGHT.Value), ", "), numINSURANCE.Value), ", ")));
				strSQL = strSQL + "'" + txtREFNO.Text + "', '" + txtREMRK.Text + "', '" + PublicVar.gstrLogonID + "'";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				cmd.ExecuteNonQuery();
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record saved!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				btnDelete.Enabled = true;
				btnInvoice.Enabled = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private void frmSSEINV_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			ManageDOCNO();
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			BindComboHeader();
			Header();
			NumberFormat();
		}

		private void frmSSESHP_FormClosing(object sender, FormClosingEventArgs e)
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

		private void NumberFormat()
		{
			numFREIGHT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Amount);
			numINSURANCE.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Amount);
		}

		private void frmSSESHP_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void btnInvoice_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "INVOICE";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptSSINV2.rpt";
			frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@CUSID=", cbCUSID.SelectedValue), ",@DOCNO="), txtDOCNO.Text), ""));
			frmRPT.Formulas = ("COMNM='" + PublicVar.gstrCompany + "',RPTTITLE='INVOICE',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbCUSID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID cannot blank!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbCUSID.Focus();
				return false;
			}
			checked
			{
				int num = dgvDOHeader.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string strSQL = "SELECT * FROM SLORD_TBL WITH(NOLOCK) ";
					strSQL += "LEFT JOIN SSSHP_TBL WITH(NOLOCK) ";
					strSQL += "ON SSSHP_SODOCNO = SLORD_DOCNO ";
					strSQL = strSQL + "WHERE SSSHP_DOCNO  = '" + Common.gfValidSQLStr(Conversions.ToString(dgvDOHeader.Rows[i].Cells["WRK_DOCNO"].Value)) + "' ";
					strSQL = strSQL + "AND SSSHP_CUSID  = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
					strSQL += "AND SSSHP_SODOCNO  = SLORD_DOCNO ";
					strSQL += "AND SLORD_UPRICE < 0 ";
					if (DB.RecordExists(strSQL))
					{
						string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sales Order Price cannot blank!");
						MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						cbCUSID.Focus();
						return false;
					}
				}
				int num2 = dgvDOHeader.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					string strSQL = "UPDATE SSINV_WRK1 ";
					strSQL = strSQL + "SET WRK_SELFG = " + Conversions.ToString(Conversions.ToInteger(dgvDOHeader.Rows[i].Cells["WRK_SELFG"].Value)) + " ";
					strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND WRK_DOCNO = '", dgvDOHeader.Rows[i].Cells["WRK_DOCNO"].Value), "'")));
					DB.ExecProc(strSQL);
				}
				if (!DB.RecordExists("SELECT * FROM SSINV_WRK1 WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' AND WRK_SELFG = 1"))
				{
					string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "At least one DO must selected!");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
				return true;
			}
		}

		private void cbDOCNOFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbDOCNOFR.SelectedIndex != -1)
			{
				cbDOCNOTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbDOCNOFR.SelectedValue);
			}
		}

		private void cbCUSIDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbCUSIDFR.SelectedIndex != -1)
			{
				cbCUSIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbCUSIDFR.SelectedValue);
			}
		}

		private void cbCUSID_SelectedValueChanged(object sender, EventArgs e)
		{
			txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MACUS_CURCD", "MACUS_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CUSID = '", cbCUSID.SelectedValue), "'"))));
			RetrieveDOData(Conversions.ToString(cbCUSID.SelectedValue), txtDOCNO.Text);
			RefreshDOGrid();
		}
	}
}
