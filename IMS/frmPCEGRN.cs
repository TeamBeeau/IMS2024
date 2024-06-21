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
	public class frmPCEGRN : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

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
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

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
		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINTFR")]
		private Button _btnPRINTFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvDetails")]
		private DataGridView _dgvDetails;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numUPRICE")]
		private NumControl _numUPRICE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDELETEFR")]
		private Button _btnDELETEFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numNGQTY")]
		private NumControl _numNGQTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numOKQTY")]
		private NumControl _numOKQTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnConfirm")]
		private Button _btnConfirm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbSUPID")]
		private ComboboxControl _cbSUPID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbPO")]
		private ComboboxControl _cbPO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCD")]
		private ComboboxControl _cbITMCD;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		private int intAccessLevel;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("txtDOCNO")]
		internal virtual TextBox txtDOCNO
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

		[field: AccessedThroughProperty("lblCUSIDTO")]
		internal virtual Label lblCUSIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCUSIDFR")]
		internal virtual Label lblCUSIDFR
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
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

		[field: AccessedThroughProperty("dtpDOCDT")]
		internal virtual DateTimePicker dtpDOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvDetails
		{
			[CompilerGenerated]
			get
			{
				return _dgvDetails;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvDetails_CellMouseDoubleClick;
				DataGridView dataGridView = _dgvDetails;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick -= value2;
				}
				_dgvDetails = value;
				dataGridView = _dgvDetails;
				if (dataGridView != null)
				{
					dataGridView.CellMouseDoubleClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
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

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numAMT")]
		internal virtual NumControl numAMT
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

		internal virtual NumControl numUPRICE
		{
			[CompilerGenerated]
			get
			{
				return _numUPRICE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numUPRICE_TextChanged;
				NumControl numControl = _numUPRICE;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numUPRICE = value;
				numControl = _numUPRICE;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
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

		[field: AccessedThroughProperty("txtRECID")]
		internal virtual TextBox txtRECID
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

		[field: AccessedThroughProperty("Label17")]
		internal virtual Label Label17
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

		internal virtual Button btnDELETEFR
		{
			[CompilerGenerated]
			get
			{
				return _btnDELETEFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnDELETEFR_Click;
				Button button = _btnDELETEFR;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnDELETEFR = value;
				button = _btnDELETEFR;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtCURCD")]
		internal virtual TextBox txtCURCD
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

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual NumControl numNGQTY
		{
			[CompilerGenerated]
			get
			{
				return _numNGQTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numNGQTY_TextChanged;
				NumControl numControl = _numNGQTY;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numNGQTY = value;
				numControl = _numNGQTY;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		internal virtual NumControl numOKQTY
		{
			[CompilerGenerated]
			get
			{
				return _numOKQTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numOKQTY_TextChanged;
				NumControl numControl = _numOKQTY;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
				}
				_numOKQTY = value;
				numControl = _numOKQTY;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label10")]
		internal virtual Label Label10
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

		internal virtual Button btnConfirm
		{
			[CompilerGenerated]
			get
			{
				return _btnConfirm;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnConfirm_Click;
				Button button = _btnConfirm;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnConfirm = value;
				button = _btnConfirm;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label21")]
		internal virtual Label Label21
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

		[field: AccessedThroughProperty("Label22")]
		internal virtual Label Label22
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

		[field: AccessedThroughProperty("Label23")]
		internal virtual Label Label23
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cboPRJCD")]
		internal virtual ComboBox cboPRJCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numWEIGHT")]
		internal virtual NumControl numWEIGHT
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

		[field: AccessedThroughProperty("txtPORECID")]
		internal virtual TextBox txtPORECID
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

		[field: AccessedThroughProperty("lblSTDWGT")]
		internal virtual Label lblSTDWGT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbSUPID
		{
			[CompilerGenerated]
			get
			{
				return _cbSUPID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbSUPID_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbSUPID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbSUPID = value;
				comboboxControl = _cbSUPID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbLOCID")]
		internal virtual ComboBox cbLOCID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbPO
		{
			[CompilerGenerated]
			get
			{
				return _cbPO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbPO_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbPO;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbPO = value;
				comboboxControl = _cbPO;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		internal virtual ComboboxControl cbITMCD
		{
			[CompilerGenerated]
			get
			{
				return _cbITMCD;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbITMCD_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbITMCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbITMCD = value;
				comboboxControl = _cbITMCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("dtpEXPDT")]
		internal virtual DateTimePicker dtpEXPDT
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

		[field: AccessedThroughProperty("txtBATCHNO")]
		internal virtual TextBox txtBATCHNO
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

		[field: AccessedThroughProperty("cbDOCNOFR")]
		internal virtual ComboboxControl cbDOCNOFR
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

		[field: AccessedThroughProperty("cbSUPIDFR")]
		internal virtual ComboboxControl cbSUPIDFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSUPIDTO")]
		internal virtual ComboboxControl cbSUPIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPACKING")]
		internal virtual TextBox txtPACKING
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

		[field: AccessedThroughProperty("Label20")]
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCGRN_DOCNO")]
		internal virtual DataGridViewTextBoxColumn PCGRN_DOCNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("DOCDT")]
		internal virtual DataGridViewTextBoxColumn DOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCGRN_SUPID")]
		internal virtual DataGridViewTextBoxColumn PCGRN_SUPID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCGRN_COMFG")]
		internal virtual DataGridViewTextBoxColumn PCGRN_COMFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCGRN_REMRK")]
		internal virtual DataGridViewTextBoxColumn PCGRN_REMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("PCGRN_DOCDT")]
		internal virtual DataGridViewTextBoxColumn PCGRN_DOCDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCEGRN()
		{
			base.Load += frmPCEGRN_Load;
			base.FormClosing += frmPCEGRN_FormClosing;
			base.KeyDown += frmPCEGRN_KeyDown;
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.Label20 = new System.Windows.Forms.Label();
			this.txtPACKING = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtBATCHNO = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.cbSUPID = new IMS.ComboboxControl();
			this.txtREFNO = new System.Windows.Forms.TextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtCURCD = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.numOKQTY = new IMS.NumControl();
			this.Label13 = new System.Windows.Forms.Label();
			this.numQTY = new IMS.NumControl();
			this.Label18 = new System.Windows.Forms.Label();
			this.numNGQTY = new IMS.NumControl();
			this.Label14 = new System.Windows.Forms.Label();
			this.numUPRICE = new IMS.NumControl();
			this.Label7 = new System.Windows.Forms.Label();
			this.numAMT = new IMS.NumControl();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.txtPORECID = new System.Windows.Forms.TextBox();
			this.cboPRJCD = new System.Windows.Forms.ComboBox();
			this.numWEIGHT = new IMS.NumControl();
			this.Label9 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.cbPO = new IMS.ComboboxControl();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.cbITMCD = new IMS.ComboboxControl();
			this.Label11 = new System.Windows.Forms.Label();
			this.dtpEXPDT = new System.Windows.Forms.DateTimePicker();
			this.lblSTDWGT = new System.Windows.Forms.Label();
			this.txtSTDWGT = new System.Windows.Forms.TextBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.PCGRN_DOCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCGRN_SUPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCGRN_COMFG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCGRN_REMRK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PCGRN_DOCDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDELETEFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.cbSUPIDTO = new IMS.ComboboxControl();
			this.cbSUPIDFR = new IMS.ComboboxControl();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.cboSTSFG = new System.Windows.Forms.ComboBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.lblCUSIDTO = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel6.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			this.Panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			this.TableLayoutPanel4.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.TableLayoutPanel6);
			this.Panel1.Controls.Add(this.TableLayoutPanel5);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1348, 623);
			this.Panel1.TabIndex = 2;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 4;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnConfirm, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54f));
			this.TableLayoutPanel6.Size = new System.Drawing.Size(504, 54);
			this.TableLayoutPanel6.TabIndex = 0;
			this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirm.Image = IMS.My.Resources.Resources.Confirm;
			this.btnConfirm.Location = new System.Drawing.Point(3, 2);
			this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(120, 50);
			this.btnConfirm.TabIndex = 23;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConfirm.UseVisualStyleBackColor = false;
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
			this.btnDelete.TabIndex = 24;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(381, 2);
			this.btnPRINT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 26;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
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
			this.btnBack.TabIndex = 25;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 8;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.Label20, 2, 8);
			this.TableLayoutPanel5.Controls.Add(this.txtPACKING, 5, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label15, 4, 7);
			this.TableLayoutPanel5.Controls.Add(this.txtBATCHNO, 5, 10);
			this.TableLayoutPanel5.Controls.Add(this.Label12, 4, 10);
			this.TableLayoutPanel5.Controls.Add(this.cbSUPID, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.txtREFNO, 1, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label23, 0, 7);
			this.TableLayoutPanel5.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel3, 0, 12);
			this.TableLayoutPanel5.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label3, 6, 0);
			this.TableLayoutPanel5.Controls.Add(this.dtpDOCDT, 7, 0);
			this.TableLayoutPanel5.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.txtCURCD, 7, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label19, 6, 1);
			this.TableLayoutPanel5.Controls.Add(this.Label10, 0, 8);
			this.TableLayoutPanel5.Controls.Add(this.numOKQTY, 1, 8);
			this.TableLayoutPanel5.Controls.Add(this.Label13, 0, 10);
			this.TableLayoutPanel5.Controls.Add(this.numQTY, 1, 10);
			this.TableLayoutPanel5.Controls.Add(this.Label18, 0, 9);
			this.TableLayoutPanel5.Controls.Add(this.numNGQTY, 1, 9);
			this.TableLayoutPanel5.Controls.Add(this.Label14, 4, 8);
			this.TableLayoutPanel5.Controls.Add(this.numUPRICE, 5, 8);
			this.TableLayoutPanel5.Controls.Add(this.Label7, 4, 9);
			this.TableLayoutPanel5.Controls.Add(this.numAMT, 5, 9);
			this.TableLayoutPanel5.Controls.Add(this.txtRECID, 6, 9);
			this.TableLayoutPanel5.Controls.Add(this.txtPORECID, 7, 9);
			this.TableLayoutPanel5.Controls.Add(this.cboPRJCD, 6, 7);
			this.TableLayoutPanel5.Controls.Add(this.numWEIGHT, 3, 8);
			this.TableLayoutPanel5.Controls.Add(this.Label9, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.txtREMRK, 1, 2);
			this.TableLayoutPanel5.Controls.Add(this.dgvDetails, 0, 3);
			this.TableLayoutPanel5.Controls.Add(this.Label6, 0, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label21, 0, 6);
			this.TableLayoutPanel5.Controls.Add(this.Label8, 0, 5);
			this.TableLayoutPanel5.Controls.Add(this.cbPO, 1, 4);
			this.TableLayoutPanel5.Controls.Add(this.cbLOCID, 1, 6);
			this.TableLayoutPanel5.Controls.Add(this.cbITMCD, 1, 5);
			this.TableLayoutPanel5.Controls.Add(this.Label11, 4, 4);
			this.TableLayoutPanel5.Controls.Add(this.dtpEXPDT, 5, 4);
			this.TableLayoutPanel5.Controls.Add(this.lblSTDWGT, 4, 5);
			this.TableLayoutPanel5.Controls.Add(this.txtSTDWGT, 5, 5);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 13;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(1223, 554);
			this.TableLayoutPanel5.TabIndex = 0;
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(230, 396);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(61, 20);
			this.Label20.TabIndex = 57;
			this.Label20.Text = "Weight";
			this.txtPACKING.Location = new System.Drawing.Point(607, 359);
			this.txtPACKING.Name = "txtPACKING";
			this.txtPACKING.ReadOnly = true;
			this.txtPACKING.Size = new System.Drawing.Size(104, 26);
			this.txtPACKING.TabIndex = 56;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(468, 363);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(68, 20);
			this.Label15.TabIndex = 55;
			this.Label15.Text = "Packing";
			this.TableLayoutPanel5.SetColumnSpan(this.txtBATCHNO, 2);
			this.txtBATCHNO.Location = new System.Drawing.Point(607, 457);
			this.txtBATCHNO.Name = "txtBATCHNO";
			this.txtBATCHNO.Size = new System.Drawing.Size(261, 26);
			this.txtBATCHNO.TabIndex = 11;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(468, 460);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(79, 20);
			this.Label12.TabIndex = 51;
			this.Label12.Text = "Batch No";
			this.cbSUPID.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbSUPID, 4);
			this.cbSUPID.ComboboxWidth = 170;
			this.cbSUPID.DataTable = null;
			this.cbSUPID.DisplayMember = null;
			this.cbSUPID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPID.HasBlankValue = true;
			this.cbSUPID.Location = new System.Drawing.Point(136, 34);
			this.cbSUPID.Margin = new System.Windows.Forms.Padding(2);
			this.cbSUPID.Name = "cbSUPID";
			this.cbSUPID.SelectedIndex = -1;
			this.cbSUPID.SelectedItem = null;
			this.cbSUPID.SelectedValue = null;
			this.cbSUPID.Size = new System.Drawing.Size(368, 26);
			this.cbSUPID.TabIndex = 16;
			this.cbSUPID.TextMultiline = true;
			this.cbSUPID.ValueMember = null;
			this.cbSUPID.WhereClause = null;
			this.TableLayoutPanel5.SetColumnSpan(this.txtREFNO, 3);
			this.txtREFNO.Location = new System.Drawing.Point(137, 359);
			this.txtREFNO.Name = "txtREFNO";
			this.txtREFNO.Size = new System.Drawing.Size(247, 26);
			this.txtREFNO.TabIndex = 10;
			this.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label23.AutoSize = true;
			this.Label23.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label23.Location = new System.Drawing.Point(3, 363);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(116, 20);
			this.Label23.TabIndex = 50;
			this.Label23.Text = "Reference No.";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 6);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(116, 20);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No.";
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel5.SetColumnSpan(this.TableLayoutPanel3, 8);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 498);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel3.TabIndex = 0;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(129, 2);
			this.btnREMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 21;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
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
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Add";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
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
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.TableLayoutPanel5.SetColumnSpan(this.txtDOCNO, 5);
			this.txtDOCNO.Location = new System.Drawing.Point(137, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 26);
			this.txtDOCNO.TabIndex = 1;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(717, 6);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(127, 20);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(874, 3);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 26);
			this.dtpDOCDT.TabIndex = 2;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 38);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(92, 20);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Supplier ID";
			this.txtCURCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtCURCD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCURCD.Enabled = false;
			this.txtCURCD.Location = new System.Drawing.Point(874, 35);
			this.txtCURCD.Name = "txtCURCD";
			this.txtCURCD.Size = new System.Drawing.Size(87, 26);
			this.txtCURCD.TabIndex = 4;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(717, 38);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(77, 20);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "Currency";
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 396);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(100, 20);
			this.Label10.TabIndex = 47;
			this.Label10.Text = "OK Quantity";
			this.numOKQTY.AllowNegative = false;
			this.numOKQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numOKQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numOKQTY.DataChanged = false;
			this.numOKQTY.Location = new System.Drawing.Point(137, 393);
			this.numOKQTY.Name = "numOKQTY";
			this.numOKQTY.NumberFormat = "8.0";
			this.numOKQTY.Size = new System.Drawing.Size(87, 26);
			this.numOKQTY.TabIndex = 10;
			this.numOKQTY.Text = "0";
			this.numOKQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numOKQTY.ThousandSeperator = false;
			this.numOKQTY.Value = 0.0;
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 460);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(113, 20);
			this.Label13.TabIndex = 4;
			this.Label13.Text = "Total Quantity";
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQTY.DataChanged = false;
			this.numQTY.Enabled = false;
			this.numQTY.Location = new System.Drawing.Point(137, 457);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.0";
			this.numQTY.Size = new System.Drawing.Size(87, 26);
			this.numQTY.TabIndex = 12;
			this.numQTY.Text = "0";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(3, 428);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(101, 20);
			this.Label18.TabIndex = 48;
			this.Label18.Text = "NG Quantity";
			this.numNGQTY.AllowNegative = false;
			this.numNGQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numNGQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numNGQTY.DataChanged = false;
			this.numNGQTY.Enabled = false;
			this.numNGQTY.Location = new System.Drawing.Point(137, 425);
			this.numNGQTY.Name = "numNGQTY";
			this.numNGQTY.NumberFormat = "8.0";
			this.numNGQTY.Size = new System.Drawing.Size(87, 26);
			this.numNGQTY.TabIndex = 11;
			this.numNGQTY.Text = "0";
			this.numNGQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numNGQTY.ThousandSeperator = false;
			this.numNGQTY.Value = 0.0;
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(468, 396);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(83, 20);
			this.Label14.TabIndex = 9;
			this.Label14.Text = "Unit Price";
			this.numUPRICE.AllowNegative = false;
			this.numUPRICE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numUPRICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numUPRICE.DataChanged = false;
			this.numUPRICE.Location = new System.Drawing.Point(607, 393);
			this.numUPRICE.Name = "numUPRICE";
			this.numUPRICE.NumberFormat = "8.2";
			this.numUPRICE.Size = new System.Drawing.Size(87, 26);
			this.numUPRICE.TabIndex = 13;
			this.numUPRICE.Text = "0.00";
			this.numUPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUPRICE.ThousandSeperator = false;
			this.numUPRICE.Value = 0.0;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(468, 428);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(66, 20);
			this.Label7.TabIndex = 8;
			this.Label7.Text = "Amount";
			this.numAMT.AllowNegative = false;
			this.numAMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numAMT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numAMT.DataChanged = false;
			this.numAMT.Enabled = false;
			this.numAMT.Location = new System.Drawing.Point(607, 425);
			this.numAMT.Name = "numAMT";
			this.numAMT.NumberFormat = "8.2";
			this.numAMT.Size = new System.Drawing.Size(87, 26);
			this.numAMT.TabIndex = 14;
			this.numAMT.Text = "0.00";
			this.numAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numAMT.ThousandSeperator = false;
			this.numAMT.Value = 0.0;
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(717, 425);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(56, 26);
			this.txtRECID.TabIndex = 0;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRECID.Visible = false;
			this.txtPORECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtPORECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtPORECID.Location = new System.Drawing.Point(874, 425);
			this.txtPORECID.Name = "txtPORECID";
			this.txtPORECID.Size = new System.Drawing.Size(56, 26);
			this.txtPORECID.TabIndex = 1;
			this.txtPORECID.TabStop = false;
			this.txtPORECID.Text = "-1";
			this.txtPORECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtPORECID.Visible = false;
			this.cboPRJCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cboPRJCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPRJCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cboPRJCD.FormattingEnabled = true;
			this.cboPRJCD.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cboPRJCD.Location = new System.Drawing.Point(717, 359);
			this.cboPRJCD.Name = "cboPRJCD";
			this.cboPRJCD.Size = new System.Drawing.Size(101, 28);
			this.cboPRJCD.TabIndex = 51;
			this.cboPRJCD.Visible = false;
			this.numWEIGHT.AllowNegative = false;
			this.numWEIGHT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWEIGHT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWEIGHT.DataChanged = false;
			this.numWEIGHT.Location = new System.Drawing.Point(297, 393);
			this.numWEIGHT.Name = "numWEIGHT";
			this.numWEIGHT.NumberFormat = "8.0";
			this.numWEIGHT.ReadOnly = true;
			this.numWEIGHT.Size = new System.Drawing.Size(87, 26);
			this.numWEIGHT.TabIndex = 16;
			this.numWEIGHT.Text = "0";
			this.numWEIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWEIGHT.ThousandSeperator = false;
			this.numWEIGHT.Value = 0.0;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 79);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(76, 20);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.TableLayoutPanel5.SetColumnSpan(this.txtREMRK, 7);
			this.txtREMRK.Location = new System.Drawing.Point(137, 67);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(696, 45);
			this.txtREMRK.TabIndex = 6;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvDetails, 8);
			this.dgvDetails.Location = new System.Drawing.Point(3, 118);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(1217, 137);
			this.dgvDetails.TabIndex = 7;
			this.dgvDetails.TabStop = false;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 264);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(128, 20);
			this.Label6.TabIndex = 47;
			this.Label6.Text = "Purchase Order";
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(3, 329);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(95, 20);
			this.Label21.TabIndex = 48;
			this.Label21.Text = "Location ID";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 296);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(85, 20);
			this.Label8.TabIndex = 3;
			this.Label8.Text = "Item Code";
			this.cbPO.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbPO, 3);
			this.cbPO.ComboboxWidth = 170;
			this.cbPO.DataTable = null;
			this.cbPO.DisplayMember = null;
			this.cbPO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPO.HasBlankValue = false;
			this.cbPO.Location = new System.Drawing.Point(137, 260);
			this.cbPO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbPO.Name = "cbPO";
			this.cbPO.SelectedIndex = -1;
			this.cbPO.SelectedItem = null;
			this.cbPO.SelectedValue = null;
			this.cbPO.Size = new System.Drawing.Size(325, 25);
			this.cbPO.TabIndex = 17;
			this.cbPO.TextMultiline = true;
			this.cbPO.ValueMember = null;
			this.cbPO.WhereClause = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbLOCID, 3);
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.Enabled = false;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(137, 325);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(247, 28);
			this.cbLOCID.TabIndex = 54;
			this.cbITMCD.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbITMCD, 3);
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = false;
			this.cbITMCD.Location = new System.Drawing.Point(137, 292);
			this.cbITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(324, 25);
			this.cbITMCD.TabIndex = 18;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(468, 264);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(96, 20);
			this.Label11.TabIndex = 3;
			this.Label11.Text = "Expiry Date";
			this.dtpEXPDT.CustomFormat = "dd/MM/yyyy";
			this.dtpEXPDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEXPDT.Location = new System.Drawing.Point(607, 261);
			this.dtpEXPDT.Name = "dtpEXPDT";
			this.dtpEXPDT.Size = new System.Drawing.Size(104, 26);
			this.dtpEXPDT.TabIndex = 3;
			this.lblSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTDWGT.AutoSize = true;
			this.lblSTDWGT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTDWGT.Location = new System.Drawing.Point(468, 296);
			this.lblSTDWGT.Name = "lblSTDWGT";
			this.lblSTDWGT.Size = new System.Drawing.Size(133, 20);
			this.lblSTDWGT.TabIndex = 50;
			this.lblSTDWGT.Text = "Standard Weight";
			this.txtSTDWGT.Location = new System.Drawing.Point(607, 293);
			this.txtSTDWGT.Name = "txtSTDWGT";
			this.txtSTDWGT.ReadOnly = true;
			this.txtSTDWGT.Size = new System.Drawing.Size(104, 26);
			this.txtSTDWGT.TabIndex = 49;
			this.txtSTDWGT.Text = "0";
			this.txtSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1348, 623);
			this.Panel2.TabIndex = 2;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Columns.AddRange(this.PCGRN_DOCNO, this.DOCDT, this.PCGRN_SUPID, this.PCGRN_COMFG, this.PCGRN_REMRK, this.PCGRN_DOCDT);
			this.dgvHEADER.Location = new System.Drawing.Point(5, 189);
			this.dgvHEADER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1064, 423);
			this.dgvHEADER.TabIndex = 0;
			this.PCGRN_DOCNO.HeaderText = "Document No";
			this.PCGRN_DOCNO.MinimumWidth = 6;
			this.PCGRN_DOCNO.Name = "PCGRN_DOCNO";
			this.PCGRN_DOCNO.ReadOnly = true;
			this.PCGRN_DOCNO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.PCGRN_DOCNO.Width = 150;
			this.DOCDT.HeaderText = "Document Date";
			this.DOCDT.MinimumWidth = 6;
			this.DOCDT.Name = "DOCDT";
			this.DOCDT.ReadOnly = true;
			this.DOCDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.DOCDT.Width = 130;
			this.PCGRN_SUPID.HeaderText = "Supplier ID";
			this.PCGRN_SUPID.MinimumWidth = 6;
			this.PCGRN_SUPID.Name = "PCGRN_SUPID";
			this.PCGRN_SUPID.ReadOnly = true;
			this.PCGRN_SUPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.PCGRN_SUPID.Width = 200;
			this.PCGRN_COMFG.HeaderText = "Status";
			this.PCGRN_COMFG.MinimumWidth = 6;
			this.PCGRN_COMFG.Name = "PCGRN_COMFG";
			this.PCGRN_COMFG.ReadOnly = true;
			this.PCGRN_COMFG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.PCGRN_COMFG.Width = 125;
			this.PCGRN_REMRK.HeaderText = "Remark";
			this.PCGRN_REMRK.MinimumWidth = 6;
			this.PCGRN_REMRK.Name = "PCGRN_REMRK";
			this.PCGRN_REMRK.ReadOnly = true;
			this.PCGRN_REMRK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.PCGRN_REMRK.Width = 300;
			this.PCGRN_DOCDT.HeaderText = "PCGRN_DOCDT";
			this.PCGRN_DOCDT.MinimumWidth = 6;
			this.PCGRN_DOCDT.Name = "PCGRN_DOCDT";
			this.PCGRN_DOCDT.ReadOnly = true;
			this.PCGRN_DOCDT.Visible = false;
			this.PCGRN_DOCDT.Width = 125;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 5;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.Controls.Add(this.btnDELETEFR, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 4, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnNew, 1, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnPRINTFR, 3, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(5, 130);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(630, 54);
			this.TableLayoutPanel4.TabIndex = 9;
			this.btnDELETEFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDELETEFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDELETEFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDELETEFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDELETEFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDELETEFR.Image = IMS.My.Resources.Resources.Delete;
			this.btnDELETEFR.Location = new System.Drawing.Point(255, 2);
			this.btnDELETEFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnDELETEFR.Name = "btnDELETEFR";
			this.btnDELETEFR.Size = new System.Drawing.Size(120, 50);
			this.btnDELETEFR.TabIndex = 10;
			this.btnDELETEFR.Text = "Delete";
			this.btnDELETEFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDELETEFR.UseVisualStyleBackColor = false;
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
			this.btnClose.Location = new System.Drawing.Point(507, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 12;
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
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(381, 2);
			this.btnPRINTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTFR.TabIndex = 11;
			this.btnPRINTFR.Text = "Print";
			this.btnPRINTFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINTFR.UseVisualStyleBackColor = false;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.cbSUPIDTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbSUPIDFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.cboSTSFG, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label22, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 4;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(827, 125);
			this.TableLayoutPanel2.TabIndex = 1;
			this.cbSUPIDTO.BlankValue = null;
			this.cbSUPIDTO.ComboboxWidth = 170;
			this.cbSUPIDTO.DataTable = null;
			this.cbSUPIDTO.DisplayMember = null;
			this.cbSUPIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDTO.HasBlankValue = true;
			this.cbSUPIDTO.Location = new System.Drawing.Point(500, 32);
			this.cbSUPIDTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbSUPIDTO.Name = "cbSUPIDTO";
			this.cbSUPIDTO.SelectedIndex = -1;
			this.cbSUPIDTO.SelectedItem = null;
			this.cbSUPIDTO.SelectedValue = null;
			this.cbSUPIDTO.Size = new System.Drawing.Size(323, 25);
			this.cbSUPIDTO.TabIndex = 19;
			this.cbSUPIDTO.TextMultiline = true;
			this.cbSUPIDTO.ValueMember = null;
			this.cbSUPIDTO.WhereClause = null;
			this.cbSUPIDFR.BlankValue = null;
			this.cbSUPIDFR.ComboboxWidth = 170;
			this.cbSUPIDFR.DataTable = null;
			this.cbSUPIDFR.DisplayMember = null;
			this.cbSUPIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSUPIDFR.HasBlankValue = true;
			this.cbSUPIDFR.Location = new System.Drawing.Point(135, 32);
			this.cbSUPIDFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbSUPIDFR.Name = "cbSUPIDFR";
			this.cbSUPIDFR.SelectedIndex = -1;
			this.cbSUPIDFR.SelectedItem = null;
			this.cbSUPIDFR.SelectedValue = null;
			this.cbSUPIDFR.Size = new System.Drawing.Size(325, 25);
			this.cbSUPIDFR.TabIndex = 18;
			this.cbSUPIDFR.TextMultiline = true;
			this.cbSUPIDFR.ValueMember = null;
			this.cbSUPIDFR.WhereClause = null;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(500, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(325, 26);
			this.cbDOCNOTO.TabIndex = 18;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(135, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(327, 25);
			this.cbDOCNOFR.TabIndex = 17;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[3] { "Pending Only", "Confirm Only", "All" });
			this.cboSTSFG.Location = new System.Drawing.Point(136, 94);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(121, 28);
			this.cboSTSFG.TabIndex = 7;
			this.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label22.Location = new System.Drawing.Point(3, 98);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(57, 20);
			this.Label22.TabIndex = 10;
			this.Label22.Text = "Status";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 34);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(92, 20);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Supplier ID";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(127, 20);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(467, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(28, 20);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(501, 62);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 26);
			this.dtpDOCDTTO.TabIndex = 6;
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(136, 62);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 26);
			this.dtpDOCDTFR.TabIndex = 5;
			this.lblCUSIDTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDTO.AutoSize = true;
			this.lblCUSIDTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDTO.Location = new System.Drawing.Point(467, 5);
			this.lblCUSIDTO.Name = "lblCUSIDTO";
			this.lblCUSIDTO.Size = new System.Drawing.Size(28, 20);
			this.lblCUSIDTO.TabIndex = 5;
			this.lblCUSIDTO.Text = "To";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 5);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(112, 20);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Document No";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(467, 34);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(28, 20);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPCEGRN";
			base.Tag = "PCEGRN";
			this.Text = "Goods Received Notes";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			Panel1.Visible = true;
			Panel2.Visible = false;
			ClearControl();
			ClearDetails();
			ManageOrderNo();
			RefreshGrid();
			BindComboBox();
			btnSave.Enabled = intAccessLevel >= 1;
			btnREMOVE.Enabled = intAccessLevel >= 3;
			btnDelete.Enabled = intAccessLevel >= 3;
			btnConfirm.Enabled = intAccessLevel >= 3;
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "PCGRN_TBL WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "PCGRN_DOCNO";
			cbDOCNOFR.DisplayMember = "PCGRN_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "PCGRN_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "PCGRN_DOCNO";
			cbDOCNOTO.DisplayMember = "PCGRN_DOCNO";
			cbDOCNOTO.LoadData();
			cbSUPIDFR.DataTable = "PCGRN_TBL WITH (NOLOCK) LEFT JOIN MASUP_TBL WITH (NOLOCK) ON MASUP_SUPID = PCGRN_SUPID ";
			cbSUPIDFR.ValueMember = "PCGRN_SUPID";
			cbSUPIDFR.DisplayMember = "MASUP_SHORT";
			cbSUPIDFR.LoadData();
			cbSUPIDTO.DataTable = "PCGRN_TBL WITH (NOLOCK) LEFT JOIN MASUP_TBL WITH (NOLOCK) ON MASUP_SUPID = PCGRN_SUPID ";
			cbSUPIDTO.ValueMember = "PCGRN_SUPID";
			cbSUPIDTO.DisplayMember = "MASUP_SHORT";
			cbSUPIDTO.LoadData();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (ValidateDetailControl() && spPCEGRN("0"))
			{
				RefreshGrid();
				ClearDetails();
				cbSUPID.Enabled = false;
				dtpDOCDT.Enabled = false;
				cbPO.Focus();
			}
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PCEGRN'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private bool spPCEGRN(string strPRO)
		{
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'PCEGRN'"));
			bool spPCEGRN = default(bool);
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("PCEGRN", "PCGRN", ref strNextNo))
					{
						MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spPCEGRN = false;
						goto IL_0510;
					}
					txtDOCNO.Text = strNextNo;
				}
			}
			else
			{
				txtDOCNO.Enabled = true;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					txtDOCNO.Focus();
					spPCEGRN = false;
					goto IL_0510;
				}
			}
			if (Operators.CompareString(strPRO, "0", false) == 0 && Operators.CompareString(txtBATCHNO.Text, string.Empty, false) == 0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtBATCHNO.Focus();
				spPCEGRN = false;
			}
			else
			{
				if (DB.RecordExists("SELECT PCGRN_ENTBY FROM PCGRN_TBL WHERE PCGRN_DOCNO = '" + txtDOCNO.Text + "'"))
				{
					string strENTBY = Conversions.ToString(DB.GetColumnValue("PCGRN_ENTBY", "PCGRN_TBL", "PCGRN_DOCNO = '" + txtDOCNO.Text + "'"));
					if (!Common.gfAllowEdit(strENTBY))
					{
						MessageBox.Show("This document is view only!\r\nOnly Supervisor user or document creator is allowed to amend.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						goto IL_0510;
					}
				}
				strSQL = "EXEC spPCEGRN ";
				strSQL = strSQL + "'" + strPRO + "', ";
				strSQL = strSQL + Conversions.ToString(Conversion.Val(txtRECID.Text)) + ", ";
				strSQL = strSQL + Conversions.ToString(Conversion.Val(txtPORECID.Text)) + ", ";
				strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPID.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbLOCID.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPO.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpEXPDT.Value) + "', ";
				strSQL = strSQL + "'" + txtREFNO.Text + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numWEIGHT.Value) + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numNGQTY.Value) + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numUPRICE.Value) + "', ";
				strSQL = strSQL + "'" + Conversions.ToString(numAMT.Value) + "', ";
				strSQL += "'', 0, 0, 0, ";
				strSQL = strSQL + "'" + txtSTDWGT.Text + "', ";
				strSQL = strSQL + "'" + txtBATCHNO.Text + "', ";
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
					spPCEGRN = false;
					ProjectData.ClearProjectError();
					goto IL_0510;
				}
				spPCEGRN = true;
			}
			goto IL_0510;
			IL_0510:
			return spPCEGRN;
		}

		private void Header()
		{
			int count = dgvHEADER.Rows.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					dgvHEADER.Rows.Remove(dgvHEADER.Rows[0]);
				}
				string strSQL = "EXEC spPCGRN '0', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
				strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDFR.SelectedValue), "', ")));
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSUPIDTO.SelectedValue), "', ")));
				strSQL += Conversions.ToString(cboSTSFG.SelectedIndex) ?? "";
				DataTable dt = DB.ExecProc(strSQL);
				try
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						dgvHEADER.ClearSelection();
						dgvHEADER.Rows.Add();
						DataGridViewRow dataGridViewRow = dgvHEADER.Rows[dgvHEADER.Rows.Count - 1];
						dataGridViewRow.Cells["PCGRN_DOCNO"].Value = dt.Rows[i]["PCGRN_DOCNO"].ToString();
						dataGridViewRow.Cells["PCGRN_DOCDT"].Value = dt.Rows[i]["PCGRN_DOCDT"].ToString();
						dataGridViewRow.Cells["PCGRN_SUPID"].Value = dt.Rows[i]["PCGRN_SUPID"].ToString();
						dataGridViewRow.Cells["PCGRN_REMRK"].Value = dt.Rows[i]["PCGRN_REMRK"].ToString();
						if (Conversions.ToDouble(dt.Rows[i]["PCGRN_COMFG"].ToString()) == 0.0)
						{
							dataGridViewRow.Cells["PCGRN_COMFG"].Value = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Pending");
						}
						else
						{
							dataGridViewRow.Cells["PCGRN_COMFG"].Value = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Confirmed");
						}
						dataGridViewRow.Cells["DOCDT"].Value = dt.Rows[i]["DOCDT"].ToString();
						dataGridViewRow = null;
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void Calculate()
		{
			numQTY.Value = numOKQTY.Value + numNGQTY.Value;
            if (cbITMCD.SelectedValue != null)
            if (G.listPackingCost.FindIndex(a => a.codePacking.Contains(cbITMCD.SelectedValue.ToString())) > -1)
				{
					Label20.Text = "Pcs";
                    numWEIGHT.Value = numOKQTY.Value;
                }                
            else
				{
                    Label20.Text = "Weight";
                    numWEIGHT.Value = Conversion.Val(txtSTDWGT.Text) * numOKQTY.Value;
                }	
                   

            numAMT.Text = Conversions.ToString(numQTY.Value * numUPRICE.Value);
		}

		private object GETTAXRATE(string PRJCD, int GSTTY, string ITMCD, string SUPCD_CUSCD, ref string TAXCD, ref double TAXRT)
		{
			object GETTAXRATE;
			try
			{
				OleDbCommand cmd = new OleDbCommand();
				cmd.Connection = DB.GetDBConnection();
				string strSQL = "spGET_TAXRATE";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@PRJCD", OleDbType.VarChar, 10).Value = PRJCD;
				cmd.Parameters.Add("@GSTTY", OleDbType.Integer, 30).Value = GSTTY;
				cmd.Parameters.Add("@ITMCD", OleDbType.VarChar, 30).Value = ITMCD;
				cmd.Parameters.Add("@SUPCD_CUSCD", OleDbType.VarChar, 15).Value = SUPCD_CUSCD;
				cmd.Parameters.Add("@TAXCD", OleDbType.VarChar, 15).Direction = ParameterDirection.Output;
				cmd.Parameters.Add("@TAXRT", OleDbType.Decimal, 5, Conversions.ToString(2)).Direction = ParameterDirection.Output;
				int iRowsAffected = cmd.ExecuteNonQuery();
				TAXCD = Conversions.ToString(cmd.Parameters["@TAXCD"].Value);
				TAXRT = Conversions.ToDouble(cmd.Parameters["@TAXRT"].Value);
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GETTAXRATE = false;
				ProjectData.ClearProjectError();
				goto IL_019d;
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GETTAXRATE = false;
				ProjectData.ClearProjectError();
				goto IL_019d;
			}
			GETTAXRATE = true;
			goto IL_019d;
			IL_019d:
			return GETTAXRATE;
		}

		private void ClearDetails()
		{
			txtRECID.Text = Conversions.ToString(-1);
			txtPORECID.Text = Conversions.ToString(-1);
			cbITMCD.SelectedIndex = -1;
			cbITMCD.Enabled = true;
			cbLOCID.SelectedIndex = -1;
			txtREFNO.Text = string.Empty;
			cboPRJCD.SelectedValue = "NA";
			cbPO.SelectedIndex = -1;
			cbPO.Enabled = true;
			dtpEXPDT.Value = DateAndTime.Now;
			numQTY.Value = 0.0;
			numOKQTY.Value = 0.0;
			numNGQTY.Value = 0.0;
			numUPRICE.Value = 0.0;
			numAMT.Value = 0.0;
			txtBATCHNO.Text = string.Empty;
			numOKQTY.Enabled = true;
			btnSave.Text = "Add";
		}

		private void ClearControl()
		{
			dgvDetails.ClearSelection();
			txtDOCNO.Text = string.Empty;
			cbSUPID.SelectedIndex = -1;
			dtpDOCDT.Value = DateTime.Now;
			dtpDOCDT.Enabled = true;
			txtCURCD.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			txtDOCNO.Enabled = true;
			cbSUPID.Enabled = true;
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearControl();
			BindComboHeader();
			Header();
		}

		private void BindHeadertoControl()
		{
			BindComboBox();
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["PCGRN_DOCNO"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PCGRN_DOCDT"].Value);
			cbSUPID.SelectedValue = dgvHEADER.CurrentRow.Cells["PCGRN_SUPID"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["PCGRN_REMRK"].Value.ToString();
		}

		private void BindGridtoControl()
		{
			txtRECID.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["PCGRN_RECID"].Value);
			txtPORECID.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["PCGRN_PORECID"].Value);
			cbPO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["PCGRN_PODOCNO"].Value);
			cbITMCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["PCGRN_ITMCD"].Value);
			cbLOCID.SelectedValue = dgvDetails.CurrentRow.Cells["PCGRN_LOCID"].Value.ToString();
			dtpEXPDT.Value = Conversions.ToDate(dgvDetails.CurrentRow.Cells["PCGRN_EXPDT"].Value);
			numWEIGHT.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCGRN_OKQTY"].Value);
			numOKQTY.Value = numWEIGHT.Value / Conversion.Val(txtSTDWGT.Text);
			numNGQTY.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCGRN_NGQTY"].Value);
			numUPRICE.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCGRN_UPRICE"].Value);
			numAMT.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["PCGRN_AMT"].Value);
			txtBATCHNO.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["PCGRN_BATCHNO"].Value);
			numOKQTY.Enabled = false;
		}

		private void RefreshGrid()
		{
			int i = 0;
			dgvDetails.DataSource = null;
			string strSQL = "EXEC spPCGRN2 '" + txtDOCNO.Text + "'";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			dataGridView.EnableHeadersVisualStyles = false;
			dataGridView.Columns[i].Visible = false;
			dataGridView.Columns[i].Width = 50;
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].HeaderText = "RECID";
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 50;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "PORECID";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 130;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Purchase Order");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 250;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description") + " 1";
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 250;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description") + " 2";
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
				i++;
				dataGridView.Columns[i].Visible = false;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Expiry Date");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Batch No");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 70;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Q'ty");
                //if (dataGridView.Rows.Count > 0)
                //{
                //	String ItemCode = dataGridView.Rows[0].Cells[3].Value.ToString();
                //	if (G.listPackingCost.FindIndex(a => a.codePacking.Contains(ItemCode)) > -1)
                //		dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Q'ty");
                //	else
                //		dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Weight");
                //}
                //else
                //            dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Weight");
                dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = false;
				dataGridView.Columns[i].Width = 70;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "NG Qty");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 70;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Price");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Amount");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Inv Bal");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightBlue;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "OS GRN");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightBlue;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "OS PR");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightBlue;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 250;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "PR Document with this Item");
				dataGridView.Columns[i].HeaderCell.Style.BackColor = Color.LightBlue;
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void BindComboBox()
		{
			cbSUPID.DataTable = "MASUP_TBL WITH (NOLOCK) ";
			cbSUPID.ValueMember = "MASUP_SUPID";
			cbSUPID.DisplayMember = "MASUP_SHORT";
			cbSUPID.LoadData();
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindHeadertoControl();
			RefreshGrid();
			Panel1.Visible = true;
			Panel2.Visible = false;
			string strCOMFG = Conversions.ToString(DB.GetColumnValue("PCGRN_COMFG", "PCGRN_TBL", "PCGRN_DOCNO = '" + txtDOCNO.Text + "'"));
			if (Conversions.ToDouble(strCOMFG) == 1.0)
			{
                btnDelete.Enabled = Common.GetAccessLevel(Conversions.ToString(base.Tag)) >= 3;

                btnConfirm.Enabled = false;
				btnREMOVE.Enabled = false;
				btnSave.Enabled = false;
			}
			else
			{
				btnSave.Enabled = intAccessLevel >= 1;
				btnREMOVE.Enabled = intAccessLevel >= 3;
				btnDelete.Enabled = intAccessLevel >= 3;
				btnConfirm.Enabled = intAccessLevel >= 3;
			}
			cbSUPID.Enabled = false;
			dtpDOCDT.Enabled = false;
			txtDOCNO.Enabled = false;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM PCGRN_TBL ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE PCGRN_SUPID = '", cbSUPID.SelectedValue), "' ")));
			strSQL = strSQL + "AND PCGRN_DOCNO = '" + txtDOCNO.Text + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No. not exists!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbSUPID.Focus();
			}
			else if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No && spPCEGRN("1"))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
				ClearControl();
				BindComboHeader();
				Header();
			}
		}

		private bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbSUPID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Supplier ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbSUPID.Focus();
				return false;
			}
			if (cbLOCID.SelectedIndex == -1)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location ID cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbLOCID.Focus();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(cboPRJCD.SelectedValue, "NA", false) && Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbITMCD.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Focus();
				return false;
			}
			string strSQL = "SELECT * FROM PCGRN_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PCGRN_PODOCNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbPO.SelectedValue)) + "' ";
			strSQL = strSQL + "AND PCGRN_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
			strSQL = strSQL + "AND PCGRN_DOCNO <> '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
			strSQL += "AND PCGRN_COMFG = 0";
			if (DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Pending GRN found for this item!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Select();
				return false;
			}
			if (numOKQTY.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "OK Quantity cannot be 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numOKQTY.Focus();
				return false;
			}
			strSQL = "SELECT * FROM PCPCO_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PCPCO_DOCNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbPO.SelectedValue)) + "' ";
			strSQL = strSQL + "AND PCPCO_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
			DataTable dt = DB.ExecProc(strSQL);
			if (dt.Rows.Count > 0 && Operators.ConditionalCompareObjectLess(dt.Rows[0]["PCPCO_QTY"], Operators.AddObject(dt.Rows[0]["PCPCO_GRNQTY"], numQTY.Value), false))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total Quantity receive over PO Quantity!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numOKQTY.Focus();
				return false;
			}
			return true;
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "GOODS RECEIVED NOTES";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPCGRN.rpt";
			if (Operators.CompareString(txtDOCNO.Text, "", false) != 0)
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1 ,@DOCNOFR=" + txtDOCNO.Text + ",@DOCNOTO=" + txtDOCNO.Text + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@SUPIDFR=", cbSUPID.SelectedValue), ",@SUPIDTO="), cbSUPID.SelectedValue), ",@COMFG=2"));
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1 ,@DOCNOFR=", cbDOCNOFR.SelectedValue), ",@DOCNOTO="), cbDOCNOTO.SelectedValue), ",@DOCDTFR="), Common.gfSQLDate(dtpDOCDTFR.Value)), ",@DOCDTTO="), Common.gfSQLDate(dtpDOCDTTO.Value)), ",@SUPIDFR="), cbSUPIDFR.SelectedValue), ",@SUPIDTO="), cbSUPIDTO.SelectedValue), ",@COMFG="), cboSTSFG.SelectedIndex), ""));
			}
			frmRPT.Formulas = "COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='GOODS RECEIVED NOTES',gintQTYDS='" + PublicVar.gintQTYDS + "',gintAMTDS='" + PublicVar.gintAMTDS + "',gintPRCDS='" + PublicVar.gintPRCDS + "'";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtDOCNO.Text.Trim(), string.Empty, false) != 0)
			{
				DisplayReport();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgvDetails_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
			string strCOMFG = Conversions.ToString(DB.GetColumnValue("PCGRN_COMFG", "PCGRN_TBL", "PCGRN_DOCNO = '" + txtDOCNO.Text + "'"));
			if (Conversions.ToDouble(strCOMFG) == 1.0)
			{
				btnSave.Enabled = false;
				btnREMOVE.Enabled = false;
			}
			else
			{
				btnSave.Enabled = intAccessLevel >= 2;
				btnREMOVE.Enabled = intAccessLevel >= 3;
			}
			cbPO.Enabled = false;
			cbITMCD.Enabled = false;
			btnSave.Text = "Update";
		}

		private void numUPRICE_TextChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			string strSQL = "SELECT * FROM PCGRN_TBL ";
			strSQL = strSQL + "WHERE PCGRN_RECID = '" + txtRECID.Text + "' ";
			strSQL = strSQL + "AND PCGRN_DOCNO = '" + txtDOCNO.Text + "'";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Please select a record!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Focus();
			}
			else if (MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?"), "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				strSQL = "DELETE PCGRN_TBL WHERE PCGRN_DOCNO = '" + txtDOCNO.Text + "' AND PCGRN_RECID = '" + txtRECID.Text + "'";
				DataTable dt = DB.ExecProc(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefreshGrid();
				ClearDetails();
			}
		}

		private void btnDELETEFR_Click(object sender, EventArgs e)
		{
			string strDOCNO = dgvHEADER.CurrentRow.Cells["PCGRN_DOCNO"].Value.ToString();
			string strSTSFG = Conversions.ToString(DB.GetColumnValue("PCGRN_COMFG", "PCGRN_TBL", "PCGRN_DOCNO = '" + strDOCNO + "'"));
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + strDOCNO;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				if (Operators.CompareString(strSTSFG, "1", false) == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record already confirm not allow to delete!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				string strSQL = "DELETE PCGRN_TBL WHERE PCGRN_DOCNO = '" + strDOCNO + "' ";
				DB.DBExecute(strSQL);
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				BindComboHeader();
				Header();
			}
		}

		private void numOKQTY_TextChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		private void numNGQTY_TextChanged(object sender, EventArgs e)
		{
			Calculate();
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
            DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Confirm order?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
			{
				string strSQL = "SELECT * FROM PCGRN_TBL ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("WHERE PCGRN_SUPID = '", cbSUPID.SelectedValue), "' ")));
				strSQL = strSQL + "AND PCGRN_DOCNO = '" + txtDOCNO.Text + "'";
				if (!DB.RecordExists(strSQL))
				{
					//MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record not found."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cbSUPID.Focus();
					return;
				}
				try
				{
					strSQL = "EXEC spPCEGRN_CONFIRM '" + txtDOCNO.Text + "', '" + PublicVar.gstrLogonID + "'";
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					string intAffected = Conversions.ToString(cmd.ExecuteNonQuery());
					RefreshGrid();
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record confirmed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
					return;
				}
				btnSave.Enabled = false;
				btnREMOVE.Enabled = false;
				btnDelete.Enabled = false;
				btnConfirm.Enabled = false;
			}
		}

		private void frmPCEGRN_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			cboSTSFG.SelectedIndex = 0;
			BindComboHeader();
			intAccessLevel = Common.GetAccessLevel(Conversions.ToString(base.Tag));
			Header();
			NumberFormat();
			string strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'PRJCD' ORDER BY MACOD_CODID";
			cboPRJCD.ValueMember = "MACOD_CODID";
			cboPRJCD.DisplayMember = "MACOD_CODID";
			Common.RetriveComboItembySQL(strSQL, cboPRJCD);
			cboPRJCD.SelectedValue = "NA";
			btnNew.Enabled = intAccessLevel != 0;
			btnDELETEFR.Enabled = intAccessLevel >= 3;
		}

		private void frmPCEGRN_FormClosing(object sender, FormClosingEventArgs e)
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

		private void NumberFormat()
		{
			numOKQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numNGQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numUPRICE.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Price);
			numAMT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Amount);
		}

		private void frmPCEGRN_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbSUPID_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbSUPID.SelectedIndex != -1)
			{
				txtCURCD.Text = Conversions.ToString(DB.GetColumnValue("MASUP_CURCD", "MASUP_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASUP_SUPID = '", cbSUPID.SelectedValue), "'"))));
				cbPO.DataTable = "PCPCO_TBL WITH (NOLOCK) ";
				cbPO.WhereClause = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("PCPCO_SUPID = '", cbSUPID.SelectedValue), "' AND PCPCO_COMFG = 0 "));
				cbPO.ValueMember = "PCPCO_DOCNO";
				cbPO.DisplayMember = "PCPCO_DOCNO";
				cbPO.LoadData();
			}
		}

		private void cbPO_SelectedValueChanged(object sender, EventArgs e)
		{
			cbITMCD.SelectedIndex = -1;
			numOKQTY.Value = 0.0;
			numNGQTY.Value = 0.0;
			numQTY.Value = 0.0;
			numUPRICE.Value = 0.0;
			numAMT.Value = 0.0;
			dtpEXPDT.Value = DateAndTime.Now;
			txtBATCHNO.Text = string.Empty;
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("PCPCO_DOCNO = '", cbPO.SelectedValue), "' "));
			strSQL += "AND PCPCO_QTY > PCPCO_GRNQTY AND PCPCO_COMFG = 0 ";
			strSQL += "AND MAITM_ITMTY = '0' AND MAITM_ACTFG = -1 ";
			cbITMCD.DataTable = "PCPCO_TBL WITH(NOLOCK) LEFT JOIN MAITM_TBL WITH(NOLOCK) ON PCPCO_ITMCD = MAITM_ITMCD ";
			cbITMCD.WhereClause = strSQL;
			cbITMCD.ValueMember = "PCPCO_ITMCD";
			cbITMCD.DisplayMember = "PCPCO_ITMCD";
			cbITMCD.LoadData();
		}

		private void cbITMCD_SelectedValueChanged(object sender, EventArgs e)
		{
			double dblPOQTY = 0.0;
			double dblGRNQT = 0.0;
			if (cbITMCD.SelectedIndex != -1)
			{
				string strWHERE = "MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				txtSTDWGT.Text = Conversions.ToString(DB.GetColumnValue("MAITM_STDWGT", "MAITM_TBL WITH (NOLOCK)", strWHERE));
				txtPACKING.Text = Conversions.ToString(DB.GetColumnValue("MAITM_PACKING", "MAITM_TBL WITH (NOLOCK)", strWHERE));
				cbLOCID.SelectedValue = RuntimeHelpers.GetObjectValue(DB.GetColumnValue("MAITM_LOCCD", "MAITM_TBL WITH (NOLOCK)", strWHERE));
				string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("PCPCO_DOCNO = '", cbPO.SelectedValue), "' AND PCPCO_ITMCD = '"), cbITMCD.SelectedValue), "'"));
				txtPORECID.Text = Conversions.ToString(DB.GetColumnValue("TOP 1 PCPCO_RECID", "PCPCO_TBL", strSQL));
				if (Operators.ConditionalCompareObjectNotEqual(cbPO.SelectedValue, "", false))
				{
					strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("PCPCO_DOCNO = '", cbPO.SelectedValue), "' AND PCPCO_RECID = "), Conversion.Val(txtPORECID.Text)), ""));
                    if (G.listPackingCost.FindIndex(a => a.codePacking.Contains(cbITMCD.SelectedValue.ToString())) > -1)
                    {
                        dblPOQTY = Conversions.ToDouble(Operators.DivideObject(DB.GetColumnValue("PCPCO_QTY", "PCPCO_TBL", strSQL), Conversion.Val("1")));//txtSTDWGT.Text

                    }
                    else
                        dblPOQTY = Conversions.ToDouble(Operators.DivideObject(DB.GetColumnValue("PCPCO_QTY", "PCPCO_TBL", strSQL), Conversion.Val(txtSTDWGT.Text)));//

                    numUPRICE.Value = Conversions.ToDouble(DB.GetColumnValue("PCPCO_UPRICE", "PCPCO_TBL", strSQL));
				}
				else
				{
					numUPRICE.Value = Common.gfGetPCPRC(Conversions.ToString(cbSUPID.SelectedValue), Conversions.ToString(cbITMCD.SelectedValue), dtpDOCDT.Value);
				}
				//db2805
				strSQL = "PCGRN_DOCNO = '" + txtDOCNO.Text + "' AND PCGRN_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "'";
				dblGRNQT = Conversions.ToDouble(Operators.DivideObject(DB.GetColumnValue("ISNULL(SUM(PCGRN_OKQTY), 0)", "PCGRN_TBL", strSQL), Conversion.Val(txtSTDWGT.Text)));
				numOKQTY.Value = dblPOQTY - dblGRNQT;
			}
		}
	}
}
