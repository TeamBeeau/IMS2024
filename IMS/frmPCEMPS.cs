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
	public class frmPCEMPS : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbMDLCD")]
		private ComboboxControl _cbMDLCD;

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
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSearch")]
		private Button _btnSearch;

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
		[AccessedThroughProperty("rdoALL")]
		private RadioButton _rdoALL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoLATEST")]
		private RadioButton _rdoLATEST;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDETAILS")]
		private DataGridView _dgvDETAILS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCOPY")]
		private Button _btnCOPY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCANCEL")]
		private Button _btnCANCEL;

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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
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

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
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

		[field: AccessedThroughProperty("Label19")]
		internal virtual Label Label19
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

		[field: AccessedThroughProperty("lblSTDWGT")]
		internal virtual Label lblSTDWGT
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

		[field: AccessedThroughProperty("dtpEFFMTH")]
		internal virtual DateTimePicker dtpEFFMTH
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpEFFYR")]
		internal virtual DateTimePicker dtpEFFYR
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

		[field: AccessedThroughProperty("lblPLNQTY")]
		internal virtual Label lblPLNQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numPLNQTY")]
		internal virtual NumControl numPLNQTY
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

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
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

		internal virtual Button btnSearch
		{
			[CompilerGenerated]
			get
			{
				return _btnSearch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSearch_Click;
				Button button = _btnSearch;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSearch = value;
				button = _btnSearch;
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual RadioButton rdoALL
		{
			[CompilerGenerated]
			get
			{
				return _rdoALL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoALL_CheckedChanged;
				RadioButton radioButton = _rdoALL;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoALL = value;
				radioButton = _rdoALL;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rdoLATEST
		{
			[CompilerGenerated]
			get
			{
				return _rdoLATEST;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoLATEST_CheckedChanged;
				RadioButton radioButton = _rdoLATEST;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoLATEST = value;
				radioButton = _rdoLATEST;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
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
				DataGridViewCellMouseEventHandler value2 = dgvDETAILS_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvDETAILS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvDETAILS = value;
				dataGridView = _dgvDETAILS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		internal virtual Button btnCOPY
		{
			[CompilerGenerated]
			get
			{
				return _btnCOPY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCOPY_Click;
				Button button = _btnCOPY;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCOPY = value;
				button = _btnCOPY;
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

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbROUCD")]
		internal virtual ComboBox cbROUCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbMCHID")]
		internal virtual ComboBox cbMCHID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnCANCEL
		{
			[CompilerGenerated]
			get
			{
				return _btnCANCEL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCANCEL_Click;
				Button button = _btnCANCEL;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCANCEL = value;
				button = _btnCANCEL;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbLOCID")]
		internal virtual ComboBox cbLOCID
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

		[field: AccessedThroughProperty("numSTDWGT")]
		internal virtual NumControl numSTDWGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCEMPS()
		{
			base.FormClosing += frmPCEMPS_FormClosing;
			base.Shown += frmPCEMPS_Shown;
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numSTDWGT = new IMS.NumControl();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.btnCOPY = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.dtpEFFYR = new System.Windows.Forms.DateTimePicker();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.cbMDLCD = new IMS.ComboboxControl();
			this.Label19 = new System.Windows.Forms.Label();
			this.cbREVNO = new System.Windows.Forms.ComboBox();
			this.dgvDETAILS = new System.Windows.Forms.DataGridView();
			this.dtpEFFMTH = new System.Windows.Forms.DateTimePicker();
			this.lblSTDWGT = new System.Windows.Forms.Label();
			this.numPLNQTY = new IMS.NumControl();
			this.lblPLNQTY = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.cbMCHID = new System.Windows.Forms.ComboBox();
			this.cbROUCD = new System.Windows.Forms.ComboBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.rdoLATEST = new System.Windows.Forms.RadioButton();
			this.rdoALL = new System.Windows.Forms.RadioButton();
			this.Label1 = new System.Windows.Forms.Label();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).BeginInit();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(1, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 4;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.numSTDWGT, 4, 4);
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.btnCOPY, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel6, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.dtpEFFYR, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.cbMDLCD, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label19, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.cbREVNO, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.dgvDETAILS, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpEFFMTH, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblSTDWGT, 3, 4);
			this.TableLayoutPanel1.Controls.Add(this.numPLNQTY, 4, 7);
			this.TableLayoutPanel1.Controls.Add(this.lblPLNQTY, 3, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.cbMCHID, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.cbROUCD, 4, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label14, 3, 5);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 6);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 9;
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(877, 520);
			this.TableLayoutPanel1.TabIndex = 0;
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(443, 381);
			this.numSTDWGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.2";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(87, 22);
			this.numSTDWGT.TabIndex = 73;
			this.numSTDWGT.Text = "0.00";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(103, 409);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(200, 24);
			this.cbLOCID.TabIndex = 72;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 411);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(59, 16);
			this.Label6.TabIndex = 71;
			this.Label6.Text = "Location";
			this.btnCOPY.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.btnCOPY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCOPY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCOPY.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCOPY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCOPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCOPY.Image = IMS.My.Resources.Resources.copy;
			this.btnCOPY.Location = new System.Drawing.Point(754, 2);
			this.btnCOPY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCOPY.Name = "btnCOPY";
			this.TableLayoutPanel1.SetRowSpan(this.btnCOPY, 2);
			this.btnCOPY.Size = new System.Drawing.Size(120, 50);
			this.btnCOPY.TabIndex = 68;
			this.btnCOPY.Text = "Copy";
			this.btnCOPY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCOPY.UseVisualStyleBackColor = false;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(329, 32);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(98, 16);
			this.Label3.TabIndex = 64;
			this.Label3.Text = "Effective Month";
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel6, 6);
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnCANCEL, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 2, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 3, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(3, 463);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(506, 54);
			this.TableLayoutPanel6.TabIndex = 47;
			this.btnCANCEL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnCANCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnCANCEL.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCANCEL.Location = new System.Drawing.Point(130, 2);
			this.btnCANCEL.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.Size = new System.Drawing.Size(120, 50);
			this.btnCANCEL.TabIndex = 15;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCANCEL.UseVisualStyleBackColor = false;
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
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(257, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(383, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 11;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.dtpEFFYR.CustomFormat = "yyyy";
			this.dtpEFFYR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFYR.Location = new System.Drawing.Point(103, 28);
			this.dtpEFFYR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFYR.Name = "dtpEFFYR";
			this.dtpEFFYR.Size = new System.Drawing.Size(104, 22);
			this.dtpEFFYR.TabIndex = 2;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 5);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.TableLayoutPanel1.SetColumnSpan(this.txtDOCNO, 3);
			this.txtDOCNO.Location = new System.Drawing.Point(103, 2);
			this.txtDOCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 32);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(91, 16);
			this.Label2.TabIndex = 63;
			this.Label2.Text = "Effective Year";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 356);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(82, 16);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Model Code";
			this.cbMDLCD.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbMDLCD, 5);
			this.cbMDLCD.ComboboxWidth = 170;
			this.cbMDLCD.DataTable = null;
			this.cbMDLCD.DisplayMember = null;
			this.cbMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCD.HasBlankValue = false;
			this.cbMDLCD.Location = new System.Drawing.Point(103, 351);
			this.cbMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbMDLCD.Name = "cbMDLCD";
			this.cbMDLCD.SelectedIndex = -1;
			this.cbMDLCD.SelectedItem = null;
			this.cbMDLCD.SelectedValue = null;
			this.cbMDLCD.Size = new System.Drawing.Size(507, 26);
			this.cbMDLCD.TabIndex = 4;
			this.cbMDLCD.TextMultiline = true;
			this.cbMDLCD.ValueMember = null;
			this.cbMDLCD.WhereClause = null;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(3, 384);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(94, 16);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "BOM Revision";
			this.cbREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbREVNO.FormattingEnabled = true;
			this.cbREVNO.Location = new System.Drawing.Point(103, 382);
			this.cbREVNO.Name = "cbREVNO";
			this.cbREVNO.Size = new System.Drawing.Size(104, 24);
			this.cbREVNO.TabIndex = 5;
			this.dgvDETAILS.AllowUserToAddRows = false;
			this.dgvDETAILS.AllowUserToDeleteRows = false;
			this.dgvDETAILS.AllowUserToResizeColumns = false;
			this.dgvDETAILS.AllowUserToResizeRows = false;
			this.dgvDETAILS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDETAILS, 6);
			this.dgvDETAILS.Location = new System.Drawing.Point(3, 57);
			this.dgvDETAILS.MultiSelect = false;
			this.dgvDETAILS.Name = "dgvDETAILS";
			this.dgvDETAILS.ReadOnly = true;
			this.dgvDETAILS.RowHeadersVisible = false;
			this.dgvDETAILS.RowHeadersWidth = 51;
			this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDETAILS.Size = new System.Drawing.Size(871, 289);
			this.dgvDETAILS.TabIndex = 67;
			this.dgvDETAILS.TabStop = false;
			this.dtpEFFMTH.CustomFormat = "MM";
			this.dtpEFFMTH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFMTH.Location = new System.Drawing.Point(443, 28);
			this.dtpEFFMTH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFMTH.Name = "dtpEFFMTH";
			this.dtpEFFMTH.Size = new System.Drawing.Size(104, 22);
			this.dtpEFFMTH.TabIndex = 3;
			this.lblSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTDWGT.AutoSize = true;
			this.lblSTDWGT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTDWGT.Location = new System.Drawing.Point(329, 384);
			this.lblSTDWGT.Name = "lblSTDWGT";
			this.lblSTDWGT.Size = new System.Drawing.Size(108, 16);
			this.lblSTDWGT.TabIndex = 48;
			this.lblSTDWGT.Text = "Standard Weight";
			this.numPLNQTY.AllowNegative = false;
			this.numPLNQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPLNQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPLNQTY.DataChanged = false;
			this.numPLNQTY.Location = new System.Drawing.Point(443, 435);
			this.numPLNQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPLNQTY.Name = "numPLNQTY";
			this.numPLNQTY.NumberFormat = "8.2";
			this.numPLNQTY.Size = new System.Drawing.Size(87, 22);
			this.numPLNQTY.TabIndex = 8;
			this.numPLNQTY.Text = "0.00";
			this.numPLNQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPLNQTY.ThousandSeperator = false;
			this.numPLNQTY.Value = 0.0;
			this.lblPLNQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPLNQTY.AutoSize = true;
			this.lblPLNQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPLNQTY.Location = new System.Drawing.Point(329, 438);
			this.lblPLNQTY.Name = "lblPLNQTY";
			this.lblPLNQTY.Size = new System.Drawing.Size(58, 16);
			this.lblPLNQTY.TabIndex = 49;
			this.lblPLNQTY.Text = "Plan Qty";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 438);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(59, 16);
			this.Label5.TabIndex = 69;
			this.Label5.Text = "Machine";
			this.cbMCHID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMCHID.FormattingEnabled = true;
			this.cbMCHID.Location = new System.Drawing.Point(103, 436);
			this.cbMCHID.Name = "cbMCHID";
			this.cbMCHID.Size = new System.Drawing.Size(200, 24);
			this.cbMCHID.TabIndex = 7;
			this.cbROUCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbROUCD.FormattingEnabled = true;
			this.cbROUCD.Location = new System.Drawing.Point(443, 409);
			this.cbROUCD.Name = "cbROUCD";
			this.cbROUCD.Size = new System.Drawing.Size(200, 24);
			this.cbROUCD.TabIndex = 6;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(329, 411);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(44, 16);
			this.Label14.TabIndex = 70;
			this.Label14.Text = "Route";
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Location = new System.Drawing.Point(1, 1);
			this.Panel2.Name = "Panel2";
			this.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Panel2.Size = new System.Drawing.Size(1348, 634);
			this.Panel2.TabIndex = 6;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Location = new System.Drawing.Point(6, 103);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(769, 511);
			this.dgvHEADER.TabIndex = 7;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 3;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.rdoLATEST, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.rdoALL, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(166, 26);
			this.TableLayoutPanel2.TabIndex = 6;
			this.rdoLATEST.AutoSize = true;
			this.rdoLATEST.Location = new System.Drawing.Point(101, 3);
			this.rdoLATEST.Name = "rdoLATEST";
			this.rdoLATEST.Size = new System.Drawing.Size(62, 20);
			this.rdoLATEST.TabIndex = 8;
			this.rdoLATEST.Text = "Latest";
			this.rdoLATEST.UseVisualStyleBackColor = true;
			this.rdoALL.AutoSize = true;
			this.rdoALL.Checked = true;
			this.rdoALL.Location = new System.Drawing.Point(54, 3);
			this.rdoALL.Name = "rdoALL";
			this.rdoALL.Size = new System.Drawing.Size(41, 20);
			this.rdoALL.TabIndex = 9;
			this.rdoALL.TabStop = true;
			this.rdoALL.Text = "All";
			this.rdoALL.UseVisualStyleBackColor = true;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(45, 16);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Status";
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSearch, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(4, 46);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 52);
			this.TableLayoutPanel4.TabIndex = 5;
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
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSearch.Location = new System.Drawing.Point(3, 2);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(120, 48);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = false;
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
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 641);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPCEMPS";
			base.Tag = "PCEMPS";
			this.Text = "Master Production Schedule ";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Validate() && spPCEMPS(Conversions.ToString(0)))
			{
				ClearDetails(false);
				BindGridDetails();
			}
		}

		private new bool Validate()
		{
			if (Operators.CompareString(txtDOCNO.Text, string.Empty, false) == 0)
			{
				string strSQL = "SELECT * FROM PCMPS_TBL WITH(NOLOCK) ";
				strSQL = strSQL + "WHERE PCMPS_EFFYR = '" + Conversions.ToString(dtpEFFYR.Value.Year) + "' ";
				strSQL = strSQL + "AND PCMPS_EFMTH = '" + Conversions.ToString(dtpEFFMTH.Value.Month) + "' ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND PCMPS_MDLCD = '", cbMDLCD.SelectedValue), "' ")));
				strSQL = strSQL + "AND PCMPS_REVNO = '" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + "' ";
				if (DB.RecordExists(strSQL))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Data already exists."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
			}
			return true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails(true);
			Header();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPCEMPS_FormClosing(object sender, FormClosingEventArgs e)
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

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void BindComboBox()
		{
			cbMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbMDLCD.WhereClause = "MAITM_ACTFG = -1 AND MAITM_ITMTY = '1'";
			cbMDLCD.ValueMember = "MAITM_ITMCD";
			cbMDLCD.DisplayMember = "MAITM_ITMCD";
			cbMDLCD.LoadData();
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			strSQL = "SELECT DISTINCT MAROU_ROUCD, MAROU_ROUNM ";
			strSQL += "FROM MAROU_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MAROU_ROUCD ";
			cbROUCD.ValueMember = "MAROU_ROUCD";
			cbROUCD.DisplayMember = "MAROU_ROUNM";
			Common.RetriveComboItembySQL(strSQL, cbROUCD);
			strSQL = "SELECT DISTINCT MAMCH_MCHID, MAMCH_MCHNM ";
			strSQL += "FROM MAMCH_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MAMCH_MCHNM";
			cbMCHID.ValueMember = "MAMCH_MCHID";
			cbMCHID.DisplayMember = "MAMCH_MCHNM";
			Common.RetriveComboItembySQL(strSQL, cbMCHID);
			BindLabel();
		}

		private void frmPCEMPS_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
			intAccessLevel = Common.GetAccessLevel(Conversions.ToString(base.Tag));
			Header();
			NumberFormat();
			btnNew.Enabled = intAccessLevel != 0;
			btnSave.Enabled = intAccessLevel >= 1;
			btnCOPY.Enabled = intAccessLevel >= 1;
			btnDelete.Enabled = intAccessLevel >= 3;
		}

		private void NumberFormat()
		{
			numSTDWGT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Weight);
			numPLNQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
		}

		private void Header()
		{
			int i = 0;
			dgvHEADER.DataSource = null;
			int Opt = ((!rdoLATEST.Checked) ? 1 : 0);
			string strSQL = "EXEC spPCMPS ";
			strSQL = strSQL + "'" + Conversions.ToString(Opt) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvHEADER;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 120;
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective Year");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective Month");
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void ClearDetails(bool blnALL)
		{
			if (blnALL)
			{
				txtDOCNO.Text = string.Empty;
				dtpEFFYR.Value = DateAndTime.Now.Date;
				dtpEFFMTH.Value = DateAndTime.Now.Date;
				dgvDETAILS.DataSource = null;
			}
			cbMDLCD.SelectedIndex = -1;
			numSTDWGT.Value = 0.0;
			numPLNQTY.Value = 0.0;
			cbMDLCD.Select();
			EnableDetails(true);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
			strMSG = Conversions.ToString(Operators.ConcatenateObject(strMSG, Operators.ConcatenateObject(Operators.ConcatenateObject(" : ", cbMDLCD.SelectedValue), "\r\n")));
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision No");
			strMSG = Conversions.ToString(Operators.ConcatenateObject(strMSG, Operators.ConcatenateObject(" : ", cbREVNO.SelectedValue)));
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				spPCEMPS(Conversions.ToString(1));
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails(false);
				BindGridDetails();
			}
		}

		private bool spPCEMPS(string strPRO)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PCEMPS'"));
			bool spPCEMPS;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PCEMPS", "PCMPS", ref strNextNo))
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spPCEMPS = false;
						goto IL_0474;
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
					spPCEMPS = false;
					goto IL_0474;
				}
			}
			if (Operators.CompareString(strPRO, "2", false) == 0)
			{
				goto IL_0256;
			}
			if (numPLNQTY.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity cannot be 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numPLNQTY.Focus();
				spPCEMPS = false;
			}
			else
			{
				if (!((numSTDWGT.Value > 0.0) & (numPLNQTY.Value > numSTDWGT.Value)) || numPLNQTY.Value % numSTDWGT.Value == 0.0)
				{
					goto IL_0256;
				}
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Quantity!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numPLNQTY.Focus();
				spPCEMPS = false;
			}
			goto IL_0474;
			IL_0256:
			strSQL = "EXEC spPCEMPS ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(dtpEFFYR.Value.Year) + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(dtpEFFMTH.Value.Month) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCD.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbROUCD.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMCHID.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(numPLNQTY.Value)) + "', ";
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
				spPCEMPS = false;
				ProjectData.ClearProjectError();
				goto IL_0474;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record edited!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			spPCEMPS = true;
			goto IL_0474;
			IL_0474:
			return spPCEMPS;
		}

		private void cbMDLCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strWHERE = "MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "'";
			numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL WITH (NOLOCK)", strWHERE));
			BindRevNo();
			checked
			{
				int num = dgvDETAILS.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(dgvDETAILS.Rows[i].Cells["PCMPS_MDLCD"].Value, cbMDLCD.SelectedValue, false))
					{
						dgvDETAILS.Rows[i].Selected = true;
						dgvDETAILS.CurrentCell = dgvDETAILS.Rows[i].Cells["PCMPS_MDLCD"];
						BindDetailsToControl();
						break;
					}
				}
			}
		}

		private void BindRevNo()
		{
			string strTYPE = Conversions.ToString(DB.GetColumnValue("MAITM_ITMTY", "MAITM_TBL WITH(NOLOCK)", "MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' AND MAITM_ACTFG = -1 "));
			string strSQL = "SELECT 0 as MABOM_REVNO ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT ISNULL(MABOM_REVNO, 0) as MABOM_REVNO ";
			strSQL += "FROM MABOM_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MABOM_MDLCD = MAITM_ITMCD  ";
			strSQL += "WHERE MAITM_ITMTY = '1' AND MAITM_ACTFG = -1 AND MABOM_ACTFG = 1 ";
			strSQL += "ORDER BY MABOM_REVNO ";
			cbREVNO.ValueMember = "MABOM_REVNO";
			cbREVNO.DisplayMember = "MABOM_REVNO";
			Common.RetriveComboItembySQL(strSQL, cbREVNO);
			if (Operators.CompareString(strTYPE, "1", false) == 0)
			{
				strSQL = "SELECT DISTINCT ISNULL(MABOM_REVNO, 0) as MABOM_REVNO ";
				strSQL += "FROM MABOM_TBL WITH (NOLOCK) ";
				strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MABOM_MDLCD = MAITM_ITMCD  ";
				strSQL += "WHERE MAITM_ITMTY = '1' AND MAITM_ACTFG = -1 ";
				strSQL = strSQL + "AND MABOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
				strSQL += "ORDER BY MABOM_REVNO ";
				cbREVNO.ValueMember = "MABOM_REVNO";
				cbREVNO.DisplayMember = "MABOM_REVNO";
				Common.RetriveComboItembySQL(strSQL, cbREVNO);
			}
		}

		private void BindLabel()
		{
			string strUOM = Conversions.ToString(DB.GetColumnValue("LMSYS_BUOM", "LMSYS_TBL", ""));
			lblSTDWGT.Text = "Standard Weight (" + strUOM + ")";
			lblPLNQTY.Text = "Plan Qty (" + strUOM + ")";
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["PCMPS_DOCNO"].Value.ToString();
			dtpEFFYR.Value = new DateTime(Conversions.ToInteger(dgvHEADER.CurrentRow.Cells["PCMPS_EFFYR"].Value), DateAndTime.Today.Month, 1);
			dtpEFFMTH.Value = new DateTime(DateAndTime.Today.Year, Conversions.ToInteger(dgvHEADER.CurrentRow.Cells["PCMPS_EFMTH"].Value), 1);
			txtDOCNO.Enabled = false;
			BindGridDetails();
			Panel2.Visible = false;
			Panel1.Visible = true;
		}

		private void BindGridDetails()
		{
			string strSQL = "SELECT PCMPS_MDLCD, PCMPS_REVNO, PCMPS_LOCID, PCMPS_ROUCD, PCMPS_MCHID, PCMPS_PLNQT ";
			strSQL += "FROM PCMPS_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PCMPS_DOCNO = '" + txtDOCNO.Text + "'";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDETAILS;
			dataGridView.DataSource = dt;
			int i = default(int);
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 150;
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
			dataGridView.Columns[i].ReadOnly = true;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision No");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Route");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Machine");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Plan Quantity");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				dataGridView.Columns[i].ReadOnly = true;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void rdoLATEST_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoLATEST.Checked)
			{
				rdoALL.Checked = false;
			}
			else
			{
				rdoALL.Checked = true;
			}
		}

		private void rdoALL_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoALL.Checked)
			{
				rdoLATEST.Checked = false;
			}
			else
			{
				rdoLATEST.Checked = true;
			}
		}

		private void dgvDETAILS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindDetailsToControl();
			EnableDetails(false);
		}

		private void BindDetailsToControl()
		{
			cbMDLCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["PCMPS_MDLCD"].Value);
			cbREVNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["PCMPS_REVNO"].Value);
			cbLOCID.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["PCMPS_LOCID"].Value);
			cbROUCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["PCMPS_ROUCD"].Value);
			cbMCHID.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["PCMPS_MCHID"].Value);
			numPLNQTY.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["PCMPS_PLNQT"].Value);
		}

		private void EnableDetails(bool blnEnable)
		{
			cbMDLCD.Enabled = blnEnable;
			cbREVNO.Enabled = blnEnable;
		}

		private void btnCOPY_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM PCMPS_TBL ";
			strSQL = strSQL + "WHERE PCMPS_EFFYR = " + Conversions.ToString(dtpEFFYR.Value.Year) + " ";
			strSQL = strSQL + "AND PCMPS_EFMTH = " + Conversions.ToString(dtpEFFMTH.Value.Month) + " ";
			if (DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Current Month MPS data already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			spPCEMPS(Conversions.ToString(2));
			BindGridDetails();
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			ClearDetails(false);
		}
	}
}
