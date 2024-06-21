using System;
using System.ComponentModel;
using System.Data;
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
	public class frmINESTK : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnConfirm")]
		private Button _btnConfirm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDetails")]
		private DataGridView _dgvDetails;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

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
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private Button _btnPRINTFR;

		private OleDbCommand cmd;

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
		internal virtual TextBox txtDOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpLOCID")]
		internal virtual LookupControl lkpLOCID
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

		internal virtual Button btnConfirm
		{
			[CompilerGenerated]
			get
			{
				return _btnConfirm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnConfirm_Click;
				Button button = _btnConfirm;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnConfirm = value;
				button = _btnConfirm;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual DataGridView dgvDetails
		{
			[CompilerGenerated]
			get
			{
				return _dgvDetails;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDetails_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvDetails;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvDetails = value;
				dataGridView = _dgvDetails;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
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
		internal virtual Label lblCUSIDTO
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoALL")]
		internal virtual RadioButton rdoALL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("rdoPENDING")]
		internal virtual RadioButton rdoPENDING
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSTKQT")]
		internal virtual NumControl numSTKQT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
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

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtITMCD")]
		internal virtual TextBox txtITMCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSYSQT")]
		internal virtual NumControl numSYSQT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual TextBox txtREMRK
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

		[field: AccessedThroughProperty("numSAFETY")]
		internal virtual NumControl numSAFETY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
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

		[field: AccessedThroughProperty("DOCDT")]
		internal virtual DataGridViewTextBoxColumn DOCDT
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

		[field: AccessedThroughProperty("UPDFGNM")]
		internal virtual DataGridViewTextBoxColumn UPDFGNM
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

		[field: AccessedThroughProperty("INSTK_UPDFG")]
		internal virtual DataGridViewTextBoxColumn INSTK_UPDFG
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

		[field: AccessedThroughProperty("txtBATCHNO")]
		internal virtual TextBox txtBATCHNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmINESTK()
		{
			base.FormClosing += frmINESTK_FormClosing;
			base.Shown += frmINESTK_Shown;
			base.KeyDown += frmINESTK_KeyDown;
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtBATCHNO = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.numSAFETY = new IMS.NumControl();
			this.Label11 = new System.Windows.Forms.Label();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.numSTKQT = new IMS.NumControl();
			this.numSYSQT = new IMS.NumControl();
			this.txtITMCD = new System.Windows.Forms.TextBox();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.lkpLOCID = new IMS.LookupControl();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.INSTK_DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_LOCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UPDFGNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_UPDFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INSTK_DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.rdoPENDING = new System.Windows.Forms.RadioButton();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.lkpLOCIDFR = new IMS.LookupControl();
			this.lkpDOCNOFR = new IMS.LookupControl();
			this.lkpDOCNOTO = new IMS.LookupControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.rdoALL = new System.Windows.Forms.RadioButton();
			this.lkpLOCIDTO = new IMS.LookupControl();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel6);
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 692);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 2;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnConfirm, 0, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel6.TabIndex = 47;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(129, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 12;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirm.Image = IMS.My.Resources.Resources.Confirm;
			this.btnConfirm.Location = new System.Drawing.Point(3, 2);
			this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(120, 50);
			this.btnConfirm.TabIndex = 11;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.txtBATCHNO, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.numSAFETY, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.numSTKQT, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.numSYSQT, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtITMCD, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.dgvDetails, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lkpLOCID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 7);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 11;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(978, 598);
			this.TableLayoutPanel1.TabIndex = 0;
			this.txtBATCHNO.Enabled = false;
			this.txtBATCHNO.Location = new System.Drawing.Point(136, 413);
			this.txtBATCHNO.Name = "txtBATCHNO";
			this.txtBATCHNO.ReadOnly = true;
			this.txtBATCHNO.Size = new System.Drawing.Size(300, 26);
			this.txtBATCHNO.TabIndex = 58;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(3, 416);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(59, 20);
			this.Label12.TabIndex = 57;
			this.Label12.Text = "Lot No";
			this.numSAFETY.AllowNegative = false;
			this.numSAFETY.DataChanged = false;
			this.numSAFETY.Location = new System.Drawing.Point(136, 477);
			this.numSAFETY.Name = "numSAFETY";
			this.numSAFETY.NumberFormat = "8.2";
			this.numSAFETY.ReadOnly = true;
			this.numSAFETY.Size = new System.Drawing.Size(99, 26);
			this.numSAFETY.TabIndex = 56;
			this.numSAFETY.TabStop = false;
			this.numSAFETY.Text = "0.00";
			this.numSAFETY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSAFETY.ThousandSeperator = false;
			this.numSAFETY.Value = 0.0;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 480);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(108, 20);
			this.Label11.TabIndex = 55;
			this.Label11.Text = "Minimum Qty";
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel5, 2);
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnCancel, 1, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(3, 541);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel5.TabIndex = 52;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(3, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 50);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Update";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(129, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.numSTKQT.AllowNegative = false;
			this.numSTKQT.DataChanged = false;
			this.numSTKQT.Location = new System.Drawing.Point(136, 509);
			this.numSTKQT.Name = "numSTKQT";
			this.numSTKQT.NumberFormat = "8.2";
			this.numSTKQT.Size = new System.Drawing.Size(99, 26);
			this.numSTKQT.TabIndex = 8;
			this.numSTKQT.Text = "0.00";
			this.numSTKQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTKQT.ThousandSeperator = false;
			this.numSTKQT.Value = 0.0;
			this.numSYSQT.AllowNegative = false;
			this.numSYSQT.DataChanged = false;
			this.numSYSQT.Location = new System.Drawing.Point(136, 445);
			this.numSYSQT.Name = "numSYSQT";
			this.numSYSQT.NumberFormat = "8.2";
			this.numSYSQT.ReadOnly = true;
			this.numSYSQT.Size = new System.Drawing.Size(99, 26);
			this.numSYSQT.TabIndex = 7;
			this.numSYSQT.TabStop = false;
			this.numSYSQT.Text = "0.00";
			this.numSYSQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSYSQT.ThousandSeperator = false;
			this.numSYSQT.Value = 0.0;
			this.txtITMCD.Enabled = false;
			this.txtITMCD.Location = new System.Drawing.Point(136, 381);
			this.txtITMCD.Name = "txtITMCD";
			this.txtITMCD.ReadOnly = true;
			this.txtITMCD.Size = new System.Drawing.Size(300, 26);
			this.txtITMCD.TabIndex = 6;
			this.txtREMRK.Enabled = false;
			this.txtREMRK.Location = new System.Drawing.Point(136, 100);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(839, 59);
			this.txtREMRK.TabIndex = 4;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 6);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(112, 20);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 512);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(123, 20);
			this.Label9.TabIndex = 52;
			this.Label9.Text = "Stock Take Qty";
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDetails, 2);
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Location = new System.Drawing.Point(3, 165);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(972, 210);
			this.dgvDetails.TabIndex = 5;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 119);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(76, 20);
			this.Label10.TabIndex = 54;
			this.Label10.Text = "Remarks";
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
			this.lkpLOCID.Enabled = false;
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
			this.lkpLOCID.TabIndex = 3;
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
			this.dtpDOCDT.Enabled = false;
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(136, 68);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 26);
			this.dtpDOCDT.TabIndex = 3;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 384);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(85, 20);
			this.Label7.TabIndex = 50;
			this.Label7.Text = "Item Code";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 448);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(96, 20);
			this.Label8.TabIndex = 51;
			this.Label8.Text = "System Qty";
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(2, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 692);
			this.Panel2.TabIndex = 3;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Columns.AddRange(this.INSTK_DOCNO, this.DOCDT, this.INSTK_LOCID, this.UPDFGNM, this.INSTK_REMRK, this.INSTK_UPDFG, this.INSTK_DOCDT);
			this.dgvHEADER.Location = new System.Drawing.Point(5, 195);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(850, 490);
			this.dgvHEADER.TabIndex = 0;
			this.INSTK_DOCNO.HeaderText = "Doc No";
			this.INSTK_DOCNO.MinimumWidth = 6;
			this.INSTK_DOCNO.Name = "INSTK_DOCNO";
			this.INSTK_DOCNO.ReadOnly = true;
			this.INSTK_DOCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INSTK_DOCNO.Width = 150;
			this.DOCDT.HeaderText = "Doc Date";
			this.DOCDT.MinimumWidth = 6;
			this.DOCDT.Name = "DOCDT";
			this.DOCDT.ReadOnly = true;
			this.DOCDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DOCDT.Width = 130;
			this.INSTK_LOCID.HeaderText = "Location";
			this.INSTK_LOCID.MinimumWidth = 6;
			this.INSTK_LOCID.Name = "INSTK_LOCID";
			this.INSTK_LOCID.ReadOnly = true;
			this.INSTK_LOCID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INSTK_LOCID.Width = 150;
			this.UPDFGNM.HeaderText = "Status";
			this.UPDFGNM.MinimumWidth = 6;
			this.UPDFGNM.Name = "UPDFGNM";
			this.UPDFGNM.ReadOnly = true;
			this.UPDFGNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.UPDFGNM.Width = 125;
			this.INSTK_REMRK.HeaderText = "Remarks";
			this.INSTK_REMRK.MinimumWidth = 6;
			this.INSTK_REMRK.Name = "INSTK_REMRK";
			this.INSTK_REMRK.ReadOnly = true;
			this.INSTK_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INSTK_REMRK.Width = 250;
			this.INSTK_UPDFG.HeaderText = "INSTK_UPDFG";
			this.INSTK_UPDFG.MinimumWidth = 6;
			this.INSTK_UPDFG.Name = "INSTK_UPDFG";
			this.INSTK_UPDFG.ReadOnly = true;
			this.INSTK_UPDFG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INSTK_UPDFG.Visible = false;
			this.INSTK_UPDFG.Width = 80;
			this.INSTK_DOCDT.HeaderText = "INADJ_DOCDT";
			this.INSTK_DOCDT.MinimumWidth = 6;
			this.INSTK_DOCDT.Name = "INSTK_DOCDT";
			this.INSTK_DOCDT.ReadOnly = true;
			this.INSTK_DOCDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.INSTK_DOCDT.Visible = false;
			this.INSTK_DOCDT.Width = 125;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 135);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel4.TabIndex = 9;
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(129, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTFR.TabIndex = 10;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
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
			this.btnClose.TabIndex = 11;
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
			this.btnSEARCH.TabIndex = 9;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 5;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.rdoPENDING, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label6, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpLOCIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.lkpDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lkpDOCNOTO, 4, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 4, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.rdoALL, 2, 3);
			this.TableLayoutPanel2.Controls.Add(this.lkpLOCIDTO, 4, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 4;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(611, 126);
			this.TableLayoutPanel2.TabIndex = 1;
			this.rdoPENDING.AutoSize = true;
			this.rdoPENDING.Checked = true;
			this.rdoPENDING.Location = new System.Drawing.Point(136, 99);
			this.rdoPENDING.Name = "rdoPENDING";
			this.rdoPENDING.Size = new System.Drawing.Size(90, 24);
			this.rdoPENDING.TabIndex = 7;
			this.rdoPENDING.TabStop = true;
			this.rdoPENDING.Text = "Pending";
			this.rdoPENDING.UseVisualStyleBackColor = true;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 101);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(57, 20);
			this.Label6.TabIndex = 10;
			this.Label6.Text = "Status";
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
			this.TableLayoutPanel2.SetColumnSpan(this.lkpLOCIDFR, 2);
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
			this.TableLayoutPanel2.SetColumnSpan(this.lkpDOCNOFR, 2);
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
			this.rdoALL.AutoSize = true;
			this.rdoALL.Location = new System.Drawing.Point(247, 99);
			this.rdoALL.Name = "rdoALL";
			this.rdoALL.Size = new System.Drawing.Size(49, 24);
			this.rdoALL.TabIndex = 8;
			this.rdoALL.Text = "All";
			this.rdoALL.UseVisualStyleBackColor = true;
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
			base.ClientSize = new System.Drawing.Size(1350, 693);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmINESTK";
			base.Tag = "INESTK";
			this.Text = "Stock Take Data Maintenance";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmINESTK_FormClosing(object sender, FormClosingEventArgs e)
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
			txtDOCNO.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			dgvDetails.ClearSelection();
			dtpDOCDT.Value = DateTime.Now;
			btnConfirm.Enabled = true;
			btnSave.Enabled = true;
		}

		private void ClearControl()
		{
			numSTKQT.Value = 0.0;
			txtITMCD.Text = string.Empty;
			numSYSQT.Value = 0.0;
			numSAFETY.Value = 0.0;
		}

		private void RefreshGrid()
		{
			int i = 0;
			dgvDetails.DataSource = null;
			string strSQL = "SELECT INSTK_ITMCD, MAITM_DESC, INSTK_BATCHNO, INSTK_SYSQT, INSTK_STKQT, INSTK_VARQT ";
			strSQL += "FROM INSTK_TBL LEFT JOIN MAITM_TBL ON MAITM_ITMCD = INSTK_ITMCD ";
			strSQL = strSQL + "WHERE INSTK_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL += "ORDER BY INSTK_ITMCD";
			DataTable dt = DB.ExecProc(strSQL);
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
				dataGridView.Columns[i].Width = 250;
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
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 130;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Stock Take Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 130;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Adjustment Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.ClearSelection();
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void frmINESTK_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Now.AddMonths(-1);
			Header();
			NumberFormat();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
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
				int STSFG = default(int);
				if (rdoPENDING.Checked)
				{
					STSFG = 0;
				}
				else if (rdoALL.Checked)
				{
					STSFG = 1;
				}
				string strSQL = "EXEC spINSTK '0', ";
				strSQL = strSQL + "'" + lkpDOCNOFR.LowValue + "', ";
				strSQL = strSQL + "'" + lkpDOCNOTO.HighValue + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
				strSQL = strSQL + "'" + lkpLOCIDFR.LowValue + "', ";
				strSQL = strSQL + "'" + lkpLOCIDTO.HighValue + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(STSFG) + "'";
				DataTable dt = DB.ExecProc(strSQL);
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
						dataGridViewRow.Cells["INSTK_LOCID"].Value = dt.Rows[i]["INSTK_LOCID"].ToString();
						dataGridViewRow.Cells["INSTK_UPDFG"].Value = dt.Rows[i]["INSTK_UPDFG"].ToString();
						dataGridViewRow.Cells["UPDFGNM"].Value = dt.Rows[i]["UPDFGNM"].ToString();
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

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["INSTK_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["INSTK_DOCDT"].Value);
			lkpLOCID.KeyValue = dgvHEADER.CurrentRow.Cells["INSTK_LOCID"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["INSTK_REMRK"].Value.ToString();
			lkpLOCID.Label1.Text = Conversions.ToString(DB.GetColumnValue("MALOC_LOCNM", "MALOC_TBL", "MALOC_LOCID = '" + lkpLOCID.KeyValue + "'"));
		}

		private void BindGridtoControl()
		{
			txtITMCD.Text = dgvDetails.CurrentRow.Cells["INSTK_ITMCD"].Value.ToString();
			txtBATCHNO.Text = dgvDetails.CurrentRow.Cells["INSTK_BATCHNO"].Value.ToString();
			numSYSQT.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["INSTK_SYSQT"].Value.ToString());
			numSTKQT.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["INSTK_STKQT"].Value.ToString());
			numSAFETY.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_SAFETY", "MAITM_TBL", "MAITM_ITMCD = '" + txtITMCD.Text + "'"));
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindHeadertoControl();
			RefreshGrid();
			string STSFG = Conversions.ToString(DB.GetColumnValue("TOP 1 INSTK_UPDFG", "INSTK_TBL", "INSTK_DOCNO = '" + txtDOCNO.Text + "'"));
			if (Operators.CompareString(STSFG, "0", false) == 0)
			{
				btnConfirm.Enabled = true;
				btnSave.Enabled = true;
			}
			else
			{
				btnSave.Enabled = false;
				btnConfirm.Enabled = false;
			}
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearControl();
			Header();
		}

		private void dgvDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (spINESTK())
			{
				RefreshGrid();
				ClearControl();
			}
		}

		private bool spINESTK()
		{
            bool spINESTK = false;// default(bool);
            if (DB.RecordExists("SELECT INSTK_ENTBY FROM INSTK_TBL WHERE INSTK_DOCNO = '" + txtDOCNO.Text + "'"))
			{
				string strENTBY = Conversions.ToString(DB.GetColumnValue("INSTK_ENTBY", "INSTK_TBL", "INSTK_DOCNO = '" + txtDOCNO.Text + "'"));
				if (!Common.gfAllowEdit(strENTBY))
				{
					MessageBox.Show("This document is view only!\r\nOnly Supervisor user or document creator is allowed to amend.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					goto IL_0173;
				}
			}
			string strSQL = "EXEC spINESTK ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + txtITMCD.Text + "', ";
			strSQL = strSQL + "'" + txtBATCHNO.Text + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(numSTKQT.Value) + "', ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
			
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				spINESTK = false;
				ProjectData.ClearProjectError();
				goto IL_0173;
			}
			spINESTK = true;
			goto IL_0173;
			IL_0173:
			return spINESTK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearControl();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			string strSQL = "EXEC spINESTK_CONFIRM ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
				return;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document confirmed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			btnConfirm.Enabled = false;
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "STOCK TAKE DATA CHECK LIST";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptINSTK.rpt";
			int STSFG = default(int);
			if (rdoPENDING.Checked)
			{
				STSFG = 0;
			}
			else if (rdoALL.Checked)
			{
				STSFG = 1;
			}
			frmRPT.Params = ("@PAR=1 ,@DOCNOFR=" + lkpDOCNOFR.LowValue + ",@DOCNOTO=" + lkpDOCNOTO.HighValue + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDTFR.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDTTO.Value) + ",@LOCIDFR=" + lkpLOCIDFR.LowValue + ",@LOCIDTO=" + lkpLOCIDTO.HighValue + ",@STSFG=" + Conversions.ToString(STSFG)) ?? "";
			frmRPT.Formulas = ("COMNM='" + PublicVar.gstrCompany + "',RPTTITLE='STOCK TAKE DATA CHECK LIST',gintQTYDS=" + PublicVar.gintQTYDS + ",gintAMTDS=" + PublicVar.gintAMTDS + ",gintPRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void NumberFormat()
		{
			numSTKQT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numSYSQT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
		}

		private void frmINESTK_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
