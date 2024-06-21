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
	public class frmPCEPAW : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDetails")]
		private DataGridView _dgvDetails;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCLOSE")]
		private Button _btnCLOSE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnConfirm")]
		private Button _btnConfirm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBACK")]
		private Button _btnBACK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numQTY")]
		private NumControl _numQTY;

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
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

		[field: AccessedThroughProperty("lblCUSIDFR")]
		internal virtual Label lblCUSIDFR
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

		[field: AccessedThroughProperty("txtLOCID")]
		internal virtual TextBox txtLOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label21")]
		internal virtual Label Label21
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

		[field: AccessedThroughProperty("txtSUPID")]
		internal virtual TextBox txtSUPID
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
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

		[field: AccessedThroughProperty("cbRACKNO")]
		internal virtual ComboBox cbRACKNO
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

		[field: AccessedThroughProperty("cbDOCNOTO")]
		internal virtual ComboboxControl cbDOCNOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbDOCNOFR")]
		internal virtual ComboboxControl cbDOCNOFR
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
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

		[field: AccessedThroughProperty("btnSEARCH")]
		internal virtual Button btnSEARCH
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

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtRECID")]
		internal virtual TextBox txtRECID
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

		internal virtual Button btnBACK
		{
			[CompilerGenerated]
			get
			{
				return _btnBACK;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnBACK_Click;
				Button button = _btnBACK;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnBACK = value;
				button = _btnBACK;
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

		[field: AccessedThroughProperty("dgvRACKDETAILS")]
		internal virtual DataGridView dgvRACKDETAILS
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbPLTID")]
		internal virtual ComboBox cbPLTID
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

		internal virtual NumControl numQTY
		{
			[CompilerGenerated]
			get
			{
				return _numQTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numOKQTY_TextChanged;
				NumControl numControl = _numQTY;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numQTY = value;
				numControl = _numQTY;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numWEIGHT")]
		internal virtual NumControl numWEIGHT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSTDWGT")]
		internal virtual NumControl numSTDWGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCEPAW()
		{
			base.FormClosing += frmPCEPAW_FormClosing;
			base.Load += frmPCEPAW_Load;
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
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnBACK = new System.Windows.Forms.Button();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvRACKDETAILS = new System.Windows.Forms.DataGridView();
			this.cbRACKNO = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtITMCD = new System.Windows.Forms.TextBox();
			this.txtLOCID = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.txtSUPID = new System.Windows.Forms.TextBox();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbPLTID = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.numQTY = new IMS.NumControl();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.numWEIGHT = new IMS.NumControl();
			this.numSTDWGT = new IMS.NumControl();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnCLOSE = new System.Windows.Forms.Button();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvRACKDETAILS).BeginInit();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.TableLayoutPanel6);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(2, 1);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1366, 670);
			this.Panel2.TabIndex = 3;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 2;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnBACK, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnConfirm, 0, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(7, 9);
			this.TableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel6.TabIndex = 4;
			this.btnBACK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBACK.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBACK.Image = IMS.My.Resources.Resources.Back;
			this.btnBACK.Location = new System.Drawing.Point(129, 2);
			this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBACK.Name = "btnBACK";
			this.btnBACK.Size = new System.Drawing.Size(120, 50);
			this.btnBACK.TabIndex = 23;
			this.btnBACK.Text = "Back";
			this.btnBACK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBACK.UseVisualStyleBackColor = false;
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
			this.btnConfirm.TabIndex = 20;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 6;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Controls.Add(this.dgvRACKDETAILS, 4, 3);
			this.TableLayoutPanel2.Controls.Add(this.cbRACKNO, 1, 7);
			this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel3, 0, 9);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 7);
			this.TableLayoutPanel2.Controls.Add(this.txtITMCD, 1, 5);
			this.TableLayoutPanel2.Controls.Add(this.txtLOCID, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label8, 0, 5);
			this.TableLayoutPanel2.Controls.Add(this.Label21, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.dgvDetails, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.txtSUPID, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 7);
			this.TableLayoutPanel2.Controls.Add(this.cbPLTID, 3, 7);
			this.TableLayoutPanel2.Controls.Add(this.Label3, 0, 6);
			this.TableLayoutPanel2.Controls.Add(this.numQTY, 1, 6);
			this.TableLayoutPanel2.Controls.Add(this.txtRECID, 4, 5);
			this.TableLayoutPanel2.Controls.Add(this.Label4, 2, 5);
			this.TableLayoutPanel2.Controls.Add(this.Label5, 2, 6);
			this.TableLayoutPanel2.Controls.Add(this.numWEIGHT, 3, 6);
			this.TableLayoutPanel2.Controls.Add(this.numSTDWGT, 3, 5);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(7, 67);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 10;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(1252, 551);
			this.TableLayoutPanel2.TabIndex = 1;
			this.dgvRACKDETAILS.AllowUserToAddRows = false;
			this.dgvRACKDETAILS.AllowUserToDeleteRows = false;
			this.dgvRACKDETAILS.AllowUserToResizeColumns = false;
			this.dgvRACKDETAILS.AllowUserToResizeRows = false;
			this.dgvRACKDETAILS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvRACKDETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel2.SetColumnSpan(this.dgvRACKDETAILS, 2);
			this.dgvRACKDETAILS.Location = new System.Drawing.Point(864, 93);
			this.dgvRACKDETAILS.MultiSelect = false;
			this.dgvRACKDETAILS.Name = "dgvRACKDETAILS";
			this.dgvRACKDETAILS.ReadOnly = true;
			this.dgvRACKDETAILS.RowHeadersVisible = false;
			this.dgvRACKDETAILS.RowHeadersWidth = 51;
			this.dgvRACKDETAILS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRACKDETAILS.Size = new System.Drawing.Size(385, 289);
			this.dgvRACKDETAILS.TabIndex = 9;
			this.dgvRACKDETAILS.TabStop = false;
			this.cbRACKNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRACKNO.FormattingEnabled = true;
			this.cbRACKNO.Location = new System.Drawing.Point(121, 452);
			this.cbRACKNO.Name = "cbRACKNO";
			this.cbRACKNO.Size = new System.Drawing.Size(250, 28);
			this.cbRACKNO.TabIndex = 8;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel2.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 495);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel3.TabIndex = 2;
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
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Add";
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
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 456);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(73, 20);
			this.Label2.TabIndex = 25;
			this.Label2.Text = "Rack No";
			this.txtITMCD.Location = new System.Drawing.Point(121, 387);
			this.txtITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtITMCD.Name = "txtITMCD";
			this.txtITMCD.ReadOnly = true;
			this.txtITMCD.Size = new System.Drawing.Size(250, 26);
			this.txtITMCD.TabIndex = 12;
			this.TableLayoutPanel2.SetColumnSpan(this.txtLOCID, 3);
			this.txtLOCID.Location = new System.Drawing.Point(121, 62);
			this.txtLOCID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtLOCID.Name = "txtLOCID";
			this.txtLOCID.ReadOnly = true;
			this.txtLOCID.Size = new System.Drawing.Size(333, 26);
			this.txtLOCID.TabIndex = 3;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 391);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(85, 20);
			this.Label8.TabIndex = 11;
			this.Label8.Text = "Item Code";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 65);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(95, 20);
			this.Label21.TabIndex = 55;
			this.Label21.Text = "Location ID";
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeColumns = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel2.SetColumnSpan(this.dgvDetails, 4);
			this.dgvDetails.Location = new System.Drawing.Point(3, 93);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.TableLayoutPanel2.SetRowSpan(this.dgvDetails, 2);
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(855, 289);
			this.dgvDetails.TabIndex = 8;
			this.dgvDetails.TabStop = false;
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 5);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(112, 20);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Document No";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 35);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(92, 20);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Supplier ID";
			this.TableLayoutPanel2.SetColumnSpan(this.txtSUPID, 3);
			this.txtSUPID.Location = new System.Drawing.Point(121, 32);
			this.txtSUPID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSUPID.Name = "txtSUPID";
			this.txtSUPID.ReadOnly = true;
			this.txtSUPID.Size = new System.Drawing.Size(333, 26);
			this.txtSUPID.TabIndex = 4;
			this.TableLayoutPanel2.SetColumnSpan(this.txtDOCNO, 3);
			this.txtDOCNO.Location = new System.Drawing.Point(121, 2);
			this.txtDOCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.ReadOnly = true;
			this.txtDOCNO.Size = new System.Drawing.Size(333, 26);
			this.txtDOCNO.TabIndex = 57;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(377, 456);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(51, 20);
			this.Label1.TabIndex = 58;
			this.Label1.Text = "Pallet";
			this.cbPLTID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPLTID.FormattingEnabled = true;
			this.cbPLTID.Location = new System.Drawing.Point(516, 452);
			this.cbPLTID.Name = "cbPLTID";
			this.cbPLTID.Size = new System.Drawing.Size(250, 28);
			this.cbPLTID.TabIndex = 59;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 423);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(71, 20);
			this.Label3.TabIndex = 60;
			this.Label3.Text = "Quantity";
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQTY.DataChanged = false;
			this.numQTY.Location = new System.Drawing.Point(121, 420);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "12.3";
			this.numQTY.Size = new System.Drawing.Size(87, 26);
			this.numQTY.TabIndex = 62;
			this.numQTY.Text = "0";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.txtRECID.Location = new System.Drawing.Point(864, 388);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(69, 26);
			this.txtRECID.TabIndex = 56;
			this.txtRECID.Text = "-1";
			this.txtRECID.Visible = false;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(377, 391);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(133, 20);
			this.Label4.TabIndex = 61;
			this.Label4.Text = "Standard Weight";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(377, 423);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(61, 20);
			this.Label5.TabIndex = 64;
			this.Label5.Text = "Weight";
			this.numWEIGHT.AllowNegative = false;
			this.numWEIGHT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWEIGHT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWEIGHT.DataChanged = false;
			this.numWEIGHT.Location = new System.Drawing.Point(516, 420);
			this.numWEIGHT.Name = "numWEIGHT";
			this.numWEIGHT.NumberFormat = "8.0";
			this.numWEIGHT.ReadOnly = true;
			this.numWEIGHT.Size = new System.Drawing.Size(87, 26);
			this.numWEIGHT.TabIndex = 65;
			this.numWEIGHT.Text = "0";
			this.numWEIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWEIGHT.ThousandSeperator = false;
			this.numWEIGHT.Value = 0.0;
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(516, 388);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.0";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(87, 26);
			this.numSTDWGT.TabIndex = 66;
			this.numSTDWGT.Text = "0";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(828, 30);
			this.TableLayoutPanel1.TabIndex = 1;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(496, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(325, 26);
			this.cbDOCNOTO.TabIndex = 18;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(123, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(327, 25);
			this.cbDOCNOFR.TabIndex = 17;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(458, 5);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(28, 20);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 5);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(112, 20);
			this.Label6.TabIndex = 2;
			this.Label6.Text = "Document No";
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 2;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnCLOSE, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 41);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(252, 54);
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
			this.btnSEARCH.TabIndex = 8;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.btnCLOSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCLOSE.Image = IMS.My.Resources.Resources.Close;
			this.btnCLOSE.Location = new System.Drawing.Point(129, 2);
			this.btnCLOSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCLOSE.Name = "btnCLOSE";
			this.btnCLOSE.Size = new System.Drawing.Size(120, 50);
			this.btnCLOSE.TabIndex = 12;
			this.btnCLOSE.Text = "Close";
			this.btnCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCLOSE.UseVisualStyleBackColor = false;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 100);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1260, 517);
			this.dgvHEADER.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.dgvHEADER);
			this.Panel1.Controls.Add(this.TableLayoutPanel4);
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(1, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 623);
			this.Panel1.TabIndex = 4;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPCEPAW";
			base.Tag = "PCEPAW";
			this.Text = "Put Away";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvRACKDETAILS).EndInit();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void BindComboBox()
		{
			cbDOCNOFR.DataTable = "PCGRN_TBL WITH (NOLOCK) ";
			cbDOCNOFR.WhereClause = "PCGRN_COMFG = 1 ";
			cbDOCNOFR.ValueMember = "PCGRN_DOCNO";
			cbDOCNOFR.DisplayMember = "PCGRN_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "PCGRN_TBL WITH (NOLOCK) ";
			cbDOCNOTO.WhereClause = "PCGRN_COMFG = 1 ";
			cbDOCNOTO.ValueMember = "PCGRN_DOCNO";
			cbDOCNOTO.DisplayMember = "PCGRN_DOCNO";
			cbDOCNOTO.LoadData();
			string strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'RACKNO' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbRACKNO.ValueMember = "MACOD_CODID";
			cbRACKNO.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbRACKNO);
			strSQL = "SELECT MAPLT_PLTID FROM MAPLT_TBL WITH (NOLOCK) ";
			strSQL += "WHERE MAPLT_STSFG = 0 ";
			strSQL += "ORDER BY MAPLT_PLTID ";
			cbPLTID.ValueMember = "MAPLT_PLTID";
			cbPLTID.DisplayMember = "MAPLT_PLTID";
			Common.RetriveComboItembySQL(strSQL, cbPLTID);
		}

		private void btnBACK_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearControl();
			Header();
		}

		private void ClearControl()
		{
			txtDOCNO.Text = string.Empty;
			txtSUPID.Text = string.Empty;
			txtSUPID.Text = string.Empty;
			dgvDetails.DataSource = null;
		}

		private void frmPCEPAW_FormClosing(object sender, FormClosingEventArgs e)
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

		private void RefreshGrid()
		{
			int i = 0;
			dgvDetails.DataSource = null;
			string strSQL = "SELECT PCPAW_RECID, PCPAW_GRLNO, PCPAW_ITMCD, MAITM_DESC,PCPAW_BATCHNO, PCPAW_QTY, ";
			strSQL += "ISNULL(PCPAW_RACKNO, MAITM_RACKNO) AS PCPAW_RACKNO, PCPAW_PLTID ";
			strSQL += "FROM PCPAW_WRK WITH(NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL WITH(NOLOCK) ";
			strSQL += "ON MAITM_ITMCD = PCPAW_ITMCD ";
			strSQL = strSQL + "WHERE PCPAW_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
			strSQL = strSQL + "AND PCPAW_COMPNM = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
			strSQL += "ORDER BY PCPAW_GRLNO, PCPAW_RECID";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvDetails.ClearSelection();
					DataGridView dataGridView = dgvDetails;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Rack No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Pallet");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void RefreshRack()
		{
			int i = 0;
			dgvRACKDETAILS.DataSource = null;
			string strSQL = "SELECT INRBAL_RACKNO, INRBAL_PLTID, ISNULL(SUM(INRBAL_QTY),0) ";
			strSQL += "FROM INRBAL_TBL WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE INRBAL_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "' ";
			strSQL += "GROUP BY INRBAL_RACKNO, INRBAL_PLTID ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvRACKDETAILS.ClearSelection();
					DataGridView dataGridView = dgvRACKDETAILS;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Rack No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Pallet");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void dgvDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindDetails();
			RefreshRack();
		}

		private void BindDetails()
		{
			txtRECID.Text = dgvDetails.CurrentRow.Cells["PCPAW_RECID"].Value.ToString();
			txtITMCD.Text = dgvDetails.CurrentRow.Cells["PCPAW_ITMCD"].Value.ToString();
			numQTY.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCPAW_QTY"].Value.ToString());
			numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL", "MAITM_ITMCD = '" + txtITMCD.Text + "'"));
			numQTY.Value = Conversions.ToDouble(Operators.DivideObject(dgvDetails.CurrentRow.Cells["PCPAW_QTY"].Value, numSTDWGT.Value));
			numWEIGHT.Value = numQTY.Value * numSTDWGT.Value;
			if (Operators.CompareString(dgvDetails.CurrentRow.Cells["PCPAW_RACKNO"].Value.ToString(), "", false) != 0)
			{
				cbRACKNO.SelectedValue = dgvDetails.CurrentRow.Cells["PCPAW_RACKNO"].Value.ToString();
			}
			else
			{
				cbRACKNO.SelectedValue = RuntimeHelpers.GetObjectValue(DB.GetColumnValue("MAITM_RACKNO", "MAITM_TBL", "MAITM_ITMCD = '" + txtITMCD.Text + "'"));
			}
		}

		private void frmPCEPAW_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
			Header();
		}

		private void Header()
		{
			int i = 0;
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spPCPAW ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbDOCNOFR.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbDOCNOTO.SelectedValue)) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvHEADER.ClearSelection();
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 200;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.Refresh();
					dataGridView = null;
				}
				Panel1.Visible = true;
				Panel2.Visible = false;
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindHeadertoControl();
			GenWorkData();
			RefreshGrid();
			Panel1.Visible = false;
			Panel2.Visible = true;
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["PCGRN_DOCNO"].Value.ToString();
			txtSUPID.Text = dgvHEADER.CurrentRow.Cells["PCGRN_SUPID"].Value.ToString();
			txtLOCID.Text = dgvHEADER.CurrentRow.Cells["PCGRN_LOCID"].Value.ToString();
		}

		private void GenWorkData()
		{
			OleDbCommand cmd = new OleDbCommand();
			try
			{
				string strSQL = "EXEC spPCPAW_Detail '" + Common.gfValidSQLStr(txtDOCNO.Text) + "', '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
		}

		private bool spPCEPAW(string strPRO)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spPCEPAW ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(txtRECID.Text)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtLOCID.Text) + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(numWEIGHT.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbRACKNO.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(cbPLTID.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "' ";
			bool spPCEPAW;
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
				spPCEPAW = false;
				ProjectData.ClearProjectError();
				goto IL_0179;
			}
			spPCEPAW = true;
			goto IL_0179;
			IL_0179:
			return spPCEPAW;
		}

		private void ClearDetails()
		{
			txtITMCD.Text = string.Empty;
			cbRACKNO.SelectedIndex = -1;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (CheckDetails() && spPCEPAW("0"))
			{
				ClearDetails();
				RefreshGrid();
			}
		}

		private bool CheckDetails()
		{
			double dblGRNQTY = 0.0;
			double dblPAWQTY = 0.0;
			if (Operators.CompareString(txtITMCD.Text, string.Empty, false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			string strWHERE = "PCGRN_DOCNO = '" + txtDOCNO.Text + "' ";
			strWHERE = Conversions.ToString(Operators.ConcatenateObject(strWHERE, Operators.ConcatenateObject(Operators.ConcatenateObject("AND PCGRN_GRLNO = '", dgvDetails.CurrentRow.Cells["PCPAW_GRLNO"].Value), "'")));
			dblGRNQTY = Conversions.ToDouble(DB.GetColumnValue("PCGRN_OKQTY", "PCGRN_TBL", strWHERE));
			strWHERE = "PCPAW_COMPNM = '" + MyProject.Computer.Name + "' ";
			strWHERE = strWHERE + "AND PCPAW_DOCNO = '" + txtDOCNO.Text + "' ";
			strWHERE = strWHERE + "AND PCPAW_ITMCD = '" + txtITMCD.Text + "' ";
			strWHERE = Conversions.ToString(Operators.ConcatenateObject(strWHERE, Operators.ConcatenateObject(Operators.ConcatenateObject("AND PCPAW_GRLNO = '", dgvDetails.CurrentRow.Cells["PCPAW_GRLNO"].Value), "' ")));
			strWHERE = strWHERE + "AND PCPAW_RECID <> " + Conversions.ToString(Conversion.Val(txtRECID.Text));
			dblPAWQTY = Conversions.ToDouble(DB.GetColumnValue("ISNULL(SUM(PCPAW_QTY), 0)", "PCPAW_WRK", strWHERE));
			if (dblPAWQTY + numQTY.Value > dblGRNQTY)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity over GRN Quantity!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(cbRACKNO.SelectedValue, string.Empty, false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Rack No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}

		private void btnCLOSE_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			bool blnOK = true;
			checked
			{
				int num = dgvDetails.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(dgvDetails.Rows[i].Cells["PCPAW_RACKNO"].Value, "", false))
					{
						blnOK = false;
						break;
					}
				}
				if (!blnOK)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Some records Rack No not set!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else if (spPCEPAW("1"))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record confirmed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					ClearDetails();
					ClearControl();
					Header();
				}
			}
		}

		private void numOKQTY_TextChanged(object sender, EventArgs e)
		{
			numWEIGHT.Value = numQTY.Value * numSTDWGT.Value;
		}
	}
}
