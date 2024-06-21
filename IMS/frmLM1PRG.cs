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
	public class frmLM1PRG : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtPRGID")]
		private TextBox _txtPRGID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvLPRG")]
		private DataGridView _dgvLPRG;

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
		[AccessedThroughProperty("cmdDelete")]
		private Button _cmdDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdSave")]
		private Button _cmdSave;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtPRGID
		{
			[CompilerGenerated]
			get
			{
				return _txtPRGID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtPRGID_Leave;
				TextBox textBox = _txtPRGID;
				if (textBox != null)
				{
					textBox.Leave -= value2;
				}
				_txtPRGID = value;
				textBox = _txtPRGID;
				if (textBox != null)
				{
					textBox.Leave += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvLPRG
		{
			[CompilerGenerated]
			get
			{
				return _dgvLPRG;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dgvLPRG_DoubleClick;
				DataGridView dataGridView = _dgvLPRG;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick -= value2;
				}
				_dgvLPRG = value;
				dataGridView = _dgvLPRG;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick += value2;
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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

		public frmLM1PRG()
		{
			base.FormClosing += frmLM1PRG_FormClosing;
			base.Load += frmLM1PRG_Load;
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
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvLPRG = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtPRGID = new System.Windows.Forms.TextBox();
			this.txtDESC = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvLPRG).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.cmdClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdClose.Image = IMS.My.Resources.Resources.Close;
			this.cmdClose.Location = new System.Drawing.Point(388, 4);
			this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(120, 50);
			this.cmdClose.TabIndex = 6;
			this.cmdClose.Text = "Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(260, 4);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(120, 50);
			this.cmdCancel.TabIndex = 5;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdSave.Image = IMS.My.Resources.Resources.Save;
			this.cmdSave.Location = new System.Drawing.Point(4, 4);
			this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(120, 50);
			this.cmdSave.TabIndex = 3;
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
			this.cmdDelete.Size = new System.Drawing.Size(120, 50);
			this.cmdDelete.TabIndex = 4;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdDelete.UseVisualStyleBackColor = false;
			this.Panel1.AutoScroll = true;
			this.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1350, 709);
			this.Panel1.TabIndex = 5;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.dgvLPRG, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtPRGID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtDESC, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 5;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1099, 578);
			this.TableLayoutPanel1.TabIndex = 32;
			this.dgvLPRG.AllowUserToAddRows = false;
			this.dgvLPRG.AllowUserToDeleteRows = false;
			this.dgvLPRG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvLPRG.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLPRG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvLPRG.ColumnHeadersHeight = 25;
			this.dgvLPRG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvLPRG, 2);
			this.dgvLPRG.Location = new System.Drawing.Point(4, 4);
			this.dgvLPRG.Margin = new System.Windows.Forms.Padding(4);
			this.dgvLPRG.MultiSelect = false;
			this.dgvLPRG.Name = "dgvLPRG";
			this.dgvLPRG.ReadOnly = true;
			this.dgvLPRG.RowHeadersWidth = 20;
			this.dgvLPRG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvLPRG.RowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvLPRG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLPRG.Size = new System.Drawing.Size(1040, 417);
			this.dgvLPRG.TabIndex = 0;
			this.dgvLPRG.TabStop = false;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 2);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cmdSave, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdCancel, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdDelete, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdClose, 3, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 508);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(517, 58);
			this.TableLayoutPanel2.TabIndex = 33;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(4, 430);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(120, 20);
			this.Label7.TabIndex = 31;
			this.Label7.Text = "Program ID";
			this.txtPRGID.Location = new System.Drawing.Point(132, 429);
			this.txtPRGID.Margin = new System.Windows.Forms.Padding(4);
			this.txtPRGID.Name = "txtPRGID";
			this.txtPRGID.Size = new System.Drawing.Size(172, 22);
			this.txtPRGID.TabIndex = 1;
			this.txtDESC.Location = new System.Drawing.Point(132, 459);
			this.txtDESC.Margin = new System.Windows.Forms.Padding(4);
			this.txtDESC.Name = "txtDESC";
			this.txtDESC.Size = new System.Drawing.Size(512, 22);
			this.txtDESC.TabIndex = 2;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(4, 460);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Description";
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1350, 709);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmLM1PRG";
			this.Text = "Program Maintenance";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvLPRG).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void frmLM1PRG_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmLM1PRG_Load(object sender, EventArgs e)
		{
			SetMaxLength();
			RefreshGrid();
			ClearFormData();
		}

		private void SetMaxLength()
		{
			txtPRGID.MaxLength = DB.CharColumnMaxLength("LPRG_TBL", "LPRG_PRGID");
			txtDESC.MaxLength = DB.CharColumnMaxLength("LPRG_TBL", "LPRG_DESC");
		}

		private void RefreshGrid()
		{
			DataTable dt = new DataTable();
			string strSQL = "LPRG_DESC, LPRG_PRGID";
			dt = DB.GetTable(strSQL, "LPRG_TBL", "", "LPRG_DESC");
			DataGridView dataGridView = dgvLPRG;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 200;
			dataGridView.Columns[0].HeaderText = "Description";
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 80;
			dataGridView.Columns[1].HeaderText = "Program ID";
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void ClearFormData()
		{
			txtPRGID.Text = "";
			txtPRGID.Modified = false;
			txtDESC.Text = "";
			txtDESC.Modified = false;
			txtPRGID.Focus();
		}

		private bool DeleteRecord()
		{
			bool DeleteRecord;
			try
			{
				string strSQL = "DELETE LPRG_TBL ";
				strSQL = strSQL + "WHERE LPRG_PRGID = '" + txtPRGID.Text.Trim() + "'";
				DeleteRecord = (DB.DBExecute(strSQL) ? true : false);
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message + "\r\nRecord not deleted!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				DeleteRecord = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				DeleteRecord = false;
				ProjectData.ClearProjectError();
			}
			return DeleteRecord;
		}

		private bool ValidKeyField()
		{
			if (Operators.CompareString(txtPRGID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Blank Program ID!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPRGID.Focus();
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
			bool SaveRecord;
			try
			{
				string strSQL = "SELECT * FROM LPRG_TBL ";
				strSQL = strSQL + "WHERE LPRG_PRGID = '" + txtPRGID.Text.Trim() + "'";
				if (!DB.RecordExists(strSQL))
				{
					strSQL = "INSERT LPRG_TBL(";
					strSQL += "LPRG_PRGID, LPRG_DESC, LPRG_USRID, LPRG_LUPDT) ";
					strSQL += "VALUES (";
					strSQL = strSQL + "'" + txtPRGID.Text.Trim() + "', '" + txtDESC.Text.Trim() + "', '" + PublicVar.gstrLogonID + "', '" + DateAndTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "')";
				}
				else
				{
					strSQL = "UPDATE LPRG_TBL SET ";
					strSQL = strSQL + "LPRG_PRGID = '" + txtPRGID.Text.Trim() + "', ";
					strSQL = strSQL + "LPRG_DESC = '" + txtDESC.Text.Trim() + "', ";
					strSQL = strSQL + "LPRG_USRID = '" + PublicVar.gstrLogonID + "', ";
					strSQL = strSQL + "LPRG_LUPDT = '" + DateAndTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "' ";
					strSQL = strSQL + "WHERE LPRG_PRGID = '" + txtPRGID.Text.Trim() + "'";
				}
				SaveRecord = DB.DBExecute(strSQL);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message, "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				SaveRecord = false;
				ProjectData.ClearProjectError();
			}
			return SaveRecord;
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (ValidAllField())
			{
				if (!SaveRecord())
				{
					MessageBox.Show("Record not edited!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				MessageBox.Show("Record edited!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefreshGrid();
				ClearFormData();
			}
		}

		private void ShowGridData()
		{
			DataGridView dataGridView = dgvLPRG;
			txtPRGID.Text = Conversions.ToString(dataGridView[1, dataGridView.CurrentCell.RowIndex].Value);
			txtDESC.Text = Conversions.ToString(dataGridView[0, dataGridView.CurrentCell.RowIndex].Value);
			dataGridView = null;
		}

		private void dgvLPRG_DoubleClick(object sender, EventArgs e)
		{
			if (dgvLPRG.CurrentRow.Index >= 0)
			{
				ShowGridData();
			}
		}

		private void txtPRGID_Leave(object sender, EventArgs e)
		{
			if (txtPRGID.Modified)
			{
				txtPRGID.Modified = false;
				string strSQL = "LPRG_PRGID = '" + txtPRGID.Text + "'";
				txtDESC.Text = Conversions.ToString(DB.GetColumnValue("LPRG_DESC", "LPRG_TBL", strSQL));
			}
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			ClearFormData();
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM LPRG_TBL ";
			strSQL = strSQL + "WHERE LPRG_PRGID = '" + txtPRGID.Text.Trim() + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show("Record not exists!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPRGID.Focus();
			}
			else if (!DeleteRecord())
			{
				MessageBox.Show("Record not deleted!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtPRGID.Focus();
			}
			else
			{
				MessageBox.Show("Record deleted!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefreshGrid();
				ClearFormData();
			}
		}
	}
}
