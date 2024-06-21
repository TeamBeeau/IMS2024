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
	public class frmMAECTY : Form
	{
		private IContainer components;

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
		[AccessedThroughProperty("dgvMACTY")]
		private DataGridView _dgvMACTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSearch")]
		private Button _btnSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCTYNM")]
		internal virtual TextBox txtCTYNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCTYID")]
		internal virtual TextBox txtCTYID
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

		internal virtual DataGridView dgvMACTY
		{
			[CompilerGenerated]
			get
			{
				return _dgvMACTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMACTY_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMACTY;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMACTY = value;
				dataGridView = _dgvMACTY;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
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

		internal virtual Button btnSearch
		{
			[CompilerGenerated]
			get
			{
				return _btnSearch;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSearch_Click;
				Button button = _btnSearch;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSearch = value;
				button = _btnSearch;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
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

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
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

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtNFLDTITLE2")]
		internal virtual TextBox txtNFLDTITLE2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtNFLDTITLE1")]
		internal virtual TextBox txtNFLDTITLE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCFLDTITLE2")]
		internal virtual TextBox txtCFLDTITLE2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCFLDTITLE1")]
		internal virtual TextBox txtCFLDTITLE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtFLDSZ")]
		internal virtual TextBox txtFLDSZ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkNFLD2")]
		internal virtual CheckBox chkNFLD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkNFLD1")]
		internal virtual CheckBox chkNFLD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkCFLD2")]
		internal virtual CheckBox chkCFLD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkCFLD1")]
		internal virtual CheckBox chkCFLD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACTY_CTYID")]
		internal virtual DataGridViewTextBoxColumn MACTY_CTYID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACTY_CTYNM")]
		internal virtual DataGridViewTextBoxColumn MACTY_CTYNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACTY_FLDSZ")]
		internal virtual DataGridViewTextBoxColumn MACTY_FLDSZ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACTY_REMRK")]
		internal virtual DataGridViewTextBoxColumn MACTY_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LCTY_CFLD1")]
		internal virtual DataGridViewCheckBoxColumn LCTY_CFLD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LCTY_CFLDTITLE1")]
		internal virtual DataGridViewTextBoxColumn LCTY_CFLDTITLE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LCTY_CFLD2")]
		internal virtual DataGridViewCheckBoxColumn LCTY_CFLD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LCTY_CFLDTITLE2")]
		internal virtual DataGridViewTextBoxColumn LCTY_CFLDTITLE2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LCTY_NFLD1")]
		internal virtual DataGridViewCheckBoxColumn LCTY_NFLD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LCTY_NFLDTITLE1")]
		internal virtual DataGridViewTextBoxColumn LCTY_NFLDTITLE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LCTY_NFLD2")]
		internal virtual DataGridViewCheckBoxColumn LCTY_NFLD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("LCTY_NFLDTITLE2")]
		internal virtual DataGridViewTextBoxColumn LCTY_NFLDTITLE2
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

		[field: AccessedThroughProperty("cbCTYIDFR")]
		internal virtual ComboBox cbCTYIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAECTY()
		{
			base.FormClosing += frmMAECTY_FormClosing;
			base.Shown += frmMAECTY_Shown;
			base.Load += frmMAECTY_Load;
			base.KeyDown += frmMAECTY_KeyDown;
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
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.chkNFLD2 = new System.Windows.Forms.CheckBox();
			this.chkNFLD1 = new System.Windows.Forms.CheckBox();
			this.chkCFLD2 = new System.Windows.Forms.CheckBox();
			this.chkCFLD1 = new System.Windows.Forms.CheckBox();
			this.txtNFLDTITLE2 = new System.Windows.Forms.TextBox();
			this.txtNFLDTITLE1 = new System.Windows.Forms.TextBox();
			this.txtCFLDTITLE2 = new System.Windows.Forms.TextBox();
			this.txtCFLDTITLE1 = new System.Windows.Forms.TextBox();
			this.txtFLDSZ = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtCTYNM = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtCTYID = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.cbCTYIDFR = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.dgvMACTY = new System.Windows.Forms.DataGridView();
			this.MACTY_CTYID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACTY_CTYNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACTY_FLDSZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACTY_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LCTY_CFLD1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.LCTY_CFLDTITLE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LCTY_CFLD2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.LCTY_CFLDTITLE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LCTY_NFLD1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.LCTY_NFLDTITLE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LCTY_NFLD2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.LCTY_NFLDTITLE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.TableLayoutPanel2.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMACTY).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 2;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel2, 2);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Controls.Add(this.btnBack, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 318);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 1;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel2.TabIndex = 1;
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
			this.btnBack.TabIndex = 14;
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
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.chkNFLD2, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel2, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.chkNFLD1, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.chkCFLD2, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.chkCFLD1, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtNFLDTITLE2, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.txtNFLDTITLE1, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtCFLDTITLE2, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtCFLDTITLE1, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtFLDSZ, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtCTYNM, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtCTYID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 4);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 14;
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
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(469, 374);
			this.TableLayoutPanel1.TabIndex = 0;
			this.chkNFLD2.AutoSize = true;
			this.chkNFLD2.Location = new System.Drawing.Point(148, 252);
			this.chkNFLD2.Margin = new System.Windows.Forms.Padding(4);
			this.chkNFLD2.Name = "chkNFLD2";
			this.chkNFLD2.Size = new System.Drawing.Size(15, 14);
			this.chkNFLD2.TabIndex = 11;
			this.chkNFLD2.UseVisualStyleBackColor = true;
			this.chkNFLD1.AutoSize = true;
			this.chkNFLD1.Location = new System.Drawing.Point(148, 204);
			this.chkNFLD1.Margin = new System.Windows.Forms.Padding(4);
			this.chkNFLD1.Name = "chkNFLD1";
			this.chkNFLD1.Size = new System.Drawing.Size(15, 14);
			this.chkNFLD1.TabIndex = 9;
			this.chkNFLD1.UseVisualStyleBackColor = true;
			this.chkCFLD2.AutoSize = true;
			this.chkCFLD2.Location = new System.Drawing.Point(148, 156);
			this.chkCFLD2.Margin = new System.Windows.Forms.Padding(4);
			this.chkCFLD2.Name = "chkCFLD2";
			this.chkCFLD2.Size = new System.Drawing.Size(15, 14);
			this.chkCFLD2.TabIndex = 7;
			this.chkCFLD2.UseVisualStyleBackColor = true;
			this.chkCFLD1.AutoSize = true;
			this.chkCFLD1.Location = new System.Drawing.Point(148, 108);
			this.chkCFLD1.Margin = new System.Windows.Forms.Padding(4);
			this.chkCFLD1.Name = "chkCFLD1";
			this.chkCFLD1.Size = new System.Drawing.Size(15, 14);
			this.chkCFLD1.TabIndex = 5;
			this.chkCFLD1.UseVisualStyleBackColor = true;
			this.txtNFLDTITLE2.Location = new System.Drawing.Point(147, 272);
			this.txtNFLDTITLE2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNFLDTITLE2.Name = "txtNFLDTITLE2";
			this.txtNFLDTITLE2.Size = new System.Drawing.Size(319, 22);
			this.txtNFLDTITLE2.TabIndex = 12;
			this.txtNFLDTITLE1.Location = new System.Drawing.Point(147, 224);
			this.txtNFLDTITLE1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNFLDTITLE1.Name = "txtNFLDTITLE1";
			this.txtNFLDTITLE1.Size = new System.Drawing.Size(319, 22);
			this.txtNFLDTITLE1.TabIndex = 10;
			this.txtCFLDTITLE2.Location = new System.Drawing.Point(147, 176);
			this.txtCFLDTITLE2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCFLDTITLE2.Name = "txtCFLDTITLE2";
			this.txtCFLDTITLE2.Size = new System.Drawing.Size(319, 22);
			this.txtCFLDTITLE2.TabIndex = 8;
			this.txtCFLDTITLE1.Location = new System.Drawing.Point(147, 128);
			this.txtCFLDTITLE1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCFLDTITLE1.Name = "txtCFLDTITLE1";
			this.txtCFLDTITLE1.Size = new System.Drawing.Size(319, 22);
			this.txtCFLDTITLE1.TabIndex = 6;
			this.txtFLDSZ.Location = new System.Drawing.Point(147, 54);
			this.txtFLDSZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFLDSZ.Name = "txtFLDSZ";
			this.txtFLDSZ.Size = new System.Drawing.Size(319, 22);
			this.txtFLDSZ.TabIndex = 3;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 275);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(130, 16);
			this.Label13.TabIndex = 11;
			this.Label13.Text = "Numeric Field Title 2";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 83);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(56, 16);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Remark";
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(3, 251);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(129, 16);
			this.Label12.TabIndex = 10;
			this.Label12.Text = "Has Numeric Field 2";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 31);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(81, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Code Name";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 227);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(133, 16);
			this.Label11.TabIndex = 9;
			this.Label11.Text = "Numeric Field Tittle 1";
			this.txtCTYNM.Location = new System.Drawing.Point(147, 28);
			this.txtCTYNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCTYNM.Name = "txtCTYNM";
			this.txtCTYNM.Size = new System.Drawing.Size(319, 22);
			this.txtCTYNM.TabIndex = 2;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 203);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(129, 16);
			this.Label10.TabIndex = 8;
			this.Label10.Text = "Has Numeric Field 1";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(76, 16);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Code Type";
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 179);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(138, 16);
			this.Label9.TabIndex = 7;
			this.Label9.Text = "Character Field Title 2";
			this.txtCTYID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCTYID.Location = new System.Drawing.Point(147, 2);
			this.txtCTYID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCTYID.Name = "txtCTYID";
			this.txtCTYID.Size = new System.Drawing.Size(319, 22);
			this.txtCTYID.TabIndex = 1;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 155);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(137, 16);
			this.Label8.TabIndex = 6;
			this.Label8.Text = "Has Character Field 2";
			this.txtREMRK.Location = new System.Drawing.Point(147, 80);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(319, 22);
			this.txtREMRK.TabIndex = 4;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 131);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(138, 16);
			this.Label7.TabIndex = 5;
			this.Label7.Text = "Character Field Title 1";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 57);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(67, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Field Size";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 107);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(137, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Has Character Field 1";
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
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSearch.Location = new System.Drawing.Point(3, 2);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(120, 50);
			this.btnSearch.TabIndex = 3;
			this.btnSearch.Text = "Search";
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 2;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.cbCTYIDFR, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label6, 0, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(288, 30);
			this.TableLayoutPanel3.TabIndex = 1;
			this.cbCTYIDFR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCTYIDFR.FormattingEnabled = true;
			this.cbCTYIDFR.Location = new System.Drawing.Point(85, 3);
			this.cbCTYIDFR.Name = "cbCTYIDFR";
			this.cbCTYIDFR.Size = new System.Drawing.Size(200, 24);
			this.cbCTYIDFR.TabIndex = 6;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 7);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(76, 16);
			this.Label6.TabIndex = 1;
			this.Label6.Text = "Code Type";
			this.dgvMACTY.AllowUserToAddRows = false;
			this.dgvMACTY.AllowUserToDeleteRows = false;
			this.dgvMACTY.AllowUserToResizeRows = false;
			this.dgvMACTY.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMACTY.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMACTY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMACTY.Columns.AddRange(this.MACTY_CTYID, this.MACTY_CTYNM, this.MACTY_FLDSZ, this.MACTY_REMRK, this.LCTY_CFLD1, this.LCTY_CFLDTITLE1, this.LCTY_CFLD2, this.LCTY_CFLDTITLE2, this.LCTY_NFLD1, this.LCTY_NFLDTITLE1, this.LCTY_NFLD2, this.LCTY_NFLDTITLE2);
			this.dgvMACTY.Location = new System.Drawing.Point(5, 118);
			this.dgvMACTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMACTY.MultiSelect = false;
			this.dgvMACTY.Name = "dgvMACTY";
			this.dgvMACTY.ReadOnly = true;
			this.dgvMACTY.RowHeadersVisible = false;
			this.dgvMACTY.RowTemplate.Height = 24;
			this.dgvMACTY.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMACTY.Size = new System.Drawing.Size(1334, 504);
			this.dgvMACTY.TabIndex = 0;
			this.MACTY_CTYID.DataPropertyName = "MACTY_CTYID";
			this.MACTY_CTYID.HeaderText = "Code Type";
			this.MACTY_CTYID.Name = "MACTY_CTYID";
			this.MACTY_CTYID.ReadOnly = true;
			this.MACTY_CTYID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACTY_CTYID.Width = 150;
			this.MACTY_CTYNM.DataPropertyName = "MACTY_CTYNM";
			this.MACTY_CTYNM.HeaderText = "Code Name";
			this.MACTY_CTYNM.Name = "MACTY_CTYNM";
			this.MACTY_CTYNM.ReadOnly = true;
			this.MACTY_CTYNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACTY_CTYNM.Width = 200;
			this.MACTY_FLDSZ.DataPropertyName = "MACTY_FLDSZ";
			this.MACTY_FLDSZ.HeaderText = "Field Size";
			this.MACTY_FLDSZ.Name = "MACTY_FLDSZ";
			this.MACTY_FLDSZ.ReadOnly = true;
			this.MACTY_FLDSZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACTY_REMRK.DataPropertyName = "MACTY_REMRK";
			this.MACTY_REMRK.HeaderText = "Remark";
			this.MACTY_REMRK.Name = "MACTY_REMRK";
			this.MACTY_REMRK.ReadOnly = true;
			this.MACTY_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACTY_REMRK.Width = 250;
			this.LCTY_CFLD1.DataPropertyName = "LCTY_CFLD1";
			this.LCTY_CFLD1.HeaderText = "Has Character Field 1";
			this.LCTY_CFLD1.Name = "LCTY_CFLD1";
			this.LCTY_CFLD1.ReadOnly = true;
			this.LCTY_CFLDTITLE1.DataPropertyName = "LCTY_CFLDTITLE1";
			this.LCTY_CFLDTITLE1.HeaderText = "Character Field Title 1";
			this.LCTY_CFLDTITLE1.Name = "LCTY_CFLDTITLE1";
			this.LCTY_CFLDTITLE1.ReadOnly = true;
			this.LCTY_CFLDTITLE1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.LCTY_CFLD2.DataPropertyName = "LCTY_CFLD2";
			this.LCTY_CFLD2.HeaderText = "Has Character Field 2";
			this.LCTY_CFLD2.Name = "LCTY_CFLD2";
			this.LCTY_CFLD2.ReadOnly = true;
			this.LCTY_CFLDTITLE2.DataPropertyName = "LCTY_CFLDTITLE2";
			this.LCTY_CFLDTITLE2.HeaderText = "Character Field Title 2";
			this.LCTY_CFLDTITLE2.Name = "LCTY_CFLDTITLE2";
			this.LCTY_CFLDTITLE2.ReadOnly = true;
			this.LCTY_CFLDTITLE2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.LCTY_NFLD1.DataPropertyName = "LCTY_NFLD1";
			this.LCTY_NFLD1.HeaderText = "Has Numeric Field 1";
			this.LCTY_NFLD1.Name = "LCTY_NFLD1";
			this.LCTY_NFLD1.ReadOnly = true;
			this.LCTY_NFLDTITLE1.DataPropertyName = "LCTY_NFLDTITLE1";
			this.LCTY_NFLDTITLE1.HeaderText = "Numeric Field Title 1";
			this.LCTY_NFLDTITLE1.Name = "LCTY_NFLDTITLE1";
			this.LCTY_NFLDTITLE1.ReadOnly = true;
			this.LCTY_NFLDTITLE1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.LCTY_NFLD2.DataPropertyName = "LCTY_NFLD2";
			this.LCTY_NFLD2.HeaderText = "Has Numeric Field 2";
			this.LCTY_NFLD2.Name = "LCTY_NFLD2";
			this.LCTY_NFLD2.ReadOnly = true;
			this.LCTY_NFLDTITLE2.DataPropertyName = "LCTY_NFLDTITLE2";
			this.LCTY_NFLDTITLE2.HeaderText = "Numeric Field Title 2";
			this.LCTY_NFLDTITLE2.Name = "LCTY_NFLDTITLE2";
			this.LCTY_NFLDTITLE2.ReadOnly = true;
			this.LCTY_NFLDTITLE2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 2;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel3);
			this.Panel2.Controls.Add(this.dgvMACTY);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 630);
			this.Panel2.TabIndex = 5;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSearch, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 59);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel4.TabIndex = 5;
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
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAECTY";
			base.Tag = "MAECTY";
			this.Text = "Code Type";
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMACTY).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			spMAECTY();
		}

		private bool spMAECTY()
		{
			bool spMAECTY = default(bool);
			if (ValidateDetailControl())
			{
				string strSQL = "EXEC spMAECTY ";
				strSQL = strSQL + "'" + txtCTYID.Text + "', ";
				strSQL = strSQL + "'" + txtCTYNM.Text + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(txtFLDSZ.Text)) + "', ";
				strSQL = strSQL + "'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(chkCFLD1.Checked) + "', ";
				strSQL = strSQL + "'" + txtCFLDTITLE1.Text + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(chkCFLD2.Checked) + "', ";
				strSQL = strSQL + "'" + txtCFLDTITLE2.Text + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(chkNFLD1.Checked) + "', ";
				strSQL = strSQL + "'" + txtNFLDTITLE1.Text + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(chkNFLD2.Checked) + "', ";
				strSQL = strSQL + "'" + txtNFLDTITLE2.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
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
					spMAECTY = false;
					ProjectData.ClearProjectError();
					goto IL_0231;
				}
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record saved!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Header();
				ClearDetailsControl();
				spMAECTY = true;
			}
			goto IL_0231;
			IL_0231:
			return spMAECTY;
		}

		public bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtCTYID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Code type cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCTYID.Select();
				return false;
			}
			string strSQL = "SELECT MACTY_CTYID FROM MACTY_TBL WHERE MACTY_CTYID = '" + txtCTYID.Text + "'";
			if (Operators.CompareString(btnSave.Text, "Save", false) == 0 && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Code type already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCTYID.Select();
				return false;
			}
			return true;
		}

		private void SetMaxLength()
		{
			cbCTYIDFR.MaxLength = DB.CharColumnMaxLength("MACTY_TBL", "MACTY_CTYID");
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
		}

		private void Header()
		{
			string strSQL;
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(cbCTYIDFR.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				strSQL = "SELECT MACTY_CTYID, MACTY_CTYNM, MACTY_FLDSZ, MACTY_REMRK, LCTY_CFLD1, ";
				strSQL += "LCTY_CFLDTITLE1, LCTY_CFLD2, LCTY_CFLDTITLE2, LCTY_NFLD1, LCTY_NFLDTITLE1, ";
				strSQL += "LCTY_NFLD2, LCTY_NFLDTITLE2 ";
				strSQL += "FROM MACTY_TBL ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MACTY_CTYID = '", cbCTYIDFR.SelectedValue), "'")));
				strSQL += "ORDER BY MACTY_CTYID";
			}
			else
			{
				strSQL = "SELECT MACTY_CTYID, MACTY_CTYNM, MACTY_FLDSZ, MACTY_REMRK, LCTY_CFLD1, ";
				strSQL += "LCTY_CFLDTITLE1, LCTY_CFLD2, LCTY_CFLDTITLE2, LCTY_NFLD1, LCTY_NFLDTITLE1, ";
				strSQL += "LCTY_NFLD2, LCTY_NFLDTITLE2 ";
				strSQL += "FROM MACTY_TBL ";
				strSQL += "ORDER BY MACTY_CTYID";
			}
			try
			{
				DataTable DT = DB.ExecProc(strSQL);
				dgvMACTY.ClearSelection();
				dgvMACTY.DataSource = DT;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			Panel1.Visible = false;
			Panel2.Visible = true;
		}

		private void frmMAECTY_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAECTY_Shown(object sender, EventArgs e)
		{
			Header();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		public void ClearDetailsControl()
		{
			txtCTYID.Text = string.Empty;
			txtCTYNM.Text = string.Empty;
			txtFLDSZ.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			chkCFLD1.Checked = false;
			txtCFLDTITLE1.Text = string.Empty;
			chkCFLD2.Checked = false;
			txtCFLDTITLE2.Text = string.Empty;
			chkNFLD1.Checked = false;
			txtNFLDTITLE1.Text = string.Empty;
			chkNFLD2.Checked = false;
			txtNFLDTITLE2.Text = string.Empty;
			txtCTYID.Enabled = true;
			btnSave.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Save");
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetailsControl();
			Header();
		}

		public void BindGridtoControl()
		{
			txtCTYID.Text = dgvMACTY.CurrentRow.Cells["MACTY_CTYID"].Value.ToString();
			txtCTYNM.Text = dgvMACTY.CurrentRow.Cells["MACTY_CTYNM"].Value.ToString();
			txtFLDSZ.Text = dgvMACTY.CurrentRow.Cells["MACTY_FLDSZ"].Value.ToString();
			txtREMRK.Text = dgvMACTY.CurrentRow.Cells["MACTY_REMRK"].Value.ToString();
			chkCFLD1.Checked = Conversions.ToBoolean(dgvMACTY.CurrentRow.Cells["LCTY_CFLD1"].Value.ToString());
			txtCFLDTITLE1.Text = dgvMACTY.CurrentRow.Cells["LCTY_CFLDTITLE1"].Value.ToString();
			chkCFLD2.Checked = Conversions.ToBoolean(dgvMACTY.CurrentRow.Cells["LCTY_CFLD2"].Value.ToString());
			txtCFLDTITLE2.Text = dgvMACTY.CurrentRow.Cells["LCTY_CFLDTITLE2"].Value.ToString();
			chkNFLD1.Checked = Conversions.ToBoolean(dgvMACTY.CurrentRow.Cells["LCTY_NFLD1"].Value.ToString());
			txtNFLDTITLE1.Text = dgvMACTY.CurrentRow.Cells["LCTY_NFLDTITLE1"].Value.ToString();
			chkNFLD2.Checked = Conversions.ToBoolean(dgvMACTY.CurrentRow.Cells["LCTY_NFLD2"].Value.ToString());
			txtNFLDTITLE2.Text = dgvMACTY.CurrentRow.Cells["LCTY_NFLDTITLE2"].Value.ToString();
		}

		private void dgvMACTY_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
			txtCTYID.Enabled = false;
			btnSave.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Update");
			Panel1.Visible = true;
			Panel2.Visible = false;
		}

		private void frmMAECTY_Load(object sender, EventArgs e)
		{
			SetMaxLength();
			BindComboBox();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAECTY_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}
	}
}
