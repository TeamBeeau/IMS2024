using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CryptoLibrary;
using IMS.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmLM1USR : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvLUSR")]
		private DataGridView _dgvLUSR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtCFM_PASWD")]
		private TextBox _txtCFM_PASWD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtNEW_PASWD")]
		private TextBox _txtNEW_PASWD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtOLD_PASWD")]
		private TextBox _txtOLD_PASWD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkCHG_PASWD")]
		private CheckBox _chkCHG_PASWD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtUSRID")]
		private TextBox _txtUSRID;

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
		[AccessedThroughProperty("cmdDelete")]
		private Button _cmdDelete;

		private clsUsers mclsUsers;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvLUSR
		{
			[CompilerGenerated]
			get
			{
				return _dgvLUSR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dgvLUSR_DoubleClick;
				DataGridView dataGridView = _dgvLUSR;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick -= value2;
				}
				_dgvLUSR = value;
				dataGridView = _dgvLUSR;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtUSRNM")]
		internal virtual TextBox txtUSRNM
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

		internal virtual TextBox txtCFM_PASWD
		{
			[CompilerGenerated]
			get
			{
				return _txtCFM_PASWD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtCFM_PASWD_KeyDown;
				TextBox textBox = _txtCFM_PASWD;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtCFM_PASWD = value;
				textBox = _txtCFM_PASWD;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtNEW_PASWD
		{
			[CompilerGenerated]
			get
			{
				return _txtNEW_PASWD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtNEW_PASWD_KeyDown;
				TextBox textBox = _txtNEW_PASWD;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtNEW_PASWD = value;
				textBox = _txtNEW_PASWD;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtOLD_PASWD
		{
			[CompilerGenerated]
			get
			{
				return _txtOLD_PASWD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtOLD_PASWD_KeyDown;
				TextBox textBox = _txtOLD_PASWD;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtOLD_PASWD = value;
				textBox = _txtOLD_PASWD;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox chkCHG_PASWD
		{
			[CompilerGenerated]
			get
			{
				return _chkCHG_PASWD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = chkCHG_PASWD_CheckedChanged;
				CheckBox checkBox = _chkCHG_PASWD;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_chkCHG_PASWD = value;
				checkBox = _chkCHG_PASWD;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtUSRID
		{
			[CompilerGenerated]
			get
			{
				return _txtUSRID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtUSRID_Leave;
				TextBox textBox = _txtUSRID;
				if (textBox != null)
				{
					textBox.Leave -= value2;
				}
				_txtUSRID = value;
				textBox = _txtUSRID;
				if (textBox != null)
				{
					textBox.Leave += value2;
				}
			}
		}

		[field: AccessedThroughProperty("chkSYSUSR")]
		internal virtual CheckBox chkSYSUSR
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkSPVFG")]
		internal virtual CheckBox chkSPVFG
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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbLGGID")]
		internal virtual ComboBox cbLGGID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmLM1USR()
		{
			base.FormClosing += frmLM1USR_FormClosing;
			base.Load += frmLM1USR_Load;
			mclsUsers = new clsUsers();
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbLGGID = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.dgvLUSR = new System.Windows.Forms.DataGridView();
			this.chkSPVFG = new System.Windows.Forms.CheckBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.chkSYSUSR = new System.Windows.Forms.CheckBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtCFM_PASWD = new System.Windows.Forms.TextBox();
			this.chkCHG_PASWD = new System.Windows.Forms.CheckBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtUSRID = new System.Windows.Forms.TextBox();
			this.txtUSRNM = new System.Windows.Forms.TextBox();
			this.txtNEW_PASWD = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtOLD_PASWD = new System.Windows.Forms.TextBox();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvLUSR).BeginInit();
			base.SuspendLayout();
			this.Panel1.AutoScroll = true;
			this.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1370, 749);
			this.Panel1.TabIndex = 0;
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbLGGID, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.dgvLUSR, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.chkSPVFG, 5, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.chkSYSUSR, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtCFM_PASWD, 5, 4);
			this.TableLayoutPanel1.Controls.Add(this.chkCHG_PASWD, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 4, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtUSRID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtUSRNM, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtNEW_PASWD, 3, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtOLD_PASWD, 1, 4);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1057, 615);
			this.TableLayoutPanel1.TabIndex = 32;
			this.cbLGGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLGGID.FormattingEnabled = true;
			this.cbLGGID.Location = new System.Drawing.Point(389, 438);
			this.cbLGGID.Name = "cbLGGID";
			this.cbLGGID.Size = new System.Drawing.Size(150, 24);
			this.cbLGGID.TabIndex = 35;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(284, 442);
			this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(69, 16);
			this.Label4.TabIndex = 34;
			this.Label4.Text = "Language";
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 6);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cmdSave, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdDelete, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdCancel, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdClose, 3, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 556);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(516, 55);
			this.TableLayoutPanel2.TabIndex = 33;
			this.cmdSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdSave.Image = IMS.My.Resources.Resources.Save;
			this.cmdSave.Location = new System.Drawing.Point(4, 4);
			this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(120, 48);
			this.cmdSave.TabIndex = 9;
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
			this.cmdDelete.Size = new System.Drawing.Size(120, 48);
			this.cmdDelete.TabIndex = 10;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdDelete.UseVisualStyleBackColor = false;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(260, 4);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(120, 48);
			this.cmdCancel.TabIndex = 11;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdClose.Image = IMS.My.Resources.Resources.Close;
			this.cmdClose.Location = new System.Drawing.Point(388, 4);
			this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(120, 48);
			this.cmdClose.TabIndex = 12;
			this.cmdClose.Text = "Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.dgvLUSR.AllowUserToAddRows = false;
			this.dgvLUSR.AllowUserToDeleteRows = false;
			this.dgvLUSR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvLUSR.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLUSR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvLUSR.ColumnHeadersHeight = 25;
			this.dgvLUSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvLUSR, 6);
			this.dgvLUSR.Location = new System.Drawing.Point(4, 4);
			this.dgvLUSR.Margin = new System.Windows.Forms.Padding(4);
			this.dgvLUSR.MultiSelect = false;
			this.dgvLUSR.Name = "dgvLUSR";
			this.dgvLUSR.ReadOnly = true;
			this.dgvLUSR.RowHeadersWidth = 20;
			this.dgvLUSR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvLUSR.RowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvLUSR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLUSR.Size = new System.Drawing.Size(1040, 427);
			this.dgvLUSR.TabIndex = 0;
			this.dgvLUSR.TabStop = false;
			this.chkSPVFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkSPVFG.AutoSize = true;
			this.chkSPVFG.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkSPVFG.Location = new System.Drawing.Point(724, 440);
			this.chkSPVFG.Margin = new System.Windows.Forms.Padding(4);
			this.chkSPVFG.Name = "chkSPVFG";
			this.chkSPVFG.Size = new System.Drawing.Size(92, 20);
			this.chkSPVFG.TabIndex = 3;
			this.chkSPVFG.Text = "Supervisor";
			this.chkSPVFG.UseVisualStyleBackColor = true;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(4, 442);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(53, 16);
			this.Label7.TabIndex = 31;
			this.Label7.Text = "User ID";
			this.chkSYSUSR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkSYSUSR.AutoSize = true;
			this.chkSYSUSR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkSYSUSR.Location = new System.Drawing.Point(570, 440);
			this.chkSYSUSR.Margin = new System.Windows.Forms.Padding(4);
			this.chkSYSUSR.Name = "chkSYSUSR";
			this.chkSYSUSR.Size = new System.Drawing.Size(104, 20);
			this.chkSYSUSR.TabIndex = 2;
			this.chkSYSUSR.Text = "System User";
			this.chkSYSUSR.UseVisualStyleBackColor = true;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(4, 472);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(45, 16);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Name";
			this.txtCFM_PASWD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCFM_PASWD.Location = new System.Drawing.Point(724, 527);
			this.txtCFM_PASWD.Margin = new System.Windows.Forms.Padding(4);
			this.txtCFM_PASWD.Name = "txtCFM_PASWD";
			this.txtCFM_PASWD.ShortcutsEnabled = false;
			this.txtCFM_PASWD.Size = new System.Drawing.Size(172, 22);
			this.txtCFM_PASWD.TabIndex = 8;
			this.chkCHG_PASWD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkCHG_PASWD.AutoSize = true;
			this.chkCHG_PASWD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCHG_PASWD.Location = new System.Drawing.Point(104, 499);
			this.chkCHG_PASWD.Margin = new System.Windows.Forms.Padding(4);
			this.chkCHG_PASWD.Name = "chkCHG_PASWD";
			this.chkCHG_PASWD.Size = new System.Drawing.Size(144, 20);
			this.chkCHG_PASWD.TabIndex = 5;
			this.chkCHG_PASWD.Text = "Change Password?";
			this.chkCHG_PASWD.UseVisualStyleBackColor = true;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(570, 530);
			this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(146, 16);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "Confirm New Password";
			this.txtUSRID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtUSRID.Location = new System.Drawing.Point(104, 439);
			this.txtUSRID.Margin = new System.Windows.Forms.Padding(4);
			this.txtUSRID.Name = "txtUSRID";
			this.txtUSRID.Size = new System.Drawing.Size(172, 22);
			this.txtUSRID.TabIndex = 1;
			this.txtUSRNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtUSRNM, 5);
			this.txtUSRNM.Location = new System.Drawing.Point(104, 469);
			this.txtUSRNM.Margin = new System.Windows.Forms.Padding(4);
			this.txtUSRNM.Name = "txtUSRNM";
			this.txtUSRNM.Size = new System.Drawing.Size(512, 22);
			this.txtUSRNM.TabIndex = 4;
			this.txtNEW_PASWD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtNEW_PASWD.Location = new System.Drawing.Point(390, 527);
			this.txtNEW_PASWD.Margin = new System.Windows.Forms.Padding(4);
			this.txtNEW_PASWD.Name = "txtNEW_PASWD";
			this.txtNEW_PASWD.ShortcutsEnabled = false;
			this.txtNEW_PASWD.Size = new System.Drawing.Size(172, 22);
			this.txtNEW_PASWD.TabIndex = 7;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(4, 530);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(92, 16);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Old Password";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(284, 530);
			this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(98, 16);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "New Password";
			this.txtOLD_PASWD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtOLD_PASWD.Location = new System.Drawing.Point(104, 527);
			this.txtOLD_PASWD.Margin = new System.Windows.Forms.Padding(4);
			this.txtOLD_PASWD.Name = "txtOLD_PASWD";
			this.txtOLD_PASWD.ShortcutsEnabled = false;
			this.txtOLD_PASWD.Size = new System.Drawing.Size(172, 22);
			this.txtOLD_PASWD.TabIndex = 6;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1370, 749);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmLM1USR";
			base.Tag = "LM1USR";
			this.Text = "User Maintenance";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvLUSR).EndInit();
			base.ResumeLayout(false);
		}

		private void frmLM1USR_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmLM1USR_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			SetMaxLength();
			BindComboBox();
			RefreshGrid();
			ClearFormData();
			cmdDelete.Enabled = PublicVar.gblnAdminGRP;
		}

		private void SetMaxLength()
		{
			txtUSRID.MaxLength = DB.CharColumnMaxLength("LUSR_TBL", "LUSR_USRID");
			txtUSRNM.MaxLength = DB.CharColumnMaxLength("LUSR_TBL", "LUSR_USRNM");
			txtOLD_PASWD.MaxLength = 15;
			txtNEW_PASWD.MaxLength = 15;
			txtCFM_PASWD.MaxLength = 15;
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'LGGID' ORDER BY MACOD_CODID";
			cbLGGID.ValueMember = "MACOD_CODID";
			cbLGGID.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbLGGID);
		}

		private void RefreshGrid()
		{
			DataTable dt = new DataTable();
			string strSQL = "LUSR_USRNM, LUSR_USRID, LUSR_LGGID, ";
			strSQL += "LUSR_SYSUSR, LUSR_SPVFG, ";
			strSQL += "CASE WHEN LUSR_SYSUSR = 1 THEN 'YES' ELSE 'NO' END AS SYSUSR";
			dt = DB.GetTable(strSQL, "LUSR_TBL", "", "LUSR_USRNM");
			DataGridView dataGridView = dgvLUSR;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 250;
			dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Name");
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 100;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "User ID");
			dataGridView.Columns[2].Visible = true;
			dataGridView.Columns[2].Width = 120;
			dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Language");
			dataGridView.Columns[3].Visible = false;
			dataGridView.Columns[4].Visible = false;
			dataGridView.Columns[5].Visible = true;
			dataGridView.Columns[5].Width = 100;
			dataGridView.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "System User");
			dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void ClearFormData()
		{
			txtUSRID.Text = "";
			txtUSRID.Modified = false;
			txtUSRNM.Text = "";
			txtUSRNM.Modified = false;
			txtOLD_PASWD.Text = "";
			txtOLD_PASWD.Modified = false;
			txtNEW_PASWD.Text = "";
			txtNEW_PASWD.Modified = false;
			txtCFM_PASWD.Text = "";
			txtCFM_PASWD.Modified = false;
			chkSYSUSR.Checked = false;
			chkCHG_PASWD.Checked = false;
			chkCHG_PASWD.Enabled = AllowChangePASWD();
			txtUSRID.Focus();
		}

		private bool DeleteRecord()
		{
			bool DeleteRecord;
			try
			{
				if (Operators.CompareString(txtUSRID.Text.Trim().ToUpper(), "ADMIN", false) == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "ADMIN user is not allow to delete!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					DeleteRecord = false;
				}
				else
				{
					string strSQL = "DELETE LUSR_TBL ";
					strSQL = strSQL + "WHERE LUSR_USRID = '" + txtUSRID.Text + "'";
					DeleteRecord = (DB.DBExecute(strSQL) ? true : false);
				}
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
			if (Operators.CompareString(txtUSRID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Blank User ID!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtUSRID.Focus();
				return false;
			}
			string strSQL = "SELECT * FROM LUSR_TBL ";
			strSQL = strSQL + "WHERE LUSR_USRID = '" + txtUSRID.Text + "'";
			if (DB.RecordExists(strSQL))
			{
				if ((Operators.CompareString(PublicVar.gstrLogonID.ToUpper(), txtUSRID.Text.Trim().ToUpper(), false) != 0) & !PublicVar.gblnAdminGRP)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Only ADMIN user can change other user's information!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtUSRID.Focus();
					return false;
				}
			}
			else if (!PublicVar.gblnAdminGRP)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Only ADMIN user can create new user!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtUSRID.Focus();
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
			if (chkCHG_PASWD.Checked && !ValidPASWD())
			{
				return false;
			}
			return true;
		}

		private bool SaveRecord()
		{
			Crypto oCrypto = new Crypto();
			checked
			{
				bool SaveRecord;
				try
				{
					clsUsers clsUsers2 = mclsUsers;
					clsUsers2.USRID = txtUSRID.Text.Trim();
					clsUsers2.USRNM = txtUSRNM.Text;
					clsUsers2.LGGID = Conversions.ToString(cbLGGID.SelectedValue);
					clsUsers2.SYSUSR = unchecked(0 - (chkSYSUSR.Checked ? 1 : 0)) * -1;
					clsUsers2.SPVFG = unchecked(0 - (chkSPVFG.Checked ? 1 : 0)) * -1;
					clsUsers2.LUPDT = DateAndTime.Now;
					string strSQL = "SELECT * FROM LUSR_TBL ";
					strSQL = strSQL + "WHERE LUSR_USRID = '" + txtUSRID.Text.Trim() + "'";
					string strPASWD;
					if (DB.RecordExists(strSQL))
					{
						strPASWD = Conversions.ToString(DB.GetColumnValue("LUSR_PASWD", "LUSR_TBL", "LUSR_USRID = '" + txtUSRID.Text.Trim() + "'"));
						if (chkCHG_PASWD.Checked)
						{
							strPASWD = oCrypto.EncryptString128Bit(txtNEW_PASWD.Text.Trim(), "");
						}
					}
					else
					{
						strPASWD = oCrypto.EncryptString128Bit(txtNEW_PASWD.Text.Trim(), "");
					}
					clsUsers2.PASWD = strPASWD;
					SaveRecord = clsUsers2.SaveRecord();
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					SaveRecord = false;
					ProjectData.ClearProjectError();
				}
				return SaveRecord;
			}
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			mclsUsers = null;
			Close();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (!ValidAllField())
			{
				return;
			}
			if (!SaveRecord())
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record not edited!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record edited!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			if (Operators.CompareString(txtUSRID.Text, PublicVar.gstrLogonID, false) == 0)
			{
				PublicVar.gstrLanguage = Conversions.ToString(cbLGGID.SelectedValue);
			}
			RefreshGrid();
			ClearFormData();
		}

		private void ShowGridData()
		{
			DataGridView dataGridView = dgvLUSR;
			txtUSRID.Text = Conversions.ToString(dataGridView[1, dataGridView.CurrentCell.RowIndex].Value);
			txtUSRNM.Text = Conversions.ToString(dataGridView[0, dataGridView.CurrentCell.RowIndex].Value);
			cbLGGID.SelectedValue = RuntimeHelpers.GetObjectValue(dataGridView[2, dataGridView.CurrentCell.RowIndex].Value);
			chkSYSUSR.Checked = Conversions.ToBoolean(dataGridView[3, dataGridView.CurrentCell.RowIndex].Value);
			chkSPVFG.Checked = Conversions.ToBoolean(dataGridView[4, dataGridView.CurrentCell.RowIndex].Value);
			txtOLD_PASWD.Text = "";
			txtNEW_PASWD.Text = "";
			txtCFM_PASWD.Text = "";
			dataGridView = null;
		}

		private void dgvLUSR_DoubleClick(object sender, EventArgs e)
		{
			if (dgvLUSR.CurrentRow.Index >= 0)
			{
				ShowGridData();
				chkCHG_PASWD.Checked = false;
				chkCHG_PASWD.Enabled = AllowChangePASWD();
				chkSYSUSR.Enabled = PublicVar.gblnAdminGRP;
				chkSPVFG.Enabled = PublicVar.gblnAdminGRP;
			}
		}

		private bool ValidPASWD()
		{
			Crypto oCrypto = new Crypto();
			string strPASWD = oCrypto.EncryptString128Bit(txtOLD_PASWD.Text.Trim(), "");
			string strSQL = "LUSR_USRID = '" + txtUSRID.Text.Trim() + "'";
			if (Operators.ConditionalCompareObjectNotEqual(strPASWD, DB.GetColumnValue("LUSR_PASWD", "LUSR_TBL", strSQL), false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Old password not match!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtOLD_PASWD.Focus();
				return false;
			}
			if (Operators.CompareString(txtNEW_PASWD.Text.Trim(), txtCFM_PASWD.Text.Trim(), false) != 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid new password. Please confirm!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCFM_PASWD.Focus();
				return false;
			}
			return true;
		}

		private bool AllowChangePASWD()
		{
			return (Operators.CompareString(PublicVar.gstrLogonID.ToUpper(), txtUSRID.Text.Trim().ToUpper(), false) == 0) | PublicVar.gblnAdminGRP;
		}

		private void txtUSRID_Leave(object sender, EventArgs e)
		{
			if (txtUSRID.Modified)
			{
				txtUSRID.Modified = false;
				string strSQL = "LUSR_USRID = '" + txtUSRID.Text + "'";
				txtUSRNM.Text = Conversions.ToString(DB.GetColumnValue("LUSR_USRNM", "LUSR_TBL", strSQL));
			}
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			ClearFormData();
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM LUSR_TBL ";
			strSQL = strSQL + "WHERE LUSR_USRID = '" + txtUSRID.Text + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record not exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtUSRID.Focus();
			}
			else if (ValidKeyField())
			{
				if (!DeleteRecord())
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record not deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtUSRID.Focus();
				}
				else
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					RefreshGrid();
					ClearFormData();
				}
			}
		}

		private void chkCHG_PASWD_CheckedChanged(object sender, EventArgs e)
		{
			txtOLD_PASWD.Text = "";
			txtOLD_PASWD.Modified = false;
			txtOLD_PASWD.ReadOnly = !chkCHG_PASWD.Checked;
			txtOLD_PASWD.TabStop = chkCHG_PASWD.Checked;
			txtNEW_PASWD.Text = "";
			txtNEW_PASWD.Modified = false;
			txtNEW_PASWD.ReadOnly = !chkCHG_PASWD.Checked;
			txtNEW_PASWD.TabStop = chkCHG_PASWD.Checked;
			txtCFM_PASWD.Text = "";
			txtCFM_PASWD.Modified = false;
			txtCFM_PASWD.ReadOnly = !chkCHG_PASWD.Checked;
			txtCFM_PASWD.TabStop = chkCHG_PASWD.Checked;
		}

		private void txtOLD_PASWD_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control)
			{
				e.Handled = true;
				txtOLD_PASWD.SelectionLength = 0;
			}
		}

		private void txtNEW_PASWD_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control)
			{
				e.Handled = true;
				txtNEW_PASWD.SelectionLength = 0;
			}
		}

		private void txtCFM_PASWD_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control)
			{
				e.Handled = true;
				txtCFM_PASWD.SelectionLength = 0;
			}
		}
	}
}
