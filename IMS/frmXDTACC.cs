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
	public class frmXDTACC : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCONFIRM")]
		private Button _btnCONFIRM;

		private string strProvider;

		private string strUserID;

		private string strPassword;

		private string strDBName;

		private string strServerName;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpDOCDTTO")]
		internal virtual DateTimePicker dtpDOCDTTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpDOCDTFR")]
		internal virtual DateTimePicker dtpDOCDTFR
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnCONFIRM
		{
			[CompilerGenerated]
			get
			{
				return _btnCONFIRM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCONFIRM_Click;
				Button button = _btnCONFIRM;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCONFIRM = value;
				button = _btnCONFIRM;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public frmXDTACC()
		{
			base.Load += XDTACC_Load;
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
			this.btnCONFIRM = new System.Windows.Forms.Button();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(1, 1);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1337, 618);
			this.Panel1.TabIndex = 0;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.btnCONFIRM, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDTTO, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDTFR, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(11, 11);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 2;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(364, 80);
			this.TableLayoutPanel1.TabIndex = 51;
			this.btnCONFIRM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCONFIRM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel1.SetColumnSpan(this.btnCONFIRM, 2);
			this.btnCONFIRM.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCONFIRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCONFIRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCONFIRM.Image = IMS.My.Resources.Resources.Confirm;
			this.btnCONFIRM.Location = new System.Drawing.Point(3, 28);
			this.btnCONFIRM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCONFIRM.Name = "btnCONFIRM";
			this.btnCONFIRM.Size = new System.Drawing.Size(128, 50);
			this.btnCONFIRM.TabIndex = 52;
			this.btnCONFIRM.Text = "Confirm";
			this.btnCONFIRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCONFIRM.UseVisualStyleBackColor = false;
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(251, 2);
			this.dtpDOCDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDTTO.TabIndex = 55;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(110, 2);
			this.dtpDOCDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDTFR.TabIndex = 53;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(220, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 54;
			this.Label1.Text = "To";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 5);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 52;
			this.Label3.Text = "Document Date";
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "XDTACC";
			this.Text = "Account Interface";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void XDTACC_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Now.AddMonths(-1);
			dtpDOCDTTO.Value = DateAndTime.Now;
		}

		private void btnCONFIRM_Click(object sender, EventArgs e)
		{
			if (LoadPCGRN() && LoadINTRN() && LoadSSSHP() && GetACCConnection() && TransferData())
			{
			}
		}

		private bool TransferData()
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spXDTACC ";
			strSQL = strSQL + "'" + strServerName + "', ";
			strSQL = strSQL + "'" + strDBName + "' ";
			bool TransferData;
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				TransferData = false;
				ProjectData.ClearProjectError();
				goto IL_00a2;
			}
			MessageBox.Show("Transfer Successful!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			TransferData = true;
			goto IL_00a2;
			IL_00a2:
			return TransferData;
		}

		private bool LoadSSSHP()
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spINT_SSSHP ";
			strSQL += "'0', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "' ";
			bool LoadSSSHP;
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				LoadSSSHP = false;
				ProjectData.ClearProjectError();
				goto IL_00af;
			}
			LoadSSSHP = true;
			goto IL_00af;
			IL_00af:
			return LoadSSSHP;
		}

		private bool LoadPCGRN()
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spINT_PCGRN ";
			strSQL += "'0', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "' ";
			bool LoadPCGRN;
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				LoadPCGRN = false;
				ProjectData.ClearProjectError();
				goto IL_00af;
			}
			LoadPCGRN = true;
			goto IL_00af;
			IL_00af:
			return LoadPCGRN;
		}

		private bool LoadINTRN()
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spINT_INTRN ";
			strSQL += "'0', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "' ";
			bool LoadINTRN;
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				LoadINTRN = false;
				ProjectData.ClearProjectError();
				goto IL_00af;
			}
			LoadINTRN = true;
			goto IL_00af;
			IL_00af:
			return LoadINTRN;
		}

		private bool GetACCConnection()
		{
			OleDbConnection oleDMSACC = new OleDbConnection();
			bool GetACCConnection;
			try
			{
				if (oleDMSACC.State != ConnectionState.Open)
				{
					string s = GetACCConnectionString();
					oleDMSACC.ConnectionString = s;
					oleDMSACC.Open();
				}
				GetACCConnection = true;
			}
			catch (OleDbException ex2)
			{
				ProjectData.SetProjectError(ex2);
				OleDbException ex = ex2;
				switch (ex.ErrorCode)
				{
				case -2147217843:
					MessageBox.Show("System failed to login! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					break;
				case -2147467259:
					MessageBox.Show("System can not locate database! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					break;
				default:
					MessageBox.Show("System message: " + Conversions.ToString(ex.ErrorCode) + "-" + ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					break;
				}
				oleDMSACC = null;
				GetACCConnection = false;
				ProjectData.ClearProjectError();
			}
			return GetACCConnection;
		}

		private string GetACCConnectionString()
		{
			string s = "";
			string GetACCConnectionString;
			try
			{
				strProvider = "SQLOLEDB.1";
				strUserID = Conversions.ToString(DB.GetColumnValue("MACTL_USERID", "MACTL_TBL", ""));
				strPassword = Conversions.ToString(DB.GetColumnValue("MACTL_PASSWD", "MACTL_TBL", ""));
				strDBName = Conversions.ToString(DB.GetColumnValue("MACTL_DBNM", "MACTL_TBL", ""));
				strServerName = Conversions.ToString(DB.GetColumnValue("MACTL_SERVER", "MACTL_TBL", ""));
				s = "Provider=" + strProvider + ";";
				s += "Persist Security Info=False;";
				s = s + "User ID=" + strUserID + ";";
				s = s + "Password=" + strPassword + ";";
				s = s + "Initial Catalog=" + strDBName + ";";
				s = s + "Data Source=" + strServerName;
				GetACCConnectionString = s;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message + "\r\nDatabase connection info. not properly setup! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GetACCConnectionString = null;
				ProjectData.ClearProjectError();
			}
			return GetACCConnectionString;
		}
	}
}
