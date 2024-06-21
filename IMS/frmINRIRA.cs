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
	public class frmINRIRA : Form
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
		[AccessedThroughProperty("cbRACKNOFR")]
		private ComboboxControl _cbRACKNOFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCATCDFR")]
		private ComboboxControl _cbCATCDFR;

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

		[field: AccessedThroughProperty("cbRACKNOTO")]
		internal virtual ComboboxControl cbRACKNOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCATCDTO")]
		internal virtual ComboboxControl cbCATCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbRACKNOFR
		{
			[CompilerGenerated]
			get
			{
				return _cbRACKNOFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbRACKNOFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbRACKNOFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbRACKNOFR = value;
				comboboxControl = _cbRACKNOFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
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

		public frmINRIRA()
		{
			base.Shown += frmINRIRA_Shown;
			base.FormClosing += frmINRIRA_FormClosing;
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
			this.cbRACKNOTO = new IMS.ComboboxControl();
			this.cbCATCDTO = new IMS.ComboboxControl();
			this.cbRACKNOFR = new IMS.ComboboxControl();
			this.cbCATCDFR = new IMS.ComboboxControl();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
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
			this.TableLayoutPanel1.Controls.Add(this.cbRACKNOTO, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbCATCDTO, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbRACKNOFR, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbCATCDFR, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 4;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(796, 143);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbRACKNOTO.BlankValue = null;
			this.cbRACKNOTO.ComboboxWidth = 170;
			this.cbRACKNOTO.DataTable = null;
			this.cbRACKNOTO.DisplayMember = null;
			this.cbRACKNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRACKNOTO.HasBlankValue = true;
			this.cbRACKNOTO.Location = new System.Drawing.Point(465, 35);
			this.cbRACKNOTO.Name = "cbRACKNOTO";
			this.cbRACKNOTO.SelectedIndex = -1;
			this.cbRACKNOTO.SelectedItem = null;
			this.cbRACKNOTO.SelectedValue = null;
			this.cbRACKNOTO.Size = new System.Drawing.Size(327, 27);
			this.cbRACKNOTO.TabIndex = 3;
			this.cbRACKNOTO.TextMultiline = true;
			this.cbRACKNOTO.ValueMember = null;
			this.cbRACKNOTO.WhereClause = null;
			this.cbCATCDTO.BlankValue = null;
			this.cbCATCDTO.ComboboxWidth = 170;
			this.cbCATCDTO.DataTable = null;
			this.cbCATCDTO.DisplayMember = null;
			this.cbCATCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCATCDTO.HasBlankValue = true;
			this.cbCATCDTO.Location = new System.Drawing.Point(465, 3);
			this.cbCATCDTO.Name = "cbCATCDTO";
			this.cbCATCDTO.SelectedIndex = -1;
			this.cbCATCDTO.SelectedItem = null;
			this.cbCATCDTO.SelectedValue = null;
			this.cbCATCDTO.Size = new System.Drawing.Size(328, 26);
			this.cbCATCDTO.TabIndex = 2;
			this.cbCATCDTO.TextMultiline = true;
			this.cbCATCDTO.ValueMember = null;
			this.cbCATCDTO.WhereClause = null;
			this.cbRACKNOFR.BlankValue = null;
			this.cbRACKNOFR.ComboboxWidth = 170;
			this.cbRACKNOFR.DataTable = null;
			this.cbRACKNOFR.DisplayMember = null;
			this.cbRACKNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRACKNOFR.HasBlankValue = true;
			this.cbRACKNOFR.Location = new System.Drawing.Point(100, 35);
			this.cbRACKNOFR.Name = "cbRACKNOFR";
			this.cbRACKNOFR.SelectedIndex = -1;
			this.cbRACKNOFR.SelectedItem = null;
			this.cbRACKNOFR.SelectedValue = null;
			this.cbRACKNOFR.Size = new System.Drawing.Size(327, 27);
			this.cbRACKNOFR.TabIndex = 2;
			this.cbRACKNOFR.TextMultiline = true;
			this.cbRACKNOFR.ValueMember = null;
			this.cbRACKNOFR.WhereClause = null;
			this.cbCATCDFR.BlankValue = null;
			this.cbCATCDFR.ComboboxWidth = 170;
			this.cbCATCDFR.DataTable = null;
			this.cbCATCDFR.DisplayMember = null;
			this.cbCATCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCATCDFR.HasBlankValue = true;
			this.cbCATCDFR.Location = new System.Drawing.Point(100, 3);
			this.cbCATCDFR.Name = "cbCATCDFR";
			this.cbCATCDFR.SelectedIndex = -1;
			this.cbCATCDFR.SelectedItem = null;
			this.cbCATCDFR.SelectedValue = null;
			this.cbCATCDFR.Size = new System.Drawing.Size(328, 26);
			this.cbCATCDFR.TabIndex = 1;
			this.cbCATCDFR.TextMultiline = true;
			this.cbCATCDFR.ValueMember = null;
			this.cbCATCDFR.WhereClause = null;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 87);
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
			this.Label7.Location = new System.Drawing.Point(434, 8);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(25, 16);
			this.Label7.TabIndex = 59;
			this.Label7.Text = "To";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 16);
			this.Label1.TabIndex = 58;
			this.Label1.Text = "Item Category";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(434, 40);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(25, 16);
			this.Label5.TabIndex = 51;
			this.Label5.Text = "To";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 40);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(61, 16);
			this.Label6.TabIndex = 52;
			this.Label6.Text = "Rack No";
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
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
			base.Name = "frmINRIRA";
			base.Tag = "INRIRA";
			this.Text = "Item-Rack Allocation List";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmINRIRA_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Panel1.Visible = true;
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "ITEM - RACK ALLOCATION LIST";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptINIRA.rpt";
			frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@CATCDFR=", cbCATCDFR.SelectedValue), ",@CATCDTO="), cbCATCDTO.SelectedValue), ",@RACKNOFR="), cbRACKNOFR.SelectedValue), ",@RACKNOTO="), cbRACKNOTO.SelectedValue), ""));
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='ITEM - RACK ALLOCATION LIST',gintQTYDS='" + PublicVar.gintQTYDS + "',gintAMTDS='" + PublicVar.gintAMTDS + "',gintPRCDS='" + PublicVar.gintPRCDS + "'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmINRIRA_FormClosing(object sender, FormClosingEventArgs e)
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

		private void BindComboHeader()
		{
			cbCATCDFR.DataTable = "MAITM_TBL WITH (NOLOCK) LEFT JOIN MACOD_TBL WITH (NOLOCK) ON MACOD_CTYID = 'CATCD' AND MACOD_CODID = MAITM_CATCD ";
			cbCATCDFR.ValueMember = "MAITM_CATCD";
			cbCATCDFR.DisplayMember = "MACOD_CODNM";
			cbCATCDFR.LoadData();
			cbCATCDTO.DataTable = "MAITM_TBL WITH (NOLOCK) LEFT JOIN MACOD_TBL WITH (NOLOCK) ON MACOD_CTYID = 'CATCD' AND MACOD_CODID = MAITM_CATCD ";
			cbCATCDTO.ValueMember = "MAITM_CATCD";
			cbCATCDTO.DisplayMember = "MACOD_CODNM";
			cbCATCDTO.LoadData();
			cbRACKNOFR.DataTable = "MAITM_TBL WITH (NOLOCK) LEFT JOIN MACOD_TBL WITH (NOLOCK) ON MACOD_CTYID = 'RACKNO' AND MACOD_CODID = MAITM_RACKNO ";
			cbRACKNOFR.ValueMember = "MAITM_RACKNO";
			cbRACKNOFR.DisplayMember = "MACOD_CODNM";
			cbRACKNOFR.LoadData();
			cbRACKNOTO.DataTable = "MAITM_TBL WITH (NOLOCK) LEFT JOIN MACOD_TBL WITH (NOLOCK) ON MACOD_CTYID = 'RACKNO' AND MACOD_CODID = MAITM_RACKNO ";
			cbRACKNOTO.ValueMember = "MAITM_RACKNO";
			cbRACKNOTO.DisplayMember = "MACOD_CODNM";
			cbRACKNOTO.LoadData();
		}

		private void cbCATCDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbCATCDFR.SelectedIndex != -1)
			{
				cbCATCDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbCATCDFR.SelectedValue);
			}
		}

		private void cbRACKNOFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbRACKNOFR.SelectedIndex != -1)
			{
				cbRACKNOTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbRACKNOFR.SelectedValue);
			}
		}
	}
}
