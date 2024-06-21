using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
	public class frmMAPITM_BAR : Form
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

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCDFR")]
		private ComboboxControl _cbITMCDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCATCDFR")]
		private ComboboxControl _cbCATCDFR;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label21")]
		internal virtual Label Label21
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdo1DBARCODE")]
		internal virtual RadioButton rdo1DBARCODE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdo2DQRCODE")]
		internal virtual RadioButton rdo2DQRCODE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbITMCDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbITMCDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbITMCDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbITMCDFR = value;
				comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbCATCDTO")]
		internal virtual ComboboxControl cbCATCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbCATCDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbCATCDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbCATCDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbCATCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbCATCDFR = value;
				comboboxControl = _cbCATCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbITMCDTO")]
		internal virtual ComboboxControl cbITMCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAPITM_BAR()
		{
			base.FormClosing += frmMAPITM_BAR_FormClosing;
			base.Shown += frmMAPITM_BAR_Shown;
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
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.cbCATCDTO = new IMS.ComboboxControl();
			this.cbCATCDFR = new IMS.ComboboxControl();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.rdo1DBARCODE = new System.Windows.Forms.RadioButton();
			this.rdo2DQRCODE = new System.Windows.Forms.RadioButton();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
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
			this.TableLayoutPanel1.Controls.Add(this.cbITMCDFR, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbCATCDTO, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbCATCDFR, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label21, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCDTO, 3, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 5;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(774, 177);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(78, 37);
			this.cbITMCDFR.Name = "cbITMCDFR";
			this.cbITMCDFR.SelectedIndex = -1;
			this.cbITMCDFR.SelectedItem = null;
			this.cbITMCDFR.SelectedValue = null;
			this.cbITMCDFR.Size = new System.Drawing.Size(326, 27);
			this.cbITMCDFR.TabIndex = 2;
			this.cbITMCDFR.TextMultiline = true;
			this.cbITMCDFR.ValueMember = null;
			this.cbITMCDFR.WhereClause = null;
			this.cbCATCDTO.BlankValue = null;
			this.cbCATCDTO.ComboboxWidth = 170;
			this.cbCATCDTO.DataTable = null;
			this.cbCATCDTO.DisplayMember = null;
			this.cbCATCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCATCDTO.HasBlankValue = true;
			this.cbCATCDTO.Location = new System.Drawing.Point(442, 3);
			this.cbCATCDTO.Name = "cbCATCDTO";
			this.cbCATCDTO.SelectedIndex = -1;
			this.cbCATCDTO.SelectedItem = null;
			this.cbCATCDTO.SelectedValue = null;
			this.cbCATCDTO.Size = new System.Drawing.Size(329, 27);
			this.cbCATCDTO.TabIndex = 53;
			this.cbCATCDTO.TextMultiline = true;
			this.cbCATCDTO.ValueMember = null;
			this.cbCATCDTO.WhereClause = null;
			this.cbCATCDFR.BlankValue = null;
			this.cbCATCDFR.ComboboxWidth = 170;
			this.cbCATCDFR.DataTable = null;
			this.cbCATCDFR.DisplayMember = null;
			this.cbCATCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCATCDFR.HasBlankValue = true;
			this.cbCATCDFR.Location = new System.Drawing.Point(78, 3);
			this.cbCATCDFR.Name = "cbCATCDFR";
			this.cbCATCDFR.SelectedIndex = -1;
			this.cbCATCDFR.SelectedItem = null;
			this.cbCATCDFR.SelectedValue = null;
			this.cbCATCDFR.Size = new System.Drawing.Size(327, 28);
			this.cbCATCDFR.TabIndex = 1;
			this.cbCATCDFR.TextMultiline = true;
			this.cbCATCDFR.ValueMember = null;
			this.cbCATCDFR.WhereClause = null;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 2);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.rdo1DBARCODE, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.rdo2DQRCODE, 1, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(78, 70);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(212, 26);
			this.TableLayoutPanel2.TabIndex = 20;
			this.rdo1DBARCODE.AutoSize = true;
			this.rdo1DBARCODE.Checked = true;
			this.rdo1DBARCODE.Location = new System.Drawing.Point(3, 3);
			this.rdo1DBARCODE.Name = "rdo1DBARCODE";
			this.rdo1DBARCODE.Size = new System.Drawing.Size(98, 20);
			this.rdo1DBARCODE.TabIndex = 0;
			this.rdo1DBARCODE.TabStop = true;
			this.rdo1DBARCODE.Text = "1D Barcode";
			this.rdo1DBARCODE.UseVisualStyleBackColor = true;
			this.rdo2DQRCODE.AutoSize = true;
			this.rdo2DQRCODE.Location = new System.Drawing.Point(107, 3);
			this.rdo2DQRCODE.Name = "rdo2DQRCODE";
			this.rdo2DQRCODE.Size = new System.Drawing.Size(102, 20);
			this.rdo2DQRCODE.TabIndex = 1;
			this.rdo2DQRCODE.TabStop = true;
			this.rdo2DQRCODE.Text = "2D QR Code";
			this.rdo2DQRCODE.UseVisualStyleBackColor = true;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 121);
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
			this.btnClose.TabIndex = 20;
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
			this.btnPRINT.TabIndex = 19;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(411, 42);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(25, 16);
			this.Label5.TabIndex = 51;
			this.Label5.Text = "To";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 42);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(69, 16);
			this.Label6.TabIndex = 52;
			this.Label6.Text = "Item Code";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(411, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(25, 16);
			this.Label2.TabIndex = 49;
			this.Label2.Text = "To";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 9);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(66, 16);
			this.Label21.TabIndex = 49;
			this.Label21.Text = "Category ";
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(442, 37);
			this.cbITMCDTO.Name = "cbITMCDTO";
			this.cbITMCDTO.SelectedIndex = -1;
			this.cbITMCDTO.SelectedItem = null;
			this.cbITMCDTO.SelectedValue = null;
			this.cbITMCDTO.Size = new System.Drawing.Size(328, 27);
			this.cbITMCDTO.TabIndex = 3;
			this.cbITMCDTO.TextMultiline = true;
			this.cbITMCDTO.ValueMember = null;
			this.cbITMCDTO.WhereClause = null;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1370, 631);
			this.Panel1.TabIndex = 20;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAPITM_BAR";
			base.Tag = "MAPITM_BAR";
			this.Text = "Print Item Barcode";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmMAPITM_BAR_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAPITM_BAR_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Panel1.Visible = true;
		}

		private void BindComboHeader()
		{
			cbCATCDFR.DataTable = "MACOD_TBL WITH (NOLOCK) ";
			cbCATCDFR.WhereClause = "MACOD_CTYID = 'CATCD'";
			cbCATCDFR.ValueMember = "MACOD_CODID";
			cbCATCDFR.DisplayMember = "MACOD_CODNM";
			cbCATCDFR.LoadData();
			cbCATCDTO.DataTable = "MACOD_TBL WITH (NOLOCK) ";
			cbCATCDTO.WhereClause = "MACOD_CTYID = 'CATCD'";
			cbCATCDTO.ValueMember = "MACOD_CODID";
			cbCATCDTO.DisplayMember = "MACOD_CODNM";
			cbCATCDTO.LoadData();
			cbITMCDFR.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbITMCDFR.ValueMember = "MAITM_ITMCD";
			cbITMCDFR.DisplayMember = "MAITM_DESC";
			cbITMCDFR.LoadData();
			cbITMCDTO.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbITMCDTO.ValueMember = "MAITM_ITMCD";
			cbITMCDTO.DisplayMember = "MAITM_DESC";
			cbITMCDTO.LoadData();
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			GenerateQRCode();
			frmRPT.ReportName = "Print Item Barcode";
			if (rdo1DBARCODE.Checked)
			{
				frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMAPITM_BAR1.rpt";
			}
			if (rdo2DQRCODE.Checked)
			{
				frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMAPITM_BAR2.rpt";
			}
			frmRPT.Params = ("@COMPNM=" + MyProject.Computer.Name) ?? "";
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='Print Item Barcode',gintQTYDS='" + PublicVar.gintQTYDS + "',gintAMTDS='" + PublicVar.gintAMTDS + "',gintPRCDS='" + PublicVar.gintPRCDS + "'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void GenerateQRCode()
		{
			string strSQL = "EXEC spMAPITM_INSERT ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCATCDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCATCDTO.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCDTO.SelectedValue), "'")));
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
			DataTable dt = DB.ExecProc("SELECT CATCD, ITMCD FROM MAPITM_BAR WHERE COMPNM = '" + MyProject.Computer.Name + "'");
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					QRCodeGenerator qrcode = new QRCodeGenerator();
					string strCATCD = dt.Rows[i]["CATCD"].ToString();
					string strITMCD = dt.Rows[i]["ITMCD"].ToString();
					byte[] imgQRCODE = Common.ImageToByte2(qrcode.CreateQrCode(Conversions.ToString(dt.Rows[i]["ITMCD"]), QRCodeGenerator.ECCLevel.L).GetGraphic(2));
					try
					{
						OleDbCommand cmd = new OleDbCommand();
						cmd.Connection = DB.GetDBConnection();
						strSQL = "spMAPITM_GENERATEBARCODE";
						cmd.CommandText = strSQL;
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.Add("@PRNID", OleDbType.VarChar, 30).Value = MyProject.Computer.Name;
						cmd.Parameters.Add("@CATCD", OleDbType.VarChar, 30).Value = strCATCD;
						cmd.Parameters.Add("@ITMCD", OleDbType.VarChar, 30).Value = strITMCD;
						cmd.Parameters.Add("@QRCODE", OleDbType.VarBinary, -1).Value = imgQRCODE;
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

		private void cbCATCDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbCATCDFR.SelectedIndex != -1)
			{
				cbCATCDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbCATCDFR.SelectedValue);
			}
		}

		private void cbITMCDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbITMCDFR.SelectedIndex != -1)
			{
				cbITMCDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbITMCDFR.SelectedValue);
			}
		}
	}
}
