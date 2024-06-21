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
	public class frmINRLED : Form
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual System.Windows.Forms.Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label4")]
		internal virtual System.Windows.Forms.Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual System.Windows.Forms.Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label6")]
		internal virtual System.Windows.Forms.Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label21")]
		internal virtual System.Windows.Forms.Label Label21
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

		[field: AccessedThroughProperty("lkpCATCDTO")]
		internal virtual LookupControl lkpCATCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual System.Windows.Forms.Label Label7
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
		internal virtual System.Windows.Forms.Label Label1
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

		[field: AccessedThroughProperty("lkpITMDESCFR")]
		internal virtual LookupControl lkpITMDESCFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label9")]
		internal virtual System.Windows.Forms.Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label8")]
		internal virtual System.Windows.Forms.Label Label8
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

		[field: AccessedThroughProperty("chkOption")]
		internal virtual System.Windows.Forms.CheckBox chkOption
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

		public frmINRLED()
		{
			base.Shown += frmINRLED_Shown;
			base.FormClosing += frmINRLED_FormClosing;
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
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnEXCEL = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.lkpITMDESCFR = new IMS.LookupControl();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.lkpCATCDTO = new IMS.LookupControl();
			this.Label7 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.lkpCATCDFR = new IMS.LookupControl();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.lkpITMCDTO = new IMS.LookupControl();
			this.lkpITMCDFR = new IMS.LookupControl();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.bgwProgress = new System.ComponentModel.BackgroundWorker();
			this.chkOption = new System.Windows.Forms.CheckBox();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.lblLOCID = new System.Windows.Forms.Label();
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
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.lkpITMDESCTO, 3, 3);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.lkpITMDESCFR, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 2, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lkpCATCDTO, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDTTO, 3, 4);
			this.TableLayoutPanel1.Controls.Add(this.lkpCATCDFR, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDTFR, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lkpITMCDTO, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.lkpITMCDFR, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label21, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.chkOption, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.lblLOCID, 3, 5);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 7;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(581, 241);
			this.TableLayoutPanel1.TabIndex = 0;
			this.lkpITMDESCTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMDESCTO.AllowBlank = false;
			this.lkpITMDESCTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpITMDESCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpITMDESCTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpITMDESCTO.DescriptionVisible1 = false;
			this.lkpITMDESCTO.DescriptionVisible2 = false;
			this.lkpITMDESCTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMDESCTO.KeyValue = "";
			this.lkpITMDESCTO.LKPCD = "ITMDESC";
			this.lkpITMDESCTO.Location = new System.Drawing.Point(366, 101);
			this.lkpITMDESCTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpITMDESCTO.MaxLength = 0;
			this.lkpITMDESCTO.Modified = false;
			this.lkpITMDESCTO.Multiline_ = false;
			this.lkpITMDESCTO.Name = "lkpITMDESCTO";
			this.lkpITMDESCTO.PasswordChar = "\0";
			this.lkpITMDESCTO.ReadOnly_ = false;
			this.lkpITMDESCTO.Size = new System.Drawing.Size(210, 23);
			this.lkpITMDESCTO.TabIndex = 8;
			this.lkpITMDESCTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpITMDESCTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpITMDESCTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpITMDESCTO.TextHeight = 23;
			this.lkpITMDESCTO.TextWidth = 180;
			this.lkpITMDESCTO.Where1 = null;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnEXCEL, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 185);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel3.TabIndex = 19;
			this.btnEXCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnEXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEXCEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnEXCEL.Image = IMS.My.Resources.Resources.Excel;
			this.btnEXCEL.Location = new System.Drawing.Point(129, 2);
			this.btnEXCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEXCEL.Name = "btnEXCEL";
			this.btnEXCEL.Size = new System.Drawing.Size(120, 50);
			this.btnEXCEL.TabIndex = 13;
			this.btnEXCEL.Text = "Excel";
			this.btnEXCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEXCEL.UseVisualStyleBackColor = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(255, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 12;
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
			this.btnPRINT.TabIndex = 11;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.lkpITMDESCFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMDESCFR.AllowBlank = false;
			this.lkpITMDESCFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpITMDESCFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpITMDESCFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpITMDESCFR.DescriptionVisible1 = false;
			this.lkpITMDESCFR.DescriptionVisible2 = false;
			this.lkpITMDESCFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMDESCFR.KeyValue = "";
			this.lkpITMDESCFR.LKPCD = "ITMDESC";
			this.lkpITMDESCFR.Location = new System.Drawing.Point(115, 101);
			this.lkpITMDESCFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpITMDESCFR.MaxLength = 0;
			this.lkpITMDESCFR.Modified = false;
			this.lkpITMDESCFR.Multiline_ = false;
			this.lkpITMDESCFR.Name = "lkpITMDESCFR";
			this.lkpITMDESCFR.PasswordChar = "\0";
			this.lkpITMDESCFR.ReadOnly_ = false;
			this.lkpITMDESCFR.Size = new System.Drawing.Size(210, 23);
			this.lkpITMDESCFR.TabIndex = 7;
			this.lkpITMDESCFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpITMDESCFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpITMDESCFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpITMDESCFR.TextHeight = 23;
			this.lkpITMDESCFR.TextWidth = 180;
			this.lkpITMDESCFR.Where1 = null;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(333, 104);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(25, 16);
			this.Label9.TabIndex = 61;
			this.Label9.Text = "To";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 104);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(104, 16);
			this.Label8.TabIndex = 60;
			this.Label8.Text = "Item Description";
			this.lkpCATCDTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCATCDTO.AllowBlank = false;
			this.lkpCATCDTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpCATCDTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpCATCDTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpCATCDTO.DescriptionVisible1 = false;
			this.lkpCATCDTO.DescriptionVisible2 = false;
			this.lkpCATCDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCATCDTO.KeyValue = "";
			this.lkpCATCDTO.LKPCD = "CATCD";
			this.lkpCATCDTO.Location = new System.Drawing.Point(366, 35);
			this.lkpCATCDTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpCATCDTO.MaxLength = 0;
			this.lkpCATCDTO.Modified = false;
			this.lkpCATCDTO.Multiline_ = false;
			this.lkpCATCDTO.Name = "lkpCATCDTO";
			this.lkpCATCDTO.PasswordChar = "\0";
			this.lkpCATCDTO.ReadOnly_ = false;
			this.lkpCATCDTO.Size = new System.Drawing.Size(210, 23);
			this.lkpCATCDTO.TabIndex = 4;
			this.lkpCATCDTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpCATCDTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpCATCDTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpCATCDTO.TextHeight = 23;
			this.lkpCATCDTO.TextWidth = 180;
			this.lkpCATCDTO.Where1 = null;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(333, 38);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(25, 16);
			this.Label7.TabIndex = 59;
			this.Label7.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(364, 132);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDTTO.TabIndex = 10;
			this.lkpCATCDFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCATCDFR.AllowBlank = false;
			this.lkpCATCDFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpCATCDFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpCATCDFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpCATCDFR.DescriptionVisible1 = false;
			this.lkpCATCDFR.DescriptionVisible2 = false;
			this.lkpCATCDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCATCDFR.KeyValue = "";
			this.lkpCATCDFR.LKPCD = "CATCD";
			this.lkpCATCDFR.Location = new System.Drawing.Point(115, 35);
			this.lkpCATCDFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpCATCDFR.MaxLength = 0;
			this.lkpCATCDFR.Modified = false;
			this.lkpCATCDFR.Multiline_ = false;
			this.lkpCATCDFR.Name = "lkpCATCDFR";
			this.lkpCATCDFR.PasswordChar = "\0";
			this.lkpCATCDFR.ReadOnly_ = false;
			this.lkpCATCDFR.Size = new System.Drawing.Size(210, 23);
			this.lkpCATCDFR.TabIndex = 3;
			this.lkpCATCDFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpCATCDFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpCATCDFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpCATCDFR.TextHeight = 23;
			this.lkpCATCDFR.TextWidth = 180;
			this.lkpCATCDFR.Where1 = null;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(113, 132);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDTFR.TabIndex = 9;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 38);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 16);
			this.Label1.TabIndex = 58;
			this.Label1.Text = "Item Category";
			this.lkpITMCDTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMCDTO.AllowBlank = false;
			this.lkpITMCDTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpITMCDTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpITMCDTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpITMCDTO.DescriptionVisible1 = false;
			this.lkpITMCDTO.DescriptionVisible2 = false;
			this.lkpITMCDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMCDTO.KeyValue = "";
			this.lkpITMCDTO.LKPCD = "ITMCD";
			this.lkpITMCDTO.Location = new System.Drawing.Point(366, 68);
			this.lkpITMCDTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpITMCDTO.MaxLength = 0;
			this.lkpITMCDTO.Modified = false;
			this.lkpITMCDTO.Multiline_ = false;
			this.lkpITMCDTO.Name = "lkpITMCDTO";
			this.lkpITMCDTO.PasswordChar = "\0";
			this.lkpITMCDTO.ReadOnly_ = false;
			this.lkpITMCDTO.Size = new System.Drawing.Size(210, 23);
			this.lkpITMCDTO.TabIndex = 6;
			this.lkpITMCDTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpITMCDTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpITMCDTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpITMCDTO.TextHeight = 23;
			this.lkpITMCDTO.TextWidth = 180;
			this.lkpITMCDTO.Where1 = null;
			this.lkpITMCDFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMCDFR.AllowBlank = false;
			this.lkpITMCDFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpITMCDFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpITMCDFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpITMCDFR.DescriptionVisible1 = false;
			this.lkpITMCDFR.DescriptionVisible2 = false;
			this.lkpITMCDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpITMCDFR.KeyValue = "";
			this.lkpITMCDFR.LKPCD = "ITMCD";
			this.lkpITMCDFR.Location = new System.Drawing.Point(115, 68);
			this.lkpITMCDFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpITMCDFR.MaxLength = 0;
			this.lkpITMCDFR.Modified = false;
			this.lkpITMCDFR.Multiline_ = false;
			this.lkpITMCDFR.Name = "lkpITMCDFR";
			this.lkpITMCDFR.PasswordChar = "\0";
			this.lkpITMCDFR.ReadOnly_ = false;
			this.lkpITMCDFR.Size = new System.Drawing.Size(210, 23);
			this.lkpITMCDFR.TabIndex = 5;
			this.lkpITMCDFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpITMCDFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpITMCDFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpITMCDFR.TextHeight = 23;
			this.lkpITMCDFR.TextWidth = 180;
			this.lkpITMCDFR.Where1 = null;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(333, 135);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 16);
			this.Label3.TabIndex = 49;
			this.Label3.Text = "To";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 135);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(101, 16);
			this.Label4.TabIndex = 50;
			this.Label4.Text = "Document Date";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(333, 71);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(25, 16);
			this.Label5.TabIndex = 51;
			this.Label5.Text = "To";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 71);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(69, 16);
			this.Label6.TabIndex = 52;
			this.Label6.Text = "Item Code";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 7);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(75, 16);
			this.Label21.TabIndex = 49;
			this.Label21.Text = "Location ID";
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1560, 672);
			this.Panel1.TabIndex = 20;
			this.chkOption.AutoSize = true;
			this.TableLayoutPanel1.SetColumnSpan(this.chkOption, 2);
			this.chkOption.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkOption.Location = new System.Drawing.Point(3, 160);
			this.chkOption.Name = "chkOption";
			this.chkOption.Size = new System.Drawing.Size(165, 20);
			this.chkOption.TabIndex = 62;
			this.chkOption.Text = "Include No Transaction";
			this.chkOption.UseVisualStyleBackColor = true;
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(113, 3);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(212, 24);
			this.cbLOCID.TabIndex = 63;
			this.lblLOCID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblLOCID.AutoSize = true;
			this.lblLOCID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLOCID.Location = new System.Drawing.Point(364, 162);
			this.lblLOCID.Name = "lblLOCID";
			this.lblLOCID.Size = new System.Drawing.Size(75, 16);
			this.lblLOCID.TabIndex = 64;
			this.lblLOCID.Text = "Location ID";
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
			base.Name = "frmINRLED";
			base.Tag = "INRLED";
			this.Text = "Stock Ledger";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmINRLED_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
			Panel1.Visible = true;
			dtpDOCDTFR.Value = DateAndTime.Now.AddMonths(-1);
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCID";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "STOCK LEDGER REPORT";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptINLED.rpt";
			frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@LOCID=", cbLOCID.SelectedValue), ",@CATCDFR="), lkpCATCDFR.LowValue), ",@CATCDTO="), lkpCATCDTO.HighValue), ",@ITMCDFR="), lkpITMCDFR.LowValue), ",@ITMCDTO="), lkpITMCDTO.HighValue), ",@ITMDESCFR="), lkpITMDESCFR.LowValue), ",@ITMDESCTO="), lkpITMDESCTO.HighValue), ",@DOCDTFR="), Common.gfSQLDate(dtpDOCDTFR.Value)), ",@DOCDTTO="), Common.gfSQLDate(dtpDOCDTTO.Value)), ",@Option="), Interaction.IIf(chkOption.Checked, 0, 1)));
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='STOCK LEDGER REPORT',gintQTYDS=" + PublicVar.gintQTYDS + ",gintAMTDS=" + PublicVar.gintAMTDS + ",gintPRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmINRLED_FormClosing(object sender, FormClosingEventArgs e)
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
			string strSQL = "EXEC spINLED ";
			strSQL = strSQL + "'" + lblLOCID.Text + "', ";
			strSQL = strSQL + "'" + lkpCATCDFR.LowValue + "', '" + lkpCATCDTO.HighValue + "', ";
			strSQL = strSQL + "'" + lkpITMCDFR.LowValue + "', '" + lkpITMCDTO.HighValue + "', ";
			strSQL = strSQL + "'" + lkpITMDESCFR.LowValue + "', '" + lkpITMDESCTO.HighValue + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', '" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Interaction.IIf(chkOption.Checked, 0, 1)));
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
			xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Stock Ledger Report");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			xlsApp.Cells[3, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "From") + " " + Common.gfSQLDate(dtpDOCDTFR.Value) + " To " + Common.gfSQLDate(dtpDOCDTTO.Value);
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[3, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[3, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			int intRow = 5;
			xlsApp.Cells[intRow, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Del Date");
			xlsApp.Cells[intRow, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
			xlsApp.Cells[intRow, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Code");
			xlsApp.Cells[intRow, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
			xlsApp.Cells[intRow, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
			xlsApp.Cells[intRow, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO Date");
			xlsApp.Cells[intRow, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO No");
			xlsApp.Cells[intRow, 8] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
			xlsApp.Cells[intRow, 9] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO Type");
			xlsApp.Cells[intRow, 10] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
			xlsApp.Cells[intRow, 11] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			xlsApp.Cells[intRow, 12] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Cust Part No");
			xlsApp.Cells[intRow, 13] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Rev");
			xlsApp.Cells[intRow, 14] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In Qty");
			xlsApp.Cells[intRow, 15] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out Qty");
			xlsApp.Cells[intRow, 16] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
			xlsApp.Cells[intRow, 17] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "SO Type");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[5, 17])).Font.Bold = true;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 17])).EntireColumn.NumberFormat = "@";
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 17])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 17])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectNotEqual(strLOCID, dt.Rows[i]["LOCID"], false))
					{
						intRow++;
						strLOCID = Conversions.ToString(dt.Rows[i]["LOCID"]);
						strITMCD = string.Empty;
						xlsApp.Cells[intRow, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1])).Font.Bold = true;
						xlsApp.Cells[intRow, 2] = strLOCID;
					}
					if (Operators.ConditionalCompareObjectEqual(dt.Rows[i]["GRPCD"], 1, false))
					{
						dblBalance = Conversions.ToDouble(dt.Rows[i]["OPNQTY"]);
					}
					if (Operators.ConditionalCompareObjectEqual(dt.Rows[i]["GRPCD"], 2, false))
					{
						intRow++;
						xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DELDT"]);
						xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOCDT"]);
						xlsApp.Cells[intRow, 3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOCCD"]);
						xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DOCNO"]);
						xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["REFNO2"]);
						xlsApp.Cells[intRow, 6] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["WKODT"]);
						xlsApp.Cells[intRow, 7] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["WKONO"]);
						xlsApp.Cells[intRow, 8] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["GRLNO"]);
						xlsApp.Cells[intRow, 9] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["WO_TYPE"]);
						xlsApp.Cells[intRow, 10] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["CUS_SHORT"]);
						xlsApp.Cells[intRow, 11] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["ITMCD"]);
						xlsApp.Cells[intRow, 12] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["CUS_CPTNO"]);
						xlsApp.Cells[intRow, 13] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["REVNO"]);
						xlsApp.Cells[intRow, 14] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["INQTY"]);
						xlsApp.Cells[intRow, 15] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["OTQTY"]);
						dblBalance = Conversions.ToDouble(Operators.SubtractObject(Operators.AddObject(dblBalance, dt.Rows[i]["INQTY"]), dt.Rows[i]["OTQTY"]));
						xlsApp.Cells[intRow, 16] = dblBalance;
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 13]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 16])).NumberFormat = "0.00";
						xlsApp.Cells[intRow, 17] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["SO_TYPE"]);
					}
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
