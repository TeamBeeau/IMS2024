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
	public class frmMAECAL : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtpYEAR")]
		private DateTimePicker _dtpYEAR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnGENERATE")]
		private Button _btnGENERATE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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

		[field: AccessedThroughProperty("clbWEEKEND")]
		internal virtual CheckedListBox clbWEEKEND
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDOCNOFR")]
		internal virtual Label lblDOCNOFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DateTimePicker dtpYEAR
		{
			[CompilerGenerated]
			get
			{
				return _dtpYEAR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dtpYEAR_ValueChanged;
				DateTimePicker dateTimePicker = _dtpYEAR;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= value2;
				}
				_dtpYEAR = value;
				dateTimePicker = _dtpYEAR;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("dgvDetails")]
		internal virtual DataGridView dgvDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpDOCDT")]
		internal virtual DateTimePicker dtpDOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDESC")]
		internal virtual TextBox txtDESC
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

		internal virtual Button btnREMOVE
		{
			[CompilerGenerated]
			get
			{
				return _btnREMOVE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnREMOVE_Click;
				Button button = _btnREMOVE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnREMOVE = value;
				button = _btnREMOVE;
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

		internal virtual Button btnGENERATE
		{
			[CompilerGenerated]
			get
			{
				return _btnGENERATE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnGENERATE_Click;
				Button button = _btnGENERATE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnGENERATE = value;
				button = _btnGENERATE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		[field: AccessedThroughProperty("MACAL_DATE")]
		internal virtual DataGridViewTextBoxColumn MACAL_DATE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACAL_DESC")]
		internal virtual DataGridViewTextBoxColumn MACAL_DESC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnCancel
		{
			[CompilerGenerated]
			get
			{
				return _btnCancel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCancel_Click;
				Button button = _btnCancel;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCancel = value;
				button = _btnCancel;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public frmMAECAL()
		{
			base.FormClosing += frmMAECAL_FormClosing;
			base.Load += frmMAECAL_Load;
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.btnGENERATE = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lblDOCNOFR = new System.Windows.Forms.Label();
			this.clbWEEKEND = new System.Windows.Forms.CheckedListBox();
			this.dtpYEAR = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtDESC = new System.Windows.Forms.TextBox();
			this.MACAL_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACAL_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnCancel = new System.Windows.Forms.Button();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(4, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1343, 624);
			this.Panel1.TabIndex = 0;
			this.btnGENERATE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnGENERATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnGENERATE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnGENERATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnGENERATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGENERATE.Image = IMS.My.Resources.Resources.Confirm;
			this.btnGENERATE.Location = new System.Drawing.Point(381, 2);
			this.btnGENERATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGENERATE.Name = "btnGENERATE";
			this.btnGENERATE.Size = new System.Drawing.Size(120, 50);
			this.btnGENERATE.TabIndex = 19;
			this.btnGENERATE.Text = "Generate";
			this.btnGENERATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGENERATE.UseVisualStyleBackColor = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(507, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 20;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.lblDOCNOFR, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.clbWEEKEND, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.dtpYEAR, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.TableLayoutPanel4, 0, 8);
			this.TableLayoutPanel3.Controls.Add(this.dtpDOCDT, 1, 4);
			this.TableLayoutPanel3.Controls.Add(this.dgvDetails, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 4);
			this.TableLayoutPanel3.Controls.Add(this.Label3, 0, 5);
			this.TableLayoutPanel3.Controls.Add(this.txtDESC, 1, 5);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(8, 10);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 8;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(798, 463);
			this.TableLayoutPanel3.TabIndex = 2;
			this.lblDOCNOFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDOCNOFR.AutoSize = true;
			this.lblDOCNOFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDOCNOFR.Location = new System.Drawing.Point(3, 5);
			this.lblDOCNOFR.Name = "lblDOCNOFR";
			this.lblDOCNOFR.Size = new System.Drawing.Size(37, 16);
			this.lblDOCNOFR.TabIndex = 3;
			this.lblDOCNOFR.Text = "Year";
			this.clbWEEKEND.FormattingEnabled = true;
			this.clbWEEKEND.Items.AddRange(new object[2] { "Saturday", "Sunday" });
			this.clbWEEKEND.Location = new System.Drawing.Point(85, 29);
			this.clbWEEKEND.Name = "clbWEEKEND";
			this.clbWEEKEND.Size = new System.Drawing.Size(202, 55);
			this.clbWEEKEND.TabIndex = 5;
			this.dtpYEAR.CustomFormat = "yyyy";
			this.dtpYEAR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpYEAR.Location = new System.Drawing.Point(85, 2);
			this.dtpYEAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpYEAR.Name = "dtpYEAR";
			this.dtpYEAR.Size = new System.Drawing.Size(105, 22);
			this.dtpYEAR.TabIndex = 5;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 48);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(55, 16);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "Holiday";
			this.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 5;
			this.TableLayoutPanel3.SetColumnSpan(this.TableLayoutPanel4, 3);
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnGENERATE, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 4, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 405);
			this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel4.TabIndex = 3;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(129, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 17;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(3, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 50);
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "Add";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(85, 287);
			this.dtpDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDT.TabIndex = 4;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetails.Columns.AddRange(this.MACAL_DATE, this.MACAL_DESC);
			this.TableLayoutPanel3.SetColumnSpan(this.dgvDetails, 3);
			this.dgvDetails.Location = new System.Drawing.Point(3, 90);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.TableLayoutPanel3.SetRowSpan(this.dgvDetails, 2);
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(786, 192);
			this.dgvDetails.TabIndex = 11;
			this.dgvDetails.TabStop = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 290);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(37, 16);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Date";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 311);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 16);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Description";
			this.txtDESC.Location = new System.Drawing.Point(85, 313);
			this.txtDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDESC.Multiline = true;
			this.txtDESC.Name = "txtDESC";
			this.TableLayoutPanel3.SetRowSpan(this.txtDESC, 2);
			this.txtDESC.Size = new System.Drawing.Size(486, 66);
			this.txtDESC.TabIndex = 17;
			this.MACAL_DATE.HeaderText = "Date";
			this.MACAL_DATE.Name = "MACAL_DATE";
			this.MACAL_DATE.ReadOnly = true;
			this.MACAL_DATE.Width = 120;
			this.MACAL_DESC.HeaderText = "Description";
			this.MACAL_DESC.Name = "MACAL_DESC";
			this.MACAL_DESC.ReadOnly = true;
			this.MACAL_DESC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACAL_DESC.Width = 400;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmMAECAL";
			base.Tag = "MAECAL";
			this.Text = "Calendar Master";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			base.ResumeLayout(false);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			ClearDetails();
			Close();
		}

		private void ClearDetails()
		{
			checked
			{
				int num = clbWEEKEND.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					clbWEEKEND.SetItemChecked(i, false);
				}
				dtpDOCDT.Value = DateAndTime.Now;
				dtpYEAR.Value = DateAndTime.Now;
				dtpYEAR.Enabled = true;
				txtDESC.Text = string.Empty;
				dgvDetails.Rows.Clear();
			}
		}

		private void frmMAECAL_FormClosing(object sender, FormClosingEventArgs e)
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

		private void dtpYEAR_ValueChanged(object sender, EventArgs e)
		{
			RefreshGrid();
		}

		private void RefreshGrid()
		{
			int i = 0;
			dgvDetails.Rows.Clear();
			string strSQL = "SELECT MACAL_DATE, MACAL_DESC ";
			strSQL += "FROM MACAL_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE MACAL_YEAR = '" + Conversions.ToString(dtpYEAR.Value) + "' ";
			strSQL += "AND MACAL_STSFG = 1 ";
			strSQL += "ORDER BY MACAL_DATE";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				try
				{
					int num = dt.Rows.Count - 1;
					for (i = 0; i <= num; i++)
					{
						dgvDetails.ClearSelection();
						dgvDetails.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvDetails.Rows[dgvDetails.Rows.Count - 1];
						dataGridViewRow.Cells["MACAL_DATE"].Value = Common.gfValidSQLStr(dt.Rows[i]["MACAL_DATE"].ToString());
						dataGridViewRow.Cells["MACAL_DESC"].Value = Common.gfValidSQLStr(dt.Rows[i]["MACAL_DESC"].ToString());
						dataGridViewRow = null;
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
		}

		private void frmMAECAL_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			RefreshGrid();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtDESC.Text.Trim(), string.Empty, false) == 0)
			{
				MessageBox.Show("Description cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			checked
			{
				int num = dgvDetails.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					string dtDATE = Common.gfValidSQLStr(dgvDetails.Rows[i].Cells["MACAL_DATE"].Value.ToString());
					if (Operators.CompareString(dtDATE, dtpDOCDT.Value.ToString("dd/MM/yyyy"), false) == 0)
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Date already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						return;
					}
				}
				if (Operators.CompareString(dtpDOCDT.Value.ToString("yyyy"), dtpYEAR.Value.ToString("yyyy"), false) != 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid year!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				dgvDetails.Rows.Add();
				dgvDetails.ClearSelection();
				dgvDetails.Rows[dgvDetails.Rows.Count - 1].Selected = true;
				dgvDetails.CurrentCell = dgvDetails.Rows[dgvDetails.Rows.Count - 1].Cells[0];
				dgvDetails.CurrentRow.Cells["MACAL_DATE"].Value = dtpDOCDT.Value.ToString("yyyy-MM-dd");
				dgvDetails.CurrentRow.Cells["MACAL_DESC"].Value = txtDESC.Text;
				txtDESC.Text = string.Empty;
				dtpYEAR.Enabled = false;
			}
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			dgvDetails.Rows.Remove(dgvDetails.SelectedRows[0]);
		}

		private void btnGENERATE_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			checked
			{
				int strOpt = default(int);
				if (clbWEEKEND.CheckedItems.Count > 0)
				{
					if (clbWEEKEND.CheckedItems.Count > 1)
					{
						strOpt = 3;
					}
					else
					{
						int num = clbWEEKEND.CheckedItems.Count - 1;
						for (int k = 0; k <= num; k++)
						{
							if (Operators.ConditionalCompareObjectEqual(clbWEEKEND.CheckedItems[k], "Sunday", false))
							{
								strOpt = 2;
							}
							if (Operators.ConditionalCompareObjectEqual(clbWEEKEND.CheckedItems[k], "Saturday", false))
							{
								strOpt = 1;
							}
						}
					}
				}
				string strSQL = "EXEC spMAECAL ";
				strSQL += "0, ";
				strSQL = strSQL + " " + Conversions.ToString(strOpt) + ", ";
				strSQL = strSQL + "'" + dtpYEAR.Value.ToString("yyyy") + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpYEAR.Value) + "', ";
				strSQL += "'', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex2 = ex3;
					MessageBox.Show(ex2.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
					return;
				}
				if (dgvDetails.Rows.Count > 0)
				{
					int num2 = dgvDetails.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						strSQL = "EXEC spMAECAL ";
						strSQL += "1, ";
						strSQL = strSQL + " " + Conversions.ToString(strOpt) + ", ";
						strSQL = strSQL + "'" + dtpYEAR.Value.ToString("yyyy") + "', ";
						strSQL = strSQL + "'" + dgvDetails.Rows[j].Cells["MACAL_DATE"].Value.ToString() + "', ";
						strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", dgvDetails.Rows[j].Cells["MACAL_DESC"].Value), "', ")));
						strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
						try
						{
							cmd.Connection = DB.GetDBConnection();
							cmd.CommandText = strSQL;
							int intAffected = cmd.ExecuteNonQuery();
						}
						catch (Exception ex4)
						{
							ProjectData.SetProjectError(ex4);
							Exception ex = ex4;
							MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							ProjectData.ClearProjectError();
							return;
						}
					}
				}
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Generate Successful!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				int num3 = clbWEEKEND.Items.Count - 1;
				for (int i = 0; i <= num3; i++)
				{
					clbWEEKEND.SetItemChecked(i, false);
				}
				ClearDetails();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}
	}
}
