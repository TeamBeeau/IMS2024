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
	public class frmPCEPCO : Form
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
		[AccessedThroughProperty("btnAdd")]
		private Button _btnAdd;

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
		[AccessedThroughProperty("btnOFFICIALPO")]
		private Button _btnOFFICIALPO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbSUPID")]
		private ComboboxControl _cbSUPID;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		private int intAccessLevel;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		internal virtual Button btnAdd
		{
			[CompilerGenerated]
			get
			{
				return _btnAdd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnAdd_Click;
				Button button = _btnAdd;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnAdd = value;
				button = _btnAdd;
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

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
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

		[field: AccessedThroughProperty("dtpETADT")]
		internal virtual DateTimePicker dtpETADT
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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
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

		internal virtual Button btnOFFICIALPO
		{
			[CompilerGenerated]
			get
			{
				return _btnOFFICIALPO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnOFFICIALPO_Click;
				Button button = _btnOFFICIALPO;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnOFFICIALPO = value;
				button = _btnOFFICIALPO;
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

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtMISCDESC")]
		internal virtual TextBox txtMISCDESC
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

		[field: AccessedThroughProperty("Label18")]
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtOSPO")]
		internal virtual TextBox txtOSPO
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

		[field: AccessedThroughProperty("cboSTSFG")]
		internal virtual ComboBox cboSTSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTSFG")]
		internal virtual Label lblSTSFG
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

		[field: AccessedThroughProperty("txtJOBNO")]
		internal virtual TextBox txtJOBNO
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

		[field: AccessedThroughProperty("cbPAYTM")]
		internal virtual ComboBox cbPAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbSUPID
		{
			[CompilerGenerated]
			get
			{
				return _cbSUPID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbSUPID_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbSUPID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbSUPID = value;
				comboboxControl = _cbSUPID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbITMCD")]
		internal virtual ComboboxControl cbITMCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbDELID")]
		internal virtual ComboBox cbDELID
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

		[field: AccessedThroughProperty("cbDOCNOFR")]
		internal virtual ComboboxControl cbDOCNOFR
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

		[field: AccessedThroughProperty("cbSUPIDFR")]
		internal virtual ComboboxControl cbSUPIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numTTLTPCHG")]
		internal virtual NumControl numTTLTPCHG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label21")]
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCPCO_DOCNO")]
		internal virtual DataGridViewTextBoxColumn PCPCO_DOCNO
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

		[field: AccessedThroughProperty("PCPCO_SUPID")]
		internal virtual DataGridViewTextBoxColumn PCPCO_SUPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCPCO_PAYTM")]
		internal virtual DataGridViewTextBoxColumn PCPCO_PAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCPCO_DELID")]
		internal virtual DataGridViewTextBoxColumn PCPCO_DELID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCPCO_REFNO")]
		internal virtual DataGridViewTextBoxColumn PCPCO_REFNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCPCO_TTLTPCHG")]
		internal virtual DataGridViewTextBoxColumn PCPCO_TTLTPCHG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCPCO_REMRK")]
		internal virtual DataGridViewTextBoxColumn PCPCO_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("STSFG")]
		internal virtual DataGridViewTextBoxColumn STSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCPCO_DOCDT")]
		internal virtual DataGridViewTextBoxColumn PCPCO_DOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblLOC_CUR")]
		internal virtual Label lblLOC_CUR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCEPCO()
		{
			base.FormClosing += frmPCEPCO_FormClosing;
			base.Load += frmPCEPCO_Load;
			base.KeyDown += frmPCEPCO_KeyDown;
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
			this.btnOFFICIALPO = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numTTLTPCHG = new IMS.NumControl();
			this.Label21 = new System.Windows.Forms.Label();
			this.cbDELID = new System.Windows.Forms.ComboBox();
			this.cbITMCD = new IMS.ComboboxControl();
			this.cbSUPID = new IMS.ComboboxControl();
			this.cbPAYTM = new System.Windows.Forms.ComboBox();
			this.txtREFNO = new System.Windows.Forms.TextBox();
			this.txtOSPO = new System.Windows.Forms.TextBox();
			this.txtMISCDESC = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtCURCD = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.Label9 = new System.Windows.Forms.Label();
			this.numUPRICE = new IMS.NumControl();
			this.numQTY = new IMS.NumControl();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.dtpETADT = new System.Windows.Forms.DateTimePicker();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.numAMT = new IMS.NumControl();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.lblLOC_CUR = new System.Windows.Forms.Label();
			this.lblSTSFG = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.PCPCO_DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCPCO_SUPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCPCO_PAYTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCPCO_DELID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCPCO_REFNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCPCO_TTLTPCHG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCPCO_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STSFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCPCO_DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDELETEFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbSUPIDTO = new IMS.ComboboxControl();
			this.cbSUPIDFR = new IMS.ComboboxControl();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.txtJOBNO = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.cboSTSFG = new System.Windows.Forms.ComboBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
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
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Controls.Add(this.lblSTSFG);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1349, 640);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnOFFICIALPO, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel6.TabIndex = 47;
			this.btnOFFICIALPO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnOFFICIALPO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnOFFICIALPO.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnOFFICIALPO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnOFFICIALPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOFFICIALPO.Image = IMS.My.Resources.Resources.Print;
			this.btnOFFICIALPO.Location = new System.Drawing.Point(381, 2);
			this.btnOFFICIALPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnOFFICIALPO.Name = "btnOFFICIALPO";
			this.btnOFFICIALPO.Size = new System.Drawing.Size(120, 50);
			this.btnOFFICIALPO.TabIndex = 20;
			this.btnOFFICIALPO.Text = "Official PO";
			this.btnOFFICIALPO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOFFICIALPO.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(3, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(129, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 18;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(255, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 19;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 5;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.numTTLTPCHG, 3, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label21, 2, 3);
			this.TableLayoutPanel1.Controls.Add(this.cbDELID, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCD, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.cbSUPID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbPAYTM, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtREFNO, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtOSPO, 3, 11);
			this.TableLayoutPanel1.Controls.Add(this.txtMISCDESC, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label15, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtCURCD, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.dgvDetails, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.numUPRICE, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.numQTY, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label14, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 2, 8);
			this.TableLayoutPanel1.Controls.Add(this.dtpETADT, 3, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label19, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label18, 2, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 10);
			this.TableLayoutPanel1.Controls.Add(this.numAMT, 3, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtRECID, 3, 9);
			this.TableLayoutPanel1.Controls.Add(this.lblLOC_CUR, 4, 3);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 14;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1285, 538);
			this.TableLayoutPanel1.TabIndex = 0;
			this.numTTLTPCHG.AllowNegative = false;
			this.numTTLTPCHG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTTLTPCHG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTTLTPCHG.DataChanged = false;
			this.numTTLTPCHG.Location = new System.Drawing.Point(788, 93);
			this.numTTLTPCHG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTTLTPCHG.Name = "numTTLTPCHG";
			this.numTTLTPCHG.NumberFormat = "8.2";
			this.numTTLTPCHG.Size = new System.Drawing.Size(152, 22);
			this.numTTLTPCHG.TabIndex = 51;
			this.numTTLTPCHG.Text = "0.00";
			this.numTTLTPCHG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTTLTPCHG.ThousandSeperator = false;
			this.numTTLTPCHG.Value = 0.0;
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(662, 96);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(120, 16);
			this.Label21.TabIndex = 50;
			this.Label21.Text = "Transport Charges";
			this.TableLayoutPanel1.SetColumnSpan(this.cbDELID, 2);
			this.cbDELID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDELID.FormattingEnabled = true;
			this.cbDELID.Location = new System.Drawing.Point(788, 63);
			this.cbDELID.Name = "cbDELID";
			this.cbDELID.Size = new System.Drawing.Size(282, 24);
			this.cbDELID.TabIndex = 6;
			this.cbITMCD.BlankValue = null;
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
            cbITMCD.SelectedValueChanged += CbITMCD_SelectedValueChanged;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = true;
			this.cbITMCD.Location = new System.Drawing.Point(106, 328);
			this.cbITMCD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(328, 28);
			this.cbITMCD.TabIndex = 9;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.cbSUPID.BlankValue = null;
			this.cbSUPID.ComboboxWidth = 170;
			this.cbSUPID.DataTable = null;
			this.cbSUPID.DisplayMember = null;
			this.cbSUPID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPID.HasBlankValue = true;
			this.cbSUPID.Location = new System.Drawing.Point(105, 30);
			this.cbSUPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbSUPID.Name = "cbSUPID";
			this.cbSUPID.SelectedIndex = -1;
			this.cbSUPID.SelectedItem = null;
			this.cbSUPID.SelectedValue = null;
			this.cbSUPID.Size = new System.Drawing.Size(328, 28);
			this.cbSUPID.TabIndex = 3;
			this.cbSUPID.TextMultiline = false;
			this.cbSUPID.ValueMember = null;
			this.cbSUPID.WhereClause = null;
			this.cbPAYTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPAYTM.FormattingEnabled = true;
			this.cbPAYTM.Location = new System.Drawing.Point(105, 63);
			this.cbPAYTM.Name = "cbPAYTM";
			this.cbPAYTM.Size = new System.Drawing.Size(150, 24);
			this.cbPAYTM.TabIndex = 5;
			this.txtREFNO.Location = new System.Drawing.Point(105, 93);
			this.txtREFNO.Name = "txtREFNO";
			this.txtREFNO.Size = new System.Drawing.Size(180, 22);
			this.txtREFNO.TabIndex = 7;
			this.txtOSPO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtOSPO.BackColor = System.Drawing.SystemColors.Control;
			this.txtOSPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TableLayoutPanel1.SetColumnSpan(this.txtOSPO, 2);
			this.txtOSPO.ForeColor = System.Drawing.Color.Tomato;
			this.txtOSPO.Location = new System.Drawing.Point(788, 420);
			this.txtOSPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOSPO.Multiline = true;
			this.txtOSPO.Name = "txtOSPO";
			this.txtOSPO.ReadOnly = true;
			this.txtOSPO.Size = new System.Drawing.Size(494, 39);
			this.txtOSPO.TabIndex = 48;
			this.txtOSPO.TabStop = false;
			this.txtMISCDESC.Location = new System.Drawing.Point(105, 412);
			this.txtMISCDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMISCDESC.Multiline = true;
			this.txtMISCDESC.Name = "txtMISCDESC";
			this.txtMISCDESC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMISCDESC.Size = new System.Drawing.Size(551, 56);
			this.txtMISCDESC.TabIndex = 13;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 432);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(76, 16);
			this.Label15.TabIndex = 49;
			this.Label15.Text = "Description";
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(662, 67);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(78, 16);
			this.Label12.TabIndex = 48;
			this.Label12.Text = "Delivery To";
			this.txtCURCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCURCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCURCD.Enabled = false;
			this.txtCURCD.Location = new System.Drawing.Point(788, 33);
			this.txtCURCD.Name = "txtCURCD";
			this.txtCURCD.Size = new System.Drawing.Size(87, 22);
			this.txtCURCD.TabIndex = 4;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnAdd, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 482);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel3.TabIndex = 14;
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
			this.btnREMOVE.TabIndex = 15;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Image = IMS.My.Resources.Resources.Save;
			this.btnAdd.Location = new System.Drawing.Point(3, 2);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 14;
			this.btnAdd.Text = "Add";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = false;
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
			this.btnCancel.TabIndex = 16;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDetails, 4);
			this.dgvDetails.Location = new System.Drawing.Point(3, 176);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(781, 137);
			this.dgvDetails.TabIndex = 10;
			this.dgvDetails.TabStop = false;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 132);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.numUPRICE.AllowNegative = false;
			this.numUPRICE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numUPRICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numUPRICE.DataChanged = false;
			this.numUPRICE.Location = new System.Drawing.Point(105, 386);
			this.numUPRICE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numUPRICE.Name = "numUPRICE";
			this.numUPRICE.NumberFormat = "8.2";
			this.numUPRICE.Size = new System.Drawing.Size(87, 22);
			this.numUPRICE.TabIndex = 12;
			this.numUPRICE.Text = "0.00";
			this.numUPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUPRICE.ThousandSeperator = false;
			this.numUPRICE.Value = 0.0;
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQTY.DataChanged = false;
			this.numQTY.Location = new System.Drawing.Point(105, 360);
			this.numQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.2";
			this.numQTY.Size = new System.Drawing.Size(87, 22);
			this.numQTY.TabIndex = 11;
			this.numQTY.Text = "0.00";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 6);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(662, 6);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(3, 389);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(65, 16);
			this.Label14.TabIndex = 9;
			this.Label14.Text = "Unit Price";
			this.txtREMRK.Location = new System.Drawing.Point(105, 121);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(551, 39);
			this.txtREMRK.TabIndex = 8;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 363);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(56, 16);
			this.Label13.TabIndex = 4;
			this.Label13.Text = "Quantity (pcs)";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 36);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(74, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Supplier ID";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 334);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(69, 16);
			this.Label8.TabIndex = 3;
			this.Label8.Text = "Item Code";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 67);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(96, 16);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Payment Term";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(788, 3);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.txtDOCNO.Location = new System.Drawing.Point(105, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(662, 334);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(67, 16);
			this.Label6.TabIndex = 5;
			this.Label6.Text = "ETA Date";
			this.dtpETADT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpETADT.CustomFormat = "dd/MM/yyyy";
			this.dtpETADT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpETADT.Location = new System.Drawing.Point(788, 331);
			this.dtpETADT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpETADT.Name = "dtpETADT";
			this.dtpETADT.Size = new System.Drawing.Size(104, 22);
			this.dtpETADT.TabIndex = 10;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(662, 36);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(61, 16);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "Currency";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 96);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(50, 16);
			this.Label11.TabIndex = 48;
			this.Label11.Text = "Ref No";
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(662, 432);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(84, 16);
			this.Label18.TabIndex = 48;
			this.Label18.Text = "Incoming PO";
			this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(662, 389);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(53, 16);
			this.Label7.TabIndex = 8;
			this.Label7.Text = "Amount";
			this.numAMT.AllowNegative = false;
			this.numAMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numAMT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numAMT.DataChanged = false;
			this.numAMT.Enabled = false;
			this.numAMT.Location = new System.Drawing.Point(788, 386);
			this.numAMT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numAMT.Name = "numAMT";
			this.numAMT.NumberFormat = "8.2";
			this.numAMT.Size = new System.Drawing.Size(87, 22);
			this.numAMT.TabIndex = 14;
			this.numAMT.TabStop = false;
			this.numAMT.Text = "0.00";
			this.numAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numAMT.ThousandSeperator = false;
			this.numAMT.Value = 0.0;
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(788, 360);
			this.txtRECID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(61, 22);
			this.txtRECID.TabIndex = 14;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRECID.Visible = false;
			this.lblLOC_CUR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLOC_CUR.AutoSize = true;
			this.lblLOC_CUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLOC_CUR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLOC_CUR.Location = new System.Drawing.Point(946, 96);
			this.lblLOC_CUR.Name = "lblLOC_CUR";
			this.lblLOC_CUR.Size = new System.Drawing.Size(111, 16);
			this.lblLOC_CUR.TabIndex = 52;
			this.lblLOC_CUR.Text = "Local Currency";
			this.lblSTSFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTSFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
			this.lblSTSFG.ForeColor = System.Drawing.Color.Brown;
			this.lblSTSFG.Location = new System.Drawing.Point(681, 28);
			this.lblSTSFG.Name = "lblSTSFG";
			this.lblSTSFG.Size = new System.Drawing.Size(208, 30);
			this.lblSTSFG.TabIndex = 50;
			this.lblSTSFG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1350, 641);
			this.Panel2.TabIndex = 2;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Columns.AddRange(this.PCPCO_DOCNO, this.DOCDT, this.PCPCO_SUPID, this.PCPCO_PAYTM, this.PCPCO_DELID, this.PCPCO_REFNO, this.PCPCO_TTLTPCHG, this.PCPCO_REMRK, this.STSFG, this.PCPCO_DOCDT);
			this.dgvHEADER.Location = new System.Drawing.Point(5, 228);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1271, 406);
			this.dgvHEADER.TabIndex = 0;
			this.dgvHEADER.TabStop = false;
			this.PCPCO_DOCNO.HeaderText = "Document No.";
			this.PCPCO_DOCNO.MinimumWidth = 6;
			this.PCPCO_DOCNO.Name = "PCPCO_DOCNO";
			this.PCPCO_DOCNO.ReadOnly = true;
			this.PCPCO_DOCNO.Width = 120;
			this.DOCDT.HeaderText = "Document Date";
			this.DOCDT.MinimumWidth = 6;
			this.DOCDT.Name = "DOCDT";
			this.DOCDT.ReadOnly = true;
			this.DOCDT.Width = 130;
			this.PCPCO_SUPID.HeaderText = "Supplier ID";
			this.PCPCO_SUPID.MinimumWidth = 6;
			this.PCPCO_SUPID.Name = "PCPCO_SUPID";
			this.PCPCO_SUPID.ReadOnly = true;
			this.PCPCO_SUPID.Width = 125;
			this.PCPCO_PAYTM.HeaderText = "Payment Term";
			this.PCPCO_PAYTM.MinimumWidth = 6;
			this.PCPCO_PAYTM.Name = "PCPCO_PAYTM";
			this.PCPCO_PAYTM.ReadOnly = true;
			this.PCPCO_PAYTM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.PCPCO_PAYTM.Width = 120;
			this.PCPCO_DELID.HeaderText = "PCPCO_DELID";
			this.PCPCO_DELID.MinimumWidth = 6;
			this.PCPCO_DELID.Name = "PCPCO_DELID";
			this.PCPCO_DELID.ReadOnly = true;
			this.PCPCO_DELID.Visible = false;
			this.PCPCO_DELID.Width = 125;
			this.PCPCO_REFNO.HeaderText = "PR/Ref. No.";
			this.PCPCO_REFNO.MinimumWidth = 6;
			this.PCPCO_REFNO.Name = "PCPCO_REFNO";
			this.PCPCO_REFNO.ReadOnly = true;
			this.PCPCO_REFNO.Width = 150;
			this.PCPCO_TTLTPCHG.HeaderText = "Transport Charges";
			this.PCPCO_TTLTPCHG.MinimumWidth = 6;
			this.PCPCO_TTLTPCHG.Name = "PCPCO_TTLTPCHG";
			this.PCPCO_TTLTPCHG.ReadOnly = true;
			this.PCPCO_TTLTPCHG.Visible = false;
			this.PCPCO_TTLTPCHG.Width = 125;
			this.PCPCO_REMRK.HeaderText = "Remark";
			this.PCPCO_REMRK.MinimumWidth = 6;
			this.PCPCO_REMRK.Name = "PCPCO_REMRK";
			this.PCPCO_REMRK.ReadOnly = true;
			this.PCPCO_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.PCPCO_REMRK.Width = 500;
			this.STSFG.HeaderText = "Status";
			this.STSFG.MinimumWidth = 6;
			this.STSFG.Name = "STSFG";
			this.STSFG.ReadOnly = true;
			this.STSFG.Width = 120;
			this.PCPCO_DOCDT.HeaderText = "PCPCO_DOCDT";
			this.PCPCO_DOCDT.MinimumWidth = 6;
			this.PCPCO_DOCDT.Name = "PCPCO_DOCDT";
			this.PCPCO_DOCDT.ReadOnly = true;
			this.PCPCO_DOCDT.Visible = false;
			this.PCPCO_DOCDT.Width = 125;
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
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 166);
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
			this.btnDELETEFR.TabIndex = 12;
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
			this.btnSEARCH.TabIndex = 10;
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
			this.btnClose.TabIndex = 14;
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
			this.btnNew.TabIndex = 11;
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
			this.btnPRINTFR.TabIndex = 13;
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
			this.TableLayoutPanel2.Controls.Add(this.cbSUPIDTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbSUPIDFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.txtJOBNO, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label20, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.cboSTSFG, 1, 4);
			this.TableLayoutPanel2.Controls.Add(this.Label22, 0, 4);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 5;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(816, 145);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbSUPIDTO.BlankValue = null;
			this.cbSUPIDTO.ComboboxWidth = 170;
			this.cbSUPIDTO.DataTable = null;
			this.cbSUPIDTO.DisplayMember = null;
			this.cbSUPIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDTO.HasBlankValue = true;
			this.cbSUPIDTO.Location = new System.Drawing.Point(484, 59);
			this.cbSUPIDTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbSUPIDTO.Name = "cbSUPIDTO";
			this.cbSUPIDTO.SelectedIndex = -1;
			this.cbSUPIDTO.SelectedItem = null;
			this.cbSUPIDTO.SelectedValue = null;
			this.cbSUPIDTO.Size = new System.Drawing.Size(327, 26);
			this.cbSUPIDTO.TabIndex = 55;
			this.cbSUPIDTO.TextMultiline = true;
			this.cbSUPIDTO.ValueMember = null;
			this.cbSUPIDTO.WhereClause = null;
			this.cbSUPIDFR.BlankValue = null;
			this.cbSUPIDFR.ComboboxWidth = 170;
			this.cbSUPIDFR.DataTable = null;
			this.cbSUPIDFR.DisplayMember = null;
			this.cbSUPIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDFR.HasBlankValue = true;
			this.cbSUPIDFR.Location = new System.Drawing.Point(119, 59);
			this.cbSUPIDFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbSUPIDFR.Name = "cbSUPIDFR";
			this.cbSUPIDFR.SelectedIndex = -1;
			this.cbSUPIDFR.SelectedItem = null;
			this.cbSUPIDFR.SelectedValue = null;
			this.cbSUPIDFR.Size = new System.Drawing.Size(326, 25);
			this.cbSUPIDFR.TabIndex = 54;
			this.cbSUPIDFR.TextMultiline = true;
			this.cbSUPIDFR.ValueMember = null;
			this.cbSUPIDFR.WhereClause = null;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(484, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(329, 25);
			this.cbDOCNOTO.TabIndex = 53;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(119, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(328, 25);
			this.cbDOCNOFR.TabIndex = 52;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.txtJOBNO.Location = new System.Drawing.Point(119, 90);
			this.txtJOBNO.Name = "txtJOBNO";
			this.txtJOBNO.Size = new System.Drawing.Size(180, 22);
			this.txtJOBNO.TabIndex = 7;
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(3, 93);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(110, 16);
			this.Label20.TabIndex = 10;
			this.Label20.Text = "Job No. (*similar)";
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[3] { "Outstanding PO Only", "Completed  PO Only", "All" });
			this.cboSTSFG.Location = new System.Drawing.Point(119, 118);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(156, 24);
			this.cboSTSFG.TabIndex = 9;
			this.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label22.Location = new System.Drawing.Point(3, 122);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(45, 16);
			this.Label22.TabIndex = 11;
			this.Label22.Text = "Status";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(453, 64);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(453, 6);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(25, 16);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 6);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(90, 16);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Document No";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(453, 35);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 16);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(119, 32);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 3;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 35);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 64);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(74, 16);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Supplier ID";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(484, 32);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 4;
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
			base.Name = "frmPCEPCO";
			base.Tag = "PCEPCO";
			this.Text = "Purchase Order";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
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

        private void CbITMCD_SelectedValueChanged(object sender, EventArgs e)
        {
			if (cbITMCD.SelectedValue == null) return;
			if(G.listPackingCost.FindIndex(a=>a.codePacking.Contains( cbITMCD.SelectedValue.ToString()))>-1)
            this.Label13.Text = "Quantity (Pcs)";
			else
                this.Label13.Text = "Quantity (Kg)";
        }

        private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			ClearControl();
			ClearDetails();
			BindComboBox();
			ManageOrderNo();
			RefreshGrid();
		}
		//Purchase Order
		private void BindComboBox()
		{
			cbSUPID.DataTable = "vwItemBySupplier  WITH (NOLOCK) ";
			cbSUPID.ValueMember = "MASUP_SUPID";
			cbSUPID.DisplayMember = "MASUP_SHORT";
			cbSUPID.LoadData();
			string strSQL = "SELECT DISTINCT MADEL_DELID, MADEL_DELNM ";
			strSQL += "FROM MADEL_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MADEL_CUSID = '' ";
			strSQL += "ORDER BY MADEL_DELID ";
			cbDELID.ValueMember = "MADEL_DELID";
			cbDELID.DisplayMember = "MADEL_DELID";
			Common.RetriveComboItembySQL(strSQL, cbDELID);
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'PAYTM' ORDER BY MACOD_CODID";
			cbPAYTM.ValueMember = "MACOD_CODID";
			cbPAYTM.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbPAYTM);
		}

		private void BindComboBoxDetails()
		{
			cbITMCD.DataTable = "vwItemBySupplier  WITH (NOLOCK) ";
			cbITMCD.WhereClause = "MASUP_SUPID = '" + Common.gfValidSQLStr(Conversions.ToString(cbSUPID.SelectedValue)) + "' ";
			cbITMCD.ValueMember = "MAITM_ITMCD";
			cbITMCD.DisplayMember = "MAITM_ITMCD";
			cbITMCD.LoadData();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) != 0)
			{
				string strSQL = "PCPCO_DOCNO = '" + txtDOCNO.Text + "'";
				string strENTBY = Conversions.ToString(DB.GetColumnValue("PCPCO_ENTBY", "PCPCO_TBL", strSQL));
				if (!Common.gfAllowEdit(strENTBY))
				{
					MessageBox.Show("This document is view only!\r\nOnly Supervisor user or document creator is allowed to amend.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (ValidateDetailControl() && spPCEPCO("0"))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefreshGrid();
				ClearDetails();
				btnDelete.Enabled = intAccessLevel >= 3;
				btnPRINT.Enabled = true;
				btnOFFICIALPO.Enabled = true;
				dtpDOCDT.Enabled = false;
				cbSUPID.Enabled = false;
				cbPAYTM.Enabled = false;
				txtREFNO.Enabled = false;
			}
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PCEPCO'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private void frmPCEPCO_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmPCEPCO_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			lblLOC_CUR.Text = Conversions.ToString(DB.GetColumnValue("LMSYS_CURCD", "LMSYS_TBL", ""));
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			BindComboHeader();
			cboSTSFG.SelectedIndex = 0;
			intAccessLevel = Common.GetAccessLevel(Conversions.ToString(base.Tag));
			Header();
			NumberFormat();
			btnNew.Enabled = intAccessLevel != 0;
			btnDELETEFR.Enabled = intAccessLevel >= 3;
			btnAdd.Enabled = intAccessLevel >= 1;
		}

		private bool spPCEPCO(string strPRO)
		{
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PCEPCO'"));
			bool spPCEPCO;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PCEPCO", "PCPCO", ref strNextNo))
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spPCEPCO = false;
						goto IL_0405;
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
					spPCEPCO = false;
					goto IL_0405;
				}
			}
			strSQL = "EXEC spPCEPCO ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(txtRECID.Text)) + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPID.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpETADT.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
			strSQL = strSQL + "'" + txtREFNO.Text + "', ";
			strSQL = strSQL + Conversions.ToString(numTTLTPCHG.Value) + ", ";
			strSQL = strSQL + "'" + txtMISCDESC.Text + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(numQTY.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPAYTM.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDELID.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Conversions.ToString(numUPRICE.Value) + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(numAMT.Value) + "', ";
			strSQL += "'', ";
			strSQL += "0, ";
			strSQL += "0, ";
			strSQL += "0, ";
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
				spPCEPCO = false;
				ProjectData.ClearProjectError();
				goto IL_0405;
			}
			spPCEPCO = true;
			goto IL_0405;
			IL_0405:
			return spPCEPCO;
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
				string strSQL = "EXEC spPCPCO '0', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDTO.SelectedValue), "', ")));
				strSQL = strSQL + "'" + txtJOBNO.Text + "', ";
				strSQL += Conversions.ToString(cboSTSFG.SelectedIndex) ?? "";
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvHEADER.ClearSelection();
						dgvHEADER.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvHEADER.Rows[dgvHEADER.Rows.Count - 1];
						dataGridViewRow.Cells["PCPCO_DOCNO"].Value = dt.Rows[i]["DOCNO"].ToString();
						dataGridViewRow.Cells["PCPCO_DOCDT"].Value = dt.Rows[i]["PCPCO_DOCDT"].ToString();
						dataGridViewRow.Cells["DOCDT"].Value = dt.Rows[i]["DOCDT"].ToString();
						dataGridViewRow.Cells["PCPCO_SUPID"].Value = dt.Rows[i]["PCPCO_SUPID"].ToString();
						dataGridViewRow.Cells["PCPCO_PAYTM"].Value = dt.Rows[i]["PCPCO_PAYTM"].ToString();
						dataGridViewRow.Cells["PCPCO_DELID"].Value = dt.Rows[i]["PCPCO_DELID"].ToString();
						dataGridViewRow.Cells["PCPCO_REFNO"].Value = dt.Rows[i]["PCPCO_REFNO"].ToString();
						dataGridViewRow.Cells["PCPCO_TTLTPCHG"].Value = dt.Rows[i]["PCPCO_TTLTPCHG"].ToString();
						dataGridViewRow.Cells["PCPCO_REMRK"].Value = dt.Rows[i]["PCPCO_REMRK"].ToString();
						dataGridViewRow.Cells["STSFG"].Value = dt.Rows[i]["STSFG"].ToString();
						dataGridViewRow = null;
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void CalculateAMT()
		{
			numAMT.Value = Common.gfRound(numQTY.Value * numUPRICE.Value, 2);
		}

		private void ClearDetails()
		{
			txtRECID.Text = Conversions.ToString(-1);
			cbITMCD.SelectedIndex = -1;
			cbITMCD.Enabled = true;
			txtMISCDESC.Text = string.Empty;
			numQTY.Value = 0.0;
			txtOSPO.Text = string.Empty;
			numUPRICE.Value = 0.0;
			numAMT.Value = 0.0;
			BindComboBoxDetails();
			btnAdd.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Add");
		}

		private void ClearControl()
		{
			dgvDetails.ClearSelection();
			txtDOCNO.Text = string.Empty;
			cbSUPID.SelectedIndex = -1;
			dtpDOCDT.Value = DateAndTime.Now.Date;
			txtCURCD.Text = string.Empty;
			cbPAYTM.SelectedIndex = -1;
			cbDELID.SelectedIndex = -1;
			numTTLTPCHG.Value = 0.0;
			txtREFNO.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			lblSTSFG.Text = string.Empty;
			btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
			btnOFFICIALPO.Enabled = false;
			btnREMOVE.Enabled = false;
			txtDOCNO.Enabled = true;
			dtpDOCDT.Enabled = true;
			cbSUPID.Enabled = true;
			cbPAYTM.Enabled = true;
			txtREFNO.Enabled = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearControl();
			BindComboHeader();
			Header();
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["PCPCO_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PCPCO_DOCDT"].Value);
			cbSUPID.SelectedValue = dgvHEADER.CurrentRow.Cells["PCPCO_SUPID"].Value.ToString();
			cbPAYTM.SelectedValue = dgvHEADER.CurrentRow.Cells["PCPCO_PAYTM"].Value.ToString();
			cbDELID.SelectedValue = dgvHEADER.CurrentRow.Cells["PCPCO_DELID"].Value.ToString();
			txtREFNO.Text = dgvHEADER.CurrentRow.Cells["PCPCO_REFNO"].Value.ToString();
			numTTLTPCHG.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["PCPCO_TTLTPCHG"].Value);
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["PCPCO_REMRK"].Value.ToString();
			lblSTSFG.Text = dgvHEADER.CurrentRow.Cells["STSFG"].Value.ToString();
			txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MASUP_CURCD", "MASUP_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASUP_SUPID = '", cbSUPID.SelectedValue), "'"))));
		}

		private void BindGridtoControl()
		{
			txtRECID.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["PCPCO_RECID"].Value);
			cbITMCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["PCPCO_ITMCD"].Value);
			dtpETADT.Value = Conversions.ToDate(dgvDetails.CurrentRow.Cells["PCPCO_ETADT"].Value);
			numQTY.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCPCO_QTY"].Value);
			txtOSPO.Text = "Total: " + OSPOQTY() + Strings.Space(5) + OSPONO();
			numUPRICE.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCPCO_UPRICE"].Value);
			numAMT.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCPCO_AMT"].Value);
			txtMISCDESC.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["PCPCO_MISCDESC"].Value);
		}

		private void RefreshGrid()
		{
			int count = dgvDetails.Rows.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				dgvDetails.Rows.Remove(dgvDetails.Rows[0]);
			}
			string strSQL = "SELECT PCPCO_RECID, PCPCO_ITMCD, MAITM_DESC, PCPCO_ETADT, CONVERT(NVARCHAR(20), PCPCO_ETADT, 103) AS ETADT, ";
			strSQL += "PCPCO_QTY, PCPCO_UPRICE, PCPCO_AMT, PCPCO_MISCDESC ";
			strSQL += "FROM PCPCO_TBL ";
			strSQL += "LEFT JOIN MAITM_TBL ";
			strSQL += "ON MAITM_ITMCD = PCPCO_ITMCD ";
			strSQL = strSQL + "WHERE PCPCO_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL += "ORDER BY PCPCO_RECID";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = false;
			dataGridView.Columns[0].Width = 100;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = "RECID";
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 100;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			dataGridView.Columns[2].Visible = true;
			dataGridView.Columns[2].Width = 250;
			dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
			dataGridView.Columns[3].Visible = false;
			dataGridView.Columns[3].Width = 100;
			dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[3].HeaderText = "PCPCO_ETADT";
			dataGridView.Columns[4].Visible = true;
			dataGridView.Columns[4].Width = 100;
			dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "ETA Date");
			dataGridView.Columns[5].Visible = true;
			dataGridView.Columns[5].Width = 100;
			dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
			dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[5].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
			dataGridView.Columns[6].Visible = true;
			dataGridView.Columns[6].Width = 100;
			dataGridView.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[6].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Unit Price");
			dataGridView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[6].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
			dataGridView.Columns[7].Visible = true;
			dataGridView.Columns[7].Width = 100;
			dataGridView.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[7].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount");
			dataGridView.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[7].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
			dataGridView.Columns[8].Visible = false;
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindHeadertoControl();
			RefreshGrid();
			ClearDetails();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = intAccessLevel >= 3;
			btnCancel.Enabled = true;
			btnPRINT.Enabled = true;
			btnOFFICIALPO.Enabled = true;
			txtDOCNO.Enabled = false;
			dtpDOCDT.Enabled = false;
			cbSUPID.Enabled = false;
			cbPAYTM.Enabled = false;
			txtREFNO.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + txtDOCNO.Text;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				spPCEPCO("1");
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ClearDetails();
				ClearControl();
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			if (cbSUPID.SelectedIndex == -1)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbSUPID.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(cbSUPID.SelectedValue, "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbSUPID.Focus();
				return false;
			}
			if (cbITMCD.SelectedIndex == -1)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(cbITMCD.SelectedValue, "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Focus();
				return false;
			}
			if (numQTY.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity cannot be 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numQTY.Focus();
				return false;
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
			frmRPT.ReportName = "PURCHASE ORDER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPCPCO.rpt";
			if (Operators.CompareString(txtDOCNO.Text, "", false) != 0)
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1,@DOCNOFR=" + txtDOCNO.Text + ",@DOCNOTO=" + txtDOCNO.Text + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@SUPIDFR=", cbSUPID.SelectedValue), ",@SUPIDTO="), cbSUPID.SelectedValue), ",@JOBNO="), txtJOBNO.Text), ",@COMFG=2"));
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1,@DOCNOFR=", cbDOCNOFR.SelectedValue), ",@DOCNOTO="), cbDOCNOTO.SelectedValue), ",@DOCDTFR="), Common.gfSQLDate(dtpDOCDTFR.Value)), ",@DOCDTTO="), Common.gfSQLDate(dtpDOCDTTO.Value)), ",@SUPIDFR="), cbSUPIDFR.SelectedValue), ",@SUPIDTO="), cbSUPIDTO.SelectedValue), ",@JOBNO="), txtJOBNO.Text), ",@COMFG="), cboSTSFG.SelectedIndex), ""));
			}
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='PURCHASE ORDER CHECK LIST',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgvDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
			cbITMCD.Enabled = false;
			btnREMOVE.Enabled = intAccessLevel >= 3;
			btnAdd.Text = "Update";
		}

		private void numQTY_TextChanged(object sender, EventArgs e)
		{
			CalculateAMT();
		}

		private void numUPRICE_TextChanged(object sender, EventArgs e)
		{
			CalculateAMT();
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			if (Conversion.Val(txtRECID.Text) == -1.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Please select a PO item."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("DELETE PCPCO_TBL WHERE PCPCO_SUPID = '", cbSUPID.SelectedValue), "' AND PCPCO_DOCNO = '"), txtDOCNO.Text), "' AND PCPCO_RECID = '"), txtRECID.Text), "'"));
				DataTable dt = DB.ExecProc(strSQL);
				RefreshGrid();
				ClearDetails();
			}
		}

		private void btnDELETEFR_Click(object sender, EventArgs e)
		{
			string strDOCNO = dgvHEADER.CurrentRow.Cells["PCPCO_DOCNO"].Value.ToString();
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + strDOCNO;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				string strSQL = "DELETE PCPCO_TBL WHERE PCPCO_DOCNO = '" + strDOCNO + "' ";
				DB.DBExecute(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Header();
			}
		}

		private void btnOFFICIALPO_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "PURCHASE ORDER";
			string strSUPTY = Conversions.ToString(DB.GetColumnValue("MASUP_SUPTY", "MASUP_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASUP_SUPID = '", cbSUPID.SelectedValue), "'"))));
			if (Operators.CompareString(strSUPTY, "LOCAL", false) == 0)
			{
				frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPCPCO1.rpt";
			}
			else
			{
				frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPCPCO2.rpt";
			}
			frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@DOCNOFR=" + txtDOCNO.Text + ",@DOCNOTO=" + txtDOCNO.Text + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@SUPIDFR=", cbSUPID.SelectedValue), ",@SUPIDTO="), cbSUPID.SelectedValue), ""));
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='PURCHASE ORDER',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void NumberFormat()
		{
			numQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numUPRICE.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Price);
			numAMT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Amount);
		}

		private void frmPCEPCO_KeyDown(object sender, KeyEventArgs e)
		{
			if (txtMISCDESC.Focused)
			{
				Common.gfControl_KeyDown(txtMISCDESC, e);
			}
			else
			{
				Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private double OSPOQTY()
		{
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("PCPCO_SUPID = '", cbSUPID.SelectedValue), "' "));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND PCPCO_ITMCD = '", cbITMCD.SelectedValue), "' ")));
			strSQL += "AND PCPCO_QTY - PCPCO_GRNQTY > 0 ";
			strSQL += "AND PCPCO_COMFG <> 1";
			return Conversions.ToDouble(DB.GetColumnValue("ISNULL(SUM(PCPCO_QTY - PCPCO_GRNQTY), 0)", "PCPCO_TBL", strSQL));
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "PCPCO_TBL WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "PCPCO_DOCNO";
			cbDOCNOFR.DisplayMember = "PCPCO_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "PCPCO_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "PCPCO_DOCNO";
			cbDOCNOTO.DisplayMember = "PCPCO_DOCNO";
			cbDOCNOTO.LoadData();
			cbSUPIDFR.DataTable = "PCPCO_TBL WITH (NOLOCK) LEFT JOIN MASUP_TBL WITH (NOLOCK) ON MASUP_SUPID = PCPCO_SUPID ";
			cbSUPIDFR.ValueMember = "PCPCO_SUPID";
			cbSUPIDFR.DisplayMember = "PCPCO_SUPID";
			cbSUPIDFR.LoadData();
			cbSUPIDTO.DataTable = "PCPCO_TBL WITH (NOLOCK) LEFT JOIN MASUP_TBL WITH (NOLOCK) ON MASUP_SUPID = PCPCO_SUPID ";
			cbSUPIDTO.ValueMember = "PCPCO_SUPID";
			cbSUPIDTO.DisplayMember = "PCPCO_SUPID";
			cbSUPIDTO.LoadData();
		}

		private string OSPONO()
		{
			string strOSPONO = string.Empty;
			string strSQL = "SELECT DISTINCT PCPCO_DOCNO ";
			strSQL += "FROM PCPCO_TBL ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE PCPCO_SUPID = '", cbSUPID.SelectedValue), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND PCPCO_ITMCD = '", cbITMCD.SelectedValue), "' ")));
			strSQL += "AND PCPCO_QTY - PCPCO_GRNQTY > 0 ";
			strSQL += "AND PCPCO_COMFG <> 1";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					strOSPONO = ((Operators.CompareString(strOSPONO, "", false) != 0) ? Conversions.ToString(Operators.ConcatenateObject(strOSPONO, Operators.ConcatenateObject(", ", dt.Rows[i]["PCPCO_DOCNO"]))) : Conversions.ToString(dt.Rows[i]["PCPCO_DOCNO"]));
				}
				return strOSPONO;
			}
		}

		private void cbSUPID_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbSUPID.SelectedIndex != -1)
			{
				int intLTIME = Conversions.ToInteger(DB.GetColumnValue("ISNULL(MASUP_LTIME,0)", "MASUP_TBL WITH(NOLOCK) ", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASUP_SUPID = '", cbSUPID.SelectedValue), "'"))));
				dtpETADT.Value = DateAndTime.DateAdd(DateInterval.Day, intLTIME, dtpDOCDT.Value);
				txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MASUP_CURCD", "MASUP_TBL WITH(NOLOCK) ", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASUP_SUPID = '", cbSUPID.SelectedValue), "'"))));
				BindComboBoxDetails();
				if(cbITMCD.SelectedValue!=null)
				numUPRICE.Value = Common.gfGetPCPRC(Conversions.ToString(cbSUPID.SelectedValue), Conversions.ToString(cbITMCD.SelectedValue), dtpDOCDT.Value);
				txtOSPO.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total") + " : " + OSPOQTY() + Strings.Space(5) + OSPONO();
			}
		}
	}
}
