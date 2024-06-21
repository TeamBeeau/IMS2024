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
	public class frmMAEROU : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

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
		[AccessedThroughProperty("dgvMAROU")]
		private DataGridView _dgvMAROU;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTR")]
		private Button _btnPRINTR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDETAILS")]
		private DataGridView _dgvDETAILS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCANCEL")]
		private Button _btnCANCEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbPROCD")]
		private ComboBox _cbPROCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbROUCDFR")]
		private ComboBox _cbROUCDFR;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblROUCD")]
		internal virtual Label lblROUCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblPROCD")]
		internal virtual Label lblPROCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOPRNO")]
		internal virtual Label lblOPRNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblROUNM")]
		internal virtual Label lblROUNM
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

		[field: AccessedThroughProperty("lblROUDCFR")]
		internal virtual Label lblROUDCFR
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

		internal virtual DataGridView dgvMAROU
		{
			[CompilerGenerated]
			get
			{
				return _dgvMAROU;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMAROU_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMAROU;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMAROU = value;
				dataGridView = _dgvMAROU;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("MACTY_TBLComboBox")]
		internal virtual ComboBox MACTY_TBLComboBox
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtOPRNO")]
		internal virtual TextBox txtOPRNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtROUNM")]
		internal virtual TextBox txtROUNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtROUCD")]
		internal virtual TextBox txtROUCD
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

		internal virtual Button btnPRINTR
		{
			[CompilerGenerated]
			get
			{
				return _btnPRINTR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPRINTR_Click;
				Button button = _btnPRINTR;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPRINTR = value;
				button = _btnPRINTR;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		internal virtual DataGridView dgvDETAILS
		{
			[CompilerGenerated]
			get
			{
				return _dgvDETAILS;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDETAILS_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvDETAILS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvDETAILS = value;
				dataGridView = _dgvDETAILS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnCANCEL
		{
			[CompilerGenerated]
			get
			{
				return _btnCANCEL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCANCEL_Click;
				Button button = _btnCANCEL;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCANCEL = value;
				button = _btnCANCEL;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnREMOVE
		{
			[CompilerGenerated]
			get
			{
				return _btnREMOVE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnREMOVE_Click;
				Button button = _btnREMOVE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnREMOVE = value;
				button = _btnREMOVE;
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

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
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

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAROU_ROUCD")]
		internal virtual DataGridViewTextBoxColumn MAROU_ROUCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAROU_ROUNM")]
		internal virtual DataGridViewTextBoxColumn MAROU_ROUNM
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

		[field: AccessedThroughProperty("MAROU_OPRNO")]
		internal virtual DataGridViewTextBoxColumn MAROU_OPRNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAROU_PROCD")]
		internal virtual DataGridViewTextBoxColumn MAROU_PROCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MAROU_MCHID")]
		internal virtual DataGridViewTextBoxColumn MAROU_MCHID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbPROCD
		{
			[CompilerGenerated]
			get
			{
				return _cbPROCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbPROCD_SelectedIndexChanged;
				ComboBox comboBox = _cbPROCD;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbPROCD = value;
				comboBox = _cbPROCD;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbMCHID")]
		internal virtual ComboBox cbMCHID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbROUCDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbROUCDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbROUCDFR_SelectedIndexChanged;
				ComboBox comboBox = _cbROUCDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbROUCDFR = value;
				comboBox = _cbROUCDFR;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbROUCDTO")]
		internal virtual ComboBox cbROUCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAEROU()
		{
			base.FormClosing += frmMAEROU_FormClosing;
			base.Shown += frmMAEROU_Shown;
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
			this.cbMCHID = new System.Windows.Forms.ComboBox();
			this.cbPROCD = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblPROCD = new System.Windows.Forms.Label();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.txtROUCD = new System.Windows.Forms.TextBox();
			this.btnBack = new System.Windows.Forms.Button();
			this.lblOPRNO = new System.Windows.Forms.Label();
			this.dgvDETAILS = new System.Windows.Forms.DataGridView();
			this.MAROU_OPRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAROU_PROCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAROU_MCHID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtOPRNO = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lblROUCD = new System.Windows.Forms.Label();
			this.lblROUNM = new System.Windows.Forms.Label();
			this.txtROUNM = new System.Windows.Forms.TextBox();
			this.btnPRINTR = new System.Windows.Forms.Button();
			this.dgvMAROU = new System.Windows.Forms.DataGridView();
			this.MAROU_ROUCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MAROU_ROUNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Label3 = new System.Windows.Forms.Label();
			this.lblROUDCFR = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.cbROUCDFR = new System.Windows.Forms.ComboBox();
			this.cbROUCDTO = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMAROU).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbMCHID, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.cbPROCD, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.lblPROCD, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.btnPRINT, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtROUCD, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnBack, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblOPRNO, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.dgvDETAILS, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtOPRNO, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.btnDelete, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblROUCD, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblROUNM, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtROUNM, 1, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 10;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(808, 435);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbMCHID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMCHID.FormattingEnabled = true;
			this.cbMCHID.Location = new System.Drawing.Point(107, 328);
			this.cbMCHID.Name = "cbMCHID";
			this.cbMCHID.Size = new System.Drawing.Size(209, 24);
			this.cbMCHID.TabIndex = 9;
			this.cbPROCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPROCD.FormattingEnabled = true;
			this.cbPROCD.Location = new System.Drawing.Point(107, 298);
			this.cbPROCD.Name = "cbPROCD";
			this.cbPROCD.Size = new System.Drawing.Size(209, 24);
			this.cbPROCD.TabIndex = 8;
			this.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel5, 6);
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnCANCEL, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(4, 379);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(378, 52);
			this.TableLayoutPanel5.TabIndex = 11;
			this.btnCANCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCANCEL.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCANCEL.Location = new System.Drawing.Point(255, 2);
			this.btnCANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.Size = new System.Drawing.Size(120, 48);
			this.btnCANCEL.TabIndex = 8;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCANCEL.UseVisualStyleBackColor = false;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(129, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 48);
			this.btnREMOVE.TabIndex = 7;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(3, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 48);
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Add";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 332);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(75, 16);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "Machine ID";
			this.lblPROCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPROCD.AutoSize = true;
			this.lblPROCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPROCD.Location = new System.Drawing.Point(3, 302);
			this.lblPROCD.Name = "lblPROCD";
			this.lblPROCD.Size = new System.Drawing.Size(94, 16);
			this.lblPROCD.TabIndex = 7;
			this.lblPROCD.Text = "Process Code";
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(685, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.TableLayoutPanel1.SetRowSpan(this.btnPRINT, 2);
			this.btnPRINT.Size = new System.Drawing.Size(120, 48);
			this.btnPRINT.TabIndex = 11;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.txtROUCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtROUCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtROUCD.Location = new System.Drawing.Point(107, 2);
			this.txtROUCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtROUCD.Name = "txtROUCD";
			this.txtROUCD.Size = new System.Drawing.Size(151, 22);
			this.txtROUCD.TabIndex = 1;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(559, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.TableLayoutPanel1.SetRowSpan(this.btnBack, 2);
			this.btnBack.Size = new System.Drawing.Size(120, 48);
			this.btnBack.TabIndex = 10;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.lblOPRNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOPRNO.AutoSize = true;
			this.lblOPRNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOPRNO.Location = new System.Drawing.Point(3, 274);
			this.lblOPRNO.Name = "lblOPRNO";
			this.lblOPRNO.Size = new System.Drawing.Size(98, 16);
			this.lblOPRNO.TabIndex = 8;
			this.lblOPRNO.Text = "Operation Seq.";
			this.dgvDETAILS.AllowUserToAddRows = false;
			this.dgvDETAILS.AllowUserToDeleteRows = false;
			this.dgvDETAILS.AllowUserToResizeRows = false;
			this.dgvDETAILS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDETAILS.Columns.AddRange(this.MAROU_OPRNO, this.MAROU_PROCD, this.MAROU_MCHID);
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDETAILS, 6);
			this.dgvDETAILS.Location = new System.Drawing.Point(3, 64);
			this.dgvDETAILS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvDETAILS.MultiSelect = false;
			this.dgvDETAILS.Name = "dgvDETAILS";
			this.dgvDETAILS.ReadOnly = true;
			this.dgvDETAILS.RowHeadersVisible = false;
			this.dgvDETAILS.RowTemplate.Height = 24;
			this.dgvDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDETAILS.Size = new System.Drawing.Size(473, 193);
			this.dgvDETAILS.TabIndex = 10;
			this.MAROU_OPRNO.DataPropertyName = "MAROU_OPRNO";
			this.MAROU_OPRNO.HeaderText = "Operation No";
			this.MAROU_OPRNO.Name = "MAROU_OPRNO";
			this.MAROU_OPRNO.ReadOnly = true;
			this.MAROU_OPRNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAROU_PROCD.DataPropertyName = "MAROU_PROCD";
			this.MAROU_PROCD.HeaderText = "Process Code";
			this.MAROU_PROCD.Name = "MAROU_PROCD";
			this.MAROU_PROCD.ReadOnly = true;
			this.MAROU_PROCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAROU_PROCD.Width = 120;
			this.MAROU_MCHID.DataPropertyName = "MAROU_MCHID";
			this.MAROU_MCHID.HeaderText = "Machine ID";
			this.MAROU_MCHID.Name = "MAROU_MCHID";
			this.MAROU_MCHID.ReadOnly = true;
			this.MAROU_MCHID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.txtOPRNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtOPRNO.Location = new System.Drawing.Point(107, 271);
			this.txtOPRNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOPRNO.Name = "txtOPRNO";
			this.txtOPRNO.Size = new System.Drawing.Size(63, 22);
			this.txtOPRNO.TabIndex = 3;
			this.txtOPRNO.Text = "0";
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(433, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.TableLayoutPanel1.SetRowSpan(this.btnDelete, 2);
			this.btnDelete.Size = new System.Drawing.Size(120, 48);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.lblROUCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblROUCD.AutoSize = true;
			this.lblROUCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblROUCD.Location = new System.Drawing.Point(3, 5);
			this.lblROUCD.Name = "lblROUCD";
			this.lblROUCD.Size = new System.Drawing.Size(80, 16);
			this.lblROUCD.TabIndex = 1;
			this.lblROUCD.Text = "Route Code";
			this.lblROUNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblROUNM.AutoSize = true;
			this.lblROUNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblROUNM.Location = new System.Drawing.Point(3, 31);
			this.lblROUNM.Name = "lblROUNM";
			this.lblROUNM.Size = new System.Drawing.Size(84, 16);
			this.lblROUNM.TabIndex = 9;
			this.lblROUNM.Text = "Route Name";
			this.txtROUNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtROUNM.Location = new System.Drawing.Point(107, 28);
			this.txtROUNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtROUNM.Name = "txtROUNM";
			this.txtROUNM.Size = new System.Drawing.Size(300, 22);
			this.txtROUNM.TabIndex = 2;
			this.btnPRINTR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTR.Location = new System.Drawing.Point(255, 2);
			this.btnPRINTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTR.Name = "btnPRINTR";
			this.btnPRINTR.Size = new System.Drawing.Size(120, 48);
			this.btnPRINTR.TabIndex = 7;
			this.btnPRINTR.Text = "Print";
			this.btnPRINTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTR.UseVisualStyleBackColor = false;
			this.dgvMAROU.AllowUserToAddRows = false;
			this.dgvMAROU.AllowUserToDeleteRows = false;
			this.dgvMAROU.AllowUserToResizeRows = false;
			this.dgvMAROU.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMAROU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMAROU.Columns.AddRange(this.MAROU_ROUCD, this.MAROU_ROUNM);
			this.dgvMAROU.Location = new System.Drawing.Point(5, 118);
			this.dgvMAROU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMAROU.MultiSelect = false;
			this.dgvMAROU.Name = "dgvMAROU";
			this.dgvMAROU.ReadOnly = true;
			this.dgvMAROU.RowHeadersVisible = false;
			this.dgvMAROU.RowTemplate.Height = 24;
			this.dgvMAROU.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMAROU.Size = new System.Drawing.Size(687, 412);
			this.dgvMAROU.TabIndex = 5;
			this.MAROU_ROUCD.DataPropertyName = "MAROU_ROUCD";
			this.MAROU_ROUCD.HeaderText = "Route Code";
			this.MAROU_ROUCD.Name = "MAROU_ROUCD";
			this.MAROU_ROUCD.ReadOnly = true;
			this.MAROU_ROUCD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAROU_ROUNM.DataPropertyName = "MAROU_ROUNM";
			this.MAROU_ROUNM.HeaderText = "Route Name";
			this.MAROU_ROUNM.Name = "MAROU_ROUNM";
			this.MAROU_ROUNM.ReadOnly = true;
			this.MAROU_ROUNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MAROU_ROUNM.Width = 300;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
			this.TableLayoutPanel2.Controls.Add(this.cbROUCDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbROUCDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label3, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblROUDCFR, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(529, 30);
			this.TableLayoutPanel2.TabIndex = 1;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(295, 7);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(25, 16);
			this.Label3.TabIndex = 7;
			this.Label3.Text = "To";
			this.lblROUDCFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblROUDCFR.AutoSize = true;
			this.lblROUDCFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblROUDCFR.Location = new System.Drawing.Point(3, 7);
			this.lblROUDCFR.Name = "lblROUDCFR";
			this.lblROUDCFR.Size = new System.Drawing.Size(80, 16);
			this.lblROUDCFR.TabIndex = 2;
			this.lblROUDCFR.Text = "Route Code";
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1340, 580);
			this.Panel1.TabIndex = 12;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel6);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvMAROU);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1340, 580);
			this.Panel2.TabIndex = 13;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINTR, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 55);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52f));
			this.TableLayoutPanel6.Size = new System.Drawing.Size(504, 52);
			this.TableLayoutPanel6.TabIndex = 9;
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
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.cbROUCDFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbROUCDFR.FormattingEnabled = true;
			this.cbROUCDFR.Location = new System.Drawing.Point(89, 3);
			this.cbROUCDFR.Name = "cbROUCDFR";
			this.cbROUCDFR.Size = new System.Drawing.Size(200, 24);
			this.cbROUCDFR.TabIndex = 10;
			this.cbROUCDTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbROUCDTO.FormattingEnabled = true;
			this.cbROUCDTO.Location = new System.Drawing.Point(326, 3);
			this.cbROUCDTO.Name = "cbROUCDTO";
			this.cbROUCDTO.Size = new System.Drawing.Size(200, 24);
			this.cbROUCDTO.TabIndex = 11;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAEROU";
			base.Tag = "MAEROU";
			this.Text = "Route Master";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDETAILS).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMAROU).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private bool spMAEROU(string strPRO)
		{
			Cursor = Cursors.WaitCursor;
			string strSQL = "EXEC spMAEROU ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(strPRO) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtROUCD.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtROUNM.Text) + "', ";
			strSQL = strSQL + " " + Conversions.ToString(Conversion.Val(txtOPRNO.Text)) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPROCD.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMCHID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "'";
			bool spMAEROU;
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
				Cursor = Cursors.Default;
				spMAEROU = false;
				ProjectData.ClearProjectError();
				goto IL_016d;
			}
			Cursor = Cursors.Default;
			spMAEROU = true;
			goto IL_016d;
			IL_016d:
			return spMAEROU;
		}

		private void RefreshGrid()
		{
			if (dgvDETAILS.Rows.Count > 0)
			{
				dgvDETAILS.Rows.Clear();
			}
			string strSQL = "MAROU_OPRNO, MAROU_PROCD, MAROU_MCHID";
			DataTable dt = DB.GetTable(strSQL, "MAROU_TBL", "MAROU_ROUCD = '" + Common.gfValidSQLStr(txtROUCD.Text) + "'", "MAROU_ROUCD, MAROU_OPRNO, MAROU_PROCD");
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dgvDETAILS.Rows.Add();
					dgvDETAILS.ClearSelection();
					dgvDETAILS.Rows[dgvDETAILS.Rows.Count - 1].Selected = true;
					dgvDETAILS.CurrentCell = dgvDETAILS.Rows[dgvDETAILS.Rows.Count - 1].Cells[0];
					dgvDETAILS.CurrentRow.Cells["MAROU_OPRNO"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAROU_OPRNO"].ToString());
					dgvDETAILS.CurrentRow.Cells["MAROU_PROCD"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAROU_PROCD"].ToString());
					dgvDETAILS.CurrentRow.Cells["MAROU_MCHID"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAROU_MCHID"].ToString());
				}
			}
		}

		private void ClearDetails()
		{
			txtOPRNO.Text = Conversions.ToString(0);
			cbPROCD.SelectedIndex = -1;
			cbMCHID.SelectedIndex = -1;
			btnSave.Tag = "Add";
			btnREMOVE.Enabled = false;
		}

		private void ClearControl()
		{
			dgvDETAILS.Rows.Clear();
			txtROUCD.Text = string.Empty;
			txtROUNM.Text = string.Empty;
			btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
			txtROUCD.Enabled = true;
			txtROUNM.Enabled = true;
		}

		private void Header()
		{
			int count = dgvMAROU.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvMAROU.Rows.Remove(dgvMAROU.Rows[0]);
				}
				string strSQL = "EXEC spMAROU '0', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbROUCDFR.SelectedValue)) + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbROUCDTO.SelectedValue)) + "'";
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvMAROU.ClearSelection();
						dgvMAROU.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvMAROU.Rows[dgvMAROU.Rows.Count - 1];
						dataGridViewRow.Cells["MAROU_ROUCD"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAROU_ROUCD"].ToString());
						dataGridViewRow.Cells["MAROU_ROUNM"].Value = Common.gfValidSQLStr(dt.Rows[i]["MAROU_ROUNM"].ToString());
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
				Panel1.Visible = false;
				Panel2.Visible = true;
			}
		}

		private void BindHeadertoControl()
		{
			txtROUCD.Text = dgvMAROU.CurrentRow.Cells["MAROU_ROUCD"].Value.ToString();
			txtROUNM.Text = dgvMAROU.CurrentRow.Cells["MAROU_ROUNM"].Value.ToString();
		}

		private void BindGridtoControl()
		{
			txtOPRNO.Text = dgvDETAILS.CurrentRow.Cells["MAROU_OPRNO"].Value.ToString();
			cbPROCD.SelectedValue = dgvDETAILS.CurrentRow.Cells["MAROU_PROCD"].Value.ToString();
			cbMCHID.SelectedValue = dgvDETAILS.CurrentRow.Cells["MAROU_MCHID"].Value.ToString();
			NewLateBinding.LateIndexSetComplex(cbPROCD.SelectedItem, new object[2]
			{
				1,
				DB.GetColumnValue("MACOD_CODNM", "MACOD_TBL", "MACOD_CTYID = 'PROCD' AND MACOD_CODID= '" + Common.gfValidSQLStr(Conversions.ToString(cbPROCD.SelectedValue)) + "'")
			}, null, false, true);
			NewLateBinding.LateIndexSetComplex(cbMCHID.SelectedItem, new object[2]
			{
				1,
				DB.GetColumnValue("MAMCH_MCHNM", "MAMCH_TBL", "MAMCH_MCHID= '" + Common.gfValidSQLStr(Conversions.ToString(cbMCHID.SelectedValue)) + "'")
			}, null, false, true);
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			BindComboBox();
			ClearDetails();
			ClearControl();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'PROCD' ";
			strSQL += " ORDER BY MACOD_CODID ";
			cbPROCD.ValueMember = "MACOD_CODID";
			cbPROCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbPROCD);
		}

		private void frmMAEROU_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAEROU_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Header();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!Conversions.ToBoolean(Operators.NotObject(ValidateDetails())) && spMAEROU("0"))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record edited!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefreshGrid();
				ClearDetails();
				btnDelete.Enabled = true;
				btnPRINT.Enabled = true;
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Header();
			ClearDetails();
			ClearControl();
		}

		private void dgvMAROU_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = true;
			btnPRINT.Enabled = true;
			btnREMOVE.Enabled = false;
			txtROUCD.Enabled = false;
			txtROUNM.Enabled = false;
			BindComboBox();
			BindHeadertoControl();
			RefreshGrid();
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
			{
				spMAEROU("1");
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				ClearControl();
				Header();
			}
		}

		private object ValidateDetails()
		{
			if (Operators.CompareString(txtROUCD.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Route Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtROUCD.Focus();
				return false;
			}
			if (Operators.CompareString(txtROUNM.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Route Name cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtROUCD.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbPROCD.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Process Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbPROCD.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbMCHID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Machine ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbMCHID.Focus();
				return false;
			}
			return true;
		}

		private void btnPRINTR_Click(object sender, EventArgs e)
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
			frmRPT.ReportName = "Route Master";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMAROU.rpt";
			if (Operators.CompareString(txtROUCD.Text, "", false) != 0)
			{
				frmRPT.Params = ("@PAR=1 ,@ROUCDfr=" + Common.gfValidSQLStr(txtROUCD.Text) + ",@ROUCDto=" + Common.gfValidSQLStr(txtROUCD.Text)) ?? "";
			}
			else
			{
				frmRPT.Params = ("@PAR=1 ,@ROUCDfr=" + Common.gfValidSQLStr(Conversions.ToString(cbROUCDFR.SelectedValue)) + ",@ROUCDto=" + Common.gfValidSQLStr(Conversions.ToString(cbROUCDTO.SelectedValue))) ?? "";
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='Route Master'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void BindComboHeader()
		{
			string strSQL = "SELECT '' as MAROU_ROUCD, '' as MAROU_ROUNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MAROU_ROUCD, MAROU_ROUNM ";
			strSQL += "FROM MAROU_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MAROU_ROUCD ";
			cbROUCDFR.ValueMember = "MAROU_ROUCD";
			cbROUCDFR.DisplayMember = "MAROU_ROUNM";
			Common.RetriveComboItembySQL(strSQL, cbROUCDFR);
			cbROUCDTO.ValueMember = "MAROU_ROUCD";
			cbROUCDTO.DisplayMember = "MAROU_ROUNM";
			Common.RetriveComboItembySQL(strSQL, cbROUCDTO);
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void dgvDETAILS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
			btnSave.Tag = "Update";
			btnREMOVE.Enabled = true;
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			string strSQL = "DELETE MAROU_TBL WHERE MAROU_ROUCD = '" + Common.gfValidSQLStr(txtROUCD.Text) + "' AND MAROU_PROCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbPROCD.SelectedValue)) + "' AND MAROU_MCHID = '" + Common.gfValidSQLStr(Conversions.ToString(cbMCHID.SelectedValue)) + "'";
			DB.DBExecute(strSQL);
			RefreshGrid();
			ClearDetails();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbPROCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT DISTINCT MAMCH_MCHID, MAMCH_MCHNM FROM MAMCH_TBL WITH(NOLOCK) WHERE MAMCH_PROCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbPROCD.SelectedValue)) + "'";
			strSQL += " ORDER BY MAMCH_MCHID ";
			cbMCHID.ValueMember = "MAMCH_MCHID";
			cbMCHID.DisplayMember = "MAMCH_MCHNM";
			Common.RetriveComboItembySQL(strSQL, cbMCHID);
		}

		private void cbROUCDFR_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbROUCDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbROUCDFR.SelectedValue);
		}
	}
}
