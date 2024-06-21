using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class frmMAEBOM : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMABOM_Header")]
		private DataGridView _dgvMABOM_Header;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private Button _btnPRINTFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCANCEL")]
		private Button _btnCANCEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMABOM_Details")]
		private DataGridView _dgvMABOM_Details;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCOPY")]
		private Button _btnCOPY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE2")]
		private Button _btnSAVE2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBACK2")]
		private Button _btnBACK2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbMDLCDFR")]
		private ComboboxControl _cbMDLCDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE1")]
		private Button _btnSAVE1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCANCEL1")]
		private Button _btnCANCEL1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbOTH05")]
		private ComboBox _cbOTH05;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbOTH04")]
		private ComboBox _cbOTH04;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbOTH03")]
		private ComboBox _cbOTH03;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbOTH02")]
		private ComboBox _cbOTH02;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbOTH01")]
		private ComboBox _cbOTH01;

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

		private int intAccessLevel;

		internal virtual DataGridView dgvMABOM_Header
		{
			[CompilerGenerated]
			get
			{
				return _dgvMABOM_Header;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMABOM_Header_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMABOM_Header;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMABOM_Header = value;
				dataGridView = _dgvMABOM_Header;
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

		[field: AccessedThroughProperty("lblMDLCDFR")]
		internal virtual Label lblMDLCDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblMDLCDTO")]
		internal virtual Label lblMDLCDTO
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

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
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
				EventHandler value2 = btnSAVE_Click;
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numMDLQT")]
		internal virtual NumControl numMDLQT
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

		[field: AccessedThroughProperty("numREVNO")]
		internal virtual NumControl numREVNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("lblREMRK")]
		internal virtual Label lblREMRK
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

		[field: AccessedThroughProperty("cboMRPFG")]
		internal virtual ComboBox cboMRPFG
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

		[field: AccessedThroughProperty("numPARQT")]
		internal virtual NumControl numPARQT
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

		[field: AccessedThroughProperty("lblQTY")]
		internal virtual Label lblQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDESC")]
		internal virtual Label lblDESC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblITMCD")]
		internal virtual Label lblITMCD
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

		internal virtual DataGridView dgvMABOM_Details
		{
			[CompilerGenerated]
			get
			{
				return _dgvMABOM_Details;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMABOM_Details_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMABOM_Details;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMABOM_Details = value;
				dataGridView = _dgvMABOM_Details;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
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

		[field: AccessedThroughProperty("chkACTFG")]
		internal virtual CheckBox chkACTFG
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

		internal virtual Button btnCOPY
		{
			[CompilerGenerated]
			get
			{
				return _btnCOPY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCOPY_Click;
				Button button = _btnCOPY;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCOPY = value;
				button = _btnCOPY;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Panel3")]
		internal virtual Panel Panel3
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
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

		[field: AccessedThroughProperty("numNREVNO")]
		internal virtual NumControl numNREVNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSAVE2
		{
			[CompilerGenerated]
			get
			{
				return _btnSAVE2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSAVE2_Click;
				Button button = _btnSAVE2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSAVE2 = value;
				button = _btnSAVE2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnBACK2
		{
			[CompilerGenerated]
			get
			{
				return _btnBACK2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnBACK2_Click;
				Button button = _btnBACK2;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnBACK2 = value;
				button = _btnBACK2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtNMDLCD")]
		internal virtual TextBox txtNMDLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbMDLCD")]
		internal virtual ComboboxControl cbMDLCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbBOMPN")]
		internal virtual ComboboxControl cbBOMPN
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbMDLCDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbMDLCDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbMDLCDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbMDLCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbMDLCDFR = value;
				comboboxControl = _cbMDLCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbMDLCDTO")]
		internal virtual ComboboxControl cbMDLCDTO
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

		[field: AccessedThroughProperty("TabPage1")]
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabPage2")]
		internal virtual TabPage TabPage2
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

		[field: AccessedThroughProperty("lblOTH05")]
		internal virtual Label lblOTH05
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTH02")]
		internal virtual Label lblOTH02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTH01")]
		internal virtual Label lblOTH01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTH03")]
		internal virtual Label lblOTH03
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTH04")]
		internal virtual Label lblOTH04
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

		internal virtual Button btnSAVE1
		{
			[CompilerGenerated]
			get
			{
				return _btnSAVE1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSAVE1_Click;
				Button button = _btnSAVE1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSAVE1 = value;
				button = _btnSAVE1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnCANCEL1
		{
			[CompilerGenerated]
			get
			{
				return _btnCANCEL1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnCANCEL1_Click;
				Button button = _btnCANCEL1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnCANCEL1 = value;
				button = _btnCANCEL1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual ComboBox cbOTH05
		{
			[CompilerGenerated]
			get
			{
				return _cbOTH05;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbOTH05_SelectedIndexChanged;
				ComboBox comboBox = _cbOTH05;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbOTH05 = value;
				comboBox = _cbOTH05;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbOTH04
		{
			[CompilerGenerated]
			get
			{
				return _cbOTH04;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbOTH04_SelectedIndexChanged;
				ComboBox comboBox = _cbOTH04;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbOTH04 = value;
				comboBox = _cbOTH04;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbOTH03
		{
			[CompilerGenerated]
			get
			{
				return _cbOTH03;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbOTH03_SelectedIndexChanged;
				ComboBox comboBox = _cbOTH03;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbOTH03 = value;
				comboBox = _cbOTH03;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbOTH02
		{
			[CompilerGenerated]
			get
			{
				return _cbOTH02;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbOTH02_SelectedIndexChanged;
				ComboBox comboBox = _cbOTH02;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbOTH02 = value;
				comboBox = _cbOTH02;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbOTH01
		{
			[CompilerGenerated]
			get
			{
				return _cbOTH01;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbOTH01_SelectedIndexChanged;
				ComboBox comboBox = _cbOTH01;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbOTH01 = value;
				comboBox = _cbOTH01;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbOTHCD01")]
		internal virtual ComboBox cbOTHCD01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTHCD01")]
		internal virtual Label lblOTHCD01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTHCD02")]
		internal virtual Label lblOTHCD02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTHCD03")]
		internal virtual Label lblOTHCD03
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTHCD04")]
		internal virtual Label lblOTHCD04
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblOTHCD05")]
		internal virtual Label lblOTHCD05
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbOTHCD02")]
		internal virtual ComboBox cbOTHCD02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbOTHCD03")]
		internal virtual ComboBox cbOTHCD03
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbOTHCD04")]
		internal virtual ComboBox cbOTHCD04
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbOTHCD05")]
		internal virtual ComboBox cbOTHCD05
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

		[field: AccessedThroughProperty("txtMDLDESC")]
		internal virtual TextBox txtMDLDESC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabPage3")]
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("tvBOM")]
		internal virtual TreeView tvBOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TabPage4")]
		internal virtual TabPage TabPage4
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

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSTAGE")]
		internal virtual ComboBox cbSTAGE
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

		[field: AccessedThroughProperty("numSEQNO")]
		internal virtual NumControl numSEQNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAEBOM()
		{
			base.FormClosing += frmMAEBOM_FormClosing;
			base.Load += frmMAEBOM_Load;
			base.KeyDown += frmMAEBOM_KeyDown;
			InitializeComponent();
			G.frmMAEBOM = this;

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
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.cbMDLCDTO = new IMS.ComboboxControl();
			this.cbMDLCDFR = new IMS.ComboboxControl();
			this.lblMDLCDFR = new System.Windows.Forms.Label();
			this.lblMDLCDTO = new System.Windows.Forms.Label();
			this.dgvMABOM_Header = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtMDLDESC = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cbBOMPN = new IMS.ComboboxControl();
			this.cbMDLCD = new IMS.ComboboxControl();
			this.cboMRPFG = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.numPARQT = new IMS.NumControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblQTY = new System.Windows.Forms.Label();
			this.lblMDLCD = new System.Windows.Forms.Label();
			this.txtDESC = new System.Windows.Forms.TextBox();
			this.lblDESC = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblITMCD = new System.Windows.Forms.Label();
			this.lblREVNO = new System.Windows.Forms.Label();
			this.numREVNO = new IMS.NumControl();
			this.numMDLQT = new IMS.NumControl();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.chkACTFG = new System.Windows.Forms.CheckBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.dgvMABOM_Details = new System.Windows.Forms.DataGridView();
			this.cbSTAGE = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.numSEQNO = new IMS.NumControl();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.cbOTHCD01 = new System.Windows.Forms.ComboBox();
			this.lblOTHCD01 = new System.Windows.Forms.Label();
			this.cbOTH05 = new System.Windows.Forms.ComboBox();
			this.cbOTH04 = new System.Windows.Forms.ComboBox();
			this.cbOTH03 = new System.Windows.Forms.ComboBox();
			this.cbOTH02 = new System.Windows.Forms.ComboBox();
			this.cbOTH01 = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSAVE1 = new System.Windows.Forms.Button();
			this.btnCANCEL1 = new System.Windows.Forms.Button();
			this.lblOTH05 = new System.Windows.Forms.Label();
			this.lblOTH02 = new System.Windows.Forms.Label();
			this.lblOTH01 = new System.Windows.Forms.Label();
			this.lblOTH03 = new System.Windows.Forms.Label();
			this.lblOTH04 = new System.Windows.Forms.Label();
			this.lblOTHCD02 = new System.Windows.Forms.Label();
			this.lblOTHCD03 = new System.Windows.Forms.Label();
			this.lblOTHCD04 = new System.Windows.Forms.Label();
			this.lblOTHCD05 = new System.Windows.Forms.Label();
			this.cbOTHCD02 = new System.Windows.Forms.ComboBox();
			this.cbOTHCD03 = new System.Windows.Forms.ComboBox();
			this.cbOTHCD04 = new System.Windows.Forms.ComboBox();
			this.cbOTHCD05 = new System.Windows.Forms.ComboBox();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.tvBOM = new System.Windows.Forms.TreeView();
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.TableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel2 = new System.Windows.Forms.Button();
			this.btnUpdate2 = new System.Windows.Forms.Button();
			this.btnRemove2 = new System.Windows.Forms.Button();
			this.TableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
			this.txtCPART_CPTNM = new System.Windows.Forms.TextBox();
			this.Label74 = new System.Windows.Forms.Label();
			this.txtCPART_CPTNO = new System.Windows.Forms.TextBox();
			this.txtCPART_REMRK = new System.Windows.Forms.TextBox();
			this.lkpCPART_CUSID = new IMS.LookupControl();
			this.Label75 = new System.Windows.Forms.Label();
			this.Label76 = new System.Windows.Forms.Label();
			this.Label77 = new System.Windows.Forms.Label();
			this.dgvCPART = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnCOPY = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.txtNMDLCD = new System.Windows.Forms.TextBox();
			this.btnSAVE2 = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.numNREVNO = new IMS.NumControl();
			this.btnBACK2 = new System.Windows.Forms.Button();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.TableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMABOM_Header).BeginInit();
			this.Panel1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMABOM_Details).BeginInit();
			this.TableLayoutPanel5.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.TableLayoutPanel8.SuspendLayout();
			this.TableLayoutPanel9.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.TabPage4.SuspendLayout();
			this.TableLayoutPanel13.SuspendLayout();
			this.TableLayoutPanel12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvCPART).BeginInit();
			this.TableLayoutPanel6.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.TableLayoutPanel7.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 4;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.cbMDLCDTO, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.cbMDLCDFR, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.lblMDLCDFR, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.lblMDLCDTO, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(796, 37);
			this.TableLayoutPanel4.TabIndex = 1;
			this.cbMDLCDTO.BlankValue = null;
			this.cbMDLCDTO.ComboboxWidth = 170;
			this.cbMDLCDTO.DataTable = null;
			this.cbMDLCDTO.DisplayMember = null;
			this.cbMDLCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCDTO.HasBlankValue = true;
			this.cbMDLCDTO.Location = new System.Drawing.Point(465, 5);
			this.cbMDLCDTO.Margin = new System.Windows.Forms.Padding(5);
			this.cbMDLCDTO.Name = "cbMDLCDTO";
			this.cbMDLCDTO.SelectedIndex = -1;
			this.cbMDLCDTO.SelectedItem = null;
			this.cbMDLCDTO.SelectedValue = null;
			this.cbMDLCDTO.Size = new System.Drawing.Size(326, 27);
			this.cbMDLCDTO.TabIndex = 10;
			this.cbMDLCDTO.TextMultiline = true;
			this.cbMDLCDTO.ValueMember = null;
			this.cbMDLCDTO.WhereClause = null;
			this.cbMDLCDFR.BlankValue = null;
			this.cbMDLCDFR.ComboboxWidth = 170;
			this.cbMDLCDFR.DataTable = null;
			this.cbMDLCDFR.DisplayMember = null;
			this.cbMDLCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCDFR.HasBlankValue = true;
			this.cbMDLCDFR.Location = new System.Drawing.Point(93, 2);
			this.cbMDLCDFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbMDLCDFR.Name = "cbMDLCDFR";
			this.cbMDLCDFR.SelectedIndex = -1;
			this.cbMDLCDFR.SelectedItem = null;
			this.cbMDLCDFR.SelectedValue = null;
			this.cbMDLCDFR.Size = new System.Drawing.Size(332, 27);
			this.cbMDLCDFR.TabIndex = 9;
			this.cbMDLCDFR.TextMultiline = true;
			this.cbMDLCDFR.ValueMember = null;
			this.cbMDLCDFR.WhereClause = null;
			this.lblMDLCDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMDLCDFR.AutoSize = true;
			this.lblMDLCDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMDLCDFR.Location = new System.Drawing.Point(4, 10);
			this.lblMDLCDFR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMDLCDFR.Name = "lblMDLCDFR";
			this.lblMDLCDFR.Size = new System.Drawing.Size(83, 17);
			this.lblMDLCDFR.TabIndex = 2;
			this.lblMDLCDFR.Text = "Model Code";
			this.lblMDLCDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMDLCDTO.AutoSize = true;
			this.lblMDLCDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMDLCDTO.Location = new System.Drawing.Point(431, 10);
			this.lblMDLCDTO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMDLCDTO.Name = "lblMDLCDTO";
			this.lblMDLCDTO.Size = new System.Drawing.Size(25, 17);
			this.lblMDLCDTO.TabIndex = 4;
			this.lblMDLCDTO.Text = "To";
			this.dgvMABOM_Header.AllowUserToAddRows = false;
			this.dgvMABOM_Header.AllowUserToDeleteRows = false;
			this.dgvMABOM_Header.AllowUserToResizeRows = false;
			this.dgvMABOM_Header.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMABOM_Header.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMABOM_Header.Location = new System.Drawing.Point(5, 118);
			this.dgvMABOM_Header.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvMABOM_Header.MultiSelect = false;
			this.dgvMABOM_Header.Name = "dgvMABOM_Header";
			this.dgvMABOM_Header.ReadOnly = true;
			this.dgvMABOM_Header.RowHeadersVisible = false;
			this.dgvMABOM_Header.RowHeadersWidth = 51;
			this.dgvMABOM_Header.RowTemplate.Height = 24;
			this.dgvMABOM_Header.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMABOM_Header.Size = new System.Drawing.Size(1320, 503);
			this.dgvMABOM_Header.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TabControl1);
			this.Panel1.Controls.Add(this.TableLayoutPanel6);
			this.Panel1.Controls.Add(this.TableLayoutPanel2);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1346, 627);
			this.Panel1.TabIndex = 5;
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Controls.Add(this.TabPage2);
			this.TabControl1.Controls.Add(this.TabPage3);
			this.TabControl1.Controls.Add(this.TabPage4);
			this.TabControl1.Location = new System.Drawing.Point(5, 60);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(1330, 567);
			this.TabControl1.TabIndex = 15;
			this.TabPage1.BackColor = System.Drawing.Color.AliceBlue;
			this.TabPage1.Controls.Add(this.TableLayoutPanel1);
			this.TabPage1.Controls.Add(this.TableLayoutPanel5);
			this.TabPage1.Location = new System.Drawing.Point(4, 26);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage1.Size = new System.Drawing.Size(1322, 537);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Main";
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 8;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.txtMDLDESC, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbBOMPN, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.cbMDLCD, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.cboMRPFG, 7, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 7, 6);
			this.TableLayoutPanel1.Controls.Add(this.numPARQT, 6, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblQTY, 6, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblMDLCD, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDESC, 3, 7);
			this.TableLayoutPanel1.Controls.Add(this.lblDESC, 3, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.lblITMCD, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.lblREVNO, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.numREVNO, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.numMDLQT, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.chkACTFG, 6, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 5, 6);
			this.TableLayoutPanel1.Controls.Add(this.dgvMABOM_Details, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.cbSTAGE, 5, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 4, 6);
			this.TableLayoutPanel1.Controls.Add(this.numSEQNO, 4, 7);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(4, 6);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 8;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1170, 440);
			this.TableLayoutPanel1.TabIndex = 0;
			this.TableLayoutPanel1.SetColumnSpan(this.txtMDLDESC, 3);
			this.txtMDLDESC.Location = new System.Drawing.Point(114, 61);
			this.txtMDLDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMDLDESC.Name = "txtMDLDESC";
			this.txtMDLDESC.Size = new System.Drawing.Size(411, 23);
			this.txtMDLDESC.TabIndex = 3;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 64);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(79, 17);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Description";
			this.cbBOMPN.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbBOMPN, 3);
			this.cbBOMPN.ComboboxWidth = 170;
			this.cbBOMPN.DataTable = null;
			this.cbBOMPN.DisplayMember = null;
			this.cbBOMPN.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBOMPN.HasBlankValue = true;
			this.cbBOMPN.Location = new System.Drawing.Point(2, 406);
			this.cbBOMPN.Margin = new System.Windows.Forms.Padding(2);
			this.cbBOMPN.Name = "cbBOMPN";
			this.cbBOMPN.SelectedIndex = -1;
			this.cbBOMPN.SelectedItem = null;
			this.cbBOMPN.SelectedValue = null;
			this.cbBOMPN.Size = new System.Drawing.Size(328, 32);
			this.cbBOMPN.TabIndex = 15;
			this.cbBOMPN.TextMultiline = true;
			this.cbBOMPN.ValueMember = null;
			this.cbBOMPN.WhereClause = null;
			this.cbMDLCD.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbMDLCD, 3);
			this.cbMDLCD.ComboboxWidth = 170;
			this.cbMDLCD.DataTable = null;
			this.cbMDLCD.DisplayMember = null;
			this.cbMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCD.HasBlankValue = true;
			this.cbMDLCD.Location = new System.Drawing.Point(113, 2);
			this.cbMDLCD.Margin = new System.Windows.Forms.Padding(2);
			this.cbMDLCD.Name = "cbMDLCD";
			this.cbMDLCD.SelectedIndex = -1;
			this.cbMDLCD.SelectedItem = null;
			this.cbMDLCD.SelectedValue = null;
			this.cbMDLCD.Size = new System.Drawing.Size(391, 28);
			this.cbMDLCD.TabIndex = 1;
			this.cbMDLCD.TextMultiline = true;
			this.cbMDLCD.ValueMember = null;
			this.cbMDLCD.WhereClause = null;
			this.cboMRPFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cboMRPFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboMRPFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cboMRPFG.FormattingEnabled = true;
			this.cboMRPFG.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cboMRPFG.Location = new System.Drawing.Point(1045, 409);
			this.cboMRPFG.Margin = new System.Windows.Forms.Padding(5);
			this.cboMRPFG.Name = "cboMRPFG";
			this.cboMRPFG.Size = new System.Drawing.Size(120, 25);
			this.cboMRPFG.TabIndex = 11;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(1044, 387);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(38, 17);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "MRP";
			this.numPARQT.AllowNegative = false;
			this.numPARQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPARQT.DataChanged = false;
			this.numPARQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numPARQT.Location = new System.Drawing.Point(945, 410);
			this.numPARQT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numPARQT.Name = "numPARQT";
			this.numPARQT.NumberFormat = "";
			this.numPARQT.Size = new System.Drawing.Size(91, 23);
			this.numPARQT.TabIndex = 10;
			this.numPARQT.Text = "0.00";
			this.numPARQT.ThousandSeperator = false;
			this.numPARQT.Value = 0.0;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(4, 91);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(103, 17);
			this.Label1.TabIndex = 14;
			this.Label1.Text = "Model Quantity";
			this.lblQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblQTY.AutoSize = true;
			this.lblQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQTY.Location = new System.Drawing.Point(945, 387);
			this.lblQTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQTY.Name = "lblQTY";
			this.lblQTY.Size = new System.Drawing.Size(91, 17);
			this.lblQTY.TabIndex = 6;
			this.lblQTY.Text = "Part Quantity";
			this.lblMDLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblMDLCD.AutoSize = true;
			this.lblMDLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblMDLCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMDLCD.Location = new System.Drawing.Point(4, 7);
			this.lblMDLCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMDLCD.Name = "lblMDLCD";
			this.lblMDLCD.Size = new System.Drawing.Size(83, 17);
			this.lblMDLCD.TabIndex = 1;
			this.lblMDLCD.Text = "Model Code";
			this.txtDESC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtDESC.Enabled = false;
			this.txtDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtDESC.Location = new System.Drawing.Point(336, 410);
			this.txtDESC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtDESC.Name = "txtDESC";
			this.txtDESC.Size = new System.Drawing.Size(328, 23);
			this.txtDESC.TabIndex = 8;
			this.lblDESC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDESC.AutoSize = true;
			this.lblDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblDESC.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDESC.Location = new System.Drawing.Point(336, 387);
			this.lblDESC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDESC.Name = "lblDESC";
			this.lblDESC.Size = new System.Drawing.Size(79, 17);
			this.lblDESC.TabIndex = 5;
			this.lblDESC.Text = "Description";
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(4, 132);
			this.lblREMRK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(57, 17);
			this.lblREMRK.TabIndex = 4;
			this.lblREMRK.Text = "Remark";
			this.lblITMCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblITMCD.AutoSize = true;
			this.lblITMCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblITMCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblITMCD.Location = new System.Drawing.Point(4, 387);
			this.lblITMCD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblITMCD.Name = "lblITMCD";
			this.lblITMCD.Size = new System.Drawing.Size(69, 17);
			this.lblITMCD.TabIndex = 4;
			this.lblITMCD.Text = "BOM Part";
			this.lblREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREVNO.AutoSize = true;
			this.lblREVNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblREVNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREVNO.Location = new System.Drawing.Point(4, 37);
			this.lblREVNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblREVNO.Name = "lblREVNO";
			this.lblREVNO.Size = new System.Drawing.Size(84, 17);
			this.lblREVNO.TabIndex = 2;
			this.lblREVNO.Text = "Revision No";
			this.numREVNO.AllowNegative = false;
			this.numREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numREVNO.DataChanged = false;
			this.numREVNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numREVNO.Location = new System.Drawing.Point(115, 34);
			this.numREVNO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numREVNO.Name = "numREVNO";
			this.numREVNO.NumberFormat = "8.2";
			this.numREVNO.Size = new System.Drawing.Size(87, 23);
			this.numREVNO.TabIndex = 2;
			this.numREVNO.Text = "0.00";
			this.numREVNO.ThousandSeperator = false;
			this.numREVNO.Value = 0.0;
			this.numMDLQT.AllowNegative = false;
			this.numMDLQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numMDLQT.DataChanged = false;
			this.numMDLQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numMDLQT.Location = new System.Drawing.Point(115, 88);
			this.numMDLQT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numMDLQT.Name = "numMDLQT";
			this.numMDLQT.NumberFormat = "8.5";
			this.numMDLQT.Size = new System.Drawing.Size(87, 23);
			this.numMDLQT.TabIndex = 4;
			this.numMDLQT.Text = "1.00000";
			this.numMDLQT.ThousandSeperator = false;
			this.numMDLQT.Value = 1.0;
			this.txtREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 7);
			this.txtREMRK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtREMRK.Location = new System.Drawing.Point(115, 115);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(744, 51);
			this.txtREMRK.TabIndex = 5;
			this.chkACTFG.AutoSize = true;
			this.chkACTFG.Location = new System.Drawing.Point(944, 3);
			this.chkACTFG.Name = "chkACTFG";
			this.chkACTFG.Size = new System.Drawing.Size(65, 21);
			this.chkACTFG.TabIndex = 4;
			this.chkACTFG.Text = "Active";
			this.chkACTFG.UseVisualStyleBackColor = true;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(771, 387);
			this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(45, 17);
			this.Label4.TabIndex = 17;
			this.Label4.Text = "Stage";
			this.dgvMABOM_Details.AllowUserToAddRows = false;
			this.dgvMABOM_Details.AllowUserToDeleteRows = false;
			this.dgvMABOM_Details.AllowUserToResizeRows = false;
			this.dgvMABOM_Details.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMABOM_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvMABOM_Details, 8);
			this.dgvMABOM_Details.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvMABOM_Details.Location = new System.Drawing.Point(4, 170);
			this.dgvMABOM_Details.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.dgvMABOM_Details.MultiSelect = false;
			this.dgvMABOM_Details.Name = "dgvMABOM_Details";
			this.dgvMABOM_Details.ReadOnly = true;
			this.dgvMABOM_Details.RowHeadersVisible = false;
			this.dgvMABOM_Details.RowHeadersWidth = 10;
			this.dgvMABOM_Details.RowTemplate.Height = 24;
			this.dgvMABOM_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMABOM_Details.Size = new System.Drawing.Size(888, 215);
			this.dgvMABOM_Details.TabIndex = 6;
			this.cbSTAGE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTAGE.FormattingEnabled = true;
			this.cbSTAGE.Location = new System.Drawing.Point(770, 407);
			this.cbSTAGE.Name = "cbSTAGE";
			this.cbSTAGE.Size = new System.Drawing.Size(168, 25);
			this.cbSTAGE.TabIndex = 18;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(672, 387);
			this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(72, 17);
			this.Label7.TabIndex = 19;
			this.Label7.Text = "Sequence";
			this.numSEQNO.AllowNegative = false;
			this.numSEQNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSEQNO.DataChanged = false;
			this.numSEQNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numSEQNO.Location = new System.Drawing.Point(672, 410);
			this.numSEQNO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numSEQNO.Name = "numSEQNO";
			this.numSEQNO.NumberFormat = "8.0";
			this.numSEQNO.Size = new System.Drawing.Size(91, 23);
			this.numSEQNO.TabIndex = 20;
			this.numSEQNO.Text = "0";
			this.numSEQNO.ThousandSeperator = false;
			this.numSEQNO.Value = 0.0;
			this.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 3;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnCANCEL, 2, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(4, 471);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(384, 54);
			this.TableLayoutPanel5.TabIndex = 13;
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
			this.btnSAVE.Text = "Add";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
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
			this.btnREMOVE.TabIndex = 13;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.btnCANCEL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnCANCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnCANCEL.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCANCEL.Location = new System.Drawing.Point(260, 2);
			this.btnCANCEL.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.Size = new System.Drawing.Size(120, 50);
			this.btnCANCEL.TabIndex = 14;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCANCEL.UseVisualStyleBackColor = false;
			this.TabPage2.BackColor = System.Drawing.Color.AliceBlue;
			this.TabPage2.Controls.Add(this.TableLayoutPanel8);
			this.TabPage2.Location = new System.Drawing.Point(4, 26);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage2.Size = new System.Drawing.Size(1322, 537);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Others";
			this.TableLayoutPanel8.ColumnCount = 4;
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel8.Controls.Add(this.cbOTHCD01, 3, 0);
			this.TableLayoutPanel8.Controls.Add(this.lblOTHCD01, 2, 0);
			this.TableLayoutPanel8.Controls.Add(this.cbOTH05, 1, 4);
			this.TableLayoutPanel8.Controls.Add(this.cbOTH04, 1, 3);
			this.TableLayoutPanel8.Controls.Add(this.cbOTH03, 1, 2);
			this.TableLayoutPanel8.Controls.Add(this.cbOTH02, 1, 1);
			this.TableLayoutPanel8.Controls.Add(this.cbOTH01, 1, 0);
			this.TableLayoutPanel8.Controls.Add(this.TableLayoutPanel9, 0, 6);
			this.TableLayoutPanel8.Controls.Add(this.lblOTH05, 0, 4);
			this.TableLayoutPanel8.Controls.Add(this.lblOTH02, 0, 1);
			this.TableLayoutPanel8.Controls.Add(this.lblOTH01, 0, 0);
			this.TableLayoutPanel8.Controls.Add(this.lblOTH03, 0, 2);
			this.TableLayoutPanel8.Controls.Add(this.lblOTH04, 0, 3);
			this.TableLayoutPanel8.Controls.Add(this.lblOTHCD02, 2, 1);
			this.TableLayoutPanel8.Controls.Add(this.lblOTHCD03, 2, 2);
			this.TableLayoutPanel8.Controls.Add(this.lblOTHCD04, 2, 3);
			this.TableLayoutPanel8.Controls.Add(this.lblOTHCD05, 2, 4);
			this.TableLayoutPanel8.Controls.Add(this.cbOTHCD02, 3, 1);
			this.TableLayoutPanel8.Controls.Add(this.cbOTHCD03, 3, 2);
			this.TableLayoutPanel8.Controls.Add(this.cbOTHCD04, 3, 3);
			this.TableLayoutPanel8.Controls.Add(this.cbOTHCD05, 3, 4);
			this.TableLayoutPanel8.Location = new System.Drawing.Point(6, 14);
			this.TableLayoutPanel8.Name = "TableLayoutPanel8";
			this.TableLayoutPanel8.RowCount = 7;
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel8.Size = new System.Drawing.Size(521, 254);
			this.TableLayoutPanel8.TabIndex = 0;
			this.cbOTHCD01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTHCD01.FormattingEnabled = true;
			this.cbOTHCD01.Location = new System.Drawing.Point(319, 3);
			this.cbOTHCD01.Name = "cbOTHCD01";
			this.cbOTHCD01.Size = new System.Drawing.Size(168, 25);
			this.cbOTHCD01.TabIndex = 2;
			this.lblOTHCD01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTHCD01.AutoSize = true;
			this.lblOTHCD01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTHCD01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTHCD01.Location = new System.Drawing.Point(249, 5);
			this.lblOTHCD01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTHCD01.Name = "lblOTHCD01";
			this.lblOTHCD01.Size = new System.Drawing.Size(63, 17);
			this.lblOTHCD01.TabIndex = 21;
			this.lblOTHCD01.Text = "Others 1";
			this.cbOTH05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTH05.FormattingEnabled = true;
			this.cbOTH05.Location = new System.Drawing.Point(74, 111);
			this.cbOTH05.Name = "cbOTH05";
			this.cbOTH05.Size = new System.Drawing.Size(168, 25);
			this.cbOTH05.TabIndex = 9;
			this.cbOTH04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTH04.FormattingEnabled = true;
			this.cbOTH04.Location = new System.Drawing.Point(74, 84);
			this.cbOTH04.Name = "cbOTH04";
			this.cbOTH04.Size = new System.Drawing.Size(168, 25);
			this.cbOTH04.TabIndex = 7;
			this.cbOTH03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTH03.FormattingEnabled = true;
			this.cbOTH03.Location = new System.Drawing.Point(74, 57);
			this.cbOTH03.Name = "cbOTH03";
			this.cbOTH03.Size = new System.Drawing.Size(168, 25);
			this.cbOTH03.TabIndex = 5;
			this.cbOTH02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTH02.FormattingEnabled = true;
			this.cbOTH02.Location = new System.Drawing.Point(74, 30);
			this.cbOTH02.Name = "cbOTH02";
			this.cbOTH02.Size = new System.Drawing.Size(168, 25);
			this.cbOTH02.TabIndex = 3;
			this.cbOTH01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTH01.FormattingEnabled = true;
			this.cbOTH01.Location = new System.Drawing.Point(74, 3);
			this.cbOTH01.Name = "cbOTH01";
			this.cbOTH01.Size = new System.Drawing.Size(168, 25);
			this.cbOTH01.TabIndex = 1;
			this.TableLayoutPanel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel9.AutoSize = true;
			this.TableLayoutPanel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel9.ColumnCount = 2;
			this.TableLayoutPanel8.SetColumnSpan(this.TableLayoutPanel9, 4);
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel9.Controls.Add(this.btnSAVE1, 0, 0);
			this.TableLayoutPanel9.Controls.Add(this.btnCANCEL1, 1, 0);
			this.TableLayoutPanel9.Location = new System.Drawing.Point(4, 177);
			this.TableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel9.Name = "TableLayoutPanel9";
			this.TableLayoutPanel9.RowCount = 1;
			this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel9.Size = new System.Drawing.Size(256, 54);
			this.TableLayoutPanel9.TabIndex = 14;
			this.btnSAVE1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnSAVE1.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE1.Location = new System.Drawing.Point(4, 2);
			this.btnSAVE1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSAVE1.Name = "btnSAVE1";
			this.btnSAVE1.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE1.TabIndex = 11;
			this.btnSAVE1.Text = "Save";
			this.btnSAVE1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE1.UseVisualStyleBackColor = false;
			this.btnCANCEL1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnCANCEL1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCANCEL1.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCANCEL1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCANCEL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCANCEL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnCANCEL1.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCANCEL1.Location = new System.Drawing.Point(132, 2);
			this.btnCANCEL1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCANCEL1.Name = "btnCANCEL1";
			this.btnCANCEL1.Size = new System.Drawing.Size(120, 50);
			this.btnCANCEL1.TabIndex = 12;
			this.btnCANCEL1.Text = "Cancel";
			this.btnCANCEL1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCANCEL1.UseVisualStyleBackColor = false;
			this.lblOTH05.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTH05.AutoSize = true;
			this.lblOTH05.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTH05.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTH05.Location = new System.Drawing.Point(4, 113);
			this.lblOTH05.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTH05.Name = "lblOTH05";
			this.lblOTH05.Size = new System.Drawing.Size(63, 17);
			this.lblOTH05.TabIndex = 15;
			this.lblOTH05.Text = "Others 5";
			this.lblOTH02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTH02.AutoSize = true;
			this.lblOTH02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTH02.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTH02.Location = new System.Drawing.Point(4, 32);
			this.lblOTH02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTH02.Name = "lblOTH02";
			this.lblOTH02.Size = new System.Drawing.Size(63, 17);
			this.lblOTH02.TabIndex = 15;
			this.lblOTH02.Text = "Others 2";
			this.lblOTH01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTH01.AutoSize = true;
			this.lblOTH01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTH01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTH01.Location = new System.Drawing.Point(4, 5);
			this.lblOTH01.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTH01.Name = "lblOTH01";
			this.lblOTH01.Size = new System.Drawing.Size(63, 17);
			this.lblOTH01.TabIndex = 15;
			this.lblOTH01.Text = "Others 1";
			this.lblOTH03.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTH03.AutoSize = true;
			this.lblOTH03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTH03.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTH03.Location = new System.Drawing.Point(4, 59);
			this.lblOTH03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTH03.Name = "lblOTH03";
			this.lblOTH03.Size = new System.Drawing.Size(63, 17);
			this.lblOTH03.TabIndex = 16;
			this.lblOTH03.Text = "Others 3";
			this.lblOTH04.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTH04.AutoSize = true;
			this.lblOTH04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTH04.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTH04.Location = new System.Drawing.Point(4, 86);
			this.lblOTH04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTH04.Name = "lblOTH04";
			this.lblOTH04.Size = new System.Drawing.Size(63, 17);
			this.lblOTH04.TabIndex = 15;
			this.lblOTH04.Text = "Others 4";
			this.lblOTHCD02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTHCD02.AutoSize = true;
			this.lblOTHCD02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTHCD02.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTHCD02.Location = new System.Drawing.Point(249, 32);
			this.lblOTHCD02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTHCD02.Name = "lblOTHCD02";
			this.lblOTHCD02.Size = new System.Drawing.Size(63, 17);
			this.lblOTHCD02.TabIndex = 23;
			this.lblOTHCD02.Text = "Others 1";
			this.lblOTHCD03.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTHCD03.AutoSize = true;
			this.lblOTHCD03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTHCD03.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTHCD03.Location = new System.Drawing.Point(249, 59);
			this.lblOTHCD03.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTHCD03.Name = "lblOTHCD03";
			this.lblOTHCD03.Size = new System.Drawing.Size(63, 17);
			this.lblOTHCD03.TabIndex = 24;
			this.lblOTHCD03.Text = "Others 1";
			this.lblOTHCD04.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTHCD04.AutoSize = true;
			this.lblOTHCD04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTHCD04.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTHCD04.Location = new System.Drawing.Point(249, 86);
			this.lblOTHCD04.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTHCD04.Name = "lblOTHCD04";
			this.lblOTHCD04.Size = new System.Drawing.Size(63, 17);
			this.lblOTHCD04.TabIndex = 25;
			this.lblOTHCD04.Text = "Others 1";
			this.lblOTHCD05.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblOTHCD05.AutoSize = true;
			this.lblOTHCD05.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblOTHCD05.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOTHCD05.Location = new System.Drawing.Point(249, 113);
			this.lblOTHCD05.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOTHCD05.Name = "lblOTHCD05";
			this.lblOTHCD05.Size = new System.Drawing.Size(63, 17);
			this.lblOTHCD05.TabIndex = 26;
			this.lblOTHCD05.Text = "Others 1";
			this.cbOTHCD02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTHCD02.FormattingEnabled = true;
			this.cbOTHCD02.Location = new System.Drawing.Point(319, 30);
			this.cbOTHCD02.Name = "cbOTHCD02";
			this.cbOTHCD02.Size = new System.Drawing.Size(168, 25);
			this.cbOTHCD02.TabIndex = 4;
			this.cbOTHCD03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTHCD03.FormattingEnabled = true;
			this.cbOTHCD03.Location = new System.Drawing.Point(319, 57);
			this.cbOTHCD03.Name = "cbOTHCD03";
			this.cbOTHCD03.Size = new System.Drawing.Size(168, 25);
			this.cbOTHCD03.TabIndex = 6;
			this.cbOTHCD04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTHCD04.FormattingEnabled = true;
			this.cbOTHCD04.Location = new System.Drawing.Point(319, 84);
			this.cbOTHCD04.Name = "cbOTHCD04";
			this.cbOTHCD04.Size = new System.Drawing.Size(168, 25);
			this.cbOTHCD04.TabIndex = 8;
			this.cbOTHCD05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbOTHCD05.FormattingEnabled = true;
			this.cbOTHCD05.Location = new System.Drawing.Point(319, 111);
			this.cbOTHCD05.Name = "cbOTHCD05";
			this.cbOTHCD05.Size = new System.Drawing.Size(168, 25);
			this.cbOTHCD05.TabIndex = 10;
			this.TabPage3.Controls.Add(this.tvBOM);
			this.TabPage3.Location = new System.Drawing.Point(4, 26);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage3.Size = new System.Drawing.Size(1322, 537);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "BOM Tree";
			this.TabPage3.UseVisualStyleBackColor = true;
			this.tvBOM.Location = new System.Drawing.Point(6, 6);
			this.tvBOM.Name = "tvBOM";
			this.tvBOM.Size = new System.Drawing.Size(1310, 495);
			this.tvBOM.TabIndex = 0;
			this.TabPage4.Controls.Add(this.TableLayoutPanel13);
			this.TabPage4.Controls.Add(this.TableLayoutPanel12);
			this.TabPage4.Controls.Add(this.dgvCPART);
			this.TabPage4.Location = new System.Drawing.Point(4, 26);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.TabPage4.Size = new System.Drawing.Size(1322, 537);
			this.TabPage4.TabIndex = 3;
			this.TabPage4.Text = "Customer Part";
			this.TabPage4.UseVisualStyleBackColor = true;
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
			this.TableLayoutPanel13.Location = new System.Drawing.Point(6, 363);
			this.TableLayoutPanel13.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel13.Name = "TableLayoutPanel13";
			this.TableLayoutPanel13.RowCount = 1;
			this.TableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel13.Size = new System.Drawing.Size(382, 54);
			this.TableLayoutPanel13.TabIndex = 58;
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
			this.TableLayoutPanel12.Size = new System.Drawing.Size(830, 138);
			this.TableLayoutPanel12.TabIndex = 57;
			this.txtCPART_CPTNM.Location = new System.Drawing.Point(148, 62);
			this.txtCPART_CPTNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCPART_CPTNM.Name = "txtCPART_CPTNM";
			this.txtCPART_CPTNM.Size = new System.Drawing.Size(591, 23);
			this.txtCPART_CPTNM.TabIndex = 57;
			this.Label74.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label74.AutoSize = true;
			this.Label74.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label74.Location = new System.Drawing.Point(3, 65);
			this.Label74.Name = "Label74";
			this.Label74.Size = new System.Drawing.Size(139, 17);
			this.Label74.TabIndex = 13;
			this.Label74.Text = "Customer Part Name";
			this.txtCPART_CPTNO.Location = new System.Drawing.Point(148, 35);
			this.txtCPART_CPTNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCPART_CPTNO.Name = "txtCPART_CPTNO";
			this.txtCPART_CPTNO.Size = new System.Drawing.Size(591, 23);
			this.txtCPART_CPTNO.TabIndex = 56;
			this.txtCPART_REMRK.Location = new System.Drawing.Point(148, 89);
			this.txtCPART_REMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCPART_REMRK.Multiline = true;
			this.txtCPART_REMRK.Name = "txtCPART_REMRK";
			this.txtCPART_REMRK.Size = new System.Drawing.Size(588, 47);
			this.txtCPART_REMRK.TabIndex = 58;
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
			this.lkpCPART_CUSID.Location = new System.Drawing.Point(150, 5);
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
			this.Label75.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label75.AutoSize = true;
			this.Label75.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label75.Location = new System.Drawing.Point(3, 104);
			this.Label75.Name = "Label75";
			this.Label75.Size = new System.Drawing.Size(57, 17);
			this.Label75.TabIndex = 12;
			this.Label75.Text = "Remark";
			this.Label76.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label76.AutoSize = true;
			this.Label76.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label76.Location = new System.Drawing.Point(3, 38);
			this.Label76.Name = "Label76";
			this.Label76.Size = new System.Drawing.Size(124, 17);
			this.Label76.TabIndex = 12;
			this.Label76.Text = "Customer Part No.";
			this.Label77.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label77.AutoSize = true;
			this.Label77.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label77.Location = new System.Drawing.Point(3, 8);
			this.Label77.Name = "Label77";
			this.Label77.Size = new System.Drawing.Size(85, 17);
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
			this.dgvCPART.Size = new System.Drawing.Size(1007, 200);
			this.dgvCPART.TabIndex = 56;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 2, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnCOPY, 3, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 3);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(512, 54);
			this.TableLayoutPanel6.TabIndex = 14;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(260, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 17;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(4, 2);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(132, 2);
			this.btnBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 16;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnCOPY.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCOPY.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCOPY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCOPY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCOPY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnCOPY.Image = IMS.My.Resources.Resources.copy;
			this.btnCOPY.Location = new System.Drawing.Point(388, 2);
			this.btnCOPY.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnCOPY.Name = "btnCOPY";
			this.btnCOPY.Size = new System.Drawing.Size(120, 50);
			this.btnCOPY.TabIndex = 18;
			this.btnCOPY.Text = "Copy To";
			this.btnCOPY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCOPY.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Location = new System.Drawing.Point(16, 634);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 2;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(0, 0);
			this.TableLayoutPanel2.TabIndex = 2;
			this.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.TableLayoutPanel7);
			this.Panel3.Location = new System.Drawing.Point(804, 18);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(531, 184);
			this.Panel3.TabIndex = 7;
			this.TableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.TableLayoutPanel7.ColumnCount = 2;
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel7.Controls.Add(this.txtNMDLCD, 1, 0);
			this.TableLayoutPanel7.Controls.Add(this.btnSAVE2, 0, 3);
			this.TableLayoutPanel7.Controls.Add(this.Label6, 0, 1);
			this.TableLayoutPanel7.Controls.Add(this.Label5, 0, 0);
			this.TableLayoutPanel7.Controls.Add(this.numNREVNO, 1, 1);
			this.TableLayoutPanel7.Controls.Add(this.btnBACK2, 1, 3);
			this.TableLayoutPanel7.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel7.Name = "TableLayoutPanel7";
			this.TableLayoutPanel7.RowCount = 4;
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel7.Size = new System.Drawing.Size(517, 165);
			this.TableLayoutPanel7.TabIndex = 0;
			this.txtNMDLCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtNMDLCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtNMDLCD.Location = new System.Drawing.Point(132, 2);
			this.txtNMDLCD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.txtNMDLCD.Name = "txtNMDLCD";
			this.txtNMDLCD.Size = new System.Drawing.Size(200, 23);
			this.txtNMDLCD.TabIndex = 1;
			this.btnSAVE2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnSAVE2.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE2.Location = new System.Drawing.Point(4, 76);
			this.btnSAVE2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSAVE2.Name = "btnSAVE2";
			this.btnSAVE2.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE2.TabIndex = 3;
			this.btnSAVE2.Text = "Save";
			this.btnSAVE2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE2.UseVisualStyleBackColor = false;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(4, 32);
			this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(84, 17);
			this.Label6.TabIndex = 4;
			this.Label6.Text = "Revision No";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(4, 5);
			this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(83, 17);
			this.Label5.TabIndex = 2;
			this.Label5.Text = "Model Code";
			this.numNREVNO.AllowNegative = false;
			this.numNREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numNREVNO.DataChanged = false;
			this.numNREVNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numNREVNO.Location = new System.Drawing.Point(132, 29);
			this.numNREVNO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numNREVNO.Name = "numNREVNO";
			this.numNREVNO.NumberFormat = "8.2";
			this.numNREVNO.Size = new System.Drawing.Size(62, 23);
			this.numNREVNO.TabIndex = 2;
			this.numNREVNO.Text = "0.00";
			this.numNREVNO.ThousandSeperator = false;
			this.numNREVNO.Value = 0.0;
			this.btnBACK2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBACK2.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBACK2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBACK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBACK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnBACK2.Image = IMS.My.Resources.Resources.Back;
			this.btnBACK2.Location = new System.Drawing.Point(132, 76);
			this.btnBACK2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnBACK2.Name = "btnBACK2";
			this.btnBACK2.Size = new System.Drawing.Size(120, 50);
			this.btnBACK2.TabIndex = 4;
			this.btnBACK2.Text = "Back";
			this.btnBACK2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBACK2.UseVisualStyleBackColor = false;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel3);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.dgvMABOM_Header);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1346, 630);
			this.Panel2.TabIndex = 6;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnPRINTFR, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(5, 56);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(512, 54);
			this.TableLayoutPanel3.TabIndex = 8;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(388, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(260, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTFR.TabIndex = 5;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(4, 2);
			this.btnSEARCH.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 50);
			this.btnSEARCH.TabIndex = 3;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(132, 2);
			this.btnNew.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 50);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 17f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel3);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			base.Name = "frmMAEBOM";
			base.Tag = "MAEBOM";
			this.Text = "Bill of Material";
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMABOM_Header).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMABOM_Details).EndInit();
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.TableLayoutPanel8.ResumeLayout(false);
			this.TableLayoutPanel8.PerformLayout();
			this.TableLayoutPanel9.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.TabPage4.ResumeLayout(false);
			this.TabPage4.PerformLayout();
			this.TableLayoutPanel13.ResumeLayout(false);
			this.TableLayoutPanel12.ResumeLayout(false);
			this.TableLayoutPanel12.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvCPART).EndInit();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			this.TableLayoutPanel7.ResumeLayout(false);
			this.TableLayoutPanel7.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void BindControltoGrid()
		{
			dgvMABOM_Details.CurrentRow.Cells["MABOM_BOMPN"].Value = RuntimeHelpers.GetObjectValue(cbBOMPN.SelectedValue);
			dgvMABOM_Details.CurrentRow.Cells["MABOM_DESC"].Value = txtDESC.Text;
			dgvMABOM_Details.CurrentRow.Cells["MABOM_PARQT"].Value = numPARQT.Value;
			dgvMABOM_Details.CurrentRow.Cells["MABOM_MRPFG"].Value = RuntimeHelpers.GetObjectValue(cboMRPFG.SelectedValue);
			dgvMABOM_Details.CurrentRow.Cells["MRPFG"].Value = cboMRPFG.Text;
		}

		private void NumberFormat()
		{
			numMDLQT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numPARQT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Weight);
		}

		private void frmMAEBOM_FormClosing(object sender, FormClosingEventArgs e)
		{
            G.IsModifyRerun = false;
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

		private void frmMAEBOM_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			intAccessLevel = Common.GetAccessLevel(Conversions.ToString(base.Tag));
			BindComboHeader();
			BindOTHERFields();
			Header();
			NumberFormat();
			Point pt = default(Point);
			pt.X = 530;
			pt.Y = 30;
			Panel3.Location = pt;
			btnNew.Enabled = intAccessLevel != 0;
			btnSAVE.Enabled = intAccessLevel >= 1;
			btnSAVE1.Enabled = intAccessLevel >= 1;
			btnSAVE2.Enabled = intAccessLevel >= 1;
			btnCOPY.Enabled = intAccessLevel >= 1;
			btnUpdate2.Enabled = intAccessLevel >= 1;
			btnREMOVE.Enabled = intAccessLevel >= 3;
			btnRemove2.Enabled = intAccessLevel >= 3;
			btnDelete.Enabled = intAccessLevel >= 3;
		}

		private void BindOTHERFields()
		{
			string strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WHERE MACOD_CTYID = 'BDTYP' AND MACOD_CFLD1 = 'OTH01'";
			DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				lblOTH01.Text = Conversions.ToString(dt.Rows[0]["MACOD_CODNM"]);
				lblOTH01.Visible = true;
				strSQL = "SELECT DISTINCT MABDM_BDGRP, MABDM_CTYID FROM MABDM_TBL WITH (NOLOCK) ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				strSQL += "ORDER BY MABDM_BDGRP";
				cbOTH01.ValueMember = "MABDM_BDGRP";
				cbOTH01.DisplayMember = "MABDM_BDGRP";
				Common.RetriveComboItembySQL(strSQL, cbOTH01);
				cbOTH01.Visible = true;
				strSQL = "SELECT MACTY_CTYID, MACTY_CTYNM FROM MACTY_TBL ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MACTY_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				dt = DB.ExecProc(strSQL);
				lblOTHCD01.Text = Conversions.ToString(dt.Rows[0]["MACTY_CTYNM"]);
				lblOTHCD01.Visible = true;
				cbOTHCD01.Visible = true;
			}
			else
			{
				lblOTH01.Text = string.Empty;
				lblOTH01.Visible = false;
				cbOTH01.DataSource = null;
				cbOTH01.Visible = false;
				lblOTHCD01.Text = string.Empty;
				lblOTHCD01.Visible = false;
				cbOTHCD01.DataSource = null;
				cbOTHCD01.Visible = false;
			}
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WHERE MACOD_CTYID = 'BDTYP' AND MACOD_CFLD1 = 'OTH02'";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				lblOTH02.Text = Conversions.ToString(dt.Rows[0]["MACOD_CODNM"]);
				lblOTH02.Visible = true;
				strSQL = "SELECT DISTINCT MABDM_BDGRP, MABDM_CTYID FROM MABDM_TBL WITH (NOLOCK) ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				strSQL += "ORDER BY MABDM_BDGRP";
				cbOTH02.ValueMember = "MABDM_BDGRP";
				cbOTH02.DisplayMember = "MABDM_BDGRP";
				Common.RetriveComboItembySQL(strSQL, cbOTH02);
				cbOTH02.Visible = true;
				strSQL = "SELECT MACTY_CTYID, MACTY_CTYNM FROM MACTY_TBL ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MACTY_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				dt = DB.ExecProc(strSQL);
				lblOTHCD02.Text = Conversions.ToString(dt.Rows[0]["MACTY_CTYNM"]);
				lblOTHCD02.Visible = true;
				cbOTHCD02.Visible = true;
			}
			else
			{
				lblOTH02.Text = string.Empty;
				lblOTH02.Visible = false;
				cbOTH02.DataSource = null;
				cbOTH02.Visible = false;
				lblOTHCD02.Text = string.Empty;
				lblOTHCD02.Visible = false;
				cbOTHCD02.DataSource = null;
				cbOTHCD02.Visible = false;
			}
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WHERE MACOD_CTYID = 'BDTYP' AND MACOD_CFLD1 = 'OTH03'";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				lblOTH03.Text = Conversions.ToString(dt.Rows[0]["MACOD_CODNM"]);
				lblOTH03.Visible = true;
				strSQL = "SELECT DISTINCT MABDM_BDGRP, MABDM_CTYID FROM MABDM_TBL WITH (NOLOCK) ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				strSQL += "ORDER BY MABDM_BDGRP";
				cbOTH03.ValueMember = "MABDM_BDGRP";
				cbOTH03.DisplayMember = "MABDM_BDGRP";
				Common.RetriveComboItembySQL(strSQL, cbOTH03);
				cbOTH03.Visible = true;
				strSQL = "SELECT MACTY_CTYID, MACTY_CTYNM FROM MACTY_TBL ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MACTY_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				dt = DB.ExecProc(strSQL);
				lblOTHCD03.Text = Conversions.ToString(dt.Rows[0]["MACTY_CTYNM"]);
				lblOTHCD03.Visible = true;
				cbOTHCD03.Visible = true;
			}
			else
			{
				lblOTH03.Text = string.Empty;
				lblOTH03.Visible = false;
				cbOTH03.DataSource = null;
				cbOTH03.Visible = false;
				lblOTHCD03.Text = string.Empty;
				lblOTHCD03.Visible = false;
				cbOTHCD03.DataSource = null;
				cbOTHCD03.Visible = false;
			}
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WHERE MACOD_CTYID = 'BDTYP' AND MACOD_CFLD1 = 'OTH04'";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				lblOTH04.Text = Conversions.ToString(dt.Rows[0]["MACOD_CODNM"]);
				lblOTH04.Visible = true;
				strSQL = "SELECT DISTINCT MABDM_BDGRP, MABDM_CTYID FROM MABDM_TBL WITH (NOLOCK) ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				strSQL += "ORDER BY MABDM_BDGRP";
				cbOTH04.ValueMember = "MABDM_BDGRP";
				cbOTH04.DisplayMember = "MABDM_BDGRP";
				Common.RetriveComboItembySQL(strSQL, cbOTH04);
				cbOTH04.Visible = true;
				strSQL = "SELECT MACTY_CTYID, MACTY_CTYNM FROM MACTY_TBL ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MACTY_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				dt = DB.ExecProc(strSQL);
				lblOTHCD04.Text = Conversions.ToString(dt.Rows[0]["MACTY_CTYNM"]);
				lblOTHCD04.Visible = true;
				cbOTHCD04.Visible = true;
			}
			else
			{
				lblOTH04.Text = string.Empty;
				lblOTH04.Visible = false;
				cbOTH04.DataSource = null;
				cbOTH04.Visible = false;
				lblOTHCD04.Text = string.Empty;
				lblOTHCD04.Visible = false;
				cbOTHCD04.DataSource = null;
				cbOTHCD04.Visible = false;
			}
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WHERE MACOD_CTYID = 'BDTYP' AND MACOD_CFLD1 = 'OTH05'";
			dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0)
			{
				lblOTH05.Text = Conversions.ToString(dt.Rows[0]["MACOD_CODNM"]);
				lblOTH05.Visible = true;
				strSQL = "SELECT DISTINCT MABDM_BDGRP, MABDM_CTYID FROM MABDM_TBL WITH (NOLOCK) ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				strSQL += "ORDER BY MABDM_BDGRP";
				cbOTH05.ValueMember = "MABDM_BDGRP";
				cbOTH05.DisplayMember = "MABDM_BDGRP";
				Common.RetriveComboItembySQL(strSQL, cbOTH05);
				cbOTH05.Visible = true;
				strSQL = "SELECT MACTY_CTYID, MACTY_CTYNM FROM MACTY_TBL ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MACTY_CTYID = '", dt.Rows[0]["MACOD_CODID"]), "' ")));
				dt = DB.ExecProc(strSQL);
				lblOTHCD05.Text = Conversions.ToString(dt.Rows[0]["MACTY_CTYNM"]);
				lblOTHCD05.Visible = true;
				cbOTHCD05.Visible = true;
			}
			else
			{
				lblOTH05.Text = string.Empty;
				lblOTH05.Visible = false;
				cbOTH05.DataSource = null;
				cbOTH05.Visible = false;
				lblOTHCD05.Text = string.Empty;
				lblOTHCD05.Visible = false;
				cbOTHCD05.DataSource = null;
				cbOTHCD05.Visible = false;
			}
		}

		private void ClearDetails()
		{
			cbBOMPN.SelectedIndex = -1;
			txtDESC.Text = string.Empty;
			numSEQNO.Value = 0.0;
			numPARQT.Value = 0.0;
			cbSTAGE.SelectedIndex = -1;
			cboMRPFG.SelectedIndex = -1;
			btnSAVE.Tag = "Add";
		}

		private void ClearOthers()
		{
			if (cbOTH01.Visible)
			{
				cbOTH01.SelectedIndex = -1;
			}
			if (cbOTHCD01.Visible)
			{
				cbOTHCD01.SelectedIndex = -1;
			}
			if (cbOTH02.Visible)
			{
				cbOTH02.SelectedIndex = -1;
			}
			if (cbOTHCD02.Visible)
			{
				cbOTHCD02.SelectedIndex = -1;
			}
			if (cbOTH03.Visible)
			{
				cbOTH03.SelectedIndex = -1;
			}
			if (cbOTHCD03.Visible)
			{
				cbOTHCD03.SelectedIndex = -1;
			}
			if (cbOTH04.Visible)
			{
				cbOTH04.SelectedIndex = -1;
			}
			if (cbOTHCD04.Visible)
			{
				cbOTHCD04.SelectedIndex = -1;
			}
			if (cbOTH05.Visible)
			{
				cbOTH05.SelectedIndex = -1;
			}
			if (cbOTHCD05.Visible)
			{
				cbOTHCD05.SelectedIndex = -1;
			}
		}

		private void ClearControl()
		{
			cbMDLCD.SelectedIndex = -1;
			TabControl1.SelectedIndex = 0;
			cbMDLCD.Enabled = true;
			txtDESC.Text = string.Empty;
			numMDLQT.Value = 1.0;
			numMDLQT.Enabled = true;
			numREVNO.Value = 0.0;
			numREVNO.Enabled = true;
			txtREMRK.Text = string.Empty;
			chkACTFG.Checked = false;
			btnREMOVE.Enabled = intAccessLevel >= 3;
			btnCANCEL.Enabled = true;
			btnPRINT.Enabled = false;
			btnBack.Enabled = true;
			btnDelete.Enabled = false;
			btnCOPY.Enabled = false;
			dgvMABOM_Details.ClearSelection();
			tvBOM.Nodes.Clear();
		}

		private bool spMAEBOM(string strPRO)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spMAEBOM ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(numREVNO.Value) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDESC.Text) + "', ";
			strSQL = strSQL + Conversions.ToString(numSEQNO.Value) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbSTAGE.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(numMDLQT.Value) + ", ";
			strSQL = strSQL + Conversions.ToString(numPARQT.Value) + ", ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cboMRPFG.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("", Interaction.IIf(chkACTFG.Checked, 1, 0)), ", ")));
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtREMRK.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(Interaction.IIf(cbOTH01.Visible, Operators.ConcatenateObject(Operators.ConcatenateObject(cbOTH01.SelectedValue, "|"), cbOTHCD01.SelectedValue), ""))) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(Interaction.IIf(cbOTH02.Visible, Operators.ConcatenateObject(Operators.ConcatenateObject(cbOTH02.SelectedValue, "|"), cbOTHCD02.SelectedValue), ""))) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(Interaction.IIf(cbOTH03.Visible, Operators.ConcatenateObject(Operators.ConcatenateObject(cbOTH03.SelectedValue, "|"), cbOTHCD03.SelectedValue), ""))) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(Interaction.IIf(cbOTH04.Visible, Operators.ConcatenateObject(Operators.ConcatenateObject(cbOTH04.SelectedValue, "|"), cbOTHCD04.SelectedValue), ""))) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(Interaction.IIf(cbOTH05.Visible, Operators.ConcatenateObject(Operators.ConcatenateObject(cbOTH05.SelectedValue, "|"), cbOTHCD05.SelectedValue), ""))) + "', ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "', ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "'";
			bool spMAEBOM;
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
				spMAEBOM = false;
				ProjectData.ClearProjectError();
				goto IL_03d3;
			}
			spMAEBOM = true;
			goto IL_03d3;
			IL_03d3:
			return spMAEBOM;
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			if (ValidateControl() && spMAEBOM("0"))
			{
				ClearDetails();
				ClearOthers();
                txtDESC.Text = "Custommer Return Entry";
                RefreshGrid();
				BindBOMTree();
				btnDelete.Enabled = intAccessLevel >= 3;
				btnPRINT.Enabled = true;
				btnCOPY.Enabled = intAccessLevel >= 1;
				cbMDLCD.Enabled = false;
				numREVNO.Enabled = false;
				numMDLQT.Enabled = false;
			}
		}

		public void Header()
		{
			int i = 0;
			int count = dgvMABOM_Header.Rows.Count;
			checked
			{
				for (int a = 1; a <= count; a++)
				{
					dgvMABOM_Header.Rows.Remove(dgvMABOM_Header.Rows[0]);
				}
				string strSQL = "EXEC spMABOM '0', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCDFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCDTO.SelectedValue), "'")));
				DataTable dt = DB.ExecProc(strSQL);
				DataGridView dataGridView = dgvMABOM_Header;
				dataGridView.DataSource = dt;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 250;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Quantity");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 250;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remarks");
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "MABOM_ACTFG";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Active");
				dataGridView.AutoResizeRows();
				dataGridView.Refresh();
				dataGridView = null;
				Panel1.Visible = false;
				Panel2.Visible = true;
				Panel3.Visible = false;
			}
		}

		private void BindComboHeader()
		{
			cbMDLCDFR.DataTable = "MABOM_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = MABOM_MDLCD";
			cbMDLCDFR.ValueMember = "MABOM_MDLCD";
			cbMDLCDFR.DisplayMember = "MABOM_MDLCD";
			cbMDLCDFR.LoadData();
			cbMDLCDTO.DataTable = "MABOM_TBL WITH (NOLOCK) LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = MABOM_MDLCD";
			cbMDLCDTO.ValueMember = "MABOM_MDLCD";
			cbMDLCDTO.DisplayMember = "MABOM_MDLCD";
			cbMDLCDTO.LoadData();
		}

		private void BindGridHeader()
		{
			cbMDLCD.SelectedValue = dgvMABOM_Header.CurrentRow.Cells["MABOM_MDLCD"].Value.ToString();
			numREVNO.Value = Conversions.ToDouble(dgvMABOM_Header.CurrentRow.Cells["MABOM_REVNO"].Value.ToString());
			txtMDLDESC.Text = dgvMABOM_Header.CurrentRow.Cells["MABOM_DESC"].Value.ToString();
			txtREMRK.Text = dgvMABOM_Header.CurrentRow.Cells["MABOM_REMRK"].Value.ToString();
			numMDLQT.Value = Conversions.ToDouble(dgvMABOM_Header.CurrentRow.Cells["MABOM_MDLQT"].Value.ToString());
			chkACTFG.Checked = Conversions.ToBoolean(dgvMABOM_Header.CurrentRow.Cells["MABOM_ACTFG"].Value);
			checked
			{
				if (cbOTH01.Items.Count > 0)
				{
					string strOther = Conversions.ToString(dgvMABOM_Header.CurrentRow.Cells["MABOM_OTHR01"].Value);
					if (strOther.IndexOf("|") > 0)
					{
						cbOTH01.SelectedValue = strOther.Substring(0, strOther.IndexOf("|"));
						cbOTHCD01.SelectedValue = strOther.Substring(strOther.IndexOf("|") + 1, Strings.Len(strOther) - strOther.IndexOf("|") - 1);
					}
				}
				if (cbOTH02.Items.Count > 0)
				{
					string strOther = Conversions.ToString(dgvMABOM_Header.CurrentRow.Cells["MABOM_OTHR02"].Value);
					if (strOther.IndexOf("|") > 0)
					{
						cbOTH02.SelectedValue = strOther.Substring(0, strOther.IndexOf("|"));
						cbOTHCD02.SelectedValue = strOther.Substring(strOther.IndexOf("|") + 1, Strings.Len(strOther) - strOther.IndexOf("|") - 1);
					}
				}
				if (cbOTH03.Items.Count > 0)
				{
					string strOther = Conversions.ToString(dgvMABOM_Header.CurrentRow.Cells["MABOM_OTHR03"].Value);
					if (strOther.IndexOf("|") > 0)
					{
						cbOTH03.SelectedValue = strOther.Substring(0, strOther.IndexOf("|"));
						cbOTHCD03.SelectedValue = strOther.Substring(strOther.IndexOf("|") + 1, Strings.Len(strOther) - strOther.IndexOf("|") - 1);
					}
				}
				if (cbOTH04.Items.Count > 0)
				{
					string strOther = Conversions.ToString(dgvMABOM_Header.CurrentRow.Cells["MABOM_OTHR04"].Value);
					if (strOther.IndexOf("|") > 0)
					{
						cbOTH04.SelectedValue = strOther.Substring(0, strOther.IndexOf("|"));
						cbOTHCD04.SelectedValue = strOther.Substring(strOther.IndexOf("|") + 1, Strings.Len(strOther) - strOther.IndexOf("|") - 1);
					}
				}
				if (cbOTH05.Items.Count > 0)
				{
					string strOther = Conversions.ToString(dgvMABOM_Header.CurrentRow.Cells["MABOM_OTHR05"].Value);
					if (strOther.IndexOf("|") > 0)
					{
						cbOTH05.SelectedValue = strOther.Substring(0, strOther.IndexOf("|"));
						cbOTHCD05.SelectedValue = strOther.Substring(strOther.IndexOf("|") + 1, Strings.Len(strOther) - strOther.IndexOf("|") - 1);
					}
				}
			}
		}

		private void BindComboBox()
		{
			cbMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbMDLCD.WhereClause = "MAITM_ITMTY = '1' AND MAITM_ACTFG = -1";
			cbMDLCD.ValueMember = "MAITM_ITMCD";
			cbMDLCD.DisplayMember = "MAITM_ITMCD";
			cbMDLCD.LoadData();
			cbBOMPN.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbBOMPN.WhereClause = "MAITM_ACTFG = -1";
			cbBOMPN.ValueMember = "MAITM_ITMCD";
			cbBOMPN.DisplayMember = "MAITM_ITMCD";
			cbBOMPN.LoadData();
			string strSQL = "SELECT '' AS MALOC_LOCID, '' AS MALOC_LOCNM UNION ";
			strSQL += "SELECT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MALOC_LOCTY = 'WIP' ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbSTAGE.ValueMember = "MALOC_LOCID";
			cbSTAGE.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbSTAGE);
			strSQL = "SELECT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'MRPFG' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cboMRPFG.ValueMember = "MACOD_CODID";
			cboMRPFG.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cboMRPFG);
		}

		private void RefreshGrid()
		{
			
			int count = dgvMABOM_Details.Rows.Count;
			checked
			{
				int i;
				for (i = 1; i <= count; i++)
				{
					dgvMABOM_Details.Rows.Remove(dgvMABOM_Details.Rows[0]);
				}
				string strSQL = "MABOM_BOMPN, MAITM_DESC, MABOM_SEQNO, MABOM_STAGE, MABOM_PARQT, MABOM_MRPFG, ";
				strSQL += "CASE WHEN MABOM_MRPFG = '0' THEN 'Exclude' WHEN MABOM_MRPFG = '1' THEN 'Include' WHEN MABOM_MRPFG = '2' THEN 'Auto Plan' END AS MRPFG ";
				DataTable dt = DB.GetTable(strSQL, "MABOM_TBL LEFT JOIN MAITM_TBL ON MAITM_ITMCD = MABOM_BOMPN", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("MABOM_MDLCD = '", cbMDLCD.SelectedValue), "' AND MABOM_REVNO = '"), numREVNO.Value), "'")), "MABOM_SEQNO");
				i = 0;
				DataGridView dataGridView = dgvMABOM_Details;
				dataGridView.DataSource = dt;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "BOM Part");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 250;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sequence");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Stage");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Quantity");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "MABOM_MRPFG";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "MRP";
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void BindBOMTree()
		{
			OleDbCommand cmd = new OleDbCommand();
			tvBOM.Nodes.Clear();
			string strSQL = "spMAKE_BOM ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCD.SelectedValue), "', ")));
			strSQL += Conversions.ToString(numREVNO.Value);
			DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count == 0)
			{
				return;
			}
			TreeNodeCollection nodes = tvBOM.Nodes;
			ComboboxControl comboboxControl;
			object[] obj = new object[1] { (comboboxControl = cbMDLCD).SelectedValue };
			object[] array = obj;
			bool[] obj2 = new bool[1] { true };
			bool[] array2 = obj2;
			NewLateBinding.LateCall(nodes, null, "Add", obj, null, null, obj2, true);
			if (array2[0])
			{
				comboboxControl.SelectedValue = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
			}
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					object left = dt.Rows[i]["PCBWF_LEVEL"];
					if (Operators.ConditionalCompareObjectEqual(left, 1, false))
					{
						TreeNodeCollection nodes2 = tvBOM.Nodes[0].Nodes;
						DataRow dataRow;
						object[] obj3 = new object[1] { (dataRow = dt.Rows[i])["PCBWF_BOMPN"] };
						array = obj3;
						bool[] obj4 = new bool[1] { true };
						array2 = obj4;
						NewLateBinding.LateCall(nodes2, null, "Add", obj3, null, null, obj4, true);
						if (array2[0])
						{
							dataRow["PCBWF_BOMPN"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, 2, false))
					{
						int num2 = tvBOM.Nodes[0].Nodes.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							if (Operators.ConditionalCompareObjectEqual(tvBOM.Nodes[0].Nodes[j].Text, dt.Rows[i]["PCBWF_MDLCD"], false))
							{
								TreeNodeCollection nodes3 = tvBOM.Nodes[0].Nodes[j].Nodes;
								DataRow dataRow;
								object[] obj5 = new object[1] { (dataRow = dt.Rows[i])["PCBWF_BOMPN"] };
								array = obj5;
								bool[] obj6 = new bool[1] { true };
								array2 = obj6;
								NewLateBinding.LateCall(nodes3, null, "Add", obj5, null, null, obj6, true);
								if (array2[0])
								{
									dataRow["PCBWF_BOMPN"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
								}
							}
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, 3, false))
					{
						int num3 = tvBOM.Nodes[0].Nodes.Count - 1;
						for (int k = 0; k <= num3; k++)
						{
							int num4 = tvBOM.Nodes[0].Nodes[k].Nodes.Count - 1;
							for (int n = 0; n <= num4; n++)
							{
								if (Operators.ConditionalCompareObjectEqual(tvBOM.Nodes[0].Nodes[k].Nodes[n].Text, dt.Rows[i]["PCBWF_MDLCD"], false))
								{
									TreeNodeCollection nodes4 = tvBOM.Nodes[0].Nodes[k].Nodes[n].Nodes;
									DataRow dataRow;
									object[] obj7 = new object[1] { (dataRow = dt.Rows[i])["PCBWF_BOMPN"] };
									array = obj7;
									bool[] obj8 = new bool[1] { true };
									array2 = obj8;
									NewLateBinding.LateCall(nodes4, null, "Add", obj7, null, null, obj8, true);
									if (array2[0])
									{
										dataRow["PCBWF_BOMPN"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
									}
								}
							}
						}
					}
					else if (Operators.ConditionalCompareObjectEqual(left, 4, false))
					{
						int num5 = tvBOM.Nodes[0].Nodes.Count - 1;
						for (int l = 0; l <= num5; l++)
						{
							int num6 = tvBOM.Nodes[0].Nodes[l].Nodes.Count - 1;
							for (int k2 = 0; k2 <= num6; k2++)
							{
								int num7 = tvBOM.Nodes[0].Nodes[l].Nodes[k2].Nodes.Count - 1;
								for (int l2 = 0; l2 <= num7; l2++)
								{
									if (Operators.ConditionalCompareObjectEqual(tvBOM.Nodes[0].Nodes[l].Nodes[k2].Nodes[l2].Text, dt.Rows[i]["PCBWF_MDLCD"], false))
									{
										TreeNodeCollection nodes5 = tvBOM.Nodes[0].Nodes[l].Nodes[k2].Nodes[l2].Nodes;
										DataRow dataRow;
										object[] obj9 = new object[1] { (dataRow = dt.Rows[i])["PCBWF_BOMPN"] };
										array = obj9;
										bool[] obj10 = new bool[1] { true };
										array2 = obj10;
										NewLateBinding.LateCall(nodes5, null, "Add", obj9, null, null, obj10, true);
										if (array2[0])
										{
											dataRow["PCBWF_BOMPN"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
										}
									}
								}
							}
						}
					}
					else
					{
						if (!Operators.ConditionalCompareObjectEqual(left, 5, false))
						{
							continue;
						}
						int num8 = tvBOM.Nodes[0].Nodes.Count - 1;
						for (int m = 0; m <= num8; m++)
						{
							int num9 = tvBOM.Nodes[0].Nodes[m].Nodes.Count - 1;
							for (int k3 = 0; k3 <= num9; k3++)
							{
								int num10 = tvBOM.Nodes[0].Nodes[m].Nodes[k3].Nodes.Count - 1;
								for (int l3 = 0; l3 <= num10; l3++)
								{
									int num11 = tvBOM.Nodes[0].Nodes[m].Nodes[k3].Nodes[l3].Nodes.Count - 1;
									for (int m2 = 0; m2 <= num11; m2++)
									{
										if (Operators.ConditionalCompareObjectEqual(tvBOM.Nodes[0].Nodes[m].Nodes[k3].Nodes[l3].Nodes[m2].Text, dt.Rows[i]["PCBWF_MDLCD"], false))
										{
											TreeNodeCollection nodes6 = tvBOM.Nodes[0].Nodes[m].Nodes[k3].Nodes[l3].Nodes[m2].Nodes;
											DataRow dataRow;
											object[] obj11 = new object[1] { (dataRow = dt.Rows[i])["PCBWF_BOMPN"] };
											array = obj11;
											bool[] obj12 = new bool[1] { true };
											array2 = obj12;
											NewLateBinding.LateCall(nodes6, null, "Add", obj11, null, null, obj12, true);
											if (array2[0])
											{
												dataRow["PCBWF_BOMPN"] = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		public void ReturnBillMaterial(String RevNo)
		{
            foreach (DataGridViewRow row in dgvMABOM_Header.Rows)
            {
				if (row.Cells["MABOM_REVNO"].Value.ToString().Contains(RevNo))
				{
                    dgvMABOM_Header.ClearSelection();
                    dgvMABOM_Header.CurrentCell = dgvMABOM_Header.Rows[row.Index].Cells[0];
                 //   dgvMABOM_Header.Rows[row.Index].Selected = true;
                    break;
                }
              
            }

           
          
          

            //string RevNo=""
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
            BindComboBox();
            BindGridHeader();
            RefreshGrid();
            BindBOMTree();
            string strSQL = "DELETE MACPT_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "'";
            DB.DBExecute(strSQL);
            strSQL = "INSERT MACPT_WRK (";
            strSQL += "WRK_COMPNM, WRK_CUSID, WRK_CPTNO, WRK_CPTNM, WRK_REMRK) ";
            strSQL = strSQL + "SELECT '" + MyProject.Computer.Name + "', MACPT_CUSID, MACPT_CPTNO, MACPT_CPTNM, MACPT_REMRK ";
            strSQL += "FROM MACPT_TBL WITH (NOLOCK) ";
            strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MACPT_ITMCD = '", cbMDLCD.SelectedValue), "' ")));
            strSQL = strSQL + "AND MACPT_REVNO = " + Conversions.ToString(numREVNO.Value) + " ";
            strSQL += "ORDER BY MACPT_CUSID";
            DB.DBExecute(strSQL);
            RefreshCPART();
            cbMDLCD.Enabled = false;
            numREVNO.Enabled = false;
		
                btnDelete.Enabled = false;
                btnPRINT.Enabled = false;
                numMDLQT.Enabled = false;
                btnREMOVE.Enabled = false;
                txtMDLDESC.Enabled = false;
                btnCOPY.Enabled =false;
          
           
          
         
           
			txtMDLDESC.Text = "Custommer Return Entry";
            txtDESC.Text = "Custommer Return Entry";

        }
        private void dgvMABOM_Header_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			Panel3.Visible = false;
			BindComboBox();
			BindGridHeader();
			RefreshGrid();
			BindBOMTree();
			string strSQL = "DELETE MACPT_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "'";
			DB.DBExecute(strSQL);
			strSQL = "INSERT MACPT_WRK (";
			strSQL += "WRK_COMPNM, WRK_CUSID, WRK_CPTNO, WRK_CPTNM, WRK_REMRK) ";
			strSQL = strSQL + "SELECT '" + MyProject.Computer.Name + "', MACPT_CUSID, MACPT_CPTNO, MACPT_CPTNM, MACPT_REMRK ";
			strSQL += "FROM MACPT_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MACPT_ITMCD = '", cbMDLCD.SelectedValue), "' ")));
			strSQL = strSQL + "AND MACPT_REVNO = " + Conversions.ToString(numREVNO.Value) + " ";
			strSQL += "ORDER BY MACPT_CUSID";
			DB.DBExecute(strSQL);
			RefreshCPART();
			cbMDLCD.Enabled = false;
			numREVNO.Enabled = false;
			btnDelete.Enabled = intAccessLevel >= 3;
			btnPRINT.Enabled = true;
			btnCOPY.Enabled = intAccessLevel >= 1;
			numMDLQT.Enabled = false;
			btnREMOVE.Enabled = false;
		}

		private void BindGridtoControl()
		{
			cbBOMPN.SelectedValue = dgvMABOM_Details.CurrentRow.Cells["MABOM_BOMPN"].Value.ToString();
			txtDESC.Text = dgvMABOM_Details.CurrentRow.Cells["MAITM_DESC"].Value.ToString();
			numSEQNO.Value = Conversions.ToDouble(dgvMABOM_Details.CurrentRow.Cells["MABOM_SEQNO"].Value);
			cbSTAGE.SelectedValue = dgvMABOM_Details.CurrentRow.Cells["MABOM_STAGE"].Value.ToString();
			numPARQT.Value = Conversions.ToDouble(dgvMABOM_Details.CurrentRow.Cells["MABOM_PARQT"].Value);
			cboMRPFG.SelectedValue = dgvMABOM_Details.CurrentRow.Cells["MABOM_MRPFG"].Value.ToString();
		}

		private void dgvMABOM_Details_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
			btnSAVE.Tag = "Update";
			btnREMOVE.Enabled = intAccessLevel >= 3;
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("DELETE MABOM_TBL WHERE MABOM_MDLCD = '", cbMDLCD.SelectedValue), "' "));
			strSQL = strSQL + "AND MABOM_REVNO = " + Conversions.ToString(numREVNO.Value) + " ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MABOM_BOMPN = '", cbBOMPN.SelectedValue), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MABOM_STAGE = '", cbSTAGE.SelectedValue), "' ")));
			strSQL += "DECLARE @TOTAL DECIMAL(12, 3) ";
			strSQL += "SELECT @TOTAL = SUM(MABOM_PARQT) FROM MABOM_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABOM_MDLCD = '", cbMDLCD.SelectedValue), "' ")));
			strSQL = strSQL + "AND MABOM_REVNO = " + Conversions.ToString(numREVNO.Value) + " ";
			strSQL += "UPDATE MABOM_TBL SET MABOM_RATIO = MABOM_PARQT/@TOTAL ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABOM_MDLCD = '", cbMDLCD.SelectedValue), "' ")));
			strSQL = strSQL + "AND MABOM_REVNO = " + Conversions.ToString(numREVNO.Value) + " ";
			DB.DBExecute(strSQL);
			RefreshGrid();
			BindBOMTree();
			ClearDetails();
			ClearOthers();
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearOthers();
			btnREMOVE.Enabled = false;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearOthers();
			ClearControl();
			BindComboBox();
			RefreshGrid();
			string strSQL = "DELETE MACPT_WRK WHERE WRK_COMPNM = '" + MyProject.Computer.Name + "'";
			DB.DBExecute(strSQL);
			RefreshCPART();
			Panel1.Visible = true;
			Panel2.Visible = false;
			btnREMOVE.Enabled = false;
			btnDelete.Enabled = false;
			btnPRINT.Enabled = false;
			btnCOPY.Enabled = false;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			G.IsModifyRerun = false;
			BindComboHeader();
			Header();
			ClearControl();
			ClearDetails();
			ClearOthers();
		}

		private bool ValidateControl()
		{
			if (Operators.ConditionalCompareObjectEqual(cbMDLCD.SelectedValue, "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbMDLCD.Focus();
				return false;
			}
			if (numREVNO.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				numREVNO.Focus();
				return false;
			}
			if (numMDLQT.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Quantity cannot be 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				numMDLQT.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(cbMDLCD.SelectedValue, cbBOMPN.SelectedValue, false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Bom Part cannot use Model Code!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			if (cbMDLCD.Enabled)
			{
				string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT * FROM MABOM_TBL WHERE MABOM_MDLCD = '", cbMDLCD.SelectedValue), "' AND MABOM_REVNO = '"), Conversion.Val(numREVNO.Text)), "'"));
				if (DB.RecordExists(strSQL))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code and Revision No already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					cbMDLCD.Focus();
					return false;
				}
			}
			if (Operators.ConditionalCompareObjectEqual(cbBOMPN.SelectedValue, "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "BOM Part cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbBOMPN.Focus();
				return false;
			}
			if (numPARQT.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity must be more than 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				numPARQT.Focus();
				return false;
			}
			if (cboMRPFG.SelectedIndex == -1)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "MRP cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cboMRPFG.Focus();
				return false;
			}
			string strITMTY = Conversions.ToString(DB.GetColumnValue("MAITM_ITMTY", "MAITM_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbBOMPN.SelectedValue), "'"))));
			checked
			{
				if (Operators.CompareString(strITMTY, "1", false) == 0)
				{
					string strSQL = "spMAKE_BOM ";
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbBOMPN.SelectedValue), "', ")));
					strSQL += Conversions.ToString(numREVNO.Value);
					DataTable dt = DB.ExecProc(strSQL);
					DataTable dtD = dt.DefaultView.ToTable(true, "PCBWF_MDLCD");
					int num = dtD.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dtD.Rows[i]["PCBWF_MDLCD"], cbMDLCD.SelectedValue, false))
						{
							string strMSG = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model") + " ", cbMDLCD.SelectedValue), " "));
							strMSG = Conversions.ToString(Operators.ConcatenateObject(strMSG, Operators.ConcatenateObject(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "exists in BOM Part") + " ", cbBOMPN.SelectedValue)));
							MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							cbBOMPN.Focus();
							return false;
						}
					}
				}
				if (Operators.ConditionalCompareObjectNotEqual(btnSAVE.Tag, "Update", false))
				{
					int num2 = dgvMABOM_Details.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(cbBOMPN.SelectedValue, dgvMABOM_Details.Rows[j].Cells["MABOM_BOMPN"].Value.ToString(), false), Operators.CompareObjectEqual(cbSTAGE.SelectedValue, dgvMABOM_Details.Rows[j].Cells["MABOM_STAGE"].Value.ToString(), false))))
						{
							MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Duplicate BOM Part!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							cbBOMPN.Focus();
							return false;
						}
					}
				}
				return true;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				spMAEBOM("1");
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				ClearOthers();
				ClearControl();
				BindComboHeader();
				Header();
			}
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "BILL OF MATERIAL MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMABOM.rpt";
			frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1 ,@MDLCDfr=", cbMDLCDFR.SelectedValue), ",@MDLCDto="), cbMDLCDTO.SelectedValue), ""));
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='BILL OF MATERIAL MASTER',gintQTYDS='" + PublicVar.gintQTYDS + "',gintAMTDS='" + PublicVar.gintAMTDS + "',gintPRCDS='" + PublicVar.gintPRCDS + "'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "BILL OF MATERIAL MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMABOM1.rpt";
			frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@MDLCD=", cbMDLCD.SelectedValue), ",@REVNO="), Conversion.Val(numREVNO.Text)), ""));
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='BILL OF MATERIAL MASTER',gintQTYDS='" + PublicVar.gintQTYDS + "',gintAMTDS='" + PublicVar.gintAMTDS + "',gintPRCDS='" + PublicVar.gintPRCDS + "'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAEBOM_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void btnCOPY_Click(object sender, EventArgs e)
		{
			Panel1.SendToBack();
			Panel1.Enabled = false;
			Panel3.BringToFront();
			Panel3.Visible = true;
			txtNMDLCD.Focus();
		}

		private void btnBACK2_Click(object sender, EventArgs e)
		{
			txtNMDLCD.Text = string.Empty;
			numNREVNO.Value = 0.0;
			Panel1.BringToFront();
			Panel1.Enabled = true;
			Panel3.SendToBack();
			Panel3.Visible = false;
		}

		private void btnSAVE2_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "SELECT * FROM MABOM_TBL WITH (NOLOCK) WHERE MABOM_MDLCD = '" + txtNMDLCD.Text + "' AND MABOM_REVNO = " + Conversions.ToString(numNREVNO.Value);
			if (DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code and Revision No already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtNMDLCD.Focus();
				return;
			}
			strSQL = "EXEC spMAEBOM_COPY ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbMDLCD.SelectedValue), "', ")));
			strSQL = strSQL + Conversions.ToString(numREVNO.Value) + ", ";
			strSQL = strSQL + "'" + txtNMDLCD.Text + "', ";
			strSQL = strSQL + Conversions.ToString(numNREVNO.Value) + ", ";
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
				ProjectData.ClearProjectError();
			}
			cbMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK) ";
			cbMDLCD.WhereClause = "MAITM_ITMTY = '1' AND MAITM_ACTFG = -1";
			cbMDLCD.ValueMember = "MAITM_ITMCD";
			cbMDLCD.DisplayMember = "MAITM_ITMCD";
			cbMDLCD.LoadData();
			cbMDLCD.SelectedValue = txtNMDLCD.Text;
			numREVNO.Value = numNREVNO.Value;
			txtNMDLCD.Text = string.Empty;
			numNREVNO.Value = 0.0;
			Panel1.Enabled = true;
			Panel3.Visible = false;
		}

		private void cbMDLCDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbMDLCDFR.SelectedIndex != -1)
			{
				cbMDLCDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbMDLCDFR.SelectedValue);
			}
		}

		private void btnSAVE1_Click(object sender, EventArgs e)
		{
			if (spMAEBOM("2"))
			{
				MessageBox.Show("Record edited!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private void btnCANCEL1_Click(object sender, EventArgs e)
		{
			ClearOthers();
		}

		private void cbOTH01_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT MABDM_BDCOD FROM MABDM_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", NewLateBinding.LateGet(NewLateBinding.LateGet(cbOTH01.Items[cbOTH01.SelectedIndex], null, "Row", new object[0], null, null, null), null, "ItemArray", new object[1] { 1 }, null, null, null)), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MABDM_BDGRP = '", cbOTH01.SelectedValue), "' ")));
			strSQL += "ORDER BY MABDM_ORDSQ";
			cbOTHCD01.ValueMember = "MABDM_BDCOD";
			cbOTHCD01.DisplayMember = "MABDM_BDCOD";
			Common.RetriveComboItembySQL(strSQL, cbOTHCD01);
		}

		private void cbOTH02_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT MABDM_BDCOD FROM MABDM_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", NewLateBinding.LateGet(NewLateBinding.LateGet(cbOTH02.Items[cbOTH02.SelectedIndex], null, "Row", new object[0], null, null, null), null, "ItemArray", new object[1] { 1 }, null, null, null)), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MABDM_BDGRP = '", cbOTH02.SelectedValue), "' ")));
			strSQL += "ORDER BY MABDM_ORDSQ";
			cbOTHCD02.ValueMember = "MABDM_BDCOD";
			cbOTHCD02.DisplayMember = "MABDM_BDCOD";
			Common.RetriveComboItembySQL(strSQL, cbOTHCD02);
		}

		private void cbOTH03_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT MABDM_BDCOD FROM MABDM_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", NewLateBinding.LateGet(NewLateBinding.LateGet(cbOTH03.Items[cbOTH03.SelectedIndex], null, "Row", new object[0], null, null, null), null, "ItemArray", new object[1] { 1 }, null, null, null)), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MABDM_BDGRP = '", cbOTH03.SelectedValue), "' ")));
			strSQL += "ORDER BY MABDM_ORDSQ";
			cbOTHCD03.ValueMember = "MABDM_BDCOD";
			cbOTHCD03.DisplayMember = "MABDM_BDCOD";
			Common.RetriveComboItembySQL(strSQL, cbOTHCD03);
		}

		private void cbOTH04_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT MABDM_BDCOD FROM MABDM_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", NewLateBinding.LateGet(NewLateBinding.LateGet(cbOTH04.Items[cbOTH04.SelectedIndex], null, "Row", new object[0], null, null, null), null, "ItemArray", new object[1] { 1 }, null, null, null)), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MABDM_BDGRP = '", cbOTH04.SelectedValue), "' ")));
			strSQL += "ORDER BY MABDM_ORDSQ";
			cbOTHCD04.ValueMember = "MABDM_BDCOD";
			cbOTHCD04.DisplayMember = "MABDM_BDCOD";
			Common.RetriveComboItembySQL(strSQL, cbOTHCD04);
		}

		private void cbOTH05_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT MABDM_BDCOD FROM MABDM_TBL WITH (NOLOCK) ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE MABDM_CTYID = '", NewLateBinding.LateGet(NewLateBinding.LateGet(cbOTH05.Items[cbOTH05.SelectedIndex], null, "Row", new object[0], null, null, null), null, "ItemArray", new object[1] { 1 }, null, null, null)), "' ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MABDM_BDGRP = '", cbOTH05.SelectedValue), "' ")));
			strSQL += "ORDER BY MABDM_ORDSQ";
			cbOTHCD05.ValueMember = "MABDM_BDCOD";
			cbOTHCD05.DisplayMember = "MABDM_BDCOD";
			Common.RetriveComboItembySQL(strSQL, cbOTHCD05);
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

		private void ClearCPART()
		{
			lkpCPART_CUSID.KeyValue = string.Empty;
			lkpCPART_CUSID.RefreshDescription();
			txtCPART_CPTNO.Text = string.Empty;
			txtCPART_CPTNM.Text = string.Empty;
			txtCPART_REMRK.Text = string.Empty;
			lkpCPART_CUSID.Focus();
		}

		private void btnCancel2_Click(object sender, EventArgs e)
		{
			ClearCPART();
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
	}
}
