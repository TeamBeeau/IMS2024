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
	public class frmPCELOTDSP : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRetrieve")]
		private Button _btnRetrieve;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbLOCID")]
		private ComboBox _cbLOCID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtGRLNO")]
		private TextBox _txtGRLNO;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cboSTSFG")]
		private ComboBox _cboSTSFG;

		[field: AccessedThroughProperty("TableLayoutPanel3")]
		internal virtual TableLayoutPanel TableLayoutPanel3
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

		[field: AccessedThroughProperty("Label15")]
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvDetails")]
		internal virtual DataGridView dgvDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnRetrieve
		{
			[CompilerGenerated]
			get
			{
				return _btnRetrieve;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRetrieve_Click;
				Button button = _btnRetrieve;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRetrieve = value;
				button = _btnRetrieve;
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

		internal virtual TextBox txtGRLNO
		{
			[CompilerGenerated]
			get
			{
				return _txtGRLNO;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = txtGRLNO_KeyDown;
				TextBox textBox = _txtGRLNO;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
				}
				_txtGRLNO = value;
				textBox = _txtGRLNO;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cbITMCD")]
		internal virtual ComboboxControl cbITMCD
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

		internal virtual ComboBox cboSTSFG
		{
			[CompilerGenerated]
			get
			{
				return _cboSTSFG;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cboSTSFG_SelectedIndexChanged;
				ComboBox comboBox = _cboSTSFG;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cboSTSFG = value;
				comboBox = _cboSTSFG;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label22")]
		internal virtual Label Label22
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmPCELOTDSP()
		{
			base.Shown += frmPCELOTDSP_Shown;
			base.FormClosing += frmPCELOTDSP_FormClosing;
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
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.Label22 = new System.Windows.Forms.Label();
			this.cboSTSFG = new System.Windows.Forms.ComboBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.cbITMCD = new IMS.ComboboxControl();
			this.txtGRLNO = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbLOCID = new System.Windows.Forms.ComboBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.dgvDetails = new System.Windows.Forms.DataGridView();
			this.btnRetrieve = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.TableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 6;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.Label22, 0, 2);
			this.TableLayoutPanel3.Controls.Add(this.cboSTSFG, 1, 2);
			this.TableLayoutPanel3.Controls.Add(this.Label8, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.cbITMCD, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.txtGRLNO, 1, 4);
			this.TableLayoutPanel3.Controls.Add(this.Label1, 0, 4);
			this.TableLayoutPanel3.Controls.Add(this.cbLOCID, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.Label15, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.dgvDetails, 0, 3);
			this.TableLayoutPanel3.Controls.Add(this.btnRetrieve, 3, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 4, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 5;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(1145, 666);
			this.TableLayoutPanel3.TabIndex = 19;
			this.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label22.AutoSize = true;
			this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label22.Location = new System.Drawing.Point(3, 76);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(57, 20);
			this.Label22.TabIndex = 82;
			this.Label22.Text = "Status";
			this.cboSTSFG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSTSFG.FormattingEnabled = true;
			this.cboSTSFG.Items.AddRange(new object[3] { "In used Only", "Disposed Only", "All" });
			this.cboSTSFG.Location = new System.Drawing.Point(94, 72);
			this.cboSTSFG.Name = "cboSTSFG";
			this.cboSTSFG.Size = new System.Drawing.Size(156, 28);
			this.cboSTSFG.TabIndex = 81;
			this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label8.AutoSize = true;
			this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label8.Location = new System.Drawing.Point(3, 41);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(85, 20);
			this.Label8.TabIndex = 80;
			this.Label8.Text = "Item Code";
			this.cbITMCD.BlankValue = null;
			this.cbITMCD.ComboboxWidth = 170;
			this.cbITMCD.DataTable = null;
			this.cbITMCD.DisplayMember = null;
			this.cbITMCD.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbITMCD.HasBlankValue = false;
			this.cbITMCD.Location = new System.Drawing.Point(94, 36);
			this.cbITMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cbITMCD.Name = "cbITMCD";
			this.cbITMCD.SelectedIndex = -1;
			this.cbITMCD.SelectedItem = null;
			this.cbITMCD.SelectedValue = null;
			this.cbITMCD.Size = new System.Drawing.Size(364, 31);
			this.cbITMCD.TabIndex = 2;
			this.cbITMCD.TextMultiline = true;
			this.cbITMCD.ValueMember = null;
			this.cbITMCD.WhereClause = null;
			this.txtGRLNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtGRLNO.Location = new System.Drawing.Point(94, 637);
			this.txtGRLNO.Name = "txtGRLNO";
			this.txtGRLNO.Size = new System.Drawing.Size(247, 26);
			this.txtGRLNO.TabIndex = 4;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 640);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(59, 20);
			this.Label1.TabIndex = 78;
			this.Label1.Text = "Lot No";
			this.cbLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLOCID.FormattingEnabled = true;
			this.cbLOCID.Location = new System.Drawing.Point(94, 3);
			this.cbLOCID.Name = "cbLOCID";
			this.cbLOCID.Size = new System.Drawing.Size(247, 28);
			this.cbLOCID.TabIndex = 1;
			this.Label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label15.AutoSize = true;
			this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label15.Location = new System.Drawing.Point(3, 7);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(73, 20);
			this.Label15.TabIndex = 56;
			this.Label15.Text = "Location";
			this.dgvDetails.AllowUserToAddRows = false;
			this.dgvDetails.AllowUserToDeleteRows = false;
			this.dgvDetails.AllowUserToResizeRows = false;
			this.dgvDetails.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel3.SetColumnSpan(this.dgvDetails, 6);
			this.dgvDetails.EnableHeadersVisualStyles = false;
			this.dgvDetails.Location = new System.Drawing.Point(3, 106);
			this.dgvDetails.MultiSelect = false;
			this.dgvDetails.Name = "dgvDetails";
			this.dgvDetails.ReadOnly = true;
			this.dgvDetails.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dgvDetails.RowHeadersVisible = false;
			this.dgvDetails.RowHeadersWidth = 51;
			this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDetails.Size = new System.Drawing.Size(1139, 525);
			this.dgvDetails.TabIndex = 58;
			this.dgvDetails.TabStop = false;
			this.btnRetrieve.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRetrieve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnRetrieve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRetrieve.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRetrieve.Location = new System.Drawing.Point(680, 2);
			this.btnRetrieve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRetrieve.Name = "btnRetrieve";
			this.TableLayoutPanel3.SetRowSpan(this.btnRetrieve, 2);
			this.btnRetrieve.Size = new System.Drawing.Size(120, 50);
			this.btnRetrieve.TabIndex = 3;
			this.btnRetrieve.Text = "Retrieve";
			this.btnRetrieve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRetrieve.UseVisualStyleBackColor = false;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(806, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.TableLayoutPanel3.SetRowSpan(this.btnClose, 2);
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 5;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1343, 716);
			this.Panel1.TabIndex = 20;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1395, 728);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmPCELOTDSP";
			base.Tag = "PCELOTDSP";
			this.Text = "Material Lot No Disposed";
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvDetails).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void frmPCELOTDSP_Shown(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox("LOCID");
			cboSTSFG.SelectedIndex = 2;
		}

		private void frmPCELOTDSP_FormClosing(object sender, FormClosingEventArgs e)
		{
			string strSQL = "DELETE PCGRN_WRK2 WHERE PCGRN_PRNID = '" + MyProject.Computer.Name + "'";
			DB.ExecProc(strSQL);
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

		private void BindComboBox(string strOption)
		{
			string strSQL = string.Empty;
			if (Operators.CompareString(strOption, "LOCID", false) == 0)
			{
				strSQL = "SELECT DISTINCT MALOC_LOCID, MALOC_LOCNM ";
				strSQL += "FROM MALOC_TBL WITH(NOLOCK) WHERE MALOC_LOCTY = 'WH' ";
				strSQL += "ORDER BY MALOC_LOCID ";
				cbLOCID.ValueMember = "MALOC_LOCID";
				cbLOCID.DisplayMember = "MALOC_LOCNM";
				Common.RetriveComboItembySQL(strSQL, cbLOCID);
			}
			if (Operators.CompareString(strOption, "ITMCD", false) == 0)
			{
				cbITMCD.DataTable = "PCGRN_TBL WITH (NOLOCK) ";
				cbITMCD.WhereClause = "PCGRN_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "'";
				cbITMCD.ValueMember = "PCGRN_ITMCD";
				cbITMCD.DisplayMember = "PCGRN_ITMCD";
				cbITMCD.LoadData();
			}
		}

		private void GenerateWorkFile()
		{
			string strSQL = "EXEC spPCELOT_WRK '" + MyProject.Computer.Name + "', '" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', '" + Common.gfValidSQLStr(Conversions.ToString(cbITMCD.SelectedValue)) + "'";
			DB.ExecProc(strSQL);
		}

		private void RefreshGrid()
		{
			dgvDetails.DataSource = null;
			string strSQL = "EXEC spPCLOT '" + MyProject.Computer.Name + "', " + Conversions.ToString(cboSTSFG.SelectedIndex);
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count != 0)
				{
					DataGridView dataGridView = dgvDetails;
					dataGridView.DataSource = dt;
					int i = default(int);
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Doc Date");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No");
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Balance Qty");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Weight);
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 40;
					dataGridView.Columns[i].HeaderText = "";
					dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
					dataGridView.ClearSelection();
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void btnRetrieve_Click(object sender, EventArgs e)
		{
			GenerateWorkFile();
			RefreshGrid();
		}

		private void cbLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindComboBox("ITMCD");
		}

		private void cboSTSFG_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshGrid();
		}

		private void txtGRLNO_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode.Equals(Keys.Return))
			{
				string strSQL = "SELECT * FROM PCGRN_TBL WITH (NOLOCK) WHERE PCGRN_GRLNO = '" + Common.gfValidSQLStr(txtGRLNO.Text) + "'";
				DataTable dt = DB.ExecProc(strSQL);
				if (dt.Rows.Count == 0)
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Invalid Lot No!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtGRLNO.Select();
				}
				else if (Operators.ConditionalCompareObjectEqual(dt.Rows[0]["PCGRN_COMFG"], 3, false))
				{
					MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Lot No Already Disposed!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txtGRLNO.Select();
				}
				else if (spPDELOT())
				{
					txtGRLNO.Text = string.Empty;
					RefreshGrid();
				}
			}
		}

		private bool spPDELOT()
		{
			OleDbCommand cmd = new OleDbCommand();
			string strSQL = "EXEC spPCELOT ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbLOCID.SelectedValue)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtGRLNO.Text) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(MyProject.Computer.Name) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "' ";
			bool spPDELOT;
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
				spPDELOT = false;
				ProjectData.ClearProjectError();
				goto IL_00de;
			}
			spPDELOT = true;
			goto IL_00de;
			IL_00de:
			return spPDELOT;
		}
	}
}
