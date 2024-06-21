using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using DataTable = System.Data.DataTable;
using Label = System.Windows.Forms.Label;

namespace IMS
{
    [DesignerGenerated]
	public class frmQOECQO : Form
	{
		private IContainer components;

		
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
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnADD")]
		private Button _btnADD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDETAILS")]
		private DataGridView _dgvDETAILS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

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
		[AccessedThroughProperty("btnRetrieve")]
		private Button _btnRetrieve;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numPRICE")]
		private NumControl _numPRICE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPrint")]
		private Button _btnPrint;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numMATCOST")]
		private NumControl _numMATCOST;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numFIXCOST")]
		private NumControl _numFIXCOST;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numPCKCOST")]
		private NumControl _numPCKCOST;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numTPTCOST")]
		private NumControl _numTPTCOST;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numVARCOST")]
		private NumControl _numVARCOST;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numCOMM")]
		private NumControl _numCOMM;

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
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

		[field: AccessedThroughProperty("btnREMOVE")]
		internal virtual Button btnREMOVE
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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
				DataGridViewCellMouseEventHandler value3 = dgvDETAILS_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvDETAILS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
					dataGridView.CellMouseDoubleClick -= value3;
				}
				_dgvDETAILS = value;
				dataGridView = _dgvDETAILS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
					dataGridView.CellMouseDoubleClick += value3;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
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

		[field: AccessedThroughProperty("cbCUSID")]
		internal virtual ComboboxControl cbCUSID
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

		[field: AccessedThroughProperty("dtpQUODT")]
		internal virtual DateTimePicker dtpQUODT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnRetrieve
		{
			[CompilerGenerated]
			get
			{
				return _btnRetrieve;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRetrieve_Click;
				Button button = _btnRetrieve;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRetrieve = value;
				button = _btnRetrieve;
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

		internal virtual NumControl numPRICE
		{
			[CompilerGenerated]
			get
			{
				return _numPRICE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numPRICE_TextChanged;
				NumControl numControl = _numPRICE;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numPRICE = value;
				numControl = _numPRICE;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
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

		[field: AccessedThroughProperty("cbHCUSID")]
		internal virtual ComboboxControl cbHCUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkLATEST")]
		internal virtual CheckBox chkLATEST
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

		[field: AccessedThroughProperty("txtQUONO")]
		internal virtual TextBox txtQUONO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCPTNO")]
		internal virtual TextBox txtCPTNO
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

		[field: AccessedThroughProperty("txtMDLCD")]
		internal virtual TextBox txtMDLCD
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

		internal virtual NumControl numMATCOST
		{
			[CompilerGenerated]
			get
			{
				return _numMATCOST;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numMATCOST_TextChanged;
				NumControl numControl = _numMATCOST;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numMATCOST = value;
				numControl = _numMATCOST;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
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

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
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
		Label labelColor = new Label();

		internal virtual NumControl numFIXCOST
		{
			[CompilerGenerated]
			get
			{
				return _numFIXCOST;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numFIXCOST_TextChanged;
				NumControl numControl = _numFIXCOST;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numFIXCOST = value;
				numControl = _numFIXCOST;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		internal virtual NumControl numPCKCOST
		{
			[CompilerGenerated]
			get
			{
				return _numPCKCOST;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numPCKCOST_TextChanged;
				NumControl numControl = _numPCKCOST;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numPCKCOST = value;
				numControl = _numPCKCOST;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		internal virtual NumControl numTPTCOST
		{
			[CompilerGenerated]
			get
			{
				return _numTPTCOST;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numTPTCOST_TextChanged;
				NumControl numControl = _numTPTCOST;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numTPTCOST = value;
				numControl = _numTPTCOST;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		internal virtual NumControl numVARCOST
		{
			[CompilerGenerated]
			get
			{
				return _numVARCOST;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numVARCOST_TextChanged;
				NumControl numControl = _numVARCOST;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numVARCOST = value;
				numControl = _numVARCOST;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual NumControl numCOMM
		{
			[CompilerGenerated]
			get
			{
				return _numCOMM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numCOMM_TextChanged;
				NumControl numControl = _numCOMM;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numCOMM = value;
				numControl = _numCOMM;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("numTOTAL")]
		internal virtual NumControl numTOTAL
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

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numPERCENT")]
		internal virtual NumControl numPERCENT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numPROFIT")]
		internal virtual NumControl numPROFIT
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

		[field: AccessedThroughProperty("cbPACKING")]
		internal virtual ComboboxControl cbPACKING
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}
		ComboboxControl cbColorCost;
		public frmQOECQO()
		{
			base.Load += frmQOECQO_Load;
			base.FormClosing += frmQOECQO_FormClosing;
			base.KeyDown += frmQOECQO_KeyDown;
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
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbHCUSID = new IMS.ComboboxControl();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.chkLATEST = new System.Windows.Forms.CheckBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.Label16 = new System.Windows.Forms.Label();
			this.numPERCENT = new IMS.NumControl();
			this.numPROFIT = new IMS.NumControl();
			this.Label15 = new System.Windows.Forms.Label();
			this.numTOTAL = new IMS.NumControl();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.numCOMM = new IMS.NumControl();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.numTPTCOST = new IMS.NumControl();
			this.numVARCOST = new IMS.NumControl();
			this.numFIXCOST = new IMS.NumControl();
			this.numPCKCOST = new IMS.NumControl();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.cbCUSID = new IMS.ComboboxControl();
            cbCUSID.ComboBox1.SelectedIndexChanged += CbCUSID_SelectedIndexChanged1;

            this.Label9 = new System.Windows.Forms.Label();
			this.dtpQUODT = new System.Windows.Forms.DateTimePicker();
			this.Label8 = new System.Windows.Forms.Label();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dgvDETAILS = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnADD = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.numPRICE = new IMS.NumControl();
			this.btnRetrieve = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtQUONO = new System.Windows.Forms.TextBox();
			this.txtCPTNO = new System.Windows.Forms.TextBox();
			this.txtREVNO = new System.Windows.Forms.TextBox();
			this.txtMDLCD = new System.Windows.Forms.TextBox();
			this.numMATCOST = new IMS.NumControl();
			this.cbPACKING = new IMS.ComboboxControl();
            cbColorCost=new IMS.ComboboxControl();

            this.Panel2.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel6.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).BeginInit();
			this.TableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(5, 3);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1998, 902);
			this.Panel2.TabIndex = 14;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 3;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbHCUSID, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.dgvHEADER, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.chkLATEST, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label6, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel6, 0, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(25, 23);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(876, 674);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbHCUSID.BlankValue = null;
			this.cbHCUSID.ComboboxWidth = 170;
			this.cbHCUSID.DataTable = null;
			this.cbHCUSID.DisplayMember = null;
			this.cbHCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHCUSID.HasBlankValue = true;
			this.cbHCUSID.Location = new System.Drawing.Point(74, 2);
			this.cbHCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbHCUSID.Name = "cbHCUSID";
			this.cbHCUSID.SelectedIndex = -1;
			this.cbHCUSID.SelectedItem = null;
			this.cbHCUSID.SelectedValue = null;
			this.cbHCUSID.Size = new System.Drawing.Size(412, 33);
			this.cbHCUSID.TabIndex = 49;
			this.cbHCUSID.TextMultiline = true;
			this.cbHCUSID.ValueMember = null;
			this.cbHCUSID.WhereClause = null;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel2.SetColumnSpan(this.dgvHEADER, 3);
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(3, 97);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(870, 575);
			this.dgvHEADER.TabIndex = 5;
			this.chkLATEST.AutoSize = true;
			this.chkLATEST.Checked = true;
			this.chkLATEST.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkLATEST.Dock = System.Windows.Forms.DockStyle.Left;
			this.chkLATEST.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkLATEST.Location = new System.Drawing.Point(492, 3);
			this.chkLATEST.Name = "chkLATEST";
			this.chkLATEST.Size = new System.Drawing.Size(63, 31);
			this.chkLATEST.TabIndex = 52;
			this.chkLATEST.Text = "Latest";
			this.chkLATEST.UseVisualStyleBackColor = true;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 10);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(65, 16);
			this.Label6.TabIndex = 8;
			this.Label6.Text = "Customer";
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 3;
			this.TableLayoutPanel2.SetColumnSpan(this.TableLayoutPanel6, 3);
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(3, 40);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(378, 52);
			this.TableLayoutPanel6.TabIndex = 9;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(3, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 48);
			this.btnSEARCH.TabIndex = 5;
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
			this.btnClose.Size = new System.Drawing.Size(120, 48);
			this.btnClose.TabIndex = 8;
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
			this.btnNew.Size = new System.Drawing.Size(120, 48);
			this.btnNew.TabIndex = 6;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(5, 3);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1998, 902);
			this.Panel1.TabIndex = 16;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 7;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.Label16, 6, 11);
			this.TableLayoutPanel3.Controls.Add(this.numPERCENT, 5, 11);
			this.TableLayoutPanel3.Controls.Add(this.numPROFIT, 4, 11);
			this.TableLayoutPanel3.Controls.Add(this.Label15, 3, 11);
			this.TableLayoutPanel3.Controls.Add(this.numTOTAL, 4, 10);
			this.TableLayoutPanel3.Controls.Add(this.Label14, 0, 12);
			this.TableLayoutPanel3.Controls.Add(this.Label13, 0, 11);
			this.TableLayoutPanel3.Controls.Add(this.numCOMM, 1, 11);
			this.TableLayoutPanel3.Controls.Add(this.Label12, 3, 9);
			this.TableLayoutPanel3.Controls.Add(this.Label11, 0, 10);
			this.TableLayoutPanel3.Controls.Add(this.numTPTCOST, 4, 9);
			this.TableLayoutPanel3.Controls.Add(this.numVARCOST, 1, 10);
			this.TableLayoutPanel3.Controls.Add(this.numFIXCOST, 4, 8);
			this.TableLayoutPanel3.Controls.Add(this.numPCKCOST, 1, 9);
			this.TableLayoutPanel3.Controls.Add(this.Label10, 3, 8);
            this.TableLayoutPanel3.Controls.Add(this.labelColor, 0, 8);
			
            this.TableLayoutPanel3.Controls.Add(this.Label7, 0, 9);
			this.TableLayoutPanel3.Controls.Add(this.Label4, 0, 7);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 3, 7);
			this.TableLayoutPanel3.Controls.Add(this.Label5, 3, 10);
			this.TableLayoutPanel3.Controls.Add(this.cbCUSID, 1, 3);
			this.TableLayoutPanel3.Controls.Add(this.Label9, 0, 6);
			this.TableLayoutPanel3.Controls.Add(this.dtpQUODT, 1, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label8, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.TableLayoutPanel4, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.dgvDETAILS, 0, 5);
			this.TableLayoutPanel3.Controls.Add(this.TableLayoutPanel1, 0, 13);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.numPRICE, 1, 12);
			this.TableLayoutPanel3.Controls.Add(this.btnRetrieve, 4, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label3, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.txtQUONO, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.txtCPTNO, 1, 6);
			this.TableLayoutPanel3.Controls.Add(this.txtREVNO, 4, 6);
			this.TableLayoutPanel3.Controls.Add(this.txtMDLCD, 3, 6);
			this.TableLayoutPanel3.Controls.Add(this.numMATCOST, 4, 7);
            this.TableLayoutPanel3.Controls.Add(this.cbPACKING, 1, 7);
            this.TableLayoutPanel3.Controls.Add(this.cbColorCost, 1, 8);

            this.TableLayoutPanel3.Location = new System.Drawing.Point(9, 8);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 13;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(1698, 670);
			this.TableLayoutPanel3.TabIndex = 1;
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(892, 589);
			this.Label16.Name = "Label16";
			this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label16.Size = new System.Drawing.Size(20, 16);
			this.Label16.TabIndex = 95;
			this.Label16.Text = "%";
			this.numPERCENT.AllowNegative = false;
			this.numPERCENT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPERCENT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPERCENT.DataChanged = false;
			this.numPERCENT.Location = new System.Drawing.Point(755, 586);
			this.numPERCENT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPERCENT.Name = "numPERCENT";
			this.numPERCENT.NumberFormat = "8.2";
			this.numPERCENT.ReadOnly = true;
			this.numPERCENT.Size = new System.Drawing.Size(131, 22);
			this.numPERCENT.TabIndex = 94;
			this.numPERCENT.TabStop = false;
			this.numPERCENT.Text = "0.00";
			this.numPERCENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPERCENT.ThousandSeperator = false;
			this.numPERCENT.Value = 0.0;
			this.numPROFIT.AllowNegative = false;
			this.numPROFIT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPROFIT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPROFIT.DataChanged = false;
			this.numPROFIT.Location = new System.Drawing.Point(618, 586);
			this.numPROFIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPROFIT.Name = "numPROFIT";
			this.numPROFIT.NumberFormat = "8.2";
			this.numPROFIT.ReadOnly = true;
			this.numPROFIT.Size = new System.Drawing.Size(131, 22);
			this.numPROFIT.TabIndex = 93;
			this.numPROFIT.TabStop = false;
			this.numPROFIT.Text = "0.00";
			this.numPROFIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPROFIT.ThousandSeperator = false;
			this.numPROFIT.Value = 0.0;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(517, 589);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label15.Size = new System.Drawing.Size(38, 16);
			this.Label15.TabIndex = 92;
			this.Label15.Text = "Profit";
			this.numTOTAL.AllowNegative = false;
			this.numTOTAL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTOTAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTOTAL.DataChanged = false;
			this.numTOTAL.Location = new System.Drawing.Point(618, 560);
			this.numTOTAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTOTAL.Name = "numTOTAL";
			this.numTOTAL.NumberFormat = "8.2";
			this.numTOTAL.ReadOnly = true;
			this.numTOTAL.Size = new System.Drawing.Size(131, 22);
			this.numTOTAL.TabIndex = 99;
			this.numTOTAL.TabStop = false;
			this.numTOTAL.Text = "0.00";
			this.numTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTOTAL.ThousandSeperator = false;
			this.numTOTAL.Value = 0.0;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(3, 589);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(83, 16);
			this.Label14.TabIndex = 89;
			this.Label14.Text = "Selling Price";
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 563);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(82, 16);
			this.Label13.TabIndex = 88;
			this.Label13.Text = "Commission";
			this.numCOMM.AllowNegative = false;
			this.numCOMM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numCOMM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numCOMM.DataChanged = false;
			this.numCOMM.Location = new System.Drawing.Point(122, 560);
			this.numCOMM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numCOMM.Name = "numCOMM";
			this.numCOMM.NumberFormat = "8.2";
			this.numCOMM.Size = new System.Drawing.Size(131, 22);
			this.numCOMM.TabIndex = 10;
			this.numCOMM.Text = "0.00";
			this.numCOMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numCOMM.ThousandSeperator = false;
			this.numCOMM.Value = 0.0;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(517, 537);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(95, 16);
			this.Label12.TabIndex = 86;
			this.Label12.Text = "Transportation";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 537);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(89, 16);
			this.Label11.TabIndex = 85;
			this.Label11.Text = "Variable Cost";
			this.numTPTCOST.AllowNegative = false;
			this.numTPTCOST.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTPTCOST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTPTCOST.DataChanged = false;
			this.numTPTCOST.Location = new System.Drawing.Point(618, 534);
			this.numTPTCOST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTPTCOST.Name = "numTPTCOST";
			this.numTPTCOST.NumberFormat = "8.2";
			this.numTPTCOST.Size = new System.Drawing.Size(131, 22);
			this.numTPTCOST.TabIndex = 9;
			this.numTPTCOST.Text = "0.00";
			this.numTPTCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTPTCOST.ThousandSeperator = false;
			this.numTPTCOST.Value = 0.0;
			this.numVARCOST.AllowNegative = false;
			this.numVARCOST.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numVARCOST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numVARCOST.DataChanged = false;
			this.numVARCOST.Location = new System.Drawing.Point(122, 534);
			this.numVARCOST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numVARCOST.Name = "numVARCOST";
			this.numVARCOST.NumberFormat = "8.2";
			this.numVARCOST.Size = new System.Drawing.Size(131, 22);
			this.numVARCOST.TabIndex = 8;
			this.numVARCOST.Text = "0.00";
			this.numVARCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numVARCOST.ThousandSeperator = false;
			this.numVARCOST.Value = 0.0;
			this.numFIXCOST.AllowNegative = false;
			this.numFIXCOST.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numFIXCOST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numFIXCOST.DataChanged = false;
			this.numFIXCOST.Location = new System.Drawing.Point(618, 508);
			this.numFIXCOST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numFIXCOST.Name = "numFIXCOST";
			this.numFIXCOST.NumberFormat = "8.2";
			this.numFIXCOST.Size = new System.Drawing.Size(131, 22);
			this.numFIXCOST.TabIndex = 7;
			this.numFIXCOST.Text = "0.00";
			this.numFIXCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFIXCOST.ThousandSeperator = false;
			this.numFIXCOST.Value = 0.0;
			this.numPCKCOST.AllowNegative = false;
			this.numPCKCOST.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPCKCOST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPCKCOST.DataChanged = false;
			this.numPCKCOST.Location = new System.Drawing.Point(122, 508);
			this.numPCKCOST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPCKCOST.Name = "numPCKCOST";
			this.numPCKCOST.NumberFormat = "8.2";
			this.numPCKCOST.Size = new System.Drawing.Size(131, 22);
			this.numPCKCOST.TabIndex = 6;
			this.numPCKCOST.Text = "0.00";
			this.numPCKCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPCKCOST.ThousandSeperator = false;
			this.numPCKCOST.Value = 0.0;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(517, 511);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(71, 16);
			this.Label10.TabIndex = 80;
			this.Label10.Text = "Fixed Cost";
            this.labelColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelColor.AutoSize = true;
            this.labelColor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelColor.Location = new System.Drawing.Point(3, 511);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(87, 16);
            this.labelColor.TabIndex = 79;
            this.labelColor.Text = "Color Cost";
          
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 511);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(87, 16);
			this.Label7.TabIndex = 79;
			this.Label7.Text = "Packing Cost";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 483);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(57, 16);
			this.Label4.TabIndex = 78;
			this.Label4.Text = "Packing";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(517, 483);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(86, 16);
			this.Label1.TabIndex = 76;
			this.Label1.Text = "Material Cost";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(517, 563);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label5.Size = new System.Drawing.Size(69, 16);
			this.Label5.TabIndex = 62;
			this.Label5.Text = "Total Cost";
			this.cbCUSID.BlankValue = null;
			this.TableLayoutPanel3.SetColumnSpan(this.cbCUSID, 3);
			this.cbCUSID.ComboboxWidth = 170;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = false;
			this.cbCUSID.Location = new System.Drawing.Point(122, 114);
			this.cbCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(412, 25);
			this.cbCUSID.TabIndex = 2;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
       
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 456);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(113, 16);
			this.Label9.TabIndex = 54;
			this.Label9.Text = "Customer Part No";
			this.dtpQUODT.CustomFormat = "dd/MM/yyyy";
			this.dtpQUODT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpQUODT.Location = new System.Drawing.Point(122, 88);
			this.dtpQUODT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpQUODT.Name = "dtpQUODT";
			this.dtpQUODT.Size = new System.Drawing.Size(131, 22);
			this.dtpQUODT.TabIndex = 1;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 91);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(97, 16);
			this.Label8.TabIndex = 52;
			this.Label8.Text = "Quotation Date";
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel3.SetColumnSpan(this.TableLayoutPanel4, 3);
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPrint, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(508, 54);
			this.TableLayoutPanel4.TabIndex = 15;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(3, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 48);
			this.btnSAVE.TabIndex = 17;
			this.btnSAVE.Text = "Update";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(258, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 16;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Image = IMS.My.Resources.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(385, 2);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(120, 50);
			this.btnPrint.TabIndex = 21;
			this.btnPrint.Text = "Print";
			this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrint.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(130, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.dgvDETAILS.AllowUserToAddRows = false;
			this.dgvDETAILS.AllowUserToDeleteRows = false;
			this.dgvDETAILS.AllowUserToResizeRows = false;
			this.dgvDETAILS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvDETAILS, 7);
			this.dgvDETAILS.EnableHeadersVisualStyles = false;
			this.dgvDETAILS.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvDETAILS.Location = new System.Drawing.Point(4, 143);
			this.dgvDETAILS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvDETAILS.MultiSelect = false;
			this.dgvDETAILS.Name = "dgvDETAILS";
			this.dgvDETAILS.RowHeadersVisible = false;
			this.dgvDETAILS.RowHeadersWidth = 10;
			this.dgvDETAILS.RowTemplate.Height = 24;
			this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDETAILS.Size = new System.Drawing.Size(1690, 306);
			this.dgvDETAILS.TabIndex = 3;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel3.SetColumnSpan(this.TableLayoutPanel1, 3);
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnADD, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 613);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel1.TabIndex = 12;
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
			this.btnCancel.TabIndex = 14;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnADD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnADD.Image = IMS.My.Resources.Resources.Save;
			this.btnADD.Location = new System.Drawing.Point(3, 2);
			this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(120, 48);
			this.btnADD.TabIndex = 12;
			this.btnADD.Text = "Edit";
			this.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnADD.UseVisualStyleBackColor = false;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(129, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 48);
			this.btnREMOVE.TabIndex = 13;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 118);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(65, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Customer";
			this.numPRICE.AllowNegative = false;
			this.numPRICE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPRICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPRICE.DataChanged = false;
			this.numPRICE.Location = new System.Drawing.Point(122, 586);
			this.numPRICE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPRICE.Name = "numPRICE";
			this.numPRICE.NumberFormat = "8.2";
			this.numPRICE.Size = new System.Drawing.Size(131, 22);
			this.numPRICE.TabIndex = 11;
			this.numPRICE.Text = "0.00";
			this.numPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPRICE.ThousandSeperator = false;
			this.numPRICE.Value = 0.0;
			this.btnRetrieve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRetrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnRetrieve.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRetrieve.Location = new System.Drawing.Point(619, 88);
			this.btnRetrieve.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnRetrieve.Name = "btnRetrieve";
			this.TableLayoutPanel3.SetRowSpan(this.btnRetrieve, 2);
			this.btnRetrieve.Size = new System.Drawing.Size(120, 50);
			this.btnRetrieve.TabIndex = 57;
			this.btnRetrieve.Text = "Retrieve";
			this.btnRetrieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRetrieve.UseVisualStyleBackColor = false;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 65);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(86, 16);
			this.Label3.TabIndex = 71;
			this.Label3.Text = "Quotation No";
			this.TableLayoutPanel3.SetColumnSpan(this.txtQUONO, 2);
			this.txtQUONO.Location = new System.Drawing.Point(122, 62);
			this.txtQUONO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtQUONO.Name = "txtQUONO";
			this.txtQUONO.Size = new System.Drawing.Size(244, 22);
			this.txtQUONO.TabIndex = 0;
			this.TableLayoutPanel3.SetColumnSpan(this.txtCPTNO, 2);
			this.txtCPTNO.Location = new System.Drawing.Point(122, 453);
			this.txtCPTNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCPTNO.Name = "txtCPTNO";
			this.txtCPTNO.ReadOnly = true;
			this.txtCPTNO.Size = new System.Drawing.Size(244, 22);
			this.txtCPTNO.TabIndex = 73;
			this.txtCPTNO.TabStop = false;
			this.txtREVNO.Location = new System.Drawing.Point(618, 453);
			this.txtREVNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREVNO.Name = "txtREVNO";
			this.txtREVNO.ReadOnly = true;
			this.txtREVNO.Size = new System.Drawing.Size(40, 22);
			this.txtREVNO.TabIndex = 75;
			this.txtREVNO.Visible = false;
			this.txtMDLCD.Location = new System.Drawing.Point(517, 453);
			this.txtMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMDLCD.Name = "txtMDLCD";
			this.txtMDLCD.ReadOnly = true;
			this.txtMDLCD.Size = new System.Drawing.Size(82, 22);
			this.txtMDLCD.TabIndex = 74;
			this.txtMDLCD.Visible = false;
			this.numMATCOST.AllowNegative = false;
			this.numMATCOST.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numMATCOST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numMATCOST.DataChanged = false;
			this.numMATCOST.Location = new System.Drawing.Point(618, 480);
			this.numMATCOST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numMATCOST.Name = "numMATCOST";
			this.numMATCOST.NumberFormat = "8.2";
			this.numMATCOST.Size = new System.Drawing.Size(131, 22);
			this.numMATCOST.TabIndex = 5;
			this.numMATCOST.Text = "0.00";
			this.numMATCOST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numMATCOST.ThousandSeperator = false;
			this.numMATCOST.Value = 0.0;
			this.cbPACKING.BlankValue = null;
			this.TableLayoutPanel3.SetColumnSpan(this.cbPACKING, 2);
			this.cbPACKING.ComboboxWidth = 170;
			this.cbPACKING.DataTable = null;
			this.cbPACKING.DisplayMember = null;
			this.cbPACKING.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPACKING.HasBlankValue = false;
			this.cbPACKING.Location = new System.Drawing.Point(123, 479);
			this.cbPACKING.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbPACKING.Name = "cbPACKING";
			this.cbPACKING.SelectedIndex = -1;
			this.cbPACKING.SelectedItem = null;
			this.cbPACKING.SelectedValue = null;
			this.cbPACKING.Size = new System.Drawing.Size(322, 25);
			this.cbPACKING.TabIndex = 100;
			this.cbPACKING.TextMultiline = true;
			this.cbPACKING.ValueMember = null;
			this.cbPACKING.WhereClause = null;

            this.cbColorCost.BlankValue = null;
            this.TableLayoutPanel3.SetColumnSpan(this.cbColorCost, 2);
            this.cbColorCost.ComboboxWidth = 170;
            this.cbColorCost.DataTable = null;
            this.cbColorCost.DisplayMember = null;
            this.cbColorCost.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColorCost.HasBlankValue = false;
            this.cbColorCost.Location = new System.Drawing.Point(1200, 479);
            this.cbColorCost.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbColorCost.Name = "cbColorCost";
            this.cbColorCost.SelectedIndex = -1;
            this.cbColorCost.SelectedItem = null;
            this.cbColorCost.SelectedValue = null;
            this.cbColorCost.Size = new System.Drawing.Size(322, 25);
            this.cbColorCost.TabIndex = 100;
            this.cbColorCost.TextMultiline = true;
            this.cbColorCost.ValueMember = null;
            this.cbColorCost.WhereClause = null;

            base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1717, 748);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmQOECQO";
			base.Tag = "QOECQO";
			this.Text = "Customer Quotation";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).EndInit();
			this.TableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}
		string sQuoNo = "";

        private void CbCUSID_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (txtQUONO.Text.Trim()=="")
            {
				if(cbCUSID.SelectedValue!=null)
				{ 	
				cbHCUSID.SelectedValue = cbCUSID.SelectedValue;
				chkLATEST.Checked = true;
                    string strSQL = "EXEC spQOCQO ";
                    strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbHCUSID.SelectedValue), "', ")));
                    strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Interaction.IIf(chkLATEST.Checked, 1, 0)));
                    DataTable dt = DB.ExecProc(strSQL);
					if(dt.Rows.Count>0)
					{
                        sQuoNo = dt.Rows[0][4].ToString();
						txtQUONO.Text = sQuoNo;
                        dtpQUODT.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dt.Rows[0]["QOcQO_QUODT"]));

                    }
                }
            }
        }

      
        private void frmQOECQO_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
			Panel2.Visible = true;
			Panel1.Visible = false;
           
        }

      
        private void BindComboBox()
		{
			cbHCUSID.DataTable = "MACUS_TBL WITH (NOLOCK)";
			cbHCUSID.ValueMember = "MACUS_CUSID";
			cbHCUSID.DisplayMember = "MACUS_SHORT";
			cbHCUSID.LoadData();
			cbCUSID.DataTable = "MACUS_TBL WITH (NOLOCK)";
			cbCUSID.ValueMember = "MACUS_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			cbCUSID.LoadData();
			cbPACKING.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbPACKING.WhereClause = "MAITM_GRPCD = 'PACKING'";
			cbPACKING.ValueMember = "MAITM_ITMCD";
			cbPACKING.DisplayMember = "MAITM_ITMCD";
			cbPACKING.LoadData();
            cbPACKING.SelectedIndexChanged += CbPACKING_SelectedIndexChanged;
       
			List<String> list = new List<string>();
			foreach (ColorCost cost in G.listColorCost)
			{
				list.Add(cost.Color);


			}

            cbColorCost.ComboBox1.DataSource = list;
            cbColorCost.SelectedIndexChanged += CbColorCost_SelectedIndexChanged;
        }

        private void CbColorCost_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbColorCost.SelectedValue == null) return;
            int index = G.listColorCost.FindIndex(a => a.Color.Contains(Conversions.ToString(cbColorCost.SelectedValue)));
            if (index > -1)
            {
               // numCOMM.Value = G.listColorCost[index].CommissionCost;
                numFIXCOST.Value = G.listColorCost[index].FixedCost;
                numTPTCOST.Value = G.listColorCost[index].Transportation;
                numVARCOST.Value = G.listColorCost[index].VariableCost;
            }
			else
			{
                numFIXCOST.Value = 0;
                numTPTCOST.Value = 0;
                numVARCOST.Value =0;
            }	
        }

        private void CbPACKING_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (cbPACKING.SelectedValue == null)
			{
				numPCKCOST.Value = 0;

                return;
			}
			int index = G.listPackingCost.FindIndex(a => a.codePacking.Contains(Conversions.ToString(cbPACKING.SelectedValue)));
       if(index>-1)
			{
				numPCKCOST.Value = G.listPackingCost[index].PackCost;
			
            }
	   else
                numPCKCOST.Value = 0;
        }

        private void Header()
		{
			int i = 0;
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spQOCQO ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbHCUSID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Interaction.IIf(chkLATEST.Checked, 1, 0)));
			DataTable dt = DB.ExecProc(strSQL);
         //   DataTable dt = DB.GetTable("*", ""TDDMRPdb"", "", "QOCQO_QUONO");

            checked
            {
				if (dt.Rows.Count > 0)
				{
					dgvHEADER.ClearSelection();
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quotation No");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.ClearSelection();
					dataGridView.Refresh();
					dataGridView = null;
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void btnADD_Click(object sender, EventArgs e)
		{
            IsNotsave = true;
            btnADD.Enabled = false;
            btnSAVE.Enabled = true;
            string strSQL = "EXEC spQOCQO_UPD '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + txtQUONO.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtMDLCD.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(txtREVNO.Text)) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPACKING.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(numMATCOST.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numPCKCOST.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numFIXCOST.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numVARCOST.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numTPTCOST.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numCOMM.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numPRICE.Value) + " ";
			DB.ExecProc(strSQL);
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			ClearDetails(false);
			RefreshGridDetails();
		}

		private void dgvDETAILS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dgvDETAILS.Rows.Count != 0 && dgvDETAILS.CurrentCell.ColumnIndex == 0)
			{
				if (Operators.ConditionalCompareObjectEqual(dgvDETAILS.CurrentRow.Cells["QOCQO_CHK"].Value, 0, false))
				{
					dgvDETAILS.CurrentRow.Cells["QOCQO_CHK"].Value = 1;
				}
				else
				{
					dgvDETAILS.CurrentRow.Cells["QOCQO_CHK"].Value = 0;
				}
				string strSQL = "EXEC spQOCQO_CHK '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
				strSQL = strSQL + "'" + txtQUONO.Text + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", dgvDETAILS.CurrentRow.Cells["QOCQO_MDLCD"].Value), "', ")));
				strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["QOCQO_REVNO"].Value))) + ", ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, dgvDETAILS.CurrentRow.Cells["QOCQO_CHK"].Value));
				DB.ExecProc(strSQL);
			}
		}
		bool IsNotsave = false;
		private void dgvDETAILS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
	

            txtCPTNO.Text = Conversions.ToString(dgvDETAILS.CurrentRow.Cells["QOCQO_CPTNO"].Value);
			txtMDLCD.Text = Conversions.ToString(dgvDETAILS.CurrentRow.Cells["QOCQO_MDLCD"].Value);
			txtREVNO.Text = Conversions.ToString(dgvDETAILS.CurrentRow.Cells["QOCQO_REVNO"].Value);
			cbPACKING.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["QOCQO_PACKING"].Value);
			numMATCOST.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOCQO_MATCOST"].Value);
			numPCKCOST.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOCQO_PCKCOST"].Value);
			numFIXCOST.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOCQO_FIXCOST"].Value);
			numVARCOST.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOCQO_VARCOST"].Value);
			numTPTCOST.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOCQO_TPTCOST"].Value);
			numCOMM.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOCQO_COMM"].Value);
			numPRICE.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOCQO_PRICE"].Value);
			btnADD.Enabled = true;
			CalcTotal();
			CalcPercentage();
		}

		private void RefreshGridDetails()
		{
			int i = 0;
			double dblTotal = 0.0;
			dgvDETAILS.DataSource = null;
			string strSQL = "SELECT QOCQO_CHK, QOCQO_MDLCD, QOCQO_REVNO, QOCQO_CPTNO, QOCQO_CPTNM, ";
			strSQL += "QOCQO_PACKING, QOCQO_MATCOST, QOCQO_PCKCOST, QOCQO_FIXCOST, ";
			strSQL += "QOCQO_VARCOST, QOCQO_TPTCOST, QOCQO_COMM, QOCQO_PRICE, ";
			strSQL += "QOCQO_TOTAL, QOCQO_PROFIT, QOCQO_RTNRT ";
			strSQL = strSQL + "FROM QOCQO_WRK WHERE QOCQO_PRNID = '" + MyProject.Computer.Name + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No data found!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (dt.Rows.Count > 0)
				{
					dgvDETAILS.ClearSelection();
					DataGridView dataGridView = dgvDETAILS;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 30;
					dataGridView.Columns[i].HeaderText = "";
					dataGridView.Columns[i].ReadOnly = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Part");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Description");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Material Cost");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing Cost");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Fixed Cost");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Variable Cost");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Transportation");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Commission");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Selling Price");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Profit");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Return Rate");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.XRate);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtQUONO.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["QOCQO_QUONO"].Value);
			dtpQUODT.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["QOcQO_QUODT"].Value));
			cbCUSID.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["QOCQO_CUSID"].Value);
			btnPrint.Enabled = true;
			GenerateWorkFile();
			RefreshGridDetails();
            btnADD.Enabled = false;
            btnSAVE.Enabled = false;
            Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}
			try
			{
				string strSQL = "DELETE QOCQO_TBL ";
				strSQL = strSQL + "WHERE QOCQO_QUONO = '" + Common.gfValidSQLStr(txtQUONO.Text) + "' ";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message + "\r\nUnable to save company information! Please contact your software vendor.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
				return;
			}
			finally
			{
				cmd = null;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			ClearDetails(true);
			Header();
		}
		//CusQuo
		private void btnBack_Click(object sender, EventArgs e)
		{
            if (IsNew)
            {
                IsNew = false;
                btnREMOVE.Enabled = true;
                btnPrint.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = true;
                btnADD.Enabled = true;
                dgvDETAILS.Enabled = true;
                btnSAVE.Text = "Update";
                this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
            }
            if (IsNotsave)
			{
                if (MessageBox.Show("Do you want to save changes to the Quote " + txtQUONO.Text + "? ", "Save Quotation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnSAVE.PerformClick();
                    return;
                }
            }	
			ClearDetails(true);
			Header();
		}

		private void ClearDetails(bool blnALL)
		{
			if (blnALL)
			{
				dgvDETAILS.DataSource = null;
				dtpQUODT.Value = DateTime.Now;
				cbCUSID.SelectedIndex = -1;
				dtpQUODT.Enabled = true;
				cbCUSID.Enabled = true;
			}
			txtCPTNO.Text = string.Empty;
			txtMDLCD.Text = string.Empty;
			txtREVNO.Text = string.Empty;
			numMATCOST.Value = 0.0;
			numPCKCOST.Value = 0.0;
			numFIXCOST.Value = 0.0;
			numVARCOST.Value = 0.0;
			numTPTCOST.Value = 0.0;
			numCOMM.Value = 0.0;
			numTOTAL.Value = 0.0;
			numPRICE.Value = 0.0;
			numPROFIT.Value = 0.0;
			numPERCENT.Value = 0.0;
		}
		String nameQO = "";

        private void btnNew_Click(object sender, EventArgs e)
        {
			IsNew = true;
			DateTime dtNow = DateTime.Now;
			 nameQO = "QO" + dtNow.ToString("yyMM");
		DataTable dt=	DB.GetTable("QOCQO_QUONO", "QOCQO_TBL", "", "QOCQO_QUODT");//[]QOCQO_WRK
            List<string> list = new List<string>();
            List<string> listField=new List<string>();
            if (dt.Rows.Count > 0 )
            {
                list = dt.Rows.OfType<DataRow>().Select(dr => (string)dr["QOCQO_QUONO"]).ToList();
           listField = list.Where(a=>a.Contains( nameQO)).ToList();
				if(listField.Count==0)
				{
					nameQO += "-001";
				}	
				else
				{
					int numQO =Convert.ToInt32( listField[0].Split('-')[1])+1;
					String sQO=numQO+"";
					if (sQO.Length < 2) sQO = "00" + sQO;
                    else if(sQO.Length < 3) sQO = "0" + sQO;

                    nameQO +="-" +sQO;
                }	
            }
			else
			{
                nameQO += "-001";
            }
			txtQUONO.Enabled = false;

           // 
            this.btnSAVE.Text = "New";
			btnREMOVE.Enabled = false;
			btnPrint.Enabled = false;
			btnCancel.Enabled = false;
			btnDelete.Enabled = false;
			btnADD.Enabled = false;
			dgvDETAILS.Enabled = false;
		
            ClearDetails(true);
			btnPrint.Enabled = false;
			Panel1.Visible = true;
			Panel2.Visible = false;
            this.btnSAVE.Image = IMS.My.Resources.Resources._New;

        }

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			
			Header();
			
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
            if (IsNew)
            {
                IsNew = false;
                btnREMOVE.Enabled = true;
                btnPrint.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = true;
                btnADD.Enabled = true;
                dgvDETAILS.Enabled = true;
                btnSAVE.Text = "Update";
                this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
            }
            if (IsNotsave)
            {

                if (MessageBox.Show("Do you want to save changes to the Quote " + txtQUONO.Text + "? ", "Save Quotation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnSAVE.PerformClick();
                    return;
                }
            }
            Close();
		}

		private void frmQOECQO_FormClosing(object sender, FormClosingEventArgs e)
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

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails(false);
		}
		bool IsNew = false;
		private void btnRetrieve_Click(object sender, EventArgs e)
		{
            if (IsNotsave)
            {
                if (MessageBox.Show("Do you want to save changes to the Quote " +txtQUONO.Text+"? ", "Save Quotation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnSAVE.PerformClick();
                    return;
                }
            }
            if (IsNew)
			{
                btnSAVE.Enabled = true;
            }
			
            GenerateWorkFile();
			RefreshGridDetails();
            if (IsNew)
            {
                txtQUONO.Text = nameQO;
            }
        }

		private void GenerateWorkFile()
		{
			string strSQL = "EXEC spQOECQO_WRK '" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtQUONO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpQUODT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
			DB.ExecProc(strSQL);
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			if(IsNew)
			{
               if( txtQUONO.Text == sQuoNo)
				{
					MessageBox.Show("Please create another order code");
					return;
				}	
            }	
            btnSAVE.Enabled = false;
            IsNotsave = false;
            OleDbCommand cmd = new OleDbCommand();
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'QOECQO'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtQUONO.Enabled = false;
				if (Operators.CompareString(txtQUONO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("QOECQO", "QUONO", ref strNextNo))
					{
						MessageBox.Show("Document No cannot blank! Please check document number control.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtQUONO.Select();
						return;
					}
					txtQUONO.Text = strNextNo;
				}
			}
			else
			{
				//txtQUONO.Enabled = true;
				if (Operators.CompareString(txtQUONO.Text.Trim(), "", false) == 0)
				{
					MessageBox.Show("Document No cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					txtQUONO.Select();
					return;
				}
			}
			strSQL = "EXEC spQOECQO ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtQUONO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpQUODT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "', ";
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
				ProjectData.ClearProjectError();
				return;
			}
            if (IsNew)
            {
                IsNew = false;
                btnREMOVE.Enabled = true;
                btnPrint.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = true;
                btnADD.Enabled = true;
                dgvDETAILS.Enabled = true;
                btnSAVE.Text = "Update";
                this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
            }
            MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			btnPrint.Enabled = true;
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "QUOTATION";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptQOLCQO.rpt";
			frmRPT.Params = "@COMPNM=" + MyProject.Computer.Name + ",@QUONO=" + Common.gfValidSQLStr(txtQUONO.Text);
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='QUOTATION',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS + ",XRTDS=" + PublicVar.gintXRTDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void CalcTotal()
		{
			numTOTAL.Value = numMATCOST.Value + numPCKCOST.Value + numFIXCOST.Value + numVARCOST.Value + numTPTCOST.Value + numCOMM.Value;
		}

		private void CalcPercentage()
		{
			if (numPRICE.Value > 0.0)
			{
				numPROFIT.Value = numPRICE.Value - numTOTAL.Value;
				numPERCENT.Value = Math.Round(numPROFIT.Value / numPRICE.Value * 100.0, 2);
			}
			else
			{
				numPROFIT.Value = 0.0;
				numPERCENT.Value = 0.0;
			}
		}

		private void numMATCOST_TextChanged(object sender, EventArgs e)
		{
			CalcTotal();
			CalcPercentage();
		}

		private void numPCKCOST_TextChanged(object sender, EventArgs e)
		{
			CalcTotal();
			CalcPercentage();
		}

		private void numFIXCOST_TextChanged(object sender, EventArgs e)
		{
			CalcTotal();
			CalcPercentage();
		}

		private void numVARCOST_TextChanged(object sender, EventArgs e)
		{
			CalcTotal();
			CalcPercentage();
		}

		private void numTPTCOST_TextChanged(object sender, EventArgs e)
		{
			CalcTotal();
			CalcPercentage();
		}

		private void numCOMM_TextChanged(object sender, EventArgs e)
		{
			CalcTotal();
			CalcPercentage();
		}

		private void numPRICE_TextChanged(object sender, EventArgs e)
		{
			CalcPercentage();
		}

		private void frmQOECQO_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
