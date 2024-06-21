using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CryptoLibrary;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmLM1EMS : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		private OleDbCommand Cmd;

		[field: AccessedThroughProperty("details")]
		internal virtual TableLayoutPanel details
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSYSCD")]
		internal virtual Label lblSYSCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSYSNM")]
		internal virtual Label lblSYSNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblADDR")]
		internal virtual Label lblADDR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTEL01")]
		internal virtual Label lblTEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTEL02")]
		internal virtual Label lblTEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSMTPPwd")]
		internal virtual TextBox txtSMTPPwd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSMTPID")]
		internal virtual TextBox txtSMTPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSMTPPort")]
		internal virtual TextBox txtSMTPPort
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSMTPServer")]
		internal virtual TextBox txtSMTPServer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTitle")]
		internal virtual TextBox txtTitle
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtBody")]
		internal virtual TextBox txtBody
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTACD")]
		internal virtual Label lblSTACD
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
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

		[field: AccessedThroughProperty("txtSMTPEmail")]
		internal virtual TextBox txtSMTPEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSAVE
		{
			[CompilerGenerated]
			get
			{
				return _btnSAVE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSAVE_Click;
				Button button = _btnSAVE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSAVE = value;
				button = _btnSAVE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("txtTo")]
		internal virtual TextBox txtTo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCC")]
		internal virtual TextBox txtCC
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

		[field: AccessedThroughProperty("chkACTFG")]
		internal virtual CheckBox chkACTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmLM1EMS()
		{
			base.Load += frmLM1EMS_Load;
			base.FormClosing += frmMAECOD_FormClosing;
			Cmd = new OleDbCommand();
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
			this.details = new System.Windows.Forms.TableLayoutPanel();
			this.chkACTFG = new System.Windows.Forms.CheckBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtTo = new System.Windows.Forms.TextBox();
			this.txtCC = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.txtSMTPEmail = new System.Windows.Forms.TextBox();
			this.lblSTACD = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtSMTPPwd = new System.Windows.Forms.TextBox();
			this.txtSMTPID = new System.Windows.Forms.TextBox();
			this.txtSMTPPort = new System.Windows.Forms.TextBox();
			this.lblSYSCD = new System.Windows.Forms.Label();
			this.txtSMTPServer = new System.Windows.Forms.TextBox();
			this.lblSYSNM = new System.Windows.Forms.Label();
			this.lblADDR = new System.Windows.Forms.Label();
			this.lblTEL01 = new System.Windows.Forms.Label();
			this.lblTEL02 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtBody = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.details.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.details.AutoSize = true;
			this.details.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.details.ColumnCount = 3;
			this.details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.details.Controls.Add(this.chkACTFG, 2, 6);
			this.details.Controls.Add(this.Label4, 1, 6);
			this.details.Controls.Add(this.txtTo, 1, 7);
			this.details.Controls.Add(this.txtCC, 1, 8);
			this.details.Controls.Add(this.Label6, 0, 4);
			this.details.Controls.Add(this.TableLayoutPanel1, 0, 12);
			this.details.Controls.Add(this.txtSMTPEmail, 1, 2);
			this.details.Controls.Add(this.lblSTACD, 0, 7);
			this.details.Controls.Add(this.Label3, 0, 8);
			this.details.Controls.Add(this.Label1, 0, 2);
			this.details.Controls.Add(this.txtSMTPPwd, 1, 4);
			this.details.Controls.Add(this.txtSMTPID, 1, 3);
			this.details.Controls.Add(this.txtSMTPPort, 1, 1);
			this.details.Controls.Add(this.lblSYSCD, 0, 0);
			this.details.Controls.Add(this.txtSMTPServer, 1, 0);
			this.details.Controls.Add(this.lblSYSNM, 0, 1);
			this.details.Controls.Add(this.lblADDR, 0, 3);
			this.details.Controls.Add(this.lblTEL01, 0, 9);
			this.details.Controls.Add(this.lblTEL02, 0, 10);
			this.details.Controls.Add(this.txtTitle, 1, 9);
			this.details.Controls.Add(this.txtBody, 1, 10);
			this.details.Controls.Add(this.Label2, 0, 6);
			this.details.Location = new System.Drawing.Point(5, 12);
			this.details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.details.Name = "details";
			this.details.RowCount = 13;
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.Size = new System.Drawing.Size(673, 599);
			this.details.TabIndex = 0;
			this.chkACTFG.AutoSize = true;
			this.chkACTFG.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkACTFG.Location = new System.Drawing.Point(548, 153);
			this.chkACTFG.Name = "chkACTFG";
			this.chkACTFG.Size = new System.Drawing.Size(64, 20);
			this.chkACTFG.TabIndex = 1;
			this.chkACTFG.Text = "Active";
			this.chkACTFG.UseVisualStyleBackColor = true;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.Color.DarkRed;
			this.Label4.Location = new System.Drawing.Point(102, 157);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(308, 16);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "* Please separate multiple email addresses with (;)";
			this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtTo.Location = new System.Drawing.Point(102, 182);
			this.txtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTo.Multiline = true;
			this.txtTo.Name = "txtTo";
			this.txtTo.Size = new System.Drawing.Size(440, 44);
			this.txtTo.TabIndex = 6;
			this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCC.Location = new System.Drawing.Point(102, 230);
			this.txtCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCC.Multiline = true;
			this.txtCC.Name = "txtCC";
			this.txtCC.Size = new System.Drawing.Size(440, 44);
			this.txtCC.TabIndex = 7;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 109);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(68, 16);
			this.Label6.TabIndex = 11;
			this.Label6.Text = "Password";
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.details.SetColumnSpan(this.TableLayoutPanel1, 2);
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27f));
			this.TableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 542);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(260, 54);
			this.TableLayoutPanel1.TabIndex = 8;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(135, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(5, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 9;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.txtSMTPEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSMTPEmail.Location = new System.Drawing.Point(102, 54);
			this.txtSMTPEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSMTPEmail.Name = "txtSMTPEmail";
			this.txtSMTPEmail.Size = new System.Drawing.Size(221, 22);
			this.txtSMTPEmail.TabIndex = 3;
			this.lblSTACD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTACD.AutoSize = true;
			this.lblSTACD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTACD.Location = new System.Drawing.Point(3, 196);
			this.lblSTACD.Name = "lblSTACD";
			this.lblSTACD.Size = new System.Drawing.Size(25, 16);
			this.lblSTACD.TabIndex = 7;
			this.lblSTACD.Text = "To";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 244);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(24, 16);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "Cc";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 57);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(93, 16);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Email Account";
			this.txtSMTPPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSMTPPwd.Location = new System.Drawing.Point(102, 106);
			this.txtSMTPPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSMTPPwd.Name = "txtSMTPPwd";
			this.txtSMTPPwd.PasswordChar = '*';
			this.txtSMTPPwd.Size = new System.Drawing.Size(221, 22);
			this.txtSMTPPwd.TabIndex = 5;
			this.txtSMTPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSMTPID.Location = new System.Drawing.Point(102, 80);
			this.txtSMTPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSMTPID.Name = "txtSMTPID";
			this.txtSMTPID.Size = new System.Drawing.Size(221, 22);
			this.txtSMTPID.TabIndex = 4;
			this.txtSMTPPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSMTPPort.Location = new System.Drawing.Point(102, 28);
			this.txtSMTPPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSMTPPort.Name = "txtSMTPPort";
			this.txtSMTPPort.Size = new System.Drawing.Size(67, 22);
			this.txtSMTPPort.TabIndex = 2;
			this.lblSYSCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSYSCD.AutoSize = true;
			this.lblSYSCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSYSCD.Location = new System.Drawing.Point(3, 5);
			this.lblSYSCD.Name = "lblSYSCD";
			this.lblSYSCD.Size = new System.Drawing.Size(89, 16);
			this.lblSYSCD.TabIndex = 1;
			this.lblSYSCD.Text = "SMTP Server";
			this.txtSMTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSMTPServer.Location = new System.Drawing.Point(102, 2);
			this.txtSMTPServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSMTPServer.Name = "txtSMTPServer";
			this.txtSMTPServer.Size = new System.Drawing.Size(221, 22);
			this.txtSMTPServer.TabIndex = 1;
			this.lblSYSNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSYSNM.AutoSize = true;
			this.lblSYSNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSYSNM.Location = new System.Drawing.Point(3, 31);
			this.lblSYSNM.Name = "lblSYSNM";
			this.lblSYSNM.Size = new System.Drawing.Size(73, 16);
			this.lblSYSNM.TabIndex = 2;
			this.lblSYSNM.Text = "SMTP Port";
			this.lblADDR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblADDR.AutoSize = true;
			this.lblADDR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblADDR.Location = new System.Drawing.Point(3, 83);
			this.lblADDR.Name = "lblADDR";
			this.lblADDR.Size = new System.Drawing.Size(58, 16);
			this.lblADDR.TabIndex = 3;
			this.lblADDR.Text = "Email ID";
			this.lblTEL01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL01.AutoSize = true;
			this.lblTEL01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL01.Location = new System.Drawing.Point(3, 281);
			this.lblTEL01.Name = "lblTEL01";
			this.lblTEL01.Size = new System.Drawing.Size(34, 16);
			this.lblTEL01.TabIndex = 4;
			this.lblTEL01.Text = "Title";
			this.lblTEL02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL02.AutoSize = true;
			this.lblTEL02.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL02.Location = new System.Drawing.Point(3, 402);
			this.lblTEL02.Name = "lblTEL02";
			this.lblTEL02.Size = new System.Drawing.Size(40, 16);
			this.lblTEL02.TabIndex = 5;
			this.lblTEL02.Text = "Body";
			this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtTitle.Location = new System.Drawing.Point(102, 278);
			this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(440, 22);
			this.txtTitle.TabIndex = 12;
			this.details.SetColumnSpan(this.txtBody, 2);
			this.txtBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtBody.Location = new System.Drawing.Point(102, 304);
			this.txtBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBody.Multiline = true;
			this.txtBody.Name = "txtBody";
			this.txtBody.Size = new System.Drawing.Size(568, 213);
			this.txtBody.TabIndex = 8;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 157);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(87, 16);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Job Control";
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.details);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1362, 627);
			this.Panel1.TabIndex = 9;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmLM1EMS";
			this.Text = "Email Setting";
			this.details.ResumeLayout(false);
			this.details.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private bool SaveRecord()
		{
			string strSQL = string.Empty;
			Crypto oCrypto = new Crypto();
			bool SaveRecord;
			try
			{
				Cmd.Connection = DB.GetDBConnection();
				strSQL = "TRUNCATE TABLE SAEMS_TBL";
				Cmd.CommandText = strSQL;
				Cmd.ExecuteNonQuery();
				strSQL = "INSERT SAEMS_TBL (";
				strSQL += "SAEMS_SMTPSERVER, SAEMS_SMTPPORT, SAEMS_SMTPEMAIL, SAEMS_SMTPID, SAEMS_SMTPPWD) ";
				strSQL += "VALUES (";
				strSQL = strSQL + "'" + txtSMTPServer.Text + "', ";
				strSQL = strSQL + "'" + txtSMTPPort.Text + "', ";
				strSQL = strSQL + "'" + txtSMTPEmail.Text + "', ";
				strSQL = strSQL + "'" + txtSMTPID.Text + "', ";
				strSQL = strSQL + "'" + oCrypto.EncryptString128Bit(txtSMTPPwd.Text, "") + "')";
				Cmd.CommandText = strSQL;
				Cmd.ExecuteNonQuery();
				strSQL = "DELETE SAEML_TBL ";
				strSQL += "WHERE SAEML_EMLTY = '1'";
				Cmd.CommandText = strSQL;
				Cmd.ExecuteNonQuery();
				strSQL = "INSERT SAEML_TBL (";
				strSQL += "SAEML_EMLTY, SAEML_ACTFG, ";
				strSQL += "SAEML_TO, SAEML_CC, SAEML_TITLE, SAEML_BODY, SAEML_ENTDT) ";
				strSQL += "VALUES (";
				strSQL = strSQL + "'1', " + Conversions.ToString(Convert.ToInt32(chkACTFG.Checked)) + ", ";
				strSQL = strSQL + "'" + txtTo.Text + "', ";
				strSQL = strSQL + "'" + txtCC.Text + "', ";
				strSQL = strSQL + "'" + txtTitle.Text + "', ";
				strSQL = strSQL + "'" + txtBody.Text + "', ";
				strSQL += "GETDATE())";
				Cmd.CommandText = strSQL;
				Cmd.ExecuteNonQuery();
				SaveRecord = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				SaveRecord = false;
				ProjectData.ClearProjectError();
			}
			return SaveRecord;
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			if (ValidateDetailControl() && SaveRecord())
			{
				MessageBox.Show("Record save successfully.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BindDatafromDB()
		{
			try
			{
				string strSQL = "SELECT SAEMS_SMTPSERVER, SAEMS_SMTPPORT, SAEMS_SMTPEMAIL, SAEMS_SMTPID, SAEMS_SMTPPWD ";
				strSQL += "FROM SAEMS_TBL";
				DataTable dt = DB.ExecProc(strSQL);
				if (dt.Rows.Count > 0)
				{
					txtSMTPServer.Text = dt.Rows[0]["SAEMS_SMTPSERVER"].ToString();
					txtSMTPPort.Text = dt.Rows[0]["SAEMS_SMTPPORT"].ToString();
					txtSMTPEmail.Text = dt.Rows[0]["SAEMS_SMTPEMAIL"].ToString();
					txtSMTPID.Text = dt.Rows[0]["SAEMS_SMTPID"].ToString();
					txtSMTPPwd.Text = dt.Rows[0]["SAEMS_SMTPPWD"].ToString();
				}
				strSQL = "SELECT SAEML_ACTFG, SAEML_TO, SAEML_CC, SAEML_TITLE, SAEML_BODY ";
				strSQL += "FROM SAEML_TBL ";
				strSQL += "WHERE SAEML_EMLTY = '1'";
				dt = DB.ExecProc(strSQL);
				if (dt.Rows.Count > 0)
				{
					chkACTFG.Checked = Conversions.ToBoolean(dt.Rows[0]["SAEML_ACTFG"]);
					txtTo.Text = dt.Rows[0]["SAEML_TO"].ToString();
					txtCC.Text = dt.Rows[0]["SAEML_CC"].ToString();
					txtTitle.Text = dt.Rows[0]["SAEML_TITLE"].ToString();
					txtBody.Text = dt.Rows[0]["SAEML_BODY"].ToString();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
			finally
			{
				DataTable dt = null;
			}
		}

		private void frmLM1EMS_Load(object sender, EventArgs e)
		{
			BindDatafromDB();
		}

		private void frmMAECOD_FormClosing(object sender, FormClosingEventArgs e)
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

		public bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtSMTPServer.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("SMTP Server cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtSMTPServer.Focus();
				return false;
			}
			if (Operators.CompareString(txtSMTPPort.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("SMTP Port cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtSMTPPort.Focus();
				return false;
			}
			if (Operators.CompareString(txtSMTPEmail.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("SMTP Email cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtSMTPEmail.Focus();
				return false;
			}
			if (Operators.CompareString(txtSMTPID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Email ID cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtSMTPID.Focus();
				return false;
			}
			if (Operators.CompareString(txtSMTPPwd.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Password cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtSMTPPwd.Focus();
				return false;
			}
			if (chkACTFG.Checked && Operators.CompareString(txtTo.Text, string.Empty, false) == 0)
			{
				MessageBox.Show("To email list is empty!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtTo.Focus();
				return false;
			}
			return true;
		}
	}
}
