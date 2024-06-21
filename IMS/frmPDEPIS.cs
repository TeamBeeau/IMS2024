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
	public class frmPDEPIS : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtWKONO")]
		private TextBox _txtWKONO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCONFIRM")]
		private Button _btnCONFIRM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUPDATE")]
		private Button _btnUPDATE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCANCEL")]
		private Button _btnCANCEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvBOM")]
		private DataGridView _dgvBOM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbLOCID")]
		private ComboBox _cbLOCID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCLOSE")]
		private Button _btnCLOSE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtGRLNO")]
		private TextBox _txtGRLNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvUsedGoods")]
		private DataGridView _dgvUsedGoods;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnADD")]
		private Button _btnADD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbRACKNO")]
		private ComboBox _cbRACKNO;

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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtWKONO
		{
			[CompilerGenerated]
			get
			{
				return _txtWKONO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtWKONO_KeyDown;
				TextBox textBox = _txtWKONO;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtWKONO = value;
				textBox = _txtWKONO;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lblPACKING")]
		internal virtual Label lblPACKING
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

		[field: AccessedThroughProperty("Label16")]
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpWKODT")]
		internal virtual DateTimePicker dtpWKODT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("numWOQTY")]
		internal virtual NumControl numWOQTY
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

		[field: AccessedThroughProperty("Label21")]
		internal virtual Label Label21
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

		internal virtual Button btnUPDATE
		{
			[CompilerGenerated]
			get
			{
				return _btnUPDATE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUPDATE_Click;
				Button button = _btnUPDATE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnUPDATE = value;
				button = _btnUPDATE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		[field: AccessedThroughProperty("numREVNO")]
		internal virtual NumControl numREVNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtMDLCD")]
		internal virtual TextBox txtMDLCD
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

		[field: AccessedThroughProperty("txtBOMPN")]
		internal virtual TextBox txtBOMPN
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvBOM
		{
			[CompilerGenerated]
			get
			{
				return _dgvBOM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvBOM_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvBOM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvBOM = value;
				dataGridView = _dgvBOM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtROUCD")]
		internal virtual TextBox txtROUCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtMCHID")]
		internal virtual TextBox txtMCHID
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numREQQT")]
		internal virtual NumControl numREQQT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numQTY")]
		internal virtual NumControl numQTY
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numBALQT")]
		internal virtual NumControl numBALQT
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

		internal virtual TextBox txtGRLNO
		{
			[CompilerGenerated]
			get
			{
				return _txtGRLNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtGRLNO_KeyDown;
				TextBox textBox = _txtGRLNO;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtGRLNO = value;
				textBox = _txtGRLNO;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numTOLRN")]
		internal virtual NumControl numTOLRN
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvUsedGoods
		{
			[CompilerGenerated]
			get
			{
				return _dgvUsedGoods;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvUsedGoods_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvUsedGoods;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvUsedGoods = value;
				dataGridView = _dgvUsedGoods;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		internal virtual Button btnADD
		{
			[CompilerGenerated]
			get
			{
				return _btnADD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnADD_Click;
				Button button = _btnADD;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnADD = value;
				button = _btnADD;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtRTNDOCNO")]
		internal virtual TextBox txtRTNDOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numRTNBALQT")]
		internal virtual NumControl numRTNBALQT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numALLQT")]
		internal virtual NumControl numALLQT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtRTLNO")]
		internal virtual TextBox txtRTLNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREFNO")]
		internal virtual TextBox txtREFNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTYPE")]
		internal virtual TextBox txtTYPE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("txtPACKING")]
		internal virtual TextBox txtPACKING
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTDWGT")]
		internal virtual Label lblSTDWGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbRACKNO
		{
			[CompilerGenerated]
			get
			{
				return _cbRACKNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbRACKNO_SelectedIndexChanged;
				ComboBox comboBox = _cbRACKNO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbRACKNO = value;
				comboBox = _cbRACKNO;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		public frmPDEPIS()
		{
			base.FormClosing += frmPDEPIS_FormClosing;
			base.Shown += frmPDEPIS_Shown;
			base.KeyDown += frmPDEPIS_KeyDown;
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
			this.cbRACKNO = new System.Windows.Forms.ComboBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnUPDATE = new System.Windows.Forms.Button();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtWKONO = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.dtpWKODT = new System.Windows.Forms.DateTimePicker();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.numREVNO = new IMS.NumControl();
			this.txtMDLCD = new System.Windows.Forms.TextBox();
			this.btnCONFIRM = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblPACKING = new System.Windows.Forms.Label();
			this.lblQTY = new System.Windows.Forms.Label();
			this.numWOQTY = new IMS.NumControl();
			this.txtROUCD = new System.Windows.Forms.TextBox();
			this.txtMCHID = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtBOMPN = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.btnCLOSE = new System.Windows.Forms.Button();
			this.numQTY = new IMS.NumControl();
			this.numBALQT = new IMS.NumControl();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.numREQQT = new IMS.NumControl();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtGRLNO = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.numTOLRN = new IMS.NumControl();
			this.dgvBOM = new System.Windows.Forms.DataGridView();
			this.dgvUsedGoods = new System.Windows.Forms.DataGridView();
			this.btnADD = new System.Windows.Forms.Button();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtRTNDOCNO = new System.Windows.Forms.TextBox();
			this.txtREFNO = new System.Windows.Forms.TextBox();
			this.txtRTLNO = new System.Windows.Forms.TextBox();
			this.txtTYPE = new System.Windows.Forms.TextBox();
			this.txtPACKING = new System.Windows.Forms.TextBox();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.numRTNBALQT = new IMS.NumControl();
			this.Label14 = new System.Windows.Forms.Label();
			this.numALLQT = new IMS.NumControl();
			this.lblSTDWGT = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvBOM).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvUsedGoods).BeginInit();
			base.SuspendLayout();
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(1, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 4;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.cbRACKNO, 3, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label15, 2, 8);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtWKONO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label16, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpWKODT, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label21, 2, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.numREVNO, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtMDLCD, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.btnCONFIRM, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblPACKING, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblQTY, 2, 4);
			this.TableLayoutPanel1.Controls.Add(this.numWOQTY, 3, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtROUCD, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtMCHID, 3, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtBOMPN, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.btnCLOSE, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.numQTY, 3, 10);
			this.TableLayoutPanel1.Controls.Add(this.numBALQT, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 2, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.numREQQT, 3, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtGRLNO, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.numTOLRN, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.dgvBOM, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.dgvUsedGoods, 4, 6);
			this.TableLayoutPanel1.Controls.Add(this.btnADD, 4, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 4, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtRTNDOCNO, 5, 7);
			this.TableLayoutPanel1.Controls.Add(this.txtREFNO, 4, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtRTLNO, 5, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtTYPE, 3, 11);
			this.TableLayoutPanel1.Controls.Add(this.txtPACKING, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 4, 8);
			this.TableLayoutPanel1.Controls.Add(this.numRTNBALQT, 5, 8);
			this.TableLayoutPanel1.Controls.Add(this.Label14, 4, 9);
			this.TableLayoutPanel1.Controls.Add(this.numALLQT, 5, 9);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 12;
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
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1152, 568);
			this.TableLayoutPanel1.TabIndex = 0;
			this.cbRACKNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRACKNO.FormattingEnabled = true;
			this.cbRACKNO.Location = new System.Drawing.Point(484, 419);
			this.cbRACKNO.Name = "cbRACKNO";
			this.cbRACKNO.Size = new System.Drawing.Size(200, 28);
			this.cbRACKNO.TabIndex = 88;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(402, 423);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(73, 20);
			this.Label15.TabIndex = 87;
			this.Label15.Text = "Rack No";
			this.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel5, 3);
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.btnUPDATE, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnCANCEL, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(4, 512);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(380, 54);
			this.TableLayoutPanel5.TabIndex = 5;
			this.btnUPDATE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUPDATE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnUPDATE.Image = IMS.My.Resources.Resources.Save;
			this.btnUPDATE.Location = new System.Drawing.Point(4, 2);
			this.btnUPDATE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnUPDATE.Name = "btnUPDATE";
			this.btnUPDATE.Size = new System.Drawing.Size(120, 50);
			this.btnUPDATE.TabIndex = 6;
			this.btnUPDATE.Text = "Update";
			this.btnUPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUPDATE.UseVisualStyleBackColor = false;
			this.btnCANCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCANCEL.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCANCEL.Location = new System.Drawing.Point(257, 2);
			this.btnCANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.Size = new System.Drawing.Size(120, 50);
			this.btnCANCEL.TabIndex = 7;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCANCEL.UseVisualStyleBackColor = false;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(131, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 8;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 5);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(122, 20);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Work Order No";
			this.txtWKONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtWKONO.Location = new System.Drawing.Point(146, 2);
			this.txtWKONO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtWKONO.Name = "txtWKONO";
			this.txtWKONO.Size = new System.Drawing.Size(250, 26);
			this.txtWKONO.TabIndex = 1;
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(3, 35);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(137, 20);
			this.Label16.TabIndex = 48;
			this.Label16.Text = "Work Order Date";
			this.dtpWKODT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpWKODT.CustomFormat = "dd/MM/yyyy";
			this.dtpWKODT.Enabled = false;
			this.dtpWKODT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpWKODT.Location = new System.Drawing.Point(146, 32);
			this.dtpWKODT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpWKODT.Name = "dtpWKODT";
			this.dtpWKODT.Size = new System.Drawing.Size(104, 26);
			this.dtpWKODT.TabIndex = 3;
			this.dtpWKODT.TabStop = false;
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(402, 95);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(72, 20);
			this.Label21.TabIndex = 50;
			this.Label21.Text = "Machine";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 65);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(98, 20);
			this.Label7.TabIndex = 51;
			this.Label7.Text = "Model Code";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(402, 65);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(73, 20);
			this.Label8.TabIndex = 51;
			this.Label8.Text = "Revision";
			this.numREVNO.AllowNegative = false;
			this.numREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numREVNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numREVNO.DataChanged = false;
			this.numREVNO.Location = new System.Drawing.Point(484, 62);
			this.numREVNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numREVNO.Name = "numREVNO";
			this.numREVNO.NumberFormat = "8.2";
			this.numREVNO.ReadOnly = true;
			this.numREVNO.Size = new System.Drawing.Size(100, 26);
			this.numREVNO.TabIndex = 54;
			this.numREVNO.TabStop = false;
			this.numREVNO.Text = "0.00";
			this.numREVNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numREVNO.ThousandSeperator = false;
			this.numREVNO.Value = 0.0;
			this.txtMDLCD.Location = new System.Drawing.Point(146, 62);
			this.txtMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMDLCD.Name = "txtMDLCD";
			this.txtMDLCD.ReadOnly = true;
			this.txtMDLCD.Size = new System.Drawing.Size(250, 26);
			this.txtMDLCD.TabIndex = 55;
			this.txtMDLCD.TabStop = false;
			this.btnCONFIRM.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCONFIRM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCONFIRM.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCONFIRM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCONFIRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCONFIRM.Image = IMS.My.Resources.Resources.Confirm;
			this.btnCONFIRM.Location = new System.Drawing.Point(729, 2);
			this.btnCONFIRM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCONFIRM.Name = "btnCONFIRM";
			this.TableLayoutPanel1.SetRowSpan(this.btnCONFIRM, 2);
			this.btnCONFIRM.Size = new System.Drawing.Size(120, 50);
			this.btnCONFIRM.TabIndex = 8;
			this.btnCONFIRM.Text = "Confirm";
			this.btnCONFIRM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCONFIRM.UseVisualStyleBackColor = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 95);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(53, 20);
			this.Label1.TabIndex = 56;
			this.Label1.Text = "Route";
			this.lblPACKING.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblPACKING.AutoSize = true;
			this.lblPACKING.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPACKING.Location = new System.Drawing.Point(3, 125);
			this.lblPACKING.Name = "lblPACKING";
			this.lblPACKING.Size = new System.Drawing.Size(68, 20);
			this.lblPACKING.TabIndex = 48;
			this.lblPACKING.Text = "Packing";
			this.lblQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblQTY.AutoSize = true;
			this.lblQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQTY.Location = new System.Drawing.Point(402, 125);
			this.lblQTY.Name = "lblQTY";
			this.lblQTY.Size = new System.Drawing.Size(71, 20);
			this.lblQTY.TabIndex = 53;
			this.lblQTY.Text = "Quantity";
			this.numWOQTY.AllowNegative = false;
			this.numWOQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWOQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWOQTY.DataChanged = false;
			this.numWOQTY.Location = new System.Drawing.Point(484, 122);
			this.numWOQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numWOQTY.Name = "numWOQTY";
			this.numWOQTY.NumberFormat = "8.2";
			this.numWOQTY.ReadOnly = true;
			this.numWOQTY.Size = new System.Drawing.Size(100, 26);
			this.numWOQTY.TabIndex = 52;
			this.numWOQTY.TabStop = false;
			this.numWOQTY.Text = "0.00";
			this.numWOQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWOQTY.ThousandSeperator = false;
			this.numWOQTY.Value = 0.0;
			this.txtROUCD.Location = new System.Drawing.Point(146, 92);
			this.txtROUCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtROUCD.Name = "txtROUCD";
			this.txtROUCD.ReadOnly = true;
			this.txtROUCD.Size = new System.Drawing.Size(200, 26);
			this.txtROUCD.TabIndex = 60;
			this.txtROUCD.TabStop = false;
			this.txtMCHID.Location = new System.Drawing.Point(484, 92);
			this.txtMCHID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMCHID.Name = "txtMCHID";
			this.txtMCHID.ReadOnly = true;
			this.txtMCHID.Size = new System.Drawing.Size(200, 26);
			this.txtMCHID.TabIndex = 61;
			this.txtMCHID.TabStop = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 391);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(85, 20);
			this.Label2.TabIndex = 62;
			this.Label2.Text = "Item Code";
			this.txtBOMPN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtBOMPN.Location = new System.Drawing.Point(146, 388);
			this.txtBOMPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBOMPN.Name = "txtBOMPN";
			this.txtBOMPN.ReadOnly = true;
			this.txtBOMPN.Size = new System.Drawing.Size(250, 26);
			this.txtBOMPN.TabIndex = 58;
			this.txtBOMPN.TabStop = false;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 423);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(95, 20);
			this.Label5.TabIndex = 64;
			this.Label5.Text = "Location ID";
			this.btnCLOSE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCLOSE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCLOSE.Image = IMS.My.Resources.Resources.Close;
			this.btnCLOSE.Location = new System.Drawing.Point(857, 2);
			this.btnCLOSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCLOSE.Name = "btnCLOSE";
			this.TableLayoutPanel1.SetRowSpan(this.btnCLOSE, 2);
			this.btnCLOSE.Size = new System.Drawing.Size(120, 50);
			this.btnCLOSE.TabIndex = 9;
			this.btnCLOSE.Text = "Close";
			this.btnCLOSE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCLOSE.UseVisualStyleBackColor = false;
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQTY.DataChanged = false;
			this.numQTY.Location = new System.Drawing.Point(484, 482);
			this.numQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.2";
			this.numQTY.Size = new System.Drawing.Size(100, 26);
			this.numQTY.TabIndex = 4;
			this.numQTY.Text = "0.00";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.numBALQT.AllowNegative = false;
			this.numBALQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numBALQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numBALQT.DataChanged = false;
			this.numBALQT.Location = new System.Drawing.Point(146, 482);
			this.numBALQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numBALQT.Name = "numBALQT";
			this.numBALQT.NumberFormat = "8.2";
			this.numBALQT.ReadOnly = true;
			this.numBALQT.Size = new System.Drawing.Size(100, 26);
			this.numBALQT.TabIndex = 70;
			this.numBALQT.TabStop = false;
			this.numBALQT.Text = "0.00";
			this.numBALQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numBALQT.ThousandSeperator = false;
			this.numBALQT.Value = 0.0;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(402, 485);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(56, 20);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Actual";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 485);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(70, 20);
			this.Label6.TabIndex = 69;
			this.Label6.Text = "Balance";
			this.numREQQT.AllowNegative = false;
			this.numREQQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numREQQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numREQQT.DataChanged = false;
			this.numREQQT.Location = new System.Drawing.Point(484, 452);
			this.numREQQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numREQQT.Name = "numREQQT";
			this.numREQQT.NumberFormat = "8.2";
			this.numREQQT.ReadOnly = true;
			this.numREQQT.Size = new System.Drawing.Size(100, 26);
			this.numREQQT.TabIndex = 65;
			this.numREQQT.TabStop = false;
			this.numREQQT.Text = "0.00";
			this.numREQQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numREQQT.ThousandSeperator = false;
			this.numREQQT.Value = 0.0;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(402, 455);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 20);
			this.Label3.TabIndex = 63;
			this.Label3.Text = "Required";
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 455);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(127, 20);
			this.Label9.TabIndex = 71;
			this.Label9.Text = "Batch QR Code";
			this.txtGRLNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtGRLNO.Location = new System.Drawing.Point(146, 452);
			this.txtGRLNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGRLNO.Name = "txtGRLNO";
			this.txtGRLNO.Size = new System.Drawing.Size(250, 26);
			this.txtGRLNO.TabIndex = 3;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(3, 155);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(115, 20);
			this.Label12.TabIndex = 73;
			this.Label12.Text = "Tolerance (%)";
			this.numTOLRN.AllowNegative = false;
			this.numTOLRN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTOLRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTOLRN.DataChanged = false;
			this.numTOLRN.Location = new System.Drawing.Point(146, 152);
			this.numTOLRN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTOLRN.Name = "numTOLRN";
			this.numTOLRN.NumberFormat = "8.2";
			this.numTOLRN.ReadOnly = true;
			this.numTOLRN.Size = new System.Drawing.Size(87, 26);
			this.numTOLRN.TabIndex = 74;
			this.numTOLRN.TabStop = false;
			this.numTOLRN.Text = "0.00";
			this.numTOLRN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTOLRN.ThousandSeperator = false;
			this.numTOLRN.Value = 0.0;
			this.dgvBOM.AllowUserToAddRows = false;
			this.dgvBOM.AllowUserToDeleteRows = false;
			this.dgvBOM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvBOM, 4);
			this.dgvBOM.Location = new System.Drawing.Point(3, 183);
			this.dgvBOM.MultiSelect = false;
			this.dgvBOM.Name = "dgvBOM";
			this.dgvBOM.ReadOnly = true;
			this.dgvBOM.RowHeadersVisible = false;
			this.dgvBOM.RowHeadersWidth = 51;
			this.dgvBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBOM.Size = new System.Drawing.Size(720, 200);
			this.dgvBOM.TabIndex = 59;
			this.dgvBOM.TabStop = false;
			this.dgvUsedGoods.AllowUserToAddRows = false;
			this.dgvUsedGoods.AllowUserToDeleteRows = false;
			this.dgvUsedGoods.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvUsedGoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dgvUsedGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvUsedGoods, 2);
			this.dgvUsedGoods.Location = new System.Drawing.Point(729, 183);
			this.dgvUsedGoods.MultiSelect = false;
			this.dgvUsedGoods.Name = "dgvUsedGoods";
			this.dgvUsedGoods.RowHeadersVisible = false;
			this.dgvUsedGoods.RowHeadersWidth = 51;
			this.dgvUsedGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsedGoods.Size = new System.Drawing.Size(420, 200);
			this.dgvUsedGoods.TabIndex = 75;
			this.dgvUsedGoods.TabStop = false;
			this.btnADD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnADD.Enabled = false;
			this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnADD.Image = IMS.My.Resources.Resources.Save;
			this.btnADD.Location = new System.Drawing.Point(730, 512);
			this.btnADD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(120, 50);
			this.btnADD.TabIndex = 76;
			this.btnADD.Text = "Add";
			this.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnADD.UseVisualStyleBackColor = false;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(729, 391);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(112, 20);
			this.Label11.TabIndex = 77;
			this.Label11.Text = "Document No";
			this.txtRTNDOCNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRTNDOCNO.Location = new System.Drawing.Point(857, 388);
			this.txtRTNDOCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRTNDOCNO.Name = "txtRTNDOCNO";
			this.txtRTNDOCNO.ReadOnly = true;
			this.txtRTNDOCNO.Size = new System.Drawing.Size(200, 26);
			this.txtRTNDOCNO.TabIndex = 78;
			this.txtRTNDOCNO.TabStop = false;
			this.txtREFNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtREFNO.Location = new System.Drawing.Point(729, 152);
			this.txtREFNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREFNO.Name = "txtREFNO";
			this.txtREFNO.ReadOnly = true;
			this.txtREFNO.Size = new System.Drawing.Size(20, 26);
			this.txtREFNO.TabIndex = 84;
			this.txtREFNO.TabStop = false;
			this.txtREFNO.Text = "-1";
			this.txtREFNO.Visible = false;
			this.txtRTLNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRTLNO.Location = new System.Drawing.Point(857, 152);
			this.txtRTLNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRTLNO.Name = "txtRTLNO";
			this.txtRTLNO.ReadOnly = true;
			this.txtRTLNO.Size = new System.Drawing.Size(20, 26);
			this.txtRTLNO.TabIndex = 83;
			this.txtRTLNO.TabStop = false;
			this.txtRTLNO.Text = "-1";
			this.txtRTLNO.Visible = false;
			this.txtTYPE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtTYPE.Location = new System.Drawing.Point(484, 526);
			this.txtTYPE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTYPE.Name = "txtTYPE";
			this.txtTYPE.ReadOnly = true;
			this.txtTYPE.Size = new System.Drawing.Size(20, 26);
			this.txtTYPE.TabIndex = 85;
			this.txtTYPE.TabStop = false;
			this.txtTYPE.Text = "-1";
			this.txtTYPE.Visible = false;
			this.txtPACKING.Location = new System.Drawing.Point(146, 122);
			this.txtPACKING.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPACKING.Name = "txtPACKING";
			this.txtPACKING.ReadOnly = true;
			this.txtPACKING.Size = new System.Drawing.Size(200, 26);
			this.txtPACKING.TabIndex = 86;
			this.txtPACKING.TabStop = false;
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(146, 419);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(200, 28);
			this.cbLOCID.TabIndex = 2;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(729, 423);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(70, 20);
			this.Label13.TabIndex = 79;
			this.Label13.Text = "Balance";
			this.numRTNBALQT.AllowNegative = false;
			this.numRTNBALQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numRTNBALQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numRTNBALQT.DataChanged = false;
			this.numRTNBALQT.Location = new System.Drawing.Point(857, 420);
			this.numRTNBALQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numRTNBALQT.Name = "numRTNBALQT";
			this.numRTNBALQT.NumberFormat = "8.2";
			this.numRTNBALQT.ReadOnly = true;
			this.numRTNBALQT.Size = new System.Drawing.Size(100, 26);
			this.numRTNBALQT.TabIndex = 80;
			this.numRTNBALQT.TabStop = false;
			this.numRTNBALQT.Text = "0.00";
			this.numRTNBALQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numRTNBALQT.ThousandSeperator = false;
			this.numRTNBALQT.Value = 0.0;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(729, 455);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(100, 20);
			this.Label14.TabIndex = 82;
			this.Label14.Text = "Allocate Qty";
			this.numALLQT.AllowNegative = false;
			this.numALLQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numALLQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numALLQT.DataChanged = false;
			this.numALLQT.Location = new System.Drawing.Point(857, 452);
			this.numALLQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numALLQT.Name = "numALLQT";
			this.numALLQT.NumberFormat = "8.2";
			this.numALLQT.Size = new System.Drawing.Size(100, 26);
			this.numALLQT.TabIndex = 81;
			this.numALLQT.Text = "0.00";
			this.numALLQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numALLQT.ThousandSeperator = false;
			this.numALLQT.Value = 0.0;
			this.lblSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTDWGT.AutoSize = true;
			this.lblSTDWGT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTDWGT.Location = new System.Drawing.Point(3, 111);
			this.lblSTDWGT.Name = "lblSTDWGT";
			this.lblSTDWGT.Size = new System.Drawing.Size(108, 16);
			this.lblSTDWGT.TabIndex = 48;
			this.lblSTDWGT.Text = "Standard Weight";
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPDEPIS";
			base.Tag = "PDEPIS";
			this.Text = "Part Issue Entry";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvBOM).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvUsedGoods).EndInit();
			base.ResumeLayout(false);
		}

		private void btnUPDATE_Click(object sender, EventArgs e)
		{
			if (!Conversions.ToBoolean(Operators.NotObject(ValidateDetails())) && spPDEPIS())
			{
				RefreshGrid(false);
				ClearDetails();
				btnCONFIRM.Enabled = true;
				txtWKONO.Enabled = false;
			}
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT INRBAL_LOCID ";
			strSQL += "FROM INRBAL_TBL WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE INRBAL_ITMCD = '" + Common.gfValidSQLStr(txtBOMPN.Text) + "' ";
			strSQL += "ORDER BY INRBAL_LOCID ";
			cbLOCID.ValueMember = "INRBAL_LOCID";
			cbLOCID.DisplayMember = "INRBAL_LOCID";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
		}

		private void ClearDetails()
		{
			txtBOMPN.Text = string.Empty;
			cbLOCID.DataSource = null;
			txtGRLNO.Text = string.Empty;
			numREQQT.Value = 0.0;
			numBALQT.Value = 0.0;
			numQTY.Value = 0.0;
		}

		private bool spPDEPIS()
		{
			OleDbCommand cmd = new OleDbCommand();
			Cursor = Cursors.WaitCursor;
			string strSQL = "EXEC spPDEPIS ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtBOMPN.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbRACKNO.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtGRLNO.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(numBALQT.Value)) + ", ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(numQTY.Value)) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "'";
			bool spPDEPIS;
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
				spPDEPIS = false;
				ProjectData.ClearProjectError();
				goto IL_01b8;
			}
			Cursor = Cursors.Default;
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			spPDEPIS = true;
			goto IL_01b8;
			IL_01b8:
			return spPDEPIS;
		}

		private object ValidateDetails()
		{
			if (numQTY.Value > numBALQT.Value)
			{
				MessageBox.Show("Invalid Quantity, Balance not enough!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			int intTOLRN = checked((int)Math.Ceiling(numTOLRN.Value / 100.0 * numREQQT.Value));
			if (numQTY.Value > numREQQT.Value + (double)intTOLRN)
			{
				MessageBox.Show("Invalid Quantity, Quantity more than Required!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			if (txtGRLNO.Text.Length == 0)
			{
				MessageBox.Show("Inavalid Batch QR Code, please scan Batch QR Code!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}

		private void RefreshGrid(bool blnNEW)
		{
			dgvBOM.DataSource = null;
			string strSQL;
			if (blnNEW)
			{
				strSQL = "EXEC spPDPIS '" + MyProject.Computer.Name + "', '" + txtWKONO.Text + "'";
				DB.ExecProc(strSQL);
			}
			strSQL = "SELECT PDPIS_TYPE, PDPIS_BOMPN, PDPIS_REQQT, PDPIS_LOCID, PDPIS_GRLNO, ";
			strSQL += "PDPIS_BATCH, PDPIS_BALQT, PDPIS_QTY ";
			strSQL = strSQL + "FROM PDPIS_WRK WHERE PDPIS_PRNID = '" + MyProject.Computer.Name + "'";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvBOM.ClearSelection();
					DataGridView dataGridView = dgvBOM;
					dataGridView.DataSource = dt;
					int i = default(int);
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 30;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Required");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Actual");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void btnCONFIRM_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM PDPIS_WRK WHERE PDPIS_PRNID = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND PDPIS_QTY = 0";
			if (DB.RecordExists(strSQL))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Some records not yet key in quantity!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			strSQL = "SELECT * FROM PDPIS_WRK WHERE PDPIS_PRNID = '" + MyProject.Computer.Name + "' ";
			strSQL += "AND PDPIS_QTY < PDPIS_REQQT";
			if (DB.RecordExists(strSQL))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Some records quantity not match with required quantity!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			strSQL = "EXEC spPDEPIS_CONFIRM '" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWKONO.Text) + "', ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
			DB.ExecProc(strSQL);
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record confirmed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			ClearControl();
			ClearDetails();
		}

		private void ClearControl()
		{
			txtWKONO.Text = string.Empty;
			txtWKONO.Enabled = true;
			dtpWKODT.Value = DateAndTime.Now;
			txtMDLCD.Text = string.Empty;
			numREVNO.Value = 0.0;
			txtROUCD.Text = string.Empty;
			txtMCHID.Text = string.Empty;
			txtPACKING.Text = string.Empty;
			numWOQTY.Value = 0.0;
			numTOLRN.Value = 0.0;
			btnCONFIRM.Enabled = false;
			dgvBOM.DataSource = null;
			btnADD.Enabled = false;
		}

		private void frmPDEPIS_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmPDEPIS_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			numWOQTY.NumberFormat = PublicVar.gstrQtyFmt;
			numREQQT.NumberFormat = PublicVar.gstrWgtFmt;
			numBALQT.NumberFormat = PublicVar.gstrWgtFmt;
			numQTY.NumberFormat = PublicVar.gstrWgtFmt;
			numRTNBALQT.NumberFormat = PublicVar.gstrWgtFmt;
			numALLQT.NumberFormat = PublicVar.gstrWgtFmt;
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void txtWKONO_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return))
			{
				txtWKONO.Text = txtWKONO.Text.Replace("\r\n", "").ToUpper();
				string strSQL = "SELECT * FROM PDWKO_TBL ";
				strSQL += "LEFT JOIN MAMCH_TBL ON MAMCH_MCHID = PDWKO_MCHID ";
				strSQL = strSQL + "WHERE PDWKO_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
				strSQL += "AND PDWKO_STSFG = 1 AND MAMCH_ISSFG = 1";
				DataTable dt = DB.ExecProc(strSQL);
				if (dt.Rows.Count == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Work Order!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				txtMDLCD.Text = Conversions.ToString(dt.Rows[0]["PDWKO_MDLCD"]);
				numREVNO.Value = Conversions.ToDouble(dt.Rows[0]["PDWKO_REVNO"]);
				txtROUCD.Text = Conversions.ToString(dt.Rows[0]["PDWKO_ROUCD"]);
				txtMCHID.Text = Conversions.ToString(dt.Rows[0]["PDWKO_MCHID"]);
				txtPACKING.Text = Conversions.ToString(dt.Rows[0]["PDWKO_PACKING"]);
				numWOQTY.Value = Conversions.ToDouble(dt.Rows[0]["PDWKO_WOQTY"]);
				numTOLRN.Value = Conversions.ToDouble(dt.Rows[0]["PDWKO_TOLRN"]);
				RefreshGrid(true);
				RefreshGridUsedGoods();
				btnADD.Enabled = true;
			}
		}

		private void RefreshGridUsedGoods()
		{
			string strSQL = "SELECT PCRTN_DOCNO, PCRTN_DOCDT, CONVERT(VARCHAR(10), PCRTN_DOCDT, 103) AS DOCDT, ";
			strSQL += "PCRTN_RTLNO, PCRTN_REFNO, PCRTN_STRNG, PCRTN_QTY - PCRTN_USED AS PCRTN_BALQT ";
			strSQL += "FROM PCRTN_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PCRTN_ITMCD = '" + Common.gfValidSQLStr(txtMDLCD.Text) + "' ";
			strSQL = strSQL + "AND PCRTN_REVNO = " + Conversions.ToString(numREVNO.Value) + " ";
			strSQL += "AND PCRTN_QTY - PCRTN_USED > 0";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvUsedGoods;
			dataGridView.DataSource = dt;
			int i = default(int);
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 120;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			dataGridView.Columns[i].ReadOnly = true;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Date");
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Strength");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
				dataGridView.Columns[i].ReadOnly = true;
				dataGridView.AutoResizeRows();
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void dgvBOM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtTYPE.Text = Conversions.ToString(dgvBOM.CurrentRow.Cells["PDPIS_TYPE"].Value);
			txtBOMPN.Text = Conversions.ToString(dgvBOM.CurrentRow.Cells["PDPIS_BOMPN"].Value);
			txtGRLNO.Text = Conversions.ToString(dgvBOM.CurrentRow.Cells["PDPIS_GRLNO"].Value);
			BindComboBox();
			cbLOCID.SelectedValue = RuntimeHelpers.GetObjectValue(dgvBOM.CurrentRow.Cells["PDPIS_LOCID"].Value);
			numREQQT.Value = Conversions.ToDouble(dgvBOM.CurrentRow.Cells["PDPIS_REQQT"].Value);
			numQTY.Value = Conversions.ToDouble(dgvBOM.CurrentRow.Cells["PDPIS_QTY"].Value);
			if (Operators.CompareString(txtTYPE.Text, "0", false) == 0)
			{
				btnUPDATE.Enabled = true;
				btnREMOVE.Enabled = false;
			}
			else
			{
				btnUPDATE.Enabled = false;
				btnREMOVE.Enabled = true;
			}
		}

		private void btnCLOSE_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT DISTINCT INRBAL_RACKNO ";
			strSQL += "FROM INRBAL_TBL WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE INRBAL_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "' ";
			strSQL = strSQL + "AND INRBAL_ITMCD = '" + Common.gfValidSQLStr(txtBOMPN.Text) + "' ";
			strSQL += "ORDER BY INRBAL_RACKNO ";
			cbRACKNO.ValueMember = "INRBAL_RACKNO";
			cbRACKNO.DisplayMember = "INRBAL_RACKNO";
			Common.RetriveComboItembySQL(strSQL, cbRACKNO);
		}

		private void frmPDEPIS_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void dgvUsedGoods_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtRTNDOCNO.Text = Conversions.ToString(dgvUsedGoods.CurrentRow.Cells["PCRTN_DOCNO"].Value);
			txtRTLNO.Text = Conversions.ToString(dgvUsedGoods.CurrentRow.Cells["PCRTN_RTLNO"].Value);
			txtREFNO.Text = Conversions.ToString(dgvUsedGoods.CurrentRow.Cells["PCRTN_REFNO"].Value);
			numRTNBALQT.Value = Conversions.ToDouble(dgvUsedGoods.CurrentRow.Cells["PCRTN_BALQT"].Value);
		}

		private void btnADD_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			Cursor = Cursors.WaitCursor;
			if (!ValidateUsedGoods())
			{
				Cursor = Cursors.Default;
				return;
			}
			string strSQL = "EXEC spPDEPIS_ADD ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWKONO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtRTNDOCNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtREFNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtRTLNO.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(numALLQT.Value)) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "'";
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
				ProjectData.ClearProjectError();
				return;
			}
			Cursor = Cursors.Default;
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record added!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			ClearUsedGoodsDetail();
			RefreshGrid(false);
			RefreshGridUsedGoods();
		}

		private void ClearUsedGoodsDetail()
		{
			txtRTNDOCNO.Text = string.Empty;
			numRTNBALQT.Value = 0.0;
			numALLQT.Value = 0.0;
		}

		private bool ValidateUsedGoods()
		{
			string strSQL = "SELECT * FROM PDPIS_WRK WHERE PDPIS_PRNID = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND PDPIS_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strSQL = strSQL + "AND PDPIS_BOMPN = '" + Common.gfValidSQLStr(txtREFNO.Text) + "'";
			if (DB.RecordExists(strSQL))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order already assign Used Goods!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			strSQL = "SELECT * FROM PDPIS_WRK WHERE PDPIS_PRNID = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND PDPIS_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strSQL += "AND PDPIS_QTY > 0";
			if (DB.RecordExists(strSQL))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Some BOM Part already assigned quantity. Previously assigned quantity will set to zero. Proceed?");
				if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					return false;
				}
			}
			return true;
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "DELETE PDPIS_WRK WHERE PDPIS_PRNID = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND PDPIS_GRLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "' ";
			strSQL = strSQL + "UPDATE PCRTN_TBL SET PCRTN_USED = PCRTN_USED - " + Conversions.ToString(numQTY.Value) + " ";
			strSQL = strSQL + "WHERE PCRTN_RTLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "' ";
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
				ProjectData.ClearProjectError();
				return;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			RefreshGrid(false);
			RefreshGridUsedGoods();
		}

		private void txtGRLNO_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return))
			{
				numBALQT.Value = Common.gfGetGRLBAL(Conversions.ToString(cbLOCID.SelectedValue), txtGRLNO.Text);
				if (numBALQT.Value == 0.0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Batch No!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					txtGRLNO.Select();
				}
			}
		}

		private void cbRACKNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strWHERE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("INRBAL_LOCID = '", cbLOCID.SelectedValue), "' "));
			strWHERE = Conversions.ToString(Operators.ConcatenateObject(strWHERE, Operators.ConcatenateObject(Operators.ConcatenateObject("AND INRBAL_RACKNO = '", cbRACKNO.SelectedValue), "' ")));
			strWHERE = strWHERE + "AND INRBAL_ITMCD = '" + txtBOMPN.Text + "'";
			numBALQT.Value = Conversions.ToDouble(DB.GetColumnValue("INRBAL_QTY", "INRBAL_TBL", strWHERE));
		}
	}
}
