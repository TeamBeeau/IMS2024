using System;
using System.ComponentModel;
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
	public class frmITE2HQ : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCONFIRM")]
		private Button _btnCONFIRM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDO")]
		private DataGridView _dgvDO;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		private SqlTransaction Trn;

		private string strMessage;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		internal virtual DataGridView dgvDO
		{
			[CompilerGenerated]
			get
			{
				return _dgvDO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDETAILS_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvDO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvDO = value;
				dataGridView = _dgvDO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("GroupBox1")]
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("RadioButton2")]
		internal virtual RadioButton RadioButton2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("RadioButton1")]
		internal virtual RadioButton RadioButton1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("ORDNO")]
		internal virtual DataGridViewTextBoxColumn ORDNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("REQDT")]
		internal virtual DataGridViewTextBoxColumn REQDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("CUSID")]
		internal virtual DataGridViewTextBoxColumn CUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PDPNL_BDLNO")]
		internal virtual DataGridViewCheckBoxColumn PDPNL_BDLNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmITE2HQ()
		{
			base.Shown += frmPNLIN_Shown;
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCONFIRM = new System.Windows.Forms.Button();
			this.dgvDO = new System.Windows.Forms.DataGridView();
			this.ORDNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.REQDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CUSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PDPNL_BDLNO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.RadioButton2 = new System.Windows.Forms.RadioButton();
			this.RadioButton1 = new System.Windows.Forms.RadioButton();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDO).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel5);
			this.Panel1.Controls.Add(this.dgvDO);
			this.Panel1.Controls.Add(this.GroupBox1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1580, 790);
			this.Panel1.TabIndex = 30;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 1;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Controls.Add(this.btnCONFIRM, 0, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(295, 6);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(128, 54);
			this.TableLayoutPanel5.TabIndex = 31;
			this.btnCONFIRM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCONFIRM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCONFIRM.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCONFIRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCONFIRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCONFIRM.Image = IMS.My.Resources.Resources.process;
			this.btnCONFIRM.Location = new System.Drawing.Point(4, 2);
			this.btnCONFIRM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCONFIRM.Name = "btnCONFIRM";
			this.btnCONFIRM.Size = new System.Drawing.Size(120, 50);
			this.btnCONFIRM.TabIndex = 26;
			this.btnCONFIRM.Text = "Process";
			this.btnCONFIRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCONFIRM.UseVisualStyleBackColor = false;
			this.dgvDO.AllowUserToAddRows = false;
			this.dgvDO.AllowUserToResizeRows = false;
			this.dgvDO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDO.Columns.AddRange(this.ORDNO, this.REQDT, this.CUSID, this.PDPNL_BDLNO);
			this.dgvDO.Location = new System.Drawing.Point(14, 66);
			this.dgvDO.Margin = new System.Windows.Forms.Padding(5);
			this.dgvDO.Name = "dgvDO";
			this.dgvDO.RowHeadersVisible = false;
			this.dgvDO.RowHeadersWidth = 25;
			this.dgvDO.Size = new System.Drawing.Size(409, 411);
			this.dgvDO.TabIndex = 26;
			this.ORDNO.HeaderText = "Delivery Order No";
			this.ORDNO.Name = "ORDNO";
			this.ORDNO.ReadOnly = true;
			this.ORDNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ORDNO.Width = 130;
			this.REQDT.HeaderText = "Delevery Date";
			this.REQDT.Name = "REQDT";
			this.REQDT.ReadOnly = true;
			this.REQDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.REQDT.Width = 120;
			this.CUSID.HeaderText = "Customer ID";
			this.CUSID.Name = "CUSID";
			this.CUSID.ReadOnly = true;
			this.CUSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.PDPNL_BDLNO.DataPropertyName = "PDPNL_BDLNO";
			this.PDPNL_BDLNO.HeaderText = "";
			this.PDPNL_BDLNO.Name = "PDPNL_BDLNO";
			this.PDPNL_BDLNO.ReadOnly = true;
			this.PDPNL_BDLNO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.PDPNL_BDLNO.Width = 40;
			this.GroupBox1.Controls.Add(this.RadioButton2);
			this.GroupBox1.Controls.Add(this.RadioButton1);
			this.GroupBox1.Location = new System.Drawing.Point(14, 3);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(258, 54);
			this.GroupBox1.TabIndex = 42;
			this.GroupBox1.TabStop = false;
			this.RadioButton2.AutoSize = true;
			this.RadioButton2.Location = new System.Drawing.Point(133, 22);
			this.RadioButton2.Name = "RadioButton2";
			this.RadioButton2.Size = new System.Drawing.Size(119, 21);
			this.RadioButton2.TabIndex = 43;
			this.RadioButton2.TabStop = true;
			this.RadioButton2.Text = "Download CSV";
			this.RadioButton2.UseVisualStyleBackColor = true;
			this.RadioButton1.AutoSize = true;
			this.RadioButton1.Location = new System.Drawing.Point(6, 22);
			this.RadioButton1.Name = "RadioButton1";
			this.RadioButton1.Size = new System.Drawing.Size(114, 21);
			this.RadioButton1.TabIndex = 43;
			this.RadioButton1.TabStop = true;
			this.RadioButton1.Text = "Data Transfer";
			this.RadioButton1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 17f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1584, 791);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			base.Name = "frmITE2HQ";
			this.Text = "Data Interface to HQ";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDO).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		public void Header()
		{
			Panel1.Visible = true;
		}

		private void btnNEW_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			ManageDOCNO();
			ClearDetails();
			ClearControl();
			ManageWHSCD();
		}

		private void btnBACK_Click(object sender, EventArgs e)
		{
			Header();
			ClearDetails();
			ClearControl();
		}

		private void frmPNLIN_Shown(object sender, EventArgs e)
		{
			Header();
		}

		public void ClearDetails()
		{
		}

		public void ClearControl()
		{
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			if (ValidateDetailControl() && spPDEQCR("0"))
			{
				RefreshGrid();
				ClearDetails();
				btnCONFIRM.Enabled = true;
			}
		}

		private bool spPDEQCR(string strPRO)
		{
			return true;
		}

		public void ManageDOCNO()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"));
		}

		private bool ValidateDetailControl()
		{
			return true;
		}

		private object AutoGenerate()
		{
			string strNo = "";
			string strICLYR = Conversions.ToString(DB.GetColumnValue("MANUM_ICLYR", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"));
			string strYRLOC = Conversions.ToString(DB.GetColumnValue("MANUM_YRLOC", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"));
			string strYRDGT = Conversions.ToString(DB.GetColumnValue("MANUM_YRDGT", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"));
			string strPREFIX = Conversions.ToString(DB.GetColumnValue("MANUM_PREFIX", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"));
			int intRUNNO = Conversions.ToInteger(DB.GetColumnValue("MANUM_RUNNO", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"));
			string intRUNNOLEN = Conversions.ToString(DB.GetColumnValue("MANUM_RUNNOLEN", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"));
			string strSPECIAL = Conversions.ToString(DB.GetColumnValue("MANUM_SPCLPREF", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"));
			string strFORMAT = intRUNNO.ToString("D" + checked((int)Math.Round((double)intRUNNO.ToString("D").Length + Conversions.ToDouble(intRUNNOLEN))));
			string strRUNNO = Strings.Right(strFORMAT, Conversions.ToInteger(intRUNNOLEN));
			if (Conversions.ToBoolean(strICLYR))
			{
				strYRDGT = (Operators.ConditionalCompareObjectEqual(DB.GetColumnValue("MANUM_YRDGT", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"), "1", false) ? DateAndTime.Now.ToString("yy") : ((!Operators.ConditionalCompareObjectEqual(DB.GetColumnValue("MANUM_YRDGT", "MANUM_TBL", "MANUM_PRGID = 'PDEQCR' AND MANUM_DOCID = 'PDPNL'"), "2", false)) ? "" : DateAndTime.Now.ToString("yyyy")));
				if (Operators.CompareString(strYRLOC, "1", false) == 0)
				{
					strNo = strYRDGT + strPREFIX + strSPECIAL + strRUNNO;
				}
				else if (Operators.CompareString(strYRLOC, "2", false) == 0)
				{
					strNo = strPREFIX + strYRDGT + strSPECIAL + strRUNNO;
				}
			}
			else
			{
				strNo = strPREFIX + strSPECIAL + strRUNNO;
			}
			return strNo;
		}

		public void RefreshGrid()
		{
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		public void BindHeadertoControl()
		{
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindHeadertoControl();
			RefreshGrid();
		}

		public void BindGridtoControl()
		{
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
		}

		private void dgvDETAILS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		public void ManageWHSCD()
		{
		}

		private void btnDELETE_Click(object sender, EventArgs e)
		{
		}

		public void DisplayReport()
		{
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnCONFIRM_Click(object sender, EventArgs e)
		{
		}
	}
}
