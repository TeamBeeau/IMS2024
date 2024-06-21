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
	public class frmPDERDO : Form
	{
		private IContainer components;

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
		[AccessedThroughProperty("dgvPDRDO")]
		private DataGridView _dgvPDRDO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

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
		[AccessedThroughProperty("btnCONFIRM")]
		private Button _btnCONFIRM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSID")]
		private ComboBox _cbCUSID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnOFFICIALDO")]
		private Button _btnOFFICIALDO;

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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
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

		[field: AccessedThroughProperty("Label21")]
		internal virtual Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label20")]
		internal virtual Label Label20
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

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbHMDLCD")]
		internal virtual ComboboxControl cbHMDLCD
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

		[field: AccessedThroughProperty("cboSTSFG")]
		internal virtual ComboBox cboSTSFG
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
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

		internal virtual DataGridView dgvPDRDO
		{
			[CompilerGenerated]
			get
			{
				return _dgvPDRDO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvPDRDO_CellMouseClick;
				DataGridView dataGridView = _dgvPDRDO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvPDRDO = value;
				dataGridView = _dgvPDRDO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("dtpDOCDT")]
		internal virtual DateTimePicker dtpDOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSTSFG")]
		internal virtual TextBox txtSTSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSAVE
		{
			[CompilerGenerated]
			get
			{
				return _btnSAVE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSave_Click;
				Button button = _btnSAVE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSAVE = value;
				button = _btnSAVE;
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

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbLOCID")]
		internal virtual ComboBox cbLOCID
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

		internal virtual Button btnCONFIRM
		{
			[CompilerGenerated]
			get
			{
				return _btnCONFIRM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCONFIRM_Click;
				Button button = _btnCONFIRM;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCONFIRM = value;
				button = _btnCONFIRM;
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

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbCUSID
		{
			[CompilerGenerated]
			get
			{
				return _cbCUSID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbCUSID_SelectedIndexChanged;
				ComboBox comboBox = _cbCUSID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbCUSID = value;
				comboBox = _cbCUSID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnOFFICIALDO
		{
			[CompilerGenerated]
			get
			{
				return _btnOFFICIALDO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnOFFICIALDO_Click;
				Button button = _btnOFFICIALDO;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnOFFICIALDO = value;
				button = _btnOFFICIALDO;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label18")]
		internal virtual Label Label18
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

		[field: AccessedThroughProperty("cbDRIVER")]
		internal virtual ComboBox cbDRIVER
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbTRUCK")]
		internal virtual ComboBox cbTRUCK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPDERDO()
		{
			base.FormClosing += frmPDERDO_FormClosing;
			base.Shown += frmPDERDO_Shown;
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
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Label9 = new System.Windows.Forms.Label();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.cbHMDLCD = new IMS.ComboboxControl();
			this.Label11 = new System.Windows.Forms.Label();
			this.cboSTSFG = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.cbCUSID = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.dgvPDRDO = new System.Windows.Forms.DataGridView();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtSTSFG = new System.Windows.Forms.TextBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.cbDRIVER = new System.Windows.Forms.ComboBox();
			this.cbTRUCK = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCONFIRM = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnOFFICIALDO = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPDRDO).BeginInit();
			this.TableLayoutPanel5.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(2, 1);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1344, 627);
			this.Panel2.TabIndex = 4;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(6, 148);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1328, 471);
			this.dgvHEADER.TabIndex = 0;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(6, 91);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel4.TabIndex = 9;
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
			this.btnNew.TabIndex = 12;
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
			this.btnSEARCH.TabIndex = 8;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
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
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.Label9, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label21, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label20, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbHMDLCD, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label11, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.cboSTSFG, 3, 2);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(6, 3);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(823, 86);
			this.TableLayoutPanel2.TabIndex = 1;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 63);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(82, 16);
			this.Label9.TabIndex = 51;
			this.Label9.Text = "Model Code";
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(494, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(325, 25);
			this.cbDOCNOTO.TabIndex = 50;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(110, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(325, 26);
			this.cbDOCNOFR.TabIndex = 10;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(442, 7);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(25, 16);
			this.Label21.TabIndex = 5;
			this.Label21.Text = "To";
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(3, 7);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(93, 16);
			this.Label20.TabIndex = 2;
			this.Label20.Text = "Document  No";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 35);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(110, 32);
			this.dtpDOCDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 5;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(442, 35);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(493, 32);
			this.dtpDOCDTTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 6;
			this.cbHMDLCD.BlankValue = null;
			this.cbHMDLCD.ComboboxWidth = 170;
			this.cbHMDLCD.DataTable = null;
			this.cbHMDLCD.DisplayMember = null;
			this.cbHMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHMDLCD.HasBlankValue = true;
			this.cbHMDLCD.Location = new System.Drawing.Point(111, 58);
			this.cbHMDLCD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbHMDLCD.Name = "cbHMDLCD";
			this.cbHMDLCD.SelectedIndex = -1;
			this.cbHMDLCD.SelectedItem = null;
			this.cbHMDLCD.SelectedValue = null;
			this.cbHMDLCD.Size = new System.Drawing.Size(324, 26);
			this.cbHMDLCD.TabIndex = 52;
			this.cbHMDLCD.TextMultiline = true;
			this.cbHMDLCD.ValueMember = null;
			this.cbHMDLCD.WhereClause = null;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(442, 63);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(45, 16);
			this.Label11.TabIndex = 53;
			this.Label11.Text = "Status";
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[3] { "Pending", "Confirmed", "All" });
			this.cboSTSFG.Location = new System.Drawing.Point(493, 59);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(170, 24);
			this.cboSTSFG.TabIndex = 54;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 7;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label16, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbCUSID, 5, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.dgvPDRDO, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtSTSFG, 6, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label18, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 4, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbDRIVER, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbTRUCK, 5, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(11, 65);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 6;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1235, 537);
			this.TableLayoutPanel1.TabIndex = 0;
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 4);
			this.txtREMRK.Location = new System.Drawing.Point(99, 88);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(461, 65);
			this.txtREMRK.TabIndex = 96;
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(305, 5);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(101, 16);
			this.Label16.TabIndex = 48;
			this.Label16.Text = "Document Date";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 5);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.TableLayoutPanel1.SetColumnSpan(this.txtDOCNO, 2);
			this.txtDOCNO.Location = new System.Drawing.Point(99, 2);
			this.txtDOCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.ReadOnly = true;
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Enabled = false;
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(566, 2);
			this.dtpDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 3;
			this.cbCUSID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.FormattingEnabled = true;
			this.cbCUSID.Location = new System.Drawing.Point(566, 29);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.Size = new System.Drawing.Size(173, 24);
			this.cbCUSID.TabIndex = 93;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(305, 33);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(65, 16);
			this.Label3.TabIndex = 92;
			this.Label3.Text = "Customer";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 33);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(59, 16);
			this.Label5.TabIndex = 79;
			this.Label5.Text = "Location";
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(99, 29);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(173, 24);
			this.cbLOCID.TabIndex = 94;
			this.dgvPDRDO.AllowUserToAddRows = false;
			this.dgvPDRDO.AllowUserToDeleteRows = false;
			this.dgvPDRDO.AllowUserToResizeRows = false;
			this.dgvPDRDO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPDRDO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvPDRDO, 7);
			this.dgvPDRDO.EnableHeadersVisualStyles = false;
			this.dgvPDRDO.Location = new System.Drawing.Point(3, 158);
			this.dgvPDRDO.MultiSelect = false;
			this.dgvPDRDO.Name = "dgvPDRDO";
			this.dgvPDRDO.RowHeadersVisible = false;
			this.dgvPDRDO.RowHeadersWidth = 51;
			this.dgvPDRDO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPDRDO.Size = new System.Drawing.Size(1229, 376);
			this.dgvPDRDO.TabIndex = 16;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(4, 112);
			this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(57, 17);
			this.Label6.TabIndex = 95;
			this.Label6.Text = "Remark";
			this.txtSTSFG.Location = new System.Drawing.Point(745, 29);
			this.txtSTSFG.Name = "txtSTSFG";
			this.txtSTSFG.Size = new System.Drawing.Size(41, 22);
			this.txtSTSFG.TabIndex = 76;
			this.txtSTSFG.Text = "-1";
			this.txtSTSFG.Visible = false;
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(3, 63);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(44, 16);
			this.Label18.TabIndex = 97;
			this.Label18.Text = "Driver";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(305, 63);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(52, 16);
			this.Label7.TabIndex = 98;
			this.Label7.Text = "Truck #";
			this.cbDRIVER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDRIVER.FormattingEnabled = true;
			this.cbDRIVER.Location = new System.Drawing.Point(99, 59);
			this.cbDRIVER.Name = "cbDRIVER";
			this.cbDRIVER.Size = new System.Drawing.Size(164, 24);
			this.cbDRIVER.TabIndex = 99;
			this.cbTRUCK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTRUCK.FormattingEnabled = true;
			this.cbTRUCK.Location = new System.Drawing.Point(566, 59);
			this.cbTRUCK.Name = "cbTRUCK";
			this.cbTRUCK.Size = new System.Drawing.Size(164, 24);
			this.cbTRUCK.TabIndex = 100;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 5;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnBack, 4, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnCONFIRM, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnREMOVE, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnOFFICIALDO, 3, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(9, 5);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(636, 56);
			this.TableLayoutPanel5.TabIndex = 87;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(4, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 12;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(513, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 19;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnCONFIRM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCONFIRM.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCONFIRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCONFIRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCONFIRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnCONFIRM.Image = IMS.My.Resources.Resources.Save;
			this.btnCONFIRM.Location = new System.Drawing.Point(132, 2);
			this.btnCONFIRM.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCONFIRM.Name = "btnCONFIRM";
			this.btnCONFIRM.Size = new System.Drawing.Size(120, 50);
			this.btnCONFIRM.TabIndex = 20;
			this.btnCONFIRM.Text = "Confirm";
			this.btnCONFIRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCONFIRM.UseVisualStyleBackColor = false;
			this.btnREMOVE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(260, 3);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 13;
			this.btnREMOVE.Text = "Delete";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.btnOFFICIALDO.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnOFFICIALDO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnOFFICIALDO.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnOFFICIALDO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnOFFICIALDO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOFFICIALDO.Image = IMS.My.Resources.Resources.Print;
			this.btnOFFICIALDO.Location = new System.Drawing.Point(387, 3);
			this.btnOFFICIALDO.Name = "btnOFFICIALDO";
			this.btnOFFICIALDO.Size = new System.Drawing.Size(120, 50);
			this.btnOFFICIALDO.TabIndex = 24;
			this.btnOFFICIALDO.Text = "Official DO";
			this.btnOFFICIALDO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOFFICIALDO.UseVisualStyleBackColor = false;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel5);
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(2, 1);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 3;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPDERDO";
			base.Tag = "PDERDO";
			this.Text = "Customer Return Delivery Order";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPDRDO).EndInit();
			this.TableLayoutPanel5.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPDERDO_FormClosing(object sender, FormClosingEventArgs e)
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

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH (NOLOCK) ";
			strSQL += "WHERE MALOC_LOCTY = 'RTN' ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			strSQL = "SELECT MACUS_CUSID, MACUS_SHORT ";
			strSQL += "FROM MACUS_TBL WITH (NOLOCK) ";
			strSQL += "ORDER BY MACUS_CUSID ";
			cbCUSID.ValueMember = "MACUS_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			Common.RetriveComboItembySQL(strSQL, cbCUSID);
			strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION ";
			strSQL += "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'DRIVER' ORDER BY MACOD_CODID";
			cbDRIVER.ValueMember = "MACOD_CODID";
			cbDRIVER.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbDRIVER);
			strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION ";
			strSQL += "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'TRUCK' ORDER BY MACOD_CODID";
			cbTRUCK.ValueMember = "MACOD_CODID";
			cbTRUCK.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbTRUCK);
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "PDRDO_TBL WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "PDRDO_DOCNO";
			cbDOCNOFR.DisplayMember = "PDRDO_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "PDRDO_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "PDRDO_DOCNO";
			cbDOCNOTO.DisplayMember = "PDRDO_DOCNO";
			cbDOCNOTO.LoadData();
			cbHMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK)";
			cbHMDLCD.WhereClause = "MAITM_ITMTY = 1 AND MAITM_ACTFG = -1";
			cbHMDLCD.ValueMember = "MAITM_ITMCD";
			cbHMDLCD.DisplayMember = "MAITM_ITMCD";
			cbHMDLCD.LoadData();
		}

		private void frmPDERDO_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Today.AddDays(-7.0);
			BindComboHeader();
			cboSTSFG.SelectedIndex = 0;
			Header();
		}

		private void Header()
		{
			int i = 0;
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spPDRDO 0, ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHMDLCD.SelectedValue)) + "', ";
			strSQL += Conversions.ToString(cboSTSFG.SelectedIndex);
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Driver");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Truck");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 200;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remarks");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindComboBox();
			BindGridHeader();
			EnableButton();
			Panel2.Visible = false;
			Panel1.Visible = true;
		}

		private void BindGridHeader()
		{
			txtDOCNO.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDRDO_DOCNO"].Value);
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PDRDO_DOCDT"].Value);
			cbCUSID.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDRDO_CUSID"].Value);
			cbDRIVER.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDRDO_DRIVER"].Value);
			cbTRUCK.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDRDO_TRUCK"].Value);
			txtREMRK.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDRDO_REMRK"].Value);
			txtSTSFG.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDRDO_STSFG"].Value);
			BindGrid();
			EnableControl();
		}

		private void EnableControl()
		{
			if (Conversions.ToDouble(txtSTSFG.Text) == 1.0)
			{
				btnSAVE.Enabled = false;
				btnCONFIRM.Enabled = false;
				btnREMOVE.Enabled = false;
				txtDOCNO.ReadOnly = true;
				dtpDOCDT.Enabled = false;
				cbLOCID.Enabled = false;
				cbCUSID.Enabled = false;
				dgvPDRDO.ReadOnly = true;
			}
			else
			{
				btnSAVE.Enabled = true;
				btnCONFIRM.Enabled = true;
				btnREMOVE.Enabled = true;
				txtDOCNO.ReadOnly = false;
				dtpDOCDT.Enabled = true;
				cbLOCID.Enabled = true;
				cbCUSID.Enabled = true;
				dgvPDRDO.ReadOnly = false;
			}
		}

		private void cbCUSID_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindGrid();
		}

		private void BindGrid()
		{
			int i = 0;
			dgvPDRDO.DataSource = null;
			string strSQL = "EXEC spPDRDO_Grid '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "'";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvPDRDO;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 30;
					dataGridView.Columns[i].HeaderText = "";
					dataGridView.Columns[i].ReadOnly = false;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Return Doc No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Return Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Return Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Return Lot No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FGR Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			BindComboHeader();
			Header();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (spPDERDO(0))
			{
			}
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			if (spPDERDO(1))
			{
			}
		}

		private bool spPDERDO(int intOption)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDERDO'"));
			bool spPDERDO;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PDERDO", "DOCNO", ref strNextNo))
					{
						MessageBox.Show("Document No cannot blank! Please check document number control.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spPDERDO = false;
						goto IL_02e6;
					}
					txtDOCNO.Text = strNextNo;
				}
			}
			else
			{
				txtDOCNO.Enabled = true;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					MessageBox.Show("Document No cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					txtDOCNO.Focus();
					spPDERDO = false;
					goto IL_02e6;
				}
			}
			strSQL = "EXEC spPDERDO " + Conversions.ToString(intOption) + ", ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDRIVER.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbTRUCK.SelectedValue), "', ")));
			strSQL = strSQL + "'" + txtREMRK.Text + "', ";
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
				spPDERDO = false;
				ProjectData.ClearProjectError();
				goto IL_02e6;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			spPDERDO = true;
			goto IL_02e6;
			IL_02e6:
			return spPDERDO;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			ClearControl();
			EnableButton();
			ManageOrderNo();
			BindComboBox();
		}

		private void EnableButton()
		{
			string left = txtSTSFG.Text;
			if (Operators.CompareString(left, Conversions.ToString(-1), false) == 0)
			{
				btnSAVE.Enabled = true;
				btnCONFIRM.Enabled = false;
				btnREMOVE.Enabled = false;
			}
			else if (Operators.CompareString(left, Conversions.ToString(0), false) == 0)
			{
				btnSAVE.Enabled = true;
				btnCONFIRM.Enabled = true;
				btnREMOVE.Enabled = true;
			}
			else if (Operators.CompareString(left, Conversions.ToString(1), false) == 0)
			{
				btnSAVE.Enabled = false;
				btnCONFIRM.Enabled = false;
				btnREMOVE.Enabled = false;
			}
		}

		private void ClearControl()
		{
			dgvPDRDO.DataSource = null;
			txtDOCNO.Text = string.Empty;
			dtpDOCDT.Value = DateTime.Now;
			dtpDOCDT.Enabled = true;
			txtDOCNO.Enabled = true;
			cbLOCID.Enabled = true;
			txtSTSFG.Text = Conversions.ToString(-1);
			txtREMRK.Text = string.Empty;
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDERDO'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private void dgvPDRDO_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dgvPDRDO.Rows.Count != 0 && !dgvPDRDO.Columns["PDRDO_CHK"].ReadOnly && dgvPDRDO.CurrentCell.ColumnIndex == 1)
			{
				if (Operators.ConditionalCompareObjectEqual(dgvPDRDO.CurrentRow.Cells["PDRDO_CHK"].Value, 0, false))
				{
					dgvPDRDO.CurrentRow.Cells["PDRDO_CHK"].Value = 1;
				}
				else
				{
					dgvPDRDO.CurrentRow.Cells["PDRDO_CHK"].Value = 0;
				}
				string strSQL = "EXEC spPDRDO_CHK '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(dgvPDRDO.CurrentRow.Cells["PDRDO_RTNID"].Value, ", ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, dgvPDRDO.CurrentRow.Cells["PDRDO_CHK"].Value));
				DB.ExecProc(strSQL);
			}
		}

		private void btnCONFIRM_Click(object sender, EventArgs e)
		{
			if (spPDERDO(2))
			{
				Header();
			}
		}

		private void btnOFFICIALDO_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "DELIVERY ORDER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDRDO.rpt";
			frmRPT.Params = "@DOCNO=" + txtDOCNO.Text;
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='DELIVERY ORDER',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.CustomPaperSize = "TDD_DO";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}
	}
}
