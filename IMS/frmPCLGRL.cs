using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IBS.Barcode;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class frmPCLGRL : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		private OleDbCommand cmd;

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

		internal virtual Button btnPRINT
		{
			[CompilerGenerated]
			get
			{
				return _btnPRINT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPRINT_Click;
				Button button = _btnPRINT;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPRINT = value;
				button = _btnPRINT;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		[field: AccessedThroughProperty("cbDOCNOFR")]
		internal virtual ComboboxControl cbDOCNOFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbDOCNOTO")]
		internal virtual ComboboxControl cbDOCNOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCLGRL()
		{
			base.Shown += frmPCLGRL_Shown;
			base.FormClosing += frmPCLGRL_FormClosing;
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
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 4;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(802, 108);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(470, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(325, 26);
			this.cbDOCNOTO.TabIndex = 60;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(101, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(326, 26);
			this.cbDOCNOFR.TabIndex = 50;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 52);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel3.TabIndex = 19;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(129, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(3, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 9;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(435, 7);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(25, 16);
			this.Label7.TabIndex = 59;
			this.Label7.Text = "To";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 7);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(90, 16);
			this.Label1.TabIndex = 58;
			this.Label1.Text = "Document No";
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1560, 672);
			this.Panel1.TabIndex = 20;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPCLGRL";
			base.Tag = "PCLGRL";
			this.Text = "Print Label - Serialised Item";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPCLGRL_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			Panel1.Visible = true;
			BindComboBox();
		}

		private void BindComboBox()
		{
			cbDOCNOFR.DataTable = "PCGRN_TBL WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "PCGRN_DOCNO";
			cbDOCNOFR.DisplayMember = "PCGRN_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "PCGRN_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "PCGRN_DOCNO";
			cbDOCNOTO.DisplayMember = "PCGRN_DOCNO";
			cbDOCNOTO.LoadData();
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			GenerateQRCode();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "Print Label - Serialised Item";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPCLGRN.rpt";
			frmRPT.Params = ("@PRNID=" + MyProject.Computer.Name) ?? "";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany) + "',RPTTITLE='Print Label - Serialised Item',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ComputerName = MyProject.Computer.Name;
			frmRPT.ViewReportbyComputerName();
		}

		private void GenerateQRCode()
		{
			string strSQL = "EXEC spPCLGRN_QR1 ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "'")));
			try
			{
				this.cmd.Connection = DB.GetDBConnection();
				this.cmd.CommandText = strSQL;
				int iRowsAffected = this.cmd.ExecuteNonQuery();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex3 = ex4;
				MessageBox.Show(ex3.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			DataTable dt = DB.ExecProc("SELECT PCGRN_RECID, PCGRN_GRLNO FROM PCGRN_WRK WHERE PCGRN_PRNID = '" + MyProject.Computer.Name + "'");
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					QRCodeGenerator qrcode = new QRCodeGenerator();
					string strRECID = dt.Rows[i]["PCGRN_RECID"].ToString();
					string strGRLNO = dt.Rows[i]["PCGRN_GRLNO"].ToString();
					byte[] imgQRCODE = Common.ImageToByte2(qrcode.CreateQrCode(Conversions.ToString(dt.Rows[i]["PCGRN_GRLNO"]), QRCodeGenerator.ECCLevel.L).GetGraphic(2));
					try
					{
						OleDbCommand cmd = new OleDbCommand();
						cmd.Connection = DB.GetDBConnection();
						strSQL = "spPCLGRN_QR2";
						cmd.CommandText = strSQL;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.Add("@PRNID", OleDbType.VarChar, 30).Value = MyProject.Computer.Name;
						cmd.Parameters.Add("@RECID", OleDbType.VarChar, 30).Value = strRECID;
						cmd.Parameters.Add("@GRLNO", OleDbType.VarChar, 30).Value = strGRLNO;
						cmd.Parameters.Add("@IMAGE", OleDbType.VarBinary, -1).Value = imgQRCODE;
						int iRowsAffected = cmd.ExecuteNonQuery();
					}
					catch (OleDbException ex5)
					{
						ProjectData.SetProjectError(ex5);
						OleDbException ex2 = ex5;
						MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
					catch (Exception ex6)
					{
						ProjectData.SetProjectError(ex6);
						Exception ex = ex6;
						MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						ProjectData.ClearProjectError();
					}
					finally
					{
						OleDbCommand cmd = null;
					}
				}
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPCLGRL_FormClosing(object sender, FormClosingEventArgs e)
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
	}
}
