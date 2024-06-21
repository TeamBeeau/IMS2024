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
	public class frmMAECUR : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMACUR")]
		private DataGridView _dgvMACUR;

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
		[AccessedThroughProperty("chkCURFR")]
		private CheckBox _chkCURFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chkCURTO")]
		private CheckBox _chkCURTO;

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

		[field: AccessedThroughProperty("numXRATE")]
		internal virtual NumControl numXRATE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblXRATE")]
		internal virtual Label lblXRATE
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

		[field: AccessedThroughProperty("lblTOCUR")]
		internal virtual Label lblTOCUR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblFRCUR")]
		internal virtual Label lblFRCUR
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

		internal virtual DataGridView dgvMACUR
		{
			[CompilerGenerated]
			get
			{
				return _dgvMACUR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMACUR_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMACUR;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMACUR = value;
				dataGridView = _dgvMACUR;
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

		[field: AccessedThroughProperty("cbFRCUR")]
		internal virtual ComboBox cbFRCUR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbTOCUR")]
		internal virtual ComboBox cbTOCUR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual CheckBox chkCURFR
		{
			[CompilerGenerated]
			get
			{
				return _chkCURFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = chkCURFR_CheckedChanged;
				CheckBox checkBox = _chkCURFR;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_chkCURFR = value;
				checkBox = _chkCURFR;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		internal virtual CheckBox chkCURTO
		{
			[CompilerGenerated]
			get
			{
				return _chkCURTO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = chkCURTO_CheckedChanged;
				CheckBox checkBox = _chkCURTO;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= value2;
				}
				_chkCURTO = value;
				checkBox = _chkCURTO;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbCURFR")]
		internal virtual ComboBox cbCURFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCURTO")]
		internal virtual ComboBox cbCURTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAECUR()
		{
			base.FormClosing += frmMAECUR_FormClosing;
			base.Shown += frmMAECUR_Shown;
			base.KeyDown += frmMAECUR_KeyDown;
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
			this.cbTOCUR = new System.Windows.Forms.ComboBox();
			this.cbFRCUR = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.lblEFFDT = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.numXRATE = new IMS.NumControl();
			this.lblXRATE = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblFRCUR = new System.Windows.Forms.Label();
			this.dtpEFFDT = new System.Windows.Forms.DateTimePicker();
			this.lblTOCUR = new System.Windows.Forms.Label();
			this.btnPRINTR = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbCURTO = new System.Windows.Forms.ComboBox();
			this.cbCURFR = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.dtpEFFDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpEFFDTFR = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblITMCDFR = new System.Windows.Forms.Label();
			this.lblITMCDTO = new System.Windows.Forms.Label();
			this.chkCURFR = new System.Windows.Forms.CheckBox();
			this.chkCURTO = new System.Windows.Forms.CheckBox();
			this.dgvMACUR = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMACUR).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbTOCUR, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbFRCUR, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.lblEFFDT, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.numXRATE, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblXRATE, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblFRCUR, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpEFFDT, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblTOCUR, 0, 1);
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(638, 288);
			this.TableLayoutPanel1.TabIndex = 1;
			this.cbTOCUR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTOCUR.FormattingEnabled = true;
			this.cbTOCUR.Location = new System.Drawing.Point(109, 33);
			this.cbTOCUR.Name = "cbTOCUR";
			this.cbTOCUR.Size = new System.Drawing.Size(200, 24);
			this.cbTOCUR.TabIndex = 8;
			this.cbFRCUR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFRCUR.FormattingEnabled = true;
			this.cbFRCUR.Location = new System.Drawing.Point(109, 3);
			this.cbFRCUR.Name = "cbFRCUR";
			this.cbFRCUR.Size = new System.Drawing.Size(200, 24);
			this.cbFRCUR.TabIndex = 7;
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
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 232);
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
			this.btnDelete.Image = IMS.My.Resources.Resources.Back;
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
			this.lblEFFDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEFFDT.AutoSize = true;
			this.lblEFFDT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEFFDT.Location = new System.Drawing.Point(3, 65);
			this.lblEFFDT.Name = "lblEFFDT";
			this.lblEFFDT.Size = new System.Drawing.Size(91, 16);
			this.lblEFFDT.TabIndex = 1;
			this.lblEFFDT.Text = "Effective Date";
			this.txtREMRK.Location = new System.Drawing.Point(109, 134);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(526, 74);
			this.txtREMRK.TabIndex = 5;
			this.numXRATE.AllowNegative = false;
			this.numXRATE.DataChanged = false;
			this.numXRATE.Location = new System.Drawing.Point(109, 98);
			this.numXRATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numXRATE.Name = "numXRATE";
			this.numXRATE.NumberFormat = "8.2";
			this.numXRATE.Size = new System.Drawing.Size(108, 22);
			this.numXRATE.TabIndex = 4;
			this.numXRATE.Text = "0.00";
			this.numXRATE.ThousandSeperator = false;
			this.numXRATE.Value = 0.0;
			this.lblXRATE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblXRATE.AutoSize = true;
			this.lblXRATE.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblXRATE.Location = new System.Drawing.Point(3, 101);
			this.lblXRATE.Name = "lblXRATE";
			this.lblXRATE.Size = new System.Drawing.Size(100, 16);
			this.lblXRATE.TabIndex = 8;
			this.lblXRATE.Text = "Exchange Rate";
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 163);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(56, 16);
			this.lblREMRK.TabIndex = 6;
			this.lblREMRK.Text = "Remark";
			this.lblFRCUR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFRCUR.AutoSize = true;
			this.lblFRCUR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFRCUR.Location = new System.Drawing.Point(3, 7);
			this.lblFRCUR.Name = "lblFRCUR";
			this.lblFRCUR.Size = new System.Drawing.Size(95, 16);
			this.lblFRCUR.TabIndex = 0;
			this.lblFRCUR.Text = "From Currency";
			this.dtpEFFDT.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDT.Location = new System.Drawing.Point(109, 62);
			this.dtpEFFDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDT.Name = "dtpEFFDT";
			this.dtpEFFDT.Size = new System.Drawing.Size(108, 22);
			this.dtpEFFDT.TabIndex = 3;
			this.lblTOCUR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTOCUR.AutoSize = true;
			this.lblTOCUR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTOCUR.Location = new System.Drawing.Point(3, 37);
			this.lblTOCUR.Name = "lblTOCUR";
			this.lblTOCUR.Size = new System.Drawing.Size(81, 16);
			this.lblTOCUR.TabIndex = 2;
			this.lblTOCUR.Text = "To Currency";
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
			this.TableLayoutPanel2.Controls.Add(this.cbCURTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbCURFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpEFFDTTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpEFFDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblITMCDFR, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblITMCDTO, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.chkCURFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.chkCURTO, 2, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(540, 82);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbCURTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCURTO.FormattingEnabled = true;
			this.cbCURTO.Location = new System.Drawing.Point(337, 29);
			this.cbCURTO.Name = "cbCURTO";
			this.cbCURTO.Size = new System.Drawing.Size(200, 24);
			this.cbCURTO.TabIndex = 18;
			this.cbCURFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCURFR.FormattingEnabled = true;
			this.cbCURFR.Location = new System.Drawing.Point(100, 29);
			this.cbCURFR.Name = "cbCURFR";
			this.cbCURFR.Size = new System.Drawing.Size(200, 24);
			this.cbCURFR.TabIndex = 16;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(306, 61);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(25, 16);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "To";
			this.dtpEFFDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDTTO.Location = new System.Drawing.Point(337, 58);
			this.dtpEFFDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDTTO.Name = "dtpEFFDTTO";
			this.dtpEFFDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpEFFDTTO.TabIndex = 6;
			this.dtpEFFDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpEFFDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEFFDTFR.Location = new System.Drawing.Point(100, 58);
			this.dtpEFFDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpEFFDTFR.Name = "dtpEFFDTFR";
			this.dtpEFFDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpEFFDTFR.TabIndex = 5;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 61);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(91, 16);
			this.Label1.TabIndex = 14;
			this.Label1.Text = "Effective Date";
			this.lblITMCDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCDFR.AutoSize = true;
			this.lblITMCDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCDFR.Location = new System.Drawing.Point(3, 33);
			this.lblITMCDFR.Name = "lblITMCDFR";
			this.lblITMCDFR.Size = new System.Drawing.Size(64, 16);
			this.lblITMCDFR.TabIndex = 2;
			this.lblITMCDFR.Text = " Currency";
			this.lblITMCDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCDTO.AutoSize = true;
			this.lblITMCDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCDTO.Location = new System.Drawing.Point(306, 33);
			this.lblITMCDTO.Name = "lblITMCDTO";
			this.lblITMCDTO.Size = new System.Drawing.Size(25, 16);
			this.lblITMCDTO.TabIndex = 5;
			this.lblITMCDTO.Text = "To";
			this.chkCURFR.AutoSize = true;
			this.chkCURFR.Checked = true;
			this.chkCURFR.CheckState = System.Windows.Forms.CheckState.Checked;
			this.TableLayoutPanel2.SetColumnSpan(this.chkCURFR, 2);
			this.chkCURFR.Location = new System.Drawing.Point(3, 3);
			this.chkCURFR.Name = "chkCURFR";
			this.chkCURFR.Size = new System.Drawing.Size(114, 20);
			this.chkCURFR.TabIndex = 15;
			this.chkCURFR.Text = "From Currency";
			this.chkCURFR.UseVisualStyleBackColor = true;
			this.chkCURTO.AutoSize = true;
			this.TableLayoutPanel2.SetColumnSpan(this.chkCURTO, 2);
			this.chkCURTO.Location = new System.Drawing.Point(306, 3);
			this.chkCURTO.Name = "chkCURTO";
			this.chkCURTO.Size = new System.Drawing.Size(100, 20);
			this.chkCURTO.TabIndex = 16;
			this.chkCURTO.Text = "To Currency";
			this.chkCURTO.UseVisualStyleBackColor = true;
			this.dgvMACUR.AllowUserToAddRows = false;
			this.dgvMACUR.AllowUserToDeleteRows = false;
			this.dgvMACUR.AllowUserToResizeRows = false;
			this.dgvMACUR.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMACUR.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMACUR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMACUR.Location = new System.Drawing.Point(5, 160);
			this.dgvMACUR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMACUR.MultiSelect = false;
			this.dgvMACUR.Name = "dgvMACUR";
			this.dgvMACUR.ReadOnly = true;
			this.dgvMACUR.RowHeadersVisible = false;
			this.dgvMACUR.RowTemplate.Height = 24;
			this.dgvMACUR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMACUR.Size = new System.Drawing.Size(1356, 447);
			this.dgvMACUR.TabIndex = 0;
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
			this.Panel2.Controls.Add(this.dgvMACUR);
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
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 101);
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
			base.Name = "frmMAECUR";
			base.Tag = "MAECUR";
			this.Text = "Currency Exchange Master";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMACUR).EndInit();
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
			btnDelete.Enabled = false;
			btnCancel.Enabled = false;
			btnPRINT.Enabled = false;
			BindComboBox();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			spMAECUR("0");
		}

		private void frmMAECUR_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAECUR_Shown(object sender, EventArgs e)
		{
			dtpEFFDTFR.Value = DateAndTime.Today.AddMonths(-1);
			BindComboHeader();
			Header();
			NumberFormat();
		}

		private bool spMAECUR(string strPRO)
		{
			bool spMAECUR = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAECUR ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbFRCUR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbTOCUR.SelectedValue), "', ")));
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDT.Value) + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numXRATE.Value) + "', ";
				strSQL = strSQL + "'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record saved!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMAECUR = false;
					ProjectData.ClearProjectError();
					goto IL_0183;
				}
				ClearDetails(false);
				spMAECUR = true;
			}
			goto IL_0183;
			IL_0183:
			return spMAECUR;
		}

		private void BindDataFromDB()
		{
			string strSQL = "MACUR_FRCUR, MACUR_TOCUR, MACUR_EFFDT, MACUR_XRATE, ";
			strSQL += "MACUR_REMRK, MACUR_LUPDT, MACUR_LUPBY ";
			DataTable dt = DB.GetTable(strSQL, "MACUR_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("MACUR_FRCUR = '", cbFRCUR.SelectedValue), "' AND MACUR_TOCUR = '"), cbTOCUR.SelectedValue), "' AND MACUR_EFFDT = '"), Common.gfSQLDate(dtpEFFDT.Value)), "'")), "");
			if (dt.Rows.Count > 0)
			{
				cbFRCUR.SelectedValue = dt.Rows[0]["MACUR_FRCUR"].ToString();
				cbTOCUR.SelectedValue = dt.Rows[0]["MACUR_TOCUR"].ToString();
				dtpEFFDT.Text = dt.Rows[0]["MACUR_EFFDT"].ToString();
				numXRATE.Value = Conversions.ToDouble(dt.Rows[0]["MACUR_XRATE"].ToString());
				txtREMRK.Text = dt.Rows[0]["MACUR_REMRK"].ToString();
			}
		}

		private void Header()
		{
			int opt = 0;
			int count = dgvMACUR.Rows.Count;
			for (int i = 1; i <= count; i = checked(i + 1))
			{
				dgvMACUR.Rows.Remove(dgvMACUR.Rows[0]);
			}
			if (chkCURFR.Checked)
			{
				opt = 0;
			}
			if (chkCURTO.Checked)
			{
				opt = 1;
			}
			string strSQL = "EXEC spMACUR '0', ";
			strSQL = strSQL + " " + Conversions.ToString(opt) + " , ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCURFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCURTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpEFFDTTO.Value) + "'";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvMACUR;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 110;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "From Currency");
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 110;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "To Currency");
			dataGridView.Columns[2].Visible = false;
			dataGridView.Columns[2].Width = 100;
			dataGridView.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[2].HeaderText = "MACUR_EFFDT";
			dataGridView.Columns[3].Visible = true;
			dataGridView.Columns[3].Width = 100;
			dataGridView.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[3].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Effective Date");
			dataGridView.Columns[4].Visible = true;
			dataGridView.Columns[4].Width = 120;
			dataGridView.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[4].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Exchange Rate");
			dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[4].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.XRate);
			dataGridView.Columns[5].Visible = true;
			dataGridView.Columns[5].Width = 300;
			dataGridView.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[5].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
			dataGridView.Columns[6].Visible = false;
			dataGridView.Columns[7].Visible = false;
			dataGridView.AutoResizeRows();
			dataGridView.Refresh();
			dataGridView = null;
			Panel2.Visible = true;
			Panel1.Visible = false;
		}

		private void BindGridToControl()
		{
			cbFRCUR.SelectedValue = dgvMACUR.CurrentRow.Cells["MACUR_FRCUR"].Value.ToString();
			cbTOCUR.SelectedValue = dgvMACUR.CurrentRow.Cells["MACUR_TOCUR"].Value.ToString();
			dtpEFFDT.Value = Conversions.ToDate(dgvMACUR.CurrentRow.Cells["MACUR_EFFDT"].Value);
			numXRATE.Value = Conversions.ToDouble(dgvMACUR.CurrentRow.Cells["MACUR_XRATE"].Value.ToString());
			txtREMRK.Text = dgvMACUR.CurrentRow.Cells["MACUR_REMRK"].Value.ToString();
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
			cbFRCUR.Enabled = false;
			dtpEFFDT.Enabled = false;
			cbTOCUR.Enabled = false;
		}

		private void dgvMACUR_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			EditRecord();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails(true);
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
				cbFRCUR.SelectedIndex = -1;
			}
			cbTOCUR.SelectedIndex = -1;
			dtpEFFDT.Value = DateAndTime.Now.Date;
			numXRATE.Value = 0.0;
			txtREMRK.Text = string.Empty;
			btnSave.Tag = "Save";
			btnDelete.Enabled = false;
			btnCancel.Enabled = false;
			btnPRINT.Enabled = false;
			cbFRCUR.Enabled = true;
			dtpEFFDT.Enabled = true;
			cbTOCUR.Enabled = true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spMAECUR("1");
				ClearDetails(true);
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbFRCUR.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "From Currency cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbFRCUR.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbTOCUR.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "To Currency cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbTOCUR.Focus();
				return false;
			}
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM MACUR_TBL WHERE MACUR_FRCUR = '", cbFRCUR.SelectedValue), "' AND MACUR_TOCUR = '"), cbTOCUR.SelectedValue), "' AND MACUR_EFFDT = '"), Common.gfSQLDate(dtpEFFDT.Value)), "'"));
			if (Operators.ConditionalCompareObjectEqual(btnSave.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Exchange rate of this effective date already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				dtpEFFDT.Focus();
				return false;
			}
			return true;
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			int opt = 0;
			if (chkCURFR.Checked)
			{
				opt = 0;
			}
			if (chkCURTO.Checked)
			{
				opt = 1;
			}
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "CURRENCY EXCHANGE MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMACUR.rpt";
			if (Operators.ConditionalCompareObjectNotEqual(cbFRCUR.SelectedValue, "", false))
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@Par=1 ,@OPT=" + Conversions.ToString(opt) + ",@CURFR=", cbTOCUR.SelectedValue), ",@CURTO="), cbTOCUR.SelectedValue), ",@EFFDTFR="), Common.gfSQLDate(dtpEFFDT.Value)), ",@EFFDTTO="), Common.gfSQLDate(dtpEFFDT.Value)), ""));
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@Par=1 ,@OPT=" + Conversions.ToString(opt) + ",@CURFR=", cbCURFR.SelectedValue), ",@CURTO="), cbCURTO.SelectedValue), ",@EFFDTFR="), Common.gfSQLDate(dtpEFFDTFR.Value)), ",@EFFDTTO="), Common.gfSQLDate(dtpEFFDTTO.Value)), ""));
			}
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='CURRENCY EXCHANGE MASTER',QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS + ",XRTDS=" + PublicVar.gintXRTDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CURCD' ";
			strSQL += " ORDER BY MACOD_CODID ";
			cbFRCUR.ValueMember = "MACOD_CODID";
			cbFRCUR.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbFRCUR);
			cbTOCUR.ValueMember = "MACOD_CODID";
			cbTOCUR.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbTOCUR);
		}

		private void BindComboHeader()
		{
			string strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CURCD' ";
			strSQL += " ORDER BY MACOD_CODID ";
			cbCURFR.ValueMember = "MACOD_CODID";
			cbCURFR.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCURFR);
			cbCURTO.ValueMember = "MACOD_CODID";
			cbCURTO.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCURTO);
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
			numXRATE.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.XRate);
		}

		private void frmMAECUR_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void chkCURFR_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCURFR.Checked)
			{
				chkCURTO.Checked = false;
			}
		}

		private void chkCURTO_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCURTO.Checked)
			{
				chkCURFR.Checked = false;
			}
		}
	}
}
