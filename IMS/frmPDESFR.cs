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
	public class frmPDESFR : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtWKONO")]
		private TextBox _txtWKONO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvBATCH")]
		private DataGridView _dgvBATCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMABOM")]
		private DataGridView _dgvMABOM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDOT")]
		private Button _btnDOT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn0")]
		private Button _btn0;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCANCEL")]
		private Button _btnCANCEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn3")]
		private Button _btn3;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn2")]
		private Button _btn2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn1")]
		private Button _btn1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn6")]
		private Button _btn6;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn5")]
		private Button _btn5;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn4")]
		private Button _btn4;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn9")]
		private Button _btn9;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn8")]
		private Button _btn8;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn7")]
		private Button _btn7;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnACCEPT")]
		private Button _btnACCEPT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvWOBOM")]
		private DataGridView _dgvWOBOM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUPDATE")]
		private Button _btnUPDATE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnFULL")]
		private Button _btnFULL;

		private bool Accept;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSTDWGT")]
		internal virtual TextBox txtSTDWGT
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

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
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

		[field: AccessedThroughProperty("Label19")]
		internal virtual Label Label19
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

		[field: AccessedThroughProperty("Label11")]
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtWKOQTY")]
		internal virtual TextBox txtWKOQTY
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

		[field: AccessedThroughProperty("txtROUCD")]
		internal virtual TextBox txtROUCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREVNO")]
		internal virtual TextBox txtREVNO
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

		[field: AccessedThroughProperty("cbPRTLN")]
		internal virtual ComboBox cbPRTLN
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

		[field: AccessedThroughProperty("cbPROTM")]
		internal virtual ComboBox cbPROTM
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

		internal virtual DataGridView dgvBATCH
		{
			[CompilerGenerated]
			get
			{
				return _dgvBATCH;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvBATCH_CellMouseClick;
				DataGridViewCellMouseEventHandler value3 = dgvBATCH_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvBATCH;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
					dataGridView.CellMouseDoubleClick -= value3;
				}
				_dgvBATCH = value;
				dataGridView = _dgvBATCH;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
					dataGridView.CellMouseDoubleClick += value3;
				}
			}
		}

		internal virtual DataGridView dgvMABOM
		{
			[CompilerGenerated]
			get
			{
				return _dgvMABOM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMABOM_CellMouseClick;
				DataGridViewCellMouseEventHandler value3 = dgvMABOM_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMABOM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
					dataGridView.CellMouseDoubleClick -= value3;
				}
				_dgvMABOM = value;
				dataGridView = _dgvMABOM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
					dataGridView.CellMouseDoubleClick += value3;
				}
			}
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtMSG")]
		internal virtual TextBox txtMSG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtBATCHNO")]
		internal virtual TextBox txtBATCHNO
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

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnDOT
		{
			[CompilerGenerated]
			get
			{
				return _btnDOT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDOT_Click;
				Button button = _btnDOT;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDOT = value;
				button = _btnDOT;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn0
		{
			[CompilerGenerated]
			get
			{
				return _btn0;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn0_Click;
				Button button = _btn0;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn0 = value;
				button = _btn0;
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

		internal virtual Button btn3
		{
			[CompilerGenerated]
			get
			{
				return _btn3;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn3_Click;
				Button button = _btn3;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn3 = value;
				button = _btn3;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn2
		{
			[CompilerGenerated]
			get
			{
				return _btn2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn2_Click;
				Button button = _btn2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn2 = value;
				button = _btn2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn1
		{
			[CompilerGenerated]
			get
			{
				return _btn1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn1_Click;
				Button button = _btn1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn1 = value;
				button = _btn1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn6
		{
			[CompilerGenerated]
			get
			{
				return _btn6;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn6_Click;
				Button button = _btn6;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn6 = value;
				button = _btn6;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn5
		{
			[CompilerGenerated]
			get
			{
				return _btn5;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn5_Click;
				Button button = _btn5;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn5 = value;
				button = _btn5;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn4
		{
			[CompilerGenerated]
			get
			{
				return _btn4;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn4_Click;
				Button button = _btn4;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn4 = value;
				button = _btn4;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn9
		{
			[CompilerGenerated]
			get
			{
				return _btn9;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn9_Click;
				Button button = _btn9;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn9 = value;
				button = _btn9;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn8
		{
			[CompilerGenerated]
			get
			{
				return _btn8;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn8_Click;
				Button button = _btn8;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn8 = value;
				button = _btn8;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btn7
		{
			[CompilerGenerated]
			get
			{
				return _btn7;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btn7_Click;
				Button button = _btn7;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btn7 = value;
				button = _btn7;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnACCEPT
		{
			[CompilerGenerated]
			get
			{
				return _btnACCEPT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnACCEPT_Click;
				Button button = _btnACCEPT;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnACCEPT = value;
				button = _btnACCEPT;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtWEIGHT")]
		internal virtual TextBox txtWEIGHT
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

		[field: AccessedThroughProperty("numFGBUFF")]
		internal virtual NumControl numFGBUFF
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

		[field: AccessedThroughProperty("TabControl1")]
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("tpWO")]
		internal virtual TabPage tpWO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("tpDISP")]
		internal virtual TabPage tpDISP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel7")]
		internal virtual TableLayoutPanel TableLayoutPanel7
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

		internal virtual DataGridView dgvWOBOM
		{
			[CompilerGenerated]
			get
			{
				return _dgvWOBOM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvWOBOM_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvWOBOM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvWOBOM = value;
				dataGridView = _dgvWOBOM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
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
				EventHandler value2 = btnCLOSE_Click;
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numADD")]
		internal virtual NumControl numADD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtISSFG")]
		internal virtual TextBox txtISSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnFULL
		{
			[CompilerGenerated]
			get
			{
				return _btnFULL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnFULL_Click;
				Button button = _btnFULL;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnFULL = value;
				button = _btnFULL;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
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

		public frmPDESFR()
		{
			base.Shown += frmPDESFR_Shown;
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
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.txtISSFG = new System.Windows.Forms.TextBox();
			this.txtMSG = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.txtWKOQTY = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtROUCD = new System.Windows.Forms.TextBox();
			this.txtSTDWGT = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.txtMCHID = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtWKONO = new System.Windows.Forms.TextBox();
			this.txtREVNO = new System.Windows.Forms.TextBox();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.tpWO = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnUPDATE = new System.Windows.Forms.Button();
			this.dgvWOBOM = new System.Windows.Forms.DataGridView();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtBOMPN = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.numADD = new IMS.NumControl();
			this.tpDISP = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.txtWEIGHT = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnFULL = new System.Windows.Forms.Button();
			this.btnACCEPT = new System.Windows.Forms.Button();
			this.btnDOT = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.txtBATCHNO = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dgvBATCH = new System.Windows.Forms.DataGridView();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.numFGBUFF = new IMS.NumControl();
			this.dgvMABOM = new System.Windows.Forms.DataGridView();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtMDLCD = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.cbPROTM = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.cbPRTLN = new System.Windows.Forms.ComboBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.tpWO.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvWOBOM).BeginInit();
			this.tpDISP.SuspendLayout();
			this.TableLayoutPanel7.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvBATCH).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMABOM).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.TableLayoutPanel2);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1516, 788);
			this.Panel1.TabIndex = 0;
			this.TableLayoutPanel2.ColumnCount = 6;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50f));
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.txtISSFG, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.txtMSG, 0, 6);
			this.TableLayoutPanel2.Controls.Add(this.btnClose, 5, 0);
			this.TableLayoutPanel2.Controls.Add(this.txtWKOQTY, 4, 4);
			this.TableLayoutPanel2.Controls.Add(this.Label19, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label11, 3, 4);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.txtROUCD, 4, 3);
			this.TableLayoutPanel2.Controls.Add(this.txtSTDWGT, 1, 4);
			this.TableLayoutPanel2.Controls.Add(this.Label14, 3, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label10, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.txtMCHID, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label13, 0, 4);
			this.TableLayoutPanel2.Controls.Add(this.txtWKONO, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.txtREVNO, 4, 1);
			this.TableLayoutPanel2.Controls.Add(this.TabControl1, 0, 5);
			this.TableLayoutPanel2.Controls.Add(this.Label15, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.txtMDLCD, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label6, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbPROTM, 4, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label7, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbPRTLN, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label9, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCID, 4, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 7;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(1163, 691);
			this.TableLayoutPanel2.TabIndex = 2;
			this.txtISSFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtISSFG.Location = new System.Drawing.Point(414, 3);
			this.txtISSFG.Name = "txtISSFG";
			this.txtISSFG.ReadOnly = true;
			this.txtISSFG.Size = new System.Drawing.Size(44, 30);
			this.txtISSFG.TabIndex = 75;
			this.txtISSFG.TabStop = false;
			this.txtISSFG.Text = "-1";
			this.txtISSFG.Visible = false;
			this.TableLayoutPanel2.SetColumnSpan(this.txtMSG, 5);
			this.txtMSG.ForeColor = System.Drawing.Color.Red;
			this.txtMSG.Location = new System.Drawing.Point(3, 593);
			this.txtMSG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMSG.Multiline = true;
			this.txtMSG.Name = "txtMSG";
			this.txtMSG.ReadOnly = true;
			this.txtMSG.Size = new System.Drawing.Size(810, 96);
			this.txtMSG.TabIndex = 16;
			this.txtMSG.TabStop = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(861, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel2.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 74;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.txtWKOQTY.Location = new System.Drawing.Point(631, 145);
			this.txtWKOQTY.Name = "txtWKOQTY";
			this.txtWKOQTY.ReadOnly = true;
			this.txtWKOQTY.Size = new System.Drawing.Size(116, 30);
			this.txtWKOQTY.TabIndex = 59;
			this.txtWKOQTY.TabStop = false;
			this.txtWKOQTY.Text = "0";
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(464, 41);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(137, 25);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "BOM Revision";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(464, 147);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(132, 25);
			this.Label11.TabIndex = 51;
			this.Label11.Text = "W/O Quantity";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(144, 25);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Work Order No";
			this.txtROUCD.Location = new System.Drawing.Point(631, 109);
			this.txtROUCD.Name = "txtROUCD";
			this.txtROUCD.ReadOnly = true;
			this.txtROUCD.Size = new System.Drawing.Size(224, 30);
			this.txtROUCD.TabIndex = 4;
			this.txtROUCD.TabStop = false;
			this.txtROUCD.Visible = false;
			this.txtSTDWGT.Location = new System.Drawing.Point(168, 145);
			this.txtSTDWGT.Name = "txtSTDWGT";
			this.txtSTDWGT.ReadOnly = true;
			this.txtSTDWGT.Size = new System.Drawing.Size(116, 30);
			this.txtSTDWGT.TabIndex = 48;
			this.txtSTDWGT.TabStop = false;
			this.txtSTDWGT.Text = "0";
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(464, 111);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(63, 25);
			this.Label14.TabIndex = 51;
			this.Label14.Text = "Route";
			this.Label14.Visible = false;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 41);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(119, 25);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Model Code";
			this.txtMCHID.Location = new System.Drawing.Point(168, 109);
			this.txtMCHID.Name = "txtMCHID";
			this.txtMCHID.ReadOnly = true;
			this.txtMCHID.Size = new System.Drawing.Size(240, 30);
			this.txtMCHID.TabIndex = 5;
			this.txtMCHID.TabStop = false;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 147);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(159, 25);
			this.Label13.TabIndex = 48;
			this.Label13.Text = "Standard Weight";
			this.txtWKONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtWKONO.Location = new System.Drawing.Point(168, 3);
			this.txtWKONO.Name = "txtWKONO";
			this.txtWKONO.Size = new System.Drawing.Size(202, 30);
			this.txtWKONO.TabIndex = 3;
			this.txtREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtREVNO.Location = new System.Drawing.Point(631, 39);
			this.txtREVNO.Name = "txtREVNO";
			this.txtREVNO.ReadOnly = true;
			this.txtREVNO.Size = new System.Drawing.Size(116, 30);
			this.txtREVNO.TabIndex = 49;
			this.txtREVNO.TabStop = false;
			this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.TableLayoutPanel2.SetColumnSpan(this.TabControl1, 6);
			this.TabControl1.Controls.Add(this.tpDISP);
			this.TabControl1.Controls.Add(this.tpWO);
			this.TabControl1.Location = new System.Drawing.Point(3, 181);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(1153, 407);
			this.TabControl1.TabIndex = 4;
			this.tpWO.BackColor = System.Drawing.Color.AliceBlue;
			this.tpWO.Controls.Add(this.TableLayoutPanel1);
			this.tpWO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.tpWO.Location = new System.Drawing.Point(4, 37);
			this.tpWO.Margin = new System.Windows.Forms.Padding(0);
			this.tpWO.Name = "tpWO";
			this.tpWO.Size = new System.Drawing.Size(1145, 366);
			this.tpWO.TabIndex = 0;
			this.tpWO.Text = "Work Order";
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Controls.Add(this.btnUPDATE, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.dgvWOBOM, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtBOMPN, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.numADD, 1, 2);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(2, 3);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 5;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(859, 356);
			this.TableLayoutPanel1.TabIndex = 0;
			this.btnUPDATE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnUPDATE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUPDATE.Image = IMS.My.Resources.Resources.Save;
			this.btnUPDATE.Location = new System.Drawing.Point(3, 301);
			this.btnUPDATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUPDATE.Name = "btnUPDATE";
			this.btnUPDATE.Size = new System.Drawing.Size(120, 50);
			this.btnUPDATE.TabIndex = 75;
			this.btnUPDATE.Text = "Update";
			this.btnUPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUPDATE.UseVisualStyleBackColor = false;
			this.dgvWOBOM.AllowUserToAddRows = false;
			this.dgvWOBOM.AllowUserToDeleteRows = false;
			this.dgvWOBOM.AllowUserToResizeColumns = false;
			this.dgvWOBOM.AllowUserToResizeRows = false;
			this.dgvWOBOM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvWOBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvWOBOM, 3);
			this.dgvWOBOM.Location = new System.Drawing.Point(3, 3);
			this.dgvWOBOM.MultiSelect = false;
			this.dgvWOBOM.Name = "dgvWOBOM";
			this.dgvWOBOM.ReadOnly = true;
			this.dgvWOBOM.RowHeadersVisible = false;
			this.dgvWOBOM.RowHeadersWidth = 51;
			this.dgvWOBOM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvWOBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvWOBOM.Size = new System.Drawing.Size(853, 201);
			this.dgvWOBOM.TabIndex = 18;
			this.dgvWOBOM.TabStop = false;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 212);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(98, 25);
			this.Label5.TabIndex = 19;
			this.Label5.Text = "BOM Part";
			this.txtBOMPN.Location = new System.Drawing.Point(129, 210);
			this.txtBOMPN.Name = "txtBOMPN";
			this.txtBOMPN.ReadOnly = true;
			this.txtBOMPN.Size = new System.Drawing.Size(240, 30);
			this.txtBOMPN.TabIndex = 20;
			this.txtBOMPN.TabStop = false;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 248);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(83, 25);
			this.Label8.TabIndex = 21;
			this.Label8.Text = "Addition";
			this.numADD.AllowNegative = false;
			this.numADD.DataChanged = false;
			this.numADD.Location = new System.Drawing.Point(129, 246);
			this.numADD.Name = "numADD";
			this.numADD.NumberFormat = "8.2";
			this.numADD.Size = new System.Drawing.Size(134, 30);
			this.numADD.TabIndex = 63;
			this.numADD.Text = "0.00";
			this.numADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numADD.ThousandSeperator = false;
			this.numADD.Value = 0.0;
			this.tpDISP.BackColor = System.Drawing.Color.AliceBlue;
			this.tpDISP.Controls.Add(this.TableLayoutPanel7);
			this.tpDISP.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.tpDISP.Location = new System.Drawing.Point(4, 37);
			this.tpDISP.Name = "tpDISP";
			this.tpDISP.Padding = new System.Windows.Forms.Padding(3);
			this.tpDISP.Size = new System.Drawing.Size(1145, 366);
			this.tpDISP.TabIndex = 1;
			this.tpDISP.Text = "Dispensing";
			this.TableLayoutPanel7.ColumnCount = 7;
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.Controls.Add(this.txtWEIGHT, 6, 1);
			this.TableLayoutPanel7.Controls.Add(this.TableLayoutPanel6, 5, 2);
			this.TableLayoutPanel7.Controls.Add(this.txtBATCHNO, 1, 0);
			this.TableLayoutPanel7.Controls.Add(this.Label3, 5, 1);
			this.TableLayoutPanel7.Controls.Add(this.dgvBATCH, 0, 1);
			this.TableLayoutPanel7.Controls.Add(this.Label2, 0, 0);
			this.TableLayoutPanel7.Controls.Add(this.Label4, 3, 0);
			this.TableLayoutPanel7.Controls.Add(this.numFGBUFF, 4, 0);
			this.TableLayoutPanel7.Controls.Add(this.dgvMABOM, 3, 1);
			this.TableLayoutPanel7.Location = new System.Drawing.Point(4, 7);
			this.TableLayoutPanel7.Name = "TableLayoutPanel7";
			this.TableLayoutPanel7.RowCount = 3;
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.Size = new System.Drawing.Size(1135, 361);
			this.TableLayoutPanel7.TabIndex = 0;
			this.txtWEIGHT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtWEIGHT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtWEIGHT.Location = new System.Drawing.Point(951, 39);
			this.txtWEIGHT.Name = "txtWEIGHT";
			this.txtWEIGHT.Size = new System.Drawing.Size(172, 30);
			this.txtWEIGHT.TabIndex = 5;
			this.txtWEIGHT.Text = "0.00";
			this.txtWEIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel7.SetColumnSpan(this.TableLayoutPanel6, 2);
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnFULL, 0, 4);
			this.TableLayoutPanel6.Controls.Add(this.btnACCEPT, 0, 4);
			this.TableLayoutPanel6.Controls.Add(this.btnDOT, 3, 3);
			this.TableLayoutPanel6.Controls.Add(this.btn0, 1, 3);
			this.TableLayoutPanel6.Controls.Add(this.btnCANCEL, 0, 3);
			this.TableLayoutPanel6.Controls.Add(this.btn3, 3, 2);
			this.TableLayoutPanel6.Controls.Add(this.btn2, 1, 2);
			this.TableLayoutPanel6.Controls.Add(this.btn1, 0, 2);
			this.TableLayoutPanel6.Controls.Add(this.btn6, 3, 1);
			this.TableLayoutPanel6.Controls.Add(this.btn5, 1, 1);
			this.TableLayoutPanel6.Controls.Add(this.btn4, 0, 1);
			this.TableLayoutPanel6.Controls.Add(this.btn9, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btn8, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btn7, 0, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(868, 72);
			this.TableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 5;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Size = new System.Drawing.Size(267, 289);
			this.TableLayoutPanel6.TabIndex = 19;
			this.btnFULL.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnFULL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel6.SetColumnSpan(this.btnFULL, 2);
			this.btnFULL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnFULL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnFULL.Image = IMS.My.Resources.Resources.Confirm;
			this.btnFULL.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFULL.Location = new System.Drawing.Point(2, 226);
			this.btnFULL.Margin = new System.Windows.Forms.Padding(2);
			this.btnFULL.Name = "btnFULL";
			this.btnFULL.Size = new System.Drawing.Size(116, 60);
			this.btnFULL.TabIndex = 12;
			this.btnFULL.TabStop = false;
			this.btnFULL.Text = "Accept Full";
			this.btnFULL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFULL.UseVisualStyleBackColor = false;
			this.btnACCEPT.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnACCEPT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel6.SetColumnSpan(this.btnACCEPT, 2);
			this.btnACCEPT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnACCEPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnACCEPT.Image = IMS.My.Resources.Resources.Confirm;
			this.btnACCEPT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnACCEPT.Location = new System.Drawing.Point(122, 226);
			this.btnACCEPT.Margin = new System.Windows.Forms.Padding(2);
			this.btnACCEPT.Name = "btnACCEPT";
			this.btnACCEPT.Size = new System.Drawing.Size(116, 60);
			this.btnACCEPT.TabIndex = 5;
			this.btnACCEPT.TabStop = false;
			this.btnACCEPT.Text = "Accept";
			this.btnACCEPT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnACCEPT.UseVisualStyleBackColor = false;
			this.btnDOT.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnDOT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDOT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDOT.Location = new System.Drawing.Point(165, 171);
			this.btnDOT.Name = "btnDOT";
			this.btnDOT.Size = new System.Drawing.Size(75, 50);
			this.btnDOT.TabIndex = 11;
			this.btnDOT.TabStop = false;
			this.btnDOT.Text = ".";
			this.btnDOT.UseVisualStyleBackColor = false;
			this.btn0.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel6.SetColumnSpan(this.btn0, 2);
			this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn0.Location = new System.Drawing.Point(84, 171);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(75, 50);
			this.btn0.TabIndex = 10;
			this.btn0.TabStop = false;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = false;
			this.btnCANCEL.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCANCEL.Location = new System.Drawing.Point(3, 171);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.Size = new System.Drawing.Size(75, 50);
			this.btnCANCEL.TabIndex = 9;
			this.btnCANCEL.TabStop = false;
			this.btnCANCEL.Text = "C";
			this.btnCANCEL.UseVisualStyleBackColor = false;
			this.btn3.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn3.Location = new System.Drawing.Point(165, 115);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(75, 50);
			this.btn3.TabIndex = 8;
			this.btn3.TabStop = false;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn2.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel6.SetColumnSpan(this.btn2, 2);
			this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn2.Location = new System.Drawing.Point(84, 115);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(75, 50);
			this.btn2.TabIndex = 7;
			this.btn2.TabStop = false;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn1.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn1.Location = new System.Drawing.Point(3, 115);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(75, 50);
			this.btn1.TabIndex = 6;
			this.btn1.TabStop = false;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn6.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn6.Location = new System.Drawing.Point(165, 59);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(75, 50);
			this.btn6.TabIndex = 5;
			this.btn6.TabStop = false;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = false;
			this.btn5.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel6.SetColumnSpan(this.btn5, 2);
			this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn5.Location = new System.Drawing.Point(84, 59);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(75, 50);
			this.btn5.TabIndex = 4;
			this.btn5.TabStop = false;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = false;
			this.btn4.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn4.Location = new System.Drawing.Point(3, 59);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(75, 50);
			this.btn4.TabIndex = 3;
			this.btn4.TabStop = false;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn9.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn9.Location = new System.Drawing.Point(165, 3);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(75, 50);
			this.btn9.TabIndex = 2;
			this.btn9.TabStop = false;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = false;
			this.btn8.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.TableLayoutPanel6.SetColumnSpan(this.btn8, 2);
			this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn8.Location = new System.Drawing.Point(84, 3);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(75, 50);
			this.btn8.TabIndex = 1;
			this.btn8.TabStop = false;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = false;
			this.btn7.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn7.Location = new System.Drawing.Point(3, 3);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(75, 50);
			this.btn7.TabIndex = 0;
			this.btn7.TabStop = false;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = false;
			this.txtBATCHNO.Location = new System.Drawing.Point(71, 3);
			this.txtBATCHNO.Name = "txtBATCHNO";
			this.txtBATCHNO.ReadOnly = true;
			this.txtBATCHNO.Size = new System.Drawing.Size(224, 30);
			this.txtBATCHNO.TabIndex = 61;
			this.txtBATCHNO.TabStop = false;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(871, 41);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(74, 25);
			this.Label3.TabIndex = 61;
			this.Label3.Text = "Weight";
			this.dgvBATCH.AllowUserToAddRows = false;
			this.dgvBATCH.AllowUserToDeleteRows = false;
			this.dgvBATCH.AllowUserToResizeColumns = false;
			this.dgvBATCH.AllowUserToResizeRows = false;
			this.dgvBATCH.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvBATCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel7.SetColumnSpan(this.dgvBATCH, 2);
			this.dgvBATCH.Location = new System.Drawing.Point(3, 39);
			this.dgvBATCH.MultiSelect = false;
			this.dgvBATCH.Name = "dgvBATCH";
			this.dgvBATCH.ReadOnly = true;
			this.dgvBATCH.RowHeadersVisible = false;
			this.dgvBATCH.RowHeadersWidth = 51;
			this.TableLayoutPanel7.SetRowSpan(this.dgvBATCH, 2);
			this.dgvBATCH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvBATCH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBATCH.Size = new System.Drawing.Size(392, 318);
			this.dgvBATCH.TabIndex = 17;
			this.dgvBATCH.TabStop = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 5);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(62, 25);
			this.Label2.TabIndex = 60;
			this.Label2.Text = "Batch";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(421, 5);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(95, 25);
			this.Label4.TabIndex = 61;
			this.Label4.Text = "FG Buffer";
			this.numFGBUFF.AllowNegative = false;
			this.numFGBUFF.DataChanged = false;
			this.numFGBUFF.Location = new System.Drawing.Point(522, 3);
			this.numFGBUFF.Name = "numFGBUFF";
			this.numFGBUFF.NumberFormat = "8.2";
			this.numFGBUFF.Size = new System.Drawing.Size(134, 30);
			this.numFGBUFF.TabIndex = 62;
			this.numFGBUFF.Text = "0.00";
			this.numFGBUFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFGBUFF.ThousandSeperator = false;
			this.numFGBUFF.Value = 0.0;
			this.dgvMABOM.AllowUserToAddRows = false;
			this.dgvMABOM.AllowUserToDeleteRows = false;
			this.dgvMABOM.AllowUserToResizeColumns = false;
			this.dgvMABOM.AllowUserToResizeRows = false;
			this.dgvMABOM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMABOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel7.SetColumnSpan(this.dgvMABOM, 2);
			this.dgvMABOM.Location = new System.Drawing.Point(421, 39);
			this.dgvMABOM.MultiSelect = false;
			this.dgvMABOM.Name = "dgvMABOM";
			this.dgvMABOM.ReadOnly = true;
			this.dgvMABOM.RowHeadersVisible = false;
			this.dgvMABOM.RowHeadersWidth = 51;
			this.TableLayoutPanel7.SetRowSpan(this.dgvMABOM, 2);
			this.dgvMABOM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvMABOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMABOM.Size = new System.Drawing.Size(444, 318);
			this.dgvMABOM.TabIndex = 18;
			this.dgvMABOM.TabStop = false;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 111);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(87, 25);
			this.Label15.TabIndex = 55;
			this.Label15.Text = "Machine";
			this.txtMDLCD.Location = new System.Drawing.Point(168, 39);
			this.txtMDLCD.Name = "txtMDLCD";
			this.txtMDLCD.ReadOnly = true;
			this.txtMDLCD.Size = new System.Drawing.Size(240, 30);
			this.txtMDLCD.TabIndex = 4;
			this.txtMDLCD.TabStop = false;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 76);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(93, 25);
			this.Label6.TabIndex = 72;
			this.Label6.Text = "Print Line";
			this.cbPROTM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbPROTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPROTM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbPROTM.FormattingEnabled = true;
			this.cbPROTM.Location = new System.Drawing.Point(631, 75);
			this.cbPROTM.Name = "cbPROTM";
			this.cbPROTM.Size = new System.Drawing.Size(188, 28);
			this.cbPROTM.TabIndex = 65;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(464, 76);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(161, 25);
			this.Label7.TabIndex = 73;
			this.Label7.Text = "Production Team";
			this.cbPRTLN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbPRTLN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPRTLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbPRTLN.FormattingEnabled = true;
			this.cbPRTLN.Location = new System.Drawing.Point(168, 75);
			this.cbPRTLN.Name = "cbPRTLN";
			this.cbPRTLN.Size = new System.Drawing.Size(134, 28);
			this.cbPRTLN.TabIndex = 71;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(464, 5);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(86, 25);
			this.Label9.TabIndex = 76;
			this.Label9.Text = "Location";
			this.cbLOCID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(631, 4);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(134, 28);
			this.cbLOCID.TabIndex = 77;
			base.AutoScaleDimensions = new System.Drawing.SizeF(12f, 25f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1177, 749);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "frmPDESFR";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			base.Tag = "PDESFR";
			this.Text = "Shop Floor Reporting";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.tpWO.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvWOBOM).EndInit();
			this.tpDISP.ResumeLayout(false);
			this.TableLayoutPanel7.ResumeLayout(false);
			this.TableLayoutPanel7.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvBATCH).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMABOM).EndInit();
			base.ResumeLayout(false);
		}

		private void InitScreen()
		{
			Point aLocation = Panel1.Location;
			aLocation.X = 0;
			aLocation.Y = 0;
			Size aSize = Panel1.Size;
			aSize.Width = base.Size.Width;
			aSize.Height = base.Size.Height;
			Panel1.Location = aLocation;
			Panel1.Size = aSize;
			checked
			{
				aLocation.X = (int)Math.Round((double)(Panel1.Size.Width - TableLayoutPanel2.Size.Width) / 2.0);
				aLocation.Y = (int)Math.Round((double)(Panel1.Size.Height - TableLayoutPanel2.Size.Height) / 2.0);
				TableLayoutPanel2.Location = aLocation;
				Panel1.Visible = true;
			}
		}

		private void BindDetailComboBox()
		{
			string strSQL = "SELECT MALOC_LOCID, MALOC_LOCNM FROM MALOC_TBL WITH (NOLOCK) ";
			strSQL += "WHERE MALOC_LOCTY = 'FG' ORDER BY MALOC_LOCID";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'PRTLN' ORDER BY MACOD_CODID";
			cbPRTLN.ValueMember = "MACOD_CODID";
			cbPRTLN.DisplayMember = "MACOD_CODID";
			Common.RetriveComboItembySQL(strSQL, cbPRTLN);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'SHIFT' ORDER BY MACOD_CODID";
			cbPROTM.ValueMember = "MACOD_CODID";
			cbPROTM.DisplayMember = "MACOD_CODID";
			Common.RetriveComboItembySQL(strSQL, cbPROTM);
		}

		private void frmPDESFR_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			InitScreen();
		}

		private void txtWKONO_KeyDown(object sender, KeyEventArgs e)
		{
			txtMSG.Text = string.Empty;
			if (!e.KeyCode.Equals(Keys.Return) || !ValidWorkOrderNo())
			{
				return;
			}
			BindDetailComboBox();
			BindHeaderControl();
			string strSQL = "SELECT * FROM PDSFR_WRK1 WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			if (DB.RecordExists(strSQL) || GenerateWorkFile())
			{
				if (Operators.CompareString(txtISSFG.Text, "0", false) == 0)
				{
					btnUPDATE.Enabled = false;
				}
				else
				{
					btnUPDATE.Enabled = true;
				}
				BindWorkOrderBOM();
				BindGridBatch();
				checkBATCHNO();
				BindGridBom();
				enableButton();
				selectionRow();
			}
		}

		private void checkBATCHNO()
		{
			string lastBATCHNO = txtBATCHNO.Text;
			string strWHERE = "PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strWHERE += "AND PDSFR_STSFG = 0 ";
			if (!DB.RecordExists("SELECT * FROM PDSFR_WRK1 WITH (NOLOCK) WHERE " + strWHERE + " "))
			{
				if (!spPDESFR())
				{
					return;
				}
				ClearHeader();
			}
			else
			{
				txtBATCHNO.Text = Conversions.ToString(DB.GetColumnValue("ISNULL(MIN(PDSFR_BATCHNO),'')", "PDSFR_WRK1 WITH (NOLOCK)", strWHERE));
				if (Operators.CompareString(txtBATCHNO.Text, lastBATCHNO, false) != 0)
				{
					txtWEIGHT.Text = Conversions.ToString(0.0);
					enableButton();
				}
				txtWEIGHT.Focus();
			}
			string PRTLN = Conversions.ToString(DB.GetColumnValue("PDSFR_PRTLN", "PDSFR_WRK1", "PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' "));
			if (Operators.CompareString(PRTLN, "", false) != 0)
			{
				cbPRTLN.SelectedValue = PRTLN;
				cbPRTLN.Enabled = false;
			}
			string PROTM = Conversions.ToString(DB.GetColumnValue("PDSFR_SHIFT", "PDSFR_WRK1", "PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' "));
			if (Operators.CompareString(PROTM, "", false) != 0)
			{
				cbPROTM.SelectedValue = PROTM;
				cbPROTM.Enabled = false;
			}
		}

		private bool spPDESFR()
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spPDESFR ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWKONO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(txtSTDWGT.Text)) + ", ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(txtISSFG.Text)) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(numFGBUFF.Value)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
			bool spPDESFR;
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
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), ex.Message.ToString());
				spPDESFR = false;
				ProjectData.ClearProjectError();
				goto IL_017c;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			spPDESFR = true;
			goto IL_017c;
			IL_017c:
			return spPDESFR;
		}

		private void ClearHeader()
		{
			txtWKONO.Text = string.Empty;
			txtMCHID.Text = string.Empty;
			txtMDLCD.Text = string.Empty;
			txtREVNO.Text = string.Empty;
			txtROUCD.Text = string.Empty;
			txtMSG.Text = string.Empty;
			txtSTDWGT.Text = Conversions.ToString(0);
			txtWKOQTY.Text = Conversions.ToString(0);
			txtWEIGHT.Text = Conversions.ToString(0.0);
			cbPRTLN.SelectedIndex = -1;
			cbPROTM.SelectedIndex = -1;
			txtBATCHNO.Text = string.Empty;
			btnACCEPT.Enabled = true;
			cbPROTM.Enabled = true;
			cbPRTLN.Enabled = true;
			txtWKONO.Enabled = true;
			btn0.Enabled = true;
			btn1.Enabled = true;
			btn2.Enabled = true;
			btn3.Enabled = true;
			btn4.Enabled = true;
			btn5.Enabled = true;
			btn6.Enabled = true;
			btn7.Enabled = true;
			btn8.Enabled = true;
			btn9.Enabled = true;
			btnDOT.Enabled = true;
			btnCANCEL.Enabled = true;
			txtWEIGHT.Enabled = true;
		}

		private void BindHeaderControl()
		{
			string strSQL = "SELECT DISTINCT PDWKO_MDLCD, PDWKO_REVNO, PDWKO_ROUCD, ";
			strSQL += "PDWKO_MCHID, PDWKO_WOQTY, MAMCH_ISSFG, MACOD_NFLD1 ";
			strSQL += "FROM PDWKO_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAMCH_TBL WITH (NOLOCK) ON MAMCH_MCHID = PDWKO_MCHID ";
			strSQL += "LEFT JOIN MACOD_TBL WITH (NOLOCK) ON MACOD_CTYID = 'PACKING' AND MACOD_CODID = PDWKO_PACKING ";
			strSQL = strSQL + "WHERE PDWKO_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			if (dt != null && dt.Rows.Count > 0)
			{
				txtMDLCD.Text = Common.gfValidSQLStr(dt.Rows[0]["PDWKO_MDLCD"].ToString());
				txtREVNO.Text = Common.gfValidSQLStr(dt.Rows[0]["PDWKO_REVNO"].ToString());
				txtROUCD.Text = Common.gfValidSQLStr(dt.Rows[0]["PDWKO_ROUCD"].ToString());
				txtMCHID.Text = Common.gfValidSQLStr(dt.Rows[0]["PDWKO_MCHID"].ToString());
				txtWKOQTY.Text = Common.gfValidSQLStr(dt.Rows[0]["PDWKO_WOQTY"].ToString());
				txtISSFG.Text = Common.gfValidSQLStr(dt.Rows[0]["MAMCH_ISSFG"].ToString());
				txtSTDWGT.Text = Common.gfValidSQLStr(dt.Rows[0]["MACOD_NFLD1"].ToString());
			}
		}

		private void BindWorkOrderBOM()
		{
			string strSQL = "SELECT PDWKB_BOMPN, PDWKB_PARQT, PDWKB_ISSQT, PDWKB_ADDQT ";
			strSQL = strSQL + "FROM PDWKB_TBL WHERE PDWKB_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvWOBOM;
			dataGridView.DataSource = dt;
			int i = default(int);
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 180;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "BOM Part");
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].ReadOnly = true;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Quantity");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Issued");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Addition");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
				dataGridView.Columns[i].ReadOnly = true;
				dataGridView.AutoResizeRows();
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.ClearSelection();
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void BindGridBatch()
		{
			int i = 0;
			dgvBATCH.DataSource = null;
			string strSQL = "SELECT PDSFR_BATCHNO, CASE WHEN PDSFR_STSFG = 0 THEN 'Pending' ELSE 'Done' END AS PDSFR_STSFG, PDSFR_WEIGHT ";
			strSQL += "FROM PDSFR_WRK1 WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strSQL = strSQL + "AND PDSFR_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
			strSQL += "ORDER BY PDSFR_RECID ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvBATCH;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Weight");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.ClearSelection();
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void BindGridBom()
		{
			int i = 0;
			dgvMABOM.DataSource = null;
			string strSQL = "SELECT PDSFR_LINENO, PDSFR_BOMPN, PDSFR_PARQT, ";
			strSQL += "PDSFR_RATIO, PDSFR_TARGET, PDSFR_ACTUAL ";
			strSQL += "FROM PDSFR_WRK2 WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strSQL = strSQL + "AND PDSFR_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
			strSQL = strSQL + "AND PDSFR_BATCHNO = '" + Common.gfValidSQLStr(txtBATCHNO.Text) + "' ";
			strSQL += "ORDER BY PDSFR_LINENO ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvMABOM;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 60;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "BOM Part");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Quantity");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ratio");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.XRate);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 90;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Target");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 90;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Actual");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.ClearSelection();
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void selectionRow()
		{
			checked
			{
				int num = dgvBATCH.Rows.Count - 1;
				for (int j = 0; j <= num; j++)
				{
					if (Operators.ConditionalCompareObjectEqual(txtBATCHNO.Text, dgvBATCH.Rows[j].Cells["PDSFR_BATCHNO"].Value, false))
					{
						dgvBATCH.Rows[j].Selected = true;
					}
				}
				string strWHERE = "PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
				strWHERE = strWHERE + "AND PDSFR_BATCHNO = '" + Common.gfValidSQLStr(txtBATCHNO.Text) + "' ";
				strWHERE += "AND PDSFR_STSFG = 0 ";
				int lineNo = Conversions.ToInteger(DB.GetColumnValue("ISNULL(MIN(PDSFR_LINENO),0)", "PDSFR_WRK2 WITH(NOLOCK)", strWHERE));
				int num2 = dgvMABOM.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(lineNo, dgvMABOM.Rows[i].Cells["PDSFR_LINENO"].Value, false))
					{
						dgvMABOM.Rows[i].Selected = true;
						txtWEIGHT.Text = Conversions.ToString(dgvMABOM.Rows[i].Cells["PDSFR_ACTUAL"].Value);
					}
				}
			}
		}

		private bool GenerateWorkFile()
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spPDESFR_WRK ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWKONO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtMDLCD.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtREVNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtSTDWGT.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWKOQTY.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(txtISSFG.Text)) + ", ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
			bool GenerateWorkFile;
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
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), ex.Message.ToString());
				GenerateWorkFile = false;
				ProjectData.ClearProjectError();
				goto IL_016b;
			}
			GenerateWorkFile = true;
			goto IL_016b;
			IL_016b:
			return GenerateWorkFile;
		}

		private bool ValidWorkOrderNo()
		{
			if (Operators.CompareString(txtWKONO.Text, string.Empty, false) == 0)
			{
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order cannot black!");
				txtWKONO.Focus();
				return false;
			}
			string strSQL = "SELECT * FROM PDWKO_TBL WITH(NOLOCK) ";
			strSQL += "LEFT JOIN MAMCH_TBL ON MAMCH_MCHID = PDWKO_MCHID ";
			strSQL = strSQL + "WHERE PDWKO_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strSQL += "AND ((PDWKO_STSFG = 2 AND MAMCH_ISSFG = 1) OR (PDWKO_STSFG = 1 AND MAMCH_ISSFG = 0))";
			if (!DB.RecordExists(strSQL))
			{
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Work Order No!");
				txtWKONO.Focus();
				return false;
			}
			strSQL = "SELECT * FROM PDSFR_WRK1 WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strSQL = strSQL + "AND PDSFR_PRNID <> '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
			if (DB.RecordExists(strSQL))
			{
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order is under another computer!");
				txtWKONO.Focus();
				return false;
			}
			txtWKONO.Enabled = false;
			return true;
		}

		private void dgvBATCH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtMSG.Text = string.Empty;
			string strWHERE = "PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strWHERE += "AND PDSFR_STSFG = 0 ";
			string batchNO = Conversions.ToString(DB.GetColumnValue("ISNULL(MIN(PDSFR_BATCHNO),0)", "PDSFR_WRK1 WITH (NOLOCK)", strWHERE));
			if (Operators.CompareString(batchNO, dgvBATCH.CurrentRow.Cells["PDSFR_BATCHNO"].Value.ToString(), false) >= 0)
			{
				txtBATCHNO.Text = Common.gfValidSQLStr(dgvBATCH.CurrentRow.Cells["PDSFR_BATCHNO"].Value.ToString());
				BindGridBom();
				enableButton();
			}
			selectionRow();
		}

		private void enableButton()
		{
			string MCHID = Conversions.ToString(DB.GetColumnValue("DISTINCT PDWKO_MCHID", "PDWKO_TBL WITH(NOLOCK)", "PDWKO_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' "));
			if (Operators.CompareString(MCHID, "MMIX", false) == 0)
			{
				btn0.Enabled = false;
				btn1.Enabled = false;
				btn2.Enabled = false;
				btn3.Enabled = false;
				btn4.Enabled = false;
				btn5.Enabled = false;
				btn6.Enabled = false;
				btn7.Enabled = false;
				btn8.Enabled = false;
				btn9.Enabled = false;
				btnDOT.Enabled = false;
				btnCANCEL.Enabled = false;
				txtWEIGHT.Enabled = false;
			}
			else
			{
				btn0.Enabled = true;
				btn1.Enabled = true;
				btn2.Enabled = true;
				btn3.Enabled = true;
				btn4.Enabled = true;
				btn5.Enabled = true;
				btn6.Enabled = true;
				btn7.Enabled = true;
				btn8.Enabled = true;
				btn9.Enabled = true;
				btnDOT.Enabled = true;
				btnCANCEL.Enabled = true;
				txtWEIGHT.Enabled = true;
			}
			string strSQL = "SELECT * FROM PDSFR_WRK2 WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE PDSFR_WKONO = '" + Common.gfValidSQLStr(txtWKONO.Text) + "' ";
			strSQL = strSQL + "AND PDSFR_BATCHNO = '" + Common.gfValidSQLStr(txtBATCHNO.Text) + "' ";
			strSQL += "AND PDSFR_STSFG = '0' ";
			if (!DB.RecordExists(strSQL))
			{
				btnACCEPT.Enabled = false;
			}
			else
			{
				btnACCEPT.Enabled = true;
			}
		}

		private void getNumber(string Number)
		{
			if (Operators.CompareString(txtWEIGHT.Text, "0", false) == 0)
			{
				txtWEIGHT.Text = "";
				txtWEIGHT.Text = Number;
				Accept = true;
			}
			else if (Accept)
			{
				txtWEIGHT.Text += Number;
			}
			else
			{
				txtWEIGHT.Text = "";
				txtWEIGHT.Text = Number;
				Accept = true;
			}
		}

		private void btnACCEPT_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			txtMSG.Text = string.Empty;
			if (Operators.CompareString(txtWKONO.Text, string.Empty, false) == 0)
			{
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work order cannot blank!");
				txtWKONO.Focus();
				return;
			}
			if (Conversion.Val(txtWEIGHT.Text) == 0.0)
			{
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Weight must more than 0!");
				txtWEIGHT.Focus();
				return;
			}
			string strSQL = "EXEC spPDESFR_ACCEPT 0, ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWKONO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtBATCHNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtMDLCD.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtREVNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtSTDWGT.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWEIGHT.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPRTLN.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPROTM.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
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
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), ex.Message.ToString());
				ProjectData.ClearProjectError();
				return;
			}
			Accept = false;
			checkBATCHNO();
			BindGridBatch();
			BindGridBom();
			selectionRow();
		}

		private void btnFULL_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			txtMSG.Text = string.Empty;
			if (Operators.CompareString(txtWKONO.Text, string.Empty, false) == 0)
			{
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work order cannot blank!");
				txtWKONO.Focus();
				return;
			}
			if (Conversion.Val(txtWEIGHT.Text) == 0.0)
			{
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Weight must more than 0!");
				txtWEIGHT.Focus();
				return;
			}
			string strSQL = "EXEC spPDESFR_ACCEPT 1, ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWKONO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtBATCHNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtMDLCD.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtREVNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtSTDWGT.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWEIGHT.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPRTLN.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbPROTM.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
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
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), ex.Message.ToString());
				ProjectData.ClearProjectError();
				return;
			}
			Accept = false;
			checkBATCHNO();
			BindGridBatch();
			BindGridBom();
			selectionRow();
		}

		private void btnCLOSE_Click(object sender, EventArgs e)
		{
			ClearHeader();
			Close();
		}

		private void btn7_Click(object sender, EventArgs e)
		{
			getNumber("7");
		}

		private void btn8_Click(object sender, EventArgs e)
		{
			getNumber("8");
		}

		private void btn9_Click(object sender, EventArgs e)
		{
			getNumber("9");
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			getNumber("4");
		}

		private void btn5_Click(object sender, EventArgs e)
		{
			getNumber("5");
		}

		private void btn6_Click(object sender, EventArgs e)
		{
			getNumber("6");
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			getNumber("1");
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			getNumber("2");
		}

		private void btn3_Click(object sender, EventArgs e)
		{
			getNumber("3");
		}

		private void btn0_Click(object sender, EventArgs e)
		{
			getNumber("0");
		}

		private void btnDOT_Click(object sender, EventArgs e)
		{
			getNumber(".");
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			txtWEIGHT.Text = Conversions.ToString(0.0);
		}

		private void dgvMABOM_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			selectionRow();
		}

		private void dgvBATCH_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			selectionRow();
		}

		private void dgvMABOM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			selectionRow();
		}

		private void dgvWOBOM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtBOMPN.Text = Conversions.ToString(dgvWOBOM.CurrentRow.Cells["PDWKB_BOMPN"].Value);
			numADD.Value = Conversions.ToDouble(dgvWOBOM.CurrentRow.Cells["PDWKB_ADDQT"].Value);
		}

		private void btnUPDATE_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spPDESFR_ADD ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtWKONO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtBOMPN.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(numADD.Value) + ", ";
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
				txtMSG.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), ex.Message.ToString());
				ProjectData.ClearProjectError();
				return;
			}
			BindWorkOrderBOM();
		}
	}
}
