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
	public class frmMAQBOM : Form
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

		[field: AccessedThroughProperty("dgvDetails")]
		internal virtual DataGridView dgvDetails
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

		public frmMAQBOM()
		{
			base.FormClosing += frmMAQBOM_FormClosing;
			base.Shown += frmMAQBOM_Shown;
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
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.cbBOMPN = new IMS.ComboboxControl();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel5);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1580, 645);
			this.Panel2.TabIndex = 2;
			this.TableLayoutPanel5.ColumnCount = 5;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnSEARCH, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.dgvDetails, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.cbBOMPN, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(8, 12);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 3;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(1330, 577);
			this.TableLayoutPanel5.TabIndex = 10;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvDetails, 4);
			this.dgvDetails.Location = new System.Drawing.Point(3, 56);
			this.dgvDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.RowTemplate.Height = 24;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(879, 519);
			this.dgvDetails.TabIndex = 0;
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 5);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(84, 20);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "BOM Part";
			this.cbBOMPN.BlankValue = null;
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
			this.cbBOMPN.Size = new System.Drawing.Size(435, 26);
			this.cbBOMPN.TabIndex = 11;
			this.cbBOMPN.TextMultiline = true;
			this.cbBOMPN.ValueMember = null;
			this.cbBOMPN.WhereClause = null;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(660, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel5.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(534, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.TableLayoutPanel5.SetRowSpan(this.btnSEARCH, 2);
			this.btnSEARCH.Size = new System.Drawing.Size(120, 50);
			this.btnSEARCH.TabIndex = 12;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 604);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAQBOM";
			base.Tag = "MAQBOM";
			this.Text = "BOM Inquiry";
			this.Panel2.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
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

		private void frmMAQBOM_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAQBOM_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
		}

		private void BindDetails()
		{
			dgvDetails.DataSource = null;
			string strSQL = "SELECT DISTINCT MABOM_MDLCD, MABOM_REVNO FROM MABOM_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABOM_BOMPN = '", cbBOMPN.SelectedValue), "' ")));
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 240;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].ReadOnly = true;
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 100;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision No");
			dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].ReadOnly = true;
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
			dataGridView.Refresh();
			dataGridView = null;
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
