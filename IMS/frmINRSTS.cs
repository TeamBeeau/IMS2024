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
	public class frmINRSTS : Form
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
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

		[field: AccessedThroughProperty("lkpITMCDTO")]
		internal virtual LookupControl lkpITMCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpITMCDFR")]
		internal virtual LookupControl lkpITMCDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpLOCIDTO")]
		internal virtual LookupControl lkpLOCIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpLOCIDFR")]
		internal virtual LookupControl lkpLOCIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpDOCDTTO")]
		internal virtual DateTimePicker dtpDOCDTTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpDOCDTFR")]
		internal virtual DateTimePicker dtpDOCDTFR
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

		[field: AccessedThroughProperty("lkpCATCDFR")]
		internal virtual LookupControl lkpCATCDFR
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

		[field: AccessedThroughProperty("lkpCATCDTO")]
		internal virtual LookupControl lkpCATCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("radALL")]
		internal virtual RadioButton radALL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("radSAFETY")]
		internal virtual RadioButton radSAFETY
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpMDLCD")]
		internal virtual LookupControl lkpMDLCD
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

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpITMDESCFR")]
		internal virtual LookupControl lkpITMDESCFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpITMDESCTO")]
		internal virtual LookupControl lkpITMDESCTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("radNONZERO")]
		internal virtual RadioButton radNONZERO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmINRSTS()
		{
			base.FormClosing += frmINRSTS_FormClosing;
			base.Shown += frmINRSTS_Shown;
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
			this.lkpITMDESCTO = new IMS.LookupControl();
			this.lkpITMDESCFR = new IMS.LookupControl();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.lkpMDLCD = new IMS.LookupControl();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.Label8 = new System.Windows.Forms.Label();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.radNONZERO = new System.Windows.Forms.RadioButton();
			this.radSAFETY = new System.Windows.Forms.RadioButton();
			this.radALL = new System.Windows.Forms.RadioButton();
			this.Label7 = new System.Windows.Forms.Label();
			this.lkpCATCDFR = new IMS.LookupControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lkpITMCDTO = new IMS.LookupControl();
			this.lkpITMCDFR = new IMS.LookupControl();
			this.lkpLOCIDTO = new IMS.LookupControl();
			this.lkpLOCIDFR = new IMS.LookupControl();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.lkpCATCDTO = new IMS.LookupControl();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.lkpITMDESCTO, 3, 3);
			this.TableLayoutPanel1.Controls.Add(this.lkpITMDESCFR, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 2, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lkpMDLCD, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.lkpCATCDFR, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDTTO, 3, 5);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDTFR, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.lkpITMCDTO, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.lkpITMCDFR, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.lkpLOCIDTO, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.lkpLOCIDFR, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label21, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lkpCATCDTO, 3, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 9;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(859, 283);
			this.TableLayoutPanel1.TabIndex = 0;
			this.lkpITMDESCTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMDESCTO.AllowBlank = false;
			this.lkpITMDESCTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpITMDESCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpITMDESCTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpITMDESCTO.DescriptionVisible1 = true;
			this.lkpITMDESCTO.DescriptionVisible2 = false;
			this.lkpITMDESCTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMDESCTO.KeyValue = "";
			this.lkpITMDESCTO.LKPCD = "ITMDESC";
			this.lkpITMDESCTO.Location = new System.Drawing.Point(503, 90);
			this.lkpITMDESCTO.MaxLength = 0;
			this.lkpITMDESCTO.Modified = false;
			this.lkpITMDESCTO.Multiline_ = false;
			this.lkpITMDESCTO.Name = "lkpITMDESCTO";
			this.lkpITMDESCTO.PasswordChar = "\0";
			this.lkpITMDESCTO.ReadOnly_ = false;
			this.lkpITMDESCTO.Size = new System.Drawing.Size(353, 23);
			this.lkpITMDESCTO.TabIndex = 8;
			this.lkpITMDESCTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpITMDESCTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpITMDESCTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpITMDESCTO.TextHeight = 23;
			this.lkpITMDESCTO.TextWidth = 130;
			this.lkpITMDESCTO.Where1 = null;
			this.lkpITMDESCFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMDESCFR.AllowBlank = false;
			this.lkpITMDESCFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpITMDESCFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpITMDESCFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpITMDESCFR.DescriptionVisible1 = true;
			this.lkpITMDESCFR.DescriptionVisible2 = false;
			this.lkpITMDESCFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMDESCFR.KeyValue = "";
			this.lkpITMDESCFR.LKPCD = "ITMDESC";
			this.lkpITMDESCFR.Location = new System.Drawing.Point(113, 90);
			this.lkpITMDESCFR.MaxLength = 0;
			this.lkpITMDESCFR.Modified = false;
			this.lkpITMDESCFR.Multiline_ = false;
			this.lkpITMDESCFR.Name = "lkpITMDESCFR";
			this.lkpITMDESCFR.PasswordChar = "\0";
			this.lkpITMDESCFR.ReadOnly_ = false;
			this.lkpITMDESCFR.Size = new System.Drawing.Size(353, 23);
			this.lkpITMDESCFR.TabIndex = 7;
			this.lkpITMDESCFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpITMDESCFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpITMDESCFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpITMDESCFR.TextHeight = 23;
			this.lkpITMDESCFR.TextWidth = 130;
			this.lkpITMDESCFR.Where1 = null;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(472, 93);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(25, 16);
			this.Label10.TabIndex = 62;
			this.Label10.Text = "To";
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 93);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(104, 16);
			this.Label9.TabIndex = 61;
			this.Label9.Text = "Item Description";
			this.lkpMDLCD.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpMDLCD.AllowBlank = false;
			this.lkpMDLCD.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpMDLCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpMDLCD.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpMDLCD.DescriptionVisible1 = true;
			this.lkpMDLCD.DescriptionVisible2 = false;
			this.lkpMDLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpMDLCD.KeyValue = "";
			this.lkpMDLCD.LKPCD = "MDLCD";
			this.lkpMDLCD.Location = new System.Drawing.Point(113, 119);
			this.lkpMDLCD.MaxLength = 0;
			this.lkpMDLCD.Modified = false;
			this.lkpMDLCD.Multiline_ = false;
			this.lkpMDLCD.Name = "lkpMDLCD";
			this.lkpMDLCD.PasswordChar = "\0";
			this.lkpMDLCD.ReadOnly_ = false;
			this.lkpMDLCD.Size = new System.Drawing.Size(353, 23);
			this.lkpMDLCD.TabIndex = 9;
			this.lkpMDLCD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpMDLCD.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpMDLCD.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpMDLCD.TextHeight = 23;
			this.lkpMDLCD.TextWidth = 130;
			this.lkpMDLCD.Where1 = null;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 227);
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
			this.btnClose.TabIndex = 16;
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
			this.btnPRINT.TabIndex = 15;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 122);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(82, 16);
			this.Label8.TabIndex = 53;
			this.Label8.Text = "Model Code";
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 3);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.radNONZERO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.radSAFETY, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.radALL, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(113, 176);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(357, 26);
			this.TableLayoutPanel2.TabIndex = 22;
			this.radNONZERO.AutoSize = true;
			this.radNONZERO.Location = new System.Drawing.Point(190, 3);
			this.radNONZERO.Name = "radNONZERO";
			this.radNONZERO.Size = new System.Drawing.Size(164, 20);
			this.radNONZERO.TabIndex = 14;
			this.radNONZERO.Text = "Non-zero Balance Only";
			this.radNONZERO.UseVisualStyleBackColor = true;
			this.radSAFETY.AutoSize = true;
			this.radSAFETY.Location = new System.Drawing.Point(50, 3);
			this.radSAFETY.Name = "radSAFETY";
			this.radSAFETY.Size = new System.Drawing.Size(134, 20);
			this.radSAFETY.TabIndex = 13;
			this.radSAFETY.Text = "Below Safety Only";
			this.radSAFETY.UseVisualStyleBackColor = true;
			this.radALL.AutoSize = true;
			this.radALL.Checked = true;
			this.radALL.Location = new System.Drawing.Point(3, 3);
			this.radALL.Name = "radALL";
			this.radALL.Size = new System.Drawing.Size(41, 20);
			this.radALL.TabIndex = 12;
			this.radALL.TabStop = true;
			this.radALL.Text = "All";
			this.radALL.UseVisualStyleBackColor = true;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(472, 35);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(25, 16);
			this.Label7.TabIndex = 55;
			this.Label7.Text = "To";
			this.lkpCATCDFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCATCDFR.AllowBlank = false;
			this.lkpCATCDFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpCATCDFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpCATCDFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpCATCDFR.DescriptionVisible1 = true;
			this.lkpCATCDFR.DescriptionVisible2 = false;
			this.lkpCATCDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCATCDFR.KeyValue = "";
			this.lkpCATCDFR.LKPCD = "CATCD";
			this.lkpCATCDFR.Location = new System.Drawing.Point(113, 32);
			this.lkpCATCDFR.MaxLength = 0;
			this.lkpCATCDFR.Modified = false;
			this.lkpCATCDFR.Multiline_ = false;
			this.lkpCATCDFR.Name = "lkpCATCDFR";
			this.lkpCATCDFR.PasswordChar = "\0";
			this.lkpCATCDFR.ReadOnly_ = false;
			this.lkpCATCDFR.Size = new System.Drawing.Size(353, 23);
			this.lkpCATCDFR.TabIndex = 3;
			this.lkpCATCDFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpCATCDFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpCATCDFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpCATCDFR.TextHeight = 23;
			this.lkpCATCDFR.TextWidth = 130;
			this.lkpCATCDFR.Where1 = null;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 35);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 16);
			this.Label1.TabIndex = 50;
			this.Label1.Text = "Item Category";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(503, 148);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDTTO.TabIndex = 11;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(113, 148);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDTFR.TabIndex = 10;
			this.lkpITMCDTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMCDTO.AllowBlank = false;
			this.lkpITMCDTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpITMCDTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpITMCDTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpITMCDTO.DescriptionVisible1 = true;
			this.lkpITMCDTO.DescriptionVisible2 = false;
			this.lkpITMCDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMCDTO.KeyValue = "";
			this.lkpITMCDTO.LKPCD = "ITMCD";
			this.lkpITMCDTO.Location = new System.Drawing.Point(503, 61);
			this.lkpITMCDTO.MaxLength = 0;
			this.lkpITMCDTO.Modified = false;
			this.lkpITMCDTO.Multiline_ = false;
			this.lkpITMCDTO.Name = "lkpITMCDTO";
			this.lkpITMCDTO.PasswordChar = "\0";
			this.lkpITMCDTO.ReadOnly_ = false;
			this.lkpITMCDTO.Size = new System.Drawing.Size(353, 23);
			this.lkpITMCDTO.TabIndex = 6;
			this.lkpITMCDTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpITMCDTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpITMCDTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpITMCDTO.TextHeight = 23;
			this.lkpITMCDTO.TextWidth = 130;
			this.lkpITMCDTO.Where1 = null;
			this.lkpITMCDFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMCDFR.AllowBlank = false;
			this.lkpITMCDFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpITMCDFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpITMCDFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpITMCDFR.DescriptionVisible1 = true;
			this.lkpITMCDFR.DescriptionVisible2 = false;
			this.lkpITMCDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMCDFR.KeyValue = "";
			this.lkpITMCDFR.LKPCD = "ITMCD";
			this.lkpITMCDFR.Location = new System.Drawing.Point(113, 61);
			this.lkpITMCDFR.MaxLength = 0;
			this.lkpITMCDFR.Modified = false;
			this.lkpITMCDFR.Multiline_ = false;
			this.lkpITMCDFR.Name = "lkpITMCDFR";
			this.lkpITMCDFR.PasswordChar = "\0";
			this.lkpITMCDFR.ReadOnly_ = false;
			this.lkpITMCDFR.Size = new System.Drawing.Size(353, 23);
			this.lkpITMCDFR.TabIndex = 5;
			this.lkpITMCDFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpITMCDFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpITMCDFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpITMCDFR.TextHeight = 23;
			this.lkpITMCDFR.TextWidth = 130;
			this.lkpITMCDFR.Where1 = null;
			this.lkpLOCIDTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDTO.AllowBlank = false;
			this.lkpLOCIDTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpLOCIDTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpLOCIDTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpLOCIDTO.DescriptionVisible1 = true;
			this.lkpLOCIDTO.DescriptionVisible2 = false;
			this.lkpLOCIDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDTO.KeyValue = "";
			this.lkpLOCIDTO.LKPCD = "LOCID";
			this.lkpLOCIDTO.Location = new System.Drawing.Point(503, 3);
			this.lkpLOCIDTO.MaxLength = 0;
			this.lkpLOCIDTO.Modified = false;
			this.lkpLOCIDTO.Multiline_ = false;
			this.lkpLOCIDTO.Name = "lkpLOCIDTO";
			this.lkpLOCIDTO.PasswordChar = "\0";
			this.lkpLOCIDTO.ReadOnly_ = false;
			this.lkpLOCIDTO.Size = new System.Drawing.Size(353, 23);
			this.lkpLOCIDTO.TabIndex = 2;
			this.lkpLOCIDTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpLOCIDTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpLOCIDTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpLOCIDTO.TextHeight = 23;
			this.lkpLOCIDTO.TextWidth = 130;
			this.lkpLOCIDTO.Where1 = null;
			this.lkpLOCIDFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDFR.AllowBlank = false;
			this.lkpLOCIDFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpLOCIDFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpLOCIDFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpLOCIDFR.DescriptionVisible1 = true;
			this.lkpLOCIDFR.DescriptionVisible2 = false;
			this.lkpLOCIDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDFR.KeyValue = "";
			this.lkpLOCIDFR.LKPCD = "LOCID";
			this.lkpLOCIDFR.Location = new System.Drawing.Point(113, 3);
			this.lkpLOCIDFR.MaxLength = 0;
			this.lkpLOCIDFR.Modified = false;
			this.lkpLOCIDFR.Multiline_ = false;
			this.lkpLOCIDFR.Name = "lkpLOCIDFR";
			this.lkpLOCIDFR.PasswordChar = "\0";
			this.lkpLOCIDFR.ReadOnly_ = false;
			this.lkpLOCIDFR.Size = new System.Drawing.Size(353, 23);
			this.lkpLOCIDFR.TabIndex = 1;
			this.lkpLOCIDFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpLOCIDFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpLOCIDFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpLOCIDFR.TextHeight = 23;
			this.lkpLOCIDFR.TextWidth = 130;
			this.lkpLOCIDFR.Where1 = null;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(472, 151);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 16);
			this.Label3.TabIndex = 49;
			this.Label3.Text = "To";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 151);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(101, 16);
			this.Label4.TabIndex = 50;
			this.Label4.Text = "Document Date";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(472, 64);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(25, 16);
			this.Label5.TabIndex = 51;
			this.Label5.Text = "To";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 64);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(69, 16);
			this.Label6.TabIndex = 52;
			this.Label6.Text = "Item Code";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(472, 6);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(25, 16);
			this.Label2.TabIndex = 49;
			this.Label2.Text = "To";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 6);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(75, 16);
			this.Label21.TabIndex = 49;
			this.Label21.Text = "Location ID";
			this.lkpCATCDTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCATCDTO.AllowBlank = false;
			this.lkpCATCDTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpCATCDTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpCATCDTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpCATCDTO.DescriptionVisible1 = true;
			this.lkpCATCDTO.DescriptionVisible2 = false;
			this.lkpCATCDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCATCDTO.KeyValue = "";
			this.lkpCATCDTO.LKPCD = "CATCD";
			this.lkpCATCDTO.Location = new System.Drawing.Point(503, 32);
			this.lkpCATCDTO.MaxLength = 0;
			this.lkpCATCDTO.Modified = false;
			this.lkpCATCDTO.Multiline_ = false;
			this.lkpCATCDTO.Name = "lkpCATCDTO";
			this.lkpCATCDTO.PasswordChar = "\0";
			this.lkpCATCDTO.ReadOnly_ = false;
			this.lkpCATCDTO.Size = new System.Drawing.Size(353, 23);
			this.lkpCATCDTO.TabIndex = 4;
			this.lkpCATCDTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpCATCDTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpCATCDTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpCATCDTO.TextHeight = 23;
			this.lkpCATCDTO.TextWidth = 130;
			this.lkpCATCDTO.Where1 = null;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1560, 670);
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
			base.Name = "frmINRSTS";
			base.Tag = "INRSTS";
			this.Text = "Stock Status Report";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmINRSTS_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmINRSTS_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			Panel1.Visible = true;
			dtpDOCDTFR.Value = DateAndTime.Now.AddMonths(-1);
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			string strOPT = string.Empty;
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			if (radALL.Checked)
			{
				strOPT = "1";
			}
			if (radSAFETY.Checked)
			{
				strOPT = "2";
			}
			if (radNONZERO.Checked)
			{
				strOPT = "3";
			}
			frmRPT.ReportName = "STOCK STATUS REPORT";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptINSTS.rpt";
			frmRPT.Params = ("@LOCIDFR=" + lkpLOCIDFR.LowValue + ",@LOCIDTO=" + lkpLOCIDTO.HighValue + ",@CATCDFR=" + lkpCATCDFR.LowValue + ",@CATCDTO=" + lkpCATCDTO.HighValue + ",@ITMCDFR=" + lkpITMCDFR.LowValue + ",@ITMCDTO=" + lkpITMCDTO.HighValue + ",@ITMDESCFR=" + lkpITMDESCFR.LowValue + ",@ITMDESCTO=" + lkpITMDESCTO.HighValue + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDTFR.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDTTO.Value) + ",@OPT=" + strOPT + ",@MDLCD=" + lkpMDLCD.KeyValue) ?? "";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='STOCK STATUS REPORT',gintQTYDS=" + PublicVar.gintQTYDS + ",gintAMTDS=" + PublicVar.gintAMTDS + ",gintPRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
