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
using Spire.Barcode;

namespace IMS
{
    [DesignerGenerated]
	public class frmPDEFGR : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

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
		[AccessedThroughProperty("btnConfirm")]
		private Button _btnConfirm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbLOCID")]
		private ComboBox _cbLOCID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbMDLCD")]
		private ComboboxControl _cbMDLCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numQTY")]
		private NumControl _numQTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbREVNO")]
		private ComboBox _cbREVNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbWKONO")]
		private ComboBox _cbWKONO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDETAILS")]
		private DataGridView _dgvDETAILS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbBATCHNO")]
		private ComboBox _cbBATCHNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		private int intAccessLevel;

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

		[field: AccessedThroughProperty("lkpDOCNOFR")]
		internal virtual LookupControl lkpDOCNOFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpDOCNOTO")]
		internal virtual LookupControl lkpDOCNOTO
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

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numWEIGHT")]
		internal virtual NumControl numWEIGHT
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

		internal virtual Button btnConfirm
		{
			[CompilerGenerated]
			get
			{
				return _btnConfirm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnConfirm_Click;
				Button button = _btnConfirm;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnConfirm = value;
				button = _btnConfirm;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label21")]
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cboSTSFG")]
		internal virtual ComboBox cboSTSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label22")]
		internal virtual Label Label22
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

		internal virtual ComboBox cbLOCID
		{
			[CompilerGenerated]
			get
			{
				return _cbLOCID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbLOCID_SelectedIndexChanged;
				ComboBox comboBox = _cbLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbLOCID = value;
				comboBox = _cbLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbMDLCD
		{
			[CompilerGenerated]
			get
			{
				return _cbMDLCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbMDLCD_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbMDLCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbMDLCD = value;
				comboboxControl = _cbMDLCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		internal virtual NumControl numQTY
		{
			[CompilerGenerated]
			get
			{
				return _numQTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = numQTY_KeyDown;
				NumControl numControl = _numQTY;
				if (numControl != null)
				{
					numControl.KeyDown -= value2;
				}
				_numQTY = value;
				numControl = _numQTY;
				if (numControl != null)
				{
					numControl.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbREVNO
		{
			[CompilerGenerated]
			get
			{
				return _cbREVNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbREVNO_SelectedValueChanged;
				ComboBox comboBox = _cbREVNO;
				if (comboBox != null)
				{
					comboBox.SelectedValueChanged -= value2;
				}
				_cbREVNO = value;
				comboBox = _cbREVNO;
				if (comboBox != null)
				{
					comboBox.SelectedValueChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbWKONO
		{
			[CompilerGenerated]
			get
			{
				return _cbWKONO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbWKONO_SelectedIndexChanged;
				ComboBox comboBox = _cbWKONO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbWKONO = value;
				comboBox = _cbWKONO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("numSTDWGT")]
		internal virtual NumControl numSTDWGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvDETAILS
		{
			[CompilerGenerated]
			get
			{
				return _dgvDETAILS;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDETAILS_CellMouseClick;
				DataGridView dataGridView = _dgvDETAILS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvDETAILS = value;
				dataGridView = _dgvDETAILS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		internal virtual Button btnUpdate
		{
			[CompilerGenerated]
			get
			{
				return _btnUpdate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUpdate_Click;
				Button button = _btnUpdate;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnUpdate = value;
				button = _btnUpdate;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtBOMPN")]
		internal virtual TextBox txtBOMPN
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

		internal virtual ComboBox cbBATCHNO
		{
			[CompilerGenerated]
			get
			{
				return _cbBATCHNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbBATCHNO_SelectedIndexChanged;
				ComboBox comboBox = _cbBATCHNO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbBATCHNO = value;
				comboBox = _cbBATCHNO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
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
				EventHandler value2 = btnSave_Click;
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

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSTAGE")]
		internal virtual TextBox txtSTAGE
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

		[field: AccessedThroughProperty("numPARQT")]
		internal virtual NumControl numPARQT
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

		[field: AccessedThroughProperty("numEXSQTY")]
		internal virtual NumControl numEXSQTY
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

		[field: AccessedThroughProperty("lkpWKONOFR")]
		internal virtual LookupControl lkpWKONOFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label18")]
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpWKONOTO")]
		internal virtual LookupControl lkpWKONOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtFGLNO")]
		internal virtual TextBox txtFGLNO
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

		[field: AccessedThroughProperty("numTTLTarget")]
		internal virtual NumControl numTTLTarget
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numTTLActual")]
		internal virtual NumControl numTTLActual
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPDEFGR()
		{
			base.Load += frmPDEFGR_Load;
			base.FormClosing += frmPDEFGR_FormClosing;
			base.KeyDown += frmPDEFGR_KeyDown;
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
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.Label8 = new System.Windows.Forms.Label();
			this.dgvDETAILS = new System.Windows.Forms.DataGridView();
			this.cbWKONO = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtBOMPN = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.cbBATCHNO = new System.Windows.Forms.ComboBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtSTAGE = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.txtFGLNO = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.cbREVNO = new System.Windows.Forms.ComboBox();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cboSTSFG = new System.Windows.Forms.ComboBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.Label18 = new System.Windows.Forms.Label();
			this.cbMDLCD = new IMS.ComboboxControl();
			this.numWEIGHT = new IMS.NumControl();
			this.numSTDWGT = new IMS.NumControl();
			this.numPARQT = new IMS.NumControl();
			this.numTTLActual = new IMS.NumControl();
			this.numTTLTarget = new IMS.NumControl();
			this.numEXSQTY = new IMS.NumControl();
			this.numQTY = new IMS.NumControl();
			this.lkpDOCNOFR = new IMS.LookupControl();
			this.lkpDOCNOTO = new IMS.LookupControl();
			this.lkpWKONOFR = new IMS.LookupControl();
			this.lkpWKONOTO = new IMS.LookupControl();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).BeginInit();
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
			this.Panel1.Size = new System.Drawing.Size(1348, 705);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 5;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnConfirm, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel6.TabIndex = 0;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(129, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 74;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirm.Image = IMS.My.Resources.Resources.Confirm;
			this.btnConfirm.Location = new System.Drawing.Point(3, 2);
			this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(120, 50);
			this.btnConfirm.TabIndex = 23;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(255, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 24;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(507, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 26;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(381, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 25;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 6;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnUpdate, 0, 11);
			this.TableLayoutPanel5.Controls.Add(this.Label8, 0, 9);
			this.TableLayoutPanel5.Controls.Add(this.dgvDETAILS, 0, 7);
			this.TableLayoutPanel5.Controls.Add(this.cbWKONO, 1, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label11, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label5, 3, 4);
			this.TableLayoutPanel5.Controls.Add(this.cbMDLCD, 1, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label12, 0, 4);
			this.TableLayoutPanel5.Controls.Add(this.cbLOCID, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label6, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label3, 3, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label21, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label10, 0, 6);
			this.TableLayoutPanel5.Controls.Add(this.numWEIGHT, 1, 6);
			this.TableLayoutPanel5.Controls.Add(this.txtREMRK, 1, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label9, 0, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label7, 3, 3);
			this.TableLayoutPanel5.Controls.Add(this.numSTDWGT, 1, 4);
			this.TableLayoutPanel5.Controls.Add(this.txtBOMPN, 1, 9);
			this.TableLayoutPanel5.Controls.Add(this.Label13, 0, 10);
			this.TableLayoutPanel5.Controls.Add(this.cbBATCHNO, 1, 10);
			this.TableLayoutPanel5.Controls.Add(this.Label14, 2, 9);
			this.TableLayoutPanel5.Controls.Add(this.txtSTAGE, 3, 9);
			this.TableLayoutPanel5.Controls.Add(this.Label15, 2, 10);
			this.TableLayoutPanel5.Controls.Add(this.numPARQT, 3, 10);
			this.TableLayoutPanel5.Controls.Add(this.Label16, 3, 6);
			this.TableLayoutPanel5.Controls.Add(this.txtFGLNO, 3, 1);
			this.TableLayoutPanel5.Controls.Add(this.numTTLActual, 5, 8);
			this.TableLayoutPanel5.Controls.Add(this.numTTLTarget, 4, 8);
			this.TableLayoutPanel5.Controls.Add(this.Label19, 2, 8);
			this.TableLayoutPanel5.Controls.Add(this.numEXSQTY, 4, 6);
			this.TableLayoutPanel5.Controls.Add(this.numQTY, 4, 4);
			this.TableLayoutPanel5.Controls.Add(this.cbREVNO, 4, 3);
			this.TableLayoutPanel5.Controls.Add(this.dtpDOCDT, 4, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 12;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(889, 590);
			this.TableLayoutPanel5.TabIndex = 0;
			this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Image = IMS.My.Resources.Resources.Save;
			this.btnUpdate.Location = new System.Drawing.Point(3, 538);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 50);
			this.btnUpdate.TabIndex = 73;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 485);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(65, 16);
			this.Label8.TabIndex = 69;
			this.Label8.Text = "BOM Part";
			this.dgvDETAILS.AllowUserToAddRows = false;
			this.dgvDETAILS.AllowUserToDeleteRows = false;
			this.dgvDETAILS.AllowUserToResizeColumns = false;
			this.dgvDETAILS.AllowUserToResizeRows = false;
			this.dgvDETAILS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvDETAILS, 6);
			this.dgvDETAILS.EnableHeadersVisualStyles = false;
			this.dgvDETAILS.Location = new System.Drawing.Point(3, 220);
			this.dgvDETAILS.MultiSelect = false;
			this.dgvDETAILS.Name = "dgvDETAILS";
			this.dgvDETAILS.ReadOnly = true;
			this.dgvDETAILS.RowHeadersVisible = false;
			this.dgvDETAILS.RowHeadersWidth = 51;
			this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDETAILS.Size = new System.Drawing.Size(883, 231);
			this.dgvDETAILS.TabIndex = 68;
			this.dgvDETAILS.TabStop = false;
			this.cbWKONO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbWKONO.FormattingEnabled = true;
			this.cbWKONO.Location = new System.Drawing.Point(129, 59);
			this.cbWKONO.Name = "cbWKONO";
			this.cbWKONO.Size = new System.Drawing.Size(180, 24);
			this.cbWKONO.TabIndex = 59;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 63);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(77, 16);
			this.Label11.TabIndex = 58;
			this.Label11.Text = "Work Order";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(523, 121);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(56, 16);
			this.Label5.TabIndex = 56;
			this.Label5.Text = "Quantity";
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(3, 121);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(108, 16);
			this.Label12.TabIndex = 51;
			this.Label12.Text = "Standard Weight";
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(129, 29);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(180, 24);
			this.cbLOCID.TabIndex = 53;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 93);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(82, 16);
			this.Label6.TabIndex = 50;
			this.Label6.Text = "Model Code";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 5);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.txtDOCNO.Location = new System.Drawing.Point(129, 2);
			this.txtDOCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(523, 5);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 33);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(59, 16);
			this.Label21.TabIndex = 48;
			this.Label21.Text = "Location";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 196);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(84, 16);
			this.Label10.TabIndex = 47;
			this.Label10.Text = "Total Weight";
			this.TableLayoutPanel5.SetColumnSpan(this.txtREMRK, 5);
			this.txtREMRK.Location = new System.Drawing.Point(129, 144);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(647, 45);
			this.txtREMRK.TabIndex = 6;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 158);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(523, 93);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(61, 16);
			this.Label7.TabIndex = 51;
			this.Label7.Text = "Revision";
			this.txtBOMPN.Location = new System.Drawing.Point(129, 482);
			this.txtBOMPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBOMPN.Name = "txtBOMPN";
			this.txtBOMPN.ReadOnly = true;
			this.txtBOMPN.Size = new System.Drawing.Size(298, 22);
			this.txtBOMPN.TabIndex = 70;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 513);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(47, 16);
			this.Label13.TabIndex = 71;
			this.Label13.Text = "Lot No";
			this.cbBATCHNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBATCHNO.FormattingEnabled = true;
			this.cbBATCHNO.Location = new System.Drawing.Point(129, 509);
			this.cbBATCHNO.Name = "cbBATCHNO";
			this.cbBATCHNO.Size = new System.Drawing.Size(226, 24);
			this.cbBATCHNO.TabIndex = 72;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(461, 485);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(44, 16);
			this.Label14.TabIndex = 74;
			this.Label14.Text = "Stage";
			this.TableLayoutPanel5.SetColumnSpan(this.txtSTAGE, 3);
			this.txtSTAGE.Location = new System.Drawing.Point(523, 482);
			this.txtSTAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSTAGE.Name = "txtSTAGE";
			this.txtSTAGE.ReadOnly = true;
			this.txtSTAGE.Size = new System.Drawing.Size(253, 22);
			this.txtSTAGE.TabIndex = 75;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(461, 513);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(56, 16);
			this.Label15.TabIndex = 76;
			this.Label15.Text = "Quantity";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(523, 196);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(97, 16);
			this.Label16.TabIndex = 78;
			this.Label16.Text = "Excess Weight";
			this.txtFGLNO.Location = new System.Drawing.Point(523, 28);
			this.txtFGLNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFGLNO.Name = "txtFGLNO";
			this.txtFGLNO.ReadOnly = true;
			this.txtFGLNO.Size = new System.Drawing.Size(26, 22);
			this.txtFGLNO.TabIndex = 80;
			this.txtFGLNO.Visible = false;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(461, 459);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(39, 16);
			this.Label19.TabIndex = 81;
			this.Label19.Text = "Total";
			this.cbREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbREVNO.FormattingEnabled = true;
			this.cbREVNO.Location = new System.Drawing.Point(633, 89);
			this.cbREVNO.Name = "cbREVNO";
			this.cbREVNO.Size = new System.Drawing.Size(104, 24);
			this.cbREVNO.TabIndex = 55;
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(633, 2);
			this.dtpDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 698);
			this.Panel2.TabIndex = 2;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 181);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1332, 494);
			this.dgvHEADER.TabIndex = 0;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 124);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel4.TabIndex = 9;
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
			this.btnClose.Location = new System.Drawing.Point(255, 2);
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
			this.TableLayoutPanel2.Controls.Add(this.cboSTSFG, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label22, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.lkpDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lkpDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpWKONOFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label18, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpWKONOTO, 3, 2);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 4;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(582, 120);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[3] { "Pending Only", "Confirm Only", "All" });
			this.cboSTSFG.Location = new System.Drawing.Point(110, 93);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(121, 24);
			this.cboSTSFG.TabIndex = 7;
			this.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label22.Location = new System.Drawing.Point(3, 97);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(45, 16);
			this.Label22.TabIndex = 10;
			this.Label22.Text = "Status";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(332, 66);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(332, 8);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(25, 16);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 8);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(90, 16);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Document No";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 37);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 66);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(98, 16);
			this.Label17.TabIndex = 11;
			this.Label17.Text = "Work Order No";
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(110, 34);
			this.dtpDOCDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 5;
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(363, 34);
			this.dtpDOCDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 6;
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(332, 37);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(25, 16);
			this.Label18.TabIndex = 13;
			this.Label18.Text = "To";
			this.cbMDLCD.BlankValue = null;
			this.cbMDLCD.ComboboxWidth = 170;
			this.cbMDLCD.DataTable = null;
			this.cbMDLCD.DisplayMember = null;
			this.cbMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCD.HasBlankValue = false;
			this.cbMDLCD.Location = new System.Drawing.Point(129, 88);
			this.cbMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbMDLCD.Name = "cbMDLCD";
			this.cbMDLCD.SelectedIndex = -1;
			this.cbMDLCD.SelectedItem = null;
			this.cbMDLCD.SelectedValue = null;
			this.cbMDLCD.Size = new System.Drawing.Size(326, 25);
			this.cbMDLCD.TabIndex = 54;
			this.cbMDLCD.TextMultiline = true;
			this.cbMDLCD.ValueMember = null;
			this.cbMDLCD.WhereClause = null;
			this.numWEIGHT.AllowNegative = false;
			this.numWEIGHT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWEIGHT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWEIGHT.DataChanged = false;
			this.numWEIGHT.Location = new System.Drawing.Point(129, 193);
			this.numWEIGHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numWEIGHT.Name = "numWEIGHT";
			this.numWEIGHT.NumberFormat = "8.3";
			this.numWEIGHT.Size = new System.Drawing.Size(180, 22);
			this.numWEIGHT.TabIndex = 10;
			this.numWEIGHT.Text = "0.000";
			this.numWEIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWEIGHT.ThousandSeperator = false;
			this.numWEIGHT.Value = 0.0;
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(129, 118);
			this.numSTDWGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.3";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(180, 22);
			this.numSTDWGT.TabIndex = 60;
			this.numSTDWGT.Text = "0.000";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.numPARQT.AllowNegative = false;
			this.numPARQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPARQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPARQT.DataChanged = false;
			this.numPARQT.Location = new System.Drawing.Point(523, 510);
			this.numPARQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPARQT.Name = "numPARQT";
			this.numPARQT.NumberFormat = "8.3";
			this.numPARQT.Size = new System.Drawing.Size(104, 22);
			this.numPARQT.TabIndex = 77;
			this.numPARQT.Text = "0.000";
			this.numPARQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPARQT.ThousandSeperator = false;
			this.numPARQT.Value = 0.0;
			this.numTTLActual.AllowNegative = false;
			this.numTTLActual.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTTLActual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTTLActual.DataChanged = false;
			this.numTTLActual.Location = new System.Drawing.Point(782, 456);
			this.numTTLActual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTTLActual.Name = "numTTLActual";
			this.numTTLActual.NumberFormat = "8.3";
			this.numTTLActual.Size = new System.Drawing.Size(104, 22);
			this.numTTLActual.TabIndex = 83;
			this.numTTLActual.Text = "0.000";
			this.numTTLActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTTLActual.ThousandSeperator = false;
			this.numTTLActual.Value = 0.0;
			this.numTTLTarget.AllowNegative = false;
			this.numTTLTarget.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTTLTarget.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTTLTarget.DataChanged = false;
			this.numTTLTarget.Location = new System.Drawing.Point(633, 456);
			this.numTTLTarget.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTTLTarget.Name = "numTTLTarget";
			this.numTTLTarget.NumberFormat = "8.3";
			this.numTTLTarget.Size = new System.Drawing.Size(104, 22);
			this.numTTLTarget.TabIndex = 82;
			this.numTTLTarget.Text = "0.000";
			this.numTTLTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTTLTarget.ThousandSeperator = false;
			this.numTTLTarget.Value = 0.0;
			this.numEXSQTY.AllowNegative = false;
			this.numEXSQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numEXSQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numEXSQTY.DataChanged = false;
			this.numEXSQTY.Location = new System.Drawing.Point(633, 193);
			this.numEXSQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numEXSQTY.Name = "numEXSQTY";
			this.numEXSQTY.NumberFormat = "8.3";
			this.numEXSQTY.Size = new System.Drawing.Size(143, 22);
			this.numEXSQTY.TabIndex = 79;
			this.numEXSQTY.Text = "0.000";
			this.numEXSQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numEXSQTY.ThousandSeperator = false;
			this.numEXSQTY.Value = 0.0;
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQTY.DataChanged = false;
			this.numQTY.Location = new System.Drawing.Point(633, 118);
			this.numQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.3";
			this.numQTY.Size = new System.Drawing.Size(104, 22);
			this.numQTY.TabIndex = 57;
			this.numQTY.Text = "0.000";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.lkpDOCNOFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOFR.AllowBlank = false;
			this.lkpDOCNOFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpDOCNOFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpDOCNOFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpDOCNOFR.DescriptionVisible1 = false;
			this.lkpDOCNOFR.DescriptionVisible2 = false;
			this.lkpDOCNOFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOFR.KeyValue = "";
			this.lkpDOCNOFR.LKPCD = "PDFGR_DOCNO";
			this.lkpDOCNOFR.Location = new System.Drawing.Point(112, 5);
			this.lkpDOCNOFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpDOCNOFR.MaxLength = 0;
			this.lkpDOCNOFR.Modified = false;
			this.lkpDOCNOFR.Multiline_ = false;
			this.lkpDOCNOFR.Name = "lkpDOCNOFR";
			this.lkpDOCNOFR.PasswordChar = "\0";
			this.lkpDOCNOFR.ReadOnly_ = false;
			this.lkpDOCNOFR.Size = new System.Drawing.Size(212, 22);
			this.lkpDOCNOFR.TabIndex = 1;
			this.lkpDOCNOFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpDOCNOFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpDOCNOFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpDOCNOFR.TextHeight = 22;
			this.lkpDOCNOFR.TextWidth = 180;
			this.lkpDOCNOFR.Where1 = null;
			this.lkpDOCNOTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOTO.AllowBlank = false;
			this.lkpDOCNOTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpDOCNOTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpDOCNOTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpDOCNOTO.DescriptionVisible1 = false;
			this.lkpDOCNOTO.DescriptionVisible2 = false;
			this.lkpDOCNOTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOTO.KeyValue = "";
			this.lkpDOCNOTO.LKPCD = "PDFGR_DOCNO";
			this.lkpDOCNOTO.Location = new System.Drawing.Point(365, 5);
			this.lkpDOCNOTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpDOCNOTO.MaxLength = 0;
			this.lkpDOCNOTO.Modified = false;
			this.lkpDOCNOTO.Multiline_ = false;
			this.lkpDOCNOTO.Name = "lkpDOCNOTO";
			this.lkpDOCNOTO.PasswordChar = "\0";
			this.lkpDOCNOTO.ReadOnly_ = false;
			this.lkpDOCNOTO.Size = new System.Drawing.Size(212, 22);
			this.lkpDOCNOTO.TabIndex = 2;
			this.lkpDOCNOTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpDOCNOTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpDOCNOTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpDOCNOTO.TextHeight = 22;
			this.lkpDOCNOTO.TextWidth = 180;
			this.lkpDOCNOTO.Where1 = null;
			this.lkpWKONOFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpWKONOFR.AllowBlank = false;
			this.lkpWKONOFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpWKONOFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpWKONOFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpWKONOFR.DescriptionVisible1 = false;
			this.lkpWKONOFR.DescriptionVisible2 = false;
			this.lkpWKONOFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpWKONOFR.KeyValue = "";
			this.lkpWKONOFR.LKPCD = "PDFGR_WKONO";
			this.lkpWKONOFR.Location = new System.Drawing.Point(112, 63);
			this.lkpWKONOFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpWKONOFR.MaxLength = 0;
			this.lkpWKONOFR.Modified = false;
			this.lkpWKONOFR.Multiline_ = false;
			this.lkpWKONOFR.Name = "lkpWKONOFR";
			this.lkpWKONOFR.PasswordChar = "\0";
			this.lkpWKONOFR.ReadOnly_ = false;
			this.lkpWKONOFR.Size = new System.Drawing.Size(212, 22);
			this.lkpWKONOFR.TabIndex = 12;
			this.lkpWKONOFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpWKONOFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpWKONOFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpWKONOFR.TextHeight = 22;
			this.lkpWKONOFR.TextWidth = 180;
			this.lkpWKONOFR.Where1 = null;
			this.lkpWKONOTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpWKONOTO.AllowBlank = false;
			this.lkpWKONOTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpWKONOTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpWKONOTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpWKONOTO.DescriptionVisible1 = false;
			this.lkpWKONOTO.DescriptionVisible2 = false;
			this.lkpWKONOTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpWKONOTO.KeyValue = "";
			this.lkpWKONOTO.LKPCD = "PDFGR_WKONO";
			this.lkpWKONOTO.Location = new System.Drawing.Point(365, 63);
			this.lkpWKONOTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpWKONOTO.MaxLength = 0;
			this.lkpWKONOTO.Modified = false;
			this.lkpWKONOTO.Multiline_ = false;
			this.lkpWKONOTO.Name = "lkpWKONOTO";
			this.lkpWKONOTO.PasswordChar = "\0";
			this.lkpWKONOTO.ReadOnly_ = false;
			this.lkpWKONOTO.Size = new System.Drawing.Size(212, 22);
			this.lkpWKONOTO.TabIndex = 14;
			this.lkpWKONOTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpWKONOTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpWKONOTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpWKONOTO.TextHeight = 22;
			this.lkpWKONOTO.TextWidth = 180;
			this.lkpWKONOTO.Where1 = null;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 706);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPDEFGR";
			base.Tag = "PDEFGR";
			this.Text = "Finished Goods Receiving";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).EndInit();
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
			Panel1.Visible = true;
			Panel2.Visible = false;
			ClearControl();
			ClearWorkData();
			BindComboBox();
			ManageOrderNo();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!Conversions.ToBoolean(Operators.NotObject(ValidateHeader())) && ValidateDetailControl() && spPDEFGR("0"))
			{
				btnDelete.Enabled = intAccessLevel >= 3;
				btnPRINT.Enabled = true;
				btnConfirm.Enabled = intAccessLevel >= 1;
				dtpDOCDT.Enabled = false;
				cbLOCID.Enabled = false;
			}
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			cbMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbMDLCD.WhereClause = "MAITM_ITMTY = 1";
			cbMDLCD.ValueMember = "MAITM_ITMCD";
			cbMDLCD.DisplayMember = "MAITM_ITMCD";
			cbMDLCD.LoadData();
		}

		private object ValidateHeader()
		{
			if (numQTY.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity cannot be zero!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numQTY.Focus();
				return false;
			}
			if (numWEIGHT.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total Weight cannot be zero!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numWEIGHT.Focus();
				return false;
			}
			return true;
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDEFGR'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private bool spPDEFGR(string strPRO)
		{
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDEFGR'"));
			bool spPDEFGR;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PDEFGR", "PDFGR", ref strNextNo))
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txtDOCNO.Focus();
						spPDEFGR = false;
						goto IL_03c7;
					}
					txtDOCNO.Text = strNextNo;
				}
			}
			else
			{
				txtDOCNO.Enabled = true;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtDOCNO.Focus();
					spPDEFGR = false;
					goto IL_03c7;
				}
			}
			strSQL = "EXEC spPDEFGR ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbWKONO.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCD.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbREVNO.SelectedValue), "', ")));
			strSQL = strSQL + Conversions.ToString(numSTDWGT.Value) + ", ";
			strSQL = strSQL + "'" + txtREMRK.Text + "', ";
			strSQL = strSQL + Conversions.ToString(numQTY.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numWEIGHT.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numEXSQTY.Value) + ", ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "',";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "'";
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				spPDEFGR = false;
				ProjectData.ClearProjectError();
				goto IL_03c7;
			}
			if (Operators.CompareString(strPRO, "0", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			spPDEFGR = true;
			goto IL_03c7;
			IL_03c7:
			return spPDEFGR;
		}

		private void Header()
		{
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spPDFGR '0', ";
			strSQL = strSQL + "'" + lkpDOCNOFR.LowValue + "', ";
			strSQL = strSQL + "'" + lkpDOCNOTO.HighValue + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = strSQL + "'" + lkpWKONOFR.LowValue + "', ";
			strSQL = strSQL + "'" + lkpWKONOTO.HighValue + "', ";
			strSQL += Conversions.ToString(cboSTSFG.SelectedIndex) ?? "";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					int i = default(int);
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Doc No";
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Doc Date";
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Location";
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Status";
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "WO No";
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Model Code";
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Revision";
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Weight";
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Excess";
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 200;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = "Remark";
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void ClearControl()
		{
			txtDOCNO.Text = string.Empty;
			txtDOCNO.Enabled = true;
			dtpDOCDT.Value = DateAndTime.Now.Date;
			dtpDOCDT.Enabled = true;
			cbWKONO.Enabled = true;
			cbLOCID.Enabled = true;
			txtFGLNO.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			dgvDETAILS.DataSource = null;
			btnConfirm.Enabled = false;
			btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
			btnUpdate.Enabled = true;
			cbMDLCD.Enabled = true;
			cbREVNO.Enabled = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearControl();
			Header();
		}

		private void BindHeadertoControl()
		{
			int intQTY = 0;
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["PDFGR_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PDFGR_DOCDT"].Value);
			txtFGLNO.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDFGR_FGLNO"].Value);
			cbLOCID.SelectedValue = dgvHEADER.CurrentRow.Cells["PDFGR_LOCID"].Value.ToString();
			if (Operators.ConditionalCompareObjectNotEqual(dgvHEADER.CurrentRow.Cells["PDFGR_WKONO"].Value, "", false))
			{
				cbWKONO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDFGR_WKONO"].Value);
			}
			cbMDLCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDFGR_MDLCD"].Value);
			cbREVNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDFGR_REVNO"].Value);
			numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL With (NOLOCK)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbMDLCD.SelectedValue), "'"))));
			numQTY.Value = Conversions.ToDouble(NewLateBinding.LateGet(null, typeof(Math), "Floor", new object[1] { Operators.DivideObject(dgvHEADER.CurrentRow.Cells["QTY"].Value, numSTDWGT.Value) }, null, null, null));
			numWEIGHT.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["TTL_WEIGHT"].Value);
			numEXSQTY.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["PDFGR_EXCESS"].Value);
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["PDFGR_REMRK"].Value.ToString();
			cbWKONO.Enabled = false;
			cbMDLCD.Enabled = false;
			cbREVNO.Enabled = false;
			GenWorkData();
			RefreshGrid();
		}

		private void ClearWorkData()
		{
			string strSQL = "DELETE PDFGD_WRK WHERE\tPDFGD_COMPNM = '" + MyProject.Computer.Name + "'";
			DB.ExecProc(strSQL);
		}

		private void GenWorkData()
		{
			if (cbREVNO.SelectedIndex != -1)
			{
				string strSQL = "EXEC spPDEFGR_WORK ";
				strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
				strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbWKONO.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCD.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(cbREVNO.SelectedValue, ", ")));
				strSQL += Conversions.ToString(numWEIGHT.Value);
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
			}
		}

		private void RefreshGrid()
		{
			int i = 0;
			double dblTotalTarget = 0.0;
			double dblTotalActual = 0.0;
			string strSQL = "SELECT PDFGD_LINENO, PDFGD_STAGE, PDFGD_BOMPN, ";
			strSQL += "IIF(ISNULL(PDFGR_WKONO, PDFGD_BATCHNO) = '', PDFGD_BATCHNO, ISNULL(PDFGR_WKONO, PDFGD_BATCHNO)) AS PDFGD_BATCHNO, ";
			strSQL += "PDFGD_TARGET, PDFGD_ACTUAL, MAITM_CATCD ";
			strSQL += "FROM PDFGD_WRK ";
			strSQL += "LEFT JOIN PDFGR_TBL WITH (NOLOCK) ";
			strSQL += "ON PDFGR_MDLCD = PDFGD_BOMPN And PDFGR_FGLNO = PDFGD_BATCHNO ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ";
			strSQL += "ON MAITM_ITMCD = PDFGD_BOMPN ";
			strSQL = strSQL + "WHERE PDFGD_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "ORDER BY PDFGD_LINENO";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDETAILS;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 80;
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].HeaderText = "Line No";
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "Stage";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 250;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "BOM Part No";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "Lot No";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "Target";
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "Actual";
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
				int num = dt.Rows.Count - 1;
				for (i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dt.Rows[i]["MAITM_CATCD"].ToString().ToUpper(), "PACKAGING", false) != 0)
					{
						dblTotalTarget = Conversions.ToDouble(Operators.AddObject(dblTotalTarget, dt.Rows[i]["PDFGD_TARGET"]));
						dblTotalActual = Conversions.ToDouble(Operators.AddObject(dblTotalActual, dt.Rows[i]["PDFGD_ACTUAL"]));
					}
				}
				numTTLTarget.Value = dblTotalTarget;
				numTTLActual.Value = dblTotalActual;
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindHeadertoControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("TOP 1 PDFGR_STSFG", "PDFGR_TBL", "PDFGR_DOCNO = '" + txtDOCNO.Text + "'"));
			if (Conversions.ToDouble(strSTSFG) == 1.0)
			{
				btnConfirm.Enabled = false;
				btnUpdate.Enabled = false;
				btnSAVE.Enabled = false;
			}
			else
			{
				btnConfirm.Enabled = intAccessLevel >= 1;
				btnUpdate.Enabled = intAccessLevel >= 1;
				btnSAVE.Enabled = intAccessLevel >= 1;
			}
			cbWKONO.Enabled = false;
			txtDOCNO.Enabled = false;
			dtpDOCDT.Enabled = false;
			cbLOCID.Enabled = false;
			btnPRINT.Enabled = true;
			btnDelete.Enabled = intAccessLevel >= 3;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM INTRN_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE INTRN_LOCID = '", cbLOCID.SelectedValue), "' ")));
			strSQL += "AND INTRN_DOCCD <> 'FGR' AND INTRN_IOFLG <> 1 ";
			strSQL = strSQL + "AND INTRN_GRLNO = '" + txtFGLNO.Text + "' ";
			if (DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document already have transaction, delete not allow!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No && spPDEFGR("1"))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearControl();
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			string strSQL = "SELECT * FROM PDFGD_WRK WHERE PDFGD_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND PDFGD_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL += "AND PDFGD_LOTCHK = 1 AND PDFGD_BATCHNO = ''";
			if (DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Some line Lot No not set!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void GenerateQRCode()
		{
			OleDbCommand cmd = new OleDbCommand();
			object settings = new BarcodeSettings();
			string strSQL = "EXEC spPDFGR_QR ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int iRowsAffected = cmd.ExecuteNonQuery();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex3 = ex4;
				MessageBox.Show(ex3.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			DataTable dt = DB.ExecProc("SELECT PDFGR_FGLNO FROM PDFGR_QR WHERE PDFGR_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "'");
			int num = checked(dt.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				NewLateBinding.LateSet(settings, null, "HasBorder", new object[1] { false }, null, null);
				NewLateBinding.LateSet(settings, null, "ShowText", new object[1] { false }, null, null);
				NewLateBinding.LateSet(settings, null, "Type", new object[1] { (BarCodeType)Conversions.ToLong(Enum.Parse(typeof(BarCodeType), "QRCode")) }, null, null);
				NewLateBinding.LateSet(settings, null, "LeftMargin", new object[1] { 1 }, null, null);
				string strFGLNO = Common.gfValidSQLStr(dt.Rows[i]["PDFGR_FGLNO"].ToString().Trim());
				NewLateBinding.LateSet(settings, null, "Data2D", new object[1] { strFGLNO }, null, null);
				NewLateBinding.LateSet(settings, null, "Data", new object[1] { strFGLNO }, null, null);
				BarCodeGenerator sprFGLNO = new BarCodeGenerator((IBarcodeSettings)settings);
				byte[] imgQRCODE = Common.ImageToByte2(sprFGLNO.GenerateImage());
				try
				{
					cmd = new OleDbCommand();
					cmd.Connection = DB.GetDBConnection();
					strSQL = "spPDFGR_QR2";
					cmd.CommandText = strSQL;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("@PRNID", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(MyProject.Computer.Name);
					cmd.Parameters.Add("@DOCNO", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(txtDOCNO.Text);
					cmd.Parameters.Add("@QRCODE", OleDbType.VarBinary, -1).Value = imgQRCODE;
					int iRowsAffected = cmd.ExecuteNonQuery();
				}
				catch (OleDbException ex5)
				{
					ProjectData.SetProjectError(ex5);
					OleDbException ex2 = ex5;
					MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6);
					Exception ex = ex6;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				finally
				{
					cmd = null;
				}
			}
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			GenerateQRCode();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "Finished Goods Receiving Label";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDFGR_Label.rpt";
			frmRPT.Params = "@PRNID=" + MyProject.Computer.Name;
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='Finished Goods Receiving Label',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			try
			{
				string strSQL = "EXEC spPDEFGR_CONFIRM '" + txtDOCNO.Text + "', '" + PublicVar.gstrLogonID + "'";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record confirmed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
				return;
			}
			btnConfirm.Enabled = false;
			btnDelete.Enabled = false;
			btnUpdate.Enabled = false;
		}

		private void frmPDEFGR_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			intAccessLevel = Common.GetAccessLevel(Conversions.ToString(base.Tag));
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			cboSTSFG.SelectedIndex = 0;
			Header();
			NumberFormat();
			btnNew.Enabled = intAccessLevel != 0;
		}

		private void frmPDEFGR_FormClosing(object sender, FormClosingEventArgs e)
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
			numQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numSTDWGT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Weight);
			numWEIGHT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
		}

		private void frmPDEFGR_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL;
			if (Operators.CompareString(txtDOCNO.Text, string.Empty, false) != 0)
			{
				strSQL = "SELECT '' AS PDWKO_WKONO UNION SELECT PDWKO_WKONO FROM PDWKO_TBL WITH(NOLOCK) ";
				strSQL = strSQL + "WHERE PDWKO_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "' AND PDWKO_STSFG > 1 ";
				strSQL += "ORDER BY PDWKO_WKONO ";
			}
			else
			{
				strSQL = "SELECT '' AS PDWKO_WKONO UNION SELECT PDWKO_WKONO FROM PDWKO_TBL WITH(NOLOCK) ";
				strSQL = strSQL + "WHERE PDWKO_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "' AND PDWKO_STSFG = 1 ";
				strSQL += "ORDER BY PDWKO_WKONO ";
			}
			cbWKONO.ValueMember = "PDWKO_WKONO";
			cbWKONO.DisplayMember = "PDWKO_WKONO";
			Common.RetriveComboItembySQL(strSQL, cbWKONO);
		}

		private void cbWKONO_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!Operators.ConditionalCompareObjectEqual(cbWKONO.SelectedValue, "", false))
			{
				string strSQL = "SELECT * FROM PDWKO_TBL WITH (NOLOCK) ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE PDWKO_WKONO = '", cbWKONO.SelectedValue), "'")));
				DataTable dt = DB.ExecProc(strSQL);
				cbMDLCD.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["PDWKO_MDLCD"]);
				cbREVNO.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["PDWKO_REVNO"]);
				numQTY.Value = Conversions.ToDouble(NewLateBinding.LateGet(null, typeof(Math), "Ceiling", new object[1] { Operators.DivideObject(dt.Rows[0]["PDWKO_WOQTY"], numSTDWGT.Value) }, null, null, null));
				numWEIGHT.Value = Conversions.ToDouble(dt.Rows[0]["PDWKO_WOQTY"]);
				GenWorkData();
				RefreshGrid();
				if (Operators.ConditionalCompareObjectNotEqual(cbWKONO.SelectedValue, "", false))
				{
					cbMDLCD.Enabled = false;
					cbREVNO.Enabled = false;
				}
				else if (Operators.CompareString(txtDOCNO.Text, "", false) == 0)
				{
					cbMDLCD.Enabled = true;
					cbREVNO.Enabled = true;
				}
				else
				{
					cbMDLCD.Enabled = false;
					cbREVNO.Enabled = false;
				}
			}
		}

		private void cbMDLCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT DISTINCT MABOM_REVNO FROM MABOM_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE MABOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
			strSQL += "ORDER BY MABOM_REVNO ";
			cbREVNO.ValueMember = "MABOM_REVNO";
			cbREVNO.DisplayMember = "MABOM_REVNO";
			Common.RetriveComboItembySQL(strSQL, cbREVNO);
			numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL With (NOLOCK)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbMDLCD.SelectedValue), "'"))));
		}

		private void numQTY_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return))
			{
				numWEIGHT.Value = numQTY.Value * numSTDWGT.Value;
				GenWorkData();
				RefreshGrid();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int intNewRow = 0;
			double dblTarget = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["PDFGD_TARGET"].Value);
			if (numPARQT.Value < dblTarget)
			{
				intNewRow = ((MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity less than Target! Add new line? "), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ? 1 : 0);
			}
			string strSQL = "EXEC spPDEFGR_WRK ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + txtSTAGE.Text + "', ";
			strSQL = strSQL + "'" + txtBOMPN.Text + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(numPARQT.Value) + ", ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', " + Conversions.ToString(intNewRow);
			DB.ExecProc(strSQL);
			RefreshGrid();
		}

		private void dgvDETAILS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtBOMPN.Text = Conversions.ToString(dgvDETAILS.CurrentRow.Cells["PDFGD_BOMPN"].Value);
			txtSTAGE.Text = Conversions.ToString(dgvDETAILS.CurrentRow.Cells["PDFGD_STAGE"].Value);
			numPARQT.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["PDFGD_ACTUAL"].Value);
			cbBATCHNO.DataSource = null;
			string strLOCID = ((Operators.CompareString(txtSTAGE.Text, "", false) != 0) ? txtSTAGE.Text : Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)));
			string strSQL = "SELECT * FROM MAITM_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE MAITM_ITMCD = '" + Common.gfValidSQLStr(txtBOMPN.Text) + "' AND MAITM_ITMCTRL = 1";
			if (DB.RecordExists(strSQL))
			{
				strSQL = "SELECT * FROM PDPRQ_TBL WITH (NOLOCK) ";
				strSQL = strSQL + "WHERE PDPRQ_WKONO = '" + Common.gfValidSQLStr(Conversions.ToString(cbWKONO.SelectedValue)) + "' ";
				strSQL = strSQL + "AND PDPRQ_ITMCD = '" + Common.gfValidSQLStr(txtBOMPN.Text) + "' ";
				if (DB.RecordExists(strSQL))
				{
					strSQL = "SELECT INTRF_GRLNO, IIF(ISNULL(PDFGR_WKONO, INTRF_GRLNO) = '', INTRF_GRLNO, ISNULL(PDFGR_WKONO, INTRF_GRLNO)) AS PDWKO_WKONO ";
					strSQL += "FROM INTRF_TBL WITH (NOLOCK) ";
					strSQL += "LEFT JOIN PDFGR_TBL WITH (NOLOCK) ";
					strSQL += "ON PDFGR_MDLCD = INTRF_ITMCD AND PDFGR_FGLNO = INTRF_GRLNO ";
					strSQL = strSQL + "WHERE LEFT(INTRF_PRQNO, 15) = '" + Common.gfValidSQLStr(Conversions.ToString(cbWKONO.SelectedValue)) + "' ";
					strSQL = strSQL + "AND INTRF_ITMCD = '" + Common.gfValidSQLStr(txtBOMPN.Text) + "' ";
					strSQL += "ORDER BY INTRF_GRLNO ";
					cbBATCHNO.ValueMember = "INTRF_GRLNO";
					cbBATCHNO.DisplayMember = "PDWKO_WKONO";
					Common.RetriveComboItembySQL(strSQL, cbBATCHNO);
				}
				else
				{
					strSQL = "SELECT INTRN_GRLNO, ISNULL(PDWKO_WKONO, INTRN_GRLNO) AS PDWKO_WKONO FROM vwItemBalanceByGRLNO ";
					strSQL = strSQL + "WHERE INTRN_LOCID = '" + strLOCID + "' ";
					strSQL = strSQL + "AND INTRN_ITMCD = '" + Common.gfValidSQLStr(txtBOMPN.Text) + "' AND INTRN_BALQT > 0 ";
					strSQL += "ORDER BY INTRN_GRLNO ";
					cbBATCHNO.ValueMember = "INTRN_GRLNO";
					cbBATCHNO.DisplayMember = "PDWKO_WKONO";
					Common.RetriveComboItembySQL(strSQL, cbBATCHNO);
				}
			}
			else
			{
				strSQL = "SELECT INTRN_GRLNO, ISNULL(PDWKO_WKONO, INTRN_GRLNO) AS PDWKO_WKONO FROM vwItemBalanceByGRLNO ";
				strSQL = strSQL + "WHERE INTRN_LOCID = '" + strLOCID + "' ";
				strSQL = strSQL + "AND INTRN_ITMCD = '" + Common.gfValidSQLStr(txtBOMPN.Text) + "' AND INTRN_BALQT > 0 ";
				strSQL += "ORDER BY INTRN_GRLNO ";
				cbBATCHNO.ValueMember = "INTRN_GRLNO";
				cbBATCHNO.DisplayMember = "PDWKO_WKONO";
				Common.RetriveComboItembySQL(strSQL, cbBATCHNO);
			}
			if (Operators.ConditionalCompareObjectNotEqual(dgvDETAILS.CurrentRow.Cells["PDFGD_BATCHNO"].Value, "", false))
			{
				cbBATCHNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["PDFGD_BATCHNO"].Value);
			}
		}

		private void cbREVNO_SelectedValueChanged(object sender, EventArgs e)
		{
			GenWorkData();
			RefreshGrid();
		}

		private void cbBATCHNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbBATCHNO.SelectedIndex != -1)
			{
				numPARQT.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["PDFGD_ACTUAL"].Value);
				string strLOCID = ((Operators.CompareString(txtSTAGE.Text, "", false) != 0) ? txtSTAGE.Text : Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)));
				string strSQL = "INTRN_LOCID = '" + strLOCID + "' ";
				strSQL = strSQL + "AND INTRN_ITMCD = '" + Common.gfValidSQLStr(txtBOMPN.Text) + "' ";
				strSQL = strSQL + "AND INTRN_GRLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "'";
				double dblGRLQTY = Conversions.ToDouble(DB.GetColumnValue("INTRN_BALQT", "vwItemBalanceByGRLNO", strSQL));
				if (dblGRLQTY < numPARQT.Value)
				{
					numPARQT.Value = dblGRLQTY;
				}
			}
		}
	}
}
