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
	public class frmMAECBOM : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbCUSID")]
		private ComboboxControl _cbCUSID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbGRPCD")]
		private ComboBox _cbGRPCD;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSELECT")]
		private Button _btnSELECT;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvBOM")]
		private DataGridView _dgvBOM;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnEDIT")]
		private Button _btnEDIT;

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

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvORIBOM")]
		internal virtual DataGridView dgvORIBOM
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

		[field: AccessedThroughProperty("TableLayoutPanel5")]
		internal virtual TableLayoutPanel TableLayoutPanel5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		[field: AccessedThroughProperty("dgvCUSBOM")]
		internal virtual DataGridView dgvCUSBOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSELECT
		{
			[CompilerGenerated]
			get
			{
				return _btnSELECT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSELECT_Click;
				Button button = _btnSELECT;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSELECT = value;
				button = _btnSELECT;
				if (button != null)
				{
					button.Click += value2;
				}
			}
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
				DataGridViewCellMouseEventHandler value2 = dgvBOM_CellMouseClick;
				DataGridView dataGridView = _dgvBOM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick -= value2;
				}
				_dgvBOM = value;
				dataGridView = _dgvBOM;
				if (dataGridView != null)
				{
					dataGridView.CellMouseClick += value2;
				}
			}
		}

		internal virtual Button btnEDIT
		{
			[CompilerGenerated]
			get
			{
				return _btnEDIT;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnEDIT_Click;
				Button button = _btnEDIT;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnEDIT = value;
				button = _btnEDIT;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
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

		[field: AccessedThroughProperty("cbBOMPN")]
		internal virtual ComboboxControl cbBOMPN
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

		[field: AccessedThroughProperty("numTOTAL")]
		internal virtual NumControl numTOTAL
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

		[field: AccessedThroughProperty("numRATIO")]
		internal virtual NumControl numRATIO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAECBOM()
		{
			base.FormClosing += frmMAECBOM_FormClosing;
			base.Shown += frmMAECBOM_Shown;
			base.KeyDown += frmMAECBOM_KeyDown;
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
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.numRATIO = new IMS.NumControl();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.btnREMOVE = new System.Windows.Forms.Button();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.cbGRPCD = new System.Windows.Forms.ComboBox();
			this.dgvORIBOM = new System.Windows.Forms.DataGridView();
			this.Label9 = new System.Windows.Forms.Label();
			this.lblCUSIDFR = new System.Windows.Forms.Label();
			this.cbCUSID = new IMS.ComboboxControl();
			this.dgvCUSBOM = new System.Windows.Forms.DataGridView();
			this.btnSELECT = new System.Windows.Forms.Button();
			this.dgvBOM = new System.Windows.Forms.DataGridView();
			this.btnEDIT = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.cbBOMPN = new IMS.ComboboxControl();
			this.numPARQT = new IMS.NumControl();
			this.numTOTAL = new IMS.NumControl();
			this.btnClose = new System.Windows.Forms.Button();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvORIBOM).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvCUSBOM).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvBOM).BeginInit();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.Controls.Add(this.TableLayoutPanel5);
			this.Panel2.Location = new System.Drawing.Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1580, 645);
			this.Panel2.TabIndex = 2;
			this.TableLayoutPanel5.ColumnCount = 10;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40f));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40f));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120f));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel5.Controls.Add(this.numRATIO, 9, 3);
			this.TableLayoutPanel5.Controls.Add(this.TableLayoutPanel1, 0, 6);
			this.TableLayoutPanel5.Controls.Add(this.cbGRPCD, 1, 1);
			this.TableLayoutPanel5.Controls.Add(this.dgvORIBOM, 0, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label9, 0, 1);
			this.TableLayoutPanel5.Controls.Add(this.lblCUSIDFR, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.cbCUSID, 1, 0);
			this.TableLayoutPanel5.Controls.Add(this.dgvCUSBOM, 3, 2);
			this.TableLayoutPanel5.Controls.Add(this.btnSELECT, 2, 2);
			this.TableLayoutPanel5.Controls.Add(this.dgvBOM, 6, 2);
			this.TableLayoutPanel5.Controls.Add(this.btnEDIT, 5, 2);
			this.TableLayoutPanel5.Controls.Add(this.Label1, 6, 4);
			this.TableLayoutPanel5.Controls.Add(this.Label2, 6, 5);
			this.TableLayoutPanel5.Controls.Add(this.cbBOMPN, 7, 4);
			this.TableLayoutPanel5.Controls.Add(this.numPARQT, 7, 5);
			this.TableLayoutPanel5.Controls.Add(this.numTOTAL, 8, 3);
			this.TableLayoutPanel5.Controls.Add(this.btnClose, 9, 0);
			this.TableLayoutPanel5.Location = new System.Drawing.Point(8, 12);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 7;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel5.Size = new System.Drawing.Size(1330, 577);
			this.TableLayoutPanel5.TabIndex = 10;
			this.numRATIO.AllowNegative = false;
			this.numRATIO.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.numRATIO.DataChanged = false;
			this.numRATIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numRATIO.Location = new System.Drawing.Point(1233, 430);
			this.numRATIO.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numRATIO.Name = "numRATIO";
			this.numRATIO.NumberFormat = "15.6";
			this.numRATIO.ReadOnly = true;
			this.numRATIO.Size = new System.Drawing.Size(93, 23);
			this.numRATIO.TabIndex = 27;
			this.numRATIO.Text = "0.000000";
			this.numRATIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numRATIO.ThousandSeperator = false;
			this.numRATIO.Value = 0.0;
			this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel5.SetColumnSpan(this.TableLayoutPanel1, 3);
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnREMOVE, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnCANCEL, 2, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(816, 517);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(384, 54);
			this.TableLayoutPanel1.TabIndex = 26;
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
			this.cbGRPCD.FormattingEnabled = true;
			this.cbGRPCD.Location = new System.Drawing.Point(90, 33);
			this.cbGRPCD.Name = "cbGRPCD";
			this.cbGRPCD.Size = new System.Drawing.Size(250, 24);
			this.cbGRPCD.TabIndex = 15;
			this.dgvORIBOM.AllowUserToAddRows = false;
			this.dgvORIBOM.AllowUserToDeleteRows = false;
			this.dgvORIBOM.AllowUserToResizeRows = false;
			this.dgvORIBOM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvORIBOM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvORIBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvORIBOM, 2);
			this.dgvORIBOM.Location = new System.Drawing.Point(3, 62);
			this.dgvORIBOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvORIBOM.MultiSelect = false;
			this.dgvORIBOM.Name = "dgvORIBOM";
			this.dgvORIBOM.ReadOnly = true;
			this.dgvORIBOM.RowHeadersVisible = false;
			this.TableLayoutPanel5.SetRowSpan(this.dgvORIBOM, 5);
			this.dgvORIBOM.RowTemplate.Height = 24;
			this.dgvORIBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvORIBOM.Size = new System.Drawing.Size(360, 513);
			this.dgvORIBOM.TabIndex = 0;
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 37);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(73, 16);
			this.Label9.TabIndex = 14;
			this.Label9.Text = "Item Group";
			this.lblCUSIDFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCUSIDFR.AutoSize = true;
			this.lblCUSIDFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCUSIDFR.Location = new System.Drawing.Point(3, 7);
			this.lblCUSIDFR.Name = "lblCUSIDFR";
			this.lblCUSIDFR.Size = new System.Drawing.Size(81, 16);
			this.lblCUSIDFR.TabIndex = 2;
			this.lblCUSIDFR.Text = "Customer ID";
			this.cbCUSID.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbCUSID, 3);
			this.cbCUSID.ComboboxWidth = 250;
			this.cbCUSID.DataTable = null;
			this.cbCUSID.DisplayMember = null;
			this.cbCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCUSID.HasBlankValue = true;
			this.cbCUSID.Location = new System.Drawing.Point(90, 2);
			this.cbCUSID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbCUSID.Name = "cbCUSID";
			this.cbCUSID.SelectedIndex = -1;
			this.cbCUSID.SelectedItem = null;
			this.cbCUSID.SelectedValue = null;
			this.cbCUSID.Size = new System.Drawing.Size(435, 26);
			this.cbCUSID.TabIndex = 11;
			this.cbCUSID.TextMultiline = true;
			this.cbCUSID.ValueMember = null;
			this.cbCUSID.WhereClause = null;
			this.dgvCUSBOM.AllowUserToAddRows = false;
			this.dgvCUSBOM.AllowUserToDeleteRows = false;
			this.dgvCUSBOM.AllowUserToResizeRows = false;
			this.dgvCUSBOM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvCUSBOM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvCUSBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvCUSBOM, 2);
			this.dgvCUSBOM.Location = new System.Drawing.Point(409, 62);
			this.dgvCUSBOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvCUSBOM.MultiSelect = false;
			this.dgvCUSBOM.Name = "dgvCUSBOM";
			this.dgvCUSBOM.ReadOnly = true;
			this.dgvCUSBOM.RowHeadersVisible = false;
			this.TableLayoutPanel5.SetRowSpan(this.dgvCUSBOM, 5);
			this.dgvCUSBOM.RowTemplate.Height = 24;
			this.dgvCUSBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCUSBOM.Size = new System.Drawing.Size(360, 513);
			this.dgvCUSBOM.TabIndex = 16;
			this.btnSELECT.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSELECT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSELECT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSELECT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSELECT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSELECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSELECT.Image = IMS.My.Resources.Resources.arrow_right;
			this.btnSELECT.Location = new System.Drawing.Point(369, 62);
			this.btnSELECT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSELECT.Name = "btnSELECT";
			this.TableLayoutPanel5.SetRowSpan(this.btnSELECT, 5);
			this.btnSELECT.Size = new System.Drawing.Size(34, 50);
			this.btnSELECT.TabIndex = 17;
			this.btnSELECT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSELECT.UseVisualStyleBackColor = false;
			this.dgvBOM.AllowUserToAddRows = false;
			this.dgvBOM.AllowUserToDeleteRows = false;
			this.dgvBOM.AllowUserToResizeRows = false;
			this.dgvBOM.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvBOM.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvBOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel5.SetColumnSpan(this.dgvBOM, 4);
			this.dgvBOM.Location = new System.Drawing.Point(815, 62);
			this.dgvBOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dgvBOM.MultiSelect = false;
			this.dgvBOM.Name = "dgvBOM";
			this.dgvBOM.ReadOnly = true;
			this.dgvBOM.RowHeadersVisible = false;
			this.dgvBOM.RowTemplate.Height = 24;
			this.dgvBOM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBOM.Size = new System.Drawing.Size(512, 364);
			this.dgvBOM.TabIndex = 18;
			this.btnEDIT.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnEDIT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEDIT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnEDIT.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnEDIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEDIT.Image = IMS.My.Resources.Resources.edit;
			this.btnEDIT.Location = new System.Drawing.Point(775, 62);
			this.btnEDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnEDIT.Name = "btnEDIT";
			this.TableLayoutPanel5.SetRowSpan(this.btnEDIT, 5);
			this.btnEDIT.Size = new System.Drawing.Size(34, 50);
			this.btnEDIT.TabIndex = 19;
			this.btnEDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEDIT.UseVisualStyleBackColor = false;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(815, 462);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(65, 16);
			this.Label1.TabIndex = 20;
			this.Label1.Text = "BOM Part";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(815, 490);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 16);
			this.Label2.TabIndex = 21;
			this.Label2.Text = "Quantity";
			this.cbBOMPN.BlankValue = null;
			this.TableLayoutPanel5.SetColumnSpan(this.cbBOMPN, 3);
			this.cbBOMPN.ComboboxWidth = 170;
			this.cbBOMPN.DataTable = null;
			this.cbBOMPN.DisplayMember = null;
			this.cbBOMPN.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBOMPN.HasBlankValue = false;
			this.cbBOMPN.Location = new System.Drawing.Point(935, 457);
			this.cbBOMPN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbBOMPN.Name = "cbBOMPN";
			this.cbBOMPN.SelectedIndex = -1;
			this.cbBOMPN.SelectedItem = null;
			this.cbBOMPN.SelectedValue = null;
			this.cbBOMPN.Size = new System.Drawing.Size(325, 26);
			this.cbBOMPN.TabIndex = 23;
			this.cbBOMPN.TextMultiline = true;
			this.cbBOMPN.ValueMember = null;
			this.cbBOMPN.WhereClause = null;
			this.numPARQT.AllowNegative = false;
			this.numPARQT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numPARQT.DataChanged = false;
			this.numPARQT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numPARQT.Location = new System.Drawing.Point(936, 487);
			this.numPARQT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numPARQT.Name = "numPARQT";
			this.numPARQT.NumberFormat = "8.2";
			this.numPARQT.Size = new System.Drawing.Size(102, 23);
			this.numPARQT.TabIndex = 24;
			this.numPARQT.Text = "0.00";
			this.numPARQT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPARQT.ThousandSeperator = false;
			this.numPARQT.Value = 0.0;
			this.numTOTAL.AllowNegative = false;
			this.numTOTAL.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.numTOTAL.DataChanged = false;
			this.numTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.numTOTAL.Location = new System.Drawing.Point(1107, 430);
			this.numTOTAL.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.numTOTAL.Name = "numTOTAL";
			this.numTOTAL.NumberFormat = "15.6";
			this.numTOTAL.ReadOnly = true;
			this.numTOTAL.Size = new System.Drawing.Size(93, 23);
			this.numTOTAL.TabIndex = 25;
			this.numTOTAL.Text = "0.000000";
			this.numTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTOTAL.ThousandSeperator = false;
			this.numTOTAL.Value = 0.0;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(1207, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel5.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 10;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 604);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmMAECBOM";
			base.Tag = "MAECBOM";
			this.Text = "Customer BOM Maintenance";
			this.Panel2.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvORIBOM).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvCUSBOM).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvBOM).EndInit();
			base.ResumeLayout(false);
		}

		private void BindComboBox(string strOption)
		{
			if (Operators.CompareString(strOption, "CUSID", false) == 0)
			{
				cbCUSID.DataTable = "MACUS_TBL WITH (NOLOCK) ";
				cbCUSID.ValueMember = "MACUS_CUSID";
				cbCUSID.DisplayMember = "MACUS_CUSID";
				cbCUSID.LoadData();
				cbCUSID.SelectedIndex = 1;
			}
			if (Operators.CompareString(strOption, "GRPCD", false) == 0)
			{
				string strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'GRPCD' ORDER BY MACOD_CODID";
				cbGRPCD.ValueMember = "MACOD_CODID";
				cbGRPCD.DisplayMember = "MACOD_CODNM";
				Common.RetriveComboItembySQL(strSQL, cbGRPCD);
			}
			if (Operators.CompareString(strOption, "BOMPN", false) == 0)
			{
				cbBOMPN.DataTable = "MAITM_TBL WITH (NOLOCK) ";
				cbBOMPN.WhereClause = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MAITM_ACTFG = -1 AND (MAITM_ITMTY = 0 OR (MAITM_ITMTY = 1 AND MAITM_GRPCD = '", cbGRPCD.SelectedValue), "'))"));
				cbBOMPN.ValueMember = "MAITM_ITMCD";
				cbBOMPN.DisplayMember = "MAITM_ITMCD";
				cbBOMPN.LoadData();
			}
		}

		private void frmMAECBOM_FormClosing(object sender, FormClosingEventArgs e)
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

		private void frmMAECBOM_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox("CUSID");
			BindComboBox("GRPCD");
		}

		private void BindORIBOM()
		{
			dgvORIBOM.DataSource = null;
			string strSQL = "EXEC spMACBOM '0', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbGRPCD.SelectedValue), "', '', 0")));
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvORIBOM;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 240;
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].ReadOnly = true;
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 100;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision No");
			dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].ReadOnly = true;
			dataGridView.AutoResizeRows();
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void BindCUSBOM()
		{
			dgvCUSBOM.DataSource = null;
			string strSQL = "EXEC spMACBOM '1', ";
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCUSID.SelectedValue), "', ")));
			strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbGRPCD.SelectedValue), "', '', 0")));
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvCUSBOM;
			dataGridView.DataSource = dt;
			dataGridView.Columns[0].Visible = true;
			dataGridView.Columns[0].Width = 240;
			dataGridView.Columns[0].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
			dataGridView.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[0].ReadOnly = true;
			dataGridView.Columns[1].Visible = true;
			dataGridView.Columns[1].Width = 100;
			dataGridView.Columns[1].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision No");
			dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[1].ReadOnly = true;
			dataGridView.AutoResizeRows();
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
			dataGridView.Refresh();
			dataGridView = null;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmMAECBOM_KeyDown(object sender, KeyEventArgs e)
		{
			Common.gfControl_KeyDown(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cbCUSID_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindORIBOM();
			BindCUSBOM();
		}

		private void cbGRPCD_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindORIBOM();
			BindCUSBOM();
		}

		private void btnSELECT_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spMAECBOM_SELECT ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(dgvORIBOM.SelectedRows[0].Cells["MABOM_MDLCD"].Value)) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dgvORIBOM.SelectedRows[0].Cells["MABOM_REVNO"].Value))) + ", ";
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
				ProjectData.ClearProjectError();
				return;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			BindORIBOM();
			BindCUSBOM();
		}

		private void btnEDIT_Click(object sender, EventArgs e)
		{
			BindComboBox("BOMPN");
			BindBOM();
		}

		private void BindBOM()
		{
			int i = 0;
			double dblPARQT = 0.0;
			double dblRATIO = 0.0;
			dgvBOM.DataSource = null;
			string strSQL = "EXEC spMACBOM '2', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbGRPCD.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(dgvCUSBOM.SelectedRows[0].Cells["MABOM_MDLCD"].Value)) + "', ";
			strSQL += Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dgvCUSBOM.SelectedRows[0].Cells["MABOM_REVNO"].Value)));
			DataTable dt = DB.ExecProc(strSQL);
			DataGridView dataGridView = dgvBOM;
			dataGridView.DataSource = dt;
			dataGridView.Columns[i].Visible = true;
			dataGridView.Columns[i].Width = 140;
			dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Bom Part");
			dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			dataGridView.Columns[i].ReadOnly = true;
			checked
			{
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 120;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Description");
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				i++;
				dataGridView.Columns[i].Visible = true;
				dataGridView.Columns[i].Width = 80;
				dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Ratio");
				dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
				dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				dataGridView.Columns[i].ReadOnly = true;
				dataGridView.AutoResizeRows();
				dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
				dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
				dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
				dataGridView.Refresh();
				dataGridView = null;
				int num = dgvBOM.RowCount - 1;
				for (int j = 0; j <= num; j++)
				{
					dblPARQT = Conversions.ToDouble(Operators.AddObject(dblPARQT, dgvBOM.Rows[j].Cells["MABOM_PARQT"].Value));
					dblRATIO = Conversions.ToDouble(Operators.AddObject(dblRATIO, dgvBOM.Rows[j].Cells["MABOM_RATIO"].Value));
				}
				numTOTAL.Value = dblPARQT;
				numRATIO.Value = dblRATIO;
			}
		}

		private void dgvBOM_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			cbBOMPN.SelectedValue = RuntimeHelpers.GetObjectValue(dgvBOM.SelectedRows[0].Cells["MABOM_BOMPN"].Value);
			numPARQT.Value = Conversions.ToDouble(dgvBOM.SelectedRows[0].Cells["MABOM_PARQT"].Value);
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			cbBOMPN.SelectedIndex = -1;
			numPARQT.Value = 0.0;
			numTOTAL.Value = 0.0;
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spMAECBOM 0, ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(dgvCUSBOM.SelectedRows[0].Cells["MABOM_MDLCD"].Value)) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dgvCUSBOM.SelectedRows[0].Cells["MABOM_REVNO"].Value))) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(numPARQT.Value) + ", ";
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
				ProjectData.ClearProjectError();
				return;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			BindBOM();
		}

		private void btnREMOVE_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spMAECBOM 1, ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbCUSID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(dgvCUSBOM.SelectedRows[0].Cells["MABOM_MDLCD"].Value)) + "', ";
			strSQL = strSQL + Conversions.ToString(Conversion.Val(RuntimeHelpers.GetObjectValue(dgvCUSBOM.SelectedRows[0].Cells["MABOM_REVNO"].Value))) + ", ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbBOMPN.SelectedValue)) + "', ";
			strSQL = strSQL + Conversions.ToString(numPARQT.Value) + ", ";
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
				ProjectData.ClearProjectError();
				return;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			BindBOM();
		}
	}
}
