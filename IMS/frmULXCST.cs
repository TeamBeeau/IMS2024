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
	public class frmULXCST : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdCalculateME")]
		private Button _cmdCalculateME;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdUndoME")]
		private Button _cmdUndoME;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdCloseME")]
		private Button _cmdCloseME;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdClose")]
		private Button _cmdClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

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

		[field: AccessedThroughProperty("dgvME")]
		internal virtual DataGridView dgvME
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpCURDT")]
		internal virtual DateTimePicker dtpCURDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpPREDT")]
		internal virtual DateTimePicker dtpPREDT
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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button cmdCalculateME
		{
			[CompilerGenerated]
			get
			{
				return _cmdCalculateME;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdCalculateME_Click;
				Button button = _cmdCalculateME;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdCalculateME = value;
				button = _cmdCalculateME;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdUndoME
		{
			[CompilerGenerated]
			get
			{
				return _cmdUndoME;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdUndoME_Click;
				Button button = _cmdUndoME;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdUndoME = value;
				button = _cmdUndoME;
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

		internal virtual Button cmdCloseME
		{
			[CompilerGenerated]
			get
			{
				return _cmdCloseME;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdCloseME_Click;
				Button button = _cmdCloseME;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdCloseME = value;
				button = _cmdCloseME;
				if (button != null)
				{
					button.Click += value2;
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

		public frmULXCST()
		{
			base.FormClosing += frmULXCST_FormClosing;
			base.Load += frmULXCST_Load;
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
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdCloseME = new System.Windows.Forms.Button();
			this.Label7 = new System.Windows.Forms.Label();
			this.dtpCURDT = new System.Windows.Forms.DateTimePicker();
			this.dgvME = new System.Windows.Forms.DataGridView();
			this.cmdCalculateME = new System.Windows.Forms.Button();
			this.cmdUndoME = new System.Windows.Forms.Button();
			this.dtpPREDT = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvME).BeginInit();
			base.SuspendLayout();
			this.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel1.Controls.Add(this.TableLayoutPanel2);
			this.Panel1.Controls.Add(this.Label13);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1350, 631);
			this.Panel1.TabIndex = 7;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.ColumnCount = 8;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50f));
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cmdCancel, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cmdClose, 4, 1);
			this.TableLayoutPanel2.Controls.Add(this.cmdCloseME, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label7, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.dtpCURDT, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.dgvME, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.cmdCalculateME, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.cmdUndoME, 7, 1);
			this.TableLayoutPanel2.Controls.Add(this.dtpPREDT, 7, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 6, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(1063, 585);
			this.TableLayoutPanel2.TabIndex = 40;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(387, 32);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(120, 50);
			this.cmdCancel.TabIndex = 41;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdClose.Image = IMS.My.Resources.Resources.Close;
			this.cmdClose.Location = new System.Drawing.Point(513, 32);
			this.cmdClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(120, 50);
			this.cmdClose.TabIndex = 41;
			this.cmdClose.Text = "Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdCloseME.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCloseME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCloseME.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdCloseME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdCloseME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCloseME.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCloseME.Image = IMS.My.Resources.Resources.process;
			this.cmdCloseME.Location = new System.Drawing.Point(260, 32);
			this.cmdCloseME.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cmdCloseME.Name = "cmdCloseME";
			this.cmdCloseME.Size = new System.Drawing.Size(120, 50);
			this.cmdCloseME.TabIndex = 41;
			this.cmdCloseME.Text = "Close ME";
			this.cmdCloseME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCloseME.UseVisualStyleBackColor = false;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(4, 5);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(120, 20);
			this.Label7.TabIndex = 31;
			this.Label7.Text = "Current Month";
			this.dtpCURDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpCURDT.CustomFormat = "MMM yyyy";
			this.dtpCURDT.Enabled = false;
			this.dtpCURDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtpCURDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCURDT.Location = new System.Drawing.Point(132, 4);
			this.dtpCURDT.Margin = new System.Windows.Forms.Padding(4);
			this.dtpCURDT.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtpCURDT.Name = "dtpCURDT";
			this.dtpCURDT.Size = new System.Drawing.Size(120, 22);
			this.dtpCURDT.TabIndex = 1;
			this.dgvME.AllowUserToAddRows = false;
			this.dgvME.AllowUserToDeleteRows = false;
			this.dgvME.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvME.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvME.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvME.ColumnHeadersHeight = 20;
			this.dgvME.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TableLayoutPanel2.SetColumnSpan(this.dgvME, 8);
			this.dgvME.EnableHeadersVisualStyles = false;
			this.dgvME.Location = new System.Drawing.Point(4, 88);
			this.dgvME.Margin = new System.Windows.Forms.Padding(4);
			this.dgvME.MultiSelect = false;
			this.dgvME.Name = "dgvME";
			this.dgvME.ReadOnly = true;
			this.dgvME.RowHeadersWidth = 20;
			this.dgvME.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvME.RowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvME.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvME.Size = new System.Drawing.Size(1040, 489);
			this.dgvME.TabIndex = 0;
			this.dgvME.TabStop = false;
			this.cmdCalculateME.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCalculateME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCalculateME.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdCalculateME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdCalculateME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCalculateME.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCalculateME.Image = IMS.My.Resources.Resources.process;
			this.cmdCalculateME.Location = new System.Drawing.Point(132, 32);
			this.cmdCalculateME.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cmdCalculateME.Name = "cmdCalculateME";
			this.cmdCalculateME.Size = new System.Drawing.Size(120, 50);
			this.cmdCalculateME.TabIndex = 38;
			this.cmdCalculateME.Text = "Calculate ME";
			this.cmdCalculateME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCalculateME.UseVisualStyleBackColor = false;
			this.cmdUndoME.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmdUndoME.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdUndoME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdUndoME.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdUndoME.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdUndoME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdUndoME.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdUndoME.Image = IMS.My.Resources.Resources.process;
			this.cmdUndoME.Location = new System.Drawing.Point(813, 32);
			this.cmdUndoME.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cmdUndoME.Name = "cmdUndoME";
			this.cmdUndoME.Size = new System.Drawing.Size(120, 50);
			this.cmdUndoME.TabIndex = 40;
			this.cmdUndoME.Text = "Undo ME";
			this.cmdUndoME.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdUndoME.UseVisualStyleBackColor = false;
			this.dtpPREDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpPREDT.CustomFormat = "MMM yyyy";
			this.dtpPREDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtpPREDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPREDT.Location = new System.Drawing.Point(813, 4);
			this.dtpPREDT.Margin = new System.Windows.Forms.Padding(4);
			this.dtpPREDT.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtpPREDT.Name = "dtpPREDT";
			this.dtpPREDT.Size = new System.Drawing.Size(120, 22);
			this.dtpPREDT.TabIndex = 34;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(690, 5);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(115, 20);
			this.Label1.TabIndex = 35;
			this.Label1.Text = "Previous Month";
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.Color.Red;
			this.Label13.Location = new System.Drawing.Point(11, 542);
			this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(0, 16);
			this.Label13.TabIndex = 37;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmULXCST";
			base.Tag = "ULXCST";
			this.Text = "Month End Costing";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvME).EndInit();
			base.ResumeLayout(false);
		}

		private void frmULXCST_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmULXCST_Load(object sender, EventArgs e)
		{
			ClearFormData();
		}

		private void RefreshGrid()
		{
			DataTable dt = new DataTable();
			string strField = "FIFO_ISUDT, FIFO_DOCNO, FIFO_DOCCD, FIFO_ITMCD, FIFO_LOCID, FIFO_TRNQT";
			dt = DB.GetTable(strField, "FIFO_WRK", "FIFO_GRLNO = ''", "FIFO_ISUDT, FIFO_DOCNO, FIFO_ITMCD");
			DataGridView dataGridView = dgvME;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Width = 110;
			dataGridView.Columns[0].HeaderText = "Document Date";
			dataGridView.Columns[1].Width = 100;
			dataGridView.Columns[1].HeaderText = "Document No";
			dataGridView.Columns[2].Width = 110;
			dataGridView.Columns[2].HeaderText = "Document Code";
			dataGridView.Columns[3].Width = 200;
			dataGridView.Columns[3].HeaderText = "Item Code";
			dataGridView.Columns[4].Width = 80;
			dataGridView.Columns[4].HeaderText = "Location";
			dataGridView.Columns[5].Width = 80;
			dataGridView.Columns[5].HeaderText = "Shortage Quantity";
			dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.AutoResizeRows();
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
			dataGridView.ClearSelection();
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void ClearFormData()
		{
			int intCYEAR = Conversions.ToInteger(DB.GetColumnValue("MACTL_CYEAR", "MACTL_TBL", ""));
			int intCMTH = Conversions.ToInteger(DB.GetColumnValue("MACTL_CMTH", "MACTL_TBL", ""));
			DateTime dtCURDT = DateAndTime.DateSerial(intCYEAR, intCMTH, 1);
			dtpCURDT.Value = dtCURDT;
			dtpPREDT.Value = dtCURDT;
			cmdCloseME.Enabled = false;
		}

		private void CalculateME()
		{
			try
			{
				switch (Costing())
				{
				case 0:
					MessageBox.Show("Costing successfully done!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case -2:
					MessageBox.Show("Costing failed! Inventory shortage.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;
				case -3:
					MessageBox.Show("Costing failed!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					break;
				}
				RefreshGrid();
				cmdCloseME.Enabled = dgvME.Rows.Count == 0;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show("Costing failed!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private int Costing()
		{
			OleDbCommand cmd = new OleDbCommand();
			int Costing;
			try
			{
				string strSQL = "COSTING1";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandTimeout = 3600;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = strSQL;
				cmd.Parameters.Add("@RETVAL", OleDbType.Integer).Direction = ParameterDirection.ReturnValue;
				cmd.Parameters.Add("@CYEAR", OleDbType.Integer).Value = dtpCURDT.Value.Year;
				cmd.Parameters.Add("@CMTH", OleDbType.Integer).Value = dtpCURDT.Value.Month;
				cmd.Parameters.Add("@USRID", OleDbType.VarChar).Value = PublicVar.gstrLogonID;
				cmd.ExecuteNonQuery();
				Costing = Conversions.ToInteger(cmd.Parameters["@RETVAL"].Value);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message, "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Costing = -3;
				ProjectData.ClearProjectError();
			}
			return Costing;
		}

		private void CloseME()
		{
			OleDbCommand cmd = new OleDbCommand();
			if (!PublicVar.gblnAdminGRP)
			{
				MessageBox.Show("Only user with admin right is allowed to perform this operation!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{
				string strSQL = "CLOSEME";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = strSQL;
				cmd.Parameters.Add("@RETVAL", OleDbType.Integer).Direction = ParameterDirection.ReturnValue;
				cmd.Parameters.Add("@CYEAR", OleDbType.Integer).Value = dtpCURDT.Value.Year;
				cmd.Parameters.Add("@CMTH", OleDbType.Integer).Value = dtpCURDT.Value.Month;
				cmd.Parameters.Add("@USRID", OleDbType.VarChar).Value = PublicVar.gstrLogonID;
				cmd.ExecuteNonQuery();
				object value = cmd.Parameters["@RETVAL"].Value;
				if (Operators.ConditionalCompareObjectEqual(value, 0, false))
				{
					MessageBox.Show("ME Closing successfully done!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					PublicVar.gintCYEAR = Conversions.ToInteger(DB.GetColumnValue("MACTL_CYEAR", "MACTL_TBL", ""));
					PublicVar.gintCMTH = Conversions.ToInteger(DB.GetColumnValue("MACTL_CMTH", "MACTL_TBL", ""));
					ClearFormData();
				}
				else if (Operators.ConditionalCompareObjectEqual(value, -2, false))
				{
					MessageBox.Show("Costing calculation is not performed for this period!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (Operators.ConditionalCompareObjectEqual(value, -3, false))
				{
					MessageBox.Show("Failed to calculate sales commission!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private void UndoME()
		{
			OleDbCommand cmd = new OleDbCommand();
			if (!PublicVar.gblnAdminGRP)
			{
				MessageBox.Show("Only user with admin right is allowed to perform this operation!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			try
			{
				string strSQL = "UNDOME";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandText = strSQL;
				cmd.Parameters.Add("@RETVAL", OleDbType.Integer).Direction = ParameterDirection.ReturnValue;
				cmd.Parameters.Add("@PYEAR", OleDbType.Integer).Value = dtpPREDT.Value.Year;
				cmd.Parameters.Add("@PMTH", OleDbType.Integer).Value = dtpPREDT.Value.Month;
				cmd.Parameters.Add("@USRID", OleDbType.VarChar).Value = PublicVar.gstrLogonID;
				cmd.ExecuteNonQuery();
				object value = cmd.Parameters["@RETVAL"].Value;
				if (Operators.ConditionalCompareObjectEqual(value, 0, false))
				{
					MessageBox.Show("Undo ME successfully!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					PublicVar.gintCYEAR = Conversions.ToInteger(DB.GetColumnValue("MACTL_CYEAR", "MACTL_TBL", ""));
					PublicVar.gintCMTH = Conversions.ToInteger(DB.GetColumnValue("MACTL_CMTH", "MACTL_TBL", ""));
					ClearFormData();
				}
				else if (Operators.ConditionalCompareObjectEqual(value, -2, false))
				{
					MessageBox.Show("Failed to undo ME!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			ClearFormData();
		}

		private void cmdCalculateME_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			CalculateME();
			Cursor.Current = Cursors.Default;
		}

		private void cmdCloseME_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			CloseME();
			Cursor.Current = Cursors.Default;
		}

		private void cmdUndoME_Click(object sender, EventArgs e)
		{
			if (checked(dtpPREDT.Value.Year * 12 + dtpPREDT.Value.Month >= dtpCURDT.Value.Year * 12 + dtpCURDT.Value.Month))
			{
				MessageBox.Show("Previous Month must earlier than Current Month!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			UndoME();
			Cursor.Current = Cursors.Default;
		}
	}
}
