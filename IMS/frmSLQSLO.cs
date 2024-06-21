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
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmSLQSLO : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private System.Windows.Forms.Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvSO")]
		private DataGridView _dgvSO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRetrieve")]
		private System.Windows.Forms.Button _btnRetrieve;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnExcel")]
		private System.Windows.Forms.Button _btnExcel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bgwProgress")]
		private BackgroundWorker _bgwProgress;

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

		internal virtual DataGridView dgvSO
		{
			[CompilerGenerated]
			get
			{
				return _dgvSO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvWO_CellMouseClick;
                DataGridViewCellMouseEventHandler value3 = dgvWO_CellMouseDoubleClick;

				DataGridView dataGridView = _dgvSO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
                if (dataGridView != null)
                {
                    dataGridView.CellMouseDoubleClick -= value3;
                }
                _dgvSO = value;
				dataGridView = _dgvSO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
                if (dataGridView != null)
                {
                    dataGridView.CellMouseDoubleClick += value3;
                }
            }
}

		[field: AccessedThroughProperty("dgvWO")]
		internal virtual DataGridView dgvWO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpFRDOCDT")]
		internal virtual DateTimePicker dtpFRDOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvDO")]
		internal virtual DataGridView dgvDO
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual System.Windows.Forms.Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual System.Windows.Forms.Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label4")]
		internal virtual System.Windows.Forms.Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual System.Windows.Forms.Label Label3
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

		[field: AccessedThroughProperty("dtpTODOCDT")]
		internal virtual DateTimePicker dtpTODOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnRetrieve
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
				System.Windows.Forms.Button button = _btnRetrieve;
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual System.Windows.Forms.Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("GroupBox4")]
		internal virtual System.Windows.Forms.GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoOption1")]
		internal virtual RadioButton rdoOption1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoOption2")]
		internal virtual RadioButton rdoOption2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		public frmSLQSLO()
		{
			base.Shown += frmSLQSLO_Shown;
			base.FormClosing += frmSLQSLO_FormClosing;
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
			this.Label7 = new System.Windows.Forms.Label();
			this.btnExcel = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.dgvFG = new System.Windows.Forms.DataGridView();
			this.dgvSO = new System.Windows.Forms.DataGridView();
			this.dgvWO = new System.Windows.Forms.DataGridView();
			this.dgvDO = new System.Windows.Forms.DataGridView();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnRetrieve = new System.Windows.Forms.Button();
			this.dtpTODOCDT = new System.Windows.Forms.DateTimePicker();
			this.dtpFRDOCDT = new System.Windows.Forms.DateTimePicker();
			this.Label15 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.rdoOption1 = new System.Windows.Forms.RadioButton();
			this.rdoOption2 = new System.Windows.Forms.RadioButton();
			this.bgwProgress = new System.ComponentModel.BackgroundWorker();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvFG).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvSO).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWO).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvDO).BeginInit();
			this.Panel1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 9;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360f));
			this.TableLayoutPanel3.Controls.Add(this.GroupBox4, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label7, 2, 1);
			this.TableLayoutPanel3.Controls.Add(this.btnExcel, 5, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label5, 7, 4);
			this.TableLayoutPanel3.Controls.Add(this.Label4, 0, 4);
			this.TableLayoutPanel3.Controls.Add(this.Label3, 8, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.dgvFG, 0, 5);
			this.TableLayoutPanel3.Controls.Add(this.dgvSO, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.dgvWO, 7, 3);
			this.TableLayoutPanel3.Controls.Add(this.dgvDO, 7, 5);
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 6, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnRetrieve, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.dtpTODOCDT, 3, 1);
			this.TableLayoutPanel3.Controls.Add(this.dtpFRDOCDT, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label15, 0, 1);
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
			this.TableLayoutPanel3.Size = new System.Drawing.Size(1331, 665);
			this.TableLayoutPanel3.TabIndex = 19;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(212, 41);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(25, 16);
			this.Label7.TabIndex = 78;
			this.Label7.Text = "To";
			this.btnExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcel.Image = IMS.My.Resources.Resources.Refresh;
			this.btnExcel.Location = new System.Drawing.Point(502, 2);
			this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnExcel.Name = "btnExcel";
			this.TableLayoutPanel3.SetRowSpan(this.btnExcel, 2);
			this.btnExcel.Size = new System.Drawing.Size(120, 50);
			this.btnExcel.TabIndex = 76;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcel.UseVisualStyleBackColor = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 10);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(70, 16);
			this.Label1.TabIndex = 73;
			this.Label1.Text = "Search By";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(645, 375);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(219, 20);
			this.Label5.TabIndex = 72;
			this.Label5.Text = "Delivery Order Information";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.TableLayoutPanel3.SetColumnSpan(this.Label4, 4);
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 375);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(232, 20);
			this.Label4.TabIndex = 71;
			this.Label4.Text = "Finished Goods Information";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(974, 62);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(197, 20);
			this.Label3.TabIndex = 70;
			this.Label3.Text = "Work Order Information";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.TableLayoutPanel3.SetColumnSpan(this.Label2, 3);
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 62);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(201, 20);
			this.Label2.TabIndex = 69;
			this.Label2.Text = "Sales Order Information";
			this.dgvFG.AllowUserToAddRows = false;
			this.dgvFG.AllowUserToDeleteRows = false;
			this.dgvFG.AllowUserToResizeRows = false;
			this.dgvFG.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvFG, 7);
			this.dgvFG.EnableHeadersVisualStyles = false;
			this.dgvFG.Location = new System.Drawing.Point(3, 398);
			this.dgvFG.MultiSelect = false;
			this.dgvFG.Name = "dgvFG";
			this.dgvFG.ReadOnly = true;
			this.dgvFG.RowHeadersVisible = false;
			this.dgvFG.RowHeadersWidth = 51;
			this.dgvFG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFG.Size = new System.Drawing.Size(636, 264);
			this.dgvFG.TabIndex = 68;
			this.dgvSO.AllowUserToAddRows = false;
			this.dgvSO.AllowUserToDeleteRows = false;
			this.dgvSO.AllowUserToResizeRows = false;
			this.dgvSO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvSO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvSO, 8);
			this.dgvSO.EnableHeadersVisualStyles = false;
			this.dgvSO.Location = new System.Drawing.Point(3, 85);
			this.dgvSO.MultiSelect = false;
			this.dgvSO.Name = "dgvSO";
			this.dgvSO.ReadOnly = true;
			this.dgvSO.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvSO.RowHeadersVisible = false;
			this.dgvSO.RowHeadersWidth = 51;
			this.dgvSO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSO.Size = new System.Drawing.Size(965, 287);
			this.dgvSO.TabIndex = 58;
			this.dgvWO.AllowUserToAddRows = false;
			this.dgvWO.AllowUserToDeleteRows = false;
			this.dgvWO.AllowUserToResizeRows = false;
			this.dgvWO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWO.EnableHeadersVisualStyles = false;
			this.dgvWO.Location = new System.Drawing.Point(974, 85);
			this.dgvWO.MultiSelect = false;
			this.dgvWO.Name = "dgvWO";
			this.dgvWO.ReadOnly = true;
			this.dgvWO.RowHeadersVisible = false;
			this.dgvWO.RowHeadersWidth = 51;
			this.dgvWO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWO.Size = new System.Drawing.Size(351, 287);
			this.dgvWO.TabIndex = 62;
         
			this.dgvDO.AllowUserToAddRows = false;
			this.dgvDO.AllowUserToDeleteRows = false;
			this.dgvDO.AllowUserToResizeRows = false;
			this.dgvDO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvDO, 2);
			this.dgvDO.EnableHeadersVisualStyles = false;
			this.dgvDO.Location = new System.Drawing.Point(645, 398);
			this.dgvDO.MultiSelect = false;
			this.dgvDO.Name = "dgvDO";
			this.dgvDO.ReadOnly = true;
			this.dgvDO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvDO.RowHeadersVisible = false;
			this.dgvDO.RowHeadersWidth = 51;
			this.dgvDO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDO.Size = new System.Drawing.Size(680, 264);
			this.dgvDO.TabIndex = 67;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel3.SetColumnSpan(this.btnClose, 2);
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(628, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel3.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnRetrieve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRetrieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRetrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRetrieve.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRetrieve.Location = new System.Drawing.Point(376, 2);
			this.btnRetrieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRetrieve.Name = "btnRetrieve";
			this.TableLayoutPanel3.SetRowSpan(this.btnRetrieve, 2);
			this.btnRetrieve.Size = new System.Drawing.Size(120, 50);
			this.btnRetrieve.TabIndex = 75;
			this.btnRetrieve.Text = "Retrieve";
			this.btnRetrieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRetrieve.UseVisualStyleBackColor = false;
			this.dtpTODOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpTODOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTODOCDT.Location = new System.Drawing.Point(243, 38);
			this.dtpTODOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpTODOCDT.Name = "dtpTODOCDT";
			this.dtpTODOCDT.Size = new System.Drawing.Size(127, 22);
			this.dtpTODOCDT.TabIndex = 74;
			this.dtpFRDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpFRDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFRDOCDT.Location = new System.Drawing.Point(79, 38);
			this.dtpFRDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFRDOCDT.Name = "dtpFRDOCDT";
			this.dtpFRDOCDT.Size = new System.Drawing.Size(127, 22);
			this.dtpFRDOCDT.TabIndex = 64;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 41);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(39, 16);
			this.Label15.TabIndex = 56;
			this.Label15.Text = "From";
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1343, 716);
			this.Panel1.TabIndex = 20;
			this.TableLayoutPanel3.SetColumnSpan(this.GroupBox4, 3);
			this.GroupBox4.Controls.Add(this.rdoOption1);
			this.GroupBox4.Controls.Add(this.rdoOption2);
			this.GroupBox4.Location = new System.Drawing.Point(79, 2);
			this.GroupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.GroupBox4.Size = new System.Drawing.Size(207, 32);
			this.GroupBox4.TabIndex = 79;
			this.GroupBox4.TabStop = false;
			this.rdoOption1.AutoSize = true;
			this.rdoOption1.Checked = true;
			this.rdoOption1.Location = new System.Drawing.Point(5, 9);
			this.rdoOption1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdoOption1.Name = "rdoOption1";
			this.rdoOption1.Size = new System.Drawing.Size(83, 20);
			this.rdoOption1.TabIndex = 4;
			this.rdoOption1.TabStop = true;
			this.rdoOption1.Text = "Doc Date";
			this.rdoOption1.UseVisualStyleBackColor = true;
			this.rdoOption2.AutoSize = true;
			this.rdoOption2.Location = new System.Drawing.Point(97, 9);
			this.rdoOption2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.rdoOption2.Name = "rdoOption2";
			this.rdoOption2.Size = new System.Drawing.Size(79, 20);
			this.rdoOption2.TabIndex = 5;
			this.rdoOption2.Text = "Del Date";
			this.rdoOption2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1395, 728);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmSLQSLO";
			base.Tag = "SLQSLO";
			this.Text = "Sales Order Status Inquiry";
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvFG).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvSO).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWO).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvDO).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

       

        private void frmSLQSLO_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpFRDOCDT.Value = DateTime.Now;
		}

		private void frmSLQSLO_FormClosing(object sender, FormClosingEventArgs e)
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
        private void ShowChildForm(object sender, EventArgs e, Form frmObject)
        {
            Form[] mdiChildren = base.MdiChildren;
            foreach (Form ChildForm in mdiChildren)
            {
                if (Operators.CompareString(ChildForm.Name, frmObject.Name, false) == 0)
                {
                    ChildForm.Show();
                    ChildForm.BringToFront();
                    frmObject = null;
                    return;
                }
            }
            frmObject.MdiParent = G.MDIParent;
            frmObject.WindowState = FormWindowState.Maximized;
            frmObject.Show();
            G.MDIParent.Panel1.Visible = false;
        }
		Timer tmShow=new Timer();
		frmPDEWKO frm;
        private void dgvWO_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			
			
				RefreshGridFG();
				RefreshGridWO();
				RefreshGridDO();
			
		}
        private void dgvWO_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            if (dgvSO.CurrentRow.DefaultCellStyle.BackColor == Color.LightSalmon)
            {
                frm = new frmPDEWKO();

                ShowChildForm(RuntimeHelpers.GetObjectValue(sender), e, frm);
                tmShow = new Timer(); tmShow.Interval = 100;
                tmShow.Tick += TmShow_Tick;

                tmShow.Enabled = true;


            }

        }
        private void TmShow_Tick(object sender, EventArgs e)
        {
		     frm.BindComboBox();
            frm.txtTYPE.Text = "ORDER";
            frm.EnableButton();
            frm.Panel1.Visible = true;
            frm.Panel2.Visible = false;
			tmShow.Enabled = false;
			tmShow.Tick-= TmShow_Tick;
             frm.cbMDLCD.SelectedValue = dgvSO.CurrentRow.Cells["SLORD_ITMCD"].Value;
              frm.cbEXSPCK.SelectedValue = dgvSO.CurrentRow.Cells["SLORD_PACKING"].Value;

        }

        private void RefreshGridSO()
		{
			DateTime dtFrom = dtpFRDOCDT.Value;
            dtFrom=dtFrom.AddDays(-1);
            DateTime dtTo = dtpTODOCDT.Value;
            dtTo=dtTo.AddDays(1);
            dgvSO.DataSource = null;
			int intOption = (rdoOption1.Checked ? 1 : 2);
			string strSQL = "EXEC spSLQSLO " + Conversions.ToString(intOption) + ", ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtFrom) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtTo) + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No data found!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			DataGridView dataGridView = dgvSO;
			dataGridView.DataSource = dt;
			int i = default(int);
			dataGridView.Columns[i].Visible = false;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Order No");
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
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Del Date");
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
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Part");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Order Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quotation");
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
				DataGridView dataGridView2 = dgvSO;
				int num = dataGridView2.RowCount - 1;
				for (i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(dataGridView2.Rows[i].Cells["ORD_STATUS"].Value, 0, false))
					{
						dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.LightSalmon;
					}
					if (Operators.ConditionalCompareObjectEqual(dataGridView2.Rows[i].Cells["ORD_STATUS"].Value, 1, false))
					{
						dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
					}
					if (Operators.ConditionalCompareObjectEqual(dataGridView2.Rows[i].Cells["ORD_STATUS"].Value, 2, false))
					{
						dataGridView2.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
					}
				}
				dataGridView2.Refresh();
				dataGridView2 = null;
			}
		}

		private void RefreshGridFG()
		{
			int i = 0;
			dgvFG.DataSource = null;
			string strSQL = Conversions.ToString(Operators.ConcatenateObject("exec spSLQSLO_FG ", dgvSO.CurrentRow.Cells["SLORD_RECID"].Value));
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvFG;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FGR Date");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance Qty");
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

		private void RefreshGridWO()
		{
			int i = 0;
			dgvWO.DataSource = null;
			string strSQL = Conversions.ToString(Operators.ConcatenateObject("exec spSLQSLO_WO ", dgvSO.CurrentRow.Cells["SLORD_RECID"].Value));
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView = dgvWO;
				dataGridView.DataSource = dt;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order No");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i = checked(i + 1);
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO Qty");
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

		private void RefreshGridDO()
		{
			int i = 0;
			dgvDO.DataSource = null;
			string strSQL = Conversions.ToString(Operators.ConcatenateObject("exec spSLQSLO_DO ", dgvSO.CurrentRow.Cells["SLORD_RECID"].Value));
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvDO;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
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

		private void btnRetrieve_Click(object sender, EventArgs e)
		{
			RefreshGridSO();
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bgwProgress.RunWorkerAsync();
		}

		private void bgwProgress_DoWork(object sender, DoWorkEventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application xlsApp = new ApplicationClass();
			int intOption = (rdoOption1.Checked ? 1 : 2);
			string strSQL = "EXEC spSLQSLO_XLS " + Conversions.ToString(intOption) + ", ";
            DateTime dtFrom = dtpFRDOCDT.Value;
            dtFrom = dtFrom.AddDays(-1);
            DateTime dtTo = dtpTODOCDT.Value;
            dtTo = dtTo.AddDays(1);
            strSQL = strSQL + "'" + Common.gfSQLDate(dtFrom) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtTo) + "'";
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
			xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sales Order Status Report");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			xlsApp.Cells[4, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Order No");
			xlsApp.Cells[4, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Del Date");
			xlsApp.Cells[4, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
			xlsApp.Cells[4, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Salesman");
			xlsApp.Cells[4, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Name");
			xlsApp.Cells[4, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			xlsApp.Cells[4, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
			xlsApp.Cells[4, 8] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Part No");
			xlsApp.Cells[4, 9] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
			xlsApp.Cells[4, 10] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Unit Price");
			xlsApp.Cells[4, 11] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
			xlsApp.Cells[4, 12] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
			xlsApp.Cells[5, 1] = "";
			xlsApp.Cells[5, 2] = "NGÀY GIAO";
			xlsApp.Cells[5, 3] = "NGÀY NHẬN";
			xlsApp.Cells[5, 4] = "NV";
			xlsApp.Cells[5, 5] = "KHÁCH HÀNG";
			xlsApp.Cells[5, 8] = "MÃ HÀNG";
			xlsApp.Cells[5, 9] = "SL";
			xlsApp.Cells[5, 10] = "GIÁ";
			xlsApp.Cells[5, 11] = "QUI CÁCH BB";
			xlsApp.Cells[5, 12] = "G.CHÚ";
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[5, 12])).Font.Bold = true;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 12])).EntireColumn.NumberFormat = "@";
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 12])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[5, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[5, 12])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[5, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[5, 12])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
			int intRow = 6;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SLORD_DOCNO"]);
					xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DELDT"]);
					xlsApp.Cells[intRow, 3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOCDT"]);
					xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SALESMAN"]);
					xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_SHORT"]);
					xlsApp.Cells[intRow, 6] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SLORD_ITMCD"]);
					xlsApp.Cells[intRow, 7] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SLORD_REVNO"]);
					xlsApp.Cells[intRow, 8] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACPT_CPTNO"]);
					xlsApp.Cells[intRow, 9] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SLORD_SOQTY"]);
					xlsApp.Cells[intRow, 10] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SLORD_UPRICE"]);
					xlsApp.Cells[intRow, 11] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SLORD_PACKING"]);
					xlsApp.Cells[intRow, 12] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SLORD_REMRK"]);
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7])).NumberFormat = "0.00";
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).NumberFormat = "0.00";
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 10]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 10])).NumberFormat = "0.000";
					intRow++;
				}
				((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 12])).VerticalAlignment = XlVAlign.xlVAlignCenter;
				xlsSheet.Columns.AutoFit();
				xlsSheet.Rows.AutoFit();
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
	}
}
