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
	public class frmPCERTF : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbTORACK")]
		private ComboBox _cbTORACK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnUPDATE")]
		private Button _btnUPDATE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCANCEL")]
		private Button _btnCANCEL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbFROMRACK")]
		private ComboBox _cbFROMRACK;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbFROMLOCID")]
		private ComboBox _cbFROMLOCID;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cbTOLOCID")]
		private ComboBox _cbTOLOCID;

		[field: AccessedThroughProperty("Panel2")]
		internal virtual Panel Panel2
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

		internal virtual ComboBox cbTORACK
		{
			[CompilerGenerated]
			get
			{
				return _cbTORACK;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbTORACK_SelectedIndexChanged;
				ComboBox comboBox = _cbTORACK;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbTORACK = value;
				comboBox = _cbTORACK;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
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
				EventHandler value2 = btnBACK_Click;
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

		internal virtual Button btnUPDATE
		{
			[CompilerGenerated]
			get
			{
				return _btnUPDATE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnUPDATE_Click;
				Button button = _btnUPDATE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnUPDATE = value;
				button = _btnUPDATE;
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual ComboBox cbFROMRACK
		{
			[CompilerGenerated]
			get
			{
				return _cbFROMRACK;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbFROMRACK_SelectedIndexChanged;
				ComboBox comboBox = _cbFROMRACK;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbFROMRACK = value;
				comboBox = _cbFROMRACK;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("dgvFROMRACK")]
		internal virtual DataGridView dgvFROMRACK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("dgvTORACK")]
		internal virtual DataGridView dgvTORACK
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

		internal virtual ComboBox cbFROMLOCID
		{
			[CompilerGenerated]
			get
			{
				return _cbFROMLOCID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbFROMLOCID_SelectedIndexChanged;
				ComboBox comboBox = _cbFROMLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbFROMLOCID = value;
				comboBox = _cbFROMLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		internal virtual ComboBox cbTOLOCID
		{
			[CompilerGenerated]
			get
			{
				return _cbTOLOCID;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = cbTOLOCID_SelectedIndexChanged;
				ComboBox comboBox = _cbTOLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
				}
				_cbTOLOCID = value;
				comboBox = _cbTOLOCID;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
				}
			}
		}

		public frmPCERTF()
		{
			base.Load += frmPCERTF_Load;
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
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvTORACK = new System.Windows.Forms.DataGridView();
			this.dgvFROMRACK = new System.Windows.Forms.DataGridView();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnUPDATE = new System.Windows.Forms.Button();
			this.btnCANCEL = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.cbTORACK = new System.Windows.Forms.ComboBox();
			this.cbFROMRACK = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cbFROMLOCID = new System.Windows.Forms.ComboBox();
			this.cbTOLOCID = new System.Windows.Forms.ComboBox();
			this.Panel2.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvTORACK).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvFROMRACK).BeginInit();
			this.TableLayoutPanel3.SuspendLayout();
			base.SuspendLayout();
			this.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel2.AutoScroll = true;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.TableLayoutPanel2);
			this.Panel2.Location = new System.Drawing.Point(3, 2);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(1366, 670);
			this.Panel2.TabIndex = 4;
			this.TableLayoutPanel2.AutoSize = true;
			this.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel2.ColumnCount = 5;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel2.Controls.Add(this.dgvTORACK, 2, 2);
			this.TableLayoutPanel2.Controls.Add(this.dgvFROMRACK, 0, 2);
			this.TableLayoutPanel2.Controls.Add(this.TableLayoutPanel3, 0, 4);
			this.TableLayoutPanel2.Controls.Add(this.Label2, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbTORACK, 3, 1);
			this.TableLayoutPanel2.Controls.Add(this.cbFROMRACK, 1, 1);
			this.TableLayoutPanel2.Controls.Add(this.Label3, 0, 0);
			this.TableLayoutPanel2.Controls.Add(this.Label1, 2, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbFROMLOCID, 1, 0);
			this.TableLayoutPanel2.Controls.Add(this.cbTOLOCID, 3, 0);
			this.TableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
			this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 5;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.Size = new System.Drawing.Size(782, 431);
			this.TableLayoutPanel2.TabIndex = 1;
			this.dgvTORACK.AllowUserToAddRows = false;
			this.dgvTORACK.AllowUserToDeleteRows = false;
			this.dgvTORACK.AllowUserToResizeColumns = false;
			this.dgvTORACK.AllowUserToResizeRows = false;
			this.dgvTORACK.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvTORACK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel2.SetColumnSpan(this.dgvTORACK, 2);
			this.dgvTORACK.Location = new System.Drawing.Point(394, 71);
			this.dgvTORACK.MultiSelect = false;
			this.dgvTORACK.Name = "dgvTORACK";
			this.dgvTORACK.ReadOnly = true;
			this.dgvTORACK.RowHeadersVisible = false;
			this.dgvTORACK.RowHeadersWidth = 51;
			this.dgvTORACK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTORACK.Size = new System.Drawing.Size(385, 289);
			this.dgvTORACK.TabIndex = 29;
			this.dgvTORACK.TabStop = false;
			this.dgvFROMRACK.AllowUserToAddRows = false;
			this.dgvFROMRACK.AllowUserToDeleteRows = false;
			this.dgvFROMRACK.AllowUserToResizeColumns = false;
			this.dgvFROMRACK.AllowUserToResizeRows = false;
			this.dgvFROMRACK.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvFROMRACK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.TableLayoutPanel2.SetColumnSpan(this.dgvFROMRACK, 2);
			this.dgvFROMRACK.Location = new System.Drawing.Point(3, 71);
			this.dgvFROMRACK.MultiSelect = false;
			this.dgvFROMRACK.Name = "dgvFROMRACK";
			this.dgvFROMRACK.RowHeadersVisible = false;
			this.dgvFROMRACK.RowHeadersWidth = 51;
			this.dgvFROMRACK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFROMRACK.Size = new System.Drawing.Size(385, 289);
			this.dgvFROMRACK.TabIndex = 28;
			this.dgvFROMRACK.TabStop = false;
			this.TableLayoutPanel3.AutoSize = true;
			this.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel3.ColumnCount = 3;
			this.TableLayoutPanel2.SetColumnSpan(this.TableLayoutPanel3, 4);
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnUPDATE, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.btnCANCEL, 1, 0);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(3, 375);
			this.TableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 1;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel3.TabIndex = 2;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(255, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 23;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnUPDATE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnUPDATE.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnUPDATE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUPDATE.Image = IMS.My.Resources.Resources.Save;
			this.btnUPDATE.Location = new System.Drawing.Point(3, 2);
			this.btnUPDATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnUPDATE.Name = "btnUPDATE";
			this.btnUPDATE.Size = new System.Drawing.Size(120, 50);
			this.btnUPDATE.TabIndex = 20;
			this.btnUPDATE.Text = "Update";
			this.btnUPDATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnUPDATE.UseVisualStyleBackColor = false;
			this.btnCANCEL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCANCEL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCANCEL.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCANCEL.Location = new System.Drawing.Point(129, 2);
			this.btnCANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCANCEL.Name = "btnCANCEL";
			this.btnCANCEL.Size = new System.Drawing.Size(120, 50);
			this.btnCANCEL.TabIndex = 22;
			this.btnCANCEL.Text = "Cancel";
			this.btnCANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCANCEL.UseVisualStyleBackColor = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 41);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(73, 20);
			this.Label2.TabIndex = 25;
			this.Label2.Text = "Rack No";
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(394, 7);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(28, 20);
			this.Label1.TabIndex = 26;
			this.Label1.Text = "To";
			this.cbTORACK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTORACK.FormattingEnabled = true;
			this.cbTORACK.Location = new System.Drawing.Point(428, 37);
			this.cbTORACK.Name = "cbTORACK";
			this.cbTORACK.Size = new System.Drawing.Size(217, 28);
			this.cbTORACK.TabIndex = 9;
			this.cbFROMRACK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFROMRACK.FormattingEnabled = true;
			this.cbFROMRACK.Location = new System.Drawing.Point(87, 37);
			this.cbFROMRACK.Name = "cbFROMRACK";
			this.cbFROMRACK.Size = new System.Drawing.Size(217, 28);
			this.cbFROMRACK.TabIndex = 27;
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 7);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(78, 20);
			this.Label3.TabIndex = 30;
			this.Label3.Text = "Location ";
			this.cbFROMLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFROMLOCID.FormattingEnabled = true;
			this.cbFROMLOCID.Location = new System.Drawing.Point(87, 3);
			this.cbFROMLOCID.Name = "cbFROMLOCID";
			this.cbFROMLOCID.Size = new System.Drawing.Size(217, 28);
			this.cbFROMLOCID.TabIndex = 31;
			this.cbTOLOCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTOLOCID.FormattingEnabled = true;
			this.cbTOLOCID.Location = new System.Drawing.Point(428, 3);
			this.cbTOLOCID.Name = "cbTOLOCID";
			this.cbTOLOCID.Size = new System.Drawing.Size(217, 28);
			this.cbTOLOCID.TabIndex = 32;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmPCERTF";
			base.Tag = "PCERTF";
			this.Text = "Stock Rack Transfer";
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvTORACK).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvFROMRACK).EndInit();
			this.TableLayoutPanel3.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void frmPCERTF_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BindComboBox();
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT INRBAL_LOCID, MALOC_LOCNM FROM INRBAL_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MALOC_TBL WITH (NOLOCK) ON MALOC_LOCID = INRBAL_LOCID ";
			cbFROMLOCID.ValueMember = "INRBAL_LOCID";
			cbFROMLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbFROMLOCID);
			cbTOLOCID.ValueMember = "INRBAL_LOCID";
			cbTOLOCID.DisplayMember = "MALOC_LOCNM";
			Common.RetriveComboItembySQL(strSQL, cbTOLOCID);
		}

		private void btnCANCEL_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void ClearDetails()
		{
			cbFROMRACK.SelectedIndex = -1;
			cbTORACK.SelectedIndex = -1;
		}

		private void btnBACK_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnUPDATE_Click(object sender, EventArgs e)
		{
			OleDbCommand cmd = new OleDbCommand();
			checked
			{
				int num = dgvFROMRACK.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(dgvFROMRACK.Rows[i].Cells["CHK"].Value, true, false))
					{
						string strSQL = "EXEC spPCERTF ";
						strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbFROMLOCID.SelectedValue)) + "', ";
						strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbFROMRACK.SelectedValue)) + "', ";
						strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(dgvFROMRACK.Rows[i].Cells["INRBAL_ITMCD"].Value)) + "', ";
						strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(dgvFROMRACK.Rows[i].Cells["INRBAL_PLTID"].Value)) + "', ";
						strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbTOLOCID.SelectedValue)) + "', ";
						strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbTORACK.SelectedValue)) + "', ";
						strSQL = strSQL + "'" + Common.gfValidSQLStr(PublicVar.gstrLogonID) + "' ";
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
					}
				}
				MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record edited!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				ClearDetails();
			}
		}

		private void cbFROMRACK_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = 0;
			dgvFROMRACK.DataSource = null;
			string strSQL = "SELECT CAST(0 AS BIT) AS CHK, INRBAL_ITMCD, INRBAL_PLTID, ISNULL(SUM(INRBAL_QTY),0) ";
			strSQL += "FROM INRBAL_TBL WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE INRBAL_RACKNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbFROMRACK.SelectedValue)) + "' ";
			strSQL += "GROUP BY INRBAL_ITMCD, INRBAL_PLTID ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvFROMRACK.ClearSelection();
					DataGridView dataGridView = dgvFROMRACK;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 30;
					dataGridView.Columns[i].HeaderText = "";
					dataGridView.Columns[i].ReadOnly = false;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Pallet");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void cbTORACK_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = 0;
			dgvTORACK.DataSource = null;
			string strSQL = "SELECT INRBAL_ITMCD, INRBAL_PLTID, ISNULL(SUM(INRBAL_QTY),0) ";
			strSQL += "FROM INRBAL_TBL WITH(NOLOCK) ";
			strSQL = strSQL + "WHERE INRBAL_RACKNO = '" + Common.gfValidSQLStr(Conversions.ToString(cbTORACK.SelectedValue)) + "' ";
			strSQL += "GROUP BY INRBAL_ITMCD, INRBAL_PLTID ";
			DataTable dt = DB.ExecProc(strSQL);
			checked
			{
				if (dt.Rows.Count > 0)
				{
					dgvTORACK.ClearSelection();
					DataGridView dataGridView = dgvTORACK;
					dataGridView.DataSource = dt;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 150;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Item No");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 80;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Pallet");
					dataGridView.Columns[i].ReadOnly = true;
					i++;
					dataGridView.Columns[i].Visible = true;
					dataGridView.Columns[i].Width = 100;
					dataGridView.Columns[i].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Quantity");
					dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
					dataGridView.Columns[i].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Quantity);
					dataGridView.Columns[i].ReadOnly = true;
					dataGridView.AutoResizeRows();
					dataGridView.Refresh();
					dataGridView = null;
				}
			}
		}

		private void cbFROMLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT DISTINCT INRBAL_RACKNO, MACOD_CODNM FROM INRBAL_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MACOD_TBL WITH (NOLOCK) ON MACOD_CTYID = 'RACKNO' AND  MACOD_CODID = INRBAL_RACKNO ";
			strSQL = strSQL + "WHERE INRBAL_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbFROMLOCID.SelectedValue)) + "'";
			cbFROMRACK.ValueMember = "INRBAL_RACKNO";
			cbFROMRACK.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbFROMRACK);
		}

		private void cbTOLOCID_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strSQL = "SELECT DISTINCT INRBAL_RACKNO, MACOD_CODNM FROM INRBAL_TBL WITH (NOLOCK) ";
			strSQL += "LEFT JOIN MACOD_TBL WITH (NOLOCK) ON MACOD_CTYID = 'RACKNO' AND  MACOD_CODID = INRBAL_RACKNO ";
			strSQL = strSQL + "WHERE INRBAL_LOCID = '" + Common.gfValidSQLStr(Conversions.ToString(cbTOLOCID.SelectedValue)) + "'";
			cbTORACK.ValueMember = "INRBAL_RACKNO";
			cbTORACK.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbTORACK);
		}
	}
}
