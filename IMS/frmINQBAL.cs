using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class frmINQBAL : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvWH1")]
		internal virtual DataGridView dgvWH1
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

		[field: AccessedThroughProperty("lblCUSIDFR")]
		internal virtual Label lblCUSIDFR
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

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
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

		[field: AccessedThroughProperty("dgvWBWIPD")]
		internal virtual DataGridView dgvWBWIPD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvWH2")]
		internal virtual DataGridView dgvWH2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvRESIN")]
		internal virtual DataGridView dgvRESIN
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvBLENDING")]
		internal virtual DataGridView dgvBLENDING
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvSBWIP")]
		internal virtual DataGridView dgvSBWIP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvFG")]
		internal virtual DataGridView dgvFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvWBWIPM")]
		internal virtual DataGridView dgvWBWIPM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmINQBAL()
		{
			base.FormClosing += frmINQBAL_FormClosing;
			base.Shown += frmINQBAL_Shown;
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
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvWBWIPD = new System.Windows.Forms.DataGridView();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.dgvWH1 = new System.Windows.Forms.DataGridView();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvWH2 = new System.Windows.Forms.DataGridView();
			this.dgvRESIN = new System.Windows.Forms.DataGridView();
			this.dgvBLENDING = new System.Windows.Forms.DataGridView();
			this.dgvSBWIP = new System.Windows.Forms.DataGridView();
			this.dgvFG = new System.Windows.Forms.DataGridView();
			this.dgvWBWIPM = new System.Windows.Forms.DataGridView();
			this.cbBOMPN = new IMS.ComboboxControl();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvWBWIPD).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvRESIN).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvBLENDING).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvSBWIP).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvFG).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWBWIPM).BeginInit();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel5);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1766, 811);
			this.Panel2.TabIndex = 2;
			this.TableLayoutPanel5.ColumnCount = 8;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479f));
			this.TableLayoutPanel5.Controls.Add(this.dgvWH1, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.dgvRESIN, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.dgvWBWIPM, 0, 4);
			this.TableLayoutPanel5.Controls.Add(this.dgvWH2, 2, 2);
			this.TableLayoutPanel5.Controls.Add(this.dgvBLENDING, 2, 3);
			this.TableLayoutPanel5.Controls.Add(this.dgvFG, 4, 2);
			this.TableLayoutPanel5.Controls.Add(this.dgvSBWIP, 4, 3);
			this.TableLayoutPanel5.Controls.Add(this.dgvWBWIPD, 2, 4);
			this.TableLayoutPanel5.Controls.Add(this.cbBOMPN, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnClose, 4, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnSEARCH, 3, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(8, 12);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 5;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(1543, 696);
			this.TableLayoutPanel5.TabIndex = 10;
			this.dgvWBWIPD.AllowUserToAddRows = false;
			this.dgvWBWIPD.AllowUserToDeleteRows = false;
			this.dgvWBWIPD.AllowUserToResizeRows = false;
			this.dgvWBWIPD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvWBWIPD.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWBWIPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvWBWIPD, 2);
			this.dgvWBWIPD.Location = new System.Drawing.Point(534, 462);
			this.dgvWBWIPD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvWBWIPD.MultiSelect = false;
			this.dgvWBWIPD.Name = "dgvWBWIPD";
			this.dgvWBWIPD.ReadOnly = true;
			this.dgvWBWIPD.RowHeadersVisible = false;
			this.dgvWBWIPD.RowHeadersWidth = 51;
			this.dgvWBWIPD.RowTemplate.Height = 24;
			this.dgvWBWIPD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWBWIPD.Size = new System.Drawing.Size(501, 232);
			this.dgvWBWIPD.TabIndex = 19;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(915, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.TableLayoutPanel5.SetRowSpan(this.btnSEARCH, 2);
			this.btnSEARCH.Size = new System.Drawing.Size(120, 50);
			this.btnSEARCH.TabIndex = 12;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.dgvWH1.AllowUserToAddRows = false;
			this.dgvWH1.AllowUserToDeleteRows = false;
			this.dgvWH1.AllowUserToResizeRows = false;
			this.dgvWH1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvWH1.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWH1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvWH1, 2);
			this.dgvWH1.Location = new System.Drawing.Point(3, 56);
			this.dgvWH1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvWH1.MultiSelect = false;
			this.dgvWH1.Name = "dgvWH1";
			this.dgvWH1.ReadOnly = true;
			this.dgvWH1.RowHeadersVisible = false;
			this.dgvWH1.RowHeadersWidth = 51;
			this.dgvWH1.RowTemplate.Height = 24;
			this.dgvWH1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWH1.Size = new System.Drawing.Size(525, 199);
			this.dgvWH1.TabIndex = 0;
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 5);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(84, 20);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "BOM Part";
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(1041, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel5.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.dgvWH2.AllowUserToAddRows = false;
			this.dgvWH2.AllowUserToDeleteRows = false;
			this.dgvWH2.AllowUserToResizeRows = false;
			this.dgvWH2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvWH2.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWH2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvWH2, 2);
			this.dgvWH2.Location = new System.Drawing.Point(534, 56);
			this.dgvWH2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvWH2.MultiSelect = false;
			this.dgvWH2.Name = "dgvWH2";
			this.dgvWH2.ReadOnly = true;
			this.dgvWH2.RowHeadersVisible = false;
			this.dgvWH2.RowHeadersWidth = 51;
			this.dgvWH2.RowTemplate.Height = 24;
			this.dgvWH2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWH2.Size = new System.Drawing.Size(501, 199);
			this.dgvWH2.TabIndex = 13;
			this.dgvRESIN.AllowUserToAddRows = false;
			this.dgvRESIN.AllowUserToDeleteRows = false;
			this.dgvRESIN.AllowUserToResizeRows = false;
			this.dgvRESIN.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvRESIN.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvRESIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvRESIN, 2);
			this.dgvRESIN.Location = new System.Drawing.Point(3, 259);
			this.dgvRESIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvRESIN.MultiSelect = false;
			this.dgvRESIN.Name = "dgvRESIN";
			this.dgvRESIN.ReadOnly = true;
			this.dgvRESIN.RowHeadersVisible = false;
			this.dgvRESIN.RowHeadersWidth = 51;
			this.dgvRESIN.RowTemplate.Height = 24;
			this.dgvRESIN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRESIN.Size = new System.Drawing.Size(525, 199);
			this.dgvRESIN.TabIndex = 14;
			this.dgvBLENDING.AllowUserToAddRows = false;
			this.dgvBLENDING.AllowUserToDeleteRows = false;
			this.dgvBLENDING.AllowUserToResizeRows = false;
			this.dgvBLENDING.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvBLENDING.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvBLENDING.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvBLENDING, 2);
			this.dgvBLENDING.Location = new System.Drawing.Point(534, 259);
			this.dgvBLENDING.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvBLENDING.MultiSelect = false;
			this.dgvBLENDING.Name = "dgvBLENDING";
			this.dgvBLENDING.ReadOnly = true;
			this.dgvBLENDING.RowHeadersVisible = false;
			this.dgvBLENDING.RowHeadersWidth = 51;
			this.dgvBLENDING.RowTemplate.Height = 24;
			this.dgvBLENDING.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBLENDING.Size = new System.Drawing.Size(501, 199);
			this.dgvBLENDING.TabIndex = 15;
			this.dgvSBWIP.AllowUserToAddRows = false;
			this.dgvSBWIP.AllowUserToDeleteRows = false;
			this.dgvSBWIP.AllowUserToResizeRows = false;
			this.dgvSBWIP.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvSBWIP.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvSBWIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvSBWIP, 3);
			this.dgvSBWIP.Location = new System.Drawing.Point(1041, 259);
			this.dgvSBWIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvSBWIP.MultiSelect = false;
			this.dgvSBWIP.Name = "dgvSBWIP";
			this.dgvSBWIP.ReadOnly = true;
			this.dgvSBWIP.RowHeadersVisible = false;
			this.dgvSBWIP.RowHeadersWidth = 51;
			this.dgvSBWIP.RowTemplate.Height = 24;
			this.dgvSBWIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSBWIP.Size = new System.Drawing.Size(505, 199);
			this.dgvSBWIP.TabIndex = 16;
			this.dgvFG.AllowUserToAddRows = false;
			this.dgvFG.AllowUserToDeleteRows = false;
			this.dgvFG.AllowUserToResizeRows = false;
			this.dgvFG.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvFG.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvFG, 3);
			this.dgvFG.Location = new System.Drawing.Point(1041, 56);
			this.dgvFG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvFG.MultiSelect = false;
			this.dgvFG.Name = "dgvFG";
			this.dgvFG.ReadOnly = true;
			this.dgvFG.RowHeadersVisible = false;
			this.dgvFG.RowHeadersWidth = 51;
			this.dgvFG.RowTemplate.Height = 24;
			this.dgvFG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFG.Size = new System.Drawing.Size(505, 199);
			this.dgvFG.TabIndex = 18;
			this.dgvWBWIPM.AllowUserToAddRows = false;
			this.dgvWBWIPM.AllowUserToDeleteRows = false;
			this.dgvWBWIPM.AllowUserToResizeRows = false;
			this.dgvWBWIPM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvWBWIPM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWBWIPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvWBWIPM, 2);
			this.dgvWBWIPM.Location = new System.Drawing.Point(3, 462);
			this.dgvWBWIPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvWBWIPM.MultiSelect = false;
			this.dgvWBWIPM.Name = "dgvWBWIPM";
			this.dgvWBWIPM.ReadOnly = true;
			this.dgvWBWIPM.RowHeadersVisible = false;
			this.dgvWBWIPM.RowHeadersWidth = 51;
			this.dgvWBWIPM.RowTemplate.Height = 24;
			this.dgvWBWIPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWBWIPM.Size = new System.Drawing.Size(525, 232);
			this.dgvWBWIPM.TabIndex = 17;
			this.cbBOMPN.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbBOMPN, 2);
			this.cbBOMPN.ComboboxWidth = 250;
			this.cbBOMPN.DataTable = null;
			this.cbBOMPN.DisplayMember = null;
			this.cbBOMPN.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBOMPN.HasBlankValue = true;
			this.cbBOMPN.Location = new System.Drawing.Point(93, 2);
			this.cbBOMPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbBOMPN.Name = "cbBOMPN";
			this.cbBOMPN.SelectedIndex = -1;
			this.cbBOMPN.SelectedItem = null;
			this.cbBOMPN.SelectedValue = null;
			this.cbBOMPN.Size = new System.Drawing.Size(495, 26);
			this.cbBOMPN.TabIndex = 11;
			this.cbBOMPN.TextMultiline = true;
			this.cbBOMPN.ValueMember = null;
			this.cbBOMPN.WhereClause = null;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1556, 770);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmINQBAL";
			base.Tag = "INQBAL";
			this.Text = "Stock Balance Inquiry by Location";
			this.Panel2.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvWBWIPD).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvRESIN).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvBLENDING).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvSBWIP).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvFG).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWBWIPM).EndInit();
			base.ResumeLayout(false);
		}

		private void BindComboBox()
		{
			cbBOMPN.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbBOMPN.WhereClause = "MAITM_ACTFG = -1";
			cbBOMPN.ValueMember = "MAITM_ITMCD";
			cbBOMPN.DisplayMember = "MAITM_ITMCD";
			cbBOMPN.LoadData();
		}

		private void frmINQBAL_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmINQBAL_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
		}

		private void BindDetails()
		{
			dgvWH1.DataSource = null;
			dgvWH2.DataSource = null;
			dgvFG.DataSource = null;
			dgvRESIN.DataSource = null;
			dgvBLENDING.DataSource = null;
			dgvSBWIP.DataSource = null;
			dgvWBWIPM.DataSource = null;
			dgvWBWIPD.DataSource = null;
			string strSQL = "EXEC spINQBAL '" + MyProject.Computer.Name + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbBOMPN.SelectedValue), "' ")));
			DB.ExecProc(strSQL);
			DataTable dt = DB.ExecProc("SELECT LOCID, GRLNO, DOCDT, PACKING, BALQT FROM INQBAL_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "' AND LOCID = 'WH1'");
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView = dgvWH1;
				dataGridView.DataSource = dt;
				dataGridView.Columns[0].Visible = true;
				dataGridView.Columns[0].Width = 80;
				dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[0].ReadOnly = true;
				dataGridView.Columns[1].Visible = true;
				dataGridView.Columns[1].Width = 120;
				dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[1].ReadOnly = true;
				dataGridView.Columns[2].Visible = true;
				dataGridView.Columns[2].Width = 100;
				dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc. Date");
				dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[2].ReadOnly = true;
				dataGridView.Columns[3].Visible = true;
				dataGridView.Columns[3].Width = 100;
				dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[3].ReadOnly = true;
				dataGridView.Columns[4].Visible = true;
				dataGridView.Columns[4].Width = 100;
				dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[4].ReadOnly = true;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
			dt = DB.ExecProc("SELECT LOCID, GRLNO, DOCDT, PACKING, BALQT FROM INQBAL_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "' AND LOCID = 'WH2'");
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView2 = dgvWH2;
				dataGridView2.DataSource = dt;
				dataGridView2.Columns[0].Visible = true;
				dataGridView2.Columns[0].Width = 80;
				dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[0].ReadOnly = true;
				dataGridView2.Columns[1].Visible = true;
				dataGridView2.Columns[1].Width = 120;
				dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[1].ReadOnly = true;
				dataGridView2.Columns[2].Visible = true;
				dataGridView2.Columns[2].Width = 100;
				dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc. Date");
				dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[2].ReadOnly = true;
				dataGridView2.Columns[3].Visible = true;
				dataGridView2.Columns[3].Width = 100;
				dataGridView2.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView2.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[3].ReadOnly = true;
				dataGridView2.Columns[4].Visible = true;
				dataGridView2.Columns[4].Width = 100;
				dataGridView2.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView2.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView2.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[4].ReadOnly = true;
				dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView2.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView2.Refresh();
				dataGridView2 = null;
			}
			dt = DB.ExecProc("SELECT LOCID, GRLNO, DOCDT, PACKING, BALQT FROM INQBAL_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "' AND LOCID = 'FG'");
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView3 = dgvFG;
				dataGridView3.DataSource = dt;
				dataGridView3.Columns[0].Visible = true;
				dataGridView3.Columns[0].Width = 80;
				dataGridView3.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView3.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[0].ReadOnly = true;
				dataGridView3.Columns[1].Visible = true;
				dataGridView3.Columns[1].Width = 120;
				dataGridView3.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				dataGridView3.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[1].ReadOnly = true;
				dataGridView3.Columns[2].Visible = true;
				dataGridView3.Columns[2].Width = 100;
				dataGridView3.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc. Date");
				dataGridView3.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[2].ReadOnly = true;
				dataGridView3.Columns[3].Visible = true;
				dataGridView3.Columns[3].Width = 100;
				dataGridView3.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView3.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[3].ReadOnly = true;
				dataGridView3.Columns[4].Visible = true;
				dataGridView3.Columns[4].Width = 100;
				dataGridView3.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView3.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView3.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[4].ReadOnly = true;
				dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView3.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView3.Refresh();
				dataGridView3 = null;
			}
			dt = DB.ExecProc("SELECT LOCID, GRLNO, DOCDT, PACKING, BALQT FROM INQBAL_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "' AND LOCID = 'RESIN'");
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView4 = dgvRESIN;
				dataGridView4.DataSource = dt;
				dataGridView4.Columns[0].Visible = true;
				dataGridView4.Columns[0].Width = 80;
				dataGridView4.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView4.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[0].ReadOnly = true;
				dataGridView4.Columns[1].Visible = true;
				dataGridView4.Columns[1].Width = 120;
				dataGridView4.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				dataGridView4.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[1].ReadOnly = true;
				dataGridView4.Columns[2].Visible = true;
				dataGridView4.Columns[2].Width = 100;
				dataGridView4.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc. Date");
				dataGridView4.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[2].ReadOnly = true;
				dataGridView4.Columns[3].Visible = true;
				dataGridView4.Columns[3].Width = 100;
				dataGridView4.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView4.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[3].ReadOnly = true;
				dataGridView4.Columns[4].Visible = true;
				dataGridView4.Columns[4].Width = 100;
				dataGridView4.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView4.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView4.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView4.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[4].ReadOnly = true;
				dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView4.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView4.Refresh();
				dataGridView4 = null;
			}
			dt = DB.ExecProc("SELECT LOCID, GRLNO, DOCDT, PACKING, BALQT FROM INQBAL_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "' AND LOCID = 'BLENDING'");
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView5 = dgvBLENDING;
				dataGridView5.DataSource = dt;
				dataGridView5.Columns[0].Visible = true;
				dataGridView5.Columns[0].Width = 80;
				dataGridView5.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView5.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[0].ReadOnly = true;
				dataGridView5.Columns[1].Visible = true;
				dataGridView5.Columns[1].Width = 120;
				dataGridView5.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				dataGridView5.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[1].ReadOnly = true;
				dataGridView5.Columns[2].Visible = true;
				dataGridView5.Columns[2].Width = 100;
				dataGridView5.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc. Date");
				dataGridView5.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[2].ReadOnly = true;
				dataGridView5.Columns[3].Visible = true;
				dataGridView5.Columns[3].Width = 100;
				dataGridView5.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView5.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[3].ReadOnly = true;
				dataGridView5.Columns[4].Visible = true;
				dataGridView5.Columns[4].Width = 100;
				dataGridView5.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView5.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView5.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView5.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[4].ReadOnly = true;
				dataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView5.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView5.Refresh();
				dataGridView5 = null;
			}
			dt = DB.ExecProc("SELECT LOCID, GRLNO, DOCDT, PACKING, BALQT FROM INQBAL_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "' AND LOCID = 'SB-WIP'");
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView6 = dgvSBWIP;
				dataGridView6.DataSource = dt;
				dataGridView6.Columns[0].Visible = true;
				dataGridView6.Columns[0].Width = 80;
				dataGridView6.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView6.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[0].ReadOnly = true;
				dataGridView6.Columns[1].Visible = true;
				dataGridView6.Columns[1].Width = 120;
				dataGridView6.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				dataGridView6.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[1].ReadOnly = true;
				dataGridView6.Columns[2].Visible = true;
				dataGridView6.Columns[2].Width = 100;
				dataGridView6.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc. Date");
				dataGridView6.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[2].ReadOnly = true;
				dataGridView6.Columns[3].Visible = true;
				dataGridView6.Columns[3].Width = 100;
				dataGridView6.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView6.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[3].ReadOnly = true;
				dataGridView6.Columns[4].Visible = true;
				dataGridView6.Columns[4].Width = 100;
				dataGridView6.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView6.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView6.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView6.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[4].ReadOnly = true;
				dataGridView6.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView6.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView6.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView6.Refresh();
				dataGridView6 = null;
			}
			dt = DB.ExecProc("SELECT LOCID, GRLNO, DOCDT, PACKING, BALQT FROM INQBAL_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "' AND LOCID = 'WB-WIP-MM'");
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView7 = dgvWBWIPM;
				dataGridView7.DataSource = dt;
				dataGridView7.Columns[0].Visible = true;
				dataGridView7.Columns[0].Width = 80;
				dataGridView7.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView7.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[0].ReadOnly = true;
				dataGridView7.Columns[1].Visible = true;
				dataGridView7.Columns[1].Width = 120;
				dataGridView7.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				dataGridView7.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[1].ReadOnly = true;
				dataGridView7.Columns[2].Visible = true;
				dataGridView7.Columns[2].Width = 100;
				dataGridView7.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc. Date");
				dataGridView7.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[2].ReadOnly = true;
				dataGridView7.Columns[3].Visible = true;
				dataGridView7.Columns[3].Width = 100;
				dataGridView7.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView7.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[3].ReadOnly = true;
				dataGridView7.Columns[4].Visible = true;
				dataGridView7.Columns[4].Width = 100;
				dataGridView7.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView7.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView7.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView7.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[4].ReadOnly = true;
				dataGridView7.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView7.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView7.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView7.Refresh();
				dataGridView7 = null;
			}
			dt = DB.ExecProc("SELECT LOCID, GRLNO, DOCDT, PACKING, BALQT FROM INQBAL_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "' AND LOCID = 'WB-WIP-D'");
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView8 = dgvWBWIPD;
				dataGridView8.DataSource = dt;
				dataGridView8.Columns[0].Visible = true;
				dataGridView8.Columns[0].Width = 80;
				dataGridView8.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				dataGridView8.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[0].ReadOnly = true;
				dataGridView8.Columns[1].Visible = true;
				dataGridView8.Columns[1].Width = 120;
				dataGridView8.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				dataGridView8.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[1].ReadOnly = true;
				dataGridView8.Columns[2].Visible = true;
				dataGridView8.Columns[2].Width = 100;
				dataGridView8.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc. Date");
				dataGridView8.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[2].ReadOnly = true;
				dataGridView8.Columns[3].Visible = true;
				dataGridView8.Columns[3].Width = 100;
				dataGridView8.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView8.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[3].ReadOnly = true;
				dataGridView8.Columns[4].Visible = true;
				dataGridView8.Columns[4].Width = 100;
				dataGridView8.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView8.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView8.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView8.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[4].ReadOnly = true;
				dataGridView8.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView8.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView8.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView8.Refresh();
				dataGridView8 = null;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			BindDetails();
		}
	}
}
