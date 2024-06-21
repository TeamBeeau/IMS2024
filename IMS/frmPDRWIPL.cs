using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmPDRWIPL : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private System.Windows.Forms.Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private System.Windows.Forms.Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnEXCEL")]
		private System.Windows.Forms.Button _btnEXCEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bgwProgress")]
		private BackgroundWorker _bgwProgress;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbLOCID")]
		private ComboBox _cbLOCID;

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnPRINT
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
				System.Windows.Forms.Button button = _btnPRINT;
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

		internal virtual System.Windows.Forms.Button btnClose
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
				System.Windows.Forms.Button button = _btnClose;
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

		[field: AccessedThroughProperty("dtpFRDATE")]
		internal virtual DateTimePicker dtpFRDATE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual System.Windows.Forms.Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label16")]
		internal virtual System.Windows.Forms.Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpTODATE")]
		internal virtual DateTimePicker dtpTODATE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnEXCEL
		{
			[CompilerGenerated]
			get
			{
				return _btnEXCEL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnEXCEL_Click;
				System.Windows.Forms.Button button = _btnEXCEL;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnEXCEL = value;
				button = _btnEXCEL;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual BackgroundWorker bgwProgress
		{
			[CompilerGenerated]
			get
			{
				return _bgwProgress;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = bgwProgress_DoWork;
				RunWorkerCompletedEventHandler value3 = bgwProgress_RunWorkerCompleted;
				BackgroundWorker backgroundWorker = _bgwProgress;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork -= value2;
					backgroundWorker.RunWorkerCompleted -= value3;
				}
				_bgwProgress = value;
				backgroundWorker = _bgwProgress;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork += value2;
					backgroundWorker.RunWorkerCompleted += value3;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual System.Windows.Forms.Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbLOCID
		{
			[CompilerGenerated]
			get
			{
				return _cbLOCID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbLOCID_SelectedIndexChanged;
				ComboBox comboBox = _cbLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbLOCID = value;
				comboBox = _cbLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lblLOCID")]
		internal virtual System.Windows.Forms.Label lblLOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPDRWIPL()
		{
			base.Shown += frmPDRWIPL_Shown;
			base.FormClosing += frmPDRWIPL_FormClosing;
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
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnEXCEL = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.dtpFRDATE = new System.Windows.Forms.DateTimePicker();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.dtpTODATE = new System.Windows.Forms.DateTimePicker();
			this.btnClose = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.bgwProgress = new System.ComponentModel.BackgroundWorker();
			this.lblLOCID = new System.Windows.Forms.Label();
			this.TableLayoutPanel3.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.lblLOCID, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.cbLOCID, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnEXCEL, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 2, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label16, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.dtpFRDATE, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.dtpTODATE, 3, 1);
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 2, 3);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 4;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(412, 132);
			this.TableLayoutPanel3.TabIndex = 19;
			this.TableLayoutPanel3.SetColumnSpan(this.cbLOCID, 3);
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(129, 3);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(200, 24);
			this.cbLOCID.TabIndex = 71;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 7);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(59, 16);
			this.Label2.TabIndex = 53;
			this.Label2.Text = "Location";
			this.btnEXCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnEXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEXCEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnEXCEL.Image = IMS.My.Resources.Resources.Excel;
			this.btnEXCEL.Location = new System.Drawing.Point(3, 80);
			this.btnEXCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEXCEL.Name = "btnEXCEL";
			this.btnEXCEL.Size = new System.Drawing.Size(120, 50);
			this.btnEXCEL.TabIndex = 52;
			this.btnEXCEL.Text = "Excel";
			this.btnEXCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEXCEL.UseVisualStyleBackColor = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(255, 36);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 50;
			this.Label1.Text = "To";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(3, 36);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(37, 16);
			this.Label16.TabIndex = 49;
			this.Label16.Text = "Date";
			this.dtpFRDATE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpFRDATE.CustomFormat = "dd/MM/yyyy";
			this.dtpFRDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFRDATE.Location = new System.Drawing.Point(129, 33);
			this.dtpFRDATE.Name = "dtpFRDATE";
			this.dtpFRDATE.Size = new System.Drawing.Size(104, 22);
			this.dtpFRDATE.TabIndex = 8;
			this.dtpFRDATE.TabStop = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(129, 80);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 6;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.dtpTODATE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpTODATE.CustomFormat = "dd/MM/yyyy";
			this.dtpTODATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTODATE.Location = new System.Drawing.Point(305, 33);
			this.dtpTODATE.Name = "dtpTODATE";
			this.dtpTODATE.Size = new System.Drawing.Size(104, 22);
			this.dtpTODATE.TabIndex = 51;
			this.dtpTODATE.TabStop = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel3.SetColumnSpan(this.btnClose, 2);
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(255, 80);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1560, 672);
			this.Panel1.TabIndex = 20;
			this.lblLOCID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLOCID.AutoSize = true;
			this.lblLOCID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLOCID.Location = new System.Drawing.Point(3, 60);
			this.lblLOCID.Name = "lblLOCID";
			this.lblLOCID.Size = new System.Drawing.Size(59, 16);
			this.lblLOCID.TabIndex = 72;
			this.lblLOCID.Text = "Location";
			this.lblLOCID.Visible = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPDRWIPL";
			base.Tag = "PDRFGL";
			this.Text = "Finished Goods Ledger";
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPDRWIPL_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
			dtpFRDATE.Value = DateAndTime.Now.Date;
			dtpTODATE.Value = DateAndTime.Now.Date;
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MALOC_LOCTY = 'WIP' ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "WIP Ledger";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDRWIPL.rpt";
			frmRPT.Params = "@LOCID=" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + ",@FRDATE=" + Common.gfSQLDate(dtpFRDATE.Value) + ",@TODATE=" + Common.gfSQLDate(dtpTODATE.Value);
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='WIP Ledger',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS + ",WGTDS=" + PublicVar.gintWGTDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPDRWIPL_FormClosing(object sender, FormClosingEventArgs e)
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

		private void btnEXCEL_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bgwProgress.RunWorkerAsync();
		}

		private void bgwProgress_DoWork(object sender, DoWorkEventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application xlsApp = new ApplicationClass();
			string strLOCID = string.Empty;
			string strITMCD = string.Empty;
			double dblBalance = 0.0;
			string strSQL = "EXEC spPDRWIPL '" + lblLOCID.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpFRDATE.Value) + "', '" + Common.gfSQLDate(dtpTODATE.Value) + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No data found!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			Workbook xlsWorkBook = xlsApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
			Worksheet xlsSheet = (Worksheet)xlsWorkBook.Sheets["Sheet1"];
			xlsApp.Cells[1, 1] = PublicVar.gstrCompany;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WIP Ledger");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			xlsApp.Cells[3, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "From") + " " + Common.gfSQLDate(dtpFRDATE.Value) + " To " + Common.gfSQLDate(dtpTODATE.Value);
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[3, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[3, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			int intRow = 5;
			xlsApp.Cells[intRow, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
			xlsApp.Cells[intRow, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Code");
			xlsApp.Cells[intRow, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
			xlsApp.Cells[intRow, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO Date");
			xlsApp.Cells[intRow, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO No");
			xlsApp.Cells[intRow, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
			xlsApp.Cells[intRow, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
			xlsApp.Cells[intRow, 8] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
			xlsApp.Cells[intRow, 9] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			xlsApp.Cells[intRow, 10] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Cust Part");
			xlsApp.Cells[intRow, 11] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
			xlsApp.Cells[intRow, 12] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In Qty");
			xlsApp.Cells[intRow, 13] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out Qty");
			xlsApp.Cells[intRow, 14] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[5, 14])).Font.Bold = true;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 10])).EntireColumn.NumberFormat = "@";
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 14])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 14])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					intRow++;
					xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOCDT"]);
					xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOCCD"]);
					xlsApp.Cells[intRow, 3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOCNO"]);
					xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["WKODT"]);
					xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["WKONO"]);
					xlsApp.Cells[intRow, 6] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["FGLNO"]);
					xlsApp.Cells[intRow, 7] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["WO_TYPE"]);
					xlsApp.Cells[intRow, 8] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["CUS_SHORT"]);
					xlsApp.Cells[intRow, 9] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MDLCD"]);
					xlsApp.Cells[intRow, 10] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["CUS_CPTNO"]);
					xlsApp.Cells[intRow, 11] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["REVNO"]);
					xlsApp.Cells[intRow, 12] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["IN_QTY"]);
					xlsApp.Cells[intRow, 13] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["OUT_QTY"]);
					xlsApp.Cells[intRow, 14] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["BALANCE"]);
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 11]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 14])).NumberFormat = "0.00";
				}
				xlsSheet.Columns.AutoFit();
				xlsSheet = null;
				xlsWorkBook = null;
				GC.Collect();
				xlsApp.WindowState = XlWindowState.xlMaximized;
				xlsApp.Visible = true;
			}
		}

		private void bgwProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Cursor = Cursors.Default;
		}

		private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblLOCID.Text = Conversions.ToString(cbLOCID.SelectedValue);
		}
	}
}
