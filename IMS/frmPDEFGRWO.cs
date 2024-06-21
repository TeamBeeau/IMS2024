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
using Spire.Barcode;

namespace IMS
{
    [DesignerGenerated]
	public class frmPDEFGRWO : Form
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
		[AccessedThroughProperty("dgvPDRWO")]
		private DataGridView _dgvPDRWO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbMDLCD")]
		private ComboboxControl _cbMDLCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbREVNO")]
		private ComboBox _cbREVNO;

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
		[AccessedThroughProperty("cbLOCID")]
		private ComboBox _cbLOCID;

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
		[AccessedThroughProperty("btnPrint")]
		private Button _btnPrint;

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

		internal virtual DataGridView dgvPDRWO
		{
			[CompilerGenerated]
			get
			{
				return _dgvPDRWO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvPDRWO_CellMouseClick;
				DataGridView dataGridView = _dgvPDRWO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvPDRWO = value;
				dataGridView = _dgvPDRWO;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lblMDLCD")]
		internal virtual Label lblMDLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblREVNO")]
		internal virtual Label lblREVNO
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

		[field: AccessedThroughProperty("lblQTY")]
		internal virtual Label lblQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numWOQTY")]
		internal virtual NumControl numWOQTY
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

		internal virtual ComboboxControl cbMDLCD
		{
			[CompilerGenerated]
			get
			{
				return _cbMDLCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbMDLCD_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbMDLCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbMDLCD = value;
				comboboxControl = _cbMDLCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		internal virtual ComboBox cbREVNO
		{
			[CompilerGenerated]
			get
			{
				return _cbREVNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbREVNO_SelectedIndexChanged;
				ComboBox comboBox = _cbREVNO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbREVNO = value;
				comboBox = _cbREVNO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
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

		internal virtual ComboBox cbLOCID
		{
			[CompilerGenerated]
			get
			{
				return _cbLOCID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbLOCID_SelectedIndexChanged;
				ComboBox comboBox = _cbLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbLOCID = value;
				comboBox = _cbLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
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

		internal virtual Button btnPrint
		{
			[CompilerGenerated]
			get
			{
				return _btnPrint;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPrint_Click;
				Button button = _btnPrint;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPrint = value;
				button = _btnPrint;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public frmPDEFGRWO()
		{
			base.FormClosing += frmPDEFGRWO_FormClosing;
			base.Shown += frmPDEFGRWO_Shown;
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
			this.lblMDLCD = new System.Windows.Forms.Label();
			this.lblREVNO = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.txtSTSFG = new System.Windows.Forms.TextBox();
			this.cbMDLCD = new IMS.ComboboxControl();
			this.cbREVNO = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.lblQTY = new System.Windows.Forms.Label();
			this.dgvPDRWO = new System.Windows.Forms.DataGridView();
			this.Label6 = new System.Windows.Forms.Label();
			this.numWOQTY = new IMS.NumControl();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCONFIRM = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPDRWO).BeginInit();
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
			this.TableLayoutPanel1.Controls.Add(this.lblMDLCD, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblREVNO, 4, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtSTSFG, 6, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbMDLCD, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbREVNO, 5, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblQTY, 5, 5);
			this.TableLayoutPanel1.Controls.Add(this.dgvPDRWO, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.numWOQTY, 6, 5);
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
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1026, 564);
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
			this.Label16.Location = new System.Drawing.Point(448, 5);
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
			this.lblMDLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMDLCD.AutoSize = true;
			this.lblMDLCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMDLCD.Location = new System.Drawing.Point(3, 63);
			this.lblMDLCD.Name = "lblMDLCD";
			this.lblMDLCD.Size = new System.Drawing.Size(82, 16);
			this.lblMDLCD.TabIndex = 9;
			this.lblMDLCD.Text = "Model Code";
			this.lblREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREVNO.AutoSize = true;
			this.lblREVNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREVNO.Location = new System.Drawing.Point(448, 63);
			this.lblREVNO.Name = "lblREVNO";
			this.lblREVNO.Size = new System.Drawing.Size(61, 16);
			this.lblREVNO.TabIndex = 47;
			this.lblREVNO.Text = "Revision";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Enabled = false;
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(566, 2);
			this.dtpDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 3;
			this.txtSTSFG.Location = new System.Drawing.Point(676, 59);
			this.txtSTSFG.Name = "txtSTSFG";
			this.txtSTSFG.Size = new System.Drawing.Size(41, 22);
			this.txtSTSFG.TabIndex = 76;
			this.txtSTSFG.Text = "-1";
			this.txtSTSFG.Visible = false;
			this.cbMDLCD.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbMDLCD, 2);
			this.cbMDLCD.ComboboxWidth = 170;
			this.cbMDLCD.DataTable = null;
			this.cbMDLCD.DisplayMember = null;
			this.cbMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCD.HasBlankValue = false;
			this.cbMDLCD.Location = new System.Drawing.Point(99, 58);
			this.cbMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbMDLCD.Name = "cbMDLCD";
			this.cbMDLCD.SelectedIndex = -1;
			this.cbMDLCD.SelectedItem = null;
			this.cbMDLCD.SelectedValue = null;
			this.cbMDLCD.Size = new System.Drawing.Size(323, 25);
			this.cbMDLCD.TabIndex = 80;
			this.cbMDLCD.TextMultiline = true;
			this.cbMDLCD.ValueMember = null;
			this.cbMDLCD.WhereClause = null;
			this.cbREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbREVNO.FormattingEnabled = true;
			this.cbREVNO.Location = new System.Drawing.Point(566, 59);
			this.cbREVNO.Name = "cbREVNO";
			this.cbREVNO.Size = new System.Drawing.Size(104, 24);
			this.cbREVNO.TabIndex = 91;
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
			this.lblQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblQTY.AutoSize = true;
			this.lblQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQTY.Location = new System.Drawing.Point(567, 542);
			this.lblQTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQTY.Name = "lblQTY";
			this.lblQTY.Size = new System.Drawing.Size(89, 17);
			this.lblQTY.TabIndex = 85;
			this.lblQTY.Text = "WO Quantity";
			this.dgvPDRWO.AllowUserToAddRows = false;
			this.dgvPDRWO.AllowUserToDeleteRows = false;
			this.dgvPDRWO.AllowUserToResizeRows = false;
			this.dgvPDRWO.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPDRWO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvPDRWO, 7);
			this.dgvPDRWO.EnableHeadersVisualStyles = false;
			this.dgvPDRWO.Location = new System.Drawing.Point(3, 158);
			this.dgvPDRWO.MultiSelect = false;
			this.dgvPDRWO.Name = "dgvPDRWO";
			this.dgvPDRWO.RowHeadersVisible = false;
			this.dgvPDRWO.RowHeadersWidth = 51;
			this.dgvPDRWO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPDRWO.Size = new System.Drawing.Size(1020, 376);
			this.dgvPDRWO.TabIndex = 16;
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
			this.numWOQTY.AllowNegative = false;
			this.numWOQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWOQTY.DataChanged = false;
			this.numWOQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numWOQTY.Location = new System.Drawing.Point(677, 539);
			this.numWOQTY.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numWOQTY.Name = "numWOQTY";
			this.numWOQTY.NumberFormat = "";
			this.numWOQTY.ReadOnly = true;
			this.numWOQTY.Size = new System.Drawing.Size(91, 23);
			this.numWOQTY.TabIndex = 86;
			this.numWOQTY.Text = "0.00";
			this.numWOQTY.ThousandSeperator = false;
			this.numWOQTY.Value = 0.0;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 5;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnCONFIRM, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnREMOVE, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnBack, 4, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnPrint, 3, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(9, 5);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(636, 54);
			this.TableLayoutPanel5.TabIndex = 87;
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
			this.btnREMOVE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(260, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 13;
			this.btnREMOVE.Text = "Delete";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
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
			this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Image = IMS.My.Resources.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(387, 2);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(120, 50);
			this.btnPrint.TabIndex = 21;
			this.btnPrint.Text = "Print";
			this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrint.UseVisualStyleBackColor = false;
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
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPDEFGRWO";
			base.Tag = "PDEFGRWO";
			this.Text = "Finished Goods Repair Work Order";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPDRWO).EndInit();
			this.TableLayoutPanel5.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPDEFGRWO_FormClosing(object sender, FormClosingEventArgs e)
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

		private void BindComboBox(string strOption)
		{
			if (Operators.CompareString(strOption, "LOCID", false) == 0)
			{
				string strSQL = "SELECT MALOC_LOCID, MALOC_LOCNM ";
				strSQL += "FROM MALOC_TBL WITH (NOLOCK) ";
				strSQL += "WHERE MALOC_LOCTY = 'REPAIR' ";
				strSQL += "ORDER BY MALOC_LOCID ";
				cbLOCID.ValueMember = "MALOC_LOCID";
				cbLOCID.DisplayMember = "MALOC_LOCNM";
				Common.RetriveComboItembySQL(strSQL, cbLOCID);
			}
			if (Operators.CompareString(strOption, "MDLCD", false) == 0)
			{
				cbMDLCD.DataTable = "MABOM_TBL WITH (NOLOCK) ";
				cbMDLCD.ValueMember = "MABOM_MDLCD";
				cbMDLCD.DisplayMember = "MABOM_MDLCD";
				cbMDLCD.LoadData();
			}
			if (Operators.CompareString(strOption, "REVNO", false) == 0)
			{
				string strSQL = "SELECT DISTINCT MABOM_REVNO ";
				strSQL += "FROM MABOM_TBL WITH (NOLOCK) ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABOM_MDLCD = '", cbMDLCD.SelectedValue), "'")));
				cbREVNO.ValueMember = "MABOM_REVNO";
				cbREVNO.DisplayMember = "MABOM_REVNO";
				Common.RetriveComboItembySQL(strSQL, cbREVNO);
			}
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "PDRWO_TBL WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "PDRWO_WKONO";
			cbDOCNOFR.DisplayMember = "PDRWO_WKONO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "PDRWO_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "PDRWO_WKONO";
			cbDOCNOTO.DisplayMember = "PDRWO_WKONO";
			cbDOCNOTO.LoadData();
			cbHMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK)";
			cbHMDLCD.WhereClause = "MAITM_ITMTY = 1 AND MAITM_ACTFG = -1";
			cbHMDLCD.ValueMember = "MAITM_ITMCD";
			cbHMDLCD.DisplayMember = "MAITM_ITMCD";
			cbHMDLCD.LoadData();
		}

		private void frmPDEFGRWO_Shown(object sender, EventArgs e)
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
			string strSQL = "EXEC spPDFGRWO ";
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
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WO Quantity");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 200;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remarks");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
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
			BindComboBox("");
			BindGridHeader();
			EnableButton();
			Panel2.Visible = false;
			Panel1.Visible = true;
		}

		private void BindGridHeader()
		{
			txtDOCNO.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDRWO_WKONO"].Value);
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PDRWO_WKODT"].Value);
			cbMDLCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDRWO_MDLCD"].Value);
			cbREVNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvHEADER.CurrentRow.Cells["PDRWO_REVNO"].Value);
			txtREMRK.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDRWO_REMRK"].Value);
			numWOQTY.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["PDRWO_WOQTY"].Value);
			txtSTSFG.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDRWO_STSFG"].Value);
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
				cbMDLCD.Enabled = false;
				cbREVNO.Enabled = false;
				dgvPDRWO.ReadOnly = true;
			}
			else
			{
				btnSAVE.Enabled = true;
				btnCONFIRM.Enabled = true;
				btnREMOVE.Enabled = true;
				txtDOCNO.ReadOnly = false;
				dtpDOCDT.Enabled = true;
				cbLOCID.Enabled = true;
				cbMDLCD.Enabled = true;
				cbREVNO.Enabled = true;
				dgvPDRWO.ReadOnly = false;
			}
		}

		private void BindGrid()
		{
			int i = 0;
			dgvPDRWO.DataSource = null;
			string strSQL = "EXEC spPDFGRWO_Grid '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Interaction.IIf(cbREVNO.SelectedValue == null, 1, RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))));
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvPDRWO;
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
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Return Type");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Strength");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Used");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
			if (spPDERWO(0))
			{
				btnCONFIRM.Enabled = true;
			}
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			if (spPDERWO(1))
			{
			}
		}

		private bool spPDERWO(int intOption)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDERWO'"));
			bool spPDERWO;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PDERWO", "DOCNO", ref strNextNo))
					{
						MessageBox.Show("Document No cannot blank! Please check document number control.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spPDERWO = false;
						goto IL_02d2;
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
					spPDERWO = false;
					goto IL_02d2;
				}
			}
			strSQL = "EXEC spPDERWO " + Conversions.ToString(intOption) + ", ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCD.SelectedValue), "', ")));
			strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + ", ";
			strSQL = strSQL + Conversions.ToString(numWOQTY.Value) + ", ";
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
				spPDERWO = false;
				ProjectData.ClearProjectError();
				goto IL_02d2;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			spPDERWO = true;
			goto IL_02d2;
			IL_02d2:
			return spPDERWO;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			ClearControl();
			EnableButton();
			ManageOrderNo();
			BindComboBox("");
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
			dgvPDRWO.DataSource = null;
			txtDOCNO.Text = string.Empty;
			dtpDOCDT.Value = DateTime.Now;
			dtpDOCDT.Enabled = true;
			txtDOCNO.Enabled = true;
			cbLOCID.Enabled = true;
			cbMDLCD.Enabled = true;
			cbREVNO.Enabled = true;
			txtSTSFG.Text = Conversions.ToString(-1);
			txtREMRK.Text = string.Empty;
			numWOQTY.Value = 0.0;
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDERWO'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private void cbREVNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindGrid();
		}

		private void cbMDLCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindComboBox("REVNO");
		}

		private void RecalculateWOQty()
		{
			int intTotal = 0;
			checked
			{
				int num = dgvPDRWO.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(dgvPDRWO.Rows[i].Cells["PDRWO_CHK"].Value, true, false))
					{
						intTotal = Conversions.ToInteger(Operators.AddObject(intTotal, dgvPDRWO.Rows[i].Cells["PDRWO_BALQT"].Value));
					}
				}
				numWOQTY.Value = intTotal;
			}
		}

		private void dgvPDRWO_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (dgvPDRWO.Rows.Count != 0 && !dgvPDRWO.Columns["PDRWO_CHK"].ReadOnly && dgvPDRWO.CurrentCell.ColumnIndex == 1)
			{
				if (Operators.ConditionalCompareObjectEqual(dgvPDRWO.CurrentRow.Cells["PDRWO_CHK"].Value, 0, false))
				{
					dgvPDRWO.CurrentRow.Cells["PDRWO_CHK"].Value = 1;
				}
				else
				{
					dgvPDRWO.CurrentRow.Cells["PDRWO_CHK"].Value = 0;
				}
				RecalculateWOQty();
				string strSQL = "EXEC spPDRWO_CHK '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(dgvPDRWO.CurrentRow.Cells["PDRWO_RTNID"].Value, ", ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, dgvPDRWO.CurrentRow.Cells["PDRWO_CHK"].Value));
				DB.ExecProc(strSQL);
			}
		}

		private void btnCONFIRM_Click(object sender, EventArgs e)
		{
			if (spPDERWO(2))
			{
				Header();
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			GenerateQRCode();
		}

		private void GenerateQRCode()
		{
			OleDbCommand cmd = new OleDbCommand();
			object settings = new BarcodeSettings();
			string strSQL = "EXEC spPDRWO_QR ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int iRowsAffected = cmd.ExecuteNonQuery();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex3 = ex4;
				MessageBox.Show(ex3.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			DataTable dt = DB.ExecProc("SELECT PDWKO_WKONO FROM PDWKO_QR WHERE PDWKO_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "'");
			int num = checked(dt.Rows.Count - 1);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				NewLateBinding.LateSet(settings, null, "HasBorder", new object[1] { false }, null, null);
				NewLateBinding.LateSet(settings, null, "ShowText", new object[1] { false }, null, null);
				NewLateBinding.LateSet(settings, null, "Type", new object[1] { (BarCodeType)Conversions.ToLong(Enum.Parse(typeof(BarCodeType), "QRCode")) }, null, null);
				NewLateBinding.LateSet(settings, null, "LeftMargin", new object[1] { 1 }, null, null);
				string strWKONO = Common.gfValidSQLStr(dt.Rows[i]["PDWKO_WKONO"].ToString().Trim());
				NewLateBinding.LateSet(settings, null, "Data2D", new object[1] { strWKONO }, null, null);
				NewLateBinding.LateSet(settings, null, "Data", new object[1] { strWKONO }, null, null);
				BarCodeGenerator sprSCRID = new BarCodeGenerator((IBarcodeSettings)settings);
				byte[] imgQRCODE = Common.ImageToByte2(sprSCRID.GenerateImage());
				try
				{
					cmd = new OleDbCommand();
					cmd.Connection = DB.GetDBConnection();
					strSQL = "spPDWKO_QR2";
					cmd.CommandText = strSQL;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("@PRNID", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(MyProject.Computer.Name);
					cmd.Parameters.Add("@WKONO", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(strWKONO);
					cmd.Parameters.Add("@QRCODE", OleDbType.VarBinary, -1).Value = imgQRCODE;
					int iRowsAffected = cmd.ExecuteNonQuery();
				}
				catch (OleDbException ex5)
				{
					ProjectData.SetProjectError(ex5);
					OleDbException ex2 = ex5;
					MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				catch (Exception ex6)
				{
					ProjectData.SetProjectError(ex6);
					Exception ex = ex6;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				finally
				{
					cmd = null;
				}
			}
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "WORK ORDER";
			string ITMGRP = Conversions.ToString(DB.GetColumnValue("MAITM_GRPCD", "MAITM_TBL WITH(NOLOCK)", "MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' "));
			if (Operators.CompareString(ITMGRP, "WB", false) != 0)
			{
				if (Operators.CompareString(ITMGRP, "SB", false) == 0)
				{
					frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKO1.rpt";
				}
				else
				{
					frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKO.rpt";
				}
			}
			else
			{
				frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKO.rpt";
			}
			frmRPT.Params = "@PRNID=" + Common.gfValidSQLStr(MyProject.Computer.Name) + " ";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='WORK ORDER',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void DisplayLabel()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "WORK ORDER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKOL2.rpt";
			frmRPT.Params = "@PAR=2,@PRNID=" + Common.gfValidSQLStr(MyProject.Computer.Name) + " ";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='WORK ORDER LABEL - SEMI PRODUCT',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ComputerName = MyProject.Computer.Name;
			frmRPT.ViewReportbyComputerName();
		}

		private void cbType_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindGrid();
		}

		private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindComboBox("MDLCD");
		}
	}
}
