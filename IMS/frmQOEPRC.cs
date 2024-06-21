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
	public class frmQOEPRC : Form
	{
		private IContainer components;

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
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnADD")]
		private Button _btnADD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

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
		[AccessedThroughProperty("cbHMDLCD")]
		private ComboboxControl _cbHMDLCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbREVNO")]
		private ComboBox _cbREVNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbMDLCD")]
		private ComboboxControl _cbMDLCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRetrieve")]
		private Button _btnRetrieve;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

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

		internal virtual ComboboxControl cbHMDLCD
		{
			[CompilerGenerated]
			get
			{
				return _cbHMDLCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbHMDLCD_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbHMDLCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbHMDLCD = value;
				comboboxControl = _cbHMDLCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbHREVNO")]
		internal virtual ComboBox cbHREVNO
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbBOMPN")]
		internal virtual ComboboxControl cbBOMPN
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

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpEFFDT")]
		internal virtual DateTimePicker dtpEFFDT
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numLTPRC")]
		internal virtual NumControl numLTPRC
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

		[field: AccessedThroughProperty("numQOPRC")]
		internal virtual NumControl numQOPRC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
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

		[field: AccessedThroughProperty("numTOTAL")]
		internal virtual NumControl numTOTAL
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

		[field: AccessedThroughProperty("numAMT1KG")]
		internal virtual NumControl numAMT1KG
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

		[field: AccessedThroughProperty("numQAMT1KG")]
		internal virtual NumControl numQAMT1KG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmQOEPRC()
		{
			base.Load += frmQOEPRC_Load;
			base.FormClosing += frmQOEPRC_FormClosing;
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
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbHREVNO = new System.Windows.Forms.ComboBox();
			this.cbHMDLCD = new IMS.ComboboxControl();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.chkLATEST = new System.Windows.Forms.CheckBox();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.Label5 = new System.Windows.Forms.Label();
			this.numLTPRC = new IMS.NumControl();
			this.Label4 = new System.Windows.Forms.Label();
			this.numPARQT = new IMS.NumControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbBOMPN = new IMS.ComboboxControl();
			this.cbMDLCD = new IMS.ComboboxControl();
			this.Label9 = new System.Windows.Forms.Label();
			this.dtpEFFDT = new System.Windows.Forms.DateTimePicker();
			this.Label8 = new System.Windows.Forms.Label();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.dgvDETAILS = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnADD = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbREVNO = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.numQOPRC = new IMS.NumControl();
			this.Label10 = new System.Windows.Forms.Label();
			this.btnRetrieve = new System.Windows.Forms.Button();
			this.numSTDWGT = new IMS.NumControl();
			this.numTOTAL = new IMS.NumControl();
			this.Label11 = new System.Windows.Forms.Label();
			this.numAMT1KG = new IMS.NumControl();
			this.Label12 = new System.Windows.Forms.Label();
			this.numQAMT1KG = new IMS.NumControl();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).BeginInit();
			this.TableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel6);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Location = new System.Drawing.Point(5, 3);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1330, 616);
			this.Panel2.TabIndex = 14;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 3;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 80);
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
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 3;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbHREVNO, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbHMDLCD, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label7, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label6, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.chkLATEST, 2, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 6);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 2;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(529, 59);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbHREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHREVNO.FormattingEnabled = true;
			this.cbHREVNO.Location = new System.Drawing.Point(91, 32);
			this.cbHREVNO.Name = "cbHREVNO";
			this.cbHREVNO.Size = new System.Drawing.Size(104, 24);
			this.cbHREVNO.TabIndex = 50;
			this.cbHMDLCD.BlankValue = null;
			this.cbHMDLCD.ComboboxWidth = 170;
			this.cbHMDLCD.DataTable = null;
			this.cbHMDLCD.DisplayMember = null;
			this.cbHMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHMDLCD.HasBlankValue = true;
			this.cbHMDLCD.Location = new System.Drawing.Point(91, 2);
			this.cbHMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbHMDLCD.Name = "cbHMDLCD";
			this.cbHMDLCD.SelectedIndex = -1;
			this.cbHMDLCD.SelectedItem = null;
			this.cbHMDLCD.SelectedValue = null;
			this.cbHMDLCD.Size = new System.Drawing.Size(366, 25);
			this.cbHMDLCD.TabIndex = 49;
			this.cbHMDLCD.TextMultiline = true;
			this.cbHMDLCD.ValueMember = null;
			this.cbHMDLCD.WhereClause = null;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 36);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(61, 16);
			this.Label7.TabIndex = 9;
			this.Label7.Text = "Revision";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 6);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(82, 16);
			this.Label6.TabIndex = 8;
			this.Label6.Text = "Model Code";
			this.chkLATEST.AutoSize = true;
			this.chkLATEST.Checked = true;
			this.chkLATEST.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkLATEST.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkLATEST.Location = new System.Drawing.Point(463, 32);
			this.chkLATEST.Name = "chkLATEST";
			this.chkLATEST.Size = new System.Drawing.Size(63, 20);
			this.chkLATEST.TabIndex = 51;
			this.chkLATEST.Text = "Latest";
			this.chkLATEST.UseVisualStyleBackColor = true;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 137);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1187, 463);
			this.dgvHEADER.TabIndex = 5;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(5, 3);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1330, 667);
			this.Panel1.TabIndex = 16;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 5;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.Label5, 0, 9);
			this.TableLayoutPanel3.Controls.Add(this.numLTPRC, 1, 8);
			this.TableLayoutPanel3.Controls.Add(this.Label4, 0, 8);
			this.TableLayoutPanel3.Controls.Add(this.numPARQT, 1, 7);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 0, 7);
			this.TableLayoutPanel3.Controls.Add(this.cbBOMPN, 1, 6);
			this.TableLayoutPanel3.Controls.Add(this.cbMDLCD, 1, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label9, 0, 6);
			this.TableLayoutPanel3.Controls.Add(this.dtpEFFDT, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label8, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.TableLayoutPanel4, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.dgvDETAILS, 0, 5);
			this.TableLayoutPanel3.Controls.Add(this.TableLayoutPanel1, 0, 10);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.cbREVNO, 1, 3);
			this.TableLayoutPanel3.Controls.Add(this.Label3, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.numQOPRC, 1, 9);
			this.TableLayoutPanel3.Controls.Add(this.Label10, 2, 3);
			this.TableLayoutPanel3.Controls.Add(this.btnRetrieve, 4, 3);
			this.TableLayoutPanel3.Controls.Add(this.numSTDWGT, 3, 3);
			this.TableLayoutPanel3.Controls.Add(this.numTOTAL, 4, 6);
			this.TableLayoutPanel3.Controls.Add(this.Label11, 3, 7);
			this.TableLayoutPanel3.Controls.Add(this.numAMT1KG, 4, 7);
			this.TableLayoutPanel3.Controls.Add(this.Label12, 3, 8);
			this.TableLayoutPanel3.Controls.Add(this.numQAMT1KG, 4, 8);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 11;
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
			this.TableLayoutPanel3.Size = new System.Drawing.Size(869, 584);
			this.TableLayoutPanel3.TabIndex = 1;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 503);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label5.Size = new System.Drawing.Size(78, 16);
			this.Label5.TabIndex = 62;
			this.Label5.Text = "Quote Price";
			this.numLTPRC.AllowNegative = false;
			this.numLTPRC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numLTPRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numLTPRC.DataChanged = false;
			this.numLTPRC.Location = new System.Drawing.Point(100, 474);
			this.numLTPRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numLTPRC.Name = "numLTPRC";
			this.numLTPRC.NumberFormat = "8.2";
			this.numLTPRC.ReadOnly = true;
			this.numLTPRC.Size = new System.Drawing.Size(104, 22);
			this.numLTPRC.TabIndex = 61;
			this.numLTPRC.Text = "0.00";
			this.numLTPRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numLTPRC.ThousandSeperator = false;
			this.numLTPRC.Value = 0.0;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 477);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(78, 16);
			this.Label4.TabIndex = 60;
			this.Label4.Text = "Latest Price";
			this.numPARQT.AllowNegative = false;
			this.numPARQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPARQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPARQT.DataChanged = false;
			this.numPARQT.Location = new System.Drawing.Point(100, 448);
			this.numPARQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPARQT.Name = "numPARQT";
			this.numPARQT.NumberFormat = "8.2";
			this.numPARQT.ReadOnly = true;
			this.numPARQT.Size = new System.Drawing.Size(104, 22);
			this.numPARQT.TabIndex = 59;
			this.numPARQT.Text = "0.00";
			this.numPARQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPARQT.ThousandSeperator = false;
			this.numPARQT.Value = 0.0;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 451);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(83, 16);
			this.Label1.TabIndex = 58;
			this.Label1.Text = "Part Quantity";
			this.cbBOMPN.BlankValue = null;
			this.TableLayoutPanel3.SetColumnSpan(this.cbBOMPN, 3);
			this.cbBOMPN.ComboboxWidth = 170;
			this.cbBOMPN.DataTable = null;
			this.cbBOMPN.DisplayMember = null;
			this.cbBOMPN.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBOMPN.HasBlankValue = true;
			this.cbBOMPN.Location = new System.Drawing.Point(100, 412);
			this.cbBOMPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbBOMPN.Name = "cbBOMPN";
			this.cbBOMPN.SelectedIndex = -1;
			this.cbBOMPN.SelectedItem = null;
			this.cbBOMPN.SelectedValue = null;
			this.cbBOMPN.Size = new System.Drawing.Size(412, 32);
			this.cbBOMPN.TabIndex = 56;
			this.cbBOMPN.TextMultiline = true;
			this.cbBOMPN.ValueMember = null;
			this.cbBOMPN.WhereClause = null;
			this.cbMDLCD.BlankValue = null;
			this.TableLayoutPanel3.SetColumnSpan(this.cbMDLCD, 3);
			this.cbMDLCD.ComboboxWidth = 170;
			this.cbMDLCD.DataTable = null;
			this.cbMDLCD.DisplayMember = null;
			this.cbMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCD.HasBlankValue = false;
			this.cbMDLCD.Location = new System.Drawing.Point(100, 88);
			this.cbMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbMDLCD.Name = "cbMDLCD";
			this.cbMDLCD.SelectedIndex = -1;
			this.cbMDLCD.SelectedItem = null;
			this.cbMDLCD.SelectedValue = null;
			this.cbMDLCD.Size = new System.Drawing.Size(412, 32);
			this.cbMDLCD.TabIndex = 55;
			this.cbMDLCD.TextMultiline = true;
			this.cbMDLCD.ValueMember = null;
			this.cbMDLCD.WhereClause = null;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 420);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(69, 16);
			this.Label9.TabIndex = 54;
			this.Label9.Text = "Item Code";
			this.dtpEFFDT.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDT.Location = new System.Drawing.Point(100, 62);
			this.dtpEFFDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDT.Name = "dtpEFFDT";
			this.dtpEFFDT.Size = new System.Drawing.Size(105, 22);
			this.dtpEFFDT.TabIndex = 53;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 65);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(91, 16);
			this.Label8.TabIndex = 52;
			this.Label8.Text = "Effective Date";
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel3.SetColumnSpan(this.TableLayoutPanel4, 3);
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(382, 54);
			this.TableLayoutPanel4.TabIndex = 15;
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
			this.btnSAVE.Text = "Save";
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
			this.dgvDETAILS.AllowUserToAddRows = false;
			this.dgvDETAILS.AllowUserToDeleteRows = false;
			this.dgvDETAILS.AllowUserToResizeRows = false;
			this.dgvDETAILS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvDETAILS, 5);
			this.dgvDETAILS.EnableHeadersVisualStyles = false;
			this.dgvDETAILS.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvDETAILS.Location = new System.Drawing.Point(4, 178);
			this.dgvDETAILS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvDETAILS.MultiSelect = false;
			this.dgvDETAILS.Name = "dgvDETAILS";
			this.dgvDETAILS.ReadOnly = true;
			this.dgvDETAILS.RowHeadersVisible = false;
			this.dgvDETAILS.RowHeadersWidth = 10;
			this.dgvDETAILS.RowTemplate.Height = 24;
			this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDETAILS.Size = new System.Drawing.Size(861, 230);
			this.dgvDETAILS.TabIndex = 7;
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
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 527);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel1.TabIndex = 9;
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
			this.btnCancel.TabIndex = 9;
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
			this.btnADD.TabIndex = 5;
			this.btnADD.Text = "Add";
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
			this.btnREMOVE.TabIndex = 6;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 96);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(82, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Model Code";
			this.cbREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbREVNO.FormattingEnabled = true;
			this.cbREVNO.Location = new System.Drawing.Point(100, 125);
			this.cbREVNO.Name = "cbREVNO";
			this.cbREVNO.Size = new System.Drawing.Size(104, 24);
			this.cbREVNO.TabIndex = 51;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 129);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(61, 16);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Revision";
			this.numQOPRC.AllowNegative = false;
			this.numQOPRC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQOPRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQOPRC.DataChanged = false;
			this.numQOPRC.Location = new System.Drawing.Point(100, 500);
			this.numQOPRC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numQOPRC.Name = "numQOPRC";
			this.numQOPRC.NumberFormat = "8.2";
			this.numQOPRC.Size = new System.Drawing.Size(104, 22);
			this.numQOPRC.TabIndex = 63;
			this.numQOPRC.Text = "0.00";
			this.numQOPRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQOPRC.ThousandSeperator = false;
			this.numQOPRC.Value = 0.0;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(211, 129);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(108, 16);
			this.Label10.TabIndex = 64;
			this.Label10.Text = "Standard Weight";
			this.btnRetrieve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRetrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnRetrieve.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRetrieve.Location = new System.Drawing.Point(523, 124);
			this.btnRetrieve.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnRetrieve.Name = "btnRetrieve";
			this.TableLayoutPanel3.SetRowSpan(this.btnRetrieve, 2);
			this.btnRetrieve.Size = new System.Drawing.Size(120, 50);
			this.btnRetrieve.TabIndex = 57;
			this.btnRetrieve.Text = "Retrieve";
			this.btnRetrieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRetrieve.UseVisualStyleBackColor = false;
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(391, 126);
			this.numSTDWGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.0";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(104, 22);
			this.numSTDWGT.TabIndex = 65;
			this.numSTDWGT.Text = "0";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.numTOTAL.AllowNegative = false;
			this.numTOTAL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTOTAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTOTAL.DataChanged = false;
			this.numTOTAL.Location = new System.Drawing.Point(522, 417);
			this.numTOTAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTOTAL.Name = "numTOTAL";
			this.numTOTAL.NumberFormat = "8.2";
			this.numTOTAL.ReadOnly = true;
			this.numTOTAL.Size = new System.Drawing.Size(144, 22);
			this.numTOTAL.TabIndex = 66;
			this.numTOTAL.Text = "0.00";
			this.numTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTOTAL.ThousandSeperator = false;
			this.numTOTAL.Value = 0.0;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(391, 451);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label11.Size = new System.Drawing.Size(75, 16);
			this.Label11.TabIndex = 67;
			this.Label11.Text = "Amount/KG";
			this.numAMT1KG.AllowNegative = false;
			this.numAMT1KG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numAMT1KG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numAMT1KG.DataChanged = false;
			this.numAMT1KG.Location = new System.Drawing.Point(522, 448);
			this.numAMT1KG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numAMT1KG.Name = "numAMT1KG";
			this.numAMT1KG.NumberFormat = "8.2";
			this.numAMT1KG.ReadOnly = true;
			this.numAMT1KG.Size = new System.Drawing.Size(144, 22);
			this.numAMT1KG.TabIndex = 68;
			this.numAMT1KG.Text = "0.00";
			this.numAMT1KG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numAMT1KG.ThousandSeperator = false;
			this.numAMT1KG.Value = 0.0;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(391, 477);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label12.Size = new System.Drawing.Size(92, 16);
			this.Label12.TabIndex = 69;
			this.Label12.Text = "Quote Amt/KG";
			this.numQAMT1KG.AllowNegative = false;
			this.numQAMT1KG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQAMT1KG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQAMT1KG.DataChanged = false;
			this.numQAMT1KG.Location = new System.Drawing.Point(522, 474);
			this.numQAMT1KG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numQAMT1KG.Name = "numQAMT1KG";
			this.numQAMT1KG.NumberFormat = "8.2";
			this.numQAMT1KG.Size = new System.Drawing.Size(144, 22);
			this.numQAMT1KG.TabIndex = 70;
			this.numQAMT1KG.Text = "0.00";
			this.numQAMT1KG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQAMT1KG.ThousandSeperator = false;
			this.numQAMT1KG.Value = 0.0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmQOEPRC";
			base.Tag = "QOEPRC";
			this.Text = "Quotation Price Setup";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).EndInit();
			this.TableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void frmQOEPRC_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox("HMDLCD");
			BindComboBox("MDLCD");
		}

		private void BindComboBox(string strOption)
		{
			if (Operators.CompareString(strOption, "HMDLCD", false) == 0)
			{
				cbHMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK)";
				cbHMDLCD.WhereClause = "MAITM_ITMTY = 1 AND MAITM_ACTFG = -1";
				cbHMDLCD.ValueMember = "MAITM_ITMCD";
				cbHMDLCD.DisplayMember = "MAITM_ITMCD";
				cbHMDLCD.LoadData();
			}
			if (Operators.CompareString(strOption, "HREVNO", false) == 0)
			{
				string strSQL = "SELECT 0 AS MABOM_REVNO UNION ";
				strSQL += "SELECT DISTINCT MABOM_REVNO ";
				strSQL += "FROM MABOM_TBL WITH (NOLOCK) ";
				strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MABOM_MDLCD = MAITM_ITMCD  ";
				strSQL += "WHERE MAITM_ITMTY = 1 AND MAITM_ACTFG = -1 ";
				strSQL = strSQL + "AND MABOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbHMDLCD.SelectedValue)) + "' ";
				strSQL += "AND MABOM_ACTFG = 1 ";
				strSQL += "ORDER BY MABOM_REVNO ";
				cbHREVNO.ValueMember = "MABOM_REVNO";
				cbHREVNO.DisplayMember = "MABOM_REVNO";
				Common.RetriveComboItembySQL(strSQL, cbHREVNO);
			}
			if (Operators.CompareString(strOption, "MDLCD", false) == 0)
			{
				cbMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK)";
				cbMDLCD.WhereClause = "MAITM_ITMTY = 1 AND MAITM_ACTFG = -1";
				cbMDLCD.ValueMember = "MAITM_ITMCD";
				cbMDLCD.DisplayMember = "MAITM_ITMCD";
				cbMDLCD.LoadData();
			}
			if (Operators.CompareString(strOption, "REVNO", false) == 0)
			{
				string strSQL = "SELECT DISTINCT MABOM_REVNO ";
				strSQL += "FROM MABOM_TBL WITH (NOLOCK) ";
				strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MABOM_MDLCD = MAITM_ITMCD  ";
				strSQL += "WHERE MAITM_ITMTY = 1 AND MAITM_ACTFG = -1 ";
				strSQL = strSQL + "AND MABOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
				strSQL += "AND MABOM_ACTFG = 1 ";
				strSQL += "ORDER BY MABOM_REVNO ";
				cbREVNO.ValueMember = "MABOM_REVNO";
				cbREVNO.DisplayMember = "MABOM_REVNO";
				Common.RetriveComboItembySQL(strSQL, cbREVNO);
			}
			if (Operators.CompareString(strOption, "BOMPN", false) == 0)
			{
				cbBOMPN.DataTable = "MABOM_TBL WITH (NOLOCK)";
				cbBOMPN.WhereClause = "MABOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' AND MABOM_REVNO = " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue)));
				cbBOMPN.ValueMember = "MABOM_BOMPN";
				cbBOMPN.DisplayMember = "MABOM_BOMPN";
				cbBOMPN.LoadData();
			}
		}

		private void Header()
		{
			int i = 0;
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spQOPRC ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbHMDLCD.SelectedValue), "', ")));
			strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbHREVNO.SelectedValue))) + ", ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Interaction.IIf(chkLATEST.Checked, 1, 0)));
			DataTable dt = DB.ExecProc(strSQL);
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
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 250;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount/KG");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
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
			OleDbCommand cmd = new OleDbCommand();
			Cursor = Cursors.WaitCursor;
			if (!checkDetails())
			{
				Cursor = Cursors.Default;
				return;
			}
			string strSQL = "UPDATE QOBOM_WRK ";
			strSQL = strSQL + "SET QOBOM_QOPRC = " + Conversions.ToString(numQOPRC.Value) + ", ";
			strSQL = strSQL + "QOBOM_QOAMT = ROUND(QOBOM_PARQT * " + Conversions.ToString(numQOPRC.Value) + ", 2) ";
			strSQL = strSQL + "WHERE QOBOM_PRNID = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND QOBOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
			strSQL = strSQL + "AND QOBOM_REVNO = " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + " ";
			strSQL = strSQL + "AND QOBOM_BOMPN = '" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "' ";
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
				Cursor = Cursors.Default;
				ProjectData.ClearProjectError();
				return;
			}
			Cursor = Cursors.Default;
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			ClearDetails(false);
			RefreshGridDetails();
		}

		private bool checkDetails()
		{
			if (Operators.ConditionalCompareObjectEqual(cbBOMPN.SelectedValue, string.Empty, false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}

		private void dgvDETAILS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			cbBOMPN.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDETAILS.CurrentRow.Cells["QOBOM_BOMPN"].Value);
			numPARQT.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOBOM_PARQT"].Value);
			numLTPRC.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOBOM_LTPRC"].Value);
			numQOPRC.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["QOBOM_QOPRC"].Value);
			btnADD.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Update");
		}

		private void RefreshGridDetails()
		{
			int i = 0;
			double dblTotal = 0.0;
			dgvDETAILS.DataSource = null;
			string strSQL = "SELECT QOBOM_BOMPN, QOBOM_PARQT, QOBOM_LTPRC, QOBOM_QOPRC, QOBOM_QOAMT, QOBOM_AMT1KG ";
			strSQL = strSQL + "FROM QOBOM_WRK WHERE QOBOM_PRNID = '" + MyProject.Computer.Name + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvDETAILS.ClearSelection();
					DataGridView dataGridView = dgvDETAILS;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Latest Price");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quote Price");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
					int num = dgvDETAILS.RowCount - 1;
					for (i = 0; i <= num; i++)
					{
						dblTotal = Conversions.ToDouble(Operators.AddObject(dblTotal, dgvDETAILS.Rows[i].Cells["QOBOM_QOAMT"].Value));
					}
					numTOTAL.Value = dblTotal;
					numAMT1KG.Value = numTOTAL.Value / numSTDWGT.Value;
					numQAMT1KG.Value = Conversions.ToDouble(dgvDETAILS.Rows[0].Cells["QOBOM_AMT1KG"].Value);
				}
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			dtpEFFDT.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["QOBOM_EFFDT"].Value));
			cbMDLCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["QOBOM_MDLCD"].Value);
			cbREVNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["QOBOM_REVNO"].Value);
			GenerateWorkFile();
			RefreshGridDetails();
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
				string strSQL = "DELETE QOBOM_TBL ";
				strSQL = strSQL + "WHERE QOBOM_EFFDT = '" + Common.gfSQLDate(dtpEFFDT.Value) + "' ";
				strSQL = strSQL + "AND QOBOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
				strSQL = strSQL + "AND QOBOM_REVNO = " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue)));
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

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails(true);
			Header();
		}

		private void ClearDetails(bool blnALL)
		{
			if (blnALL)
			{
				dgvDETAILS.DataSource = null;
				dtpEFFDT.Value = DateTime.Now;
				cbMDLCD.SelectedIndex = -1;
				cbREVNO.SelectedIndex = -1;
				dtpEFFDT.Enabled = true;
				cbMDLCD.Enabled = true;
				cbREVNO.Enabled = true;
				numSTDWGT.Value = 0.0;
				btnADD.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Add");
			}
			cbBOMPN.SelectedIndex = -1;
			numPARQT.Value = 0.0;
			numLTPRC.Value = 0.0;
			numQOPRC.Value = 0.0;
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			if (Operators.ConditionalCompareObjectEqual(cbBOMPN.SelectedValue, string.Empty, false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
				{
					return;
				}
				try
				{
					string strSQL = "DELETE QOBOM_WRK ";
					strSQL = strSQL + "WHERE QOBOM_PRNID = '" + MyProject.Computer.Name + "' ";
					strSQL = strSQL + "AND QOBOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
					strSQL = strSQL + "AND QOBOM_REVNO = " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + " ";
					strSQL = strSQL + "AND QOBOM_BOMPN = '" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "' ";
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
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record not deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails(false);
				RefreshGridDetails();
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			ClearDetails(true);
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmQOEPRC_FormClosing(object sender, FormClosingEventArgs e)
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

		private void cbHMDLCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindComboBox("HREVNO");
		}

		private void btnRetrieve_Click(object sender, EventArgs e)
		{
			GenerateWorkFile();
			RefreshGridDetails();
		}

		private void GenerateWorkFile()
		{
			dtpEFFDT.Enabled = false;
			cbMDLCD.Enabled = false;
			cbREVNO.Enabled = false;
			string strSQL = "EXEC spQOEPRC_WRK '" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "', ";
			strSQL += Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue)));
			DB.ExecProc(strSQL);
		}

		private void cbMDLCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindComboBox("REVNO");
			numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL", "MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "'"));
		}

		private void cbREVNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindComboBox("BOMPN");
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spQOEPRC ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + ", ";
			strSQL = strSQL + Conversions.ToString(numQAMT1KG.Value) + ", ";
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
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			ClearDetails(true);
			Header();
		}
	}
}
