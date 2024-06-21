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
	public class frmMAESPR : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

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
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMASPR")]
		private DataGridView _dgvMASPR;

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
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private Button _btnPRINTFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSIDFR")]
		private ComboboxControl _cbCUSIDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCDFR")]
		private ComboboxControl _cbITMCDFR;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

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

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numPRICE")]
		internal virtual NumControl numPRICE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblEFFDT")]
		internal virtual Label lblEFFDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpEFFDT")]
		internal virtual DateTimePicker dtpEFFDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblPRICE")]
		internal virtual Label lblPRICE
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

		[field: AccessedThroughProperty("lblCUSID")]
		internal virtual Label lblCUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblITMCD")]
		internal virtual Label lblITMCD
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

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvMASPR
		{
			[CompilerGenerated]
			get
			{
				return _dgvMASPR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMASPR_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMASPR;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMASPR = value;
				dataGridView = _dgvMASPR;
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCUSIDTO")]
		internal virtual ComboboxControl cbCUSIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbCUSIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbCUSIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbCUSIDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbCUSIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbCUSIDFR = value;
				comboboxControl = _cbCUSIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
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

		[field: AccessedThroughProperty("dtpEFFDTTO")]
		internal virtual DateTimePicker dtpEFFDTTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpEFFDTFR")]
		internal virtual DateTimePicker dtpEFFDTFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblITMCDFR")]
		internal virtual Label lblITMCDFR
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

		[field: AccessedThroughProperty("lblITMCDTO")]
		internal virtual Label lblITMCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbITMCDTO")]
		internal virtual ComboboxControl cbITMCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbITMCDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbITMCDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbITMCDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbITMCDFR = value;
				comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbCUSID")]
		internal virtual ComboboxControl cbCUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbITMCD")]
		internal virtual ComboboxControl cbITMCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAESPR()
		{
			base.FormClosing += frmMAESPR_FormClosing;
			base.Shown += frmMAESPR_Shown;
			base.KeyDown += frmMAESPR_KeyDown;
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbITMCD = new IMS.ComboboxControl();
			this.cbCUSID = new IMS.ComboboxControl();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.numPRICE = new IMS.NumControl();
			this.lblEFFDT = new System.Windows.Forms.Label();
			this.dtpEFFDT = new System.Windows.Forms.DateTimePicker();
			this.lblPRICE = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblCUSID = new System.Windows.Forms.Label();
			this.lblITMCD = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvMASPR = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.cbCUSIDTO = new IMS.ComboboxControl();
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.cbCUSIDFR = new IMS.ComboboxControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpEFFDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpEFFDTFR = new System.Windows.Forms.DateTimePicker();
			this.lblITMCDFR = new System.Windows.Forms.Label();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.lblITMCDTO = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMASPR).BeginInit();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1580, 672);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbITMCD, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbCUSID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.numPRICE, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblEFFDT, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpEFFDT, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblPRICE, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblCUSID, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblITMCD, 0, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 9;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(636, 285);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbITMCD.BlankValue = null;
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = true;
			this.cbITMCD.Location = new System.Drawing.Point(100, 35);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(324, 26);
			this.cbITMCD.TabIndex = 11;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.cbCUSID.BlankValue = null;
			this.cbCUSID.ComboboxWidth = 170;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = true;
			this.cbCUSID.Location = new System.Drawing.Point(100, 3);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(324, 26);
			this.cbCUSID.TabIndex = 10;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 5;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 2);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnBack, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 229);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel3.TabIndex = 1;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(507, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 10;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(381, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 9;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
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
			this.btnSave.TabIndex = 6;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(129, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.txtREMRK.Location = new System.Drawing.Point(100, 143);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(456, 61);
			this.txtREMRK.TabIndex = 5;
			this.numPRICE.AllowNegative = false;
			this.numPRICE.DataChanged = false;
			this.numPRICE.Location = new System.Drawing.Point(100, 105);
			this.numPRICE.Name = "numPRICE";
			this.numPRICE.NumberFormat = "8.2";
			this.numPRICE.Size = new System.Drawing.Size(152, 22);
			this.numPRICE.TabIndex = 4;
			this.numPRICE.Text = "0.00";
			this.numPRICE.ThousandSeperator = false;
			this.numPRICE.Value = 0.0;
			this.lblEFFDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEFFDT.AutoSize = true;
			this.lblEFFDT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEFFDT.Location = new System.Drawing.Point(3, 70);
			this.lblEFFDT.Name = "lblEFFDT";
			this.lblEFFDT.Size = new System.Drawing.Size(91, 16);
			this.lblEFFDT.TabIndex = 1;
			this.lblEFFDT.Text = "Effective Date";
			this.dtpEFFDT.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDT.Location = new System.Drawing.Point(100, 67);
			this.dtpEFFDT.Name = "dtpEFFDT";
			this.dtpEFFDT.Size = new System.Drawing.Size(104, 22);
			this.dtpEFFDT.TabIndex = 3;
			this.lblPRICE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPRICE.AutoSize = true;
			this.lblPRICE.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPRICE.Location = new System.Drawing.Point(3, 108);
			this.lblPRICE.Name = "lblPRICE";
			this.lblPRICE.Size = new System.Drawing.Size(39, 16);
			this.lblPRICE.TabIndex = 8;
			this.lblPRICE.Text = "Price";
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 165);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(56, 16);
			this.lblREMRK.TabIndex = 6;
			this.lblREMRK.Text = "Remark";
			this.lblCUSID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSID.AutoSize = true;
			this.lblCUSID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSID.Location = new System.Drawing.Point(3, 8);
			this.lblCUSID.Name = "lblCUSID";
			this.lblCUSID.Size = new System.Drawing.Size(81, 16);
			this.lblCUSID.TabIndex = 0;
			this.lblCUSID.Text = "Customer ID";
			this.lblITMCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCD.AutoSize = true;
			this.lblITMCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCD.Location = new System.Drawing.Point(3, 40);
			this.lblITMCD.Name = "lblITMCD";
			this.lblITMCD.Size = new System.Drawing.Size(69, 16);
			this.lblITMCD.TabIndex = 2;
			this.lblITMCD.Text = "Item Code";
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.dgvMASPR);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1580, 672);
			this.Panel2.TabIndex = 2;
			this.dgvMASPR.AllowUserToAddRows = false;
			this.dgvMASPR.AllowUserToDeleteRows = false;
			this.dgvMASPR.AllowUserToResizeRows = false;
			this.dgvMASPR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMASPR.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMASPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMASPR.Location = new System.Drawing.Point(5, 176);
			this.dgvMASPR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMASPR.MultiSelect = false;
			this.dgvMASPR.Name = "dgvMASPR";
			this.dgvMASPR.ReadOnly = true;
			this.dgvMASPR.RowHeadersVisible = false;
			this.dgvMASPR.RowTemplate.Height = 24;
			this.dgvMASPR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMASPR.Size = new System.Drawing.Size(1131, 369);
			this.dgvMASPR.TabIndex = 0;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 114);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel4.TabIndex = 9;
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
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbITMCDTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbITMCDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpEFFDTTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpEFFDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblITMCDFR, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblITMCDTO, 2, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(800, 86);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(469, 32);
			this.cbITMCDTO.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
			this.cbITMCDTO.Name = "cbITMCDTO";
			this.cbITMCDTO.SelectedIndex = -1;
			this.cbITMCDTO.SelectedItem = null;
			this.cbITMCDTO.SelectedValue = null;
			this.cbITMCDTO.Size = new System.Drawing.Size(324, 26);
			this.cbITMCDTO.TabIndex = 14;
			this.cbITMCDTO.TextMultiline = true;
			this.cbITMCDTO.ValueMember = null;
			this.cbITMCDTO.WhereClause = null;
			this.cbCUSIDTO.BlankValue = null;
			this.cbCUSIDTO.ComboboxWidth = 170;
			this.cbCUSIDTO.DataTable = null;
			this.cbCUSIDTO.DisplayMember = null;
			this.cbCUSIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDTO.HasBlankValue = true;
			this.cbCUSIDTO.Location = new System.Drawing.Point(467, 2);
			this.cbCUSIDTO.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbCUSIDTO.Name = "cbCUSIDTO";
			this.cbCUSIDTO.SelectedIndex = -1;
			this.cbCUSIDTO.SelectedItem = null;
			this.cbCUSIDTO.SelectedValue = null;
			this.cbCUSIDTO.Size = new System.Drawing.Size(324, 26);
			this.cbCUSIDTO.TabIndex = 12;
			this.cbCUSIDTO.TextMultiline = true;
			this.cbCUSIDTO.ValueMember = null;
			this.cbCUSIDTO.WhereClause = null;
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(102, 32);
			this.cbITMCDFR.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbITMCDFR.Name = "cbITMCDFR";
			this.cbITMCDFR.SelectedIndex = -1;
			this.cbITMCDFR.SelectedItem = null;
			this.cbITMCDFR.SelectedValue = null;
			this.cbITMCDFR.Size = new System.Drawing.Size(324, 26);
			this.cbITMCDFR.TabIndex = 13;
			this.cbITMCDFR.TextMultiline = true;
			this.cbITMCDFR.ValueMember = null;
			this.cbITMCDFR.WhereClause = null;
			this.cbCUSIDFR.BlankValue = null;
			this.cbCUSIDFR.ComboboxWidth = 170;
			this.cbCUSIDFR.DataTable = null;
			this.cbCUSIDFR.DisplayMember = null;
			this.cbCUSIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDFR.HasBlankValue = true;
			this.cbCUSIDFR.Location = new System.Drawing.Point(101, 2);
			this.cbCUSIDFR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbCUSIDFR.Name = "cbCUSIDFR";
			this.cbCUSIDFR.SelectedIndex = -1;
			this.cbCUSIDFR.SelectedItem = null;
			this.cbCUSIDFR.SelectedValue = null;
			this.cbCUSIDFR.Size = new System.Drawing.Size(324, 26);
			this.cbCUSIDFR.TabIndex = 11;
			this.cbCUSIDFR.TextMultiline = true;
			this.cbCUSIDFR.ValueMember = null;
			this.cbCUSIDFR.WhereClause = null;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(91, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Effective Date";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(434, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpEFFDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDTTO.Location = new System.Drawing.Point(465, 62);
			this.dtpEFFDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDTTO.Name = "dtpEFFDTTO";
			this.dtpEFFDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpEFFDTTO.TabIndex = 6;
			this.dtpEFFDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDTFR.Location = new System.Drawing.Point(100, 62);
			this.dtpEFFDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDTFR.Name = "dtpEFFDTFR";
			this.dtpEFFDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpEFFDTFR.TabIndex = 5;
			this.lblITMCDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCDFR.AutoSize = true;
			this.lblITMCDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCDFR.Location = new System.Drawing.Point(3, 37);
			this.lblITMCDFR.Name = "lblITMCDFR";
			this.lblITMCDFR.Size = new System.Drawing.Size(69, 16);
			this.lblITMCDFR.TabIndex = 4;
			this.lblITMCDFR.Text = "Item Code";
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(434, 7);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(25, 16);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 7);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(81, 16);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Customer ID";
			this.lblITMCDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCDTO.AutoSize = true;
			this.lblITMCDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCDTO.Location = new System.Drawing.Point(434, 37);
			this.lblITMCDTO.Name = "lblITMCDTO";
			this.lblITMCDTO.Size = new System.Drawing.Size(25, 16);
			this.lblITMCDTO.TabIndex = 3;
			this.lblITMCDTO.Text = "To";
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAESPR";
			this.Text = "Sales Price Master";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMASPR).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void BindComboHeader()
		{
			cbCUSIDFR.DataTable = "MASPR_TBL  WITH (NOLOCK) LEFT JOIN MACUS_TBL WITH (NOLOCK) ON MACUS_CUSID = MASPR_CUSID ";
			cbCUSIDFR.ValueMember = "MASPR_CUSID";
			cbCUSIDFR.DisplayMember = "MACUS_SHORT";
			cbCUSIDFR.LoadData();
			cbCUSIDTO.DataTable = "MASPR_TBL WITH (NOLOCK) LEFT JOIN MACUS_TBL WITH (NOLOCK) ON MACUS_CUSID = MASPR_CUSID ";
			cbCUSIDTO.ValueMember = "MASPR_CUSID";
			cbCUSIDTO.DisplayMember = "MACUS_SHORT";
			cbCUSIDTO.LoadData();
			cbITMCDFR.DataTable = "MASPR_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = MASPR_ITMCD ";
			cbITMCDFR.ValueMember = "MASPR_ITMCD";
			cbITMCDFR.DisplayMember = "MASPR_ITMCD";
			cbITMCDFR.LoadData();
			cbITMCDTO.DataTable = "MASPR_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = MASPR_ITMCD ";
			cbITMCDTO.ValueMember = "MASPR_ITMCD";
			cbITMCDTO.DisplayMember = "MASPR_ITMCD";
			cbITMCDTO.LoadData();
		}

		private void BindComboBox()
		{
			cbITMCD.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbITMCD.ValueMember = "MAITM_ITMCD";
			cbITMCD.DisplayMember = "MAITM_ITMCD";
			cbITMCD.LoadData();
			cbCUSID.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSID.ValueMember = "MACUS_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			cbCUSID.LoadData();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			BindComboBox();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = false;
			btnCancel.Enabled = false;
			btnPRINT.Enabled = false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			spMAESPR("0");
		}

		private void frmMAESPR_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAESPR_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			BindComboBox();
			dtpEFFDTFR.Value = DateAndTime.Today.AddMonths(-1);
			Header();
			NumberFormat();
		}

		private bool spMAESPR(string strPRO)
		{
			bool spMAESPR = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAESPR ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDT.Value) + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numPRICE.Value) + "', ";
				strSQL = strSQL + "'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), Conversions.ToString(Interaction.IIf(Operators.CompareString(strPRO, "0", false) == 0, "Record saved!", "Record deleted!"))), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMAESPR = false;
					ProjectData.ClearProjectError();
					goto IL_01a6;
				}
				ClearDetails(false);
				spMAESPR = true;
			}
			goto IL_01a6;
			IL_01a6:
			return spMAESPR;
		}

		private void Header()
		{
			int count = dgvMASPR.Rows.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				dgvMASPR.Rows.Remove(dgvMASPR.Rows[0]);
			}
			string strSQL = "EXEC spMASPR '0', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDTO.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCDTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDTTO.Value) + "'";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvMASPR;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 100;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID");
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 120;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Name");
			dataGridView.Columns[2].Visible = true;
			dataGridView.Columns[2].Width = 150;
			dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			dataGridView.Columns[3].Visible = true;
			dataGridView.Columns[3].Width = 100;
			dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective Date");
			dataGridView.Columns[4].Visible = true;
			dataGridView.Columns[4].Width = 130;
			dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Price");
			dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[4].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
			dataGridView.Columns[5].Visible = false;
			dataGridView.Columns[5].Width = 100;
			dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[5].HeaderText = "MASPR_EFFDT";
			dataGridView.Columns[6].Visible = true;
			dataGridView.Columns[6].Width = 250;
			dataGridView.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[6].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
			Panel2.Visible = true;
			Panel1.Visible = false;
		}

		private void ClearDetails(bool all)
		{
			if (all)
			{
				cbCUSID.SelectedIndex = -1;
			}
			dtpEFFDT.Value = DateTime.Now;
			dtpEFFDT.Enabled = true;
			cbITMCD.SelectedIndex = -1;
			numPRICE.Value = 0.0;
			txtREMRK.Text = string.Empty;
			btnSave.Tag = "Save";
			btnDelete.Enabled = false;
			btnCancel.Enabled = false;
			btnPRINT.Enabled = false;
			cbITMCD.Enabled = true;
			cbCUSID.Enabled = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails(true);
			BindComboHeader();
			Header();
		}

		private void BindGridtoControl()
		{
			cbCUSID.SelectedValue = dgvMASPR.CurrentRow.Cells["MASPR_CUSID"].Value.ToString();
			dtpEFFDT.Text = Conversions.ToString(Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dgvMASPR.CurrentRow.Cells["MASPR_EFFDT"].Value)));
			cbITMCD.SelectedValue = dgvMASPR.CurrentRow.Cells["MASPR_ITMCD"].Value.ToString();
			numPRICE.Value = Conversions.ToDouble(dgvMASPR.CurrentRow.Cells["MASPR_PRICE"].Value.ToString());
			txtREMRK.Text = dgvMASPR.CurrentRow.Cells["MASPR_REMRK"].Value.ToString();
			string strCUSID = Conversions.ToString(DB.GetColumnValue("MACUS_CUSNM", "MACUS_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CUSID = '", cbCUSID.SelectedValue), "'"))));
			string strITMCD = Conversions.ToString(DB.GetColumnValue("MAITM_DESC", "MAITM_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbITMCD.SelectedValue), "'"))));
			NewLateBinding.LateIndexSetComplex(cbCUSID.SelectedItem, new object[2] { 1, strCUSID }, null, false, true);
			NewLateBinding.LateIndexSetComplex(cbITMCD.SelectedItem, new object[2] { 1, strITMCD }, null, false, true);
		}

		private void EditRecord()
		{
			BindComboBox();
			BindGridtoControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnSave.Tag = "Update";
			btnDelete.Enabled = true;
			btnCancel.Enabled = true;
			btnPRINT.Enabled = true;
			cbCUSID.Enabled = false;
			dtpEFFDT.Enabled = false;
			cbITMCD.Enabled = false;
		}

		private void dgvMASPR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			EditRecord();
		}

		private void BindDataFromDB()
		{
			string strSQL = "MASPR_CUSID, MASPR_EFFDT, MASPR_ITMCD, MASPR_PRICE, ";
			strSQL += "MASPR_REMRK, MASPR_ENTDT, ";
			strSQL += "MASPR_ENTBY, MASPR_LUPDT, MASPR_LUPBY";
			DataTable dt = DB.GetTable(strSQL, "MASPR_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("MASPR_CUSID = '", cbCUSID.SelectedValue), "' AND MASPR_ITMCD = '"), cbITMCD.SelectedValue), "' AND MASPR_EFFDT = '"), Common.gfSQLDate(dtpEFFDT.Value)), "'")), "");
			if (dt.Rows.Count > 0)
			{
				cbCUSID.SelectedValue = dt.Rows[0]["MASPR_CUSID"].ToString();
				dtpEFFDT.Text = dt.Rows[0]["MASPR_EFFDT"].ToString();
				cbITMCD.SelectedValue = dt.Rows[0]["MASPR_ITMCD"].ToString();
				numPRICE.Value = Conversions.ToDouble(dt.Rows[0]["MASPR_PRICE"].ToString());
				txtREMRK.Text = dt.Rows[0]["MASPR_REMRK"].ToString();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			BindDataFromDB();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spMAESPR("1");
				ClearDetails(true);
				BindComboHeader();
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbCUSID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbCUSID.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbITMCD.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbITMCD.Focus();
				return false;
			}
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM MASPR_TBL WHERE MASPR_CUSID = '", cbCUSID.SelectedValue), "' AND MASPR_ITMCD = '"), cbITMCD.SelectedValue), "' AND MASPR_EFFDT = '"), Common.gfSQLDate(dtpEFFDT.Value)), "'"));
			if (Operators.CompareString(btnSave.Text, "Save", false) == 0 && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective date for customer and item code already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				dtpEFFDT.Focus();
				return false;
			}
			return true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "SALES PRICE MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMASPR.rpt";
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(cbCUSID.SelectedItem, new object[1] { 1 }, null), null, "Trim", new object[0], null, null, null), "", false))
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@Par=1 ,@CUSIDfr=", cbCUSID.SelectedValue), ",@CUSIDto="), cbCUSID.SelectedValue), ",@ITMCDfr="), cbITMCD.SelectedValue), ",@ITMCDto="), cbITMCD.SelectedValue), ",@EFFDTfr="), Common.gfSQLDate(dtpEFFDT.Value)), ",@EFFDTto="), Common.gfSQLDate(dtpEFFDT.Value)), ""));
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@Par=1 ,@CUSIDfr=", cbCUSIDFR.SelectedValue), ",@CUSIDto="), cbCUSIDTO.SelectedValue), ",@ITMCDfr="), cbITMCDFR.SelectedValue), ",@ITMCDto="), cbITMCDTO.SelectedValue), ",@EFFDTfr="), Common.gfSQLDate(dtpEFFDTFR.Value)), ",@EFFDTto="), Common.gfSQLDate(dtpEFFDTTO.Value)), ""));
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='SALES PRICE MASTER',gintQTYDS='" + PublicVar.gintQTYDS + "',gintAMTDS='" + PublicVar.gintAMTDS + "',gintPRCDS='" + PublicVar.gintPRCDS + "'";
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

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void NumberFormat()
		{
			numPRICE.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Price);
		}

		private void frmMAESPR_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbCUSIDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbCUSIDFR.SelectedIndex != -1)
			{
				cbCUSIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbCUSIDFR.SelectedValue);
			}
		}

		private void cbITMCDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbITMCDFR.SelectedIndex != -1)
			{
				cbITMCDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbITMCDFR.SelectedValue);
			}
		}
	}
}
