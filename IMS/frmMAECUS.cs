using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmMAECUS : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnNEW")]
		private System.Windows.Forms.Button _btnNEW;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSEARCH")]
		private System.Windows.Forms.Button _btnSEARCH;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvMACUS")]
		private DataGridView _dgvMACUS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private System.Windows.Forms.Button _btnPRINTFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDELETE")]
		private System.Windows.Forms.Button _btnDELETE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private System.Windows.Forms.Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private System.Windows.Forms.Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBACK")]
		private System.Windows.Forms.Button _btnBACK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private System.Windows.Forms.Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private System.Windows.Forms.Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSIDTO")]
		private ComboboxControl _cbCUSIDTO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSIDFR")]
		private ComboboxControl _cbCUSIDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoSTICK1")]
		private RadioButton _rdoSTICK1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoSTICK2")]
		private RadioButton _rdoSTICK2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rbBigLabel1")]
		private RadioButton _rbBigLabel1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rbBigLabel2")]
		private RadioButton _rbBigLabel2;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnEXCEL")]
		private System.Windows.Forms.Button _btnEXCEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bgwProgress")]
		private BackgroundWorker _bgwProgress;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		private SqlTransaction Trn;

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblREMRK")]
		internal virtual System.Windows.Forms.Label lblREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtEMAIL")]
		internal virtual System.Windows.Forms.TextBox txtEMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCNTPS")]
		internal virtual System.Windows.Forms.TextBox txtCNTPS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtFAXNO1")]
		internal virtual System.Windows.Forms.TextBox txtFAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTEL02")]
		internal virtual System.Windows.Forms.TextBox txtTEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTEL01")]
		internal virtual System.Windows.Forms.TextBox txtTEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR4")]
		internal virtual System.Windows.Forms.TextBox txtADDR4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR3")]
		internal virtual System.Windows.Forms.TextBox txtADDR3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR2")]
		internal virtual System.Windows.Forms.TextBox txtADDR2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR1")]
		internal virtual System.Windows.Forms.TextBox txtADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCUSNM")]
		internal virtual System.Windows.Forms.TextBox txtCUSNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCNTPS")]
		internal virtual System.Windows.Forms.Label lblCNTPS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblFAX01")]
		internal virtual System.Windows.Forms.Label lblFAX01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTEL02")]
		internal virtual System.Windows.Forms.Label lblTEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTEL01")]
		internal virtual System.Windows.Forms.Label lblTEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTACD")]
		internal virtual System.Windows.Forms.Label lblSTACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCNTRY")]
		internal virtual System.Windows.Forms.Label lblCNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCUSID")]
		internal virtual System.Windows.Forms.Label lblCUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCUSID")]
		internal virtual System.Windows.Forms.TextBox txtCUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCUSNM")]
		internal virtual System.Windows.Forms.Label lblCUSNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblADDR1")]
		internal virtual System.Windows.Forms.Label lblADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblEMAIL")]
		internal virtual System.Windows.Forms.Label lblEMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREMK")]
		internal virtual System.Windows.Forms.TextBox txtREMK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnNEW
		{
			[CompilerGenerated]
			get
			{
				return _btnNEW;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnNEW_Click;
				System.Windows.Forms.Button button = _btnNEW;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnNEW = value;
				button = _btnNEW;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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

		[field: AccessedThroughProperty("TableLayoutPanel2")]
		internal virtual TableLayoutPanel TableLayoutPanel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCUSIDTO")]
		internal virtual System.Windows.Forms.Label lblCUSIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCUSIDFR")]
		internal virtual System.Windows.Forms.Label lblCUSIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvMACUS
		{
			[CompilerGenerated]
			get
			{
				return _dgvMACUS;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvMACUS_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvMACUS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvMACUS = value;
				dataGridView = _dgvMACUS;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Button btnPRINTFR
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
				System.Windows.Forms.Button button = _btnPRINTFR;
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual System.Windows.Forms.Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtFAXNO2")]
		internal virtual System.Windows.Forms.TextBox txtFAXNO2
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual System.Windows.Forms.Label Label1
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual System.Windows.Forms.Label Label3
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

		[field: AccessedThroughProperty("txtGSTID")]
		internal virtual System.Windows.Forms.TextBox txtGSTID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtACCNO")]
		internal virtual System.Windows.Forms.TextBox txtACCNO
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

		internal virtual System.Windows.Forms.Button btnDELETE
		{
			[CompilerGenerated]
			get
			{
				return _btnDELETE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDELETE_Click;
				System.Windows.Forms.Button button = _btnDELETE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDELETE = value;
				button = _btnDELETE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual System.Windows.Forms.Button btnPRINT
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
				System.Windows.Forms.Button button = _btnPRINT;
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

		internal virtual System.Windows.Forms.Button btnSAVE
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
				System.Windows.Forms.Button button = _btnSAVE;
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

		internal virtual System.Windows.Forms.Button btnBACK
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
				System.Windows.Forms.Button button = _btnBACK;
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

		[field: AccessedThroughProperty("chkINTFG")]
		internal virtual System.Windows.Forms.CheckBox chkINTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		internal virtual System.Windows.Forms.Button btnCancel
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
				System.Windows.Forms.Button button = _btnCancel;
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual System.Windows.Forms.Label Label7
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

		[field: AccessedThroughProperty("cbPAYTM")]
		internal virtual ComboBox cbPAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSTACD")]
		internal virtual ComboBox cbSTACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCNTRY")]
		internal virtual ComboBox cbCNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCURCD")]
		internal virtual ComboBox cbCURCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCUSTY")]
		internal virtual ComboBox cbCUSTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbPRCTY")]
		internal virtual ComboBox cbPRCTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbTAXCD")]
		internal virtual ComboBox cbTAXCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbCUSIDTO
		{
			[CompilerGenerated]
			get
			{
				return _cbCUSIDTO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbCUSIDTO_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbCUSIDTO;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbCUSIDTO = value;
				comboboxControl = _cbCUSIDTO;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		internal virtual ComboboxControl cbCUSIDFR
		{
			[CompilerGenerated]
			get
			{
				return _cbCUSIDFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbCUSIDFR_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbCUSIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbCUSIDFR = value;
				comboboxControl = _cbCUSIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("chkAVESL")]
		internal virtual System.Windows.Forms.CheckBox chkAVESL
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

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual RadioButton rdoSTICK1
		{
			[CompilerGenerated]
			get
			{
				return _rdoSTICK1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoSTICK1_CheckedChanged;
				RadioButton radioButton = _rdoSTICK1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoSTICK1 = value;
				radioButton = _rdoSTICK1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rdoSTICK2
		{
			[CompilerGenerated]
			get
			{
				return _rdoSTICK2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoSTICK2_CheckedChanged;
				RadioButton radioButton = _rdoSTICK2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoSTICK2 = value;
				radioButton = _rdoSTICK2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label11")]
		internal virtual System.Windows.Forms.Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSTKQTY")]
		internal virtual NumControl numSTKQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label8")]
		internal virtual System.Windows.Forms.Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtSHORT")]
		internal virtual System.Windows.Forms.TextBox txtSHORT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label12")]
		internal virtual System.Windows.Forms.Label Label12
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

		internal virtual RadioButton rbBigLabel1
		{
			[CompilerGenerated]
			get
			{
				return _rbBigLabel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rbBigLabel1_CheckedChanged;
				RadioButton radioButton = _rbBigLabel1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rbBigLabel1 = value;
				radioButton = _rbBigLabel1;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rbBigLabel2
		{
			[CompilerGenerated]
			get
			{
				return _rbBigLabel2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rbBigLabel2_CheckedChanged;
				RadioButton radioButton = _rbBigLabel2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rbBigLabel2 = value;
				radioButton = _rbBigLabel2;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
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

		internal virtual BackgroundWorker bgwProgress
		{
			[CompilerGenerated]
			get
			{
				return _bgwProgress;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = bgwProgress_DoWork;
				RunWorkerCompletedEventHandler value3 = bgwProgress_RunWorkerCompleted;
				BackgroundWorker backgroundWorker = _bgwProgress;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork -= value2;
					backgroundWorker.RunWorkerCompleted -= value3;
				}
				_bgwProgress = value;
				backgroundWorker = _bgwProgress;
				if (backgroundWorker != null)
				{
					backgroundWorker.DoWork += value2;
					backgroundWorker.RunWorkerCompleted += value3;
				}
			}
		}

		[field: AccessedThroughProperty("Label13")]
		internal virtual System.Windows.Forms.Label Label13
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

		[field: AccessedThroughProperty("MACUS_CUSID")]
		internal virtual DataGridViewTextBoxColumn MACUS_CUSID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_SHORT")]
		internal virtual DataGridViewTextBoxColumn MACUS_SHORT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_CUSNM")]
		internal virtual DataGridViewTextBoxColumn MACUS_CUSNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_ADDR1")]
		internal virtual DataGridViewTextBoxColumn MACUS_ADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Addr")]
		internal virtual DataGridViewTextBoxColumn Addr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_ADDR2")]
		internal virtual DataGridViewTextBoxColumn MACUS_ADDR2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_ADDR3")]
		internal virtual DataGridViewTextBoxColumn MACUS_ADDR3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_ADDR4")]
		internal virtual DataGridViewTextBoxColumn MACUS_ADDR4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_CNTRY")]
		internal virtual DataGridViewTextBoxColumn MACUS_CNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_STACD")]
		internal virtual DataGridViewTextBoxColumn MACUS_STACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_TEL01")]
		internal virtual DataGridViewTextBoxColumn MACUS_TEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_TEL02")]
		internal virtual DataGridViewTextBoxColumn MACUS_TEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_FAXNO1")]
		internal virtual DataGridViewTextBoxColumn MACUS_FAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_FAXNO2")]
		internal virtual DataGridViewTextBoxColumn MACUS_FAXNO2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_CNTPS")]
		internal virtual DataGridViewTextBoxColumn MACUS_CNTPS
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_EMAIL")]
		internal virtual DataGridViewTextBoxColumn MACUS_EMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_CUSTY")]
		internal virtual DataGridViewTextBoxColumn MACUS_CUSTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_PAYTM")]
		internal virtual DataGridViewTextBoxColumn MACUS_PAYTM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_PRCTY")]
		internal virtual DataGridViewTextBoxColumn MACUS_PRCTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_TAXCD")]
		internal virtual DataGridViewTextBoxColumn MACUS_TAXCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_GSTID")]
		internal virtual DataGridViewTextBoxColumn MACUS_GSTID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_ACCNO")]
		internal virtual DataGridViewTextBoxColumn MACUS_ACCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_REMRK")]
		internal virtual DataGridViewTextBoxColumn MACUS_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_INTFG")]
		internal virtual DataGridViewTextBoxColumn MACUS_INTFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_AVESL")]
		internal virtual DataGridViewTextBoxColumn MACUS_AVESL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_CURCD")]
		internal virtual DataGridViewTextBoxColumn MACUS_CURCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_STKFMT")]
		internal virtual DataGridViewTextBoxColumn MACUS_STKFMT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_STKQTY")]
		internal virtual DataGridViewTextBoxColumn MACUS_STKQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("MACUS_LBLFMT")]
		internal virtual DataGridViewTextBoxColumn MACUS_LBLFMT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAECUS()
		{
			base.FormClosing += frmMAECUS_FormClosing;
			base.Shown += frmMAECUS_Shown;
			base.KeyDown += frmMAECUS_KeyDown;
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
			this.numSTKQTY = new IMS.NumControl();
			this.Label11 = new System.Windows.Forms.Label();
			this.chkAVESL = new System.Windows.Forms.CheckBox();
			this.cbTAXCD = new System.Windows.Forms.ComboBox();
			this.cbPRCTY = new System.Windows.Forms.ComboBox();
			this.cbCUSTY = new System.Windows.Forms.ComboBox();
			this.cbCURCD = new System.Windows.Forms.ComboBox();
			this.cbSTACD = new System.Windows.Forms.ComboBox();
			this.cbPAYTM = new System.Windows.Forms.ComboBox();
			this.cbCNTRY = new System.Windows.Forms.ComboBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnDELETE = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnBACK = new System.Windows.Forms.Button();
			this.txtACCNO = new System.Windows.Forms.TextBox();
			this.txtFAXNO2 = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtEMAIL = new System.Windows.Forms.TextBox();
			this.txtCNTPS = new System.Windows.Forms.TextBox();
			this.txtFAXNO1 = new System.Windows.Forms.TextBox();
			this.txtTEL02 = new System.Windows.Forms.TextBox();
			this.txtTEL01 = new System.Windows.Forms.TextBox();
			this.txtADDR4 = new System.Windows.Forms.TextBox();
			this.txtADDR3 = new System.Windows.Forms.TextBox();
			this.txtADDR2 = new System.Windows.Forms.TextBox();
			this.txtADDR1 = new System.Windows.Forms.TextBox();
			this.txtCUSNM = new System.Windows.Forms.TextBox();
			this.lblCNTPS = new System.Windows.Forms.Label();
			this.lblFAX01 = new System.Windows.Forms.Label();
			this.lblTEL02 = new System.Windows.Forms.Label();
			this.lblTEL01 = new System.Windows.Forms.Label();
			this.lblCNTRY = new System.Windows.Forms.Label();
			this.lblCUSID = new System.Windows.Forms.Label();
			this.txtCUSID = new System.Windows.Forms.TextBox();
			this.lblCUSNM = new System.Windows.Forms.Label();
			this.lblADDR1 = new System.Windows.Forms.Label();
			this.lblEMAIL = new System.Windows.Forms.Label();
			this.txtREMK = new System.Windows.Forms.TextBox();
			this.lblSTACD = new System.Windows.Forms.Label();
			this.chkINTFG = new System.Windows.Forms.CheckBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtGSTID = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.rdoSTICK1 = new System.Windows.Forms.RadioButton();
			this.rdoSTICK2 = new System.Windows.Forms.RadioButton();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtSHORT = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.rbBigLabel1 = new System.Windows.Forms.RadioButton();
			this.rbBigLabel2 = new System.Windows.Forms.RadioButton();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.btnNEW = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbCUSIDTO = new IMS.ComboboxControl();
			this.cbCUSIDFR = new IMS.ComboboxControl();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.dgvMACUS = new System.Windows.Forms.DataGridView();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnEXCEL = new System.Windows.Forms.Button();
			this.bgwProgress = new System.ComponentModel.BackgroundWorker();
			this.MACUS_CUSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_SHORT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_CUSNM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_ADDR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_ADDR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_ADDR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_ADDR4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_CNTRY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_STACD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_TEL01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_TEL02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_FAXNO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_FAXNO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_CNTPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_CUSTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_PAYTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_PRCTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_TAXCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_GSTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_ACCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_INTFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_AVESL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_CURCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_STKFMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_STKQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MACUS_LBLFMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMACUS).BeginInit();
			this.Panel1.SuspendLayout();
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
			this.TableLayoutPanel1.Controls.Add(this.numSTKQTY, 3, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 2, 12);
			this.TableLayoutPanel1.Controls.Add(this.chkAVESL, 2, 17);
			this.TableLayoutPanel1.Controls.Add(this.cbTAXCD, 1, 16);
			this.TableLayoutPanel1.Controls.Add(this.cbPRCTY, 1, 15);
			this.TableLayoutPanel1.Controls.Add(this.cbCUSTY, 1, 14);
			this.TableLayoutPanel1.Controls.Add(this.cbCURCD, 3, 14);
			this.TableLayoutPanel1.Controls.Add(this.cbSTACD, 3, 7);
			this.TableLayoutPanel1.Controls.Add(this.cbPAYTM, 3, 15);
			this.TableLayoutPanel1.Controls.Add(this.cbCNTRY, 1, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 2, 15);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 20);
			this.TableLayoutPanel1.Controls.Add(this.txtACCNO, 1, 17);
			this.TableLayoutPanel1.Controls.Add(this.txtFAXNO2, 1, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label1, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 17);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 15);
			this.TableLayoutPanel1.Controls.Add(this.lblREMRK, 0, 18);
			this.TableLayoutPanel1.Controls.Add(this.Label2, 0, 14);
			this.TableLayoutPanel1.Controls.Add(this.txtEMAIL, 1, 13);
			this.TableLayoutPanel1.Controls.Add(this.txtCNTPS, 1, 12);
			this.TableLayoutPanel1.Controls.Add(this.txtFAXNO1, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtTEL02, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.txtTEL01, 1, 8);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR4, 1, 6);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR3, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR2, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.txtADDR1, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtCUSNM, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblCNTPS, 0, 12);
			this.TableLayoutPanel1.Controls.Add(this.lblFAX01, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.lblTEL02, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.lblTEL01, 0, 8);
			this.TableLayoutPanel1.Controls.Add(this.lblCNTRY, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.lblCUSID, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtCUSID, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblCUSNM, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblADDR1, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.lblEMAIL, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.txtREMK, 1, 18);
			this.TableLayoutPanel1.Controls.Add(this.lblSTACD, 2, 7);
			this.TableLayoutPanel1.Controls.Add(this.chkINTFG, 2, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 14);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 2, 16);
			this.TableLayoutPanel1.Controls.Add(this.txtGSTID, 3, 16);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 2, 11);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 3, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtSHORT, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 2, 13);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel6, 3, 13);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 21;
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
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(929, 619);
			this.TableLayoutPanel1.TabIndex = 6;
			this.numSTKQTY.AllowNegative = false;
			this.numSTKQTY.DataChanged = false;
			this.numSTKQTY.Location = new System.Drawing.Point(639, 322);
			this.numSTKQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSTKQTY.Name = "numSTKQTY";
			this.numSTKQTY.NumberFormat = "8.0";
			this.numSTKQTY.Size = new System.Drawing.Size(77, 22);
			this.numSTKQTY.TabIndex = 9;
			this.numSTKQTY.Text = "0";
			this.numSTKQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTKQTY.ThousandSeperator = false;
			this.numSTKQTY.Value = 0.0;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(407, 325);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(100, 16);
			this.Label11.TabIndex = 23;
			this.Label11.Text = "Sticker Quantity";
			this.chkAVESL.AutoSize = true;
			this.chkAVESL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAVESL.Location = new System.Drawing.Point(407, 469);
			this.chkAVESL.Name = "chkAVESL";
			this.chkAVESL.Size = new System.Drawing.Size(85, 20);
			this.chkAVESL.TabIndex = 7;
			this.chkAVESL.Text = "AVE Sale";
			this.chkAVESL.UseVisualStyleBackColor = true;
			this.cbTAXCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTAXCD.FormattingEnabled = true;
			this.cbTAXCD.Location = new System.Drawing.Point(114, 439);
			this.cbTAXCD.Name = "cbTAXCD";
			this.cbTAXCD.Size = new System.Drawing.Size(200, 24);
			this.cbTAXCD.TabIndex = 11;
			this.cbPRCTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPRCTY.FormattingEnabled = true;
			this.cbPRCTY.Location = new System.Drawing.Point(114, 409);
			this.cbPRCTY.Name = "cbPRCTY";
			this.cbPRCTY.Size = new System.Drawing.Size(200, 24);
			this.cbPRCTY.TabIndex = 10;
			this.cbCUSTY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSTY.FormattingEnabled = true;
			this.cbCUSTY.Location = new System.Drawing.Point(114, 379);
			this.cbCUSTY.Name = "cbCUSTY";
			this.cbCUSTY.Size = new System.Drawing.Size(200, 24);
			this.cbCUSTY.TabIndex = 9;
			this.cbCURCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCURCD.FormattingEnabled = true;
			this.cbCURCD.Location = new System.Drawing.Point(639, 379);
			this.cbCURCD.Name = "cbCURCD";
			this.cbCURCD.Size = new System.Drawing.Size(200, 24);
			this.cbCURCD.TabIndex = 8;
			this.cbSTACD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTACD.FormattingEnabled = true;
			this.cbSTACD.Location = new System.Drawing.Point(639, 185);
			this.cbSTACD.Name = "cbSTACD";
			this.cbSTACD.Size = new System.Drawing.Size(214, 24);
			this.cbSTACD.TabIndex = 9;
			this.cbPAYTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPAYTM.FormattingEnabled = true;
			this.cbPAYTM.Location = new System.Drawing.Point(639, 409);
			this.cbPAYTM.Name = "cbPAYTM";
			this.cbPAYTM.Size = new System.Drawing.Size(150, 24);
			this.cbPAYTM.TabIndex = 38;
			this.cbCNTRY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCNTRY.FormattingEnabled = true;
			this.cbCNTRY.Location = new System.Drawing.Point(114, 185);
			this.cbCNTRY.Name = "cbCNTRY";
			this.cbCNTRY.Size = new System.Drawing.Size(214, 24);
			this.cbCNTRY.TabIndex = 8;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(407, 413);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(96, 16);
			this.Label9.TabIndex = 17;
			this.Label9.Text = "Payment Term";
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 5;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 3);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnDELETE, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnPRINT, 4, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnBACK, 3, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 563);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel3.TabIndex = 7;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 25;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnDELETE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDELETE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDELETE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDELETE.Image = IMS.My.Resources.Resources.Delete;
			this.btnDELETE.Location = new System.Drawing.Point(129, 2);
			this.btnDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDELETE.Name = "btnDELETE";
			this.btnDELETE.Size = new System.Drawing.Size(120, 50);
			this.btnDELETE.TabIndex = 24;
			this.btnDELETE.Text = "Delete";
			this.btnDELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDELETE.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(507, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 27;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(3, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 23;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnBACK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBACK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBACK.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBACK.Image = IMS.My.Resources.Resources.Back;
			this.btnBACK.Location = new System.Drawing.Point(381, 2);
			this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBACK.Name = "btnBACK";
			this.btnBACK.Size = new System.Drawing.Size(120, 50);
			this.btnBACK.TabIndex = 26;
			this.btnBACK.Text = "Back";
			this.btnBACK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBACK.UseVisualStyleBackColor = false;
			this.txtACCNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtACCNO.Location = new System.Drawing.Point(114, 468);
			this.txtACCNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtACCNO.Name = "txtACCNO";
			this.txtACCNO.Size = new System.Drawing.Size(287, 22);
			this.txtACCNO.TabIndex = 21;
			this.txtFAXNO2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtFAXNO2.Location = new System.Drawing.Point(114, 294);
			this.txtFAXNO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFAXNO2.Name = "txtFAXNO2";
			this.txtFAXNO2.Size = new System.Drawing.Size(287, 22);
			this.txtFAXNO2.TabIndex = 13;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 297);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(61, 16);
			this.Label1.TabIndex = 18;
			this.Label1.Text = "Fax No 2";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 471);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(77, 16);
			this.Label5.TabIndex = 21;
			this.Label5.Text = "Account No";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 443);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(67, 16);
			this.Label4.TabIndex = 20;
			this.Label4.Text = "Tax Code";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 413);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(74, 16);
			this.Label3.TabIndex = 19;
			this.Label3.Text = "Price Type";
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 508);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(56, 16);
			this.lblREMRK.TabIndex = 18;
			this.lblREMRK.Text = "Remark";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 383);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(100, 16);
			this.Label2.TabIndex = 18;
			this.Label2.Text = "Customer Type";
			this.txtEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtEMAIL.Location = new System.Drawing.Point(114, 350);
			this.txtEMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEMAIL.Name = "txtEMAIL";
			this.txtEMAIL.Size = new System.Drawing.Size(287, 22);
			this.txtEMAIL.TabIndex = 15;
			this.txtCNTPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCNTPS.Location = new System.Drawing.Point(114, 322);
			this.txtCNTPS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCNTPS.Name = "txtCNTPS";
			this.txtCNTPS.Size = new System.Drawing.Size(287, 22);
			this.txtCNTPS.TabIndex = 14;
			this.txtFAXNO1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtFAXNO1.Location = new System.Drawing.Point(114, 266);
			this.txtFAXNO1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFAXNO1.Name = "txtFAXNO1";
			this.txtFAXNO1.Size = new System.Drawing.Size(287, 22);
			this.txtFAXNO1.TabIndex = 12;
			this.txtTEL02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtTEL02.Location = new System.Drawing.Point(114, 240);
			this.txtTEL02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTEL02.Name = "txtTEL02";
			this.txtTEL02.Size = new System.Drawing.Size(287, 22);
			this.txtTEL02.TabIndex = 11;
			this.txtTEL01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtTEL01.Location = new System.Drawing.Point(114, 214);
			this.txtTEL01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTEL01.Name = "txtTEL01";
			this.txtTEL01.Size = new System.Drawing.Size(287, 22);
			this.txtTEL01.TabIndex = 10;
			this.txtADDR4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR4, 2);
			this.txtADDR4.Location = new System.Drawing.Point(114, 158);
			this.txtADDR4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR4.Name = "txtADDR4";
			this.txtADDR4.Size = new System.Drawing.Size(494, 22);
			this.txtADDR4.TabIndex = 7;
			this.txtADDR3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR3, 2);
			this.txtADDR3.Location = new System.Drawing.Point(114, 132);
			this.txtADDR3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR3.Name = "txtADDR3";
			this.txtADDR3.Size = new System.Drawing.Size(494, 22);
			this.txtADDR3.TabIndex = 6;
			this.txtADDR2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR2, 2);
			this.txtADDR2.Location = new System.Drawing.Point(114, 106);
			this.txtADDR2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR2.Name = "txtADDR2";
			this.txtADDR2.Size = new System.Drawing.Size(494, 22);
			this.txtADDR2.TabIndex = 5;
			this.txtADDR1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtADDR1, 2);
			this.txtADDR1.Location = new System.Drawing.Point(114, 80);
			this.txtADDR1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR1.Name = "txtADDR1";
			this.txtADDR1.Size = new System.Drawing.Size(494, 22);
			this.txtADDR1.TabIndex = 4;
			this.txtCUSNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtCUSNM, 2);
			this.txtCUSNM.Location = new System.Drawing.Point(114, 28);
			this.txtCUSNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCUSNM.Name = "txtCUSNM";
			this.txtCUSNM.Size = new System.Drawing.Size(494, 22);
			this.txtCUSNM.TabIndex = 2;
			this.lblCNTPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTPS.AutoSize = true;
			this.lblCNTPS.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTPS.Location = new System.Drawing.Point(3, 325);
			this.lblCNTPS.Name = "lblCNTPS";
			this.lblCNTPS.Size = new System.Drawing.Size(99, 16);
			this.lblCNTPS.TabIndex = 16;
			this.lblCNTPS.Text = "Contact Person";
			this.lblFAX01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFAX01.AutoSize = true;
			this.lblFAX01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFAX01.Location = new System.Drawing.Point(3, 269);
			this.lblFAX01.Name = "lblFAX01";
			this.lblFAX01.Size = new System.Drawing.Size(51, 16);
			this.lblFAX01.TabIndex = 17;
			this.lblFAX01.Text = "Fax No";
			this.lblTEL02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL02.AutoSize = true;
			this.lblTEL02.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL02.Location = new System.Drawing.Point(3, 243);
			this.lblTEL02.Name = "lblTEL02";
			this.lblTEL02.Size = new System.Drawing.Size(38, 16);
			this.lblTEL02.TabIndex = 18;
			this.lblTEL02.Text = "Tel 2";
			this.lblTEL01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL01.AutoSize = true;
			this.lblTEL01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL01.Location = new System.Drawing.Point(3, 217);
			this.lblTEL01.Name = "lblTEL01";
			this.lblTEL01.Size = new System.Drawing.Size(38, 16);
			this.lblTEL01.TabIndex = 19;
			this.lblTEL01.Text = "Tel 1";
			this.lblCNTRY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTRY.AutoSize = true;
			this.lblCNTRY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTRY.Location = new System.Drawing.Point(3, 189);
			this.lblCNTRY.Name = "lblCNTRY";
			this.lblCNTRY.Size = new System.Drawing.Size(53, 16);
			this.lblCNTRY.TabIndex = 9;
			this.lblCNTRY.Text = "Country";
			this.lblCUSID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSID.AutoSize = true;
			this.lblCUSID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSID.Location = new System.Drawing.Point(3, 5);
			this.lblCUSID.Name = "lblCUSID";
			this.lblCUSID.Size = new System.Drawing.Size(81, 16);
			this.lblCUSID.TabIndex = 7;
			this.lblCUSID.Text = "Customer ID";
			this.txtCUSID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCUSID.Location = new System.Drawing.Point(114, 2);
			this.txtCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCUSID.Name = "txtCUSID";
			this.txtCUSID.Size = new System.Drawing.Size(287, 22);
			this.txtCUSID.TabIndex = 1;
			this.lblCUSNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSNM.AutoSize = true;
			this.lblCUSNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSNM.Location = new System.Drawing.Point(3, 31);
			this.lblCUSNM.Name = "lblCUSNM";
			this.lblCUSNM.Size = new System.Drawing.Size(105, 16);
			this.lblCUSNM.TabIndex = 14;
			this.lblCUSNM.Text = "Customer Name";
			this.lblADDR1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblADDR1.AutoSize = true;
			this.lblADDR1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblADDR1.Location = new System.Drawing.Point(3, 83);
			this.lblADDR1.Name = "lblADDR1";
			this.lblADDR1.Size = new System.Drawing.Size(69, 16);
			this.lblADDR1.TabIndex = 13;
			this.lblADDR1.Text = "Address 1";
			this.lblEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEMAIL.AutoSize = true;
			this.lblEMAIL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEMAIL.Location = new System.Drawing.Point(3, 353);
			this.lblEMAIL.Name = "lblEMAIL";
			this.lblEMAIL.Size = new System.Drawing.Size(42, 16);
			this.lblEMAIL.TabIndex = 17;
			this.lblEMAIL.Text = "Email";
			this.txtREMK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMK, 2);
			this.txtREMK.Location = new System.Drawing.Point(114, 494);
			this.txtREMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMK.Multiline = true;
			this.txtREMK.Name = "txtREMK";
			this.txtREMK.Size = new System.Drawing.Size(494, 45);
			this.txtREMK.TabIndex = 22;
			this.lblSTACD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTACD.AutoSize = true;
			this.lblSTACD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTACD.Location = new System.Drawing.Point(407, 189);
			this.lblSTACD.Name = "lblSTACD";
			this.lblSTACD.Size = new System.Drawing.Size(39, 16);
			this.lblSTACD.TabIndex = 8;
			this.lblSTACD.Text = "State";
			this.chkINTFG.AutoSize = true;
			this.chkINTFG.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkINTFG.Location = new System.Drawing.Point(407, 241);
			this.chkINTFG.Name = "chkINTFG";
			this.chkINTFG.Size = new System.Drawing.Size(110, 20);
			this.chkINTFG.TabIndex = 9;
			this.chkINTFG.Text = "Data Interface";
			this.chkINTFG.UseVisualStyleBackColor = true;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(407, 383);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(61, 16);
			this.Label7.TabIndex = 20;
			this.Label7.Text = "Currency";
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(407, 443);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(52, 16);
			this.Label6.TabIndex = 22;
			this.Label6.Text = "GST ID";
			this.txtGSTID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtGSTID.Location = new System.Drawing.Point(639, 440);
			this.txtGSTID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGSTID.Name = "txtGSTID";
			this.txtGSTID.Size = new System.Drawing.Size(287, 22);
			this.txtGSTID.TabIndex = 20;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(407, 297);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(94, 16);
			this.Label10.TabIndex = 22;
			this.Label10.Text = "Sticker Format";
			this.TableLayoutPanel5.ColumnCount = 2;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.rdoSTICK1, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.rdoSTICK2, 1, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(639, 293);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(77, 24);
			this.TableLayoutPanel5.TabIndex = 7;
			this.rdoSTICK1.AutoSize = true;
			this.rdoSTICK1.Checked = true;
			this.rdoSTICK1.Location = new System.Drawing.Point(3, 3);
			this.rdoSTICK1.Name = "rdoSTICK1";
			this.rdoSTICK1.Size = new System.Drawing.Size(33, 20);
			this.rdoSTICK1.TabIndex = 0;
			this.rdoSTICK1.TabStop = true;
			this.rdoSTICK1.Text = "1";
			this.rdoSTICK1.UseVisualStyleBackColor = true;
			this.rdoSTICK2.AutoSize = true;
			this.rdoSTICK2.Location = new System.Drawing.Point(42, 3);
			this.rdoSTICK2.Name = "rdoSTICK2";
			this.rdoSTICK2.Size = new System.Drawing.Size(33, 20);
			this.rdoSTICK2.TabIndex = 1;
			this.rdoSTICK2.Text = "2";
			this.rdoSTICK2.UseVisualStyleBackColor = true;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 57);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(79, 16);
			this.Label8.TabIndex = 39;
			this.Label8.Text = "Short Name";
			this.txtSHORT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtSHORT.Location = new System.Drawing.Point(114, 54);
			this.txtSHORT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtSHORT.Name = "txtSHORT";
			this.txtSHORT.Size = new System.Drawing.Size(287, 22);
			this.txtSHORT.TabIndex = 3;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(407, 353);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(113, 16);
			this.Label12.TabIndex = 40;
			this.Label12.Text = " Big Label Format";
			this.TableLayoutPanel6.ColumnCount = 2;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.rbBigLabel1, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.rbBigLabel2, 1, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(639, 349);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(77, 24);
			this.TableLayoutPanel6.TabIndex = 41;
			this.rbBigLabel1.AutoSize = true;
			this.rbBigLabel1.Checked = true;
			this.rbBigLabel1.Location = new System.Drawing.Point(3, 3);
			this.rbBigLabel1.Name = "rbBigLabel1";
			this.rbBigLabel1.Size = new System.Drawing.Size(33, 20);
			this.rbBigLabel1.TabIndex = 0;
			this.rbBigLabel1.TabStop = true;
			this.rbBigLabel1.Text = "1";
			this.rbBigLabel1.UseVisualStyleBackColor = true;
			this.rbBigLabel2.AutoSize = true;
			this.rbBigLabel2.Location = new System.Drawing.Point(42, 3);
			this.rbBigLabel2.Name = "rbBigLabel2";
			this.rbBigLabel2.Size = new System.Drawing.Size(33, 20);
			this.rbBigLabel2.TabIndex = 1;
			this.rbBigLabel2.Text = "2";
			this.rbBigLabel2.UseVisualStyleBackColor = true;
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(255, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTFR.TabIndex = 5;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
			this.btnNEW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNEW.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNEW.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNEW.Image = IMS.My.Resources.Resources._New;
			this.btnNEW.Location = new System.Drawing.Point(129, 2);
			this.btnNEW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnNEW.Name = "btnNEW";
			this.btnNEW.Size = new System.Drawing.Size(120, 50);
			this.btnNEW.TabIndex = 4;
			this.btnNEW.Text = "New";
			this.btnNEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNEW.UseVisualStyleBackColor = false;
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
			this.btnSEARCH.TabIndex = 3;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label13, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label14, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 3, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 2;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(780, 50);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbCUSIDTO.BlankValue = null;
			this.cbCUSIDTO.ComboboxWidth = 170;
			this.cbCUSIDTO.DataTable = null;
			this.cbCUSIDTO.DisplayMember = null;
			this.cbCUSIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDTO.HasBlankValue = true;
			this.cbCUSIDTO.Location = new System.Drawing.Point(452, 2);
			this.cbCUSIDTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbCUSIDTO.Name = "cbCUSIDTO";
			this.cbCUSIDTO.SelectedIndex = -1;
			this.cbCUSIDTO.SelectedItem = null;
			this.cbCUSIDTO.SelectedValue = null;
			this.cbCUSIDTO.Size = new System.Drawing.Size(324, 26);
			this.cbCUSIDTO.TabIndex = 10;
			this.cbCUSIDTO.TextMultiline = true;
			this.cbCUSIDTO.ValueMember = null;
			this.cbCUSIDTO.WhereClause = null;
			this.cbCUSIDFR.BlankValue = null;
			this.cbCUSIDFR.ComboboxWidth = 170;
			this.cbCUSIDFR.DataTable = null;
			this.cbCUSIDFR.DisplayMember = null;
			this.cbCUSIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDFR.HasBlankValue = true;
			this.cbCUSIDFR.Location = new System.Drawing.Point(90, 2);
			this.cbCUSIDFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCUSIDFR.Name = "cbCUSIDFR";
			this.cbCUSIDFR.SelectedIndex = -1;
			this.cbCUSIDFR.SelectedItem = null;
			this.cbCUSIDFR.SelectedValue = null;
			this.cbCUSIDFR.Size = new System.Drawing.Size(324, 26);
			this.cbCUSIDFR.TabIndex = 9;
			this.cbCUSIDFR.TextMultiline = true;
			this.cbCUSIDFR.ValueMember = null;
			this.cbCUSIDFR.WhereClause = null;
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(90, 32);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(67, 16);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "CUSIDFR";
			this.lblCUSIDFR.Visible = false;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 7);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(81, 16);
			this.Label13.TabIndex = 11;
			this.Label13.Text = "Customer ID";
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(420, 7);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(25, 16);
			this.Label14.TabIndex = 12;
			this.Label14.Text = "To";
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(451, 32);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(68, 16);
			this.lblCUSIDTO.TabIndex = 3;
			this.lblCUSIDTO.Text = "CUSIDTO";
			this.lblCUSIDTO.Visible = false;
			this.dgvMACUS.AllowUserToAddRows = false;
			this.dgvMACUS.AllowUserToDeleteRows = false;
			this.dgvMACUS.AllowUserToResizeRows = false;
			this.dgvMACUS.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvMACUS.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvMACUS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMACUS.Columns.AddRange(this.MACUS_CUSID, this.MACUS_SHORT, this.MACUS_CUSNM, this.MACUS_ADDR1, this.Addr, this.MACUS_ADDR2, this.MACUS_ADDR3, this.MACUS_ADDR4, this.MACUS_CNTRY, this.MACUS_STACD, this.MACUS_TEL01, this.MACUS_TEL02, this.MACUS_FAXNO1, this.MACUS_FAXNO2, this.MACUS_CNTPS, this.MACUS_EMAIL, this.MACUS_CUSTY, this.MACUS_PAYTM, this.MACUS_PRCTY, this.MACUS_TAXCD, this.MACUS_GSTID, this.MACUS_ACCNO, this.MACUS_REMRK, this.MACUS_INTFG, this.MACUS_AVESL, this.MACUS_CURCD, this.MACUS_STKFMT, this.MACUS_STKQTY, this.MACUS_LBLFMT);
			this.dgvMACUS.Location = new System.Drawing.Point(5, 118);
			this.dgvMACUS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvMACUS.MultiSelect = false;
			this.dgvMACUS.Name = "dgvMACUS";
			this.dgvMACUS.ReadOnly = true;
			this.dgvMACUS.RowHeadersVisible = false;
			this.dgvMACUS.RowHeadersWidth = 20;
			this.dgvMACUS.RowTemplate.Height = 24;
			this.dgvMACUS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMACUS.Size = new System.Drawing.Size(1316, 504);
			this.dgvMACUS.TabIndex = 0;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1346, 630);
			this.Panel1.TabIndex = 8;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BackColor = System.Drawing.Color.AliceBlue;
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Controls.Add(this.dgvMACUS);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1346, 630);
			this.Panel2.TabIndex = 9;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 5;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 4, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNEW, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnEXCEL, 3, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 2, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 61);
			this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel4.TabIndex = 8;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(507, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 6;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnEXCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEXCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnEXCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEXCEL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnEXCEL.Image = IMS.My.Resources.Resources.Excel;
			this.btnEXCEL.Location = new System.Drawing.Point(381, 2);
			this.btnEXCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEXCEL.Name = "btnEXCEL";
			this.btnEXCEL.Size = new System.Drawing.Size(120, 50);
			this.btnEXCEL.TabIndex = 53;
			this.btnEXCEL.Text = "Excel";
			this.btnEXCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEXCEL.UseVisualStyleBackColor = false;
			this.MACUS_CUSID.HeaderText = "Customer ID";
			this.MACUS_CUSID.Name = "MACUS_CUSID";
			this.MACUS_CUSID.ReadOnly = true;
			this.MACUS_CUSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_CUSID.Width = 150;
			this.MACUS_SHORT.HeaderText = "Short Name";
			this.MACUS_SHORT.Name = "MACUS_SHORT";
			this.MACUS_SHORT.ReadOnly = true;
			this.MACUS_SHORT.Width = 200;
			this.MACUS_CUSNM.HeaderText = "Customer Name";
			this.MACUS_CUSNM.Name = "MACUS_CUSNM";
			this.MACUS_CUSNM.ReadOnly = true;
			this.MACUS_CUSNM.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_CUSNM.Visible = false;
			this.MACUS_ADDR1.HeaderText = "Address 1";
			this.MACUS_ADDR1.Name = "MACUS_ADDR1";
			this.MACUS_ADDR1.ReadOnly = true;
			this.MACUS_ADDR1.Visible = false;
			this.MACUS_ADDR1.Width = 200;
			this.Addr.HeaderText = "Address";
			this.Addr.Name = "Addr";
			this.Addr.ReadOnly = true;
			this.Addr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Addr.Width = 350;
			this.MACUS_ADDR2.HeaderText = "Address 2";
			this.MACUS_ADDR2.Name = "MACUS_ADDR2";
			this.MACUS_ADDR2.ReadOnly = true;
			this.MACUS_ADDR2.Visible = false;
			this.MACUS_ADDR3.HeaderText = "Address 3";
			this.MACUS_ADDR3.Name = "MACUS_ADDR3";
			this.MACUS_ADDR3.ReadOnly = true;
			this.MACUS_ADDR3.Visible = false;
			this.MACUS_ADDR4.HeaderText = "Address 4";
			this.MACUS_ADDR4.Name = "MACUS_ADDR4";
			this.MACUS_ADDR4.ReadOnly = true;
			this.MACUS_ADDR4.Visible = false;
			this.MACUS_CNTRY.HeaderText = "Country";
			this.MACUS_CNTRY.Name = "MACUS_CNTRY";
			this.MACUS_CNTRY.ReadOnly = true;
			this.MACUS_CNTRY.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_STACD.HeaderText = "State";
			this.MACUS_STACD.Name = "MACUS_STACD";
			this.MACUS_STACD.ReadOnly = true;
			this.MACUS_STACD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_TEL01.HeaderText = "Tel 1";
			this.MACUS_TEL01.Name = "MACUS_TEL01";
			this.MACUS_TEL01.ReadOnly = true;
			this.MACUS_TEL01.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_TEL02.HeaderText = "Tel 2";
			this.MACUS_TEL02.Name = "MACUS_TEL02";
			this.MACUS_TEL02.ReadOnly = true;
			this.MACUS_TEL02.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_FAXNO1.HeaderText = "Fax No 1";
			this.MACUS_FAXNO1.Name = "MACUS_FAXNO1";
			this.MACUS_FAXNO1.ReadOnly = true;
			this.MACUS_FAXNO1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_FAXNO2.HeaderText = "Fax No 2";
			this.MACUS_FAXNO2.Name = "MACUS_FAXNO2";
			this.MACUS_FAXNO2.ReadOnly = true;
			this.MACUS_CNTPS.HeaderText = "Contact Person";
			this.MACUS_CNTPS.Name = "MACUS_CNTPS";
			this.MACUS_CNTPS.ReadOnly = true;
			this.MACUS_CNTPS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_CNTPS.Width = 120;
			this.MACUS_EMAIL.HeaderText = "Email";
			this.MACUS_EMAIL.Name = "MACUS_EMAIL";
			this.MACUS_EMAIL.ReadOnly = true;
			this.MACUS_EMAIL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_CUSTY.HeaderText = "Customer Type";
			this.MACUS_CUSTY.Name = "MACUS_CUSTY";
			this.MACUS_CUSTY.ReadOnly = true;
			this.MACUS_CUSTY.Visible = false;
			this.MACUS_CUSTY.Width = 120;
			this.MACUS_PAYTM.HeaderText = "Payment Term";
			this.MACUS_PAYTM.Name = "MACUS_PAYTM";
			this.MACUS_PAYTM.ReadOnly = true;
			this.MACUS_PAYTM.Visible = false;
			this.MACUS_PAYTM.Width = 120;
			this.MACUS_PRCTY.HeaderText = "Price Type";
			this.MACUS_PRCTY.Name = "MACUS_PRCTY";
			this.MACUS_PRCTY.ReadOnly = true;
			this.MACUS_TAXCD.HeaderText = "Tax Code";
			this.MACUS_TAXCD.Name = "MACUS_TAXCD";
			this.MACUS_TAXCD.ReadOnly = true;
			this.MACUS_GSTID.HeaderText = "GST ID";
			this.MACUS_GSTID.Name = "MACUS_GSTID";
			this.MACUS_GSTID.ReadOnly = true;
			this.MACUS_GSTID.Visible = false;
			this.MACUS_ACCNO.HeaderText = "Account No";
			this.MACUS_ACCNO.Name = "MACUS_ACCNO";
			this.MACUS_ACCNO.ReadOnly = true;
			this.MACUS_REMRK.HeaderText = "Remarks";
			this.MACUS_REMRK.Name = "MACUS_REMRK";
			this.MACUS_REMRK.ReadOnly = true;
			this.MACUS_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.MACUS_REMRK.Width = 250;
			this.MACUS_INTFG.HeaderText = "Data Interface";
			this.MACUS_INTFG.Name = "MACUS_INTFG";
			this.MACUS_INTFG.ReadOnly = true;
			this.MACUS_INTFG.Visible = false;
			this.MACUS_AVESL.HeaderText = "MACUS_AVESL";
			this.MACUS_AVESL.Name = "MACUS_AVESL";
			this.MACUS_AVESL.ReadOnly = true;
			this.MACUS_AVESL.Visible = false;
			this.MACUS_CURCD.HeaderText = "Currency";
			this.MACUS_CURCD.Name = "MACUS_CURCD";
			this.MACUS_CURCD.ReadOnly = true;
			this.MACUS_CURCD.Visible = false;
			this.MACUS_STKFMT.HeaderText = "Sticker Format";
			this.MACUS_STKFMT.Name = "MACUS_STKFMT";
			this.MACUS_STKFMT.ReadOnly = true;
			this.MACUS_STKFMT.Visible = false;
			this.MACUS_STKQTY.HeaderText = "Sticker Quantity";
			this.MACUS_STKQTY.Name = "MACUS_STKQTY";
			this.MACUS_STKQTY.ReadOnly = true;
			this.MACUS_STKQTY.Visible = false;
			this.MACUS_LBLFMT.HeaderText = "Label Format";
			this.MACUS_LBLFMT.Name = "MACUS_LBLFMT";
			this.MACUS_LBLFMT.ReadOnly = true;
			this.MACUS_LBLFMT.Visible = false;
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
			base.Name = "frmMAECUS";
			base.Tag = "MAECUS";
			this.Text = "Customer";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel6.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMACUS).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		public bool SaveRecord()
		{
			string query = string.Empty;
			bool SaveRecord = default(bool);
			checked
			{
				if (ValidateDetailControl())
				{
					int STKFMT = default(int);
					if (rdoSTICK1.Checked)
					{
						STKFMT = 1;
					}
					if (rdoSTICK2.Checked)
					{
						STKFMT = 2;
					}
					int LBLFMT = default(int);
					if (rbBigLabel1.Checked)
					{
						LBLFMT = 1;
					}
					if (rbBigLabel2.Checked)
					{
						LBLFMT = 2;
					}
					if (Operators.ConditionalCompareObjectEqual(btnSAVE.Tag, "Save", false))
					{
						query += "INSERT INTO MACUS_TBL (MACUS_CUSID, MACUS_CUSNM, MACUS_SHORT, MACUS_ADDR1, MACUS_ADDR2, MACUS_ADDR3, ";
						query += "MACUS_ADDR4, MACUS_CNTRY, MACUS_STACD, MACUS_TEL01, MACUS_TEL02, ";
						query += "MACUS_FAXNO1, MACUS_FAXNO2, MACUS_CNTPS, MACUS_EMAIL, MACUS_CUSTY, MACUS_PAYTM, ";
						query += "MACUS_PRCTY, MACUS_CURCD, MACUS_TAXCD, MACUS_GSTID, MACUS_ACCNO, MACUS_REMRK, ";
						query += "MACUS_ENTDT, MACUS_ENTBY, MACUS_LUPDT, MACUS_LUPBY, MACUS_INTFG, MACUS_AVESL, ";
						query += "MACUS_STKFMT, MACUS_STKQTY, MACUS_LBLFMT) ";
						query += "VALUES (";
						query = query + "'" + txtCUSID.Text + "', ";
						query = query + "N'" + txtCUSNM.Text + "', ";
						query = query + "N'" + txtSHORT.Text + "', ";
						query = query + "N'" + txtADDR1.Text + "', ";
						query = query + "N'" + txtADDR2.Text + "', ";
						query = query + "N'" + txtADDR3.Text + "', ";
						query = query + "N'" + txtADDR4.Text + "', ";
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCNTRY.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSTACD.SelectedValue), "', ")));
						query = query + "'" + txtTEL01.Text + "', ";
						query = query + "'" + txtTEL02.Text + "', ";
						query = query + "'" + txtFAXNO1.Text + "', ";
						query = query + "'" + txtFAXNO2.Text + "', ";
						query = query + "'" + txtCNTPS.Text + "', ";
						query = query + "'" + txtEMAIL.Text + "', ";
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSTY.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPAYTM.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPRCTY.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCURCD.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject(" '", cbTAXCD.SelectedValue), "', ")));
						query = query + "'" + txtGSTID.Text + "', ";
						query = query + "'" + txtACCNO.Text + "', ";
						query = query + "N'" + txtREMK.Text + "', ";
						query = query + "'" + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "', ";
						query = query + "'" + PublicVar.gstrLogonID + "', ";
						query = query + "'" + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "', ";
						query = query + "'" + PublicVar.gstrLogonID + "',";
						query = query + "'" + Conversions.ToString(unchecked(0 - (chkINTFG.Checked ? 1 : 0)) * -1) + "', ";
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(chkAVESL.Checked, 1, 0)), "', ")));
						query = query + "'" + Conversions.ToString(STKFMT) + "', ";
						query = query + "'" + Conversions.ToString(Conversion.Val(numSTKQTY.Value)) + "', ";
						query = query + "'" + Conversions.ToString(LBLFMT) + "')";
					}
					else
					{
						query += "UPDATE MACUS_TBL SET ";
						query = query + "MACUS_CUSNM = N'" + txtCUSNM.Text + "', ";
						query = query + "MACUS_SHORT = N'" + txtSHORT.Text + "', ";
						query = query + "MACUS_ADDR1 = N'" + txtADDR1.Text + "', ";
						query = query + "MACUS_ADDR2 = N'" + txtADDR2.Text + "', ";
						query = query + "MACUS_ADDR3 = N'" + txtADDR3.Text + "', ";
						query = query + "MACUS_ADDR4 = N'" + txtADDR4.Text + "', ";
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CNTRY = '", cbCNTRY.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_STACD = '", cbSTACD.SelectedValue), "', ")));
						query = query + "MACUS_TEL01 = '" + txtTEL01.Text + "', ";
						query = query + "MACUS_TEL02 = '" + txtTEL02.Text + "', ";
						query = query + "MACUS_FAXNO1 = '" + txtFAXNO1.Text + "', ";
						query = query + "MACUS_FAXNO2 = '" + txtFAXNO2.Text + "', ";
						query = query + "MACUS_CNTPS = '" + txtCNTPS.Text + "', ";
						query = query + "MACUS_EMAIL = '" + txtEMAIL.Text + "', ";
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CUSTY = '", cbCUSTY.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_PAYTM = '", cbPAYTM.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_PRCTY = '", cbPRCTY.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_CURCD = '", cbCURCD.SelectedValue), "', ")));
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_TAXCD = '", cbTAXCD.SelectedValue), "', ")));
						query = query + "MACUS_GSTID = '" + txtGSTID.Text + "', ";
						query = query + "MACUS_ACCNO = '" + txtACCNO.Text + "', ";
						query = query + "MACUS_REMRK = N'" + txtREMK.Text + "', ";
						query = query + "MACUS_INTFG = '" + Conversions.ToString(unchecked(0 - (chkINTFG.Checked ? 1 : 0)) * -1) + "', ";
						query = Conversions.ToString(Operators.ConcatenateObject(query, Operators.ConcatenateObject(Operators.ConcatenateObject("MACUS_AVESL = '", Interaction.IIf(chkAVESL.Checked, 1, 0)), "', ")));
						query = query + "MACUS_STKFMT = '" + Conversions.ToString(STKFMT) + "', ";
						query = query + "MACUS_STKQTY = '" + Conversions.ToString(Conversion.Val(numSTKQTY.Value)) + "', ";
						query = query + "MACUS_LBLFMT = '" + Conversions.ToString(LBLFMT) + "', ";
						query = query + "MACUS_LUPBY = '" + PublicVar.gstrLogonID + "', ";
						query = query + "MACUS_LUPDT = '" + DateTime.Now.ToString("dd MMM yyyy HH:mm:ss") + "' ";
						query = query + "WHERE MACUS_CUSID = '" + txtCUSID.Text + "'";
					}
					try
					{
						cmd.Connection = DB.GetDBConnection();
						cmd.CommandText = query;
						int intAffected = cmd.ExecuteNonQuery();
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record saved!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception ex = ex2;
						MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						SaveRecord = false;
						ProjectData.ClearProjectError();
						goto IL_098f;
					}
					ClearDetails();
					Header();
					SaveRecord = true;
				}
				goto IL_098f;
			}
			IL_098f:
			return SaveRecord;
		}

		private void BindComboHeader()
		{
			cbCUSIDFR.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSIDFR.ValueMember = "MACUS_CUSID";
			cbCUSIDFR.DisplayMember = "MACUS_SHORT";
			cbCUSIDFR.LoadData();
			cbCUSIDTO.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSIDTO.ValueMember = "MACUS_CUSID";
			cbCUSIDTO.DisplayMember = "MACUS_SHORT";
			cbCUSIDTO.LoadData();
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			SaveRecord();
		}

		private void frmMAECUS_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAECUS_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Header();
		}

		private void Header()
		{
			int count = dgvMACUS.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvMACUS.Rows.Remove(dgvMACUS.Rows[0]);
				}
				string strSQL = "EXEC spMACUS '0', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDTO.SelectedValue), "'")));
				System.Data.DataTable dt = DB.ExecProc(strSQL);
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dgvMACUS.ClearSelection();
					dgvMACUS.Rows.Add();
					DataGridViewRow dataGridViewRow = dgvMACUS.Rows[dgvMACUS.Rows.Count - 1];
					dataGridViewRow.Cells["MACUS_CUSID"].Value = dt.Rows[i]["MACUS_CUSID"].ToString();
					dataGridViewRow.Cells["MACUS_CUSNM"].Value = dt.Rows[i]["MACUS_CUSNM"].ToString();
					dataGridViewRow.Cells["MACUS_SHORT"].Value = dt.Rows[i]["MACUS_SHORT"].ToString();
					dataGridViewRow.Cells["ADDR"].Value = dt.Rows[i]["ADDR"].ToString();
					dataGridViewRow.Cells["MACUS_ADDR1"].Value = dt.Rows[i]["MACUS_ADDR1"].ToString();
					dataGridViewRow.Cells["MACUS_ADDR2"].Value = dt.Rows[i]["MACUS_ADDR2"].ToString();
					dataGridViewRow.Cells["MACUS_ADDR3"].Value = dt.Rows[i]["MACUS_ADDR3"].ToString();
					dataGridViewRow.Cells["MACUS_ADDR4"].Value = dt.Rows[i]["MACUS_ADDR4"].ToString();
					dataGridViewRow.Cells["MACUS_CNTRY"].Value = dt.Rows[i]["MACUS_CNTRY"].ToString();
					dataGridViewRow.Cells["MACUS_STACD"].Value = dt.Rows[i]["MACUS_STACD"].ToString();
					dataGridViewRow.Cells["MACUS_TEL01"].Value = dt.Rows[i]["MACUS_TEL01"].ToString();
					dataGridViewRow.Cells["MACUS_TEL02"].Value = dt.Rows[i]["MACUS_TEL02"].ToString();
					dataGridViewRow.Cells["MACUS_FAXNO1"].Value = dt.Rows[i]["MACUS_FAXNO1"].ToString();
					dataGridViewRow.Cells["MACUS_FAXNO2"].Value = dt.Rows[i]["MACUS_FAXNO2"].ToString();
					dataGridViewRow.Cells["MACUS_CNTPS"].Value = dt.Rows[i]["MACUS_CNTPS"].ToString();
					dataGridViewRow.Cells["MACUS_EMAIL"].Value = dt.Rows[i]["MACUS_EMAIL"].ToString();
					dataGridViewRow.Cells["MACUS_CUSTY"].Value = dt.Rows[i]["MACUS_CUSTY"].ToString();
					dataGridViewRow.Cells["MACUS_PAYTM"].Value = dt.Rows[i]["MACUS_PAYTM"].ToString();
					dataGridViewRow.Cells["MACUS_PRCTY"].Value = dt.Rows[i]["MACUS_PRCTY"].ToString();
					dataGridViewRow.Cells["MACUS_CURCD"].Value = dt.Rows[i]["MACUS_CURCD"].ToString();
					dataGridViewRow.Cells["MACUS_TAXCD"].Value = dt.Rows[i]["MACUS_TAXCD"].ToString();
					dataGridViewRow.Cells["MACUS_GSTID"].Value = dt.Rows[i]["MACUS_GSTID"].ToString();
					dataGridViewRow.Cells["MACUS_ACCNO"].Value = dt.Rows[i]["MACUS_ACCNO"].ToString();
					dataGridViewRow.Cells["MACUS_REMRK"].Value = dt.Rows[i]["MACUS_REMRK"].ToString();
					dataGridViewRow.Cells["MACUS_INTFG"].Value = dt.Rows[i]["MACUS_INTFG"].ToString();
					dataGridViewRow.Cells["MACUS_AVESL"].Value = dt.Rows[i]["MACUS_AVESL"].ToString();
					dataGridViewRow.Cells["MACUS_STKFMT"].Value = dt.Rows[i]["MACUS_STKFMT"].ToString();
					dataGridViewRow.Cells["MACUS_STKQTY"].Value = dt.Rows[i]["MACUS_STKQTY"].ToString();
					dataGridViewRow.Cells["MACUS_LBLFMT"].Value = dt.Rows[i]["MACUS_LBLFMT"].ToString();
					dataGridViewRow = null;
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void BindGridToControls()
		{
			txtCUSID.Text = dgvMACUS.CurrentRow.Cells["MACUS_CUSID"].Value.ToString();
			txtCUSNM.Text = dgvMACUS.CurrentRow.Cells["MACUS_CUSNM"].Value.ToString();
			txtSHORT.Text = dgvMACUS.CurrentRow.Cells["MACUS_SHORT"].Value.ToString();
			txtREMK.Text = dgvMACUS.CurrentRow.Cells["MACUS_REMRK"].Value.ToString();
			txtADDR1.Text = dgvMACUS.CurrentRow.Cells["MACUS_ADDR1"].Value.ToString();
			txtADDR2.Text = dgvMACUS.CurrentRow.Cells["MACUS_ADDR2"].Value.ToString();
			txtADDR3.Text = dgvMACUS.CurrentRow.Cells["MACUS_ADDR3"].Value.ToString();
			txtADDR4.Text = dgvMACUS.CurrentRow.Cells["MACUS_ADDR4"].Value.ToString();
			cbCNTRY.SelectedValue = dgvMACUS.CurrentRow.Cells["MACUS_CNTRY"].Value.ToString();
			cbSTACD.SelectedValue = dgvMACUS.CurrentRow.Cells["MACUS_STACD"].Value.ToString();
			txtTEL01.Text = dgvMACUS.CurrentRow.Cells["MACUS_TEL01"].Value.ToString();
			txtTEL02.Text = dgvMACUS.CurrentRow.Cells["MACUS_TEL02"].Value.ToString();
			txtFAXNO1.Text = dgvMACUS.CurrentRow.Cells["MACUS_FAXNO1"].Value.ToString();
			txtFAXNO2.Text = dgvMACUS.CurrentRow.Cells["MACUS_FAXNO2"].Value.ToString();
			txtCNTPS.Text = dgvMACUS.CurrentRow.Cells["MACUS_CNTPS"].Value.ToString();
			cbCUSTY.SelectedValue = dgvMACUS.CurrentRow.Cells["MACUS_CUSTY"].Value.ToString();
			cbPAYTM.SelectedValue = dgvMACUS.CurrentRow.Cells["MACUS_PAYTM"].Value.ToString();
			cbPRCTY.SelectedValue = dgvMACUS.CurrentRow.Cells["MACUS_PRCTY"].Value.ToString();
			cbCURCD.SelectedValue = dgvMACUS.CurrentRow.Cells["MACUS_CURCD"].Value.ToString();
			cbTAXCD.SelectedValue = dgvMACUS.CurrentRow.Cells["MACUS_TAXCD"].Value.ToString();
			txtGSTID.Text = dgvMACUS.CurrentRow.Cells["MACUS_GSTID"].Value.ToString();
			txtACCNO.Text = dgvMACUS.CurrentRow.Cells["MACUS_ACCNO"].Value.ToString();
			txtEMAIL.Text = dgvMACUS.CurrentRow.Cells["MACUS_EMAIL"].Value.ToString();
			chkINTFG.Checked = Conversions.ToBoolean(dgvMACUS.CurrentRow.Cells["MACUS_INTFG"].Value.ToString());
			chkAVESL.Checked = Conversions.ToBoolean(dgvMACUS.CurrentRow.Cells["MACUS_AVESL"].Value.ToString());
			numSTKQTY.Value = Conversions.ToDouble(dgvMACUS.CurrentRow.Cells["MACUS_STKQTY"].Value.ToString());
			object value = dgvMACUS.CurrentRow.Cells["MACUS_STKFMT"].Value;
			if (Operators.ConditionalCompareObjectEqual(value, 1, false))
			{
				rdoSTICK1.Checked = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(value, 2, false))
			{
				rdoSTICK2.Checked = true;
			}
			object value2 = dgvMACUS.CurrentRow.Cells["MACUS_LBLFMT"].Value;
			if (Operators.ConditionalCompareObjectEqual(value2, 1, false))
			{
				rbBigLabel1.Checked = true;
			}
			else if (Operators.ConditionalCompareObjectEqual(value2, 2, false))
			{
				rbBigLabel2.Checked = true;
			}
		}

		public void ClearDetails()
		{
			txtCUSID.Text = string.Empty;
			txtCUSNM.Text = string.Empty;
			txtSHORT.Text = string.Empty;
			txtREMK.Text = string.Empty;
			txtADDR1.Text = string.Empty;
			txtADDR2.Text = string.Empty;
			txtADDR3.Text = string.Empty;
			txtADDR4.Text = string.Empty;
			cbCNTRY.SelectedIndex = -1;
			cbSTACD.SelectedIndex = -1;
			txtTEL01.Text = string.Empty;
			txtTEL02.Text = string.Empty;
			txtFAXNO1.Text = string.Empty;
			txtFAXNO2.Text = string.Empty;
			txtCNTPS.Text = string.Empty;
			txtEMAIL.Text = string.Empty;
			cbCUSTY.SelectedIndex = -1;
			cbPAYTM.SelectedIndex = -1;
			cbPRCTY.SelectedIndex = -1;
			cbCURCD.SelectedIndex = -1;
			cbTAXCD.SelectedIndex = -1;
			txtGSTID.Text = string.Empty;
			txtACCNO.Text = string.Empty;
			txtCUSID.Enabled = true;
			chkINTFG.Checked = false;
			chkAVESL.Checked = false;
			numSTKQTY.Value = 0.0;
			rdoSTICK1.Checked = true;
			rbBigLabel1.Checked = true;
		}

		private void btnNEW_Click(object sender, EventArgs e)
		{
			ClearDetails();
			BindComboBox();
			btnSAVE.Tag = "Save";
			btnPRINT.Enabled = false;
			btnDELETE.Enabled = false;
			Panel2.Visible = false;
			Panel1.Visible = true;
			txtCUSID.Focus();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'PAYTM' ORDER BY MACOD_CODID";
			cbPAYTM.ValueMember = "MACOD_CODID";
			cbPAYTM.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbPAYTM);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CURCD' ";
			strSQL += " ORDER BY MACOD_CODID ";
			cbCURCD.ValueMember = "MACOD_CODID";
			cbCURCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCURCD);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CNTRY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbCNTRY.ValueMember = "MACOD_CODID";
			cbCNTRY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCNTRY);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'STACD' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbSTACD.ValueMember = "MACOD_CODID";
			cbSTACD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbSTACD);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CUSTY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbCUSTY.ValueMember = "MACOD_CODID";
			cbCUSTY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCUSTY);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'PRCTY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbPRCTY.ValueMember = "MACOD_CODID";
			cbPRCTY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbPRCTY);
			strSQL = "SELECT '' as MACOD_CODID, '' as MACOD_CODNM ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'TAXCD' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbTAXCD.ValueMember = "MACOD_CODID";
			cbTAXCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbTAXCD);
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnBACK_Click(object sender, EventArgs e)
		{
			ClearDetails();
			BindComboHeader();
			Header();
			btnSAVE.Enabled = true;
			btnBACK.Enabled = true;
			btnPRINT.Enabled = true;
			btnDELETE.Enabled = true;
		}

		public bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtCUSID.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCUSID.Focus();
				return false;
			}
			if (Operators.CompareString(txtCUSNM.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Name cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCUSNM.Focus();
				return false;
			}
			string strSQL = "SELECT MACUS_CUSID FROM MACUS_TBL WHERE MACUS_CUSID = '" + txtCUSID.Text + "'";
			if (Operators.ConditionalCompareObjectEqual(btnSAVE.Tag, "Save", false) && DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID already exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCUSID.Focus();
				return false;
			}
			if (Conversion.Val(numSTKQTY.Value) == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sticker Quantity cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				numSTKQTY.Focus();
				return false;
			}
			return true;
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		public void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "CUSTOMER MASTER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptMACUS.rpt";
			if (Operators.CompareString(txtCUSID.Text.Trim(), "", false) != 0)
			{
				frmRPT.Params = ("@PAR=1 ,@CUSIDFR=" + txtCUSID.Text + ",@CUSIDTO=" + txtCUSID.Text) ?? "";
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1 ,@CUSIDFR=", cbCUSIDFR.SelectedValue), ",@CUSIDTO="), cbCUSIDTO.SelectedValue), ""));
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='CUSTOMER MASTER'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnDELETE_Click(object sender, EventArgs e)
		{
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID");
			strMSG = strMSG + " : " + txtCUSID.Text + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Name");
			strMSG = strMSG + " : " + txtCUSNM.Text;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				string strSQL = "DELETE MACUS_TBL ";
				strSQL = strSQL + "WHERE MACUS_CUSID = '" + txtCUSID.Text + "' ";
				DB.DBExecute(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				BindComboHeader();
				Header();
			}
		}

		private void dgvMACUS_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			Panel2.Visible = false;
			Panel1.Visible = true;
			btnSAVE.Tag = "Update";
			txtCUSID.Enabled = false;
			btnDELETE.Enabled = true;
			btnPRINT.Enabled = true;
			BindComboBox();
			BindGridToControls();
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
			btnSAVE.Tag = "Save";
			btnPRINT.Enabled = false;
			btnDELETE.Enabled = false;
			Panel2.Visible = false;
			Panel1.Visible = true;
			txtCUSID.Focus();
		}

		private void frmMAECUS_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbCUSIDFR_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCUSIDFR.SelectedIndex == -1)
			{
				lblCUSIDFR.Text = string.Empty;
				return;
			}
			cbCUSIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbCUSIDFR.SelectedValue);
			lblCUSIDFR.Text = Conversions.ToString(cbCUSIDFR.SelectedValue);
		}

		private void cbCUSIDTO_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCUSIDTO.SelectedIndex == -1)
			{
				lblCUSIDTO.Text = "zzz";
			}
			else
			{
				lblCUSIDTO.Text = Conversions.ToString(cbCUSIDTO.SelectedValue);
			}
		}

		private void rdoSTICK1_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoSTICK1.Checked)
			{
				rdoSTICK2.Checked = false;
			}
			else
			{
				rdoSTICK2.Checked = true;
			}
		}

		private void rdoSTICK2_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoSTICK2.Checked)
			{
				rdoSTICK1.Checked = false;
			}
			else
			{
				rdoSTICK1.Checked = true;
			}
		}

		private void rbBigLabel1_CheckedChanged(object sender, EventArgs e)
		{
			if (rbBigLabel1.Checked)
			{
				rbBigLabel2.Checked = false;
			}
			else
			{
				rbBigLabel2.Checked = true;
			}
		}

		private void rbBigLabel2_CheckedChanged(object sender, EventArgs e)
		{
			if (rbBigLabel2.Checked)
			{
				rbBigLabel1.Checked = false;
			}
			else
			{
				rbBigLabel1.Checked = true;
			}
		}

		private void btnEXCEL_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bgwProgress.RunWorkerAsync();
		}

		private void bgwProgress_DoWork(object sender, DoWorkEventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application xlsApp = new ApplicationClass();
			string strSQL = "EXEC spMACUS '0', ";
			strSQL = strSQL + "'" + lblCUSIDFR.Text + "', ";
			strSQL = strSQL + "'" + lblCUSIDTO.Text + "'";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No data found!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			Workbook xlsWorkBook = xlsApp.Workbooks.Add(RuntimeHelpers.GetObjectValue(Missing.Value));
			Worksheet xlsSheet = (Worksheet)xlsWorkBook.Sheets["Sheet1"];
			xlsApp.Cells[1, 1] = PublicVar.gstrCompany;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer List");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			int intRow = 4;
			xlsApp.Cells[intRow, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID");
			xlsApp.Cells[intRow, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer Name");
			xlsApp.Cells[intRow, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Address");
			xlsApp.Cells[intRow, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Country");
			xlsApp.Cells[intRow, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "State");
			xlsApp.Cells[intRow, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Tel 1");
			xlsApp.Cells[intRow, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Tel 2");
			xlsApp.Cells[intRow, 8] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Fax 1");
			xlsApp.Cells[intRow, 9] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Fax 2");
			xlsApp.Cells[intRow, 10] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Contact Person");
			xlsApp.Cells[intRow, 11] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Email");
			xlsApp.Cells[intRow, 12] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Price Type");
			xlsApp.Cells[intRow, 13] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Tax Code");
			xlsApp.Cells[intRow, 14] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Account No");
			xlsApp.Cells[intRow, 15] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 15])).Font.Bold = true;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 15])).EntireColumn.NumberFormat = "@";
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 15])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 15])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					intRow++;
					xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_CUSID"]);
					xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_SHORT"]);
					xlsApp.Cells[intRow, 3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["ADDR"]);
					xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_CNTRY"]);
					xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_STACD"]);
					xlsApp.Cells[intRow, 6] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_TEL01"]);
					xlsApp.Cells[intRow, 7] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_TEL02"]);
					xlsApp.Cells[intRow, 8] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_FAXNO1"]);
					xlsApp.Cells[intRow, 9] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_FAXNO2"]);
					xlsApp.Cells[intRow, 10] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_CNTPS"]);
					xlsApp.Cells[intRow, 11] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_EMAIL"]);
					xlsApp.Cells[intRow, 12] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_PRCTY"]);
					xlsApp.Cells[intRow, 13] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_TAXCD"]);
					xlsApp.Cells[intRow, 14] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_ACCNO"]);
					xlsApp.Cells[intRow, 15] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["MACUS_REMRK"]);
				}
				xlsSheet.Columns.AutoFit();
				xlsSheet = null;
				xlsWorkBook = null;
				GC.Collect();
				xlsApp.WindowState = XlWindowState.xlMaximized;
				xlsApp.Visible = true;
			}
		}

		private void bgwProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			Cursor = Cursors.Default;
		}
	}
}
