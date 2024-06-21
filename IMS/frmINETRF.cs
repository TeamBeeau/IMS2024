using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using IMS.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class frmINETRF : Form
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
		[AccessedThroughProperty("txtPRQDOCNO")]
		private TextBox _txtPRQDOCNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtGRLNO")]
		private TextBox _txtGRLNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnADD")]
		private Button _btnADD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbLOCID")]
		private ComboboxControl _cbLOCID;

		private int count;

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

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
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

		[field: AccessedThroughProperty("numBALQTY")]
		internal virtual NumControl numBALQTY
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

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblGRLNO")]
		internal virtual Label lblGRLNO
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

		[field: AccessedThroughProperty("cbLOCID_TO")]
		internal virtual ComboboxControl cbLOCID_TO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtPRQDOCNO
		{
			[CompilerGenerated]
			get
			{
				return _txtPRQDOCNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtPRQDOCNO_KeyDown;
				TextBox textBox = _txtPRQDOCNO;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtPRQDOCNO = value;
				textBox = _txtPRQDOCNO;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtGRLNO
		{
			[CompilerGenerated]
			get
			{
				return _txtGRLNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtGRLNO_KeyDown;
				TextBox textBox = _txtGRLNO;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtGRLNO = value;
				textBox = _txtGRLNO;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
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

		[field: AccessedThroughProperty("cbLOCIDFR_TO")]
		internal virtual ComboboxControl cbLOCIDFR_TO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbLOCIDFR_FR")]
		internal virtual ComboboxControl cbLOCIDFR_FR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbLOCIDTO_TO")]
		internal virtual ComboboxControl cbLOCIDTO_TO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbLOCIDTO_FR")]
		internal virtual ComboboxControl cbLOCIDTO_FR
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

		[field: AccessedThroughProperty("Label19")]
		internal virtual Label Label19
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

		[field: AccessedThroughProperty("cmbTRFTY")]
		internal virtual ComboBox cmbTRFTY
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

		[field: AccessedThroughProperty("Label18")]
		internal virtual Label Label18
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

		internal virtual Button btnADD
		{
			[CompilerGenerated]
			get
			{
				return _btnADD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnADD_Click;
				Button button = _btnADD;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnADD = value;
				button = _btnADD;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbLOCID
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
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbLOCID_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbLOCID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbLOCID = value;
				comboboxControl = _cbLOCID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("numLotBal")]
		internal virtual NumControl numLotBal
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

		public frmINETRF()
		{
			base.FormClosing += frmINETRF_FormClosing;
			base.Load += frmINETRF_Load;
			base.KeyDown += frmINETRF_KeyDown;
			count = 0;
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
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbLOCID = new IMS.ComboboxControl();
			this.txtPRQDOCNO = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.cmbTRFTY = new System.Windows.Forms.ComboBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnADD = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.numQTY = new IMS.NumControl();
			this.Label4 = new System.Windows.Forms.Label();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtITMCD = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.txtGRLNO = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.numSAFETY = new IMS.NumControl();
			this.Label12 = new System.Windows.Forms.Label();
			this.numBALQTY = new IMS.NumControl();
			this.Label18 = new System.Windows.Forms.Label();
			this.numSTDWGT = new IMS.NumControl();
			this.cbLOCID_TO = new IMS.ComboboxControl();
			this.Label7 = new System.Windows.Forms.Label();
			this.lblGRLNO = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtREFNO = new System.Windows.Forms.TextBox();
			this.numLotBal = new IMS.NumControl();
			this.Label20 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDELETEFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbLOCIDTO_TO = new IMS.ComboboxControl();
			this.cbLOCIDTO_FR = new IMS.ComboboxControl();
			this.cbLOCIDFR_TO = new IMS.ComboboxControl();
			this.cbLOCIDFR_FR = new IMS.ComboboxControl();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
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
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel6.TabIndex = 47;
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
			this.btnSave.TabIndex = 49;
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
			this.btnDelete.TabIndex = 12;
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
			this.btnPRINT.TabIndex = 14;
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
			this.btnBack.TabIndex = 13;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtPRQDOCNO, 5, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label15, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.cmbTRFTY, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label14, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.txtRECID, 2, 10);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 12);
			this.TableLayoutPanel1.Controls.Add(this.numQTY, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.dgvDetails, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtITMCD, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label19, 2, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtGRLNO, 3, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.numSAFETY, 3, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 2, 9);
			this.TableLayoutPanel1.Controls.Add(this.numBALQTY, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label18, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.numSTDWGT, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID_TO, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblGRLNO, 4, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtREFNO, 5, 7);
			this.TableLayoutPanel1.Controls.Add(this.numLotBal, 3, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label20, 2, 8);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 13;
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
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(905, 495);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbLOCID.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbLOCID, 3);
			this.cbLOCID.ComboboxWidth = 170;
			this.cbLOCID.DataTable = null;
			this.cbLOCID.DisplayMember = null;
			this.cbLOCID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.HasBlankValue = false;
			this.cbLOCID.Location = new System.Drawing.Point(127, 316);
			this.cbLOCID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.SelectedIndex = -1;
			this.cbLOCID.SelectedItem = null;
			this.cbLOCID.SelectedValue = null;
			this.cbLOCID.Size = new System.Drawing.Size(364, 31);
			this.cbLOCID.TabIndex = 57;
			this.cbLOCID.TabStop = false;
			this.cbLOCID.TextMultiline = true;
			this.cbLOCID.ValueMember = null;
			this.cbLOCID.WhereClause = null;
			this.txtPRQDOCNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPRQDOCNO.Location = new System.Drawing.Point(711, 33);
			this.txtPRQDOCNO.Name = "txtPRQDOCNO";
			this.txtPRQDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtPRQDOCNO.TabIndex = 48;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(534, 36);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(171, 16);
			this.Label15.TabIndex = 48;
			this.Label15.Text = "Part Request Document No";
			this.cmbTRFTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTRFTY.FormattingEnabled = true;
			this.cmbTRFTY.Items.AddRange(new object[3] { "Material Issue to Production", "Production Return to Store", "Location Transfer" });
			this.cmbTRFTY.Location = new System.Drawing.Point(711, 3);
			this.cmbTRFTY.Name = "cmbTRFTY";
			this.cmbTRFTY.Size = new System.Drawing.Size(191, 24);
			this.cmbTRFTY.TabIndex = 3;
			this.cmbTRFTY.TabStop = false;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(534, 7);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(93, 16);
			this.Label14.TabIndex = 48;
			this.Label14.Text = "Transfer Type";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 354);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(108, 16);
			this.Label11.TabIndex = 49;
			this.Label11.Text = "Standard Weight";
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(313, 403);
			this.txtRECID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(87, 22);
			this.txtRECID.TabIndex = 46;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRECID.Visible = true;
			txtRECID.Enabled = false;

            this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnADD, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 439);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel3.TabIndex = 1;
			this.btnADD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnADD.Image = IMS.My.Resources.Resources.Save;
			this.btnADD.Location = new System.Drawing.Point(3, 2);
			this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(120, 50);
			this.btnADD.TabIndex = 8;
			this.btnADD.Text = "Add";
			this.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnADD.UseVisualStyleBackColor = false;
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
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
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
			this.btnREMOVE.TabIndex = 9;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQTY.DataChanged = false;
			this.numQTY.Location = new System.Drawing.Point(127, 403);
			this.numQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.2";
			this.numQTY.Size = new System.Drawing.Size(87, 22);
			this.numQTY.TabIndex = 7;
			this.numQTY.Text = "0.00";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 7);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDetails, 6);
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Location = new System.Drawing.Point(3, 135);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(874, 140);
			this.dgvDetails.TabIndex = 6;
			this.dgvDetails.TabStop = false;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(313, 7);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(424, 3);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.txtDOCNO.Location = new System.Drawing.Point(127, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 82);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 5);
			this.txtREMRK.Location = new System.Drawing.Point(127, 62);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(586, 57);
			this.txtREMRK.TabIndex = 5;
			this.txtREMRK.TabStop = false;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 293);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(69, 16);
			this.Label8.TabIndex = 3;
			this.Label8.Text = "Item Code";
			this.txtITMCD.Location = new System.Drawing.Point(127, 290);
			this.txtITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtITMCD.Name = "txtITMCD";
			this.txtITMCD.ReadOnly = true;
			this.txtITMCD.Size = new System.Drawing.Size(180, 22);
			this.txtITMCD.TabIndex = 50;
			this.txtITMCD.TabStop = false;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(313, 293);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(63, 16);
			this.Label19.TabIndex = 48;
			this.Label19.Text = "Batch No";
			this.txtGRLNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TableLayoutPanel1.SetColumnSpan(this.txtGRLNO, 2);
			this.txtGRLNO.Location = new System.Drawing.Point(424, 290);
			this.txtGRLNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGRLNO.Name = "txtGRLNO";
			this.txtGRLNO.Size = new System.Drawing.Size(180, 22);
			this.txtGRLNO.TabIndex = 6;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 406);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(84, 16);
			this.Label13.TabIndex = 4;
			this.Label13.Text = "Transfer Qty.";
			this.numSAFETY.AllowNegative = false;
			this.numSAFETY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSAFETY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSAFETY.DataChanged = false;
			this.numSAFETY.Location = new System.Drawing.Point(424, 377);
			this.numSAFETY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSAFETY.Name = "numSAFETY";
			this.numSAFETY.NumberFormat = "8.2";
			this.numSAFETY.ReadOnly = true;
			this.numSAFETY.Size = new System.Drawing.Size(87, 22);
			this.numSAFETY.TabIndex = 52;
			this.numSAFETY.TabStop = false;
			this.numSAFETY.Text = "0.00";
			this.numSAFETY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSAFETY.ThousandSeperator = false;
			this.numSAFETY.Value = 0.0;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(313, 380);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(87, 16);
			this.Label12.TabIndex = 50;
			this.Label12.Text = "Minimum Qty.";
			this.numBALQTY.AllowNegative = false;
			this.numBALQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numBALQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numBALQTY.DataChanged = false;
			this.numBALQTY.Location = new System.Drawing.Point(127, 377);
			this.numBALQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numBALQTY.Name = "numBALQTY";
			this.numBALQTY.NumberFormat = "8.2";
			this.numBALQTY.ReadOnly = true;
			this.numBALQTY.Size = new System.Drawing.Size(87, 22);
			this.numBALQTY.TabIndex = 51;
			this.numBALQTY.TabStop = false;
			this.numBALQTY.Text = "0.00";
			this.numBALQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numBALQTY.ThousandSeperator = false;
			this.numBALQTY.Value = 0.0;
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(3, 380);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(118, 16);
			this.Label18.TabIndex = 54;
			this.Label18.Text = "Total Balance Qty.";
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(127, 351);
			this.numSTDWGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.2";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(87, 22);
			this.numSTDWGT.TabIndex = 55;
			this.numSTDWGT.TabStop = false;
			this.numSTDWGT.Text = "0.00";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.cbLOCID_TO.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbLOCID_TO, 3);
			this.cbLOCID_TO.ComboboxWidth = 170;
			this.cbLOCID_TO.DataTable = null;
			this.cbLOCID_TO.DisplayMember = null;
			this.cbLOCID_TO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID_TO.HasBlankValue = false;
			this.cbLOCID_TO.Location = new System.Drawing.Point(127, 32);
			this.cbLOCID_TO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbLOCID_TO.Name = "cbLOCID_TO";
			this.cbLOCID_TO.SelectedIndex = -1;
			this.cbLOCID_TO.SelectedItem = null;
			this.cbLOCID_TO.SelectedValue = null;
			this.cbLOCID_TO.Size = new System.Drawing.Size(324, 25);
			this.cbLOCID_TO.TabIndex = 51;
			this.cbLOCID_TO.TabStop = false;
			this.cbLOCID_TO.TextMultiline = true;
			this.cbLOCID_TO.ValueMember = null;
			this.cbLOCID_TO.WhereClause = null;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 36);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(79, 16);
			this.Label7.TabIndex = 48;
			this.Label7.Text = "To Location";
			this.lblGRLNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblGRLNO.AutoSize = true;
			this.lblGRLNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblGRLNO.Location = new System.Drawing.Point(534, 323);
			this.lblGRLNO.Name = "lblGRLNO";
			this.lblGRLNO.Size = new System.Drawing.Size(107, 16);
			this.lblGRLNO.TabIndex = 53;
			this.lblGRLNO.Text = "Job No./Ref. No.";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 323);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(59, 16);
			this.Label5.TabIndex = 56;
			this.Label5.Text = "Location";
			this.txtREFNO.Location = new System.Drawing.Point(711, 316);
			this.txtREFNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREFNO.Name = "txtREFNO";
			this.txtREFNO.ReadOnly = true;
			this.txtREFNO.Size = new System.Drawing.Size(180, 22);
			this.txtREFNO.TabIndex = 48;
			this.txtREFNO.TabStop = false;
			this.numLotBal.AllowNegative = false;
			this.numLotBal.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numLotBal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numLotBal.DataChanged = false;
			this.numLotBal.Location = new System.Drawing.Point(424, 351);
			this.numLotBal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numLotBal.Name = "numLotBal";
			this.numLotBal.NumberFormat = "8.2";
			this.numLotBal.ReadOnly = true;
			this.numLotBal.Size = new System.Drawing.Size(87, 22);
			this.numLotBal.TabIndex = 58;
			this.numLotBal.TabStop = false;
			this.numLotBal.Text = "0.00";
			this.numLotBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numLotBal.ThousandSeperator = false;
			this.numLotBal.Value = 0.0;
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(313, 354);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(105, 16);
			this.Label20.TabIndex = 59;
			this.Label20.Text = "Lot Balance Qty.";
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 630);
			this.Panel2.TabIndex = 2;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 201);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1215, 420);
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
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 139);
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
			this.btnDELETEFR.TabIndex = 11;
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
			this.btnSEARCH.TabIndex = 9;
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
			this.btnClose.TabIndex = 13;
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
			this.btnNew.TabIndex = 10;
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
			this.btnPRINTFR.TabIndex = 12;
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
			this.TableLayoutPanel2.Controls.Add(this.cbLOCIDTO_TO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCIDTO_FR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCIDFR_TO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCIDFR_FR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label10, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label6, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 3);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 3);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 3);
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
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(808, 116);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbLOCIDTO_TO.BlankValue = null;
			this.cbLOCIDTO_TO.ComboboxWidth = 170;
			this.cbLOCIDTO_TO.DataTable = null;
			this.cbLOCIDTO_TO.DisplayMember = null;
			this.cbLOCIDTO_TO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCIDTO_TO.HasBlankValue = true;
			this.cbLOCIDTO_TO.Location = new System.Drawing.Point(479, 61);
			this.cbLOCIDTO_TO.Margin = new System.Windows.Forms.Padding(2);
			this.cbLOCIDTO_TO.Name = "cbLOCIDTO_TO";
			this.cbLOCIDTO_TO.SelectedIndex = -1;
			this.cbLOCIDTO_TO.SelectedItem = null;
			this.cbLOCIDTO_TO.SelectedValue = null;
			this.cbLOCIDTO_TO.Size = new System.Drawing.Size(323, 25);
			this.cbLOCIDTO_TO.TabIndex = 55;
			this.cbLOCIDTO_TO.TextMultiline = true;
			this.cbLOCIDTO_TO.ValueMember = null;
			this.cbLOCIDTO_TO.WhereClause = null;
			this.cbLOCIDTO_FR.BlankValue = null;
			this.cbLOCIDTO_FR.ComboboxWidth = 170;
			this.cbLOCIDTO_FR.DataTable = null;
			this.cbLOCIDTO_FR.DisplayMember = null;
			this.cbLOCIDTO_FR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCIDTO_FR.HasBlankValue = true;
			this.cbLOCIDTO_FR.Location = new System.Drawing.Point(117, 61);
			this.cbLOCIDTO_FR.Margin = new System.Windows.Forms.Padding(2);
			this.cbLOCIDTO_FR.Name = "cbLOCIDTO_FR";
			this.cbLOCIDTO_FR.SelectedIndex = -1;
			this.cbLOCIDTO_FR.SelectedItem = null;
			this.cbLOCIDTO_FR.SelectedValue = null;
			this.cbLOCIDTO_FR.Size = new System.Drawing.Size(320, 25);
			this.cbLOCIDTO_FR.TabIndex = 54;
			this.cbLOCIDTO_FR.TextMultiline = true;
			this.cbLOCIDTO_FR.ValueMember = null;
			this.cbLOCIDTO_FR.WhereClause = null;
			this.cbLOCIDFR_TO.BlankValue = null;
			this.cbLOCIDFR_TO.ComboboxWidth = 170;
			this.cbLOCIDFR_TO.DataTable = null;
			this.cbLOCIDFR_TO.DisplayMember = null;
			this.cbLOCIDFR_TO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCIDFR_TO.HasBlankValue = true;
			this.cbLOCIDFR_TO.Location = new System.Drawing.Point(479, 32);
			this.cbLOCIDFR_TO.Margin = new System.Windows.Forms.Padding(2);
			this.cbLOCIDFR_TO.Name = "cbLOCIDFR_TO";
			this.cbLOCIDFR_TO.SelectedIndex = -1;
			this.cbLOCIDFR_TO.SelectedItem = null;
			this.cbLOCIDFR_TO.SelectedValue = null;
			this.cbLOCIDFR_TO.Size = new System.Drawing.Size(323, 25);
			this.cbLOCIDFR_TO.TabIndex = 54;
			this.cbLOCIDFR_TO.TextMultiline = true;
			this.cbLOCIDFR_TO.ValueMember = null;
			this.cbLOCIDFR_TO.WhereClause = null;
			this.cbLOCIDFR_FR.BlankValue = null;
			this.cbLOCIDFR_FR.ComboboxWidth = 170;
			this.cbLOCIDFR_FR.DataTable = null;
			this.cbLOCIDFR_FR.DisplayMember = null;
			this.cbLOCIDFR_FR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCIDFR_FR.HasBlankValue = true;
			this.cbLOCIDFR_FR.Location = new System.Drawing.Point(117, 32);
			this.cbLOCIDFR_FR.Margin = new System.Windows.Forms.Padding(2);
			this.cbLOCIDFR_FR.Name = "cbLOCIDFR_FR";
			this.cbLOCIDFR_FR.SelectedIndex = -1;
			this.cbLOCIDFR_FR.SelectedItem = null;
			this.cbLOCIDFR_FR.SelectedValue = null;
			this.cbLOCIDFR_FR.Size = new System.Drawing.Size(324, 25);
			this.cbLOCIDFR_FR.TabIndex = 53;
			this.cbLOCIDFR_FR.TextMultiline = true;
			this.cbLOCIDFR_FR.ValueMember = null;
			this.cbLOCIDFR_FR.WhereClause = null;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(479, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(327, 26);
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
			this.cbDOCNOFR.Location = new System.Drawing.Point(117, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(327, 26);
			this.cbDOCNOFR.TabIndex = 52;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(449, 65);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(25, 16);
			this.Label10.TabIndex = 47;
			this.Label10.Text = "To";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 65);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(95, 16);
			this.Label6.TabIndex = 48;
			this.Label6.Text = "Location ID To";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 36);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(109, 16);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Location ID From";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 94);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(449, 94);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(480, 91);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 8;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(118, 91);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 7;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(449, 7);
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
			this.Label16.Location = new System.Drawing.Point(449, 36);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 16);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmINETRF";
			base.Tag = "INETRF";
			this.Text = "Material Transfer";
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

		private void BindHeaderCombo()
		{
			cbDOCNOFR.DataTable = "INTRF_TBL WITH (NOLOCK)";
			cbDOCNOFR.ValueMember = "INTRF_DOCNO";
			cbDOCNOFR.DisplayMember = "INTRF_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "INTRF_TBL WITH (NOLOCK)";
			cbDOCNOTO.ValueMember = "INTRF_DOCNO";
			cbDOCNOTO.DisplayMember = "INTRF_DOCNO";
			cbDOCNOTO.LoadData();
			cbLOCIDFR_FR.DataTable = "MALOC_TBL WITH (NOLOCK)";
			cbLOCIDFR_FR.WhereClause = "MALOC_ACTFG = -1 ";
			cbLOCIDFR_FR.ValueMember = "MALOC_LOCID";
			cbLOCIDFR_FR.DisplayMember = "MALOC_LOCNM";
			cbLOCIDFR_FR.LoadData();
			cbLOCIDFR_TO.DataTable = "MALOC_TBL WITH (NOLOCK)";
			cbLOCIDFR_TO.WhereClause = "MALOC_ACTFG = -1 ";
			cbLOCIDFR_TO.ValueMember = "MALOC_LOCID";
			cbLOCIDFR_TO.DisplayMember = "MALOC_LOCNM";
			cbLOCIDFR_TO.LoadData();
			cbLOCIDTO_FR.DataTable = "MALOC_TBL WITH (NOLOCK)";
			cbLOCIDTO_FR.WhereClause = "MALOC_ACTFG = -1 AND MALOC_LOCTY <> 'WH'";
			cbLOCIDTO_FR.ValueMember = "MALOC_LOCID";
			cbLOCIDTO_FR.DisplayMember = "MALOC_LOCNM";
			cbLOCIDTO_FR.LoadData();
			cbLOCIDTO_TO.DataTable = "MALOC_TBL WITH (NOLOCK)";
			cbLOCIDTO_TO.WhereClause = "MALOC_ACTFG = -1 AND MALOC_LOCTY <> 'WH'";
			cbLOCIDTO_TO.ValueMember = "MALOC_LOCID";
			cbLOCIDTO_TO.DisplayMember = "MALOC_LOCNM";
			cbLOCIDTO_TO.LoadData();
		}

		private void Header()
		{
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spINTRF '0', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCIDFR_FR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCIDFR_TO.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCIDTO_FR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCIDTO_TO.SelectedValue), "'")));
			DataTable dt = DB.ExecProc(strSQL);
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
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Transfer Type");
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO No");
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "To Location");
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
					Panel2.Visible = true;
					Panel1.Visible = false;
				}
			}
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmINETRF_FormClosing(object sender, FormClosingEventArgs e)
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

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "STOCK TRANSFER CHECK LIST";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptINTRF.rpt";
			if (Operators.CompareString(txtDOCNO.Text, "", false) != 0)
			{
				frmRPT.Params = "@PAR=1 ,@DOCNOFR=" + txtDOCNO.Text + ",@DOCNOTO=" + txtDOCNO.Text + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@LOCIDFR_FR=,@LOCIDFR_TO=z,@LOCIDTO_FR=,@LOCIDTO_TO=z";
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1 ,@DOCNOFR=", cbDOCNOFR.SelectedValue), ",@DOCNOTO="), cbDOCNOTO.SelectedValue), ",@DOCDTFR="), Common.gfSQLDate(dtpDOCDTFR.Value)), ",@DOCDTTO="), Common.gfSQLDate(dtpDOCDTTO.Value)), ",@LOCIDFR_FR="), cbLOCIDFR_FR.SelectedValue), ",@LOCIDFR_TO="), cbLOCIDFR_TO.SelectedValue), ",@LOCIDTO_FR="), cbLOCIDTO_FR.SelectedValue), ",@LOCIDTO_TO="), cbLOCIDTO_TO.SelectedValue), ""));
			}
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='STOCK\tTRANSFER CHECK LIST',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = true;
			btnPRINT.Enabled = false;
			ClearHeaderControl();
			BindComboBox();
			ManageOrderNo();
		}

		private void BindComboBox()
		{
			cbLOCID_TO.DataTable = "MALOC_TBL WITH (NOLOCK)";
			cbLOCID_TO.WhereClause = "MALOC_ACTFG = -1 AND MALOC_LOCTY <> 'WH'";
			cbLOCID_TO.ValueMember = "MALOC_LOCID";
			cbLOCID_TO.DisplayMember = "MALOC_LOCNM";
			cbLOCID_TO.LoadData();
			cbLOCID.DataTable = "MALOC_TBL WITH (NOLOCK)";
			cbLOCID.WhereClause = "MALOC_ACTFG = -1";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			cbLOCID.LoadData();
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'INETRF'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private void btnDELETEFR_Click(object sender, EventArgs e)
		{
			string strDOCNO = dgvHEADER.CurrentRow.Cells["INTRF_DOCNO"].Value.ToString();
			string strLOCIDFR = dgvHEADER.CurrentRow.Cells["INTRF_LOCIDFR"].Value.ToString();
			string strLOCIDTO = dgvHEADER.CurrentRow.Cells["INTRF_LOCIDTO"].Value.ToString();
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + strDOCNO;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				string strSQL = "UPDATE INTRF_TBL SET INTRF_STSFG = '2' WHERE INTRF_DOCNO = '" + strDOCNO + "' ";
				strSQL = strSQL + "DELETE INTRN_TBL WHERE INTRN_DOCCD = 'TRF' AND INTRN_DOCNO = '" + strDOCNO + "'";
				strSQL = strSQL + "DELETE INTRN_TBL WHERE INTRN_DOCCD = 'TRF' AND INTRN_DOCNO = '" + strDOCNO + "'";
				DB.DBExecute(strSQL);
				MessageBox.Show("Record deleted!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				BindHeaderCombo();
				Header();
			}
		}

		private void txtPRQDOCNO_KeyDown(object sender, KeyEventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			if (e.KeyCode.Equals(Keys.Return))
			{
				if (!DB.RecordExists("SELECT * FROM PDPRQ_TBL WITH (NOLOCK) WHERE PDPRQ_DOCNO = '" + Common.gfValidSQLStr(txtPRQDOCNO.Text) + "' "))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Part Request Document No!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtPRQDOCNO.Focus();
				}
				else if (ValidateHeaderControl() && spINETRF_DETAILS("0"))
				{
					txtPRQDOCNO.Enabled = false;
					cbLOCID_TO.Enabled = false;
					cmbTRFTY.Enabled = false;
					dtpDOCDT.Enabled = false;
					txtGRLNO.Focus();
					RefreshGrid();
					ClearDetails();
				}
			}
		}

		private void RefreshGrid()
		{
			int i = 0;
			dgvDetails.DataSource = null;
			string strSQL;
			if (Operators.CompareString(txtDOCNO.Text, string.Empty, false) != 0)
			{
				strSQL = "SELECT INTRF_RECID, INTRF_ITMCD, INTRF_LOCIDFR, INTRF_GRLNO, INTRF_QTY, INTRF_REFNO ";
				strSQL += "FROM INTRF_TBL WITH (NOLOCK) ";
				strSQL = strSQL + "WHERE INTRF_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
				strSQL += "ORDER BY INTRF_ITMCD ";
			}
			else
			{
				strSQL = "SELECT INTRF_RECID, INTRF_ITMCD, INTRF_LOCID, INTRF_GRLNO, INTRF_QTY, INTRF_REFNO ";
				strSQL += "FROM INTRF_WRK WITH (NOLOCK) ";
				strSQL = strSQL + "WHERE INTRF_COMPNM = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
				strSQL += "ORDER BY INTRF_ITMCD ";
			}
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = false;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "GRL No");
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
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void txtGRLNO_KeyDown(object sender, KeyEventArgs e)
		{
			bool blnFound = false;
			if (e.KeyCode.Equals(Keys.Return))
			{
				//txtPRQDOCNO.Text =
				txtPRQDOCNO.Text = txtGRLNO.Text;// Conversions.ToString(DB.GetColumnValue("DISTINCT INTRF_PRQNO", "INTRF_TBL WITH(NOLOCK)", "INTRF_DOCNO = '" + txtDOCNO.Text + "' "));
				DataTable dt= DB.GetTable("INTRF_RECID", "INTRF_TBL","", " INTRF_RECID ", " DESC");
				if(dt!=null)
				if(dt.Rows.Count>0)
				{
					int index =Convert.ToInt32(dt.Rows[0]["INTRF_RECID"])+1;
                    txtRECID.Text = index+ "";
                }
				
                string strSQL = "SELECT * FROM PCGRN_TBL WITH(NOLOCK) WHERE PCGRN_GRLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "' AND PCGRN_COMFG = 2";
				if (DB.RecordExists(strSQL))
				{
					blnFound = true;
				}
				strSQL = "SELECT * FROM PDFGR_TBL WITH(NOLOCK) WHERE PDFGR_FGLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "' AND PDFGR_STSFG = 1";
				if (DB.RecordExists(strSQL))
				{
					blnFound = true;
				}
				strSQL = "SELECT * FROM PDRFG_TBL WITH(NOLOCK) WHERE PDRFG_FGLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "' AND PDRFG_STSFG = 1";
				if (DB.RecordExists(strSQL))
				{
					blnFound = true;
				}
				if (!blnFound)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Batch No!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtGRLNO.Focus();
				}
				else
				{
					BindDetails();
				}
			}
		}

		private void BindDetails()
		{
			string strLOCID = string.Empty;
			double dblREQQT = 0.0;
			checked
			{
				if (Operators.CompareString(txtGRLNO.Text, string.Empty, false) != 0)
				{
					string strSQL = "SELECT * FROM INTRF_WRK WHERE INTRF_COMPNM = '" + MyProject.Computer.Name + "' ";
					strSQL = strSQL + "AND INTRF_GRLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "'";
					DataTable dt = DB.ExecProc(strSQL);
					if (dt.Rows.Count > 0)
					{
						txtITMCD.Text = Conversions.ToString(dt.Rows[0]["INTRF_ITMCD"]);
						cbLOCID.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["INTRF_LOCID"]);
						numQTY.Value = Conversions.ToDouble(dt.Rows[0]["INTRF_QTY"]);
					}
					else
					{
						strSQL = "SELECT * FROM PCGRN_TBL WITH (NOLOCK) WHERE PCGRN_GRLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "'";
						dt = DB.ExecProc(strSQL);
						if (dt.Rows.Count > 0)
						{
							txtITMCD.Text = Conversions.ToString(dt.Rows[0]["PCGRN_ITMCD"]);
							strLOCID = Conversions.ToString(dt.Rows[0]["PCGRN_LOCID"]);
						}
						else
						{
							strSQL = "SELECT * FROM PDFGR_TBL WITH (NOLOCK) WHERE PDFGR_FGLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "'";
							dt = DB.ExecProc(strSQL);
							if (dt.Rows.Count > 0)
							{
								txtITMCD.Text = Conversions.ToString(dt.Rows[0]["PDFGR_MDLCD"]);
								strLOCID = Conversions.ToString(dt.Rows[0]["PDFGR_LOCID"]);
							}
							else
							{
								strSQL = "SELECT * FROM PDRFG_TBL WITH (NOLOCK) WHERE PDRFG_FGLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "'";
								dt = DB.ExecProc(strSQL);
								if (dt.Rows.Count > 0)
								{
									txtITMCD.Text = Conversions.ToString(dt.Rows[0]["PDRFG_MDLCD"]);
									strLOCID = Conversions.ToString(dt.Rows[0]["PDRFG_LOCID"]);
								}
							}
						}
						string strITMTY = Conversions.ToString(DB.GetColumnValue("MAITM_ITMTY", "MAITM_TBL", "MAITM_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'"));
						if (Operators.CompareString(strLOCID, "", false) == 0)
						{
							cbLOCID.SelectedIndex = -1;
						}
						else
						{
							cbLOCID.SelectedValue = strLOCID;
						}
						numLotBal.Value = Common.gfGetGRLBAL(strLOCID, txtGRLNO.Text);
						int num = dgvDetails.RowCount - 1;
						for (int i = 0; i <= num; i++)
						{
							if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dgvDetails.Rows[i].Cells["INTRF_ITMCD"].Value, txtITMCD.Text, false), Operators.CompareObjectEqual(dgvDetails.Rows[i].Cells["INTRF_GRLNO"].Value, "", false))))
							{
								dblREQQT = Conversions.ToDouble(dgvDetails.Rows[i].Cells["INTRF_QTY"].Value);
								txtRECID.Text = Conversions.ToString(dgvDetails.Rows[i].Cells["INTRF_RECID"].Value);
								break;
							}
						}
						if (dblREQQT < numLotBal.Value)
						{
							numQTY.Value = dblREQQT;
						}
						else
						{
							numQTY.Value = numLotBal.Value;
						}
					}
				}
				numBALQTY.Value = Conversions.ToDouble(DB.GetColumnValue("INBAL_QTY", "INBAL_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INBAL_LOCID = '", cbLOCID.SelectedValue), "' AND INBAL_ITMCD = '"), Common.gfValidSQLStr(txtITMCD.Text)), "'"))));
				numBALQTY.BackColor = SystemColors.ButtonHighlight;
				numSAFETY.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_SAFETY", "MAITM_TBL", "MAITM_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'"));
				numSAFETY.BackColor = SystemColors.ButtonHighlight;
				numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL", "MAITM_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'"));
				numSTDWGT.BackColor = SystemColors.ButtonHighlight;
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
		}

		private bool ValidateHeaderControl()
		{
			if (cmbTRFTY.SelectedIndex == -1)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Please select a Transfer Type!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbTRFTY.Focus();
				return false;
			}
			if (cbLOCID_TO.SelectedIndex == -1)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location ID To cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbLOCID_TO.Focus();
				return false;
			}
			return true;
		}

		private void ClearHeaderControl()
		{
			cbLOCID_TO.SelectedIndex = -1;
			cmbTRFTY.SelectedIndex = -1;
			count = 0;
			txtDOCNO.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			dtpDOCDT.Value = DateAndTime.Now;
			txtPRQDOCNO.Text = string.Empty;
			txtPRQDOCNO.Enabled = true;
			txtDOCNO.Enabled = true;
			btnSave.Enabled = true;
			btnPRINT.Enabled = true;
			txtGRLNO.Enabled = true;
			btnREMOVE.Enabled = true;
			btnDelete.Enabled = true;
			cbLOCID_TO.Enabled = true;
			cmbTRFTY.Enabled = true;
			dtpDOCDT.Enabled = true;
			dgvDetails.DataSource = null;
		}

		private void ClearDetails()
		{
			txtRECID.Text = Conversions.ToString(-1);
			txtITMCD.Text = string.Empty;
			txtGRLNO.Text = string.Empty;
			txtGRLNO.Enabled = true;
			txtREFNO.Text = string.Empty;
			numBALQTY.Value = 0.0;
			numSTDWGT.Value = 0.0;
			numSAFETY.Value = 0.0;
			numBALQTY.ForeColor = SystemColors.WindowText;
			numSAFETY.ForeColor = SystemColors.WindowText;
			numQTY.Value = 0.0;
			txtGRLNO.Enabled = true;
			txtREFNO.Enabled = true;
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			if (Conversions.ToDouble(txtRECID.Text) == -1.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No select record!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string strSQL = "DELETE INTRF_WRK WHERE INTRF_RECID = '" + txtRECID.Text + "' AND INTRF_COMPNM = '" + MyProject.Computer.Name + "' ";
			DataTable DT = DB.ExecProc(strSQL);
			RefreshGrid();
			ClearDetails();
		}

		private bool spINETRF_DETAILS(string strPRO)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spINETRF_DETAILS ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtRECID.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtREFNO.Text) + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(numQTY.Value)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtPRQDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtGRLNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
			bool spINETRF_DETAILS;
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
				spINETRF_DETAILS = false;
				ProjectData.ClearProjectError();
				goto IL_0163;
			}
			spINETRF_DETAILS = true;
			goto IL_0163;
			IL_0163:
			return spINETRF_DETAILS;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearHeaderControl();
			ClearDetails();
			BindHeaderCombo();
			Header();
		}

		private void frmINETRF_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Now.AddMonths(-1);
			BindHeaderCombo();
			Header();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strDOCNO = txtDOCNO.Text;
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + strDOCNO;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				string strSQL = "UPDATE INTRF_TBL SET INTRF_STSFG = '2' WHERE INTRF_DOCNO = '" + strDOCNO + "' ";
				strSQL = strSQL + "DELETE INTRN_TBL WHERE INTRN_DOCCD = 'TRF' AND INTRN_DOCNO = '" + strDOCNO + "' ";
				DB.DBExecute(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				BindHeaderCombo();
				Header();
			}
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string strNextNo = "";
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "SELECT * FROM INTRF_WRK WHERE INTRF_COMPNM = '" + MyProject.Computer.Name + "' AND INTRF_GRLNO = ''";
			if (DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No not set complete!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'INETRF'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("INETRF", "INTRF", ref strNextNo))
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						return;
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
					return;
				}
			}
			strSQL = "EXEC spINETRF ";
			strSQL += "'0', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cmbTRFTY.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID_TO.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtPRQDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtREMRK.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
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
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record saved!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			BindHeaderCombo();
			Header();
		}

		private void dgvDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ClearDetails();
			txtRECID.Text = dgvDetails.CurrentRow.Cells["INTRF_RECID"].Value.ToString();
			txtITMCD.Text = dgvDetails.CurrentRow.Cells["INTRF_ITMCD"].Value.ToString();
			txtGRLNO.Text = dgvDetails.CurrentRow.Cells["INTRF_GRLNO"].Value.ToString();
			try
			{
                String LOC = dgvDetails.CurrentRow.Cells["INTRF_LOCID"].Value.ToString();
                cbLOCID.SelectedValue = LOC;
            }
		catch(Exception ex)
			{

			}

            txtREFNO.Text = dgvDetails.CurrentRow.Cells["INTRF_REFNO"].Value.ToString();
			if (Operators.CompareString(txtGRLNO.Text, string.Empty, false) != 0)
			{
				txtGRLNO.Enabled = false;
				BindDetails();
			}
			else
			{
				txtGRLNO.Enabled = true;
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindHeaderControl();
			RefreshGrid();
		}

		private void BindHeaderControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["INTRF_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["INTRF_DOCDT"].Value.ToString());
			cmbTRFTY.SelectedValue = dgvHEADER.CurrentRow.Cells["INTRF_TRFTY"].Value.ToString();
			cbLOCID_TO.SelectedValue = dgvHEADER.CurrentRow.Cells["INTRF_LOCIDTO"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["INTRF_REMRK"].Value.ToString();
			txtPRQDOCNO.Text = Conversions.ToString(DB.GetColumnValue("DISTINCT INTRF_PRQNO", "INTRF_TBL WITH(NOLOCK)", "INTRF_DOCNO = '" + txtDOCNO.Text + "' "));
			txtDOCNO.Enabled = false;
			cbLOCID_TO.Enabled = false;
			cmbTRFTY.Enabled = false;
			dtpDOCDT.Enabled = false;
			txtPRQDOCNO.Enabled = false;
			txtGRLNO.Enabled = false;
			btnSave.Enabled = false;
			btnREMOVE.Enabled = false;
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void btnADD_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			bool blnFound = false;
			if (txtGRLNO.Text.Length == 0)
			{
				MessageBox.Show("Invalid Batch No!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(cbLOCID.SelectedValue, cbLOCID_TO.SelectedValue, false))
			{
				MessageBox.Show("Cannot transfer from same location!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbLOCID.Select();
				return;
			}
			checked
			{
               
                if (Operators.CompareString(txtPRQDOCNO.Text, string.Empty, false) != 0)
				{
					if (Conversions.ToDouble(txtRECID.Text) == -1.0)
					{
						MessageBox.Show("No select record!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txtGRLNO.Focus();
						return;
					}
					int num = dgvDetails.Rows.Count - 1;
					if (txtGRLNO.Text.Trim() != "" && txtITMCD.Text.Trim() != "") blnFound = true;
					else

                    for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(txtITMCD.Text, dgvDetails.Rows[i].Cells["INTRF_ITMCD"].Value.ToString(), false) == 0)
						{
							blnFound = true;
						}
					}
					if (!blnFound)
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Item Code!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txtGRLNO.Focus();
						return;
					}
					if (numQTY.Value == 0.0)
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity cannot be 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						numQTY.Focus();
						return;
					}
					decimal QTY = Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[2]
					{
						DB.GetColumnValue("ISNULL(INTRF_QTY,0)", "INTRF_WRK WITH(NOLOCK)", "INTRF_RECID = '" + Common.gfValidSQLStr(txtRECID.Text) + "' "),
						2
					}, null, null, null));
					if (numQTY.Value > Convert.ToDouble(QTY))
					{
						if (txtGRLNO.Text.Trim() == "" && txtITMCD.Text.Trim() == "")
						{
							MessageBox.Show("Invalid Quantity!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							numQTY.Focus();
                            return;
                        }
						
					}
					if (numQTY.Value > numLotBal.Value)
					{
						MessageBox.Show("Transfer Quantity cannot more than Lot Balance Quantity!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						numQTY.Focus();
						return;
					}
					if (txtGRLNO.Text.Trim() == "" && txtITMCD.Text.Trim() == "")
					{
						if (!spINETRF_DETAILS("2"))
						{
							return;
						}
					}
					else
					{
                        String strSQL = "INSERT INTRF_WRK (";
                        strSQL += "  INTRF_ITMCD, INTRF_GRLNO, INTRF_LOCID, INTRF_QTY, INTRF_REFNO, INTRF_VOLUMN, INTRF_COMPNM) ";
                        strSQL += "VALUES (";
                        strSQL = strSQL + "'" + txtITMCD.Text + "'," + "'" + txtGRLNO.Text + "'," + "'" + cbLOCID.SelectedValue.ToString() + "'," + "'" +numQTY.Value + "'," + "''," + "'0','" + MyProject.Computer.Name + "')";

                        DB.DBExecute(strSQL);
                       
                       //     return;
                    }	
				}
				else
				{
					if (count == 0)
					{
						string strSQL = "DELETE FROM INTRF_WRK WHERE INTRF_COMPNM = '" + MyProject.Computer.Name + "' ";
						DataTable dt = DB.ExecProc(strSQL);
						count = 1;
					}
					if (numQTY.Value > numLotBal.Value)
					{
						MessageBox.Show("Transfer Quantity cannot more than Lot Balance Quantity!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						numQTY.Focus();
						return;
					}
					if (!spINETRF_DETAILS("1"))
					{
						return;
					}
				}
				txtPRQDOCNO.Enabled = false;
				cbLOCID_TO.Enabled = false;
				cmbTRFTY.Enabled = false;
				dtpDOCDT.Enabled = false;
				RefreshGrid();
				ClearDetails();
			}
		}

		private void frmINETRF_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbLOCID.SelectedIndex == -1)
			{
				return;
			}
			checked
			{
				int num = dgvDetails.RowCount - 1;
				double dblREQQT = default(double);
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dgvDetails.Rows[i].Cells["INTRF_ITMCD"].Value, txtITMCD.Text, false), Operators.CompareObjectEqual(dgvDetails.Rows[i].Cells["INTRF_GRLNO"].Value, "", false))))
					{
						dblREQQT = Conversions.ToDouble(dgvDetails.Rows[i].Cells["INTRF_QTY"].Value);
						txtRECID.Text = Conversions.ToString(dgvDetails.Rows[i].Cells["INTRF_RECID"].Value);
						break;
					}
				}
				numLotBal.Value = Common.gfGetGRLBAL(Conversions.ToString(cbLOCID.SelectedValue), txtGRLNO.Text);
				if (dblREQQT < numLotBal.Value)
				{
					numQTY.Value = dblREQQT;
				}
				else
				{
					numQTY.Value = numLotBal.Value;
				}
				numBALQTY.Value = Conversions.ToDouble(DB.GetColumnValue("INBAL_QTY", "INBAL_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INBAL_LOCID = '", cbLOCID.SelectedValue), "' AND INBAL_ITMCD = '"), Common.gfValidSQLStr(txtITMCD.Text)), "'"))));
				numBALQTY.BackColor = SystemColors.ButtonHighlight;
				numSAFETY.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_SAFETY", "MAITM_TBL", "MAITM_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'"));
				numSAFETY.BackColor = SystemColors.ButtonHighlight;
				numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL", "MAITM_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'"));
				numSTDWGT.BackColor = SystemColors.ButtonHighlight;
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
		}
	}
}
