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
	public class frmLM1GRP : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtGRPCD")]
		private TextBox _txtGRPCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvLGRP")]
		private DataGridView _dgvLGRP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdClose")]
		private Button _cmdClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdDelete")]
		private Button _cmdDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

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

		internal virtual TextBox txtGRPCD
		{
			[CompilerGenerated]
			get
			{
				return _txtGRPCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtGRPCD_Leave;
				TextBox textBox = _txtGRPCD;
				if (textBox != null)
				{
					textBox.Leave -= value2;
				}
				_txtGRPCD = value;
				textBox = _txtGRPCD;
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

		internal virtual DataGridView dgvLGRP
		{
			[CompilerGenerated]
			get
			{
				return _dgvLGRP;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dgvLGRP_DoubleClick;
				DataGridView dataGridView = _dgvLGRP;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick -= value2;
				}
				_dgvLGRP = value;
				dataGridView = _dgvLGRP;
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

		public frmLM1GRP()
		{
			base.FormClosing += frmLM1GRP_FormClosing;
			base.Load += frmLM1GRP_Load;
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
			this.cmdDelete = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtGRPCD = new System.Windows.Forms.TextBox();
			this.dgvLGRP = new System.Windows.Forms.DataGridView();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtDESC = new System.Windows.Forms.TextBox();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvLGRP).BeginInit();
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
			this.Panel1.AutoScroll = true;
			this.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1350, 709);
			this.Panel1.TabIndex = 7;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtGRPCD, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.dgvLGRP, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtDESC, 1, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 5;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1077, 578);
			this.TableLayoutPanel1.TabIndex = 32;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 2);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cmdClose, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdSave, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdCancel, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdDelete, 1, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 508);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(515, 60);
			this.TableLayoutPanel2.TabIndex = 33;
			this.txtGRPCD.Location = new System.Drawing.Point(132, 429);
			this.txtGRPCD.Margin = new System.Windows.Forms.Padding(4);
			this.txtGRPCD.Name = "txtGRPCD";
			this.txtGRPCD.Size = new System.Drawing.Size(172, 22);
			this.txtGRPCD.TabIndex = 1;
			this.dgvLGRP.AllowUserToAddRows = false;
			this.dgvLGRP.AllowUserToDeleteRows = false;
			this.dgvLGRP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvLGRP.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLGRP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvLGRP.ColumnHeadersHeight = 25;
			this.dgvLGRP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvLGRP, 2);
			this.dgvLGRP.Location = new System.Drawing.Point(4, 4);
			this.dgvLGRP.Margin = new System.Windows.Forms.Padding(4);
			this.dgvLGRP.MultiSelect = false;
			this.dgvLGRP.Name = "dgvLGRP";
			this.dgvLGRP.ReadOnly = true;
			this.dgvLGRP.RowHeadersWidth = 20;
			this.dgvLGRP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvLGRP.RowsDefaultCellStyle = DataGridViewCellStyle2;
			this.dgvLGRP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLGRP.Size = new System.Drawing.Size(1040, 417);
			this.dgvLGRP.TabIndex = 0;
			this.dgvLGRP.TabStop = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(4, 460);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(120, 20);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Description";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(4, 430);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(120, 20);
			this.Label7.TabIndex = 31;
			this.Label7.Text = "Group Code";
			this.txtDESC.Location = new System.Drawing.Point(132, 459);
			this.txtDESC.Margin = new System.Windows.Forms.Padding(4);
			this.txtDESC.Name = "txtDESC";
			this.txtDESC.Size = new System.Drawing.Size(512, 22);
			this.txtDESC.TabIndex = 2;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1350, 709);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmLM1GRP";
			this.Text = "User Group Maintenance";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvLGRP).EndInit();
			base.ResumeLayout(false);
		}

		private void frmLM1GRP_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmLM1GRP_Load(object sender, EventArgs e)
		{
			SetMaxLength();
			RefreshGrid();
			ClearFormData();
		}

		private void SetMaxLength()
		{
			txtGRPCD.MaxLength = DB.CharColumnMaxLength("LGRP_TBL", "LGRP_GRPCD");
			txtDESC.MaxLength = DB.CharColumnMaxLength("LGRP_TBL", "LGRP_DESC");
		}

		private void RefreshGrid()
		{
			DataTable dt = new DataTable();
			string strSQL = "LGRP_DESC, LGRP_GRPCD";
			dt = DB.GetTable(strSQL, "LGRP_TBL", "", "LGRP_DESC");
			DataGridView dataGridView = dgvLGRP;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 200;
			dataGridView.Columns[0].HeaderText = "Description";
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 80;
			dataGridView.Columns[1].HeaderText = "Group Code";
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void ClearFormData()
		{
			txtGRPCD.Text = "";
			txtGRPCD.Modified = false;
			txtDESC.Text = "";
			txtDESC.Modified = false;
			txtGRPCD.Focus();
		}

		private bool DeleteRecord()
		{
			bool DeleteRecord;
			try
			{
				string strSQL = "DELETE LGRP_TBL ";
				strSQL = strSQL + "WHERE LGRP_GRPCD = '" + txtGRPCD.Text.Trim() + "'";
				if (!DB.DBExecute(strSQL))
				{
					DeleteRecord = false;
				}
				else
				{
					strSQL = "DELETE LXCS_TBL ";
					strSQL = strSQL + "WHERE LXCS_GRPCD = '" + txtGRPCD.Text.Trim() + "'";
					if (!DB.DBExecute(strSQL))
					{
						DeleteRecord = false;
					}
					else
					{
						strSQL = "DELETE LPGP_TBL ";
						strSQL = strSQL + "WHERE LPGP_GRPCD = '" + txtGRPCD.Text.Trim() + "'";
						DeleteRecord = (DB.DBExecute(strSQL) ? true : false);
					}
				}
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
			if (Operators.CompareString(txtGRPCD.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Blank Group Code!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtGRPCD.Focus();
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
				string strSQL = "SELECT * FROM LGRP_TBL ";
				strSQL = strSQL + "WHERE LGRP_GRPCD = '" + txtGRPCD.Text.Trim() + "'";
				if (!DB.RecordExists(strSQL))
				{
					strSQL = "INSERT LGRP_TBL(";
					strSQL += "LGRP_GRPCD, LGRP_DESC, LGRP_LUPDT) ";
					strSQL += "VALUES (";
					strSQL = strSQL + "'" + txtGRPCD.Text.Trim() + "', '" + txtDESC.Text.Trim() + "', '" + DateAndTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "')";
				}
				else
				{
					strSQL = "UPDATE LGRP_TBL SET ";
					strSQL = strSQL + "LGRP_GRPCD = '" + txtGRPCD.Text.Trim() + "', ";
					strSQL = strSQL + "LGRP_DESC = '" + txtDESC.Text.Trim() + "', ";
					strSQL = strSQL + "LGRP_LUPDT = '" + DateAndTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "' ";
					strSQL = strSQL + "WHERE LGRP_GRPCD = '" + txtGRPCD.Text.Trim() + "'";
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
			DataGridView dataGridView = dgvLGRP;
			txtGRPCD.Text = Conversions.ToString(dataGridView[1, dataGridView.CurrentCell.RowIndex].Value);
			txtDESC.Text = Conversions.ToString(dataGridView[0, dataGridView.CurrentCell.RowIndex].Value);
			dataGridView = null;
		}

		private void dgvLGRP_DoubleClick(object sender, EventArgs e)
		{
			if (dgvLGRP.CurrentRow.Index >= 0)
			{
				ShowGridData();
			}
		}

		private void txtGRPCD_Leave(object sender, EventArgs e)
		{
			if (txtGRPCD.Modified)
			{
				txtGRPCD.Modified = false;
				string strSQL = "LGRP_GRPCD = '" + txtGRPCD.Text.Trim() + "'";
				txtDESC.Text = Conversions.ToString(DB.GetColumnValue("LGRP_DESC", "LGRP_TBL", strSQL));
			}
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			ClearFormData();
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM LGRP_TBL ";
			strSQL = strSQL + "WHERE LGRP_GRPCD = '" + txtGRPCD.Text.Trim() + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show("Invalid group code entered!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtGRPCD.Focus();
			}
			else if (!DeleteRecord())
			{
				MessageBox.Show("Record not deleted!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtGRPCD.Focus();
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
