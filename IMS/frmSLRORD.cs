using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmSLRORD : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkMDLCD")]
		private CheckBox _chkMDLCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkCUSID")]
		private CheckBox _chkCUSID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCLOSE")]
		private Button _btnCLOSE;

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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
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

		internal virtual CheckBox chkMDLCD
		{
			[CompilerGenerated]
			get
			{
				return _chkMDLCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = chkMDLCD_CheckedChanged;
				CheckBox checkBox = _chkMDLCD;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_chkMDLCD = value;
				checkBox = _chkMDLCD;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox chkCUSID
		{
			[CompilerGenerated]
			get
			{
				return _chkCUSID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = chkCUSID_CheckedChanged;
				CheckBox checkBox = _chkCUSID;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_chkCUSID = value;
				checkBox = _chkCUSID;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("dtpGRCDTFR")]
		internal virtual DateTimePicker dtpGRCDTFR
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

		[field: AccessedThroughProperty("cbCATCD")]
		internal virtual ComboBox cbCATCD
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

		internal virtual Button btnCLOSE
		{
			[CompilerGenerated]
			get
			{
				return _btnCLOSE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCLOSE_Click;
				Button button = _btnCLOSE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCLOSE = value;
				button = _btnCLOSE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbGRPCD")]
		internal virtual ComboBox cbGRPCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmSLRORD()
		{
			base.FormClosing += frmSLRORD_FormClosing;
			base.Load += frmSLRORD_Load;
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
        Label lbBrand = new Label();
        ComboBox cbBrand = new ComboBox();
        [System.Diagnostics.DebuggerStepThrough]
		
		private void InitializeComponent()
		{
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.dtpGRCDTFR = new System.Windows.Forms.DateTimePicker();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.chkCUSID = new System.Windows.Forms.CheckBox();
			this.chkMDLCD = new System.Windows.Forms.CheckBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbCATCD = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbGRPCD = new System.Windows.Forms.ComboBox();
			this.btnCLOSE = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(2, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1345, 625);
			this.Panel1.TabIndex = 0;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpGRCDTFR, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 1,5);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
        
            this.TableLayoutPanel1.Controls.Add(this.cbCATCD, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.lbBrand, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.cbBrand, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbGRPCD, 1, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(796, 250);
			this.TableLayoutPanel1.TabIndex = 1;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 35);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(64, 16);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "Group By";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 6);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(48, 16);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "Period";
			this.dtpGRCDTFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpGRCDTFR.CustomFormat = "MMM/yyyy";
			this.dtpGRCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpGRCDTFR.Location = new System.Drawing.Point(100, 3);
			this.dtpGRCDTFR.Name = "dtpGRCDTFR";
			this.dtpGRCDTFR.Size = new System.Drawing.Size(120, 22);
			this.dtpGRCDTFR.TabIndex = 65;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.chkCUSID, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.chkMDLCD, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(100, 31);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25f));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(200, 25);
			this.TableLayoutPanel3.TabIndex = 2;
			this.chkCUSID.AutoSize = true;
			this.chkCUSID.Checked = true;
			this.chkCUSID.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCUSID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCUSID.Location = new System.Drawing.Point(3, 3);
			this.chkCUSID.Name = "chkCUSID";
			this.chkCUSID.Size = new System.Drawing.Size(84, 20);
			this.chkCUSID.TabIndex = 0;
			this.chkCUSID.Text = "Customer";
			this.chkCUSID.UseVisualStyleBackColor = true;
			this.chkMDLCD.AutoSize = true;
			this.chkMDLCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkMDLCD.Location = new System.Drawing.Point(93, 3);
			this.chkMDLCD.Name = "chkMDLCD";
			this.chkMDLCD.Size = new System.Drawing.Size(65, 20);
			this.chkMDLCD.TabIndex = 1;
			this.chkMDLCD.Text = "Model";
			this.chkMDLCD.UseVisualStyleBackColor = true;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 96);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 16);
			this.Label1.TabIndex = 67;
			this.Label1.Text = "Item Category";
			lbBrand.Text = "Brand";
            this.cbBrand.Location = new System.Drawing.Point(100, 62);
            this.cbBrand.Size = new System.Drawing.Size(133, 24);
            this.cbCATCD.FormattingEnabled = true;
			this.cbCATCD.Location = new System.Drawing.Point(100, 92);
			this.cbCATCD.Name = "cbCATCD";
			this.cbCATCD.Size = new System.Drawing.Size(133, 24);
			this.cbCATCD.TabIndex = 68;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 66);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(73, 16);
			this.Label2.TabIndex = 69;
			this.Label2.Text = "Item Group";
			this.cbGRPCD.FormattingEnabled = true;
			this.cbGRPCD.Location = new System.Drawing.Point(100, 62);
			this.cbGRPCD.Name = "cbGRPCD";
			this.cbGRPCD.Size = new System.Drawing.Size(133, 24);
			this.cbGRPCD.TabIndex = 70;
			this.btnCLOSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCLOSE.Image = IMS.My.Resources.Resources.Close;
			this.btnCLOSE.Location = new System.Drawing.Point(129, 3);
			this.btnCLOSE.Name = "btnCLOSE";
			this.btnCLOSE.Size = new System.Drawing.Size(120, 50);
			this.btnCLOSE.TabIndex = 25;
			this.btnCLOSE.Text = "Close";
			this.btnCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCLOSE.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(3, 3);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 22;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.ColumnCount = 2;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.btnPRINT, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.btnCLOSE, 1, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(100, 122);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(255, 58);
			this.TableLayoutPanel2.TabIndex = 1;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmSLRORD";
			base.Tag = "SLRORD";
			this.Text = "Sales Report";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			base.ResumeLayout(false);
            cbGRPCD.SelectedIndexChanged += CbGRPCD_SelectedIndexChanged;
            cbBrand.SelectedIndexChanged += CbBrand_SelectedIndexChanged;
		}

        private void CbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

            string strSQL2 = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
            strSQL2 += "WHERE MACOD_CTYID = 'CATCD' ";
            strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbBrand.SelectedValue), "' ")));
            strSQL2 += "ORDER BY MACOD_CODID";
            cbCATCD.ValueMember = "MACOD_CODID";
            cbCATCD.DisplayMember = "MACOD_CODNM";
            Common.RetriveComboItembySQL(strSQL2, cbCATCD);
        }

        private void CbGRPCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strSQL2 = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
            strSQL2 += "WHERE MACOD_CTYID = 'BRAND' ";
            strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbGRPCD.SelectedValue), "' ")));
            strSQL2 += "ORDER BY MACOD_CODID";
            cbBrand.ValueMember = "MACOD_CODID";
            cbBrand.DisplayMember = "MACOD_CODNM";
            Common.RetriveComboItembySQL(strSQL2, cbBrand);
        }

        private void frmSLRORD_FormClosing(object sender, FormClosingEventArgs e)
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

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			string strReportFile = string.Empty;
			int intGroupBy = default(int);
			if (chkCUSID.Checked)
			{
				intGroupBy = 0;
				strReportFile = "crptSLRORD_CUS.rpt";
			}
			if (chkMDLCD.Checked)
			{
				intGroupBy = 1;
				strReportFile = "crptSLRORD_MDL.rpt";
			}
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "SALES REPORT";
			frmRPT.ReportFile = PublicVar.gstrRptPath + strReportFile;
			frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PERIOD=" + Common.gfSQLDate(dtpGRCDTFR.Value) + ",@GROUPBY=" + Conversions.ToString(intGroupBy) + ",@GRPCD=", cbGRPCD.SelectedValue), ",@CATCD="), cbCATCD.SelectedValue));
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='SALES REPORT',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS;
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void frmSLRORD_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'GRPCD' ORDER BY MACOD_CODID";
			cbGRPCD.ValueMember = "MACOD_CODID";
			cbGRPCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbGRPCD);
            
           

		}

		private void btnCLOSE_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void chkCUSID_CheckedChanged(object sender, EventArgs e)
		{
			chkMDLCD.Checked = !chkCUSID.Checked;
		}

		private void chkMDLCD_CheckedChanged(object sender, EventArgs e)
		{
			chkCUSID.Checked = !chkMDLCD.Checked;
		}
	}
}
