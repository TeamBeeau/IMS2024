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
	public class frmLM1XCS : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdRemove1")]
		private Button _cmdRemove1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdSelect1")]
		private Button _cmdSelect1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdRemove2")]
		private Button _cmdRemove2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdSelect2")]
		private Button _cmdSelect2;

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
		[AccessedThroughProperty("cmdSave")]
		private Button _cmdSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdRefresh")]
		private Button _cmdRefresh;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvLXCS")]
		internal virtual DataGridView dgvLXCS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpGRPCD")]
		internal virtual LookupControl lkpGRPCD
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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvLPGP")]
		internal virtual DataGridView dgvLPGP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button cmdRemove1
		{
			[CompilerGenerated]
			get
			{
				return _cmdRemove1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdRemove1_Click;
				Button button = _cmdRemove1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdRemove1 = value;
				button = _cmdRemove1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdSelect1
		{
			[CompilerGenerated]
			get
			{
				return _cmdSelect1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdSelect1_Click;
				Button button = _cmdSelect1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdSelect1 = value;
				button = _cmdSelect1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdRemove2
		{
			[CompilerGenerated]
			get
			{
				return _cmdRemove2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdRemove2_Click;
				Button button = _cmdRemove2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdRemove2 = value;
				button = _cmdRemove2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdSelect2
		{
			[CompilerGenerated]
			get
			{
				return _cmdSelect2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdSelect2_Click;
				Button button = _cmdSelect2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdSelect2 = value;
				button = _cmdSelect2;
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual Button cmdRefresh
		{
			[CompilerGenerated]
			get
			{
				return _cmdRefresh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdRefresh_Click;
				Button button = _cmdRefresh;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdRefresh = value;
				button = _cmdRefresh;
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

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmLM1XCS()
		{
			base.FormClosing += frmLM1XCS_FormClosing;
			base.Load += frmLM1XCS_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMS.frmLM1XCS));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label7 = new System.Windows.Forms.Label();
			this.lkpGRPCD = new IMS.LookupControl();
			this.cmdRefresh = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.cmdSelect2 = new System.Windows.Forms.Button();
			this.cmdRemove2 = new System.Windows.Forms.Button();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.dgvLXCS = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cmdSelect1 = new System.Windows.Forms.Button();
			this.cmdRemove1 = new System.Windows.Forms.Button();
			this.dgvLPGP = new System.Windows.Forms.DataGridView();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvLXCS).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvLPGP).BeginInit();
			base.SuspendLayout();
			this.cmdClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdClose.Image = IMS.My.Resources.Resources.Close;
			this.cmdClose.Location = new System.Drawing.Point(260, 4);
			this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(120, 50);
			this.cmdClose.TabIndex = 47;
			this.cmdClose.Text = "Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdSave.Image = IMS.My.Resources.Resources.Save;
			this.cmdSave.Location = new System.Drawing.Point(4, 4);
			this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(120, 50);
			this.cmdSave.TabIndex = 44;
			this.cmdSave.Text = "Save";
			this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdSave.UseVisualStyleBackColor = false;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(132, 4);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(120, 50);
			this.cmdCancel.TabIndex = 45;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.Panel1.AutoScroll = true;
			this.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.lkpGRPCD);
			this.Panel1.Controls.Add(this.cmdRefresh);
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1350, 631);
			this.Panel1.TabIndex = 7;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(16, 16);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(120, 20);
			this.Label7.TabIndex = 32;
			this.Label7.Text = "Group Code";
			this.lkpGRPCD.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpGRPCD.AllowBlank = false;
			this.lkpGRPCD.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpGRPCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpGRPCD.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpGRPCD.DescriptionVisible1 = true;
			this.lkpGRPCD.DescriptionVisible2 = false;
			this.lkpGRPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpGRPCD.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpGRPCD.KeyValue = "";
			this.lkpGRPCD.LKPCD = "USRGRP";
			this.lkpGRPCD.Location = new System.Drawing.Point(137, 12);
			this.lkpGRPCD.Margin = new System.Windows.Forms.Padding(5);
			this.lkpGRPCD.MaxLength = 0;
			this.lkpGRPCD.Modified = false;
			this.lkpGRPCD.Multiline_ = false;
			this.lkpGRPCD.Name = "lkpGRPCD";
			this.lkpGRPCD.PasswordChar = "\0";
			this.lkpGRPCD.ReadOnly_ = false;
			this.lkpGRPCD.Size = new System.Drawing.Size(589, 22);
			this.lkpGRPCD.TabIndex = 0;
			this.lkpGRPCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpGRPCD.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpGRPCD.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpGRPCD.TextHeight = 22;
			this.lkpGRPCD.TextWidth = 207;
			this.lkpGRPCD.Where1 = null;
			this.cmdRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdRefresh.Image = IMS.My.Resources.Resources.Refresh;
			this.cmdRefresh.Location = new System.Drawing.Point(972, 4);
			this.cmdRefresh.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cmdRefresh.Name = "cmdRefresh";
			this.cmdRefresh.Size = new System.Drawing.Size(120, 50);
			this.cmdRefresh.TabIndex = 41;
			this.cmdRefresh.Text = "Refresh";
			this.cmdRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdRefresh.UseVisualStyleBackColor = false;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel4, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.dgvLXCS, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.dgvLPGP, 1, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(12, 59);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1096, 590);
			this.TableLayoutPanel1.TabIndex = 42;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel4, 2);
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.cmdSave, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.cmdClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.cmdCancel, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 502);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(413, 59);
			this.TableLayoutPanel4.TabIndex = 43;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.cmdSelect2, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.cmdRemove2, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(522, 426);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(261, 60);
			this.TableLayoutPanel3.TabIndex = 44;
			this.cmdSelect2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdSelect2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdSelect2.Image = IMS.My.Resources.Resources.check;
			this.cmdSelect2.Location = new System.Drawing.Point(4, 4);
			this.cmdSelect2.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSelect2.Name = "cmdSelect2";
			this.cmdSelect2.Size = new System.Drawing.Size(120, 50);
			this.cmdSelect2.TabIndex = 37;
			this.cmdSelect2.Text = "Select All";
			this.cmdSelect2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdSelect2.UseVisualStyleBackColor = false;
			this.cmdRemove2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdRemove2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdRemove2.Image = IMS.My.Resources.Resources.uncheck;
			this.cmdRemove2.Location = new System.Drawing.Point(132, 4);
			this.cmdRemove2.Margin = new System.Windows.Forms.Padding(4);
			this.cmdRemove2.Name = "cmdRemove2";
			this.cmdRemove2.Size = new System.Drawing.Size(120, 50);
			this.cmdRemove2.TabIndex = 38;
			this.cmdRemove2.Text = "Remove All";
			this.cmdRemove2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdRemove2.UseVisualStyleBackColor = false;
			this.Label13.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.Label13, 2);
			this.Label13.ForeColor = System.Drawing.Color.Red;
			this.Label13.Location = new System.Drawing.Point(4, 0);
			this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(1088, 16);
			this.Label13.TabIndex = 34;
			this.Label13.Text = resources.GetString("Label13.Text");
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.BackColor = System.Drawing.Color.Khaki;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(4, 16);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(137, 22);
			this.Label1.TabIndex = 39;
			this.Label1.Text = "User-Group";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.BackColor = System.Drawing.Color.Khaki;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(523, 16);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(137, 22);
			this.Label2.TabIndex = 40;
			this.Label2.Text = "Program-Group";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.dgvLXCS.AllowUserToAddRows = false;
			this.dgvLXCS.AllowUserToDeleteRows = false;
			this.dgvLXCS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvLXCS.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLXCS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvLXCS.ColumnHeadersHeight = 25;
			this.dgvLXCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvLXCS.Location = new System.Drawing.Point(4, 42);
			this.dgvLXCS.Margin = new System.Windows.Forms.Padding(4);
			this.dgvLXCS.MultiSelect = false;
			this.dgvLXCS.Name = "dgvLXCS";
			this.dgvLXCS.RowHeadersWidth = 20;
			this.dgvLXCS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvLXCS.RowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvLXCS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLXCS.Size = new System.Drawing.Size(511, 377);
			this.dgvLXCS.TabIndex = 2;
			this.dgvLXCS.TabStop = false;
			this.TableLayoutPanel2.ColumnCount = 2;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cmdSelect1, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdRemove1, 1, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 426);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(261, 60);
			this.TableLayoutPanel2.TabIndex = 43;
			this.cmdSelect1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdSelect1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdSelect1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdSelect1.Image = IMS.My.Resources.Resources.check;
			this.cmdSelect1.Location = new System.Drawing.Point(4, 4);
			this.cmdSelect1.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSelect1.Name = "cmdSelect1";
			this.cmdSelect1.Size = new System.Drawing.Size(120, 50);
			this.cmdSelect1.TabIndex = 35;
			this.cmdSelect1.Text = "Select All";
			this.cmdSelect1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdSelect1.UseVisualStyleBackColor = false;
			this.cmdRemove1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdRemove1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdRemove1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdRemove1.Image = IMS.My.Resources.Resources.uncheck;
			this.cmdRemove1.Location = new System.Drawing.Point(132, 4);
			this.cmdRemove1.Margin = new System.Windows.Forms.Padding(4);
			this.cmdRemove1.Name = "cmdRemove1";
			this.cmdRemove1.Size = new System.Drawing.Size(120, 50);
			this.cmdRemove1.TabIndex = 36;
			this.cmdRemove1.Text = "Remove All";
			this.cmdRemove1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdRemove1.UseVisualStyleBackColor = false;
			this.dgvLPGP.AllowUserToAddRows = false;
			this.dgvLPGP.AllowUserToDeleteRows = false;
			this.dgvLPGP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvLPGP.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLPGP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
			this.dgvLPGP.ColumnHeadersHeight = 25;
			this.dgvLPGP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvLPGP.Location = new System.Drawing.Point(523, 42);
			this.dgvLPGP.Margin = new System.Windows.Forms.Padding(4);
			this.dgvLPGP.MultiSelect = false;
			this.dgvLPGP.Name = "dgvLPGP";
			this.dgvLPGP.RowHeadersWidth = 20;
			this.dgvLPGP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvLPGP.RowsDefaultCellStyle = DataGridViewCellStyle4;
			this.dgvLPGP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLPGP.Size = new System.Drawing.Size(551, 377);
			this.dgvLPGP.TabIndex = 3;
			this.dgvLPGP.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmLM1XCS";
			this.Text = "User Access Maintenance";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvLXCS).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvLPGP).EndInit();
			base.ResumeLayout(false);
		}

		private void frmLM1XCS_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmLM1XCS_Load(object sender, EventArgs e)
		{
			SetMaxLength();
			ClearFormData();
		}

		private void SetMaxLength()
		{
			lkpGRPCD.MaxLength = DB.CharColumnMaxLength("LGRP_TBL", "LGRP_GRPCD");
		}

		private void RefreshGrid()
		{
			DataTable dt = new DataTable();
			if (Operators.CompareString(lkpGRPCD.KeyValue, "", false) != 0)
			{
				string strFields = "CONVERT(BIT, CASE WHEN LXCS_USRID IS NULL THEN 0 ELSE 1 END) AS CHK, LUSR_USRNM, LUSR_USRID";
				string strTable = "LUSR_TBL LEFT OUTER JOIN LXCS_TBL ON LUSR_USRID = LXCS_USRID AND LXCS_GRPCD = '" + lkpGRPCD.KeyValue + "'";
				dt = DB.GetTable(strFields, strTable, "", "LUSR_USRNM");
				DataGridView dataGridView = dgvLXCS;
				dataGridView.DataSource = dt;
				dataGridView.Columns[0].Visible = true;
				dataGridView.Columns[0].Width = 30;
				dataGridView.Columns[0].HeaderText = "";
				dataGridView.Columns[1].Visible = true;
				dataGridView.Columns[1].Width = 200;
				dataGridView.Columns[1].HeaderText = "Name";
				dataGridView.Columns[1].ReadOnly = true;
				dataGridView.Columns[2].Visible = true;
				dataGridView.Columns[2].Width = 80;
				dataGridView.Columns[2].HeaderText = "User ID";
				dataGridView.Columns[2].ReadOnly = true;
				dataGridView.AutoResizeRows();
				dataGridView.Refresh();
				dataGridView = null;
				strFields = "CONVERT(BIT, CASE WHEN LPGP_PRGID IS NULL THEN 0 ELSE 1 END) AS CHK, LPRG_DESC, LPRG_PRGID";
				strTable = "LPRG_TBL LEFT OUTER JOIN LPGP_TBL ON LPRG_PRGID = LPGP_PRGID AND LPGP_GRPCD = '" + lkpGRPCD.KeyValue + "'";
				dt = DB.GetTable(strFields, strTable, "", "LPRG_DESC");
				DataGridView dataGridView2 = dgvLPGP;
				dataGridView2.DataSource = dt;
				dataGridView2.Columns[0].Visible = true;
				dataGridView2.Columns[0].Width = 30;
				dataGridView2.Columns[0].HeaderText = "";
				dataGridView2.Columns[1].Visible = true;
				dataGridView2.Columns[1].Width = 230;
				dataGridView2.Columns[1].HeaderText = "Description";
				dataGridView2.Columns[1].ReadOnly = true;
				dataGridView2.Columns[2].Visible = true;
				dataGridView2.Columns[2].Width = 110;
				dataGridView2.Columns[2].HeaderText = "Program ID";
				dataGridView2.Columns[2].ReadOnly = true;
				dataGridView2.AutoResizeRows();
				dataGridView2.Refresh();
				dataGridView2 = null;
			}
		}

		private void ClearFormData()
		{
			lkpGRPCD.KeyValue = "ADMIN";
			lkpGRPCD.RefreshDescription();
			lkpGRPCD.Modified = false;
			dgvLXCS.DataSource = null;
			dgvLPGP.DataSource = null;
			lkpGRPCD.Focus();
		}

		private bool ValidKeyField()
		{
			if (Operators.CompareString(lkpGRPCD.KeyValue, "", false) == 0)
			{
				MessageBox.Show("Blank Group Code!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpGRPCD.Focus();
				return false;
			}
			return true;
		}

		private bool ValidAllField()
		{
			if (!ValidKeyField())
			{
				return false;
			}
			return true;
		}

		private bool SaveRecord()
		{
			checked
			{
				bool SaveRecord;
				try
				{
					if (MessageBox.Show("Save User-Group access?", "IMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						goto IL_02eb;
					}
					if (dgvLXCS.Rows.Count != 0)
					{
						DataTable dt = (DataTable)dgvLXCS.DataSource;
						int num = dt.Rows.Count - 1;
						int i = 0;
						while (true)
						{
							if (i > num)
							{
								MessageBox.Show("User-Group access saved.", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								break;
							}
							if (Operators.ConditionalCompareObjectEqual(dt.Rows[i]["CHK"], true, false))
							{
								string strSQL = "SELECT * FROM LXCS_TBL ";
								strSQL = strSQL + "WHERE LXCS_USRID = '" + dt.Rows[i]["LUSR_USRID"].ToString() + "' ";
								strSQL = strSQL + "AND LXCS_GRPCD = '" + lkpGRPCD.KeyValue + "'";
								if (DB.RecordExists(strSQL))
								{
									goto IL_02ca;
								}
								strSQL = "INSERT LXCS_TBL(";
								strSQL += "LXCS_USRID, LXCS_GRPCD, LXCS_LUPDT) ";
								strSQL += "VALUES (";
								strSQL = strSQL + "'" + dt.Rows[i]["LUSR_USRID"].ToString() + "', '" + lkpGRPCD.KeyValue + "', GETDATE())";
								if (DB.DBExecute(strSQL))
								{
									goto IL_02ca;
								}
								MessageBox.Show("Row:" + (i + 1) + " - " + dt.Rows[i]["LUSR_USRID"].ToString() + "\r\nRecord not edited!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								SaveRecord = false;
							}
							else
							{
								string strSQL = "DELETE LXCS_TBL ";
								strSQL = strSQL + "WHERE LXCS_USRID = '" + dt.Rows[i]["LUSR_USRID"].ToString() + "' ";
								strSQL = strSQL + "AND LXCS_GRPCD = '" + lkpGRPCD.KeyValue + "'";
								if (DB.DBExecute(strSQL))
								{
									goto IL_02ca;
								}
								MessageBox.Show("Row:" + (i + 1) + " - " + dt.Rows[i]["LUSR_USRID"].ToString() + "\r\nRecord not edited!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								SaveRecord = false;
							}
							goto end_IL_0001;
							IL_02ca:
							i++;
						}
						goto IL_02eb;
					}
					MessageBox.Show("No record!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					lkpGRPCD.Focus();
					SaveRecord = false;
					goto end_IL_0001;
					IL_02eb:
					if (MessageBox.Show("Save Program-Group access?", "IMS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
					{
						goto IL_05b1;
					}
					if (dgvLPGP.Rows.Count != 0)
					{
						DataTable dt = (DataTable)dgvLPGP.DataSource;
						int num2 = dt.Rows.Count - 1;
						int i = 0;
						while (true)
						{
							if (i > num2)
							{
								MessageBox.Show("Program-Group access saved.", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
								break;
							}
							if (Operators.ConditionalCompareObjectEqual(dt.Rows[i]["CHK"], true, false))
							{
								string strSQL = "SELECT * FROM LPGP_TBL ";
								strSQL = strSQL + "WHERE LPGP_PRGID = '" + dt.Rows[i]["LPRG_PRGID"].ToString() + "' ";
								strSQL = strSQL + "AND LPGP_GRPCD = '" + lkpGRPCD.KeyValue + "'";
								if (DB.RecordExists(strSQL))
								{
									goto IL_0590;
								}
								strSQL = "INSERT LPGP_TBL(";
								strSQL += "LPGP_PRGID, LPGP_GRPCD, LPGP_USRID, LPGP_LUPDT) ";
								strSQL += "VALUES (";
								strSQL = strSQL + "'" + dt.Rows[i]["LPRG_PRGID"].ToString() + "', '" + lkpGRPCD.KeyValue + "', '" + PublicVar.gstrLogonID + "', GETDATE())";
								if (DB.DBExecute(strSQL))
								{
									goto IL_0590;
								}
								MessageBox.Show("Row:" + (i + 1) + dt.Rows[i]["LPRG_PRGID"].ToString() + "\r\nRecord not edited!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								SaveRecord = false;
							}
							else
							{
								string strSQL = "DELETE LPGP_TBL ";
								strSQL = strSQL + "WHERE LPGP_PRGID = '" + dt.Rows[i]["LPRG_PRGID"].ToString() + "' ";
								strSQL = strSQL + "AND LPGP_GRPCD = '" + lkpGRPCD.KeyValue + "'";
								if (DB.DBExecute(strSQL))
								{
									goto IL_0590;
								}
								MessageBox.Show("Row:" + (i + 1) + dt.Rows[i]["LPRG_PRGID"].ToString() + "\r\nRecord not edited!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								SaveRecord = false;
							}
							goto end_IL_0001;
							IL_0590:
							i++;
						}
						goto IL_05b1;
					}
					MessageBox.Show("No record!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					lkpGRPCD.Focus();
					SaveRecord = false;
					goto end_IL_0001;
					IL_05b1:
					SaveRecord = true;
					end_IL_0001:;
				}
				catch (OleDbException ex3)
				{
					ProjectData.SetProjectError(ex3);
					OleDbException ex2 = ex3;
					MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message + "\r\nRecord not edited!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					SaveRecord = false;
					ProjectData.ClearProjectError();
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex = ex4;
					MessageBox.Show(ex.Message + "\r\nRecord not edited!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					SaveRecord = false;
					ProjectData.ClearProjectError();
				}
				return SaveRecord;
			}
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (ValidAllField() && SaveRecord())
			{
				ClearFormData();
			}
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			ClearFormData();
		}

		private void cmdRefresh_Click(object sender, EventArgs e)
		{
			RefreshGrid();
		}

		private void cmdSelect1_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dgvLXCS.DataSource;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dt.Rows[i]["CHK"] = true;
				}
				dgvLXCS.DataSource = dt;
			}
		}

		private void cmdRemove1_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dgvLXCS.DataSource;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dt.Rows[i]["CHK"] = false;
				}
				dgvLXCS.DataSource = dt;
			}
		}

		private void cmdSelect2_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dgvLPGP.DataSource;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dt.Rows[i]["CHK"] = true;
				}
				dgvLPGP.DataSource = dt;
			}
		}

		private void cmdRemove2_Click(object sender, EventArgs e)
		{
			DataTable dt = (DataTable)dgvLPGP.DataSource;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dt.Rows[i]["CHK"] = false;
				}
				dgvLPGP.DataSource = dt;
			}
		}
	}
}
