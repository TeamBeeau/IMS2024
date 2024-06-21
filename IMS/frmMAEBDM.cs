using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmMAEBDM : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdClose")]
		private Button _cmdClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdDelete")]
		private Button _cmdDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdSave")]
		private Button _cmdSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMABDM")]
		private DataGridView _dgvMABDM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lkpBDGRP")]
		private LookupControl _lkpBDGRP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("lkpBDCOD")]
		private LookupControl _lkpBDCOD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRefresh")]
		private Button _btnRefresh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvCODTY")]
		private DataGridView _dgvCODTY;

		private string mCODTY;

		private string mReturnValue;

		[field: AccessedThroughProperty("cmdPrint")]
		internal virtual Button cmdPrint
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button cmdClose
		{
			[CompilerGenerated]
			get
			{
				return _cmdClose;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdClose_Click;
				Button button = _cmdClose;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdClose = value;
				button = _cmdClose;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdDelete
		{
			[CompilerGenerated]
			get
			{
				return _cmdDelete;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdDelete_Click;
				Button button = _cmdDelete;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdDelete = value;
				button = _cmdDelete;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdCancel
		{
			[CompilerGenerated]
			get
			{
				return _cmdCancel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdCancel_Click;
				Button button = _cmdCancel;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdCancel = value;
				button = _cmdCancel;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button cmdSave
		{
			[CompilerGenerated]
			get
			{
				return _cmdSave;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdSave_Click;
				Button button = _cmdSave;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdSave = value;
				button = _cmdSave;
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

		internal virtual DataGridView dgvMABDM
		{
			[CompilerGenerated]
			get
			{
				return _dgvMABDM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dgvMABDM_DoubleClick;
				DataGridView dataGridView = _dgvMABDM;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick -= value2;
				}
				_dgvMABDM = value;
				dataGridView = _dgvMABDM;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LookupControl lkpBDGRP
		{
			[CompilerGenerated]
			get
			{
				return _lkpBDGRP;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				LookupControl.BeforeLookupEventHandler obj = lkpBDGRP_BeforeLookup;
				LookupControl lookupControl = _lkpBDGRP;
				if (lookupControl != null)
				{
					lookupControl.BeforeLookup -= obj;
				}
				_lkpBDGRP = value;
				lookupControl = _lkpBDGRP;
				if (lookupControl != null)
				{
					lookupControl.BeforeLookup += obj;
				}
			}
		}

		[field: AccessedThroughProperty("lblBDGRP")]
		internal virtual Label lblBDGRP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual LookupControl lkpBDCOD
		{
			[CompilerGenerated]
			get
			{
				return _lkpBDCOD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				LookupControl.BeforeLookupEventHandler obj = lkpBDCOD_BeforeLookup;
				LookupControl lookupControl = _lkpBDCOD;
				if (lookupControl != null)
				{
					lookupControl.BeforeLookup -= obj;
				}
				_lkpBDCOD = value;
				lookupControl = _lkpBDCOD;
				if (lookupControl != null)
				{
					lookupControl.BeforeLookup += obj;
				}
			}
		}

		internal virtual Button btnRefresh
		{
			[CompilerGenerated]
			get
			{
				return _btnRefresh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRefresh_Click;
				Button button = _btnRefresh;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRefresh = value;
				button = _btnRefresh;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual DataGridView dgvCODTY
		{
			[CompilerGenerated]
			get
			{
				return _dgvCODTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dgvCODTY_DoubleClick;
				DataGridView dataGridView = _dgvCODTY;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick -= value2;
				}
				_dgvCODTY = value;
				dataGridView = _dgvCODTY;
				if (dataGridView != null)
				{
					dataGridView.DoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lblCODTY")]
		internal virtual Label lblCODTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCODTY")]
		internal virtual TextBox txtCODTY
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
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

		[field: AccessedThroughProperty("numORDSQ")]
		internal virtual NumControl numORDSQ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public string CODTY
		{
			set
			{
				mCODTY = value;
			}
		}

		public string ReturnValue
		{
			get
			{
				return mReturnValue;
			}
		}

		public frmMAEBDM()
		{
			base.FormClosing += frmMAEBDM_FormClosing;
			base.Load += frmMAEBDM_Load;
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cmdPrint = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.numORDSQ = new IMS.NumControl();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvCODTY = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.Label7 = new System.Windows.Forms.Label();
			this.lkpBDGRP = new IMS.LookupControl();
			this.dgvMABDM = new System.Windows.Forms.DataGridView();
			this.lblCODTY = new System.Windows.Forms.Label();
			this.txtCODTY = new System.Windows.Forms.TextBox();
			this.lblBDGRP = new System.Windows.Forms.Label();
			this.lkpBDCOD = new IMS.LookupControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvCODTY).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMABDM).BeginInit();
			base.SuspendLayout();
			this.cmdPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdPrint.Enabled = false;
			this.cmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdPrint.Image = IMS.My.Resources.Resources.Print;
			this.cmdPrint.Location = new System.Drawing.Point(388, 4);
			this.cmdPrint.Margin = new System.Windows.Forms.Padding(4);
			this.cmdPrint.Name = "cmdPrint";
			this.cmdPrint.Size = new System.Drawing.Size(120, 48);
			this.cmdPrint.TabIndex = 9;
			this.cmdPrint.Text = "Print";
			this.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdPrint.UseVisualStyleBackColor = false;
			this.cmdClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdClose.Image = IMS.My.Resources.Resources.Close;
			this.cmdClose.Location = new System.Drawing.Point(516, 4);
			this.cmdClose.Margin = new System.Windows.Forms.Padding(4);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(120, 48);
			this.cmdClose.TabIndex = 8;
			this.cmdClose.Text = "Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdDelete.Image = IMS.My.Resources.Resources.Delete;
			this.cmdDelete.Location = new System.Drawing.Point(132, 4);
			this.cmdDelete.Margin = new System.Windows.Forms.Padding(4);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.Size = new System.Drawing.Size(120, 48);
			this.cmdDelete.TabIndex = 7;
			this.cmdDelete.Text = "Delete";
			this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdDelete.UseVisualStyleBackColor = false;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.cmdCancel.Location = new System.Drawing.Point(260, 4);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(120, 48);
			this.cmdCancel.TabIndex = 6;
			this.cmdCancel.Text = "Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.cmdSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cmdSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.cmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSave.Image = IMS.My.Resources.Resources.Save;
			this.cmdSave.Location = new System.Drawing.Point(4, 4);
			this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.Size = new System.Drawing.Size(120, 48);
			this.cmdSave.TabIndex = 5;
			this.cmdSave.Text = "Save";
			this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdSave.UseVisualStyleBackColor = false;
			this.Panel1.AutoScroll = true;
			this.Panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Margin = new System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1370, 749);
			this.Panel1.TabIndex = 7;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.numORDSQ, 3, 4);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.dgvCODTY, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnRefresh, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lkpBDGRP, 3, 1);
			this.TableLayoutPanel1.Controls.Add(this.dgvMABDM, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblCODTY, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtCODTY, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblBDGRP, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.lkpBDCOD, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 2, 4);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1067, 599);
			this.TableLayoutPanel1.TabIndex = 244;
			this.numORDSQ.AllowNegative = false;
			this.numORDSQ.DataChanged = false;
			this.numORDSQ.Location = new System.Drawing.Point(531, 502);
			this.numORDSQ.Name = "numORDSQ";
			this.numORDSQ.NumberFormat = "8";
			this.numORDSQ.Size = new System.Drawing.Size(94, 22);
			this.numORDSQ.TabIndex = 247;
			this.numORDSQ.Text = "0";
			this.numORDSQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numORDSQ.ThousandSeperator = false;
			this.numORDSQ.Value = 0.0;
			this.TableLayoutPanel2.ColumnCount = 5;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 4);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cmdSave, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdDelete, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdPrint, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdCancel, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.cmdClose, 4, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 537);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(643, 55);
			this.TableLayoutPanel2.TabIndex = 245;
			this.dgvCODTY.AllowUserToAddRows = false;
			this.dgvCODTY.AllowUserToDeleteRows = false;
			this.dgvCODTY.AllowUserToResizeRows = false;
			this.dgvCODTY.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvCODTY.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCODTY.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvCODTY.ColumnHeadersHeight = 25;
			this.dgvCODTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvCODTY, 2);
			this.dgvCODTY.Location = new System.Drawing.Point(4, 4);
			this.dgvCODTY.Margin = new System.Windows.Forms.Padding(4);
			this.dgvCODTY.MultiSelect = false;
			this.dgvCODTY.Name = "dgvCODTY";
			this.dgvCODTY.ReadOnly = true;
			this.dgvCODTY.RowHeadersWidth = 20;
			this.dgvCODTY.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvCODTY.RowsDefaultCellStyle = DataGridViewCellStyle2;
			this.TableLayoutPanel1.SetRowSpan(this.dgvCODTY, 3);
			this.dgvCODTY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCODTY.Size = new System.Drawing.Size(391, 113);
			this.dgvCODTY.TabIndex = 0;
			this.dgvCODTY.TabStop = false;
			this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRefresh.Location = new System.Drawing.Point(532, 69);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(120, 48);
			this.btnRefresh.TabIndex = 2;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(4, 508);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(117, 16);
			this.Label7.TabIndex = 44;
			this.Label7.Text = "Break Down Code";
			this.lkpBDGRP.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpBDGRP.AllowBlank = false;
			this.lkpBDGRP.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpBDGRP.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpBDGRP.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpBDGRP.DescriptionVisible1 = true;
			this.lkpBDGRP.DescriptionVisible2 = false;
			this.lkpBDGRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpBDGRP.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpBDGRP.KeyValue = "";
			this.lkpBDGRP.LKPCD = "BDGRP";
			this.lkpBDGRP.Location = new System.Drawing.Point(535, 36);
			this.lkpBDGRP.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.lkpBDGRP.MaxLength = 0;
			this.lkpBDGRP.Modified = false;
			this.lkpBDGRP.Multiline_ = false;
			this.lkpBDGRP.Name = "lkpBDGRP";
			this.lkpBDGRP.PasswordChar = "\0";
			this.lkpBDGRP.ReadOnly_ = false;
			this.lkpBDGRP.Size = new System.Drawing.Size(500, 23);
			this.lkpBDGRP.TabIndex = 1;
			this.lkpBDGRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpBDGRP.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpBDGRP.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpBDGRP.TextHeight = 23;
			this.lkpBDGRP.TextWidth = 258;
			this.lkpBDGRP.Where1 = null;
			this.dgvMABDM.AllowUserToAddRows = false;
			this.dgvMABDM.AllowUserToDeleteRows = false;
			this.dgvMABDM.AllowUserToResizeRows = false;
			this.dgvMABDM.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvMABDM.BackgroundColor = System.Drawing.Color.Lavender;
			DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaGreen;
			DataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMABDM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
			this.dgvMABDM.ColumnHeadersHeight = 25;
			this.dgvMABDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvMABDM, 4);
			this.dgvMABDM.Location = new System.Drawing.Point(4, 125);
			this.dgvMABDM.Margin = new System.Windows.Forms.Padding(4);
			this.dgvMABDM.MultiSelect = false;
			this.dgvMABDM.Name = "dgvMABDM";
			this.dgvMABDM.ReadOnly = true;
			this.dgvMABDM.RowHeadersWidth = 20;
			this.dgvMABDM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
			DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Yellow;
			this.dgvMABDM.RowsDefaultCellStyle = DataGridViewCellStyle4;
			this.dgvMABDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMABDM.Size = new System.Drawing.Size(1050, 370);
			this.dgvMABDM.TabIndex = 3;
			this.dgvMABDM.TabStop = false;
			this.lblCODTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCODTY.AutoSize = true;
			this.lblCODTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCODTY.Location = new System.Drawing.Point(403, 7);
			this.lblCODTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCODTY.Name = "lblCODTY";
			this.lblCODTY.Size = new System.Drawing.Size(76, 16);
			this.lblCODTY.TabIndex = 243;
			this.lblCODTY.Text = "Code Type";
			this.txtCODTY.Location = new System.Drawing.Point(532, 4);
			this.txtCODTY.Margin = new System.Windows.Forms.Padding(4);
			this.txtCODTY.Name = "txtCODTY";
			this.txtCODTY.ReadOnly = true;
			this.txtCODTY.Size = new System.Drawing.Size(172, 22);
			this.txtCODTY.TabIndex = 1;
			this.txtCODTY.TabStop = false;
			this.lblBDGRP.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblBDGRP.AutoSize = true;
			this.lblBDGRP.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblBDGRP.Location = new System.Drawing.Point(403, 39);
			this.lblBDGRP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblBDGRP.Name = "lblBDGRP";
			this.lblBDGRP.Size = new System.Drawing.Size(121, 16);
			this.lblBDGRP.TabIndex = 241;
			this.lblBDGRP.Text = "Break Down Group";
			this.lkpBDCOD.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpBDCOD.AllowBlank = false;
			this.lkpBDCOD.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpBDCOD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpBDCOD.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpBDCOD.DescriptionVisible1 = true;
			this.lkpBDCOD.DescriptionVisible2 = false;
			this.lkpBDCOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpBDCOD.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpBDCOD.KeyValue = "";
			this.lkpBDCOD.LKPCD = "CODE";
			this.lkpBDCOD.Location = new System.Drawing.Point(132, 505);
			this.lkpBDCOD.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.lkpBDCOD.MaxLength = 0;
			this.lkpBDCOD.Modified = false;
			this.lkpBDCOD.Multiline_ = false;
			this.lkpBDCOD.Name = "lkpBDCOD";
			this.lkpBDCOD.PasswordChar = "\0";
			this.lkpBDCOD.ReadOnly_ = false;
			this.lkpBDCOD.Size = new System.Drawing.Size(229, 23);
			this.lkpBDCOD.TabIndex = 4;
			this.lkpBDCOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpBDCOD.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpBDCOD.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpBDCOD.TextHeight = 23;
			this.lkpBDCOD.TextWidth = 200;
			this.lkpBDCOD.Where1 = null;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(403, 508);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(107, 16);
			this.Label1.TabIndex = 246;
			this.Label1.Text = "Order Sequence";
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1370, 749);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmMAEBDM";
			base.Tag = "MAEBDM";
			this.Text = "Break Down Matrix";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvCODTY).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMABDM).EndInit();
			base.ResumeLayout(false);
		}

		private void frmMAEBDM_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.Owner != null)
			{
				return;
			}
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

		private void frmMAEBDM_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			SetMaxLength();
			RefreshCODTY();
			ClearFormData();
			if (base.Owner != null)
			{
				FindCodeType();
				dgvCODTY_DoubleClick(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void SetMaxLength()
		{
			lkpBDGRP.MaxLength = DB.CharColumnMaxLength("MABDM_TBL", "MABDM_BDGRP");
			lkpBDCOD.MaxLength = DB.CharColumnMaxLength("MABDM_TBL", "MABDM_BDCOD");
		}

		private void RefreshCODTY()
		{
			DataTable dt = new DataTable();
			dgvCODTY.DataSource = null;
			string strSQL = "SELECT MACOD_CODNM, MACOD_CODID FROM MACOD_TBL WHERE MACOD_CTYID = 'BDTYP' ORDER BY MACOD_CODNM";
			dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvCODTY;
			dataGridView.DataSource = dt;
			dataGridView = null;
			DataGridView dataGridView2 = dgvCODTY;
			dataGridView2.DataSource = dt;
			dataGridView2.Columns[0].Visible = true;
			dataGridView2.Columns[0].Width = 150;
			dataGridView2.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
			dataGridView2.Columns[1].Visible = false;
			dataGridView2.Columns[1].Width = 120;
			dataGridView2.Columns[1].HeaderText = "MACOD_CODID";
			dataGridView2.AutoResizeRows();
			dataGridView2.Refresh();
			dataGridView2 = null;
		}

		private void RefreshdgvMBDM()
		{
			DataTable dt = new DataTable();
			if (Operators.CompareString(txtCODTY.Text, "", false) != 0 && Operators.CompareString(lkpBDGRP.KeyValue, "", false) != 0)
			{
				string strFields = "MABDM_BDCOD, MACOD_CODNM, MABDM_ORDSQ ";
				string strWhere = "MABDM_CTYID = MACOD_CTYID ";
				strWhere += "AND MABDM_BDCOD = MACOD_CODID ";
				strWhere = strWhere + "AND MABDM_CTYID = '" + Common.gfValidSQLStr(txtCODTY.Text) + "' AND MABDM_BDGRP = '" + Common.gfValidSQLStr(lkpBDGRP.KeyValue) + "'";
				dt = DB.GetTable(strFields, "MABDM_TBL, MACOD_TBL", strWhere, "MABDM_ORDSQ");
				DataGridView dataGridView = dgvMABDM;
				dataGridView.DataSource = dt;
				dataGridView.Columns[0].Visible = true;
				dataGridView.Columns[0].Width = 100;
				dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Break Down Code");
				dataGridView.Columns[1].Visible = true;
				dataGridView.Columns[1].Width = 200;
				dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Code Description");
				dataGridView.Columns[2].Visible = true;
				dataGridView.Columns[2].Width = 100;
				dataGridView.Columns[2].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Order Sequence");
				dataGridView.AutoResizeRows();
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void ClearFormData()
		{
			lkpBDGRP.KeyValue = "";
			lkpBDGRP.RefreshDescription();
			lkpBDCOD.KeyValue = "";
			lkpBDCOD.RefreshDescription();
			dgvMABDM.DataSource = null;
			lkpBDGRP.Focus();
		}

		private bool DeleteRecord()
		{
			Cursor = Cursors.WaitCursor;
			bool DeleteRecord;
			try
			{
				string strSQL = "DELETE MABDM_TBL ";
				strSQL = strSQL + "WHERE MABDM_CTYID = '" + Common.gfValidSQLStr(txtCODTY.Text.Trim()) + "' ";
				strSQL = strSQL + "AND MABDM_BDGRP = '" + Common.gfValidSQLStr(lkpBDGRP.KeyValue) + "' ";
				strSQL = strSQL + "AND MABDM_BDCOD = '" + Common.gfValidSQLStr(lkpBDCOD.KeyValue) + "'";
				DeleteRecord = (DB.DBExecute(strSQL) ? true : false);
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "\r\n" + ex2.Message + "\r\n" + Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record not deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Cursor = Cursors.Default;
				DeleteRecord = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Cursor = Cursors.Default;
				DeleteRecord = false;
				ProjectData.ClearProjectError();
			}
			return DeleteRecord;
		}

		private bool ValidKeyField()
		{
			if (Operators.CompareString(txtCODTY.Text, "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Code Type!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtCODTY.Focus();
				return false;
			}
			if (Operators.CompareString(lkpBDGRP.KeyValue.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Break Down Group!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpBDGRP.Focus();
				return false;
			}
			if (!lkpBDCOD.IsValid())
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid code entered!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpBDCOD.Focus();
				return false;
			}
			return true;
		}

		private bool SaveRecord()
		{
			Cursor = Cursors.WaitCursor;
			bool SaveRecord;
			try
			{
				string strSQL = "SELECT * FROM MABDM_TBL ";
				strSQL = strSQL + "WHERE MABDM_CTYID = '" + Common.gfValidSQLStr(txtCODTY.Text.Trim()) + "' ";
				strSQL = strSQL + "AND MABDM_BDGRP = '" + Common.gfValidSQLStr(lkpBDGRP.KeyValue) + "' ";
				strSQL = strSQL + "AND MABDM_BDCOD = '" + Common.gfValidSQLStr(lkpBDCOD.KeyValue) + "'";
				if (!DB.RecordExists(strSQL))
				{
					strSQL = "INSERT MABDM_TBL(";
					strSQL += "MABDM_CTYID, MABDM_BDGRP, MABDM_BDCOD, MABDM_ORDSQ, ";
					strSQL += "MABDM_USRID, MABDM_LUPDT) ";
					strSQL += "VALUES (";
					strSQL = strSQL + "'" + Common.gfValidSQLStr(txtCODTY.Text.Trim()) + "', '" + Common.gfValidSQLStr(lkpBDGRP.KeyValue) + "', '" + Common.gfValidSQLStr(lkpBDCOD.KeyValue) + "', " + Conversions.ToString(numORDSQ.Value) + ", ";
					strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "', GETDATE())";
				}
				else
				{
					strSQL = "UPDATE MABDM_TBL SET ";
					strSQL = strSQL + "MABDM_ORDSQ = " + Conversions.ToString(numORDSQ.Value) + ", ";
					strSQL = strSQL + "MABDM_USRID = '" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "', ";
					strSQL += "MABDM_LUPDT = GETDATE() ";
					strSQL = strSQL + "WHERE MABDM_CTYID = '" + Common.gfValidSQLStr(txtCODTY.Text.Trim()) + "' ";
					strSQL = strSQL + "AND MABDM_BDGRP = '" + Common.gfValidSQLStr(lkpBDGRP.KeyValue) + "' ";
					strSQL = strSQL + "AND MABDM_BDCOD = '" + Common.gfValidSQLStr(lkpBDCOD.KeyValue) + "'";
				}
				int intAffected = 0 - (DB.DBExecute(strSQL) ? 1 : 0);
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "\r\n" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Cursor = Cursors.Default;
				SaveRecord = false;
				ProjectData.ClearProjectError();
				goto IL_02b6;
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Cursor = Cursors.Default;
				SaveRecord = false;
				ProjectData.ClearProjectError();
				goto IL_02b6;
			}
			Cursor = Cursors.Default;
			SaveRecord = true;
			goto IL_02b6;
			IL_02b6:
			return SaveRecord;
		}

		private void FindCodeType()
		{
			DataGridView dataGridView = dgvCODTY;
			checked
			{
				int num = dataGridView.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dataGridView.Rows[i].Selected = true;
					if (Operators.CompareString(dataGridView.Rows[i].Cells[1].ToString(), mCODTY, false) == 0)
					{
						return;
					}
				}
				dataGridView = null;
			}
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cmdSave_Click(object sender, EventArgs e)
		{
			if (ValidKeyField() && SaveRecord())
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				if (base.Owner != null)
				{
					mReturnValue = lkpBDGRP.KeyValue;
					cmdClose_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				else
				{
					RefreshdgvMBDM();
					lkpBDCOD.KeyValue = "";
					lkpBDCOD.RefreshDescription();
				}
			}
		}

		private void ShowGridData()
		{
			DataGridView dataGridView = dgvMABDM;
			lkpBDCOD.KeyValue = Conversions.ToString(dataGridView[0, dataGridView.CurrentCell.RowIndex].Value);
			lkpBDCOD.RefreshDescription();
			numORDSQ.Value = Conversions.ToDouble(dataGridView[2, dataGridView.CurrentCell.RowIndex].Value);
			dataGridView = null;
		}

		private void dgvCODTY_DoubleClick(object sender, EventArgs e)
		{
			txtCODTY.Text = dgvCODTY[1, dgvCODTY.CurrentCell.RowIndex].Value.ToString();
			lkpBDGRP.KeyValue = "";
			lkpBDCOD.KeyValue = "";
			lkpBDCOD.RefreshDescription();
			dgvMABDM.DataSource = null;
		}

		private void dgvMABDM_DoubleClick(object sender, EventArgs e)
		{
			if (dgvMABDM.CurrentRow.Index >= 0)
			{
				ShowGridData();
			}
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			ClearFormData();
		}

		private void cmdDelete_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(lkpBDCOD.KeyValue, "", false) == 0)
			{
				return;
			}
			string strSQL = "SELECT * FROM MABDM_TBL ";
			strSQL = strSQL + "WHERE MABDM_CTYID = '" + Common.gfValidSQLStr(txtCODTY.Text.Trim()) + "' ";
			strSQL = strSQL + "AND MABDM_BDGRP = '" + Common.gfValidSQLStr(lkpBDGRP.KeyValue) + "' ";
			strSQL = strSQL + "AND MABDM_BDCOD = '" + Common.gfValidSQLStr(lkpBDCOD.KeyValue) + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid code entered!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				lkpBDCOD.Focus();
				return;
			}
			DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
			{
				if (!DeleteRecord())
				{
					return;
				}
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			RefreshdgvMBDM();
			lkpBDCOD.KeyValue = "";
			lkpBDCOD.RefreshDescription();
		}

		private void lkpBDGRP_BeforeLookup()
		{
			lkpBDGRP.Where1 = "MABDM_CTYID = '" + Common.gfValidSQLStr(txtCODTY.Text) + "'";
		}

		private void lkpBDCOD_BeforeLookup()
		{
			lkpBDCOD.Where1 = "MACOD_CTYID = '" + Common.gfValidSQLStr(txtCODTY.Text) + "'";
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			RefreshdgvMBDM();
			lkpBDCOD.KeyValue = "";
			lkpBDCOD.RefreshDescription();
		}
	}
}
