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
	public class frmPCERTN : Form
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
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

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
		[AccessedThroughProperty("btnPRINTFR")]
		private Button _btnPRINTFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDetails")]
		private DataGridView _dgvDetails;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numQTY")]
		private NumControl _numQTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numUPRICE")]
		private NumControl _numUPRICE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDELETEFR")]
		private Button _btnDELETEFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnConfirm")]
		private Button _btnConfirm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSID")]
		private ComboboxControl _cbCUSID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCD")]
		private ComboboxControl _cbITMCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbPACKING")]
		private ComboboxControl _cbPACKING;

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

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
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

		internal virtual Button btnPRINTFR
		{
			[CompilerGenerated]
			get
			{
				return _btnPRINTFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPRINTFR_Click;
				Button button = _btnPRINTFR;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPRINTFR = value;
				button = _btnPRINTFR;
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

		internal virtual DataGridView dgvDetails
		{
			[CompilerGenerated]
			get
			{
				return _dgvDetails;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDetails_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvDetails;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvDetails = value;
				dataGridView = _dgvDetails;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
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
				EventHandler value2 = numQTY_TextChanged;
				NumControl numControl = _numQTY;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numQTY = value;
				numControl = _numQTY;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		internal virtual NumControl numUPRICE
		{
			[CompilerGenerated]
			get
			{
				return _numUPRICE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numUPRICE_TextChanged;
				NumControl numControl = _numUPRICE;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numUPRICE = value;
				numControl = _numUPRICE;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
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
		Button btnReturnMaterial = new Button();

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

		internal virtual Button btnREMOVE
		{
			[CompilerGenerated]
			get
			{
				return _btnREMOVE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnREMOVE_Click;
				Button button = _btnREMOVE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnREMOVE = value;
				button = _btnREMOVE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		[field: AccessedThroughProperty("numWEIGHT")]
		internal virtual NumControl numWEIGHT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTDWGT")]
		internal virtual Label lblSTDWGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbCUSID_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbCUSID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbCUSID = value;
				comboboxControl = _cbCUSID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbLOCID")]
		internal virtual ComboBox cbLOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbITMCD //db2
		{
			[CompilerGenerated]
			get
			{
				return _cbITMCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbITMCD_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbITMCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbITMCD = value;
				comboboxControl = _cbITMCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("txtBATCHNO")]
		internal virtual TextBox txtBATCHNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbDOCNOFR")]
		internal virtual ComboboxControl cbDOCNOFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbDOCNOTO")]
		internal virtual ComboboxControl cbDOCNOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCUSIDFR")]
		internal virtual ComboboxControl cbCUSIDFR
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

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
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

		[field: AccessedThroughProperty("numSTRNG")]
		internal virtual NumControl numSTRNG
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

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbREVNO")]
		internal virtual ComboBox cbREVNO
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

		[field: AccessedThroughProperty("cbTYPE")]
		internal virtual ComboBox cbTYPE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSTDWGT")]
		internal virtual NumControl numSTDWGT
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

		public frmPCERTN()
		{
			base.Load += frmPCERTN_Load;
			base.FormClosing += frmPCERTN_FormClosing;
			base.KeyDown += frmPCERTN_KeyDown;
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
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.cbPACKING = new IMS.ComboboxControl();
			this.numSTDWGT = new IMS.NumControl();
			this.cbTYPE = new System.Windows.Forms.ComboBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.cbREVNO = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.numSTRNG = new IMS.NumControl();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.cbITMCD = new IMS.ComboboxControl();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.cbCUSID = new IMS.ComboboxControl();
			this.Label4 = new System.Windows.Forms.Label();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtCURCD = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.numAMT = new IMS.NumControl();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.numWEIGHT = new IMS.NumControl();
			this.Label7 = new System.Windows.Forms.Label();
			this.numQTY = new IMS.NumControl();
			this.Label14 = new System.Windows.Forms.Label();
			this.numUPRICE = new IMS.NumControl();
			this.lblSTDWGT = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtBATCHNO = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDELETEFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbCUSIDTO = new IMS.ComboboxControl();
			this.cbCUSIDFR = new IMS.ComboboxControl();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.cboSTSFG = new System.Windows.Forms.ComboBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
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
			this.Panel1.Size = new System.Drawing.Size(1348, 623);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnConfirm, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel6.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel6.TabIndex = 0;
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
			this.btnConfirm.TabIndex = 16;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConfirm.UseVisualStyleBackColor = false;
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
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
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
			this.btnPRINT.TabIndex = 19;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
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
			this.btnBack.TabIndex = 18;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 8;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.cbPACKING, 1, 6);
    
        
            this.TableLayoutPanel5.Controls.Add(this.numSTDWGT, 5, 6);
			this.TableLayoutPanel5.Controls.Add(this.cbTYPE, 7, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label13, 6, 2);
			this.TableLayoutPanel5.Controls.Add(this.cbREVNO, 5, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label11, 4, 5);
			this.TableLayoutPanel5.Controls.Add(this.numSTRNG, 5, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label6, 4, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label20, 2, 7);
			this.TableLayoutPanel5.Controls.Add(this.cbITMCD, 1, 5);
			this.TableLayoutPanel5.Controls.Add(this.cbLOCID, 1, 2);
			this.TableLayoutPanel5.Controls.Add(this.cbCUSID, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel3, 0, 11);
			this.TableLayoutPanel5.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label3, 6, 0);
			this.TableLayoutPanel5.Controls.Add(this.dtpDOCDT, 7, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.txtCURCD, 7, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label19, 6, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label21, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label10, 0, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label8, 0, 5);
			this.TableLayoutPanel5.Controls.Add(this.dgvDetails, 0, 4);
			this.TableLayoutPanel5.Controls.Add(this.txtREMRK, 1, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label9, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.numAMT, 5, 8);
			this.TableLayoutPanel5.Controls.Add(this.txtRECID, 6, 8);
			this.TableLayoutPanel5.Controls.Add(this.numWEIGHT, 3, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label7, 4, 8);
			this.TableLayoutPanel5.Controls.Add(this.numQTY, 1, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label14, 0, 8);
			this.TableLayoutPanel5.Controls.Add(this.numUPRICE, 1, 8);
			this.TableLayoutPanel5.Controls.Add(this.lblSTDWGT, 4, 6);
			this.TableLayoutPanel5.Controls.Add(this.Label15, 0, 6);
			this.TableLayoutPanel5.Controls.Add(this.txtBATCHNO, 1, 9);
			this.TableLayoutPanel5.Controls.Add(this.Label12, 0, 9);
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
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(1258, 519);
			this.TableLayoutPanel5.TabIndex = 0;
			this.cbPACKING.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbPACKING, 3);
			this.cbPACKING.ComboboxWidth = 150;
			this.cbPACKING.DataTable = null;
			this.cbPACKING.DisplayMember = null;
			this.cbPACKING.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPACKING.HasBlankValue = false;
			this.cbPACKING.Location = new System.Drawing.Point(102, 340);
			this.cbPACKING.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbPACKING.Name = "cbPACKING";
			this.cbPACKING.SelectedIndex = -1;
			this.cbPACKING.SelectedItem = null;
			this.cbPACKING.SelectedValue = null;
			this.cbPACKING.Size = new System.Drawing.Size(261, 25);
			this.cbPACKING.TabIndex = 65;
			this.cbPACKING.TextMultiline = true;
			this.cbPACKING.ValueMember = null;
			this.cbPACKING.WhereClause = null;
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(546, 341);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.0";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(87, 22);
			this.numSTDWGT.TabIndex = 64;
			this.numSTDWGT.Text = "0";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.cbTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTYPE.FormattingEnabled = true;
			this.cbTYPE.Location = new System.Drawing.Point(763, 61);
			this.cbTYPE.Name = "cbTYPE";
			this.cbTYPE.Size = new System.Drawing.Size(173, 24);
			this.cbTYPE.TabIndex = 63;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(656, 65);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(40, 16);
			this.Label13.TabIndex = 62;
			this.Label13.Text = "Type";
			this.cbREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbREVNO.FormattingEnabled = true;
			this.cbREVNO.Location = new System.Drawing.Point(546, 311);
			this.cbREVNO.Name = "cbREVNO";
			this.cbREVNO.Size = new System.Drawing.Size(104, 24);
			this.cbREVNO.TabIndex = 60;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(432, 315);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(94, 16);
			this.Label11.TabIndex = 59;
			this.Label11.Text = "BOM Revision";
			this.numSTRNG.AllowNegative = false;
			this.numSTRNG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTRNG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTRNG.DataChanged = false;
			this.numSTRNG.Location = new System.Drawing.Point(546, 370);
			this.numSTRNG.Name = "numSTRNG";
			this.numSTRNG.NumberFormat = "8.2";
			this.numSTRNG.Size = new System.Drawing.Size(87, 22);
			this.numSTRNG.TabIndex = 9;
			this.numSTRNG.Text = "0.00";
			this.numSTRNG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTRNG.ThousandSeperator = false;
			this.numSTRNG.Value = 0.0;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(432, 373);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(57, 16);
			this.Label6.TabIndex = 58;
			this.Label6.Text = "Strength";
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(195, 373);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(50, 16);
			this.Label20.TabIndex = 57;
			this.Label20.Text = "Weight";
			this.cbITMCD.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbITMCD, 3);
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = false;
			this.cbITMCD.Location = new System.Drawing.Point(102, 310);
			this.cbITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(324, 25);
			this.cbITMCD.TabIndex = 6;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbLOCID, 4);
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(102, 61);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(326, 24);
			this.cbLOCID.TabIndex = 4;
			this.cbCUSID.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbCUSID, 4);
			this.cbCUSID.ComboboxWidth = 170;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = true;
			this.cbCUSID.Location = new System.Drawing.Point(102, 30);
			this.cbCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(327, 26);
			this.cbCUSID.TabIndex = 3;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 6);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(93, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No.";
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel5.SetColumnSpan(this.TableLayoutPanel3, 8);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
            this.TableLayoutPanel3.Controls.Add(this.btnReturnMaterial,3, 0);
            this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 463);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel3.TabIndex = 0;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(129, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 14;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(3, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 50);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Add";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;


			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 15;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;

            //
            this.btnReturnMaterial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturnMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturnMaterial.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnReturnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReturnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMaterial.Image = IMS.My.Resources.Resources.Back;
            this.btnReturnMaterial.Location = new System.Drawing.Point(255, 2);
            this.btnReturnMaterial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnMaterial.Name = "btnReturnMaterial";
            this.btnReturnMaterial.Size = new System.Drawing.Size(160, 50);
            this.btnReturnMaterial.TabIndex = 15;
            this.btnReturnMaterial.Text = "Modify Material";
            this.btnReturnMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnMaterial.UseVisualStyleBackColor = false;
            this.btnReturnMaterial.Click += BtnReturnMaterial_Click;

            this.TableLayoutPanel5.SetColumnSpan(this.txtDOCNO, 3);
			this.txtDOCNO.Location = new System.Drawing.Point(102, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(656, 6);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(763, 3);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 35);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(81, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Customer ID";
			this.txtCURCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCURCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCURCD.Enabled = false;
			this.txtCURCD.Location = new System.Drawing.Point(763, 32);
			this.txtCURCD.Name = "txtCURCD";
			this.txtCURCD.Size = new System.Drawing.Size(87, 22);
			this.txtCURCD.TabIndex = 4;
			this.txtCURCD.TabStop = false;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(656, 35);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(61, 16);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "Currency";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 65);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(75, 16);
			this.Label21.TabIndex = 48;
			this.Label21.Text = "Location ID";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 373);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(56, 16);
			this.Label10.TabIndex = 47;
			this.Label10.Text = "Quantity";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 315);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(82, 16);
			this.Label8.TabIndex = 3;
			this.Label8.Text = "Model Code";
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvDetails, 8);
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Location = new System.Drawing.Point(3, 142);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(1252, 163);
			this.dgvDetails.TabIndex = 7;
			this.dgvDetails.TabStop = false;
			this.TableLayoutPanel5.SetColumnSpan(this.txtREMRK, 7);
			this.txtREMRK.Location = new System.Drawing.Point(102, 91);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(696, 45);
			this.txtREMRK.TabIndex = 5;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 105);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.numAMT.AllowNegative = false;
			this.numAMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numAMT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numAMT.DataChanged = false;
			this.numAMT.Enabled = false;
			this.numAMT.Location = new System.Drawing.Point(546, 398);
			this.numAMT.Name = "numAMT";
			this.numAMT.NumberFormat = "8.2";
			this.numAMT.Size = new System.Drawing.Size(87, 22);
			this.numAMT.TabIndex = 11;
			this.numAMT.Text = "0.00";
			this.numAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numAMT.ThousandSeperator = false;
			this.numAMT.Value = 0.0;
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(656, 398);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(56, 22);
			this.txtRECID.TabIndex = 0;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRECID.Visible = false;
			this.numWEIGHT.AllowNegative = false;
			this.numWEIGHT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWEIGHT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWEIGHT.DataChanged = false;
			this.numWEIGHT.Location = new System.Drawing.Point(251, 370);
			this.numWEIGHT.Name = "numWEIGHT";
			this.numWEIGHT.NumberFormat = "8.0";
			this.numWEIGHT.ReadOnly = true;
			this.numWEIGHT.Size = new System.Drawing.Size(87, 22);
			this.numWEIGHT.TabIndex = 16;
			this.numWEIGHT.Text = "0";
			this.numWEIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWEIGHT.ThousandSeperator = false;
			this.numWEIGHT.Value = 0.0;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(432, 401);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(53, 16);
			this.Label7.TabIndex = 8;
			this.Label7.Text = "Amount";
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQTY.DataChanged = false;
			this.numQTY.Location = new System.Drawing.Point(102, 370);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.2";
			this.numQTY.Size = new System.Drawing.Size(87, 22);
			this.numQTY.TabIndex = 8;
			this.numQTY.Text = "0.00";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(3, 401);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(65, 16);
			this.Label14.TabIndex = 9;
			this.Label14.Text = "70% of Unit Price";
			this.numUPRICE.AllowNegative = false;
			this.numUPRICE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numUPRICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numUPRICE.DataChanged = false;
			this.numUPRICE.Location = new System.Drawing.Point(102, 398);
			this.numUPRICE.Name = "numUPRICE";
			this.numUPRICE.NumberFormat = "8.2";
			this.numUPRICE.Size = new System.Drawing.Size(87, 22);
			this.numUPRICE.TabIndex = 10;
			this.numUPRICE.Text = "0.00";
			this.numUPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUPRICE.ThousandSeperator = false;
			this.numUPRICE.Value = 0.0;
			this.numUPRICE.Enabled = false;
			this.lblSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTDWGT.AutoSize = true;
			this.lblSTDWGT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTDWGT.Location = new System.Drawing.Point(432, 344);
			this.lblSTDWGT.Name = "lblSTDWGT";
			this.lblSTDWGT.Size = new System.Drawing.Size(108, 16);
			this.lblSTDWGT.TabIndex = 50;
			this.lblSTDWGT.Text = "Standard Weight";
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 344);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(57, 16);
			this.Label15.TabIndex = 55;
			this.Label15.Text = "Packing";
			this.TableLayoutPanel5.SetColumnSpan(this.txtBATCHNO, 3);
			this.txtBATCHNO.Location = new System.Drawing.Point(102, 426);
			this.txtBATCHNO.Name = "txtBATCHNO";
			this.txtBATCHNO.Size = new System.Drawing.Size(261, 22);
			this.txtBATCHNO.TabIndex = 12;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(3, 429);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(63, 16);
			this.Label12.TabIndex = 51;
			this.Label12.Text = "Batch No";
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 623);
			this.Panel2.TabIndex = 2;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 189);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1064, 423);
			this.dgvHEADER.TabIndex = 0;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 5;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnDELETEFR, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 4, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 3, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 130);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(630, 54);
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
			this.btnClose.Location = new System.Drawing.Point(507, 2);
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
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(381, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTFR.TabIndex = 11;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.cboSTSFG, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label22, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 4;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(798, 117);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbCUSIDTO.BlankValue = null;
			this.cbCUSIDTO.ComboboxWidth = 170;
			this.cbCUSIDTO.DataTable = null;
			this.cbCUSIDTO.DisplayMember = null;
			this.cbCUSIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDTO.HasBlankValue = true;
			this.cbCUSIDTO.Location = new System.Drawing.Point(471, 32);
			this.cbCUSIDTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbCUSIDTO.Name = "cbCUSIDTO";
			this.cbCUSIDTO.SelectedIndex = -1;
			this.cbCUSIDTO.SelectedItem = null;
			this.cbCUSIDTO.SelectedValue = null;
			this.cbCUSIDTO.Size = new System.Drawing.Size(323, 25);
			this.cbCUSIDTO.TabIndex = 19;
			this.cbCUSIDTO.TextMultiline = true;
			this.cbCUSIDTO.ValueMember = null;
			this.cbCUSIDTO.WhereClause = null;
			this.cbCUSIDFR.BlankValue = null;
			this.cbCUSIDFR.ComboboxWidth = 170;
			this.cbCUSIDFR.DataTable = null;
			this.cbCUSIDFR.DisplayMember = null;
			this.cbCUSIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDFR.HasBlankValue = true;
			this.cbCUSIDFR.Location = new System.Drawing.Point(109, 32);
			this.cbCUSIDFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbCUSIDFR.Name = "cbCUSIDFR";
			this.cbCUSIDFR.SelectedIndex = -1;
			this.cbCUSIDFR.SelectedItem = null;
			this.cbCUSIDFR.SelectedValue = null;
			this.cbCUSIDFR.Size = new System.Drawing.Size(325, 25);
			this.cbCUSIDFR.TabIndex = 18;
			this.cbCUSIDFR.TextMultiline = true;
			this.cbCUSIDFR.ValueMember = null;
			this.cbCUSIDFR.WhereClause = null;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(471, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(325, 26);
			this.cbDOCNOTO.TabIndex = 18;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(109, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(327, 25);
			this.cbDOCNOFR.TabIndex = 17;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[3] { "Pending Only", "Confirm Only", "All" });
			this.cboSTSFG.Location = new System.Drawing.Point(110, 90);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(121, 24);
			this.cboSTSFG.TabIndex = 7;
			this.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label22.Location = new System.Drawing.Point(3, 94);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(45, 16);
			this.Label22.TabIndex = 10;
			this.Label22.Text = "Status";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 36);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(81, 16);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Customer ID";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(441, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(472, 62);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 6;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(110, 62);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 5;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(441, 7);
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
			this.Label16.Location = new System.Drawing.Point(441, 36);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 16);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPCERTN";
			base.Tag = "PCERTN";
			this.Text = "Customer Return Entry";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}
		//db2
        private void BtnReturnMaterial_Click(object sender, EventArgs e)
        {

            if (cbITMCD.SelectedValue != null)
            {
                String sItemCode = Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue));
                String sRevNo = Common.gfValidSQLStr(Conversions.ToString(cbREVNO.SelectedValue));
                DataTable dt = DB.GetTable("MACPT_CPTNO", "MACPT_TBL", "MACPT_REVNO='" + sRevNo + "' AND MACPT_ITMCD='" + sItemCode + "'", "");
                if (dt != null)
                    if (dt.Rows.Count > 0)
                    {
                        G.IsModifyRerun = true;
					 G.frmMAEBOM = new frmMAEBOM();
                        G.MDIParent.ShowChildForm(RuntimeHelpers.GetObjectValue(sender), e, G.frmMAEBOM);
                        G.frmMAEBOM.cbMDLCDFR.SelectedValue = sItemCode;
                        G.frmMAEBOM.cbMDLCDTO.SelectedValue = sItemCode;
                        G.frmMAEBOM.Header();

						
                        G.frmMAEBOM.ReturnBillMaterial(sRevNo);


                    }
            }
            //"PCRTN_ITMCD"
   //         foreach (DataRow row in this.dtMaterialReturn.Rows)
			//{
			//	String ItemCode = row["PCRTN_ITMCD"].ToString();
   //             String Version = row["PCRTN_REVNO"].ToString();
			//	DataTable dt = DB.GetTable("MABOM_BOMPN", "MABOM_TBL", "MABOM_MDLCD='" + ItemCode + "' AND MABOM_REVNO='"+ Version + "'","");
   //        if(dt.Rows.Count>0)
			//	{
			//		foreach(DataRow row2 in dt.Rows)
			//		{
			//			String ItemCode2 = row2[0].ToString();
   //                     string strSQL = "UPDATE PCGRN_TBL SET PDSWOR_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
   //                     strSQL = strSQL + "PCGRN_ITMCD = " + ItemCode2 + " ";
   //                     strSQL = strSQL + "WHERE PCGRN_ITMCD = '" + ItemCode2 +  "' ";
   //                     //strSQL = strSQL + "AND PDSWOR_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
   //                     //strSQL = strSQL + "AND PDSWOR_REVNO = " + Conversions.ToString(numREVNO.Value);

			//		//	DB.RecordExists();
			//		}
			//	}
			//}
        }

        private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnSave.Enabled = true;
			btnREMOVE.Enabled = true;
			btnDelete.Enabled = true;
			btnConfirm.Enabled = true;
			cbCUSID.Enabled = true;
			dtpDOCDT.Enabled = true;
			cbLOCID.Enabled = true;
			txtDOCNO.Enabled = true;
			ClearControl();
			ClearDetails();
			ManageOrderNo();
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "PCRTN_TBL WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "PCRTN_DOCNO";
			cbDOCNOFR.DisplayMember = "PCRTN_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "PCRTN_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "PCRTN_DOCNO";
			cbDOCNOTO.DisplayMember = "PCRTN_DOCNO";
			cbDOCNOTO.LoadData();
			cbCUSIDFR.DataTable = "PCRTN_TBL WITH (NOLOCK) LEFT JOIN MACUS_TBL WITH (NOLOCK) ON MACUS_CUSID = PCRTN_CUSID ";
			cbCUSIDFR.ValueMember = "PCRTN_CUSID";
			cbCUSIDFR.DisplayMember = "PCRTN_CUSID";
			cbCUSIDFR.LoadData();
			cbCUSIDTO.DataTable = "PCRTN_TBL WITH (NOLOCK) LEFT JOIN MACUS_TBL WITH (NOLOCK) ON MACUS_CUSID = PCRTN_CUSID ";
			cbCUSIDTO.ValueMember = "PCRTN_CUSID";
			cbCUSIDTO.DisplayMember = "PCRTN_CUSID";
			cbCUSIDTO.LoadData();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (ValidateDetailControl() && spPCERTN("0"))
			{
				RefreshGrid();
				ClearDetails();
				cbLOCID.Enabled = false;
				cbCUSID.Enabled = false;
				dtpDOCDT.Enabled = false;
			}
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PCERTN'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private bool spPCERTN(string strPRO)
		{
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PCERTN'"));
			bool spPCERTN;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PCERTN", "PCRTN", ref strNextNo))
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spPCERTN = false;
						goto IL_044e;
					}
					txtDOCNO.Text = strNextNo;
				}
			}
			else
			{
				txtDOCNO.Enabled = true;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					txtDOCNO.Focus();
					spPCERTN = false;
					goto IL_044e;
				}
			}
			if (Operators.CompareString(strPRO, "0", false) == 0 && Operators.CompareString(txtBATCHNO.Text, string.Empty, false) == 0)
			{
				MessageBox.Show("Batch No cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtBATCHNO.Focus();
				spPCERTN = false;
			}
			else
			{
				strSQL = "EXEC spPCERTN ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = strSQL + Conversions.ToString(Conversion.Val(txtRECID.Text)) + ", ";
				strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbTYPE.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
				strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + ", ";
				strSQL = strSQL + Conversions.ToString(numWEIGHT.Value) + ", ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPACKING.SelectedValue), "', ")));
				strSQL = strSQL + Conversions.ToString(numSTRNG.Value) + ", ";
				strSQL = strSQL + Conversions.ToString(numUPRICE.Value) + ", ";
				strSQL = strSQL + Conversions.ToString(numAMT.Value) + ", ";
				strSQL = strSQL + Conversions.ToString(numSTDWGT.Value) + ", ";
				strSQL = strSQL + "'" + txtBATCHNO.Text + "', ";
				strSQL = strSQL + "'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spPCERTN = false;
					ProjectData.ClearProjectError();
					goto IL_044e;
				}
				spPCERTN = true;
			}
			goto IL_044e;
			IL_044e:
			return spPCERTN;
		}

		private void Header()  //DBA000
		{
			Panel2.Visible = true;
			Panel1.Visible = false;
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spPCRTN '0', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDTO.SelectedValue), "', ")));
			strSQL += Conversions.ToString(cboSTSFG.SelectedIndex) ?? "";
			DataTable dt = DB.ExecProc(strSQL);
			btnReturnMaterial.Enabled = false;
			checked
			{
				if (dt.Rows.Count != 0)
				{
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					int i = default(int);
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document Date");
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
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
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 300;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void Calculate()
		{
			numWEIGHT.Value = numSTDWGT.Value * numQTY.Value;
			numAMT.Value = numQTY.Value * numUPRICE.Value;
		}

		private void ClearDetails()
		{
			txtRECID.Text = Conversions.ToString(-1);
			cbITMCD.Enabled = true;
			cbREVNO.Enabled = true;
			cbITMCD.SelectedIndex = -1;
			cbREVNO.SelectedIndex = -1;
			cbPACKING.SelectedIndex = -1;
			numSTDWGT.Value = 0.0;
			numQTY.Value = 0.0;
			numSTRNG.Value = 0.0;
			numUPRICE.Value = 0.0;
			numAMT.Value = 0.0;
			txtBATCHNO.Text = string.Empty;
			btnSave.Text = "Add";
		}

		private void ClearControl()
		{
			dgvDetails.DataSource = null;
			txtDOCNO.Text = string.Empty;
			cbLOCID.Enabled = true;
			dtpDOCDT.Value = DateTime.Now;
			dtpDOCDT.Enabled = true;
			txtCURCD.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			txtDOCNO.Enabled = true;
			cbCUSID.Enabled = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			btnReturnMaterial.Enabled = false;
			ClearDetails();
			ClearControl();
			Header();
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["PCRTN_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PCRTN_DOCDT"].Value);
			cbTYPE.SelectedValue = dgvHEADER.CurrentRow.Cells["PCRTN_TYPE"].Value.ToString();
			cbCUSID.SelectedValue = dgvHEADER.CurrentRow.Cells["PCRTN_CUSID"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["PCRTN_REMRK"].Value.ToString();
			cbLOCID.SelectedValue = dgvHEADER.CurrentRow.Cells["PCRTN_LOCID"].Value.ToString();
		}

		private void BindGridtoControl()
		{
			txtRECID.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["PCRTN_RECID"].Value);
			cbITMCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["PCRTN_ITMCD"].Value);
			cbREVNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["PCRTN_REVNO"].Value);
			numWEIGHT.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCRTN_QTY"].Value);
			cbPACKING.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["PCRTN_PACKING"].Value);
			numQTY.Value = numWEIGHT.Value / numSTDWGT.Value;
			numSTRNG.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCRTN_STRNG"].Value);
			numUPRICE.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCRTN_UPRICE"].Value);
			numAMT.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCRTN_AMT"].Value);
			txtBATCHNO.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["PCRTN_BATCHNO"].Value);
		}
		//db01 Get Value Return
		DataTable dtMaterialReturn=new DataTable();
		private void RefreshGrid()
		{
			dgvDetails.DataSource = null;
			string strSQL = "SELECT PCRTN_RECID, PCRTN_ITMCD, PCRTN_REVNO, MAITM_DESC, PCRTN_BATCHNO, ";
			strSQL += "PCRTN_STRNG, PCRTN_QTY, PCRTN_PACKING, PCRTN_UPRICE, PCRTN_AMT ";
			strSQL += "FROM PCRTN_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL ON MAITM_ITMCD = PCRTN_ITMCD ";
			strSQL = strSQL + "WHERE PCRTN_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "'";
			DataTable dt = DB.ExecProc(strSQL);
			dtMaterialReturn = dt;
            DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			int i = default(int);
			dataGridView.Columns[i].Visible = false;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Strength");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Weight");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Unit Price");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void BindComboBox()
		{
			cbCUSID.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSID.ValueMember = "MACUS_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			cbCUSID.LoadData();
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) WHERE MALOC_LOCTY = 'RTN' ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) WHERE MACOD_CTYID = 'RTNTYPE' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbTYPE.ValueMember = "MACOD_CODID";
			cbTYPE.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbTYPE);
			cbPACKING.DataTable = "MACOD_TBL WITH(NOLOCK) ";
			cbPACKING.WhereClause = "MACOD_CTYID = 'PACKING' ";
			cbPACKING.ValueMember = "MACOD_CODID";
			cbPACKING.DisplayMember = "MACOD_CODID";
			cbPACKING.LoadData();
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindHeadertoControl();
			RefreshGrid();
			Panel1.Visible = true;
			Panel2.Visible = false;
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("PCRTN_STSFG", "PCRTN_TBL", "PCRTN_DOCNO = '" + txtDOCNO.Text + "'"));
			if (Conversions.ToDouble(strSTSFG) == 1.0)
			{
				btnDelete.Enabled = false;
				btnConfirm.Enabled = false;
				btnREMOVE.Enabled = false;
				btnSave.Enabled = false;
			}
			else
			{
				btnSave.Enabled = intAccessLevel >= 1;
				btnREMOVE.Enabled = intAccessLevel >= 3;
				btnDelete.Enabled = intAccessLevel >= 3;
				btnConfirm.Enabled = intAccessLevel >= 1;
			}
			cbCUSID.Enabled = false;
			dtpDOCDT.Enabled = false;
			cbLOCID.Enabled = false;
			txtDOCNO.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM PCRTN_TBL ";
			strSQL = strSQL + "WHERE PCRTN_DOCNO = '" + txtDOCNO.Text + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No. not exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbCUSID.Focus();
			}
			else if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No && spPCERTN("1"))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				ClearControl();
				BindComboHeader();
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbCUSID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show("Customer ID cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbCUSID.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbLOCID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show("Location ID cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbLOCID.Focus();
				return false;
			}
			if (numQTY.Value == 0.0)
			{
				MessageBox.Show("Quantity cannot be 0!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numQTY.Select();
				return false;
			}
			if (Conversions.ToDouble(txtRECID.Text) == -1.0)
			{
				string strSQL = "SELECT * FROM PCRTN_TBL WITH (NOLOCK) ";
				strSQL = strSQL + "WHERE PCRTN_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
				strSQL = strSQL + "AND PCRTN_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				strSQL = strSQL + "AND PCRTN_REVNO = " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + " ";
				strSQL = strSQL + "AND PCRTN_BATCHNO = '" + Common.gfValidSQLStr(txtBATCHNO.Text) + "'";
				if (DB.RecordExists(strSQL))
				{
					MessageBox.Show("Duplicate data entered!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
			}
			return true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "CUSTOMER RETURN LIST";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPCRTN.rpt";
			if (Operators.CompareString(txtDOCNO.Text, "", false) != 0)
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1 ,@DOCNOFR=" + txtDOCNO.Text + ",@DOCNOTO=" + txtDOCNO.Text + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@CUSIDFR=", cbCUSID.SelectedValue), ",@CUSIDTO="), cbCUSID.SelectedValue), ",@STSFG=2"));
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1 ,@DOCNOFR=", cbDOCNOFR.SelectedValue), ",@DOCNOTO="), cbDOCNOTO.SelectedValue), ",@DOCDTFR="), Common.gfSQLDate(dtpDOCDTFR.Value)), ",@DOCDTTO="), Common.gfSQLDate(dtpDOCDTTO.Value)), ",@CUSIDFR="), cbCUSIDFR.SelectedValue), ",@CUSIDTO="), cbCUSIDTO.SelectedValue), ",@STSFG="), cboSTSFG.SelectedIndex), ""));
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='CUSTOMER RETURN LIST',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS;
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtDOCNO.Text.Trim(), string.Empty, false) != 0)
			{
				DisplayReport();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		//db2005
		private void dgvDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
            //[MACPT_ITMCD]
            btnReturnMaterial.Enabled = true;

            BindGridtoControl();
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("PCRTN_STSFG", "PCRTN_TBL", "PCRTN_DOCNO = '" + txtDOCNO.Text + "'"));
			if (Conversions.ToDouble(strSTSFG) == 1.0)
			{
				btnSave.Enabled = false;
				btnREMOVE.Enabled = false;
			}
			else
			{
				btnSave.Enabled = intAccessLevel >= 1;
				btnREMOVE.Enabled = intAccessLevel >= 3;
			}
			cbITMCD.Enabled = false;
			cbREVNO.Enabled = false;
			btnSave.Text = "Update";
		}

		private void numQTY_TextChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		private void numUPRICE_TextChanged(object sender, EventArgs e)
		{

			Calculate();
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM PCRTN_TBL ";
			strSQL = strSQL + "WHERE PCRTN_RECID = '" + txtRECID.Text + "' ";
			strSQL = strSQL + "AND PCRTN_DOCNO = '" + txtDOCNO.Text + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Please select a record!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Focus();
			}
			else if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				strSQL = "DELETE PCRTN_TBL WHERE PCRTN_DOCNO = '" + txtDOCNO.Text + "' AND PCRTN_RECID = '" + txtRECID.Text + "'";
				DataTable dt = DB.ExecProc(strSQL);
				RefreshGrid();
				ClearDetails();
			}
		}

		private void btnDELETEFR_Click(object sender, EventArgs e)
		{
			string strDOCNO = dgvHEADER.CurrentRow.Cells["PCRTN_DOCNO"].Value.ToString();
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("PCRTN_STSFG", "PCRTN_TBL", "PCRTN_DOCNO = '" + strDOCNO + "'"));
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + strDOCNO;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				if ((Operators.CompareString(strSTSFG, "1", false) == 0) & !PublicVar.gblnSupervisor)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record already confirm not allow to delete!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				string strSQL = "DELETE PCRTN_TBL WHERE PCRTN_DOCNO = '" + strDOCNO + "' ";
				strSQL = strSQL + "DELETE INTRN_TBL WHERE INTRN_DOCNO = '" + strDOCNO + "' ";
				DB.DBExecute(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				BindComboHeader();
				Header();
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM PCRTN_TBL ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE PCRTN_CUSID = '", cbCUSID.SelectedValue), "' ")));
			strSQL = strSQL + "AND PCRTN_DOCNO = '" + txtDOCNO.Text + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No. not exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbCUSID.Focus();
				return;
			}
			try
			{
				strSQL = "EXEC spPCERTN_CONFIRM '" + txtDOCNO.Text + "', '" + PublicVar.gstrLogonID + "'";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
				RefreshGrid();
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
			btnSave.Enabled = false;
			btnREMOVE.Enabled = false;
			btnDelete.Enabled = false;
			btnConfirm.Enabled = false;
		}

		private void frmPCERTN_Load(object sender, EventArgs e)
		{
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			cboSTSFG.SelectedIndex = 0;
			BindComboHeader();
			BindComboBox();
			Header();
			NumberFormat();
			CheckAccessLevel();
			btnNew.Enabled = intAccessLevel != 0;
			btnDELETEFR.Enabled = intAccessLevel >= 3;
		}

		private void CheckAccessLevel()
		{
			string strWhere = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("LPRGX_USRID = '" + PublicVar.gstrLogonID + "' AND LPRGX_PRGID = '", base.Tag), "'"));
			if (DB.RecordExists("SELECT * FROM LPRGX_TBL WHERE " + strWhere))
			{
				intAccessLevel = Conversions.ToInteger(DB.GetColumnValue("LPRGX_LEVEL", "LPRGX_TBL", strWhere));
			}
			else
			{
				intAccessLevel = 3;
			}
		}

		private void frmPCERTN_FormClosing(object sender, FormClosingEventArgs e)
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
			numWEIGHT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Weight);
			numSTRNG.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numUPRICE.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Price);
			numAMT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Amount);
		}

		private void frmPCERTN_KeyDown(object sender, KeyEventArgs e)
			{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbITMCD_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbITMCD.SelectedIndex != -1)  //db01
			{
				BindBOMRev();
				string strSQL = "SELECT SLORD_UPRICE ";
				strSQL += "FROM SLORD_TBL  ";
				strSQL = strSQL + "WHERE SLORD_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
				strSQL = strSQL + "AND SLORD_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				DataTable dt = DB.ExecProc(strSQL);
				if (dt.Rows.Count > 0)
				{
					double uprice = Convert.ToDouble(dt.Rows[0]["SLORD_UPRICE"]);
					numUPRICE.Value = (uprice * 70)/100.0;

				}
			}
        }

		private void BindBOMRev()
		{
			string strSQL = "SELECT DISTINCT MACPT_REVNO ";
			strSQL += "FROM MACPT_TBL WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE MACPT_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
			strSQL = strSQL + "AND MACPT_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
			strSQL += "ORDER BY MACPT_REVNO ";
			cbREVNO.ValueMember = "MACPT_REVNO";
			cbREVNO.DisplayMember = "MACPT_REVNO";
			Common.RetriveComboItembySQL(strSQL, cbREVNO);
		}

		private void cbCUSID_SelectedIndexChanged(object sender, EventArgs e) //db3
		{
			txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MACUS_CURCD", "MACUS_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CUSID = '", cbCUSID.SelectedValue), "'"))));
			string strWHERE = "MACPT_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' AND MAITM_ITMTY = '1' ";
			cbITMCD.DataTable = "MACPT_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL ON MAITM_ITMCD = MACPT_ITMCD";
			cbITMCD.WhereClause = strWHERE;
			cbITMCD.ValueMember = "MACPT_ITMCD";
			cbITMCD.DisplayMember = "MACPT_CPTNO";
			cbITMCD.LoadData();
		}

		private void cbPACKING_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbPACKING.SelectedIndex != -1)
			{
				string strWHERE = "MACOD_CTYID = 'PACKING' AND MACOD_CODID = '" + Common.gfValidSQLStr(Conversions.ToString(cbPACKING.SelectedValue)) + "'";
				numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MACOD_NFLD1", "MACOD_TBL", strWHERE));
			}
		}
	}
}
