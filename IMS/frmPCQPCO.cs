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
	public class frmPCQPCO : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvPO")]
		private DataGridView _dgvPO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRetrieve")]
		private Button _btnRetrieve;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDetails")]
		private DataGridView _dgvDetails;

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
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

		internal virtual DataGridView dgvPO
		{
			[CompilerGenerated]
			get
			{
				return _dgvPO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = dgvPO_CellDoubleClick;
				DataGridView dataGridView = _dgvPO;
				if (dataGridView != null)
				{
					dataGridView.CellDoubleClick -= value2;
				}
				_dgvPO = value;
				dataGridView = _dgvPO;
				if (dataGridView != null)
				{
					dataGridView.CellDoubleClick += value2;
				}
			}
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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

		[field: AccessedThroughProperty("cbDOCNOTO")]
		internal virtual ComboboxControl cbDOCNOTO
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

		[field: AccessedThroughProperty("cbDOCNOFR")]
		internal virtual ComboboxControl cbDOCNOFR
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

		[field: AccessedThroughProperty("Label16")]
		internal virtual Label Label16
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

		[field: AccessedThroughProperty("Label17")]
		internal virtual Label Label17
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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
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

		[field: AccessedThroughProperty("cbITMTY")]
		internal virtual ComboBox cbITMTY
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

		[field: AccessedThroughProperty("cbCATCD")]
		internal virtual ComboBox cbCATCD
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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

		[field: AccessedThroughProperty("cbITMCD")]
		internal virtual ComboboxControl cbITMCD
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

		[field: AccessedThroughProperty("txtOSPO")]
		internal virtual TextBox txtOSPO
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

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCURCD")]
		internal virtual TextBox txtCURCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
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

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
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

		[field: AccessedThroughProperty("numQTY")]
		internal virtual NumControl numQTY
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

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
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

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
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

		[field: AccessedThroughProperty("dtpDOCDT")]
		internal virtual DateTimePicker dtpDOCDT
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

		[field: AccessedThroughProperty("Label18")]
		internal virtual Label Label18
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

		[field: AccessedThroughProperty("Label19")]
		internal virtual Label Label19
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

		[field: AccessedThroughProperty("Label22")]
		internal virtual Label Label22
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

		[field: AccessedThroughProperty("numAMT")]
		internal virtual NumControl numAMT
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

		[field: AccessedThroughProperty("lblLOC_CUR")]
		internal virtual Label lblLOC_CUR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSUPID")]
		internal virtual TextBox txtSUPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPAYTM")]
		internal virtual TextBox txtPAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDELID")]
		internal virtual TextBox txtDELID
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

		[field: AccessedThroughProperty("lblStatus")]
		internal virtual Label lblStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCQPCO()
		{
			base.Shown += frmPCQPCO_Shown;
			base.FormClosing += frmPCQPCO_FormClosing;
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
			this.cbSUPIDTO = new IMS.ComboboxControl();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbSUPIDFR = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.Label3 = new System.Windows.Forms.Label();
			this.dgvPO = new System.Windows.Forms.DataGridView();
			this.Label16 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.btnRetrieve = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbITMTY = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.cbCATCD = new System.Windows.Forms.ComboBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numTTLTPCHG = new IMS.NumControl();
			this.Label21 = new System.Windows.Forms.Label();
			this.cbITMCD = new IMS.ComboboxControl();
			this.txtREFNO = new System.Windows.Forms.TextBox();
			this.txtMISCDESC = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.txtCURCD = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.Label9 = new System.Windows.Forms.Label();
			this.numUPRICE = new IMS.NumControl();
			this.numQTY = new IMS.NumControl();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.dtpETADT = new System.Windows.Forms.DateTimePicker();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.lblLOC_CUR = new System.Windows.Forms.Label();
			this.txtSUPID = new System.Windows.Forms.TextBox();
			this.txtPAYTM = new System.Windows.Forms.TextBox();
			this.txtDELID = new System.Windows.Forms.TextBox();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.txtOSPO = new System.Windows.Forms.TextBox();
			this.numAMT = new IMS.NumControl();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPO).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			base.SuspendLayout();
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 6;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.cbSUPIDTO, 3, 2);
			this.TableLayoutPanel3.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.cbSUPIDFR, 1, 2);
			this.TableLayoutPanel3.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label3, 2, 2);
			this.TableLayoutPanel3.Controls.Add(this.dgvPO, 0, 5);
			this.TableLayoutPanel3.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel3.Controls.Add(this.dtpDOCDTTO, 3, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label17, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.dtpDOCDTFR, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label4, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.btnRetrieve, 0, 4);
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 1, 4);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.cbITMTY, 1, 3);
			this.TableLayoutPanel3.Controls.Add(this.Label5, 2, 3);
			this.TableLayoutPanel3.Controls.Add(this.cbCATCD, 3, 3);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 7;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(1380, 684);
			this.TableLayoutPanel3.TabIndex = 19;
			this.cbSUPIDTO.BlankValue = null;
			this.cbSUPIDTO.ComboboxWidth = 170;
			this.cbSUPIDTO.DataTable = null;
			this.cbSUPIDTO.DisplayMember = null;
			this.cbSUPIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDTO.HasBlankValue = true;
			this.cbSUPIDTO.Location = new System.Drawing.Point(558, 60);
			this.cbSUPIDTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbSUPIDTO.Name = "cbSUPIDTO";
			this.cbSUPIDTO.SelectedIndex = -1;
			this.cbSUPIDTO.SelectedItem = null;
			this.cbSUPIDTO.SelectedValue = null;
			this.cbSUPIDTO.Size = new System.Drawing.Size(335, 25);
			this.cbSUPIDTO.TabIndex = 55;
			this.cbSUPIDTO.TextMultiline = true;
			this.cbSUPIDTO.ValueMember = null;
			this.cbSUPIDTO.WhereClause = null;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(558, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(324, 26);
			this.cbDOCNOTO.TabIndex = 53;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbSUPIDFR.BlankValue = null;
			this.cbSUPIDFR.ComboboxWidth = 170;
			this.cbSUPIDFR.DataTable = null;
			this.cbSUPIDFR.DisplayMember = null;
			this.cbSUPIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDFR.HasBlankValue = true;
			this.cbSUPIDFR.Location = new System.Drawing.Point(130, 60);
			this.cbSUPIDFR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbSUPIDFR.Name = "cbSUPIDFR";
			this.cbSUPIDFR.SelectedIndex = -1;
			this.cbSUPIDFR.SelectedItem = null;
			this.cbSUPIDFR.SelectedValue = null;
			this.cbSUPIDFR.Size = new System.Drawing.Size(323, 25);
			this.cbSUPIDFR.TabIndex = 54;
			this.cbSUPIDFR.TextMultiline = true;
			this.cbSUPIDFR.ValueMember = null;
			this.cbSUPIDFR.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(130, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(323, 26);
			this.cbDOCNOFR.TabIndex = 52;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(460, 64);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 16);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "To";
			this.dgvPO.AllowUserToAddRows = false;
			this.dgvPO.AllowUserToDeleteRows = false;
			this.dgvPO.AllowUserToResizeRows = false;
			this.dgvPO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvPO, 6);
			this.dgvPO.EnableHeadersVisualStyles = false;
			this.dgvPO.Location = new System.Drawing.Point(3, 174);
			this.dgvPO.MultiSelect = false;
			this.dgvPO.Name = "dgvPO";
			this.dgvPO.ReadOnly = true;
			this.dgvPO.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvPO.RowHeadersVisible = false;
			this.dgvPO.RowHeadersWidth = 51;
			this.dgvPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPO.Size = new System.Drawing.Size(1374, 487);
			this.dgvPO.TabIndex = 58;
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(460, 36);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 16);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(557, 33);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 4;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 7);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(90, 16);
			this.Label2.TabIndex = 77;
			this.Label2.Text = "Document No";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 64);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(74, 16);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Supplier ID";
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(129, 33);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 3;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(460, 7);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(25, 16);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 36);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(101, 16);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Document Date";
			this.btnRetrieve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRetrieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRetrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRetrieve.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRetrieve.Location = new System.Drawing.Point(3, 119);
			this.btnRetrieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRetrieve.Name = "btnRetrieve";
			this.btnRetrieve.Size = new System.Drawing.Size(120, 50);
			this.btnRetrieve.TabIndex = 75;
			this.btnRetrieve.Text = "Retrieve";
			this.btnRetrieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRetrieve.UseVisualStyleBackColor = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(129, 119);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 94);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(68, 16);
			this.Label1.TabIndex = 78;
			this.Label1.Text = "Item Type";
			this.cbITMTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMTY.FormattingEnabled = true;
			this.cbITMTY.Items.AddRange(new object[3] { "Outstanding PO Only", "Completed  PO Only", "All" });
			this.cbITMTY.Location = new System.Drawing.Point(129, 90);
			this.cbITMTY.Name = "cbITMTY";
			this.cbITMTY.Size = new System.Drawing.Size(156, 24);
			this.cbITMTY.TabIndex = 79;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(460, 94);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(91, 16);
			this.Label5.TabIndex = 80;
			this.Label5.Text = "Item Category";
			this.cbCATCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCATCD.FormattingEnabled = true;
			this.cbCATCD.Items.AddRange(new object[3] { "Outstanding PO Only", "Completed  PO Only", "All" });
			this.cbCATCD.Location = new System.Drawing.Point(557, 90);
			this.cbCATCD.Name = "cbCATCD";
			this.cbCATCD.Size = new System.Drawing.Size(156, 24);
			this.cbCATCD.TabIndex = 81;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(3, 9);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1383, 716);
			this.Panel1.TabIndex = 20;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.TableLayoutPanel1);
			this.Panel2.Location = new System.Drawing.Point(3, 5);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1349, 640);
			this.Panel2.TabIndex = 21;
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
			this.TableLayoutPanel1.Controls.Add(this.cbITMCD, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.txtREFNO, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtMISCDESC, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label15, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtCURCD, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.dgvDetails, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.numUPRICE, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.numQTY, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label14, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label18, 2, 8);
			this.TableLayoutPanel1.Controls.Add(this.dtpETADT, 3, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label19, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label20, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label22, 2, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label23, 2, 10);
			this.TableLayoutPanel1.Controls.Add(this.lblLOC_CUR, 4, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtSUPID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtPAYTM, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtDELID, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtRECID, 4, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label24, 2, 9);
			this.TableLayoutPanel1.Controls.Add(this.lblStatus, 3, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtOSPO, 3, 11);
			this.TableLayoutPanel1.Controls.Add(this.numAMT, 3, 10);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 6);
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1285, 530);
			this.TableLayoutPanel1.TabIndex = 0;
			this.numTTLTPCHG.AllowNegative = false;
			this.numTTLTPCHG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTTLTPCHG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTTLTPCHG.DataChanged = false;
			this.numTTLTPCHG.Location = new System.Drawing.Point(788, 87);
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
			this.Label21.Location = new System.Drawing.Point(662, 90);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(120, 16);
			this.Label21.TabIndex = 50;
			this.Label21.Text = "Transport Charges";
			this.cbITMCD.BlankValue = null;
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = true;
			this.cbITMCD.Location = new System.Drawing.Point(106, 322);
			this.cbITMCD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(328, 26);
			this.cbITMCD.TabIndex = 9;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.txtREFNO.Location = new System.Drawing.Point(105, 87);
			this.txtREFNO.Name = "txtREFNO";
			this.txtREFNO.ReadOnly = true;
			this.txtREFNO.Size = new System.Drawing.Size(180, 22);
			this.txtREFNO.TabIndex = 7;
			this.txtMISCDESC.Location = new System.Drawing.Point(105, 404);
			this.txtMISCDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMISCDESC.Multiline = true;
			this.txtMISCDESC.Name = "txtMISCDESC";
			this.txtMISCDESC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMISCDESC.Size = new System.Drawing.Size(551, 56);
			this.txtMISCDESC.TabIndex = 13;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 424);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(76, 16);
			this.Label15.TabIndex = 49;
			this.Label15.Text = "Description";
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(662, 62);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(78, 16);
			this.Label12.TabIndex = 48;
			this.Label12.Text = "Delivery To";
			this.txtCURCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCURCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCURCD.Enabled = false;
			this.txtCURCD.Location = new System.Drawing.Point(788, 31);
			this.txtCURCD.Name = "txtCURCD";
			this.txtCURCD.ReadOnly = true;
			this.txtCURCD.Size = new System.Drawing.Size(87, 22);
			this.txtCURCD.TabIndex = 4;
			this.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 4);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.btnBack, 1, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 474);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel2.TabIndex = 14;
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
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
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
			this.btnBack.TabIndex = 16;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDetails, 4);
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Location = new System.Drawing.Point(3, 170);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(937, 137);
			this.dgvDetails.TabIndex = 10;
			this.dgvDetails.TabStop = false;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 126);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.numUPRICE.AllowNegative = false;
			this.numUPRICE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numUPRICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numUPRICE.DataChanged = false;
			this.numUPRICE.Location = new System.Drawing.Point(105, 378);
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
			this.numQTY.Location = new System.Drawing.Point(105, 352);
			this.numQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.2";
			this.numQTY.Size = new System.Drawing.Size(87, 22);
			this.numQTY.TabIndex = 11;
			this.numQTY.Text = "0.00";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 6);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(90, 16);
			this.Label6.TabIndex = 3;
			this.Label6.Text = "Document No";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(662, 6);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(101, 16);
			this.Label7.TabIndex = 2;
			this.Label7.Text = "Document Date";
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(3, 381);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(65, 16);
			this.Label14.TabIndex = 9;
			this.Label14.Text = "Unit Price";
			this.txtREMRK.Location = new System.Drawing.Point(105, 115);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(551, 39);
			this.txtREMRK.TabIndex = 8;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 355);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(56, 16);
			this.Label13.TabIndex = 4;
			this.Label13.Text = "Quantity";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 34);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(74, 16);
			this.Label8.TabIndex = 4;
			this.Label8.Text = "Supplier ID";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 327);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(69, 16);
			this.Label10.TabIndex = 3;
			this.Label10.Text = "Item Code";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 62);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(96, 16);
			this.Label11.TabIndex = 9;
			this.Label11.Text = "Payment Term";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Enabled = false;
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(788, 3);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.txtDOCNO.Location = new System.Drawing.Point(105, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.ReadOnly = true;
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(662, 327);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(67, 16);
			this.Label18.TabIndex = 5;
			this.Label18.Text = "ETA Date";
			this.dtpETADT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpETADT.CustomFormat = "dd/MM/yyyy";
			this.dtpETADT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpETADT.Location = new System.Drawing.Point(788, 324);
			this.dtpETADT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpETADT.Name = "dtpETADT";
			this.dtpETADT.Size = new System.Drawing.Size(104, 22);
			this.dtpETADT.TabIndex = 10;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(662, 34);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(61, 16);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "Currency";
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(3, 90);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(50, 16);
			this.Label20.TabIndex = 48;
			this.Label20.Text = "Ref No";
			this.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label22.Location = new System.Drawing.Point(662, 424);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(84, 16);
			this.Label22.TabIndex = 48;
			this.Label22.Text = "Incoming PO";
			this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label23.AutoSize = true;
			this.Label23.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label23.Location = new System.Drawing.Point(662, 381);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(53, 16);
			this.Label23.TabIndex = 8;
			this.Label23.Text = "Amount";
			this.lblLOC_CUR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLOC_CUR.AutoSize = true;
			this.lblLOC_CUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.lblLOC_CUR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLOC_CUR.Location = new System.Drawing.Point(946, 90);
			this.lblLOC_CUR.Name = "lblLOC_CUR";
			this.lblLOC_CUR.Size = new System.Drawing.Size(111, 16);
			this.lblLOC_CUR.TabIndex = 52;
			this.lblLOC_CUR.Text = "Local Currency";
			this.txtSUPID.Location = new System.Drawing.Point(105, 31);
			this.txtSUPID.Name = "txtSUPID";
			this.txtSUPID.ReadOnly = true;
			this.txtSUPID.Size = new System.Drawing.Size(180, 22);
			this.txtSUPID.TabIndex = 53;
			this.txtPAYTM.Location = new System.Drawing.Point(105, 59);
			this.txtPAYTM.Name = "txtPAYTM";
			this.txtPAYTM.ReadOnly = true;
			this.txtPAYTM.Size = new System.Drawing.Size(180, 22);
			this.txtPAYTM.TabIndex = 54;
			this.txtDELID.Location = new System.Drawing.Point(788, 59);
			this.txtDELID.Name = "txtDELID";
			this.txtDELID.ReadOnly = true;
			this.txtDELID.Size = new System.Drawing.Size(152, 22);
			this.txtDELID.TabIndex = 55;
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(946, 352);
			this.txtRECID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(61, 22);
			this.txtRECID.TabIndex = 14;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRECID.Visible = false;
			this.Label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label24.AutoSize = true;
			this.Label24.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label24.Location = new System.Drawing.Point(662, 355);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(74, 16);
			this.Label24.TabIndex = 56;
			this.Label24.Text = "Completed";
			this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.lblStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblStatus.Location = new System.Drawing.Point(788, 355);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(51, 16);
			this.lblStatus.TabIndex = 57;
			this.lblStatus.Text = "Status";
			this.txtOSPO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtOSPO.BackColor = System.Drawing.SystemColors.Control;
			this.txtOSPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TableLayoutPanel1.SetColumnSpan(this.txtOSPO, 2);
			this.txtOSPO.ForeColor = System.Drawing.Color.Tomato;
			this.txtOSPO.Location = new System.Drawing.Point(788, 407);
			this.txtOSPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOSPO.Multiline = true;
			this.txtOSPO.Name = "txtOSPO";
			this.txtOSPO.ReadOnly = true;
			this.txtOSPO.Size = new System.Drawing.Size(494, 50);
			this.txtOSPO.TabIndex = 48;
			this.txtOSPO.TabStop = false;
			this.numAMT.AllowNegative = false;
			this.numAMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numAMT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numAMT.DataChanged = false;
			this.numAMT.Enabled = false;
			this.numAMT.Location = new System.Drawing.Point(788, 378);
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
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1395, 728);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPCQPCO";
			base.Tag = "PCQPCO";
			this.Text = "Purchase Order Inquiry";
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPO).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			base.ResumeLayout(false);
		}

		private void frmPCQPCO_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			BindComboHeader();
			NumberFormat();
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void frmPCQPCO_FormClosing(object sender, FormClosingEventArgs e)
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
			numTTLTPCHG.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Amount);
			numQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numUPRICE.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Price);
			numAMT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Amount);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
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
			string strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'ITMTY' ORDER BY MACOD_CODID";
			cbITMTY.ValueMember = "MACOD_CODID";
			cbITMTY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbITMTY);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'CATCD' ORDER BY MACOD_CODID";
			cbCATCD.ValueMember = "MACOD_CODID";
			cbCATCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCATCD);
		}

		private void BindComboBoxDetails()
		{
			cbITMCD.DataTable = "vwItemBySupplier WITH (NOLOCK) ";
			cbITMCD.WhereClause = "MASUP_SUPID = '" + Common.gfValidSQLStr(txtSUPID.Text) + "' ";
			cbITMCD.ValueMember = "MAITM_ITMCD";
			cbITMCD.DisplayMember = "MAITM_ITMCD";
			cbITMCD.LoadData();
		}

		private void RefreshGrid()
		{
			dgvPO.DataSource = null;
			string strSQL = "EXEC spPCQPCO ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDTO.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMTY.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCATCD.SelectedValue), "' ")));
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvPO;
			dataGridView.DataSource = dt;
			int i = default(int);
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 120;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "PO No");
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].ReadOnly = true;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "PO Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "GRN Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Price");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Currency");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Exchange Rate");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.XRate);
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Completed");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Reference No");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void btnRetrieve_Click(object sender, EventArgs e)
		{
			RefreshGrid();
		}

		private void dgvPO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			BindHeadertoControl();
			RefreshDetailGrid();
			Panel1.Visible = false;
			Panel2.Visible = true;
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvPO.CurrentRow.Cells["PCPCO_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvPO.CurrentRow.Cells["PCPCO_DOCDT"].Value);
			txtSUPID.Text = dgvPO.CurrentRow.Cells["PCPCO_SUPID"].Value.ToString();
			txtPAYTM.Text = dgvPO.CurrentRow.Cells["PCPCO_PAYTM"].Value.ToString();
			txtDELID.Text = dgvPO.CurrentRow.Cells["PCPCO_DELID"].Value.ToString();
			txtREFNO.Text = dgvPO.CurrentRow.Cells["PCPCO_REFNO"].Value.ToString();
			numTTLTPCHG.Value = Conversions.ToDouble(dgvPO.CurrentRow.Cells["PCPCO_TTLTPCHG"].Value);
			txtREMRK.Text = dgvPO.CurrentRow.Cells["PCPCO_REMRK"].Value.ToString();
			txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MASUP_CURCD", "MASUP_TBL", "MASUP_SUPID = '" + txtSUPID.Text + "'"));
			BindComboBoxDetails();
		}

		private void RefreshDetailGrid()
		{
			dgvDetails.DataSource = null;
			string strSQL = "SELECT PCPCO_RECID, PCPCO_ITMCD, MAITM_DESC, PCPCO_ETADT, CONVERT(NVARCHAR(20), PCPCO_ETADT, 103) AS ETADT, ";
			strSQL += "PCPCO_QTY, PCPCO_UPRICE, PCPCO_AMT, PCPCO_MISCDESC, ";
			strSQL += "CASE WHEN PCPCO_QTY > PCPCO_GRNQTY AND PCPCO_COMFG = 0 THEN 'NO' ELSE 'YES' END AS COMPLETED ";
			strSQL += "FROM PCPCO_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ";
			strSQL += "ON MAITM_ITMCD = PCPCO_ITMCD ";
			strSQL = strSQL + "WHERE PCPCO_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL += "ORDER BY PCPCO_RECID";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			int i = default(int);
			dataGridView.Columns[i].Visible = false;
			dataGridView.Columns[i].Width = 100;
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].HeaderText = "RECID";
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 250;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "PCPCO_ETADT";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "ETA Date");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Unit Price");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Completed");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void dgvDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
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
			lblStatus.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["COMPLETED"].Value);
			EnableControl();
		}

		private void EnableControl()
		{
			if (Operators.CompareString(lblStatus.Text, "YES", false) == 0)
			{
				numQTY.ReadOnly = true;
			}
			else
			{
				numQTY.ReadOnly = false;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (ValidateDetailControl() && spPCQPCO("0"))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefreshGrid();
				ClearDetails();
			}
		}

		private bool ValidateDetailControl()
		{
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
		}

		private double OSPOQTY()
		{
			string strSQL = "PCPCO_SUPID = '" + txtSUPID.Text + "' ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND PCPCO_ITMCD = '", cbITMCD.SelectedValue), "' ")));
			strSQL += "AND PCPCO_QTY - PCPCO_GRNQTY > 0 ";
			strSQL += "AND PCPCO_COMFG <> 1";
			return Conversions.ToDouble(DB.GetColumnValue("ISNULL(SUM(PCPCO_QTY - PCPCO_GRNQTY), 0)", "PCPCO_TBL", strSQL));
		}

		private string OSPONO()
		{
			string strOSPONO = string.Empty;
			string strSQL = "SELECT DISTINCT PCPCO_DOCNO ";
			strSQL += "FROM PCPCO_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PCPCO_SUPID = '" + txtSUPID.Text + "' ";
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

		private bool spPCQPCO(string strPRO)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spPCEPCO ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(txtRECID.Text)) + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = strSQL + "'" + txtSUPID.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpETADT.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
			strSQL = strSQL + "'" + txtREFNO.Text + "', ";
			strSQL = strSQL + Conversions.ToString(numTTLTPCHG.Value) + ", ";
			strSQL = strSQL + "'" + txtMISCDESC.Text + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(numQTY.Value) + "', ";
			strSQL = strSQL + "'" + txtPAYTM.Text + "', ";
			strSQL = strSQL + "'" + txtDELID.Text + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(numUPRICE.Value) + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(numAMT.Value) + "', ";
			strSQL += "'', ";
			strSQL += "0, ";
			strSQL += "0, ";
			strSQL += "0, ";
			strSQL = strSQL + "'" + txtREMRK.Text + "', ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
			bool spPCQPCO;
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
				spPCQPCO = false;
				ProjectData.ClearProjectError();
				goto IL_028f;
			}
			spPCQPCO = true;
			goto IL_028f;
			IL_028f:
			return spPCQPCO;
		}
	}
}
