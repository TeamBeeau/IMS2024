using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Spire.Barcode;
using DataTable = System.Data.DataTable;

namespace IMS
{
    [DesignerGenerated]
	public class frmPDEWKO : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private System.Windows.Forms.Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private System.Windows.Forms.Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPrint")]
		private System.Windows.Forms.Button _btnPrint;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private System.Windows.Forms.Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private System.Windows.Forms.Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private System.Windows.Forms.Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private System.Windows.Forms.Button _btnNew;

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
		[AccessedThroughProperty("numWKOQTY")]
		private NumControl _numWKOQTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRELEASE")]
		private System.Windows.Forms.Button _btnRELEASE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbLOCID")]
		private ComboBox _cbLOCID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDeleteAD")]
		private System.Windows.Forms.Button _btnDeleteAD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCert")]
		private System.Windows.Forms.Button _btnCert;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvPDWKP")]
		private DataGridView _dgvPDWKP;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnAdd")]
		private System.Windows.Forms.Button _btnAdd;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRemove")]
		private System.Windows.Forms.Button _btnRemove;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnEXCEL")]
		private System.Windows.Forms.Button _btnEXCEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbPACKING")]
		private ComboboxControl _cbPACKING;

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
		internal virtual System.Windows.Forms.Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDOCNO")]
		internal virtual System.Windows.Forms.TextBox txtDOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label10")]
		internal virtual System.Windows.Forms.Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label19")]
		internal virtual System.Windows.Forms.Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvSLORD")]
		internal virtual DataGridView dgvSLORD
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

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnSave
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
				System.Windows.Forms.Button button = _btnSave;
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

		internal virtual System.Windows.Forms.Button btnDelete
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
				System.Windows.Forms.Button button = _btnDelete;
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

		internal virtual System.Windows.Forms.Button btnPrint
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
				System.Windows.Forms.Button button = _btnPrint;
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

		internal virtual System.Windows.Forms.Button btnBack
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
				System.Windows.Forms.Button button = _btnBack;
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

		internal virtual System.Windows.Forms.Button btnSEARCH
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
				System.Windows.Forms.Button button = _btnSEARCH;
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

		internal virtual System.Windows.Forms.Button btnClose
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
				System.Windows.Forms.Button button = _btnClose;
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

		internal virtual System.Windows.Forms.Button btnNew
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
				System.Windows.Forms.Button button = _btnNew;
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual System.Windows.Forms.Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual System.Windows.Forms.Label Label1
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual System.Windows.Forms.Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTDWGT")]
		internal virtual System.Windows.Forms.Label lblSTDWGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual System.Windows.Forms.TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label6")]
		internal virtual System.Windows.Forms.Label Label6
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

		[field: AccessedThroughProperty("lblONHAND")]
		internal virtual System.Windows.Forms.Label lblONHAND
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblWKOQTY")]
		internal virtual System.Windows.Forms.Label lblWKOQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblWIPQTY")]
		internal virtual System.Windows.Forms.Label lblWIPQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label16")]
		internal virtual System.Windows.Forms.Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label14")]
		internal virtual System.Windows.Forms.Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label15")]
		internal virtual System.Windows.Forms.Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbROUCD")]
		internal virtual ComboBox cbROUCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbMCHID")]
		internal virtual ComboBox cbMCHID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtRECID")]
		internal virtual System.Windows.Forms.TextBox txtRECID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual NumControl numWKOQTY
		{
			[CompilerGenerated]
			get
			{
				return _numWKOQTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = numWKOQTY_KeyDown;
				NumControl numControl = _numWKOQTY;
				if (numControl != null)
				{
					numControl.KeyDown -= value2;
				}
				_numWKOQTY = value;
				numControl = _numWKOQTY;
				if (numControl != null)
				{
					numControl.KeyDown += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Button btnRELEASE
		{
			[CompilerGenerated]
			get
			{
				return _btnRELEASE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRELEASE_Click;
				System.Windows.Forms.Button button = _btnRELEASE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRELEASE = value;
				button = _btnRELEASE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("lblFGBUFF")]
		internal virtual System.Windows.Forms.Label lblFGBUFF
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbTOLRN")]
		internal virtual ComboBox cbTOLRN
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual System.Windows.Forms.Label Label3
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

		[field: AccessedThroughProperty("numOHQTY")]
		internal virtual NumControl numOHQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numWIPQT")]
		internal virtual NumControl numWIPQT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTYPE")]
		internal virtual System.Windows.Forms.TextBox txtTYPE
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual System.Windows.Forms.Label Label7
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual System.Windows.Forms.Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbEXSPCK")]
		internal virtual ComboBox cbEXSPCK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label9")]
		internal virtual System.Windows.Forms.Label Label9
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
		internal virtual System.Windows.Forms.Label Label11
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

		internal virtual System.Windows.Forms.Button btnDeleteAD
		{
			[CompilerGenerated]
			get
			{
				return _btnDeleteAD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDeleteAD_Click;
				System.Windows.Forms.Button button = _btnDeleteAD;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDeleteAD = value;
				button = _btnDeleteAD;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("dtpENTDT")]
		internal virtual DateTimePicker dtpENTDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTTLQTY")]
		internal virtual System.Windows.Forms.Label lblTTLQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numTOTAL")]
		internal virtual NumControl numTOTAL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvPDPRQ")]
		internal virtual DataGridView dgvPDPRQ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnCert
		{
			[CompilerGenerated]
			get
			{
				return _btnCert;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCert_Click;
				System.Windows.Forms.Button button = _btnCert;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCert = value;
				button = _btnCert;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual DataGridView dgvPDWKP
		{
			[CompilerGenerated]
			get
			{
				return _dgvPDWKP;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvPDWKP_CellMouseClick;
				DataGridView dataGridView = _dgvPDWKP;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvPDWKP = value;
				dataGridView = _dgvPDWKP;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual System.Windows.Forms.Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label13")]
		internal virtual System.Windows.Forms.Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label17")]
		internal virtual System.Windows.Forms.Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numPacking")]
		internal virtual NumControl numPacking
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnAdd
		{
			[CompilerGenerated]
			get
			{
				return _btnAdd;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnAdd_Click;
				System.Windows.Forms.Button button = _btnAdd;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnAdd = value;
				button = _btnAdd;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Button btnRemove
		{
			[CompilerGenerated]
			get
			{
				return _btnRemove;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRemove_Click;
				System.Windows.Forms.Button button = _btnRemove;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRemove = value;
				button = _btnRemove;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Button btnEXCEL
		{
			[CompilerGenerated]
			get
			{
				return _btnEXCEL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnEXCEL_Click;
				System.Windows.Forms.Button button = _btnEXCEL;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnEXCEL = value;
				button = _btnEXCEL;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		[field: AccessedThroughProperty("Label21")]
		internal virtual System.Windows.Forms.Label Label21
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label20")]
		internal virtual System.Windows.Forms.Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbPACKING
		{
			[CompilerGenerated]
			get
			{
				return _cbPACKING;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbPACKING_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbPACKING;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbPACKING = value;
				comboboxControl = _cbPACKING;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		public frmPDEWKO()
		{
			base.FormClosing += frmPDEWKO_FormClosing;
			base.Shown += frmPDEWKO_Shown;
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
			this.dgvPDWKP = new System.Windows.Forms.DataGridView();
			this.cbEXSPCK = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.cbTOLRN = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.dgvSLORD = new System.Windows.Forms.DataGridView();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.cbMDLCD = new IMS.ComboboxControl();
			this.Label19 = new System.Windows.Forms.Label();
			this.lblSTDWGT = new System.Windows.Forms.Label();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.lblONHAND = new System.Windows.Forms.Label();
			this.lblWIPQTY = new System.Windows.Forms.Label();
			this.lblWKOQTY = new System.Windows.Forms.Label();
			this.numWKOQTY = new IMS.NumControl();
			this.lblTTLQTY = new System.Windows.Forms.Label();
			this.numOHQTY = new IMS.NumControl();
			this.numWIPQT = new IMS.NumControl();
			this.numTOTAL = new IMS.NumControl();
			this.txtTYPE = new System.Windows.Forms.TextBox();
			this.cbREVNO = new System.Windows.Forms.ComboBox();
			this.numSTDWGT = new IMS.NumControl();
			this.lblFGBUFF = new System.Windows.Forms.Label();
			this.numFGBUFF = new IMS.NumControl();
			this.cbMCHID = new System.Windows.Forms.ComboBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.cbROUCD = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.dtpENTDT = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.dgvPDPRQ = new System.Windows.Forms.DataGridView();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.numPacking = new IMS.NumControl();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnEXCEL = new System.Windows.Forms.Button();
			this.cbPACKING = new IMS.ComboboxControl();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCert = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnRELEASE = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnDeleteAD = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
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
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPDWKP).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvSLORD).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvPDPRQ).BeginInit();
			this.TableLayoutPanel6.SuspendLayout();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Controls.Add(this.TableLayoutPanel6);
			this.Panel1.Location = new System.Drawing.Point(2, 1);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1362, 630);
			this.Panel1.TabIndex = 3;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 9;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.dgvPDWKP, 7, 10);
			this.TableLayoutPanel1.Controls.Add(this.cbEXSPCK, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.cbTOLRN, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label16, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.dgvSLORD, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbMDLCD, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label19, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.lblSTDWGT, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtRECID, 2, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblONHAND, 4, 5);
			this.TableLayoutPanel1.Controls.Add(this.lblWIPQTY, 4, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblWKOQTY, 4, 8);
			this.TableLayoutPanel1.Controls.Add(this.numWKOQTY, 5, 8);
			this.TableLayoutPanel1.Controls.Add(this.lblTTLQTY, 4, 13);
			this.TableLayoutPanel1.Controls.Add(this.numOHQTY, 5, 5);
			this.TableLayoutPanel1.Controls.Add(this.numWIPQT, 5, 6);
			this.TableLayoutPanel1.Controls.Add(this.numTOTAL, 5, 13);
			this.TableLayoutPanel1.Controls.Add(this.txtTYPE, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbREVNO, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.numSTDWGT, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblFGBUFF, 4, 4);
			this.TableLayoutPanel1.Controls.Add(this.numFGBUFF, 5, 4);
			this.TableLayoutPanel1.Controls.Add(this.cbMCHID, 5, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label15, 4, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label14, 4, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbROUCD, 5, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.cbLOCID, 5, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.dtpENTDT, 6, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.dgvPDPRQ, 7, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 7, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 7, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label17, 7, 12);
			this.TableLayoutPanel1.Controls.Add(this.numPacking, 8, 12);
			this.TableLayoutPanel1.Controls.Add(this.btnAdd, 7, 13);
			this.TableLayoutPanel1.Controls.Add(this.btnRemove, 8, 13);
			this.TableLayoutPanel1.Controls.Add(this.btnEXCEL, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.cbPACKING, 8, 11);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(8, 71);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 15;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1344, 522);
			this.TableLayoutPanel1.TabIndex = 0;
			this.dgvPDWKP.AllowUserToAddRows = false;
			this.dgvPDWKP.AllowUserToDeleteRows = false;
			this.dgvPDWKP.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPDWKP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvPDWKP, 2);
			this.dgvPDWKP.EnableHeadersVisualStyles = false;
			this.dgvPDWKP.Location = new System.Drawing.Point(888, 263);
			this.dgvPDWKP.MultiSelect = false;
			this.dgvPDWKP.Name = "dgvPDWKP";
			this.dgvPDWKP.ReadOnly = true;
			this.dgvPDWKP.RowHeadersVisible = false;
			this.dgvPDWKP.RowHeadersWidth = 51;
			this.dgvPDWKP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPDWKP.Size = new System.Drawing.Size(292, 146);
			this.dgvPDWKP.TabIndex = 76;
			this.TableLayoutPanel1.SetColumnSpan(this.cbEXSPCK, 2);
			this.cbEXSPCK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEXSPCK.FormattingEnabled = true;
			this.cbEXSPCK.Location = new System.Drawing.Point(129, 145);
			this.cbEXSPCK.Name = "cbEXSPCK";
			this.cbEXSPCK.Size = new System.Drawing.Size(200, 24);
			this.cbEXSPCK.TabIndex = 72;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 149);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(104, 16);
			this.Label8.TabIndex = 71;
			this.Label8.Text = "Excess Packing";
			this.cbTOLRN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTOLRN.FormattingEnabled = true;
			this.cbTOLRN.Location = new System.Drawing.Point(129, 89);
			this.cbTOLRN.Name = "cbTOLRN";
			this.cbTOLRN.Size = new System.Drawing.Size(103, 24);
			this.cbTOLRN.TabIndex = 49;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 93);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(93, 16);
			this.Label3.TabIndex = 49;
			this.Label3.Text = "Tolerance (%)";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(550, 5);
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
			this.txtDOCNO.Location = new System.Drawing.Point(129, 2);
			this.txtDOCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.dgvSLORD.AllowUserToAddRows = false;
			this.dgvSLORD.AllowUserToDeleteRows = false;
			this.dgvSLORD.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvSLORD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvSLORD, 7);
			this.dgvSLORD.EnableHeadersVisualStyles = false;
			this.dgvSLORD.Location = new System.Drawing.Point(3, 263);
			this.dgvSLORD.MultiSelect = false;
			this.dgvSLORD.Name = "dgvSLORD";
			this.dgvSLORD.ReadOnly = true;
			this.dgvSLORD.RowHeadersVisible = false;
			this.dgvSLORD.RowHeadersWidth = 51;
			this.TableLayoutPanel1.SetRowSpan(this.dgvSLORD, 3);
			this.dgvSLORD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSLORD.Size = new System.Drawing.Size(853, 200);
			this.dgvSLORD.TabIndex = 16;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 244);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(91, 16);
			this.Label6.TabIndex = 48;
			this.Label6.Text = "Sales Order";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 33);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(82, 16);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Model Code";
			this.cbMDLCD.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbMDLCD, 2);
			this.cbMDLCD.ComboboxWidth = 170;
			this.cbMDLCD.DataTable = null;
			this.cbMDLCD.DisplayMember = null;
			this.cbMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCD.HasBlankValue = false;
			this.cbMDLCD.Location = new System.Drawing.Point(129, 28);
			this.cbMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbMDLCD.Name = "cbMDLCD";
			this.cbMDLCD.SelectedIndex = -1;
			this.cbMDLCD.SelectedItem = null;
			this.cbMDLCD.SelectedValue = null;
			this.cbMDLCD.Size = new System.Drawing.Size(325, 26);
			this.cbMDLCD.TabIndex = 48;
			this.cbMDLCD.TextMultiline = true;
			this.cbMDLCD.ValueMember = null;
			this.cbMDLCD.WhereClause = null;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(3, 63);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(94, 16);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "BOM Revision";
			this.lblSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTDWGT.AutoSize = true;
			this.lblSTDWGT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTDWGT.Location = new System.Drawing.Point(3, 121);
			this.lblSTDWGT.Name = "lblSTDWGT";
			this.lblSTDWGT.Size = new System.Drawing.Size(108, 16);
			this.lblSTDWGT.TabIndex = 48;
			this.lblSTDWGT.Text = "Standard Weight";
			this.txtRECID.Location = new System.Drawing.Point(239, 89);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(54, 22);
			this.txtRECID.TabIndex = 60;
			this.txtRECID.Text = "-1";
			this.txtRECID.Visible = false;
			this.lblONHAND.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblONHAND.AutoSize = true;
			this.lblONHAND.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblONHAND.Location = new System.Drawing.Point(550, 149);
			this.lblONHAND.Name = "lblONHAND";
			this.lblONHAND.Size = new System.Drawing.Size(112, 16);
			this.lblONHAND.TabIndex = 50;
			this.lblONHAND.Text = "On Hand Quantity";
			this.lblWIPQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblWIPQTY.AutoSize = true;
			this.lblWIPQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblWIPQTY.Location = new System.Drawing.Point(550, 177);
			this.lblWIPQTY.Name = "lblWIPQTY";
			this.lblWIPQTY.Size = new System.Drawing.Size(84, 16);
			this.lblWIPQTY.TabIndex = 52;
			this.lblWIPQTY.Text = "WIP Quantity";
			this.lblWKOQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblWKOQTY.AutoSize = true;
			this.lblWKOQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblWKOQTY.Location = new System.Drawing.Point(550, 223);
			this.lblWKOQTY.Name = "lblWKOQTY";
			this.lblWKOQTY.Size = new System.Drawing.Size(86, 16);
			this.lblWKOQTY.TabIndex = 51;
			this.lblWKOQTY.Text = "W/O Quantity";
			this.numWKOQTY.AllowNegative = false;
			this.numWKOQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWKOQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWKOQTY.DataChanged = false;
			this.numWKOQTY.Location = new System.Drawing.Point(668, 220);
			this.numWKOQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numWKOQTY.Name = "numWKOQTY";
			this.numWKOQTY.NumberFormat = "8.0";
			this.numWKOQTY.Size = new System.Drawing.Size(104, 22);
			this.numWKOQTY.TabIndex = 48;
			this.numWKOQTY.Text = "0";
			this.numWKOQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWKOQTY.ThousandSeperator = false;
			this.numWKOQTY.Value = 0.0;
			this.lblTTLQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTTLQTY.AutoSize = true;
			this.lblTTLQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTTLQTY.Location = new System.Drawing.Point(550, 473);
			this.lblTTLQTY.Name = "lblTTLQTY";
			this.lblTTLQTY.Size = new System.Drawing.Size(90, 16);
			this.lblTTLQTY.TabIndex = 52;
			this.lblTTLQTY.Text = "Total Quantity";
			this.numOHQTY.AllowNegative = false;
			this.numOHQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numOHQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numOHQTY.DataChanged = false;
			this.numOHQTY.Location = new System.Drawing.Point(668, 146);
			this.numOHQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numOHQTY.Name = "numOHQTY";
			this.numOHQTY.NumberFormat = "8.0";
			this.numOHQTY.ReadOnly = true;
			this.numOHQTY.Size = new System.Drawing.Size(104, 22);
			this.numOHQTY.TabIndex = 61;
			this.numOHQTY.Text = "0";
			this.numOHQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numOHQTY.ThousandSeperator = false;
			this.numOHQTY.Value = 0.0;
			this.numWIPQT.AllowNegative = false;
			this.numWIPQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWIPQT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWIPQT.DataChanged = false;
			this.numWIPQT.Location = new System.Drawing.Point(668, 174);
			this.numWIPQT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numWIPQT.Name = "numWIPQT";
			this.numWIPQT.NumberFormat = "8.0";
			this.numWIPQT.ReadOnly = true;
			this.numWIPQT.Size = new System.Drawing.Size(104, 22);
			this.numWIPQT.TabIndex = 62;
			this.numWIPQT.Text = "0";
			this.numWIPQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWIPQT.ThousandSeperator = false;
			this.numWIPQT.Value = 0.0;
			this.numTOTAL.AllowNegative = false;
			this.numTOTAL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTOTAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTOTAL.DataChanged = false;
			this.numTOTAL.Location = new System.Drawing.Point(668, 470);
			this.numTOTAL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTOTAL.Name = "numTOTAL";
			this.numTOTAL.NumberFormat = "8.0";
			this.numTOTAL.ReadOnly = true;
			this.numTOTAL.Size = new System.Drawing.Size(104, 22);
			this.numTOTAL.TabIndex = 63;
			this.numTOTAL.Text = "0";
			this.numTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTOTAL.ThousandSeperator = false;
			this.numTOTAL.Value = 0.0;
			this.txtTYPE.Location = new System.Drawing.Point(239, 59);
			this.txtTYPE.Name = "txtTYPE";
			this.txtTYPE.Size = new System.Drawing.Size(54, 22);
			this.txtTYPE.TabIndex = 64;
			this.txtTYPE.Text = "-1";
			this.txtTYPE.Visible = false;
			this.cbREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbREVNO.FormattingEnabled = true;
			this.cbREVNO.Location = new System.Drawing.Point(129, 59);
			this.cbREVNO.Name = "cbREVNO";
			this.cbREVNO.Size = new System.Drawing.Size(104, 24);
			this.cbREVNO.TabIndex = 48;
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(129, 118);
			this.numSTDWGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.0";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(104, 22);
			this.numSTDWGT.TabIndex = 67;
			this.numSTDWGT.Text = "0";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.lblFGBUFF.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFGBUFF.AutoSize = true;
			this.lblFGBUFF.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFGBUFF.Location = new System.Drawing.Point(550, 121);
			this.lblFGBUFF.Name = "lblFGBUFF";
			this.lblFGBUFF.Size = new System.Drawing.Size(63, 16);
			this.lblFGBUFF.TabIndex = 56;
			this.lblFGBUFF.Text = "FG Buffer";
			this.numFGBUFF.AllowNegative = false;
			this.numFGBUFF.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numFGBUFF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numFGBUFF.DataChanged = false;
			this.numFGBUFF.Location = new System.Drawing.Point(668, 118);
			this.numFGBUFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numFGBUFF.Name = "numFGBUFF";
			this.numFGBUFF.NumberFormat = "8.0";
			this.numFGBUFF.ReadOnly = true;
			this.numFGBUFF.Size = new System.Drawing.Size(104, 22);
			this.numFGBUFF.TabIndex = 49;
			this.numFGBUFF.Text = "0";
			this.numFGBUFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numFGBUFF.ThousandSeperator = false;
			this.numFGBUFF.Value = 0.0;
			this.TableLayoutPanel1.SetColumnSpan(this.cbMCHID, 2);
			this.cbMCHID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMCHID.FormattingEnabled = true;
			this.cbMCHID.Location = new System.Drawing.Point(668, 89);
			this.cbMCHID.Name = "cbMCHID";
			this.cbMCHID.Size = new System.Drawing.Size(200, 24);
			this.cbMCHID.TabIndex = 48;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(550, 93);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(59, 16);
			this.Label15.TabIndex = 55;
			this.Label15.Text = "Machine";
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(550, 63);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(44, 16);
			this.Label14.TabIndex = 51;
			this.Label14.Text = "Route";
			this.TableLayoutPanel1.SetColumnSpan(this.cbROUCD, 2);
			this.cbROUCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbROUCD.FormattingEnabled = true;
			this.cbROUCD.Location = new System.Drawing.Point(668, 59);
			this.cbROUCD.Name = "cbROUCD";
			this.cbROUCD.Size = new System.Drawing.Size(200, 24);
			this.cbROUCD.TabIndex = 48;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(550, 33);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(59, 16);
			this.Label7.TabIndex = 69;
			this.Label7.Text = "Location";
			this.TableLayoutPanel1.SetColumnSpan(this.cbLOCID, 2);
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(668, 29);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(200, 24);
			this.cbLOCID.TabIndex = 70;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 177);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(63, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Remarks";
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 2);
			this.txtREMRK.Location = new System.Drawing.Point(129, 174);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.TableLayoutPanel1.SetRowSpan(this.txtREMRK, 3);
			this.txtREMRK.Size = new System.Drawing.Size(395, 65);
			this.txtREMRK.TabIndex = 15;
			this.dtpENTDT.CustomFormat = "hh:mm:ss";
			this.dtpENTDT.Dock = System.Windows.Forms.DockStyle.Right;
			this.dtpENTDT.Enabled = false;
			this.dtpENTDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpENTDT.Location = new System.Drawing.Point(778, 2);
			this.dtpENTDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpENTDT.Name = "dtpENTDT";
			this.dtpENTDT.Size = new System.Drawing.Size(104, 22);
			this.dtpENTDT.TabIndex = 73;
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(668, 2);
			this.dtpDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 3;
			this.dgvPDPRQ.AllowUserToAddRows = false;
			this.dgvPDPRQ.AllowUserToDeleteRows = false;
			this.dgvPDPRQ.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPDPRQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvPDPRQ, 2);
			this.dgvPDPRQ.EnableHeadersVisualStyles = false;
			this.dgvPDPRQ.Location = new System.Drawing.Point(888, 3);
			this.dgvPDPRQ.MultiSelect = false;
			this.dgvPDPRQ.Name = "dgvPDPRQ";
			this.dgvPDPRQ.ReadOnly = true;
			this.dgvPDPRQ.RowHeadersVisible = false;
			this.dgvPDPRQ.RowHeadersWidth = 51;
			this.TableLayoutPanel1.SetRowSpan(this.dgvPDPRQ, 9);
			this.dgvPDPRQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPDPRQ.Size = new System.Drawing.Size(292, 232);
			this.dgvPDPRQ.TabIndex = 74;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(888, 244);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(82, 16);
			this.Label12.TabIndex = 75;
			this.Label12.Text = "Packaging";
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(888, 419);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(57, 16);
			this.Label13.TabIndex = 77;
			this.Label13.Text = "Packing";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(888, 447);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(56, 16);
			this.Label17.TabIndex = 78;
			this.Label17.Text = "Quantity";
			this.numPacking.AllowNegative = false;
			this.numPacking.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPacking.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPacking.DataChanged = false;
			this.numPacking.Location = new System.Drawing.Point(1014, 444);
			this.numPacking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numPacking.Name = "numPacking";
			this.numPacking.NumberFormat = "8.0";
			this.numPacking.Size = new System.Drawing.Size(104, 22);
			this.numPacking.TabIndex = 80;
			this.numPacking.Text = "0";
			this.numPacking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPacking.ThousandSeperator = false;
			this.numPacking.Value = 0.0;
			this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Image = IMS.My.Resources.Resources.Save;
			this.btnAdd.Location = new System.Drawing.Point(888, 470);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnAdd.Name = "btnAdd";
			this.TableLayoutPanel1.SetRowSpan(this.btnAdd, 2);
			this.btnAdd.Size = new System.Drawing.Size(120, 50);
			this.btnAdd.TabIndex = 81;
			this.btnAdd.Text = "Add";
			this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnRemove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove.Image = IMS.My.Resources.Resources.Delete;
			this.btnRemove.Location = new System.Drawing.Point(1014, 470);
			this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRemove.Name = "btnRemove";
			this.TableLayoutPanel1.SetRowSpan(this.btnRemove, 2);
			this.btnRemove.Size = new System.Drawing.Size(120, 50);
			this.btnRemove.TabIndex = 82;
			this.btnRemove.Text = "Remove";
			this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemove.UseVisualStyleBackColor = false;
			this.btnEXCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnEXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEXCEL.Image = IMS.My.Resources.Resources.Excel;
			this.btnEXCEL.Location = new System.Drawing.Point(3, 470);
			this.btnEXCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEXCEL.Name = "btnEXCEL";
			this.TableLayoutPanel1.SetRowSpan(this.btnEXCEL, 2);
			this.btnEXCEL.Size = new System.Drawing.Size(120, 50);
			this.btnEXCEL.TabIndex = 83;
			this.btnEXCEL.Text = "Excel";
			this.btnEXCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEXCEL.UseVisualStyleBackColor = false;
			this.cbPACKING.BlankValue = null;
			this.cbPACKING.ComboboxWidth = 170;
			this.cbPACKING.DataTable = null;
            cbPACKING.Enabled=false;

            this.cbPACKING.DisplayMember = null;
			this.cbPACKING.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPACKING.HasBlankValue = false;
			this.cbPACKING.Location = new System.Drawing.Point(1016, 414);
			this.cbPACKING.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbPACKING.Name = "cbPACKING";
			this.cbPACKING.SelectedIndex = -1;
			this.cbPACKING.SelectedItem = null;
			this.cbPACKING.SelectedValue = null;
			this.cbPACKING.Size = new System.Drawing.Size(323, 26);
			this.cbPACKING.TabIndex = 101;
			this.cbPACKING.TextMultiline = true;
			this.cbPACKING.ValueMember = null;
			this.cbPACKING.WhereClause = null;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 7;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnCert, 6, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnRELEASE, 4, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDeleteAD, 5, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPrint, 3, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(882, 56);
			this.TableLayoutPanel6.TabIndex = 47;
			this.btnCert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCert.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCert.Image = IMS.My.Resources.Resources.Print;
			this.btnCert.Location = new System.Drawing.Point(759, 3);
			this.btnCert.Name = "btnCert";
			this.btnCert.Size = new System.Drawing.Size(120, 50);
			this.btnCert.TabIndex = 50;
			this.btnCert.Text = "Certificate";
			this.btnCert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCert.UseVisualStyleBackColor = false;
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
			this.btnSave.TabIndex = 17;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
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
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnRELEASE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRELEASE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRELEASE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRELEASE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRELEASE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRELEASE.Location = new System.Drawing.Point(507, 2);
			this.btnRELEASE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRELEASE.Name = "btnRELEASE";
			this.btnRELEASE.Size = new System.Drawing.Size(120, 50);
			this.btnRELEASE.TabIndex = 48;
			this.btnRELEASE.Text = "Release WO";
			this.btnRELEASE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRELEASE.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(255, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 19;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnDeleteAD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDeleteAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDeleteAD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDeleteAD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDeleteAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteAD.Image = IMS.My.Resources.Resources.Delete;
			this.btnDeleteAD.Location = new System.Drawing.Point(633, 2);
			this.btnDeleteAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDeleteAD.Name = "btnDeleteAD";
			this.btnDeleteAD.Size = new System.Drawing.Size(120, 50);
			this.btnDeleteAD.TabIndex = 49;
			this.btnDeleteAD.Text = "Delete (Admin)";
			this.btnDeleteAD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDeleteAD.UseVisualStyleBackColor = false;
			this.btnPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Image = IMS.My.Resources.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(381, 2);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(120, 50);
			this.btnPrint.TabIndex = 20;
			this.btnPrint.Text = "Print";
			this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrint.UseVisualStyleBackColor = false;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(2, 1);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1362, 630);
			this.Panel2.TabIndex = 4;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(5, 169);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1315, 380);
			this.dgvHEADER.TabIndex = 0;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 110);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
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
			this.btnNew.TabIndex = 9;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
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
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 3;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(834, 85);
			this.TableLayoutPanel2.TabIndex = 1;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 62);
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
			this.cbDOCNOTO.Location = new System.Drawing.Point(503, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(326, 25);
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
			this.cbDOCNOFR.Location = new System.Drawing.Point(119, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(324, 24);
			this.cbDOCNOFR.TabIndex = 10;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(450, 6);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(25, 16);
			this.Label21.TabIndex = 5;
			this.Label21.Text = "To";
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(3, 6);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(98, 16);
			this.Label20.TabIndex = 2;
			this.Label20.Text = "Work Order No";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 34);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(109, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Work Order Date";
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(118, 31);
			this.dtpDOCDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 5;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(450, 34);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(501, 31);
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
			this.cbHMDLCD.Location = new System.Drawing.Point(119, 57);
			this.cbHMDLCD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbHMDLCD.Name = "cbHMDLCD";
			this.cbHMDLCD.SelectedIndex = -1;
			this.cbHMDLCD.SelectedItem = null;
			this.cbHMDLCD.SelectedValue = null;
			this.cbHMDLCD.Size = new System.Drawing.Size(323, 25);
			this.cbHMDLCD.TabIndex = 52;
			this.cbHMDLCD.TextMultiline = true;
			this.cbHMDLCD.ValueMember = null;
			this.cbHMDLCD.WhereClause = null;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(450, 62);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(45, 16);
			this.Label11.TabIndex = 53;
			this.Label11.Text = "Status";
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[4] { "New Only", "Released Only", "FG Received Only", "All" });
			this.cboSTSFG.Location = new System.Drawing.Point(501, 58);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(170, 24);
			this.cboSTSFG.TabIndex = 54;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1364, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPDEWKO";
			base.Tag = "PDEWKO";
			this.Text = "Work Order Entry ";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPDWKP).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvSLORD).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvPDPRQ).EndInit();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
            dgvSLORD.CellMouseClick += DgvSLORD_CellMouseClick;

            base.ResumeLayout(false);
		}

        private void DgvSLORD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			String sSLONO= dgvSLORD.CurrentRow.Cells["PDWKO_SODOCNO"].Value.ToString();
		DataTable dt=	DB.GetTable("SLORD_PACKING", "SLORD_TBL", "SLORD_DOCNO='" + sSLONO + "'","");
if(dt.Rows.Count > 0)
			{
				String sPacking = dt.Rows[0][0].ToString();
				cbPACKING.Enabled = true;
                cbPACKING.SelectedValue = Conversions.ToString(sPacking);
                cbPACKING.Enabled = false;
            }

        }

        private void frmPDEWKO_FormClosing(object sender, FormClosingEventArgs e)
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

		public void BindComboBox()
		{
			cbMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK)";
			cbMDLCD.WhereClause = "MAITM_ITMTY = 1 AND MAITM_ACTFG = -1";
			cbMDLCD.ValueMember = "MAITM_ITMCD";
			cbMDLCD.DisplayMember = "MAITM_ITMCD";
			cbMDLCD.LoadData();
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += " ";//WHERE MALOC_LOCTY = 'WIP'
            strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
          //  cbLOCID.Enabled=false;

            cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
			strSQL = "SELECT DISTINCT MAROU_ROUCD, MAROU_ROUNM ";
			strSQL += "FROM MAROU_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MAROU_ROUCD ";
			cbROUCD.ValueMember = "MAROU_ROUCD";
			cbROUCD.DisplayMember = "MAROU_ROUNM";
			Common.RetriveComboItembySQL(strSQL, cbROUCD);
			strSQL = "SELECT DISTINCT MAMCH_MCHID, MAMCH_MCHNM ";
			strSQL += "FROM MAMCH_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MAMCH_MCHNM";
			cbMCHID.ValueMember = "MAMCH_MCHID";
			cbMCHID.DisplayMember = "MAMCH_MCHNM";
			Common.RetriveComboItembySQL(strSQL, cbMCHID);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'TOLRN' ORDER BY MACOD_CODID";
			cbTOLRN.ValueMember = "MACOD_CODID";
			cbTOLRN.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbTOLRN);
			strSQL = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM, 0 AS MACOD_NFLD1 UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM, MACOD_NFLD1 ";
			strSQL += "FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'PACKING' ORDER BY MACOD_CODID";
			cbEXSPCK.ValueMember = "MACOD_CODID";
			cbEXSPCK.DisplayMember = "MACOD_CODID";
			Common.RetriveComboItembySQL(strSQL, cbEXSPCK);
            cbPACKING.DataTable = "MACOD_TBL WITH(NOLOCK) ";
            cbPACKING.WhereClause = "MACOD_CTYID = 'PACKING' ";
            cbPACKING.ValueMember = "MACOD_CODID";
            cbPACKING.DisplayMember = "MACOD_CODID";
            cbPACKING.LoadData();
   //         cbPACKING.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			//cbPACKING.WhereClause = "MAITM_GRPCD = 'PACKING'";
			//cbPACKING.ValueMember = "MAITM_ITMCD";
			//cbPACKING.DisplayMember = "MAITM_ITMCD";
			//cbPACKING.LoadData();
            //cbPACKING.SelectedValue = RuntimeHelpers.GetObjectValue(dgvPDWKP.CurrentRow.Cells["WRK_PACKING"].Value);
            //numPacking.Value = Conversions.ToDouble(dgvPDWKP.CurrentRow.Cells["WRK_QTY"].Value);


           // int intPacking = Conversions.ToInteger(DB.GetColumnValue("MACOD_NFLD1", "MACOD_TBL", "MACOD_CTYID = 'PACKING' AND MACOD_CODID = '" + Common.gfValidSQLStr(Conversions.ToString(cbPACKING.SelectedValue)) + "'"));
			//numPacking.Value = Math.Ceiling(numWKOQTY.Value / (double)intPacking);

			BindLabel();
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "PDWKO_TBL WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "PDWKO_WKONO";
			cbDOCNOFR.DisplayMember = "PDWKO_WKONO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "PDWKO_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "PDWKO_WKONO";
			cbDOCNOTO.DisplayMember = "PDWKO_WKONO";
			cbDOCNOTO.LoadData();
			cbHMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK)";
			cbHMDLCD.WhereClause = "MAITM_ITMTY = 1 AND MAITM_ACTFG = -1";
			cbHMDLCD.ValueMember = "MAITM_ITMCD";
			cbHMDLCD.DisplayMember = "MAITM_ITMCD";
			cbHMDLCD.LoadData();
		}

		private void ClearDetails()
		{
			txtDOCNO.Text = "";
			dtpDOCDT.Value = DateAndTime.Today;
			dtpENTDT.Value = DateTime.Now;
			cbMDLCD.SelectedIndex = -1;
			cbMDLCD.TextBox1.Text = string.Empty;
			cbREVNO.SelectedIndex = -1;
			cbEXSPCK.SelectedIndex = -1;
			cbTOLRN.SelectedIndex = -1;
			cbPACKING.SelectedIndex = -1;
			numPacking.Value = 0.0;
			txtRECID.Text = Conversions.ToString(-1);
			numFGBUFF.Value = 0.0;
			numOHQTY.Value = 0.0;
			numWIPQT.Value = 0.0;
			numWKOQTY.Value = 0.0;
			numTOTAL.Value = 0.0;
			txtREMRK.Text = "";
			dgvSLORD.DataSource = null;
			dgvPDPRQ.DataSource = null;
			dgvPDWKP.DataSource = null;
			txtDOCNO.Enabled = true;
			cbMDLCD.Enabled = true;
			btnDelete.Enabled = true;
			btnPrint.Enabled = true;
			btnSave.Enabled = true;
			btnRELEASE.Enabled = true;
		}

		private void frmPDEWKO_Shown(object sender, EventArgs e)
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
			string strSQL = "EXEC spPDWKO ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHMDLCD.SelectedValue)) + "', ";
			strSQL += Conversions.ToString(cboSTSFG.SelectedIndex);
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvHEADER.ClearSelection();
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = "PDWKO_WKODT";
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Route");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Machine");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Tolerance");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Excess Packing");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "PDWKO_WOQTY");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 200;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remarks");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "PDWKO_STSFG");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Status");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Enter By");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Update By");
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
			Panel2.Visible = false;
			Panel1.Visible = true;
		}

		private void checkQTYPROD()
		{
			string strWHERE = "INBAL_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
			strWHERE += "AND EXISTS (SELECT * FROM MALOC_TBL WHERE MALOC_LOCID = INBAL_LOCID AND MALOC_MRPFG = '1')";
			numOHQTY.Value = Conversions.ToDouble(DB.GetColumnValue("ISNULL(SUM(INBAL_QTY),0)", "INBAL_TBL WITH(NOLOCK)", strWHERE));
			strWHERE = "PDWKO_STSFG <> 2 AND PDWKO_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' AND PDWKO_REVNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbREVNO.SelectedValue)) + "' ";
			numWIPQT.Value = Conversions.ToDouble(DB.GetColumnValue("ISNULL(SUM(PDWKO_WOQTY),0)", "PDWKO_TBL WITH(NOLOCK)", strWHERE));
		}

		private void BindGridHeader()
		{
			txtRECID.Text = dgvHEADER.CurrentRow.Cells["PDWKO_RECID"].Value.ToString();
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["PDWKO_WKONO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PDWKO_WKODT"].Value);
			dtpENTDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PDWKO_ENTDT"].Value);
			txtTYPE.Text = dgvHEADER.CurrentRow.Cells["PDWKO_TYPE"].Value.ToString();
			cbMDLCD.SelectedValue = dgvHEADER.CurrentRow.Cells["PDWKO_MDLCD"].Value.ToString();
			cbREVNO.SelectedValue = dgvHEADER.CurrentRow.Cells["PDWKO_REVNO"].Value.ToString();
			cbLOCID.SelectedValue = dgvHEADER.CurrentRow.Cells["PDWKO_LOCID"].Value.ToString();
			cbROUCD.SelectedValue = dgvHEADER.CurrentRow.Cells["PDWKO_ROUCD"].Value.ToString();
			cbTOLRN.SelectedValue = dgvHEADER.CurrentRow.Cells["PDWKO_TOLRN"].Value.ToString();
			cbEXSPCK.SelectedValue = dgvHEADER.CurrentRow.Cells["PDWKO_EXSPCK"].Value.ToString();
			cbMCHID.SelectedValue = dgvHEADER.CurrentRow.Cells["PDWKO_MCHID"].Value.ToString();
			numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL With (NOLOCK)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbMDLCD.SelectedValue), "'"))));
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["PDWKO_REMRK"].Value.ToString();
			numWKOQTY.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["PDWKO_WOQTY"].Value.ToString());
			BindGridPDPRQ();
			GeneratePDWKP();
			RefreshGridPDWKP();
			EnableButton();
		}

		private void BindGridPDPRQ()
		{
			int i = 0;
			dgvPDPRQ.DataSource = null;
			string strSQL = "EXEC spPDWKO_PART '" + Common.gfValidSQLStr(txtDOCNO.Text) + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count != 0)
				{
					DataGridView dataGridView = dgvPDPRQ;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Require");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void GeneratePDWKP()
		{
			string strSQL = "EXEC spPDEWKO_PACKING 0, '" + MyProject.Computer.Name + "', '" + Common.gfValidSQLStr(txtDOCNO.Text) + "', '', 0";
			DB.ExecProc(strSQL);
		}

		private void RefreshGridPDWKP()
		{
			int i = 0;
			dgvPDWKP.DataSource = null;
			string strSQL = "SELECT WRK_PACKING, WRK_QTY ";
			strSQL = strSQL + "FROM PDWKP_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count != 0)
			{
				DataGridView dataGridView = dgvPDWKP;
				dataGridView.DataSource = dt;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				dataGridView.Columns[i].ReadOnly = true;
				i = checked(i + 1);
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				dataGridView.Columns[i].ReadOnly = true;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		public void EnableButton()
		{
			if (Conversions.ToDouble(txtRECID.Text) != -1.0)
			{
				switch (Conversions.ToInteger(DB.GetColumnValue("PDWKO_STSFG", "PDWKO_TBL WITH(NOLOCK)", "PDWKO_WKONO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "'")))
				{
				case 0:
					btnSave.Enabled = true;
					btnRELEASE.Enabled = true;
					btnDelete.Enabled = true;
					btnPrint.Enabled = false;
					btnDeleteAD.Enabled = false;
					btnAdd.Enabled = true;
					btnRemove.Enabled = true;
					break;
				case 1:
					btnSave.Enabled = false;
					btnRELEASE.Enabled = false;
					btnDelete.Enabled = false;
					btnPrint.Enabled = true;
					btnDeleteAD.Enabled = Conversions.ToBoolean(Interaction.IIf(PublicVar.gblnSupervisor, true, false));
					btnAdd.Enabled = false;
					btnRemove.Enabled = false;
					break;
				case 2:
					btnSave.Enabled = false;
					btnRELEASE.Enabled = false;
					btnDelete.Enabled = false;
					btnPrint.Enabled = true;
					btnDeleteAD.Enabled = false;
					btnAdd.Enabled = false;
					btnRemove.Enabled = false;
					break;
				}
				txtDOCNO.Enabled = false;
				cbMDLCD.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
				cbMDLCD.Enabled = true;
				btnSave.Enabled = true;
				btnRELEASE.Enabled = false;
				btnDelete.Enabled = false;
				btnPrint.Enabled = false;
				btnDeleteAD.Enabled = false;
			}
		}
		public void NewWO()
		{
            BindComboBox();
            txtTYPE.Text = "ORDER";
            EnableButton();
            Panel1.Visible = true;
            Panel2.Visible = false;
        }
		private void btnNew_Click(object sender, EventArgs e)
		{
			NewWO();

        }

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			Header();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (spPDEWKO(Conversions.ToString(0)))
			{
				btnAdd.Enabled = true;
				btnRemove.Enabled = true;
			}
		}

		private bool spPDEWKO(string strPRO)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PDEWKO'"));
			bool spPDEWKO;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PDEWKO", "PDWKO", ref strNextNo))
					{
						MessageBox.Show("Document No cannot blank! Please check document number control.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spPDEWKO = false;
						goto IL_0498;
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
					spPDEWKO = false;
					goto IL_0498;
				}
			}
			if (Conversions.ToDouble(strPRO) == 0.0 && numWKOQTY.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity cannot be 0."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numWKOQTY.Focus();
				spPDEWKO = false;
			}
			else
			{
				strSQL = "EXEC spPDEWKO ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCD.SelectedValue), "', ")));
				strSQL = strSQL + " " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + ", ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbROUCD.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMCHID.SelectedValue), "', ")));
				strSQL = strSQL + " " + Conversions.ToString(Conversion.Val(numWKOQTY.Value)) + ", ";
				strSQL = strSQL + " " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbTOLRN.SelectedValue))) + ", ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbEXSPCK.SelectedValue)) + "', ";
				strSQL = strSQL + "'" + txtREMRK.Text + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "', ";
				strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
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
					spPDEWKO = false;
					ProjectData.ClearProjectError();
					goto IL_0498;
				}
				switch (strPRO)
				{
				case "0":
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "1":
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				case "2":
					//MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order released."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					break;
				}
				spPDEWKO = true;
			}
			goto IL_0498;
			IL_0498:
			return spPDEWKO;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + txtDOCNO.Text;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				spPDEWKO(Conversions.ToString(1));
				ClearDetails();
				BindComboHeader();
				Header();
			}
		}

		private void btnDeleteAD_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "SELECT * FROM PDFGR_TBL WHERE PDFGR_WKONO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "'";
			if (DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order already FG Receiving, not allow to delete!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			strSQL = "EXEC spPDEWKO_DELETE '" + Common.gfValidSQLStr(txtDOCNO.Text) + "'";
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
				ProjectData.ClearProjectError();
				return;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private void RefreshSalesOrder()
		{
			int i = 0;
			dgvSLORD.DataSource = null;
			string strSQL = "EXEC spPDWKO_SLORD ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "', ";
			strSQL += Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue)));
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt != null)
				{
					dgvSLORD.ClearSelection();
					DataGridView dataGridView = dgvSLORD;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Reference No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 110;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery Date");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
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
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Reserved");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		bool IsLoad = false;
		private void cbMDLCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindRevNo();
			numSTDWGT.Value = Conversions.ToDouble(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL With (NOLOCK)", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbMDLCD.SelectedValue), "'"))));
			numFGBUFF.Value = Conversions.ToDouble(DB.GetColumnValue("INBAL_QTY", "INBAL_TBL WITH(NOLOCK)", "INBAL_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' AND INBAL_LOCID = 'FGBUFF' "));
            string strSQL = "EXEC spMAITM '0', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString("")) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString("")) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString("")) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString("")) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'",  "zzzzz"), "' ")));
            DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				String LOCID = dt.Rows[0]["MAITM_LOCCD"].ToString();
				if (LOCID.Trim() != "")
				{

					cbLOCID.SelectedValue = LOCID;
					if (IsLoad)
					{
						string strSQL2 = "SELECT * FROM MALOC_TBL WITH (NOLOCK) WHERE MALOC_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "'";
						System.Data.DataTable dt2 = DB.ExecProc(strSQL2);
						cbROUCD.SelectedValue = RuntimeHelpers.GetObjectValue(dt2.Rows[0]["MALOC_ROUCD"]);
						cbMCHID.SelectedValue = RuntimeHelpers.GetObjectValue(dt2.Rows[0]["MALOC_MCHID"]);
					}
				}
            }
        }

		private void BindRevNo()
		{
			string strSQL = "SELECT DISTINCT MABOM_REVNO ";
			strSQL += "FROM MABOM_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MABOM_MDLCD = MAITM_ITMCD  ";
			strSQL += "WHERE MAITM_ITMTY = 1 AND MAITM_ACTFG = -1 ";
			strSQL = strSQL + "AND MABOM_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
			strSQL += "AND MABOM_ACTFG = 1 ";
			strSQL += "ORDER BY MABOM_REVNO ";
			cbREVNO.ValueMember = "MABOM_REVNO";
			cbREVNO.DisplayMember = "MABOM_REVNO";
			Common.RetriveComboItembySQL(strSQL, cbREVNO);
		}

		private void calculateTotal()
		{
			int total = 0;
			checked
			{
				int num = dgvSLORD.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					total = (int)Math.Round((double)total + Conversions.ToDouble(Common.gfValidSQLStr(dgvSLORD.Rows[i].Cells["PDWKO_BALQT"].Value.ToString())));
				}
				numTOTAL.Value = total;
				numWKOQTY.Value = total;
			}
		}

		private void cbREVNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshSalesOrder();
			calculateTotal();
			checkQTYPROD();
		}

		private void BindLabel()
		{
			string strUOM = Conversions.ToString(DB.GetColumnValue("LMSYS_BUOM", "LMSYS_TBL", ""));
			lblFGBUFF.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "FG Buffer") + " (" + strUOM + ")";
			lblSTDWGT.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Standard Weight") + " (" + strUOM + ")";
			lblONHAND.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "On Hand Quantity") + " (" + strUOM + ")";
			lblWIPQTY.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "WIP Quantity") + " (" + strUOM + ")";
			lblWKOQTY.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "W/O Quantity") + " (" + strUOM + ")";
			lblTTLQTY.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total Quantity") + " (" + strUOM + ")";
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			GenerateQRCode();
			string strSQL = "SELECT * FROM PDWKB_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = PDWKB_BOMPN ";
			strSQL = strSQL + "WHERE PDWKB_WKONO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
			strSQL += "AND MAITM_ITMCTRL = 1";
			if (DB.RecordExists(strSQL))
			{
				DisplayReport3();
			}
			DisplayReport1();
		}

		private void GenerateQRCode()
		{
			OleDbCommand cmd = new OleDbCommand();
			object settings = new BarcodeSettings();
			string strSQL = "EXEC spPDWKO_QR ";
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
			System.Data.DataTable dt = DB.ExecProc("SELECT PDWKO_WKONO FROM PDWKO_QR WHERE PDWKO_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "'");
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

		private void DisplayReport1()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "WORK ORDER SHEET";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKO_SHEET.rpt";
			frmRPT.Params = "@PRNID=" + MyProject.Computer.Name + ",@WKONO=" + Common.gfValidSQLStr(txtDOCNO.Text);
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='WORK ORDER SHEET',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS + ",XRTDS=" + PublicVar.gintXRTDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void DisplayReport3()
		{
			string strSQL = "SELECT DISTINCT PDPRQ_DOCNO FROM PDPRQ_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PDPRQ_WKONO = '" + txtDOCNO.Text + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					GenerateQRCode2(dt.Rows[i]["PDPRQ_DOCNO"].ToString());
					DisplayReport31(dt.Rows[i]["PDPRQ_DOCNO"].ToString());
				}
			}
		}

		private void DisplayReport31(string strDOCNO)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "MATERIAL REQUEST LIST";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKO_REQ.rpt";
			frmRPT.Params = "@PRNID=" + MyProject.Computer.Name + ",@DOCNO=" + Common.gfValidSQLStr(strDOCNO);
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='MATERIAL REQUEST LIST',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
			frmRPT.Refresh();
		}

		private void GenerateQRCode2(string strDOCNO)
		{
			OleDbCommand cmd = new OleDbCommand();
			object settings = new BarcodeSettings();
			string strSQL = "EXEC spPDPRQ_QR ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(strDOCNO) + "' ";
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
			NewLateBinding.LateSet(settings, null, "HasBorder", new object[1] { false }, null, null);
			NewLateBinding.LateSet(settings, null, "ShowText", new object[1] { false }, null, null);
			NewLateBinding.LateSet(settings, null, "Type", new object[1] { (BarCodeType)Conversions.ToLong(Enum.Parse(typeof(BarCodeType), "QRCode")) }, null, null);
			NewLateBinding.LateSet(settings, null, "LeftMargin", new object[1] { 1 }, null, null);
			NewLateBinding.LateSet(settings, null, "Data2D", new object[1] { strDOCNO }, null, null);
			NewLateBinding.LateSet(settings, null, "Data", new object[1] { strDOCNO }, null, null);
			BarCodeGenerator sprQRCODE = new BarCodeGenerator((IBarcodeSettings)settings);
			byte[] imgQRCODE = Common.ImageToByte2(sprQRCODE.GenerateImage());
			try
			{
				cmd = new OleDbCommand();
				cmd.Connection = DB.GetDBConnection();
				strSQL = "spPDPRQ_QR2";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@PRNID", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(MyProject.Computer.Name);
				cmd.Parameters.Add("@WKONO", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(strDOCNO);
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

		private void btnRELEASE_Click(object sender, EventArgs e)
		{
            DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Release order?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ok == DialogResult.OK)
            {
                string strSQL = "SELECT * FROM PDWKO_TBL WHERE PDWKO_WKONO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' AND ISNULL(PDWKO_LOCID, '') = ''";
				if (DB.RecordExists(strSQL))
				{
					MessageBox.Show("Location ID not set.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					cbLOCID.Select();
				}
				else
				{
					spPDEWKO(Conversions.ToString(2));
					EnableButton();
				}
			}
		}

		private void numWKOQTY_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return) && numWKOQTY.Value > numSTDWGT.Value)
			{
				MessageBox.Show("Work Order Quantity cannot exceed Standard Weight.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				numWKOQTY.Select();
			}
		}

		private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			string strSQL = "SELECT * FROM MALOC_TBL WITH (NOLOCK) WHERE MALOC_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			cbROUCD.Enabled = true;
			cbMCHID.Enabled = true;

            cbROUCD.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["MALOC_ROUCD"]);
			cbMCHID.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["MALOC_MCHID"]);
            cbROUCD.Enabled = false;
            cbMCHID.Enabled = false;
            IsLoad = true;
			cbLOCID.Enabled = false;
		}

		private void btnCert_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "Certificate Of Analysis";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDRCOA.rpt";
			frmRPT.Params = "@DOCNO=" + txtDOCNO.Text;
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='Certificate Of Analysis',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string strSQL = "EXEC spPDEWKO_PACKING 1, ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPACKING.SelectedValue), "', ")));
			strSQL += Conversions.ToString(numPacking.Value);
			DB.ExecProc(strSQL);
			RefreshGridPDWKP();
		}

		private void btnRemove_Click(object sender, EventArgs e)
		{
			string strSQL = "EXEC spPDEWKO_PACKING 2, ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPACKING.SelectedValue), "', ")));
			strSQL += Conversions.ToString(numPacking.Value);
			DB.ExecProc(strSQL);
			RefreshGridPDWKP();
		}

		private void dgvPDWKP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			cbPACKING.SelectedValue = RuntimeHelpers.GetObjectValue(dgvPDWKP.CurrentRow.Cells["WRK_PACKING"].Value);
			numPacking.Value = Conversions.ToDouble(dgvPDWKP.CurrentRow.Cells["WRK_QTY"].Value);
		}

		private void cbPACKING_SelectedIndexChanged(object sender, EventArgs e)
		{
			int intPacking = Conversions.ToInteger(DB.GetColumnValue("MACOD_NFLD1", "MACOD_TBL", "MACOD_CTYID = 'PACKING' AND MACOD_CODID = '" + Common.gfValidSQLStr(Conversions.ToString(cbPACKING.SelectedValue)) + "'"));
			numPacking.Value = Math.Ceiling(numWKOQTY.Value / (double)intPacking);
		}

		private void btnEXCEL_Click(object sender, EventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application xlsApp = new ApplicationClass();
			int intTotal = 0;
			Cursor = Cursors.WaitCursor;
			string strSQL = "EXEC spPDWKO_SLORD ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "', ";
			strSQL += Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue)));
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count != 0)
				{
					Workbook xlsWorkBook = xlsApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
					Worksheet xlsSheet = (Worksheet)xlsWorkBook.Sheets["Sheet1"];
					xlsApp.Cells[1, 1] = PublicVar.gstrCompany;
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
					xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sales Order Status By Model");
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
					xlsApp.Cells[3, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model");
					xlsApp.Cells[3, 2] = RuntimeHelpers.GetObjectValue(cbMDLCD.SelectedValue);
					xlsApp.Cells[4, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revison");
					xlsApp.Cells[4, 2] = RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue);
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 2]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 2])).NumberFormat = "0.00";
					xlsApp.Cells[6, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
					xlsApp.Cells[6, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					xlsApp.Cells[6, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Reference No");
					xlsApp.Cells[6, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery Date");
					xlsApp.Cells[6, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
					xlsApp.Cells[6, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Reserved");
					xlsApp.Cells[6, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance");
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 7])).Font.Bold = true;
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 4])).EntireColumn.NumberFormat = "@";
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 7])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[6, 7])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
					int intRow = 7;
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWKO_SODOCNO"]);
						xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWKO_CUSID"]);
						xlsApp.Cells[intRow, 3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWKO_REFNO"]);
						xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["DELDT"]);
						xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWKO_QTY"]);
						xlsApp.Cells[intRow, 6] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWKO_RSVQT"]);
						xlsApp.Cells[intRow, 7] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWKO_BALQT"]);
						((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 5]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7])).NumberFormat = "0.000";
						intTotal = Conversions.ToInteger(Operators.AddObject(intTotal, dt.Rows[i]["PDWKO_BALQT"]));
						intRow++;
					}
					xlsApp.Cells[intRow, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Toal");
					xlsApp.Cells[intRow, 7] = intTotal;
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7])).NumberFormat = "0.000";
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 6]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7])).Font.Bold = true;
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 6]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 6]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 7])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
					xlsSheet.Columns.AutoFit();
					xlsSheet = null;
					xlsWorkBook = null;
					GC.Collect();
					xlsApp.WindowState = XlWindowState.xlMaximized;
					xlsApp.Visible = true;
					Cursor = Cursors.Default;
				}
			}
		}
	}
}
