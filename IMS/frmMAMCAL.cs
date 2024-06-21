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
	public class frmMAMCAL : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtpYEAR")]
		private DateTimePicker _dtpYEAR;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("mthCAL")]
		private MonthCalendar _mthCAL;

		private OleDbCommand cmd;

		private SqlDataReader Dr;

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

		[field: AccessedThroughProperty("lblDOCNOFR")]
		internal virtual Label lblDOCNOFR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual DateTimePicker dtpYEAR
		{
			[CompilerGenerated]
			get
			{
				return _dtpYEAR;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = dtpYEAR_ValueChanged;
				DateTimePicker dateTimePicker = _dtpYEAR;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged -= value2;
				}
				_dtpYEAR = value;
				dateTimePicker = _dtpYEAR;
				if (dateTimePicker != null)
				{
					dateTimePicker.ValueChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("TableLayoutPanel4")]
		internal virtual TableLayoutPanel TableLayoutPanel4
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

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
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

		[field: AccessedThroughProperty("txtDESC")]
		internal virtual TextBox txtDESC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual MonthCalendar mthCAL
		{
			[CompilerGenerated]
			get
			{
				return _mthCAL;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				DateRangeEventHandler value2 = mthCAL_DateChanged;
				MonthCalendar monthCalendar = _mthCAL;
				if (monthCalendar != null)
				{
					monthCalendar.DateChanged -= value2;
				}
				_mthCAL = value;
				monthCalendar = _mthCAL;
				if (monthCalendar != null)
				{
					monthCalendar.DateChanged += value2;
				}
			}
		}

		[field: AccessedThroughProperty("txtDATE")]
		internal virtual TextBox txtDATE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkSTSFG")]
		internal virtual CheckBox chkSTSFG
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmMAMCAL()
		{
			base.Load += frmMAMCAL_Load;
			base.FormClosing += frmMAMCAL_FormClosing;
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
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.chkSTSFG = new System.Windows.Forms.CheckBox();
			this.txtDATE = new System.Windows.Forms.TextBox();
			this.lblDOCNOFR = new System.Windows.Forms.Label();
			this.dtpYEAR = new System.Windows.Forms.DateTimePicker();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtDESC = new System.Windows.Forms.TextBox();
			this.mthCAL = new System.Windows.Forms.MonthCalendar();
			this.Panel1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.TableLayoutPanel3);
			this.Panel1.Location = new System.Drawing.Point(4, 3);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1343, 624);
			this.Panel1.TabIndex = 1;
			this.TableLayoutPanel3.ColumnCount = 4;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel3.Controls.Add(this.txtDATE, 1, 4);
			this.TableLayoutPanel3.Controls.Add(this.lblDOCNOFR, 0, 0);
			this.TableLayoutPanel3.Controls.Add(this.dtpYEAR, 1, 0);
			this.TableLayoutPanel3.Controls.Add(this.TableLayoutPanel4, 0, 8);
			this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 4);
			this.TableLayoutPanel3.Controls.Add(this.Label3, 0, 5);
			this.TableLayoutPanel3.Controls.Add(this.txtDESC, 1, 5);
			this.TableLayoutPanel3.Controls.Add(this.mthCAL, 1, 1);
			this.TableLayoutPanel3.Controls.Add(this.chkSTSFG, 3, 4);
			this.TableLayoutPanel3.Location = new System.Drawing.Point(8, 10);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 8;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.Size = new System.Drawing.Size(798, 392);
			this.TableLayoutPanel3.TabIndex = 2;
			this.chkSTSFG.AutoSize = true;
			this.chkSTSFG.Location = new System.Drawing.Point(291, 212);
			this.chkSTSFG.Name = "chkSTSFG";
			this.chkSTSFG.Size = new System.Drawing.Size(74, 20);
			this.chkSTSFG.TabIndex = 3;
			this.chkSTSFG.Text = "Holiday";
			this.chkSTSFG.UseVisualStyleBackColor = true;
			this.txtDATE.Location = new System.Drawing.Point(85, 211);
			this.txtDATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDATE.Name = "txtDATE";
			this.txtDATE.ReadOnly = true;
			this.txtDATE.Size = new System.Drawing.Size(180, 22);
			this.txtDATE.TabIndex = 4;
			this.lblDOCNOFR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblDOCNOFR.AutoSize = true;
			this.lblDOCNOFR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDOCNOFR.Location = new System.Drawing.Point(3, 5);
			this.lblDOCNOFR.Name = "lblDOCNOFR";
			this.lblDOCNOFR.Size = new System.Drawing.Size(37, 16);
			this.lblDOCNOFR.TabIndex = 3;
			this.lblDOCNOFR.Text = "Year";
			this.TableLayoutPanel3.SetColumnSpan(this.dtpYEAR, 2);
			this.dtpYEAR.CustomFormat = "yyyy";
			this.dtpYEAR.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpYEAR.Location = new System.Drawing.Point(85, 2);
			this.dtpYEAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpYEAR.Name = "dtpYEAR";
			this.dtpYEAR.Size = new System.Drawing.Size(105, 22);
			this.dtpYEAR.TabIndex = 5;
			this.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.TableLayoutPanel4.AutoSize = true;
			this.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel4.ColumnCount = 3;
			this.TableLayoutPanel3.SetColumnSpan(this.TableLayoutPanel4, 4);
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanel4.Controls.Add(this.btnClose, 2, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnSave, 0, 0);
			this.TableLayoutPanel4.Controls.Add(this.btnCancel, 1, 0);
			this.TableLayoutPanel4.Location = new System.Drawing.Point(3, 331);
			this.TableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 1;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.Size = new System.Drawing.Size(378, 54);
			this.TableLayoutPanel4.TabIndex = 3;
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
			this.btnClose.TabIndex = 20;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
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
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "Save";
			this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnCancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
			this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Image = IMS.My.Resources.Resources.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(129, 2);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(120, 50);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 214);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(37, 16);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Date";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 262);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(76, 16);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Description";
			this.TableLayoutPanel3.SetColumnSpan(this.txtDESC, 3);
			this.txtDESC.Location = new System.Drawing.Point(85, 237);
			this.txtDESC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtDESC.Multiline = true;
			this.txtDESC.Name = "txtDESC";
			this.txtDESC.Size = new System.Drawing.Size(486, 66);
			this.txtDESC.TabIndex = 3;
			this.TableLayoutPanel3.SetColumnSpan(this.mthCAL, 3);
			this.mthCAL.Location = new System.Drawing.Point(91, 35);
			this.mthCAL.Name = "mthCAL";
			this.TableLayoutPanel3.SetRowSpan(this.mthCAL, 3);
			this.mthCAL.ShowToday = false;
			this.mthCAL.ShowTodayCircle = false;
			this.mthCAL.TabIndex = 3;
			this.mthCAL.TodayDate = new System.DateTime(0L);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1350, 631);
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "frmMAMCAL";
			base.Tag = "MAMCAL";
			this.Text = "Calendar Maintenance";
			this.Panel1.ResumeLayout(false);
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.TableLayoutPanel4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private void frmMAMCAL_Load(object sender, EventArgs e)
		{
			Common.Set_FormLanguage(this);
			BoldDate();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int status = (chkSTSFG.Checked ? 1 : 0);
			string strSQL = "EXEC spMAMCAL ";
			strSQL = strSQL + " " + Conversions.ToString(status) + ", ";
			strSQL = strSQL + "'" + Conversions.ToString(dtpYEAR.Value.Year) + "', ";
			strSQL = strSQL + "'" + Common.gfSQLDate(Conversions.ToDate(txtDATE.Text)) + "', ";
			strSQL = strSQL + "'" + Common.gfValidSQLStr(txtDESC.Text) + "', ";
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
				MessageBox.Show(ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
				return;
			}
			MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Record edited!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			BoldDate();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			txtDESC.Text = string.Empty;
			txtDATE.Text = string.Empty;
			chkSTSFG.Checked = false;
			Close();
		}

		private void frmMAMCAL_FormClosing(object sender, FormClosingEventArgs e)
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

		private void btnCancel_Click(object sender, EventArgs e)
		{
			ClearDetails();
		}

		private void ClearDetails()
		{
			dtpYEAR.Value = DateAndTime.Now;
			mthCAL.SelectionRange = new SelectionRange(DateAndTime.Now, DateAndTime.Now);
			txtDESC.Text = string.Empty;
			txtDATE.Text = string.Empty;
			chkSTSFG.Checked = false;
		}

		private void dtpYEAR_ValueChanged(object sender, EventArgs e)
		{
			DateTime currentDate = new DateTime(dtpYEAR.Value.Year, 1, 1);
			mthCAL.SelectionRange = new SelectionRange(currentDate, currentDate);
		}

		private void mthCAL_DateChanged(object sender, DateRangeEventArgs e)
		{
			txtDATE.Text = mthCAL.SelectionStart.ToString("yyyy-MM-dd");
			string strWHERE = "MACAL_YEAR = '" + Conversions.ToString(dtpYEAR.Value.Year) + "' ";
			strWHERE = strWHERE + "AND MACAL_DATE = '" + txtDATE.Text + "' ";
			string desc = Conversions.ToString(DB.GetColumnValue("MACAL_DESC", "MACAL_TBL", strWHERE));
			txtDESC.Text = desc;
			int status = Conversions.ToInteger(DB.GetColumnValue("MACAL_STSFG", "MACAL_TBL", strWHERE));
			if (status == 1)
			{
				chkSTSFG.Checked = true;
			}
			else
			{
				chkSTSFG.Checked = false;
			}
		}

		private void BoldDate()
		{
			DataTable dt = DB.GetTable("MACAL_DATE", "MACAL_TBL", "MACAL_YEAR = '" + Conversions.ToString(dtpYEAR.Value.Year) + "' AND MACAL_STSFG = '1' ", "MACAL_DATE");
			mthCAL.RemoveAllBoldedDates();
			checked
			{
				if (dt.Rows.Count > 0)
				{
					int num = dt.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						string iDate = dt.Rows[i]["MACAL_DATE"].ToString();
						DateTime oDate = Convert.ToDateTime(iDate);
						mthCAL.AddBoldedDate(oDate);
					}
				}
				mthCAL.UpdateBoldedDates();
			}
		}
	}
}
