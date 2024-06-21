using System;
using System.Collections.Generic;
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
using Button = System.Windows.Forms.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using DataTable = System.Data.DataTable;
using Label = System.Windows.Forms.Label;

namespace IMS
{
	[DesignerGenerated]
	public class frmPCRORD : Form
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

		[field: AccessedThroughProperty("cbHCATCD")]
		internal virtual ComboBox cbHCATCD
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
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [AccessedThroughProperty("cbHGRPCD")]
        private ComboBox _cbHGRPCD;
        internal virtual ComboBox cbHGRPCD
        {
            [CompilerGenerated]
            get
            {
                return _cbHGRPCD;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [CompilerGenerated]
            set
            {
                EventHandler value2 = cbHGRPCD_SelectedIndexChanged;
                ComboBox comboBox = _cbHGRPCD;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= value2;
                }
                _cbHGRPCD = value;
                comboBox = _cbHGRPCD;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged += value2;
                }
            }
        }
        public frmPCRORD()
		{
			base.FormClosing += frmSLRORD_FormClosing;
			base.Load += frmSLRORD_Load;
            this.Shown += FrmPCRORD_Shown;
			InitializeComponent();
		}

        private void FrmPCRORD_Shown(object sender, EventArgs e)
        {
            cbHGRPCD.SelectedIndex = -1;
            cbHBRAND.SelectedIndex = -1;
            cbHCATCD.SelectedIndex = -1;
            BindComboBox("HGRPCD");
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
        [CompilerGenerated]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [AccessedThroughProperty("cbHBRAND")]
        private ComboBox _cbHBRAND;
        internal virtual ComboBox cbHBRAND
        {
            [CompilerGenerated]
            get
            {
                return _cbHBRAND;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            [CompilerGenerated]
            set
            {
                EventHandler value2 = cbHBRAND_SelectedIndexChanged;
                ComboBox comboBox = _cbHBRAND;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= value2;
                }
                _cbHBRAND = value;
                comboBox = _cbHBRAND;
                if (comboBox != null)
                {
                    comboBox.SelectedIndexChanged += value2;
                }
            }
        }
        DateTimePicker dtpGRDEND = new DateTimePicker();
		Label lb6=new Label();
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
			this.cbHCATCD = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbHGRPCD = new System.Windows.Forms.ComboBox();
			this.cbHBRAND=new System.Windows.Forms.ComboBox();
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
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(SizeType.Absolute, 200));
     
            this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.lb6, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.dtpGRCDTFR, 1, 0);
            this.TableLayoutPanel1.Controls.Add(this.dtpGRDEND, 3, 1);
            this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 1,6);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 5);
        
            this.TableLayoutPanel1.Controls.Add(this.cbHCATCD, 1, 5);
            this.TableLayoutPanel1.Controls.Add(this.lbBrand, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.cbHBRAND, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.cbHGRPCD, 1, 3);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
			this.Label5.Text = "From Date";

            this.lb6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lb6.AutoSize = true;
            this.lb6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb6.Location = new System.Drawing.Point(3, 6);
            this.lb6.Name = "Label6";
            this.lb6.Size = new System.Drawing.Size(48, 16);
            this.lb6.TabIndex = 7;
            this.lb6.Text = "To Date";
            this.dtpGRCDTFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpGRCDTFR.CustomFormat = "MMM/yyyy";
			this.dtpGRCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpGRCDTFR.Location = new System.Drawing.Point(100, 3);
			this.dtpGRCDTFR.Name = "dtpGRCDTFR";
			this.dtpGRCDTFR.Size = new System.Drawing.Size(120, 22);
			this.dtpGRCDTFR.TabIndex = 65;

            this.dtpGRDEND.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpGRDEND.CustomFormat = "MMM/yyyy";
            this.dtpGRDEND.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGRDEND.Location = new System.Drawing.Point(100, 3);
            this.dtpGRDEND.Name = "dtpGRDEND";
            this.dtpGRDEND.Size = new System.Drawing.Size(120, 22);
           // this.dtpGRDEND.TabIndex = 65;
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
            this.cbHBRAND.Location = new System.Drawing.Point(100, 62);
            this.cbHBRAND.Size = new System.Drawing.Size(133, 24);
            this.cbHCATCD.FormattingEnabled = true;
			this.cbHCATCD.Location = new System.Drawing.Point(100, 92);
			this.cbHCATCD.Name = "cbHCATCD";
			this.cbHCATCD.Size = new System.Drawing.Size(133, 24);
			this.cbHCATCD.TabIndex = 68;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 66);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(73, 16);
			this.Label2.TabIndex = 69;
			this.Label2.Text = "Item Group";
			this.cbHGRPCD.FormattingEnabled = true;
			this.cbHGRPCD.Location = new System.Drawing.Point(100, 62);
			this.cbHGRPCD.Name = "cbGRPCD";
			this.cbHGRPCD.Size = new System.Drawing.Size(133, 24);
			this.cbHGRPCD.TabIndex = 70;
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
			this.Text = "Purchase Report";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			base.ResumeLayout(false);
         
           
		}

        private void cbHBRAND_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbHCATCD.SelectedIndex = -1;
            BindComboBox("HCATCD");
        }
		bool IsLoad = false;
        private void cbHGRPCD_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (!IsLoad)
			{
				IsLoad = true; return;
			}
            cbHBRAND.SelectedIndex = -1;
            cbHCATCD.SelectedIndex = -1;
            BindComboBox("HBRAND");
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
		BackgroundWorker workReport = new BackgroundWorker();
		private void btnPRINT_Click(object sender, EventArgs e)
		{
			btnPRINT.Enabled = false;

            if (!workReport.IsBusy)
			{
                btnPRINT.Text="Wait ...";
                workReport.DoWork-= WorkReport_DoWork;
                workReport.RunWorkerCompleted -= WorkReport_RunWorkerCompleted;
                workReport.RunWorkerAsync(); workReport.DoWork += WorkReport_DoWork;
                workReport.RunWorkerCompleted += WorkReport_RunWorkerCompleted;

            }	
			
		}

        private void WorkReport_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DisplayReport();
            btnPRINT.Text = "Print";
            btnPRINT.Enabled = true;
        }

        private void WorkReport_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void DisplayReport()
		{
			String sCATCD = "",sGRPCD="",sBRAND="";
			if (cbHCATCD.SelectedValue != null) sCATCD = Conversions.ToString(cbHCATCD.SelectedValue);
            if (cbHGRPCD.SelectedValue != null) sGRPCD= Conversions.ToString(cbHGRPCD.SelectedValue);
            if (cbHBRAND.SelectedValue != null) sBRAND=Conversions.ToString(cbHBRAND.SelectedValue);
            string strSQL = "EXEC spMAITM '0', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("0") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(sCATCD) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(sGRPCD) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(sBRAND) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";

            strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'",  "zzzzz"), "' ")));
            DataTable dt = DB.ExecProc(strSQL);
			List<String> list = new List<string>();
		 foreach (DataRow dr in dt.Rows)
			{
				list.Add(dr["MAITM_ITMCD"].ToString());


            }
			 dt = new DataTable();
			string strSQL2 = "* ";
            
			if (chkCUSID.Checked)
			{

               
                foreach (string s in list)
                {
                    string sWhere = " PCPCO_ENTDT >= '" + dtpGRCDTFR.Value + "' AND  PCPCO_ENTDT <= '" + dtpGRDEND.Value + "' ";

					if (s != "")
					{
						sWhere += " AND PCPCO_ITMCD ='" + s + "' ";
						DataTable dt2 = DB.GetTable(strSQL2, "PCPCO_TBL", sWhere + " ", " PCPCO_SUPID ");//+ Conversions.ToString(cbHCUSID.SelectedValue) + \"'
					dt.Merge(dt2);
					}

                }
                if (dt == null)
					return;
				Microsoft.Office.Interop.Excel.Application xlsApp = new ApplicationClass();
				decimal intTotal = 0;

				checked
				{
					if (dt.Rows.Count != 0)
					{
						Workbook xlsWorkBook = xlsApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
						Worksheet xlsSheet = (Worksheet)xlsWorkBook.Sheets["Sheet1"];
						xlsApp.Cells[1, 1] = PublicVar.gstrCompany;
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
						xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Purchase Report");
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
                        xlsApp.Cells[3, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type Filed ");
                        xlsApp.Cells[3, 2] = RuntimeHelpers.GetObjectValue("Customer");
                        xlsApp.Cells[4, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Periold ");
                       String date="From "+ dtpGRCDTFR.Value.ToString("yyyy-MM");
						xlsApp.Cells[4, 2] =  RuntimeHelpers.GetObjectValue(date);// RuntimeHelpers.GetObjectValue(date);
                      //  ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 2]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 2])).NumberFormat = "0.00";
						xlsApp.Cells[6, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
						xlsApp.Cells[6, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "From");
						xlsApp.Cells[6, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model");
                        xlsApp.Cells[6, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Reference No");

                        xlsApp.Cells[6, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery Date");
						xlsApp.Cells[6, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Qty");
						xlsApp.Cells[6, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "UpPrice");
                        xlsApp.Cells[6, 8] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Unit");
                        xlsApp.Cells[6, 9] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "TotalPrice");
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 9])).Font.Bold = true;
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 5])).EntireColumn.NumberFormat = "@";
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 9])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 9])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
						int intRow = 7;
						int num = dt.Rows.Count - 1;

						String nameCusIDPrev = dt.Rows[0]["PCPCO_SUPID"].ToString();
						intTotal = 0;
						decimal TotalPrice = 0;
                        xlsApp.Cells[intRow, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
                        xlsApp.Cells[intRow, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), nameCusIDPrev);
                        ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow,2]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 3])).Font.Bold = true;
                        intRow++;
                        for (int i = 0; i <= num; i++)
						{
							String nameCusID = dt.Rows[i]["PCPCO_SUPID"].ToString();
							if (nameCusIDPrev != dt.Rows[i]["PCPCO_SUPID"].ToString() || i == num)
							{

                               
                                xlsApp.Cells[intRow, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total");
								xlsApp.Cells[intRow, 6] = intTotal;
								xlsApp.Cells[intRow, 9] = TotalPrice; intTotal = 0; TotalPrice = 0;
								//((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5])).NumberFormat = "0.000";
								((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";
								((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).Font.Bold = true;
                                 ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                                nameCusIDPrev = nameCusID;
                                intRow++;
                                xlsApp.Cells[intRow, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
                                xlsApp.Cells[intRow, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), nameCusIDPrev);
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 2]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 2])).Font.Bold = true;
                                intRow++;

                            }
							//[PCPCO_PAYTM]
						
						
                            decimal Qty = (decimal)RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_QTY"]);
							decimal Price = (decimal)RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_UPRICE"]);
                            String Unit = Conversions.ToString(DB.GetColumnValue("MASUP_CURCD", "MASUP_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASUP_SUPID = '", dt.Rows[i]["PCPCO_SUPID"].ToString()), "'"))));
                            DataTable dtUnit = DB.GetTable("*", "MACUR_TBL", "MACUR_FRCUR='"+ Unit + "'"," MACUR_LUPDT ","DESC");
							decimal dUnit = 1;

							if (dtUnit != null)
								if (dtUnit.Rows.Count > 0)
									dUnit =(decimal)dtUnit.Rows[0]["MACUR_XRATE"];

							Price = Price * dUnit;
                            xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_DOCNO"]);
							xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_DELID"]);
							xlsApp.Cells[intRow,3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_ITMCD"]);
                            xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_DOCDT"]);
							DateTime date2 = (DateTime)(dt.Rows[i]["PCPCO_ENTDT"]);
                            xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(date2.ToString("yyyy/MM/dd"));
							xlsApp.Cells[intRow, 6] = Qty;
							xlsApp.Cells[intRow, 7] = Price;
							xlsApp.Cells[intRow, 8] = "VND";
                            xlsApp.Cells[intRow, 9] = Qty * Price ;
                            ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 6]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";
                            intTotal += Qty;
							TotalPrice += Qty * Price ;
							intRow++;
                            if (i == num)
                            {
                                xlsApp.Cells[intRow, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total");
                                xlsApp.Cells[intRow, 6] = intTotal;
                                xlsApp.Cells[intRow, 9] = TotalPrice; intTotal = 0; TotalPrice = 0;
                                //((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5])).NumberFormat = "0.000";
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).Font.Bold = true;
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                                nameCusIDPrev = nameCusID;
                                intRow++;
                              
                            }

                        }
						//xlsApp.Cells[intRow, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Toal");
						//xlsApp.Cells[intRow, 7] = intTotal;
						xlsSheet.Columns.AutoFit();
						xlsSheet = null;
						xlsWorkBook = null;
						GC.Collect();

                        xlsApp.WindowState = XlWindowState.xlMinimized;
                        xlsApp.WindowState = XlWindowState.xlMaximized;
                       

                        xlsApp.Visible = true;
						Cursor = Cursors.Default;
					}
				}
			}
			else
			{
              //  dt = DB.GetTable(strSQL2, "PCPCO_TBL", sWhere + " ", " PCPCO_ITMCD ");//+ Conversions.ToString(cbHCUSID.SelectedValue) + \"'
                foreach (string s in list)
                {
                    string sWhere = " PCPCO_ENTDT >= '" + dtpGRCDTFR.Value + "' AND  PCPCO_ENTDT <= '" + dtpGRDEND.Value + "' ";

                    if (s != list[0])
                    {
                        sWhere += " AND PCPCO_ITMCD ='" + s + "' ";
                        DataTable dt2 = DB.GetTable(strSQL2, "PCPCO_TBL", sWhere + " ", " PCPCO_ITMCD ");//+ Conversions.ToString(cbHCUSID.SelectedValue) + \"'
                        dt.Merge(dt2);
                    }

                }
                if (dt == null)
                    return;
                Microsoft.Office.Interop.Excel.Application xlsApp = new ApplicationClass();
                decimal intTotal = 0;

                checked
                {
                    if (dt.Rows.Count != 0)
                    {
                        Workbook xlsWorkBook = xlsApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
                        Worksheet xlsSheet = (Worksheet)xlsWorkBook.Sheets["Sheet1"];
                        xlsApp.Cells[1, 1] = PublicVar.gstrCompany;
                        ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
                        xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Purchase Report");
                        ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
                        xlsApp.Cells[3, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type Filed ");
                        xlsApp.Cells[3, 2] = RuntimeHelpers.GetObjectValue("Model");
                        xlsApp.Cells[4, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Periold ");
                        String date = "From " + dtpGRCDTFR.Value.ToString("yyyy-MM");
                        xlsApp.Cells[4, 2] = RuntimeHelpers.GetObjectValue(date);
                        xlsApp.Cells[6, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
                        xlsApp.Cells[6, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "From");
                        xlsApp.Cells[6, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
                        xlsApp.Cells[6, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Reference No");

                        xlsApp.Cells[6, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery Date");
                        xlsApp.Cells[6, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Qty");
                        xlsApp.Cells[6, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "UpPrice");
                         xlsApp.Cells[6, 8] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Unit");
                        xlsApp.Cells[6, 9] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "TotalPrice");
                        ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 9])).Font.Bold = true;
                        ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 5])).EntireColumn.NumberFormat = "@";
                        ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 9])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                        ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 9])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                        int intRow = 7;
                        int num = dt.Rows.Count - 1;
                        String nameCusIDPrev = dt.Rows[0]["PCPCO_ITMCD"].ToString();
                        intTotal = 0;
                        decimal TotalPrice = 0;
                        xlsApp.Cells[intRow, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model");
                        xlsApp.Cells[intRow, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), nameCusIDPrev);
                        ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 2]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 3])).Font.Bold = true;
                        intRow++;
                        for (int i = 0; i <= num; i++)
                        {
                            String nameCusID = dt.Rows[i]["PCPCO_ITMCD"].ToString();
                            if (nameCusIDPrev != dt.Rows[i]["PCPCO_ITMCD"].ToString())
                            {
                                xlsApp.Cells[intRow, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total");
                                xlsApp.Cells[intRow, 6] = intTotal;
                                xlsApp.Cells[intRow, 9] = TotalPrice; intTotal = 0; TotalPrice = 0;
                                //((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5])).NumberFormat = "0.000";
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).Font.Bold = true;
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                                nameCusIDPrev = nameCusID;
                                intRow++;
                                xlsApp.Cells[intRow, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model");
                                xlsApp.Cells[intRow, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), nameCusIDPrev);
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 2]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 2])).Font.Bold = true;
                                intRow++;
                            }
                            decimal Qty = (decimal)RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_QTY"]);
                            decimal Price = (decimal)RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_UPRICE"]);
                            String Unit = Conversions.ToString(DB.GetColumnValue("MASUP_CURCD", "MASUP_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASUP_SUPID = '", dt.Rows[i]["PCPCO_SUPID"].ToString()), "'"))));
                            DataTable dtUnit = DB.GetTable("*", "MACUR_TBL", "MACUR_FRCUR='" + Unit + "'", " MACUR_LUPDT ", "DESC");
                            decimal dUnit = 1;

                            if (dtUnit != null)
                                if (dtUnit.Rows.Count > 0)
                                    dUnit = (decimal)dtUnit.Rows[0]["MACUR_XRATE"];
                            Price = Price * dUnit;
                            xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_DOCNO"]);
                            xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_DELID"]);
                            xlsApp.Cells[intRow, 3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_SUPID"]);

                            xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PCPCO_DOCDT"]);
                            DateTime date2 = (DateTime)(dt.Rows[i]["PCPCO_ENTDT"]);
                            xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(date2.ToString("yyyy/MM/dd"));
                            xlsApp.Cells[intRow, 6] = Qty;
                            xlsApp.Cells[intRow, 7] = Price;
                            xlsApp.Cells[intRow, 8] = "VND";
                            xlsApp.Cells[intRow, 9] = Qty * Price;
                            ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 6]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";

                             intTotal += Qty;
                            TotalPrice += Qty * Price* dUnit;
                            intRow++;
                            if (i == num)
                            {
                                xlsApp.Cells[intRow, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total");
                                xlsApp.Cells[intRow, 6] = intTotal;
                                xlsApp.Cells[intRow, 9] = TotalPrice; intTotal = 0; TotalPrice = 0;
                                //((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5])).NumberFormat = "0.000";
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).NumberFormat = "_(* #,##0.00_);_(* (#,##0.00);_(* \"-\"??_);_(@_)";
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).Font.Bold = true;
                                ((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 9])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
                                nameCusIDPrev = nameCusID;
                                intRow++;
                                

                            }

                        }
                        //xlsApp.Cells[intRow, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Toal");
                        //xlsApp.Cells[intRow, 7] = intTotal;
                        xlsSheet.Columns.AutoFit();
                        xlsSheet = null;
                        xlsWorkBook = null;
                        GC.Collect();
                        xlsApp.WindowState = XlWindowState.xlMinimized;
                        xlsApp.WindowState = XlWindowState.xlMaximized;
                        xlsApp.Visible = true;
                        Cursor = Cursors.Default;
                    }
                }
            }

			//if (cbHBRAND.SelectedValue != null)
			//    if (cbHBRAND.SelectedValue.ToString().Trim() != "")
			//    {
			//        sWhere += " AND MAITM_BRAND='" + Common.gfValidSQLStr(Conversions.ToString(cbHBRAND.SelectedValue)) + "'";

			//    }
			//CRViewer frmRPT = new CRViewer();
			//string strReportFile = string.Empty;
			//int intGroupBy = default(int);
			//if (chkCUSID.Checked)
			//{
			//	intGroupBy = 0;
			//	strReportFile = "crptPCPRORD_CUS.rpt";
			//}
			//if (chkMDLCD.Checked)
			//{
			//	intGroupBy = 1;
			//	strReportFile = "crptSLRORD_MDL.rpt";
			//}
			//frmRPT.ServerName = PublicVar.gstrServerName;
			//frmRPT.DatabaseName = PublicVar.gstrDBName;
			//frmRPT.UserID = PublicVar.gstrUserID;
			//frmRPT.Password = PublicVar.gstrPassword;
			//frmRPT.ReportName = "PURCHASE REPORT";
			//frmRPT.ReportFile = PublicVar.gstrRptPath + strReportFile;
			//frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PERIOD=" + Common.gfSQLDate(dtpGRCDTFR.Value) + ",@GROUPBY=" + Conversions.ToString(intGroupBy) + ",@GRPCD=", cbHGRPCD.SelectedValue), ",@CATCD="), cbHCATCD.SelectedValue));
			//frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='PURCHASE REPORT',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS;
			//frmRPT.Destination = PublicEnum.Dest.Screen;
			//frmRPT.ViewReport("");
		}

		private void frmSLRORD_Load(object sender, EventArgs e)
        {
  
            Common.Set_FormLanguage(this);
         
        }

        private void BindComboBox(string strOption)
        {
            string strSQL1 = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";

            if (Operators.CompareString(strOption, "HGRPCD", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'GRPCD' ";
                strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", "0"), "' ")));
                strSQL1 += "ORDER BY MACOD_CODID";
                cbHGRPCD.ValueMember = "MACOD_CODID";
                cbHGRPCD.DisplayMember = "MACOD_CODNM";
                Common.RetriveComboItembySQL(strSQL1, cbHGRPCD);

            }
            if (Operators.CompareString(strOption, "HBRAND", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'BRAND' ";
                strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHGRPCD.SelectedValue), "' ")));
                strSQL1 += " ORDER BY MACOD_CODID ";
                cbHBRAND.ValueMember = "MACOD_CODID";
                cbHBRAND.DisplayMember = "MACOD_CODNM";
                Common.RetriveComboItembySQL(strSQL1, cbHBRAND);
            }
            if (Operators.CompareString(strOption, "HCATCD", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'CATCD' ";
                strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHBRAND.SelectedValue), "' ")));
                strSQL1 += "ORDER BY MACOD_CODID";
                cbHCATCD.ValueMember = "MACOD_CODID";
                cbHCATCD.DisplayMember = "MACOD_CODNM";
                Common.RetriveComboItembySQL(strSQL1, cbHCATCD);
            }
         

          //  string strSQL2 = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
            //if (Operators.CompareString(strOption, "ITMTY", false) == 0)
            //{
            //    strSQL2 += "WHERE MACOD_CTYID = 'ITMTY' ORDER BY MACOD_CODID";
            //    cbITMTY.ValueMember = "MACOD_CODID";
            //    cbITMTY.DisplayMember = "MACOD_CODNM";
            //    Common.RetriveComboItembySQL(strSQL2, cbITMTY);
            //}
            //if (Operators.CompareString(strOption, "GRPCD", false) == 0)
            //{
            //    strSQL2 += "WHERE MACOD_CTYID = 'GRPCD' ";
            //    strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbITMTY.SelectedValue), "' ")));
            //    strSQL2 += "ORDER BY MACOD_CODID";
            //    cbGRPCD.ValueMember = "MACOD_CODID";
            //    cbGRPCD.DisplayMember = "MACOD_CODNM";
            //    Common.RetriveComboItembySQL(strSQL2, cbGRPCD);
            //}
            //if (Operators.CompareString(strOption, "BRAND", false) == 0)
            //{
            //    strSQL2 += "WHERE MACOD_CTYID = 'BRAND' ";
            //    strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHGRPCD.SelectedValue), "' ")));
            //    strSQL2 += "ORDER BY MACOD_CODID";
            //    cbHBRAND.ValueMember = "MACOD_CODID";
            //    cbHBRAND.DisplayMember = "MACOD_CODNM";
            //    Common.RetriveComboItembySQL(strSQL2, cbHBRAND);
            //}
            //if (Operators.CompareString(strOption, "CATCD", false) == 0)
            //{
            //    strSQL2 += "WHERE MACOD_CTYID = 'CATCD' ";
            //    strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHBRAND.SelectedValue), "' ")));
            //    strSQL2 += "ORDER BY MACOD_CODID";
            //    cbHCATCD.ValueMember = "MACOD_CODID";
            //    cbHCATCD.DisplayMember = "MACOD_CODNM";
            //    Common.RetriveComboItembySQL(strSQL2, cbHCATCD);
            //}
            //if (Operators.CompareString(strOption, "SUBCATCD", false) == 0)
            //{
            //    strSQL2 += "WHERE MACOD_CTYID = 'SUBCATCD' ";
            //    strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHCATCD.SelectedValue), "' ")));
            //    strSQL2 += "ORDER BY MACOD_CODID";
            //    cbSUBCATCD.ValueMember = "MACOD_CODID";
            //    cbSUBCATCD.DisplayMember = "MACOD_CODNM";
            //    Common.RetriveComboItembySQL(strSQL2, cbSUBCATCD);
            //}
          //  BindLabel();
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
