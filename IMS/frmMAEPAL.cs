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
	public class frmMAEPAL : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNEW")]
		private Button _btnNEW;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

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
		[AccessedThroughProperty("dgvDETAILS")]
		private DataGridView _dgvDETAILS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnADD")]
		private Button _btnADD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCDFR")]
		private ComboboxControl _cbITMCDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSORT")]
		private Button _btnSORT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

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

		internal virtual Button btnNEW
		{
			[CompilerGenerated]
			get
			{
				return _btnNEW;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnNEW_Click;
				Button button = _btnNEW;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnNEW = value;
				button = _btnNEW;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
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

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
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

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSUPID")]
		internal virtual ComboboxControl cbSUPID
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

		[field: AccessedThroughProperty("numPRCNT")]
		internal virtual NumControl numPRCNT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblQTY")]
		internal virtual Label lblQTY
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

		[field: AccessedThroughProperty("lblREVNO")]
		internal virtual Label lblREVNO
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

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
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

		[field: AccessedThroughProperty("lblSUPIDFR")]
		internal virtual Label lblSUPIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbITMCDTO")]
		internal virtual ComboboxControl cbITMCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbITMCDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbITMCDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbITMCDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbITMCDFR = value;
				comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("dtpEFFDT")]
		internal virtual DateTimePicker dtpEFFDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblEFFDT")]
		internal virtual Label lblEFFDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpEFFDTFR")]
		internal virtual DateTimePicker dtpEFFDTFR
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpEFFDTTO")]
		internal virtual DateTimePicker dtpEFFDTTO
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

		[field: AccessedThroughProperty("txtMODE")]
		internal virtual TextBox txtMODE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSEQNO")]
		internal virtual NumControl numSEQNO
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

		internal virtual Button btnSORT
		{
			[CompilerGenerated]
			get
			{
				return _btnSORT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSORT_Click;
				Button button = _btnSORT;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSORT = value;
				button = _btnSORT;
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

		public frmMAEPAL()
		{
			base.FormClosing += frmMAEPAL_FormClosing;
			base.Shown += frmMAEPAL_Shown;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMS.frmMAEPAL));
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNEW = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dtpEFFDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpEFFDTFR = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numSEQNO = new IMS.NumControl();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.lblEFFDT = new System.Windows.Forms.Label();
			this.lblSUPIDFR = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtMODE = new System.Windows.Forms.TextBox();
			this.cbSUPID = new IMS.ComboboxControl();
			this.cbITMCD = new IMS.ComboboxControl();
			this.dgvDETAILS = new System.Windows.Forms.DataGridView();
			this.lblREVNO = new System.Windows.Forms.Label();
			this.dtpEFFDT = new System.Windows.Forms.DateTimePicker();
			this.numPRCNT = new IMS.NumControl();
			this.lblQTY = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSORT = new System.Windows.Forms.Button();
			this.btnADD = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).BeginInit();
			this.TableLayoutPanel5.SuspendLayout();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Location = new System.Drawing.Point(3, 1);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 630);
			this.Panel2.TabIndex = 24;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNEW, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 73);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel4.TabIndex = 20;
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
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnNEW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNEW.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNEW.Image = IMS.My.Resources.Resources._New;
			this.btnNEW.Location = new System.Drawing.Point(129, 2);
			this.btnNEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNEW.Name = "btnNEW";
			this.btnNEW.Size = new System.Drawing.Size(120, 50);
			this.btnNEW.TabIndex = 4;
			this.btnNEW.Text = "New";
			this.btnNEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNEW.UseVisualStyleBackColor = false;
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
			this.btnSEARCH.TabIndex = 3;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.dtpEFFDTTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.dtpEFFDTFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbITMCDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbITMCDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label15, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label9, 2, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 2;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(774, 56);
			this.TableLayoutPanel2.TabIndex = 3;
			this.dtpEFFDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDTTO.Location = new System.Drawing.Point(440, 32);
			this.dtpEFFDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDTTO.Name = "dtpEFFDTTO";
			this.dtpEFFDTTO.Size = new System.Drawing.Size(104, 22);
			this.dtpEFFDTTO.TabIndex = 21;
			this.dtpEFFDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDTFR.Location = new System.Drawing.Point(78, 32);
			this.dtpEFFDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDTFR.Name = "dtpEFFDTFR";
			this.dtpEFFDTFR.Size = new System.Drawing.Size(104, 22);
			this.dtpEFFDTFR.TabIndex = 21;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 35);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(37, 16);
			this.Label1.TabIndex = 21;
			this.Label1.Text = "Date";
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(441, 2);
			this.cbITMCDTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbITMCDTO.Name = "cbITMCDTO";
			this.cbITMCDTO.SelectedIndex = -1;
			this.cbITMCDTO.SelectedItem = null;
			this.cbITMCDTO.SelectedValue = null;
			this.cbITMCDTO.Size = new System.Drawing.Size(329, 26);
			this.cbITMCDTO.TabIndex = 22;
			this.cbITMCDTO.TextMultiline = true;
			this.cbITMCDTO.ValueMember = null;
			this.cbITMCDTO.WhereClause = null;
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(78, 2);
			this.cbITMCDFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCDFR.Name = "cbITMCDFR";
			this.cbITMCDFR.SelectedIndex = -1;
			this.cbITMCDFR.SelectedItem = null;
			this.cbITMCDFR.SelectedValue = null;
			this.cbITMCDFR.Size = new System.Drawing.Size(325, 26);
			this.cbITMCDFR.TabIndex = 21;
			this.cbITMCDFR.TextMultiline = true;
			this.cbITMCDFR.ValueMember = null;
			this.cbITMCDFR.WhereClause = null;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 7);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(69, 16);
			this.Label15.TabIndex = 1;
			this.Label15.Text = "Item Code";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(409, 7);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(25, 16);
			this.Label2.TabIndex = 23;
			this.Label2.Text = "To";
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(409, 35);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(25, 16);
			this.Label9.TabIndex = 5;
			this.Label9.Text = "To";
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 130);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 10;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1329, 478);
			this.dgvHEADER.TabIndex = 2;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel6);
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Controls.Add(this.TableLayoutPanel5);
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(2, 3);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1346, 634);
			this.Panel1.TabIndex = 25;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 2;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 1, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(8, 8);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(256, 54);
			this.TableLayoutPanel6.TabIndex = 14;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(4, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(132, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 16;
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
			this.TableLayoutPanel1.Controls.Add(this.numSEQNO, 2, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblEFFDT, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblSUPIDFR, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtMODE, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbSUPID, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCD, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.dgvDETAILS, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblREVNO, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpEFFDT, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.numPRCNT, 3, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblQTY, 3, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 2, 5);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(8, 70);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 7;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(738, 397);
			this.TableLayoutPanel1.TabIndex = 0;
			this.numSEQNO.AllowNegative = false;
			this.numSEQNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSEQNO.DataChanged = false;
			this.numSEQNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numSEQNO.Location = new System.Drawing.Point(447, 369);
			this.numSEQNO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numSEQNO.Name = "numSEQNO";
			this.numSEQNO.NumberFormat = "8.0";
			this.numSEQNO.Size = new System.Drawing.Size(91, 23);
			this.numSEQNO.TabIndex = 15;
			this.numSEQNO.Text = "0";
			this.numSEQNO.ThousandSeperator = false;
			this.numSEQNO.Value = 0.0;
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 5);
			this.txtREMRK.Location = new System.Drawing.Point(86, 31);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(551, 39);
			this.txtREMRK.TabIndex = 15;
			this.lblEFFDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEFFDT.AutoSize = true;
			this.lblEFFDT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEFFDT.Location = new System.Drawing.Point(446, 6);
			this.lblEFFDT.Name = "lblEFFDT";
			this.lblEFFDT.Size = new System.Drawing.Size(91, 16);
			this.lblEFFDT.TabIndex = 15;
			this.lblEFFDT.Text = "Effective Date";
			this.lblSUPIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSUPIDFR.AutoSize = true;
			this.lblSUPIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSUPIDFR.Location = new System.Drawing.Point(3, 347);
			this.lblSUPIDFR.Name = "lblSUPIDFR";
			this.lblSUPIDFR.Size = new System.Drawing.Size(77, 16);
			this.lblSUPIDFR.TabIndex = 15;
			this.lblSUPIDFR.Text = "Supplier ID ";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 6);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(69, 16);
			this.Label3.TabIndex = 15;
			this.Label3.Text = "Item Code";
			this.txtMODE.Location = new System.Drawing.Point(706, 3);
			this.txtMODE.Name = "txtMODE";
			this.txtMODE.Size = new System.Drawing.Size(29, 22);
			this.txtMODE.TabIndex = 17;
			this.txtMODE.Text = "-1";
			this.txtMODE.Visible = false;
			this.cbSUPID.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbSUPID, 2);
			this.cbSUPID.ComboboxWidth = 170;
			this.cbSUPID.DataTable = null;
			this.cbSUPID.DisplayMember = null;
			this.cbSUPID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPID.HasBlankValue = true;
			this.cbSUPID.Location = new System.Drawing.Point(3, 367);
			this.cbSUPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbSUPID.Name = "cbSUPID";
			this.cbSUPID.SelectedIndex = -1;
			this.cbSUPID.SelectedItem = null;
			this.cbSUPID.SelectedValue = null;
			this.cbSUPID.Size = new System.Drawing.Size(437, 28);
			this.cbSUPID.TabIndex = 15;
			this.cbSUPID.TextMultiline = true;
			this.cbSUPID.ValueMember = null;
			this.cbSUPID.WhereClause = null;
			this.cbITMCD.BlankValue = null;
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = false;
			this.cbITMCD.Location = new System.Drawing.Point(86, 2);
			this.cbITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(331, 25);
			this.cbITMCD.TabIndex = 15;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.dgvDETAILS.AllowUserToAddRows = false;
			this.dgvDETAILS.AllowUserToDeleteRows = false;
			this.dgvDETAILS.AllowUserToResizeRows = false;
			this.dgvDETAILS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDETAILS, 6);
			this.dgvDETAILS.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvDETAILS.Location = new System.Drawing.Point(4, 84);
			this.dgvDETAILS.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvDETAILS.MultiSelect = false;
			this.dgvDETAILS.Name = "dgvDETAILS";
			this.dgvDETAILS.ReadOnly = true;
			this.dgvDETAILS.RowHeadersVisible = false;
			this.dgvDETAILS.RowHeadersWidth = 10;
			this.dgvDETAILS.RowTemplate.Height = 24;
			this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDETAILS.Size = new System.Drawing.Size(730, 249);
			this.dgvDETAILS.TabIndex = 6;
			this.lblREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREVNO.AutoSize = true;
			this.lblREVNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblREVNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREVNO.Location = new System.Drawing.Point(4, 42);
			this.lblREVNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblREVNO.Name = "lblREVNO";
			this.lblREVNO.Size = new System.Drawing.Size(64, 17);
			this.lblREVNO.TabIndex = 2;
			this.lblREVNO.Text = "Remarks";
			this.dtpEFFDT.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDT.Location = new System.Drawing.Point(548, 2);
			this.dtpEFFDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDT.Name = "dtpEFFDT";
			this.dtpEFFDT.Size = new System.Drawing.Size(104, 22);
			this.dtpEFFDT.TabIndex = 16;
			this.numPRCNT.AllowNegative = false;
			this.numPRCNT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPRCNT.DataChanged = false;
			this.numPRCNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numPRCNT.Location = new System.Drawing.Point(549, 369);
			this.numPRCNT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numPRCNT.Name = "numPRCNT";
			this.numPRCNT.NumberFormat = "8.0";
			this.numPRCNT.Size = new System.Drawing.Size(91, 23);
			this.numPRCNT.TabIndex = 9;
			this.numPRCNT.Text = "0";
			this.numPRCNT.ThousandSeperator = false;
			this.numPRCNT.Value = 0.0;
			this.lblQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblQTY.AutoSize = true;
			this.lblQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQTY.Location = new System.Drawing.Point(549, 346);
			this.lblQTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQTY.Name = "lblQTY";
			this.lblQTY.Size = new System.Drawing.Size(81, 17);
			this.lblQTY.TabIndex = 6;
			this.lblQTY.Text = "Percentage";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(447, 346);
			this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(94, 17);
			this.Label4.TabIndex = 15;
			this.Label4.Text = "Sequence No";
			this.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 3;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnSORT, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnADD, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(7, 470);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(382, 54);
			this.TableLayoutPanel5.TabIndex = 13;
			this.btnSORT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSORT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSORT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSORT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSORT.Image = (System.Drawing.Image)resources.GetObject("btnSORT.Image");
			this.btnSORT.Location = new System.Drawing.Point(259, 2);
			this.btnSORT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSORT.Name = "btnSORT";
			this.btnSORT.Size = new System.Drawing.Size(120, 48);
			this.btnSORT.TabIndex = 64;
			this.btnSORT.Text = "Sort";
			this.btnSORT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSORT.UseVisualStyleBackColor = false;
			this.btnADD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnADD.Image = IMS.My.Resources.Resources.Save;
			this.btnADD.Location = new System.Drawing.Point(4, 2);
			this.btnADD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(120, 50);
			this.btnADD.TabIndex = 12;
			this.btnADD.Text = "Add";
			this.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnADD.UseVisualStyleBackColor = false;
			this.btnREMOVE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(132, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 13;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Location = new System.Drawing.Point(16, 634);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 2;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(0, 0);
			this.TableLayoutPanel3.TabIndex = 2;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmMAEPAL";
			base.Tag = "MAEPAL";
			this.Text = "Purchase Allocation Master";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).EndInit();
			this.TableLayoutPanel5.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void frmMAEPAL_FormClosing(object sender, FormClosingEventArgs e)
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

		private void BindComboHeader()
		{
			cbITMCDFR.DataTable = "MAPAL_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAPAL_ITMCD = MAITM_ITMCD ";
			cbITMCDFR.ValueMember = "MAPAL_ITMCD";
			cbITMCDFR.DisplayMember = "MAPAL_ITMCD";
			cbITMCDFR.LoadData();
			cbITMCDTO.DataTable = "MAPAL_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAPAL_ITMCD = MAITM_ITMCD ";
			cbITMCDTO.ValueMember = "MAPAL_ITMCD";
			cbITMCDTO.DisplayMember = "MAPAL_ITMCD";
			cbITMCDTO.LoadData();
		}

		private void BindComboBox()
		{
			cbITMCD.DataTable = "MAITM_TBL  WITH (NOLOCK) ";
			cbITMCD.WhereClause = "MAITM_ITMTY = '0' AND MAITM_ACTFG = -1";
			cbITMCD.ValueMember = "MAITM_ITMCD";
			cbITMCD.DisplayMember = "MAITM_ITMCD";
			cbITMCD.LoadData();
			cbSUPID.DataTable = "MASUP_TBL  WITH (NOLOCK) ";
			cbSUPID.ValueMember = "MASUP_SUPID";
			cbSUPID.DisplayMember = "MASUP_SHORT";
			cbSUPID.LoadData();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAEPAL_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Header();
		}

		private void RefreshGridDetails()
		{
			int i = 0;
			dgvDETAILS.DataSource = null;
			string strSQL = "EXEC spMAPAL_DETAILS ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDT.Value) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvDETAILS.ClearSelection();
					DataGridView dataGridView = dgvDETAILS;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sequence No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Name");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Percentage");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.Refresh();
					dataGridView.Rows[0].Selected = true;
					dataGridView = null;
				}
			}
		}

		private void Header()
		{
			int i = 0;
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spMAPAL ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCDTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDTTO.Value) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvHEADER.ClearSelection();
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Description");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Enter By");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Update By");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.Refresh();
					dataGridView = null;
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnNEW_Click(object sender, EventArgs e)
		{
			ClearDetails();
			BindComboBox();
			txtMODE.Text = Conversions.ToString(-1);
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void ClearDetails()
		{
			dgvDETAILS.DataSource = null;
			cbSUPID.SelectedIndex = -1;
			numPRCNT.Value = 0.0;
			numSEQNO.Value = 0.0;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			if (dgvDETAILS.Rows.Count > 0 && !checkPercentage(1))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Percentage must 100%!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			ClearDetails();
			ClearControl();
			BindComboHeader();
			Header();
			txtMODE.Text = Conversions.ToString(-1);
			Panel1.Visible = false;
			Panel2.Visible = true;
		}

		private void ClearControl()
		{
			cbITMCD.Enabled = true;
			dtpEFFDT.Enabled = true;
			txtREMRK.Enabled = true;
		}

		private bool checkPercentage(int mode)
		{
			int total = 0;
			checked
			{
				int num = dgvDETAILS.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectNotEqual(cbSUPID.SelectedValue, dgvDETAILS.Rows[i].Cells["MAPAL_SUPID"].Value, false))
					{
						total = (int)Math.Round((double)total + Conversions.ToDouble(Common.gfValidSQLStr(dgvDETAILS.Rows[i].Cells["MAPAL_PRCNT"].Value.ToString())));
					}
				}
				total = (int)Math.Round((double)total + numPRCNT.Value);
				if (total > 100)
				{
					return false;
				}
				return true;
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindHeadertoControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void BindHeadertoControl()
		{
			cbITMCD.SelectedValue = dgvHEADER.CurrentRow.Cells["MAPAL_ITMCD"].Value.ToString();
			dtpEFFDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["MAPAL_EFFDT"].Value.ToString());
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["MAPAL_REMARK"].Value.ToString();
			txtMODE.Text = Conversions.ToString(0);
			RefreshGridDetails();
			cbITMCD.Enabled = false;
			dtpEFFDT.Enabled = false;
		}

		private void btnADD_Click(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(cbSUPID.SelectedItem, new object[1] { 1 }, null), null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbSUPID.Select();
				return;
			}
			if (numPRCNT.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Percentage cannot be 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				numPRCNT.Select();
				return;
			}
			if (dgvDETAILS.Rows.Count > 0 && !checkPercentage(0))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Percentage already exceed 100%!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				numPRCNT.Select();
				return;
			}
			if (Conversions.ToDouble(txtMODE.Text) == -1.0)
			{
				string strSQL = "SELECT * FROM MAPAL_TBL ";
				strSQL = strSQL + "WHERE MAPAL_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				strSQL = strSQL + "AND MAPAL_EFFDT = '" + Common.gfSQLDate(dtpEFFDT.Value) + "'";
				if (DB.RecordExists(strSQL))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "This Item & Effective Date already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
			}
			if (!Conversions.ToBoolean(Operators.NotObject(spMAEPAL())))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record edited!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				RefreshGridDetails();
				txtMODE.Text = Conversions.ToString(0);
				cbITMCD.Enabled = false;
				dtpEFFDT.Enabled = false;
				txtREMRK.Enabled = false;
			}
		}

		private object spMAEPAL()
		{
			OleDbCommand cmd = new OleDbCommand();
			Cursor = Cursors.WaitCursor;
			string strSQL = "EXEC spMAEPAL ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtREMRK.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbSUPID.SelectedValue)) + "', ";
			strSQL = strSQL + " " + Conversions.ToString(Conversion.Val(numPRCNT.Value)) + ", ";
			strSQL = strSQL + " " + Conversions.ToString(Conversion.Val(numSEQNO.Value)) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "' ";
			object spMAEPAL;
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
				spMAEPAL = false;
				ProjectData.ClearProjectError();
				goto IL_0189;
			}
			Cursor = Cursors.Default;
			spMAEPAL = true;
			goto IL_0189;
			IL_0189:
			return spMAEPAL;
		}

		private void cbITMCDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbITMCDFR.SelectedIndex != -1)
			{
				cbITMCDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbITMCDFR.SelectedValue);
			}
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			if (cbSUPID.SelectedValue == null)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbSUPID.SelectedValue, null, "Trim", new object[0], null, null, null), string.Empty, false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier");
			strMSG = Conversions.ToString(Operators.ConcatenateObject(strMSG, Operators.ConcatenateObject(" : ", cbSUPID.SelectedValue)));
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
			{
				return;
			}
			try
			{
				string strSQL = "DELETE MAPAL_TBL ";
				strSQL = strSQL + "WHERE MAPAL_RECID = '" + dgvDETAILS.CurrentRow.Cells["MAPAL_RECID"].Value.ToString() + "' ";
				strSQL = strSQL + "AND MAPAL_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				strSQL = strSQL + "AND MAPAL_EFFDT = '" + Common.gfSQLDate(dtpEFFDT.Value) + "' ";
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
			ClearDetails();
			RefreshGridDetails();
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
				string strSQL = "DELETE MAPAL_TBL ";
				strSQL = strSQL + "WHERE MAPAL_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				strSQL = strSQL + "AND MAPAL_EFFDT = '" + Common.gfSQLDate(dtpEFFDT.Value) + "' ";
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
			ClearDetails();
			ClearControl();
			BindComboHeader();
			Header();
		}

		private void dgvDETAILS_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			cbSUPID.SelectedValue = dgvDETAILS.CurrentRow.Cells["MAPAL_SUPID"].Value.ToString();
			numPRCNT.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["MAPAL_PRCNT"].Value.ToString());
			numSEQNO.Value = Conversions.ToDouble(dgvDETAILS.CurrentRow.Cells["MAPAL_SEQNO"].Value.ToString());
		}

		private void btnSORT_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			Cursor = Cursors.WaitCursor;
			string strSQL = "EXEC spMAPAL_SORT ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDT.Value) + "' ";
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
			}
			Cursor = Cursors.Default;
			RefreshGridDetails();
		}
	}
}
