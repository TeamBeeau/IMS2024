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
using Microsoft.VisualBasic.CompilerServices;
using Spire.Barcode;

namespace IMS
{
    [DesignerGenerated]
	public class frmMAEPLT : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCLOSE")]
		private Button _btnCLOSE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBACK2")]
		private Button _btnBACK2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPrint2")]
		private Button _btnPrint2;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		private SqlTransaction Trn;

		[field: AccessedThroughProperty("pnlHeader")]
		internal virtual Panel pnlHeader
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel8")]
		internal virtual TableLayoutPanel TableLayoutPanel8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvHEADER
		{
			[CompilerGenerated]
			get
			{
				return _dgvHEADER;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvHEADER_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvHEADER;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvHEADER = value;
				dataGridView = _dgvHEADER;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("pnlNew")]
		internal virtual Panel pnlNew
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

		internal virtual Button btnSave
		{
			[CompilerGenerated]
			get
			{
				return _btnSave;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSave_Click;
				Button button = _btnSave;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSave = value;
				button = _btnSave;
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

		[field: AccessedThroughProperty("TableLayoutPanel9")]
		internal virtual TableLayoutPanel TableLayoutPanel9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numPLTCNT")]
		internal virtual NumControl numPLTCNT
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

		[field: AccessedThroughProperty("cbHSTSFG")]
		internal virtual ComboBox cbHSTSFG
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

		[field: AccessedThroughProperty("pnlEdit")]
		internal virtual Panel pnlEdit
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

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnBACK2
		{
			[CompilerGenerated]
			get
			{
				return _btnBACK2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnBACK2_Click;
				Button button = _btnBACK2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnBACK2 = value;
				button = _btnBACK2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnUpdate
		{
			[CompilerGenerated]
			get
			{
				return _btnUpdate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUpdate_Click;
				Button button = _btnUpdate;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnUpdate = value;
				button = _btnUpdate;
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPLTID")]
		internal virtual TextBox txtPLTID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpPLTIDTO")]
		internal virtual LookupControl lkpPLTIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpPLTIDFR")]
		internal virtual LookupControl lkpPLTIDFR
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

		[field: AccessedThroughProperty("cbLOCID")]
		internal virtual ComboBox cbLOCID
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

		[field: AccessedThroughProperty("dgvPallet")]
		internal virtual DataGridView dgvPallet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnPrint2
		{
			[CompilerGenerated]
			get
			{
				return _btnPrint2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPrint2_Click;
				Button button = _btnPrint2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPrint2 = value;
				button = _btnPrint2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public frmMAEPLT()
		{
			base.FormClosing += frmMAEPLT_FormClosing;
			base.Shown += frmMAEPLT_Shown;
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
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnCLOSE = new System.Windows.Forms.Button();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.cbHSTSFG = new System.Windows.Forms.ComboBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.pnlNew = new System.Windows.Forms.Panel();
			this.TableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvPallet = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPrint2 = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.pnlEdit = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbSTSFG = new System.Windows.Forms.ComboBox();
			this.txtPLTID = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnBACK2 = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.lkpPLTIDTO = new IMS.LookupControl();
			this.lkpPLTIDFR = new IMS.LookupControl();
			this.numPLTCNT = new IMS.NumControl();
			this.pnlHeader.SuspendLayout();
			this.TableLayoutPanel8.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.pnlNew.SuspendLayout();
			this.TableLayoutPanel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPallet).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			this.pnlEdit.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.pnlHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.pnlHeader.AutoScroll = true;
			this.pnlHeader.Controls.Add(this.TableLayoutPanel8);
			this.pnlHeader.Controls.Add(this.TableLayoutPanel3);
			this.pnlHeader.Controls.Add(this.dgvHEADER);
			this.pnlHeader.Location = new System.Drawing.Point(7, 6);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(1380, 754);
			this.pnlHeader.TabIndex = 35;
			this.TableLayoutPanel8.AutoSize = true;
			this.TableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel8.ColumnCount = 3;
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel8.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel8.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel8.Controls.Add(this.btnCLOSE, 2, 0);
			this.TableLayoutPanel8.Location = new System.Drawing.Point(5, 115);
			this.TableLayoutPanel8.Margin = new System.Windows.Forms.Padding(4);
			this.TableLayoutPanel8.Name = "TableLayoutPanel8";
			this.TableLayoutPanel8.RowCount = 1;
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.Size = new System.Drawing.Size(378, 52);
			this.TableLayoutPanel8.TabIndex = 24;
			this.btnSEARCH.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(3, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 48);
			this.btnSEARCH.TabIndex = 7;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(129, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 48);
			this.btnNew.TabIndex = 8;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnCLOSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCLOSE.Image = IMS.My.Resources.Resources.Close;
			this.btnCLOSE.Location = new System.Drawing.Point(255, 2);
			this.btnCLOSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCLOSE.Name = "btnCLOSE";
			this.btnCLOSE.Size = new System.Drawing.Size(120, 48);
			this.btnCLOSE.TabIndex = 10;
			this.btnCLOSE.Text = "Close";
			this.btnCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCLOSE.UseVisualStyleBackColor = false;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.lkpPLTIDTO, 3, 1);
			this.TableLayoutPanel3.Controls.Add(this.lkpPLTIDFR, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label13, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label15, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.cbHSTSFG, 1, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label14, 2, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.cbLOCID, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 3;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(555, 101);
			this.TableLayoutPanel3.TabIndex = 19;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(4, 40);
			this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(73, 20);
			this.Label13.TabIndex = 46;
			this.Label13.Text = "Pallet ID";
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(4, 74);
			this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(57, 20);
			this.Label15.TabIndex = 44;
			this.Label15.Text = "Status";
			this.cbHSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHSTSFG.FormattingEnabled = true;
			this.cbHSTSFG.Location = new System.Drawing.Point(84, 70);
			this.cbHSTSFG.Name = "cbHSTSFG";
			this.cbHSTSFG.Size = new System.Drawing.Size(151, 28);
			this.cbHSTSFG.TabIndex = 6;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(304, 40);
			this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(28, 20);
			this.Label14.TabIndex = 126;
			this.Label14.Text = "To";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(4, 7);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(73, 20);
			this.Label2.TabIndex = 127;
			this.Label2.Text = "Location";
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(84, 3);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(151, 28);
			this.cbLOCID.TabIndex = 128;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 181);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(5);
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 25;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1327, 400);
			this.dgvHEADER.TabIndex = 20;
			this.pnlNew.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.pnlNew.AutoScroll = true;
			this.pnlNew.Controls.Add(this.TableLayoutPanel9);
			this.pnlNew.Location = new System.Drawing.Point(7, 3);
			this.pnlNew.Name = "pnlNew";
			this.pnlNew.Size = new System.Drawing.Size(1380, 754);
			this.pnlNew.TabIndex = 36;
			this.TableLayoutPanel9.ColumnCount = 4;
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.Controls.Add(this.dgvPallet, 0, 1);
			this.TableLayoutPanel9.Controls.Add(this.TableLayoutPanel2, 0, 3);
			this.TableLayoutPanel9.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel9.Controls.Add(this.numPLTCNT, 1, 0);
			this.TableLayoutPanel9.Location = new System.Drawing.Point(12, 13);
			this.TableLayoutPanel9.Name = "TableLayoutPanel9";
			this.TableLayoutPanel9.RowCount = 4;
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.Size = new System.Drawing.Size(896, 483);
			this.TableLayoutPanel9.TabIndex = 30;
			this.dgvPallet.AllowUserToAddRows = false;
			this.dgvPallet.AllowUserToDeleteRows = false;
			this.dgvPallet.AllowUserToResizeRows = false;
			this.dgvPallet.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel9.SetColumnSpan(this.dgvPallet, 3);
			this.dgvPallet.Location = new System.Drawing.Point(3, 35);
			this.dgvPallet.MultiSelect = false;
			this.dgvPallet.Name = "dgvPallet";
			this.dgvPallet.ReadOnly = true;
			this.dgvPallet.RowHeadersVisible = false;
			this.dgvPallet.RowHeadersWidth = 51;
			this.dgvPallet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPallet.Size = new System.Drawing.Size(739, 356);
			this.dgvPallet.TabIndex = 108;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 3;
			this.TableLayoutPanel9.SetColumnSpan(this.TableLayoutPanel2, 4);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.btnPrint2, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.btnBack, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(4, 418);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(378, 52);
			this.TableLayoutPanel2.TabIndex = 25;
			this.btnPrint2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPrint2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPrint2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPrint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint2.Image = IMS.My.Resources.Resources.Print;
			this.btnPrint2.Location = new System.Drawing.Point(129, 2);
			this.btnPrint2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPrint2.Name = "btnPrint2";
			this.btnPrint2.Size = new System.Drawing.Size(120, 48);
			this.btnPrint2.TabIndex = 15;
			this.btnPrint2.Text = "Print";
			this.btnPrint2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrint2.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(255, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 48);
			this.btnBack.TabIndex = 14;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(3, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 48);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(4, 6);
			this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(100, 20);
			this.Label4.TabIndex = 107;
			this.Label4.Text = "Pallet Count";
			this.pnlEdit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.pnlEdit.AutoScroll = true;
			this.pnlEdit.Controls.Add(this.TableLayoutPanel1);
			this.pnlEdit.Location = new System.Drawing.Point(7, 3);
			this.pnlEdit.Name = "pnlEdit";
			this.pnlEdit.Size = new System.Drawing.Size(1350, 754);
			this.pnlEdit.TabIndex = 37;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbSTSFG, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtPLTID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel4, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 6);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 4;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(828, 162);
			this.TableLayoutPanel1.TabIndex = 30;
			this.cbSTSFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTSFG.FormattingEnabled = true;
			this.cbSTSFG.Location = new System.Drawing.Point(84, 35);
			this.cbSTSFG.Name = "cbSTSFG";
			this.cbSTSFG.Size = new System.Drawing.Size(168, 28);
			this.cbSTSFG.TabIndex = 33;
			this.txtPLTID.Location = new System.Drawing.Point(84, 3);
			this.txtPLTID.Name = "txtPLTID";
			this.txtPLTID.ReadOnly = true;
			this.txtPLTID.Size = new System.Drawing.Size(292, 26);
			this.txtPLTID.TabIndex = 1;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel4, 2);
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnBACK2, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINT, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnUpdate, 0, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(4, 90);
			this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel4.TabIndex = 25;
			this.btnBACK2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBACK2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBACK2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBACK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBACK2.Image = IMS.My.Resources.Resources.Back;
			this.btnBACK2.Location = new System.Drawing.Point(255, 2);
			this.btnBACK2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBACK2.Name = "btnBACK2";
			this.btnBACK2.Size = new System.Drawing.Size(120, 48);
			this.btnBACK2.TabIndex = 8;
			this.btnBACK2.Text = "Back";
			this.btnBACK2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBACK2.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(129, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 20;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Image = IMS.My.Resources.Resources.Save;
			this.btnUpdate.Location = new System.Drawing.Point(3, 3);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 48);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(4, 39);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(57, 20);
			this.Label1.TabIndex = 106;
			this.Label1.Text = "Status";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(4, 6);
			this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(73, 20);
			this.Label8.TabIndex = 115;
			this.Label8.Text = "Pallet ID";
			this.lkpPLTIDTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpPLTIDTO.AllowBlank = false;
			this.lkpPLTIDTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpPLTIDTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpPLTIDTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpPLTIDTO.DescriptionVisible1 = true;
			this.lkpPLTIDTO.DescriptionVisible2 = false;
			this.lkpPLTIDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpPLTIDTO.KeyValue = "";
			this.lkpPLTIDTO.LKPCD = "MAPLT_PLTID";
			this.lkpPLTIDTO.Location = new System.Drawing.Point(341, 39);
			this.lkpPLTIDTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpPLTIDTO.MaxLength = 25;
			this.lkpPLTIDTO.Modified = false;
			this.lkpPLTIDTO.Multiline_ = false;
			this.lkpPLTIDTO.Name = "lkpPLTIDTO";
			this.lkpPLTIDTO.PasswordChar = "\0";
			this.lkpPLTIDTO.ReadOnly_ = false;
			this.lkpPLTIDTO.Size = new System.Drawing.Size(209, 23);
			this.lkpPLTIDTO.TabIndex = 5;
			this.lkpPLTIDTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpPLTIDTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpPLTIDTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpPLTIDTO.TextHeight = 23;
			this.lkpPLTIDTO.TextWidth = 180;
			this.lkpPLTIDTO.Where1 = "";
			this.lkpPLTIDFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpPLTIDFR.AllowBlank = false;
			this.lkpPLTIDFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpPLTIDFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpPLTIDFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpPLTIDFR.DescriptionVisible1 = true;
			this.lkpPLTIDFR.DescriptionVisible2 = false;
			this.lkpPLTIDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpPLTIDFR.KeyValue = "";
			this.lkpPLTIDFR.LKPCD = "MAPLT_PLTID";
			this.lkpPLTIDFR.Location = new System.Drawing.Point(86, 39);
			this.lkpPLTIDFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpPLTIDFR.MaxLength = 0;
			this.lkpPLTIDFR.Modified = false;
			this.lkpPLTIDFR.Multiline_ = false;
			this.lkpPLTIDFR.Name = "lkpPLTIDFR";
			this.lkpPLTIDFR.PasswordChar = "\0";
			this.lkpPLTIDFR.ReadOnly_ = false;
			this.lkpPLTIDFR.Size = new System.Drawing.Size(209, 23);
			this.lkpPLTIDFR.TabIndex = 4;
			this.lkpPLTIDFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpPLTIDFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpPLTIDFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpPLTIDFR.TextHeight = 23;
			this.lkpPLTIDFR.TextWidth = 180;
			this.lkpPLTIDFR.Where1 = "";
			this.numPLTCNT.AllowNegative = false;
			this.numPLTCNT.DataChanged = false;
			this.numPLTCNT.Location = new System.Drawing.Point(111, 3);
			this.numPLTCNT.Name = "numPLTCNT";
			this.numPLTCNT.NumberFormat = "8.0";
			this.numPLTCNT.Size = new System.Drawing.Size(100, 26);
			this.numPLTCNT.TabIndex = 3;
			this.numPLTCNT.Text = "0";
			this.numPLTCNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPLTCNT.ThousandSeperator = false;
			this.numPLTCNT.Value = 0.0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 749);
			base.ControlBox = false;
			base.Controls.Add(this.pnlEdit);
			base.Controls.Add(this.pnlHeader);
			base.Controls.Add(this.pnlNew);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmMAEPLT";
			base.Tag = "MAEPLT";
			this.Text = "Pallet Maintenance";
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.TableLayoutPanel8.ResumeLayout(false);
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.pnlNew.ResumeLayout(false);
			this.TableLayoutPanel9.ResumeLayout(false);
			this.TableLayoutPanel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPallet).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.pnlEdit.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void Header()
		{
			int i = 0;
			string STSFG = string.Empty;
			dgvHEADER.DataSource = null;
			if (Operators.ConditionalCompareObjectEqual(cbHSTSFG.SelectedItem, "All", false))
			{
				STSFG = "";
			}
			if (Operators.ConditionalCompareObjectEqual(cbHSTSFG.SelectedItem, "New", false))
			{
				STSFG = Conversions.ToString(0);
			}
			if (Operators.ConditionalCompareObjectEqual(cbHSTSFG.SelectedItem, "Used", false))
			{
				STSFG = Conversions.ToString(1);
			}
			if (Operators.ConditionalCompareObjectEqual(cbHSTSFG.SelectedItem, "Disposed", false))
			{
				STSFG = Conversions.ToString(2);
			}
			string strSQL = "EXEC spMAPLT ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfValidSQLStr(lkpPLTIDFR.LowValue) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(lkpPLTIDTO.HighValue) + "', ";
			strSQL = strSQL + "'" + STSFG + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = "Pallet ID";
					dataGridView.Columns[i].ReadOnly = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = "Location";
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = "Rack No";
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = "Status";
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
				pnlNew.Visible = false;
				pnlHeader.Visible = true;
				pnlEdit.Visible = false;
			}
		}

		private void ClearDetails()
		{
			numPLTCNT.Value = 0.0;
		}

		private void BindCombox()
		{
			string strSQL = string.Empty;
			strSQL = "SELECT '' AS MALOC_LOCID, '' AS MALOC_LOCNM UNION ";
			strSQL += "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM FROM MALOC_TBL WITH (NOLOCK) ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			cbHSTSFG.Items.Clear();
			cbHSTSFG.Items.Add("All");
			cbHSTSFG.Items.Add("New");
			cbHSTSFG.Items.Add("Used");
			cbHSTSFG.Items.Add("Approved");
			cbHSTSFG.SelectedIndex = 0;
			cbSTSFG.Items.Clear();
			cbSTSFG.Items.Add("New");
			cbSTSFG.Items.Add("Used");
			cbSTSFG.Items.Add("Disposed");
			cbSTSFG.SelectedIndex = 0;
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtPLTID.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["MAPLT_PLTID"].Value);
			cbSTSFG.SelectedIndex = Conversions.ToInteger(dgvHEADER.CurrentRow.Cells["MAPLT_STSFG"].Value);
			string strSQL = "DELETE MAPLT_WRK WHERE MAPLT_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "INSERT INTO MAPLT_WRK (MAPLT_COMPNM, MAPLT_PLTID, MAPLT_LOCID, MAPLT_RACKNO) ";
			strSQL = strSQL + "SELECT '" + MyProject.Computer.Name + "', MAPLT_PLTID, MAPLT_LOCID, MAPLT_RACKNO ";
			strSQL = strSQL + "FROM MAPLT_TBL WHERE MAPLT_PLTID = '" + txtPLTID.Text + "'";
			DB.ExecProc(strSQL);
			pnlNew.Visible = false;
			pnlHeader.Visible = false;
			pnlEdit.Visible = true;
		}

		private void btnCLOSE_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAEPLT_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAEPLT_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindCombox();
			Header();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (numPLTCNT.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Pallet Count cannot be blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			string strSQL = "EXEC spMAEPLT '" + MyProject.Computer.Name + "', " + Conversions.ToString(numPLTCNT.Value) + ", '" + PublicVar.gstrLogonID + "'";
			DB.ExecProc(strSQL);
			BindGridPallet();
			numPLTCNT.ReadOnly = true;
			btnSave.Enabled = false;
			btnPrint2.Enabled = true;
		}

		private void BindGridPallet()
		{
			string strSQL = "SELECT MAPLT_PLTID FROM MAPLT_WRK WHERE MAPLT_COMPNM = '" + MyProject.Computer.Name + "'";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvPallet;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 150;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = "Pallet ID";
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			pnlNew.Visible = true;
			pnlHeader.Visible = false;
			pnlEdit.Visible = false;
			numPLTCNT.ReadOnly = false;
			btnSave.Enabled = true;
			btnPrint2.Enabled = false;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			pnlNew.Visible = false;
			pnlHeader.Visible = true;
			pnlEdit.Visible = false;
		}

		private void ClearDetails2()
		{
			txtPLTID.Text = string.Empty;
			cbSTSFG.SelectedIndex = 0;
			cbSTSFG.Enabled = true;
		}

		private void btnBACK2_Click(object sender, EventArgs e)
		{
			ClearDetails2();
			pnlNew.Visible = false;
			pnlHeader.Visible = true;
			pnlEdit.Visible = false;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string strSQL = "UPDATE MAPLT_TBL SET MAPLT_STSFG = " + Conversions.ToString(cbSTSFG.SelectedIndex) + ", ";
			strSQL = strSQL + "MAPLT_LUPBY = '" + PublicVar.gstrLogonID + "', MAPLT_LUPDT = GETDATE() ";
			strSQL = strSQL + "WHERE MAPLT_PLTID = '" + Common.gfValidSQLStr(txtPLTID.Text) + "' ";
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record edited!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), ex.Message.ToString()), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
				return;
			}
			ClearDetails2();
			Header();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			GenerateQRCode();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "PRINT PALLET TICKET";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMALPLT.rpt";
			frmRPT.Params = ("@COMPNM=" + Common.gfValidSQLStr(MyProject.Computer.Name)) ?? "";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany) + "',RPTTITLE='PRINT PALLET TICKET',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS + ",XRTDS=" + PublicVar.gintXRTDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void GenerateQRCode()
		{
			string STSFG = string.Empty;
			object settings = new BarcodeSettings();
			string strSQL = "SELECT MAPLT_PLTID FROM MAPLT_WRK WHERE MAPLT_COMPNM = '" + MyProject.Computer.Name + "'";
			DataTable dt = DB.ExecProc(strSQL);
			int num = checked(dt.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				NewLateBinding.LateSet(settings, null, "HasBorder", new object[1] { false }, null, null);
				NewLateBinding.LateSet(settings, null, "ShowText", new object[1] { false }, null, null);
				NewLateBinding.LateSet(settings, null, "Type", new object[1] { (BarCodeType)Conversions.ToLong(Enum.Parse(typeof(BarCodeType), "QRCode")) }, null, null);
				NewLateBinding.LateSet(settings, null, "LeftMargin", new object[1] { 1 }, null, null);
				string strPLTID = Common.gfValidSQLStr(dt.Rows[i]["MAPLT_PLTID"].ToString().Trim());
				NewLateBinding.LateSet(settings, null, "Data2D", new object[1] { strPLTID }, null, null);
				NewLateBinding.LateSet(settings, null, "Data", new object[1] { strPLTID }, null, null);
				BarCodeGenerator sprPLTID = new BarCodeGenerator((IBarcodeSettings)settings);
				byte[] imgQRCODE = Common.ImageToByte2(sprPLTID.GenerateImage());
				try
				{
					OleDbCommand cmd = new OleDbCommand();
					cmd.Connection = DB.GetDBConnection();
					strSQL = "spMAEPLT_QR";
					cmd.CommandText = strSQL;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("@COMPNM", OleDbType.VarChar, 50).Value = Common.gfValidSQLStr(MyProject.Computer.Name);
					cmd.Parameters.Add("@PLTID", OleDbType.VarChar, 25).Value = Common.gfValidSQLStr(strPLTID);
					cmd.Parameters.Add("@QRCODE", OleDbType.VarBinary, -1).Value = imgQRCODE;
					int iRowsAffected = cmd.ExecuteNonQuery();
				}
				catch (OleDbException ex3)
				{
					ProjectData.SetProjectError(ex3);
					OleDbException ex2 = ex3;
					MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				catch (Exception ex4)
				{
					ProjectData.SetProjectError(ex4);
					Exception ex = ex4;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				finally
				{
					OleDbCommand cmd = null;
				}
			}
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPrint2_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}
	}
}
