using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class frmINQLOT : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtLOTNO")]
		private TextBox _txtLOTNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtWKONO")]
		private TextBox _txtWKONO;

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvWH1")]
		internal virtual DataGridView dgvWH1
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

		[field: AccessedThroughProperty("lblCUSIDFR")]
		internal virtual Label lblCUSIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvWBWIPD")]
		internal virtual DataGridView dgvWBWIPD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvWH2")]
		internal virtual DataGridView dgvWH2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvRESIN")]
		internal virtual DataGridView dgvRESIN
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvBLENDING")]
		internal virtual DataGridView dgvBLENDING
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvSBWIP")]
		internal virtual DataGridView dgvSBWIP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvFG")]
		internal virtual DataGridView dgvFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvWBWIPM")]
		internal virtual DataGridView dgvWBWIPM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtLOTNO
		{
			[CompilerGenerated]
			get
			{
				return _txtLOTNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtLOTNO_KeyDown;
				TextBox textBox = _txtLOTNO;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtLOTNO = value;
				textBox = _txtLOTNO;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lblITMCD")]
		internal virtual Label lblITMCD
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		internal virtual TextBox txtWKONO
		{
			[CompilerGenerated]
			get
			{
				return _txtWKONO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtWKONO_KeyDown;
				TextBox textBox = _txtWKONO;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtWKONO = value;
				textBox = _txtWKONO;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblREVNO")]
		internal virtual Label lblREVNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmINQLOT()
		{
			base.FormClosing += frmINQLOT_FormClosing;
			base.Shown += frmINQLOT_Shown;
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
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.txtWKONO = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.dgvWBWIPM = new System.Windows.Forms.DataGridView();
			this.dgvWBWIPD = new System.Windows.Forms.DataGridView();
			this.txtLOTNO = new System.Windows.Forms.TextBox();
			this.lblITMCD = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.dgvBLENDING = new System.Windows.Forms.DataGridView();
			this.Label3 = new System.Windows.Forms.Label();
			this.dgvRESIN = new System.Windows.Forms.DataGridView();
			this.dgvSBWIP = new System.Windows.Forms.DataGridView();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.dgvWH2 = new System.Windows.Forms.DataGridView();
			this.Label6 = new System.Windows.Forms.Label();
			this.dgvWH1 = new System.Windows.Forms.DataGridView();
			this.Label7 = new System.Windows.Forms.Label();
			this.dgvFG = new System.Windows.Forms.DataGridView();
			this.Label8 = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblREVNO = new System.Windows.Forms.Label();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvWBWIPM).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWBWIPD).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvBLENDING).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvRESIN).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvSBWIP).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvFG).BeginInit();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel5);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1766, 800);
			this.Panel2.TabIndex = 2;
			this.TableLayoutPanel5.ColumnCount = 8;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 479f));
			this.TableLayoutPanel5.Controls.Add(this.lblREVNO, 2, 1);
			this.TableLayoutPanel5.Controls.Add(this.txtWKONO, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label9, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.btnPRINT, 4, 0);
			this.TableLayoutPanel5.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.dgvWBWIPM, 0, 7);
			this.TableLayoutPanel5.Controls.Add(this.dgvWBWIPD, 2, 7);
			this.TableLayoutPanel5.Controls.Add(this.txtLOTNO, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.lblITMCD, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label1, 0, 6);
			this.TableLayoutPanel5.Controls.Add(this.Label2, 2, 6);
			this.TableLayoutPanel5.Controls.Add(this.dgvBLENDING, 2, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label3, 2, 4);
			this.TableLayoutPanel5.Controls.Add(this.dgvRESIN, 0, 5);
			this.TableLayoutPanel5.Controls.Add(this.dgvSBWIP, 4, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label4, 0, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label5, 4, 4);
			this.TableLayoutPanel5.Controls.Add(this.dgvWH2, 2, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label6, 2, 2);
			this.TableLayoutPanel5.Controls.Add(this.dgvWH1, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label7, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.dgvFG, 4, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label8, 4, 2);
			this.TableLayoutPanel5.Controls.Add(this.btnClose, 5, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(8, 12);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 9;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(1543, 701);
			this.TableLayoutPanel5.TabIndex = 10;
			this.txtWKONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtWKONO.Location = new System.Drawing.Point(107, 32);
			this.txtWKONO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtWKONO.Name = "txtWKONO";
			this.txtWKONO.Size = new System.Drawing.Size(311, 22);
			this.txtWKONO.TabIndex = 33;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 37);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(98, 16);
			this.Label9.TabIndex = 32;
			this.Label9.Text = "Work Order No";
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(975, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.TableLayoutPanel5.SetRowSpan(this.btnPRINT, 2);
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 30;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 7);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(47, 16);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Lot No";
			this.dgvWBWIPM.AllowUserToAddRows = false;
			this.dgvWBWIPM.AllowUserToDeleteRows = false;
			this.dgvWBWIPM.AllowUserToResizeRows = false;
			this.dgvWBWIPM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvWBWIPM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWBWIPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvWBWIPM, 2);
			this.dgvWBWIPM.EnableHeadersVisualStyles = false;
			this.dgvWBWIPM.Location = new System.Drawing.Point(3, 501);
			this.dgvWBWIPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvWBWIPM.MultiSelect = false;
			this.dgvWBWIPM.Name = "dgvWBWIPM";
			this.dgvWBWIPM.ReadOnly = true;
			this.dgvWBWIPM.RowHeadersVisible = false;
			this.dgvWBWIPM.RowHeadersWidth = 51;
			this.dgvWBWIPM.RowTemplate.Height = 24;
			this.dgvWBWIPM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWBWIPM.Size = new System.Drawing.Size(480, 190);
			this.dgvWBWIPM.TabIndex = 17;
			this.dgvWBWIPD.AllowUserToAddRows = false;
			this.dgvWBWIPD.AllowUserToDeleteRows = false;
			this.dgvWBWIPD.AllowUserToResizeRows = false;
			this.dgvWBWIPD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvWBWIPD.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWBWIPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvWBWIPD, 2);
			this.dgvWBWIPD.EnableHeadersVisualStyles = false;
			this.dgvWBWIPD.Location = new System.Drawing.Point(489, 501);
			this.dgvWBWIPD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvWBWIPD.MultiSelect = false;
			this.dgvWBWIPD.Name = "dgvWBWIPD";
			this.dgvWBWIPD.ReadOnly = true;
			this.dgvWBWIPD.RowHeadersVisible = false;
			this.dgvWBWIPD.RowHeadersWidth = 51;
			this.dgvWBWIPD.RowTemplate.Height = 24;
			this.dgvWBWIPD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWBWIPD.Size = new System.Drawing.Size(480, 190);
			this.dgvWBWIPD.TabIndex = 19;
			this.txtLOTNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtLOTNO.Location = new System.Drawing.Point(107, 2);
			this.txtLOTNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLOTNO.Name = "txtLOTNO";
			this.txtLOTNO.Size = new System.Drawing.Size(311, 22);
			this.txtLOTNO.TabIndex = 20;
			this.lblITMCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCD.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.lblITMCD, 2);
			this.lblITMCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.lblITMCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCD.Location = new System.Drawing.Point(489, 6);
			this.lblITMCD.Name = "lblITMCD";
			this.lblITMCD.Size = new System.Drawing.Size(55, 17);
			this.lblITMCD.TabIndex = 21;
			this.lblITMCD.Text = "ITMCD";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label1, 2);
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 482);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 17);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "WB-WIP-MM";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label2, 2);
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(489, 482);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(83, 17);
			this.Label2.TabIndex = 23;
			this.Label2.Text = "WB-WIP-D";
			this.dgvBLENDING.AllowUserToAddRows = false;
			this.dgvBLENDING.AllowUserToDeleteRows = false;
			this.dgvBLENDING.AllowUserToResizeRows = false;
			this.dgvBLENDING.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvBLENDING.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvBLENDING.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvBLENDING, 2);
			this.dgvBLENDING.EnableHeadersVisualStyles = false;
			this.dgvBLENDING.Location = new System.Drawing.Point(489, 290);
			this.dgvBLENDING.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvBLENDING.MultiSelect = false;
			this.dgvBLENDING.Name = "dgvBLENDING";
			this.dgvBLENDING.ReadOnly = true;
			this.dgvBLENDING.RowHeadersVisible = false;
			this.dgvBLENDING.RowHeadersWidth = 51;
			this.dgvBLENDING.RowTemplate.Height = 24;
			this.dgvBLENDING.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBLENDING.Size = new System.Drawing.Size(480, 190);
			this.dgvBLENDING.TabIndex = 15;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label3, 2);
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(489, 271);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(86, 17);
			this.Label3.TabIndex = 24;
			this.Label3.Text = "BLENDING";
			this.dgvRESIN.AllowUserToAddRows = false;
			this.dgvRESIN.AllowUserToDeleteRows = false;
			this.dgvRESIN.AllowUserToResizeRows = false;
			this.dgvRESIN.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvRESIN.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvRESIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvRESIN, 2);
			this.dgvRESIN.EnableHeadersVisualStyles = false;
			this.dgvRESIN.Location = new System.Drawing.Point(3, 290);
			this.dgvRESIN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvRESIN.MultiSelect = false;
			this.dgvRESIN.Name = "dgvRESIN";
			this.dgvRESIN.ReadOnly = true;
			this.dgvRESIN.RowHeadersVisible = false;
			this.dgvRESIN.RowHeadersWidth = 51;
			this.dgvRESIN.RowTemplate.Height = 24;
			this.dgvRESIN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRESIN.Size = new System.Drawing.Size(480, 190);
			this.dgvRESIN.TabIndex = 14;
			this.dgvSBWIP.AllowUserToAddRows = false;
			this.dgvSBWIP.AllowUserToDeleteRows = false;
			this.dgvSBWIP.AllowUserToResizeRows = false;
			this.dgvSBWIP.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvSBWIP.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvSBWIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvSBWIP, 3);
			this.dgvSBWIP.EnableHeadersVisualStyles = false;
			this.dgvSBWIP.Location = new System.Drawing.Point(975, 290);
			this.dgvSBWIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvSBWIP.MultiSelect = false;
			this.dgvSBWIP.Name = "dgvSBWIP";
			this.dgvSBWIP.ReadOnly = true;
			this.dgvSBWIP.RowHeadersVisible = false;
			this.dgvSBWIP.RowHeadersWidth = 51;
			this.dgvSBWIP.RowTemplate.Height = 24;
			this.dgvSBWIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSBWIP.Size = new System.Drawing.Size(480, 190);
			this.dgvSBWIP.TabIndex = 16;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label4, 2);
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 271);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(54, 17);
			this.Label4.TabIndex = 25;
			this.Label4.Text = "RESIN";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label5, 2);
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(975, 271);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(62, 17);
			this.Label5.TabIndex = 26;
			this.Label5.Text = "SB-WIP";
			this.dgvWH2.AllowUserToAddRows = false;
			this.dgvWH2.AllowUserToDeleteRows = false;
			this.dgvWH2.AllowUserToResizeRows = false;
			this.dgvWH2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvWH2.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWH2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvWH2, 2);
			this.dgvWH2.EnableHeadersVisualStyles = false;
			this.dgvWH2.Location = new System.Drawing.Point(489, 79);
			this.dgvWH2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvWH2.MultiSelect = false;
			this.dgvWH2.Name = "dgvWH2";
			this.dgvWH2.ReadOnly = true;
			this.dgvWH2.RowHeadersVisible = false;
			this.dgvWH2.RowHeadersWidth = 51;
			this.dgvWH2.RowTemplate.Height = 24;
			this.dgvWH2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWH2.Size = new System.Drawing.Size(480, 190);
			this.dgvWH2.TabIndex = 13;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label6, 2);
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(489, 60);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(42, 17);
			this.Label6.TabIndex = 27;
			this.Label6.Text = "WH2";
			this.dgvWH1.AllowUserToAddRows = false;
			this.dgvWH1.AllowUserToDeleteRows = false;
			this.dgvWH1.AllowUserToResizeRows = false;
			this.dgvWH1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvWH1.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWH1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvWH1, 2);
			this.dgvWH1.EnableHeadersVisualStyles = false;
			this.dgvWH1.Location = new System.Drawing.Point(3, 79);
			this.dgvWH1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvWH1.MultiSelect = false;
			this.dgvWH1.Name = "dgvWH1";
			this.dgvWH1.ReadOnly = true;
			this.dgvWH1.RowHeadersVisible = false;
			this.dgvWH1.RowHeadersWidth = 51;
			this.dgvWH1.RowTemplate.Height = 24;
			this.dgvWH1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWH1.Size = new System.Drawing.Size(480, 190);
			this.dgvWH1.TabIndex = 0;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label7, 2);
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 60);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(48, 17);
			this.Label7.TabIndex = 28;
			this.Label7.Text = "WH-1";
			this.dgvFG.AllowUserToAddRows = false;
			this.dgvFG.AllowUserToDeleteRows = false;
			this.dgvFG.AllowUserToResizeRows = false;
			this.dgvFG.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvFG.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvFG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvFG, 3);
			this.dgvFG.EnableHeadersVisualStyles = false;
			this.dgvFG.Location = new System.Drawing.Point(975, 79);
			this.dgvFG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvFG.MultiSelect = false;
			this.dgvFG.Name = "dgvFG";
			this.dgvFG.ReadOnly = true;
			this.dgvFG.RowHeadersVisible = false;
			this.dgvFG.RowHeadersWidth = 51;
			this.dgvFG.RowTemplate.Height = 24;
			this.dgvFG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFG.Size = new System.Drawing.Size(480, 190);
			this.dgvFG.TabIndex = 18;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.Label8, 2);
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(975, 60);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(29, 17);
			this.Label8.TabIndex = 29;
			this.Label8.Text = "FG";
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(1101, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel5.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.lblREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREVNO.AutoSize = true;
			this.TableLayoutPanel5.SetColumnSpan(this.lblREVNO, 2);
			this.lblREVNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.lblREVNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREVNO.Location = new System.Drawing.Point(489, 36);
			this.lblREVNO.Name = "lblREVNO";
			this.lblREVNO.Size = new System.Drawing.Size(62, 17);
			this.lblREVNO.TabIndex = 34;
			this.lblREVNO.Text = "REVNO";
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1556, 770);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmINQLOT";
			base.Tag = "INQLOT";
			this.Text = "Lot No Inquiry";
			this.Panel2.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvWBWIPM).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWBWIPD).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvBLENDING).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvRESIN).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvSBWIP).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvWH1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvFG).EndInit();
			base.ResumeLayout(false);
		}

		private void frmINQLOT_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmINQLOT_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
		}

		private void BindDetails()
		{
			int constDocNo = 100;
			int constDocDate = 75;
			int constRefNo = 90;
			int constIn = 60;
			int constOut = 60;
			int constBal = 75;
			dgvWH1.DataSource = null;
			dgvWH2.DataSource = null;
			dgvFG.DataSource = null;
			dgvRESIN.DataSource = null;
			dgvBLENDING.DataSource = null;
			dgvSBWIP.DataSource = null;
			dgvWBWIPM.DataSource = null;
			dgvWBWIPD.DataSource = null;
			string strSQL = "EXEC spINQLOT '" + MyProject.Computer.Name + "', '" + Common.gfValidSQLStr(txtLOTNO.Text) + "' ";
			DB.ExecProc(strSQL);
			strSQL = "SELECT DOCNO, CONVERT(VARCHAR(10), DOCDT, 103) AS DOCDT, REFNO, ";
			strSQL += "CASE WHEN IOFLG = 1 THEN QTY ELSE 0 END AS IN_QTY, ";
			strSQL += "CASE WHEN IOFLG = 3 THEN QTY ELSE 0 END AS OUT_QTY, BALQT ";
			strSQL += "FROM INQLOT_WRK ";
			strSQL = strSQL + "WHERE COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND LOCID = 'WH1' ORDER BY RECID";
			DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView = dgvWH1;
				dataGridView.DataSource = dt;
				dataGridView.Columns[0].Visible = true;
				dataGridView.Columns[0].Width = constDocNo;
				dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
				dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[0].ReadOnly = true;
				dataGridView.Columns[1].Visible = true;
				dataGridView.Columns[1].Width = constDocDate;
				dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[1].ReadOnly = true;
				dataGridView.Columns[2].Visible = true;
				dataGridView.Columns[2].Width = constRefNo;
				dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
				dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[2].ReadOnly = true;
				dataGridView.Columns[3].Visible = true;
				dataGridView.Columns[3].Width = constIn;
				dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In");
				dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[3].ReadOnly = true;
				dataGridView.Columns[4].Visible = true;
				dataGridView.Columns[4].Width = constOut;
				dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out");
				dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[4].ReadOnly = true;
				dataGridView.Columns[5].Visible = true;
				dataGridView.Columns[5].Width = constBal;
				dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[5].ReadOnly = true;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
			strSQL = "SELECT DOCNO, CONVERT(VARCHAR(10), DOCDT, 103) AS DOCDT, REFNO, ";
			strSQL += "CASE WHEN IOFLG = 1 THEN QTY ELSE 0 END AS IN_QTY, ";
			strSQL += "CASE WHEN IOFLG = 3 THEN QTY ELSE 0 END AS OUT_QTY, BALQT ";
			strSQL += "FROM INQLOT_WRK ";
			strSQL = strSQL + "WHERE COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND LOCID = 'WH2' ORDER BY RECID";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView2 = dgvWH2;
				dataGridView2.DataSource = dt;
				dataGridView2.Columns[0].Visible = true;
				dataGridView2.Columns[0].Width = constDocNo;
				dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
				dataGridView2.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[0].ReadOnly = true;
				dataGridView2.Columns[1].Visible = true;
				dataGridView2.Columns[1].Width = constDocDate;
				dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView2.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[1].ReadOnly = true;
				dataGridView2.Columns[2].Visible = true;
				dataGridView2.Columns[2].Width = constRefNo;
				dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
				dataGridView2.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[2].ReadOnly = true;
				dataGridView2.Columns[3].Visible = true;
				dataGridView2.Columns[3].Width = constIn;
				dataGridView2.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In");
				dataGridView2.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView2.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[3].ReadOnly = true;
				dataGridView2.Columns[4].Visible = true;
				dataGridView2.Columns[4].Width = constOut;
				dataGridView2.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out");
				dataGridView2.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView2.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView2.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[4].ReadOnly = true;
				dataGridView2.Columns[5].Visible = true;
				dataGridView2.Columns[5].Width = constBal;
				dataGridView2.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView2.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView2.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView2.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView2.Columns[5].ReadOnly = true;
				dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView2.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView2.Refresh();
				dataGridView2 = null;
			}
			strSQL = "SELECT DOCNO, CONVERT(VARCHAR(10), DOCDT, 103) AS DOCDT, REFNO, ";
			strSQL += "CASE WHEN IOFLG = 1 THEN QTY ELSE 0 END AS IN_QTY, ";
			strSQL += "CASE WHEN IOFLG = 3 THEN QTY ELSE 0 END AS OUT_QTY, BALQT ";
			strSQL += "FROM INQLOT_WRK ";
			strSQL = strSQL + "WHERE COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND LOCID = 'FG' ORDER BY RECID";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView3 = dgvFG;
				dataGridView3.DataSource = dt;
				dataGridView3.Columns[0].Visible = true;
				dataGridView3.Columns[0].Width = constDocNo;
				dataGridView3.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
				dataGridView3.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[0].ReadOnly = true;
				dataGridView3.Columns[1].Visible = true;
				dataGridView3.Columns[1].Width = constDocDate;
				dataGridView3.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView3.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[1].ReadOnly = true;
				dataGridView3.Columns[2].Visible = true;
				dataGridView3.Columns[2].Width = constRefNo;
				dataGridView3.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
				dataGridView3.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[2].ReadOnly = true;
				dataGridView3.Columns[3].Visible = true;
				dataGridView3.Columns[3].Width = constIn;
				dataGridView3.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In");
				dataGridView3.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView3.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView3.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[3].ReadOnly = true;
				dataGridView3.Columns[4].Visible = true;
				dataGridView3.Columns[4].Width = constOut;
				dataGridView3.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out");
				dataGridView3.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView3.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView3.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[4].ReadOnly = true;
				dataGridView3.Columns[5].Visible = true;
				dataGridView3.Columns[5].Width = constBal;
				dataGridView3.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView3.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView3.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView3.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView3.Columns[5].ReadOnly = true;
				dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView3.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView3.Refresh();
				dataGridView3 = null;
			}
			strSQL = "SELECT DOCNO, CONVERT(VARCHAR(10), DOCDT, 103) AS DOCDT, REFNO, ";
			strSQL += "CASE WHEN IOFLG = 1 THEN QTY ELSE 0 END AS IN_QTY, ";
			strSQL += "CASE WHEN IOFLG = 3 THEN QTY ELSE 0 END AS OUT_QTY, BALQT ";
			strSQL += "FROM INQLOT_WRK ";
			strSQL = strSQL + "WHERE COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND LOCID = 'RESIN' ORDER BY RECID";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView4 = dgvRESIN;
				dataGridView4.DataSource = dt;
				dataGridView4.Columns[0].Visible = true;
				dataGridView4.Columns[0].Width = constDocNo;
				dataGridView4.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
				dataGridView4.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[0].ReadOnly = true;
				dataGridView4.Columns[1].Visible = true;
				dataGridView4.Columns[1].Width = constDocDate;
				dataGridView4.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView4.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[1].ReadOnly = true;
				dataGridView4.Columns[2].Visible = true;
				dataGridView4.Columns[2].Width = constRefNo;
				dataGridView4.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
				dataGridView4.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[2].ReadOnly = true;
				dataGridView4.Columns[3].Visible = true;
				dataGridView4.Columns[3].Width = constIn;
				dataGridView4.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In");
				dataGridView4.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView4.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView4.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[3].ReadOnly = true;
				dataGridView4.Columns[4].Visible = true;
				dataGridView4.Columns[4].Width = constOut;
				dataGridView4.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out");
				dataGridView4.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView4.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView4.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[4].ReadOnly = true;
				dataGridView4.Columns[5].Visible = true;
				dataGridView4.Columns[5].Width = constBal;
				dataGridView4.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView4.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView4.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView4.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView4.Columns[5].ReadOnly = true;
				dataGridView4.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView4.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView4.Refresh();
				dataGridView4 = null;
			}
			strSQL = "SELECT DOCNO, CONVERT(VARCHAR(10), DOCDT, 103) AS DOCDT, REFNO, ";
			strSQL += "CASE WHEN IOFLG = 1 THEN QTY ELSE 0 END AS IN_QTY, ";
			strSQL += "CASE WHEN IOFLG = 3 THEN QTY ELSE 0 END AS OUT_QTY, BALQT ";
			strSQL += "FROM INQLOT_WRK ";
			strSQL = strSQL + "WHERE COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND LOCID = 'BLENDING' ORDER BY RECID";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView5 = dgvBLENDING;
				dataGridView5.DataSource = dt;
				dataGridView5.Columns[0].Visible = true;
				dataGridView5.Columns[0].Width = constDocNo;
				dataGridView5.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
				dataGridView5.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[0].ReadOnly = true;
				dataGridView5.Columns[1].Visible = true;
				dataGridView5.Columns[1].Width = constDocDate;
				dataGridView5.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView5.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[1].ReadOnly = true;
				dataGridView5.Columns[2].Visible = true;
				dataGridView5.Columns[2].Width = constRefNo;
				dataGridView5.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
				dataGridView5.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[2].ReadOnly = true;
				dataGridView5.Columns[3].Visible = true;
				dataGridView5.Columns[3].Width = constIn;
				dataGridView5.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In");
				dataGridView5.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView5.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView5.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[3].ReadOnly = true;
				dataGridView5.Columns[4].Visible = true;
				dataGridView5.Columns[4].Width = constOut;
				dataGridView5.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out");
				dataGridView5.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView5.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView5.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[4].ReadOnly = true;
				dataGridView5.Columns[5].Visible = true;
				dataGridView5.Columns[5].Width = constBal;
				dataGridView5.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView5.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView5.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView5.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView5.Columns[5].ReadOnly = true;
				dataGridView5.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView5.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView5.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView5.Refresh();
				dataGridView5 = null;
			}
			strSQL = "SELECT DOCNO, CONVERT(VARCHAR(10), DOCDT, 103) AS DOCDT, REFNO, ";
			strSQL += "CASE WHEN IOFLG = 1 THEN QTY ELSE 0 END AS IN_QTY, ";
			strSQL += "CASE WHEN IOFLG = 3 THEN QTY ELSE 0 END AS OUT_QTY, BALQT ";
			strSQL += "FROM INQLOT_WRK ";
			strSQL = strSQL + "WHERE COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND LOCID = 'SB-WIP' ORDER BY RECID";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView6 = dgvSBWIP;
				dataGridView6.DataSource = dt;
				dataGridView6.Columns[0].Visible = true;
				dataGridView6.Columns[0].Width = constDocNo;
				dataGridView6.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
				dataGridView6.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[0].ReadOnly = true;
				dataGridView6.Columns[1].Visible = true;
				dataGridView6.Columns[1].Width = constDocDate;
				dataGridView6.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView6.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[1].ReadOnly = true;
				dataGridView6.Columns[2].Visible = true;
				dataGridView6.Columns[2].Width = constRefNo;
				dataGridView6.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
				dataGridView6.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[2].ReadOnly = true;
				dataGridView6.Columns[3].Visible = true;
				dataGridView6.Columns[3].Width = constIn;
				dataGridView6.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In");
				dataGridView6.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView6.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView6.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[3].ReadOnly = true;
				dataGridView6.Columns[4].Visible = true;
				dataGridView6.Columns[4].Width = constOut;
				dataGridView6.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out");
				dataGridView6.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView6.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView6.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[4].ReadOnly = true;
				dataGridView6.Columns[5].Visible = true;
				dataGridView6.Columns[5].Width = constBal;
				dataGridView6.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView6.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView6.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView6.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView6.Columns[5].ReadOnly = true;
				dataGridView6.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView6.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView6.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView6.Refresh();
				dataGridView6 = null;
			}
			strSQL = "SELECT DOCNO, CONVERT(VARCHAR(10), DOCDT, 103) AS DOCDT, REFNO, ";
			strSQL += "CASE WHEN IOFLG = 1 THEN QTY ELSE 0 END AS IN_QTY, ";
			strSQL += "CASE WHEN IOFLG = 3 THEN QTY ELSE 0 END AS OUT_QTY, BALQT ";
			strSQL += "FROM INQLOT_WRK ";
			strSQL = strSQL + "WHERE COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND LOCID = 'WB-WIP-MM' ORDER BY RECID";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView7 = dgvWBWIPM;
				dataGridView7.DataSource = dt;
				dataGridView7.Columns[0].Visible = true;
				dataGridView7.Columns[0].Width = constDocNo;
				dataGridView7.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
				dataGridView7.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[0].ReadOnly = true;
				dataGridView7.Columns[1].Visible = true;
				dataGridView7.Columns[1].Width = constDocDate;
				dataGridView7.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView7.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[1].ReadOnly = true;
				dataGridView7.Columns[2].Visible = true;
				dataGridView7.Columns[2].Width = constRefNo;
				dataGridView7.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
				dataGridView7.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[2].ReadOnly = true;
				dataGridView7.Columns[3].Visible = true;
				dataGridView7.Columns[3].Width = constIn;
				dataGridView7.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In");
				dataGridView7.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView7.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView7.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[3].ReadOnly = true;
				dataGridView7.Columns[4].Visible = true;
				dataGridView7.Columns[4].Width = constOut;
				dataGridView7.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out");
				dataGridView7.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView7.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView7.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[4].ReadOnly = true;
				dataGridView7.Columns[5].Visible = true;
				dataGridView7.Columns[5].Width = constBal;
				dataGridView7.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView7.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView7.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView7.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView7.Columns[5].ReadOnly = true;
				dataGridView7.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView7.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView7.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView7.Refresh();
				dataGridView7 = null;
			}
			strSQL = "SELECT DOCNO, CONVERT(VARCHAR(10), DOCDT, 103) AS DOCDT, REFNO, ";
			strSQL += "CASE WHEN IOFLG = 1 THEN QTY ELSE 0 END AS IN_QTY, ";
			strSQL += "CASE WHEN IOFLG = 3 THEN QTY ELSE 0 END AS OUT_QTY, BALQT ";
			strSQL += "FROM INQLOT_WRK ";
			strSQL = strSQL + "WHERE COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND LOCID = 'WB-WIP-D' ORDER BY RECID";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				DataGridView dataGridView8 = dgvWBWIPD;
				dataGridView8.DataSource = dt;
				dataGridView8.Columns[0].Visible = true;
				dataGridView8.Columns[0].Width = constDocNo;
				dataGridView8.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
				dataGridView8.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[0].ReadOnly = true;
				dataGridView8.Columns[1].Visible = true;
				dataGridView8.Columns[1].Width = constDocDate;
				dataGridView8.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
				dataGridView8.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[1].ReadOnly = true;
				dataGridView8.Columns[2].Visible = true;
				dataGridView8.Columns[2].Width = constRefNo;
				dataGridView8.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
				dataGridView8.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[2].ReadOnly = true;
				dataGridView8.Columns[3].Visible = true;
				dataGridView8.Columns[3].Width = constIn;
				dataGridView8.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "In");
				dataGridView8.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView8.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView8.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[3].ReadOnly = true;
				dataGridView8.Columns[4].Visible = true;
				dataGridView8.Columns[4].Width = constOut;
				dataGridView8.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Out");
				dataGridView8.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView8.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView8.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[4].ReadOnly = true;
				dataGridView8.Columns[5].Visible = true;
				dataGridView8.Columns[5].Width = constBal;
				dataGridView8.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView8.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView8.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView8.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView8.Columns[5].ReadOnly = true;
				dataGridView8.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView8.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView8.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView8.Refresh();
				dataGridView8 = null;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtLOTNO_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return))
			{
				string strSQL = "EXEC spINQLOT_Info '" + txtLOTNO.Text + "'";
				DataTable dt = DB.ExecProc(strSQL);
				lblITMCD.Text = Conversions.ToString(dt.Rows[0]["ITMCD"]);
				lblREVNO.Text = Conversions.ToString(dt.Rows[0]["REVNO"]);
				txtWKONO.Text = Conversions.ToString(dt.Rows[0]["REFNO"]);
				BindDetails();
			}
		}

		private void txtWKONO_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return))
			{
				
				string strSQL = "EXEC spINQLOT_Info '" + txtWKONO.Text + "'";
				DataTable dt = DB.ExecProc(strSQL);
				if (dt.Rows.Count == 0) return;
                    lblITMCD.Text = Conversions.ToString(dt.Rows[0]["ITMCD"]);
				lblREVNO.Text = Conversions.ToString(dt.Rows[0]["REVNO"]);
				txtLOTNO.Text = Conversions.ToString(dt.Rows[0]["REFNO"]);
				BindDetails();
			}
		}

		private void btnPRINT_Click(object sender, EventArgs e)
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
			frmRPT.ReportName = "Lot No Tracking Detail";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptINRLOT.rpt";
			frmRPT.Params = "@LOTNO=" + txtLOTNO.Text;
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='Lot No Tracking Detail',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}
	}
}
