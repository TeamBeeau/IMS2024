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

namespace IMS
{
	[DesignerGenerated]
	public class frmINEADJ : Form
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
		[AccessedThroughProperty("cbBATCHNO")]
		private ComboBox _cbBATCHNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCD")]
		private ComboboxControl _cbITMCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbLOCID")]
		private ComboBox _cbLOCID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbREVNO")]
		private ComboBox _cbREVNO;

		private OleDbCommand cmd;

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

		[field: AccessedThroughProperty("numQTY")]
		internal virtual NumControl numQTY
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

		[field: AccessedThroughProperty("txtRECID")]
		internal virtual TextBox txtRECID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpLOCIDFR")]
		internal virtual LookupControl lkpLOCIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpLOCIDTO")]
		internal virtual LookupControl lkpLOCIDTO
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

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoOUT")]
		internal virtual RadioButton rdoOUT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoIN")]
		internal virtual RadioButton rdoIN
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

		[field: AccessedThroughProperty("numSAFETY")]
		internal virtual NumControl numSAFETY
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

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numBALQTY")]
		internal virtual NumControl numBALQTY
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

		internal virtual ComboboxControl cbITMCD
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
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbITMCD_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbITMCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbITMCD = value;
				comboboxControl = _cbITMCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
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
				EventHandler value2 = cbREVNO_SelectedIndexChanged;
				ComboBox comboBox = _cbREVNO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbREVNO = value;
				comboBox = _cbREVNO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lblREVNO")]
		internal virtual Label lblREVNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("GroupBox2")]
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("INADJ_DOCNO")]
		internal virtual DataGridViewTextBoxColumn INADJ_DOCNO
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

		[field: AccessedThroughProperty("INADJ_LOCID")]
		internal virtual DataGridViewTextBoxColumn INADJ_LOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("INADJ_REMRK")]
		internal virtual DataGridViewTextBoxColumn INADJ_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("INADJ_DOCDT")]
		internal virtual DataGridViewTextBoxColumn INADJ_DOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmINEADJ()
		{
			base.FormClosing += frmINEADJ_FormClosing;
			base.Shown += frmINEADJ_Shown;
			base.KeyDown += frmINEADJ_KeyDown;
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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbREVNO = new System.Windows.Forms.ComboBox();
			this.lblREVNO = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.cbITMCD = new IMS.ComboboxControl();
			this.cbBATCHNO = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.numBALQTY = new IMS.NumControl();
			this.numSAFETY = new IMS.NumControl();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.numQTY = new IMS.NumControl();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.rdoIN = new System.Windows.Forms.RadioButton();
			this.rdoOUT = new System.Windows.Forms.RadioButton();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.INADJ_DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INADJ_LOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INADJ_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INADJ_DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDELETEFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Label17 = new System.Windows.Forms.Label();
			this.lkpLOCIDFR = new IMS.LookupControl();
			this.lkpLOCIDTO = new IMS.LookupControl();
			this.lkpDOCNOFR = new IMS.LookupControl();
			this.lkpDOCNOTO = new IMS.LookupControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			this.GroupBox2.SuspendLayout();
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
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 696);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 3;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 2, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 1, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 4);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel6.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel6.TabIndex = 47;
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
			this.btnDelete.TabIndex = 13;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
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
			this.btnPRINT.TabIndex = 15;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
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
			this.btnBack.TabIndex = 14;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 3;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Location = new System.Drawing.Point(747, 488);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 3;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(0, 0);
			this.TableLayoutPanel5.TabIndex = 3;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 5;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbREVNO, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.lblREVNO, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCD, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.cbBATCHNO, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.numBALQTY, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.numSAFETY, 4, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 3, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtRECID, 4, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.numQTY, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.dgvDetails, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.GroupBox2, 1, 9);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 11;
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(669, 623);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbREVNO.FormattingEnabled = true;
			this.cbREVNO.Location = new System.Drawing.Point(137, 399);
			this.cbREVNO.Name = "cbREVNO";
			this.cbREVNO.Size = new System.Drawing.Size(95, 28);
			this.cbREVNO.TabIndex = 77;
			this.lblREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREVNO.AutoSize = true;
			this.lblREVNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREVNO.Location = new System.Drawing.Point(3, 403);
			this.lblREVNO.Name = "lblREVNO";
			this.lblREVNO.Size = new System.Drawing.Size(64, 20);
			this.lblREVNO.TabIndex = 76;
			this.lblREVNO.Text = "Rev No";
			this.TableLayoutPanel1.SetColumnSpan(this.cbLOCID, 2);
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(137, 35);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(226, 28);
			this.cbLOCID.TabIndex = 75;
			this.cbITMCD.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbITMCD, 4);
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = false;
			this.cbITMCD.Location = new System.Drawing.Point(137, 363);
			this.cbITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(452, 31);
			this.cbITMCD.TabIndex = 74;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbBATCHNO, 2);
			this.cbBATCHNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBATCHNO.FormattingEnabled = true;
			this.cbBATCHNO.Location = new System.Drawing.Point(137, 433);
			this.cbBATCHNO.Name = "cbBATCHNO";
			this.cbBATCHNO.Size = new System.Drawing.Size(226, 28);
			this.cbBATCHNO.TabIndex = 73;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 437);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(59, 20);
			this.Label11.TabIndex = 53;
			this.Label11.Text = "Lot No";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 470);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(105, 20);
			this.Label10.TabIndex = 52;
			this.Label10.Text = "Balance Qty.";
			this.numBALQTY.AllowNegative = false;
			this.numBALQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numBALQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TableLayoutPanel1.SetColumnSpan(this.numBALQTY, 2);
			this.numBALQTY.DataChanged = false;
			this.numBALQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numBALQTY.ForeColor = System.Drawing.SystemColors.WindowText;
			this.numBALQTY.Location = new System.Drawing.Point(137, 467);
			this.numBALQTY.Name = "numBALQTY";
			this.numBALQTY.NumberFormat = "8.3";
			this.numBALQTY.ReadOnly = true;
			this.numBALQTY.Size = new System.Drawing.Size(87, 26);
			this.numBALQTY.TabIndex = 51;
			this.numBALQTY.TabStop = false;
			this.numBALQTY.Text = "0.000";
			this.numBALQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numBALQTY.ThousandSeperator = false;
			this.numBALQTY.Value = 0.0;
			this.numSAFETY.AllowNegative = false;
			this.numSAFETY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSAFETY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSAFETY.DataChanged = false;
			this.numSAFETY.Location = new System.Drawing.Point(517, 467);
			this.numSAFETY.Name = "numSAFETY";
			this.numSAFETY.NumberFormat = "8.3";
			this.numSAFETY.ReadOnly = true;
			this.numSAFETY.Size = new System.Drawing.Size(87, 26);
			this.numSAFETY.TabIndex = 50;
			this.numSAFETY.TabStop = false;
			this.numSAFETY.Text = "0.000";
			this.numSAFETY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSAFETY.ThousandSeperator = false;
			this.numSAFETY.Value = 0.0;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(384, 470);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(112, 20);
			this.Label7.TabIndex = 49;
			this.Label7.Text = "Minimum Qty.";
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(517, 533);
			this.txtRECID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(87, 26);
			this.txtRECID.TabIndex = 46;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRECID.Visible = false;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 6);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(112, 20);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 5);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(4, 709);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel3.TabIndex = 1;
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
			this.btnREMOVE.TabIndex = 11;
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
			this.btnSave.TabIndex = 10;
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
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(384, 6);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(127, 20);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TableLayoutPanel1.SetColumnSpan(this.numQTY, 2);
			this.numQTY.DataChanged = false;
			this.numQTY.Location = new System.Drawing.Point(137, 499);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.3";
			this.numQTY.Size = new System.Drawing.Size(87, 26);
			this.numQTY.TabIndex = 7;
			this.numQTY.Text = "0.000";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 536);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(45, 20);
			this.Label6.TabIndex = 48;
			this.Label6.Text = "Type";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 39);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(95, 20);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Location ID";
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDetails, 5);
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Location = new System.Drawing.Point(3, 127);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(663, 231);
			this.dgvDetails.TabIndex = 5;
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(517, 3);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 26);
			this.dtpDOCDT.TabIndex = 2;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 502);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(128, 20);
			this.Label13.TabIndex = 4;
			this.Label13.Text = "Adjustment Qty.";
			this.TableLayoutPanel1.SetColumnSpan(this.txtDOCNO, 2);
			this.txtDOCNO.Location = new System.Drawing.Point(137, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 26);
			this.txtDOCNO.TabIndex = 1;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 85);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(76, 20);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 4);
			this.txtREMRK.Location = new System.Drawing.Point(137, 69);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(529, 52);
			this.txtREMRK.TabIndex = 4;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 368);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(85, 20);
			this.Label8.TabIndex = 3;
			this.Label8.Text = "Item Code";
			this.TableLayoutPanel1.SetColumnSpan(this.GroupBox2, 2);
			this.GroupBox2.Controls.Add(this.rdoIN);
			this.GroupBox2.Controls.Add(this.rdoOUT);
			this.GroupBox2.Location = new System.Drawing.Point(137, 531);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(241, 31);
			this.GroupBox2.TabIndex = 80;
			this.GroupBox2.TabStop = false;
			this.rdoIN.AutoSize = true;
			this.rdoIN.Checked = true;
			this.rdoIN.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rdoIN.Location = new System.Drawing.Point(5, 8);
			this.rdoIN.Name = "rdoIN";
			this.rdoIN.Size = new System.Drawing.Size(95, 24);
			this.rdoIN.TabIndex = 8;
			this.rdoIN.TabStop = true;
			this.rdoIN.Text = "Adjust In";
			this.rdoIN.UseVisualStyleBackColor = true;
			this.rdoOUT.AutoSize = true;
			this.rdoOUT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rdoOUT.Location = new System.Drawing.Point(120, 8);
			this.rdoOUT.Name = "rdoOUT";
			this.rdoOUT.Size = new System.Drawing.Size(109, 24);
			this.rdoOUT.TabIndex = 9;
			this.rdoOUT.TabStop = true;
			this.rdoOUT.Text = "Adjust Out";
			this.rdoOUT.UseVisualStyleBackColor = true;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 696);
			this.Panel2.TabIndex = 2;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Columns.AddRange(this.INADJ_DOCNO, this.DOCDT, this.INADJ_LOCID, this.INADJ_REMRK, this.INADJ_DOCDT);
			this.dgvHEADER.Location = new System.Drawing.Point(5, 177);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(897, 510);
			this.dgvHEADER.TabIndex = 0;
			this.INADJ_DOCNO.HeaderText = "Doc No";
			this.INADJ_DOCNO.MinimumWidth = 6;
			this.INADJ_DOCNO.Name = "INADJ_DOCNO";
			this.INADJ_DOCNO.ReadOnly = true;
			this.INADJ_DOCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INADJ_DOCNO.Width = 150;
			this.DOCDT.HeaderText = "Doc Date";
			this.DOCDT.MinimumWidth = 6;
			this.DOCDT.Name = "DOCDT";
			this.DOCDT.ReadOnly = true;
			this.DOCDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DOCDT.Width = 130;
			this.INADJ_LOCID.HeaderText = "Location";
			this.INADJ_LOCID.MinimumWidth = 6;
			this.INADJ_LOCID.Name = "INADJ_LOCID";
			this.INADJ_LOCID.ReadOnly = true;
			this.INADJ_LOCID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INADJ_LOCID.Width = 150;
			this.INADJ_REMRK.HeaderText = "Remark";
			this.INADJ_REMRK.MinimumWidth = 6;
			this.INADJ_REMRK.Name = "INADJ_REMRK";
			this.INADJ_REMRK.ReadOnly = true;
			this.INADJ_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INADJ_REMRK.Width = 300;
			this.INADJ_DOCDT.HeaderText = "INADJ_DOCDT";
			this.INADJ_DOCDT.MinimumWidth = 6;
			this.INADJ_DOCDT.Name = "INADJ_DOCDT";
			this.INADJ_DOCDT.ReadOnly = true;
			this.INADJ_DOCDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INADJ_DOCDT.Visible = false;
			this.INADJ_DOCDT.Width = 125;
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
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 113);
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
			this.btnDELETEFR.TabIndex = 9;
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
			this.btnSEARCH.TabIndex = 7;
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
			this.btnClose.TabIndex = 11;
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
			this.btnNew.TabIndex = 8;
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
			this.btnPRINTFR.TabIndex = 10;
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
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpLOCIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpLOCIDTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lkpDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(611, 94);
			this.TableLayoutPanel2.TabIndex = 1;
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 38);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(95, 20);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Location ID";
			this.lkpLOCIDFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDFR.AllowBlank = false;
			this.lkpLOCIDFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpLOCIDFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpLOCIDFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpLOCIDFR.DescriptionVisible1 = false;
			this.lkpLOCIDFR.DescriptionVisible2 = false;
			this.lkpLOCIDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDFR.KeyValue = "";
			this.lkpLOCIDFR.LKPCD = "INADJ_LOCID";
			this.lkpLOCIDFR.Location = new System.Drawing.Point(138, 37);
			this.lkpLOCIDFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpLOCIDFR.MaxLength = 0;
			this.lkpLOCIDFR.Modified = false;
			this.lkpLOCIDFR.Multiline_ = false;
			this.lkpLOCIDFR.Name = "lkpLOCIDFR";
			this.lkpLOCIDFR.PasswordChar = "\0";
			this.lkpLOCIDFR.ReadOnly_ = false;
			this.lkpLOCIDFR.Size = new System.Drawing.Size(212, 22);
			this.lkpLOCIDFR.TabIndex = 3;
			this.lkpLOCIDFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpLOCIDFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpLOCIDFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpLOCIDFR.TextHeight = 22;
			this.lkpLOCIDFR.TextWidth = 180;
			this.lkpLOCIDFR.Where1 = "MALOC_ACTFG = -1";
			this.lkpLOCIDTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDTO.AllowBlank = false;
			this.lkpLOCIDTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpLOCIDTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpLOCIDTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpLOCIDTO.DescriptionVisible1 = false;
			this.lkpLOCIDTO.DescriptionVisible2 = false;
			this.lkpLOCIDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDTO.KeyValue = "";
			this.lkpLOCIDTO.LKPCD = "INADJ_LOCID";
			this.lkpLOCIDTO.Location = new System.Drawing.Point(394, 37);
			this.lkpLOCIDTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpLOCIDTO.MaxLength = 0;
			this.lkpLOCIDTO.Modified = false;
			this.lkpLOCIDTO.Multiline_ = false;
			this.lkpLOCIDTO.Name = "lkpLOCIDTO";
			this.lkpLOCIDTO.PasswordChar = "\0";
			this.lkpLOCIDTO.ReadOnly_ = false;
			this.lkpLOCIDTO.Size = new System.Drawing.Size(212, 22);
			this.lkpLOCIDTO.TabIndex = 4;
			this.lkpLOCIDTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpLOCIDTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpLOCIDTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpLOCIDTO.TextHeight = 22;
			this.lkpLOCIDTO.TextWidth = 180;
			this.lkpLOCIDTO.Where1 = "MALOC_ACTFG = -1";
			this.lkpDOCNOFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOFR.AllowBlank = false;
			this.lkpDOCNOFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpDOCNOFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpDOCNOFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpDOCNOFR.DescriptionVisible1 = false;
			this.lkpDOCNOFR.DescriptionVisible2 = false;
			this.lkpDOCNOFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOFR.KeyValue = "";
			this.lkpDOCNOFR.LKPCD = "INADJ_DOCNO";
			this.lkpDOCNOFR.Location = new System.Drawing.Point(138, 5);
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
			this.lkpDOCNOTO.LKPCD = "INADJ_DOCNO";
			this.lkpDOCNOTO.Location = new System.Drawing.Point(394, 5);
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
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 69);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(127, 20);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(358, 69);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(28, 20);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(392, 66);
			this.dtpDOCDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 26);
			this.dtpDOCDTTO.TabIndex = 6;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(136, 66);
			this.dtpDOCDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 26);
			this.dtpDOCDTFR.TabIndex = 5;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(358, 6);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(28, 20);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 6);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(112, 20);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Document No";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(358, 38);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(28, 20);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 697);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmINEADJ";
			base.Tag = "INEADJ";
			this.Text = "Stock Adjustment";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
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
			ClearDetails();
			ManageOrderNo();
			RefreshGrid();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (ValidateDetailControl() && spINEADJ("0"))
			{
				RefreshGrid();
				BindComboBox("LOTNO");
				ClearDetails();
				btnDelete.Enabled = true;
				btnPRINT.Enabled = true;
				cbLOCID.Enabled = false;
				dtpDOCDT.Enabled = false;
				txtREMRK.Enabled = false;
			}
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'INEADJ'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private void frmINEADJ_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmINEADJ_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			Header();
			NumberFormat();
			BindComboBox("LOCID");
		}

		private void BindComboBox(string strOption)
		{
			if (Operators.CompareString(strOption, "LOCID", false) == 0)
			{
				string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
				strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
				strSQL += "ORDER BY MALOC_LOCID ";
				cbLOCID.ValueMember = "MALOC_LOCID";
				cbLOCID.DisplayMember = "MALOC_LOCNM";
				Common.RetriveComboItembySQL(strSQL, cbLOCID);
			}
			if (Operators.CompareString(strOption, "ITMCD", false) == 0)
			{
				if (cbLOCID.SelectedIndex == -1)
				{
					return;
				}
				cbITMCD.DataTable = "INBAL_TBL WITH (NOLOCK) ";
				cbITMCD.WhereClause = "INBAL_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "' ";
				cbITMCD.ValueMember = "INBAL_ITMCD";
				cbITMCD.DisplayMember = "INBAL_ITMCD";
				cbITMCD.LoadData();
			}
			if (Operators.CompareString(strOption, "REVNO", false) == 0)
			{
				string strSQL = "SELECT DISTINCT MABOM_REVNO ";
				strSQL += "FROM MABOM_TBL WITH(NOLOCK) ";
				strSQL = strSQL + "WHERE MABOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				strSQL += "AND MABOM_ACTFG = 1 ";
				strSQL += "ORDER BY MABOM_REVNO ";
				cbREVNO.ValueMember = "MABOM_REVNO";
				cbREVNO.DisplayMember = "MABOM_REVNO";
				Common.RetriveComboItembySQL(strSQL, cbREVNO);
			}
			if (Operators.CompareString(strOption, "LOTNO", false) == 0)
			{
				string strSQL = "SELECT INTRN_GRLNO FROM vwItemBalanceByGRLNO ";
				strSQL = strSQL + "WHERE INTRN_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "' ";
				strSQL = strSQL + "AND INTRN_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				strSQL = ((cbREVNO.SelectedIndex != -1) ? Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND INTRN_REVNO = ", cbREVNO.SelectedValue), " "))) : (strSQL + "AND INTRN_REVNO = 0 "));
				strSQL += "AND INTRN_BALQT <> 0";
				cbBATCHNO.ValueMember = "INTRN_GRLNO";
				cbBATCHNO.DisplayMember = "INTRN_GRLNO";
				Common.RetriveComboItembySQL(strSQL, cbBATCHNO);
			}
		}

		private bool spINEADJ(string strPRO)
		{
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'INEADJ'"));
			bool spINEADJ = default(bool);
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("INEADJ", "INADJ", ref strNextNo))
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spINEADJ = false;
						goto IL_03d0;
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
					spINEADJ = false;
					goto IL_03d0;
				}
			}
			int IOFLG = (rdoIN.Checked ? 1 : (rdoOUT.Checked ? 3 : 0));
			if (DB.RecordExists("SELECT INADJ_ENTBY FROM INADJ_TBL WHERE INADJ_DOCNO = '" + txtDOCNO.Text + "'"))
			{
				string strENTBY = Conversions.ToString(DB.GetColumnValue("INADJ_ENTBY", "INADJ_TBL", "INADJ_DOCNO = '" + txtDOCNO.Text + "'"));
				if (!Common.gfAllowEdit(strENTBY))
				{
					MessageBox.Show("This document is view only!\r\nOnly Supervisor user or document creator is allowed to amend.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					goto IL_03d0;
				}
			}
			strSQL = "EXEC spINEADJ ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(txtRECID.Text)) + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(numQTY.Value) + ", ";
			strSQL = strSQL + "'" + Conversions.ToString(IOFLG) + "', ";
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
				spINEADJ = false;
				ProjectData.ClearProjectError();
				goto IL_03d0;
			}
			spINEADJ = true;
			goto IL_03d0;
			IL_03d0:
			return spINEADJ;
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
				string strSQL = "EXEC spINADJ '0', ";
				strSQL = strSQL + "'" + lkpDOCNOFR.LowValue + "', ";
				strSQL = strSQL + "'" + lkpDOCNOTO.HighValue + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
				strSQL = strSQL + "'" + lkpLOCIDFR.LowValue + "', ";
				strSQL = strSQL + "'" + lkpLOCIDTO.HighValue + "'";
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvHEADER.ClearSelection();
						dgvHEADER.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvHEADER.Rows[dgvHEADER.Rows.Count - 1];
						dataGridViewRow.Cells["INADJ_DOCNO"].Value = dt.Rows[i]["INADJ_DOCNO"].ToString();
						dataGridViewRow.Cells["INADJ_DOCDT"].Value = dt.Rows[i]["INADJ_DOCDT"].ToString();
						dataGridViewRow.Cells["DOCDT"].Value = dt.Rows[i]["DOCDT"].ToString();
						dataGridViewRow.Cells["INADJ_LOCID"].Value = dt.Rows[i]["INADJ_LOCID"].ToString();
						dataGridViewRow.Cells["INADJ_REMRK"].Value = dt.Rows[i]["INADJ_REMRK"].ToString();
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

		private void ClearDetails()
		{
			txtRECID.Text = Conversions.ToString(-1);
			cbITMCD.Enabled = true;
			cbBATCHNO.Enabled = true;
			numBALQTY.Value = 0.0;
			numSAFETY.Value = 0.0;
			numBALQTY.ForeColor = SystemColors.WindowText;
			numSAFETY.ForeColor = SystemColors.WindowText;
			numQTY.Value = 0.0;
			rdoIN.Checked = true;
			btnSave.Tag = "Add";
		}

		private void ClearControl()
		{
			dgvDetails.ClearSelection();
			txtDOCNO.Text = string.Empty;
			dtpDOCDT.Value = DateTime.Now;
			dtpDOCDT.Enabled = true;
			txtREMRK.Text = string.Empty;
			btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
			txtDOCNO.Enabled = true;
			cbLOCID.Enabled = true;
			cbLOCID.SelectedIndex = -1;
			btnREMOVE.Enabled = false;
			txtREMRK.Enabled = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearControl();
			Header();
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["INADJ_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["INADJ_DOCDT"].Value);
			cbLOCID.SelectedValue = dgvHEADER.CurrentRow.Cells["INADJ_LOCID"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["INADJ_REMRK"].Value.ToString();
		}

		private void BindGridtoControl()
		{
			txtRECID.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["INADJ_RECID"].Value);
			cbITMCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["INADJ_ITMCD"].Value);
			cbREVNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["INADJ_REVNO"].Value);
			cbBATCHNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["INADJ_BATCHNO"].Value);
			numQTY.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["INADJ_QTY"].Value);
			object value = dgvDetails.CurrentRow.Cells["INADJ_IOFLG"].Value;
			if (Operators.ConditionalCompareObjectEqual(value, 1, false))
			{
				rdoIN.Checked = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(value, 3, false))
			{
				rdoOUT.Checked = true;
			}
			else
			{
				rdoIN.Checked = true;
			}
		}

		private void RefreshGrid()
		{
			int i = 0;
			dgvDetails.DataSource = null;
			string strSQL = "SELECT INADJ_RECID, INADJ_ITMCD, INADJ_REVNO, INADJ_BATCHNO, INADJ_QTY, INADJ_IOFLG, ";
			strSQL += "CASE WHEN INADJ_IOFLG = 1 THEN 'IN' WHEN INADJ_IOFLG = 3 THEN 'OUT' ELSE '' END AS IOFLG ";
			strSQL += "FROM INADJ_TBL ";
			strSQL = strSQL + "WHERE INADJ_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL += "ORDER BY INADJ_RECID";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = false;
			dataGridView.Columns[i].Width = 30;
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].HeaderText = "RECID";
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Rev No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 30;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "IOFLG";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 50;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "I/O";
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.ClearSelection();
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindHeadertoControl();
			RefreshGrid();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = true;
			btnCancel.Enabled = true;
			btnPRINT.Enabled = true;
			txtDOCNO.Enabled = false;
			cbLOCID.Enabled = false;
			dtpDOCDT.Enabled = false;
			txtREMRK.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spINEADJ("1");
				ClearDetails();
				ClearControl();
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbLOCID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbLOCID.Select();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbITMCD.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Select();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbBATCHNO.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbBATCHNO.Select();
				return false;
			}
			if (numQTY.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity cannot be 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numQTY.Select();
				return false;
			}
			checked
			{
				if (Operators.CompareString(btnSave.Text, "Add", false) == 0)
				{
					int num = dgvDetails.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(cbITMCD.SelectedValue, dgvDetails.Rows[i].Cells["INADJ_ITMCD"].Value.ToString(), false), Operators.CompareObjectEqual(cbBATCHNO.SelectedValue, dgvDetails.Rows[i].Cells["INADJ_BATCHNO"].Value.ToString(), false))))
						{
							MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Duplicate line!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							cbITMCD.Select();
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

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "STOCK ADJUSTMENT";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptINADJ.rpt";
			string strParams;
			if (Operators.CompareString(txtDOCNO.Text, "", false) != 0)
			{
				strParams = "@PAR=1 ,";
				strParams = strParams + "@DOCNOFR=" + txtDOCNO.Text + ",";
				strParams = strParams + "@DOCNOTO=" + txtDOCNO.Text + ",";
				strParams = strParams + "@DOCDTFR=" + Common.gfSQLDate(dtpDOCDT.Value) + ",";
				strParams = strParams + "@DOCDTTO=" + Common.gfSQLDate(dtpDOCDT.Value) + ",";
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@LOCIDFR=", cbLOCID.SelectedValue), ",")));
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@LOCIDTO=", cbLOCID.SelectedValue), "")));
			}
			else
			{
				strParams = "@PAR=1 ,";
				strParams = strParams + "@DOCNOFR=" + lkpDOCNOFR.LowValue + ",";
				strParams = strParams + "@DOCNOTO=" + lkpDOCNOTO.HighValue + ",";
				strParams = strParams + "@DOCDTFR=" + Common.gfSQLDate(dtpDOCDTFR.Value) + ",";
				strParams = strParams + "@DOCDTTO=" + Common.gfSQLDate(dtpDOCDTTO.Value) + ",";
				strParams = strParams + "@LOCIDFR=" + lkpLOCIDFR.LowValue + ",";
				strParams = string.Concat(strParams, "@LOCIDTO=" + lkpLOCIDTO.HighValue);
			}
			frmRPT.Params = strParams;
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='STOCK ADJUSTMENT',gintQTYDS='" + PublicVar.gintQTYDS + "',gintAMTDS='" + PublicVar.gintAMTDS + "',gintPRCDS='" + PublicVar.gintPRCDS + "'";
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
			cbBATCHNO.Enabled = false;
			btnREMOVE.Enabled = true;
			btnSave.Tag = "Update";
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			string strSQL = "DELETE INADJ_TBL WHERE INADJ_DOCNO = '" + txtDOCNO.Text + "' AND INADJ_RECID = '" + txtRECID.Text + "' ";
			strSQL = strSQL + "DELETE INTRN_TBL WHERE INTRN_DOCCD = 'ADJ' AND INTRN_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND INTRN_LOCID = '", cbLOCID.SelectedValue), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND INTRN_ITMCD = '", cbITMCD.SelectedValue), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND INTRN_GRLNO = '", cbBATCHNO.SelectedValue), "' ")));
			DB.ExecProc(strSQL);
			RefreshGrid();
			ClearDetails();
		}

		private void btnDELETEFR_Click(object sender, EventArgs e)
		{
			string strDOCNO = dgvHEADER.CurrentRow.Cells["INADJ_DOCNO"].Value.ToString();
			string strLOCID = dgvHEADER.CurrentRow.Cells["INADJ_LOCID"].Value.ToString();
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + strDOCNO;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				string strSQL = "DELETE INADJ_TBL WHERE INADJ_DOCNO = '" + strDOCNO + "' ";
				strSQL = strSQL + "DELETE INTRN_TBL WHERE INTRN_DOCCD = 'ADJ' AND INTRN_DOCNO = '" + strDOCNO + "' AND INTRN_LOCID = '" + strLOCID + "' ";
				DB.DBExecute(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Header();
			}
		}

		private void NumberFormat()
		{
			numQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numBALQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numSAFETY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
		}

		private void frmINEADJ_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void RefreshInfo()
		{
			string strWHERE = "INTRN_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "' ";
			strWHERE = strWHERE + "AND INTRN_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
			strWHERE = strWHERE + "AND INTRN_GRLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "'";
			numBALQTY.Value = Conversions.ToDouble(DB.GetColumnValue("INTRN_BALQT", "vwItemBalanceByGRLNO", strWHERE));
			numSAFETY.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_SAFETY", "MAITM_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbITMCD.SelectedValue), "'"))));
			numBALQTY.BackColor = SystemColors.ButtonHighlight;
			numSAFETY.BackColor = SystemColors.ButtonHighlight;
			if (numBALQTY.Value > numSAFETY.Value)
			{
				numBALQTY.ForeColor = Color.ForestGreen;
				numSAFETY.ForeColor = Color.ForestGreen;
			}
			else
			{
				numBALQTY.ForeColor = Color.Firebrick;
				numSAFETY.ForeColor = Color.Firebrick;
			}
		}

		private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindComboBox("ITMCD");
		}

		private void cbITMCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strITMTY = Conversions.ToString(DB.GetColumnValue("MAITM_ITMTY", "MAITM_TBL", "MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "'"));
			if (Operators.CompareString(strITMTY, "1", false) == 0)
			{
				BindComboBox("REVNO");
				if (cbREVNO.SelectedIndex == -1)
				{
					BindComboBox("LOTNO");
				}
			}
			else
			{
				BindComboBox("REVNO");
				BindComboBox("LOTNO");
			}
		}

		private void cbREVNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindComboBox("LOTNO");
		}

		private void cbBATCHNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshInfo();
		}
	}
}
