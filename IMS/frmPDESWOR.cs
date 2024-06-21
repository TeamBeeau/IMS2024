using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class frmPDESWOR : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvHEADER")]
		private DataGridView _dgvHEADER;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRELEASE")]
		private Button _btnRELEASE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

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

		internal virtual Button btnRELEASE
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
				Button button = _btnRELEASE;
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
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

		[field: AccessedThroughProperty("Label9")]
		internal virtual Label Label9
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

		[field: AccessedThroughProperty("numREVNO")]
		internal virtual NumControl numREVNO
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

		[field: AccessedThroughProperty("lblSTDWGT")]
		internal virtual Label lblSTDWGT
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

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numSOQTY")]
		internal virtual NumControl numSOQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numONHAND")]
		internal virtual NumControl numONHAND
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

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("numREQQTY")]
		internal virtual NumControl numREQQTY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
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

		public frmPDESWOR()
		{
			base.Load += frmPDESWOR_Load;
			base.FormClosing += frmPDESWKOR_FormClosing;
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
			this.btnSave = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.cbMDLCD = new IMS.ComboboxControl();
			this.Label1 = new System.Windows.Forms.Label();
			this.numREVNO = new IMS.NumControl();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.lblSTDWGT = new System.Windows.Forms.Label();
			this.numSTDWGT = new IMS.NumControl();
			this.Label3 = new System.Windows.Forms.Label();
			this.numSOQTY = new IMS.NumControl();
			this.numONHAND = new IMS.NumControl();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.numREQQTY = new IMS.NumControl();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnRELEASE = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.TableLayoutPanel2);
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Controls.Add(this.dgvHEADER);
			this.Panel1.Location = new System.Drawing.Point(3, 1);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1345, 707);
			this.Panel1.TabIndex = 1;
			this.TableLayoutPanel2.ColumnCount = 4;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.btnSave, 0, 4);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label9, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbMDLCD, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.numREVNO, 3, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbLOCID, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.lblSTDWGT, 2, 1);
			this.TableLayoutPanel2.Controls.Add(this.numSTDWGT, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label3, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.numSOQTY, 1, 2);
			this.TableLayoutPanel2.Controls.Add(this.numONHAND, 3, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label4, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.Label5, 0, 3);
			this.TableLayoutPanel2.Controls.Add(this.numREQQTY, 1, 3);
			this.TableLayoutPanel2.Controls.Add(this.btnCANCEL, 1, 4);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(9, 503);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 5;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(1326, 194);
			this.TableLayoutPanel2.TabIndex = 15;
			this.btnSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Image = IMS.My.Resources.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(3, 114);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(120, 50);
			this.btnSave.TabIndex = 80;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 37);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(59, 16);
			this.Label2.TabIndex = 69;
			this.Label2.Text = "Location";
			this.Label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label9.Location = new System.Drawing.Point(3, 7);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(82, 16);
			this.Label9.TabIndex = 52;
			this.Label9.Text = "Model Code";
			this.cbMDLCD.BlankValue = null;
			this.cbMDLCD.ComboboxWidth = 170;
			this.cbMDLCD.DataTable = null;
			this.cbMDLCD.DisplayMember = null;
			this.cbMDLCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMDLCD.HasBlankValue = true;
			this.cbMDLCD.Location = new System.Drawing.Point(130, 2);
			this.cbMDLCD.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.cbMDLCD.Name = "cbMDLCD";
			this.cbMDLCD.SelectedIndex = -1;
			this.cbMDLCD.SelectedItem = null;
			this.cbMDLCD.SelectedValue = null;
			this.cbMDLCD.Size = new System.Drawing.Size(373, 26);
			this.cbMDLCD.TabIndex = 53;
			this.cbMDLCD.TextMultiline = true;
			this.cbMDLCD.ValueMember = null;
			this.cbMDLCD.WhereClause = null;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(510, 7);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(61, 16);
			this.Label1.TabIndex = 54;
			this.Label1.Text = "Revision";
			this.numREVNO.AllowNegative = false;
			this.numREVNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numREVNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numREVNO.DataChanged = false;
			this.numREVNO.Location = new System.Drawing.Point(624, 4);
			this.numREVNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numREVNO.Name = "numREVNO";
			this.numREVNO.NumberFormat = "8.0";
			this.numREVNO.ReadOnly = true;
			this.numREVNO.Size = new System.Drawing.Size(150, 22);
			this.numREVNO.TabIndex = 68;
			this.numREVNO.Text = "0";
			this.numREVNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numREVNO.ThousandSeperator = false;
			this.numREVNO.Value = 0.0;
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(129, 33);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(200, 24);
			this.cbLOCID.TabIndex = 71;
			this.lblSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTDWGT.AutoSize = true;
			this.lblSTDWGT.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTDWGT.Location = new System.Drawing.Point(510, 37);
			this.lblSTDWGT.Name = "lblSTDWGT";
			this.lblSTDWGT.Size = new System.Drawing.Size(108, 16);
			this.lblSTDWGT.TabIndex = 72;
			this.lblSTDWGT.Text = "Standard Weight";
			this.numSTDWGT.AllowNegative = false;
			this.numSTDWGT.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSTDWGT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSTDWGT.DataChanged = false;
			this.numSTDWGT.Location = new System.Drawing.Point(624, 34);
			this.numSTDWGT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSTDWGT.Name = "numSTDWGT";
			this.numSTDWGT.NumberFormat = "8.0";
			this.numSTDWGT.ReadOnly = true;
			this.numSTDWGT.Size = new System.Drawing.Size(150, 22);
			this.numSTDWGT.TabIndex = 73;
			this.numSTDWGT.Text = "0";
			this.numSTDWGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSTDWGT.ThousandSeperator = false;
			this.numSTDWGT.Value = 0.0;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 65);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(84, 16);
			this.Label3.TabIndex = 74;
			this.Label3.Text = "Total SO Qty";
			this.numSOQTY.AllowNegative = false;
			this.numSOQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numSOQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numSOQTY.DataChanged = false;
			this.numSOQTY.Location = new System.Drawing.Point(129, 62);
			this.numSOQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numSOQTY.Name = "numSOQTY";
			this.numSOQTY.NumberFormat = "8.0";
			this.numSOQTY.ReadOnly = true;
			this.numSOQTY.Size = new System.Drawing.Size(150, 22);
			this.numSOQTY.TabIndex = 75;
			this.numSOQTY.Text = "0";
			this.numSOQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numSOQTY.ThousandSeperator = false;
			this.numSOQTY.Value = 0.0;
			this.numONHAND.AllowNegative = false;
			this.numONHAND.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numONHAND.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numONHAND.DataChanged = false;
			this.numONHAND.Location = new System.Drawing.Point(624, 62);
			this.numONHAND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numONHAND.Name = "numONHAND";
			this.numONHAND.NumberFormat = "8.0";
			this.numONHAND.ReadOnly = true;
			this.numONHAND.Size = new System.Drawing.Size(150, 22);
			this.numONHAND.TabIndex = 76;
			this.numONHAND.Text = "0";
			this.numONHAND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numONHAND.ThousandSeperator = false;
			this.numONHAND.Value = 0.0;
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(510, 65);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(61, 16);
			this.Label4.TabIndex = 77;
			this.Label4.Text = "On Hand";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 91);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(79, 16);
			this.Label5.TabIndex = 78;
			this.Label5.Text = "Require Qty";
			this.numREQQTY.AllowNegative = false;
			this.numREQQTY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numREQQTY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.numREQQTY.DataChanged = false;
			this.numREQQTY.Location = new System.Drawing.Point(129, 88);
			this.numREQQTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.numREQQTY.Name = "numREQQTY";
			this.numREQQTY.NumberFormat = "8.0";
			this.numREQQTY.Size = new System.Drawing.Size(150, 22);
			this.numREQQTY.TabIndex = 79;
			this.numREQQTY.Text = "0";
			this.numREQQTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numREQQTY.ThousandSeperator = false;
			this.numREQQTY.Value = 0.0;
			this.btnCANCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCANCEL.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCANCEL.Location = new System.Drawing.Point(129, 114);
			this.btnCANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.Size = new System.Drawing.Size(120, 50);
			this.btnCANCEL.TabIndex = 81;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCANCEL.UseVisualStyleBackColor = false;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel1.Controls.Add(this.btnRELEASE, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(10, 7);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(252, 60);
			this.TableLayoutPanel1.TabIndex = 14;
			this.btnRELEASE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRELEASE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRELEASE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRELEASE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRELEASE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRELEASE.Image = IMS.My.Resources.Resources.inspection;
			this.btnRELEASE.Location = new System.Drawing.Point(3, 3);
			this.btnRELEASE.Name = "btnRELEASE";
			this.btnRELEASE.Size = new System.Drawing.Size(120, 50);
			this.btnRELEASE.TabIndex = 15;
			this.btnRELEASE.Text = "Release";
			this.btnRELEASE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRELEASE.UseVisualStyleBackColor = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(129, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 14;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.EnableHeadersVisualStyles = false;
			this.dgvHEADER.Location = new System.Drawing.Point(8, 72);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1327, 426);
			this.dgvHEADER.TabIndex = 10;
			this.dgvHEADER.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 720);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPDESWOR";
			base.Tag = "PDESWOR";
			this.Text = "Sales Order Work Order Request";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			base.ResumeLayout(false);
		}

		private void frmPDESWOR_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
			GenerateWorkFile();
			RefrechGrid();
		}

		private void BindComboBox()
		{
			cbMDLCD.DataTable = "MAITM_TBL WITH (NOLOCK)";
			cbMDLCD.WhereClause = "MAITM_ITMTY = 1 AND MAITM_ACTFG = -1";
			cbMDLCD.ValueMember = "MAITM_ITMCD";
			cbMDLCD.DisplayMember = "MAITM_ITMCD";
			cbMDLCD.LoadData();
			string strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
			strSQL += "FROM MALOC_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MALOC_LOCTY = 'WIP' ";
			strSQL += "ORDER BY MALOC_LOCID ";
			cbLOCID.ValueMember = "MALOC_LOCID";
			cbLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbLOCID);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPDESWKOR_FormClosing(object sender, FormClosingEventArgs e)
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

		private void GenerateWorkFile()
		{
			string strSQL = "EXEC spPDSWOR '" + MyProject.Computer.Name + "' ";
			DB.ExecProc(strSQL);
		}

		private void RefrechGrid()
		{
			dgvHEADER.DataSource = null;
			string strSQL = "SELECT PDSWOR_MDLCD, PDSWOR_REVNO, PDSWOR_LOCID, PDSWOR_STDWGT, PDSWOR_SOQTY, PDSWOR_ONHAND, PDSWOR_REQ ";
			strSQL += "FROM PDSWOR_WRK WITH (NOLOCK) ";
			strSQL = strSQL + "WHERE PDSWOR_COMPNM = '" + MyProject.Computer.Name + "' ";
			strSQL += "ORDER BY PDSWOR_MDLCD";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvHEADER.ClearSelection();
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					int i = default(int);
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 180;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Std Weight");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Total SO Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "On Hand");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Require Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void btnRELEASE_Click(object sender, EventArgs e)
		{
            DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Release order?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
			{

				OleDbCommand cmd = new OleDbCommand();
				string strSQL = "SELECT * FROM PDSWOR_WRK ";
				strSQL = strSQL + "WHERE PDSWOR_COMPNM = '" + MyProject.Computer.Name + "' ";
				strSQL += "AND PDSWOR_LOCID <> '' AND PDSWOR_REQ > 0";
				if (!DB.RecordExists(strSQL))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No data to release!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				strSQL = "EXEC spPDESWOR ";
				strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
				strSQL = strSQL + "'" + PublicVar.gstrLogonID + "' ";
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
				//	MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order Generated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				GenerateWorkFile();
				RefrechGrid();
			}
		}

		private void dgvHEADER_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridView dataGridView = dgvHEADER;
			cbMDLCD.SelectedValue = RuntimeHelpers.GetObjectValue(dataGridView.CurrentRow.Cells["PDSWOR_MDLCD"].Value);
			numREVNO.Value = Conversions.ToDouble(dataGridView.CurrentRow.Cells["PDSWOR_REVNO"].Value);
			if (Operators.ConditionalCompareObjectNotEqual(dataGridView.CurrentRow.Cells["PDSWOR_LOCID"].Value, "", false))
			{
				cbLOCID.SelectedValue = RuntimeHelpers.GetObjectValue(dataGridView.CurrentRow.Cells["PDSWOR_RECNO"].Value);
			}
			else
			{
				cbLOCID.SelectedIndex = -1;
			}
			numSTDWGT.Value = Conversions.ToDouble(dataGridView.CurrentRow.Cells["PDSWOR_STDWGT"].Value);
			numSOQTY.Value = Conversions.ToDouble(dataGridView.CurrentRow.Cells["PDSWOR_SOQTY"].Value);
			numONHAND.Value = Conversions.ToDouble(dataGridView.CurrentRow.Cells["PDSWOR_ONHAND"].Value);
			numREQQTY.Value = Conversions.ToDouble(dataGridView.CurrentRow.Cells["PDSWOR_REQ"].Value);
			dataGridView = null;
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			cbMDLCD.SelectedIndex = -1;
			numREVNO.Value = 0.0;
			cbLOCID.SelectedIndex = -1;
			numSTDWGT.Value = 0.0;
			numSOQTY.Value = 0.0;
			numONHAND.Value = 0.0;
			numREQQTY.Value = 0.0;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			if (ValidDetail())
			{
				string strSQL = "UPDATE PDSWOR_WRK SET PDSWOR_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
				strSQL = strSQL + "PDSWOR_REQ = " + Conversions.ToString(numREQQTY.Value) + " ";
				strSQL = strSQL + "WHERE PDSWOR_COMPNM = '" + MyProject.Computer.Name + "' ";
				strSQL = strSQL + "AND PDSWOR_MDLCD = '" + Common.gfValidSQLStr(Conversions.ToString(cbMDLCD.SelectedValue)) + "' ";
				strSQL = strSQL + "AND PDSWOR_REVNO = " + Conversions.ToString(numREVNO.Value);
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
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record updated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				RefrechGrid();
			}
		}

		private bool ValidDetail()
		{
			if (cbLOCID.SelectedIndex == -1)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Location cannot be blank!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				cbLOCID.Select();
				return false;
			}
			if (numREQQTY.Value == 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Require Qauntity cannot be 0!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				numREQQTY.Select();
				return false;
			}
			if (numREQQTY.Value > numSTDWGT.Value && numREQQTY.Value % numSTDWGT.Value != 0.0)
			{
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Quantity, Require Quantity must be in factor of Standard Weight!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				numREQQTY.Select();
				return false;
			}
			return true;
		}
	}
}
