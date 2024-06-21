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
	public class frmPCRPCO : Form
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
		[AccessedThroughProperty("cbSUPID")]
		private ComboboxControl _cbSUPID;

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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbSUPID
		{
			[CompilerGenerated]
			get
			{
				return _cbSUPID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbSUPID_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbSUPID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbSUPID = value;
				comboboxControl = _cbSUPID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbITMCDTO")]
		internal virtual ComboboxControl cbITMCDTO
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

		[field: AccessedThroughProperty("cbITMCDFR")]
		internal virtual ComboboxControl cbITMCDFR
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkGRN")]
		internal virtual CheckBox chkGRN
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSTSFG")]
		internal virtual ComboBox cbSTSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCRPCO()
		{
			base.Shown += frmPCRPCO_Shown;
			base.FormClosing += frmPCRPCO_FormClosing;
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
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.chkGRN = new System.Windows.Forms.CheckBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.Label4 = new System.Windows.Forms.Label();
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.Label3 = new System.Windows.Forms.Label();
			this.cbSUPID = new IMS.ComboboxControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbSTSFG = new System.Windows.Forms.ComboBox();
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
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCDTO, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCDFR, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbSUPID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbDOCNOTO, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbDOCNOFR, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbSTSFG, 1, 4);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 7;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(789, 229);
			this.TableLayoutPanel1.TabIndex = 0;
			this.TableLayoutPanel2.ColumnCount = 1;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Controls.Add(this.chkGRN, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(99, 93);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(133, 25);
			this.TableLayoutPanel2.TabIndex = 54;
			this.chkGRN.AutoSize = true;
			this.chkGRN.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkGRN.Location = new System.Drawing.Point(3, 3);
			this.chkGRN.Name = "chkGRN";
			this.chkGRN.Size = new System.Drawing.Size(123, 20);
			this.chkGRN.TabIndex = 0;
			this.chkGRN.Text = "Good Received";
			this.chkGRN.UseVisualStyleBackColor = true;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 128);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(45, 16);
			this.Label5.TabIndex = 64;
			this.Label5.Text = "Status";
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(461, 62);
			this.cbITMCDTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCDTO.Name = "cbITMCDTO";
			this.cbITMCDTO.SelectedIndex = -1;
			this.cbITMCDTO.SelectedItem = null;
			this.cbITMCDTO.SelectedValue = null;
			this.cbITMCDTO.Size = new System.Drawing.Size(325, 26);
			this.cbITMCDTO.TabIndex = 5;
			this.cbITMCDTO.TextMultiline = true;
			this.cbITMCDTO.ValueMember = null;
			this.cbITMCDTO.WhereClause = null;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(430, 67);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(25, 16);
			this.Label4.TabIndex = 65;
			this.Label4.Text = "To";
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(99, 62);
			this.cbITMCDFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCDFR.Name = "cbITMCDFR";
			this.cbITMCDFR.SelectedIndex = -1;
			this.cbITMCDFR.SelectedItem = null;
			this.cbITMCDFR.SelectedValue = null;
			this.cbITMCDFR.Size = new System.Drawing.Size(325, 26);
			this.cbITMCDFR.TabIndex = 4;
			this.cbITMCDFR.TextMultiline = true;
			this.cbITMCDFR.ValueMember = null;
			this.cbITMCDFR.WhereClause = null;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 67);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(69, 16);
			this.Label3.TabIndex = 63;
			this.Label3.Text = "Item Code";
			this.cbSUPID.BlankValue = null;
			this.cbSUPID.ComboboxWidth = 170;
			this.cbSUPID.DataTable = null;
			this.cbSUPID.DisplayMember = null;
			this.cbSUPID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPID.HasBlankValue = true;
			this.cbSUPID.Location = new System.Drawing.Point(99, 2);
			this.cbSUPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbSUPID.Name = "cbSUPID";
			this.cbSUPID.SelectedIndex = -1;
			this.cbSUPID.SelectedItem = null;
			this.cbSUPID.SelectedValue = null;
			this.cbSUPID.Size = new System.Drawing.Size(325, 26);
			this.cbSUPID.TabIndex = 1;
			this.cbSUPID.TextMultiline = true;
			this.cbSUPID.ValueMember = null;
			this.cbSUPID.WhereClause = null;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 7);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(58, 16);
			this.Label2.TabIndex = 61;
			this.Label2.Text = "Supplier";
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(461, 32);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(325, 26);
			this.cbDOCNOTO.TabIndex = 3;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(99, 32);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(325, 26);
			this.cbDOCNOFR.TabIndex = 2;
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
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 173);
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
			this.btnClose.TabIndex = 7;
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
			this.btnPRINT.TabIndex = 6;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(430, 37);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(25, 16);
			this.Label7.TabIndex = 59;
			this.Label7.Text = "To";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 37);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(90, 16);
			this.Label1.TabIndex = 58;
			this.Label1.Text = "Document No";
			this.cbSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTSFG.FormattingEnabled = true;
			this.cbSTSFG.Location = new System.Drawing.Point(99, 124);
			this.cbSTSFG.Name = "cbSTSFG";
			this.cbSTSFG.Size = new System.Drawing.Size(133, 24);
			this.cbSTSFG.TabIndex = 55;
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
			base.Name = "frmPCRPCO";
			base.Tag = "PCRPCO";
			this.Text = "Purchase Order Status Report";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPCRPCO_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			Panel1.Visible = true;
			BindComboBox();
		}

		private void BindComboBox()
		{
			cbSUPID.DataTable = "MASUP_TBL WITH (NOLOCK) ";
			cbSUPID.ValueMember = "MASUP_SUPID";
			cbSUPID.DisplayMember = "MASUP_SHORT";
			cbSUPID.LoadData();
			string strSQL = "SELECT 0 AS STSFG, '" + Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Pending") + "' AS STSFGNM ";
			strSQL += "UNION ";
			strSQL = strSQL + "SELECT 1 AS STSFG, '" + Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Confirmed") + "' AS STSFGNM ";
			cbSTSFG.ValueMember = "STSFG";
			cbSTSFG.DisplayMember = "STSFGNM";
			Common.RetriveComboItembySQL(strSQL, cbSTSFG);
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "Purchase Order Status Report";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPCRPCO.rpt";
			string strParams = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("@SUPID=", cbSUPID.SelectedValue), ","));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@DOCNOFR=", cbDOCNOFR.SelectedValue), ",")));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@DOCNOTO=", cbDOCNOTO.SelectedValue), ",")));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@ITMCDFR=", cbITMCDFR.SelectedValue), ",")));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@ITMCDTO=", cbITMCDTO.SelectedValue), ",")));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject("@COMFG=", cbSTSFG.SelectedValue)));
			frmRPT.Params = strParams;
			frmRPT.Formulas = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='Purchase Order Status Report',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS + ",GRN=", Interaction.IIf(chkGRN.Checked, 1, 0)), ""));
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPCRPCO_FormClosing(object sender, FormClosingEventArgs e)
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

		private void cbSUPID_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbSUPID.SelectedIndex != -1)
			{
				cbDOCNOFR.DataTable = "PCPCO_TBL WITH (NOLOCK) ";
				cbDOCNOFR.WhereClause = "PCPCO_SUPID = '" + Common.gfValidSQLStr(Conversions.ToString(cbSUPID.SelectedValue)) + "' ";
				cbDOCNOFR.ValueMember = "PCPCO_DOCNO";
				cbDOCNOFR.DisplayMember = "PCPCO_DOCNO";
				cbDOCNOFR.LoadData();
				cbDOCNOTO.DataTable = "PCPCO_TBL WITH (NOLOCK) ";
				cbDOCNOTO.WhereClause = "PCPCO_SUPID = '" + Common.gfValidSQLStr(Conversions.ToString(cbSUPID.SelectedValue)) + "' ";
				cbDOCNOTO.ValueMember = "PCPCO_DOCNO";
				cbDOCNOTO.DisplayMember = "PCPCO_DOCNO";
				cbDOCNOTO.LoadData();
				cbITMCDFR.DataTable = "PCPCO_TBL WITH (NOLOCK) ";
				cbITMCDFR.WhereClause = "PCPCO_SUPID = '" + Common.gfValidSQLStr(Conversions.ToString(cbSUPID.SelectedValue)) + "' ";
				cbITMCDFR.ValueMember = "PCPCO_ITMCD";
				cbITMCDFR.DisplayMember = "PCPCO_ITMCD";
				cbITMCDFR.LoadData();
				cbITMCDTO.DataTable = "PCPCO_TBL WITH (NOLOCK) ";
				cbITMCDTO.WhereClause = "PCPCO_SUPID = '" + Common.gfValidSQLStr(Conversions.ToString(cbSUPID.SelectedValue)) + "' ";
				cbITMCDTO.ValueMember = "PCPCO_ITMCD";
				cbITMCDTO.DisplayMember = "PCPCO_ITMCD";
				cbITMCDTO.LoadData();
			}
		}
	}
}
