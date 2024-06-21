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
	public class frmPDEWKB : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvPDWKB")]
		private DataGridView _dgvPDWKB;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnPrint")]
		private Button _btnPrint;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnBack")]
		private Button _btnBack;

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
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnREMOVE")]
		private Button _btnREMOVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCANCEL")]
		private Button _btnCANCEL;

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

		[field: AccessedThroughProperty("txtDOCNO")]
		internal virtual TextBox txtDOCNO
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

		[field: AccessedThroughProperty("Label19")]
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DataGridView dgvPDWKB
		{
			[CompilerGenerated]
			get
			{
				return _dgvPDWKB;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellMouseEventHandler value2 = dgvPDWKB_CellMouseClick;
				DataGridView dataGridView = _dgvPDWKB;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvPDWKB = value;
				dataGridView = _dgvPDWKB;
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

		[field: AccessedThroughProperty("TableLayoutPanel6")]
		internal virtual TableLayoutPanel TableLayoutPanel6
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

		[field: AccessedThroughProperty("lblWKOQTY")]
		internal virtual Label lblWKOQTY
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
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

		[field: AccessedThroughProperty("dtpENTDT")]
		internal virtual DateTimePicker dtpENTDT
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

		[field: AccessedThroughProperty("numWOQTY")]
		internal virtual NumControl numWOQTY
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

		[field: AccessedThroughProperty("numREVNO")]
		internal virtual NumControl numREVNO
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
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

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
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

		[field: AccessedThroughProperty("lblQTY")]
		internal virtual Label lblQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numPARQT")]
		internal virtual NumControl numPARQT
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

		[field: AccessedThroughProperty("numSEQNO")]
		internal virtual NumControl numSEQNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPDEWKB()
		{
			base.FormClosing += frmPDEWKB_FormClosing;
			base.Shown += frmPDEWKB_Shown;
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
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.cbSTAGE = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.cbBOMPN = new IMS.ComboboxControl();
			this.Label5 = new System.Windows.Forms.Label();
			this.numREVNO = new IMS.NumControl();
			this.numTOLRN = new IMS.NumControl();
			this.txtTYPE = new System.Windows.Forms.TextBox();
			this.numWOQTY = new IMS.NumControl();
			this.txtMDLCD = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDOCNO = new System.Windows.Forms.TextBox();
			this.dgvPDWKB = new System.Windows.Forms.DataGridView();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.lblWKOQTY = new System.Windows.Forms.Label();
			this.dtpENTDT = new System.Windows.Forms.DateTimePicker();
			this.dtpDOCDT = new System.Windows.Forms.DateTimePicker();
			this.lblQTY = new System.Windows.Forms.Label();
			this.numPARQT = new IMS.NumControl();
			this.txtRECID = new System.Windows.Forms.TextBox();
			this.numSEQNO = new IMS.NumControl();
			this.Label6 = new System.Windows.Forms.Label();
			this.TableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
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
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvPDWKB).BeginInit();
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
			this.Panel1.Size = new System.Drawing.Size(1348, 630);
			this.Panel1.TabIndex = 3;
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
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 0, 6);
			this.TableLayoutPanel1.Controls.Add(this.cbSTAGE, 1, 5);
			this.TableLayoutPanel1.Controls.Add(this.Label7, 0, 5);
			this.TableLayoutPanel1.Controls.Add(this.cbBOMPN, 1, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label5, 0, 4);
			this.TableLayoutPanel1.Controls.Add(this.numREVNO, 5, 1);
			this.TableLayoutPanel1.Controls.Add(this.numTOLRN, 5, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtTYPE, 2, 2);
			this.TableLayoutPanel1.Controls.Add(this.numWOQTY, 1, 2);
			this.TableLayoutPanel1.Controls.Add(this.txtMDLCD, 1, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 4, 2);
			this.TableLayoutPanel1.Controls.Add(this.Label16, 4, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label4, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.txtDOCNO, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.dgvPDWKB, 0, 3);
			this.TableLayoutPanel1.Controls.Add(this.Label10, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label19, 4, 1);
			this.TableLayoutPanel1.Controls.Add(this.lblWKOQTY, 0, 2);
			this.TableLayoutPanel1.Controls.Add(this.dtpENTDT, 6, 0);
			this.TableLayoutPanel1.Controls.Add(this.dtpDOCDT, 5, 0);
			this.TableLayoutPanel1.Controls.Add(this.lblQTY, 4, 5);
			this.TableLayoutPanel1.Controls.Add(this.numPARQT, 5, 5);
			this.TableLayoutPanel1.Controls.Add(this.txtRECID, 6, 4);
			this.TableLayoutPanel1.Controls.Add(this.numSEQNO, 5, 4);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 4, 4);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(14, 70);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 7;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(752, 579);
			this.TableLayoutPanel1.TabIndex = 0;
			this.TableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel5.AutoSize = true;
			this.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel5.ColumnCount = 3;
			this.TableLayoutPanel1.SetColumnSpan(this.TableLayoutPanel5, 5);
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel5.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.btnCANCEL, 2, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(4, 523);
			this.TableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(384, 54);
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
			this.cbSTAGE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTAGE.FormattingEnabled = true;
			this.cbSTAGE.Location = new System.Drawing.Point(99, 494);
			this.cbSTAGE.Name = "cbSTAGE";
			this.cbSTAGE.Size = new System.Drawing.Size(168, 24);
			this.cbSTAGE.TabIndex = 84;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 498);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(44, 16);
			this.Label7.TabIndex = 83;
			this.Label7.Text = "Stage";
			this.cbBOMPN.BlankValue = null;
			this.TableLayoutPanel1.SetColumnSpan(this.cbBOMPN, 3);
			this.cbBOMPN.ComboboxWidth = 170;
			this.cbBOMPN.DataTable = null;
			this.cbBOMPN.DisplayMember = null;
			this.cbBOMPN.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBOMPN.HasBlankValue = true;
			this.cbBOMPN.Location = new System.Drawing.Point(99, 464);
			this.cbBOMPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbBOMPN.Name = "cbBOMPN";
			this.cbBOMPN.SelectedIndex = -1;
			this.cbBOMPN.SelectedItem = null;
			this.cbBOMPN.SelectedValue = null;
			this.cbBOMPN.Size = new System.Drawing.Size(323, 25);
			this.cbBOMPN.TabIndex = 80;
			this.cbBOMPN.TextMultiline = true;
			this.cbBOMPN.ValueMember = null;
			this.cbBOMPN.WhereClause = null;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 468);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(65, 16);
			this.Label5.TabIndex = 79;
			this.Label5.Text = "BOM Part";
			this.numREVNO.AllowNegative = false;
			this.numREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numREVNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numREVNO.DataChanged = false;
			this.numREVNO.Location = new System.Drawing.Point(535, 28);
			this.numREVNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numREVNO.Name = "numREVNO";
			this.numREVNO.NumberFormat = "8.0";
			this.numREVNO.ReadOnly = true;
			this.numREVNO.Size = new System.Drawing.Size(104, 22);
			this.numREVNO.TabIndex = 78;
			this.numREVNO.Text = "0";
			this.numREVNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numREVNO.ThousandSeperator = false;
			this.numREVNO.Value = 0.0;
			this.numTOLRN.AllowNegative = false;
			this.numTOLRN.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numTOLRN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numTOLRN.DataChanged = false;
			this.numTOLRN.Location = new System.Drawing.Point(535, 55);
			this.numTOLRN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numTOLRN.Name = "numTOLRN";
			this.numTOLRN.NumberFormat = "8.0";
			this.numTOLRN.ReadOnly = true;
			this.numTOLRN.Size = new System.Drawing.Size(104, 22);
			this.numTOLRN.TabIndex = 77;
			this.numTOLRN.Text = "0";
			this.numTOLRN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTOLRN.ThousandSeperator = false;
			this.numTOLRN.Value = 0.0;
			this.txtTYPE.Location = new System.Drawing.Point(273, 55);
			this.txtTYPE.Name = "txtTYPE";
			this.txtTYPE.Size = new System.Drawing.Size(68, 22);
			this.txtTYPE.TabIndex = 76;
			this.txtTYPE.Text = "-1";
			this.txtTYPE.Visible = false;
			this.numWOQTY.AllowNegative = false;
			this.numWOQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numWOQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numWOQTY.DataChanged = false;
			this.numWOQTY.Location = new System.Drawing.Point(99, 55);
			this.numWOQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numWOQTY.Name = "numWOQTY";
			this.numWOQTY.NumberFormat = "8.0";
			this.numWOQTY.ReadOnly = true;
			this.numWOQTY.Size = new System.Drawing.Size(104, 22);
			this.numWOQTY.TabIndex = 75;
			this.numWOQTY.Text = "0";
			this.numWOQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numWOQTY.ThousandSeperator = false;
			this.numWOQTY.Value = 0.0;
			this.TableLayoutPanel1.SetColumnSpan(this.txtMDLCD, 2);
			this.txtMDLCD.Location = new System.Drawing.Point(99, 28);
			this.txtMDLCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMDLCD.Name = "txtMDLCD";
			this.txtMDLCD.ReadOnly = true;
			this.txtMDLCD.Size = new System.Drawing.Size(180, 22);
			this.txtMDLCD.TabIndex = 74;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(428, 58);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(93, 16);
			this.Label3.TabIndex = 49;
			this.Label3.Text = "Tolerance (%)";
			this.Label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label16.AutoSize = true;
			this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label16.Location = new System.Drawing.Point(428, 5);
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
			this.dgvPDWKB.AllowUserToAddRows = false;
			this.dgvPDWKB.AllowUserToDeleteRows = false;
			this.dgvPDWKB.AllowUserToResizeRows = false;
			this.dgvPDWKB.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvPDWKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel1.SetColumnSpan(this.dgvPDWKB, 7);
			this.dgvPDWKB.EnableHeadersVisualStyles = false;
			this.dgvPDWKB.Location = new System.Drawing.Point(3, 83);
			this.dgvPDWKB.MultiSelect = false;
			this.dgvPDWKB.Name = "dgvPDWKB";
			this.dgvPDWKB.ReadOnly = true;
			this.dgvPDWKB.RowHeadersVisible = false;
			this.dgvPDWKB.RowHeadersWidth = 51;
			this.dgvPDWKB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPDWKB.Size = new System.Drawing.Size(685, 376);
			this.dgvPDWKB.TabIndex = 16;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label10.Location = new System.Drawing.Point(3, 31);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(82, 16);
			this.Label10.TabIndex = 9;
			this.Label10.Text = "Model Code";
			this.Label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label19.Location = new System.Drawing.Point(428, 31);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(94, 16);
			this.Label19.TabIndex = 47;
			this.Label19.Text = "BOM Revision";
			this.lblWKOQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblWKOQTY.AutoSize = true;
			this.lblWKOQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblWKOQTY.Location = new System.Drawing.Point(3, 58);
			this.lblWKOQTY.Name = "lblWKOQTY";
			this.lblWKOQTY.Size = new System.Drawing.Size(86, 16);
			this.lblWKOQTY.TabIndex = 51;
			this.lblWKOQTY.Text = "W/O Quantity";
			this.dtpENTDT.CustomFormat = "hh:mm:ss";
			this.dtpENTDT.Dock = System.Windows.Forms.DockStyle.Right;
			this.dtpENTDT.Enabled = false;
			this.dtpENTDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpENTDT.Location = new System.Drawing.Point(645, 2);
			this.dtpENTDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpENTDT.Name = "dtpENTDT";
			this.dtpENTDT.Size = new System.Drawing.Size(104, 22);
			this.dtpENTDT.TabIndex = 73;
			this.dtpDOCDT.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDT.Enabled = false;
			this.dtpDOCDT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDT.Location = new System.Drawing.Point(535, 2);
			this.dtpDOCDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDT.Name = "dtpDOCDT";
			this.dtpDOCDT.Size = new System.Drawing.Size(104, 22);
			this.dtpDOCDT.TabIndex = 3;
			this.lblQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblQTY.AutoSize = true;
			this.lblQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblQTY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQTY.Location = new System.Drawing.Point(429, 497);
			this.lblQTY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQTY.Name = "lblQTY";
			this.lblQTY.Size = new System.Drawing.Size(91, 17);
			this.lblQTY.TabIndex = 85;
			this.lblQTY.Text = "Part Quantity";
			this.numPARQT.AllowNegative = false;
			this.numPARQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPARQT.DataChanged = false;
			this.numPARQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numPARQT.Location = new System.Drawing.Point(536, 494);
			this.numPARQT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numPARQT.Name = "numPARQT";
			this.numPARQT.NumberFormat = "";
			this.numPARQT.Size = new System.Drawing.Size(91, 23);
			this.numPARQT.TabIndex = 86;
			this.numPARQT.Text = "0.00";
			this.numPARQT.ThousandSeperator = false;
			this.numPARQT.Value = 0.0;
			this.txtRECID.Location = new System.Drawing.Point(645, 465);
			this.txtRECID.Name = "txtRECID";
			this.txtRECID.Size = new System.Drawing.Size(68, 22);
			this.txtRECID.TabIndex = 88;
			this.txtRECID.Text = "-1";
			this.txtRECID.Visible = false;
			this.numSEQNO.AllowNegative = false;
			this.numSEQNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSEQNO.DataChanged = false;
			this.numSEQNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numSEQNO.Location = new System.Drawing.Point(536, 465);
			this.numSEQNO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numSEQNO.Name = "numSEQNO";
			this.numSEQNO.NumberFormat = "8.0";
			this.numSEQNO.Size = new System.Drawing.Size(91, 23);
			this.numSEQNO.TabIndex = 90;
			this.numSEQNO.Text = "0";
			this.numSEQNO.ThousandSeperator = false;
			this.numSEQNO.Value = 0.0;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(428, 468);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(70, 16);
			this.Label6.TabIndex = 89;
			this.Label6.Text = "Sequence";
			this.TableLayoutPanel6.AutoSize = true;
			this.TableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel6.ColumnCount = 2;
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel6.Controls.Add(this.btnBack, 0, 0);
			this.TableLayoutPanel6.Controls.Add(this.btnPrint, 1, 0);
			this.TableLayoutPanel6.Location = new System.Drawing.Point(10, 10);
			this.TableLayoutPanel6.Name = "TableLayoutPanel6";
			this.TableLayoutPanel6.RowCount = 1;
			this.TableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel6.Size = new System.Drawing.Size(252, 54);
			this.TableLayoutPanel6.TabIndex = 47;
			this.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Image = IMS.My.Resources.Resources.Back;
			this.btnBack.Location = new System.Drawing.Point(3, 2);
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
			this.btnPrint.Location = new System.Drawing.Point(129, 2);
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
			this.TableLayoutPanel4.ColumnCount = 2;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(6, 91);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(252, 54);
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
			this.btnClose.Location = new System.Drawing.Point(129, 2);
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
			this.TableLayoutPanel2.Size = new System.Drawing.Size(831, 88);
			this.TableLayoutPanel2.TabIndex = 1;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 65);
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
			this.cbDOCNOTO.Location = new System.Drawing.Point(502, 2);
			this.cbDOCNOTO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbDOCNOTO.Name = "cbDOCNOTO";
			this.cbDOCNOTO.SelectedIndex = -1;
			this.cbDOCNOTO.SelectedItem = null;
			this.cbDOCNOTO.SelectedValue = null;
			this.cbDOCNOTO.Size = new System.Drawing.Size(325, 28);
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
			this.cbDOCNOFR.Location = new System.Drawing.Point(118, 2);
			this.cbDOCNOFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbDOCNOFR.Name = "cbDOCNOFR";
			this.cbDOCNOFR.SelectedIndex = -1;
			this.cbDOCNOFR.SelectedItem = null;
			this.cbDOCNOFR.SelectedValue = null;
			this.cbDOCNOFR.Size = new System.Drawing.Size(325, 28);
			this.cbDOCNOFR.TabIndex = 10;
			this.cbDOCNOFR.TextMultiline = true;
			this.cbDOCNOFR.ValueMember = null;
			this.cbDOCNOFR.WhereClause = null;
			this.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label21.AutoSize = true;
			this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label21.Location = new System.Drawing.Point(450, 8);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(25, 16);
			this.Label21.TabIndex = 5;
			this.Label21.Text = "To";
			this.Label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label20.AutoSize = true;
			this.Label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label20.Location = new System.Drawing.Point(3, 8);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(98, 16);
			this.Label20.TabIndex = 2;
			this.Label20.Text = "Work Order No";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 37);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(109, 16);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Work Order Date";
			this.dtpDOCDTFR.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTFR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTFR.Location = new System.Drawing.Point(118, 34);
			this.dtpDOCDTFR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpDOCDTFR.Name = "dtpDOCDTFR";
			this.dtpDOCDTFR.Size = new System.Drawing.Size(105, 22);
			this.dtpDOCDTFR.TabIndex = 5;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(450, 37);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(25, 16);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "To";
			this.dtpDOCDTTO.CustomFormat = "dd/MM/yyyy";
			this.dtpDOCDTTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDOCDTTO.Location = new System.Drawing.Point(501, 34);
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
			this.cbHMDLCD.Location = new System.Drawing.Point(119, 60);
			this.cbHMDLCD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbHMDLCD.Name = "cbHMDLCD";
			this.cbHMDLCD.SelectedIndex = -1;
			this.cbHMDLCD.SelectedItem = null;
			this.cbHMDLCD.SelectedValue = null;
			this.cbHMDLCD.Size = new System.Drawing.Size(324, 24);
			this.cbHMDLCD.TabIndex = 52;
			this.cbHMDLCD.TextMultiline = true;
			this.cbHMDLCD.ValueMember = null;
			this.cbHMDLCD.WhereClause = null;
			this.Label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label11.AutoSize = true;
			this.Label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label11.Location = new System.Drawing.Point(450, 65);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(45, 16);
			this.Label11.TabIndex = 53;
			this.Label11.Text = "Status";
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[2] { "New", "Released" });
			this.cboSTSFG.Location = new System.Drawing.Point(501, 61);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(170, 24);
			this.cboSTSFG.TabIndex = 54;
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
			base.Name = "frmPDEWKB";
			base.Tag = "PDEWKB";
			this.Text = "Work Order BOM Maintenance";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			this.TableLayoutPanel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvPDWKB).EndInit();
			this.TableLayoutPanel6.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPDEWKB_FormClosing(object sender, FormClosingEventArgs e)
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
		}

		private void BindComboHeader()
		{
			cbHMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK)";
			cbHMDLCD.WhereClause = "MAITM_ITMTY = 1 AND MAITM_ACTFG = -1";
			cbHMDLCD.ValueMember = "MAITM_ITMCD";
			cbHMDLCD.DisplayMember = "MAITM_ITMCD";
			cbHMDLCD.LoadData();
		}

		private void frmPDEWKB_Shown(object sender, EventArgs e)
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
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbDOCNOFR.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbDOCNOTO.SelectedValue)) + "', ";
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

		private void BindGridHeader()
		{
			txtDOCNO.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDWKO_WKONO"].Value);
			dtpDOCDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PDWKO_WKODT"].Value);
			dtpENTDT.Value = Conversions.ToDate(dgvHEADER.CurrentRow.Cells["PDWKO_ENTDT"].Value);
			txtTYPE.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDWKO_TYPE"].Value);
			txtMDLCD.Text = Conversions.ToString(dgvHEADER.CurrentRow.Cells["PDWKO_MDLCD"].Value);
			numREVNO.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["PDWKO_REVNO"].Value);
			numTOLRN.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["PDWKO_TOLRN"].Value);
			numWOQTY.Value = Conversions.ToDouble(dgvHEADER.CurrentRow.Cells["PDWKO_WOQTY"].Value);
			BindBOMGrid();
		}

		private void BindBOMGrid()
		{
			int i = 0;
			dgvPDWKB.DataSource = null;
			string strSQL = "SELECT PDWKB_RECID, PDWKB_STAGE, PDWKB_SEQNO, PDWKB_BOMPN, PDWKB_PARQT, PDWKB_RATIO ";
			strSQL += "FROM PDWKB_TBL WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PDWKB_WKONO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
			strSQL += "ORDER BY PDWKB_SEQNO";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					DataGridView dataGridView = dgvPDWKB;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Stage");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Sequence");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 250;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "BOM Part");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Part Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ratio");
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
			if (spPDEWKB(0))
			{
				BindBOMGrid();
			}
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			if (spPDEWKB(1))
			{
				BindBOMGrid();
			}
		}

		private bool spPDEWKB(int intOption)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strNextNo = "";
			string strSQL = "EXEC spPDEWKB " + Conversions.ToString(intOption) + ", ";
			strSQL = strSQL + "'" + txtDOCNO.Text + "', ";
			strSQL = strSQL + "'" + txtRECID.Text + "', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSTAGE.SelectedValue), "', ")));
			strSQL = strSQL + Conversions.ToString(numSEQNO.Value) + ", ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbBOMPN.SelectedValue), "', ")));
			strSQL = strSQL + Conversions.ToString(numPARQT.Value) + ", ";
			strSQL = strSQL + "'" + PublicVar.gstrLogonID + "'";
			bool spPDEWKB;
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
				spPDEWKB = false;
				ProjectData.ClearProjectError();
				goto IL_017c;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			spPDEWKB = true;
			goto IL_017c;
			IL_017c:
			return spPDEWKB;
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			GenerateQRCode();
			string strSQL;
			if (Operators.CompareString(txtTYPE.Text, "ORDER", false) == 0)
			{
				DisplayReport();
				strSQL = "SELECT * FROM PDWKO_QR ";
				strSQL += "LEFT JOIN MACUS_TBL ";
				strSQL += "ON PDWKO_CUSID = MACUS_CUSID ";
				strSQL = strSQL + "WHERE PDWKO_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
				strSQL += "AND MACUS_STKFMT = 1";
				if (DB.RecordExists(strSQL))
				{
					DisplayLabel1();
				}
				strSQL = "SELECT * FROM PDWKO_QR ";
				strSQL += "LEFT JOIN MACUS_TBL ";
				strSQL += "ON PDWKO_CUSID = MACUS_CUSID ";
				strSQL = strSQL + "WHERE PDWKO_PRNID = '" + Common.gfValidSQLStr(MyProject.Computer.Name) + "' ";
				strSQL += "AND MACUS_STKFMT = 2";
				if (DB.RecordExists(strSQL))
				{
					DisplayLabel1();
				}
			}
			strSQL = "SELECT * FROM PDWKB_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MAITM_TBL WITH (NOLOCK) ON MAITM_ITMCD = PDWKB_BOMPN ";
			strSQL = strSQL + "WHERE PDWKB_WKONO = '" + Common.gfValidSQLStr(txtDOCNO.Text) + "' ";
			strSQL += "AND MAITM_ITMCTRL = 1";
			if (DB.RecordExists(strSQL))
			{
				DisplayReport3();
			}
			DisplayReport1();
		}

		private void DisplayLabel1()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "WORK ORDER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKOL.rpt";
			frmRPT.Params = "@PAR=0,@PRNID=" + Common.gfValidSQLStr(MyProject.Computer.Name) + " ";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='WORK ORDER LABEL - FORMAT 1',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ComputerName = MyProject.Computer.Name;
			frmRPT.ViewReportbyComputerName();
		}

		private void DisplayLabel2()
		{
			CRViewer frmRPT = new CRViewer();
			frmRPT.ServerName = PublicVar.gstrServerName;
			frmRPT.DatabaseName = PublicVar.gstrDBName;
			frmRPT.UserID = PublicVar.gstrUserID;
			frmRPT.Password = PublicVar.gstrPassword;
			frmRPT.ReportName = "WORK ORDER";
			frmRPT.ReportFile = PublicVar.gstrRptPath + "crptPDWKOL1.rpt";
			frmRPT.Params = "@PAR=1,@PRNID=" + Common.gfValidSQLStr(MyProject.Computer.Name) + " ";
			frmRPT.Formulas = ("COMNM='" + Common.gfValidSQLStr(PublicVar.gstrCompany.Replace(",", "")) + "',RPTTITLE='WORK ORDER LABEL - FORMAT 2',DTFMT=" + Conversions.ToString(PublicVar.gintRptDateFmt) + ",QTYDS=" + PublicVar.gintQTYDS + ",AMTDS=" + PublicVar.gintAMTDS + ",PRCDS=" + PublicVar.gintPRCDS) ?? "";
			frmRPT.Destination = PublicEnum.Dest.Screen;
			frmRPT.ComputerName = MyProject.Computer.Name;
			frmRPT.ViewReportbyComputerName();
		}

		private void DisplayLabel3()
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
				byte[] imgSCRIDQRCODE = Common.ImageToByte2(sprSCRID.GenerateImage());
				try
				{
					cmd = new OleDbCommand();
					cmd.Connection = DB.GetDBConnection();
					strSQL = "spPDWKO_QR2";
					cmd.CommandText = strSQL;
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.Add("@PRNID", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(MyProject.Computer.Name);
					cmd.Parameters.Add("@WKONO", OleDbType.VarChar, 30).Value = Common.gfValidSQLStr(strWKONO);
					cmd.Parameters.Add("@QRCODE", OleDbType.VarBinary, -1).Value = imgSCRIDQRCODE;
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
			string ITMGRP = Conversions.ToString(DB.GetColumnValue("MAITM_GRPCD", "MAITM_TBL WITH(NOLOCK)", "MAITM_ITMCD = '" + Common.gfValidSQLStr(txtMDLCD.Text) + "' "));
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
			DataTable dt = DB.ExecProc(strSQL);
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

		private void dgvPDWKB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtRECID.Text = Conversions.ToString(dgvPDWKB.CurrentRow.Cells["PDWKB_RECID"].Value);
			cbBOMPN.SelectedValue = RuntimeHelpers.GetObjectValue(dgvPDWKB.CurrentRow.Cells["PDWKB_BOMPN"].Value);
			numSEQNO.Value = Conversions.ToDouble(dgvPDWKB.CurrentRow.Cells["PDWKB_SEQNO"].Value);
			cbSTAGE.SelectedValue = RuntimeHelpers.GetObjectValue(dgvPDWKB.CurrentRow.Cells["PDWKB_STAGE"].Value);
			numPARQT.Value = Conversions.ToDouble(dgvPDWKB.CurrentRow.Cells["PDWKB_PARQT"].Value);
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			txtRECID.Text = Conversions.ToString(-1);
			cbBOMPN.SelectedIndex = -1;
			numSEQNO.Value = 0.0;
			cbSTAGE.SelectedIndex = -1;
			numPARQT.Value = 0.0;
		}
	}
}
