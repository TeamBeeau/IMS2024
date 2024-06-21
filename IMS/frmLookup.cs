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
	public class frmLookup : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dgvLookup")]
		private DataGridView _dgvLookup;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txtValue")]
		private TextBox _txtValue;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmdCancel")]
		private Button _cmdCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnRefresh")]
		private Button _btnRefresh;

		private DataTable mDataSource;

		private string mColumns;

		private string mTable;

		private string mWhere;

		private string mWhere1;

		private string mOrderBy;

		private int mRecords;

		private string mLKPCD;

		private string mKeyColumn;

		private string mKeyColumnName;

		private string mDescColumn;

		private string mDescColumnName;

		private string mKeyColumn2;

		private string mKeyColumnName2;

		private string mDescColumn2;

		private string mDescColumnName2;

		private bool mValueSelected;

		private DataGridViewRow mSelectedRow;

		internal virtual DataGridView dgvLookup
		{
			[CompilerGenerated]
			get
			{
				return _dgvLookup;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = dgvLookup_CellDoubleClick;
				KeyEventHandler value3 = dgvLookup_KeyDown;
				DataGridView dataGridView = _dgvLookup;
				if (dataGridView != null)
				{
					dataGridView.CellDoubleClick -= value2;
					dataGridView.KeyDown -= value3;
				}
				_dgvLookup = value;
				dataGridView = _dgvLookup;
				if (dataGridView != null)
				{
					dataGridView.CellDoubleClick += value2;
					dataGridView.KeyDown += value3;
				}
			}
		}

		[field: AccessedThroughProperty("lblTrtType")]
		internal virtual Label lblTrtType
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cboSearchBy")]
		internal virtual ComboBox cboSearchBy
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblRemarks")]
		internal virtual Label lblRemarks
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual TextBox txtValue
		{
			[CompilerGenerated]
			get
			{
				return _txtValue;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = txtValue_TextChanged;
				TextBox textBox = _txtValue;
				if (textBox != null)
				{
					textBox.TextChanged -= value2;
				}
				_txtValue = value;
				textBox = _txtValue;
				if (textBox != null)
				{
					textBox.TextChanged += value2;
				}
			}
		}

		internal virtual Button cmdCancel
		{
			[CompilerGenerated]
			get
			{
				return _cmdCancel;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cmdCancel_Click;
				Button button = _cmdCancel;
				if (button != null)
				{
					button.Click -= value2;
				}
				_cmdCancel = value;
				button = _cmdCancel;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("cboSearchPattern")]
		internal virtual ComboBox cboSearchPattern
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("NumControl1")]
		internal virtual NumControl NumControl1
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

		internal virtual Button btnRefresh
		{
			[CompilerGenerated]
			get
			{
				return _btnRefresh;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnRefresh_Click;
				Button button = _btnRefresh;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnRefresh = value;
				button = _btnRefresh;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		public DataTable DataSource
		{
			get
			{
				return mDataSource;
			}
			set
			{
				mDataSource = value;
			}
		}

		public string _Columns
		{
			set
			{
				mColumns = value;
			}
		}

		public string _Table
		{
			set
			{
				mTable = value;
			}
		}

		public string _Where
		{
			set
			{
				mWhere = value;
			}
		}

		public string _Where1
		{
			set
			{
				mWhere1 = value;
			}
		}

		public string _OrderBy
		{
			set
			{
				mOrderBy = value;
			}
		}

		public int _Records
		{
			set
			{
				mRecords = value;
			}
		}

		public string _LKPCD
		{
			set
			{
				mLKPCD = value;
			}
		}

		public string _KeyColumn
		{
			set
			{
				mKeyColumn = value;
			}
		}

		public string _KeyColumnName
		{
			set
			{
				mKeyColumnName = value;
			}
		}

		public string _DescColumn
		{
			set
			{
				mDescColumn = value;
			}
		}

		public string _DescColumnName
		{
			set
			{
				mDescColumnName = value;
			}
		}

		public string _KeyColumn2
		{
			set
			{
				mKeyColumn2 = value;
			}
		}

		public string _KeyColumnName2
		{
			set
			{
				mKeyColumnName2 = value;
			}
		}

		public string _DescColumn2
		{
			set
			{
				mDescColumn2 = value;
			}
		}

		public string _DescColumnName2
		{
			set
			{
				mDescColumnName2 = value;
			}
		}

		public DataGridViewRow SelectedRow
		{
			get
			{
				return mSelectedRow;
			}
		}

		public bool ValueSelected
		{
			get
			{
				return mValueSelected;
			}
		}

		public frmLookup()
		{
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvLookup = new System.Windows.Forms.DataGridView();
			this.lblTrtType = new System.Windows.Forms.Label();
			this.cboSearchBy = new System.Windows.Forms.ComboBox();
			this.lblRemarks = new System.Windows.Forms.Label();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.cboSearchPattern = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.NumControl1 = new IMS.NumControl();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.dgvLookup).BeginInit();
			base.SuspendLayout();
			this.dgvLookup.AllowUserToAddRows = false;
			this.dgvLookup.AllowUserToDeleteRows = false;
			this.dgvLookup.AllowUserToOrderColumns = true;
			this.dgvLookup.AllowUserToResizeRows = false;
			this.dgvLookup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvLookup.BackgroundColor = System.Drawing.Color.FloralWhite;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLookup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.dgvLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvLookup.Location = new System.Drawing.Point(15, 95);
			this.dgvLookup.Margin = new System.Windows.Forms.Padding(4);
			this.dgvLookup.MultiSelect = false;
			this.dgvLookup.Name = "dgvLookup";
			this.dgvLookup.ReadOnly = true;
			this.dgvLookup.RowHeadersWidth = 20;
			this.dgvLookup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvLookup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvLookup.Size = new System.Drawing.Size(1033, 553);
			this.dgvLookup.TabIndex = 6;
			this.lblTrtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.lblTrtType.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblTrtType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTrtType.Location = new System.Drawing.Point(16, 15);
			this.lblTrtType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTrtType.Name = "lblTrtType";
			this.lblTrtType.Size = new System.Drawing.Size(96, 20);
			this.lblTrtType.TabIndex = 34;
			this.lblTrtType.Text = "Search By";
			this.lblTrtType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cboSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cboSearchBy.Location = new System.Drawing.Point(127, 15);
			this.cboSearchBy.Margin = new System.Windows.Forms.Padding(4);
			this.cboSearchBy.Name = "cboSearchBy";
			this.cboSearchBy.Size = new System.Drawing.Size(271, 24);
			this.cboSearchBy.TabIndex = 0;
			this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.lblRemarks.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblRemarks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblRemarks.Location = new System.Drawing.Point(16, 46);
			this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRemarks.Name = "lblRemarks";
			this.lblRemarks.Size = new System.Drawing.Size(96, 20);
			this.lblRemarks.TabIndex = 36;
			this.lblRemarks.Text = "Value";
			this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtValue.Location = new System.Drawing.Point(127, 46);
			this.txtValue.Margin = new System.Windows.Forms.Padding(4);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(563, 22);
			this.txtValue.TabIndex = 2;
			this.cboSearchPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSearchPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cboSearchPattern.Items.AddRange(new object[2] { "Beginning of Field", "Any Part of Field" });
			this.cboSearchPattern.Location = new System.Drawing.Point(419, 15);
			this.cboSearchPattern.Margin = new System.Windows.Forms.Padding(4);
			this.cboSearchPattern.Name = "cboSearchPattern";
			this.cboSearchPattern.Size = new System.Drawing.Size(271, 24);
			this.cboSearchPattern.TabIndex = 1;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label1.Location = new System.Drawing.Point(715, 15);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(108, 20);
			this.Label1.TabIndex = 38;
			this.Label1.Text = "Top Records";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.NumControl1.AllowNegative = false;
			this.NumControl1.DataChanged = false;
			this.NumControl1.Location = new System.Drawing.Point(830, 15);
			this.NumControl1.Margin = new System.Windows.Forms.Padding(4);
			this.NumControl1.Name = "NumControl1";
			this.NumControl1.NumberFormat = "8.0";
			this.NumControl1.Size = new System.Drawing.Size(73, 22);
			this.NumControl1.TabIndex = 3;
			this.NumControl1.TabStop = false;
			this.NumControl1.Text = "10";
			this.NumControl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.NumControl1.ThousandSeperator = false;
			this.NumControl1.Value = 10.0;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cmdCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmdCancel.Location = new System.Drawing.Point(928, 54);
			this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.Size = new System.Drawing.Size(120, 40);
			this.cmdCancel.TabIndex = 5;
			this.cmdCancel.Text = "   &Cancel";
			this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
			this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnRefresh.Image = IMS.My.Resources.Resources.Refresh;
			this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnRefresh.Location = new System.Drawing.Point(928, 12);
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(120, 40);
			this.btnRefresh.TabIndex = 4;
			this.btnRefresh.TabStop = false;
			this.btnRefresh.Text = "&Refresh";
			this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRefresh.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.cmdCancel;
			base.ClientSize = new System.Drawing.Size(1063, 661);
			base.Controls.Add(this.btnRefresh);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.NumControl1);
			base.Controls.Add(this.cboSearchPattern);
			base.Controls.Add(this.cmdCancel);
			base.Controls.Add(this.lblRemarks);
			base.Controls.Add(this.txtValue);
			base.Controls.Add(this.lblTrtType);
			base.Controls.Add(this.cboSearchBy);
			base.Controls.Add(this.dgvLookup);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.MaximizeBox = false;
			base.Name = "frmLookup";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lookup";
			((System.ComponentModel.ISupportInitialize)this.dgvLookup).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public void Lookup(Form mdi)
		{
			DataGridView dataGridView = dgvLookup;
			dataGridView.DataSource = mDataSource;
			dataGridView.AutoResizeColumns();
			dataGridView.AutoResizeRows();
			dataGridView.AutoResizeColumnHeadersHeight();
			dataGridView.Refresh();
			dataGridView = null;
			cboSearchBy.Items.Add(mKeyColumnName);
			if (Operators.CompareString(mDescColumnName, string.Empty, false) != 0)
			{
				cboSearchBy.Items.Add(mDescColumnName);
			}
			if ((Operators.CompareString(mKeyColumnName2, null, false) != 0) & (Operators.CompareString(mKeyColumnName2, "", false) != 0))
			{
				cboSearchBy.Items.Add(mKeyColumnName2);
			}
			if ((Operators.CompareString(mDescColumnName2, null, false) != 0) & (Operators.CompareString(mDescColumnName2, "", false) != 0))
			{
				cboSearchBy.Items.Add(mDescColumnName2);
			}
			checked
			{
				int num = mDataSource.Columns.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(mDataSource.Columns[i].ColumnName, mKeyColumnName, false) != 0 && Operators.CompareString(mDataSource.Columns[i].ColumnName, mDescColumnName, false) != 0 && Operators.CompareString(mDataSource.Columns[i].ColumnName, mKeyColumnName2, false) != 0 && Operators.CompareString(mDataSource.Columns[i].ColumnName, mDescColumnName2, false) != 0)
					{
						cboSearchBy.Items.Add(mDataSource.Columns[i].ColumnName);
					}
				}
				if (cboSearchBy.Items.Count > 0)
				{
					if (cboSearchBy.Items.Count >= 2)
					{
						cboSearchBy.SelectedIndex = 1;
					}
					else
					{
						cboSearchBy.SelectedIndex = 0;
					}
				}
				if (cboSearchPattern.Items.Count > 0)
				{
					if (cboSearchPattern.Items.Count >= 2)
					{
						cboSearchPattern.SelectedIndex = 1;
					}
					else
					{
						cboSearchPattern.SelectedIndex = 0;
					}
				}
				NumControl1.Value = mRecords;
				ShowDialog(mdi);
			}
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgvLookup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dataGridView = dgvLookup;
			if (dataGridView.Rows.Count != 0)
			{
				mDataSource = (DataTable)dataGridView.DataSource;
				mValueSelected = true;
				mSelectedRow = dataGridView.CurrentRow;
				dataGridView = null;
				cmdCancel_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void dgvLookup_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return && dgvLookup.SelectedCells.Count != 0)
			{
				dgvLookup_CellDoubleClick(RuntimeHelpers.GetObjectValue(sender), null);
			}
		}

		private void txtValue_TextChanged(object sender, EventArgs e)
		{
		}

		private void SearchValue()
		{
			if (cboSearchBy.SelectedIndex == -1)
			{
				return;
			}
			DataGridView dataGridView = dgvLookup;
			checked
			{
				int num = dataGridView.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					switch (cboSearchPattern.SelectedIndex)
					{
					case 0:
						if (dataGridView[cboSearchBy.SelectedIndex, i].Value.ToString().Trim().ToUpper()
							.IndexOf(txtValue.Text.Trim().ToUpper(), 0) == 0)
						{
							dataGridView[cboSearchBy.SelectedIndex, i].Selected = true;
							return;
						}
						break;
					case -1:
					case 1:
						if (dataGridView[cboSearchBy.SelectedIndex, i].Value.ToString().Trim().ToUpper()
							.IndexOf(txtValue.Text.Trim().ToUpper(), 0) >= 0)
						{
							dataGridView[cboSearchBy.SelectedIndex, i].Selected = true;
							return;
						}
						break;
					}
				}
				dataGridView = null;
			}
		}

		private string ConstructSQL()
		{
			string tColumns = "";
			bool blnIsDateColumn = false;
			string strSearch = "";
			checked
			{
				string strSQL;
				if (mColumns.ToUpper().Contains("DISTINCT"))
				{
					strSQL = "SELECT " + mColumns.ToUpper().Replace("DISTINCT", "DISTINCT TOP " + NumControl1.Value);
					strSQL = strSQL + " FROM " + mTable;
				}
				else
				{
					strSQL = "IF OBJECT_ID(N'TEMPDB..[#TABLE]') IS NOT NULL DROP TABLE #TABLE ";
					strSQL = strSQL + "SELECT " + mColumns + ", * INTO #TABLE ";
					strSQL = strSQL + "FROM " + mTable;
					DB.DBExecute(strSQL);
					DataTable dt = DB.GetTable("*", "#TABLE", "", "");
					int num = dt.Columns.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						tColumns = ((Operators.CompareString(tColumns, "", false) != 0) ? (tColumns + ", [" + dt.Columns[i].ColumnName + "]") : ("[" + dt.Columns[i].ColumnName + "]"));
						if (Operators.CompareString(dt.Columns[i].ColumnName, cboSearchBy.Text, false) == 0 && Operators.CompareString(dt.Columns[i].DataType.FullName, "System.DateTime", false) == 0)
						{
							blnIsDateColumn = true;
						}
					}
					strSQL = "SELECT TOP " + NumControl1.Value + " " + tColumns;
					strSQL += " FROM #TABLE";
				}
				if (Operators.CompareString(mWhere, "", false) != 0)
				{
					strSQL = strSQL + " WHERE " + mWhere;
					if (Operators.CompareString(mWhere1, "", false) != 0)
					{
						strSQL = strSQL + " AND " + mWhere1;
					}
					if (Operators.CompareString(txtValue.Text, "", false) != 0)
					{
						string left = cboSearchBy.Text;
						if (Operators.CompareString(left, mKeyColumnName, false) == 0)
						{
							string left2 = cboSearchPattern.Text;
							if (Operators.CompareString(left2, "Beginning of Field", false) != 0)
							{
								if (Operators.CompareString(left2, "Any Part of Field", false) == 0)
								{
									strSearch = mKeyColumn + " LIKE '%" + txtValue.Text + "%'";
								}
							}
							else
							{
								strSearch = mKeyColumn + " LIKE '" + txtValue.Text + "%'";
							}
						}
						else if (Operators.CompareString(left, mDescColumnName, false) == 0)
						{
							string left3 = cboSearchPattern.Text;
							if (Operators.CompareString(left3, "Beginning of Field", false) != 0)
							{
								if (Operators.CompareString(left3, "Any Part of Field", false) == 0)
								{
									strSearch = mDescColumn + " LIKE '%" + txtValue.Text + "%'";
								}
							}
							else
							{
								strSearch = mDescColumn + " LIKE '" + txtValue.Text + "%'";
							}
						}
						else if (Operators.CompareString(left, mKeyColumnName2, false) == 0)
						{
							string left4 = cboSearchPattern.Text;
							if (Operators.CompareString(left4, "Beginning of Field", false) != 0)
							{
								if (Operators.CompareString(left4, "Any Part of Field", false) == 0)
								{
									strSearch = mKeyColumn2 + " LIKE '%" + txtValue.Text + "%'";
								}
							}
							else
							{
								strSearch = mKeyColumn2 + " LIKE '" + txtValue.Text + "%'";
							}
						}
						else if (Operators.CompareString(left, mDescColumnName2, false) == 0)
						{
							string left5 = cboSearchPattern.Text;
							if (Operators.CompareString(left5, "Beginning of Field", false) != 0)
							{
								if (Operators.CompareString(left5, "Any Part of Field", false) == 0)
								{
									strSearch = mDescColumn2 + " LIKE '%" + txtValue.Text + "%'";
								}
							}
							else
							{
								strSearch = mDescColumn2 + " LIKE '" + txtValue.Text + "%'";
							}
						}
						else
						{
							string left6 = cboSearchPattern.Text;
							if (Operators.CompareString(left6, "Beginning of Field", false) == 0)
							{
								strSearch = ((!blnIsDateColumn) ? ("[" + cboSearchBy.Text + "] LIKE '" + txtValue.Text + "%'") : ("CONVERT(VARCHAR, [" + cboSearchBy.Text + "], 103) LIKE '" + txtValue.Text + "%'"));
							}
							else if (Operators.CompareString(left6, "Any Part of Field", false) == 0)
							{
								strSearch = ((!blnIsDateColumn) ? ("[" + cboSearchBy.Text + "] LIKE '%" + txtValue.Text + "%'") : ("CONVERT(VARCHAR, [" + cboSearchBy.Text + "], 103) LIKE '%" + txtValue.Text + "%'"));
							}
						}
						if (Operators.CompareString(strSearch, "", false) != 0)
						{
							strSQL = strSQL + " AND " + strSearch;
						}
					}
				}
				else
				{
					if (Operators.CompareString(mWhere1, "", false) != 0)
					{
						strSQL = strSQL + " WHERE " + mWhere1;
					}
					if (Operators.CompareString(txtValue.Text, "", false) != 0)
					{
						string left7 = cboSearchBy.Text;
						if (Operators.CompareString(left7, mKeyColumnName, false) == 0)
						{
							string left8 = cboSearchPattern.Text;
							if (Operators.CompareString(left8, "Beginning of Field", false) != 0)
							{
								if (Operators.CompareString(left8, "Any Part of Field", false) == 0)
								{
									strSearch = mKeyColumn + " LIKE '%" + txtValue.Text + "%'";
								}
							}
							else
							{
								strSearch = mKeyColumn + " LIKE '" + txtValue.Text + "%'";
							}
						}
						else if (Operators.CompareString(left7, mDescColumnName, false) == 0)
						{
							string left9 = cboSearchPattern.Text;
							if (Operators.CompareString(left9, "Beginning of Field", false) != 0)
							{
								if (Operators.CompareString(left9, "Any Part of Field", false) == 0)
								{
									strSearch = mDescColumn + " LIKE '%" + txtValue.Text + "%'";
								}
							}
							else
							{
								strSearch = mDescColumn + " LIKE '" + txtValue.Text + "%'";
							}
						}
						else if (Operators.CompareString(left7, mKeyColumnName2, false) == 0)
						{
							string left10 = cboSearchPattern.Text;
							if (Operators.CompareString(left10, "Beginning of Field", false) != 0)
							{
								if (Operators.CompareString(left10, "Any Part of Field", false) == 0)
								{
									strSearch = mKeyColumn2 + " LIKE '%" + txtValue.Text + "%'";
								}
							}
							else
							{
								strSearch = mKeyColumn2 + " LIKE '" + txtValue.Text + "%'";
							}
						}
						else if (Operators.CompareString(left7, mDescColumnName2, false) == 0)
						{
							string left11 = cboSearchPattern.Text;
							if (Operators.CompareString(left11, "Beginning of Field", false) != 0)
							{
								if (Operators.CompareString(left11, "Any Part of Field", false) == 0)
								{
									strSearch = mDescColumn2 + " LIKE '%" + txtValue.Text + "%'";
								}
							}
							else
							{
								strSearch = mDescColumn2 + " LIKE '" + txtValue.Text + "%'";
							}
						}
						else
						{
							string left12 = cboSearchPattern.Text;
							if (Operators.CompareString(left12, "Beginning of Field", false) == 0)
							{
								strSearch = ((!blnIsDateColumn) ? ("[" + cboSearchBy.Text + "] LIKE '" + txtValue.Text + "%'") : ("CONVERT(VARCHAR, [" + cboSearchBy.Text + "], 103) LIKE '" + txtValue.Text + "%'"));
							}
							else if (Operators.CompareString(left12, "Any Part of Field", false) == 0)
							{
								strSearch = ((!blnIsDateColumn) ? ("[" + cboSearchBy.Text + "] LIKE '%" + txtValue.Text + "%'") : ("CONVERT(VARCHAR, [" + cboSearchBy.Text + "], 103) LIKE '%" + txtValue.Text + "%'"));
							}
						}
						if (Operators.CompareString(strSearch, "", false) != 0)
						{
							strSQL = ((Operators.CompareString(mWhere1, "", false) == 0) ? (strSQL + " WHERE " + strSearch) : (strSQL + " AND " + strSearch));
						}
					}
				}
				if (Operators.CompareString(mOrderBy, "", false) != 0)
				{
					strSQL = strSQL + " ORDER BY " + mOrderBy;
				}
				return strSQL;
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			checked
			{
				try
				{
					cmd.CommandText = ConstructSQL();
					cmd.Connection = DB.GetDBConnection();
					adp.SelectCommand = cmd;
					adp.Fill(dt);
					DataGridView dataGridView = dgvLookup;
					dataGridView.DataSource = dt;
					dataGridView.Refresh();
					int num = dataGridView.Columns.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Strings.InStr(mColumns, "AS [" + dataGridView.Columns[i].Name + "]", CompareMethod.Text) == 0)
						{
							dataGridView.Columns[i].Visible = false;
						}
					}
					dataGridView = null;
					Common.WriteLookupSetting(mLKPCD, (int)Math.Round(NumControl1.Value));
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, "Lookup", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
				finally
				{
				}
			}
		}
	}
}
