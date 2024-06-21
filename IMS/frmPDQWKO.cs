using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class frmPDQWKO : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private System.Windows.Forms.Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtpDOCDTfr")]
		private DateTimePicker _dtpDOCDTfr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnExcel")]
		private System.Windows.Forms.Button _btnExcel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bgwProgress")]
		private BackgroundWorker _bgwProgress;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRefresh")]
		private System.Windows.Forms.Button _btnRefresh;

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

		internal virtual System.Windows.Forms.Button btnClose
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
				System.Windows.Forms.Button button = _btnClose;
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
		internal virtual System.Windows.Forms.Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvWO")]
		internal virtual DataGridView dgvWO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DateTimePicker dtpDOCDTfr
		{
			[CompilerGenerated]
			get
			{
				return _dtpDOCDTfr;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dtpDOCDT_CloseUp;
				DateTimePicker dateTimePicker = _dtpDOCDTfr;
				if (dateTimePicker != null)
				{
					dateTimePicker.CloseUp -= value2;
				}
				_dtpDOCDTfr = value;
				dateTimePicker = _dtpDOCDTfr;
				if (dateTimePicker != null)
				{
					dateTimePicker.CloseUp += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Button btnExcel
		{
			[CompilerGenerated]
			get
			{
				return _btnExcel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnExcel_Click;
				System.Windows.Forms.Button button = _btnExcel;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnExcel = value;
				button = _btnExcel;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual BackgroundWorker bgwProgress
		{
			[CompilerGenerated]
			get
			{
				return _bgwProgress;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = bgwProgress_DoWork;
				RunWorkerCompletedEventHandler value3 = bgwProgress_RunWorkerCompleted;
				BackgroundWorker backgroundWorker = _bgwProgress;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork -= value2;
					backgroundWorker.RunWorkerCompleted -= value3;
				}
				_bgwProgress = value;
				backgroundWorker = _bgwProgress;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork += value2;
					backgroundWorker.RunWorkerCompleted += value3;
				}
			}
		}

		internal virtual System.Windows.Forms.Button btnRefresh
		{
			[CompilerGenerated]
			get
			{
				return _btnRefresh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRefresh_Click;
				System.Windows.Forms.Button button = _btnRefresh;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRefresh = value;
				button = _btnRefresh;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("dtpDOCDTto")]
		internal virtual DateTimePicker dtpDOCDTto
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual System.Windows.Forms.Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPDQWKO()
		{
			base.Shown += frmPDQWKO_Shown;
			base.FormClosing += frmPDQWKO_FormClosing;
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
			this.btnRefresh = new System.Windows.Forms.Button();
			this.Label15 = new System.Windows.Forms.Label();
			this.dgvWO = new System.Windows.Forms.DataGridView();
			this.dtpDOCDTfr = new System.Windows.Forms.DateTimePicker();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnExcel = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.bgwProgress = new System.ComponentModel.BackgroundWorker();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTto = new System.Windows.Forms.DateTimePicker();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvWO).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 7;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.dtpDOCDTto, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnRefresh, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label15, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.dgvWO, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 6, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnExcel, 5, 0);
			this.TableLayoutPanel3.Controls.Add(this.dtpDOCDTfr, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(8, 8);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 3;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(1622, 676);
			this.TableLayoutPanel3.TabIndex = 19;
			this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRefresh.Location = new System.Drawing.Point(299, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.TableLayoutPanel3.SetRowSpan(this.btnRefresh, 2);
			this.btnRefresh.Size = new System.Drawing.Size(120, 50);
			this.btnRefresh.TabIndex = 61;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 5);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(39, 16);
			this.Label15.TabIndex = 56;
			this.Label15.Text = "From";
			this.dgvWO.AllowUserToAddRows = false;
			this.dgvWO.AllowUserToDeleteRows = false;
			this.dgvWO.AllowUserToResizeRows = false;
			this.dgvWO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvWO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvWO, 7);
			this.dgvWO.EnableHeadersVisualStyles = false;
			this.dgvWO.Location = new System.Drawing.Point(3, 59);
			this.dgvWO.MultiSelect = false;
			this.dgvWO.Name = "dgvWO";
			this.dgvWO.ReadOnly = true;
			this.dgvWO.RowHeadersVisible = false;
			this.dgvWO.RowHeadersWidth = 51;
			this.dgvWO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWO.Size = new System.Drawing.Size(1616, 614);
			this.dgvWO.TabIndex = 58;
			this.dtpDOCDTfr.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTfr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTfr.Location = new System.Drawing.Point(48, 2);
			this.dtpDOCDTfr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTfr.Name = "dtpDOCDTfr";
			this.dtpDOCDTfr.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDTfr.TabIndex = 59;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(551, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel3.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcel.Image = IMS.My.Resources.Resources.Excel;
			this.btnExcel.Location = new System.Drawing.Point(425, 3);
			this.btnExcel.Name = "btnExcel";
			this.TableLayoutPanel3.SetRowSpan(this.btnExcel, 2);
			this.btnExcel.Size = new System.Drawing.Size(120, 50);
			this.btnExcel.TabIndex = 60;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcel.UseVisualStyleBackColor = false;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1635, 689);
			this.Panel1.TabIndex = 20;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(158, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 62;
			this.Label1.Text = "To";
			this.dtpDOCDTto.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTto.Location = new System.Drawing.Point(189, 2);
			this.dtpDOCDTto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTto.Name = "dtpDOCDTto";
			this.dtpDOCDTto.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDTto.TabIndex = 63;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1638, 701);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPDQWKO";
			base.Tag = "PDQWKO";
			this.Text = "Work Order Status & Monitoring";
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvWO).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPDQWKO_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTfr.Value = DateAndTime.Today.AddDays(-7.0);
			dtpDOCDTto.Value = DateTime.Now;
			RefreshGrid();
		}

		private void frmPDQWKO_FormClosing(object sender, FormClosingEventArgs e)
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

		private void RefreshGrid()
		{
			int i = 0;
			dgvWO.DataSource = null;
			string strSQL = "EXEC spPDQWKO '" + MyProject.Computer.Name + "', '" + Common.gfSQLDate(dtpDOCDTfr.Value) + "', '" + Common.gfSQLDate(dtpDOCDTto.Value) + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show("No Record(s) Found!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			DataGridView dataGridView = dgvWO;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 30;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No");
			dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView.Columns[i].ReadOnly = true;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Date");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 130;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO No");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 70;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 70;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Cust Part");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FGR Remark");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 30;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WH");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "TRF Time");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "TRF By");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FGR Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FGR Time");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FGR By");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DO Time");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DO By");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Driver");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Truck No");
				dataGridView.Columns[i].ReadOnly = true;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.ClearSelection();
				dataGridView.Refresh();
				dataGridView = null;
				BindHeaderColor();
			}
		}

		private void BindHeaderColor()
		{
			if (dgvWO.RowCount == 0)
			{
				return;
			}
			DataGridView dataGridView = dgvWO;
			checked
			{
				int num = dataGridView.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					object value = dataGridView.Rows[i].Cells["FGRSTS"].Value;
					if (Operators.ConditionalCompareObjectEqual(value, 0, false))
					{
						object value2 = dataGridView.Rows[i].Cells["PISTS"].Value;
						if (Operators.ConditionalCompareObjectEqual(value2, 0, false))
						{
							object value3 = dataGridView.Rows[i].Cells["PICHK"].Value;
							if (Operators.ConditionalCompareObjectEqual(value3, 0, false))
							{
								dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
							}
							else if (Operators.ConditionalCompareObjectEqual(value3, 1, false))
							{
								dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
							}
						}
						else if (Operators.ConditionalCompareObjectEqual(value2, 1, false))
						{
							dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightYellow;
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(value, 1, false))
					{
						dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
					}
				}
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void dtpDOCDT_CloseUp(object sender, EventArgs e)
		{
			RefreshGrid();
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bgwProgress.RunWorkerAsync();
		}

		private void bgwProgress_DoWork(object sender, DoWorkEventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application xlsApp = new ApplicationClass();
			string strSQL = "EXEC spPDQWKO '" + MyProject.Computer.Name + "', '" + Common.gfSQLDate(dtpDOCDTfr.Value) + "', '" + Common.gfSQLDate(dtpDOCDTto.Value) + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No data found!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			Workbook xlsWorkBook = xlsApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
			Worksheet xlsSheet = (Worksheet)xlsWorkBook.Sheets["Sheet1"];
			xlsApp.Cells[1, 1] = PublicVar.gstrCompany;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order Status") + " " + dtpDOCDTfr.Value.ToString("dd/MM/yyyy");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			xlsApp.Cells[4, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Date");
			xlsApp.Cells[4, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO No");
			xlsApp.Cells[4, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
			xlsApp.Cells[4, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
			xlsApp.Cells[4, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
			xlsApp.Cells[4, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
			xlsApp.Cells[4, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Cust Part");
			xlsApp.Cells[4, 8] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FGR Remark");
			xlsApp.Cells[4, 9] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO Qty");
			xlsApp.Cells[4, 10] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
			xlsApp.Cells[4, 11] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Issue");
			xlsApp.Cells[4, 12] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part issue Time");
			xlsApp.Cells[4, 13] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Issue By");
			xlsApp.Cells[4, 14] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FGR Qty");
			xlsApp.Cells[4, 15] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FG Time");
			xlsApp.Cells[4, 16] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FG By");
			xlsApp.Cells[4, 17] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DO Time");
			xlsApp.Cells[4, 18] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "DO By");
			xlsApp.Cells[4, 19] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Driver");
			xlsApp.Cells[4, 20] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Truck No");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 20])).Font.Bold = true;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 20])).EntireColumn.NumberFormat = "@";
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 20])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 20])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
			int intRow = 5;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["WKODT"]);
					xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["WKONO"]);
					xlsApp.Cells[intRow, 3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["TYPE"]);
					xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["CUS_SHORT"]);
					xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MDLCD"]);
					xlsApp.Cells[intRow, 6] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["REVNO"]);
					xlsApp.Cells[intRow, 7] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["CPTNO"]);
					xlsApp.Cells[intRow, 8] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["FGR_REMRK"]);
					xlsApp.Cells[intRow, 9] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["QTY"]);
					xlsApp.Cells[intRow, 10] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["STATUS"]);
					xlsApp.Cells[intRow, 11] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dt.Rows[i]["PICHK"], 1, false), "Yes", "No"));
					xlsApp.Cells[intRow, 12] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PITIME"]);
					xlsApp.Cells[intRow, 13] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PIUSER"]);
					xlsApp.Cells[intRow, 14] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["FGRQTY"]);
					xlsApp.Cells[intRow, 15] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["FGRTIME"]);
					xlsApp.Cells[intRow, 16] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["FGRUSER"]);
					xlsApp.Cells[intRow, 17] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOTIME"]);
					xlsApp.Cells[intRow, 18] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOUSER"]);
					xlsApp.Cells[intRow, 19] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DRIVER"]);
					xlsApp.Cells[intRow, 20] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["TRUCK"]);
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 6]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 6])).NumberFormat = "0.00";
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).NumberFormat = "0.000";
					intRow++;
				}
				xlsSheet.Columns.AutoFit();
				xlsSheet = null;
				xlsWorkBook = null;
				GC.Collect();
				xlsApp.WindowState = XlWindowState.xlMaximized;
				xlsApp.Visible = true;
			}
		}

		private void bgwProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Cursor = Cursors.Default;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			RefreshGrid();
		}
	}
}
