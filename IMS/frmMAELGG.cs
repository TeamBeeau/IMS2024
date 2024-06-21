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

namespace IMS
{
	[DesignerGenerated]
	public class frmMAELGG : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

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
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMALGG")]
		private DataGridView _dgvMALGG;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCTYID")]
		internal virtual Label lblCTYID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblREMRK")]
		internal virtual Label lblREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCODNM")]
		internal virtual Label lblCODNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCODID")]
		internal virtual Label lblCODID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtORIFLD")]
		internal virtual TextBox txtORIFLD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtLGGFLD")]
		internal virtual TextBox txtLGGFLD
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

		[field: AccessedThroughProperty("lblCTYIDFR")]
		internal virtual Label lblCTYIDFR
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

		internal virtual DataGridView dgvMALGG
		{
			[CompilerGenerated]
			get
			{
				return _dgvMALGG;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMALGG_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMALGG;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMALGG = value;
				dataGridView = _dgvMALGG;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("MACTY_TBLComboBox")]
		internal virtual ComboBox MACTY_TBLComboBox
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

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("cbHPRGID")]
		internal virtual ComboBox cbHPRGID
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

		[field: AccessedThroughProperty("cbHLGGID")]
		internal virtual ComboBox cbHLGGID
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

		[field: AccessedThroughProperty("cbPRGID")]
		internal virtual ComboBox cbPRGID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAELGG()
		{
			base.FormClosing += frmMAELGG_FormClosing;
			base.Shown += frmMAELGG_Shown;
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.lblCTYID = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblCODNM = new System.Windows.Forms.Label();
			this.lblCODID = new System.Windows.Forms.Label();
			this.txtORIFLD = new System.Windows.Forms.TextBox();
			this.txtLGGFLD = new System.Windows.Forms.TextBox();
			this.cbLGGID = new System.Windows.Forms.ComboBox();
			this.cbPRGID = new System.Windows.Forms.ComboBox();
			this.dgvMALGG = new System.Windows.Forms.DataGridView();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbHPRGID = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbHLGGID = new System.Windows.Forms.ComboBox();
			this.lblCTYIDFR = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMALGG).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.lblCTYID, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblCODNM, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblCODID, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtORIFLD, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtLGGFLD, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.cbLGGID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbPRGID, 1, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 11);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(602, 186);
			this.TableLayoutPanel1.TabIndex = 0;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 2);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 134);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49f));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(384, 49);
			this.TableLayoutPanel3.TabIndex = 12;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(4, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 45);
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
			this.btnDelete.Location = new System.Drawing.Point(132, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 45);
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
			this.btnBack.Location = new System.Drawing.Point(260, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 45);
			this.btnBack.TabIndex = 11;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.lblCTYID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCTYID.AutoSize = true;
			this.lblCTYID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCTYID.Location = new System.Drawing.Point(4, 7);
			this.lblCTYID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCTYID.Name = "lblCTYID";
			this.lblCTYID.Size = new System.Drawing.Size(69, 16);
			this.lblCTYID.TabIndex = 1;
			this.lblCTYID.Text = "Language";
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(4, 91);
			this.lblREMRK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(103, 16);
			this.lblREMRK.TabIndex = 7;
			this.lblREMRK.Text = "Converted Field";
			this.lblCODNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCODNM.AutoSize = true;
			this.lblCODNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCODNM.Location = new System.Drawing.Point(4, 65);
			this.lblCODNM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCODNM.Name = "lblCODNM";
			this.lblCODNM.Size = new System.Drawing.Size(87, 16);
			this.lblCODNM.TabIndex = 8;
			this.lblCODNM.Text = "Original Field";
			this.lblCODID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCODID.AutoSize = true;
			this.lblCODID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCODID.Location = new System.Drawing.Point(4, 37);
			this.lblCODID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCODID.Name = "lblCODID";
			this.lblCODID.Size = new System.Drawing.Size(60, 16);
			this.lblCODID.TabIndex = 9;
			this.lblCODID.Text = "Program";
			this.txtORIFLD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtORIFLD, 2);
			this.txtORIFLD.Location = new System.Drawing.Point(115, 62);
			this.txtORIFLD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtORIFLD.Name = "txtORIFLD";
			this.txtORIFLD.Size = new System.Drawing.Size(483, 22);
			this.txtORIFLD.TabIndex = 3;
			this.txtLGGFLD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtLGGFLD, 2);
			this.txtLGGFLD.Location = new System.Drawing.Point(115, 88);
			this.txtLGGFLD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtLGGFLD.Name = "txtLGGFLD";
			this.txtLGGFLD.Size = new System.Drawing.Size(483, 22);
			this.txtLGGFLD.TabIndex = 4;
			this.cbLGGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLGGID.FormattingEnabled = true;
			this.cbLGGID.Location = new System.Drawing.Point(114, 3);
			this.cbLGGID.Name = "cbLGGID";
			this.cbLGGID.Size = new System.Drawing.Size(150, 24);
			this.cbLGGID.TabIndex = 37;
			this.cbPRGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPRGID.FormattingEnabled = true;
			this.cbPRGID.Location = new System.Drawing.Point(114, 33);
			this.cbPRGID.Name = "cbPRGID";
			this.cbPRGID.Size = new System.Drawing.Size(250, 24);
			this.cbPRGID.TabIndex = 38;
			this.dgvMALGG.AllowUserToAddRows = false;
			this.dgvMALGG.AllowUserToDeleteRows = false;
			this.dgvMALGG.AllowUserToResizeRows = false;
			this.dgvMALGG.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMALGG.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMALGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMALGG.Location = new System.Drawing.Point(5, 101);
			this.dgvMALGG.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvMALGG.MultiSelect = false;
			this.dgvMALGG.Name = "dgvMALGG";
			this.dgvMALGG.ReadOnly = true;
			this.dgvMALGG.RowHeadersVisible = false;
			this.dgvMALGG.RowTemplate.Height = 24;
			this.dgvMALGG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMALGG.Size = new System.Drawing.Size(1339, 472);
			this.dgvMALGG.TabIndex = 5;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(132, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 45);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(4, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 45);
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
			this.TableLayoutPanel2.Controls.Add(this.cbHPRGID, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbHLGGID, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCTYIDFR, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 11);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(562, 30);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbHPRGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHPRGID.FormattingEnabled = true;
			this.cbHPRGID.Location = new System.Drawing.Point(309, 3);
			this.cbHPRGID.Name = "cbHPRGID";
			this.cbHPRGID.Size = new System.Drawing.Size(250, 24);
			this.cbHPRGID.TabIndex = 38;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(240, 6);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(62, 17);
			this.Label1.TabIndex = 37;
			this.Label1.Text = "Program";
			this.cbHLGGID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHLGGID.FormattingEnabled = true;
			this.cbHLGGID.Location = new System.Drawing.Point(83, 3);
			this.cbHLGGID.Name = "cbHLGGID";
			this.cbHLGGID.Size = new System.Drawing.Size(150, 24);
			this.cbHLGGID.TabIndex = 36;
			this.lblCTYIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCTYIDFR.AutoSize = true;
			this.lblCTYIDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCTYIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCTYIDFR.Location = new System.Drawing.Point(4, 6);
			this.lblCTYIDFR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCTYIDFR.Name = "lblCTYIDFR";
			this.lblCTYIDFR.Size = new System.Drawing.Size(72, 17);
			this.lblCTYIDFR.TabIndex = 2;
			this.lblCTYIDFR.Text = "Language";
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.dgvMALGG);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 593);
			this.Panel2.TabIndex = 6;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 47);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(384, 49);
			this.TableLayoutPanel4.TabIndex = 6;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(260, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 45);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 593);
			this.Panel1.TabIndex = 1;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 594);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			base.Name = "frmMAELGG";
			base.Tag = "MAELGG";
			this.Text = "Language Setup";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvMALGG).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			spMAELGG("0");
		}

		private void frmMAELGG_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAELGG_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
			Header();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'LGGID' AND MACOD_CODID <> 'ENG' ORDER BY MACOD_CODID";
			cbHLGGID.ValueMember = "MACOD_CODID";
			cbHLGGID.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbHLGGID);
			cbLGGID.ValueMember = "MACOD_CODID";
			cbLGGID.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbLGGID);
			strSQL = "SELECT '' AS LPRG_PRGID, '' AS LPRG_DESC UNION SELECT LPRG_PRGID, LPRG_DESC FROM LPRG_TBL WITH (NOLOCK) ORDER BY LPRG_DESC";
			cbHPRGID.ValueMember = "LPRG_PRGID";
			cbHPRGID.DisplayMember = "LPRG_DESC";
			Common.RetriveComboItembySQL(strSQL, cbHPRGID);
			cbPRGID.ValueMember = "LPRG_PRGID";
			cbPRGID.DisplayMember = "LPRG_DESC";
			Common.RetriveComboItembySQL(strSQL, cbPRGID);
		}

		private void ClearFormData()
		{
			txtORIFLD.Text = string.Empty;
			txtLGGFLD.Text = string.Empty;
		}

		private bool spMAELGG(string strPRO)
		{
			bool spMAELGG = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAELGG ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(strPRO) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLGGID.SelectedValue)) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPRGID.SelectedValue)) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(txtORIFLD.Text) + "', ";
				strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtLGGFLD.Text) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), Conversions.ToString(Interaction.IIf(Operators.CompareString(strPRO, "0", false) == 0, "Record edited!", "Record deleted!"))), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMAELGG = false;
					ProjectData.ClearProjectError();
					goto IL_0184;
				}
				ClearDetailsControl();
				spMAELGG = true;
			}
			goto IL_0184;
			IL_0184:
			return spMAELGG;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			cbLGGID.Enabled = true;
			cbPRGID.Enabled = true;
			cbLGGID.SelectedValue = RuntimeHelpers.GetObjectValue(cbHLGGID.SelectedValue);
			cbPRGID.SelectedValue = RuntimeHelpers.GetObjectValue(cbHPRGID.SelectedValue);
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = false;
		}

		private void Header()
		{
			int count = dgvMALGG.Rows.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				dgvMALGG.Rows.Remove(dgvMALGG.Rows[0]);
			}
			try
			{
				string strSQL = "EXEC spMALGG ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHLGGID.SelectedValue)) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHPRGID.SelectedValue)) + "'";
				DataTable dt = DB.ExecProc(strSQL);
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvMALGG;
					dataGridView.DataSource = dt;
					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[0].Width = 80;
					dataGridView.Columns[0].HeaderText = "LGGID";
					dataGridView.Columns[0].ReadOnly = true;
					dataGridView.Columns[1].Visible = true;
					dataGridView.Columns[1].Width = 100;
					dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Language");
					dataGridView.Columns[1].ReadOnly = true;
					dataGridView.Columns[2].Visible = false;
					dataGridView.Columns[2].Width = 80;
					dataGridView.Columns[2].HeaderText = "PRGID";
					dataGridView.Columns[2].ReadOnly = true;
					dataGridView.Columns[3].Visible = true;
					dataGridView.Columns[3].Width = 300;
					dataGridView.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Program");
					dataGridView.Columns[4].ReadOnly = true;
					dataGridView.Columns[4].Visible = true;
					dataGridView.Columns[4].Width = 450;
					dataGridView.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Original Field");
					dataGridView.Columns[4].ReadOnly = true;
					dataGridView.Columns[5].Visible = true;
					dataGridView.Columns[5].Width = 450;
					dataGridView.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Converted Field");
					dataGridView.Columns[5].ReadOnly = true;
					dataGridView = null;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			Panel1.Visible = false;
			Panel2.Visible = true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult OKDIALOG = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (OKDIALOG == DialogResult.OK)
			{
				spMAELGG("1");
				ClearDetailsControl();
				Header();
			}
		}

		public void ClearDetailsControl()
		{
			txtORIFLD.Text = string.Empty;
			txtLGGFLD.Text = string.Empty;
			btnDelete.Enabled = false;
			btnSave.Tag = "Save";
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetailsControl();
			Header();
		}

		public void EditRecord()
		{
			BindGridtoControl();
			cbLGGID.Enabled = false;
			cbPRGID.Enabled = false;
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = true;
			btnSave.Tag = "Update";
		}

		public void BindGridtoControl()
		{
			cbLGGID.SelectedValue = RuntimeHelpers.GetObjectValue(dgvMALGG.CurrentRow.Cells["MALGG_LGGID"].Value);
			cbPRGID.SelectedValue = RuntimeHelpers.GetObjectValue(dgvMALGG.CurrentRow.Cells["MALGG_PRGID"].Value);
			txtORIFLD.Text = dgvMALGG.CurrentRow.Cells["MALGG_ORIFLD"].Value.ToString();
			txtLGGFLD.Text = dgvMALGG.CurrentRow.Cells["MALGG_LGGFLD"].Value.ToString();
		}

		private void dgvMALGG_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			EditRecord();
		}

		public bool ValidateDetailControl()
		{
			string strSQL = "SELECT * FROM MALGG_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE MALGG_LGGID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLGGID.SelectedValue)) + "' ";
			strSQL = strSQL + "AND MALGG_PRGID = '" + Common.gfValidSQLStr(Conversions.ToString(cbPRGID.SelectedValue)) + "' ";
			strSQL = strSQL + "AND MALGG_ORIFLD = '" + Common.gfValidSQLStr(txtORIFLD.Text) + "'";
			if (Operators.ConditionalCompareObjectEqual(btnSave.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtORIFLD.Focus();
				return false;
			}
			return true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
