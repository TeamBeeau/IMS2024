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
	public class frmMAEMSG : Form
	{
		private IContainer components;

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
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDetail")]
		private DataGridView _dgvDetail;

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

		[field: AccessedThroughProperty("lblCODNM")]
		internal virtual Label lblCODNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtMSG")]
		internal virtual TextBox txtMSG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("MACTY_TBLComboBox")]
		internal virtual ComboBox MACTY_TBLComboBox
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

		internal virtual DataGridView dgvDetail
		{
			[CompilerGenerated]
			get
			{
				return _dgvDetail;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDetail_CellMouseClick;
				DataGridView dataGridView = _dgvDetail;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvDetail = value;
				dataGridView = _dgvDetail;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtRECID")]
		internal virtual TextBox txtRECID
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

		public frmMAEMSG()
		{
			base.FormClosing += frmMAEMSG_FormClosing;
			base.Shown += frmMAEMSG_Shown;
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblCODNM = new System.Windows.Forms.Label();
			this.dgvDetail = new System.Windows.Forms.DataGridView();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.txtMSG = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetail).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblCODNM, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.dgvDetail, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtRECID, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtMSG, 1, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(14, 8);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 3;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1095, 524);
			this.TableLayoutPanel1.TabIndex = 0;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 2);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 469);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(512, 52);
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
			this.btnSave.Size = new System.Drawing.Size(120, 48);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(260, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 48);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(388, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 48);
			this.btnClose.TabIndex = 12;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(132, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 48);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.lblCODNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCODNM.AutoSize = true;
			this.lblCODNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCODNM.Location = new System.Drawing.Point(4, 393);
			this.lblCODNM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCODNM.Name = "lblCODNM";
			this.lblCODNM.Size = new System.Drawing.Size(65, 17);
			this.lblCODNM.TabIndex = 8;
			this.lblCODNM.Text = "Message";
			this.dgvDetail.AllowUserToAddRows = false;
			this.dgvDetail.AllowUserToDeleteRows = false;
			this.dgvDetail.AllowUserToResizeRows = false;
			this.dgvDetail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvDetail.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDetail, 3);
			this.dgvDetail.EnableHeadersVisualStyles = false;
			this.dgvDetail.Location = new System.Drawing.Point(4, 2);
			this.dgvDetail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvDetail.MultiSelect = false;
			this.dgvDetail.Name = "dgvDetail";
			this.dgvDetail.ReadOnly = true;
			this.dgvDetail.RowHeadersVisible = false;
			this.dgvDetail.RowTemplate.Height = 24;
			this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetail.Size = new System.Drawing.Size(1087, 334);
			this.dgvDetail.TabIndex = 39;
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(764, 390);
			this.txtRECID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(48, 23);
			this.txtRECID.TabIndex = 45;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.Visible = false;
			this.txtMSG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtMSG.Location = new System.Drawing.Point(77, 340);
			this.txtMSG.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtMSG.Multiline = true;
			this.txtMSG.Name = "txtMSG";
			this.txtMSG.Size = new System.Drawing.Size(680, 124);
			this.txtMSG.TabIndex = 3;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1360, 720);
			this.Panel1.TabIndex = 1;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 17f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1584, 791);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			base.Name = "frmMAEMSG";
			base.Tag = "MAELGG";
			this.Text = "Language Setup";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetail).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			spMAEMSG("0");
		}

		private void frmMAEMSG_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAEMSG_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			RefreshGrid();
			ClearFormData();
		}

		private void ClearFormData()
		{
			txtRECID.Text = "-1";
			txtMSG.Text = string.Empty;
		}

		private bool spMAEMSG(string strPRO)
		{
			Cursor = Cursors.WaitCursor;
			string strSQL;
			if (Operators.CompareString(strPRO, "0", false) == 0)
			{
				if (Operators.CompareString(txtRECID.Text, "-1", false) == 0)
				{
					strSQL = "INSERT INTO MAMSG_TBL (MAMSG_USRID, MAMSG_USRNM, MAMSG_MSG, MAMSG_LUPDT) ";
					strSQL = strSQL + "SELECT LUSR_USRID, LUSR_USRNM, N'" + Common.gfValidSQLStr(txtMSG.Text) + "', GETDATE() FROM LUSR_TBL WHERE LUSR_USRID = '" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "'";
				}
				else
				{
					strSQL = "UPDATE MAMSG_TBL SET MAMSG_MSG = N'" + Common.gfValidSQLStr(txtMSG.Text) + "' WHERE MAMSG_RECID = " + Common.gfValidSQLStr(txtRECID.Text);
				}
			}
			else
			{
				strSQL = "DELETE MAMSG_TBL WHERE MAMSG_RECID = " + Common.gfValidSQLStr(txtRECID.Text);
			}
			bool spMAEMSG;
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
				Cursor = Cursors.Default;
				spMAEMSG = false;
				ProjectData.ClearProjectError();
				goto IL_01b0;
			}
			Cursor = Cursors.Default;
			RefreshGrid();
			ClearFormData();
			spMAEMSG = true;
			goto IL_01b0;
			IL_01b0:
			return spMAEMSG;
		}

		private void RefreshGrid()
		{
			dgvDetail.DataSource = null;
			try
			{
				string strSQL = "SELECT MAMSG_RECID, MAMSG_MSG FROM MAMSG_TBL WITH (NOLOCK) ";
				strSQL = strSQL + "WHERE MAMSG_USRID = '" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "'";
				DataTable dt = DB.ExecProc(strSQL);
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvDetail;
					dataGridView.DataSource = dt;
					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[0].Width = 80;
					dataGridView.Columns[0].HeaderText = "RECID";
					dataGridView.Columns[0].ReadOnly = true;
					dataGridView.Columns[1].Visible = true;
					dataGridView.Columns[1].Width = 300;
					dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Message");
					dataGridView.Columns[1].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.Refresh();
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
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult OKDIALOG = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (OKDIALOG == DialogResult.OK)
			{
				spMAEMSG("1");
			}
		}

		private void BindGridtoControl()
		{
			txtRECID.Text = dgvDetail.CurrentRow.Cells["MAMSG_RECID"].Value.ToString();
			txtMSG.Text = dgvDetail.CurrentRow.Cells["MAMSG_MSG"].Value.ToString();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgvDetail_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearFormData();
		}
	}
}
