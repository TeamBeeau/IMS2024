using System;
using System.ComponentModel;
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
	public class frmSSLORD : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCLOSE")]
		private Button _btnCLOSE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSID")]
		private ComboboxControl _cbCUSID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bgwProgress")]
		private BackgroundWorker _bgwProgress;

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

		[field: AccessedThroughProperty("cbSTSFG")]
		internal virtual ComboBox cbSTSFG
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

		[field: AccessedThroughProperty("cbITMCDFR")]
		internal virtual ComboboxControl cbITMCDFR
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

		internal virtual ComboboxControl cbCUSID
		{
			[CompilerGenerated]
			get
			{
				return _cbCUSID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbCUSID_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbCUSID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbCUSID = value;
				comboboxControl = _cbCUSID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbDOCNOFR")]
		internal virtual ComboboxControl cbDOCNOFR
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
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

		[field: AccessedThroughProperty("chkDO")]
		internal virtual CheckBox chkDO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkWKO")]
		internal virtual CheckBox chkWKO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		public frmSSLORD()
		{
			base.FormClosing += frmSSLORD_FormClosing;
			base.Load += frmSSLORD_Load;
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbSTSFG = new System.Windows.Forms.ComboBox();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbCUSID = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.chkDO = new System.Windows.Forms.CheckBox();
			this.chkWKO = new System.Windows.Forms.CheckBox();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnCLOSE = new System.Windows.Forms.Button();
			this.bgwProgress = new System.ComponentModel.BackgroundWorker();
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
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbSTSFG, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCDTO, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCDFR, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbDOCNOTO, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbCUSID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbDOCNOFR, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 5);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(809, 242);
			this.TableLayoutPanel1.TabIndex = 1;
			this.cbSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTSFG.FormattingEnabled = true;
			this.cbSTSFG.Location = new System.Drawing.Point(99, 121);
			this.cbSTSFG.Name = "cbSTSFG";
			this.cbSTSFG.Size = new System.Drawing.Size(133, 24);
			this.cbSTSFG.TabIndex = 53;
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(466, 60);
			this.cbITMCDTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbITMCDTO.Name = "cbITMCDTO";
			this.cbITMCDTO.SelectedIndex = -1;
			this.cbITMCDTO.SelectedItem = null;
			this.cbITMCDTO.SelectedValue = null;
			this.cbITMCDTO.Size = new System.Drawing.Size(328, 25);
			this.cbITMCDTO.TabIndex = 54;
			this.cbITMCDTO.TextMultiline = true;
			this.cbITMCDTO.ValueMember = null;
			this.cbITMCDTO.WhereClause = null;
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(100, 60);
			this.cbITMCDFR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbITMCDFR.Name = "cbITMCDFR";
			this.cbITMCDFR.SelectedIndex = -1;
			this.cbITMCDFR.SelectedItem = null;
			this.cbITMCDFR.SelectedValue = null;
			this.cbITMCDFR.Size = new System.Drawing.Size(327, 25);
			this.cbITMCDFR.TabIndex = 13;
			this.cbITMCDFR.TextMultiline = true;
			this.cbITMCDFR.ValueMember = null;
			this.cbITMCDFR.WhereClause = null;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(465, 31);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(329, 25);
			this.cbDOCNOTO.TabIndex = 11;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbCUSID.BlankValue = null;
			this.cbCUSID.ComboboxWidth = 170;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = true;
			this.cbCUSID.Location = new System.Drawing.Point(99, 2);
			this.cbCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(328, 25);
			this.cbCUSID.TabIndex = 53;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(99, 31);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(328, 25);
			this.cbDOCNOFR.TabIndex = 12;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(434, 35);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(25, 16);
			this.Label2.TabIndex = 6;
			this.Label2.Text = "To";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 125);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(45, 16);
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Status";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 64);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(69, 16);
			this.Label8.TabIndex = 6;
			this.Label8.Text = "Item Code";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 35);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "Document No";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 6);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(81, 16);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "Customer ID";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(434, 64);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 16);
			this.Label3.TabIndex = 9;
			this.Label3.Text = "To";
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.chkDO, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.chkWKO, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(99, 90);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25f));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(200, 25);
			this.TableLayoutPanel3.TabIndex = 2;
			this.chkDO.AutoSize = true;
			this.chkDO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkDO.Location = new System.Drawing.Point(105, 3);
			this.chkDO.Name = "chkDO";
			this.chkDO.Size = new System.Drawing.Size(47, 20);
			this.chkDO.TabIndex = 1;
			this.chkDO.Text = "DO";
			this.chkDO.UseVisualStyleBackColor = true;
			this.chkWKO.AutoSize = true;
			this.chkWKO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkWKO.Location = new System.Drawing.Point(3, 3);
			this.chkWKO.Name = "chkWKO";
			this.chkWKO.Size = new System.Drawing.Size(96, 20);
			this.chkWKO.TabIndex = 0;
			this.chkWKO.Text = "Work Order";
			this.chkWKO.UseVisualStyleBackColor = true;
			this.TableLayoutPanel2.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 3);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.btnPRINT, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.btnCLOSE, 1, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 151);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(260, 58);
			this.TableLayoutPanel2.TabIndex = 1;
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
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmSSLORD";
			base.Tag = "SSLORD";
			this.Text = "Sales Order Status Report";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void frmSSLORD_FormClosing(object sender, FormClosingEventArgs e)
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
			string strParams = string.Empty;
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "SALES ORDER STATUS REPORT";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptSSLORD.rpt";
			strParams = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("@CUSID=", cbCUSID.SelectedValue), ","));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@DOCNOFR=", cbDOCNOFR.SelectedValue), ",")));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@DOCNOTO=", cbDOCNOTO.SelectedValue), ",")));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@ITMCDFR=", cbITMCDFR.SelectedValue), ",")));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@ITMCDTO=", cbITMCDTO.SelectedValue), ",")));
			strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject("@STSFG=", cbSTSFG.SelectedValue)));
			frmRPT.Params = strParams;
			frmRPT.Formulas = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='SALES ORDER STATUS REPORT',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS + ",WKO=", Interaction.IIf(chkWKO.Checked, 1, 0)), ",DO="), Interaction.IIf(chkDO.Checked, 1, 0)), ""));
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnEXCEL_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bgwProgress.RunWorkerAsync();
		}

		private void bgwProgress_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		private void bgwProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Cursor = Cursors.Default;
		}

		private void frmSSLORD_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
		}

		private void BindComboHeader()
		{
			cbCUSID.DataTable = "SLORD_TBL WITH (NOLOCK) LEFT JOIN MACUS_TBL WITH (NOLOCK) ON MACUS_CUSID = SLORD_CUSID ";
			cbCUSID.ValueMember = "MACUS_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			cbCUSID.LoadData();
			string strSQL = "SELECT 0 AS STSFG, 'Pending' AS STSFGNM ";
			strSQL += "UNION ";
			strSQL += "SELECT 1 AS STSFG, 'Completed' AS STSFGNM ";
			strSQL += "UNION ";
			strSQL += "SELECT 2 AS STSFG, 'Invoiced' AS STSFGNM ";
			cbSTSFG.ValueMember = "STSFG";
			cbSTSFG.DisplayMember = "STSFGNM";
			Common.RetriveComboItembySQL(strSQL, cbSTSFG);
		}

		private void cbCUSID_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbCUSID.SelectedIndex != -1)
			{
				cbDOCNOFR.DataTable = "SLORD_TBL WITH (NOLOCK)";
				cbDOCNOFR.WhereClause = "SLORD_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
				cbDOCNOFR.ValueMember = "SLORD_DOCNO";
				cbDOCNOFR.DisplayMember = "SLORD_DOCNO";
				cbDOCNOFR.LoadData();
				cbDOCNOTO.DataTable = "SLORD_TBL WITH (NOLOCK)";
				cbDOCNOTO.WhereClause = "SLORD_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
				cbDOCNOTO.ValueMember = "SLORD_DOCNO";
				cbDOCNOTO.DisplayMember = "SLORD_DOCNO";
				cbDOCNOTO.LoadData();
				cbITMCDFR.DataTable = "SLORD_TBL WITH (NOLOCK)";
				cbITMCDFR.WhereClause = "SLORD_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
				cbITMCDFR.ValueMember = "SLORD_ITMCD";
				cbITMCDFR.DisplayMember = "SLORD_ITMCD";
				cbITMCDFR.LoadData();
				cbITMCDTO.DataTable = "SLORD_TBL WITH (NOLOCK)";
				cbITMCDTO.WhereClause = "SLORD_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
				cbITMCDTO.ValueMember = "SLORD_ITMCD";
				cbITMCDTO.DisplayMember = "SLORD_ITMCD";
				cbITMCDTO.LoadData();
			}
		}

		private void btnCLOSE_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
