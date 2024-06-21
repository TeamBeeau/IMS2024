using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
	public class frmINESTG : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDOWNLOAD")]
		private System.Windows.Forms.Button _btnDOWNLOAD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUPLOAD")]
		private System.Windows.Forms.Button _btnUPLOAD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnGENERATE")]
		private System.Windows.Forms.Button _btnGENERATE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private System.Windows.Forms.Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private System.Windows.Forms.Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private System.Windows.Forms.Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private System.Windows.Forms.Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private System.Windows.Forms.Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private System.Windows.Forms.Button _btnPRINTFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private System.Windows.Forms.Button _btnCancel;

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

		[field: AccessedThroughProperty("txtDOCNO")]
		internal virtual System.Windows.Forms.TextBox txtDOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnDOWNLOAD
		{
			[CompilerGenerated]
			get
			{
				return _btnDOWNLOAD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDOWNLOAD_Click;
				System.Windows.Forms.Button button = _btnDOWNLOAD;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDOWNLOAD = value;
				button = _btnDOWNLOAD;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lkpLOCID")]
		internal virtual LookupControl lkpLOCID
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

		[field: AccessedThroughProperty("Label4")]
		internal virtual System.Windows.Forms.Label Label4
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

		[field: AccessedThroughProperty("dtpDOCDT")]
		internal virtual DateTimePicker dtpDOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnUPLOAD
		{
			[CompilerGenerated]
			get
			{
				return _btnUPLOAD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUPLOAD_Click;
				System.Windows.Forms.Button button = _btnUPLOAD;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnUPLOAD = value;
				button = _btnUPLOAD;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("SaveFileDialog1")]
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual OpenFileDialog OpenFileDialog1
		{
			[CompilerGenerated]
			get
			{
				return _OpenFileDialog1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = OpenFileDialog1_FileOk;
				OpenFileDialog openFileDialog = _OpenFileDialog1;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk -= value2;
				}
				_OpenFileDialog1 = value;
				openFileDialog = _OpenFileDialog1;
				if (openFileDialog != null)
				{
					openFileDialog.FileOk += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Button btnGENERATE
		{
			[CompilerGenerated]
			get
			{
				return _btnGENERATE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnGENERATE_Click;
				System.Windows.Forms.Button button = _btnGENERATE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnGENERATE = value;
				button = _btnGENERATE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("dgvDetails")]
		internal virtual DataGridView dgvDetails
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

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnSEARCH
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
				System.Windows.Forms.Button button = _btnSEARCH;
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

		internal virtual System.Windows.Forms.Button btnNew
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
				System.Windows.Forms.Button button = _btnNew;
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label17")]
		internal virtual System.Windows.Forms.Label Label17
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

		[field: AccessedThroughProperty("lkpLOCIDTO")]
		internal virtual LookupControl lkpLOCIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpDOCNOFR")]
		internal virtual LookupControl lkpDOCNOFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpDOCNOTO")]
		internal virtual LookupControl lkpDOCNOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual System.Windows.Forms.Label Label2
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

		[field: AccessedThroughProperty("lblCUSIDTO")]
		internal virtual System.Windows.Forms.Label lblCUSIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCUSIDFR")]
		internal virtual System.Windows.Forms.Label lblCUSIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label16")]
		internal virtual System.Windows.Forms.Label Label16
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

		internal virtual System.Windows.Forms.Button btnBack
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
				System.Windows.Forms.Button button = _btnBack;
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

		internal virtual System.Windows.Forms.Button btnPRINTFR
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
				System.Windows.Forms.Button button = _btnPRINTFR;
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual System.Windows.Forms.Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual System.Windows.Forms.TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("ProgressBar1")]
		internal virtual ProgressBar ProgressBar1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnCancel
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
				System.Windows.Forms.Button button = _btnCancel;
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

		[field: AccessedThroughProperty("txtUPDFG")]
		internal virtual System.Windows.Forms.TextBox txtUPDFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("DOCDT")]
		internal virtual DataGridViewTextBoxColumn DOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("INSTK_DOCDT")]
		internal virtual DataGridViewTextBoxColumn INSTK_DOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("INSTK_LOCID")]
		internal virtual DataGridViewTextBoxColumn INSTK_LOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("INSTK_DOCNO")]
		internal virtual DataGridViewTextBoxColumn INSTK_DOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("INSTK_REMRK")]
		internal virtual DataGridViewTextBoxColumn INSTK_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("STATUS")]
		internal virtual DataGridViewTextBoxColumn STATUS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("INSTK_UPDFG")]
		internal virtual DataGridViewTextBoxColumn INSTK_UPDFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmINESTG()
		{
			base.FormClosing += frmINESTKD_FormClosing;
			base.Shown += frmINESTKD_Shown;
			base.KeyDown += frmINESTG_KeyDown;
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
			this.txtUPDFG = new System.Windows.Forms.TextBox();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnGENERATE = new System.Windows.Forms.Button();
			this.btnDOWNLOAD = new System.Windows.Forms.Button();
			this.btnUPLOAD = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.lkpLOCID = new IMS.LookupControl();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_LOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_UPDFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Label17 = new System.Windows.Forms.Label();
			this.lkpLOCIDFR = new IMS.LookupControl();
			this.lkpDOCNOFR = new IMS.LookupControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.lkpDOCNOTO = new IMS.LookupControl();
			this.lkpLOCIDTO = new IMS.LookupControl();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.txtUPDFG);
			this.Panel1.Controls.Add(this.ProgressBar1);
			this.Panel1.Controls.Add(this.dgvDetails);
			this.Panel1.Controls.Add(this.TableLayoutPanel6);
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 2;
			this.txtUPDFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtUPDFG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtUPDFG.Location = new System.Drawing.Point(638, 66);
			this.txtUPDFG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtUPDFG.Name = "txtUPDFG";
			this.txtUPDFG.Size = new System.Drawing.Size(87, 26);
			this.txtUPDFG.TabIndex = 50;
			this.txtUPDFG.TabStop = false;
			this.txtUPDFG.Text = "-1";
			this.txtUPDFG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtUPDFG.Visible = false;
			this.ProgressBar1.Location = new System.Drawing.Point(5, 599);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(858, 20);
			this.ProgressBar1.TabIndex = 49;
			this.ProgressBar1.Visible = false;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Location = new System.Drawing.Point(5, 237);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(858, 356);
			this.dgvDetails.TabIndex = 48;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 6;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnGENERATE, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDOWNLOAD, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnUPLOAD, 2, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 4, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnCancel, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 5, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(772, 54);
			this.TableLayoutPanel6.TabIndex = 47;
			this.btnGENERATE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnGENERATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnGENERATE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnGENERATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnGENERATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGENERATE.Image = IMS.My.Resources.Resources.button_down;
			this.btnGENERATE.Location = new System.Drawing.Point(3, 2);
			this.btnGENERATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnGENERATE.Name = "btnGENERATE";
			this.btnGENERATE.Size = new System.Drawing.Size(128, 50);
			this.btnGENERATE.TabIndex = 5;
			this.btnGENERATE.Text = "Generate";
			this.btnGENERATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnGENERATE.UseVisualStyleBackColor = false;
			this.btnDOWNLOAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDOWNLOAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDOWNLOAD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDOWNLOAD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDOWNLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDOWNLOAD.Image = IMS.My.Resources.Resources.button_down;
			this.btnDOWNLOAD.Location = new System.Drawing.Point(137, 2);
			this.btnDOWNLOAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDOWNLOAD.Name = "btnDOWNLOAD";
			this.btnDOWNLOAD.Size = new System.Drawing.Size(128, 50);
			this.btnDOWNLOAD.TabIndex = 6;
			this.btnDOWNLOAD.Text = "Download";
			this.btnDOWNLOAD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDOWNLOAD.UseVisualStyleBackColor = false;
			this.btnUPLOAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUPLOAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnUPLOAD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUPLOAD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUPLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUPLOAD.Image = IMS.My.Resources.Resources.button_up;
			this.btnUPLOAD.Location = new System.Drawing.Point(271, 2);
			this.btnUPLOAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUPLOAD.Name = "btnUPLOAD";
			this.btnUPLOAD.Size = new System.Drawing.Size(120, 50);
			this.btnUPLOAD.TabIndex = 7;
			this.btnUPLOAD.Text = "Upload";
			this.btnUPLOAD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUPLOAD.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(523, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 9;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(397, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(649, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 10;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lkpLOCID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 1, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 4;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(607, 172);
			this.TableLayoutPanel1.TabIndex = 0;
			this.txtREMRK.Location = new System.Drawing.Point(136, 100);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(369, 69);
			this.txtREMRK.TabIndex = 4;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 124);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(76, 20);
			this.Label6.TabIndex = 49;
			this.Label6.Text = "Remarks";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 6);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(112, 20);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 38);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(95, 20);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Location ID";
			this.lkpLOCID.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCID.AllowBlank = false;
			this.lkpLOCID.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpLOCID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpLOCID.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpLOCID.DescriptionVisible1 = true;
			this.lkpLOCID.DescriptionVisible2 = false;
			this.lkpLOCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCID.KeyValue = "";
			this.lkpLOCID.LKPCD = "LOCID";
			this.lkpLOCID.Location = new System.Drawing.Point(138, 37);
			this.lkpLOCID.Margin = new System.Windows.Forms.Padding(5);
			this.lkpLOCID.MaxLength = 0;
			this.lkpLOCID.Modified = false;
			this.lkpLOCID.Multiline_ = false;
			this.lkpLOCID.Name = "lkpLOCID";
			this.lkpLOCID.PasswordChar = "\0";
			this.lkpLOCID.ReadOnly_ = false;
			this.lkpLOCID.Size = new System.Drawing.Size(464, 23);
			this.lkpLOCID.TabIndex = 2;
			this.lkpLOCID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpLOCID.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpLOCID.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpLOCID.TextHeight = 23;
			this.lkpLOCID.TextWidth = 180;
			this.lkpLOCID.Where1 = "MALOC_ACTFG = -1";
			this.txtDOCNO.Enabled = false;
			this.txtDOCNO.Location = new System.Drawing.Point(136, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 26);
			this.txtDOCNO.TabIndex = 1;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 71);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(127, 20);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(136, 68);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 26);
			this.dtpDOCDT.TabIndex = 3;
			this.OpenFileDialog1.FileName = "OpenFileDialog1";
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(2, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 630);
			this.Panel2.TabIndex = 3;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Columns.AddRange(this.DOCDT, this.INSTK_DOCDT, this.INSTK_LOCID, this.INSTK_DOCNO, this.INSTK_REMRK, this.STATUS, this.INSTK_UPDFG);
			this.dgvHEADER.Location = new System.Drawing.Point(5, 157);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(847, 452);
			this.dgvHEADER.TabIndex = 0;
			this.DOCDT.HeaderText = "Document Date";
			this.DOCDT.MinimumWidth = 6;
			this.DOCDT.Name = "DOCDT";
			this.DOCDT.ReadOnly = true;
			this.DOCDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DOCDT.Width = 130;
			this.INSTK_DOCDT.HeaderText = "STKDT";
			this.INSTK_DOCDT.MinimumWidth = 6;
			this.INSTK_DOCDT.Name = "INSTK_DOCDT";
			this.INSTK_DOCDT.ReadOnly = true;
			this.INSTK_DOCDT.Visible = false;
			this.INSTK_DOCDT.Width = 125;
			this.INSTK_LOCID.HeaderText = "Location ID";
			this.INSTK_LOCID.MinimumWidth = 6;
			this.INSTK_LOCID.Name = "INSTK_LOCID";
			this.INSTK_LOCID.ReadOnly = true;
			this.INSTK_LOCID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INSTK_LOCID.Width = 150;
			this.INSTK_DOCNO.HeaderText = "Document No";
			this.INSTK_DOCNO.MinimumWidth = 6;
			this.INSTK_DOCNO.Name = "INSTK_DOCNO";
			this.INSTK_DOCNO.ReadOnly = true;
			this.INSTK_DOCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INSTK_DOCNO.Width = 150;
			this.INSTK_REMRK.HeaderText = "Remarks";
			this.INSTK_REMRK.MinimumWidth = 6;
			this.INSTK_REMRK.Name = "INSTK_REMRK";
			this.INSTK_REMRK.ReadOnly = true;
			this.INSTK_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INSTK_REMRK.Width = 250;
			this.STATUS.HeaderText = "Status";
			this.STATUS.MinimumWidth = 6;
			this.STATUS.Name = "STATUS";
			this.STATUS.ReadOnly = true;
			this.STATUS.Width = 120;
			this.INSTK_UPDFG.HeaderText = "UPDFG";
			this.INSTK_UPDFG.MinimumWidth = 6;
			this.INSTK_UPDFG.Name = "INSTK_UPDFG";
			this.INSTK_UPDFG.ReadOnly = true;
			this.INSTK_UPDFG.Visible = false;
			this.INSTK_UPDFG.Width = 125;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 95);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel4.TabIndex = 9;
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(255, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTFR.TabIndex = 9;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(381, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(3, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 50);
			this.btnSEARCH.TabIndex = 7;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(129, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 50);
			this.btnNew.TabIndex = 8;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpLOCIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.lkpLOCIDTO, 3, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(611, 96);
			this.TableLayoutPanel2.TabIndex = 1;
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 38);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(95, 20);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Location ID";
			this.lkpLOCIDFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDFR.AllowBlank = false;
			this.lkpLOCIDFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpLOCIDFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpLOCIDFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpLOCIDFR.DescriptionVisible1 = false;
			this.lkpLOCIDFR.DescriptionVisible2 = false;
			this.lkpLOCIDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDFR.KeyValue = "";
			this.lkpLOCIDFR.LKPCD = "INSTK_LOCID";
			this.lkpLOCIDFR.Location = new System.Drawing.Point(138, 37);
			this.lkpLOCIDFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpLOCIDFR.MaxLength = 0;
			this.lkpLOCIDFR.Modified = false;
			this.lkpLOCIDFR.Multiline_ = false;
			this.lkpLOCIDFR.Name = "lkpLOCIDFR";
			this.lkpLOCIDFR.PasswordChar = "\0";
			this.lkpLOCIDFR.ReadOnly_ = false;
			this.lkpLOCIDFR.Size = new System.Drawing.Size(212, 22);
			this.lkpLOCIDFR.TabIndex = 3;
			this.lkpLOCIDFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpLOCIDFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpLOCIDFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpLOCIDFR.TextHeight = 22;
			this.lkpLOCIDFR.TextWidth = 180;
			this.lkpLOCIDFR.Where1 = "MALOC_ACTFG = -1";
			this.lkpDOCNOFR.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOFR.AllowBlank = false;
			this.lkpDOCNOFR.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpDOCNOFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpDOCNOFR.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpDOCNOFR.DescriptionVisible1 = false;
			this.lkpDOCNOFR.DescriptionVisible2 = false;
			this.lkpDOCNOFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOFR.KeyValue = "";
			this.lkpDOCNOFR.LKPCD = "INSTK_DOCNO";
			this.lkpDOCNOFR.Location = new System.Drawing.Point(138, 5);
			this.lkpDOCNOFR.Margin = new System.Windows.Forms.Padding(5);
			this.lkpDOCNOFR.MaxLength = 0;
			this.lkpDOCNOFR.Modified = false;
			this.lkpDOCNOFR.Multiline_ = false;
			this.lkpDOCNOFR.Name = "lkpDOCNOFR";
			this.lkpDOCNOFR.PasswordChar = "\0";
			this.lkpDOCNOFR.ReadOnly_ = false;
			this.lkpDOCNOFR.Size = new System.Drawing.Size(212, 22);
			this.lkpDOCNOFR.TabIndex = 1;
			this.lkpDOCNOFR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpDOCNOFR.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpDOCNOFR.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpDOCNOFR.TextHeight = 22;
			this.lkpDOCNOFR.TextWidth = 180;
			this.lkpDOCNOFR.Where1 = null;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 70);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(127, 20);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(358, 70);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(28, 20);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(392, 67);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 26);
			this.dtpDOCDTTO.TabIndex = 6;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(136, 67);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 26);
			this.dtpDOCDTFR.TabIndex = 5;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(358, 6);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(28, 20);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 6);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(112, 20);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Document No";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(358, 38);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(28, 20);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			this.lkpDOCNOTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOTO.AllowBlank = false;
			this.lkpDOCNOTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpDOCNOTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpDOCNOTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpDOCNOTO.DescriptionVisible1 = false;
			this.lkpDOCNOTO.DescriptionVisible2 = false;
			this.lkpDOCNOTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpDOCNOTO.KeyValue = "";
			this.lkpDOCNOTO.LKPCD = "INSTK_DOCNO";
			this.lkpDOCNOTO.Location = new System.Drawing.Point(394, 5);
			this.lkpDOCNOTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpDOCNOTO.MaxLength = 0;
			this.lkpDOCNOTO.Modified = false;
			this.lkpDOCNOTO.Multiline_ = false;
			this.lkpDOCNOTO.Name = "lkpDOCNOTO";
			this.lkpDOCNOTO.PasswordChar = "\0";
			this.lkpDOCNOTO.ReadOnly_ = false;
			this.lkpDOCNOTO.Size = new System.Drawing.Size(212, 22);
			this.lkpDOCNOTO.TabIndex = 2;
			this.lkpDOCNOTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpDOCNOTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpDOCNOTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpDOCNOTO.TextHeight = 22;
			this.lkpDOCNOTO.TextWidth = 180;
			this.lkpDOCNOTO.Where1 = null;
			this.lkpLOCIDTO.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDTO.AllowBlank = false;
			this.lkpLOCIDTO.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpLOCIDTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpLOCIDTO.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpLOCIDTO.DescriptionVisible1 = false;
			this.lkpLOCIDTO.DescriptionVisible2 = false;
			this.lkpLOCIDTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpLOCIDTO.KeyValue = "";
			this.lkpLOCIDTO.LKPCD = "INSTK_LOCID";
			this.lkpLOCIDTO.Location = new System.Drawing.Point(394, 37);
			this.lkpLOCIDTO.Margin = new System.Windows.Forms.Padding(5);
			this.lkpLOCIDTO.MaxLength = 0;
			this.lkpLOCIDTO.Modified = false;
			this.lkpLOCIDTO.Multiline_ = false;
			this.lkpLOCIDTO.Name = "lkpLOCIDTO";
			this.lkpLOCIDTO.PasswordChar = "\0";
			this.lkpLOCIDTO.ReadOnly_ = false;
			this.lkpLOCIDTO.Size = new System.Drawing.Size(212, 22);
			this.lkpLOCIDTO.TabIndex = 4;
			this.lkpLOCIDTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpLOCIDTO.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpLOCIDTO.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpLOCIDTO.TextHeight = 22;
			this.lkpLOCIDTO.TextWidth = 180;
			this.lkpLOCIDTO.Where1 = "MALOC_ACTFG = -1";
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmINESTG";
			base.Tag = "INESTG";
			this.Text = "Generate Stock Take Data";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmINESTKD_FormClosing(object sender, FormClosingEventArgs e)
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

		private void ClearDetails()
		{
			lkpLOCID.KeyValue = string.Empty;
			lkpLOCID.RefreshDescription();
			txtREMRK.Text = string.Empty;
			txtDOCNO.Text = string.Empty;
			dgvDetails.ClearSelection();
			dtpDOCDT.Value = DateTime.Now;
			btnGENERATE.Enabled = true;
			btnDOWNLOAD.Enabled = true;
			btnUPLOAD.Enabled = true;
			btnPRINT.Enabled = false;
		}

		private bool GenerateData()
		{
			OleDbCommand cmd = new OleDbCommand();
			bool GenerateData;
			try
			{
				cmd = new OleDbCommand();
				cmd.Connection = DB.GetDBConnection();
				string strSQL = "spINESTG";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@COMPNM", OleDbType.VarChar, 50).Value = MyProject.Computer.Name;
				cmd.Parameters.Add("@DOCDT", OleDbType.Date).Value = Common.gfSQLDate(dtpDOCDT.Value);
				cmd.Parameters.Add("@LOCID", OleDbType.VarChar, 15).Value = lkpLOCID.KeyValue;
				cmd.Parameters.Add("@REMRK", OleDbType.VarChar, 200).Value = txtREMRK.Text;
				cmd.Parameters.Add("@ENTBY", OleDbType.VarChar, 20).Value = PublicVar.gstrLogonID;
				cmd.Parameters.Add("@DOCNO", OleDbType.VarChar, 25).Direction = ParameterDirection.Output;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
				txtDOCNO.Text = cmd.Parameters["@DOCNO"].Value.ToString();
				GenerateData = true;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GenerateData = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GenerateData = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
			}
			return GenerateData;
		}

		private bool ValidateDetails()
		{
			if (Operators.CompareString(lkpLOCID.KeyValue.Trim(), "", false) == 0)
			{
				MessageBox.Show("Location ID cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpLOCID.Focus();
				return false;
			}
			if (!lkpLOCID.IsValid())
			{
				MessageBox.Show("Invalid Location ID!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpLOCID.Focus();
				return false;
			}
			return true;
		}

		private void CreateCSVfile()
		{
			Microsoft.Office.Interop.Excel.Application xlApp = new ApplicationClass();
			string strXLFolder = System.Windows.Forms.Application.StartupPath + "\\XL\\";
			string strXLFile = strXLFolder + "STK- " + lkpLOCID.KeyValue + "-" + dtpDOCDT.Value.Date.ToString("yyyyMMdd") + "-" + txtDOCNO.Text + ".xlsx";
			System.Data.DataTable dt = new System.Data.DataTable();
			int iXLRow = 8;
			checked
			{
				try
				{
					Cursor = Cursors.WaitCursor;
					xlApp.WindowState = XlWindowState.xlMaximized;
					xlApp.Visible = false;
					Workbook xlWorkBook = xlApp.Workbooks.Open(PublicVar.gstrRptPath + "INESTKD.xltx", RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
					Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Sheets["sheet1"];
					string strSQL = "INSTK_ITMCD, MAITM_RACKNO, MAITM_DESC, INSTK_BATCHNO, INSTK_STKQT, INSTK_DSPFG ";
					dt = DB.GetTable(strSQL, "INSTK_TBL LEFT JOIN MAITM_TBL ON MAITM_ITMCD = INSTK_ITMCD", "INSTK_DOCNO = '" + txtDOCNO.Text + "' AND INSTK_LOCID ='" + lkpLOCID.KeyValue + "' AND INSTK_DOCDT = '" + Common.gfSQLDate(dtpDOCDT.Value) + "'", "MAITM_RACKNO, INSTK_ITMCD");
					xlWorkSheet.Cells[2, 2] = "'" + dtpDOCDT.Value.ToString("dd/MM/yyyy");
					xlWorkSheet.Cells[3, 2] = "'" + lkpLOCID.KeyValue;
					xlWorkSheet.Cells[4, 2] = "'" + txtDOCNO.Text;
					ProgressBar1.Visible = true;
					ProgressBar1.Minimum = 0;
					ProgressBar1.Maximum = dt.Rows.Count;
					int num = dt.Rows.Count - 1;
					for (int iRow = 0; iRow <= num; iRow++)
					{
						ProgressBar1.Value = iRow + 1;
						iXLRow++;
						xlWorkSheet.Cells[iXLRow, 1] = "'" + dt.Rows[iRow]["INSTK_ITMCD"].ToString();
						xlWorkSheet.Cells[iXLRow, 2] = iRow + 1;
						xlWorkSheet.Cells[iXLRow, 3] = "'" + dt.Rows[iRow]["MAITM_RACKNO"].ToString();
						xlWorkSheet.Cells[iXLRow, 4] = "'" + dt.Rows[iRow]["MAITM_DESC"].ToString();
						xlWorkSheet.Cells[iXLRow, 5] = "'" + dt.Rows[iRow]["INSTK_BATCHNO"].ToString();
						xlWorkSheet.Cells[iXLRow, 6] = "'" + dt.Rows[iRow]["INSTK_STKQT"].ToString();
						xlWorkSheet.Cells[iXLRow, 7] = "'" + dt.Rows[iRow]["INSTK_DSPFG"].ToString();
					}
					Cursor = Cursors.Default;
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Stock Take Data download successfully!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					ProgressBar1.Visible = false;
					NewLateBinding.LateCall(NewLateBinding.LateGet(xlWorkBook.Sheets["Sheet1"], null, "Cells", new object[2] { 1, 1 }, null, null, null), null, "Select", new object[0], null, null, null, true);
					xlApp.Visible = true;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					ProjectData.ClearProjectError();
				}
			}
		}

		private void btnUPLOAD_Click(object sender, EventArgs e)
		{
			OpenFileDialog1.ShowDialog();
		}

		private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			UploadData();
			RefreshGrid();
		}

		private void btnDOWNLOAD_Click(object sender, EventArgs e)
		{
			CreateCSVfile();
		}

		private void btnGENERATE_Click(object sender, EventArgs e)
		{
			if (ValidateDetails() && GenerateData())
			{
				RefreshGrid();
				btnGENERATE.Enabled = false;
				btnPRINT.Enabled = true;
			}
		}

		private void RefreshGrid()
		{
			int i = 0;
			dgvDetails.DataSource = null;
			string strSQL = "SELECT INSTK_ITMCD, MAITM_RACKNO, MAITM_DESC, INSTK_BATCHNO, INSTK_SYSQT, INSTK_STKQT, INSTK_VARQT, INSTK_DSPFG ";
			strSQL += "FROM INSTK_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = INSTK_ITMCD ";
			strSQL = strSQL + "WHERE INSTK_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL += "ORDER BY MAITM_RACKNO, INSTK_ITMCD, INSTK_BATCHNO ";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 150;
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Rack");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Descriptions");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "System Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Stock Take Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 130;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Adjustment Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Dispose");
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.ClearSelection();
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void frmINESTKD_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Now.AddMonths(-1);
			Header();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			ClearDetails();
			RefreshGrid();
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void Header()
		{
			int count = dgvHEADER.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvHEADER.Rows.Remove(dgvHEADER.Rows[0]);
				}
				string strSQL = "EXEC spINSTG '0', ";
				strSQL = strSQL + "'" + lkpDOCNOFR.LowValue + "', ";
				strSQL = strSQL + "'" + lkpDOCNOTO.HighValue + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
				strSQL = strSQL + "'" + lkpLOCIDFR.LowValue + "', ";
				strSQL = strSQL + "'" + lkpLOCIDTO.HighValue + "'";
				System.Data.DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvHEADER.ClearSelection();
						dgvHEADER.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvHEADER.Rows[dgvHEADER.Rows.Count - 1];
						dataGridViewRow.Cells["INSTK_DOCNO"].Value = dt.Rows[i]["INSTK_DOCNO"].ToString();
						dataGridViewRow.Cells["INSTK_DOCDT"].Value = dt.Rows[i]["INSTK_DOCDT"].ToString();
						dataGridViewRow.Cells["DOCDT"].Value = dt.Rows[i]["DOCDT"].ToString();
						dataGridViewRow.Cells["STATUS"].Value = dt.Rows[i]["STATUS"].ToString();
						dataGridViewRow.Cells["INSTK_UPDFG"].Value = dt.Rows[i]["INSTK_UPDFG"].ToString();
						dataGridViewRow.Cells["INSTK_LOCID"].Value = dt.Rows[i]["INSTK_LOCID"].ToString();
						dataGridViewRow.Cells["INSTK_REMRK"].Value = dt.Rows[i]["INSTK_REMRK"].ToString();
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

		private bool UploadData()
		{
			Microsoft.Office.Interop.Excel.Application xlApp = new ApplicationClass();
			string strXLFolder = System.Windows.Forms.Application.StartupPath + "\\XL\\";
			string strXLFile = strXLFolder + "STK- " + lkpLOCID.KeyValue + "-" + dtpDOCDT.Value.Date.ToString("yyyyMMdd") + "-" + txtDOCNO.Text + ".xlsx";
			int iXLRow = 9;
			OleDbCommand cmd = new OleDbCommand();
			bool UploadData = default(bool);
			try
			{
				if (DB.RecordExists("SELECT INSTK_ENTBY FROM INSTK_TBL WHERE INSTK_DOCNO = '" + txtDOCNO.Text + "'"))
				{
					string strENTBY = Conversions.ToString(DB.GetColumnValue("INSTK_ENTBY", "INSTK_TBL", "INSTK_DOCNO = '" + txtDOCNO.Text + "'"));
					if (!Common.gfAllowEdit(strENTBY))
					{
						MessageBox.Show("This document is view only!\r\nOnly Supervisor user or document creator is allowed to amend.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						goto IL_0867;
					}
				}
				Workbook xlWorkBook = xlApp.Workbooks.Open(OpenFileDialog1.FileName, RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value), RuntimeHelpers.GetObjectValue(Missing.Value));
				xlApp.Visible = false;
				Worksheet xlWorkSheet = (Worksheet)xlWorkBook.Sheets["Sheet1"];
				Range xlsRange = xlWorkSheet.UsedRange;
				string strSQL;
				if (xlsRange.Columns.Count > 0 && xlsRange.Rows.Count > 0)
				{
					strSQL = "DELETE INSTK_WRK WHERE COMPNM = '" + MyProject.Computer.Name + "'";
					DB.ExecProc(strSQL);
					Cursor = Cursors.WaitCursor;
					ProgressBar1.Visible = true;
					ProgressBar1.Minimum = iXLRow;
					ProgressBar1.Maximum = xlsRange.Rows.Count;
					int num = iXLRow;
					int count = xlsRange.Rows.Count;
					for (int iRow = num; iRow <= count; iRow = checked(iRow + 1))
					{
						ProgressBar1.Value = iRow;
						string strITMCD = NewLateBinding.LateGet(xlsRange.Cells[iRow, 1], null, "text", new object[0], null, null, null).ToString().Trim();
						string strLOTNO = NewLateBinding.LateGet(xlsRange.Cells[iRow, 5], null, "text", new object[0], null, null, null).ToString().Trim();
						xlsRange.get_Range(RuntimeHelpers.GetObjectValue(xlsRange.Cells[iRow, 6]), RuntimeHelpers.GetObjectValue(xlsRange.Cells[iRow, 6])).NumberFormat = "0.00";
						if (Operators.CompareString(strITMCD, "", false) != 0)
						{
							strSQL = "SELECT * FROM INSTK_WRK WITH(NOLOCK) ";
							strSQL = strSQL + "WHERE COMPNM = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
							strSQL = strSQL + "AND ITMCD = '" + Common.gfValidSQLStr(strITMCD) + "' ";
							strSQL = strSQL + "AND BATCHNO = '" + Common.gfValidSQLStr(strLOTNO) + "' ";
							strSQL = strSQL + "AND DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
							if (DB.RecordExists(strSQL))
							{
								strSQL = "UPDATE INSTK_WRK SET ";
								strSQL = strSQL + "STKQT = STKQT + " + Conversions.ToString(Conversion.Val(NewLateBinding.LateGet(xlsRange.Cells[iRow, 6], null, "text", new object[0], null, null, null).ToString().Trim())) + ", ";
								strSQL = strSQL + "DSPFG = " + Conversions.ToString(Conversion.Val(NewLateBinding.LateGet(xlsRange.Cells[iRow, 7], null, "text", new object[0], null, null, null).ToString().Trim())) + ", ";
								strSQL = strSQL + "LUPBY = '" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "', ";
								strSQL = strSQL + "LUPDT = '" + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "' ";
								strSQL = strSQL + "WHERE COMPNM = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
								strSQL = strSQL + "AND ITMCD = '" + Common.gfValidSQLStr(strITMCD) + "' ";
								strSQL = strSQL + "AND BATCHNO = '" + Common.gfValidSQLStr(strLOTNO) + "' ";
								strSQL = strSQL + "AND DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
								DB.ExecProc(strSQL);
							}
							else
							{
								strSQL = "INSERT INSTK_WRK (COMPNM, DOCNO, DOCDT, LOCID, ITMCD, BATCHNO, STKQT, DSPFG, LUPBY, LUPDT)";
								strSQL += "VALUES (";
								strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
								strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
								strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
								strSQL = strSQL + "'" + lkpLOCID.KeyValue + "', ";
								strSQL = strSQL + "'" + Common.gfValidSQLStr(NewLateBinding.LateGet(xlsRange.Cells[iRow, 1], null, "text", new object[0], null, null, null).ToString().Trim()) + "', ";
								strSQL = strSQL + "'" + Common.gfValidSQLStr(NewLateBinding.LateGet(xlsRange.Cells[iRow, 5], null, "text", new object[0], null, null, null).ToString().Trim()) + "', ";
								strSQL = strSQL + " " + Conversions.ToString(Conversion.Val(NewLateBinding.LateGet(xlsRange.Cells[iRow, 6], null, "text", new object[0], null, null, null).ToString().Trim())) + ", ";
								strSQL = strSQL + " " + Conversions.ToString(Conversion.Val(NewLateBinding.LateGet(xlsRange.Cells[iRow, 7], null, "text", new object[0], null, null, null).ToString().Trim())) + ", ";
								strSQL = strSQL + "'" + PublicVar.gstrLogonID + "', ";
								strSQL = strSQL + "'" + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "')";
								DB.ExecProc(strSQL);
							}
						}
					}
				}
				Cursor = Cursors.Default;
				ProgressBar1.Visible = false;
				strSQL = "EXEC spINESTG_UPLOAD ";
				strSQL = strSQL + "'" + MyProject.Computer.Name + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
				}
				catch (Exception ex3)
				{
					ProjectData.SetProjectError(ex3);
					Exception ex2 = ex3;
					MessageBox.Show(ex2.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					UploadData = false;
					ProjectData.ClearProjectError();
					goto IL_0867;
				}
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				ProjectData.ClearProjectError();
			}
			UploadData = true;
			goto IL_0867;
			IL_0867:
			return UploadData;
		}

		private void KillExcelProcess()
		{
			try
			{
				Process[] Xcel = Process.GetProcessesByName("EXCEL");
				Process[] array = Xcel;
				foreach (Process Process in array)
				{
					Process.Kill();
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				ProjectData.ClearProjectError();
			}
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["INSTK_DOCNO"].Value.ToString();
			txtUPDFG.Text = dgvHEADER.CurrentRow.Cells["INSTK_UPDFG"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["INSTK_DOCDT"].Value);
			lkpLOCID.KeyValue = dgvHEADER.CurrentRow.Cells["INSTK_LOCID"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["INSTK_REMRK"].Value.ToString();
			lkpLOCID.Label1.Text = Conversions.ToString(DB.GetColumnValue("MALOC_LOCNM", "MALOC_TBL", "MALOC_LOCID = '" + lkpLOCID.KeyValue + "'"));
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindHeadertoControl();
			RefreshGrid();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnGENERATE.Enabled = false;
			btnPRINT.Enabled = true;
			if (Operators.CompareString(txtUPDFG.Text, "0", false) == 0)
			{
				btnDOWNLOAD.Enabled = true;
				btnUPLOAD.Enabled = true;
			}
			else
			{
				btnDOWNLOAD.Enabled = false;
				btnUPLOAD.Enabled = false;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure to cancel this Stock Take document?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				string strSQL = "UPDATE INSTK_TBL SET INSTK_UPDFG = '2' WHERE INSTK_DOCNO = '" + txtDOCNO.Text + "'";
				DB.ExecProc(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Stock Take Data cancelled!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				Header();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			Header();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "STOCK TAKE DATA CHECK LIST";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptINSTG.rpt";
			if (Operators.CompareString(txtDOCNO.Text, "", false) != 0)
			{
				frmRPT.Params = ("@PAR=1 ,@DOCNOFR=" + txtDOCNO.Text + ",@DOCNOTO=" + txtDOCNO.Text + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@LOCIDFR=" + lkpLOCID.KeyValue + ",@LOCIDTO=" + lkpLOCID.KeyValue) ?? "";
			}
			else
			{
				frmRPT.Params = ("@PAR=1 ,@DOCNOFR=" + lkpDOCNOFR.LowValue + ",@DOCNOTO=" + lkpDOCNOTO.HighValue + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDTFR.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDTTO.Value) + ",@LOCIDFR=" + lkpLOCIDFR.LowValue + ",@LOCIDTO=" + lkpLOCIDTO.HighValue) ?? "";
			}
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='STOCK TAKE DATA CHECK LIST',gintQTYDS=" + PublicVar.gintQTYDS + ",gintAMTDS=" + PublicVar.gintAMTDS + ",gintPRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void frmINESTG_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
