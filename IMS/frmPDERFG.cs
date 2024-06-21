using System;
using System.Collections.Generic;
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
	public class frmPDERFG : Form
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
		[AccessedThroughProperty("cbWKONO")]
		private ComboBox _cbWKONO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDETAILS")]
		private DataGridView _dgvDETAILS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnAdd1")]
		private Button _btnAdd1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbBATCHNO")]
		private ComboBox _cbBATCHNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbBOMPN")]
		private ComboboxControl _cbBOMPN;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvPDRWP")]
		private DataGridView _dgvPDRWP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnAdd2")]
		private Button _btnAdd2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRemove2")]
		private Button _btnRemove2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRemove1")]
		private Button _btnRemove1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbPACKING")]
		private ComboboxControl _cbPACKING;

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

		internal virtual Button btnAdd1
		{
			[CompilerGenerated]
			get
			{
				return _btnAdd1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnAdd1_Click;
				Button button = _btnAdd1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnAdd1 = value;
				button = _btnAdd1;
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtType")]
		internal virtual TextBox txtType
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbBOMPN
		{
			[CompilerGenerated]
			get
			{
				return _cbBOMPN;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbBOMPN_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbBOMPN;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbBOMPN = value;
				comboboxControl = _cbBOMPN;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvPDRWP
		{
			[CompilerGenerated]
			get
			{
				return _dgvPDRWP;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvPDRWP_CellMouseClick;
				DataGridView dataGridView = _dgvPDRWP;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvPDRWP = value;
				dataGridView = _dgvPDRWP;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
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

		[field: AccessedThroughProperty("numPacking")]
		internal virtual NumControl numPacking
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnAdd2
		{
			[CompilerGenerated]
			get
			{
				return _btnAdd2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnAdd2_Click;
				Button button = _btnAdd2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnAdd2 = value;
				button = _btnAdd2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnRemove2
		{
			[CompilerGenerated]
			get
			{
				return _btnRemove2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRemove2_Click;
				Button button = _btnRemove2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRemove2 = value;
				button = _btnRemove2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("numBALQT")]
		internal virtual NumControl numBALQT
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

		[field: AccessedThroughProperty("numLineNo")]
		internal virtual NumControl numLineNo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnRemove1
		{
			[CompilerGenerated]
			get
			{
				return _btnRemove1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRemove1_Click;
				Button button = _btnRemove1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRemove1 = value;
				button = _btnRemove1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label19")]
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtMDLCD")]
		internal virtual TextBox txtMDLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbGRLNO")]
		internal virtual ComboBox cbGRLNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label20")]
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbPACKING
		{
			[CompilerGenerated]
			get
			{
				return _cbPACKING;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbPACKING_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbPACKING;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbPACKING = value;
				comboboxControl = _cbPACKING;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		public frmPDERFG()
		{
			base.Load += frmPDERFG_Load;
			base.FormClosing += frmPDERFG_FormClosing;
			base.KeyDown += frmPDERFG_KeyDown;
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
		ComboBox cbLocation = new ComboBox();
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
			this.btnRemove1 = new System.Windows.Forms.Button();
			this.btnAdd1 = new System.Windows.Forms.Button();
			this.Label8 = new System.Windows.Forms.Label();
			this.dgvDETAILS = new System.Windows.Forms.DataGridView();
			this.cbWKONO = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.numWEIGHT = new IMS.NumControl();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.cbBATCHNO = new System.Windows.Forms.ComboBox();
			this.cbBOMPN = new IMS.ComboboxControl();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.numEXSQTY = new IMS.NumControl();
			this.Label12 = new System.Windows.Forms.Label();
			this.dgvPDRWP = new System.Windows.Forms.DataGridView();
			this.Label6 = new System.Windows.Forms.Label();
			this.btnAdd2 = new System.Windows.Forms.Button();
			this.btnRemove2 = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtType = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.numPARQT = new IMS.NumControl();
			this.numBALQT = new IMS.NumControl();
			this.Label14 = new System.Windows.Forms.Label();
			this.numLineNo = new IMS.NumControl();
			this.Label19 = new System.Windows.Forms.Label();
			this.txtMDLCD = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.numPacking = new IMS.NumControl();
			this.cbGRLNO = new System.Windows.Forms.ComboBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cboSTSFG = new System.Windows.Forms.ComboBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.lkpDOCNOFR = new IMS.LookupControl();
			this.lkpDOCNOTO = new IMS.LookupControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lkpWKONOFR = new IMS.LookupControl();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.Label18 = new System.Windows.Forms.Label();
			this.lkpWKONOTO = new IMS.LookupControl();
			this.cbPACKING = new IMS.ComboboxControl();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvPDRWP).BeginInit();
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
			this.TableLayoutPanel5.ColumnCount = 7;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnRemove1, 1, 11);
			this.TableLayoutPanel5.Controls.Add(this.btnAdd1, 0, 11);
			this.TableLayoutPanel5.Controls.Add(this.Label8, 0, 8);
			this.TableLayoutPanel5.Controls.Add(this.dgvDETAILS, 0, 6);
			this.TableLayoutPanel5.Controls.Add(this.cbWKONO, 1, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label11, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.cbLOCID, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label21, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label10, 0, 5);
			this.TableLayoutPanel5.Controls.Add(this.numWEIGHT, 1, 5);
			this.TableLayoutPanel5.Controls.Add(this.txtREMRK, 1, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label9, 0, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label13, 0, 9);
			this.TableLayoutPanel5.Controls.Add(this.cbBATCHNO, 1, 9);
            this.TableLayoutPanel5.Controls.Add(this.cbLocation, 1, 7);
            this.TableLayoutPanel5.Controls.Add(this.cbBOMPN, 1, 8);
			this.TableLayoutPanel5.Controls.Add(this.Label16, 3, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label3, 3, 0);
			this.TableLayoutPanel5.Controls.Add(this.dtpDOCDT, 4, 0);
			this.TableLayoutPanel5.Controls.Add(this.numEXSQTY, 4, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label12, 5, 5);
			this.TableLayoutPanel5.Controls.Add(this.dgvPDRWP, 5, 6);
			this.TableLayoutPanel5.Controls.Add(this.Label6, 5, 8);
			this.TableLayoutPanel5.Controls.Add(this.btnAdd2, 5, 11);
			this.TableLayoutPanel5.Controls.Add(this.btnRemove2, 6, 11);
			this.TableLayoutPanel5.Controls.Add(this.Label5, 3, 2);
			this.TableLayoutPanel5.Controls.Add(this.txtType, 4, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label15, 0, 10);
			this.TableLayoutPanel5.Controls.Add(this.numPARQT, 1, 10);
			this.TableLayoutPanel5.Controls.Add(this.numBALQT, 4, 9);
			this.TableLayoutPanel5.Controls.Add(this.Label14, 3, 9);
			this.TableLayoutPanel5.Controls.Add(this.numLineNo, 4, 8);
			this.TableLayoutPanel5.Controls.Add(this.Label19, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.txtMDLCD, 1, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label7, 5, 10);
			this.TableLayoutPanel5.Controls.Add(this.numPacking, 6, 10);
			this.TableLayoutPanel5.Controls.Add(this.cbGRLNO, 6, 9);
			this.TableLayoutPanel5.Controls.Add(this.Label20, 5, 9);
			this.TableLayoutPanel5.Controls.Add(this.cbPACKING, 6, 8);
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
            this.TableLayoutPanel5.Size = new System.Drawing.Size(1152, 563);
			this.TableLayoutPanel5.TabIndex = 0;
			this.btnRemove1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRemove1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRemove1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRemove1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRemove1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove1.Image = IMS.My.Resources.Resources.Delete;
			this.btnRemove1.Location = new System.Drawing.Point(129, 511);
			this.btnRemove1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRemove1.Name = "btnRemove1";
			this.btnRemove1.Size = new System.Drawing.Size(120, 50);
			this.btnRemove1.TabIndex = 91;
			this.btnRemove1.Text = "Remove";
			this.btnRemove1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemove1.UseVisualStyleBackColor = false;
			this.btnAdd1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAdd1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnAdd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd1.Image = IMS.My.Resources.Resources.Save;
			this.btnAdd1.Location = new System.Drawing.Point(3, 511);
			this.btnAdd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd1.Name = "btnAdd1";
			this.btnAdd1.Size = new System.Drawing.Size(120, 50);
			this.btnAdd1.TabIndex = 73;
			this.btnAdd1.Text = "Add";
			this.btnAdd1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd1.UseVisualStyleBackColor = false;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 430);
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
			this.TableLayoutPanel5.SetColumnSpan(this.dgvDETAILS, 5);
			this.dgvDETAILS.EnableHeadersVisualStyles = false;
			this.dgvDETAILS.Location = new System.Drawing.Point(3, 190);
			this.dgvDETAILS.MultiSelect = false;
			this.dgvDETAILS.Name = "dgvDETAILS";
			this.dgvDETAILS.ReadOnly = true;
			this.dgvDETAILS.RowHeadersVisible = false;
			this.dgvDETAILS.RowHeadersWidth = 51;
			this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDETAILS.Size = new System.Drawing.Size(688, 231);
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
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(129, 29);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(180, 24);
			this.cbLOCID.TabIndex = 53;
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
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 33);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(75, 16);
			this.Label21.TabIndex = 48;
			this.Label21.Text = "Location ID";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 166);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(84, 16);
			this.Label10.TabIndex = 47;
			this.Label10.Text = "Total Weight";
			this.numWEIGHT.AllowNegative = false;
			this.numWEIGHT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWEIGHT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWEIGHT.DataChanged = false;
			this.numWEIGHT.Location = new System.Drawing.Point(129, 163);
			this.numWEIGHT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numWEIGHT.Name = "numWEIGHT";
			this.numWEIGHT.NumberFormat = "8.3";
			this.numWEIGHT.Size = new System.Drawing.Size(180, 22);
			this.numWEIGHT.TabIndex = 10;
			this.numWEIGHT.Text = "0.000";
			this.numWEIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWEIGHT.ThousandSeperator = false;
			this.numWEIGHT.Value = 0.0;
			this.TableLayoutPanel5.SetColumnSpan(this.txtREMRK, 4);
			this.txtREMRK.Location = new System.Drawing.Point(129, 114);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(562, 45);
			this.txtREMRK.TabIndex = 6;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 128);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 460);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(47, 16);
			this.Label13.TabIndex = 71;
			this.Label13.Text = "Lot No";
			this.cbBATCHNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBATCHNO.FormattingEnabled = true;
			this.cbBATCHNO.Location = new System.Drawing.Point(129, 456);
			this.cbBATCHNO.Name = "cbBATCHNO";
			this.cbBATCHNO.Size = new System.Drawing.Size(180, 24);
			this.cbBATCHNO.TabIndex = 72;
			this.cbBOMPN.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbBOMPN, 3);
			this.cbBOMPN.ComboboxWidth = 170;
			this.cbBOMPN.DataTable = null;
			this.cbBOMPN.DisplayMember = null;
			this.cbBOMPN.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBOMPN.HasBlankValue = false;
			this.cbBOMPN.Location = new System.Drawing.Point(130, 426);
			this.cbBOMPN.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbBOMPN.Name = "cbBOMPN";
			this.cbBOMPN.SelectedIndex = -1;
			this.cbBOMPN.SelectedItem = null;
			this.cbBOMPN.SelectedValue = null;
			this.cbBOMPN.Size = new System.Drawing.Size(324, 25);
			this.cbBOMPN.TabIndex = 82;
			this.cbBOMPN.TextMultiline = true;
			this.cbBOMPN.ValueMember = null;
			this.cbBOMPN.WhereClause = null;
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(345, 166);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(97, 16);
			this.Label16.TabIndex = 78;
			this.Label16.Text = "Excess Weight";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(345, 5);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(463, 2);
			this.dtpDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.numEXSQTY.AllowNegative = false;
			this.numEXSQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numEXSQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numEXSQTY.DataChanged = false;
			this.numEXSQTY.Location = new System.Drawing.Point(463, 163);
			this.numEXSQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numEXSQTY.Name = "numEXSQTY";
			this.numEXSQTY.NumberFormat = "8.3";
			this.numEXSQTY.Size = new System.Drawing.Size(123, 22);
			this.numEXSQTY.TabIndex = 79;
			this.numEXSQTY.Text = "0.000";
			this.numEXSQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numEXSQTY.ThousandSeperator = false;
			this.numEXSQTY.Value = 0.0;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(697, 166);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(82, 16);
			this.Label12.TabIndex = 83;
			this.Label12.Text = "Packaging";
			this.dgvPDRWP.AllowUserToAddRows = false;
			this.dgvPDRWP.AllowUserToDeleteRows = false;
			this.dgvPDRWP.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPDRWP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvPDRWP, 2);
			this.dgvPDRWP.EnableHeadersVisualStyles = false;
			this.dgvPDRWP.Location = new System.Drawing.Point(697, 190);
			this.dgvPDRWP.MultiSelect = false;
			this.dgvPDRWP.Name = "dgvPDRWP";
			this.dgvPDRWP.ReadOnly = true;
			this.dgvPDRWP.RowHeadersVisible = false;
			this.dgvPDRWP.RowHeadersWidth = 51;
			this.dgvPDRWP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPDRWP.Size = new System.Drawing.Size(292, 231);
			this.dgvPDRWP.TabIndex = 84;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(697, 430);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(57, 16);
			this.Label6.TabIndex = 85;
			this.Label6.Text = "Packing";
			this.btnAdd2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAdd2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnAdd2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd2.Image = IMS.My.Resources.Resources.Save;
			this.btnAdd2.Location = new System.Drawing.Point(697, 511);
			this.btnAdd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd2.Name = "btnAdd2";
			this.btnAdd2.Size = new System.Drawing.Size(120, 50);
			this.btnAdd2.TabIndex = 89;
			this.btnAdd2.Text = "Add";
			this.btnAdd2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd2.UseVisualStyleBackColor = false;
			this.btnRemove2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRemove2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRemove2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRemove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove2.Image = IMS.My.Resources.Resources.Delete;
			this.btnRemove2.Location = new System.Drawing.Point(823, 511);
			this.btnRemove2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRemove2.Name = "btnRemove2";
			this.btnRemove2.Size = new System.Drawing.Size(120, 50);
			this.btnRemove2.TabIndex = 90;
			this.btnRemove2.Text = "Remove";
			this.btnRemove2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemove2.UseVisualStyleBackColor = false;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(345, 63);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(112, 16);
			this.Label5.TabIndex = 80;
			this.Label5.Text = "Work Order Type";
			this.txtType.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtType.Location = new System.Drawing.Point(463, 60);
			this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtType.Name = "txtType";
			this.txtType.ReadOnly = true;
			this.txtType.Size = new System.Drawing.Size(228, 22);
			this.txtType.TabIndex = 81;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 488);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(56, 16);
			this.Label15.TabIndex = 76;
			this.Label15.Text = "Quantity";
			this.numPARQT.AllowNegative = false;
			this.numPARQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPARQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPARQT.DataChanged = false;
			this.numPARQT.Location = new System.Drawing.Point(129, 485);
			this.numPARQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPARQT.Name = "numPARQT";
			this.numPARQT.NumberFormat = "8.3";
			this.numPARQT.Size = new System.Drawing.Size(104, 22);
			this.numPARQT.TabIndex = 77;
			this.numPARQT.Text = "0.000";
			this.numPARQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPARQT.ThousandSeperator = false;
			this.numPARQT.Value = 0.0;
			this.numBALQT.AllowNegative = false;
			this.numBALQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numBALQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numBALQT.DataChanged = false;
			this.numBALQT.Location = new System.Drawing.Point(463, 457);
			this.numBALQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numBALQT.Name = "numBALQT";
			this.numBALQT.NumberFormat = "8.3";
			this.numBALQT.ReadOnly = true;
			this.numBALQT.Size = new System.Drawing.Size(104, 22);
			this.numBALQT.TabIndex = 92;
			this.numBALQT.Text = "0.000";
			this.numBALQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numBALQT.ThousandSeperator = false;
			this.numBALQT.Value = 0.0;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(345, 460);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(81, 16);
			this.Label14.TabIndex = 93;
			this.Label14.Text = "Balance Qty";
			this.numLineNo.AllowNegative = false;
			this.numLineNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numLineNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numLineNo.DataChanged = false;
			this.numLineNo.Location = new System.Drawing.Point(463, 427);
			this.numLineNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numLineNo.Name = "numLineNo";
			this.numLineNo.NumberFormat = "8.0";
			this.numLineNo.ReadOnly = true;
			this.numLineNo.Size = new System.Drawing.Size(104, 22);
			this.numLineNo.TabIndex = 94;
			this.numLineNo.Text = "0";
			this.numLineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numLineNo.ThousandSeperator = false;
			this.numLineNo.Value = 0.0;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(3, 91);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(82, 16);
			this.Label19.TabIndex = 95;
			this.Label19.Text = "Model Code";
			this.txtMDLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel5.SetColumnSpan(this.txtMDLCD, 3);
			this.txtMDLCD.Location = new System.Drawing.Point(129, 88);
			this.txtMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMDLCD.Name = "txtMDLCD";
			this.txtMDLCD.Size = new System.Drawing.Size(325, 22);
			this.txtMDLCD.TabIndex = 96;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(697, 488);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(56, 16);
			this.Label7.TabIndex = 87;
			this.Label7.Text = "Quantity";
			this.numPacking.AllowNegative = false;
			this.numPacking.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPacking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPacking.DataChanged = false;
			this.numPacking.Location = new System.Drawing.Point(823, 485);
			this.numPacking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPacking.Name = "numPacking";
			this.numPacking.NumberFormat = "8.0";
			this.numPacking.Size = new System.Drawing.Size(104, 22);
			this.numPacking.TabIndex = 88;
			this.numPacking.Text = "0";
			this.numPacking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPacking.ThousandSeperator = false;
			this.numPacking.Value = 0.0;
			this.cbGRLNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGRLNO.FormattingEnabled = true;
			this.cbGRLNO.Location = new System.Drawing.Point(823, 456);
			this.cbGRLNO.Name = "cbGRLNO";
			this.cbGRLNO.Size = new System.Drawing.Size(180, 24);
			this.cbGRLNO.TabIndex = 97;
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(697, 460);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(47, 16);
			this.Label20.TabIndex = 98;
			this.Label20.Text = "Lot No";
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
			this.dgvHEADER.Size = new System.Drawing.Size(1277, 494);
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
			this.lkpDOCNOFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOFR.AllowBlank = false;
			this.lkpDOCNOFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpDOCNOFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpDOCNOFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpDOCNOFR.DescriptionVisible1 = false;
			this.lkpDOCNOFR.DescriptionVisible2 = false;
			this.lkpDOCNOFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOFR.KeyValue = "";
			this.lkpDOCNOFR.LKPCD = "PDRWO_DOCNO";
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
			this.lkpDOCNOTO.LKPCD = "PDRWO_DOCNO";
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
			this.lkpWKONOFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpWKONOFR.AllowBlank = false;
			this.lkpWKONOFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpWKONOFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpWKONOFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpWKONOFR.DescriptionVisible1 = false;
			this.lkpWKONOFR.DescriptionVisible2 = false;
			this.lkpWKONOFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpWKONOFR.KeyValue = "";
			this.lkpWKONOFR.LKPCD = "PDRWO_WKONO";
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
			this.lkpWKONOTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpWKONOTO.AllowBlank = false;
			this.lkpWKONOTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpWKONOTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpWKONOTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpWKONOTO.DescriptionVisible1 = false;
			this.lkpWKONOTO.DescriptionVisible2 = false;
			this.lkpWKONOTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpWKONOTO.KeyValue = "";
			this.lkpWKONOTO.LKPCD = "PDRWO_WKONO";
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
			this.cbPACKING.BlankValue = null;
			this.cbPACKING.ComboboxWidth = 170;
			this.cbPACKING.DataTable = null;
			this.cbPACKING.DisplayMember = null;
			this.cbPACKING.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPACKING.HasBlankValue = false;
			this.cbPACKING.Location = new System.Drawing.Point(825, 426);
			this.cbPACKING.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbPACKING.Name = "cbPACKING";
			this.cbPACKING.SelectedIndex = -1;
			this.cbPACKING.SelectedItem = null;
			this.cbPACKING.SelectedValue = null;
			this.cbPACKING.Size = new System.Drawing.Size(322, 25);
			this.cbPACKING.TabIndex = 101;
			this.cbPACKING.TextMultiline = true;
			this.cbPACKING.ValueMember = null;
			this.cbPACKING.WhereClause = null;
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
			base.Name = "frmPDERFG";
			base.Tag = "PDERFG";
			this.Text = "Return Work Order FG Receiving";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvPDRWP).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
            cbLocation.SelectedIndexChanged += CbLocation_SelectedIndexChanged;

            base.ResumeLayout(false);
		}

        private void CbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBOMPN.DataTable = null;
			cbBATCHNO.DataSource = null;
			cbBOMPN.ComboBox1.DataSource = null;
            if (cbLocation.SelectedValue.ToString().Contains("RTN"))
            {
                string strWHERE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("INTRN_LOCID = '", cbLocation.SelectedValue), "' "));
                strWHERE += "AND (INTRN_BALQT > 0 Or INTRN_ITMCD = 'NAC591') ";
                strWHERE += "AND NOT EXISTS (SELECT * FROM PCRTN_TBL WITH (NOLOCK) WHERE PCRTN_BATCHNO = INTRN_GRLNO)";
				
                cbBOMPN.DataTable = "vwItemBalanceByGRLNO";
                cbBOMPN.WhereClause = strWHERE;
                cbBOMPN.ValueMember = "INTRN_ITMCD";
                cbBOMPN.DisplayMember = "INTRN_ITMCD";
                cbBOMPN.LoadData();
            }
            else
            {
                BindComboBox("ITMCD");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			ClearControl();
			BindComboBox();
			ManageOrderNo();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!Conversions.ToBoolean(Operators.NotObject(ValidateHeader())) && spPDERFG("0"))
			{
				btnDelete.Enabled = true;
				btnPRINT.Enabled = true;
				btnConfirm.Enabled = true;
				dtpDOCDT.Enabled = false;
				cbLOCID.Enabled = false;
			}
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH (NOLOCK) ";
			strSQL += "WHERE MALOC_LOCTY = 'RTN' ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			cbPACKING.DataTable = "MACOD_TBL WITH (NOLOCK) ";
			cbPACKING.WhereClause = "MACOD_CTYID = 'PACKING'";
			cbPACKING.ValueMember = "MACOD_CODID";
			cbPACKING.DisplayMember = "MACOD_CODID";
			cbPACKING.LoadData();
            strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
            strSQL += "FROM MALOC_TBL WITH(NOLOCK) WHERE MALOC_LOCTY = 'WH' OR MALOC_LOCTY = 'RTN' ";
            strSQL += "ORDER BY MALOC_LOCID ";
            cbLocation.ValueMember = "MALOC_LOCID";
            cbLocation.DisplayMember = "MALOC_LOCNM";
            Common.RetriveComboItembySQL(strSQL, cbLocation);
        }

		private object ValidateHeader()
		{
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
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDERFG'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private bool spPDERFG(string strPRO)
		{
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDERFG'"));
			bool spPDERFG;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PDERFG", "DOCNO", ref strNextNo))
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txtDOCNO.Focus();
						spPDERFG = false;
						goto IL_0355;
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
					spPDERFG = false;
					goto IL_0355;
				}
			}
			strSQL = "EXEC spPDERFG ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbWKONO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + txtMDLCD.Text + "', ";
			strSQL = strSQL + "'" + txtREMRK.Text + "', ";
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
				spPDERFG = false;
				ProjectData.ClearProjectError();
				goto IL_0355;
			}
			if (Operators.CompareString(strPRO, "0", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			spPDERFG = true;
			goto IL_0355;
			IL_0355:
			return spPDERFG;
		}

		private void Header()
		{
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spPDRFG '0', ";
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
					int num = dt.Rows.Count - 1;
					int i;
					for (i = 0; i <= num; i++)
					{
						dataGridView.DataSource = dt;
						dataGridView.Columns[i].Visible = true;
						dataGridView.Columns[i].Width = 150;
						dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
						dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
						i++;
						dataGridView.Columns[i].Visible = false;
						i++;
						dataGridView.Columns[i].Visible = true;
						dataGridView.Columns[i].Width = 100;
						dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
						dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Date");
						i++;
						dataGridView.Columns[i].Visible = true;
						dataGridView.Columns[i].Width = 100;
						dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
						dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
						i++;
						dataGridView.Columns[i].Visible = false;
						i++;
						dataGridView.Columns[i].Visible = true;
						dataGridView.Columns[i].Width = 100;
						dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
						dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
						i++;
						dataGridView.Columns[i].Visible = true;
						dataGridView.Columns[i].Width = 120;
						dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
						dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO No");
						i++;
						dataGridView.Columns[i].Visible = true;
						dataGridView.Columns[i].Width = 150;
						dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
						dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
						i++;
						dataGridView.Columns[i].Visible = false;
						i++;
						dataGridView.Columns[i].Visible = false;
						i++;
						dataGridView.Columns[i].Visible = true;
						dataGridView.Columns[i].Width = 120;
						dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
						dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
					}
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
			txtREMRK.Text = string.Empty;
			dgvDETAILS.DataSource = null;
			dgvPDRWP.DataSource = null;
			btnConfirm.Enabled = false;
            btnDelete.Enabled = Common.GetAccessLevel(Conversions.ToString(base.Tag)) >= 3;

            //btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
			btnAdd1.Enabled = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearControl();
			Header();
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["PDRFG_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PDRFG_DOCDT"].Value);
			cbLOCID.SelectedValue = dgvHEADER.CurrentRow.Cells["PDRFG_LOCID"].Value.ToString();
			if (Operators.ConditionalCompareObjectNotEqual(dgvHEADER.CurrentRow.Cells["PDRFG_WKONO"].Value, "", false))
			{
				cbWKONO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDRFG_WKONO"].Value);
			}
			txtMDLCD.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDRFG_MDLCD"].Value);
			numWEIGHT.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["TTL_WEIGHT"].Value);
			numEXSQTY.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["PDRFG_EXCESS"].Value);
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["PDRFG_REMRK"].Value.ToString();
			cbWKONO.Enabled = false;
			GenWorkFile();
			RefreshGrid();
			GenPackingWorkFile();
			RefreshGridPDRFGP();
		}

		private void GenWorkFile()
		{
			string strSQL = "EXEC spPDERFG_WORK 0, '" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbWKONO.SelectedValue), "', '', '', 0")));
			DB.ExecProc(strSQL);
		}

		private void UpdateWorkFile(int intOption)
		{
			string strSQL = "EXEC spPDERFG_WORK " + Conversions.ToString(intOption) + ", ";
			strSQL = strSQL + " '" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbWKONO.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbBOMPN.SelectedValue.ToString()), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbBATCHNO.SelectedValue), "', "), numPARQT.Value)));
			DB.ExecProc(strSQL);
		}

		private void GenPackingWorkFile()
		{
			string strSQL = "EXEC spPDERFG_PACKING 0, ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL += "'', '', 0";
			DB.ExecProc(strSQL);
		}

		private void RefreshGrid()
		{
			int i = 0;
			string strSQL = "SELECT PDRFGD_LINENO, PDRFGD_BOMPN, ";
			strSQL += "IIF(ISNULL(PDRFG_WKONO, PDRFGD_BATCHNO) = '', PDRFGD_BATCHNO, ISNULL(PDRFG_WKONO, PDRFGD_BATCHNO)) AS PDRFGD_BATCHNO, PDRFGD_ACTUAL ";
			strSQL += "FROM PDRFGD_WRK ";
			strSQL += "LEFT JOIN PDRFG_TBL WITH (NOLOCK) ";
			strSQL += "ON PDRFG_MDLCD = PDRFGD_BOMPN AND PDRFG_FGLNO = PDRFGD_BATCHNO ";
			strSQL = strSQL + "WHERE PDRFGD_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "ORDER BY PDRFGD_LINENO";
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
				dataGridView.Columns[i].HeaderText = "Actual";
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindHeadertoControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("TOP 1 PDRFG_STSFG", "PDRFG_TBL", "PDRFG_DOCNO = '" + txtDOCNO.Text + "'"));
			if (Conversions.ToDouble(strSTSFG) == 1.0)
			{
				btnConfirm.Enabled = false;
                btnDelete.Enabled = Common.GetAccessLevel(Conversions.ToString(base.Tag)) >= 3;
                btnAdd1.Enabled = false;
				btnSAVE.Enabled = false;
			}
			else
			{
				btnConfirm.Enabled = true;
				btnDelete.Enabled = true;
				btnAdd1.Enabled = true;
				btnSAVE.Enabled = true;
			}
			cbWKONO.Enabled = false;
			txtDOCNO.Enabled = false;
			dtpDOCDT.Enabled = false;
			cbLOCID.Enabled = false;
			btnPRINT.Enabled = true;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No && spPDERFG("1"))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearControl();
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			if (numPARQT.Value > numBALQT.Value)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Quantity!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			checked
			{
				if (numLineNo.Value == 0.0)
				{
					int num = dgvDETAILS.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(cbBOMPN.SelectedValue, dgvDETAILS.Rows[i].Cells["PDRFGD_BOMPN"].Value, false))
						{
							MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Duplicate item entered!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return false;
						}
					}
				}
				return true;
			}
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void GenerateQRCode()
		{
			OleDbCommand cmd = new OleDbCommand();
			object settings = new BarcodeSettings();
			string strSQL = "EXEC spPDRFG_QR ";
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
			DataTable dt = DB.ExecProc("SELECT DISTINCT PDFGR_FGLNO FROM PDFGR_QR WHERE PDFGR_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "'");
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
				string strSQL = "EXEC spPDERFG_CONFIRM '" + txtDOCNO.Text + "', '" + PublicVar.gstrLogonID + "'";
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
			btnSAVE.Enabled = false;
            btnDelete.Enabled = Common.GetAccessLevel(Conversions.ToString(base.Tag)) >= 3;

            btnAdd1.Enabled = false;
			btnAdd2.Enabled = false;
		}

		private void frmPDERFG_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			cboSTSFG.SelectedIndex = 0;
			Header();
			NumberFormat();
		}

		private void frmPDERFG_FormClosing(object sender, FormClosingEventArgs e)
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
			numWEIGHT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
		}

		private void frmPDERFG_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}
        private void GetLOT()
        {
            string strSQL = "EXEC spPCELOT_WRK '" + MyProject.Computer.Name + "', '" + Common.gfValidSQLStr(Conversions.ToString(cbLocation.SelectedValue)) + "', '" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "'";
            DB.ExecProc(strSQL);
            string strSQL2 = "EXEC spPCLOT '" + MyProject.Computer.Name + "', " + Conversions.ToString(0);
            DataTable dt = DB.ExecProc(strSQL2);
        }
        private void BindComboBox(string strOption)
        {
            string strSQL = string.Empty;
           
            if (Operators.CompareString(strOption, "ITMCD", false) == 0)
            {
				cbBOMPN.ComboBox1.DataSource = null;// ();

                cbBOMPN.DataTable = null;
				cbBOMPN.WhereClause = null;
				cbBOMPN.DisplayMember = null;
                cbBOMPN.DataTable = "PCGRN_TBL WITH (NOLOCK) ";
                cbBOMPN.WhereClause = "PCGRN_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLocation.SelectedValue)) + "'";
                cbBOMPN.ValueMember = "PCGRN_ITMCD";
                cbBOMPN.DisplayMember = "PCGRN_ITMCD";
                cbBOMPN.LoadData();
            }
        }
        private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT PDRWO_WKONO ";
			strSQL += "FROM PDRWO_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE PDRWO_LOCID = '", cbLOCID.SelectedValue), "' ")));
			strSQL += "AND PDRWO_STSFG = 1 ";
			strSQL += "ORDER BY PDRWO_WKONO ";
			cbWKONO.ValueMember = "PDRWO_WKONO";
			cbWKONO.DisplayMember = "PDRWO_WKONO";
			Common.RetriveComboItembySQL(strSQL, cbWKONO);
			//if (cbLocation.SelectedValue == null) return;
   //         if (cbLocation.SelectedValue.ToString().Contains("RTN"))
   //         {
			//	string strWHERE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("INTRN_LOCID = '", cbLOCID.SelectedValue), "' "));
			//	strWHERE += "AND (INTRN_BALQT > 0 Or INTRN_ITMCD = 'NAC591') ";
			//	strWHERE += "AND NOT EXISTS (SELECT * FROM PCRTN_TBL WITH (NOLOCK) WHERE PCRTN_BATCHNO = INTRN_GRLNO)";

			//	cbBOMPN.DataTable = "vwItemBalanceByGRLNO";
			//	cbBOMPN.WhereClause = strWHERE;
			//	cbBOMPN.ValueMember = "INTRN_ITMCD";
			//	cbBOMPN.DisplayMember = "INTRN_ITMCD";
			//	cbBOMPN.LoadData();
			//}
			//else
			//{
   //             BindComboBox("ITMCD");
   //         }	
          
			//dbnow
            
        }

        private void cbWKONO_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!Operators.ConditionalCompareObjectEqual(cbWKONO.SelectedValue, "", false))
			{
				string strSQL = "SELECT * FROM PDRWO_TBL WITH (NOLOCK) ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE PDRWO_WKONO = '", cbWKONO.SelectedValue), "'")));
				DataTable dt = DB.ExecProc(strSQL);
				if (Operators.CompareString(txtMDLCD.Text, "", false) == 0)
				{
					txtMDLCD.Text = Conversions.ToString(dt.Rows[0]["PDRWO_MDLCD"]);
				}
				numWEIGHT.Value = Conversions.ToDouble(dt.Rows[0]["PDRWO_WOQTY"]);
				txtType.Text = Conversions.ToString(dt.Rows[0]["PDRWO_TYPE"]);
				GenWorkFile();
				RefreshGrid();
			}
		}

		private void ClearDetails()
		{
			cbBOMPN.SelectedIndex = -1;
			cbBATCHNO.SelectedIndex = -1;
			numLineNo.Value = 0.0;
			numBALQT.Value = 0.0;
			numPARQT.Value = 0.0;
		}

		private void btnAdd1_Click(object sender, EventArgs e)
		{
			if (ValidateDetailControl())
			{
				UpdateWorkFile(1);
				RefreshGrid();
				ClearDetails();
			}
		}

		private void btnRemove1_Click(object sender, EventArgs e)
		{
			if ((numLineNo.Value == 1.0) | (numLineNo.Value == 2.0))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, "", "Not allow to revome line 1 and 2!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			UpdateWorkFile(2);
			RefreshGrid();
			ClearDetails();
		}

		private void dgvDETAILS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (!Operators.ConditionalCompareObjectEqual(dgvDETAILS.CurrentRow.Cells["PDRFGD_LINENO"].Value, 1, false))
			{
				numLineNo.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["PDRFGD_LINENO"].Value);
				cbBOMPN.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["PDRFGD_BOMPN"].Value);
				cbBATCHNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["PDRFGD_BATCHNO"].Value);
				numPARQT.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["PDRFGD_ACTUAL"].Value);
			}
		}
		bool IsLoad = false;
		DataTable dtLotNo;

        private void cbBOMPN_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!cbLocation.SelectedValue.ToString().Contains("RTN"))
			{
                string strSQL = "EXEC spPCELOT_WRK '" + MyProject.Computer.Name + "', '" + Common.gfValidSQLStr(Conversions.ToString(cbLocation.SelectedValue)) + "', '" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "'";
                DB.ExecProc(strSQL);
                string strSQL2 = "EXEC spPCLOT '" + MyProject.Computer.Name + "', " + Conversions.ToString(0);
                dtLotNo = DB.ExecProc(strSQL2);
				List<String> list = new List<string>();
            

                foreach (DataRow row in dtLotNo.Rows)
				{
					if (Convert.ToDouble( row["INTRN_BALQT"])>0)
					{
						list.Add(row["PCGRN_DOCNO"].ToString());
					}	
				}
				_cbBATCHNO.DataSource = list;
    //            string strSQL = "SELECT PCGRN_DOCNO ";
				//strSQL += "FROM PCGRN_TBL ";
				//strSQL += "WHERE PCGRN_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "'"; // Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE INTRN_LOCID = '", cbLOCID.SelectedValue), "' ")));

				//strSQL += "ORDER BY PCGRN_DOCNO ";
				//cbBATCHNO.ValueMember = "PCGRN_DOCNO";
				//cbBATCHNO.DisplayMember = "PCGRN_DOCNO";
				//Common.RetriveComboItembySQL(strSQL, cbBATCHNO);
			}
			else
			{
				string strSQL = "SELECT INTRN_GRLNO ";
				strSQL += "FROM vwItemBalanceByGRLNO ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE INTRN_LOCID = '", cbLOCID.SelectedValue), "' ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND INTRN_ITMCD = '", cbBOMPN.SelectedValue), "' ")));
				strSQL += "AND INTRN_BALQT > 0 ";
				strSQL += "ORDER BY INTRN_GRLNO ";
				cbBATCHNO.DataSource = null;

                cbBATCHNO.ValueMember = "INTRN_GRLNO";
				cbBATCHNO.DisplayMember = "INTRN_GRLNO";
                Common.RetriveComboItembySQL(strSQL, cbBATCHNO);
            }
        }
      
        private void cbBATCHNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!cbLocation.SelectedValue.ToString().Contains("RTN"))
			{
				numBALQT.Value = 0.0;
				if (cbBATCHNO.SelectedIndex != -1)
				{
                 DataRow[] rows  = dtLotNo.Select(string.Format("PCGRN_DOCNO ='{0}' ", cbBATCHNO.SelectedValue.ToString()));
                   
                    if(rows.Length>0)
					{
						numBALQT.Value = Conversions.ToDouble(rows[0]["INTRN_BALQT"]);

                    }	
                }
			}
			else
			{
                numBALQT.Value = 0.0;
				if (cbBATCHNO.SelectedIndex != -1)
				{
					string strSQL = "INTRN_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "' ";
					strSQL = strSQL + "AND INTRN_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "' ";
					strSQL = strSQL + "AND INTRN_GRLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "'";
					numBALQT.Value = Conversions.ToDouble(DB.GetColumnValue("INTRN_BALQT", "vwItemBalanceByGRLNO", strSQL));
				}
            }
        }

		private void RefreshGridPDRFGP()
		{
			int i = 0;
			dgvPDRWP.DataSource = null;
			string strSQL = "SELECT WRK_PACKING, WRK_GRLNO, WRK_QTY ";
			strSQL = strSQL + "FROM PDRFGP_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "'";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count != 0)
				{
					DataGridView dataGridView = dgvPDRWP;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void btnAdd2_Click(object sender, EventArgs e)
		{
			string strSQL = "EXEC spPDERFG_PACKING 1, ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPACKING.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbGRLNO.SelectedValue), "', ")));
			strSQL += Conversions.ToString(numPacking.Value);
			DB.ExecProc(strSQL);
			RefreshGridPDRFGP();
		}

		private void btnRemove2_Click(object sender, EventArgs e)
		{
			string strSQL = "EXEC spPDERFG_PACKING 2, ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPACKING.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbGRLNO.SelectedValue), "', ")));
			strSQL += Conversions.ToString(numPacking.Value);
			DB.ExecProc(strSQL);
			RefreshGridPDRFGP();
		}

		private void cbPACKING_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT INTRN_GRLNO ";
			strSQL += "FROM vwItemBalanceByGRLNO ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE INTRN_LOCID = '", cbLOCID.SelectedValue), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND INTRN_ITMCD = '", cbPACKING.SelectedValue), "' ")));
			strSQL += "AND INTRN_BALQT > 0 ";
			strSQL += "ORDER BY INTRN_GRLNO ";
			cbGRLNO.ValueMember = "INTRN_GRLNO";
			cbGRLNO.DisplayMember = "INTRN_GRLNO";
			Common.RetriveComboItembySQL(strSQL, cbGRLNO);
		}

		private void dgvPDRWP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			cbPACKING.SelectedValue = RuntimeHelpers.GetObjectValue(dgvPDRWP.CurrentRow.Cells["WRK_PACKING"].Value);
			cbGRLNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvPDRWP.CurrentRow.Cells["WRK_GRLNO"].Value);
			numPacking.Value = Conversions.ToDouble(dgvPDRWP.CurrentRow.Cells["WRK_QTY"].Value);
		}
	}
}
