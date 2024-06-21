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
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
    [DesignerGenerated]
	public class frmPDEWOR : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCDTO")]
		private ComboboxControl _cbITMCDTO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbITMCDFR")]
		private ComboboxControl _cbITMCDFR;

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
		[AccessedThroughProperty("btnRELEASE")]
		private System.Windows.Forms.Button _btnRELEASE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnExcel")]
		private System.Windows.Forms.Button _btnExcel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("bgwProgress")]
		private BackgroundWorker _bgwProgress;

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

		internal virtual ComboboxControl cbITMCDTO
		{
			[CompilerGenerated]
			get
			{
				return _cbITMCDTO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbITMCDTO_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbITMCDTO;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbITMCDTO = value;
				comboboxControl = _cbITMCDTO;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual System.Windows.Forms.Label Label2
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
				ComboboxControl.SelectedIndexChangedEventHandler obj = cbITMCDFR_SelectedIndexChanged;
				ComboboxControl comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged -= obj;
				}
				_cbITMCDFR = value;
				comboboxControl = _cbITMCDFR;
				if (comboboxControl != null)
				{
					comboboxControl.SelectedIndexChanged += obj;
				}
			}
		}

		[field: AccessedThroughProperty("dgvHEADER")]
		internal virtual DataGridView dgvHEADER
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

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual System.Windows.Forms.Button btnExcel
		{
			[CompilerGenerated]
			get
			{
				return _btnExcel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnExcel_Click;
				System.Windows.Forms.Button button = _btnExcel;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnExcel = value;
				button = _btnExcel;
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

		[field: AccessedThroughProperty("lblTOITMCD")]
		internal virtual System.Windows.Forms.Label lblTOITMCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblFRITMCD")]
		internal virtual System.Windows.Forms.Label lblFRITMCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPDEWOR()
		{
			base.Load += frmPDEWOR_Load;
			base.FormClosing += frmPDEWKOR_FormClosing;
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
			this.btnExcel = new System.Windows.Forms.Button();
			this.btnRELEASE = new System.Windows.Forms.Button();
			this.btnSEARCH = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lblTOITMCD = new System.Windows.Forms.Label();
			this.lblFRITMCD = new System.Windows.Forms.Label();
			this.cbITMCDFR = new IMS.ComboboxControl();
			this.cbITMCDTO = new IMS.ComboboxControl();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.dgvHEADER = new System.Windows.Forms.DataGridView();
			this.bgwProgress = new System.ComponentModel.BackgroundWorker();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.TableLayoutPanel1);
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Controls.Add(this.dgvHEADER);
			this.Panel1.Location = new System.Drawing.Point(3, 1);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1385, 674);
			this.Panel1.TabIndex = 1;
			this.TableLayoutPanel1.ColumnCount = 4;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.Controls.Add(this.btnExcel, 2, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnRELEASE, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnSEARCH, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnClose, 3, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(10, 46);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(507, 57);
			this.TableLayoutPanel1.TabIndex = 14;
			this.btnExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnExcel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcel.Image = IMS.My.Resources.Resources.Excel;
			this.btnExcel.Location = new System.Drawing.Point(255, 3);
			this.btnExcel.Name = "btnExcel";
			this.btnExcel.Size = new System.Drawing.Size(120, 50);
			this.btnExcel.TabIndex = 16;
			this.btnExcel.Text = "Excel";
			this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnExcel.UseVisualStyleBackColor = false;
			this.btnRELEASE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRELEASE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRELEASE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRELEASE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRELEASE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRELEASE.Image = IMS.My.Resources.Resources.inspection;
			this.btnRELEASE.Location = new System.Drawing.Point(129, 3);
			this.btnRELEASE.Name = "btnRELEASE";
			this.btnRELEASE.Size = new System.Drawing.Size(120, 50);
			this.btnRELEASE.TabIndex = 15;
			this.btnRELEASE.Text = "Release";
			this.btnRELEASE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRELEASE.UseVisualStyleBackColor = false;
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
			this.btnClose.Location = new System.Drawing.Point(381, 3);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 14;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.lblTOITMCD, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.lblFRITMCD, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.cbITMCDFR, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.cbITMCDTO, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label5, 2, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(10, 4);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 2;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(778, 47);
			this.TableLayoutPanel3.TabIndex = 13;
			this.lblTOITMCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTOITMCD.AutoSize = true;
			this.lblTOITMCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTOITMCD.Location = new System.Drawing.Point(78, 31);
			this.lblTOITMCD.Name = "lblTOITMCD";
			this.lblTOITMCD.Size = new System.Drawing.Size(69, 16);
			this.lblTOITMCD.TabIndex = 52;
			this.lblTOITMCD.Text = "Item Code";
			this.lblTOITMCD.Visible = false;
			this.lblFRITMCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFRITMCD.AutoSize = true;
			this.lblFRITMCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFRITMCD.Location = new System.Drawing.Point(3, 31);
			this.lblFRITMCD.Name = "lblFRITMCD";
			this.lblFRITMCD.Size = new System.Drawing.Size(69, 16);
			this.lblFRITMCD.TabIndex = 51;
			this.lblFRITMCD.Text = "Item Code";
			this.lblFRITMCD.Visible = false;
			this.cbITMCDFR.BlankValue = null;
			this.cbITMCDFR.ComboboxWidth = 170;
			this.cbITMCDFR.DataTable = null;
			this.cbITMCDFR.DisplayMember = null;
			this.cbITMCDFR.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDFR.HasBlankValue = true;
			this.cbITMCDFR.Location = new System.Drawing.Point(78, 2);
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
			this.cbITMCDTO.BlankValue = null;
			this.cbITMCDTO.ComboboxWidth = 170;
			this.cbITMCDTO.DataTable = null;
			this.cbITMCDTO.DisplayMember = null;
			this.cbITMCDTO.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCDTO.HasBlankValue = true;
			this.cbITMCDTO.Location = new System.Drawing.Point(447, 2);
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
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 7);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(69, 16);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "Item Code";
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(416, 7);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(25, 16);
			this.Label5.TabIndex = 3;
			this.Label5.Text = "To";
			this.dgvHEADER.AllowUserToAddRows = false;
			this.dgvHEADER.AllowUserToDeleteRows = false;
			this.dgvHEADER.AllowUserToResizeRows = false;
			this.dgvHEADER.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.dgvHEADER.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvHEADER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHEADER.Location = new System.Drawing.Point(8, 109);
			this.dgvHEADER.MultiSelect = false;
			this.dgvHEADER.Name = "dgvHEADER";
			this.dgvHEADER.ReadOnly = true;
			this.dgvHEADER.RowHeadersVisible = false;
			this.dgvHEADER.RowHeadersWidth = 51;
			this.dgvHEADER.RowTemplate.Height = 24;
			this.dgvHEADER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHEADER.Size = new System.Drawing.Size(1367, 561);
			this.dgvHEADER.TabIndex = 10;
			this.dgvHEADER.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1400, 729);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPDEWOR";
			base.Tag = "PDEWOR";
			this.Text = "Master Production Work Order Request";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvHEADER).EndInit();
			base.ResumeLayout(false);
		}

		private void frmPDEWOR_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboHeader();
			Header();
		}

		private void BindComboHeader()
		{
			cbITMCDFR.DataTable = "PCMPS_TBL WITH (NOLOCK) ";
			cbITMCDFR.ValueMember = "PCMPS_MDLCD";
			cbITMCDFR.DisplayMember = "PCMPS_MDLCD";
			cbITMCDFR.LoadData();
			cbITMCDTO.DataTable = "PCMPS_TBL WITH (NOLOCK)";
			cbITMCDTO.ValueMember = "PCMPS_MDLCD";
			cbITMCDTO.DisplayMember = "PCMPS_MDLCD";
			cbITMCDTO.LoadData();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void frmPDEWKOR_FormClosing(object sender, FormClosingEventArgs e)
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

		private void Header()
		{
			dgvHEADER.DataSource = null;
			string strSQL = "EXEC spPDWOR ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMCDFR.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMCDTO.SelectedValue)) + "' ";
			System.Data.DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvHEADER.ClearSelection();
					DataGridView dataGridView = dgvHEADER;
					dataGridView.DataSource = dt;
					int i = default(int);
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 120;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Cust Part");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Safety");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Std Weight");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Max Level");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Plan Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "TM FG Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "OS WO Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Onhand");
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

		private void btnSEARCH_Click(object sender, EventArgs e)
		{
			Header();
		}

		private void btnRELEASE_Click(object sender, EventArgs e)
        {
            DialogResult ok = MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Release order?"), "Inovex Business Suites", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (ok == DialogResult.OK)
			{

				OleDbCommand cmd = new OleDbCommand();
				string strSQL = "SELECT * FROM PDWOR_WRK ";
				strSQL = strSQL + "WHERE PDWOR_COMPNM = '" + MyProject.Computer.Name + "' ";
				strSQL += "AND PDWOR_REQ > 0";
				if (!DB.RecordExists(strSQL))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No data to release!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				strSQL = "EXEC spPDEWOR ";
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
				//MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Work Order Generated!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Header();
			}
		}

		private void btnExcel_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			bgwProgress.RunWorkerAsync();
		}

		private void bgwProgress_DoWork(object sender, DoWorkEventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application xlsApp = new ApplicationClass();
			string strSQL = "EXEC spPDWOR ";
			strSQL = strSQL + "'" + MyProject.Computer.Name + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(lblFRITMCD.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(lblTOITMCD.Text) + "' ";
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
			xlsApp.Cells[2, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Master Production Report") + " " + DateTime.Now.ToString("MM/yyyy");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[2, 4])).Merge(RuntimeHelpers.GetObjectValue(Missing.Value));
			xlsApp.Cells[4, 1] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Document No");
			xlsApp.Cells[4, 2] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
			xlsApp.Cells[4, 3] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Revision");
			xlsApp.Cells[4, 4] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Safety Level");
			xlsApp.Cells[4, 5] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Standard Weight");
			xlsApp.Cells[4, 6] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Max Level");
			xlsApp.Cells[4, 7] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Plan Qty");
			xlsApp.Cells[4, 8] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "TM FG Qty");
			xlsApp.Cells[4, 9] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "TM WO Qty");
			xlsApp.Cells[4, 10] = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "On Hand");
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 10])).Font.Bold = true;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[1, 10])).EntireColumn.NumberFormat = "@";
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 10])).Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
			((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 1]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[4, 10])).Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
			int intRow = 5;
			checked
			{
				int num = dt.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					xlsApp.Cells[intRow, 1] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_DOCNO"]);
					xlsApp.Cells[intRow, 2] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_MDLCD"]);
					xlsApp.Cells[intRow, 3] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_REVNO"]);
					xlsApp.Cells[intRow, 4] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_SAFETY"]);
					xlsApp.Cells[intRow, 5] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_STDWGT"]);
					xlsApp.Cells[intRow, 6] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_MAXLVL"]);
					xlsApp.Cells[intRow, 7] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_PLNQTY"]);
					xlsApp.Cells[intRow, 8] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_TMFGQTY"]);
					xlsApp.Cells[intRow, 9] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_TMWOQTY"]);
					xlsApp.Cells[intRow, 10] = RuntimeHelpers.GetObjectValue(dt.Rows[i]["PDWOR_ONHAND"]);
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 3]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 3])).NumberFormat = "0.00";
					((_Worksheet)xlsSheet).get_Range(RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 4]), RuntimeHelpers.GetObjectValue(xlsSheet.Cells[intRow, 10])).NumberFormat = "0.000";
					intRow++;
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

		private void cbITMCDFR_SelectedIndexChanged(object sender, EventArgs e)
		{

			lblFRITMCD.Text = Conversions.ToString(cbITMCDFR.SelectedValue);
			if(cbITMCDFR.SelectedValue!=null)
			cbITMCDTO.SelectedValue = cbITMCDFR.SelectedValue;

        }

		private void cbITMCDTO_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblTOITMCD.Text = Conversions.ToString(cbITMCDTO.SelectedValue);
		}
	}
}
