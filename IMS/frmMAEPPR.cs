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
	public class frmMAEPPR : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMAPPR")]
		private DataGridView _dgvMAPPR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

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
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTR")]
		private Button _btnPRINTR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCDFR")]
		private ComboboxControl _cbITMCDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbSUPIDFR")]
		private ComboboxControl _cbSUPIDFR;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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

		[field: AccessedThroughProperty("lblITMCD")]
		internal virtual Label lblITMCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSUPID")]
		internal virtual Label lblSUPID
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

		internal virtual DataGridView dgvMAPPR
		{
			[CompilerGenerated]
			get
			{
				return _dgvMAPPR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMAPPR_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMAPPR;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMAPPR = value;
				dataGridView = _dgvMAPPR;
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

		[field: AccessedThroughProperty("lblITMCDTO")]
		internal virtual Label lblITMCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSUPIDTO")]
		internal virtual Label lblSUPIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSUPIDFR")]
		internal virtual Label lblSUPIDFR
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

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
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

		[field: AccessedThroughProperty("dtpEFFDTFR")]
		internal virtual DateTimePicker dtpEFFDTFR
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

		[field: AccessedThroughProperty("dtpEFFDTTO")]
		internal virtual DateTimePicker dtpEFFDTTO
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

		internal virtual ComboboxControl cbSUPIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbSUPIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbSUPIDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbSUPIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbSUPIDFR = value;
				comboboxControl = _cbSUPIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbSUPIDTO")]
		internal virtual ComboboxControl cbSUPIDTO
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

		[field: AccessedThroughProperty("cbSUPID")]
		internal virtual ComboboxControl cbSUPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAEPPR()
		{
			base.FormClosing += frmMAEPPR_FormClosing;
			base.Shown += frmMAEPPR_Shown;
			base.KeyDown += frmMAEPPR_KeyDown;
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
			this.cbITMCD = new IMS.ComboboxControl();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbSUPID = new IMS.ComboboxControl();
			this.lblEFFDT = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.numPRICE = new IMS.NumControl();
			this.lblPRICE = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblSUPID = new System.Windows.Forms.Label();
			this.dtpEFFDT = new System.Windows.Forms.DateTimePicker();
			this.lblITMCD = new System.Windows.Forms.Label();
			this.btnPRINTR = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbSUPIDTO = new IMS.ComboboxControl();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.dtpEFFDTTO = new System.Windows.Forms.DateTimePicker();
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.dtpEFFDTFR = new System.Windows.Forms.DateTimePicker();
			this.cbSUPIDFR = new IMS.ComboboxControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblITMCDFR = new System.Windows.Forms.Label();
			this.lblSUPIDTO = new System.Windows.Forms.Label();
			this.lblSUPIDFR = new System.Windows.Forms.Label();
			this.lblITMCDTO = new System.Windows.Forms.Label();
			this.dgvMAPPR = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMAPPR).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbITMCD, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.cbSUPID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblEFFDT, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.numPRICE, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblPRICE, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblSUPID, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpEFFDT, 1, 2);
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(636, 298);
			this.TableLayoutPanel1.TabIndex = 1;
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
			this.cbITMCD.TabIndex = 13;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
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
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 242);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel3.TabIndex = 7;
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
			this.cbSUPID.BlankValue = null;
			this.cbSUPID.ComboboxWidth = 170;
			this.cbSUPID.DataTable = null;
			this.cbSUPID.DisplayMember = null;
			this.cbSUPID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPID.HasBlankValue = true;
			this.cbSUPID.Location = new System.Drawing.Point(100, 3);
			this.cbSUPID.Name = "cbSUPID";
			this.cbSUPID.SelectedIndex = -1;
			this.cbSUPID.SelectedItem = null;
			this.cbSUPID.SelectedValue = null;
			this.cbSUPID.Size = new System.Drawing.Size(324, 26);
			this.cbSUPID.TabIndex = 12;
			this.cbSUPID.TextMultiline = true;
			this.cbSUPID.ValueMember = null;
			this.cbSUPID.WhereClause = null;
			this.lblEFFDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEFFDT.AutoSize = true;
			this.lblEFFDT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEFFDT.Location = new System.Drawing.Point(3, 70);
			this.lblEFFDT.Name = "lblEFFDT";
			this.lblEFFDT.Size = new System.Drawing.Size(91, 16);
			this.lblEFFDT.TabIndex = 1;
			this.lblEFFDT.Text = "Effective Date";
			this.txtREMRK.Location = new System.Drawing.Point(100, 143);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(460, 74);
			this.txtREMRK.TabIndex = 5;
			this.numPRICE.AllowNegative = false;
			this.numPRICE.DataChanged = false;
			this.numPRICE.Location = new System.Drawing.Point(100, 105);
			this.numPRICE.Name = "numPRICE";
			this.numPRICE.NumberFormat = "8.2";
			this.numPRICE.Size = new System.Drawing.Size(108, 22);
			this.numPRICE.TabIndex = 4;
			this.numPRICE.Text = "0.00";
			this.numPRICE.ThousandSeperator = false;
			this.numPRICE.Value = 0.0;
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
			this.lblREMRK.Location = new System.Drawing.Point(3, 172);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(56, 16);
			this.lblREMRK.TabIndex = 6;
			this.lblREMRK.Text = "Remark";
			this.lblSUPID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSUPID.AutoSize = true;
			this.lblSUPID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSUPID.Location = new System.Drawing.Point(3, 8);
			this.lblSUPID.Name = "lblSUPID";
			this.lblSUPID.Size = new System.Drawing.Size(74, 16);
			this.lblSUPID.TabIndex = 0;
			this.lblSUPID.Text = "Supplier ID";
			this.dtpEFFDT.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDT.Location = new System.Drawing.Point(100, 67);
			this.dtpEFFDT.Name = "dtpEFFDT";
			this.dtpEFFDT.Size = new System.Drawing.Size(108, 22);
			this.dtpEFFDT.TabIndex = 3;
			this.lblITMCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCD.AutoSize = true;
			this.lblITMCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCD.Location = new System.Drawing.Point(3, 40);
			this.lblITMCD.Name = "lblITMCD";
			this.lblITMCD.Size = new System.Drawing.Size(69, 16);
			this.lblITMCD.TabIndex = 2;
			this.lblITMCD.Text = "Item Code";
			this.btnPRINTR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTR.Location = new System.Drawing.Point(255, 2);
			this.btnPRINTR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTR.Name = "btnPRINTR";
			this.btnPRINTR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTR.TabIndex = 9;
			this.btnPRINTR.Text = "Print";
			this.btnPRINTR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTR.UseVisualStyleBackColor = false;
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
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbSUPIDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbITMCDTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpEFFDTTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbITMCDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.dtpEFFDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbSUPIDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblITMCDFR, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblSUPIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblSUPIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblITMCDTO, 2, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(814, 86);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbSUPIDTO.BlankValue = null;
			this.cbSUPIDTO.ComboboxWidth = 170;
			this.cbSUPIDTO.DataTable = null;
			this.cbSUPIDTO.DisplayMember = null;
			this.cbSUPIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDTO.HasBlankValue = true;
			this.cbSUPIDTO.Location = new System.Drawing.Point(478, 2);
			this.cbSUPIDTO.Margin = new System.Windows.Forms.Padding(12, 2, 12, 2);
			this.cbSUPIDTO.Name = "cbSUPIDTO";
			this.cbSUPIDTO.SelectedIndex = -1;
			this.cbSUPIDTO.SelectedItem = null;
			this.cbSUPIDTO.SelectedValue = null;
			this.cbSUPIDTO.Size = new System.Drawing.Size(324, 26);
			this.cbSUPIDTO.TabIndex = 19;
			this.cbSUPIDTO.TextMultiline = true;
			this.cbSUPIDTO.ValueMember = null;
			this.cbSUPIDTO.WhereClause = null;
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(475, 32);
			this.cbITMCDTO.Margin = new System.Windows.Forms.Padding(9, 2, 9, 2);
			this.cbITMCDTO.Name = "cbITMCDTO";
			this.cbITMCDTO.SelectedIndex = -1;
			this.cbITMCDTO.SelectedItem = null;
			this.cbITMCDTO.SelectedValue = null;
			this.cbITMCDTO.Size = new System.Drawing.Size(324, 26);
			this.cbITMCDTO.TabIndex = 18;
			this.cbITMCDTO.TextMultiline = true;
			this.cbITMCDTO.ValueMember = null;
			this.cbITMCDTO.WhereClause = null;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(438, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(25, 16);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "To";
			this.dtpEFFDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDTTO.Location = new System.Drawing.Point(469, 62);
			this.dtpEFFDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDTTO.Name = "dtpEFFDTTO";
			this.dtpEFFDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpEFFDTTO.TabIndex = 6;
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(104, 32);
			this.cbITMCDFR.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
			this.cbITMCDFR.Name = "cbITMCDFR";
			this.cbITMCDFR.SelectedIndex = -1;
			this.cbITMCDFR.SelectedItem = null;
			this.cbITMCDFR.SelectedValue = null;
			this.cbITMCDFR.Size = new System.Drawing.Size(324, 26);
			this.cbITMCDFR.TabIndex = 17;
			this.cbITMCDFR.TextMultiline = true;
			this.cbITMCDFR.ValueMember = null;
			this.cbITMCDFR.WhereClause = null;
			this.dtpEFFDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDTFR.Location = new System.Drawing.Point(100, 62);
			this.dtpEFFDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDTFR.Name = "dtpEFFDTFR";
			this.dtpEFFDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpEFFDTFR.TabIndex = 5;
			this.cbSUPIDFR.BlankValue = null;
			this.cbSUPIDFR.ComboboxWidth = 170;
			this.cbSUPIDFR.DataTable = null;
			this.cbSUPIDFR.DisplayMember = null;
			this.cbSUPIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDFR.HasBlankValue = true;
			this.cbSUPIDFR.Location = new System.Drawing.Point(102, 2);
			this.cbSUPIDFR.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbSUPIDFR.Name = "cbSUPIDFR";
			this.cbSUPIDFR.SelectedIndex = -1;
			this.cbSUPIDFR.SelectedItem = null;
			this.cbSUPIDFR.SelectedValue = null;
			this.cbSUPIDFR.Size = new System.Drawing.Size(324, 26);
			this.cbSUPIDFR.TabIndex = 15;
			this.cbSUPIDFR.TextMultiline = true;
			this.cbSUPIDFR.ValueMember = null;
			this.cbSUPIDFR.WhereClause = null;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 16);
			this.Label1.TabIndex = 14;
			this.Label1.Text = "Effective Date";
			this.lblITMCDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCDFR.AutoSize = true;
			this.lblITMCDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCDFR.Location = new System.Drawing.Point(3, 37);
			this.lblITMCDFR.Name = "lblITMCDFR";
			this.lblITMCDFR.Size = new System.Drawing.Size(69, 16);
			this.lblITMCDFR.TabIndex = 2;
			this.lblITMCDFR.Text = "Item Code";
			this.lblSUPIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSUPIDTO.AutoSize = true;
			this.lblSUPIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSUPIDTO.Location = new System.Drawing.Point(438, 7);
			this.lblSUPIDTO.Name = "lblSUPIDTO";
			this.lblSUPIDTO.Size = new System.Drawing.Size(25, 16);
			this.lblSUPIDTO.TabIndex = 4;
			this.lblSUPIDTO.Text = "To";
			this.lblSUPIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSUPIDFR.AutoSize = true;
			this.lblSUPIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSUPIDFR.Location = new System.Drawing.Point(3, 7);
			this.lblSUPIDFR.Name = "lblSUPIDFR";
			this.lblSUPIDFR.Size = new System.Drawing.Size(74, 16);
			this.lblSUPIDFR.TabIndex = 3;
			this.lblSUPIDFR.Text = "Supplier ID";
			this.lblITMCDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCDTO.AutoSize = true;
			this.lblITMCDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCDTO.Location = new System.Drawing.Point(438, 37);
			this.lblITMCDTO.Name = "lblITMCDTO";
			this.lblITMCDTO.Size = new System.Drawing.Size(25, 16);
			this.lblITMCDTO.TabIndex = 5;
			this.lblITMCDTO.Text = "To";
			this.dgvMAPPR.AllowUserToAddRows = false;
			this.dgvMAPPR.AllowUserToDeleteRows = false;
			this.dgvMAPPR.AllowUserToResizeRows = false;
			this.dgvMAPPR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMAPPR.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMAPPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMAPPR.Location = new System.Drawing.Point(5, 176);
			this.dgvMAPPR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMAPPR.MultiSelect = false;
			this.dgvMAPPR.Name = "dgvMAPPR";
			this.dgvMAPPR.ReadOnly = true;
			this.dgvMAPPR.RowHeadersVisible = false;
			this.dgvMAPPR.RowTemplate.Height = 24;
			this.dgvMAPPR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMAPPR.Size = new System.Drawing.Size(1356, 437);
			this.dgvMAPPR.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1369, 630);
			this.Panel1.TabIndex = 8;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvMAPPR);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1369, 630);
			this.Panel2.TabIndex = 14;
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
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTR, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 114);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel4.TabIndex = 14;
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
			base.Name = "frmMAEPPR";
			base.Tag = "MAEPPR";
			this.Text = "Purchase Price Master";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMAPPR).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void BindComboHeader()
		{
			cbSUPIDFR.DataTable = "MAPPR_TBL WITH (NOLOCK) LEFT JOIN MASUP_TBL WITH (NOLOCK) ON MASUP_SUPID = MAPPR_SUPID ";
			cbSUPIDFR.ValueMember = "MAPPR_SUPID";
			cbSUPIDFR.DisplayMember = "MASUP_SHORT";
			cbSUPIDFR.LoadData();
			cbSUPIDTO.DataTable = "MAPPR_TBL WITH (NOLOCK) LEFT JOIN MASUP_TBL WITH (NOLOCK) ON MASUP_SUPID = MAPPR_SUPID ";
			cbSUPIDTO.ValueMember = "MAPPR_SUPID";
			cbSUPIDTO.DisplayMember = "MASUP_SHORT";
			cbSUPIDTO.LoadData();
			cbITMCDFR.DataTable = "MAPPR_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = MAPPR_ITMCD ";
			cbITMCDFR.ValueMember = "MAPPR_ITMCD";
			cbITMCDFR.DisplayMember = "MAPPR_ITMCD";
			cbITMCDFR.LoadData();
			cbITMCDTO.DataTable = "MAPPR_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = MAPPR_ITMCD ";
			cbITMCDTO.ValueMember = "MAPPR_ITMCD";
			cbITMCDTO.DisplayMember = "MAPPR_ITMCD";
			cbITMCDTO.LoadData();
		}

		private void BindComboBox()
		{
			cbITMCD.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbITMCD.ValueMember = "MAITM_ITMCD";
			cbITMCD.DisplayMember = "MAITM_ITMCD";
			cbITMCD.LoadData();
			cbSUPID.DataTable = "MASUP_TBL WITH (NOLOCK) ";
			cbSUPID.ValueMember = "MASUP_SUPID";
			cbSUPID.DisplayMember = "MASUP_SHORT";
			cbSUPID.LoadData();
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
			spMAEPPR("0");
		}

		private void frmMAEPPR_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAEPPR_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			BindComboBox();
			dtpEFFDTFR.Value = DateAndTime.Today.AddMonths(-1);
			Header();
			NumberFormat();
		}

		private bool spMAEPPR(string strPRO)
		{
			bool spMAEPPR = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAEPPR ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPID.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDT.Value) + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numPRICE.Value) + "', ";
				strSQL = strSQL + "'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), Conversions.ToString(Interaction.IIf(Operators.CompareString(strPRO, "0", false) == 0, "Record saved!", "Record deleted!"))), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMAEPPR = false;
					ProjectData.ClearProjectError();
					goto IL_01a1;
				}
				ClearDetails(false);
				spMAEPPR = true;
			}
			goto IL_01a1;
			IL_01a1:
			return spMAEPPR;
		}

		private void BindDataFromDB()
		{
			string strSQL = "MAPPR_SUPID, MAPPR_EFFDT, MAPPR_ITMCD, MAPPR_PRICE, ";
			strSQL += "MAPPR_REMRK, MAPPR_ENTDT, ";
			strSQL += "MAPPR_ENTBY, MAPPR_LUPDT, MAPPR_LUPBY ";
			DataTable dt = DB.GetTable(strSQL, "MAPPR_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("MAPPR_SUPID = '", cbSUPID.SelectedValue), "' AND MAPPR_ITMCD = '"), cbITMCD.SelectedValue), "' AND MAPPR_EFFDT = '"), Common.gfSQLDate(dtpEFFDT.Value.Date)), "'")), "");
			if (dt.Rows.Count > 0)
			{
				cbSUPID.SelectedValue = dt.Rows[0]["MAPPR_SUPID"].ToString();
				dtpEFFDT.Text = dt.Rows[0]["MAPPR_EFFDT"].ToString();
				cbITMCD.SelectedValue = dt.Rows[0]["MAPPR_ITMCD"].ToString();
				numPRICE.Value = Conversions.ToDouble(dt.Rows[0]["MAPPR_PRICE"].ToString());
				txtREMRK.Text = dt.Rows[0]["MAPPR_REMRK"].ToString();
			}
		}

		private void Header()
		{
			int count = dgvMAPPR.Rows.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				dgvMAPPR.Rows.Remove(dgvMAPPR.Rows[0]);
			}
			string strSQL = "EXEC spMAPPR '0', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDTO.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCDTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDTTO.Value) + "'";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvMAPPR;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 100;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID");
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 250;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Name");
			dataGridView.Columns[2].Visible = true;
			dataGridView.Columns[2].Width = 150;
			dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			dataGridView.Columns[3].Visible = true;
			dataGridView.Columns[3].Width = 100;
			dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective Date");
			dataGridView.Columns[4].Visible = false;
			dataGridView.Columns[4].Width = 100;
			dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[4].HeaderText = "MAPPR_EFFDT";
			dataGridView.Columns[5].Visible = true;
			dataGridView.Columns[5].Width = 130;
			dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Price");
			dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[5].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
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

		private void BindGridToControl()
		{
			cbSUPID.SelectedValue = dgvMAPPR.CurrentRow.Cells["MAPPR_SUPID"].Value.ToString();
			dtpEFFDT.Value = Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dgvMAPPR.CurrentRow.Cells["MAPPR_EFFDT"].Value));
			cbITMCD.SelectedValue = dgvMAPPR.CurrentRow.Cells["MAPPR_ITMCD"].Value.ToString();
			numPRICE.Value = Conversions.ToDouble(dgvMAPPR.CurrentRow.Cells["MAPPR_PRICE"].Value.ToString());
			txtREMRK.Text = dgvMAPPR.CurrentRow.Cells["MAPPR_REMRK"].Value.ToString();
			string strSUPID = Conversions.ToString(DB.GetColumnValue("MASUP_SUPNM", "MASUP_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASUP_SUPID = '", cbSUPID.SelectedValue), "'"))));
			string strITMCD = Conversions.ToString(DB.GetColumnValue("MAITM_DESC", "MAITM_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbITMCD.SelectedValue), "'"))));
			NewLateBinding.LateIndexSetComplex(cbSUPID.SelectedItem, new object[2] { 1, strSUPID }, null, false, true);
			NewLateBinding.LateIndexSetComplex(cbITMCD.SelectedItem, new object[2] { 1, strITMCD }, null, false, true);
		}

		private void EditRecord()
		{
			BindComboBox();
			BindGridToControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnSave.Tag = "Update";
			btnDelete.Enabled = true;
			btnCancel.Enabled = true;
			btnPRINT.Enabled = true;
			cbSUPID.Enabled = false;
			dtpEFFDT.Enabled = false;
			cbITMCD.Enabled = false;
		}

		private void dgvMAPPR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			EditRecord();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails(true);
			BindComboHeader();
			Header();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			BindDataFromDB();
		}

		private void ClearDetails(bool all)
		{
			if (all)
			{
				cbSUPID.SelectedIndex = -1;
				BindComboBox();
			}
			dtpEFFDT.Value = DateTime.Now;
			cbITMCD.SelectedIndex = -1;
			numPRICE.Value = 0.0;
			txtREMRK.Text = string.Empty;
			btnSave.Tag = "Save";
			btnDelete.Enabled = false;
			btnCancel.Enabled = false;
			btnPRINT.Enabled = false;
			cbSUPID.Enabled = true;
			dtpEFFDT.Enabled = true;
			cbITMCD.Enabled = true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spMAEPPR("1");
				ClearDetails(true);
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(cbSUPID.SelectedItem, new object[1] { 1 }, null), null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbSUPID.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateIndexGet(cbITMCD.SelectedItem, new object[1] { 1 }, null), null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbITMCD.Focus();
				return false;
			}
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM MAPPR_TBL WHERE MAPPR_SUPID = '", cbSUPID.SelectedValue), "' AND MAPPR_ITMCD = '"), cbITMCD.SelectedValue), "' AND MAPPR_EFFDT = '"), Common.gfSQLDate(dtpEFFDT.Value.Date)), "'"));
			if (Operators.ConditionalCompareObjectEqual(btnSave.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective date for supplier and item code already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				dtpEFFDT.Focus();
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
			frmRPT.ReportName = "PURCHASE PRICE MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMAPPR.rpt";
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(cbSUPID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@Par=1 ,@SUPIDfr=", cbSUPID.SelectedValue), ",@SUPIDto="), cbSUPID.SelectedValue), ",@ITMCDfr="), cbITMCD.SelectedValue), ",@ITMCDto="), cbITMCD.SelectedValue), ",@EFFDTfr="), Common.gfSQLDate(dtpEFFDT.Value)), ",@EFFDTto="), Common.gfSQLDate(dtpEFFDT.Value)), ""));
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@Par=1 ,@SUPIDfr=", cbSUPIDFR.SelectedValue), ",@SUPIDto="), cbSUPIDTO.SelectedValue), ",@ITMCDfr="), cbITMCDFR.SelectedValue), ",@ITMCDto="), cbITMCDTO.SelectedValue), ",@EFFDTfr="), Common.gfSQLDate(dtpEFFDTFR.Value)), ",@EFFDTto="), Common.gfSQLDate(dtpEFFDTTO.Value)), ""));
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='PURCHASE PRICE MASTER',gintQTYDS='" + PublicVar.gintQTYDS + "',gintAMTDS='" + PublicVar.gintAMTDS + "',gintPRCDS='" + PublicVar.gintPRCDS + "'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINTR_Click(object sender, EventArgs e)
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

		private void frmMAEPPR_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbSUPIDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbSUPIDFR.SelectedIndex != -1)
			{
				cbSUPIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbSUPIDFR.SelectedValue);
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
