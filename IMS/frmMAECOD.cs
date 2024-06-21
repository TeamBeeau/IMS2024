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

namespace IMS
{
	[DesignerGenerated]
	public class frmMAECOD : Form
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
		[AccessedThroughProperty("dgvMACOD")]
		private DataGridView _dgvMACOD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		private int intAccessLevel;

		private string strMessage;

		private SqlDataAdapter dataAdapter;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCTYID")]
		internal virtual Label lblCTYID
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

		[field: AccessedThroughProperty("lblCODNM")]
		internal virtual Label lblCODNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCODID")]
		internal virtual Label lblCODID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCODID")]
		internal virtual TextBox txtCODID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCODNM")]
		internal virtual TextBox txtCODNM
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCTYIDFR")]
		internal virtual Label lblCTYIDFR
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

		internal virtual DataGridView dgvMACOD
		{
			[CompilerGenerated]
			get
			{
				return _dgvMACOD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMACOD_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMACOD;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMACOD = value;
				dataGridView = _dgvMACOD;
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

		[field: AccessedThroughProperty("lblNFLDTITLE2")]
		internal virtual Label lblNFLDTITLE2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCFLDTITLE2")]
		internal virtual Label lblCFLDTITLE2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblNFLDTITLE1")]
		internal virtual Label lblNFLDTITLE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCFLDTITLE1")]
		internal virtual Label lblCFLDTITLE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numNFLD2")]
		internal virtual NumControl numNFLD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCFLD2")]
		internal virtual TextBox txtCFLD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numNFLD1")]
		internal virtual NumControl numNFLD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCFLD1")]
		internal virtual TextBox txtCFLD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACOD_CTYID")]
		internal virtual DataGridViewTextBoxColumn MACOD_CTYID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACOD_CODID")]
		internal virtual DataGridViewTextBoxColumn MACOD_CODID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACOD_CODNM")]
		internal virtual DataGridViewTextBoxColumn MACOD_CODNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACOD_REMRK")]
		internal virtual DataGridViewTextBoxColumn MACOD_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACOD_CFLD1")]
		internal virtual DataGridViewTextBoxColumn MACOD_CFLD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACOD_NFLD1")]
		internal virtual DataGridViewTextBoxColumn MACOD_NFLD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACOD_CFLD2")]
		internal virtual DataGridViewTextBoxColumn MACOD_CFLD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACOD_NFLD2")]
		internal virtual DataGridViewTextBoxColumn MACOD_NFLD2
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

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("cbCTYIDFR")]
		internal virtual ComboBox cbCTYIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCTYID")]
		internal virtual ComboBox cbCTYID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAECOD()
		{
			base.FormClosing += frmMAECOD_FormClosing;
			base.Shown += frmMAECOD_Shown;
			base.Load += frmMAECOD_Load;
			base.KeyDown += frmMAECOD_KeyDown;
			cmd = new OleDbCommand();
			dataAdapter = new SqlDataAdapter();
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
			this.cbCTYID = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.numNFLD2 = new IMS.NumControl();
			this.lblNFLDTITLE2 = new System.Windows.Forms.Label();
			this.txtCFLD2 = new System.Windows.Forms.TextBox();
			this.lblCFLDTITLE2 = new System.Windows.Forms.Label();
			this.numNFLD1 = new IMS.NumControl();
			this.txtCFLD1 = new System.Windows.Forms.TextBox();
			this.lblNFLDTITLE1 = new System.Windows.Forms.Label();
			this.lblCFLDTITLE1 = new System.Windows.Forms.Label();
			this.lblCTYID = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblCODNM = new System.Windows.Forms.Label();
			this.lblCODID = new System.Windows.Forms.Label();
			this.txtCODNM = new System.Windows.Forms.TextBox();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.txtCODID = new System.Windows.Forms.TextBox();
			this.dgvMACOD = new System.Windows.Forms.DataGridView();
			this.MACOD_CTYID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACOD_CODID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACOD_CODNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACOD_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACOD_CFLD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACOD_NFLD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACOD_CFLD2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACOD_NFLD2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbCTYIDFR = new System.Windows.Forms.ComboBox();
			this.lblCTYIDFR = new System.Windows.Forms.Label();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMACOD).BeginInit();
			this.TableLayoutPanel2.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbCTYID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.numNFLD2, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.lblNFLDTITLE2, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtCFLD2, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblCFLDTITLE2, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.numNFLD1, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtCFLD1, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblNFLDTITLE1, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.lblCFLDTITLE1, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblCTYID, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblCODNM, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblCODID, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtCODNM, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtCODID, 1, 1);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(14, 8);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 10;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(615, 300);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbCTYID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCTYID.FormattingEnabled = true;
			this.cbCTYID.Location = new System.Drawing.Point(127, 3);
			this.cbCTYID.Name = "cbCTYID";
			this.cbCTYID.Size = new System.Drawing.Size(200, 25);
			this.cbCTYID.TabIndex = 7;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 2);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 243);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(384, 54);
			this.TableLayoutPanel3.TabIndex = 12;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(4, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 50);
			this.btnSave.TabIndex = 9;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(132, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(260, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 11;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.numNFLD2.AllowNegative = false;
			this.numNFLD2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numNFLD2.DataChanged = false;
			this.numNFLD2.Location = new System.Drawing.Point(128, 195);
			this.numNFLD2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numNFLD2.Name = "numNFLD2";
			this.numNFLD2.NumberFormat = "8.3";
			this.numNFLD2.Size = new System.Drawing.Size(325, 23);
			this.numNFLD2.TabIndex = 8;
			this.numNFLD2.Text = "0.000";
			this.numNFLD2.ThousandSeperator = false;
			this.numNFLD2.Value = 0.0;
			this.lblNFLDTITLE2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblNFLDTITLE2.AutoSize = true;
			this.lblNFLDTITLE2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblNFLDTITLE2.Location = new System.Drawing.Point(4, 198);
			this.lblNFLDTITLE2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNFLDTITLE2.Name = "lblNFLDTITLE2";
			this.lblNFLDTITLE2.Size = new System.Drawing.Size(104, 17);
			this.lblNFLDTITLE2.TabIndex = 8;
			this.lblNFLDTITLE2.Text = "Decimal Field 2";
			this.txtCFLD2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCFLD2.Location = new System.Drawing.Point(128, 168);
			this.txtCFLD2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtCFLD2.Name = "txtCFLD2";
			this.txtCFLD2.Size = new System.Drawing.Size(325, 23);
			this.txtCFLD2.TabIndex = 7;
			this.lblCFLDTITLE2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCFLDTITLE2.AutoSize = true;
			this.lblCFLDTITLE2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCFLDTITLE2.Location = new System.Drawing.Point(4, 171);
			this.lblCFLDTITLE2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCFLDTITLE2.Name = "lblCFLDTITLE2";
			this.lblCFLDTITLE2.Size = new System.Drawing.Size(116, 17);
			this.lblCFLDTITLE2.TabIndex = 9;
			this.lblCFLDTITLE2.Text = "Character Field 2";
			this.numNFLD1.AllowNegative = false;
			this.numNFLD1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numNFLD1.DataChanged = false;
			this.numNFLD1.Location = new System.Drawing.Point(128, 141);
			this.numNFLD1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numNFLD1.Name = "numNFLD1";
			this.numNFLD1.NumberFormat = "8.3";
			this.numNFLD1.Size = new System.Drawing.Size(325, 23);
			this.numNFLD1.TabIndex = 6;
			this.numNFLD1.Text = "0.000";
			this.numNFLD1.ThousandSeperator = false;
			this.numNFLD1.Value = 0.0;
			this.txtCFLD1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCFLD1.Location = new System.Drawing.Point(128, 114);
			this.txtCFLD1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtCFLD1.Name = "txtCFLD1";
			this.txtCFLD1.Size = new System.Drawing.Size(325, 23);
			this.txtCFLD1.TabIndex = 5;
			this.lblNFLDTITLE1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblNFLDTITLE1.AutoSize = true;
			this.lblNFLDTITLE1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblNFLDTITLE1.Location = new System.Drawing.Point(4, 144);
			this.lblNFLDTITLE1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNFLDTITLE1.Name = "lblNFLDTITLE1";
			this.lblNFLDTITLE1.Size = new System.Drawing.Size(104, 17);
			this.lblNFLDTITLE1.TabIndex = 10;
			this.lblNFLDTITLE1.Text = "Decimal Field 1";
			this.lblCFLDTITLE1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCFLDTITLE1.AutoSize = true;
			this.lblCFLDTITLE1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCFLDTITLE1.Location = new System.Drawing.Point(4, 117);
			this.lblCFLDTITLE1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCFLDTITLE1.Name = "lblCFLDTITLE1";
			this.lblCFLDTITLE1.Size = new System.Drawing.Size(116, 17);
			this.lblCFLDTITLE1.TabIndex = 11;
			this.lblCFLDTITLE1.Text = "Character Field 1";
			this.lblCTYID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCTYID.AutoSize = true;
			this.lblCTYID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCTYID.Location = new System.Drawing.Point(4, 7);
			this.lblCTYID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCTYID.Name = "lblCTYID";
			this.lblCTYID.Size = new System.Drawing.Size(77, 17);
			this.lblCTYID.TabIndex = 1;
			this.lblCTYID.Text = "Code Type";
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(4, 90);
			this.lblREMRK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(57, 17);
			this.lblREMRK.TabIndex = 7;
			this.lblREMRK.Text = "Remark";
			this.lblCODNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCODNM.AutoSize = true;
			this.lblCODNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCODNM.Location = new System.Drawing.Point(4, 63);
			this.lblCODNM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCODNM.Name = "lblCODNM";
			this.lblCODNM.Size = new System.Drawing.Size(82, 17);
			this.lblCODNM.TabIndex = 8;
			this.lblCODNM.Text = "Code Name";
			this.lblCODID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCODID.AutoSize = true;
			this.lblCODID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCODID.Location = new System.Drawing.Point(4, 36);
			this.lblCODID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCODID.Name = "lblCODID";
			this.lblCODID.Size = new System.Drawing.Size(58, 17);
			this.lblCODID.TabIndex = 9;
			this.lblCODID.Text = "Code ID";
			this.txtCODNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCODNM.Location = new System.Drawing.Point(128, 60);
			this.txtCODNM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtCODNM.Name = "txtCODNM";
			this.txtCODNM.Size = new System.Drawing.Size(483, 23);
			this.txtCODNM.TabIndex = 3;
			this.txtREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtREMRK.Location = new System.Drawing.Point(128, 87);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(483, 23);
			this.txtREMRK.TabIndex = 4;
			this.txtCODID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCODID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCODID.Location = new System.Drawing.Point(128, 33);
			this.txtCODID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtCODID.Name = "txtCODID";
			this.txtCODID.Size = new System.Drawing.Size(208, 23);
			this.txtCODID.TabIndex = 2;
			this.dgvMACOD.AllowUserToAddRows = false;
			this.dgvMACOD.AllowUserToDeleteRows = false;
			this.dgvMACOD.AllowUserToResizeRows = false;
			this.dgvMACOD.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMACOD.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMACOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMACOD.Columns.AddRange(this.MACOD_CTYID, this.MACOD_CODID, this.MACOD_CODNM, this.MACOD_REMRK, this.MACOD_CFLD1, this.MACOD_NFLD1, this.MACOD_CFLD2, this.MACOD_NFLD2);
			this.dgvMACOD.Location = new System.Drawing.Point(5, 118);
			this.dgvMACOD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvMACOD.MultiSelect = false;
			this.dgvMACOD.Name = "dgvMACOD";
			this.dgvMACOD.ReadOnly = true;
			this.dgvMACOD.RowHeadersVisible = false;
			this.dgvMACOD.RowHeadersWidth = 20;
			this.dgvMACOD.RowTemplate.Height = 24;
			this.dgvMACOD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMACOD.Size = new System.Drawing.Size(1316, 504);
			this.dgvMACOD.TabIndex = 5;
			this.MACOD_CTYID.HeaderText = "Code Type";
			this.MACOD_CTYID.Name = "MACOD_CTYID";
			this.MACOD_CTYID.ReadOnly = true;
			this.MACOD_CTYID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACOD_CODID.HeaderText = "Code ID";
			this.MACOD_CODID.Name = "MACOD_CODID";
			this.MACOD_CODID.ReadOnly = true;
			this.MACOD_CODID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACOD_CODID.Width = 150;
			this.MACOD_CODNM.HeaderText = "Code Name";
			this.MACOD_CODNM.Name = "MACOD_CODNM";
			this.MACOD_CODNM.ReadOnly = true;
			this.MACOD_CODNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACOD_CODNM.Width = 300;
			this.MACOD_REMRK.HeaderText = "Remark";
			this.MACOD_REMRK.Name = "MACOD_REMRK";
			this.MACOD_REMRK.ReadOnly = true;
			this.MACOD_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACOD_REMRK.Width = 300;
			this.MACOD_CFLD1.HeaderText = "Character Field 1";
			this.MACOD_CFLD1.Name = "MACOD_CFLD1";
			this.MACOD_CFLD1.ReadOnly = true;
			this.MACOD_CFLD1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACOD_CFLD1.Width = 150;
			this.MACOD_NFLD1.HeaderText = "Decimal Field 1";
			this.MACOD_NFLD1.Name = "MACOD_NFLD1";
			this.MACOD_NFLD1.ReadOnly = true;
			this.MACOD_NFLD1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACOD_NFLD1.Width = 150;
			this.MACOD_CFLD2.HeaderText = "Character Field 2";
			this.MACOD_CFLD2.Name = "MACOD_CFLD2";
			this.MACOD_CFLD2.ReadOnly = true;
			this.MACOD_CFLD2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACOD_CFLD2.Width = 150;
			this.MACOD_NFLD2.HeaderText = "Decimal Field 2";
			this.MACOD_NFLD2.Name = "MACOD_NFLD2";
			this.MACOD_NFLD2.ReadOnly = true;
			this.MACOD_NFLD2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACOD_NFLD2.Width = 150;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(132, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 50);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(4, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 50);
			this.btnSEARCH.TabIndex = 3;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 2;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbCTYIDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCTYIDFR, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(291, 31);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbCTYIDFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCTYIDFR.FormattingEnabled = true;
			this.cbCTYIDFR.Location = new System.Drawing.Point(88, 3);
			this.cbCTYIDFR.Name = "cbCTYIDFR";
			this.cbCTYIDFR.Size = new System.Drawing.Size(200, 25);
			this.cbCTYIDFR.TabIndex = 7;
			this.lblCTYIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCTYIDFR.AutoSize = true;
			this.lblCTYIDFR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblCTYIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCTYIDFR.Location = new System.Drawing.Point(4, 7);
			this.lblCTYIDFR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCTYIDFR.Name = "lblCTYIDFR";
			this.lblCTYIDFR.Size = new System.Drawing.Size(77, 17);
			this.lblCTYIDFR.TabIndex = 2;
			this.lblCTYIDFR.Text = "Code Type";
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.dgvMACOD);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1346, 630);
			this.Panel2.TabIndex = 6;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 56);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(384, 54);
			this.TableLayoutPanel4.TabIndex = 6;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(260, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 1;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 17f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			base.Name = "frmMAECOD";
			base.Tag = "MAECOD";
			this.Text = "System Code Master";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvMACOD).EndInit();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			strMessage = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!");
			spMAECOD("0");
		}

		private void frmMAECOD_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAECOD_Shown(object sender, EventArgs e)
		{
			Header();
		}

		private void SetMaxLength()
		{
			cbCTYIDFR.MaxLength = DB.CharColumnMaxLength("MACTY_TBL", "MACTY_CTYID");
		}

		private bool spMAECOD(string strPRO)
		{
			bool spMAECOD = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAECOD ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCTYID.SelectedValue), "', ")));
				strSQL = strSQL + "'" + txtCODID.Text + "', ";
				strSQL = strSQL + "N'" + txtCODNM.Text + "', ";
				strSQL = strSQL + "N'" + txtCFLD1.Text + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numNFLD1.Value) + "', ";
				strSQL = strSQL + "N'" + txtCFLD2.Text + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numNFLD2.Value) + "', ";
				strSQL = strSQL + "N'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
				try
				{
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
					MessageBox.Show(strMessage, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					spMAECOD = false;
					ProjectData.ClearProjectError();
					goto IL_01ba;
				}
				Header();
				ClearDetailsControl();
				spMAECOD = true;
			}
			goto IL_01ba;
			IL_01ba:
			return spMAECOD;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(cbCTYIDFR.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				cbCTYID.SelectedValue = RuntimeHelpers.GetObjectValue(cbCTYIDFR.SelectedValue);
			}
			ManageExtraField();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnDelete.Enabled = false;
		}

		private void Header()
		{
			int count = dgvMACOD.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvMACOD.Rows.Remove(dgvMACOD.Rows[0]);
				}
				try
				{
					string strSQL = "EXEC spMACOD ";
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCTYIDFR.SelectedValue), "'")));
					DataTable dt = DB.ExecProc(strSQL);
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvMACOD.ClearSelection();
						dgvMACOD.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvMACOD.Rows[dgvMACOD.Rows.Count - 1];
						dataGridViewRow.Cells["MACOD_CTYID"].Value = dt.Rows[i]["MACOD_CTYID"].ToString();
						dataGridViewRow.Cells["MACOD_CODID"].Value = dt.Rows[i]["MACOD_CODID"].ToString();
						dataGridViewRow.Cells["MACOD_CODNM"].Value = dt.Rows[i]["MACOD_CODNM"].ToString();
						dataGridViewRow.Cells["MACOD_REMRK"].Value = dt.Rows[i]["MACOD_REMRK"].ToString();
						dataGridViewRow.Cells["MACOD_CFLD1"].Value = dt.Rows[i]["MACOD_CFLD1"].ToString();
						dataGridViewRow.Cells["MACOD_NFLD1"].Value = dt.Rows[i]["MACOD_NFLD1"].ToString();
						dataGridViewRow.Cells["MACOD_CFLD2"].Value = dt.Rows[i]["MACOD_CFLD2"].ToString();
						dataGridViewRow.Cells["MACOD_NFLD2"].Value = dt.Rows[i]["MACOD_NFLD2"].ToString();
						dataGridViewRow = null;
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					strMessage = ex.Message;
					MessageBox.Show(strMessage);
					ProjectData.ClearProjectError();
				}
				Panel1.Visible = false;
				Panel2.Visible = true;
			}
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				strMessage = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!");
				spMAECOD("1");
				ClearDetailsControl();
				Header();
			}
		}

		public void ClearDetailsControl()
		{
			cbCTYID.SelectedIndex = -1;
			txtCODID.Text = string.Empty;
			txtCODNM.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			txtCFLD1.Text = string.Empty;
			numNFLD1.Value = 0.0;
			txtCFLD2.Text = string.Empty;
			numNFLD2.Value = 0.0;
			txtCODID.Enabled = true;
			cbCTYID.Enabled = true;
			btnDelete.Enabled = true;
			btnSave.Tag = "Save";
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetailsControl();
			Header();
		}

		public void EditRecord()
		{
			BindGridtoControl();
			Panel1.Visible = true;
			Panel2.Visible = false;
			cbCTYID.Enabled = false;
			txtCODID.Enabled = false;
			btnSave.Tag = "Update";
		}

		public void BindGridtoControl()
		{
			cbCTYID.SelectedValue = dgvMACOD.CurrentRow.Cells["MACOD_CTYID"].Value.ToString();
			txtCODID.Text = dgvMACOD.CurrentRow.Cells["MACOD_CODID"].Value.ToString();
			txtCODNM.Text = dgvMACOD.CurrentRow.Cells["MACOD_CODNM"].Value.ToString();
			txtREMRK.Text = dgvMACOD.CurrentRow.Cells["MACOD_REMRK"].Value.ToString();
			txtCFLD1.Text = dgvMACOD.CurrentRow.Cells["MACOD_CFLD1"].Value.ToString();
			numNFLD1.Value = Conversions.ToDouble(dgvMACOD.CurrentRow.Cells["MACOD_NFLD1"].Value.ToString());
			txtCFLD2.Text = dgvMACOD.CurrentRow.Cells["MACOD_CFLD2"].Value.ToString();
			numNFLD2.Value = Conversions.ToDouble(dgvMACOD.CurrentRow.Cells["MACOD_NFLD2"].Value.ToString());
		}

		private void dgvMACOD_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			EditRecord();
			ManageExtraField();
		}

		public bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbCTYID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Code type cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbCTYID.Focus();
				return false;
			}
			if (Operators.CompareString(txtCODID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Code ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCODID.Focus();
				return false;
			}
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT MACOD_CODID FROM MACOD_TBL WHERE MACOD_CTYID = '", cbCTYID.SelectedValue), "' AND MACOD_CODID = '"), txtCODID.Text), "'"));
			if (Operators.ConditionalCompareObjectEqual(btnSave.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Code ID already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCODID.Focus();
				return false;
			}
			return true;
		}

		private void frmMAECOD_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			CheckAccessLevel();
			SetMaxLength();
			BindComboBox();
			btnNew.Enabled = intAccessLevel != 0;
			btnSave.Enabled = intAccessLevel >= 1;
			btnDelete.Enabled = intAccessLevel >= 3;
		}

		private void CheckAccessLevel()
		{
			string strWhere = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("LPRGX_USRID = '" + PublicVar.gstrLogonID + "' AND LPRGX_PRGID = '", base.Tag), "'"));
			if (DB.RecordExists("SELECT * FROM LPRGX_TBL WHERE " + strWhere))
			{
				intAccessLevel = Conversions.ToInteger(DB.GetColumnValue("LPRGX_LEVEL", "LPRGX_TBL", strWhere));
			}
			else
			{
				intAccessLevel = 3;
			}
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT '' as MACTY_CTYID, '' as MACTY_CTYNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACTY_CTYID, MACTY_CTYNM FROM MACTY_TBL WITH(NOLOCK) ";
			strSQL += " ORDER BY MACTY_CTYID ";
			cbCTYIDFR.ValueMember = "MACTY_CTYID";
			cbCTYIDFR.DisplayMember = "MACTY_CTYNM";
			Common.RetriveComboItembySQL(strSQL, cbCTYIDFR);
			strSQL = "SELECT '' as MACTY_CTYID, '' as MACTY_CTYNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACTY_CTYID, MACTY_CTYNM FROM MACTY_TBL WITH(NOLOCK) ";
			strSQL += " ORDER BY MACTY_CTYID ";
			cbCTYID.ValueMember = "MACTY_CTYID";
			cbCTYID.DisplayMember = "MACTY_CTYNM";
			Common.RetriveComboItembySQL(strSQL, cbCTYID);
		}

		public void ManageExtraField()
		{
			string strCFLD1 = Conversions.ToString(DB.GetColumnValue("LCTY_CFLD1", "MACTY_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACTY_CTYID = '", cbCTYID.SelectedValue), "'"))));
			string strCFLDTITLE1 = Conversions.ToString(DB.GetColumnValue("LCTY_CFLDTITLE1", "MACTY_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACTY_CTYID = '", cbCTYID.SelectedValue), "'"))));
			string strCFLD2 = Conversions.ToString(DB.GetColumnValue("LCTY_CFLD2", "MACTY_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACTY_CTYID = '", cbCTYID.SelectedValue), "'"))));
			string strCFLDTITLE2 = Conversions.ToString(DB.GetColumnValue("LCTY_CFLDTITLE2", "MACTY_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACTY_CTYID = '", cbCTYID.SelectedValue), "'"))));
			string strNFLD1 = Conversions.ToString(DB.GetColumnValue("LCTY_NFLD1", "MACTY_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACTY_CTYID = '", cbCTYID.SelectedValue), "'"))));
			string strNFLDTITLE1 = Conversions.ToString(DB.GetColumnValue("LCTY_NFLDTITLE1", "MACTY_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACTY_CTYID = '", cbCTYID.SelectedValue), "'"))));
			string strNFLD2 = Conversions.ToString(DB.GetColumnValue("LCTY_NFLD2", "MACTY_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACTY_CTYID = '", cbCTYID.SelectedValue), "'"))));
			string strNFLDTITLE2 = Conversions.ToString(DB.GetColumnValue("LCTY_NFLDTITLE2", "MACTY_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACTY_CTYID = '", cbCTYID.SelectedValue), "'"))));
			if (Conversions.ToBoolean(strCFLD1))
			{
				lblCFLDTITLE1.Visible = true;
				lblCFLDTITLE1.Text = strCFLDTITLE1;
				txtCFLD1.Visible = true;
			}
			else
			{
				lblCFLDTITLE1.Visible = false;
				txtCFLD1.Visible = false;
			}
			if (Conversions.ToBoolean(strCFLD2))
			{
				lblCFLDTITLE2.Visible = true;
				lblCFLDTITLE2.Text = strCFLDTITLE2;
				txtCFLD2.Visible = true;
			}
			else
			{
				lblCFLDTITLE2.Visible = false;
				txtCFLD2.Visible = false;
			}
			if (Conversions.ToBoolean(strNFLD1))
			{
				lblNFLDTITLE1.Visible = true;
				lblNFLDTITLE1.Text = strNFLDTITLE1;
				numNFLD1.Visible = true;
			}
			else
			{
				lblNFLDTITLE1.Visible = false;
				numNFLD1.Visible = false;
			}
			if (Conversions.ToBoolean(strNFLD2))
			{
				lblNFLDTITLE2.Visible = true;
				lblNFLDTITLE2.Text = strNFLDTITLE2;
				numNFLD2.Visible = true;
			}
			else
			{
				lblNFLDTITLE2.Visible = false;
				numNFLD2.Visible = false;
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAECOD_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
