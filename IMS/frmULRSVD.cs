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
	public class frmULRSVD : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private Button _btnPRINTFR;

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
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

		internal virtual Button btnPRINTFR
		{
			[CompilerGenerated]
			get
			{
				return _btnPRINTFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPRINTFR_Click;
				Button button = _btnPRINTFR;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPRINTFR = value;
				button = _btnPRINTFR;
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

		[field: AccessedThroughProperty("cbITMCDTO")]
		internal virtual ComboboxControl cbITMCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbLOCIDTO")]
		internal virtual ComboboxControl cbLOCIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbLOCIDFR")]
		internal virtual ComboboxControl cbLOCIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
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

		[field: AccessedThroughProperty("Label17")]
		internal virtual Label Label17
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

		[field: AccessedThroughProperty("lblCUSIDFR")]
		internal virtual Label lblCUSIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label16")]
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpCURDT")]
		internal virtual DateTimePicker dtpCURDT
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

		[field: AccessedThroughProperty("cbBRAND")]
		internal virtual ComboBox cbBRAND
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

		[field: AccessedThroughProperty("cbGRPCD")]
		internal virtual ComboBox cbGRPCD
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

		public frmULRSVD()
		{
			base.FormClosing += frmULRSVD_FormClosing;
			base.Load += frmULRSVD_Load;
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
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.cbGRPCD = new System.Windows.Forms.ComboBox();
			this.cbBRAND = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.cbLOCIDTO = new IMS.ComboboxControl();
			this.cbLOCIDFR = new IMS.ComboboxControl();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.dtpCURDT = new System.Windows.Forms.DateTimePicker();
			this.cbCATCD = new System.Windows.Forms.ComboBox();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(1, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 630);
			this.Panel2.TabIndex = 3;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 2;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 0, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 189);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel4.TabIndex = 9;
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
			this.btnClose.TabIndex = 13;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(3, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTFR.TabIndex = 12;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbITMCDFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbGRPCD, 1, 5);
			this.TableLayoutPanel2.Controls.Add(this.cbBRAND, 1, 4);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 0, 5);
			this.TableLayoutPanel2.Controls.Add(this.Label3, 0, 4);
			this.TableLayoutPanel2.Controls.Add(this.cbITMCDTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCIDTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label10, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label6, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.dtpCURDT, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbCATCD, 1, 3);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 6;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(795, 177);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(109, 59);
			this.cbITMCDFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbITMCDFR.Name = "cbITMCDFR";
			this.cbITMCDFR.SelectedIndex = -1;
			this.cbITMCDFR.SelectedItem = null;
			this.cbITMCDFR.SelectedValue = null;
			this.cbITMCDFR.Size = new System.Drawing.Size(324, 25);
			this.cbITMCDFR.TabIndex = 55;
			this.cbITMCDFR.TextMultiline = true;
			this.cbITMCDFR.ValueMember = null;
			this.cbITMCDFR.WhereClause = null;
			this.cbGRPCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGRPCD.FormattingEnabled = true;
			this.cbGRPCD.Location = new System.Drawing.Point(110, 150);
			this.cbGRPCD.Name = "cbGRPCD";
			this.cbGRPCD.Size = new System.Drawing.Size(133, 24);
			this.cbGRPCD.TabIndex = 10;
			this.cbBRAND.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBRAND.FormattingEnabled = true;
			this.cbBRAND.Location = new System.Drawing.Point(110, 120);
			this.cbBRAND.Name = "cbBRAND";
			this.cbBRAND.Size = new System.Drawing.Size(133, 24);
			this.cbBRAND.TabIndex = 11;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 154);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(73, 16);
			this.Label1.TabIndex = 10;
			this.Label1.Text = "Item Group";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 124);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(72, 16);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "Item Brand";
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(469, 59);
			this.cbITMCDTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbITMCDTO.Name = "cbITMCDTO";
			this.cbITMCDTO.SelectedIndex = -1;
			this.cbITMCDTO.SelectedItem = null;
			this.cbITMCDTO.SelectedValue = null;
			this.cbITMCDTO.Size = new System.Drawing.Size(323, 26);
			this.cbITMCDTO.TabIndex = 55;
			this.cbITMCDTO.TextMultiline = true;
			this.cbITMCDTO.ValueMember = null;
			this.cbITMCDTO.WhereClause = null;
			this.cbLOCIDTO.BlankValue = null;
			this.cbLOCIDTO.ComboboxWidth = 170;
			this.cbLOCIDTO.DataTable = null;
			this.cbLOCIDTO.DisplayMember = null;
			this.cbLOCIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCIDTO.HasBlankValue = true;
			this.cbLOCIDTO.Location = new System.Drawing.Point(469, 30);
			this.cbLOCIDTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbLOCIDTO.Name = "cbLOCIDTO";
			this.cbLOCIDTO.SelectedIndex = -1;
			this.cbLOCIDTO.SelectedItem = null;
			this.cbLOCIDTO.SelectedValue = null;
			this.cbLOCIDTO.Size = new System.Drawing.Size(324, 25);
			this.cbLOCIDTO.TabIndex = 54;
			this.cbLOCIDTO.TextMultiline = true;
			this.cbLOCIDTO.ValueMember = null;
			this.cbLOCIDTO.WhereClause = null;
			this.cbLOCIDFR.BlankValue = null;
			this.cbLOCIDFR.ComboboxWidth = 170;
			this.cbLOCIDFR.DataTable = null;
			this.cbLOCIDFR.DisplayMember = null;
			this.cbLOCIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCIDFR.HasBlankValue = true;
			this.cbLOCIDFR.Location = new System.Drawing.Point(109, 30);
			this.cbLOCIDFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbLOCIDFR.Name = "cbLOCIDFR";
			this.cbLOCIDFR.SelectedIndex = -1;
			this.cbLOCIDFR.SelectedItem = null;
			this.cbLOCIDFR.SelectedValue = null;
			this.cbLOCIDFR.Size = new System.Drawing.Size(325, 25);
			this.cbLOCIDFR.TabIndex = 53;
			this.cbLOCIDFR.TextMultiline = true;
			this.cbLOCIDFR.ValueMember = null;
			this.cbLOCIDFR.WhereClause = null;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(439, 64);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(25, 16);
			this.Label10.TabIndex = 47;
			this.Label10.Text = "To";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 64);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(69, 16);
			this.Label6.TabIndex = 48;
			this.Label6.Text = "Item Code";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 34);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(75, 16);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Location ID";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(439, 34);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 16);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 94);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(91, 16);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Item Category";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 6);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.dtpCURDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpCURDT.CustomFormat = "MMM yyyy";
			this.dtpCURDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtpCURDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCURDT.Location = new System.Drawing.Point(110, 3);
			this.dtpCURDT.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
			this.dtpCURDT.Name = "dtpCURDT";
			this.dtpCURDT.Size = new System.Drawing.Size(120, 22);
			this.dtpCURDT.TabIndex = 10;
			this.cbCATCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCATCD.FormattingEnabled = true;
			this.cbCATCD.Location = new System.Drawing.Point(110, 90);
			this.cbCATCD.Name = "cbCATCD";
			this.cbCATCD.Size = new System.Drawing.Size(133, 24);
			this.cbCATCD.TabIndex = 10;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmULRSVD";
			base.Tag = "ULRSVD";
			this.Text = "Stock Value Details";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmULRSVD_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmULRSVD_Load(object sender, EventArgs e)
		{
			BindComboBox();
		}

		private void BindComboBox()
		{
			cbITMCDFR.DataTable = "MAITM_TBL  WITH (NOLOCK) ";
			cbITMCDFR.WhereClause = "MAITM_ITMTY = '0' AND MAITM_ACTFG = -1";
			cbITMCDFR.ValueMember = "MAITM_ITMCD";
			cbITMCDFR.DisplayMember = "MAITM_ITMCD";
			cbITMCDFR.LoadData();
			cbITMCDTO.DataTable = "MAITM_TBL  WITH (NOLOCK) ";
			cbITMCDTO.WhereClause = "MAITM_ITMTY = '0' AND MAITM_ACTFG = -1";
			cbITMCDTO.ValueMember = "MAITM_ITMCD";
			cbITMCDTO.DisplayMember = "MAITM_ITMCD";
			cbITMCDTO.LoadData();
			cbLOCIDFR.DataTable = "MALOC_TBL WITH (NOLOCK)";
			cbLOCIDFR.WhereClause = "MALOC_ACTFG = -1 ";
			cbLOCIDFR.ValueMember = "MALOC_LOCID";
			cbLOCIDFR.DisplayMember = "MALOC_LOCNM";
			cbLOCIDFR.LoadData();
			cbLOCIDTO.DataTable = "MALOC_TBL WITH (NOLOCK)";
			cbLOCIDTO.WhereClause = "MALOC_ACTFG = -1 ";
			cbLOCIDTO.ValueMember = "MALOC_LOCID";
			cbLOCIDTO.DisplayMember = "MALOC_LOCNM";
			cbLOCIDTO.LoadData();
			string strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'BRAND' ORDER BY MACOD_CODID";
			cbBRAND.ValueMember = "MACOD_CODID";
			cbBRAND.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbBRAND);
			strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'GRPCD' ORDER BY MACOD_CODID";
			cbGRPCD.ValueMember = "MACOD_CODID";
			cbGRPCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbGRPCD);
			strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'CATCD' ORDER BY MACOD_CODID";
			cbCATCD.ValueMember = "MACOD_CODID";
			cbCATCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCATCD);
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "STOCK VALUE DETAILS";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptULRSVD.rpt";
			frmRPT.Params = ("@PYEAR=" + Conversions.ToString(dtpCURDT.Value.Year) + ",@PMTH=" + Conversions.ToString(dtpCURDT.Value.Month) + ",@LOCCD1=" + Common.gfValidSQLStr(Conversions.ToString(cbLOCIDFR.SelectedValue)) + ",@LOCCD2=" + Common.gfValidSQLStr(Conversions.ToString(cbLOCIDTO.SelectedValue)) + ",@ITMCD1=" + Common.gfValidSQLStr(Conversions.ToString(cbITMCDFR.SelectedValue)) + ",@ITMCD2=" + Common.gfValidSQLStr(Conversions.ToString(cbITMCDTO.SelectedValue)) + ",@CATCD=" + Common.gfValidSQLStr(Conversions.ToString(cbCATCD.SelectedValue)) + ",@BRAND=" + Common.gfValidSQLStr(Conversions.ToString(cbBRAND.SelectedValue)) + ",@GRPCD=" + Common.gfValidSQLStr(Conversions.ToString(cbGRPCD.SelectedValue))) ?? "";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='STOCK VALUE DETAILS',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}
	}
}
