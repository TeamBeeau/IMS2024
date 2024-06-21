using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmLM1BAK : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRestore")]
		private Button _btnRestore;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBackup")]
		private Button _btnBackup;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdRestore")]
		private Button _cmdRestore;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdBackup")]
		private Button _cmdBackup;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("SaveFileDialog1")]
		private SaveFileDialog _SaveFileDialog1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtRestoreAs")]
		internal virtual TextBox txtRestoreAs
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnRestore
		{
			[CompilerGenerated]
			get
			{
				return _btnRestore;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRestore_Click;
				Button button = _btnRestore;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRestore = value;
				button = _btnRestore;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnBackup
		{
			[CompilerGenerated]
			get
			{
				return _btnBackup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnBackup_Click;
				Button button = _btnBackup;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnBackup = value;
				button = _btnBackup;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdRestore
		{
			[CompilerGenerated]
			get
			{
				return _cmdRestore;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdRestore_Click;
				Button button = _cmdRestore;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdRestore = value;
				button = _cmdRestore;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdBackup
		{
			[CompilerGenerated]
			get
			{
				return _cmdBackup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdBackup_Click;
				Button button = _cmdBackup;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdBackup = value;
				button = _cmdBackup;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtRestore")]
		internal virtual TextBox txtRestore
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtBackup")]
		internal virtual TextBox txtBackup
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

		internal virtual OpenFileDialog OpenFileDialog1
		{
			[CompilerGenerated]
			get
			{
				return _OpenFileDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = OpenFileDialog1_FileOk;
				OpenFileDialog openFileDialog = _OpenFileDialog1;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk -= value2;
				}
				_OpenFileDialog1 = value;
				openFileDialog = _OpenFileDialog1;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk += value2;
				}
			}
		}

		internal virtual SaveFileDialog SaveFileDialog1
		{
			[CompilerGenerated]
			get
			{
				return _SaveFileDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = SaveFileDialog1_FileOk;
				SaveFileDialog saveFileDialog = _SaveFileDialog1;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk -= value2;
				}
				_SaveFileDialog1 = value;
				saveFileDialog = _SaveFileDialog1;
				if (saveFileDialog != null)
				{
					saveFileDialog.FileOk += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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

		public frmLM1BAK()
		{
			base.FormClosing += frmBackup_FormClosing;
			base.Load += frmBackup_Load;
			base.KeyDown += frmLM1BAK_KeyDown;
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.cmdBackup = new System.Windows.Forms.Button();
			this.txtRestoreAs = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnBackup = new System.Windows.Forms.Button();
			this.btnRestore = new System.Windows.Forms.Button();
			this.txtBackup = new System.Windows.Forms.TextBox();
			this.txtRestore = new System.Windows.Forms.TextBox();
			this.cmdRestore = new System.Windows.Forms.Button();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1370, 631);
			this.Panel1.TabIndex = 1;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.cmdBackup, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtRestoreAs, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.btnBackup, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnRestore, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtBackup, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtRestore, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.cmdRestore, 3, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(622, 200);
			this.TableLayoutPanel1.TabIndex = 26;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 1;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 2);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 143);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(126, 54);
			this.TableLayoutPanel3.TabIndex = 12;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(3, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 27;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.cmdBackup.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmdBackup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.cmdBackup.Location = new System.Drawing.Point(544, 3);
			this.cmdBackup.Name = "cmdBackup";
			this.cmdBackup.Size = new System.Drawing.Size(75, 30);
			this.cmdBackup.TabIndex = 2;
			this.cmdBackup.Text = "Backup";
			this.cmdBackup.UseVisualStyleBackColor = false;
			this.txtRestoreAs.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRestoreAs.BackColor = System.Drawing.SystemColors.Window;
			this.txtRestoreAs.Enabled = false;
			this.txtRestoreAs.Location = new System.Drawing.Point(105, 95);
			this.txtRestoreAs.Name = "txtRestoreAs";
			this.txtRestoreAs.Size = new System.Drawing.Size(402, 22);
			this.txtRestoreAs.TabIndex = 5;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 99);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(96, 13);
			this.Label6.TabIndex = 25;
			this.Label6.Text = "Restore As";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 11);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(96, 13);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Backup To";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 67);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 13);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "Restore From";
			this.btnBackup.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnBackup.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnBackup.Location = new System.Drawing.Point(513, 5);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(25, 25);
			this.btnBackup.TabIndex = 1;
			this.btnBackup.TabStop = false;
			this.btnBackup.Text = "...";
			this.btnBackup.UseVisualStyleBackColor = false;
			this.btnRestore.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnRestore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnRestore.Location = new System.Drawing.Point(513, 61);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(25, 25);
			this.btnRestore.TabIndex = 4;
			this.btnRestore.TabStop = false;
			this.btnRestore.Text = "...";
			this.btnRestore.UseVisualStyleBackColor = false;
			this.txtBackup.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtBackup.BackColor = System.Drawing.SystemColors.Window;
			this.txtBackup.Enabled = false;
			this.txtBackup.Location = new System.Drawing.Point(105, 7);
			this.txtBackup.Name = "txtBackup";
			this.txtBackup.Size = new System.Drawing.Size(402, 22);
			this.txtBackup.TabIndex = 0;
			this.txtRestore.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRestore.BackColor = System.Drawing.SystemColors.Window;
			this.txtRestore.Enabled = false;
			this.txtRestore.Location = new System.Drawing.Point(105, 63);
			this.txtRestore.Name = "txtRestore";
			this.txtRestore.Size = new System.Drawing.Size(402, 22);
			this.txtRestore.TabIndex = 3;
			this.cmdRestore.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cmdRestore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.cmdRestore.Location = new System.Drawing.Point(544, 59);
			this.cmdRestore.Name = "cmdRestore";
			this.cmdRestore.Size = new System.Drawing.Size(75, 30);
			this.cmdRestore.TabIndex = 6;
			this.cmdRestore.Text = "Restore";
			this.cmdRestore.UseVisualStyleBackColor = false;
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.SaveFileDialog1.OverwritePrompt = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmLM1BAK";
			this.Text = "Backup & Restore";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void frmBackup_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmBackup_Load(object sender, EventArgs e)
		{
			ClearFormData();
			cmdRestore.Enabled = Operators.CompareString(PublicVar.gstrLogonID, "ADMIN", false) == 0;
		}

		private void ClearFormData()
		{
			txtBackup.Text = "";
			txtRestore.Text = "";
			txtRestoreAs.Text = PublicVar.gstrDBName;
			txtBackup.Focus();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnBackup_Click(object sender, EventArgs e)
		{
			SaveFileDialog1.Title = "Backup";
			SaveFileDialog1.InitialDirectory = "C:\\";
			SaveFileDialog1.Filter = "Backup File|*.bak";
			SaveFileDialog1.ShowDialog();
		}

		private void btnRestore_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.Title = "Restore";
			OpenFileDialog1.InitialDirectory = "C:\\";
			OpenFileDialog1.Filter = "Backup File|*.bak";
			OpenFileDialog1.FileName = "";
			OpenFileDialog1.ShowDialog();
		}

		private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			txtBackup.Text = SaveFileDialog1.FileName;
		}

		private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			txtRestore.Text = OpenFileDialog1.FileName;
		}

		private void cmdBackup_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtBackup.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Invalid backup file!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (File.Exists(txtBackup.Text))
			{
				MessageBox.Show("Database backup file already exists!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Cursor.Current = Cursors.WaitCursor;
			if (BackupFullDB())
			{
				MessageBox.Show("Database backup successfully!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			Cursor.Current = Cursors.Default;
		}

		private bool BackupFullDB()
		{
			bool BackupFullDB;
			try
			{
				string strSQL = "BACKUP DATABASE " + PublicVar.gstrDBName + " TO DISK = '" + txtBackup.Text + "'";
				DB.DBExecute(strSQL);
				BackupFullDB = true;
			}
			catch (SqlException ex2)
			{
				ProjectData.SetProjectError(ex2);
				SqlException ex = ex2;
				MessageBox.Show(ex.Message, "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				BackupFullDB = false;
				ProjectData.ClearProjectError();
			}
			return BackupFullDB;
		}

		private void cmdRestore_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtRestore.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Invalid restore file!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (!File.Exists(txtRestore.Text))
			{
				MessageBox.Show("Database restore file not exists!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Operators.CompareString(txtRestoreAs.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("[Restore As] is empty!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			string strMSG = "Restore operation need to terminate all user connections and will be overwriting existing database.";
			strMSG += "\r\nConfirm to restore?";
			if (MessageBox.Show(strMSG, "IMS", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Cancel && KillAllDBConnections())
			{
				Cursor.Current = Cursors.WaitCursor;
				if (RestoreFullDB())
				{
					MessageBox.Show("Database restore successfully!\r\nApplication will be restarted.", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				Cursor.Current = Cursors.Default;
				Application.Exit();
			}
		}

		private bool RestoreFullDB()
		{
			OleDbConnection oleCon = new OleDbConnection();
			OleDbCommand cmd = new OleDbCommand();
			string s = "";
			bool RestoreFullDB;
			try
			{
				s = "Provider=SQLOLEDB.1;Persist Security Info=False;";
				s = s + "User ID=sa;Password=" + PublicVar.gstrPassword + ";";
				s = s + "Initial Catalog=master;Data Source=" + PublicVar.gstrServerName;
				oleCon.ConnectionString = s;
				oleCon.Open();
				string strSQL = "RESTORE DATABASE " + txtRestoreAs.Text + " FROM DISK = '" + txtRestore.Text + "' WITH REPLACE";
				cmd.Connection = oleCon;
				cmd.CommandText = strSQL;
				cmd.ExecuteNonQuery();
				RestoreFullDB = true;
			}
			catch (SqlException ex2)
			{
				ProjectData.SetProjectError(ex2);
				SqlException ex = ex2;
				MessageBox.Show(ex.Message, "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				RestoreFullDB = false;
				ProjectData.ClearProjectError();
			}
			return RestoreFullDB;
		}

		private bool KillAllDBConnections()
		{
			OleDbConnection oleCon = new OleDbConnection();
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			DataTable dt2 = new DataTable();
			string s = "";
			int iSPID = 0;
			checked
			{
				bool KillAllDBConnections;
				try
				{
					s = "Provider=SQLOLEDB.1;Persist Security Info=False;";
					s = s + "User ID=sa;Password=" + PublicVar.gstrPassword + ";";
					s = s + "Initial Catalog=master;Data Source=" + PublicVar.gstrServerName;
					oleCon.ConnectionString = s;
					oleCon.Open();
					cmd.Connection = oleCon;
					cmd.CommandText = "SELECT SPID FROM MASTER..SYSPROCESSES WHERE DBID = DB_ID('" + PublicVar.gstrDBName + "')";
					adp.SelectCommand = cmd;
					adp.Fill(dt);
					if (dt.Rows.Count > 0)
					{
						int num = dt.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							iSPID = Conversions.ToInteger(dt.Rows[i]["SPID"]);
							cmd.CommandText = "KILL " + iSPID;
							cmd.ExecuteNonQuery();
						}
					}
					cmd.CommandText = "SELECT SPID FROM MASTER..SYSPROCESSES WHERE DBID = DB_ID('" + PublicVar.gstrDBName + "')";
					adp.SelectCommand = cmd;
					adp.Fill(dt2);
					if (dt2.Rows.Count > 0)
					{
						MessageBox.Show("Unable to enter Single User Mode!", "IMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						KillAllDBConnections = false;
					}
					else
					{
						KillAllDBConnections = true;
					}
				}
				catch (SqlException ex2)
				{
					ProjectData.SetProjectError(ex2);
					SqlException ex = ex2;
					string left = ex.ToString();
					if (Operators.CompareString(left, "-2147215398", false) == 0)
					{
						KillAllDBConnections = true;
						ProjectData.ClearProjectError();
					}
					else
					{
						if (iSPID != 0)
						{
							MessageBox.Show("Unable to kill this connection " + Conversions.ToString(iSPID), "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						else
						{
							MessageBox.Show(ex.Message, "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
						KillAllDBConnections = false;
						ProjectData.ClearProjectError();
					}
				}
				finally
				{
					dt = null;
				}
				return KillAllDBConnections;
			}
		}

		private void frmLM1BAK_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
