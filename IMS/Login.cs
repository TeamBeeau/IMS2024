using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CryptoLibrary;
using IMS.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class Login : Form
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdOK")]
		private Button _cmdOK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

		private IContainer components;

		private clsUsers mclsUsers;

		[field: AccessedThroughProperty("imgCompany")]
		internal virtual PictureBox imgCompany
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("UsernameLabel")]
		internal virtual Label UsernameLabel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PasswordLabel")]
		internal virtual Label PasswordLabel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtUsername")]
		internal virtual TextBox txtUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPassword")]
		internal virtual TextBox txtPassword
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button cmdOK
		{
			[CompilerGenerated]
			get
			{
				return _cmdOK;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdOK_Click;
				Button button = _cmdOK;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdOK = value;
				button = _cmdOK;
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

		[field: AccessedThroughProperty("TextBox1")]
		internal virtual TextBox TextBox1
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

		[field: AccessedThroughProperty("lblCompany")]
		internal virtual Label lblCompany
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

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblProductName")]
		internal virtual Label lblProductName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblProductVersion")]
		internal virtual Label lblProductVersion
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

		public Login()
		{
			base.Activated += Login_Activated;
			base.FormClosed += Login_FormClosed;
			base.Load += Login_Load;
			base.KeyDown += Form1_KeyDown;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMS.Login));
			this.UsernameLabel = new System.Windows.Forms.Label();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.lblCompany = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Label2 = new System.Windows.Forms.Label();
			this.imgCompany = new System.Windows.Forms.PictureBox();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdOK = new System.Windows.Forms.Button();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.lblProductVersion = new System.Windows.Forms.Label();
			this.lblProductName = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.imgCompany).BeginInit();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.UsernameLabel.Location = new System.Drawing.Point(192, 140);
			this.UsernameLabel.Name = "UsernameLabel";
			this.UsernameLabel.Size = new System.Drawing.Size(167, 23);
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "User Name";
			this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.PasswordLabel.Location = new System.Drawing.Point(192, 203);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(99, 23);
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "Password";
			this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtUsername.Location = new System.Drawing.Point(192, 166);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(206, 26);
			this.txtUsername.TabIndex = 1;
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtPassword.Location = new System.Drawing.Point(192, 229);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(206, 26);
			this.txtPassword.TabIndex = 3;
			this.txtPassword.UseSystemPasswordChar = true;
			this.lblCompany.BackColor = System.Drawing.Color.Transparent;
			this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCompany.ForeColor = System.Drawing.Color.Maroon;
			this.lblCompany.Location = new System.Drawing.Point(199, 2);
			this.lblCompany.Name = "lblCompany";
			this.lblCompany.Size = new System.Drawing.Size(380, 126);
			this.lblCompany.TabIndex = 6;
			this.lblCompany.Text = "Company Name && Address";
			this.TextBox1.BackColor = System.Drawing.Color.Silver;
			this.TextBox1.ForeColor = System.Drawing.Color.DarkGreen;
			this.TextBox1.Location = new System.Drawing.Point(0, 436);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new System.Drawing.Size(593, 34);
			this.TextBox1.TabIndex = 7;
			this.TextBox1.TabStop = false;
			this.TextBox1.Text = resources.GetString("TextBox1.Text");
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.Color.Brown;
			this.Label1.Location = new System.Drawing.Point(283, 203);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(179, 23);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "** case sensitive";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.imgCompany);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.lblCompany);
			this.Panel1.Controls.Add(this.txtUsername);
			this.Panel1.Controls.Add(this.cmdCancel);
			this.Panel1.Controls.Add(this.UsernameLabel);
			this.Panel1.Controls.Add(this.cmdOK);
			this.Panel1.Controls.Add(this.PasswordLabel);
			this.Panel1.Controls.Add(this.txtPassword);
			this.Panel1.Location = new System.Drawing.Point(0, 73);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(593, 363);
			this.Panel1.TabIndex = 9;
			this.Label2.BackColor = System.Drawing.Color.Maroon;
			this.Label2.Location = new System.Drawing.Point(2, 124);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(412, 1);
			this.Label2.TabIndex = 9;
			this.imgCompany.BackColor = System.Drawing.Color.Transparent;
			this.imgCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.imgCompany.Image = (System.Drawing.Image)resources.GetObject("imgCompany.Image");
			this.imgCompany.Location = new System.Drawing.Point(3, 2);
			this.imgCompany.Name = "imgCompany";
			this.imgCompany.Size = new System.Drawing.Size(186, 119);
			this.imgCompany.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgCompany.TabIndex = 0;
			this.imgCompany.TabStop = false;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdCancel.Location = new System.Drawing.Point(302, 268);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(80, 60);
			this.cmdCancel.TabIndex = 5;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdOK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdOK.Image = IMS.My.Resources.Resources.Login;
			this.cmdOK.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.cmdOK.Location = new System.Drawing.Point(205, 268);
			this.cmdOK.Name = "cmdOK";
			this.cmdOK.Size = new System.Drawing.Size(80, 60);
			this.cmdOK.TabIndex = 4;
			this.cmdOK.Text = "Login";
			this.cmdOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdOK.UseVisualStyleBackColor = false;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.lblProductVersion);
			this.Panel2.Controls.Add(this.lblProductName);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(593, 71);
			this.Panel2.TabIndex = 10;
			this.lblProductVersion.Font = new System.Drawing.Font("Sitka Small", 9.75f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.lblProductVersion.ForeColor = System.Drawing.Color.Maroon;
			this.lblProductVersion.Location = new System.Drawing.Point(485, 42);
			this.lblProductVersion.Name = "lblProductVersion";
			this.lblProductVersion.Size = new System.Drawing.Size(104, 23);
			this.lblProductVersion.TabIndex = 9;
			this.lblProductVersion.Text = "Version No.";
			this.lblProductVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblProductName.Font = new System.Drawing.Font("Sitka Small", 18f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
			this.lblProductName.ForeColor = System.Drawing.Color.Maroon;
			this.lblProductName.Location = new System.Drawing.Point(9, 11);
			this.lblProductName.Name = "lblProductName";
			this.lblProductName.Size = new System.Drawing.Size(367, 50);
			this.lblProductName.TabIndex = 1;
			this.lblProductName.Text = "Inovex Business Solutions";
			this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			base.CancelButton = this.cmdCancel;
			base.ClientSize = new System.Drawing.Size(594, 470);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.Panel2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.KeyPreview = true;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Login";
			base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.imgCompany).EndInit();
			this.Panel2.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void Login_Activated(object sender, EventArgs e)
		{
			txtUsername.Focus();
			txtUsername.SelectionStart = 0;
			txtUsername.SelectionLength = txtUsername.TextLength;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Login_FormClosed(object sender, FormClosedEventArgs e)
		{
			string strSQL = "DELETE LGUSR_TBL WHERE LGUSR_COMPTNM = '" + MyProject.Computer.Name + "'";
			DB.ExecProc(strSQL);
			Application.Exit();
			ProjectData.EndApp();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			lblProductName.Text = PublicVar.gstrSystemNm;
			lblProductVersion.Text = "ver. " + Application.ProductVersion;
			string strADDR1 = Conversions.ToString(DB.GetColumnValue("LMSYS_ADDR1", "LMSYS_TBL", ""));
			string strADDR2 = Conversions.ToString(DB.GetColumnValue("LMSYS_ADDR2", "LMSYS_TBL", ""));
			string strADDR3 = Conversions.ToString(DB.GetColumnValue("LMSYS_ADDR3", "LMSYS_TBL", ""));
			string strADDR4 = Conversions.ToString(DB.GetColumnValue("LMSYS_ADDR4", "LMSYS_TBL", ""));
			string strTEL = Conversions.ToString(DB.GetColumnValue("LMSYS_TEL01", "LMSYS_TBL", ""));
			string strEMAIL = Conversions.ToString(DB.GetColumnValue("LMSYS_EMAIL", "LMSYS_TBL", ""));
			string strTemp = PublicVar.gstrCompany;
			strTemp = strTemp + "\r\n" + strADDR1;
			strTemp = strTemp + "\r\n" + strADDR2;
			strTemp = strTemp + "\r\n" + strADDR3;
			strTemp = strTemp + "\r\n" + strADDR4;
			strTemp = strTemp + "\r\n" + strTEL;
			strTemp = strTemp + "\r\n" + strEMAIL;
			lblCompany.Text = strTemp;
			mclsUsers = new clsUsers();
			string strLogo = Application.StartupPath + "\\Media\\" + PublicVar.gstrCompany;
			if (MyProject.Computer.FileSystem.FileExists(strLogo))
			{
				imgCompany.ImageLocation = strLogo;
			}
			string strBackGround = Application.StartupPath + "\\Media\\BackGround";
			if (MyProject.Computer.FileSystem.FileExists(strBackGround))
			{
				try
				{
                    Panel1.BackgroundImage = Image.FromFile(strBackGround);
                }
				catch(Exception ex) { 
				}
			}
			string strSQL = "DELETE LGUSR_TBL WHERE LGUSR_COMPTNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "INSERT INTO LGUSR_TBL (LGUSR_COMPTNM, LGUSR_HDDNO, LGUSR_LUPDT) ";
			strSQL = strSQL + "VALUES ('" + MyProject.Computer.Name + "', '" + Common.GETHDDSerialNo() + "', GETDATE())";
			DB.ExecProc(strSQL);
			SetTxtMaxLen();
			txtPassword.Text = "";
			txtUsername.Focus();
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			string strSQL = "DELETE LGUSR_TBL WHERE LGUSR_COMPTNM = '" + MyProject.Computer.Name + "'";
			DB.ExecProc(strSQL);
			Close();
		}

		private void cmdOK_Click(object sender, EventArgs e)
		{
			DataTable dt;
			if (UserLogin())
			{
				if (G.quotation2 == null)
				{
					G.quotation2 = new Quotation2();

                }
                G.quotation2.GetData();
                Common.Disable_All_MenuItem((MDIParent)base.Owner);
				Common.Set_All_MenuItem((MDIParent)base.Owner);
				string strSQL = "LXCS_USRID = '" + PublicVar.gstrLogonID + "' ";
				strSQL += "AND LXCS_GRPCD = 'ADMIN'";
				dt = DB.GetTable("*", "LXCS_TBL", strSQL, "");
				PublicVar.gblnAdminGRP = dt.Rows.Count != 0;
				strSQL = "LUSR_USRID = '" + PublicVar.gstrLogonID + "' ";
				strSQL += "AND LUSR_SPVFG = 1";
				dt = DB.GetTable("*", "LUSR_TBL", strSQL, "");
				PublicVar.gblnSupervisor = dt.Rows.Count != 0;
				PublicVar.gintVIWBY = Conversions.ToInteger(DB.GetColumnValue("MACTL_VIWBY", "MACTL_TBL", ""));
				PublicVar.gintEDTBY = Conversions.ToInteger(DB.GetColumnValue("MACTL_EDTBY", "MACTL_TBL", ""));
				PublicVar.gstrWHSCD = Conversions.ToString(DB.GetColumnValue("MACTL_WHSCD", "MACTL_TBL", ""));
				PublicVar.gstrMDICaption = PublicVar.gstrSystemNm;
				base.Owner.Text = PublicVar.gstrMDICaption + "   [" + PublicVar.gstrServerName + " : " + PublicVar.gstrDBName + "]   [" + PublicVar.gstrCompany + " : " + PublicVar.gstrLogonID + "]";
				PublicVar.gblnSessionStart = true;
				Hide();
			}
			dt = null;
		}

		private bool CheckLICNO()
		{
			Crypto oCrypto = new Crypto();
			string strSQL = "EXEC spGETMAC";
			DataTable dt = DB.ExecProc(strSQL);
			string strMAC = Conversions.ToString(dt.Rows[0]["MACADDRESS"]);
			string strLICNO = Conversions.ToString(DB.GetColumnValue("LMSYS_LICNO", "LMSYS_TBL", ""));
			//if (Operators.CompareString(strLICNO, oCrypto.EncryptString128Bit(strMAC, ""), false) != 0)
			//{
			//	MessageBox.Show("Incorrect Software Key, please contact software vendor!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			//	return false;
			//}
			return true;
		}

		private void SetTxtMaxLen()
		{
			txtUsername.MaxLength = DB.CharColumnMaxLength("LUSR_TBL", "LUSR_USRID");
			txtPassword.MaxLength = 15;
		}
		//string strPASWDs;

        private bool UserLogin()
		{
			Crypto oCrypto = new Crypto();
			try
			{
              //  strPASWDs = oCrypto.DecryptString128Bit("c3Cr5o4hoxQHhF45JT2WXg==", ""); ;

                string strPASWD = oCrypto.EncryptString128Bit(txtPassword.Text.Trim(), ""); ;
				#if DEBUG
                txtUsername.Text = "ADMIN"; strPASWD = "c3Cr5o4hoxQHhF45JT2WXg==";
				#endif
				string strSQL = "SELECT * FROM LUSR_TBL ";
				strSQL = strSQL + "WHERE LUSR_USRID = '" + txtUsername.Text.Trim() + "' ";
				strSQL += "AND LUSR_SYSUSR = 1";
				if (!DB.RecordExists(strSQL))
				{
					MessageBox.Show("Invalid system user!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return false;
				}
			
                clsUsers clsUsers2 = mclsUsers;
				clsUsers2.USRID = txtUsername.Text.Trim();
				clsUsers2.PASWD = strPASWD;
				int intRet = default(int);
				string blnLogin = Conversions.ToString(clsUsers2.Login(ref intRet));
				clsUsers2 = null;
				switch (intRet)
				{
				case 1:
					MessageBox.Show("Invalid user ID!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtUsername.Focus();
					return false;
				case 2:
					MessageBox.Show("Invalid user password!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtPassword.Focus();
					return false;
				default:
					PublicVar.gstrLogonID = txtUsername.Text.ToUpper();
					PublicVar.gstrLanguage = Conversions.ToString(DB.GetColumnValue("LUSR_LGGID", "LUSR_TBL", "LUSR_USRID = '" + PublicVar.gstrLogonID + "'"));
					if (!CheckLICNO())
					{
						return false;
					}
						if (G.quotation2 == null) G.quotation2 = new Quotation2();
                            if (G.quotation2 != null)
						{
                            string strSQL2 = "EXEC spMAITM '0', ";
                            strSQL2 = strSQL2 + "'" + Common.gfValidSQLStr("0") + "', ";
                            strSQL2 = strSQL2 + "'" + Common.gfValidSQLStr("") + "', ";
                            strSQL2 = strSQL2 + "'" + Common.gfValidSQLStr("PACKING") + "', ";
                            strSQL2 = strSQL2 + "'" + Common.gfValidSQLStr("") + "', ";
                            strSQL2 = strSQL2 + "'" + Common.gfValidSQLStr("") + "', ";
                            strSQL2 = strSQL2 + "'" + Common.gfValidSQLStr("") + "', ";
                            strSQL2 = strSQL2 + "'" + Common.gfValidSQLStr("") + "', ";
                            strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2,"'zzzzz' "));
                            G.dtPacking = DB.ExecProc(strSQL2);

                            DataColumn cols = new DataColumn();
                            cols.DefaultValue = "0";
                            cols.ColumnName = "PackingCost";
                            G.dtPacking.Columns.AddRange(new DataColumn[] { cols });
                          
                            G.quotation2.RefreshCal();
						}
                       // if (File.Exists("PackingCost.conf"))
                       //  G.listPackingCost = Access.LoadPackingCost();
                        G.listColorCost = new List<ColorCost>();
                        DataTable dt = DB.GetTable("*", "CostSetup", "", "");
                        foreach (DataRow dr in dt.Rows)
                        {
                            G.listColorCost.Add(new ColorCost(dr["Category"].ToString(), Convert.ToDouble(dr["VariableCost"]), Convert.ToDouble(dr["FixedCost"]), Convert.ToDouble(dr["Transportation"]), Convert.ToDouble(dr["OtherCost"])));
                        }
                       
#if !DEBUG
						if (!Dongle.CheckForDongle())
							{
												return false;
						}
#endif
                        return true;
				}
			}
			finally
			{
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
