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
	public class frmMAEITM : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMAITM")]
		private DataGridView _dgvMAITM;

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
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private Button _btnPRINTFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbHBRAND")]
		private ComboBox _cbHBRAND;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbHGRPCD")]
		private ComboBox _cbHGRPCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbHITMTY")]
		private ComboBox _cbHITMTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMTY")]
		private ComboBox _cbITMTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCATCD")]
		private ComboBox _cbCATCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbGRPCD")]
		private ComboBox _cbGRPCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbBRAND")]
		private ComboBox _cbBRAND;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCDFR")]
		private ComboboxControl _cbITMCDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvSPART")]
		private DataGridView _dgvSPART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate")]
		private Button _btnUpdate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvCPART")]
		private DataGridView _dgvCPART;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel2")]
		private Button _btnCancel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUpdate2")]
		private Button _btnUpdate2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRemove2")]
		private Button _btnRemove2;

		private OleDbCommand cmd;

		private string strMODE;

		private int intAccessLevel;

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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
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

		internal virtual DataGridView dgvMAITM
		{
			[CompilerGenerated]
			get
			{
				return _dgvMAITM;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMAITM_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMAITM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMAITM = value;
				dataGridView = _dgvMAITM;
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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

		[field: AccessedThroughProperty("txtDESC")]
		internal virtual TextBox txtDESC
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

		[field: AccessedThroughProperty("txtDESC2")]
		internal virtual TextBox txtDESC2
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

		[field: AccessedThroughProperty("Label12")]
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label24")]
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label18")]
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label32")]
		internal virtual Label Label32
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label23")]
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label30")]
		internal virtual Label Label30
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label22")]
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label29")]
		internal virtual Label Label29
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

		[field: AccessedThroughProperty("Label28")]
		internal virtual Label Label28
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

		[field: AccessedThroughProperty("Label27")]
		internal virtual Label Label27
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label26")]
		internal virtual Label Label26
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

		[field: AccessedThroughProperty("Label25")]
		internal virtual Label Label25
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

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
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

		[field: AccessedThroughProperty("Label31")]
		internal virtual Label Label31
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkACTFG")]
		internal virtual CheckBox chkACTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkSRLFG")]
		internal virtual CheckBox chkSRLFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCFIELD1")]
		internal virtual TextBox txtCFIELD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSRLNO3")]
		internal virtual TextBox txtSRLNO3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSRLNO1")]
		internal virtual TextBox txtSRLNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSRLNO2")]
		internal virtual TextBox txtSRLNO2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCFIELD2")]
		internal virtual TextBox txtCFIELD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual Button btnPRINTFR
		{
			[CompilerGenerated]
			get
			{
				return _btnPRINTFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnPRINTFR_Click;
				Button button = _btnPRINTFR;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnPRINTFR = value;
				button = _btnPRINTFR;
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		[field: AccessedThroughProperty("Label36")]
		internal virtual Label Label36
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label35")]
		internal virtual Label Label35
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbHBRAND
		{
			[CompilerGenerated]
			get
			{
				return _cbHBRAND;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbHBRAND_SelectedIndexChanged;
				ComboBox comboBox = _cbHBRAND;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbHBRAND = value;
				comboBox = _cbHBRAND;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbHGRPCD
		{
			[CompilerGenerated]
			get
			{
				return _cbHGRPCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbHGRPCD_SelectedIndexChanged;
				ComboBox comboBox = _cbHGRPCD;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbHGRPCD = value;
				comboBox = _cbHGRPCD;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label34")]
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label33")]
		internal virtual Label Label33
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

		internal virtual ComboBox cbHITMTY
		{
			[CompilerGenerated]
			get
			{
				return _cbHITMTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbHITMTY_SelectedIndexChanged;
				ComboBox comboBox = _cbHITMTY;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbHITMTY = value;
				comboBox = _cbHITMTY;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbHCATCD")]
		internal virtual ComboBox cbHCATCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDESCTO")]
		internal virtual TextBox txtDESCTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDESCFR")]
		internal virtual TextBox txtDESCFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbITMTY
		{
			[CompilerGenerated]
			get
			{
				return _cbITMTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbITMTY_SelectedIndexChanged;
				ComboBox comboBox = _cbITMTY;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbITMTY = value;
				comboBox = _cbITMTY;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbCATCD
		{
			[CompilerGenerated]
			get
			{
				return _cbCATCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbCATCD_SelectedIndexChanged;
				ComboBox comboBox = _cbCATCD;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbCATCD = value;
				comboBox = _cbCATCD;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbGRPCD
		{
			[CompilerGenerated]
			get
			{
				return _cbGRPCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbGRPCD_SelectedIndexChanged;
				ComboBox comboBox = _cbGRPCD;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbGRPCD = value;
				comboBox = _cbGRPCD;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbBRAND
		{
			[CompilerGenerated]
			get
			{
				return _cbBRAND;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbBRAND_SelectedIndexChanged;
				ComboBox comboBox = _cbBRAND;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbBRAND = value;
				comboBox = _cbBRAND;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbLOCCD")]
		internal virtual ComboBox cbLOCCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbUOM")]
		internal virtual ComboBox cbUOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbITAXCD")]
		internal virtual ComboBox cbITAXCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbOTAXCD")]
		internal virtual ComboBox cbOTAXCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label37")]
		internal virtual Label Label37
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSUBCATCD")]
		internal virtual ComboBox cbSUBCATCD
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

		[field: AccessedThroughProperty("txtDILCD")]
		internal virtual TextBox txtDILCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label41")]
		internal virtual Label Label41
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCLRGP")]
		internal virtual ComboBox cbCLRGP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel8")]
		internal virtual TableLayoutPanel TableLayoutPanel8
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

		[field: AccessedThroughProperty("tpGENERAL")]
		internal virtual TabPage tpGENERAL
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

		[field: AccessedThroughProperty("numSLPRC")]
		internal virtual NumControl numSLPRC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numPUPRC")]
		internal virtual NumControl numPUPRC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numLTIME")]
		internal virtual NumControl numLTIME
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numMOQ")]
		internal virtual NumControl numMOQ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSPQ")]
		internal virtual NumControl numSPQ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSAFETY")]
		internal virtual NumControl numSAFETY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("tpDISPENSER")]
		internal virtual TabPage tpDISPENSER
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

		[field: AccessedThroughProperty("tpOTHER")]
		internal virtual TabPage tpOTHER
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

		[field: AccessedThroughProperty("numNFIELD1")]
		internal virtual NumControl numNFIELD1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numNFIELD2")]
		internal virtual NumControl numNFIELD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkPRDDSP")]
		internal virtual CheckBox chkPRDDSP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numVALVE")]
		internal virtual NumControl numVALVE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numLABVALVE")]
		internal virtual NumControl numLABVALVE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkPUMPMDL")]
		internal virtual CheckBox chkPUMPMDL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkDSP1ST")]
		internal virtual CheckBox chkDSP1ST
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label44")]
		internal virtual Label Label44
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numDILRT2")]
		internal virtual NumControl numDILRT2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numDILRT")]
		internal virtual NumControl numDILRT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label39")]
		internal virtual Label Label39
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtDILCD2")]
		internal virtual TextBox txtDILCD2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label42")]
		internal virtual Label Label42
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label46")]
		internal virtual Label Label46
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSTUTTER")]
		internal virtual NumControl numSTUTTER
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numMINSPIT")]
		internal virtual NumControl numMINSPIT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numFLOW2TO1")]
		internal virtual NumControl numFLOW2TO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numFLOW1TOOFF")]
		internal virtual NumControl numFLOW1TOOFF
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label48")]
		internal virtual Label Label48
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label50")]
		internal virtual Label Label50
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numRECIRC")]
		internal virtual NumControl numRECIRC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label53")]
		internal virtual Label Label53
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label54")]
		internal virtual Label Label54
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numTOLERG")]
		internal virtual NumControl numTOLERG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numTOLERP")]
		internal virtual NumControl numTOLERP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label56")]
		internal virtual Label Label56
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numDSPLOW")]
		internal virtual NumControl numDSPLOW
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numDSPORD")]
		internal virtual NumControl numDSPORD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label58")]
		internal virtual Label Label58
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSTKDSP")]
		internal virtual NumControl numSTKDSP
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numBARSZ")]
		internal virtual NumControl numBARSZ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label60")]
		internal virtual Label Label60
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCOLORCID")]
		internal virtual TextBox txtCOLORCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtBATCH")]
		internal virtual TextBox txtBATCH
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label40")]
		internal virtual Label Label40
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label43")]
		internal virtual Label Label43
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label45")]
		internal virtual Label Label45
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label47")]
		internal virtual Label Label47
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label49")]
		internal virtual Label Label49
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label51")]
		internal virtual Label Label51
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label52")]
		internal virtual Label Label52
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label55")]
		internal virtual Label Label55
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label57")]
		internal virtual Label Label57
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label59")]
		internal virtual Label Label59
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label61")]
		internal virtual Label Label61
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSUPCD")]
		internal virtual ComboboxControl cbSUPCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbITMCDTO")]
		internal virtual ComboboxControl cbITMCDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbITMCDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbITMCDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbITMCDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbITMCDFR = value;
				comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("numSTDWGT")]
		internal virtual NumControl numSTDWGT
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

		[field: AccessedThroughProperty("chkAVESL")]
		internal virtual CheckBox chkAVESL
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

		[field: AccessedThroughProperty("pbIMAGE4")]
		internal virtual PictureBox pbIMAGE4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("pbIMAGE7")]
		internal virtual PictureBox pbIMAGE7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("pbIMAGE3")]
		internal virtual PictureBox pbIMAGE3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("pbIMAGE6")]
		internal virtual PictureBox pbIMAGE6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("pbIMAGE2")]
		internal virtual PictureBox pbIMAGE2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("pbIMAGE1")]
		internal virtual PictureBox pbIMAGE1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkHZC4")]
		internal virtual CheckBox chkHZC4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkHZC1")]
		internal virtual CheckBox chkHZC1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkHZC2")]
		internal virtual CheckBox chkHZC2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkHZC3")]
		internal virtual CheckBox chkHZC3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkHZC6")]
		internal virtual CheckBox chkHZC6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkHZC7")]
		internal virtual CheckBox chkHZC7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkHZC5")]
		internal virtual CheckBox chkHZC5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkHZC8")]
		internal virtual CheckBox chkHZC8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("pbIMAGE8")]
		internal virtual PictureBox pbIMAGE8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("pbIMAGE5")]
		internal virtual PictureBox pbIMAGE5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label62")]
		internal virtual Label Label62
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numMONTH")]
		internal virtual NumControl numMONTH
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label63")]
		internal virtual Label Label63
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel9")]
		internal virtual TableLayoutPanel TableLayoutPanel9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label67")]
		internal virtual Label Label67
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label66")]
		internal virtual Label Label66
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label64")]
		internal virtual Label Label64
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label65")]
		internal virtual Label Label65
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSTABLE")]
		internal virtual ComboBox cbSTABLE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbFLAME")]
		internal virtual ComboBox cbFLAME
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSPECIAL")]
		internal virtual ComboBox cbSPECIAL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbHEALTH")]
		internal virtual ComboBox cbHEALTH
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("tpSPART")]
		internal virtual TabPage tpSPART
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel10")]
		internal virtual TableLayoutPanel TableLayoutPanel10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSPART_SPTNM")]
		internal virtual TextBox txtSPART_SPTNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label68")]
		internal virtual Label Label68
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSPART_SPTNO")]
		internal virtual TextBox txtSPART_SPTNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSPART_REMRK")]
		internal virtual TextBox txtSPART_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpSPART_SUPID")]
		internal virtual LookupControl lkpSPART_SUPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label70")]
		internal virtual Label Label70
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label71")]
		internal virtual Label Label71
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvSPART
		{
			[CompilerGenerated]
			get
			{
				return _dgvSPART;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvSPART_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvSPART;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvSPART = value;
				dataGridView = _dgvSPART;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label69")]
		internal virtual Label Label69
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel11")]
		internal virtual TableLayoutPanel TableLayoutPanel11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual Button btnUpdate
		{
			[CompilerGenerated]
			get
			{
				return _btnUpdate;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUpdate_Click;
				Button button = _btnUpdate;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnUpdate = value;
				button = _btnUpdate;
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

		[field: AccessedThroughProperty("Label38")]
		internal virtual Label Label38
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label72")]
		internal virtual Label Label72
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbPACKING")]
		internal virtual ComboBox cbPACKING
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numMAXLVL")]
		internal virtual NumControl numMAXLVL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label73")]
		internal virtual Label Label73
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkITMCTRL")]
		internal virtual CheckBox chkITMCTRL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkSLITM")]
		internal virtual CheckBox chkSLITM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("tpCPART")]
		internal virtual TabPage tpCPART
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel12")]
		internal virtual TableLayoutPanel TableLayoutPanel12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCPART_CPTNM")]
		internal virtual TextBox txtCPART_CPTNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label74")]
		internal virtual Label Label74
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCPART_CPTNO")]
		internal virtual TextBox txtCPART_CPTNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCPART_REMRK")]
		internal virtual TextBox txtCPART_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lkpCPART_CUSID")]
		internal virtual LookupControl lkpCPART_CUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label75")]
		internal virtual Label Label75
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label76")]
		internal virtual Label Label76
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label77")]
		internal virtual Label Label77
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvCPART
		{
			[CompilerGenerated]
			get
			{
				return _dgvCPART;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvCPART_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvCPART;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvCPART = value;
				dataGridView = _dgvCPART;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel13")]
		internal virtual TableLayoutPanel TableLayoutPanel13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnCancel2
		{
			[CompilerGenerated]
			get
			{
				return _btnCancel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCancel2_Click;
				Button button = _btnCancel2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCancel2 = value;
				button = _btnCancel2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnUpdate2
		{
			[CompilerGenerated]
			get
			{
				return _btnUpdate2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUpdate2_Click;
				Button button = _btnUpdate2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnUpdate2 = value;
				button = _btnUpdate2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnRemove2
		{
			[CompilerGenerated]
			get
			{
				return _btnRemove2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRemove2_Click;
				Button button = _btnRemove2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRemove2 = value;
				button = _btnRemove2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public frmMAEITM()
		{
			base.FormClosing += frmMAEITM_FormClosing;
			base.Shown += frmMAEITM_Shown;
			base.KeyDown += frmMAEITM_KeyDown;
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
			this.chkACTFG = new System.Windows.Forms.CheckBox();
			this.chkSRLFG = new System.Windows.Forms.CheckBox();
			this.txtCFIELD1 = new System.Windows.Forms.TextBox();
			this.txtSRLNO3 = new System.Windows.Forms.TextBox();
			this.txtSRLNO1 = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label32 = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.Label30 = new System.Windows.Forms.Label();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label29 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label28 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label27 = new System.Windows.Forms.Label();
			this.Label26 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label25 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDESC = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtITMCD = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label31 = new System.Windows.Forms.Label();
			this.txtSRLNO2 = new System.Windows.Forms.TextBox();
			this.txtCFIELD2 = new System.Windows.Forms.TextBox();
			this.txtDESC2 = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.cbITMTY = new System.Windows.Forms.ComboBox();
			this.cbCATCD = new System.Windows.Forms.ComboBox();
			this.cbGRPCD = new System.Windows.Forms.ComboBox();
			this.cbLOCCD = new System.Windows.Forms.ComboBox();
			this.cbITAXCD = new System.Windows.Forms.ComboBox();
			this.cbOTAXCD = new System.Windows.Forms.ComboBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.cbBRAND = new System.Windows.Forms.ComboBox();
			this.Label37 = new System.Windows.Forms.Label();
			this.cbSUBCATCD = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtDILCD = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.cbUOM = new System.Windows.Forms.ComboBox();
			this.cbRACKNO = new System.Windows.Forms.ComboBox();
			this.Label41 = new System.Windows.Forms.Label();
			this.cbCLRGP = new System.Windows.Forms.ComboBox();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.txtDESCTO = new System.Windows.Forms.TextBox();
			this.Label36 = new System.Windows.Forms.Label();
			this.Label35 = new System.Windows.Forms.Label();
			this.cbHBRAND = new System.Windows.Forms.ComboBox();
			this.cbHGRPCD = new System.Windows.Forms.ComboBox();
			this.Label34 = new System.Windows.Forms.Label();
			this.Label33 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.cbHITMTY = new System.Windows.Forms.ComboBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.cbHCATCD = new System.Windows.Forms.ComboBox();
			this.txtDESCFR = new System.Windows.Forms.TextBox();
			this.dgvMAITM = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.tpGENERAL = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.Label73 = new System.Windows.Forms.Label();
			this.Label63 = new System.Windows.Forms.Label();
			this.lblSTDWGT = new System.Windows.Forms.Label();
			this.Label38 = new System.Windows.Forms.Label();
			this.chkAVESL = new System.Windows.Forms.CheckBox();
			this.Label72 = new System.Windows.Forms.Label();
			this.cbPACKING = new System.Windows.Forms.ComboBox();
			this.chkSLITM = new System.Windows.Forms.CheckBox();
			this.chkITMCTRL = new System.Windows.Forms.CheckBox();
			this.tpDISPENSER = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.cbSTABLE = new System.Windows.Forms.ComboBox();
			this.cbFLAME = new System.Windows.Forms.ComboBox();
			this.cbSPECIAL = new System.Windows.Forms.ComboBox();
			this.cbHEALTH = new System.Windows.Forms.ComboBox();
			this.Label64 = new System.Windows.Forms.Label();
			this.Label65 = new System.Windows.Forms.Label();
			this.Label66 = new System.Windows.Forms.Label();
			this.Label67 = new System.Windows.Forms.Label();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.pbIMAGE4 = new System.Windows.Forms.PictureBox();
			this.pbIMAGE7 = new System.Windows.Forms.PictureBox();
			this.pbIMAGE3 = new System.Windows.Forms.PictureBox();
			this.pbIMAGE6 = new System.Windows.Forms.PictureBox();
			this.pbIMAGE2 = new System.Windows.Forms.PictureBox();
			this.pbIMAGE1 = new System.Windows.Forms.PictureBox();
			this.chkHZC4 = new System.Windows.Forms.CheckBox();
			this.chkHZC1 = new System.Windows.Forms.CheckBox();
			this.chkHZC2 = new System.Windows.Forms.CheckBox();
			this.chkHZC3 = new System.Windows.Forms.CheckBox();
			this.chkHZC6 = new System.Windows.Forms.CheckBox();
			this.chkHZC7 = new System.Windows.Forms.CheckBox();
			this.chkHZC5 = new System.Windows.Forms.CheckBox();
			this.chkHZC8 = new System.Windows.Forms.CheckBox();
			this.pbIMAGE8 = new System.Windows.Forms.PictureBox();
			this.pbIMAGE5 = new System.Windows.Forms.PictureBox();
			this.Label62 = new System.Windows.Forms.Label();
			this.chkPRDDSP = new System.Windows.Forms.CheckBox();
			this.chkPUMPMDL = new System.Windows.Forms.CheckBox();
			this.chkDSP1ST = new System.Windows.Forms.CheckBox();
			this.Label44 = new System.Windows.Forms.Label();
			this.Label39 = new System.Windows.Forms.Label();
			this.txtDILCD2 = new System.Windows.Forms.TextBox();
			this.Label40 = new System.Windows.Forms.Label();
			this.Label42 = new System.Windows.Forms.Label();
			this.Label43 = new System.Windows.Forms.Label();
			this.Label45 = new System.Windows.Forms.Label();
			this.Label46 = new System.Windows.Forms.Label();
			this.Label47 = new System.Windows.Forms.Label();
			this.Label48 = new System.Windows.Forms.Label();
			this.Label49 = new System.Windows.Forms.Label();
			this.Label50 = new System.Windows.Forms.Label();
			this.Label51 = new System.Windows.Forms.Label();
			this.Label52 = new System.Windows.Forms.Label();
			this.Label53 = new System.Windows.Forms.Label();
			this.Label54 = new System.Windows.Forms.Label();
			this.Label55 = new System.Windows.Forms.Label();
			this.Label56 = new System.Windows.Forms.Label();
			this.Label57 = new System.Windows.Forms.Label();
			this.Label58 = new System.Windows.Forms.Label();
			this.Label59 = new System.Windows.Forms.Label();
			this.Label60 = new System.Windows.Forms.Label();
			this.txtCOLORCID = new System.Windows.Forms.TextBox();
			this.Label61 = new System.Windows.Forms.Label();
			this.txtBATCH = new System.Windows.Forms.TextBox();
			this.tpOTHER = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.tpSPART = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.dgvSPART = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
			this.txtSPART_SPTNM = new System.Windows.Forms.TextBox();
			this.Label68 = new System.Windows.Forms.Label();
			this.txtSPART_SPTNO = new System.Windows.Forms.TextBox();
			this.txtSPART_REMRK = new System.Windows.Forms.TextBox();
			this.Label69 = new System.Windows.Forms.Label();
			this.Label70 = new System.Windows.Forms.Label();
			this.Label71 = new System.Windows.Forms.Label();
			this.tpCPART = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel2 = new System.Windows.Forms.Button();
			this.btnUpdate2 = new System.Windows.Forms.Button();
			this.btnRemove2 = new System.Windows.Forms.Button();
			this.TableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
			this.txtCPART_CPTNM = new System.Windows.Forms.TextBox();
			this.Label74 = new System.Windows.Forms.Label();
			this.txtCPART_CPTNO = new System.Windows.Forms.TextBox();
			this.txtCPART_REMRK = new System.Windows.Forms.TextBox();
			this.Label75 = new System.Windows.Forms.Label();
			this.Label76 = new System.Windows.Forms.Label();
			this.Label77 = new System.Windows.Forms.Label();
			this.dgvCPART = new System.Windows.Forms.DataGridView();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.numMAXLVL = new IMS.NumControl();
			this.numMONTH = new IMS.NumControl();
			this.numSTDWGT = new IMS.NumControl();
			this.cbSUPCD = new IMS.ComboboxControl();
			this.numSLPRC = new IMS.NumControl();
			this.numPUPRC = new IMS.NumControl();
			this.numLTIME = new IMS.NumControl();
			this.numMOQ = new IMS.NumControl();
			this.numSPQ = new IMS.NumControl();
			this.numSAFETY = new IMS.NumControl();
			this.numVALVE = new IMS.NumControl();
			this.numLABVALVE = new IMS.NumControl();
			this.numDILRT2 = new IMS.NumControl();
			this.numDILRT = new IMS.NumControl();
			this.numSTUTTER = new IMS.NumControl();
			this.numMINSPIT = new IMS.NumControl();
			this.numFLOW2TO1 = new IMS.NumControl();
			this.numFLOW1TOOFF = new IMS.NumControl();
			this.numRECIRC = new IMS.NumControl();
			this.numTOLERG = new IMS.NumControl();
			this.numTOLERP = new IMS.NumControl();
			this.numDSPLOW = new IMS.NumControl();
			this.numDSPORD = new IMS.NumControl();
			this.numSTKDSP = new IMS.NumControl();
			this.numBARSZ = new IMS.NumControl();
			this.numNFIELD1 = new IMS.NumControl();
			this.numNFIELD2 = new IMS.NumControl();
			this.lkpSPART_SUPID = new IMS.LookupControl();
			this.lkpCPART_CUSID = new IMS.LookupControl();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMAITM).BeginInit();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel8.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.tpGENERAL.SuspendLayout();
			this.TableLayoutPanel7.SuspendLayout();
			this.tpDISPENSER.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel9.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE4).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE7).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE6).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE8).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE5).BeginInit();
			this.tpOTHER.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.tpSPART.SuspendLayout();
			this.TableLayoutPanel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvSPART).BeginInit();
			this.TableLayoutPanel10.SuspendLayout();
			this.tpCPART.SuspendLayout();
			this.TableLayoutPanel13.SuspendLayout();
			this.TableLayoutPanel12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvCPART).BeginInit();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 5;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(0, 20);
			this.TableLayoutPanel1.TabIndex = 0;
			this.chkACTFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkACTFG.AutoSize = true;
			this.chkACTFG.Location = new System.Drawing.Point(464, 6);
			this.chkACTFG.Margin = new System.Windows.Forms.Padding(4);
			this.chkACTFG.Name = "chkACTFG";
			this.chkACTFG.Size = new System.Drawing.Size(15, 14);
			this.chkACTFG.TabIndex = 5;
			this.chkACTFG.UseVisualStyleBackColor = true;
			this.chkSRLFG.AutoSize = true;
			this.chkSRLFG.Location = new System.Drawing.Point(119, 34);
			this.chkSRLFG.Margin = new System.Windows.Forms.Padding(4);
			this.chkSRLFG.Name = "chkSRLFG";
			this.chkSRLFG.Size = new System.Drawing.Size(15, 14);
			this.chkSRLFG.TabIndex = 46;
			this.chkSRLFG.UseVisualStyleBackColor = true;
			this.txtCFIELD1.Location = new System.Drawing.Point(118, 132);
			this.txtCFIELD1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCFIELD1.Name = "txtCFIELD1";
			this.txtCFIELD1.Size = new System.Drawing.Size(225, 22);
			this.txtCFIELD1.TabIndex = 50;
			this.txtSRLNO3.Location = new System.Drawing.Point(118, 106);
			this.txtSRLNO3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSRLNO3.Name = "txtSRLNO3";
			this.txtSRLNO3.Size = new System.Drawing.Size(225, 22);
			this.txtSRLNO3.TabIndex = 49;
			this.txtSRLNO1.Location = new System.Drawing.Point(118, 54);
			this.txtSRLNO1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSRLNO1.Name = "txtSRLNO1";
			this.txtSRLNO1.Size = new System.Drawing.Size(225, 22);
			this.txtSRLNO1.TabIndex = 47;
			this.Label24.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label24.AutoSize = true;
			this.Label24.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label24.Location = new System.Drawing.Point(3, 33);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(73, 16);
			this.Label24.TabIndex = 18;
			this.Label24.Text = "Serial Flag";
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(512, 214);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(77, 16);
			this.Label18.TabIndex = 13;
			this.Label18.Text = "Sales Price";
			this.Label32.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label32.AutoSize = true;
			this.Label32.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label32.Location = new System.Drawing.Point(349, 162);
			this.Label32.Name = "Label32";
			this.Label32.Size = new System.Drawing.Size(101, 16);
			this.Label32.TabIndex = 26;
			this.Label32.Text = "Numeric Field 2";
			this.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label23.AutoSize = true;
			this.Label23.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label23.Location = new System.Drawing.Point(349, 7);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(108, 16);
			this.Label23.TabIndex = 17;
			this.Label23.Text = "Output Tax Code";
			this.Label30.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label30.AutoSize = true;
			this.Label30.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label30.Location = new System.Drawing.Point(349, 135);
			this.Label30.Name = "Label30";
			this.Label30.Size = new System.Drawing.Size(109, 16);
			this.Label30.TabIndex = 24;
			this.Label30.Text = "Character Field 2";
			this.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label22.Location = new System.Drawing.Point(3, 7);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(98, 16);
			this.Label22.TabIndex = 16;
			this.Label22.Text = "Input Tax Code";
			this.Label29.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label29.AutoSize = true;
			this.Label29.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label29.Location = new System.Drawing.Point(3, 135);
			this.Label29.Name = "Label29";
			this.Label29.Size = new System.Drawing.Size(109, 16);
			this.Label29.TabIndex = 23;
			this.Label29.Text = "Character Field 1";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 214);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(99, 16);
			this.Label17.TabIndex = 12;
			this.Label17.Text = "Purchase Price";
			this.Label28.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label28.AutoSize = true;
			this.Label28.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label28.Location = new System.Drawing.Point(382, 5);
			this.Label28.Name = "Label28";
			this.Label28.Size = new System.Drawing.Size(75, 16);
			this.Label28.TabIndex = 22;
			this.Label28.Text = "Active Flag";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 97);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(82, 16);
			this.Label21.TabIndex = 15;
			this.Label21.Text = "Safety Level";
			this.Label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label27.AutoSize = true;
			this.Label27.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label27.Location = new System.Drawing.Point(3, 109);
			this.Label27.Name = "Label27";
			this.Label27.Size = new System.Drawing.Size(74, 16);
			this.Label27.TabIndex = 21;
			this.Label27.Text = "Serial No 3";
			this.Label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label26.AutoSize = true;
			this.Label26.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label26.Location = new System.Drawing.Point(3, 83);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(74, 16);
			this.Label26.TabIndex = 20;
			this.Label26.Text = "Serial No 2";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(3, 157);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(94, 16);
			this.Label16.TabIndex = 11;
			this.Label16.Text = "Supplier Code";
			this.Label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label25.AutoSize = true;
			this.Label25.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label25.Location = new System.Drawing.Point(3, 57);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(74, 16);
			this.Label25.TabIndex = 19;
			this.Label25.Text = "Serial No 1";
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 127);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(95, 16);
			this.Label11.TabIndex = 7;
			this.Label11.Text = "Location Code";
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(512, 157);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(73, 16);
			this.Label15.TabIndex = 10;
			this.Label15.Text = "Lead Time";
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(512, 186);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(149, 16);
			this.Label14.TabIndex = 9;
			this.Label14.Text = "Minimum Order Quantity";
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 186);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(166, 16);
			this.Label13.TabIndex = 8;
			this.Label13.Text = "Standard Packing Quantity";
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 37);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(73, 16);
			this.Label9.TabIndex = 5;
			this.Label9.Text = "Item Group";
			this.TableLayoutPanel8.SetColumnSpan(this.txtREMRK, 3);
			this.txtREMRK.Location = new System.Drawing.Point(151, 80);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(474, 64);
			this.txtREMRK.TabIndex = 4;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(512, 7);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(91, 16);
			this.Label8.TabIndex = 4;
			this.Label8.Text = "Item Category";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 104);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(56, 16);
			this.Label6.TabIndex = 4;
			this.Label6.Text = "Remark";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 7);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(68, 16);
			this.Label4.TabIndex = 2;
			this.Label4.Text = "Item Type";
			this.TableLayoutPanel8.SetColumnSpan(this.txtDESC, 2);
			this.txtDESC.Location = new System.Drawing.Point(151, 28);
			this.txtDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDESC.Name = "txtDESC";
			this.txtDESC.Size = new System.Drawing.Size(305, 22);
			this.txtDESC.TabIndex = 2;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 31);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Description";
			this.txtITMCD.Location = new System.Drawing.Point(151, 2);
			this.txtITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtITMCD.Name = "txtITMCD";
			this.txtITMCD.Size = new System.Drawing.Size(225, 22);
			this.txtITMCD.TabIndex = 1;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(69, 16);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "Item Code";
			this.Label31.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label31.AutoSize = true;
			this.Label31.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label31.Location = new System.Drawing.Point(3, 162);
			this.Label31.Name = "Label31";
			this.Label31.Size = new System.Drawing.Size(101, 16);
			this.Label31.TabIndex = 25;
			this.Label31.Text = "Numeric Field 1";
			this.txtSRLNO2.Location = new System.Drawing.Point(118, 80);
			this.txtSRLNO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSRLNO2.Name = "txtSRLNO2";
			this.txtSRLNO2.Size = new System.Drawing.Size(225, 22);
			this.txtSRLNO2.TabIndex = 48;
			this.txtCFIELD2.Location = new System.Drawing.Point(464, 132);
			this.txtCFIELD2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCFIELD2.Name = "txtCFIELD2";
			this.txtCFIELD2.Size = new System.Drawing.Size(225, 22);
			this.txtCFIELD2.TabIndex = 51;
			this.TableLayoutPanel8.SetColumnSpan(this.txtDESC2, 2);
			this.txtDESC2.Location = new System.Drawing.Point(151, 54);
			this.txtDESC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDESC2.Name = "txtDESC2";
			this.txtDESC2.Size = new System.Drawing.Size(306, 22);
			this.txtDESC2.TabIndex = 3;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 57);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(142, 16);
			this.Label7.TabIndex = 32;
			this.Label7.Text = "Sales Item Description";
			this.cbITMTY.FormattingEnabled = true;
			this.cbITMTY.Location = new System.Drawing.Point(175, 3);
			this.cbITMTY.Name = "cbITMTY";
			this.cbITMTY.Size = new System.Drawing.Size(133, 24);
			this.cbITMTY.TabIndex = 6;
			this.cbCATCD.FormattingEnabled = true;
			this.cbCATCD.Location = new System.Drawing.Point(679, 3);
			this.cbCATCD.Name = "cbCATCD";
			this.cbCATCD.Size = new System.Drawing.Size(133, 24);
			this.cbCATCD.TabIndex = 7;
			this.cbGRPCD.FormattingEnabled = true;
			this.cbGRPCD.Location = new System.Drawing.Point(175, 33);
			this.cbGRPCD.Name = "cbGRPCD";
			this.cbGRPCD.Size = new System.Drawing.Size(133, 24);
			this.cbGRPCD.TabIndex = 8;
			this.cbLOCCD.FormattingEnabled = true;
			this.cbLOCCD.Location = new System.Drawing.Point(175, 123);
			this.cbLOCCD.Name = "cbLOCCD";
			this.cbLOCCD.Size = new System.Drawing.Size(133, 24);
			this.cbLOCCD.TabIndex = 14;
			this.cbITAXCD.FormattingEnabled = true;
			this.cbITAXCD.Location = new System.Drawing.Point(118, 3);
			this.cbITAXCD.Name = "cbITAXCD";
			this.cbITAXCD.Size = new System.Drawing.Size(133, 24);
			this.cbITAXCD.TabIndex = 44;
			this.cbOTAXCD.FormattingEnabled = true;
			this.cbOTAXCD.Location = new System.Drawing.Point(464, 3);
			this.cbOTAXCD.Name = "cbOTAXCD";
			this.cbOTAXCD.Size = new System.Drawing.Size(133, 24);
			this.cbOTAXCD.TabIndex = 45;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 67);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(72, 16);
			this.Label10.TabIndex = 6;
			this.Label10.Text = "Item Brand";
			this.cbBRAND.FormattingEnabled = true;
			this.cbBRAND.Location = new System.Drawing.Point(175, 63);
			this.cbBRAND.Name = "cbBRAND";
			this.cbBRAND.Size = new System.Drawing.Size(133, 24);
			this.cbBRAND.TabIndex = 10;
			this.Label37.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label37.AutoSize = true;
			this.Label37.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label37.Location = new System.Drawing.Point(512, 37);
			this.Label37.Name = "Label37";
			this.Label37.Size = new System.Drawing.Size(118, 16);
			this.Label37.TabIndex = 48;
			this.Label37.Text = "Item Sub Category";
			this.cbSUBCATCD.FormattingEnabled = true;
			this.cbSUBCATCD.Location = new System.Drawing.Point(679, 33);
			this.cbSUBCATCD.Name = "cbSUBCATCD";
			this.cbSUBCATCD.Size = new System.Drawing.Size(133, 24);
			this.cbSUBCATCD.TabIndex = 9;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(757, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDelete.Name = "btnDelete";
			this.TableLayoutPanel8.SetRowSpan(this.btnDelete, 2);
			this.btnDelete.Size = new System.Drawing.Size(120, 48);
			this.btnDelete.TabIndex = 55;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(1009, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.TableLayoutPanel8.SetRowSpan(this.btnPRINT, 2);
			this.btnPRINT.Size = new System.Drawing.Size(120, 48);
			this.btnPRINT.TabIndex = 57;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(883, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBack.Name = "btnBack";
			this.TableLayoutPanel8.SetRowSpan(this.btnBack, 2);
			this.btnBack.Size = new System.Drawing.Size(120, 48);
			this.btnBack.TabIndex = 56;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(631, 2);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.TableLayoutPanel8.SetRowSpan(this.btnSave, 2);
			this.btnSave.Size = new System.Drawing.Size(120, 48);
			this.btnSave.TabIndex = 54;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.txtDILCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtDILCD.Location = new System.Drawing.Point(149, 256);
			this.txtDILCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDILCD.Name = "txtDILCD";
			this.txtDILCD.Size = new System.Drawing.Size(225, 22);
			this.txtDILCD.TabIndex = 40;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(512, 97);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(39, 16);
			this.Label12.TabIndex = 8;
			this.Label12.Text = "UOM";
			this.cbUOM.FormattingEnabled = true;
			this.cbUOM.Location = new System.Drawing.Point(679, 93);
			this.cbUOM.Name = "cbUOM";
			this.cbUOM.Size = new System.Drawing.Size(133, 24);
			this.cbUOM.TabIndex = 13;
			this.cbRACKNO.FormattingEnabled = true;
			this.cbRACKNO.Location = new System.Drawing.Point(679, 123);
			this.cbRACKNO.Name = "cbRACKNO";
			this.cbRACKNO.Size = new System.Drawing.Size(133, 24);
			this.cbRACKNO.TabIndex = 15;
			this.Label41.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label41.AutoSize = true;
			this.Label41.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label41.Location = new System.Drawing.Point(512, 67);
			this.Label41.Name = "Label41";
			this.Label41.Size = new System.Drawing.Size(80, 16);
			this.Label41.TabIndex = 56;
			this.Label41.Text = "Color Group";
			this.cbCLRGP.FormattingEnabled = true;
			this.cbCLRGP.Location = new System.Drawing.Point(679, 63);
			this.cbCLRGP.Name = "cbCLRGP";
			this.cbCLRGP.Size = new System.Drawing.Size(133, 24);
			this.cbCLRGP.TabIndex = 11;
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(255, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 48);
			this.btnPRINTFR.TabIndex = 4;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(129, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 48);
			this.btnNew.TabIndex = 3;
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
			this.btnSearch.Size = new System.Drawing.Size(120, 48);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Search";
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.cbITMCDTO, 3, 2);
			this.TableLayoutPanel3.Controls.Add(this.txtDESCTO, 3, 3);
			this.TableLayoutPanel3.Controls.Add(this.Label36, 2, 3);
			this.TableLayoutPanel3.Controls.Add(this.Label35, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.cbHITMTY, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label19, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label5, 2, 2);
			this.TableLayoutPanel3.Controls.Add(this.cbITMCDFR, 1, 2);
			this.TableLayoutPanel3.Controls.Add(this.txtDESCFR, 1, 3);
			this.TableLayoutPanel3.Controls.Add(this.cbHCATCD, 3, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label20, 2, 1);
			this.TableLayoutPanel3.Controls.Add(this.Label33, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label34, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.cbHGRPCD, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.cbHBRAND, 1, 1);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(5, 8);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 4;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(851, 117);
			this.TableLayoutPanel3.TabIndex = 1;
			this.txtDESCTO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDESCTO.Location = new System.Drawing.Point(520, 93);
			this.txtDESCTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDESCTO.Name = "txtDESCTO";
			this.txtDESCTO.Size = new System.Drawing.Size(214, 22);
			this.txtDESCTO.TabIndex = 49;
			this.Label36.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label36.AutoSize = true;
			this.Label36.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label36.Location = new System.Drawing.Point(423, 96);
			this.Label36.Name = "Label36";
			this.Label36.Size = new System.Drawing.Size(25, 16);
			this.Label36.TabIndex = 47;
			this.Label36.Text = "To";
			this.Label35.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label35.AutoSize = true;
			this.Label35.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label35.Location = new System.Drawing.Point(3, 96);
			this.Label35.Name = "Label35";
			this.Label35.Size = new System.Drawing.Size(76, 16);
			this.Label35.TabIndex = 46;
			this.Label35.Text = "Description";
			this.cbHBRAND.FormattingEnabled = true;
			this.cbHBRAND.Location = new System.Drawing.Point(85, 33);
			this.cbHBRAND.Name = "cbHBRAND";
			this.cbHBRAND.Size = new System.Drawing.Size(133, 24);
			this.cbHBRAND.TabIndex = 45;
			this.cbHGRPCD.FormattingEnabled = true;
			this.cbHGRPCD.Location = new System.Drawing.Point(520, 3);
			this.cbHGRPCD.Name = "cbHGRPCD";
			this.cbHGRPCD.Size = new System.Drawing.Size(133, 24);
			this.cbHGRPCD.TabIndex = 44;
			this.Label34.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label34.AutoSize = true;
			this.Label34.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label34.Location = new System.Drawing.Point(3, 37);
			this.Label34.Name = "Label34";
			this.Label34.Size = new System.Drawing.Size(44, 16);
			this.Label34.TabIndex = 43;
			this.Label34.Text = "Brand";
			this.Label33.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label33.AutoSize = true;
			this.Label33.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label33.Location = new System.Drawing.Point(423, 7);
			this.Label33.Name = "Label33";
			this.Label33.Size = new System.Drawing.Size(81, 16);
			this.Label33.TabIndex = 42;
			this.Label33.Text = "Group Code";
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(423, 37);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(91, 16);
			this.Label20.TabIndex = 40;
			this.Label20.Text = "Item Category";
			this.cbHITMTY.FormattingEnabled = true;
			this.cbHITMTY.Location = new System.Drawing.Point(85, 3);
			this.cbHITMTY.Name = "cbHITMTY";
			this.cbHITMTY.Size = new System.Drawing.Size(133, 24);
			this.cbHITMTY.TabIndex = 39;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(3, 7);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(68, 16);
			this.Label19.TabIndex = 38;
			this.Label19.Text = "Item Type";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 67);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(69, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Item Code";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(423, 67);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(25, 16);
			this.Label5.TabIndex = 3;
			this.Label5.Text = "To";
			this.cbHCATCD.FormattingEnabled = true;
			this.cbHCATCD.Location = new System.Drawing.Point(520, 33);
			this.cbHCATCD.Name = "cbHCATCD";
			this.cbHCATCD.Size = new System.Drawing.Size(133, 24);
			this.cbHCATCD.TabIndex = 41;
			this.txtDESCFR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtDESCFR.Location = new System.Drawing.Point(85, 93);
			this.txtDESCFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDESCFR.Name = "txtDESCFR";
			this.txtDESCFR.Size = new System.Drawing.Size(214, 22);
			this.txtDESCFR.TabIndex = 48;
			this.dgvMAITM.AllowUserToAddRows = false;
			this.dgvMAITM.AllowUserToDeleteRows = false;
			this.dgvMAITM.AllowUserToResizeRows = false;
			this.dgvMAITM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMAITM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMAITM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMAITM.EnableHeadersVisualStyles = false;
			this.dgvMAITM.Location = new System.Drawing.Point(5, 189);
			this.dgvMAITM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMAITM.MultiSelect = false;
			this.dgvMAITM.Name = "dgvMAITM";
			this.dgvMAITM.ReadOnly = true;
			this.dgvMAITM.RowHeadersVisible = false;
			this.dgvMAITM.RowHeadersWidth = 51;
			this.dgvMAITM.RowTemplate.Height = 24;
			this.dgvMAITM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMAITM.Size = new System.Drawing.Size(1358, 553);
			this.dgvMAITM.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel8);
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1794, 809);
			this.Panel1.TabIndex = 4;
			this.TableLayoutPanel8.ColumnCount = 8;
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.Controls.Add(this.btnPRINT, 7, 0);
			this.TableLayoutPanel8.Controls.Add(this.btnDelete, 5, 0);
			this.TableLayoutPanel8.Controls.Add(this.btnBack, 6, 0);
			this.TableLayoutPanel8.Controls.Add(this.txtREMRK, 1, 3);
			this.TableLayoutPanel8.Controls.Add(this.txtDESC, 1, 1);
			this.TableLayoutPanel8.Controls.Add(this.btnSave, 4, 0);
			this.TableLayoutPanel8.Controls.Add(this.Label6, 0, 3);
			this.TableLayoutPanel8.Controls.Add(this.txtDESC2, 1, 2);
			this.TableLayoutPanel8.Controls.Add(this.Label1, 0, 0);
			this.TableLayoutPanel8.Controls.Add(this.Label3, 0, 1);
			this.TableLayoutPanel8.Controls.Add(this.Label7, 0, 2);
			this.TableLayoutPanel8.Controls.Add(this.txtITMCD, 1, 0);
			this.TableLayoutPanel8.Controls.Add(this.Label28, 2, 0);
			this.TableLayoutPanel8.Controls.Add(this.chkACTFG, 3, 0);
			this.TableLayoutPanel8.Controls.Add(this.TabControl1, 0, 4);
			this.TableLayoutPanel8.Location = new System.Drawing.Point(4, 8);
			this.TableLayoutPanel8.Name = "TableLayoutPanel8";
			this.TableLayoutPanel8.RowCount = 5;
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.Size = new System.Drawing.Size(1134, 615);
			this.TableLayoutPanel8.TabIndex = 5;
			this.TableLayoutPanel8.SetColumnSpan(this.TabControl1, 8);
			this.TabControl1.Controls.Add(this.tpGENERAL);
			this.TabControl1.Controls.Add(this.tpDISPENSER);
			this.TabControl1.Controls.Add(this.tpOTHER);
			this.TabControl1.Controls.Add(this.tpSPART);
			this.TabControl1.Controls.Add(this.tpCPART);
			this.TabControl1.Location = new System.Drawing.Point(3, 149);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(1115, 445);
			this.TabControl1.TabIndex = 4;
			this.TabControl1.TabStop = false;
			this.tpGENERAL.BackColor = System.Drawing.Color.AliceBlue;
			this.tpGENERAL.Controls.Add(this.TableLayoutPanel7);
			this.tpGENERAL.Location = new System.Drawing.Point(4, 25);
			this.tpGENERAL.Name = "tpGENERAL";
			this.tpGENERAL.Padding = new System.Windows.Forms.Padding(3);
			this.tpGENERAL.Size = new System.Drawing.Size(1107, 416);
			this.tpGENERAL.TabIndex = 0;
			this.tpGENERAL.Text = "General";
			this.TableLayoutPanel7.ColumnCount = 5;
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 343f));
			this.TableLayoutPanel7.Controls.Add(this.numMAXLVL, 1, 10);
			this.TableLayoutPanel7.Controls.Add(this.numMONTH, 1, 9);
			this.TableLayoutPanel7.Controls.Add(this.Label73, 0, 10);
			this.TableLayoutPanel7.Controls.Add(this.Label63, 0, 9);
			this.TableLayoutPanel7.Controls.Add(this.numSTDWGT, 1, 8);
			this.TableLayoutPanel7.Controls.Add(this.lblSTDWGT, 0, 8);
			this.TableLayoutPanel7.Controls.Add(this.cbSUPCD, 1, 5);
			this.TableLayoutPanel7.Controls.Add(this.numSLPRC, 3, 7);
			this.TableLayoutPanel7.Controls.Add(this.numPUPRC, 1, 7);
			this.TableLayoutPanel7.Controls.Add(this.numLTIME, 3, 5);
			this.TableLayoutPanel7.Controls.Add(this.numMOQ, 3, 6);
			this.TableLayoutPanel7.Controls.Add(this.numSPQ, 1, 6);
			this.TableLayoutPanel7.Controls.Add(this.numSAFETY, 1, 3);
			this.TableLayoutPanel7.Controls.Add(this.Label9, 0, 1);
			this.TableLayoutPanel7.Controls.Add(this.Label8, 2, 0);
			this.TableLayoutPanel7.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel7.Controls.Add(this.Label21, 0, 3);
			this.TableLayoutPanel7.Controls.Add(this.Label18, 2, 7);
			this.TableLayoutPanel7.Controls.Add(this.Label11, 0, 4);
			this.TableLayoutPanel7.Controls.Add(this.cbCATCD, 3, 0);
			this.TableLayoutPanel7.Controls.Add(this.cbITMTY, 1, 0);
			this.TableLayoutPanel7.Controls.Add(this.cbLOCCD, 1, 4);
			this.TableLayoutPanel7.Controls.Add(this.Label38, 2, 4);
			this.TableLayoutPanel7.Controls.Add(this.Label14, 2, 6);
			this.TableLayoutPanel7.Controls.Add(this.cbSUBCATCD, 3, 1);
			this.TableLayoutPanel7.Controls.Add(this.Label37, 2, 1);
			this.TableLayoutPanel7.Controls.Add(this.cbGRPCD, 1, 1);
			this.TableLayoutPanel7.Controls.Add(this.cbRACKNO, 3, 4);
			this.TableLayoutPanel7.Controls.Add(this.Label16, 0, 5);
			this.TableLayoutPanel7.Controls.Add(this.Label15, 2, 5);
			this.TableLayoutPanel7.Controls.Add(this.cbBRAND, 1, 2);
			this.TableLayoutPanel7.Controls.Add(this.Label10, 0, 2);
			this.TableLayoutPanel7.Controls.Add(this.cbCLRGP, 3, 2);
			this.TableLayoutPanel7.Controls.Add(this.Label41, 2, 2);
			this.TableLayoutPanel7.Controls.Add(this.Label13, 0, 6);
			this.TableLayoutPanel7.Controls.Add(this.Label17, 0, 7);
			this.TableLayoutPanel7.Controls.Add(this.cbUOM, 3, 3);
			this.TableLayoutPanel7.Controls.Add(this.Label12, 2, 3);
			this.TableLayoutPanel7.Controls.Add(this.chkAVESL, 2, 9);
			this.TableLayoutPanel7.Controls.Add(this.Label72, 2, 8);
			this.TableLayoutPanel7.Controls.Add(this.cbPACKING, 3, 8);
			this.TableLayoutPanel7.Controls.Add(this.chkSLITM, 2, 10);
			this.TableLayoutPanel7.Controls.Add(this.chkITMCTRL, 2, 11);
			this.TableLayoutPanel7.Location = new System.Drawing.Point(7, 7);
			this.TableLayoutPanel7.Name = "TableLayoutPanel7";
			this.TableLayoutPanel7.RowCount = 12;
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel7.Size = new System.Drawing.Size(1097, 399);
			this.TableLayoutPanel7.TabIndex = 0;
			this.Label73.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label73.AutoSize = true;
			this.Label73.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label73.Location = new System.Drawing.Point(3, 300);
			this.Label73.Name = "Label73";
			this.Label73.Size = new System.Drawing.Size(69, 16);
			this.Label73.TabIndex = 17;
			this.Label73.Text = "Max Level";
			this.Label63.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label63.AutoSize = true;
			this.Label63.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label63.Location = new System.Drawing.Point(3, 272);
			this.Label63.Name = "Label63";
			this.Label63.Size = new System.Drawing.Size(85, 16);
			this.Label63.TabIndex = 57;
			this.Label63.Text = "Expire Month";
			this.lblSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTDWGT.AutoSize = true;
			this.lblSTDWGT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTDWGT.Location = new System.Drawing.Point(3, 243);
			this.lblSTDWGT.Name = "lblSTDWGT";
			this.lblSTDWGT.Size = new System.Drawing.Size(108, 16);
			this.lblSTDWGT.TabIndex = 13;
			this.lblSTDWGT.Text = "Standard Weight";
			this.Label38.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label38.AutoSize = true;
			this.Label38.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label38.Location = new System.Drawing.Point(512, 127);
			this.Label38.Name = "Label38";
			this.Label38.Size = new System.Drawing.Size(96, 16);
			this.Label38.TabIndex = 50;
			this.Label38.Text = "Base Rack No";
			this.chkAVESL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkAVESL.AutoSize = true;
			this.chkAVESL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAVESL.Location = new System.Drawing.Point(512, 270);
			this.chkAVESL.Name = "chkAVESL";
			this.chkAVESL.Size = new System.Drawing.Size(117, 20);
			this.chkAVESL.TabIndex = 22;
			this.chkAVESL.Text = "Average Sales";
			this.chkAVESL.UseVisualStyleBackColor = true;
			this.Label72.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label72.AutoSize = true;
			this.Label72.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label72.Location = new System.Drawing.Point(512, 243);
			this.Label72.Name = "Label72";
			this.Label72.Size = new System.Drawing.Size(57, 16);
			this.Label72.TabIndex = 58;
			this.Label72.Text = "Packing";
			this.cbPACKING.FormattingEnabled = true;
			this.cbPACKING.Location = new System.Drawing.Point(679, 239);
			this.cbPACKING.Name = "cbPACKING";
			this.cbPACKING.Size = new System.Drawing.Size(133, 24);
			this.cbPACKING.TabIndex = 20;
			this.chkSLITM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkSLITM.AutoSize = true;
			this.chkSLITM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkSLITM.Location = new System.Drawing.Point(512, 298);
			this.chkSLITM.Name = "chkSLITM";
			this.chkSLITM.Size = new System.Drawing.Size(90, 20);
			this.chkSLITM.TabIndex = 60;
			this.chkSLITM.Text = "Sales Item";
			this.chkSLITM.UseVisualStyleBackColor = true;
			this.chkITMCTRL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkITMCTRL.AutoSize = true;
			this.chkITMCTRL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkITMCTRL.Location = new System.Drawing.Point(512, 350);
			this.chkITMCTRL.Name = "chkITMCTRL";
			this.chkITMCTRL.Size = new System.Drawing.Size(161, 20);
			this.chkITMCTRL.TabIndex = 59;
			this.chkITMCTRL.Text = "Control By Warehouse";
			this.chkITMCTRL.UseVisualStyleBackColor = true;
			this.tpDISPENSER.BackColor = System.Drawing.Color.AliceBlue;
			this.tpDISPENSER.Controls.Add(this.TableLayoutPanel6);
			this.tpDISPENSER.Location = new System.Drawing.Point(4, 25);
			this.tpDISPENSER.Name = "tpDISPENSER";
			this.tpDISPENSER.Padding = new System.Windows.Forms.Padding(3);
			this.tpDISPENSER.Size = new System.Drawing.Size(1107, 416);
			this.tpDISPENSER.TabIndex = 1;
			this.tpDISPENSER.Text = "Dispenser";
			this.TableLayoutPanel6.ColumnCount = 6;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.TableLayoutPanel9, 4, 8);
			this.TableLayoutPanel6.Controls.Add(this.TableLayoutPanel2, 4, 1);
			this.TableLayoutPanel6.Controls.Add(this.Label62, 4, 0);
			this.TableLayoutPanel6.Controls.Add(this.chkPRDDSP, 1, 4);
			this.TableLayoutPanel6.Controls.Add(this.numVALVE, 1, 5);
			this.TableLayoutPanel6.Controls.Add(this.numLABVALVE, 3, 5);
			this.TableLayoutPanel6.Controls.Add(this.chkPUMPMDL, 3, 8);
			this.TableLayoutPanel6.Controls.Add(this.chkDSP1ST, 1, 8);
			this.TableLayoutPanel6.Controls.Add(this.Label44, 0, 8);
			this.TableLayoutPanel6.Controls.Add(this.numDILRT2, 3, 10);
			this.TableLayoutPanel6.Controls.Add(this.numDILRT, 3, 9);
			this.TableLayoutPanel6.Controls.Add(this.txtDILCD, 1, 9);
			this.TableLayoutPanel6.Controls.Add(this.Label39, 0, 9);
			this.TableLayoutPanel6.Controls.Add(this.txtDILCD2, 1, 10);
			this.TableLayoutPanel6.Controls.Add(this.Label40, 2, 9);
			this.TableLayoutPanel6.Controls.Add(this.Label42, 0, 10);
			this.TableLayoutPanel6.Controls.Add(this.Label43, 2, 10);
			this.TableLayoutPanel6.Controls.Add(this.Label45, 2, 8);
			this.TableLayoutPanel6.Controls.Add(this.Label46, 0, 7);
			this.TableLayoutPanel6.Controls.Add(this.numSTUTTER, 1, 7);
			this.TableLayoutPanel6.Controls.Add(this.numMINSPIT, 3, 7);
			this.TableLayoutPanel6.Controls.Add(this.Label47, 2, 7);
			this.TableLayoutPanel6.Controls.Add(this.numFLOW2TO1, 1, 6);
			this.TableLayoutPanel6.Controls.Add(this.numFLOW1TOOFF, 3, 6);
			this.TableLayoutPanel6.Controls.Add(this.Label48, 0, 6);
			this.TableLayoutPanel6.Controls.Add(this.Label49, 2, 6);
			this.TableLayoutPanel6.Controls.Add(this.Label50, 0, 5);
			this.TableLayoutPanel6.Controls.Add(this.Label51, 2, 5);
			this.TableLayoutPanel6.Controls.Add(this.Label52, 2, 4);
			this.TableLayoutPanel6.Controls.Add(this.numRECIRC, 3, 4);
			this.TableLayoutPanel6.Controls.Add(this.Label53, 0, 4);
			this.TableLayoutPanel6.Controls.Add(this.Label54, 0, 3);
			this.TableLayoutPanel6.Controls.Add(this.Label55, 2, 3);
			this.TableLayoutPanel6.Controls.Add(this.numTOLERG, 1, 3);
			this.TableLayoutPanel6.Controls.Add(this.numTOLERP, 3, 3);
			this.TableLayoutPanel6.Controls.Add(this.Label56, 0, 2);
			this.TableLayoutPanel6.Controls.Add(this.numDSPLOW, 1, 2);
			this.TableLayoutPanel6.Controls.Add(this.Label57, 2, 2);
			this.TableLayoutPanel6.Controls.Add(this.numDSPORD, 3, 2);
			this.TableLayoutPanel6.Controls.Add(this.Label58, 0, 1);
			this.TableLayoutPanel6.Controls.Add(this.numSTKDSP, 1, 1);
			this.TableLayoutPanel6.Controls.Add(this.Label59, 2, 1);
			this.TableLayoutPanel6.Controls.Add(this.numBARSZ, 3, 1);
			this.TableLayoutPanel6.Controls.Add(this.Label60, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.txtCOLORCID, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.Label61, 2, 0);
			this.TableLayoutPanel6.Controls.Add(this.txtBATCH, 3, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(7, 7);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 11;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Size = new System.Drawing.Size(1094, 363);
			this.TableLayoutPanel6.TabIndex = 0;
			this.TableLayoutPanel9.ColumnCount = 2;
			this.TableLayoutPanel6.SetColumnSpan(this.TableLayoutPanel9, 2);
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.Controls.Add(this.cbSTABLE, 1, 3);
			this.TableLayoutPanel9.Controls.Add(this.cbFLAME, 1, 2);
			this.TableLayoutPanel9.Controls.Add(this.cbSPECIAL, 1, 1);
			this.TableLayoutPanel9.Controls.Add(this.cbHEALTH, 1, 0);
			this.TableLayoutPanel9.Controls.Add(this.Label64, 0, 0);
			this.TableLayoutPanel9.Controls.Add(this.Label65, 0, 1);
			this.TableLayoutPanel9.Controls.Add(this.Label66, 0, 2);
			this.TableLayoutPanel9.Controls.Add(this.Label67, 0, 3);
			this.TableLayoutPanel9.Location = new System.Drawing.Point(767, 234);
			this.TableLayoutPanel9.Name = "TableLayoutPanel9";
			this.TableLayoutPanel9.RowCount = 4;
			this.TableLayoutPanel6.SetRowSpan(this.TableLayoutPanel9, 5);
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.Size = new System.Drawing.Size(315, 121);
			this.TableLayoutPanel9.TabIndex = 6;
			this.cbSTABLE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTABLE.FormattingEnabled = true;
			this.cbSTABLE.Items.AddRange(new object[4] { "Material Issue to Production", "Material Transfer to Service", "Production Return to Store", "Service Return to Store" });
			this.cbSTABLE.Location = new System.Drawing.Point(63, 93);
			this.cbSTABLE.Name = "cbSTABLE";
			this.cbSTABLE.Size = new System.Drawing.Size(145, 24);
			this.cbSTABLE.TabIndex = 65;
			this.cbFLAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFLAME.FormattingEnabled = true;
			this.cbFLAME.Items.AddRange(new object[4] { "Material Issue to Production", "Material Transfer to Service", "Production Return to Store", "Service Return to Store" });
			this.cbFLAME.Location = new System.Drawing.Point(63, 63);
			this.cbFLAME.Name = "cbFLAME";
			this.cbFLAME.Size = new System.Drawing.Size(145, 24);
			this.cbFLAME.TabIndex = 64;
			this.cbSPECIAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSPECIAL.FormattingEnabled = true;
			this.cbSPECIAL.Items.AddRange(new object[4] { "Material Issue to Production", "Material Transfer to Service", "Production Return to Store", "Service Return to Store" });
			this.cbSPECIAL.Location = new System.Drawing.Point(63, 33);
			this.cbSPECIAL.Name = "cbSPECIAL";
			this.cbSPECIAL.Size = new System.Drawing.Size(145, 24);
			this.cbSPECIAL.TabIndex = 63;
			this.cbHEALTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbHEALTH.FormattingEnabled = true;
			this.cbHEALTH.Items.AddRange(new object[4] { "Material Issue to Production", "Material Transfer to Service", "Production Return to Store", "Service Return to Store" });
			this.cbHEALTH.Location = new System.Drawing.Point(63, 3);
			this.cbHEALTH.Name = "cbHEALTH";
			this.cbHEALTH.Size = new System.Drawing.Size(145, 24);
			this.cbHEALTH.TabIndex = 6;
			this.Label64.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label64.AutoSize = true;
			this.Label64.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label64.Location = new System.Drawing.Point(3, 7);
			this.Label64.Name = "Label64";
			this.Label64.Size = new System.Drawing.Size(47, 16);
			this.Label64.TabIndex = 59;
			this.Label64.Text = "Health";
			this.Label65.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label65.AutoSize = true;
			this.Label65.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label65.Location = new System.Drawing.Point(3, 37);
			this.Label65.Name = "Label65";
			this.Label65.Size = new System.Drawing.Size(54, 16);
			this.Label65.TabIndex = 60;
			this.Label65.Text = "Special";
			this.Label66.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label66.AutoSize = true;
			this.Label66.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label66.Location = new System.Drawing.Point(3, 67);
			this.Label66.Name = "Label66";
			this.Label66.Size = new System.Drawing.Size(46, 16);
			this.Label66.TabIndex = 61;
			this.Label66.Text = "Flame";
			this.Label67.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label67.AutoSize = true;
			this.Label67.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label67.Location = new System.Drawing.Point(3, 97);
			this.Label67.Name = "Label67";
			this.Label67.Size = new System.Drawing.Size(47, 16);
			this.Label67.TabIndex = 62;
			this.Label67.Text = "Stable";
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel6.SetColumnSpan(this.TableLayoutPanel2, 2);
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.pbIMAGE4, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.pbIMAGE7, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.pbIMAGE3, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.pbIMAGE6, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.pbIMAGE2, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.pbIMAGE1, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.chkHZC4, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.chkHZC1, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.chkHZC2, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.chkHZC3, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.chkHZC6, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.chkHZC7, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.chkHZC5, 2, 3);
			this.TableLayoutPanel2.Controls.Add(this.chkHZC8, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.pbIMAGE8, 3, 3);
			this.TableLayoutPanel2.Controls.Add(this.pbIMAGE5, 3, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(767, 29);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 4;
			this.TableLayoutPanel6.SetRowSpan(this.TableLayoutPanel2, 7);
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(315, 199);
			this.TableLayoutPanel2.TabIndex = 1;
			this.pbIMAGE4.Image = IMS.My.Resources.Resources.Dangerous;
			this.pbIMAGE4.Location = new System.Drawing.Point(121, 150);
			this.pbIMAGE4.Name = "pbIMAGE4";
			this.pbIMAGE4.Size = new System.Drawing.Size(43, 43);
			this.pbIMAGE4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIMAGE4.TabIndex = 22;
			this.pbIMAGE4.TabStop = false;
			this.pbIMAGE4.Tag = "Dangerous";
			this.pbIMAGE7.Image = IMS.My.Resources.Resources.Oxidising;
			this.pbIMAGE7.Location = new System.Drawing.Point(262, 101);
			this.pbIMAGE7.Name = "pbIMAGE7";
			this.pbIMAGE7.Size = new System.Drawing.Size(43, 43);
			this.pbIMAGE7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIMAGE7.TabIndex = 21;
			this.pbIMAGE7.TabStop = false;
			this.pbIMAGE7.Tag = "Oxidising";
			this.pbIMAGE3.Image = IMS.My.Resources.Resources.Gas_Under_Pressure;
			this.pbIMAGE3.Location = new System.Drawing.Point(121, 101);
			this.pbIMAGE3.Name = "pbIMAGE3";
			this.pbIMAGE3.Size = new System.Drawing.Size(43, 43);
			this.pbIMAGE3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIMAGE3.TabIndex = 20;
			this.pbIMAGE3.TabStop = false;
			this.pbIMAGE3.Tag = "Gas Under Pressure";
			this.pbIMAGE6.Image = IMS.My.Resources.Resources.Explosive;
			this.pbIMAGE6.Location = new System.Drawing.Point(262, 52);
			this.pbIMAGE6.Name = "pbIMAGE6";
			this.pbIMAGE6.Size = new System.Drawing.Size(43, 43);
			this.pbIMAGE6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIMAGE6.TabIndex = 19;
			this.pbIMAGE6.TabStop = false;
			this.pbIMAGE6.Tag = "Explosive";
			this.pbIMAGE2.Image = IMS.My.Resources.Resources.Environmental;
			this.pbIMAGE2.Location = new System.Drawing.Point(121, 52);
			this.pbIMAGE2.Name = "pbIMAGE2";
			this.pbIMAGE2.Size = new System.Drawing.Size(43, 43);
			this.pbIMAGE2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIMAGE2.TabIndex = 18;
			this.pbIMAGE2.TabStop = false;
			this.pbIMAGE2.Tag = "Environmental";
			this.pbIMAGE1.Image = IMS.My.Resources.Resources.Carcinogenic;
			this.pbIMAGE1.Location = new System.Drawing.Point(121, 3);
			this.pbIMAGE1.Name = "pbIMAGE1";
			this.pbIMAGE1.Size = new System.Drawing.Size(43, 43);
			this.pbIMAGE1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIMAGE1.TabIndex = 6;
			this.pbIMAGE1.TabStop = false;
			this.pbIMAGE1.Tag = "Carcinogenic";
			this.chkHZC4.AutoSize = true;
			this.chkHZC4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHZC4.Location = new System.Drawing.Point(3, 150);
			this.chkHZC4.Name = "chkHZC4";
			this.chkHZC4.Size = new System.Drawing.Size(94, 20);
			this.chkHZC4.TabIndex = 16;
			this.chkHZC4.Text = "Dangerous";
			this.chkHZC4.UseVisualStyleBackColor = true;
			this.chkHZC1.AutoSize = true;
			this.chkHZC1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHZC1.Location = new System.Drawing.Point(3, 3);
			this.chkHZC1.Name = "chkHZC1";
			this.chkHZC1.Size = new System.Drawing.Size(106, 20);
			this.chkHZC1.TabIndex = 9;
			this.chkHZC1.Text = "Carcinogenic";
			this.chkHZC1.UseVisualStyleBackColor = true;
			this.chkHZC2.AutoSize = true;
			this.chkHZC2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHZC2.Location = new System.Drawing.Point(3, 52);
			this.chkHZC2.Name = "chkHZC2";
			this.chkHZC2.Size = new System.Drawing.Size(112, 20);
			this.chkHZC2.TabIndex = 10;
			this.chkHZC2.Text = "Environmental";
			this.chkHZC2.UseVisualStyleBackColor = true;
			this.chkHZC3.AutoSize = true;
			this.chkHZC3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHZC3.Location = new System.Drawing.Point(3, 101);
			this.chkHZC3.Name = "chkHZC3";
			this.chkHZC3.Size = new System.Drawing.Size(92, 36);
			this.chkHZC3.TabIndex = 11;
			this.chkHZC3.Text = "Gas Under\r\nPressure";
			this.chkHZC3.UseVisualStyleBackColor = true;
			this.chkHZC6.AutoSize = true;
			this.chkHZC6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHZC6.Location = new System.Drawing.Point(170, 52);
			this.chkHZC6.Name = "chkHZC6";
			this.chkHZC6.Size = new System.Drawing.Size(86, 20);
			this.chkHZC6.TabIndex = 12;
			this.chkHZC6.Text = "Explosive";
			this.chkHZC6.UseVisualStyleBackColor = true;
			this.chkHZC7.AutoSize = true;
			this.chkHZC7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHZC7.Location = new System.Drawing.Point(170, 101);
			this.chkHZC7.Name = "chkHZC7";
			this.chkHZC7.Size = new System.Drawing.Size(82, 20);
			this.chkHZC7.TabIndex = 14;
			this.chkHZC7.Text = "Oxidising";
			this.chkHZC7.UseVisualStyleBackColor = true;
			this.chkHZC5.AutoSize = true;
			this.chkHZC5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHZC5.Location = new System.Drawing.Point(170, 150);
			this.chkHZC5.Name = "chkHZC5";
			this.chkHZC5.Size = new System.Drawing.Size(85, 20);
			this.chkHZC5.TabIndex = 13;
			this.chkHZC5.Text = "Corrosive";
			this.chkHZC5.UseVisualStyleBackColor = true;
			this.chkHZC8.AutoSize = true;
			this.chkHZC8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkHZC8.Location = new System.Drawing.Point(170, 3);
			this.chkHZC8.Name = "chkHZC8";
			this.chkHZC8.Size = new System.Drawing.Size(60, 20);
			this.chkHZC8.TabIndex = 15;
			this.chkHZC8.Text = "Toxic";
			this.chkHZC8.UseVisualStyleBackColor = true;
			this.pbIMAGE8.Image = IMS.My.Resources.Resources.Corrosive;
			this.pbIMAGE8.Location = new System.Drawing.Point(262, 150);
			this.pbIMAGE8.Name = "pbIMAGE8";
			this.pbIMAGE8.Size = new System.Drawing.Size(43, 43);
			this.pbIMAGE8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIMAGE8.TabIndex = 17;
			this.pbIMAGE8.TabStop = false;
			this.pbIMAGE8.Tag = "Corrosive";
			this.pbIMAGE5.Image = IMS.My.Resources.Resources.Toxic;
			this.pbIMAGE5.Location = new System.Drawing.Point(262, 3);
			this.pbIMAGE5.Name = "pbIMAGE5";
			this.pbIMAGE5.Size = new System.Drawing.Size(43, 43);
			this.pbIMAGE5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbIMAGE5.TabIndex = 23;
			this.pbIMAGE5.TabStop = false;
			this.pbIMAGE5.Tag = "Toxic";
			this.Label62.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label62.AutoSize = true;
			this.Label62.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label62.Location = new System.Drawing.Point(767, 5);
			this.Label62.Name = "Label62";
			this.Label62.Size = new System.Drawing.Size(88, 16);
			this.Label62.TabIndex = 92;
			this.Label62.Text = "Hazard Code";
			this.chkPRDDSP.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkPRDDSP.AutoSize = true;
			this.chkPRDDSP.Location = new System.Drawing.Point(150, 117);
			this.chkPRDDSP.Margin = new System.Windows.Forms.Padding(4);
			this.chkPRDDSP.Name = "chkPRDDSP";
			this.chkPRDDSP.Size = new System.Drawing.Size(15, 14);
			this.chkPRDDSP.TabIndex = 30;
			this.chkPRDDSP.UseVisualStyleBackColor = true;
			this.chkPUMPMDL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkPUMPMDL.AutoSize = true;
			this.chkPUMPMDL.Location = new System.Drawing.Point(537, 235);
			this.chkPUMPMDL.Margin = new System.Windows.Forms.Padding(4);
			this.chkPUMPMDL.Name = "chkPUMPMDL";
			this.chkPUMPMDL.Size = new System.Drawing.Size(15, 14);
			this.chkPUMPMDL.TabIndex = 39;
			this.chkPUMPMDL.UseVisualStyleBackColor = true;
			this.chkDSP1ST.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkDSP1ST.AutoSize = true;
			this.chkDSP1ST.Location = new System.Drawing.Point(150, 235);
			this.chkDSP1ST.Margin = new System.Windows.Forms.Padding(4);
			this.chkDSP1ST.Name = "chkDSP1ST";
			this.chkDSP1ST.Size = new System.Drawing.Size(15, 14);
			this.chkDSP1ST.TabIndex = 38;
			this.chkDSP1ST.UseVisualStyleBackColor = true;
			this.Label44.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label44.AutoSize = true;
			this.Label44.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label44.Location = new System.Drawing.Point(3, 234);
			this.Label44.Name = "Label44";
			this.Label44.Size = new System.Drawing.Size(98, 16);
			this.Label44.TabIndex = 59;
			this.Label44.Text = "Dispenser First";
			this.Label39.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label39.AutoSize = true;
			this.Label39.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label39.Location = new System.Drawing.Point(3, 259);
			this.Label39.Name = "Label39";
			this.Label39.Size = new System.Drawing.Size(95, 16);
			this.Label39.TabIndex = 53;
			this.Label39.Text = "Diluent Code 1";
			this.txtDILCD2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtDILCD2.Location = new System.Drawing.Point(149, 288);
			this.txtDILCD2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDILCD2.Name = "txtDILCD2";
			this.txtDILCD2.Size = new System.Drawing.Size(225, 22);
			this.txtDILCD2.TabIndex = 42;
			this.Label40.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label40.AutoSize = true;
			this.Label40.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label40.Location = new System.Drawing.Point(380, 259);
			this.Label40.Name = "Label40";
			this.Label40.Size = new System.Drawing.Size(94, 16);
			this.Label40.TabIndex = 54;
			this.Label40.Text = "Diluent Ratio 1";
			this.Label42.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label42.AutoSize = true;
			this.Label42.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label42.Location = new System.Drawing.Point(3, 291);
			this.Label42.Name = "Label42";
			this.Label42.Size = new System.Drawing.Size(95, 16);
			this.Label42.TabIndex = 57;
			this.Label42.Text = "Diluent Code 2";
			this.Label43.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label43.AutoSize = true;
			this.Label43.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label43.Location = new System.Drawing.Point(380, 291);
			this.Label43.Name = "Label43";
			this.Label43.Size = new System.Drawing.Size(94, 16);
			this.Label43.TabIndex = 58;
			this.Label43.Text = "Diluent Ratio 2";
			this.Label45.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label45.AutoSize = true;
			this.Label45.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label45.Location = new System.Drawing.Point(380, 234);
			this.Label45.Name = "Label45";
			this.Label45.Size = new System.Drawing.Size(91, 16);
			this.Label45.TabIndex = 60;
			this.Label45.Text = "Pump Module";
			this.Label46.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label46.AutoSize = true;
			this.Label46.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label46.Location = new System.Drawing.Point(3, 204);
			this.Label46.Name = "Label46";
			this.Label46.Size = new System.Drawing.Size(86, 16);
			this.Label46.TabIndex = 63;
			this.Label46.Text = "Stutter Factor";
			this.Label47.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label47.AutoSize = true;
			this.Label47.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label47.Location = new System.Drawing.Point(380, 204);
			this.Label47.Name = "Label47";
			this.Label47.Size = new System.Drawing.Size(87, 16);
			this.Label47.TabIndex = 66;
			this.Label47.Text = "Minimum Spit";
			this.Label48.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label48.AutoSize = true;
			this.Label48.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label48.Location = new System.Drawing.Point(3, 172);
			this.Label48.Name = "Label48";
			this.Label48.Size = new System.Drawing.Size(107, 16);
			this.Label48.TabIndex = 69;
			this.Label48.Text = "Flow 2 To Flow 1";
			this.Label49.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label49.AutoSize = true;
			this.Label49.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label49.Location = new System.Drawing.Point(380, 172);
			this.Label49.Name = "Label49";
			this.Label49.Size = new System.Drawing.Size(85, 16);
			this.Label49.TabIndex = 70;
			this.Label49.Text = "Flow 1 To Off";
			this.Label50.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label50.AutoSize = true;
			this.Label50.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label50.Location = new System.Drawing.Point(3, 144);
			this.Label50.Name = "Label50";
			this.Label50.Size = new System.Drawing.Size(94, 16);
			this.Label50.TabIndex = 71;
			this.Label50.Text = "Valve Number";
			this.Label51.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label51.AutoSize = true;
			this.Label51.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label51.Location = new System.Drawing.Point(380, 144);
			this.Label51.Name = "Label51";
			this.Label51.Size = new System.Drawing.Size(120, 16);
			this.Label51.TabIndex = 72;
			this.Label51.Text = "Lab Valve Number";
			this.Label52.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label52.AutoSize = true;
			this.Label52.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label52.Location = new System.Drawing.Point(380, 116);
			this.Label52.Name = "Label52";
			this.Label52.Size = new System.Drawing.Size(87, 16);
			this.Label52.TabIndex = 74;
			this.Label52.Text = "Recirc Group";
			this.Label53.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label53.AutoSize = true;
			this.Label53.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label53.Location = new System.Drawing.Point(3, 116);
			this.Label53.Name = "Label53";
			this.Label53.Size = new System.Drawing.Size(139, 16);
			this.Label53.TabIndex = 75;
			this.Label53.Text = "Product On Dispenser";
			this.Label54.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label54.AutoSize = true;
			this.Label54.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label54.Location = new System.Drawing.Point(3, 88);
			this.Label54.Name = "Label54";
			this.Label54.Size = new System.Drawing.Size(140, 16);
			this.Label54.TabIndex = 77;
			this.Label54.Text = "Material Tolerence (g)";
			this.Label55.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label55.AutoSize = true;
			this.Label55.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label55.Location = new System.Drawing.Point(380, 88);
			this.Label55.Name = "Label55";
			this.Label55.Size = new System.Drawing.Size(144, 16);
			this.Label55.TabIndex = 78;
			this.Label55.Text = "Material Tolerence (%)";
			this.Label56.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label56.AutoSize = true;
			this.Label56.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label56.Location = new System.Drawing.Point(3, 60);
			this.Label56.Name = "Label56";
			this.Label56.Size = new System.Drawing.Size(133, 16);
			this.Label56.TabIndex = 81;
			this.Label56.Text = "Dispenser Low Level";
			this.Label57.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label57.AutoSize = true;
			this.Label57.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label57.Location = new System.Drawing.Point(380, 60);
			this.Label57.Name = "Label57";
			this.Label57.Size = new System.Drawing.Size(107, 16);
			this.Label57.TabIndex = 83;
			this.Label57.Text = "Dispenser Order";
			this.Label58.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label58.AutoSize = true;
			this.Label58.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label58.Location = new System.Drawing.Point(3, 32);
			this.Label58.Name = "Label58";
			this.Label58.Size = new System.Drawing.Size(127, 16);
			this.Label58.TabIndex = 85;
			this.Label58.Text = "Stock On Dispenser";
			this.Label59.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label59.AutoSize = true;
			this.Label59.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label59.Location = new System.Drawing.Point(380, 32);
			this.Label59.Name = "Label59";
			this.Label59.Size = new System.Drawing.Size(150, 16);
			this.Label59.TabIndex = 87;
			this.Label59.Text = "Barrel Graph Max Value";
			this.Label60.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label60.AutoSize = true;
			this.Label60.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label60.Location = new System.Drawing.Point(3, 5);
			this.Label60.Name = "Label60";
			this.Label60.Size = new System.Drawing.Size(117, 16);
			this.Label60.TabIndex = 89;
			this.Label60.Text = "Color Computer ID";
			this.txtCOLORCID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCOLORCID.Location = new System.Drawing.Point(149, 2);
			this.txtCOLORCID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCOLORCID.Name = "txtCOLORCID";
			this.txtCOLORCID.Size = new System.Drawing.Size(225, 22);
			this.txtCOLORCID.TabIndex = 22;
			this.Label61.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label61.AutoSize = true;
			this.Label61.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label61.Location = new System.Drawing.Point(380, 5);
			this.Label61.Name = "Label61";
			this.Label61.Size = new System.Drawing.Size(93, 16);
			this.Label61.TabIndex = 91;
			this.Label61.Text = "Batch Number";
			this.txtBATCH.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtBATCH.Location = new System.Drawing.Point(536, 2);
			this.txtBATCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtBATCH.Name = "txtBATCH";
			this.txtBATCH.Size = new System.Drawing.Size(225, 22);
			this.txtBATCH.TabIndex = 23;
			this.tpOTHER.BackColor = System.Drawing.Color.AliceBlue;
			this.tpOTHER.Controls.Add(this.TableLayoutPanel5);
			this.tpOTHER.Location = new System.Drawing.Point(4, 25);
			this.tpOTHER.Name = "tpOTHER";
			this.tpOTHER.Size = new System.Drawing.Size(1107, 416);
			this.tpOTHER.TabIndex = 2;
			this.tpOTHER.Text = "Other";
			this.TableLayoutPanel5.ColumnCount = 4;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.numNFIELD1, 1, 6);
			this.TableLayoutPanel5.Controls.Add(this.Label32, 2, 6);
			this.TableLayoutPanel5.Controls.Add(this.Label31, 0, 6);
			this.TableLayoutPanel5.Controls.Add(this.chkSRLFG, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.txtCFIELD2, 3, 5);
			this.TableLayoutPanel5.Controls.Add(this.txtSRLNO1, 1, 2);
			this.TableLayoutPanel5.Controls.Add(this.txtSRLNO3, 1, 4);
			this.TableLayoutPanel5.Controls.Add(this.txtCFIELD1, 1, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label22, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label23, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label30, 2, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label24, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label29, 0, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label27, 0, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label26, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.txtSRLNO2, 1, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label25, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.cbOTAXCD, 3, 0);
			this.TableLayoutPanel5.Controls.Add(this.cbITAXCD, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.numNFIELD2, 3, 6);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(4, 4);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 8;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(819, 194);
			this.TableLayoutPanel5.TabIndex = 0;
			this.tpSPART.Controls.Add(this.TableLayoutPanel11);
			this.tpSPART.Controls.Add(this.dgvSPART);
			this.tpSPART.Controls.Add(this.TableLayoutPanel10);
			this.tpSPART.Location = new System.Drawing.Point(4, 25);
			this.tpSPART.Name = "tpSPART";
			this.tpSPART.Size = new System.Drawing.Size(1107, 416);
			this.tpSPART.TabIndex = 3;
			this.tpSPART.Text = "Supplier Part";
			this.tpSPART.UseVisualStyleBackColor = true;
			this.TableLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel11.AutoSize = true;
			this.TableLayoutPanel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel11.ColumnCount = 3;
			this.TableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel11.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel11.Controls.Add(this.btnUpdate, 0, 0);
			this.TableLayoutPanel11.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel11.Location = new System.Drawing.Point(6, 356);
			this.TableLayoutPanel11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel11.Name = "TableLayoutPanel11";
			this.TableLayoutPanel11.RowCount = 1;
			this.TableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel11.Size = new System.Drawing.Size(382, 54);
			this.TableLayoutPanel11.TabIndex = 14;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(259, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 48);
			this.btnCancel.TabIndex = 61;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnUpdate.Image = IMS.My.Resources.Resources.Save;
			this.btnUpdate.Location = new System.Drawing.Point(4, 2);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(120, 50);
			this.btnUpdate.TabIndex = 59;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnREMOVE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(132, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 60;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.dgvSPART.AllowUserToAddRows = false;
			this.dgvSPART.AllowUserToDeleteRows = false;
			this.dgvSPART.AllowUserToResizeRows = false;
			this.dgvSPART.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvSPART.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSPART.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvSPART.Location = new System.Drawing.Point(6, 7);
			this.dgvSPART.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvSPART.MultiSelect = false;
			this.dgvSPART.Name = "dgvSPART";
			this.dgvSPART.ReadOnly = true;
			this.dgvSPART.RowHeadersVisible = false;
			this.dgvSPART.RowHeadersWidth = 10;
			this.dgvSPART.RowTemplate.Height = 24;
			this.dgvSPART.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSPART.Size = new System.Drawing.Size(880, 200);
			this.dgvSPART.TabIndex = 54;
			this.TableLayoutPanel10.AutoSize = true;
			this.TableLayoutPanel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel10.ColumnCount = 2;
			this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel10.Controls.Add(this.txtSPART_SPTNM, 1, 2);
			this.TableLayoutPanel10.Controls.Add(this.Label68, 0, 2);
			this.TableLayoutPanel10.Controls.Add(this.txtSPART_SPTNO, 1, 1);
			this.TableLayoutPanel10.Controls.Add(this.txtSPART_REMRK, 1, 3);
			this.TableLayoutPanel10.Controls.Add(this.lkpSPART_SUPID, 1, 0);
			this.TableLayoutPanel10.Controls.Add(this.Label69, 0, 3);
			this.TableLayoutPanel10.Controls.Add(this.Label70, 0, 1);
			this.TableLayoutPanel10.Controls.Add(this.Label71, 0, 0);
			this.TableLayoutPanel10.Location = new System.Drawing.Point(7, 215);
			this.TableLayoutPanel10.Name = "TableLayoutPanel10";
			this.TableLayoutPanel10.RowCount = 4;
			this.TableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel10.Size = new System.Drawing.Size(816, 136);
			this.TableLayoutPanel10.TabIndex = 1;
			this.txtSPART_SPTNM.Location = new System.Drawing.Point(134, 61);
			this.txtSPART_SPTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSPART_SPTNM.Name = "txtSPART_SPTNM";
			this.txtSPART_SPTNM.Size = new System.Drawing.Size(588, 22);
			this.txtSPART_SPTNM.TabIndex = 57;
			this.Label68.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label68.AutoSize = true;
			this.Label68.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label68.Location = new System.Drawing.Point(3, 64);
			this.Label68.Name = "Label68";
			this.Label68.Size = new System.Drawing.Size(125, 16);
			this.Label68.TabIndex = 13;
			this.Label68.Text = "Supplier Part Name";
			this.txtSPART_SPTNO.Location = new System.Drawing.Point(134, 35);
			this.txtSPART_SPTNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSPART_SPTNO.Name = "txtSPART_SPTNO";
			this.txtSPART_SPTNO.Size = new System.Drawing.Size(588, 22);
			this.txtSPART_SPTNO.TabIndex = 56;
			this.txtSPART_REMRK.Location = new System.Drawing.Point(134, 87);
			this.txtSPART_REMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSPART_REMRK.Multiline = true;
			this.txtSPART_REMRK.Name = "txtSPART_REMRK";
			this.txtSPART_REMRK.Size = new System.Drawing.Size(588, 47);
			this.txtSPART_REMRK.TabIndex = 58;
			this.Label69.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label69.AutoSize = true;
			this.Label69.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label69.Location = new System.Drawing.Point(3, 102);
			this.Label69.Name = "Label69";
			this.Label69.Size = new System.Drawing.Size(56, 16);
			this.Label69.TabIndex = 12;
			this.Label69.Text = "Remark";
			this.Label70.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label70.AutoSize = true;
			this.Label70.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label70.Location = new System.Drawing.Point(3, 38);
			this.Label70.Name = "Label70";
			this.Label70.Size = new System.Drawing.Size(109, 16);
			this.Label70.TabIndex = 12;
			this.Label70.Text = "Supplier Part No.";
			this.Label71.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label71.AutoSize = true;
			this.Label71.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label71.Location = new System.Drawing.Point(3, 8);
			this.Label71.Name = "Label71";
			this.Label71.Size = new System.Drawing.Size(74, 16);
			this.Label71.TabIndex = 12;
			this.Label71.Text = "Supplier ID";
			this.tpCPART.Controls.Add(this.TableLayoutPanel13);
			this.tpCPART.Controls.Add(this.TableLayoutPanel12);
			this.tpCPART.Controls.Add(this.dgvCPART);
			this.tpCPART.Location = new System.Drawing.Point(4, 25);
			this.tpCPART.Name = "tpCPART";
			this.tpCPART.Padding = new System.Windows.Forms.Padding(3);
			this.tpCPART.Size = new System.Drawing.Size(1107, 416);
			this.tpCPART.TabIndex = 4;
			this.tpCPART.Text = "Customer Part";
			this.tpCPART.UseVisualStyleBackColor = true;
			this.TableLayoutPanel13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel13.AutoSize = true;
			this.TableLayoutPanel13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel13.ColumnCount = 3;
			this.TableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel13.Controls.Add(this.btnCancel2, 2, 0);
			this.TableLayoutPanel13.Controls.Add(this.btnUpdate2, 0, 0);
			this.TableLayoutPanel13.Controls.Add(this.btnRemove2, 1, 0);
			this.TableLayoutPanel13.Location = new System.Drawing.Point(6, 358);
			this.TableLayoutPanel13.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel13.Name = "TableLayoutPanel13";
			this.TableLayoutPanel13.RowCount = 1;
			this.TableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel13.Size = new System.Drawing.Size(382, 54);
			this.TableLayoutPanel13.TabIndex = 57;
			this.btnCancel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel2.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel2.Location = new System.Drawing.Point(259, 2);
			this.btnCancel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel2.Name = "btnCancel2";
			this.btnCancel2.Size = new System.Drawing.Size(120, 48);
			this.btnCancel2.TabIndex = 61;
			this.btnCancel2.Text = "Cancel";
			this.btnCancel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel2.UseVisualStyleBackColor = false;
			this.btnUpdate2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpdate2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUpdate2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUpdate2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnUpdate2.Image = IMS.My.Resources.Resources.Save;
			this.btnUpdate2.Location = new System.Drawing.Point(4, 2);
			this.btnUpdate2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnUpdate2.Name = "btnUpdate2";
			this.btnUpdate2.Size = new System.Drawing.Size(120, 50);
			this.btnUpdate2.TabIndex = 59;
			this.btnUpdate2.Text = "Update";
			this.btnUpdate2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUpdate2.UseVisualStyleBackColor = false;
			this.btnRemove2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnRemove2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRemove2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRemove2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRemove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemove2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnRemove2.Image = IMS.My.Resources.Resources.Delete;
			this.btnRemove2.Location = new System.Drawing.Point(132, 2);
			this.btnRemove2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnRemove2.Name = "btnRemove2";
			this.btnRemove2.Size = new System.Drawing.Size(120, 50);
			this.btnRemove2.TabIndex = 60;
			this.btnRemove2.Text = "Remove";
			this.btnRemove2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRemove2.UseVisualStyleBackColor = false;
			this.TableLayoutPanel12.AutoSize = true;
			this.TableLayoutPanel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel12.ColumnCount = 2;
			this.TableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel12.Controls.Add(this.txtCPART_CPTNM, 1, 2);
			this.TableLayoutPanel12.Controls.Add(this.Label74, 0, 2);
			this.TableLayoutPanel12.Controls.Add(this.txtCPART_CPTNO, 1, 1);
			this.TableLayoutPanel12.Controls.Add(this.txtCPART_REMRK, 1, 3);
			this.TableLayoutPanel12.Controls.Add(this.lkpCPART_CUSID, 1, 0);
			this.TableLayoutPanel12.Controls.Add(this.Label75, 0, 3);
			this.TableLayoutPanel12.Controls.Add(this.Label76, 0, 1);
			this.TableLayoutPanel12.Controls.Add(this.Label77, 0, 0);
			this.TableLayoutPanel12.Location = new System.Drawing.Point(6, 212);
			this.TableLayoutPanel12.Name = "TableLayoutPanel12";
			this.TableLayoutPanel12.RowCount = 4;
			this.TableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel12.Size = new System.Drawing.Size(823, 136);
			this.TableLayoutPanel12.TabIndex = 56;
			this.txtCPART_CPTNM.Location = new System.Drawing.Point(141, 61);
			this.txtCPART_CPTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCPART_CPTNM.Name = "txtCPART_CPTNM";
			this.txtCPART_CPTNM.Size = new System.Drawing.Size(591, 22);
			this.txtCPART_CPTNM.TabIndex = 57;
			this.Label74.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label74.AutoSize = true;
			this.Label74.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label74.Location = new System.Drawing.Point(3, 64);
			this.Label74.Name = "Label74";
			this.Label74.Size = new System.Drawing.Size(132, 16);
			this.Label74.TabIndex = 13;
			this.Label74.Text = "Customer Part Name";
			this.txtCPART_CPTNO.Location = new System.Drawing.Point(141, 35);
			this.txtCPART_CPTNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCPART_CPTNO.Name = "txtCPART_CPTNO";
			this.txtCPART_CPTNO.Size = new System.Drawing.Size(591, 22);
			this.txtCPART_CPTNO.TabIndex = 56;
			this.txtCPART_REMRK.Location = new System.Drawing.Point(141, 87);
			this.txtCPART_REMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCPART_REMRK.Multiline = true;
			this.txtCPART_REMRK.Name = "txtCPART_REMRK";
			this.txtCPART_REMRK.Size = new System.Drawing.Size(588, 47);
			this.txtCPART_REMRK.TabIndex = 58;
			this.Label75.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label75.AutoSize = true;
			this.Label75.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label75.Location = new System.Drawing.Point(3, 102);
			this.Label75.Name = "Label75";
			this.Label75.Size = new System.Drawing.Size(56, 16);
			this.Label75.TabIndex = 12;
			this.Label75.Text = "Remark";
			this.Label76.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label76.AutoSize = true;
			this.Label76.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label76.Location = new System.Drawing.Point(3, 38);
			this.Label76.Name = "Label76";
			this.Label76.Size = new System.Drawing.Size(116, 16);
			this.Label76.TabIndex = 12;
			this.Label76.Text = "Customer Part No.";
			this.Label77.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label77.AutoSize = true;
			this.Label77.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label77.Location = new System.Drawing.Point(3, 8);
			this.Label77.Name = "Label77";
			this.Label77.Size = new System.Drawing.Size(81, 16);
			this.Label77.TabIndex = 12;
			this.Label77.Text = "Customer ID";
			this.dgvCPART.AllowUserToAddRows = false;
			this.dgvCPART.AllowUserToDeleteRows = false;
			this.dgvCPART.AllowUserToResizeRows = false;
			this.dgvCPART.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvCPART.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCPART.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvCPART.Location = new System.Drawing.Point(6, 7);
			this.dgvCPART.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvCPART.MultiSelect = false;
			this.dgvCPART.Name = "dgvCPART";
			this.dgvCPART.ReadOnly = true;
			this.dgvCPART.RowHeadersVisible = false;
			this.dgvCPART.RowHeadersWidth = 10;
			this.dgvCPART.RowTemplate.Height = 24;
			this.dgvCPART.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCPART.Size = new System.Drawing.Size(880, 200);
			this.dgvCPART.TabIndex = 55;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel3);
			this.Panel2.Controls.Add(this.dgvMAITM);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Panel2.Size = new System.Drawing.Size(1594, 789);
			this.Panel2.TabIndex = 5;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSearch, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 132);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52f));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(504, 52);
			this.TableLayoutPanel4.TabIndex = 5;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(381, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 48);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(520, 62);
			this.cbITMCDTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCDTO.Name = "cbITMCDTO";
			this.cbITMCDTO.SelectedIndex = -1;
			this.cbITMCDTO.SelectedItem = null;
			this.cbITMCDTO.SelectedValue = null;
			this.cbITMCDTO.Size = new System.Drawing.Size(328, 27);
			this.cbITMCDTO.TabIndex = 6;
			this.cbITMCDTO.TextMultiline = true;
			this.cbITMCDTO.ValueMember = null;
			this.cbITMCDTO.WhereClause = null;
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(85, 62);
			this.cbITMCDFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCDFR.Name = "cbITMCDFR";
			this.cbITMCDFR.SelectedIndex = -1;
			this.cbITMCDFR.SelectedItem = null;
			this.cbITMCDFR.SelectedValue = null;
			this.cbITMCDFR.Size = new System.Drawing.Size(332, 26);
			this.cbITMCDFR.TabIndex = 50;
			this.cbITMCDFR.TextMultiline = true;
			this.cbITMCDFR.ValueMember = null;
			this.cbITMCDFR.WhereClause = null;
			this.numMAXLVL.AllowNegative = false;
			this.numMAXLVL.DataChanged = false;
			this.numMAXLVL.Location = new System.Drawing.Point(175, 297);
			this.numMAXLVL.Name = "numMAXLVL";
			this.numMAXLVL.NumberFormat = "8.0";
			this.numMAXLVL.Size = new System.Drawing.Size(100, 22);
			this.numMAXLVL.TabIndex = 16;
			this.numMAXLVL.Text = "0";
			this.numMAXLVL.ThousandSeperator = false;
			this.numMAXLVL.Value = 0.0;
			this.numMONTH.AllowNegative = false;
			this.numMONTH.DataChanged = false;
			this.numMONTH.Location = new System.Drawing.Point(175, 269);
			this.numMONTH.Name = "numMONTH";
			this.numMONTH.NumberFormat = "8.0";
			this.numMONTH.Size = new System.Drawing.Size(100, 22);
			this.numMONTH.TabIndex = 21;
			this.numMONTH.Text = "0";
			this.numMONTH.ThousandSeperator = false;
			this.numMONTH.Value = 0.0;
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(175, 239);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.0";
			this.numSTDWGT.Size = new System.Drawing.Size(100, 22);
			this.numSTDWGT.TabIndex = 19;
			this.numSTDWGT.Text = "0";
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.cbSUPCD.BlankValue = null;
			this.cbSUPCD.ComboboxWidth = 170;
			this.cbSUPCD.DataTable = null;
			this.cbSUPCD.DisplayMember = null;
			this.cbSUPCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPCD.HasBlankValue = false;
			this.cbSUPCD.Location = new System.Drawing.Point(175, 152);
			this.cbSUPCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbSUPCD.Name = "cbSUPCD";
			this.cbSUPCD.SelectedIndex = -1;
			this.cbSUPCD.SelectedItem = null;
			this.cbSUPCD.SelectedValue = null;
			this.cbSUPCD.Size = new System.Drawing.Size(331, 26);
			this.cbSUPCD.TabIndex = 6;
			this.cbSUPCD.TextMultiline = true;
			this.cbSUPCD.ValueMember = null;
			this.cbSUPCD.WhereClause = null;
			this.numSLPRC.AllowNegative = false;
			this.numSLPRC.DataChanged = false;
			this.numSLPRC.Location = new System.Drawing.Point(679, 211);
			this.numSLPRC.Name = "numSLPRC";
			this.numSLPRC.NumberFormat = "8.2";
			this.numSLPRC.Size = new System.Drawing.Size(100, 22);
			this.numSLPRC.TabIndex = 21;
			this.numSLPRC.Text = "0.00";
			this.numSLPRC.ThousandSeperator = false;
			this.numSLPRC.Value = 0.0;
			this.numPUPRC.AllowNegative = false;
			this.numPUPRC.DataChanged = false;
			this.numPUPRC.Location = new System.Drawing.Point(175, 211);
			this.numPUPRC.Name = "numPUPRC";
			this.numPUPRC.NumberFormat = "8.2";
			this.numPUPRC.Size = new System.Drawing.Size(100, 22);
			this.numPUPRC.TabIndex = 20;
			this.numPUPRC.Text = "0.00";
			this.numPUPRC.ThousandSeperator = false;
			this.numPUPRC.Value = 0.0;
			this.numLTIME.AllowNegative = false;
			this.numLTIME.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numLTIME.DataChanged = false;
			this.numLTIME.Location = new System.Drawing.Point(679, 154);
			this.numLTIME.Name = "numLTIME";
			this.numLTIME.NumberFormat = "8.0";
			this.numLTIME.Size = new System.Drawing.Size(100, 22);
			this.numLTIME.TabIndex = 17;
			this.numLTIME.Text = "0";
			this.numLTIME.ThousandSeperator = false;
			this.numLTIME.Value = 0.0;
			this.numMOQ.AllowNegative = false;
			this.numMOQ.DataChanged = false;
			this.numMOQ.Location = new System.Drawing.Point(679, 183);
			this.numMOQ.Name = "numMOQ";
			this.numMOQ.NumberFormat = "8.0";
			this.numMOQ.Size = new System.Drawing.Size(100, 22);
			this.numMOQ.TabIndex = 19;
			this.numMOQ.Text = "0";
			this.numMOQ.ThousandSeperator = false;
			this.numMOQ.Value = 0.0;
			this.numSPQ.AllowNegative = false;
			this.numSPQ.DataChanged = false;
			this.numSPQ.Location = new System.Drawing.Point(175, 183);
			this.numSPQ.Name = "numSPQ";
			this.numSPQ.NumberFormat = "8.0";
			this.numSPQ.Size = new System.Drawing.Size(100, 22);
			this.numSPQ.TabIndex = 18;
			this.numSPQ.Text = "0";
			this.numSPQ.ThousandSeperator = false;
			this.numSPQ.Value = 0.0;
			this.numSAFETY.AllowNegative = false;
			this.numSAFETY.DataChanged = false;
			this.numSAFETY.Location = new System.Drawing.Point(175, 93);
			this.numSAFETY.Name = "numSAFETY";
			this.numSAFETY.NumberFormat = "8.0";
			this.numSAFETY.Size = new System.Drawing.Size(100, 22);
			this.numSAFETY.TabIndex = 12;
			this.numSAFETY.Text = "0";
			this.numSAFETY.ThousandSeperator = false;
			this.numSAFETY.Value = 0.0;
			this.numVALVE.AllowNegative = false;
			this.numVALVE.DataChanged = false;
			this.numVALVE.Location = new System.Drawing.Point(149, 141);
			this.numVALVE.Name = "numVALVE";
			this.numVALVE.NumberFormat = "8.0";
			this.numVALVE.Size = new System.Drawing.Size(100, 22);
			this.numVALVE.TabIndex = 32;
			this.numVALVE.Text = "0";
			this.numVALVE.ThousandSeperator = false;
			this.numVALVE.Value = 0.0;
			this.numLABVALVE.AllowNegative = false;
			this.numLABVALVE.DataChanged = false;
			this.numLABVALVE.Location = new System.Drawing.Point(536, 141);
			this.numLABVALVE.Name = "numLABVALVE";
			this.numLABVALVE.NumberFormat = "8.0";
			this.numLABVALVE.Size = new System.Drawing.Size(100, 22);
			this.numLABVALVE.TabIndex = 33;
			this.numLABVALVE.Text = "0";
			this.numLABVALVE.ThousandSeperator = false;
			this.numLABVALVE.Value = 0.0;
			this.numDILRT2.AllowNegative = false;
			this.numDILRT2.DataChanged = false;
			this.numDILRT2.Location = new System.Drawing.Point(536, 284);
			this.numDILRT2.Name = "numDILRT2";
			this.numDILRT2.NumberFormat = "15.5";
			this.numDILRT2.Size = new System.Drawing.Size(100, 22);
			this.numDILRT2.TabIndex = 43;
			this.numDILRT2.Text = "0.00000";
			this.numDILRT2.ThousandSeperator = false;
			this.numDILRT2.Value = 0.0;
			this.numDILRT.AllowNegative = false;
			this.numDILRT.DataChanged = false;
			this.numDILRT.Location = new System.Drawing.Point(536, 256);
			this.numDILRT.Name = "numDILRT";
			this.numDILRT.NumberFormat = "15.5";
			this.numDILRT.Size = new System.Drawing.Size(100, 22);
			this.numDILRT.TabIndex = 41;
			this.numDILRT.Text = "0.00000";
			this.numDILRT.ThousandSeperator = false;
			this.numDILRT.Value = 0.0;
			this.numSTUTTER.AllowNegative = false;
			this.numSTUTTER.DataChanged = false;
			this.numSTUTTER.Location = new System.Drawing.Point(149, 197);
			this.numSTUTTER.Name = "numSTUTTER";
			this.numSTUTTER.NumberFormat = "15.5";
			this.numSTUTTER.Size = new System.Drawing.Size(100, 22);
			this.numSTUTTER.TabIndex = 36;
			this.numSTUTTER.Text = "0.00000";
			this.numSTUTTER.ThousandSeperator = false;
			this.numSTUTTER.Value = 0.0;
			this.numMINSPIT.AllowNegative = false;
			this.numMINSPIT.DataChanged = false;
			this.numMINSPIT.Location = new System.Drawing.Point(536, 197);
			this.numMINSPIT.Name = "numMINSPIT";
			this.numMINSPIT.NumberFormat = "15.5";
			this.numMINSPIT.Size = new System.Drawing.Size(100, 22);
			this.numMINSPIT.TabIndex = 37;
			this.numMINSPIT.Text = "0.00000";
			this.numMINSPIT.ThousandSeperator = false;
			this.numMINSPIT.Value = 0.0;
			this.numFLOW2TO1.AllowNegative = false;
			this.numFLOW2TO1.DataChanged = false;
			this.numFLOW2TO1.Location = new System.Drawing.Point(149, 169);
			this.numFLOW2TO1.Name = "numFLOW2TO1";
			this.numFLOW2TO1.NumberFormat = "15.5";
			this.numFLOW2TO1.Size = new System.Drawing.Size(100, 22);
			this.numFLOW2TO1.TabIndex = 34;
			this.numFLOW2TO1.Text = "0.00000";
			this.numFLOW2TO1.ThousandSeperator = false;
			this.numFLOW2TO1.Value = 0.0;
			this.numFLOW1TOOFF.AllowNegative = false;
			this.numFLOW1TOOFF.DataChanged = false;
			this.numFLOW1TOOFF.Location = new System.Drawing.Point(536, 169);
			this.numFLOW1TOOFF.Name = "numFLOW1TOOFF";
			this.numFLOW1TOOFF.NumberFormat = "15.5";
			this.numFLOW1TOOFF.Size = new System.Drawing.Size(100, 22);
			this.numFLOW1TOOFF.TabIndex = 35;
			this.numFLOW1TOOFF.Text = "0.00000";
			this.numFLOW1TOOFF.ThousandSeperator = false;
			this.numFLOW1TOOFF.Value = 0.0;
			this.numRECIRC.AllowNegative = false;
			this.numRECIRC.DataChanged = false;
			this.numRECIRC.Location = new System.Drawing.Point(536, 113);
			this.numRECIRC.Name = "numRECIRC";
			this.numRECIRC.NumberFormat = "15.5";
			this.numRECIRC.Size = new System.Drawing.Size(100, 22);
			this.numRECIRC.TabIndex = 31;
			this.numRECIRC.Text = "0.00000";
			this.numRECIRC.ThousandSeperator = false;
			this.numRECIRC.Value = 0.0;
			this.numTOLERG.AllowNegative = false;
			this.numTOLERG.DataChanged = false;
			this.numTOLERG.Location = new System.Drawing.Point(149, 85);
			this.numTOLERG.Name = "numTOLERG";
			this.numTOLERG.NumberFormat = "15.5";
			this.numTOLERG.Size = new System.Drawing.Size(100, 22);
			this.numTOLERG.TabIndex = 28;
			this.numTOLERG.Text = "0.00000";
			this.numTOLERG.ThousandSeperator = false;
			this.numTOLERG.Value = 0.0;
			this.numTOLERP.AllowNegative = false;
			this.numTOLERP.DataChanged = false;
			this.numTOLERP.Location = new System.Drawing.Point(536, 85);
			this.numTOLERP.Name = "numTOLERP";
			this.numTOLERP.NumberFormat = "8.2";
			this.numTOLERP.Size = new System.Drawing.Size(100, 22);
			this.numTOLERP.TabIndex = 29;
			this.numTOLERP.Text = "0.00";
			this.numTOLERP.ThousandSeperator = false;
			this.numTOLERP.Value = 0.0;
			this.numDSPLOW.AllowNegative = false;
			this.numDSPLOW.DataChanged = false;
			this.numDSPLOW.Location = new System.Drawing.Point(149, 57);
			this.numDSPLOW.Name = "numDSPLOW";
			this.numDSPLOW.NumberFormat = "15.5";
			this.numDSPLOW.Size = new System.Drawing.Size(100, 22);
			this.numDSPLOW.TabIndex = 26;
			this.numDSPLOW.Text = "0.00000";
			this.numDSPLOW.ThousandSeperator = false;
			this.numDSPLOW.Value = 0.0;
			this.numDSPORD.AllowNegative = false;
			this.numDSPORD.DataChanged = false;
			this.numDSPORD.Location = new System.Drawing.Point(536, 57);
			this.numDSPORD.Name = "numDSPORD";
			this.numDSPORD.NumberFormat = "8.0";
			this.numDSPORD.Size = new System.Drawing.Size(100, 22);
			this.numDSPORD.TabIndex = 27;
			this.numDSPORD.Text = "0";
			this.numDSPORD.ThousandSeperator = false;
			this.numDSPORD.Value = 0.0;
			this.numSTKDSP.AllowNegative = false;
			this.numSTKDSP.DataChanged = false;
			this.numSTKDSP.Location = new System.Drawing.Point(149, 29);
			this.numSTKDSP.Name = "numSTKDSP";
			this.numSTKDSP.NumberFormat = "15.5";
			this.numSTKDSP.Size = new System.Drawing.Size(100, 22);
			this.numSTKDSP.TabIndex = 24;
			this.numSTKDSP.Text = "0.00000";
			this.numSTKDSP.ThousandSeperator = false;
			this.numSTKDSP.Value = 0.0;
			this.numBARSZ.AllowNegative = false;
			this.numBARSZ.DataChanged = false;
			this.numBARSZ.Location = new System.Drawing.Point(536, 29);
			this.numBARSZ.Name = "numBARSZ";
			this.numBARSZ.NumberFormat = "8.0";
			this.numBARSZ.Size = new System.Drawing.Size(100, 22);
			this.numBARSZ.TabIndex = 25;
			this.numBARSZ.Text = "0";
			this.numBARSZ.ThousandSeperator = false;
			this.numBARSZ.Value = 0.0;
			this.numNFIELD1.AllowNegative = false;
			this.numNFIELD1.DataChanged = false;
			this.numNFIELD1.Location = new System.Drawing.Point(118, 159);
			this.numNFIELD1.Name = "numNFIELD1";
			this.numNFIELD1.NumberFormat = "15.6";
			this.numNFIELD1.Size = new System.Drawing.Size(100, 22);
			this.numNFIELD1.TabIndex = 52;
			this.numNFIELD1.Text = "0.000000";
			this.numNFIELD1.ThousandSeperator = false;
			this.numNFIELD1.Value = 0.0;
			this.numNFIELD2.AllowNegative = false;
			this.numNFIELD2.DataChanged = false;
			this.numNFIELD2.Location = new System.Drawing.Point(464, 159);
			this.numNFIELD2.Name = "numNFIELD2";
			this.numNFIELD2.NumberFormat = "15.6";
			this.numNFIELD2.Size = new System.Drawing.Size(100, 22);
			this.numNFIELD2.TabIndex = 53;
			this.numNFIELD2.Text = "0.000000";
			this.numNFIELD2.ThousandSeperator = false;
			this.numNFIELD2.Value = 0.0;
			this.lkpSPART_SUPID.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpSPART_SUPID.AllowBlank = true;
			this.lkpSPART_SUPID.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpSPART_SUPID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpSPART_SUPID.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpSPART_SUPID.DescriptionVisible1 = true;
			this.lkpSPART_SUPID.DescriptionVisible2 = false;
			this.lkpSPART_SUPID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpSPART_SUPID.KeyValue = "";
			this.lkpSPART_SUPID.LKPCD = "SUPID";
			this.lkpSPART_SUPID.Location = new System.Drawing.Point(136, 5);
			this.lkpSPART_SUPID.Margin = new System.Windows.Forms.Padding(5);
			this.lkpSPART_SUPID.MaxLength = 0;
			this.lkpSPART_SUPID.Modified = false;
			this.lkpSPART_SUPID.Multiline_ = false;
			this.lkpSPART_SUPID.Name = "lkpSPART_SUPID";
			this.lkpSPART_SUPID.PasswordChar = "\0";
			this.lkpSPART_SUPID.ReadOnly_ = false;
			this.lkpSPART_SUPID.Size = new System.Drawing.Size(675, 23);
			this.lkpSPART_SUPID.TabIndex = 55;
			this.lkpSPART_SUPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpSPART_SUPID.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpSPART_SUPID.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpSPART_SUPID.TextHeight = 23;
			this.lkpSPART_SUPID.TextWidth = 180;
			this.lkpSPART_SUPID.Where1 = null;
			this.lkpCPART_CUSID.ActiveFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCPART_CUSID.AllowBlank = true;
			this.lkpCPART_CUSID.BackColor = System.Drawing.Color.AliceBlue;
			this.lkpCPART_CUSID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.lkpCPART_CUSID.DescriptionForeColor = System.Drawing.SystemColors.ControlText;
			this.lkpCPART_CUSID.DescriptionVisible1 = true;
			this.lkpCPART_CUSID.DescriptionVisible2 = false;
			this.lkpCPART_CUSID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lkpCPART_CUSID.KeyValue = "";
			this.lkpCPART_CUSID.LKPCD = "CUSID";
			this.lkpCPART_CUSID.Location = new System.Drawing.Point(143, 5);
			this.lkpCPART_CUSID.Margin = new System.Windows.Forms.Padding(5);
			this.lkpCPART_CUSID.MaxLength = 0;
			this.lkpCPART_CUSID.Modified = false;
			this.lkpCPART_CUSID.Multiline_ = false;
			this.lkpCPART_CUSID.Name = "lkpCPART_CUSID";
			this.lkpCPART_CUSID.PasswordChar = "\0";
			this.lkpCPART_CUSID.ReadOnly_ = false;
			this.lkpCPART_CUSID.Size = new System.Drawing.Size(675, 23);
			this.lkpCPART_CUSID.TabIndex = 55;
			this.lkpCPART_CUSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.lkpCPART_CUSID.TextBackColor = System.Drawing.SystemColors.Window;
			this.lkpCPART_CUSID.TextForeColor = System.Drawing.SystemColors.WindowText;
			this.lkpCPART_CUSID.TextHeight = 23;
			this.lkpCPART_CUSID.TextWidth = 180;
			this.lkpCPART_CUSID.Where1 = null;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 749);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAEITM";
			base.Tag = "MAEITM";
			this.Text = "Item Master";
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMAITM).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel8.ResumeLayout(false);
			this.TableLayoutPanel8.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.tpGENERAL.ResumeLayout(false);
			this.TableLayoutPanel7.ResumeLayout(false);
			this.TableLayoutPanel7.PerformLayout();
			this.tpDISPENSER.ResumeLayout(false);
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel6.PerformLayout();
			this.TableLayoutPanel9.ResumeLayout(false);
			this.TableLayoutPanel9.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE4).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE7).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE6).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE8).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pbIMAGE5).EndInit();
			this.tpOTHER.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.tpSPART.ResumeLayout(false);
			this.tpSPART.PerformLayout();
			this.TableLayoutPanel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvSPART).EndInit();
			this.TableLayoutPanel10.ResumeLayout(false);
			this.TableLayoutPanel10.PerformLayout();
			this.tpCPART.ResumeLayout(false);
			this.tpCPART.PerformLayout();
			this.TableLayoutPanel13.ResumeLayout(false);
			this.TableLayoutPanel12.ResumeLayout(false);
			this.TableLayoutPanel12.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvCPART).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (ValidateDetailControl())
			{
				spMAEITM();
			}
		}

		private bool spMAEITM()
		{
			string strNextNo = "";
			if (Operators.CompareString(txtITMCD.Text.Trim(), string.Empty, false) != 0)
			{
				goto IL_00d6;
			}
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'MAEITM'"));
			bool spMAEITM;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				if (Common.gfAutoNum("MAEITM", "MAEITM", ref strNextNo))
				{
					txtITMCD.Text = strNextNo;
					goto IL_00d6;
				}
				MessageBox.Show("Item Code cannot blank! Please check document number control. ", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtITMCD.Focus();
				spMAEITM = false;
			}
			else
			{
				MessageBox.Show("Item Code cannot blank!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtITMCD.Focus();
				spMAEITM = false;
			}
			goto IL_0dd8;
			IL_0dd8:
			return spMAEITM;
			IL_00d6:
			strSQL = "EXEC spMAEITM ";
			strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtITMCD.Text) + "', ";
			strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtDESC.Text) + "', ";
			strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtDESC2.Text) + "', ";
			strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtREMRK.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(chkACTFG.Checked)) + ", ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbITMTY.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbITMTY.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbCATCD.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbCATCD.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbGRPCD.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbGRPCD.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbSUBCATCD.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbSUBCATCD.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbBRAND.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbBRAND.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbCLRGP.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbCLRGP.SelectedValue)))), "', ")));
			strSQL = strSQL + Conversions.ToString(numSAFETY.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numMAXLVL.Value) + ", ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbUOM.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbUOM.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbPACKING.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbPACKING.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbLOCCD.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbLOCCD.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbRACKNO.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbRACKNO.SelectedValue)))), "', ")));
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbSUPCD.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(numLTIME.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numSPQ.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numMOQ.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numPUPRC.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numSLPRC.Value) + ", ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkAVESL.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkSLITM.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkITMCTRL.Checked, 1, 0), ", ")));
			strSQL = strSQL + Conversions.ToString(numMONTH.Value) + ", ";
			strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtCOLORCID.Text) + "', ";
			strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtBATCH.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(numSTKDSP.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numBARSZ.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numDSPLOW.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numTOLERP.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numTOLERG.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numDSPORD.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(chkPRDDSP.Checked) + ", ";
			strSQL = strSQL + Conversions.ToString(numRECIRC.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numVALVE.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numLABVALVE.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numFLOW2TO1.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numFLOW1TOOFF.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numSTUTTER.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numMINSPIT.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(chkDSP1ST.Checked) + ", ";
			strSQL = strSQL + Conversions.ToString(chkPUMPMDL.Checked) + ", ";
			strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtDILCD.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(numDILRT.Value) + ", ";
			strSQL = strSQL + "N'" + Common.gfValidSQLStr(txtDILCD2.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(numDILRT2.Value) + ", ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkHZC1.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkHZC2.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkHZC3.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkHZC4.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkHZC5.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkHZC6.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkHZC7.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Interaction.IIf(chkHZC8.Checked, 1, 0), ", ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbHEALTH.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbHEALTH.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbSPECIAL.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbSPECIAL.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbFLAME.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbFLAME.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbSTABLE.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbSTABLE.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbITAXCD.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbITAXCD.SelectedValue)))), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(cbOTAXCD.SelectedIndex == -1, string.Empty, Common.gfValidSQLStr(Conversions.ToString(cbOTAXCD.SelectedValue)))), "', ")));
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(chkSRLFG.Checked)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtSRLNO1.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtSRLNO2.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtSRLNO3.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtCFIELD1.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtCFIELD2.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(numNFIELD1.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numNFIELD2.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numSTDWGT.Value) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "', ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "'";
			try
			{
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
				MessageBox.Show("Record added!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				spMAEITM = false;
				ProjectData.ClearProjectError();
				goto IL_0dd8;
			}
			Header();
			ClearDetails();
			spMAEITM = true;
			goto IL_0dd8;
		}

		private void Header()
		{
			int i = 0;
			dgvMAITM.DataSource = null;
			string strSQL = "EXEC spMAITM '0', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHITMTY.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHCATCD.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHGRPCD.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHBRAND.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMCDFR.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMCDTO.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDESCFR.Text) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(txtDESCTO.Text.Length == 0, "zzzzz", Common.gfValidSQLStr(txtDESCTO.Text))), "' ")));
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvMAITM;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 100;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			dataGridView.Columns[i].ReadOnly = true;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 180;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description") + " 1";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 180;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description") + " 2";
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Category");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Color Group");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 130;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Group");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sub Category");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Brand");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Rack No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "UOM");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "SPQ");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "MOQ");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lead Time");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Purchase Price");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Selling Price");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Avg Sales");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sales Item");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Control By Warehouse");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Expire Month");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Safety");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Max Level");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Input Tax Code");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Output Tax Code");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Serial Flag");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Serial No") + " 1";
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Serial No") + " 2";
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Serial No") + " 3";
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Active Flag");
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Character Field") + " 1";
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Character Field") + " 2";
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Numeric Field") + " 1";
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Numeric Field") + " 2";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Standard Weight");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void RefreshSPART()
		{
			int i = 0;
			dgvSPART.DataSource = null;
			string strSQL = "SELECT WRK_SUPID, WRK_SPTNO, WRK_SPTNM, WRK_REMRK ";
			strSQL += "FROM MASPT_WRK ";
			strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "ORDER BY WRK_SUPID";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvSPART;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 100;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID");
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Part No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Part Name");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 350;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void RefreshCPART()
		{
			int i = 0;
			dgvCPART.DataSource = null;
			string strSQL = "SELECT WRK_CUSID, WRK_CPTNO, WRK_CPTNM, WRK_REMRK ";
			strSQL += "FROM MACPT_WRK ";
			strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "ORDER BY WRK_CUSID";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvCPART;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 120;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID");
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Part No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Part Name");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 330;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void frmMAEITM_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAEITM_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox("HITMTY");
			BindComboBox("ITMTY");
			BindComboHeader();
			intAccessLevel = Common.GetAccessLevel(Conversions.ToString(base.Tag));
			btnNew.Enabled = intAccessLevel != 0;
			btnSave.Enabled = intAccessLevel >= 1;
			btnDelete.Enabled = intAccessLevel >= 3;
			Header();
		}

		private void BindComboBox(string strOption)
		{
			string strSQL1 = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
			if (Operators.CompareString(strOption, "HITMTY", false) == 0)
			{
				strSQL1 += "WHERE MACOD_CTYID = 'ITMTY' ORDER BY MACOD_CODID";
				cbHITMTY.ValueMember = "MACOD_CODID";
				cbHITMTY.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL1, cbHITMTY);
			}
			if (Operators.CompareString(strOption, "HGRPCD", false) == 0)
			{
				strSQL1 += " WHERE MACOD_CTYID = 'GRPCD' ";
				strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHITMTY.SelectedValue), "' ")));
				strSQL1 += "ORDER BY MACOD_CODID";
				cbHGRPCD.ValueMember = "MACOD_CODID";
				cbHGRPCD.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL1, cbHGRPCD);
			}
			if (Operators.CompareString(strOption, "HBRAND", false) == 0)
			{
				strSQL1 += " WHERE MACOD_CTYID = 'BRAND' ";
				strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHGRPCD.SelectedValue), "' ")));
				strSQL1 += "ORDER BY MACOD_CODID";
				cbHBRAND.ValueMember = "MACOD_CODID";
				cbHBRAND.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL1, cbHBRAND);
			}
			if (Operators.CompareString(strOption, "HCATCD", false) == 0)
			{
				strSQL1 += "WHERE MACOD_CTYID = 'CATCD' ";
				strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHBRAND.SelectedValue), "' ")));
				strSQL1 += "ORDER BY MACOD_CODID";
				cbHCATCD.ValueMember = "MACOD_CODID";
				cbHCATCD.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL1, cbHCATCD);
			}
			string strSQL2 = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
			if (Operators.CompareString(strOption, "ITMTY", false) == 0)
			{
				strSQL2 += "WHERE MACOD_CTYID = 'ITMTY' ORDER BY MACOD_CODID";
				cbITMTY.ValueMember = "MACOD_CODID";
				cbITMTY.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL2, cbITMTY);
			}
			if (Operators.CompareString(strOption, "GRPCD", false) == 0)
			{
				strSQL2 += "WHERE MACOD_CTYID = 'GRPCD' ";
				strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbITMTY.SelectedValue), "' ")));
				strSQL2 += "ORDER BY MACOD_CODID";
				cbGRPCD.ValueMember = "MACOD_CODID";
				cbGRPCD.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL2, cbGRPCD);
			}
			if (Operators.CompareString(strOption, "BRAND", false) == 0)
			{
				strSQL2 += "WHERE MACOD_CTYID = 'BRAND' ";
				strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbGRPCD.SelectedValue), "' ")));
				strSQL2 += "ORDER BY MACOD_CODID";
				cbBRAND.ValueMember = "MACOD_CODID";
				cbBRAND.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL2, cbBRAND);
			}
			if (Operators.CompareString(strOption, "CATCD", false) == 0)
			{
				strSQL2 += "WHERE MACOD_CTYID = 'CATCD' ";
				strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbBRAND.SelectedValue), "' ")));
				strSQL2 += "ORDER BY MACOD_CODID";
				cbCATCD.ValueMember = "MACOD_CODID";
				cbCATCD.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL2, cbCATCD);
			}
			if (Operators.CompareString(strOption, "SUBCATCD", false) == 0)
			{
				strSQL2 += "WHERE MACOD_CTYID = 'SUBCATCD' ";
				strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbCATCD.SelectedValue), "' ")));
				strSQL2 += "ORDER BY MACOD_CODID";
				cbSUBCATCD.ValueMember = "MACOD_CODID";
				cbSUBCATCD.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL2, cbSUBCATCD);
			}
			BindLabel();
		}

		private void BindLabel()
		{
			string strUOM = Conversions.ToString(DB.GetColumnValue("LMSYS_BUOM", "LMSYS_TBL", ""));
			lblSTDWGT.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Standard Weight") + " (" + strUOM + ")";
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnPRINT.Enabled = false;
			ClearDetails();
			string strSQL = "DELETE MASPT_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "DELETE MACPT_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "'";
			DB.DBExecute(strSQL);
			RefreshSPART();
			RefreshCPART();
			strMODE = "NEW";
		}

		private void BindGridtoControl()
		{
			txtITMCD.Text = dgvMAITM.CurrentRow.Cells["MAITM_ITMCD"].Value.ToString();
			txtDESC.Text = dgvMAITM.CurrentRow.Cells["MAITM_DESC"].Value.ToString();
			txtDESC2.Text = dgvMAITM.CurrentRow.Cells["MAITM_DESC2"].Value.ToString();
			txtREMRK.Text = dgvMAITM.CurrentRow.Cells["MAITM_REMRK"].Value.ToString();
			cbITMTY.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_ITMTY"].Value.ToString();
			cbGRPCD.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_GRPCD"].Value.ToString();
			cbCATCD.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_CATCD"].Value.ToString();
			cbSUBCATCD.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_SUBCATCD"].Value.ToString();
			cbBRAND.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_BRAND"].Value.ToString();
			cbCLRGP.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_CLRGP"].Value.ToString();
			cbRACKNO.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_RACKNO"].Value.ToString();
			cbLOCCD.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_LOCCD"].Value.ToString();
			cbUOM.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_UOM"].Value.ToString();
			numSPQ.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_SPQ"].Value);
			numMOQ.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_MOQ"].Value);
			numLTIME.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_LTIME"].Value);
			cbSUPCD.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_SUPCD"].Value.ToString();
			numPUPRC.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_PUPRC"].Value);
			numSLPRC.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_SLPRC"].Value);
			chkAVESL.Checked = Conversions.ToBoolean(dgvMAITM.CurrentRow.Cells["MAITM_AVESL"].Value);
			chkSLITM.Checked = Conversions.ToBoolean(dgvMAITM.CurrentRow.Cells["MAITM_SLITM"].Value);
			chkITMCTRL.Checked = Conversions.ToBoolean(dgvMAITM.CurrentRow.Cells["MAITM_ITMCTRL"].Value);
			numMONTH.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_EXPMONTH"].Value);
			numSAFETY.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_SAFETY"].Value.ToString());
			numMAXLVL.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_MAXLVL"].Value.ToString());
			cbITAXCD.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_ITAXCD"].Value.ToString();
			cbOTAXCD.SelectedValue = dgvMAITM.CurrentRow.Cells["MAITM_OTAXCD"].Value.ToString();
			if (Operators.CompareString(dgvMAITM.CurrentRow.Cells["MAITM_SRLFG"].Value.ToString(), "T", false) == 0)
			{
				chkSRLFG.Checked = true;
			}
			else
			{
				chkSRLFG.Checked = false;
			}
			txtSRLNO1.Text = dgvMAITM.CurrentRow.Cells["MAITM_SRLNO1"].Value.ToString();
			txtSRLNO2.Text = dgvMAITM.CurrentRow.Cells["MAITM_SRLNO2"].Value.ToString();
			txtSRLNO3.Text = dgvMAITM.CurrentRow.Cells["MAITM_SRLNO3"].Value.ToString();
			chkACTFG.Checked = Conversions.ToBoolean(dgvMAITM.CurrentRow.Cells["MAITM_ACTFG"].Value.ToString());
			txtCFIELD1.Text = dgvMAITM.CurrentRow.Cells["MAITM_CFIELD1"].Value.ToString();
			txtCFIELD2.Text = dgvMAITM.CurrentRow.Cells["MAITM_CFIELD2"].Value.ToString();
			numNFIELD1.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_NFIELD1"].Value);
			numNFIELD2.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_NFIELD2"].Value);
			numSTDWGT.Value = Conversions.ToDouble(dgvMAITM.CurrentRow.Cells["MAITM_STDWGT"].Value);
			cbPACKING.SelectedValue = RuntimeHelpers.GetObjectValue(dgvMAITM.CurrentRow.Cells["MAITM_PACKING"].Value);
			BindDispenserInfo();
		}

		private void BindDispenserInfo()
		{
			string strSQL = "SELECT * FROM MAITM_TBL WITH (NOLOCK) WHERE MAITM_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'";
			DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count != 0)
			{
				txtCOLORCID.Text = Common.gfValidSQLStr(Conversions.ToString(dt.Rows[0]["MAITM_COLORCID"]));
				txtBATCH.Text = Common.gfValidSQLStr(Conversions.ToString(dt.Rows[0]["MAITM_BATCH"]));
				numSTKDSP.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_STKDSP"]);
				numBARSZ.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_BARSZ"]);
				numDSPLOW.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_DSPLOW"]);
				numDSPORD.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_DSPORD"]);
				numTOLERG.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_TOLERG"]);
				numTOLERP.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_TOLERP"]);
				chkPRDDSP.Checked = Conversions.ToBoolean(Common.gfValidSQLStr(Conversions.ToString(dt.Rows[0]["MAITM_PRDDSP"])));
				numRECIRC.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_RECIRC"]);
				numVALVE.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_VALVE"]);
				numLABVALVE.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_LABVALVE"]);
				numFLOW2TO1.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_FLOW2TO1"]);
				numFLOW1TOOFF.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_FLOW1TOOFF"]);
				numSTUTTER.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_STUTTER"]);
				numMINSPIT.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_MINSPIT"]);
				chkDSP1ST.Checked = Conversions.ToBoolean(Common.gfValidSQLStr(Conversions.ToString(dt.Rows[0]["MAITM_DSP1ST"])));
				chkPUMPMDL.Checked = Conversions.ToBoolean(Common.gfValidSQLStr(Conversions.ToString(dt.Rows[0]["MAITM_PUMPMDL"])));
				txtDILCD.Text = Common.gfValidSQLStr(Conversions.ToString(dt.Rows[0]["MAITM_DILCD"]));
				numDILRT.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_DILRT"]);
				txtDILCD2.Text = Common.gfValidSQLStr(Conversions.ToString(dt.Rows[0]["MAITM_DILCD2"]));
				numDILRT2.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_DILRT2"]);
				chkHZC1.Checked = Conversions.ToBoolean(dt.Rows[0]["MAITM_HZC1"]);
				chkHZC2.Checked = Conversions.ToBoolean(dt.Rows[0]["MAITM_HZC2"]);
				chkHZC3.Checked = Conversions.ToBoolean(dt.Rows[0]["MAITM_HZC3"]);
				chkHZC4.Checked = Conversions.ToBoolean(dt.Rows[0]["MAITM_HZC4"]);
				chkHZC5.Checked = Conversions.ToBoolean(dt.Rows[0]["MAITM_HZC5"]);
				chkHZC6.Checked = Conversions.ToBoolean(dt.Rows[0]["MAITM_HZC6"]);
				chkHZC7.Checked = Conversions.ToBoolean(dt.Rows[0]["MAITM_HZC7"]);
				chkHZC8.Checked = Conversions.ToBoolean(dt.Rows[0]["MAITM_HZC8"]);
				cbHEALTH.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["MAITM_HLTHZ"]);
				cbSPECIAL.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["MAITM_SPCHZ"]);
				cbFLAME.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["MAITM_FLMHZ"]);
				cbSTABLE.SelectedValue = RuntimeHelpers.GetObjectValue(dt.Rows[0]["MAITM_STBHZ"]);
				numSTDWGT.Value = Conversions.ToDouble(dt.Rows[0]["MAITM_STDWGT"]);
			}
		}

		private void dgvMAITM_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			EditRecord();
			BindGridtoControl();
			string strSQL = "DELETE MASPT_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "DELETE MACPT_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "'";
			DB.DBExecute(strSQL);
			strSQL = "INSERT MASPT_WRK (";
			strSQL += "WRK_COMPNM, WRK_SUPID, WRK_SPTNO, WRK_SPTNM, WRK_REMRK) ";
			strSQL = strSQL + "SELECT '" + MyProject.Computer.Name + "', MASPT_SUPID, MASPT_SPTNO, MASPT_SPTNM, MASPT_REMRK ";
			strSQL += "FROM MASPT_TBL ";
			strSQL = strSQL + "WHERE MASPT_ITMCD = '" + txtITMCD.Text + "' ";
			strSQL += "ORDER BY MASPT_SUPID";
			DB.DBExecute(strSQL);
			RefreshSPART();
			strSQL = "INSERT MACPT_WRK (";
			strSQL += "WRK_COMPNM, WRK_CUSID, WRK_CPTNO, WRK_CPTNM, WRK_REMRK) ";
			strSQL = strSQL + "SELECT '" + MyProject.Computer.Name + "', MACPT_CUSID, MACPT_CPTNO, MACPT_CPTNM, MACPT_REMRK ";
			strSQL += "FROM MACPT_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE MACPT_ITMCD = '" + txtITMCD.Text + "' ";
			strSQL += "ORDER BY MACPT_CUSID";
			DB.DBExecute(strSQL);
			RefreshCPART();
		}

		private void EditRecord()
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			txtITMCD.Enabled = false;
			btnPRINT.Enabled = true;
			strMODE = "EDIT";
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			Header();
			ClearDetails();
		}

		private void BindComboHeader()
		{
			cbITMCDFR.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbITMCDFR.ValueMember = "MAITM_ITMCD";
			cbITMCDFR.DisplayMember = "MAITM_ITMCD";
			cbITMCDFR.LoadData();
			cbITMCDTO.DataTable = "MAITM_TBL WITH (NOLOCK)";
			cbITMCDTO.ValueMember = "MAITM_ITMCD";
			cbITMCDTO.DisplayMember = "MAITM_ITMCD";
			cbITMCDTO.LoadData();
			string strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'COLOR' ORDER BY MACOD_CODID";
			cbCLRGP.ValueMember = "MACOD_CODID";
			cbCLRGP.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCLRGP);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'RACKNO' ORDER BY MACOD_CODID";
			cbRACKNO.ValueMember = "MACOD_CODID";
			cbRACKNO.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbRACKNO);
			strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM FROM MALOC_TBL WITH (NOLOCK) ORDER BY MALOC_LOCID";
			cbLOCCD.ValueMember = "MALOC_LOCID";
			cbLOCCD.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCCD);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'UOM' ORDER BY MACOD_CODID";
			cbUOM.ValueMember = "MACOD_CODID";
			cbUOM.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbUOM);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'PACKING' ORDER BY MACOD_CODID";
			cbPACKING.ValueMember = "MACOD_CODID";
			cbPACKING.DisplayMember = "MACOD_CODID";
			Common.RetriveComboItembySQL(strSQL, cbPACKING);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'TAXCD' ORDER BY MACOD_CODID";
			cbITAXCD.ValueMember = "MACOD_CODID";
			cbITAXCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbITAXCD);
			cbOTAXCD.ValueMember = "MACOD_CODID";
			cbOTAXCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbOTAXCD);
			cbSUPCD.DataTable = "MASUP_TBL  WITH (NOLOCK) ";
			cbSUPCD.ValueMember = "MASUP_SUPID";
			cbSUPCD.DisplayMember = "MASUP_SHORT";
			cbSUPCD.LoadData();
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'HEALTH-HZ' ORDER BY MACOD_CODID";
			cbHEALTH.ValueMember = "MACOD_CODID";
			cbHEALTH.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbHEALTH);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'SPECIAL-HZ' ORDER BY MACOD_CODID";
			cbSPECIAL.ValueMember = "MACOD_CODID";
			cbSPECIAL.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbSPECIAL);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'FLAME-HZ' ORDER BY MACOD_CODID";
			cbFLAME.ValueMember = "MACOD_CODID";
			cbFLAME.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbFLAME);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'STABLE-HZ' ORDER BY MACOD_CODID";
			cbSTABLE.ValueMember = "MACOD_CODID";
			cbSTABLE.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbSTABLE);
		}

		private void ClearDetails()
		{
			txtITMCD.Text = string.Empty;
			txtDESC.Text = string.Empty;
			txtDESC2.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			chkACTFG.Checked = true;
			cbITMTY.SelectedIndex = -1;
			cbCATCD.SelectedIndex = -1;
			cbGRPCD.SelectedIndex = -1;
			cbSUBCATCD.SelectedIndex = -1;
			cbBRAND.SelectedIndex = -1;
			cbCLRGP.SelectedIndex = -1;
			cbLOCCD.SelectedIndex = -1;
			cbRACKNO.SelectedIndex = -1;
			numSAFETY.Value = 0.0;
			numMAXLVL.Value = 0.0;
			cbUOM.SelectedIndex = -1;
			cbSUPCD.SelectedIndex = -1;
			cbPACKING.SelectedIndex = -1;
			numLTIME.Value = 0.0;
			numSPQ.Value = 0.0;
			numMOQ.Value = 0.0;
			numPUPRC.Value = 0.0;
			numSLPRC.Value = 0.0;
			chkAVESL.Checked = false;
			chkSLITM.Checked = false;
			chkITMCTRL.Checked = false;
			numSTDWGT.Value = 0.0;
			numMONTH.Value = 0.0;
			txtCOLORCID.Text = string.Empty;
			txtBATCH.Text = string.Empty;
			numSTKDSP.Value = 0.0;
			numBARSZ.Value = 0.0;
			numDSPLOW.Value = 0.0;
			numDSPORD.Value = 0.0;
			numTOLERG.Value = 0.0;
			numTOLERP.Value = 0.0;
			chkPRDDSP.Checked = false;
			numRECIRC.Value = 0.0;
			numVALVE.Value = 0.0;
			numLABVALVE.Value = 0.0;
			numFLOW2TO1.Value = 0.0;
			numFLOW1TOOFF.Value = 0.0;
			numSTUTTER.Value = 0.0;
			numMINSPIT.Value = 0.0;
			chkDSP1ST.Checked = false;
			chkPUMPMDL.Checked = false;
			txtDILCD.Text = string.Empty;
			numDILRT.Value = 0.0;
			txtDILCD2.Text = string.Empty;
			numDILRT2.Value = 0.0;
			chkHZC1.Checked = false;
			chkHZC2.Checked = false;
			chkHZC3.Checked = false;
			chkHZC4.Checked = false;
			chkHZC5.Checked = false;
			chkHZC6.Checked = false;
			chkHZC7.Checked = false;
			chkHZC8.Checked = false;
			cbHEALTH.SelectedIndex = -1;
			cbSPECIAL.SelectedIndex = -1;
			cbFLAME.SelectedIndex = -1;
			cbSTABLE.SelectedIndex = -1;
			cbITAXCD.SelectedIndex = -1;
			cbOTAXCD.SelectedIndex = -1;
			chkSRLFG.Checked = false;
			txtSRLNO1.Text = string.Empty;
			txtSRLNO2.Text = string.Empty;
			txtSRLNO3.Text = string.Empty;
			txtCFIELD1.Text = string.Empty;
			txtCFIELD2.Text = string.Empty;
			numNFIELD1.Value = 0.0;
			numNFIELD2.Value = 0.0;
			txtITMCD.Enabled = true;
			strMODE = string.Empty;
			TabControl1.SelectedIndex = 0;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Header();
		}

		private bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtDESC.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtDESC.Select();
				return false;
			}
			string strSQL = "SELECT MAITM_ITMCD FROM MAITM_TBL WHERE MAITM_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'";
			if (Operators.CompareString(strMODE, "NEW", false) == 0 && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item code already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtITMCD.Select();
				return false;
			}
			if (Operators.CompareString(txtITMCD.Text, string.Empty, false) == 0)
			{
				if (Operators.CompareString(lkpSPART_SUPID.KeyValue, string.Empty, false) == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					lkpSPART_SUPID.Select();
					return false;
				}
				if (Operators.CompareString(txtSPART_SPTNO.Text, string.Empty, false) == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Part No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtSPART_SPTNO.Select();
					return false;
				}
				if (Operators.CompareString(txtSPART_SPTNM.Text, string.Empty, false) == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier Part Name cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtSPART_SPTNM.Select();
					return false;
				}
			}
			return true;
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "ITEM MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMAITM.rpt";
			string strParams = "@PAR=1 ,";
			if (Operators.CompareString(txtITMCD.Text.Trim(), "", false) != 0)
			{
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@ITMTY=", cbITMTY.SelectedValue), ",")));
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@CATCD=", cbCATCD.SelectedValue), ",")));
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@GRPCD=", cbGRPCD.SelectedValue), ",")));
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@BRAND=", cbBRAND.SelectedValue), ",")));
				strParams = strParams + "@ITMCDfr=" + txtITMCD.Text + ",@ITMCDto=" + txtITMCD.Text + ",";
				strParams = string.Concat(strParams, "@DESCFR=" + txtDESC.Text + ",@DESCTO=" + txtDESC.Text);
			}
			else
			{
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@ITMTY=", cbHITMTY.SelectedValue), ",")));
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@CATCD=", cbHCATCD.SelectedValue), ",")));
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@GRPCD=", cbHGRPCD.SelectedValue), ",")));
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject("@BRAND=", cbHBRAND.SelectedValue), ",")));
				strParams = Conversions.ToString(Operators.ConcatenateObject(strParams, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@ITMCDfr=", cbITMCDFR.SelectedValue), ",@ITMCDto="), cbITMCDTO.SelectedValue), ",")));
				strParams = string.Concat(strParams, "@DESCFR=" + txtDESCFR.Text + ",@DESCTO=" + txtDESCTO.Text);
			}
			frmRPT.Params = strParams;
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='ITEM MASTER'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
			strMSG = strMSG + " : " + txtITMCD.Text;
			DialogResult ok = MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
            {
				string strSQL = "";


                try
				{
					strSQL = "DELETE MAITM_TBL WHERE MAITM_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'";
					DB.DBExecute(strSQL);
				}
				catch(Exception)
				{

				}
				try
				{
					strSQL = "DELETE MASPT_TBL WHERE MASPT_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'";
					DB.DBExecute(strSQL);
				}
                catch (Exception)
                {

                }
				try
				{
					strSQL = "DELETE MACPT_TBL WHERE MACPT_ITMCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'";
					DB.DBExecute(strSQL);
				}
				catch (Exception)

				{

				}
                 strSQL = "SELECT MABOM_MDLCD FROM MABOM_TBL WHERE MABOM_MDLCD = '" + Common.gfValidSQLStr(txtITMCD.Text) + "'";
                if (DB.RecordExists(strSQL))
                {
                    MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "BOM data found, cannot delete!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				BindComboHeader();
				Header();
				ClearDetails();
			}
		}

		private void frmMAEITM_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbITMCDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbITMCDFR.SelectedIndex != -1)
			{
				cbITMCDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbITMCDFR.SelectedValue);
			}
		}

		private void ClearSPART()
		{
			lkpSPART_SUPID.KeyValue = string.Empty;
			lkpSPART_SUPID.RefreshDescription();
			txtSPART_SPTNO.Text = string.Empty;
			txtSPART_SPTNM.Text = string.Empty;
			txtSPART_REMRK.Text = string.Empty;
			lkpSPART_SUPID.Focus();
		}

		private void ClearCPART()
		{
			lkpCPART_CUSID.KeyValue = string.Empty;
			lkpCPART_CUSID.RefreshDescription();
			txtCPART_CPTNO.Text = string.Empty;
			txtCPART_CPTNM.Text = string.Empty;
			txtCPART_REMRK.Text = string.Empty;
			lkpCPART_CUSID.Focus();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearSPART();
		}

		private void dgvSPART_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			lkpSPART_SUPID.KeyValue = dgvSPART.CurrentRow.Cells["WRK_SUPID"].Value.ToString();
			lkpSPART_SUPID.RefreshDescription();
			txtSPART_SPTNO.Text = dgvSPART.CurrentRow.Cells["WRK_SPTNO"].Value.ToString();
			txtSPART_SPTNM.Text = dgvSPART.CurrentRow.Cells["WRK_SPTNM"].Value.ToString();
			txtSPART_REMRK.Text = dgvSPART.CurrentRow.Cells["WRK_REMRK"].Value.ToString();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM MASPT_WRK ";
			strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND WRK_SUPID = '" + lkpSPART_SUPID.KeyValue + "'";
			if (DB.RecordExists(strSQL))
			{
				strSQL = "UPDATE MASPT_WRK ";
				strSQL = strSQL + "SET WRK_SPTNO = '" + txtSPART_SPTNO.Text + "', ";
				strSQL = strSQL + "WRK_SPTNM = N'" + txtSPART_SPTNM.Text + "', ";
				strSQL = strSQL + "WRK_REMRK = N'" + txtSPART_REMRK.Text + "' ";
				strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
				strSQL = strSQL + "AND WRK_SUPID = '" + lkpSPART_SUPID.KeyValue + "'";
				DB.DBExecute(strSQL);
			}
			else
			{
				strSQL = "INSERT MASPT_WRK (";
				strSQL += "WRK_COMPNM, WRK_SUPID, WRK_SPTNO, WRK_SPTNM, WRK_REMRK) ";
				strSQL += "VALUES (";
				strSQL = strSQL + "'" + MyProject.Computer.Name + "', '" + lkpSPART_SUPID.KeyValue + "', ";
				strSQL = strSQL + "'" + txtSPART_SPTNO.Text + "', N'" + txtSPART_SPTNM.Text + "', ";
				strSQL = strSQL + "N'" + txtSPART_REMRK.Text + "')";
				DB.DBExecute(strSQL);
			}
			RefreshSPART();
			ClearSPART();
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM MASPT_WRK ";
			strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND WRK_SUPID = '" + lkpSPART_SUPID.KeyValue + "'";
			if (DB.RecordExists(strSQL))
			{
				strSQL = "DELETE MASPT_WRK ";
				strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
				strSQL = strSQL + "AND WRK_SUPID = '" + lkpSPART_SUPID.KeyValue + "'";
				DB.DBExecute(strSQL);
				RefreshSPART();
				ClearSPART();
			}
			else
			{
				MessageBox.Show("Record not exists!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void dgvCPART_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			lkpCPART_CUSID.KeyValue = dgvCPART.CurrentRow.Cells["WRK_CUSID"].Value.ToString();
			lkpCPART_CUSID.RefreshDescription();
			txtCPART_CPTNO.Text = dgvCPART.CurrentRow.Cells["WRK_CPTNO"].Value.ToString();
			txtCPART_CPTNM.Text = dgvCPART.CurrentRow.Cells["WRK_CPTNM"].Value.ToString();
			txtCPART_REMRK.Text = dgvCPART.CurrentRow.Cells["WRK_REMRK"].Value.ToString();
		}

		private void btnUpdate2_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM MACPT_WRK ";
			strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND WRK_CUSID = '" + lkpCPART_CUSID.KeyValue + "'";
			if (DB.RecordExists(strSQL))
			{
				strSQL = "UPDATE MACPT_WRK ";
				strSQL = strSQL + "SET WRK_CPTNO = '" + txtCPART_CPTNO.Text + "', ";
				strSQL = strSQL + "WRK_CPTNM = N'" + txtCPART_CPTNM.Text + "', ";
				strSQL = strSQL + "WRK_REMRK = N'" + txtCPART_REMRK.Text + "' ";
				strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
				strSQL = strSQL + "AND WRK_CUSID = '" + lkpCPART_CUSID.KeyValue + "'";
				DB.DBExecute(strSQL);
			}
			else
			{
				strSQL = "INSERT MACPT_WRK (";
				strSQL += "WRK_COMPNM, WRK_CUSID, WRK_CPTNO, WRK_CPTNM, WRK_REMRK) ";
				strSQL += "VALUES (";
				strSQL = strSQL + "'" + MyProject.Computer.Name + "', '" + lkpCPART_CUSID.KeyValue + "', ";
				strSQL = strSQL + "'" + txtCPART_CPTNO.Text + "', N'" + txtCPART_CPTNM.Text + "', ";
				strSQL = strSQL + "N'" + txtCPART_REMRK.Text + "')";
				DB.DBExecute(strSQL);
			}
			RefreshCPART();
			ClearCPART();
		}

		private void btnRemove2_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM MACPT_WRK ";
			strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL = strSQL + "AND WRK_CUSID = '" + lkpCPART_CUSID.KeyValue + "'";
			if (DB.RecordExists(strSQL))
			{
				strSQL = "DELETE MACPT_WRK ";
				strSQL = strSQL + "WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "' ";
				strSQL = strSQL + "AND WRK_CUSID = '" + lkpCPART_CUSID.KeyValue + "'";
				DB.DBExecute(strSQL);
				RefreshCPART();
				ClearCPART();
			}
			else
			{
				MessageBox.Show("Record not exists!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnCancel2_Click(object sender, EventArgs e)
		{
			ClearCPART();
		}

		private void cbHITMTY_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbHGRPCD.SelectedIndex = -1;
			cbHBRAND.SelectedIndex = -1;
			cbHCATCD.SelectedIndex = -1;
			BindComboBox("HGRPCD");
		}

		private void cbHGRPCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbHBRAND.SelectedIndex = -1;
			cbHCATCD.SelectedIndex = -1;
			BindComboBox("HBRAND");
		}

		private void cbHBRAND_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbHCATCD.SelectedIndex = -1;
			BindComboBox("HCATCD");
		}

		private void cbITMTY_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbGRPCD.SelectedIndex = -1;
			cbBRAND.SelectedIndex = -1;
			cbCATCD.SelectedIndex = -1;
			cbSUBCATCD.SelectedIndex = -1;
			BindComboBox("GRPCD");
		}

		private void cbGRPCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbBRAND.SelectedIndex = -1;
			cbCATCD.SelectedIndex = -1;
			cbSUBCATCD.SelectedIndex = -1;
			BindComboBox("BRAND");
		}

		private void cbBRAND_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbCATCD.SelectedIndex = -1;
			cbSUBCATCD.SelectedIndex = -1;
			BindComboBox("CATCD");
		}

		private void cbCATCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbSUBCATCD.SelectedIndex = -1;
			BindComboBox("SUBCATCD");
		}
	}
}
