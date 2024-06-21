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
	public class frmSSESHP : Form
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
		[AccessedThroughProperty("btnDELETEFR")]
		private Button _btnDELETEFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnConfirm")]
		private Button _btnConfirm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnOFFICIALDO")]
		private Button _btnOFFICIALDO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSID")]
		private ComboboxControl _cbCUSID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDO")]
		private DataGridView _dgvDO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDETAILS")]
		private DataGridView _dgvDETAILS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCert")]
		private Button _btnCert;

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
		[AccessedThroughProperty("btnRemove")]
		private Button _btnRemove;

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

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
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

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnOFFICIALDO
		{
			[CompilerGenerated]
			get
			{
				return _btnOFFICIALDO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnOFFICIALDO_Click;
				Button button = _btnOFFICIALDO;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnOFFICIALDO = value;
				button = _btnOFFICIALDO;
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

		[field: AccessedThroughProperty("cbDELID")]
		internal virtual ComboboxControl cbDELID
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

		internal virtual DataGridView dgvDO
		{
			[CompilerGenerated]
			get
			{
				return _dgvDO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDO_CellMouseClick;
				DataGridView dataGridView = _dgvDO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvDO = value;
				dataGridView = _dgvDO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtITMCD")]
		internal virtual TextBox txtITMCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREVNO")]
		internal virtual TextBox txtREVNO
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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
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

		[field: AccessedThroughProperty("txtUPRICE")]
		internal virtual TextBox txtUPRICE
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

		[field: AccessedThroughProperty("txtAMT")]
		internal virtual TextBox txtAMT
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

		[field: AccessedThroughProperty("cbTRUCK")]
		internal virtual ComboBox cbTRUCK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbDRIVER")]
		internal virtual ComboBox cbDRIVER
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

		[field: AccessedThroughProperty("Label18")]
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnCert
		{
			[CompilerGenerated]
			get
			{
				return _btnCert;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCert_Click;
				Button button = _btnCert;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCert = value;
				button = _btnCert;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		private  ComboBox cbBATCHNO
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSODOCNO")]
		internal virtual TextBox txtSODOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label23")]
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label24")]
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnRemove
		{
			[CompilerGenerated]
			get
			{
				return _btnRemove;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRemove_Click;
				Button button = _btnRemove;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRemove = value;
				button = _btnRemove;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public frmSSESHP()
		{
			base.Load += frmSSESHP_Load;
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
			this.btnCert = new System.Windows.Forms.Button();
			this.btnOFFICIALDO = new System.Windows.Forms.Button();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.Label23 = new System.Windows.Forms.Label();
			this.cbTRUCK = new System.Windows.Forms.ComboBox();
			this.cbDRIVER = new System.Windows.Forms.ComboBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.cbPAYTM = new System.Windows.Forms.ComboBox();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.dgvDETAILS = new System.Windows.Forms.DataGridView();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtCURCD = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtITMCD = new System.Windows.Forms.TextBox();
			this.txtREVNO = new System.Windows.Forms.TextBox();
			this.txtUPRICE = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtAMT = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.cbBATCHNO = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtSODOCNO = new System.Windows.Forms.TextBox();
			this.dgvDO = new System.Windows.Forms.DataGridView();
			this.Label24 = new System.Windows.Forms.Label();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDELETEFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
			this.cbCUSID = new IMS.ComboboxControl();
			this.cbDELID = new IMS.ComboboxControl();
			this.numDOQTY = new IMS.NumControl();
			this.cbCUSIDTO = new IMS.ComboboxControl();
			this.cbCUSIDFR = new IMS.ComboboxControl();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).BeginInit();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDO).BeginInit();
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
			this.Panel1.Size = new System.Drawing.Size(1382, 676);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 6;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnCert, 5, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnOFFICIALDO, 4, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnConfirm, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(756, 56);
			this.TableLayoutPanel6.TabIndex = 0;
			this.btnCert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCert.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCert.Image = IMS.My.Resources.Resources.Print;
			this.btnCert.Location = new System.Drawing.Point(633, 3);
			this.btnCert.Name = "btnCert";
			this.btnCert.Size = new System.Drawing.Size(120, 50);
			this.btnCert.TabIndex = 27;
			this.btnCert.Text = "Certificate";
			this.btnCert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCert.UseVisualStyleBackColor = false;
			this.btnOFFICIALDO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnOFFICIALDO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnOFFICIALDO.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnOFFICIALDO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnOFFICIALDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOFFICIALDO.Image = IMS.My.Resources.Resources.Print;
			this.btnOFFICIALDO.Location = new System.Drawing.Point(507, 3);
			this.btnOFFICIALDO.Name = "btnOFFICIALDO";
			this.btnOFFICIALDO.Size = new System.Drawing.Size(120, 50);
			this.btnOFFICIALDO.TabIndex = 23;
			this.btnOFFICIALDO.Text = "Official DO";
			this.btnOFFICIALDO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOFFICIALDO.UseVisualStyleBackColor = false;
			this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirm.Image = IMS.My.Resources.Resources.Confirm;
			this.btnConfirm.Location = new System.Drawing.Point(3, 3);
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
			this.btnDelete.Location = new System.Drawing.Point(129, 3);
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
			this.btnPRINT.Location = new System.Drawing.Point(381, 3);
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
			this.btnBack.Location = new System.Drawing.Point(255, 3);
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
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80f));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.Label23, 0, 6);
			this.TableLayoutPanel5.Controls.Add(this.cbTRUCK, 4, 4);
			this.TableLayoutPanel5.Controls.Add(this.cbDRIVER, 4, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label20, 3, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label18, 3, 3);
			this.TableLayoutPanel5.Controls.Add(this.cbPAYTM, 4, 2);
			this.TableLayoutPanel5.Controls.Add(this.cbLOCID, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.cbCUSID, 1, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label12, 0, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label21, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel3, 0, 11);
			this.TableLayoutPanel5.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.dgvDETAILS, 0, 7);
			this.TableLayoutPanel5.Controls.Add(this.txtREMRK, 1, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label9, 0, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label3, 3, 0);
			this.TableLayoutPanel5.Controls.Add(this.dtpDOCDT, 4, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label19, 3, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label11, 3, 2);
			this.TableLayoutPanel5.Controls.Add(this.txtCURCD, 4, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label5, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.cbDELID, 1, 4);
			this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel1, 0, 10);
			this.TableLayoutPanel5.Controls.Add(this.dgvDO, 5, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label24, 5, 6);
			this.TableLayoutPanel5.Controls.Add(this.txtRECID, 4, 14);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 15;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(1369, 589);
			this.TableLayoutPanel5.TabIndex = 0;
			this.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label23.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label23, 4);
			this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label23.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label23.Location = new System.Drawing.Point(3, 195);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(177, 16);
			this.Label23.TabIndex = 59;
			this.Label23.Text = "Outstanding Sales Order";
			this.cbTRUCK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTRUCK.FormattingEnabled = true;
			this.cbTRUCK.Location = new System.Drawing.Point(617, 121);
			this.cbTRUCK.Name = "cbTRUCK";
			this.cbTRUCK.Size = new System.Drawing.Size(164, 24);
			this.cbTRUCK.TabIndex = 58;
			this.cbDRIVER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDRIVER.FormattingEnabled = true;
			this.cbDRIVER.Location = new System.Drawing.Point(617, 91);
			this.cbDRIVER.Name = "cbDRIVER";
			this.cbDRIVER.Size = new System.Drawing.Size(164, 24);
			this.cbDRIVER.TabIndex = 57;
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(510, 125);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(52, 16);
			this.Label20.TabIndex = 56;
			this.Label20.Text = "Truck #";
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(510, 95);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(44, 16);
			this.Label18.TabIndex = 55;
			this.Label18.Text = "Driver";
			this.cbPAYTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPAYTM.FormattingEnabled = true;
			this.cbPAYTM.Location = new System.Drawing.Point(617, 61);
			this.cbPAYTM.Name = "cbPAYTM";
			this.cbPAYTM.Size = new System.Drawing.Size(164, 24);
			this.cbPAYTM.TabIndex = 50;
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(99, 31);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(214, 24);
			this.cbLOCID.TabIndex = 49;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(3, 125);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(55, 16);
			this.Label12.TabIndex = 6;
			this.Label12.Text = "Ship To";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 35);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(59, 16);
			this.Label21.TabIndex = 48;
			this.Label21.Text = "Location";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 6);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel5.SetColumnSpan(this.TableLayoutPanel3, 3);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnRemove, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 531);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 56);
			this.TableLayoutPanel3.TabIndex = 0;
			this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.Image = IMS.My.Resources.Resources.Delete;
			this.btnRemove.Location = new System.Drawing.Point(129, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(120, 50);
			this.btnRemove.TabIndex = 62;
			this.btnRemove.Text = "Remove";
			this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(3, 3);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 61;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.txtDOCNO.Location = new System.Drawing.Point(99, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.dgvDETAILS.AllowUserToAddRows = false;
			this.dgvDETAILS.AllowUserToDeleteRows = false;
			this.dgvDETAILS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvDETAILS, 5);
			this.dgvDETAILS.EnableHeadersVisualStyles = false;
			this.dgvDETAILS.Location = new System.Drawing.Point(3, 216);
			this.dgvDETAILS.MultiSelect = false;
			this.dgvDETAILS.Name = "dgvDETAILS";
			this.dgvDETAILS.ReadOnly = true;
			this.dgvDETAILS.RowHeadersVisible = false;
			this.dgvDETAILS.RowHeadersWidth = 51;
			this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDETAILS.Size = new System.Drawing.Size(778, 183);
			this.dgvDETAILS.TabIndex = 8;
			this.dgvDETAILS.TabStop = false;
			this.TableLayoutPanel5.SetColumnSpan(this.txtREMRK, 5);
			this.txtREMRK.Location = new System.Drawing.Point(99, 151);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(1081, 39);
			this.txtREMRK.TabIndex = 7;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 162);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(510, 6);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(617, 3);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(510, 35);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(61, 16);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "Currency";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(510, 65);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(96, 16);
			this.Label11.TabIndex = 10;
			this.Label11.Text = "Payment Term";
			this.txtCURCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCURCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCURCD.Enabled = false;
			this.txtCURCD.Location = new System.Drawing.Point(617, 32);
			this.txtCURCD.Name = "txtCURCD";
			this.txtCURCD.Size = new System.Drawing.Size(87, 22);
			this.txtCURCD.TabIndex = 4;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 65);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(65, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Customer";
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel5.SetColumnSpan(this.TableLayoutPanel1, 4);
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.Label8, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtITMCD, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtREVNO, 5, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtUPRICE, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label14, 4, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtAMT, 5, 2);
			this.TableLayoutPanel1.Controls.Add(this.numDOQTY, 5, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 4, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label15, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.cbBATCHNO, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtSODOCNO, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 415);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 4;
			this.TableLayoutPanel5.SetRowSpan(this.TableLayoutPanel1, 4);
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(546, 111);
			this.TableLayoutPanel1.TabIndex = 2;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(321, 34);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(82, 16);
			this.Label8.TabIndex = 16;
			this.Label8.Text = "Revision No";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 34);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(69, 16);
			this.Label7.TabIndex = 9;
			this.Label7.Text = "Item Code";
			this.txtITMCD.Location = new System.Drawing.Point(121, 31);
			this.txtITMCD.Name = "txtITMCD";
			this.txtITMCD.ReadOnly = true;
			this.txtITMCD.Size = new System.Drawing.Size(174, 22);
			this.txtITMCD.TabIndex = 18;
			this.txtITMCD.TabStop = false;
			this.txtREVNO.Location = new System.Drawing.Point(409, 31);
			this.txtREVNO.Name = "txtREVNO";
			this.txtREVNO.ReadOnly = true;
			this.txtREVNO.Size = new System.Drawing.Size(109, 22);
			this.txtREVNO.TabIndex = 21;
			this.txtREVNO.TabStop = false;
			this.txtUPRICE.Location = new System.Drawing.Point(121, 59);
			this.txtUPRICE.Name = "txtUPRICE";
			this.txtUPRICE.ReadOnly = true;
			this.txtUPRICE.Size = new System.Drawing.Size(123, 22);
			this.txtUPRICE.TabIndex = 23;
			this.txtUPRICE.TabStop = false;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 62);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(65, 16);
			this.Label10.TabIndex = 19;
			this.Label10.Text = "Unit Price";
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(321, 62);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(53, 16);
			this.Label14.TabIndex = 24;
			this.Label14.Text = "Amount";
			this.txtAMT.Location = new System.Drawing.Point(409, 59);
			this.txtAMT.Name = "txtAMT";
			this.txtAMT.ReadOnly = true;
			this.txtAMT.Size = new System.Drawing.Size(123, 22);
			this.txtAMT.TabIndex = 25;
			this.txtAMT.TabStop = false;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(321, 91);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(57, 16);
			this.Label13.TabIndex = 22;
			this.Label13.Text = " O/S Qty";
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 91);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(63, 16);
			this.Label15.TabIndex = 10;
			this.Label15.Text = "Batch No";
			this.cbBATCHNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBATCHNO.FormattingEnabled = true;
			this.cbBATCHNO.Location = new System.Drawing.Point(121, 87);
			this.cbBATCHNO.Name = "cbBATCHNO";
			this.cbBATCHNO.Size = new System.Drawing.Size(174, 24);
			this.cbBATCHNO.TabIndex = 60;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 6);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(112, 16);
			this.Label6.TabIndex = 61;
			this.Label6.Text = "SO Document No";
			this.txtSODOCNO.Location = new System.Drawing.Point(121, 3);
			this.txtSODOCNO.Name = "txtSODOCNO";
			this.txtSODOCNO.ReadOnly = true;
			this.txtSODOCNO.Size = new System.Drawing.Size(174, 22);
			this.txtSODOCNO.TabIndex = 62;
			this.txtSODOCNO.TabStop = false;
			this.dgvDO.AllowUserToAddRows = false;
			this.dgvDO.AllowUserToDeleteRows = false;
			this.dgvDO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDO.EnableHeadersVisualStyles = false;
			this.dgvDO.Location = new System.Drawing.Point(787, 216);
			this.dgvDO.MultiSelect = false;
			this.dgvDO.Name = "dgvDO";
			this.dgvDO.ReadOnly = true;
			this.dgvDO.RowHeadersVisible = false;
			this.dgvDO.RowHeadersWidth = 51;
			this.dgvDO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDO.Size = new System.Drawing.Size(579, 183);
			this.dgvDO.TabIndex = 9;
			this.dgvDO.TabStop = false;
			this.Label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label24.AutoSize = true;
			this.Label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label24.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label24.Location = new System.Drawing.Point(787, 195);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(109, 16);
			this.Label24.TabIndex = 60;
			this.Label24.Text = "Delivery Order";
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(617, 548);
			this.txtRECID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(87, 22);
			this.txtRECID.TabIndex = 0;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRECID.Visible = false;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1382, 676);
			this.Panel2.TabIndex = 2;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 199);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1175, 466);
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
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 137);
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
			this.TableLayoutPanel2.Size = new System.Drawing.Size(805, 118);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[3] { "Pending Only", "Confirm Only", "All" });
			this.cboSTSFG.Location = new System.Drawing.Point(110, 91);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(121, 24);
			this.cboSTSFG.TabIndex = 7;
			this.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label22.Location = new System.Drawing.Point(3, 95);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(45, 16);
			this.Label22.TabIndex = 10;
			this.Label22.Text = "Status";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 37);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(65, 16);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Customer";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 66);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(446, 66);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(477, 63);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 6;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(110, 63);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 5;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(446, 7);
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
			this.Label16.Location = new System.Drawing.Point(446, 37);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 16);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			this.cbCUSID.BlankValue = null;
			this.cbCUSID.ComboboxWidth = 170;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = true;
			this.cbCUSID.Location = new System.Drawing.Point(99, 60);
			this.cbCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(325, 25);
			this.cbCUSID.TabIndex = 53;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
			this.cbDELID.BlankValue = null;
			this.cbDELID.ComboboxWidth = 170;
			this.cbDELID.DataTable = null;
			this.cbDELID.DisplayMember = null;
			this.cbDELID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDELID.HasBlankValue = true;
			this.cbDELID.Location = new System.Drawing.Point(99, 120);
			this.cbDELID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDELID.Name = "cbDELID";
			this.cbDELID.SelectedIndex = -1;
			this.cbDELID.SelectedItem = null;
			this.cbDELID.SelectedValue = null;
			this.cbDELID.Size = new System.Drawing.Size(325, 25);
			this.cbDELID.TabIndex = 54;
			this.cbDELID.TextMultiline = true;
			this.cbDELID.ValueMember = null;
			this.cbDELID.WhereClause = null;
			this.numDOQTY.AllowNegative = false;
			this.numDOQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numDOQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numDOQTY.DataChanged = false;
			this.numDOQTY.Location = new System.Drawing.Point(409, 88);
			this.numDOQTY.Name = "numDOQTY";
			this.numDOQTY.NumberFormat = "8.2";
			this.numDOQTY.ReadOnly = true;
			this.numDOQTY.Size = new System.Drawing.Size(87, 22);
			this.numDOQTY.TabIndex = 20;
			this.numDOQTY.TabStop = false;
			this.numDOQTY.Text = "0.00";
			this.numDOQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numDOQTY.ThousandSeperator = false;
			this.numDOQTY.Value = 0.0;
			this.cbCUSIDTO.BlankValue = null;
			this.cbCUSIDTO.ComboboxWidth = 170;
			this.cbCUSIDTO.DataTable = null;
			this.cbCUSIDTO.DisplayMember = null;
			this.cbCUSIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDTO.HasBlankValue = true;
			this.cbCUSIDTO.Location = new System.Drawing.Point(476, 32);
			this.cbCUSIDTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbCUSIDTO.Name = "cbCUSIDTO";
			this.cbCUSIDTO.SelectedIndex = -1;
			this.cbCUSIDTO.SelectedItem = null;
			this.cbCUSIDTO.SelectedValue = null;
			this.cbCUSIDTO.Size = new System.Drawing.Size(325, 26);
			this.cbCUSIDTO.TabIndex = 13;
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
			this.cbCUSIDFR.Size = new System.Drawing.Size(331, 26);
			this.cbCUSIDFR.TabIndex = 12;
			this.cbCUSIDFR.TextMultiline = true;
			this.cbCUSIDFR.ValueMember = null;
			this.cbCUSIDFR.WhereClause = null;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(476, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(327, 26);
			this.cbDOCNOTO.TabIndex = 51;
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
			this.cbDOCNOFR.Size = new System.Drawing.Size(332, 25);
			this.cbDOCNOFR.TabIndex = 11;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1384, 679);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmSSESHP";
			base.Tag = "SSESHP";
			this.Text = "Delivery Order";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).EndInit();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDO).EndInit();
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
			BindComboBox();
			ManageOrderNo();
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "SSSHP_TBL WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "SSSHP_DOCNO";
			cbDOCNOFR.DisplayMember = "SSSHP_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "SSSHP_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "SSSHP_DOCNO";
			cbDOCNOTO.DisplayMember = "SSSHP_DOCNO";
			cbDOCNOTO.LoadData();
			cbCUSIDFR.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSIDFR.ValueMember = "MACUS_CUSID";
			cbCUSIDFR.DisplayMember = "MACUS_SHORT";
			cbCUSIDFR.LoadData();
			cbCUSIDTO.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSIDTO.ValueMember = "MACUS_CUSID";
			cbCUSIDTO.DisplayMember = "MACUS_SHORT";
			cbCUSIDTO.LoadData();
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'SSESHP'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private void Header()
		{
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spSSSHP '0', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDTO.SelectedValue), "', ")));
			strSQL += "'', ";
			strSQL += Conversions.ToString(cboSTSFG.SelectedIndex) ?? "";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvHEADER.ClearSelection();
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					int i = default(int);
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 130;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 200;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "CUSID");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 200;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 130;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "PAYTM");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Payment Term");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 130;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DELID");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ship To");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = "SSSHP_DRIVER";
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = "SSSHP_TRUCK";
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 400;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 30;
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void ClearDetails()
		{
			txtITMCD.Text = string.Empty;
			txtUPRICE.Text = string.Empty;
			txtREVNO.Text = string.Empty;
			txtAMT.Text = string.Empty;
			numDOQTY.Value = 0.0;
			cbBATCHNO.SelectedIndex = -1;
			txtRECID.Text = Conversions.ToString(-1);
		}

		private void ClearControl()
		{
			txtRECID.Text = Conversions.ToString(-1);
			dgvDETAILS.DataSource = null;
			txtDOCNO.Text = string.Empty;
			cbCUSID.SelectedIndex = -1;
			cbLOCID.SelectedIndex = -1;
			cbLOCID.Enabled = true;
			dtpDOCDT.Value = DateTime.Now;
			dtpDOCDT.Enabled = true;
			txtCURCD.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
			txtDOCNO.Enabled = true;
			cbCUSID.Enabled = true;
			cbPAYTM.Enabled = true;
			cbDELID.Enabled = true;
			btnConfirm.Enabled = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearControl();
			BindComboHeader();
			Header();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT 'FG' as LOCID ";
			cbLOCID.ValueMember = "LOCID";
			cbLOCID.DisplayMember = "LOCID";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'PAYTM' ORDER BY MACOD_CODID";
			cbPAYTM.ValueMember = "MACOD_CODID";
			cbPAYTM.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbPAYTM);
			strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION ";
			strSQL += "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'DRIVER' ORDER BY MACOD_CODID";
			cbDRIVER.ValueMember = "MACOD_CODID";
			cbDRIVER.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbDRIVER);
			strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION ";
			strSQL += "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'TRUCK' ORDER BY MACOD_CODID";
			cbTRUCK.ValueMember = "MACOD_CODID";
			cbTRUCK.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbTRUCK);
			cbCUSID.DataTable = "SLORD_TBL WITH (NOLOCK) LEFT JOIN MACUS_TBL WITH (NOLOCK) ON MACUS_CUSID = SLORD_CUSID ";
			cbCUSID.ValueMember = "SLORD_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			cbCUSID.LoadData();
			cbDELID.DataTable = "MADEL_TBL WITH (NOLOCK) ";
			cbDELID.ValueMember = "MADEL_DELID";
			cbDELID.DisplayMember = "MADEL_DELID";
			cbDELID.LoadData();
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["SSSHP_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["SSSHP_DOCDT"].Value);
			cbLOCID.SelectedValue = dgvHEADER.CurrentRow.Cells["SSSHP_LOCID"].Value.ToString();
			cbCUSID.SelectedValue = dgvHEADER.CurrentRow.Cells["SSSHP_CUSID"].Value.ToString();
			cbPAYTM.SelectedValue = dgvHEADER.CurrentRow.Cells["SSSHP_PAYTM"].Value.ToString();
			cbDRIVER.SelectedValue = dgvHEADER.CurrentRow.Cells["SSSHP_DRIVER"].Value.ToString();
			cbTRUCK.SelectedValue = dgvHEADER.CurrentRow.Cells["SSSHP_TRUCK"].Value.ToString();
			cbDELID.SelectedValue = dgvHEADER.CurrentRow.Cells["SSSHP_DELID"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["SSSHP_REMRK"].Value.ToString();
			txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MACUS_CURCD", "MACUS_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CUSID = '", cbCUSID.SelectedValue), "'"))));
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindHeadertoControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
			checkEnable();
		}

		private void checkEnable()
		{
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("SSSHP_STSFG", "SSSHP_TBL", "SSSHP_DOCNO = '" + txtDOCNO.Text + "'"));
			txtRECID.Text = Conversions.ToString(-1);
			if (Conversions.ToDouble(strSTSFG) == 1.0)
			{
				btnDelete.Enabled = Conversions.ToBoolean(Interaction.IIf(PublicVar.gblnSupervisor, true, false));
				btnRemove.Enabled = Conversions.ToBoolean(Interaction.IIf(PublicVar.gblnSupervisor, true, false));
				btnConfirm.Enabled = false;
				cbBATCHNO.Enabled = false;
				cbTRUCK.Enabled = true;
				cbDRIVER.Enabled = true;
			}
			else
			{
				btnDelete.Enabled = true;
				btnRemove.Enabled = true;
				btnConfirm.Enabled = true;
				cbBATCHNO.Enabled = true;
				cbTRUCK.Enabled = true;
				cbDRIVER.Enabled = true;
			}
			cbCUSID.Enabled = false;
			cbDELID.Enabled = false;
			dtpDOCDT.Enabled = false;
			cbLOCID.Enabled = false;
			txtDOCNO.Enabled = false;
			cbPAYTM.Enabled = false;
			btnPRINT.Enabled = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
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
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbLOCID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location ID cannot blank!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbLOCID.Focus();
				return false;
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

		private void btnDELETEFR_Click(object sender, EventArgs e)
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["SSSHP_DOCNO"].Value.ToString();
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("SSSHP_STSFG", "SSSHP_TBL", "SSSHP_DOCNO = '" + txtDOCNO.Text + "'"));
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + txtDOCNO.Text;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				if ((Operators.CompareString(strSTSFG, "1", false) == 0) & !PublicVar.gblnSupervisor)
				{
					strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record already confirm not allow to delete!");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (spSSESHP("1"))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					BindComboHeader();
					Header();
				}
			}
		}

		private void frmSSESHP_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			cboSTSFG.SelectedIndex = 0;
			Header();
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

		private void frmSSESHP_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void btnOFFICIALDO_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "DELIVERY ORDER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptSSSHP2.rpt";
			frmRPT.Params = "@DOCNO=" + txtDOCNO.Text;
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='DELIVERY ORDER',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.CustomPaperSize = "TDD_DO";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnCert_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "Certificate Of Analysis";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDRCOA.rpt";
			frmRPT.Params = "@DOCNO=" + txtDOCNO.Text;
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='Certificate Of Analysis',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void cbCUSID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCUSID.SelectedIndex != -1)
			{
				txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MACUS_CURCD", "MACUS_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CUSID = '", cbCUSID.SelectedValue), "'"))));
				cbDELID.DataTable = "MADEL_TBL WITH (NOLOCK) LEFT JOIN MACUS_TBL WITH (NOLOCK) ON MACUS_CUSID = MADEL_CUSID";
				cbDELID.WhereClause = "MADEL_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
				cbDELID.ValueMember = "MADEL_DELID";
				cbDELID.DisplayMember = "MADEL_DELID";
				cbDELID.LoadData();
				BindDetailsGrid();
				BindGridControl();
			}
		}

		private void BindDetailsGrid()
		{
			int i = 0;
			dgvDETAILS.DataSource = null;
			string strSQL = "EXEC spSSSHP2 '0', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvDETAILS.ClearSelection();
					DataGridView dataGridView = dgvDETAILS;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "SO Doc No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 75;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Unit Price");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Order");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Shipped");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Onhand");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Outstanding");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void dgvDETAILS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtSODOCNO.Text = Conversions.ToString(dgvDETAILS.CurrentRow.Cells["SSSHP_SODOCNO"].Value);
			txtITMCD.Text = Conversions.ToString(dgvDETAILS.CurrentRow.Cells["SSSHP_ITMCD"].Value);
			txtREVNO.Text = Conversions.ToString(dgvDETAILS.CurrentRow.Cells["SSSHP_REVNO"].Value);
			if (Operators.CompareString(txtDOCNO.Text, "", false) != 0)
			{
				string strSQL = "SELECT * FROM SSSHP_TBL WHERE SSSHP_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "'";
				if (DB.RecordExists(strSQL))
				{
					string strWHERE = "SSSHP_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
					strWHERE = strWHERE + "AND SSSHP_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "' ";
					strWHERE = strWHERE + "AND SSSHP_REVNO = '" + Common.gfValidSQLStr(txtREVNO.Text) + "'";
					txtRECID.Text = Conversions.ToString(DB.GetColumnValue("SSSHP_RECID", "SSSHP_TBL", strWHERE));
				}
				else
				{
					txtRECID.Text = Conversions.ToString(-1);
				}
			}
			BindBatchNo();
		}

		private void BindGridControl()
		{
			int i = 0;
			dgvDO.DataSource = null;
			string strSQL = "EXEC spSSSHP2 '1', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvDO.ClearSelection();
					DataGridView dataGridView = dgvDO;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 30;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "RECID");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "SO Doc No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 75;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "SSSHP_UPRICE");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "SSSHP_AMT");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void BindBatchNo()
		{
			string strSQL = "SELECT INTRN_GRLNO FROM vwItemBalanceByGRLNO ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE INTRN_LOCID = '", cbLOCID.SelectedValue), "' ")));
			strSQL = strSQL + "AND INTRN_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "' ";
			strSQL = strSQL + "AND INTRN_REVNO = '" + Common.gfValidSQLStr(txtREVNO.Text) + "' ";
			strSQL = strSQL + "AND (INTRN_BALQT > 0 OR EXISTS (SELECT * FROM SSSHP_TBL WHERE SSSHP_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL += "AND SSSHP_BATCHNO = INTRN_GRLNO))";
			cbBATCHNO.ValueMember = "INTRN_GRLNO";
			cbBATCHNO.DisplayMember = "INTRN_GRLNO";
			Common.RetriveComboItembySQL(strSQL, cbBATCHNO);
		}

		private bool spSSESHP(string strPRO)
		{
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'SSESHP'"));
			bool spSSESHP;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("SSESHP", "SSSHP", ref strNextNo))
					{
						string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control.");
						MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spSSESHP = false;
						goto IL_04e8;
					}
					txtDOCNO.Text = strNextNo;
				}
			}
			else
			{
				txtDOCNO.Enabled = true;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank!");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					txtDOCNO.Focus();
					spSSESHP = false;
					goto IL_04e8;
				}
			}
			strSQL = "EXEC spSSESHP ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(txtRECID.Text)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPAYTM.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbDELID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL += "'', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtSODOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtITMCD.Text) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(Conversions.ToDouble(strPRO) == 0.0, Common.gfValidSQLStr(txtREVNO.Text), 0)), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(Conversions.ToDouble(strPRO) == 0.0, Common.gfValidSQLStr(Conversions.ToString(numDOQTY.Value)), 0)), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(Conversions.ToDouble(strPRO) == 0.0, Common.gfValidSQLStr(txtUPRICE.Text), 0)), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(Conversions.ToDouble(strPRO) == 0.0, Common.gfValidSQLStr(txtAMT.Text), 0)), "', ")));
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbDRIVER.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbTRUCK.SelectedValue)) + "', ";
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
				spSSESHP = false;
				ProjectData.ClearProjectError();
				goto IL_04e8;
			}
			spSSESHP = true;
			goto IL_04e8;
			IL_04e8:
			return spSSESHP;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strDOCNO = txtDOCNO.Text;
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("SSSHP_STSFG", "SSSHP_TBL", "SSSHP_DOCNO = '" + strDOCNO + "'"));
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + strDOCNO;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				if ((Operators.CompareString(strSTSFG, "1", false) == 0) & !PublicVar.gblnSupervisor)
				{
					strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record already confirm not allow to delete!");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (spSSESHP("1"))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					BindComboHeader();
					Header();
				}
			}
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			GenerateQRCode();
			DisplayReport();
			DisplayLabel();
		}

		private void GenerateQRCode()
		{
			OleDbCommand cmd = new OleDbCommand();
			object settings = new BarcodeSettings();
			string strSQL = "EXEC spSSSHP_QR ";
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
			DataTable dt = DB.ExecProc("SELECT DISTINCT PDWKO_WKONO FROM PDWKO_QR WHERE PDWKO_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "'");
			int num = checked(dt.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				NewLateBinding.LateSet(settings, null, "HasBorder", new object[1] { false }, null, null);
				NewLateBinding.LateSet(settings, null, "ShowText", new object[1] { false }, null, null);
				NewLateBinding.LateSet(settings, null, "Type", new object[1] { (BarCodeType)Conversions.ToLong(Enum.Parse(typeof(BarCodeType), "QRCode")) }, null, null);
				NewLateBinding.LateSet(settings, null, "LeftMargin", new object[1] { 1 }, null, null);
				string strWKONO = Common.gfValidSQLStr(dt.Rows[i]["PDWKO_WKONO"].ToString().Trim());
				NewLateBinding.LateSet(settings, null, "Data2D", new object[1] { strWKONO }, null, null);
				NewLateBinding.LateSet(settings, null, "Data", new object[1] { strWKONO }, null, null);
				BarCodeGenerator sprSCRID = new BarCodeGenerator((IBarcodeSettings)settings);
				byte[] imgQRCODE = Common.ImageToByte2(sprSCRID.GenerateImage());
				try
				{
					cmd = new OleDbCommand();
					cmd.Connection = DB.GetDBConnection();
					strSQL = "spPDWKO_QR2";
					cmd.CommandText = strSQL;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("@PRNID", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(MyProject.Computer.Name);
					cmd.Parameters.Add("@WKONO", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(strWKONO);
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
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "WORK ORDER";
			string strSQL = "SELECT DISTINCT PDWKO_MDLCD FROM PDWKO_QR ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK)  ON MAITM_ITMCD = PDWKO_MDLCD ";
			strSQL = strSQL + "WHERE PDWKO_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
			strSQL += "AND MAITM_ITMTY = 1";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string ITMGRP = Conversions.ToString(DB.GetColumnValue("MAITM_GRPCD", "MAITM_TBL WITH(NOLOCK)", "MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(dt.Rows[i]["PDWKO_MDLCD"])) + "' "));
					if (Operators.CompareString(ITMGRP, "", false) == 0)
					{
						continue;
					}
					if (Operators.CompareString(ITMGRP, "WB", false) != 0)
					{
						if (Operators.CompareString(ITMGRP, "SB", false) == 0)
						{
							frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKO1.rpt";
						}
						else
						{
							frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKO.rpt";
						}
					}
					else
					{
						frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKO.rpt";
					}
					frmRPT.Params = "@PRNID=" + Common.gfValidSQLStr(MyProject.Computer.Name) + " ";
					frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='WORK ORDER',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
					frmRPT.Destination = PublicEnum.Dest.Screen;
					frmRPT.ViewReport("");
				}
			}
		}

		private void DisplayLabel()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "WORK ORDER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKOL.rpt";
			frmRPT.Params = "@PAR=0,@PRNID=" + Common.gfValidSQLStr(MyProject.Computer.Name) + " ";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='WORK ORDER LABEL - FORMAT 1',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ComputerName = MyProject.Computer.Name;
			frmRPT.ViewReportbyComputerName();
		}

		private bool ValidateBatchno()
		{
			bool blnFound = false;
			string strITMCD = string.Empty;
			string strWHERE = "PDFGR_FGLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "' ";
			if (DB.RecordExists("SELECT * FROM PDFGR_TBL WITH(NOLOCK) WHERE " + strWHERE + " "))
			{
				strITMCD = Conversions.ToString(DB.GetColumnValue("PDFGR_MDLCD", "PDFGR_TBL WITH(NOLOCK)", "PDFGR_FGLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "' "));
				blnFound = true;
			}
			strWHERE = "PCGRN_GRLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "' ";
			if (DB.RecordExists("SELECT * FROM PCGRN_TBL WITH(NOLOCK) WHERE " + strWHERE + " "))
			{
				strITMCD = Conversions.ToString(DB.GetColumnValue("PCGRN_ITMCD", "PCGRN_TBL WITH(NOLOCK)", "PCGRN_GRLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "' "));
				blnFound = true;
			}
			if (!blnFound)
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No not found.");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				cbBATCHNO.Select();
				return false;
			}
			string strITMTY = Conversions.ToString(DB.GetColumnValue("MAITM_ITMTY", "MAITM_TBL WITH(NOLOCK)", "MAITM_ITMCD = '" + Common.gfValidSQLStr(strITMCD) + "' "));
			if (Operators.CompareString(strITMTY, "1", false) == 0)
			{
				strWHERE = "PDFGR_FGLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "' ";
				strWHERE += "AND PDFGR_STSFG <> '1' ";
				if (DB.RecordExists("SELECT * FROM PDFGR_TBL WITH(NOLOCK) WHERE " + strWHERE + " "))
				{
					string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No not available!");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					cbBATCHNO.Select();
					return false;
				}
			}
			return true;
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
            DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Confirm order?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
			{
				string strSQL = "SELECT * FROM SSSHP_TBL WHERE SSSHP_STSFG = 1 AND SSSHP_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
				if (DB.RecordExists(strSQL))
				{
					string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Document No! Document already confirmed.");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				strSQL = "EXEC spSSESHP_CONFIRM ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
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
					ProjectData.ClearProjectError();
					return;
				}
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record confirmed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				ClearControl();
				BindComboHeader();
				Header();
			}
		}

		private void cbBATCHNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool blnFound = false;
			if (cbBATCHNO.SelectedIndex == -1 || !ValidateBatchno())
			{
				return;
			}
			txtITMCD.Text = Conversions.ToString(DB.GetColumnValue("PDFGR_MDLCD", "PDFGR_TBL WITH(NOLOCK)", "PDFGR_FGLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "' "));
			txtREVNO.Text = Conversions.ToString(DB.GetColumnValue("PDFGR_REVNO", "PDFGR_TBL WITH(NOLOCK)", "PDFGR_FGLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "' "));
			if (Operators.CompareString(txtITMCD.Text, "", false) == 0)
			{
				txtITMCD.Text = Conversions.ToString(DB.GetColumnValue("PCGRN_ITMCD", "PCGRN_TBL WITH(NOLOCK)", "PCGRN_GRLNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbBATCHNO.SelectedValue)) + "' "));
			}
			checked
			{
				int num = dgvDETAILS.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if ((Operators.CompareString(txtSODOCNO.Text, dgvDETAILS.Rows[i].Cells["SSSHP_SODOCNO"].Value.ToString(), false) == 0) & (Operators.CompareString(txtITMCD.Text, dgvDETAILS.Rows[i].Cells["SSSHP_ITMCD"].Value.ToString(), false) == 0))
					{
						blnFound = true;
					}
				}
				string strMSG;
				if (!blnFound)
				{
					strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record not found.");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					ClearDetails();
					return;
				}
				string strWHERE = "SSSHP_SODOCNO = '" + Common.gfValidSQLStr(txtSODOCNO.Text) + "' ";
				strWHERE = strWHERE + "AND SSSHP_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "' ";
				strWHERE = strWHERE + "AND SSSHP_REVNO = '" + Common.gfValidSQLStr(txtREVNO.Text) + "' ";
				strWHERE = strWHERE + "AND SSSHP_COMPNM = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
				txtUPRICE.Text = Conversions.ToString(DB.GetColumnValue("SSSHP_UPRICE", "SSSHP_WRK WITH(NOLOCK)", strWHERE));
				txtAMT.Text = Conversions.ToString(DB.GetColumnValue("SSSHP_AMT", "SSSHP_WRK WITH(NOLOCK)", strWHERE));
				decimal availQty = new decimal(Common.gfGetGRLBAL(Conversions.ToString(cbLOCID.SelectedValue), Conversions.ToString(cbBATCHNO.SelectedValue)));
				if (decimal.Compare(availQty, 0m) <= 0)
				{
					strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Lot No!, Balance 0.");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					ClearDetails();
					return;
				}
				decimal outStand = Conversions.ToDecimal(DB.GetColumnValue("ISNULL(SSSHP_OUTSTAND,0)", "SSSHP_WRK WITH(NOLOCK)", strWHERE));
				if (decimal.Compare(availQty, outStand) >= 0)
				{
					numDOQTY.Value = Convert.ToDouble(outStand);
					return;
				}
				numDOQTY.Value = Convert.ToDouble(availQty);
				strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DO Qty less than Outstanding Qty!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			if (spSSESHP("0"))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				BindDetailsGrid();
				BindGridControl();
				checkEnable();
			}
		}

		private void dgvDO_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtSODOCNO.Text = Conversions.ToString(dgvDO.CurrentRow.Cells["SSSHP_SODOCNO"].Value);
			txtITMCD.Text = Conversions.ToString(dgvDO.CurrentRow.Cells["SSSHP_ITMCD"].Value);
			txtREVNO.Text = Conversions.ToString(dgvDO.CurrentRow.Cells["SSSHP_REVNO"].Value);
			txtRECID.Text = Conversions.ToString(dgvDO.CurrentRow.Cells["SSSHP_RECID"].Value);
			BindBatchNo();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			if (Conversions.ToDouble(txtRECID.Text) != -1.0)
			{
				string strSQL = "DELETE SSSHP_TBL WHERE SSSHP_RECID = " + Conversions.ToString(Conversion.Val(txtRECID.Text)) + " ";
				strSQL = strSQL + "DELETE INTRN_TBL WHERE INTRN_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
				strSQL = strSQL + "AND INTRN_REFNO1 = '" + Common.gfValidSQLStr(txtRECID.Text) + "'";
				DB.ExecProc(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				BindDetailsGrid();
				BindGridControl();
			}
		}
	}
}
