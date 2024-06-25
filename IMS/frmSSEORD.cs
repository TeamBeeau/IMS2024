using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmSSEORD : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPRINT")]
		private Button _btnPRINT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnDELETEFR")]
		private Button _btnDELETEFR;

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
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnADD")]
		private Button _btnADD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

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
		[AccessedThroughProperty("numQTY")]
		private NumControl _numQTY;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSIDFR")]
		private ComboboxControl _cbCUSIDFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbDOCNOFR")]
		private ComboboxControl _cbDOCNOFR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSID")]
		private ComboboxControl _cbCUSID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCD")]
		private ComboboxControl _cbITMCD;

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
		[AccessedThroughProperty("rdoSample")]
		private RadioButton _rdoSample;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoNormal")]
		private RadioButton _rdoNormal;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("numPACKING")]
		private NumControl _numPACKING;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbPACKING")]
		private ComboboxControl _cbPACKING;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnConfirm")]
		private Button _btnConfirm;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("rdoProcessing")]
		private RadioButton _rdoProcessing;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
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

		[field: AccessedThroughProperty("lblSTSFG")]
		internal virtual Label lblSTSFG
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

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDOCNOTO")]
		internal virtual Label lblDOCNOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblDOCNOFR")]
		internal virtual Label lblDOCNOFR
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

		[field: AccessedThroughProperty("dtpDOCDTFR")]
		internal virtual DateTimePicker dtpDOCDTFR
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

		[field: AccessedThroughProperty("Label17")]
		internal virtual Label Label17
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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
				DataGridViewCellMouseEventHandler value2 = dgvDetails_CellMouseClick;
				DataGridView dataGridView = _dgvDetails;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvDetails = value;
				dataGridView = _dgvDetails;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
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

		internal virtual NumControl numQTY
		{
			[CompilerGenerated]
			get
			{
				return _numQTY;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = numQTY_TextChanged;
				KeyEventHandler value3 = numQTY_KeyDown;
				NumControl numControl = _numQTY;
				if (numControl != null)
				{
					numControl.TextChanged -= value2;
					numControl.KeyDown -= value3;
				}
				_numQTY = value;
				numControl = _numQTY;
				if (numControl != null)
				{
					numControl.TextChanged += value2;
					numControl.KeyDown += value3;
				}
			}
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

		[field: AccessedThroughProperty("Label14")]
		internal virtual Label Label14
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

		[field: AccessedThroughProperty("lblQTY")]
		internal virtual Label lblQTY
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

		[field: AccessedThroughProperty("Label8")]
		internal virtual Label Label8
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

		[field: AccessedThroughProperty("txtDOCNO")]
		internal virtual TextBox txtDOCNO
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		[field: AccessedThroughProperty("txtRECID")]
		internal virtual TextBox txtRECID
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

		[field: AccessedThroughProperty("txtREFNO")]
		internal virtual TextBox txtREFNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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
				ComboboxControl.SelectedValueChangedEventHandler obj = cbCUSIDFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbCUSIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbCUSIDFR = value;
				comboboxControl = _cbCUSIDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbDOCNOTO")]
		internal virtual ComboboxControl cbDOCNOTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbDOCNOFR
		{
			[CompilerGenerated]
			get
			{
				return _cbDOCNOFR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedValueChangedEventHandler obj = cbDOCNOFR_SelectedValueChanged;
				ComboboxControl comboboxControl = _cbDOCNOFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged -= obj;
				}
				_cbDOCNOFR = value;
				comboboxControl = _cbDOCNOFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedValueChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("cbCUSIDTO")]
		internal virtual ComboboxControl cbCUSIDTO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboboxControl cbCUSID
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
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbCUSID_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbCUSID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbCUSID = value;
				comboboxControl = _cbCUSID;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
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
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbITMCD_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbITMCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbITMCD = value;
				comboboxControl = _cbITMCD;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("lblREVNO")]
		internal virtual Label lblREVNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("dtpDELDT")]
		internal virtual DateTimePicker dtpDELDT
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

		[field: AccessedThroughProperty("lblSTDWGT")]
		internal virtual Label lblSTDWGT
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

		[field: AccessedThroughProperty("chkCOMPLETED")]
		internal virtual CheckBox chkCOMPLETED
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkFOC")]
		internal virtual CheckBox chkFOC
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

		[field: AccessedThroughProperty("chkZERO")]
		internal virtual CheckBox chkZERO
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

		internal virtual RadioButton rdoSample
		{
			[CompilerGenerated]
			get
			{
				return _rdoSample;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoSample_CheckedChanged;
				RadioButton radioButton = _rdoSample;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoSample = value;
				radioButton = _rdoSample;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		internal virtual RadioButton rdoNormal
		{
			[CompilerGenerated]
			get
			{
				return _rdoNormal;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoNormal_CheckedChanged;
				RadioButton radioButton = _rdoNormal;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoNormal = value;
				radioButton = _rdoNormal;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSLMAN")]
		internal virtual ComboBox cbSLMAN
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

		[field: AccessedThroughProperty("Label13")]
		internal virtual Label Label13
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

		internal virtual NumControl numPACKING
		{
			[CompilerGenerated]
			get
			{
				return _numPACKING;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = numPACKING_KeyDown;
				NumControl numControl = _numPACKING;
				if (numControl != null)
				{
					numControl.KeyDown -= value2;
				}
				_numPACKING = value;
				numControl = _numPACKING;
				if (numControl != null)
				{
					numControl.KeyDown += value2;
				}
			}
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
        [field: AccessedThroughProperty("numSTDWGT")]
		internal virtual NumControl numSTDWGT
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

		[field: AccessedThroughProperty("Label20")]
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCPTNO")]
		internal virtual TextBox txtCPTNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dtpENTDT")]
		internal virtual DateTimePicker dtpENTDT
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtEXPORD")]
		internal virtual TextBox txtEXPORD
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

		internal virtual RadioButton rdoProcessing
		{
			[CompilerGenerated]
			get
			{
				return _rdoProcessing;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = rdoProcessing_CheckedChanged;
				RadioButton radioButton = _rdoProcessing;
				if (radioButton != null)
				{
					radioButton.CheckedChanged -= value2;
				}
				_rdoProcessing = value;
				radioButton = _rdoProcessing;
				if (radioButton != null)
				{
					radioButton.CheckedChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbQUONO")]
		internal virtual ComboBox cbQUONO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbDELID")]
		internal virtual ComboBox cbDELID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtQUONO")]
		internal virtual TextBox txtQUONO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmSSEORD()
		{
			base.FormClosing += frmSSEORD_FormClosing;
			base.Load += frmSSEORD_Load;
			base.KeyDown += frmSSEORD_KeyDown;
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
        Label lbShowUOM = new Label();
        Label lbUOM = new Label();
        [System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txtEXPORD = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.dtpENTDT = new System.Windows.Forms.DateTimePicker();
			this.cbSLMAN = new System.Windows.Forms.ComboBox();
			this.Label18 = new System.Windows.Forms.Label();
			this.lblSTSFG = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.rdoProcessing = new System.Windows.Forms.RadioButton();
			this.rdoSample = new System.Windows.Forms.RadioButton();
			this.rdoNormal = new System.Windows.Forms.RadioButton();
			this.cbREVNO = new System.Windows.Forms.ComboBox();
			this.lblREVNO = new System.Windows.Forms.Label();
			this.txtREFNO = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnADD = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.Label9 = new System.Windows.Forms.Label();
			this.numUPRICE = new IMS.NumControl();
			this.numUPRICE.Enabled = false;
			this.numQTY = new IMS.NumControl();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.lblQTY = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.numAMT = new IMS.NumControl();
			this.cbITMCD = new IMS.ComboboxControl();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.dtpDELDT = new System.Windows.Forms.DateTimePicker();
			this.cbCUSID = new IMS.ComboboxControl();
			this.Label6 = new System.Windows.Forms.Label();
			this.chkCOMPLETED = new System.Windows.Forms.CheckBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.chkFOC = new System.Windows.Forms.CheckBox();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.numPACKING = new IMS.NumControl();
			this.lblSTDWGT = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.cbPACKING = new IMS.ComboboxControl();
			//cbPACKING.Enabled = false;
			this.numSTDWGT = new IMS.NumControl();
			this.Label20 = new System.Windows.Forms.Label();
			this.txtCPTNO = new System.Windows.Forms.TextBox();
			this.cbQUONO = new System.Windows.Forms.ComboBox();
			this.cbDELID = new System.Windows.Forms.ComboBox();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPRINT = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnConfirm = new System.Windows.Forms.Button();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDELETEFR = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnPRINTFR = new System.Windows.Forms.Button();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.chkZERO = new System.Windows.Forms.CheckBox();
			this.cbCUSIDFR = new IMS.ComboboxControl();
			this.cbDOCNOTO = new IMS.ComboboxControl();
			this.cbDOCNOFR = new IMS.ComboboxControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblDOCNOTO = new System.Windows.Forms.Label();
			this.lblDOCNOFR = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.dtpDOCDTFR = new System.Windows.Forms.DateTimePicker();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.dtpDOCDTTO = new System.Windows.Forms.DateTimePicker();
			this.cbCUSIDTO = new IMS.ComboboxControl();
			this.txtQUONO = new System.Windows.Forms.TextBox();
			txtQUONO.Enabled = false;
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
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
			this.Panel1.Location = new System.Drawing.Point(3, 2);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1349, 709);
			this.Panel1.TabIndex = 3;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 6;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.txtEXPORD, 3, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label21, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpENTDT, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.cbSLMAN, 3, 9);
			this.TableLayoutPanel1.Controls.Add(this.Label18, 2, 9);
			this.TableLayoutPanel1.Controls.Add(this.lblSTSFG, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label15, 0, 9);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 1, 3);
			this.TableLayoutPanel1.Controls.Add(this.cbREVNO, 3, 10);
			this.TableLayoutPanel1.Controls.Add(this.lblREVNO, 2, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtREFNO, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel3, 0, 15);
			this.TableLayoutPanel1.Controls.Add(this.dgvDetails, 0, 7);
			this.TableLayoutPanel1.Controls.Add(this.Label9, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.numUPRICE, 1, 13);
			this.TableLayoutPanel1.Controls.Add(this.numQTY, 1, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label14, 0, 13);
			this.TableLayoutPanel1.Controls.Add(this.txtREMRK, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.lblQTY, 0, 12);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 0, 10);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 3, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label11, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 2, 13);
			this.TableLayoutPanel1.Controls.Add(this.numAMT, 3, 13);
			this.TableLayoutPanel1.Controls.Add(this.cbITMCD, 1, 10);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.dtpDELDT, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.cbCUSID, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 2, 1);
			this.TableLayoutPanel1.Controls.Add(this.chkCOMPLETED, 2, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label12, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.chkFOC, 2, 3);
			this.TableLayoutPanel1.Controls.Add(this.txtRECID, 2, 15);
			this.TableLayoutPanel1.Controls.Add(this.Label19, 2, 12);
			this.TableLayoutPanel1.Controls.Add(this.numPACKING, 3, 12);
			this.TableLayoutPanel1.Controls.Add(this.lblSTDWGT,2, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label13, 0, 11);
			this.TableLayoutPanel1.Controls.Add(this.cbPACKING, 1, 11);

            this.TableLayoutPanel1.Controls.Add(this.numSTDWGT, 3, 11);
			this.TableLayoutPanel1.Controls.Add(this.Label20, 4, 10);
			this.TableLayoutPanel1.Controls.Add(this.txtCPTNO, 5, 10);
			this.TableLayoutPanel1.Controls.Add(this.cbDELID, 1, 9);
			this.TableLayoutPanel1.Controls.Add(this.cbQUONO, 5, 1);
			this.TableLayoutPanel1.Controls.Add(this.txtQUONO, 3, 1);
          
            this.TableLayoutPanel1.Location = new System.Drawing.Point(5, 64);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 16;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(1148, 559);
			this.TableLayoutPanel1.TabIndex = 51;
			this.txtEXPORD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtEXPORD.Location = new System.Drawing.Point(544, 61);
			this.txtEXPORD.Name = "txtEXPORD";
			this.txtEXPORD.Size = new System.Drawing.Size(180, 22);
			this.txtEXPORD.TabIndex = 76;
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(430, 64);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(102, 16);
			this.Label21.TabIndex = 75;
			this.Label21.Text = "Expected Order";
			this.dtpENTDT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpENTDT.CustomFormat = "hh:mm:ss";
			this.dtpENTDT.Enabled = false;
			this.dtpENTDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpENTDT.Location = new System.Drawing.Point(730, 3);
			this.dtpENTDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpENTDT.Name = "dtpENTDT";
			this.dtpENTDT.Size = new System.Drawing.Size(104, 22);
			this.dtpENTDT.TabIndex = 74;
			this.TableLayoutPanel1.SetColumnSpan(this.cbSLMAN, 2);
			this.cbSLMAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSLMAN.FormattingEnabled = true;
			this.cbSLMAN.Location = new System.Drawing.Point(544, 356);
			this.cbSLMAN.Name = "cbSLMAN";
			this.cbSLMAN.Size = new System.Drawing.Size(218, 24);
			this.cbSLMAN.TabIndex = 13;
			this.Label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label18.Location = new System.Drawing.Point(430, 360);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(69, 16);
			this.Label18.TabIndex = 53;
			this.Label18.Text = "Salesman";
			this.lblSTSFG.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTSFG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblSTSFG.ForeColor = System.Drawing.Color.Brown;
			this.lblSTSFG.Location = new System.Drawing.Point(849, 3);
			this.lblSTSFG.Name = "lblSTSFG";
			this.lblSTSFG.Size = new System.Drawing.Size(93, 21);
			this.lblSTSFG.TabIndex = 50;
			this.lblSTSFG.Text = "Status";
			this.lblSTSFG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblSTSFG.Visible = false;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 360);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(74, 16);
			this.Label15.TabIndex = 53;
			this.Label15.Text = "Delivery ID";
			this.TableLayoutPanel5.ColumnCount = 3;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145f));
			this.TableLayoutPanel5.Controls.Add(this.rdoProcessing, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.rdoSample, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.rdoNormal, 0, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(99, 89);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 2;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(275, 25);
			this.TableLayoutPanel5.TabIndex = 52;
			this.rdoProcessing.AutoSize = true;
			this.rdoProcessing.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rdoProcessing.Location = new System.Drawing.Point(158, 3);
			this.rdoProcessing.Name = "rdoProcessing";
			this.rdoProcessing.Size = new System.Drawing.Size(94, 20);
			this.rdoProcessing.TabIndex = 8;
			this.rdoProcessing.TabStop = true;
			this.rdoProcessing.Text = "Processing";
			this.rdoProcessing.UseVisualStyleBackColor = true;
			this.rdoSample.AutoSize = true;
			this.rdoSample.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rdoSample.Location = new System.Drawing.Point(79, 3);
			this.rdoSample.Name = "rdoSample";
			this.rdoSample.Size = new System.Drawing.Size(73, 20);
			this.rdoSample.TabIndex = 7;
			this.rdoSample.TabStop = true;
			this.rdoSample.Text = "Sample";
			this.rdoSample.UseVisualStyleBackColor = true;
			this.rdoNormal.AutoSize = true;
			this.rdoNormal.Checked = true;
			this.rdoNormal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rdoNormal.Location = new System.Drawing.Point(3, 3);
			this.rdoNormal.Name = "rdoNormal";
			this.rdoNormal.Size = new System.Drawing.Size(70, 20);
			this.rdoNormal.TabIndex = 6;
			this.rdoNormal.TabStop = true;
			this.rdoNormal.Text = "Normal";
			this.rdoNormal.UseVisualStyleBackColor = true;
			this.cbREVNO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbREVNO.FormattingEnabled = true;
			this.cbREVNO.Location = new System.Drawing.Point(544, 386);
			this.cbREVNO.Name = "cbREVNO";
			this.cbREVNO.Size = new System.Drawing.Size(106, 24);
			this.cbREVNO.TabIndex = 15;
			this.lblREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREVNO.AutoSize = true;
			this.lblREVNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREVNO.Location = new System.Drawing.Point(430, 390);
			this.lblREVNO.Name = "lblREVNO";
			this.lblREVNO.Size = new System.Drawing.Size(61, 16);
			this.lblREVNO.TabIndex = 52;
			this.lblREVNO.Text = "Revision";
			this.txtREFNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtREFNO.Location = new System.Drawing.Point(99, 120);
			this.txtREFNO.Name = "txtREFNO";
			this.txtREFNO.Size = new System.Drawing.Size(180, 22);
			this.txtREFNO.TabIndex = 9;
			this.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel3, 2);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnADD, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCancel, 2, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 501);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 56);
			this.TableLayoutPanel3.TabIndex = 1;
			this.btnREMOVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnREMOVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnREMOVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnREMOVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnREMOVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnREMOVE.Image = IMS.My.Resources.Resources.Delete;
			this.btnREMOVE.Location = new System.Drawing.Point(129, 3);
			this.btnREMOVE.Name = "btnREMOVE";
			this.btnREMOVE.Size = new System.Drawing.Size(120, 50);
			this.btnREMOVE.TabIndex = 21;
			this.btnREMOVE.Text = "Remove";
			this.btnREMOVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnREMOVE.UseVisualStyleBackColor = false;
			this.btnADD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnADD.Image = IMS.My.Resources.Resources.Save;
			this.btnADD.Location = new System.Drawing.Point(3, 3);
			this.btnADD.Name = "btnADD";
			this.btnADD.Size = new System.Drawing.Size(120, 50);
			this.btnADD.TabIndex = 20;
			this.btnADD.Text = "Add";
			this.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnADD.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(255, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 22;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvDetails, 6);
			this.dgvDetails.Location = new System.Drawing.Point(3, 203);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(1142, 137);
			this.dgvDetails.TabIndex = 10;
			this.dgvDetails.TabStop = false;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 159);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(63, 16);
			this.Label9.TabIndex = 8;
			this.Label9.Text = "Remarks";
			this.numUPRICE.AllowNegative = false;
			this.numUPRICE.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numUPRICE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numUPRICE.DataChanged = false;
			this.numUPRICE.Location = new System.Drawing.Point(99, 474);
			this.numUPRICE.Name = "numUPRICE";
			this.numUPRICE.NumberFormat = "8.2";
			this.numUPRICE.Size = new System.Drawing.Size(133, 22);
			this.numUPRICE.TabIndex = 19;
			this.numUPRICE.Text = "0.00";
			this.numUPRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUPRICE.ThousandSeperator = false;
			this.numUPRICE.Value = 0.0;
			this.numQTY.AllowNegative = false;
			this.numQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numQTY.DataChanged = false;
			this.numQTY.Location = new System.Drawing.Point(99, 446);
			this.numQTY.Name = "numQTY";
			this.numQTY.NumberFormat = "8.3";
			this.numQTY.Size = new System.Drawing.Size(133, 22);
			this.numQTY.TabIndex = 17;
			this.numQTY.Text = "0.000";
			this.numQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQTY.ThousandSeperator = false;
			this.numQTY.Value = 0.0;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 6);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(90, 16);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "Document No";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(430, 6);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(101, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Document Date";
			this.Label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label14.Location = new System.Drawing.Point(3, 477);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(65, 16);
			this.Label14.TabIndex = 9;
			this.Label14.Text = "Unit Price";
			this.TableLayoutPanel1.SetColumnSpan(this.txtREMRK, 3);
			this.txtREMRK.Location = new System.Drawing.Point(99, 148);
			this.txtREMRK.Multiline = true;
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(551, 39);
			this.txtREMRK.TabIndex = 11;
			this.lblQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblQTY.AutoSize = true;
			this.lblQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQTY.Location = new System.Drawing.Point(3, 449);
			this.lblQTY.Name = "lblQTY";
			this.lblQTY.Size = new System.Drawing.Size(56, 16);
			this.lblQTY.TabIndex = 4;
			this.lblQTY.Text = "Quantity";
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 390);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(69, 16);
			this.Label8.TabIndex = 3;
			this.Label8.Text = "Item Code";
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(544, 3);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 2;
			this.txtDOCNO.Location = new System.Drawing.Point(99, 3);
			this.txtDOCNO.Name = "txtDOCNO";
			this.txtDOCNO.Size = new System.Drawing.Size(180, 22);
			this.txtDOCNO.TabIndex = 1;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(3, 123);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(56, 16);
			this.Label11.TabIndex = 48;
			this.Label11.Text = "Ref. No.";
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(430, 477);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(53, 16);
			this.Label7.TabIndex = 8;
			this.Label7.Text = "Amount";
			this.numAMT.AllowNegative = false;
			this.numAMT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numAMT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numAMT.DataChanged = false;
			this.numAMT.Enabled = false;
			this.numAMT.Location = new System.Drawing.Point(544, 474);
			this.numAMT.Name = "numAMT";
			this.numAMT.NumberFormat = "8.2";
			this.numAMT.ReadOnly = true;
			this.numAMT.Size = new System.Drawing.Size(104, 22);
			this.numAMT.TabIndex = 14;
			this.numAMT.TabStop = false;
			this.numAMT.Text = "0.00";
			this.numAMT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numAMT.ThousandSeperator = false;
			this.numAMT.Value = 0.0;
			this.cbITMCD.BlankValue = null;
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = false;
			this.cbITMCD.Location = new System.Drawing.Point(99, 385);
			this.cbITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(325, 26);
			this.cbITMCD.TabIndex = 14;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 64);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(90, 16);
			this.Label10.TabIndex = 52;
			this.Label10.Text = "Delivery Date";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 35);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(81, 16);
			this.Label5.TabIndex = 4;
			this.Label5.Text = "Customer ID";
			this.dtpDELDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDELDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDELDT.Location = new System.Drawing.Point(99, 61);
			this.dtpDELDT.Name = "dtpDELDT";
			this.dtpDELDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDELDT.TabIndex = 5;
			dtpDELDT.Enabled = true;

            this.cbCUSID.BlankValue = null;
			this.cbCUSID.ComboboxWidth = 170;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = false;
			this.cbCUSID.Location = new System.Drawing.Point(99, 30);
			this.cbCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(325, 26);
			this.cbCUSID.TabIndex = 3;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(430, 35);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(86, 16);
			this.Label6.TabIndex = 52;
			this.Label6.Text = "Quotation No";
			this.chkCOMPLETED.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkCOMPLETED.AutoSize = true;
			this.chkCOMPLETED.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCOMPLETED.Location = new System.Drawing.Point(430, 121);
			this.chkCOMPLETED.Name = "chkCOMPLETED";
			this.chkCOMPLETED.Size = new System.Drawing.Size(93, 20);
			this.chkCOMPLETED.TabIndex = 10;
			this.chkCOMPLETED.Text = "Completed";
			this.chkCOMPLETED.UseVisualStyleBackColor = true;
			this.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label12.AutoSize = true;
			this.Label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label12.Location = new System.Drawing.Point(3, 93);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(77, 16);
			this.Label12.TabIndex = 53;
			this.Label12.Text = "Order Type";
			this.chkFOC.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.chkFOC.AutoSize = true;
			this.chkFOC.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkFOC.Location = new System.Drawing.Point(430, 91);
			this.chkFOC.Name = "chkFOC";
			this.chkFOC.Size = new System.Drawing.Size(54, 20);
			this.chkFOC.TabIndex = 8;
			this.chkFOC.Text = "FOC";
			this.chkFOC.UseVisualStyleBackColor = true;
			this.txtRECID.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtRECID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtRECID.Location = new System.Drawing.Point(430, 518);
			this.txtRECID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(61, 22);
			this.txtRECID.TabIndex = 14;
			this.txtRECID.TabStop = false;
			this.txtRECID.Text = "-1";
			this.txtRECID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtRECID.Visible = false;
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(430, 449);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(80, 16);
			this.Label19.TabIndex = 57;
			this.Label19.Text = "Packing Qty";
			this.numPACKING.AllowNegative = false;
			this.numPACKING.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPACKING.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numPACKING.DataChanged = false;
			this.numPACKING.Location = new System.Drawing.Point(544, 446);
			this.numPACKING.Name = "numPACKING";
			this.numPACKING.NumberFormat = "8.3";
			this.numPACKING.Size = new System.Drawing.Size(104, 22);
			this.numPACKING.TabIndex = 18;
			this.numPACKING.Text = "0.000";
			this.numPACKING.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPACKING.ThousandSeperator = false;
			this.numPACKING.Value = 0.0;
			this.lblSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTDWGT.AutoSize = true;
			this.lblSTDWGT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTDWGT.Location = new System.Drawing.Point(430, 420);
			this.lblSTDWGT.Name = "lblSTDWGT";
			this.lblSTDWGT.Size = new System.Drawing.Size(108, 16);
			this.lblSTDWGT.TabIndex = 52;
			this.lblSTDWGT.Text = "Standard Weight";
			this.Label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label13.AutoSize = true;
			this.Label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label13.Location = new System.Drawing.Point(3, 420);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(57, 16);
			this.Label13.TabIndex = 55;
			this.Label13.Text = "Packing";
            this.cbPACKING.BlankValue = null;
            this.cbPACKING.ComboboxWidth = 170;
            this.cbPACKING.DataTable = null;
            this.cbPACKING.DisplayMember = null;
            this.cbPACKING.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPACKING.HasBlankValue = false;
            this.cbPACKING.Location = new System.Drawing.Point(99, 30);
            this.cbPACKING.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPACKING.Name = "cbPACKING";
            this.cbPACKING.SelectedIndex = -1;
            this.cbPACKING.SelectedItem = null;
            this.cbPACKING.SelectedValue = null;
            this.cbPACKING.Size = new System.Drawing.Size(325, 26);
            this.cbPACKING.TabIndex = 3;
            this.cbPACKING.TextMultiline = true;
            this.cbPACKING.ValueMember = null;
            this.cbPACKING.WhereClause = null;

           
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(544, 417);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.3";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(104, 22);
			this.numSTDWGT.TabIndex = 60;
			this.numSTDWGT.TabStop = false;
			this.numSTDWGT.Text = "0.000";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(730, 390);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(113, 16);
			this.Label20.TabIndex = 61;
			this.Label20.Text = "Customer Part No";
			this.txtCPTNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCPTNO.Location = new System.Drawing.Point(849, 386);
			this.txtCPTNO.Name = "txtCPTNO";
			this.txtCPTNO.ReadOnly = true;
			this.txtCPTNO.Size = new System.Drawing.Size(180, 22);
			this.txtCPTNO.TabIndex = 62;
			this.cbQUONO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbQUONO.FormattingEnabled = true;
			this.cbQUONO.Location = new System.Drawing.Point(849, 31);
			this.cbQUONO.Name = "cbQUONO";
			this.cbQUONO.Size = new System.Drawing.Size(180, 24);
			this.cbQUONO.TabIndex = 77;
			this.cbQUONO.Visible = false;
			this.cbDELID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDELID.FormattingEnabled = true;
			this.cbDELID.Location = new System.Drawing.Point(99, 356);
			this.cbDELID.Name = "cbDELID";
			this.cbDELID.Size = new System.Drawing.Size(180, 24);
			this.cbDELID.TabIndex = 78;
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 5;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnDelete, 1, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPRINT, 4, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 3, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnConfirm, 2, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(630, 56);
			this.TableLayoutPanel6.TabIndex = 47;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSAVE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(3, 3);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 52;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = IMS.My.Resources.Resources.Delete;
			this.btnDelete.Location = new System.Drawing.Point(129, 3);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(120, 50);
			this.btnDelete.TabIndex = 19;
			this.btnDelete.Text = "Delete";
			this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnPRINT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINT.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINT.Location = new System.Drawing.Point(507, 3);
			this.btnPRINT.Name = "btnPRINT";
			this.btnPRINT.Size = new System.Drawing.Size(120, 50);
			this.btnPRINT.TabIndex = 21;
			this.btnPRINT.Text = "Print";
			this.btnPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPRINT.UseVisualStyleBackColor = false;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(381, 3);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(120, 50);
			this.btnBack.TabIndex = 20;
			this.btnBack.Text = "Back";
			this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnConfirm.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirm.Image = IMS.My.Resources.Resources.Confirm;
			this.btnConfirm.Location = new System.Drawing.Point(255, 3);
			this.btnConfirm.Name = "btnConfirm";
			this.btnConfirm.Size = new System.Drawing.Size(120, 50);
			this.btnConfirm.TabIndex = 53;
			this.btnConfirm.Text = "Confirm";
			this.btnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnConfirm.UseVisualStyleBackColor = false;
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.dgvHEADER);
			this.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(3, 2);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1350, 710);
			this.Panel2.TabIndex = 4;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Location = new System.Drawing.Point(4, 190);
			this.dgvHEADER.MultiSelect = true;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1271, 475);
			this.dgvHEADER.TabIndex = 0;
			this.dgvHEADER.TabStop = false;
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
			this.TableLayoutPanel4.Location = new System.Drawing.Point(4, 131);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(630, 56);
			this.TableLayoutPanel4.TabIndex = 9;
			this.btnDELETEFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDELETEFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnDELETEFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnDELETEFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnDELETEFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDELETEFR.Image = IMS.My.Resources.Resources.Delete;
			this.btnDELETEFR.Location = new System.Drawing.Point(255, 3);
			this.btnDELETEFR.Name = "btnDELETEFR";
			this.btnDELETEFR.Size = new System.Drawing.Size(120, 50);
			this.btnDELETEFR.TabIndex = 12;
			this.btnDELETEFR.Text = "Delete";
			this.btnDELETEFR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDELETEFR.UseVisualStyleBackColor = false;
			this.btnSEARCH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSEARCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSEARCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSEARCH.Image = IMS.My.Resources.Resources.Refresh;
			this.btnSEARCH.Location = new System.Drawing.Point(3, 3);
			this.btnSEARCH.Name = "btnSEARCH";
			this.btnSEARCH.Size = new System.Drawing.Size(120, 50);
			this.btnSEARCH.TabIndex = 10;
			this.btnSEARCH.Text = "Search";
			this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSEARCH.UseVisualStyleBackColor = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(507, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 14;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNew.Image = IMS.My.Resources.Resources._New;
			this.btnNew.Location = new System.Drawing.Point(129, 3);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(120, 50);
			this.btnNew.TabIndex = 11;
			this.btnNew.Text = "New";
			this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNew.UseVisualStyleBackColor = false;
			this.btnPRINTFR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnPRINTFR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnPRINTFR.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnPRINTFR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnPRINTFR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPRINTFR.Image = IMS.My.Resources.Resources.Print;
			this.btnPRINTFR.Location = new System.Drawing.Point(381, 3);
			this.btnPRINTFR.Name = "btnPRINTFR";
			this.btnPRINTFR.Size = new System.Drawing.Size(120, 50);
			this.btnPRINTFR.TabIndex = 13;
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
			this.TableLayoutPanel2.Controls.Add(this.chkZERO, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDFR, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOTO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbDOCNOFR, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.lblDOCNOTO, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.lblDOCNOFR, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label16, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTFR, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label17, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.dtpDOCDTTO, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbCUSIDTO, 3, 2);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(5, 12);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 4;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(798, 114);
			this.TableLayoutPanel2.TabIndex = 1;
			this.chkZERO.AutoSize = true;
			this.chkZERO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkZERO.Location = new System.Drawing.Point(110, 91);
			this.chkZERO.Name = "chkZERO";
			this.chkZERO.Size = new System.Drawing.Size(104, 20);
			this.chkZERO.TabIndex = 10;
			this.chkZERO.Text = "Show 0 Price";
			this.chkZERO.UseVisualStyleBackColor = true;
			this.cbCUSIDFR.BlankValue = null;
			this.cbCUSIDFR.ComboboxWidth = 170;
			this.cbCUSIDFR.DataTable = null;
			this.cbCUSIDFR.DisplayMember = null;
			this.cbCUSIDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDFR.HasBlankValue = true;
			this.cbCUSIDFR.Location = new System.Drawing.Point(109, 60);
			this.cbCUSIDFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbCUSIDFR.Name = "cbCUSIDFR";
			this.cbCUSIDFR.SelectedIndex = -1;
			this.cbCUSIDFR.SelectedItem = null;
			this.cbCUSIDFR.SelectedValue = null;
			this.cbCUSIDFR.Size = new System.Drawing.Size(326, 26);
			this.cbCUSIDFR.TabIndex = 10;
			this.cbCUSIDFR.TextMultiline = true;
			this.cbCUSIDFR.ValueMember = null;
			this.cbCUSIDFR.WhereClause = null;
			this.cbDOCNOTO.BlankValue = null;
			this.cbDOCNOTO.ComboboxWidth = 170;
			this.cbDOCNOTO.DataTable = null;
			this.cbDOCNOTO.DisplayMember = null;
			this.cbDOCNOTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOTO.HasBlankValue = true;
			this.cbDOCNOTO.Location = new System.Drawing.Point(470, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(326, 26);
			this.cbDOCNOTO.TabIndex = 10;
			this.cbDOCNOTO.TextMultiline = true;
			this.cbDOCNOTO.ValueMember = null;
			this.cbDOCNOTO.WhereClause = null;
			this.cbDOCNOFR.BlankValue = null;
			this.cbDOCNOFR.ComboboxWidth = 170;
			this.cbDOCNOFR.DataTable = null;
			this.cbDOCNOFR.DisplayMember = null;
			this.cbDOCNOFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDOCNOFR.HasBlankValue = true;
			this.cbDOCNOFR.Location = new System.Drawing.Point(109, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(326, 26);
			this.cbDOCNOFR.TabIndex = 10;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(440, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.lblDOCNOTO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDOCNOTO.AutoSize = true;
			this.lblDOCNOTO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDOCNOTO.Location = new System.Drawing.Point(440, 7);
			this.lblDOCNOTO.Name = "lblDOCNOTO";
			this.lblDOCNOTO.Size = new System.Drawing.Size(25, 16);
			this.lblDOCNOTO.TabIndex = 5;
			this.lblDOCNOTO.Text = "To";
			this.lblDOCNOFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDOCNOFR.AutoSize = true;
			this.lblDOCNOFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDOCNOFR.Location = new System.Drawing.Point(3, 7);
			this.lblDOCNOFR.Name = "lblDOCNOFR";
			this.lblDOCNOFR.Size = new System.Drawing.Size(90, 16);
			this.lblDOCNOFR.TabIndex = 2;
			this.lblDOCNOFR.Text = "Document No";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(440, 36);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(25, 16);
			this.Label16.TabIndex = 46;
			this.Label16.Text = "To";
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(110, 33);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 3;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 36);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(101, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Document Date";
			this.Label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label17.AutoSize = true;
			this.Label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label17.Location = new System.Drawing.Point(3, 65);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(81, 16);
			this.Label17.TabIndex = 47;
			this.Label17.Text = "Customer ID";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(471, 33);
			this.dtpDOCDTTO.Name = "dtpDOCDTTO";
			this.dtpDOCDTTO.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTTO.TabIndex = 4;
			this.cbCUSIDTO.BlankValue = null;
			this.cbCUSIDTO.ComboboxWidth = 170;
			this.cbCUSIDTO.DataTable = null;
			this.cbCUSIDTO.DisplayMember = null;
			this.cbCUSIDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSIDTO.HasBlankValue = true;
			this.cbCUSIDTO.Location = new System.Drawing.Point(470, 60);
			this.cbCUSIDTO.Margin = new System.Windows.Forms.Padding(2);
			this.cbCUSIDTO.Name = "cbCUSIDTO";
			this.cbCUSIDTO.SelectedIndex = -1;
			this.cbCUSIDTO.SelectedItem = null;
			this.cbCUSIDTO.SelectedValue = null;
			this.cbCUSIDTO.Size = new System.Drawing.Size(326, 26);
			this.cbCUSIDTO.TabIndex = 48;
			this.cbCUSIDTO.TextMultiline = true;
			this.cbCUSIDTO.ValueMember = null;
			this.cbCUSIDTO.WhereClause = null;
			this.txtQUONO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtQUONO.Location = new System.Drawing.Point(544, 31);
			this.txtQUONO.Name = "txtQUONO";
			this.txtQUONO.Size = new System.Drawing.Size(180, 22);
			this.txtQUONO.TabIndex = 79;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 700);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmSSEORD";
			base.Tag = "SSEORD";
			this.Text = "Sales Order";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmSSEORD_FormClosing(object sender, FormClosingEventArgs e)
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

		private bool ValidateDetailControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbCUSID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID cannot blank!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbCUSID.Select();
				return false;
			}
			if (DateTime.Compare(dtpDELDT.Value.Date, dtpDOCDT.Value.Date) < 0)
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery Date must exceed Document Date!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				dtpDELDT.Select();
				return false;
			}
			if (cbITMCD.SelectedValue == null)
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Select();
				return false;
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbITMCD.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code cannot blank!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbITMCD.Select();
				return false;
			}
			if (numQTY.Value == 0.0)
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity cannot be 0!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numQTY.Select();
				return false;
			}
			string strSQL = "SELECT * FROM MAITM_TBL WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
			strSQL = strSQL + "AND MAITM_MOQ > " + Conversions.ToString(Conversion.Val(numQTY.Value)) + " ";
			if (DB.RecordExists(strSQL))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity is less than minimum order quantity!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numQTY.Select();
				return false;
			}
			return true;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		bool IsNew = false;
		private void btnNew_Click(object sender, EventArgs e)
		{
			IsNew = true;
	

            Panel1.Visible = true;
			Panel2.Visible = false;
			ClearControl();
			ClearDetails();
			ManageOrderNo();
			RefreshGrid();
		}

		private void ManageOrderNo()
		{
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'SSEORD'"));
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
			}
			else
			{
				txtDOCNO.Enabled = true;
			}
		}

		private void ClearDetails()
		{
			txtRECID.Text = Conversions.ToString(-1);
			cbITMCD.SelectedIndex = -1;
			cbREVNO.SelectedIndex = -1;
			cbITMCD.Enabled = true;
			cbITMCD.TextBox1.Text = string.Empty;
			cbREVNO.Enabled = true;


			numQTY.Value = 0.0;
			numUPRICE.Value = 0.0;
			numAMT.Value = 0.0;
			lblREVNO.Visible = false;
			cbREVNO.Visible = false;
			btnADD.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Add");
		}

		private void ClearControl()
		{
			dgvDetails.ClearSelection();
			txtDOCNO.Text = string.Empty;
			lblSTSFG.Text = "0";
			cbCUSID.SelectedIndex = -1;
			cbQUONO.SelectedIndex = -1;
			txtQUONO.Text = string.Empty;
			dtpDOCDT.Value = DateAndTime.Now.Date;
			dtpDELDT.Value = DateAndTime.Now.Date;
			chkCOMPLETED.Checked = false;
			chkFOC.Checked = false;
			rdoNormal.Checked = true;
			txtEXPORD.Text = string.Empty;
			txtREFNO.Text = string.Empty;
			txtREMRK.Text = string.Empty;
			btnDelete.Enabled = false;
			btnSAVE.Enabled = false;
			btnADD.Enabled = true;
			btnConfirm.Enabled = false;
			btnPRINT.Enabled = false;
			btnREMOVE.Enabled = false;
			txtDOCNO.Enabled = true;
			dtpDOCDT.Enabled = true;
			cbCUSID.Enabled = true;
			txtREFNO.Enabled = true;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			string strMSG;
			if (Conversion.Val(txtRECID.Text) == -1.0)
			{
				strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Please select a item.");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure to delete this record?");
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No)
			{
				string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("DELETE SLORD_TBL WHERE SLORD_CUSID = '", cbCUSID.SelectedValue), "' "));
				strSQL = strSQL + "AND SLORD_DOCNO = '" + txtDOCNO.Text + "' ";
				strSQL = strSQL + "AND SLORD_RECID = '" + txtRECID.Text + "'";
				DB.ExecProc(strSQL);
				RefreshGrid();
				ClearDetails();
			}
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			ClearDetails();
			ClearControl();
			BindComboHeader();
			Header();
		}

		private void Header()
		{
			int i = 0;
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spSSORD ";
			strSQL += "'0', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(chkZERO.Checked, 1, 0)), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDOCNOTO.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTFR.Value) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDTTO.Value) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDFR.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSIDTO.SelectedValue), "' ")));
			DataTable dt = DB.ExecProc(strSQL, 120);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvHEADER.ClearSelection();
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Date");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Time");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Type");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quo No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Expected Order");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ref No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Remark");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Enter By");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "SLORD_STSFG");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "SLORD_COMFG");
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.Refresh();
					dataGridView = null;
				}
				Panel2.Visible = true;
				Panel1.Visible = false;
			}
		}

		private void BindComboHeader()
		{
			cbDOCNOFR.DataTable = "SLORD_TBL  WITH (NOLOCK) ";
			cbDOCNOFR.ValueMember = "SLORD_DOCNO";
			cbDOCNOFR.DisplayMember = "SLORD_DOCNO";
			cbDOCNOFR.LoadData();
			cbDOCNOTO.DataTable = "SLORD_TBL WITH (NOLOCK) ";
			cbDOCNOTO.ValueMember = "SLORD_DOCNO";
			cbDOCNOTO.DisplayMember = "SLORD_DOCNO";
			cbDOCNOTO.LoadData();
			cbCUSIDFR.DataTable = "MACUS_TBL  WITH (NOLOCK) ";
			cbCUSIDFR.ValueMember = "MACUS_CUSID";
			cbCUSIDFR.DisplayMember = "MACUS_CUSID";
			cbCUSIDFR.LoadData();
			cbCUSIDTO.DataTable = "MACUS_TBL WITH (NOLOCK) ";
			cbCUSIDTO.ValueMember = "MACUS_CUSID";
			cbCUSIDTO.DisplayMember = "MACUS_CUSID";
			cbCUSIDTO.LoadData();
		}

		private void BindComboBox()
		{
			cbCUSID.DataTable = "MACUS_TBL  WITH (NOLOCK) ";
			cbCUSID.ValueMember = "MACUS_CUSID";
			cbCUSID.DisplayMember = "MACUS_SHORT";
			cbCUSID.LoadData();
			string strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'SLPRS' ORDER BY MACOD_CODID";
			cbSLMAN.ValueMember = "MACOD_CODID";
			cbSLMAN.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbSLMAN);
            cbPACKING.DataTable = "MACOD_TBL WITH(NOLOCK) ";
            cbPACKING.WhereClause = "MACOD_CTYID = 'PACKING' ";
            cbPACKING.ValueMember = "MACOD_CODID";
            cbPACKING.DisplayMember = "MACOD_CODID";
            cbPACKING.LoadData();
            //strSQL = "SELECT DISTINCT MAITM_ITMCD, MAITM_SUBCATCD, MAITM_STDWGT FROM MAITM_TBL WITH (NOLOCK) WHERE MAITM_GRPCD = 'PACKING' ORDER BY MAITM_ITMCD";
            //         cbPACKING.ComboBox1.ValueMember = "MAITM_ITMCD";
            //         cbPACKING.ComboBox1.DisplayMember = "MAITM_ITMCD";
            //         cbPACKING.ValueMember = "MAITM_ITMCD";
            //         cbPACKING.DisplayMember = "MAITM_ITMCD";
            //cbPACKING.DataTable = "MAITM_TBL WITH (NOLOCK)  ";
            //cbPACKING.WhereClause = "MAITM_GRPCD = 'PACKING'";

            //cbPACKING.LoadData();
            //List<String> listPacking = new List<string>();
            //foreach (PackingCost packingCost in G.listPackingCost)
            //{
            //	listPacking.Add(packingCost.codePacking);
            //}
            //cbPACKING.ComboBox1.DataSource = listPacking;

            //Common.RetriveComboItembySQL(strSQL, cbPACKING.ComboBox1);
            BindLabel();
		}

		private void BindLabel()
		{
			string strUOM = Conversions.ToString(DB.GetColumnValue("LMSYS_BUOM", "LMSYS_TBL", ""));
			lblSTDWGT.Text = "Standard Weight (" + strUOM + ")";
			lblQTY.Text = "Quantity (" + strUOM + ")";
		}

		private void RefreshGrid()
		{
			int i = 0;
			dgvDetails.DataSource = null;
			string strSQL = "SELECT SLORD_RECID, SLORD_DELID, SLORD_SLMAN, SLORD_ITMCD, SLORD_REVNO, SLORD_PACKING, MAITM_DESC, ";
			strSQL += "SLORD_SOQTY, SLORD_UPRICE, SLORD_AMT ";
			strSQL += "FROM SLORD_TBL ";
			strSQL += "LEFT JOIN MAITM_TBL ";
			strSQL += "ON MAITM_ITMCD = SLORD_ITMCD ";
			strSQL = strSQL + "WHERE SLORD_DOCNO = '" + txtDOCNO.Text + "' ";
			strSQL += "ORDER BY SLORD_RECID";
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvDetails;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = false;
			dataGridView.Columns[i].Width = 100;
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].HeaderText = "RECID";
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Delivery ID");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Salesman");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 150;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item Code");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Packing");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 200;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 100;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "Unit Price";
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].HeaderText = "Amount";
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Amount);
				dataGridView.Refresh();
				dataGridView = null;
			}
		}

		private void btnADD_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) != 0)
			{
				string strSQL = "SLORD_DOCNO = '" + txtDOCNO.Text + "'";
				string strENTBY = Conversions.ToString(DB.GetColumnValue("SLORD_ENTBY", "SLORD_TBL", strSQL));
				if (!Common.gfAllowEdit(strENTBY))
				{
					MessageBox.Show("This document is view only!\r\nOnly Supervisor user or document creator is allowed to amend.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
			}
			if (ValidateDetailControl() && spSSEORD("0"))
			{
				RefreshGrid();
				ClearDetails();
				btnSAVE.Enabled = true;
				if (Operators.CompareString(lblSTSFG.Text, "0", false) == 0)
				{
					btnConfirm.Enabled = true;
				}
				else
				{
					btnConfirm.Enabled = false;
				}
				btnDelete.Enabled = true;
				btnPRINT.Enabled = true;
				dtpDOCDT.Enabled = false;
				cbCUSID.Enabled = false;
			}
		}

		private bool spSSEORD(string strPRO)
		{
			string strNextNo = "";
			string strSQL = Conversions.ToString(DB.GetColumnValue("MANUM_CNTRLNO", "MANUM_TBL", "MANUM_PRGID = 'SSEORD'"));
			bool spSSEORD;
			if (Operators.CompareString(strSQL, "1", false) == 0)
			{
				txtDOCNO.Enabled = false;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					if (!Common.gfAutoNum("SSEORD", "SLORD", ref strNextNo))
					{
						string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank! Please check document number control.");
						MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						txtDOCNO.Focus();
						spSSEORD = false;
						goto IL_0524;
					}
					txtDOCNO.Text = strNextNo;
				}
			}
			else
			{
				txtDOCNO.Enabled = true;
				if (Operators.CompareString(txtDOCNO.Text.Trim(), "", false) == 0)
				{
					string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No cannot blank!");
					MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					txtDOCNO.Focus();
					spSSEORD = false;
					goto IL_0524;
				}
			}
			int TYPE = default(int);
			if (rdoNormal.Checked)
			{
				TYPE = 0;
			}
			if (rdoSample.Checked)
			{
				TYPE = 1;
			}
			if (rdoProcessing.Checked)
			{
				TYPE = 2;
			}
			strSQL = "EXEC spSSEORD ";
			strSQL = strSQL + "'" + strPRO + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(txtRECID.Text)) + "', ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDOCDT.Value) + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(TYPE) + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Common.gfSQLDate(dtpDELDT.Value) + "', ";
			strSQL = strSQL + "'" + txtQUONO.Text + "', ";
			strSQL = strSQL + "'" + txtEXPORD.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbDELID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSLMAN.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbITMCD.SelectedValue), "', ")));
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue))) + "', ";
			strSQL = strSQL + "'" + txtREFNO.Text + "', ";
			
			if(cbPACKING.SelectedValue!=null)
               
            strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbPACKING.SelectedValue), "', ")));
			else
                strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", "CAN20"), "', ")));


            strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(numQTY.Value)) + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(numUPRICE.Value)) + "', ";
			strSQL = strSQL + "'" + Conversions.ToString(Conversion.Val(numAMT.Value)) + "', ";
			strSQL = strSQL + "'" + txtREMRK.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(chkFOC.Checked, 1, 0)), "', ")));
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";

            string strSQL2 = "UPDATE SLORD_TBL SET ";
            strSQL2 = strSQL2 + Operators.ConcatenateObject(Operators.ConcatenateObject( "SLORD_COMFG = '", Interaction.IIf(chkCOMPLETED.Checked, 1, 0)), "', ");
            strSQL2 = strSQL2 + "SLORD_DELDT = '" + Common.gfSQLDate(dtpDELDT.Value) + "', ";
            strSQL2 = strSQL2 + "SLORD_REFNO = '" + Common.gfValidSQLStr(txtREFNO.Text) + "', ";
            strSQL2 = strSQL2 + "SLORD_REMRK = '" + Common.gfValidSQLStr(txtREMRK.Text) + "' ";
            strSQL2 = strSQL2 + "WHERE SLORD_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
            try
            {
                cmd.Connection = DB.GetDBConnection();
                cmd.CommandText = strSQL2;
                int intAffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex2)
            {
                ProjectData.SetProjectError(ex2);
                Exception ex = ex2;
                MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
 
            }
            MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

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
				spSSEORD = false;
				ProjectData.ClearProjectError();
				goto IL_0524;
			}
			if (Operators.CompareString(strPRO, "0", false) == 0)
			{
				MessageBox.Show("Record saved!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				MessageBox.Show("Record deleted!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			spSSEORD = true;
			goto IL_0524;
			IL_0524:
			return spSSEORD;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
			strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			strMSG = strMSG + " : " + txtDOCNO.Text;
			if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
			{
				spSSEORD("1");
				ClearDetails();
				ClearControl();
				BindComboHeader();
				Header();
			}
		}

		private void NumberFormat()
		{
			numQTY.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Quantity);
			numUPRICE.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Price);
			numAMT.NumberFormat = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.NumControl, PublicEnum.NumberFormatEnum.Amount);
		}

		private void frmSSEORD_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			BindComboBox();
			dtpDOCDTFR.Value = DateAndTime.Today.AddMonths(-1);
			Header();
			NumberFormat();
		}

		private void BindHeadertoControl()
		{
			txtDOCNO.Text = dgvHEADER.CurrentRow.Cells["SLORD_DOCNO"].Value.ToString();
			lblSTSFG.Text = dgvHEADER.CurrentRow.Cells["SLORD_STSFG"].Value.ToString();
			txtEXPORD.Text = dgvHEADER.CurrentRow.Cells["SLORD_EXPORD"].Value.ToString();
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["SLORD_DOCDT"].Value);
			dtpENTDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["SLORD_ENTDT"].Value);
			cbCUSID.SelectedValue = dgvHEADER.CurrentRow.Cells["SLORD_CUSID"].Value.ToString();
			cbQUONO.SelectedValue = dgvHEADER.CurrentRow.Cells["SLORD_QUONO"].Value.ToString();
			txtQUONO.Text = dgvHEADER.CurrentRow.Cells["SLORD_QUONO"].Value.ToString();
			dtpDELDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["SLORD_DELDT"].Value);
			txtREFNO.Text = dgvHEADER.CurrentRow.Cells["SLORD_REFNO"].Value.ToString();
			txtREMRK.Text = dgvHEADER.CurrentRow.Cells["SLORD_REMRK"].Value.ToString();
			chkCOMPLETED.Checked = Conversions.ToBoolean(dgvHEADER.CurrentRow.Cells["SLORD_COMFG"].Value.ToString());
			if (Operators.ConditionalCompareObjectEqual(dgvHEADER.CurrentRow.Cells["SLORD_TYPE"].Value, 0, false))
			{
				rdoNormal.Checked = true;
			}
			if (Operators.ConditionalCompareObjectEqual(dgvHEADER.CurrentRow.Cells["SLORD_TYPE"].Value, 1, false))
			{
				rdoSample.Checked = true;
			}
			if (Operators.ConditionalCompareObjectEqual(dgvHEADER.CurrentRow.Cells["SLORD_TYPE"].Value, 2, false))
			{
				rdoProcessing.Checked = true;
			}
			if (Operators.ConditionalCompareObjectEqual(dgvHEADER.CurrentRow.Cells["SLORD_FOCFG"].Value, 1, false))
			{
				chkFOC.Checked = true;
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindHeadertoControl();
			RefreshGrid();
			ClearDetails();
			Panel1.Visible = true;
			Panel2.Visible = false;
			if (Operators.CompareString(lblSTSFG.Text, "0", false) == 0)
			{
				btnADD.Enabled = true;
				btnSAVE.Enabled = true;
				btnREMOVE.Enabled = true;
				btnDelete.Enabled = true;
				btnConfirm.Enabled = true;
			}
			else
			{
				btnADD.Enabled = PublicVar.gblnSupervisor;
				btnSAVE.Enabled = PublicVar.gblnSupervisor;
				btnREMOVE.Enabled = PublicVar.gblnSupervisor;
				btnDelete.Enabled = PublicVar.gblnSupervisor;
				btnConfirm.Enabled = false;
			}
			btnCancel.Enabled = true;
			btnPRINT.Enabled = true;
			txtDOCNO.Enabled = false;
			dtpDOCDT.Enabled = false;
			cbCUSID.Enabled = false;
		}

		private void BindGridtoControl()
		{
			txtRECID.Text = Conversions.ToString(dgvDetails.CurrentRow.Cells["SLORD_RECID"].Value);
			cbITMCD.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["SLORD_ITMCD"].Value);
			cbREVNO.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["SLORD_REVNO"].Value);
			cbDELID.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["SLORD_DELID"].Value);
			cbSLMAN.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["SLORD_SLMAN"].Value);
			cbPACKING.SelectedValue = RuntimeHelpers.GetObjectValue(dgvDetails.CurrentRow.Cells["SLORD_PACKING"].Value);
			numQTY.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["SLORD_SOQTY"].Value);
			numPACKING.Value = Math.Round(numQTY.Value / numSTDWGT.Value, 2);
			numUPRICE.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["SLORD_UPRICE"].Value);
			numAMT.Value = Conversions.ToDouble(dgvDetails.CurrentRow.Cells["SLORD_AMT"].Value);
		}

		private void CalculateAMT()
		{
			numAMT.Value = Common.gfRound(numQTY.Value * numUPRICE.Value, 2);
		}

		private void dgvDetails_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			BindGridtoControl();
			cbITMCD.Enabled = false;
			cbREVNO.Enabled = false;
			btnREMOVE.Enabled = true;
			btnADD.Text = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Update");
		}

		private void numQTY_TextChanged(object sender, EventArgs e)
		{
			CalculateAMT();
		}

		private void numUPRICE_TextChanged(object sender, EventArgs e)
		{
			CalculateAMT();
		}

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}
		
		private void btnDELETEFR_Click(object sender, EventArgs e)
		{
			if (dgvHEADER.RowCount != 0)
			{
                string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Are you sure want to delete this record?") + "\r\n";
                strMSG += Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");

                if (MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.No)
                {
					foreach (DataGridViewRow row in dgvHEADER.SelectedRows)
					{
						string strDOCNO = row.Cells["SLORD_DOCNO"].Value.ToString();
						string strSQL = "DELETE SLORD_TBL WHERE SLORD_DOCNO = '" + strDOCNO + "' ";
						DB.DBExecute(strSQL);
					}
                    MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record deleted!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Header();
                }
			}
		}

		private void cbDOCNOFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbDOCNOFR.SelectedIndex != -1)
			{
				cbDOCNOTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbDOCNOFR.SelectedValue);
			}
		}

		private void cbCUSIDFR_SelectedValueChanged(object sender, EventArgs e)
		{
			if (cbCUSIDFR.SelectedIndex != -1)
			{
				cbCUSIDTO.SelectedValue = RuntimeHelpers.GetObjectValue(cbCUSIDFR.SelectedValue);
			}
		}

		private void BindRevNo()
		{
			string strTYPE = Conversions.ToString(DB.GetColumnValue("MAITM_ITMTY", "MAITM_TBL WITH(NOLOCK)", "MAITM_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' AND MAITM_ACTFG = -1 "));
			string strSQL = "SELECT 0 AS MACPT_REVNO ";
			strSQL += "UNION ";
			strSQL += "SELECT DISTINCT ISNULL(MACPT_REVNO, 0) AS MACPT_REVNO ";
			strSQL += "FROM MACPT_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MACPT_ITMCD = MAITM_ITMCD  ";
			strSQL += "LEFT JOIN MABOM_TBL WITH (NOLOCK) ON MACPT_ITMCD = MABOM_MDLCD AND MACPT_REVNO = MABOM_REVNO ";
			strSQL += "WHERE MAITM_ITMTY = '1' AND MAITM_ACTFG = -1 AND MABOM_ACTFG = 1 ";
			strSQL = strSQL + "AND MACPT_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
			strSQL = strSQL + "AND MACPT_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
			strSQL += "ORDER BY MACPT_REVNO ";
			cbREVNO.ValueMember = "MACPT_REVNO";
			cbREVNO.DisplayMember = "MACPT_REVNO";
			Common.RetriveComboItembySQL(strSQL, cbREVNO);
			if (Operators.CompareString(strTYPE, "1", false) == 0)
			{
				strSQL = "SELECT DISTINCT ISNULL(MACPT_REVNO, 0) AS MACPT_REVNO ";
				strSQL += "FROM MACPT_TBL WITH (NOLOCK) ";
				strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MACPT_ITMCD = MAITM_ITMCD  ";
				strSQL += "LEFT JOIN MABOM_TBL WITH (NOLOCK) ON MACPT_ITMCD = MABOM_MDLCD AND MACPT_REVNO = MABOM_REVNO ";
				strSQL += "WHERE MAITM_ITMTY = '1' AND MAITM_ACTFG = -1 AND MABOM_ACTFG = 1 ";
				strSQL = strSQL + "AND MACPT_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
				strSQL = strSQL + "AND MACPT_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
				strSQL += "ORDER BY MACPT_REVNO ";
				cbREVNO.ValueMember = "MACPT_REVNO";
				cbREVNO.DisplayMember = "MACPT_REVNO";
				Common.RetriveComboItembySQL(strSQL, cbREVNO);
				lblREVNO.Visible = true;
				cbREVNO.Visible = true;
			}
			else
			{
				lblREVNO.Visible = false;
				cbREVNO.Visible = false;
			}
		}

		private void btnPRINT_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void btnPRINTFR_Click(object sender, EventArgs e)
		{
			DisplayReport();
		}

		private void DisplayReport()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "SALES ORDER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptSSORD.rpt";
			if (Operators.CompareString(txtDOCNO.Text, "", false) != 0)
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1,@SHOWZERO=0,@DOCNOFR=" + txtDOCNO.Text + ",@DOCNOTO=" + txtDOCNO.Text + ",@DOCDTFR=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@DOCDTTO=" + Common.gfSQLDate(dtpDOCDT.Value) + ",@CUSIDFR=", cbCUSID.SelectedValue), ",@CUSIDTO="), cbCUSID.SelectedValue), ""));
			}
			else
			{
				frmRPT.Params = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("@PAR=1,@SHOWZERO=0,@DOCNOFR=", cbDOCNOFR.SelectedValue), ",@DOCNOTO="), cbDOCNOTO.SelectedValue), ",@DOCDTFR="), Common.gfSQLDate(dtpDOCDTFR.Value)), ",@DOCDTTO="), Common.gfSQLDate(dtpDOCDTTO.Value)), ",@CUSIDFR="), cbCUSIDFR.SelectedValue), ",@CUSIDTO="), cbCUSIDTO.SelectedValue), ""));
			}
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='SALES ORDER',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ViewReport("");
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			if (ValidateHeaderControl())
			{
				string strSQL = "UPDATE SLORD_TBL SET ";
				strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("SLORD_COMFG = '", Interaction.IIf(chkCOMPLETED.Checked, 1, 0)), "', ")));
				strSQL = strSQL + "SLORD_DELDT = '" + Common.gfSQLDate(dtpDELDT.Value) + "', ";
				strSQL = strSQL + "SLORD_REFNO = '" + Common.gfValidSQLStr(txtREFNO.Text) + "', ";
				strSQL = strSQL + "SLORD_REMRK = '" + Common.gfValidSQLStr(txtREMRK.Text) + "' ";
				strSQL = strSQL + "WHERE SLORD_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
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
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated."), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		private bool ValidateHeaderControl()
		{
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cbCUSID.SelectedValue, null, "Trim", new object[0], null, null, null), "", false))
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Customer ID cannot blank!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				cbCUSID.Select();
				return false;
			}
			if (DateTime.Compare(dtpDELDT.Value.Date, dtpDOCDT.Value.Date) < 0)
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Delivery Date!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				dtpDELDT.Focus();
				return false;
			}
			if (dgvDetails.Rows.Count == 0)
			{
				string strMSG = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Incomplete Sales Order!");
				MessageBox.Show(strMSG, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			return true;
		}

		private void rdoNormal_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoNormal.Checked)
			{
				rdoSample.Checked = false;
				rdoProcessing.Checked = false;
			}
		}

		private void rdoSample_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoSample.Checked)
			{
				rdoNormal.Checked = false;
				rdoProcessing.Checked = false;
			}
		}

		private void rdoProcessing_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoProcessing.Checked)
			{
				rdoNormal.Checked = false;
				rdoSample.Checked = false;
			}
		}

		private void cbCUSID_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT DISTINCT QOCQO_QUONO FROM QOCQO_TBL WITH (NOLOCK) WHERE QOCQO_CUSID = '", cbCUSID.SelectedValue), "'"));
			cbQUONO.ValueMember = "QOCQO_QUONO";
			cbQUONO.DisplayMember = "QOCQO_QUONO";
			Common.RetriveComboItembySQL(strSQL, cbQUONO);
			strSQL = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT MADEL_DELID FROM MADEL_TBL WITH (NOLOCK) WHERE MADEL_CUSID = '", cbCUSID.SelectedValue), "'"));
			cbDELID.ValueMember = "MADEL_DELID";
			cbDELID.DisplayMember = "MADEL_DELID";
			Common.RetriveComboItembySQL(strSQL, cbDELID);
			string strWHERE = "(MAITM_ITMTY = '0' AND MAITM_SLITM = 1) OR (MAITM_ITMTY = '1' AND MACPT_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "')";
			cbITMCD.DataTable = "MAITM_TBL WITH (NOLOCK) LEFT JOIN MACPT_TBL ON MACPT_ITMCD = MAITM_ITMCD";
			cbITMCD.WhereClause = strWHERE;
			cbITMCD.ValueMember = "MAITM_ITMCD";
			cbITMCD.DisplayMember = "MACPT_CPTNO";
			cbITMCD.LoadData();
		}
		bool IsLoad = false;
		private void cbPACKING_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbPACKING.SelectedValue == null) return;
                if (!IsLoad)
			{
				IsLoad = true;
				return;

            }	
            lblSTDWGT.Text = "Standard Weight (" + UOM + ")";
            lblQTY.Text = "Quantity (" + UOM + ")";
			if (!UOM.ToLower().Trim().Contains("kg"))
			{
				numSTDWGT.Value = 1;
				cbPACKING.SelectedValue = "Kg";

			}
			else
			{

				numSTDWGT.Value = Conversions.ToInteger(DB.GetColumnValue("MACOD_NFLD1", "MACOD_TBL", "MACOD_CTYID = 'PACKING' AND MACOD_CODID = '" + Common.gfValidSQLStr(Conversions.ToString(cbPACKING.SelectedValue)) + "'"));
//            Conversions.ToDouble(G.listPackingCost[G.listPackingCost.FindIndex(a => a.codePacking.Contains(cbPACKING.SelectedValue.ToString()))].STDWGT); // NewLateBinding.LateIndexGet(cbPACKING.ComboBox1.SelectedItem, new object[1] { "MAITM_STDWGT" }, null)); ;// ;

            }
            numPACKING.Value = Math.Round(numQTY.Value / numSTDWGT.Value, 2);
		
		}

		private void numQTY_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return) | e.KeyCode.Equals(Keys.Tab))
			{
				numPACKING.Value = Math.Round(numQTY.Value / numSTDWGT.Value, 2);
			}
		}

		private void numPACKING_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return) | e.KeyCode.Equals(Keys.Tab))
			{
				numQTY.Value = numSTDWGT.Value * numPACKING.Value;
			}
		}

		private void frmSSEORD_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Confirm order?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
			{
				string strSQL = "UPDATE SLORD_TBL SET SLORD_STSFG = 1 WHERE SLORD_DOCNO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "'";
				DB.DBExecute(strSQL);
			//	MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Order confirmed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Header();
				ClearControl();
				ClearDetails();
			}
		}

		private void cbREVNO_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strWHERE = "MACPT_CUSID = '" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "' ";
			strWHERE = strWHERE + "AND MACPT_ITMCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "' ";
			strWHERE = strWHERE + "AND MACPT_REVNO = " + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(Interaction.IIf(cbREVNO.SelectedValue == null, 0, RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue)))));
			txtCPTNO.Text = Conversions.ToString(DB.GetColumnValue("MACPT_CPTNO", "MACPT_TBL", strWHERE));
		}
        String UOM = "";
        private void cbITMCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			//
			if (cbITMCD.SelectedValue == null) return;
			String sItemCode = Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue));
		DataTable dt=	DB.GetTable("MAITM_UOM", "MAITM_TBL", "MAITM_ITMCD='" + sItemCode + "'", "");
            if (dt!=null)
        if (dt.Rows.Count>0)
			{
				UOM = dt.Rows[0][0].ToString();
				
					
            }
			if (cbCUSID.SelectedIndex != -1)
			{
				BindRevNo();
				string strWHERE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("QOCQO_CUSID = '", cbCUSID.SelectedValue), "' "));
				strWHERE = Conversions.ToString(Operators.ConcatenateObject(strWHERE, Operators.ConcatenateObject(Operators.ConcatenateObject("AND QOCQO_QUONO = '", cbQUONO.SelectedValue), "' ")));
				strWHERE = Conversions.ToString(Operators.ConcatenateObject(strWHERE, Operators.ConcatenateObject(Operators.ConcatenateObject("AND QOCQO_MDLCD = '", cbITMCD.SelectedValue), "' ")));
				strWHERE = Conversions.ToString(Operators.ConcatenateObject(strWHERE, Operators.ConcatenateObject("AND QOCQO_REVNO = ", Interaction.IIf(cbREVNO.SelectedValue == null, 0, RuntimeHelpers.GetObjectValue(cbREVNO.SelectedValue)))));
				double dblSLPRC = Conversions.ToDouble(DB.GetColumnValue("QOCQO_PRICE", "QOCQO_TBL", strWHERE));
				if (dblSLPRC == 0.0)
				{
					strWHERE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASPR_CUSID = '", cbCUSID.SelectedValue), "' "));
					strWHERE = Conversions.ToString(Operators.ConcatenateObject(strWHERE, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MASPR_ITMCD = '", cbITMCD.SelectedValue), "' ")));
					strWHERE = strWHERE + "AND MASPR_EFFDT <= '" + Common.gfSQLDate(dtpDOCDT.Value) + "'";
					DateTime dtEFFDT = Conversions.ToDate(DB.GetColumnValue("MAX(MASPR_EFFDT)", "MASPR_TBL", strWHERE));
					strWHERE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MASPR_CUSID = '", cbCUSID.SelectedValue), "' "));
					strWHERE = Conversions.ToString(Operators.ConcatenateObject(strWHERE, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MASPR_ITMCD = '", cbITMCD.SelectedValue), "' ")));
					strWHERE = strWHERE + "AND MASPR_EFFDT = '" + Common.gfSQLDate(dtEFFDT) + "'";
					dblSLPRC = Conversions.ToDouble(DB.GetColumnValue("MASPR_PRICE", "MASPR_TBL", strWHERE));
				}
				if (dblSLPRC == 0.0)
				{
					strWHERE = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ITMCD = '", cbITMCD.SelectedValue), "'"));
					dblSLPRC = Conversions.ToDouble(DB.GetColumnValue("MAITM_SLPRC", "MAITM_TBL", strWHERE));
				}
				numUPRICE.Value = dblSLPRC;
			}
            lblSTDWGT.Text = "Standard Weight (" + UOM + ")";
            lblQTY.Text = "Quantity (" + UOM + ")";
            if (!UOM.ToLower().Trim().Contains("kg"))
            {
				cbPACKING.SelectedValue = "01M3";

                cbPACKING.Enabled = false;
                numSTDWGT.Value = 1;
				
                cbPACKING.SelectedValue = "";
            }
			else
                cbPACKING.Enabled = true;
        }
	}
}
