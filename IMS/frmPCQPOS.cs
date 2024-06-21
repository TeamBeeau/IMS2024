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
	public class frmPCQPOS : Form
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

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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
				DataGridViewCellMouseEventHandler value2 = dgvPO_CellMouseClick;
				DataGridView dataGridView = _dgvPO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvPO = value;
				dataGridView = _dgvPO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("dgvWH")]
		internal virtual DataGridView dgvWH
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvGRN")]
		internal virtual DataGridView dgvGRN
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
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

		[field: AccessedThroughProperty("numDAY")]
		internal virtual NumControl numDAY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCQPOS()
		{
			base.Shown += frmPCQPOS_Shown;
			base.FormClosing += frmPCQPOS_FormClosing;
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
			this.Label1 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.dgvGRN = new System.Windows.Forms.DataGridView();
			this.dgvPO = new System.Windows.Forms.DataGridView();
			this.dgvWH = new System.Windows.Forms.DataGridView();
			this.btnRetrieve = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.numDAY = new IMS.NumControl();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvGRN).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvPO).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH).BeginInit();
			this.Panel1.SuspendLayout();
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
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Controls.Add(this.numDAY, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label5, 5, 4);
			this.TableLayoutPanel3.Controls.Add(this.Label4, 0, 4);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label15, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.dgvGRN, 0, 5);
			this.TableLayoutPanel3.Controls.Add(this.dgvPO, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.btnRetrieve, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.dgvWH, 5, 5);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 6;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(1301, 667);
			this.TableLayoutPanel3.TabIndex = 19;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(264, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(44, 20);
			this.Label1.TabIndex = 73;
			this.Label1.Text = "days";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(737, 372);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(298, 25);
			this.Label5.TabIndex = 72;
			this.Label5.Text = "Inventory Balance Information";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.TableLayoutPanel3.SetColumnSpan(this.Label4, 4);
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 372);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(403, 25);
			this.Label4.TabIndex = 71;
			this.Label4.Text = "Current PO Goods Receiving Information";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.TableLayoutPanel3.SetColumnSpan(this.Label2, 3);
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 54);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(277, 25);
			this.Label2.TabIndex = 69;
			this.Label2.Text = "Purchase Order Information";
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 5);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(162, 20);
			this.Label15.TabIndex = 56;
			this.Label15.Text = "No GRN for the past";
			this.dgvGRN.AllowUserToAddRows = false;
			this.dgvGRN.AllowUserToDeleteRows = false;
			this.dgvGRN.AllowUserToResizeRows = false;
			this.dgvGRN.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvGRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvGRN, 5);
			this.dgvGRN.EnableHeadersVisualStyles = false;
			this.dgvGRN.Location = new System.Drawing.Point(3, 400);
			this.dgvGRN.MultiSelect = false;
			this.dgvGRN.Name = "dgvGRN";
			this.dgvGRN.ReadOnly = true;
			this.dgvGRN.RowHeadersVisible = false;
			this.dgvGRN.RowHeadersWidth = 51;
			this.dgvGRN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvGRN.Size = new System.Drawing.Size(728, 264);
			this.dgvGRN.TabIndex = 68;
			this.dgvPO.AllowUserToAddRows = false;
			this.dgvPO.AllowUserToDeleteRows = false;
			this.dgvPO.AllowUserToResizeRows = false;
			this.dgvPO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvPO, 6);
			this.dgvPO.EnableHeadersVisualStyles = false;
			this.dgvPO.Location = new System.Drawing.Point(3, 82);
			this.dgvPO.MultiSelect = false;
			this.dgvPO.Name = "dgvPO";
			this.dgvPO.ReadOnly = true;
			this.dgvPO.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvPO.RowHeadersVisible = false;
			this.dgvPO.RowHeadersWidth = 51;
			this.dgvPO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPO.Size = new System.Drawing.Size(1295, 287);
			this.dgvPO.TabIndex = 58;
			this.dgvWH.AllowUserToAddRows = false;
			this.dgvWH.AllowUserToDeleteRows = false;
			this.dgvWH.AllowUserToResizeRows = false;
			this.dgvWH.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWH.EnableHeadersVisualStyles = false;
			this.dgvWH.Location = new System.Drawing.Point(737, 400);
			this.dgvWH.MultiSelect = false;
			this.dgvWH.Name = "dgvWH";
			this.dgvWH.ReadOnly = true;
			this.dgvWH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvWH.RowHeadersVisible = false;
			this.dgvWH.RowHeadersWidth = 51;
			this.dgvWH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWH.Size = new System.Drawing.Size(561, 264);
			this.dgvWH.TabIndex = 67;
			this.btnRetrieve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRetrieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRetrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRetrieve.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRetrieve.Location = new System.Drawing.Point(314, 2);
			this.btnRetrieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRetrieve.Name = "btnRetrieve";
			this.TableLayoutPanel3.SetRowSpan(this.btnRetrieve, 2);
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
			this.btnClose.Location = new System.Drawing.Point(440, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel3.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1343, 716);
			this.Panel1.TabIndex = 20;
			this.numDAY.AllowNegative = false;
			this.numDAY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numDAY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numDAY.DataChanged = false;
			this.numDAY.Location = new System.Drawing.Point(171, 2);
			this.numDAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numDAY.Name = "numDAY";
			this.numDAY.NumberFormat = "8.0";
			this.numDAY.Size = new System.Drawing.Size(87, 26);
			this.numDAY.TabIndex = 76;
			this.numDAY.TabStop = false;
			this.numDAY.Text = "0";
			this.numDAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numDAY.ThousandSeperator = false;
			this.numDAY.Value = 0.0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1395, 728);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPCQPOS";
			base.Tag = "PCQPOS";
			this.Text = "Purchase Order Status Inquiry";
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvGRN).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvPO).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPCQPOS_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
		}

		private void frmPCQPOS_FormClosing(object sender, FormClosingEventArgs e)
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

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgvPO_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			RefreshGridGRN();
			RefreshGridWH();
		}

		private void RefreshGridPO()
		{
			dgvPO.DataSource = null;
			string strSQL = "exec spPCQPOS " + Conversions.ToString(numDAY.Value);
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvPO;
			dataGridView.DataSource = dt;
			int i = default(int);
			dataGridView.Columns[i].Visible = false;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "PO No");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
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
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "ETA Date");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 180;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "PO Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "GRN Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Reference No");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.ClearSelection();
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void RefreshGridGRN()
		{
			int i = 0;
			dgvGRN.DataSource = null;
			string strSQL = Conversions.ToString(Operators.ConcatenateObject("exec spPCQPOS_GRN ", dgvPO.CurrentRow.Cells["PCPCO_RECID"].Value));
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvGRN;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "GRN No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "GRN Date");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Batch No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "GRN Qty");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.ClearSelection();
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void RefreshGridWH()
		{
			int i = 0;
			dgvWH.DataSource = null;
			string strSQL = "exec spPCQPOS_WH '" + Common.gfValidSQLStr(Conversions.ToString(dgvPO.CurrentRow.Cells["PCPCO_ITMCD"].Value)) + "'";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvWH;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Bal Qty");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "GRN No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "GRN Date");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.ClearSelection();
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void btnRetrieve_Click(object sender, EventArgs e)
		{
			RefreshGridPO();
		}
	}
}
