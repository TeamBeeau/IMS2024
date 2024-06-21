using System;
using System.ComponentModel;
using System.Data;
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
	public class frmMAEMCH : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMAMCH")]
		private DataGridView _dgvMAMCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private Button _btnPRINTFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbMCHIDFR")]
		private ComboBox _cbMCHIDFR;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDELID")]
		internal virtual Label lblDELID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDELNM")]
		internal virtual Label lblDELNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblADDR1")]
		internal virtual Label lblADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtMCHNM")]
		internal virtual TextBox txtMCHNM
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

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblREMRK")]
		internal virtual Label lblREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvMAMCH
		{
			[CompilerGenerated]
			get
			{
				return _dgvMAMCH;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMADEL_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMAMCH;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMAMCH = value;
				dataGridView = _dgvMAMCH;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSEARCH
		{
			[CompilerGenerated]
			get
			{
				return _btnSEARCH;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSEARCH_Click;
				Button button = _btnSEARCH;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSEARCH = value;
				button = _btnSEARCH;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnBack
		{
			[CompilerGenerated]
			get
			{
				return _btnBack;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnBack_Click;
				Button button = _btnBack;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnBack = value;
				button = _btnBack;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnCancel
		{
			[CompilerGenerated]
			get
			{
				return _btnCancel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCancel_Click;
				Button button = _btnCancel;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCancel = value;
				button = _btnCancel;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnDelete
		{
			[CompilerGenerated]
			get
			{
				return _btnDelete;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDelete_Click;
				Button button = _btnDelete;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDelete = value;
				button = _btnDelete;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnNew
		{
			[CompilerGenerated]
			get
			{
				return _btnNew;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnNew_Click;
				Button button = _btnNew;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnNew = value;
				button = _btnNew;
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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
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

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

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

		[field: AccessedThroughProperty("txtMCHID")]
		internal virtual TextBox txtMCHID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cboSTSFG")]
		internal virtual ComboBox cboSTSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbOPRNO")]
		internal virtual ComboBox cbOPRNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbMCHIDTO")]
		internal virtual ComboBox cbMCHIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbMCHIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbMCHIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbMCHIDFR_SelectedIndexChanged;
				ComboBox comboBox = _cbMCHIDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbMCHIDFR = value;
				comboBox = _cbMCHIDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cboMRPFG")]
		internal virtual ComboBox cboMRPFG
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

		[field: AccessedThroughProperty("chkISSFG")]
		internal virtual CheckBox chkISSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAMCH_MCHID")]
		internal virtual DataGridViewTextBoxColumn MAMCH_MCHID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAMCH_MCHNM")]
		internal virtual DataGridViewTextBoxColumn MAMCH_MCHNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAMCH_PROCD")]
		internal virtual DataGridViewTextBoxColumn MAMCH_PROCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("STSFGNM")]
		internal virtual DataGridViewTextBoxColumn STSFGNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAMCH_STSFG")]
		internal virtual DataGridViewTextBoxColumn MAMCH_STSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAMCH_MRPFG")]
		internal virtual DataGridViewTextBoxColumn MAMCH_MRPFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAMCH_ISSFG")]
		internal virtual DataGridViewTextBoxColumn MAMCH_ISSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAMCH_REMRK")]
		internal virtual DataGridViewTextBoxColumn MAMCH_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAEMCH()
		{
			base.FormClosing += frmMAEMCH_FormClosing;
			base.Shown += frmMAEMCH_Shown;
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
			this.Label5 = new System.Windows.Forms.Label();
			this.cboMRPFG = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbOPRNO = new System.Windows.Forms.ComboBox();
			this.cboSTSFG = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.txtMCHID = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblDELID = new System.Windows.Forms.Label();
			this.lblDELNM = new System.Windows.Forms.Label();
			this.txtMCHNM = new System.Windows.Forms.TextBox();
			this.lblADDR1 = new System.Windows.Forms.Label();
			this.chkISSFG = new System.Windows.Forms.CheckBox();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbMCHIDTO = new System.Windows.Forms.ComboBox();
			this.cbMCHIDFR = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.dgvMAMCH = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.MAMCH_MCHID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAMCH_MCHNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAMCH_PROCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STSFGNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAMCH_STSFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAMCH_MRPFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAMCH_ISSFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAMCH_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMAMCH).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.cboMRPFG, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.cbOPRNO, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.cboSTSFG, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.txtMCHID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblDELID, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblDELNM, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtMCHNM, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblADDR1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.chkISSFG, 1, 6);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(636, 269);
			this.TableLayoutPanel1.TabIndex = 0;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 175);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(67, 16);
			this.Label5.TabIndex = 22;
			this.Label5.Text = "Part Issue";
			this.cboMRPFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cboMRPFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMRPFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cboMRPFG.FormattingEnabled = true;
			this.cboMRPFG.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cboMRPFG.Location = new System.Drawing.Point(110, 143);
			this.cboMRPFG.Margin = new System.Windows.Forms.Padding(5);
			this.cboMRPFG.Name = "cboMRPFG";
			this.cboMRPFG.Size = new System.Drawing.Size(120, 25);
			this.cboMRPFG.TabIndex = 6;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 147);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(38, 16);
			this.Label2.TabIndex = 18;
			this.Label2.Text = "MRP";
			this.cbOPRNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOPRNO.FormattingEnabled = true;
			this.cbOPRNO.Location = new System.Drawing.Point(108, 55);
			this.cbOPRNO.Name = "cbOPRNO";
			this.cbOPRNO.Size = new System.Drawing.Size(214, 24);
			this.cbOPRNO.TabIndex = 3;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Location = new System.Drawing.Point(108, 85);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(133, 24);
			this.cboSTSFG.TabIndex = 4;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 5;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 2);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnBack, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 215);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(630, 52);
			this.TableLayoutPanel3.TabIndex = 20;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(507, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 48);
			this.btnPRINT.TabIndex = 12;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(3, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 48);
			this.btnSAVE.TabIndex = 8;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 48);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(381, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 48);
			this.btnBack.TabIndex = 11;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(129, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 48);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.txtMCHID.Location = new System.Drawing.Point(108, 2);
			this.txtMCHID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMCHID.Name = "txtMCHID";
			this.txtMCHID.Size = new System.Drawing.Size(166, 22);
			this.txtMCHID.TabIndex = 1;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(80, 16);
			this.Label1.TabIndex = 21;
			this.Label1.Text = "Machine No";
			this.txtREMRK.Location = new System.Drawing.Point(108, 114);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(416, 22);
			this.txtREMRK.TabIndex = 5;
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 117);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(63, 16);
			this.lblREMRK.TabIndex = 17;
			this.lblREMRK.Text = "Remarks";
			this.lblDELID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDELID.AutoSize = true;
			this.lblDELID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDELID.Location = new System.Drawing.Point(3, 31);
			this.lblDELID.Name = "lblDELID";
			this.lblDELID.Size = new System.Drawing.Size(99, 16);
			this.lblDELID.TabIndex = 0;
			this.lblDELID.Text = "Machine Name";
			this.lblDELNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDELNM.AutoSize = true;
			this.lblDELNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDELNM.Location = new System.Drawing.Point(3, 59);
			this.lblDELNM.Name = "lblDELNM";
			this.lblDELNM.Size = new System.Drawing.Size(88, 16);
			this.lblDELNM.TabIndex = 1;
			this.lblDELNM.Text = "Operation No";
			this.txtMCHNM.Location = new System.Drawing.Point(108, 28);
			this.txtMCHNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMCHNM.Name = "txtMCHNM";
			this.txtMCHNM.Size = new System.Drawing.Size(263, 22);
			this.txtMCHNM.TabIndex = 2;
			this.lblADDR1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblADDR1.AutoSize = true;
			this.lblADDR1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblADDR1.Location = new System.Drawing.Point(3, 89);
			this.lblADDR1.Name = "lblADDR1";
			this.lblADDR1.Size = new System.Drawing.Size(45, 16);
			this.lblADDR1.TabIndex = 5;
			this.lblADDR1.Text = "Status";
			this.chkISSFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkISSFG.AutoSize = true;
			this.chkISSFG.Location = new System.Drawing.Point(108, 176);
			this.chkISSFG.Name = "chkISSFG";
			this.chkISSFG.Size = new System.Drawing.Size(15, 14);
			this.chkISSFG.TabIndex = 7;
			this.chkISSFG.UseVisualStyleBackColor = true;
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(255, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 48);
			this.btnPRINTFR.TabIndex = 22;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(129, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 48);
			this.btnNew.TabIndex = 6;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(3, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 48);
			this.btnSEARCH.TabIndex = 5;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbMCHIDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbMCHIDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label4, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label3, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(552, 30);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbMCHIDTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMCHIDTO.FormattingEnabled = true;
			this.cbMCHIDTO.Location = new System.Drawing.Point(335, 3);
			this.cbMCHIDTO.Name = "cbMCHIDTO";
			this.cbMCHIDTO.Size = new System.Drawing.Size(214, 24);
			this.cbMCHIDTO.TabIndex = 25;
			this.cbMCHIDFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMCHIDFR.FormattingEnabled = true;
			this.cbMCHIDFR.Location = new System.Drawing.Point(84, 3);
			this.cbMCHIDFR.Name = "cbMCHIDFR";
			this.cbMCHIDFR.Size = new System.Drawing.Size(214, 24);
			this.cbMCHIDFR.TabIndex = 24;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(304, 7);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(25, 16);
			this.Label4.TabIndex = 23;
			this.Label4.Text = "To";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 7);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(75, 16);
			this.Label3.TabIndex = 23;
			this.Label3.Text = "Machine ID";
			this.dgvMAMCH.AllowUserToAddRows = false;
			this.dgvMAMCH.AllowUserToDeleteRows = false;
			this.dgvMAMCH.AllowUserToResizeRows = false;
			this.dgvMAMCH.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMAMCH.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMAMCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMAMCH.Columns.AddRange(this.MAMCH_MCHID, this.MAMCH_MCHNM, this.MAMCH_PROCD, this.STSFGNM, this.MAMCH_STSFG, this.MAMCH_MRPFG, this.MAMCH_ISSFG, this.MAMCH_REMRK);
			this.dgvMAMCH.Location = new System.Drawing.Point(5, 118);
			this.dgvMAMCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMAMCH.MultiSelect = false;
			this.dgvMAMCH.Name = "dgvMAMCH";
			this.dgvMAMCH.ReadOnly = true;
			this.dgvMAMCH.RowHeadersVisible = false;
			this.dgvMAMCH.RowTemplate.Height = 24;
			this.dgvMAMCH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMAMCH.Size = new System.Drawing.Size(1320, 500);
			this.dgvMAMCH.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1340, 600);
			this.Panel1.TabIndex = 21;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvMAMCH);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1350, 632);
			this.Panel2.TabIndex = 23;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 59);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52f));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(504, 52);
			this.TableLayoutPanel4.TabIndex = 23;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(381, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 48);
			this.btnClose.TabIndex = 24;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.MAMCH_MCHID.DataPropertyName = "MAMCH_MCHID";
			this.MAMCH_MCHID.HeaderText = "Machine No";
			this.MAMCH_MCHID.Name = "MAMCH_MCHID";
			this.MAMCH_MCHID.ReadOnly = true;
			this.MAMCH_MCHID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAMCH_MCHID.Width = 150;
			this.MAMCH_MCHNM.DataPropertyName = "MAMCH_MCHNM";
			this.MAMCH_MCHNM.HeaderText = "Machine Name";
			this.MAMCH_MCHNM.Name = "MAMCH_MCHNM";
			this.MAMCH_MCHNM.ReadOnly = true;
			this.MAMCH_MCHNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAMCH_MCHNM.Width = 250;
			this.MAMCH_PROCD.DataPropertyName = "MAMCH_PROCD";
			this.MAMCH_PROCD.HeaderText = "Operation No";
			this.MAMCH_PROCD.Name = "MAMCH_PROCD";
			this.MAMCH_PROCD.ReadOnly = true;
			this.MAMCH_PROCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.STSFGNM.DataPropertyName = "STSFGNM";
			this.STSFGNM.HeaderText = "Status";
			this.STSFGNM.Name = "STSFGNM";
			this.STSFGNM.ReadOnly = true;
			this.STSFGNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAMCH_STSFG.HeaderText = "STSFG";
			this.MAMCH_STSFG.Name = "MAMCH_STSFG";
			this.MAMCH_STSFG.ReadOnly = true;
			this.MAMCH_STSFG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAMCH_STSFG.Visible = false;
			this.MAMCH_MRPFG.HeaderText = "MRPFG";
			this.MAMCH_MRPFG.Name = "MAMCH_MRPFG";
			this.MAMCH_MRPFG.ReadOnly = true;
			this.MAMCH_MRPFG.Visible = false;
			this.MAMCH_ISSFG.HeaderText = "ISSFG";
			this.MAMCH_ISSFG.Name = "MAMCH_ISSFG";
			this.MAMCH_ISSFG.ReadOnly = true;
			this.MAMCH_ISSFG.Visible = false;
			this.MAMCH_REMRK.DataPropertyName = "MAMCH_REMRK";
			this.MAMCH_REMRK.HeaderText = "Remark";
			this.MAMCH_REMRK.Name = "MAMCH_REMRK";
			this.MAMCH_REMRK.ReadOnly = true;
			this.MAMCH_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAMCH_REMRK.Width = 300;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAEMCH";
			base.Tag = "MAEMCH";
			this.Text = "Machine Master";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMAMCH).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			BindComboBox();
			ClearDetails();
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			spMAEMCH("0");
		}

		private bool spMAEMCH(string strPRO)
		{
			Cursor = Cursors.WaitCursor;
			bool spMAEMCH = default(bool);
			if (!ValidateDetailControl())
			{
				Cursor = Cursors.Default;
			}
			else
			{
				string strSQL = "EXEC spMAEMCH ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(strPRO) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(txtMCHID.Text) + "', ";
				strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtMCHNM.Text) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbOPRNO.SelectedValue)) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cboSTSFG.SelectedIndex)) + "', ";
				strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtREMRK.Text) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cboMRPFG.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkISSFG.Checked, 1, 0), ", ")));
				strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), Conversions.ToString(Interaction.IIf(Operators.CompareString(strPRO, "0", false) == 0, "Record edited!", "Record deleted!"))), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Cursor = Cursors.Default;
					spMAEMCH = false;
					ProjectData.ClearProjectError();
					goto IL_023a;
				}
				Cursor = Cursors.Default;
				Header();
				ClearDetails();
				spMAEMCH = true;
			}
			goto IL_023a;
			IL_023a:
			return spMAEMCH;
		}

		private void BindComboHeader()
		{
			string strSQL = "SELECT '' as MAMCH_MCHID, '' as MAMCH_MCHNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MAMCH_MCHID, MAMCH_MCHNM ";
			strSQL += "FROM MAMCH_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MAMCH_MCHID ";
			cbMCHIDFR.ValueMember = "MAMCH_MCHID";
			cbMCHIDFR.DisplayMember = "MAMCH_MCHNM";
			Common.RetriveComboItembySQL(strSQL, cbMCHIDFR);
			cbMCHIDTO.ValueMember = "MAMCH_MCHID";
			cbMCHIDTO.DisplayMember = "MAMCH_MCHNM";
			Common.RetriveComboItembySQL(strSQL, cbMCHIDTO);
		}

		private void Header()
		{
			int count = dgvMAMCH.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvMAMCH.Rows.Remove(dgvMAMCH.Rows[0]);
				}
				string strSQL = "EXEC spMAMCH '0', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMCHIDFR.SelectedValue)) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMCHIDTO.SelectedValue)) + "'";
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvMAMCH.ClearSelection();
						dgvMAMCH.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvMAMCH.Rows[dgvMAMCH.Rows.Count - 1];
						dataGridViewRow.Cells["MAMCH_MCHID"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAMCH_MCHID"].ToString());
						dataGridViewRow.Cells["MAMCH_MCHNM"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAMCH_MCHNM"].ToString());
						dataGridViewRow.Cells["MAMCH_PROCD"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAMCH_PROCD"].ToString());
						dataGridViewRow.Cells["MAMCH_STSFG"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAMCH_STSFG"].ToString());
						dataGridViewRow.Cells["MAMCH_REMRK"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAMCH_REMRK"].ToString());
						dataGridViewRow.Cells["MAMCH_MRPFG"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAMCH_MRPFG"].ToString());
						dataGridViewRow.Cells["MAMCH_ISSFG"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAMCH_ISSFG"].ToString());
						dataGridViewRow.Cells["STSFGNM"].Value = Common.gfValidSQLStr(dt.Rows[i]["STSFGNM"].ToString());
						dataGridViewRow = null;
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void ClearDetails()
		{
			cbOPRNO.SelectedIndex = -1;
			txtMCHID.Text = string.Empty;
			txtMCHNM.Text = string.Empty;
			cboSTSFG.SelectedIndex = -1;
			txtREMRK.Text = string.Empty;
			cboMRPFG.SelectedIndex = -1;
			txtMCHID.Enabled = true;
			btnSAVE.Tag = "Save";
			btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			BindComboHeader();
			Header();
		}

		private void BindGridtoControl()
		{
			txtMCHID.Text = dgvMAMCH.CurrentRow.Cells["MAMCH_MCHID"].Value.ToString();
			txtMCHNM.Text = dgvMAMCH.CurrentRow.Cells["MAMCH_MCHNM"].Value.ToString();
			cbOPRNO.SelectedValue = dgvMAMCH.CurrentRow.Cells["MAMCH_PROCD"].Value.ToString();
			NewLateBinding.LateIndexSetComplex(cbOPRNO.SelectedItem, new object[2]
			{
				1,
				DB.GetColumnValue("MACOD_CODNM", "MACOD_TBL", "MACOD_CTYID ='PROCD' AND MACOD_CODID = '" + Common.gfValidSQLStr(Conversions.ToString(cbOPRNO.SelectedValue)) + "'")
			}, null, false, true);
			cboSTSFG.SelectedIndex = Conversions.ToInteger(dgvMAMCH.CurrentRow.Cells["MAMCH_STSFG"].Value.ToString());
			cboSTSFG.SelectedIndex = Conversions.ToInteger(dgvMAMCH.CurrentRow.Cells["MAMCH_STSFG"].Value.ToString());
			cboMRPFG.SelectedValue = RuntimeHelpers.GetObjectValue(dgvMAMCH.CurrentRow.Cells["MAMCH_MRPFG"].Value);
			chkISSFG.Checked = Conversions.ToBoolean(Interaction.IIf(Operators.ConditionalCompareObjectEqual(dgvMAMCH.CurrentRow.Cells["MAMCH_ISSFG"].Value, 1, false), true, false));
			txtREMRK.Text = dgvMAMCH.CurrentRow.Cells["MAMCH_REMRK"].Value.ToString();
		}

		private void dgvMADEL_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindGridtoControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnSAVE.Tag = "Update";
			txtMCHID.Enabled = false;
			btnDelete.Enabled = true;
			btnPRINT.Enabled = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
			{
				spMAEMCH("1");
				ClearDetails();
				Header();
			}
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'PROCD' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbOPRNO.ValueMember = "MACOD_CODID";
			cbOPRNO.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbOPRNO);
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'MRPFG' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cboMRPFG.ValueMember = "MACOD_CODID";
			cboMRPFG.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cboMRPFG);
		}

		private bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtMCHID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Machine ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtMCHID.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbOPRNO.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Opeation No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbOPRNO.Focus();
				return false;
			}
			if (cboSTSFG.SelectedIndex == -1)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cboSTSFG.Focus();
				return false;
			}
			string strSQL = "SELECT * FROM MAMCH_TBL WHERE MAMCH_MCHID = '" + Common.gfValidSQLStr(txtMCHID.Text) + "'";
			if (Operators.ConditionalCompareObjectEqual(btnSAVE.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtMCHID.Focus();
				return false;
			}
			return true;
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "MACHINE MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMAMCH.rpt";
			if (Operators.CompareString(txtMCHID.Text.Trim(), "", false) != 0)
			{
				frmRPT.Params = ("@Par=1 ,@MCHIDFR=" + Common.gfValidSQLStr(txtMCHID.Text) + ",@MCHIDTO=" + Common.gfValidSQLStr(txtMCHID.Text)) ?? "";
			}
			else
			{
				frmRPT.Params = ("@Par=1 ,@MCHIDFR=" + Common.gfValidSQLStr(Conversions.ToString(cbMCHIDFR.SelectedValue)) + ",@MCHIDTO=" + Common.gfValidSQLStr(Conversions.ToString(cbMCHIDTO.SelectedValue))) ?? "";
			}
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='MACHINE MASTER',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS + ",XRTDS=" + PublicVar.gintXRTDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAEMCH_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAEMCH_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Header();
			cboSTSFG.Items.Add("Inactive");
			cboSTSFG.Items.Add("Active");
		}

		private void cbMCHIDFR_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbMCHIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbMCHIDFR.SelectedValue);
		}
	}
}
