using System;
using System.ComponentModel;
using System.Data.OleDb;
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
	public class frmPCXMRP : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCALC")]
		private Button _btnCALC;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkAVESL")]
		private CheckBox _chkAVESL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkMPS")]
		private CheckBox _chkMPS;

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

		internal virtual Button btnCALC
		{
			[CompilerGenerated]
			get
			{
				return _btnCALC;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCALC_Click;
				Button button = _btnCALC;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCALC = value;
				button = _btnCALC;
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblNoOfMth")]
		internal virtual Label lblNoOfMth
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

		[field: AccessedThroughProperty("dtpRPODT")]
		internal virtual DateTimePicker dtpRPODT
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

		[field: AccessedThroughProperty("dtpCUTOFF")]
		internal virtual DateTimePicker dtpCUTOFF
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

		[field: AccessedThroughProperty("dtpMRPDT")]
		internal virtual DateTimePicker dtpMRPDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numAVMTH")]
		internal virtual NumControl numAVMTH
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox chkAVESL
		{
			[CompilerGenerated]
			get
			{
				return _chkAVESL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = chkAVESL_CheckedChanged;
				CheckBox checkBox = _chkAVESL;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_chkAVESL = value;
				checkBox = _chkAVESL;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkSFTYFG")]
		internal virtual CheckBox chkSFTYFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkWOFG")]
		internal virtual CheckBox chkWOFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpMPSDT")]
		internal virtual DateTimePicker dtpMPSDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblMPSDT")]
		internal virtual Label lblMPSDT
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

		internal virtual CheckBox chkMPS
		{
			[CompilerGenerated]
			get
			{
				return _chkMPS;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = chkMPS_CheckedChanged;
				CheckBox checkBox = _chkMPS;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_chkMPS = value;
				checkBox = _chkMPS;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		public frmPCXMRP()
		{
			base.Shown += frmPCXMRP_Shown;
			base.FormClosing += frmPCXMRP_FormClosing;
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
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.chkSFTYFG = new System.Windows.Forms.CheckBox();
			this.chkWOFG = new System.Windows.Forms.CheckBox();
			this.dtpMPSDT = new System.Windows.Forms.DateTimePicker();
			this.lblMPSDT = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.chkMPS = new System.Windows.Forms.CheckBox();
			this.chkAVESL = new System.Windows.Forms.CheckBox();
			this.numAVMTH = new IMS.NumControl();
			this.lblNoOfMth = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.dtpRPODT = new System.Windows.Forms.DateTimePicker();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpCUTOFF = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.dtpMRPDT = new System.Windows.Forms.DateTimePicker();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnCALC = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
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
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.chkSFTYFG, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.chkWOFG, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.dtpMPSDT, 3, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblMPSDT, 2, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.chkMPS, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.chkAVESL, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.numAVMTH, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblNoOfMth, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpRPODT, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpCUTOFF, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpMRPDT, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 8;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(455, 258);
			this.TableLayoutPanel1.TabIndex = 0;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 157);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(113, 16);
			this.Label8.TabIndex = 76;
			this.Label8.Text = "Safety Stock Flag";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 127);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(61, 16);
			this.Label7.TabIndex = 75;
			this.Label7.Text = "WO Flag";
			this.chkSFTYFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkSFTYFG.AutoSize = true;
			this.chkSFTYFG.Location = new System.Drawing.Point(123, 158);
			this.chkSFTYFG.Margin = new System.Windows.Forms.Padding(4);
			this.chkSFTYFG.Name = "chkSFTYFG";
			this.chkSFTYFG.Size = new System.Drawing.Size(15, 14);
			this.chkSFTYFG.TabIndex = 8;
			this.chkSFTYFG.UseVisualStyleBackColor = true;
			this.chkWOFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkWOFG.AutoSize = true;
			this.chkWOFG.Location = new System.Drawing.Point(123, 128);
			this.chkWOFG.Margin = new System.Windows.Forms.Padding(4);
			this.chkWOFG.Name = "chkWOFG";
			this.chkWOFG.Size = new System.Drawing.Size(15, 14);
			this.chkWOFG.TabIndex = 7;
			this.chkWOFG.UseVisualStyleBackColor = true;
			this.dtpMPSDT.CustomFormat = "dd/MM/yyyy";
			this.dtpMPSDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMPSDT.Location = new System.Drawing.Point(348, 92);
			this.dtpMPSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpMPSDT.Name = "dtpMPSDT";
			this.dtpMPSDT.Size = new System.Drawing.Size(104, 22);
			this.dtpMPSDT.TabIndex = 6;
			this.dtpMPSDT.Visible = false;
			this.lblMPSDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMPSDT.AutoSize = true;
			this.lblMPSDT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMPSDT.Location = new System.Drawing.Point(232, 97);
			this.lblMPSDT.Name = "lblMPSDT";
			this.lblMPSDT.Size = new System.Drawing.Size(69, 16);
			this.lblMPSDT.TabIndex = 71;
			this.lblMPSDT.Text = "MPS Date";
			this.lblMPSDT.Visible = false;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 97);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(67, 16);
			this.Label5.TabIndex = 70;
			this.Label5.Text = "MPS Flag";
			this.chkMPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkMPS.AutoSize = true;
			this.chkMPS.Location = new System.Drawing.Point(123, 98);
			this.chkMPS.Margin = new System.Windows.Forms.Padding(4);
			this.chkMPS.Name = "chkMPS";
			this.chkMPS.Size = new System.Drawing.Size(15, 14);
			this.chkMPS.TabIndex = 5;
			this.chkMPS.UseVisualStyleBackColor = true;
			this.chkAVESL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkAVESL.AutoSize = true;
			this.chkAVESL.Location = new System.Drawing.Point(123, 68);
			this.chkAVESL.Margin = new System.Windows.Forms.Padding(4);
			this.chkAVESL.Name = "chkAVESL";
			this.chkAVESL.Size = new System.Drawing.Size(15, 14);
			this.chkAVESL.TabIndex = 3;
			this.chkAVESL.UseVisualStyleBackColor = true;
			this.numAVMTH.AllowNegative = false;
			this.numAVMTH.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numAVMTH.DataChanged = false;
			this.numAVMTH.Location = new System.Drawing.Point(348, 64);
			this.numAVMTH.Name = "numAVMTH";
			this.numAVMTH.NumberFormat = "8.0";
			this.numAVMTH.Size = new System.Drawing.Size(100, 22);
			this.numAVMTH.TabIndex = 4;
			this.numAVMTH.Text = "0";
			this.numAVMTH.ThousandSeperator = false;
			this.numAVMTH.Value = 0.0;
			this.numAVMTH.Visible = false;
			this.lblNoOfMth.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblNoOfMth.AutoSize = true;
			this.lblNoOfMth.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblNoOfMth.Location = new System.Drawing.Point(232, 67);
			this.lblNoOfMth.Name = "lblNoOfMth";
			this.lblNoOfMth.Size = new System.Drawing.Size(79, 16);
			this.lblNoOfMth.TabIndex = 66;
			this.lblNoOfMth.Text = "No of Month";
			this.lblNoOfMth.Visible = false;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 67);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(98, 16);
			this.Label4.TabIndex = 65;
			this.Label4.Text = "Average Sales";
			this.dtpRPODT.CustomFormat = "dd/MM/yyyy";
			this.dtpRPODT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRPODT.Location = new System.Drawing.Point(348, 32);
			this.dtpRPODT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpRPODT.Name = "dtpRPODT";
			this.dtpRPODT.Size = new System.Drawing.Size(104, 22);
			this.dtpRPODT.TabIndex = 2;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(232, 37);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(110, 16);
			this.Label3.TabIndex = 63;
			this.Label3.Text = "Require PO Date";
			this.dtpCUTOFF.CustomFormat = "dd/MM/yyyy";
			this.dtpCUTOFF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCUTOFF.Location = new System.Drawing.Point(122, 32);
			this.dtpCUTOFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpCUTOFF.Name = "dtpCUTOFF";
			this.dtpCUTOFF.Size = new System.Drawing.Size(104, 22);
			this.dtpCUTOFF.TabIndex = 1;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 37);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(78, 16);
			this.Label2.TabIndex = 61;
			this.Label2.Text = "Cut Off Date";
			this.dtpMRPDT.CustomFormat = "dd/MM/yyyy";
			this.dtpMRPDT.Enabled = false;
			this.dtpMRPDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMRPDT.Location = new System.Drawing.Point(122, 2);
			this.dtpMRPDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpMRPDT.Name = "dtpMRPDT";
			this.dtpMRPDT.Size = new System.Drawing.Size(104, 22);
			this.dtpMRPDT.TabIndex = 60;
			this.dtpMRPDT.TabStop = false;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCALC, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 202);
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
			this.btnCALC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCALC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCALC.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCALC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCALC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCALC.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnCALC.Image = IMS.My.Resources.Resources.process;
			this.btnCALC.Location = new System.Drawing.Point(3, 2);
			this.btnCALC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCALC.Name = "btnCALC";
			this.btnCALC.Size = new System.Drawing.Size(120, 50);
			this.btnCALC.TabIndex = 9;
			this.btnCALC.Text = "Calculate";
			this.btnCALC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCALC.UseVisualStyleBackColor = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 7);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(70, 16);
			this.Label1.TabIndex = 58;
			this.Label1.Text = "MRP Date";
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
			base.Name = "frmPCXMRP";
			base.Tag = "PCXMRP";
			this.Text = "MRP Calculation";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPCXMRP_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			Panel1.Visible = true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPCXMRP_FormClosing(object sender, FormClosingEventArgs e)
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

		private void chkAVESL_CheckedChanged(object sender, EventArgs e)
		{
			if (chkAVESL.Checked)
			{
				lblNoOfMth.Visible = true;
				numAVMTH.Visible = true;
			}
			else
			{
				lblNoOfMth.Visible = false;
				numAVMTH.Visible = false;
			}
		}

		private void chkMPS_CheckedChanged(object sender, EventArgs e)
		{
			if (chkMPS.Checked)
			{
				lblMPSDT.Visible = true;
				dtpMPSDT.Visible = true;
			}
			else
			{
				lblMPSDT.Visible = false;
				dtpMPSDT.Visible = false;
			}
		}

		private void btnCALC_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spPCXMRP ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpMRPDT.Value) + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpCUTOFF.Value) + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpRPODT.Value) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkAVESL.Checked, 1, 0), ", ")));
				strSQL = strSQL + Conversions.ToString(numAVMTH.Value) + ", ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkMPS.Checked, 1, 0), ", ")));
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpMPSDT.Value) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkWOFG.Checked, 1, 0), ", ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkSFTYFG.Checked, 1, 0), ", ")));
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "' ";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
					return;
				}
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "MRP Calculation completed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private bool ValidateDetailControl()
		{
			if (DateTime.Compare(dtpCUTOFF.Value.Date, DateTime.Now.Date) < 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Cut Off Date cannot less than today."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			if (DateTime.Compare(dtpRPODT.Value.Date, DateTime.Now.Date) < 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Require PO Date cannot less than today."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			if (chkAVESL.Checked & ((numAVMTH.Value == 0.0) | (numAVMTH.Value > 12.0)))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Valid no of month is 1-12."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			if (chkMPS.Checked & (DateTime.Compare(dtpMPSDT.Value.Date, DateTime.Now.Date) < 0))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "MPS Date cannot less than today."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return false;
			}
			return true;
		}
	}
}
