using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmLM1PRGX : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvLPRGX")]
		private DataGridView _dgvLPRGX;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdClose")]
		private Button _cmdClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdDelete")]
		private Button _cmdDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdSave")]
		private Button _cmdSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lkpUSRID")]
		private LookupControl _lkpUSRID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvLPRGX
		{
			[CompilerGenerated]
			get
			{
				return _dgvLPRGX;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dgvLPRGX_DoubleClick;
				DataGridView dataGridView = _dgvLPRGX;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick -= value2;
				}
				_dgvLPRGX = value;
				dataGridView = _dgvLPRGX;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick += value2;
				}
			}
		}

		internal virtual Button cmdClose
		{
			[CompilerGenerated]
			get
			{
				return _cmdClose;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdClose_Click;
				Button button = _cmdClose;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdClose = value;
				button = _cmdClose;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdCancel
		{
			[CompilerGenerated]
			get
			{
				return _cmdCancel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdCancel_Click;
				Button button = _cmdCancel;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdCancel = value;
				button = _cmdCancel;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdDelete
		{
			[CompilerGenerated]
			get
			{
				return _cmdDelete;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdDelete_Click;
				Button button = _cmdDelete;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdDelete = value;
				button = _cmdDelete;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdSave
		{
			[CompilerGenerated]
			get
			{
				return _cmdSave;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdSave_Click;
				Button button = _cmdSave;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdSave = value;
				button = _cmdSave;
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
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

		internal virtual LookupControl lkpUSRID
		{
			[CompilerGenerated]
			get
			{
				return _lkpUSRID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				LookupControl.AfterLookupEventHandler obj = lkpUSRID_AfterLookup;
				LookupControl.LeftWithModifiedEventHandler obj2 = lkpUSRID_LeftWithModified;
				LookupControl lookupControl = _lkpUSRID;
				if (lookupControl != null)
				{
					lookupControl.AfterLookup -= obj;
					lookupControl.LeftWithModified -= obj2;
				}
				_lkpUSRID = value;
				lookupControl = _lkpUSRID;
				if (lookupControl != null)
				{
					lookupControl.AfterLookup += obj;
					lookupControl.LeftWithModified += obj2;
				}
			}
		}

		[field: AccessedThroughProperty("cmbLEVEL")]
		internal virtual ComboBox cmbLEVEL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpPRGID")]
		internal virtual LookupControl lkpPRGID
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

		public frmLM1PRGX()
		{
			base.FormClosing += frmLM1PRGX_FormClosing;
			base.Load += frmLM1PRGX_Load;
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lkpPRGID = new IMS.LookupControl();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.cmbLEVEL = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvLPRGX = new System.Windows.Forms.DataGridView();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.lkpUSRID = new IMS.LookupControl();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvLPRGX).BeginInit();
			base.SuspendLayout();
			this.cmdClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdClose.Image = IMS.My.Resources.Resources.Close;
			this.cmdClose.Location = new System.Drawing.Point(388, 4);
			this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(120, 50);
			this.cmdClose.TabIndex = 6;
			this.cmdClose.Text = "Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(260, 4);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(120, 50);
			this.cmdCancel.TabIndex = 5;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdSave.Image = IMS.My.Resources.Resources.Save;
			this.cmdSave.Location = new System.Drawing.Point(4, 4);
			this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(120, 50);
			this.cmdSave.TabIndex = 3;
			this.cmdSave.Text = "Save";
			this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdSave.UseVisualStyleBackColor = false;
			this.cmdDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdDelete.Image = IMS.My.Resources.Resources.Delete;
			this.cmdDelete.Location = new System.Drawing.Point(132, 4);
			this.cmdDelete.Margin = new System.Windows.Forms.Padding(4);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(120, 50);
			this.cmdDelete.TabIndex = 4;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdDelete.UseVisualStyleBackColor = false;
			this.Panel1.AutoScroll = true;
			this.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1350, 631);
			this.Panel1.TabIndex = 5;
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.lkpPRGID, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.btnSEARCH, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.cmbLEVEL, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.dgvLPRGX, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lkpUSRID, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1055, 621);
			this.TableLayoutPanel1.TabIndex = 32;
			this.lkpPRGID.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpPRGID.AllowBlank = false;
			this.lkpPRGID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lkpPRGID.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpPRGID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpPRGID.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpPRGID.DescriptionVisible1 = true;
			this.lkpPRGID.DescriptionVisible2 = false;
			this.lkpPRGID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpPRGID.KeyValue = "";
			this.lkpPRGID.LKPCD = "PRGID";
			this.lkpPRGID.Location = new System.Drawing.Point(133, 478);
			this.lkpPRGID.Margin = new System.Windows.Forms.Padding(5);
			this.lkpPRGID.MaxLength = 0;
			this.lkpPRGID.Modified = false;
			this.lkpPRGID.Multiline_ = false;
			this.lkpPRGID.Name = "lkpPRGID";
			this.lkpPRGID.PasswordChar = "\0";
			this.lkpPRGID.ReadOnly_ = false;
			this.lkpPRGID.Size = new System.Drawing.Size(747, 23);
			this.lkpPRGID.TabIndex = 34;
			this.lkpPRGID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpPRGID.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpPRGID.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpPRGID.TextHeight = 23;
			this.lkpPRGID.TextWidth = 150;
			this.lkpPRGID.Where1 = null;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnSEARCH.Location = new System.Drawing.Point(889, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(90, 32);
			this.btnSEARCH.TabIndex = 33;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.cmbLEVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLEVEL.FormattingEnabled = true;
			this.cmbLEVEL.Items.AddRange(new object[4] { "Read Only", "Add", "Add, Edit", "Add, Edit, Delete" });
			this.cmbLEVEL.Location = new System.Drawing.Point(131, 509);
			this.cmbLEVEL.Name = "cmbLEVEL";
			this.cmbLEVEL.Size = new System.Drawing.Size(177, 24);
			this.cmbLEVEL.TabIndex = 51;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 10);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(53, 16);
			this.Label6.TabIndex = 50;
			this.Label6.Text = "User ID";
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 2);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cmdSave, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdCancel, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdDelete, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdClose, 3, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 559);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(517, 58);
			this.TableLayoutPanel2.TabIndex = 33;
			this.dgvLPRGX.AllowUserToAddRows = false;
			this.dgvLPRGX.AllowUserToDeleteRows = false;
			this.dgvLPRGX.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvLPRGX.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLPRGX.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvLPRGX.ColumnHeadersHeight = 25;
			this.dgvLPRGX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvLPRGX, 3);
			this.dgvLPRGX.Location = new System.Drawing.Point(4, 40);
			this.dgvLPRGX.Margin = new System.Windows.Forms.Padding(4);
			this.dgvLPRGX.MultiSelect = false;
			this.dgvLPRGX.Name = "dgvLPRGX";
			this.dgvLPRGX.ReadOnly = true;
			this.dgvLPRGX.RowHeadersWidth = 20;
			this.dgvLPRGX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvLPRGX.RowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvLPRGX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLPRGX.Size = new System.Drawing.Size(1040, 429);
			this.dgvLPRGX.TabIndex = 0;
			this.dgvLPRGX.TabStop = false;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(4, 479);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(120, 20);
			this.Label7.TabIndex = 31;
			this.Label7.Text = "Program ID";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(4, 511);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Access Level";
			this.lkpUSRID.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpUSRID.AllowBlank = false;
			this.lkpUSRID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lkpUSRID.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpUSRID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpUSRID.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpUSRID.DescriptionVisible1 = true;
			this.lkpUSRID.DescriptionVisible2 = false;
			this.lkpUSRID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpUSRID.KeyValue = "";
			this.lkpUSRID.LKPCD = "USRID";
			this.lkpUSRID.Location = new System.Drawing.Point(133, 6);
			this.lkpUSRID.Margin = new System.Windows.Forms.Padding(5);
			this.lkpUSRID.MaxLength = 0;
			this.lkpUSRID.Modified = false;
			this.lkpUSRID.Multiline_ = false;
			this.lkpUSRID.Name = "lkpUSRID";
			this.lkpUSRID.PasswordChar = "\0";
			this.lkpUSRID.ReadOnly_ = false;
			this.lkpUSRID.Size = new System.Drawing.Size(548, 23);
			this.lkpUSRID.TabIndex = 33;
			this.lkpUSRID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpUSRID.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpUSRID.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpUSRID.TextHeight = 23;
			this.lkpUSRID.TextWidth = 150;
			this.lkpUSRID.Where1 = null;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmLM1PRGX";
			this.Text = "Program Control by User";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvLPRGX).EndInit();
			base.ResumeLayout(false);
		}

		private void frmLM1PRGX_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmLM1PRGX_Load(object sender, EventArgs e)
		{
			SetMaxLength();
			RefreshGrid();
			ClearFormData();
		}

		private void SetMaxLength()
		{
			lkpUSRID.MaxLength = DB.CharColumnMaxLength("LPRGX_TBL", "LPRGX_USRID");
			lkpPRGID.MaxLength = DB.CharColumnMaxLength("LPRGX_TBL", "LPRGX_PRGID");
		}

		private void RefreshGrid()
		{
			DataTable dt = new DataTable();
			string strSQL = "LPRGX_PRGID, LPRG_DESC, LPRGX_LEVEL, ";
			strSQL += "CASE WHEN LPRGX_LEVEL = 0 THEN 'READ ONLY' WHEN LPRGX_LEVEL = 1 THEN 'ADD' ";
			strSQL += "WHEN LPRGX_LEVEL = 2 THEN 'ADD, EDIT' WHEN LPRGX_LEVEL = 3 THEN 'ADD, EDIT, DELETE' ELSE '' END AS XLEVEL";
			dt = DB.GetTable(strSQL, "LPRGX_TBL LEFT JOIN LPRG_TBL ON LPRGX_PRGID = LPRG_PRGID", "LPRGX_USRID = '" + lkpUSRID.KeyValue + "'", "LPRGX_PRGID");
			DataGridView dataGridView = dgvLPRGX;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 80;
			dataGridView.Columns[0].HeaderText = "Program ID";
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 200;
			dataGridView.Columns[1].HeaderText = "Description";
			dataGridView.Columns[2].Visible = false;
			dataGridView.Columns[3].Visible = true;
			dataGridView.Columns[3].Width = 200;
			dataGridView.Columns[3].HeaderText = "Access Level";
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void ClearFormData()
		{
			lkpPRGID.KeyValue = "";
			lkpPRGID.RefreshDescription();
			cmbLEVEL.SelectedIndex = 0;
			lkpPRGID.Focus();
		}

		private bool DeleteRecord()
		{
			bool DeleteRecord;
			try
			{
				string strSQL = "DELETE LPRGX_TBL ";
				strSQL = strSQL + "WHERE LPRGX_USRID = '" + lkpUSRID.KeyValue + "' ";
				strSQL = strSQL + "AND LPRGX_PRGID = '" + lkpPRGID.KeyValue + "'";
				DeleteRecord = (DB.DBExecute(strSQL) ? true : false);
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message + "\r\nRecord not deleted!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				DeleteRecord = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				DeleteRecord = false;
				ProjectData.ClearProjectError();
			}
			return DeleteRecord;
		}

		private bool ValidKeyField()
		{
			if (!lkpPRGID.IsValid())
			{
				MessageBox.Show("Invalid Program ID!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpPRGID.Focus();
				return false;
			}
			if (cmbLEVEL.SelectedIndex == -1)
			{
				MessageBox.Show("Please select a Access Level!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cmbLEVEL.Focus();
				return false;
			}
			return true;
		}

		private bool SaveRecord()
		{
			bool SaveRecord;
			try
			{
				string strSQL = "SELECT * FROM LPRGX_TBL ";
				strSQL = strSQL + "WHERE LPRGX_USRID = '" + lkpUSRID.KeyValue + "' ";
				strSQL = strSQL + "AND LPRGX_PRGID = '" + lkpPRGID.KeyValue + "'";
				if (!DB.RecordExists(strSQL))
				{
					strSQL = "INSERT LPRGX_TBL(";
					strSQL += "LPRGX_USRID, LPRGX_PRGID, LPRGX_LEVEL, LPRGX_LUPBY, LPRGX_LUPDT) ";
					strSQL += "VALUES (";
					strSQL = strSQL + "'" + lkpUSRID.KeyValue + "', '" + lkpPRGID.KeyValue + "', " + Conversions.ToString(cmbLEVEL.SelectedIndex) + ", '" + PublicVar.gstrLogonID + "', GETDATE())";
				}
				else
				{
					strSQL = "UPDATE LPRGX_TBL SET ";
					strSQL = strSQL + "LPRGX_LEVEL = " + Conversions.ToString(cmbLEVEL.SelectedIndex) + ", ";
					strSQL = strSQL + "LPRGX_LUPBY = '" + PublicVar.gstrLogonID + "', ";
					strSQL += "LPRGX_LUPDT = GETDATE() ";
					strSQL = strSQL + "WHERE LPRGX_USRID = '" + lkpUSRID.KeyValue + "' ";
					strSQL = strSQL + "AND LPRGX_PRGID = '" + lkpPRGID.KeyValue + "'";
				}
				SaveRecord = DB.DBExecute(strSQL);
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message + "\r\nRecord not deleted!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				SaveRecord = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				SaveRecord = false;
				ProjectData.ClearProjectError();
			}
			return SaveRecord;
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (ValidKeyField())
			{
				if (!SaveRecord())
				{
					MessageBox.Show("Record not edited!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				MessageBox.Show("Record edited!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefreshGrid();
				ClearFormData();
			}
		}

		private void ShowGridData()
		{
			DataGridView dataGridView = dgvLPRGX;
			lkpPRGID.KeyValue = Conversions.ToString(dataGridView[0, dataGridView.CurrentCell.RowIndex].Value);
			lkpPRGID.RefreshDescription();
			cmbLEVEL.SelectedIndex = Conversions.ToInteger(dataGridView[2, dataGridView.CurrentCell.RowIndex].Value);
			dataGridView = null;
		}

		private void dgvLPRGX_DoubleClick(object sender, EventArgs e)
		{
			if (dgvLPRGX.CurrentRow.Index >= 0)
			{
				ShowGridData();
			}
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			ClearFormData();
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM LPRGX_TBL ";
			strSQL = strSQL + "WHERE LPRGX_USRID = '" + lkpUSRID.KeyValue + "' ";
			strSQL = strSQL + "AND LPRGX_PRGID = '" + lkpPRGID.KeyValue + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show("Record not exists!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpPRGID.Focus();
			}
			else if (!DeleteRecord())
			{
				MessageBox.Show("Record not deleted!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpPRGID.Focus();
			}
			else
			{
				MessageBox.Show("Record deleted!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefreshGrid();
				ClearFormData();
			}
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			RefreshGrid();
		}

		private void lkpUSRID_AfterLookup(bool Cancel)
		{
			RefreshGrid();
		}

		private void lkpUSRID_LeftWithModified()
		{
			lkpUSRID.Modified = false;
			RefreshGrid();
		}
	}
}
