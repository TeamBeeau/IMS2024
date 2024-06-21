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
	public class LookupControl : UserControl
	{
		public delegate void AfterLookupEventHandler(bool Cancel);

		public delegate void BeforeLookupEventHandler();

		public delegate void LeftWithModifiedEventHandler();

		public delegate void KeyDownEventHandler(object sender, KeyEventArgs e);

		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		private string mLKPCD;

		private string mKeyValue;

		private string mDescriptionValue;

		private bool mAllowBlank;

		private Color mDescriptionForeColor;

		private bool mDescriptionVisible1;

		private bool mDescriptionVisible2;

		private int mTextHeight;

		private int mTextWidth;

		private string mColumns;

		private string mTable;

		private string mWhere;

		private string mOrderBy;

		private string mKeyColumn;

		private string mKeyColumnName;

		private string mDescColumn;

		private string mDescColumnName;

		private string mKeyColumn2;

		private string mKeyColumnName2;

		private string mDescColumn2;

		private string mDescColumnName2;

		private string mWhere1;

		private DataRow mOtherValue;

		private int mRecords;

		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return _Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = Button1_Click;
				Button button = _Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				_Button1 = value;
				button = _Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual TextBox TextBox1
		{
			[CompilerGenerated]
			get
			{
				return _TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				KeyEventHandler value2 = TextBox1_KeyDown;
				EventHandler value3 = TextBox1_Leave;
				EventHandler value4 = TextBox1_TextChanged;
				TextBox textBox = _TextBox1;
				if (textBox != null)
				{
					textBox.KeyDown -= value2;
					textBox.Leave -= value3;
					textBox.TextChanged -= value4;
				}
				_TextBox1 = value;
				textBox = _TextBox1;
				if (textBox != null)
				{
					textBox.KeyDown += value2;
					textBox.Leave += value3;
					textBox.TextChanged += value4;
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

		public string LKPCD
		{
			get
			{
				return mLKPCD;
			}
			set
			{
				mLKPCD = value;
			}
		}

		public string KeyValue
		{
			get
			{
				if (mKeyValue == null)
				{
					mKeyValue = "";
				}
				return mKeyValue;
			}
			set
			{
				mKeyValue = value;
				TextBox1.Text = mKeyValue;
			}
		}

		public string DescriptionValue
		{
			get
			{
				return mDescriptionValue;
			}
		}

		public bool AllowBlank
		{
			get
			{
				return mAllowBlank;
			}
			set
			{
				mAllowBlank = value;
			}
		}

		public CharacterCasing CharacterCasing
		{
			get
			{
				return TextBox1.CharacterCasing;
			}
			set
			{
				TextBox1.CharacterCasing = value;
			}
		}

		public Color DescriptionForeColor
		{
			get
			{
				return mDescriptionForeColor;
			}
			set
			{
				mDescriptionForeColor = value;
				Label1.ForeColor = value;
				Label2.ForeColor = value;
			}
		}

		public bool DescriptionVisible1
		{
			get
			{
				return mDescriptionVisible1;
			}
			set
			{
				mDescriptionVisible1 = value;
				Label1.Visible = value;
			}
		}

		public bool DescriptionVisible2
		{
			get
			{
				return mDescriptionVisible2;
			}
			set
			{
				mDescriptionVisible2 = value;
				Label2.Visible = value;
			}
		}

		public int MaxLength
		{
			get
			{
				return TextBox1.MaxLength;
			}
			set
			{
				TextBox1.MaxLength = value;
			}
		}

		public bool Modified
		{
			get
			{
				return TextBox1.Modified;
			}
			set
			{
				TextBox1.Modified = value;
			}
		}

		public bool Multiline_
		{
			get
			{
				return TextBox1.Multiline;
			}
			set
			{
				TextBox1.Multiline = value;
			}
		}

		public string PasswordChar
		{
			get
			{
				return Conversions.ToString(TextBox1.PasswordChar);
			}
			set
			{
				TextBox1.PasswordChar = Conversions.ToChar(value);
			}
		}

		public bool ReadOnly_
		{
			get
			{
				return TextBox1.ReadOnly;
			}
			set
			{
				TextBox1.ReadOnly = value;
				Button1.Enabled = !value;
			}
		}

		public HorizontalAlignment TextAlign
		{
			get
			{
				return TextBox1.TextAlign;
			}
			set
			{
				TextBox1.TextAlign = value;
			}
		}

		public Color TextBackColor
		{
			get
			{
				return TextBox1.BackColor;
			}
			set
			{
				TextBox1.BackColor = value;
			}
		}

		public Color TextForeColor
		{
			get
			{
				return TextBox1.ForeColor;
			}
			set
			{
				TextBox1.ForeColor = value;
			}
		}

		public string Where1
		{
			get
			{
				return mWhere1;
			}
			set
			{
				mWhere1 = value;
			}
		}

		public DataRow OtherValue
		{
			get
			{
				return mOtherValue;
			}
		}

		public Font ActiveFont
		{
			get
			{
				return TextBox1.Font;
			}
			set
			{
				TextBox1.Font = value;
				Button1.Font = value;
				Label1.Font = value;
				Label2.Font = value;
			}
		}

		public int TextHeight
		{
			get
			{
				return mTextHeight;
			}
			set
			{
				mTextHeight = value;
				Size aSize = TextBox1.Size;
				aSize.Height = value;
				TextBox1.Size = aSize;
				aSize = Label1.Size;
				aSize.Height = value;
				Label1.Size = aSize;
				aSize = Label2.Size;
				aSize.Height = value;
				Label2.Size = aSize;
				aSize = Button1.Size;
				aSize.Height = value;
				aSize.Width = value;
				Button1.Size = aSize;
				checked
				{
					Point aLocation = default(Point);
					aLocation.X = Button1.Location.X + Button1.Size.Width + 3;
					Label1.Location = aLocation;
					aLocation = Label2.Location;
					aLocation.Y = TextBox1.Location.Y + TextBox1.Size.Height + 4;
					Label2.Location = aLocation;
				}
			}
		}

		public int TextWidth
		{
			get
			{
				return mTextWidth;
			}
			set
			{
				mTextWidth = value;
				Size aSize = TextBox1.Size;
				aSize.Width = value;
				TextBox1.Size = aSize;
				Point aLocation = Button1.Location;
				checked
				{
					aLocation.X = TextBox1.Location.X + TextBox1.Size.Width + 2;
					Button1.Location = aLocation;
					aLocation.X = aLocation.X + Button1.Size.Width + 3;
					Label1.Location = aLocation;
					aSize = Label2.Size;
					aSize.Width = TextBox1.Size.Width + Button1.Size.Width + Label1.Size.Width + 5;
					Label2.Size = aSize;
				}
			}
		}

		public string LowValue
		{
			get
			{
				if (mKeyValue == null || Information.IsDBNull(mKeyValue) || Operators.CompareString(mKeyValue.Trim(), "", false) == 0)
				{
					return " ";
				}
				return mKeyValue.Trim();
			}
		}

		public string HighValue
		{
			get
			{
				if (mKeyValue == null || Information.IsDBNull(mKeyValue) || Operators.CompareString(mKeyValue.Trim(), "", false) == 0)
				{
					if (TextBox1.MaxLength == 0)
					{
						return "z";
					}
					return Strings.StrDup(TextBox1.MaxLength, "z");
				}
				return mKeyValue.Trim();
			}
		}

		public event AfterLookupEventHandler AfterLookup;

		public event BeforeLookupEventHandler BeforeLookup;

		public event LeftWithModifiedEventHandler LeftWithModified;

		public new event KeyDownEventHandler KeyDown;

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
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			base.SuspendLayout();
			this.Label2.BackColor = System.Drawing.Color.AliceBlue;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new System.Drawing.Point(0, 26);
			this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(734, 22);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Label2";
			this.Label1.BackColor = System.Drawing.Color.AliceBlue;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new System.Drawing.Point(290, 0);
			this.Label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(434, 22);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Label1";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox1.Location = new System.Drawing.Point(0, 0);
			this.TextBox1.Margin = new System.Windows.Forms.Padding(5);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(258, 22);
			this.TextBox1.TabIndex = 1;
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.Image = IMS.My.Resources.Resources.Magnifier;
			this.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Button1.Location = new System.Drawing.Point(260, 0);
			this.Button1.Margin = new System.Windows.Forms.Padding(5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(22, 22);
			this.Button1.TabIndex = 5;
			this.Button1.TabStop = false;
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 17f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.Label2);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new System.Windows.Forms.Padding(5);
			base.Name = "LookupControl";
			base.Size = new System.Drawing.Size(734, 48);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public LookupControl()
		{
			base.BackColorChanged += LookupControl_BackColorChanged;
			base.EnabledChanged += LookupControl_EnabledChanged;
			base.Resize += LookupControl_Resize;
			InitializeComponent();
			mDescriptionVisible1 = true;
			mDescriptionVisible2 = false;
			mDescriptionForeColor = Label1.ForeColor;
			Label1.Text = "";
			Label2.Text = "";
			mTextHeight = TextBox1.Size.Height;
			mTextWidth = TextBox1.Size.Width;
		}

		private void LookupControl_BackColorChanged(object sender, EventArgs e)
		{
			Label1.BackColor = BackColor;
			Label1.Refresh();
			Label2.BackColor = BackColor;
			Label2.Refresh();
		}

		private void LookupControl_EnabledChanged(object sender, EventArgs e)
		{
			TextBox1.Enabled = base.Enabled;
			Button1.Enabled = base.Enabled;
		}

		private void LookupControl_Resize(object sender, EventArgs e)
		{
		}

		private bool ReadXMLSetting()
		{
			DataSet ds = new DataSet();
			bool ReadXMLSetting;
			try
			{
				mColumns = "";
				mTable = "";
				mKeyColumn = "";
				mKeyColumnName = "";
				mDescColumn = "";
				mDescColumnName = "";
				mKeyColumn2 = "";
				mKeyColumnName2 = "";
				mDescColumn2 = "";
				mDescColumnName2 = "";
				ds.ReadXml(Application.StartupPath + "\\Lookup.xml");
				foreach (DataRow dr in ds.Tables["Lookup"].Rows)
				{
					if (Operators.CompareString(dr["LKPCD"].ToString().ToUpper(), mLKPCD, false) == 0)
					{
						mColumns = dr["COLUMNS"].ToString();
						mTable = dr["TABLE"].ToString();
						mWhere = dr["WHERE"].ToString();
						mOrderBy = dr["ORDERBY"].ToString();
						mKeyColumn = dr["KEYCOLUMN"].ToString();
						mKeyColumnName = dr["KEYCOLUMNNAME"].ToString();
						mDescColumn = dr["DESCCOLUMN"].ToString();
						mDescColumnName = dr["DESCCOLUMNNAME"].ToString();
						mKeyColumn2 = dr["KEYCOLUMN2"].ToString();
						mKeyColumnName2 = dr["KEYCOLUMNNAME2"].ToString();
						mDescColumn2 = dr["DESCCOLUMN2"].ToString();
						mDescColumnName2 = dr["DESCCOLUMNNAME2"].ToString();
						break;
					}
				}
				if (Operators.CompareString(mColumns, "", false) == 0 || Operators.CompareString(mTable, "", false) == 0 || Operators.CompareString(mKeyColumn, "", false) == 0 || Operators.CompareString(mKeyColumnName, "", false) == 0)
				{
					MessageBox.Show(Application.StartupPath + "\\Lookup.xml not define properly!", "Lookup", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ReadXMLSetting = false;
				}
				else
				{
					ReadXMLSetting = true;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ReadXMLSetting = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				ds = null;
			}
			return ReadXMLSetting;
		}

		private string ConstructSQL(bool blnIncludeInput)
		{
			mRecords = Common.ReadLookupSetting(mLKPCD);
			string strSQL = ((!mColumns.ToUpper().Contains("DISTINCT")) ? ("SELECT TOP " + mRecords + " " + mColumns) : ("SELECT " + mColumns.ToUpper().Replace("DISTINCT", "DISTINCT TOP " + mRecords)));
			strSQL = strSQL + " FROM " + mTable;
			if (Operators.CompareString(mWhere, "", false) != 0)
			{
				strSQL = strSQL + " WHERE " + mWhere;
				if (Operators.CompareString(mWhere1, "", false) != 0)
				{
					strSQL = strSQL + " AND " + mWhere1;
				}
			}
			else if (Operators.CompareString(mWhere1, "", false) != 0)
			{
				strSQL = strSQL + " WHERE " + mWhere1;
			}
			if (blnIncludeInput)
			{
				string strColumnType = Conversions.ToString(DB.GetColumnValue("TYPE_NAME(SYSTEM_TYPE_ID)", "SYS.COLUMNS", "NAME = '" + mKeyColumn.Replace(" + ", "").Replace("'", "") + "' AND [OBJECT_ID] = OBJECT_ID('" + mTable + "')"));
				switch (strColumnType.ToUpper())
				{
				case "BIGINT":
				case "DECIMAL":
				case "FLOAT":
				case "INT":
				case "SMALLINT":
				case "TINYINT":
					strSQL = ((!((Operators.CompareString(mWhere, "", false) != 0) | (Operators.CompareString(mWhere1, "", false) != 0))) ? string.Concat(strSQL, " WHERE " + mKeyColumn + " = " + Conversions.ToString(Conversion.Val(mKeyValue))) : string.Concat(strSQL, " AND " + mKeyColumn + " = " + Conversions.ToString(Conversion.Val(mKeyValue))));
					break;
				default:
					strSQL = ((!((Operators.CompareString(mWhere, "", false) != 0) | (Operators.CompareString(mWhere1, "", false) != 0))) ? (strSQL + " WHERE " + mKeyColumn + " = '" + mKeyValue + "'") : (strSQL + " AND " + mKeyColumn + " = '" + mKeyValue + "'"));
					break;
				}
			}
			if (Operators.CompareString(mOrderBy, "", false) != 0)
			{
				strSQL = strSQL + " ORDER BY " + mOrderBy;
			}
			return strSQL;
		}

		private void LoadFormLookup()
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			frmLookup frm = new frmLookup();
			cmd.CommandText = ConstructSQL(false);
			cmd.Connection = DB.GetDBConnection();
			adp.SelectCommand = cmd;
			adp.Fill(dt);
			frm.DataSource = dt;
			frm._Columns = mColumns;
			frm._Table = mTable;
			frm._Where = mWhere;
			frm._Where1 = mWhere1;
			frm._OrderBy = mOrderBy;
			frm._Records = mRecords;
			frm._LKPCD = mLKPCD;
			frm._KeyColumn = mKeyColumn;
			frm._KeyColumnName = mKeyColumnName;
			frm._DescColumn = mDescColumn;
			frm._DescColumnName = mDescColumnName;
			frm._KeyColumn2 = mKeyColumn2;
			frm._KeyColumnName2 = mKeyColumnName2;
			frm._DescColumn2 = mDescColumn2;
			frm._DescColumnName2 = mDescColumnName2;
			frm.Lookup(base.ParentForm);
			if (!frm.ValueSelected)
			{
				mOtherValue = dt.NewRow();
				AfterLookupEventHandler afterLookupEvent = AfterLookup;
				if (afterLookupEvent != null)
				{
					afterLookupEvent(true);
				}
				return;
			}
			dt = frm.DataSource;
			DataGridViewRow mGridRow = frm.SelectedRow;
			mKeyValue = Conversions.ToString(mGridRow.Cells[mKeyColumnName].Value);
			bool blnDataChanged = Operators.CompareString(TextBox1.Text.Trim(), mKeyValue.Trim(), false) != 0;
			TextBox1.Text = mKeyValue;
			TextBox1.Modified = false;
			if (Operators.CompareString(mDescColumnName, "", false) != 0)
			{
				mDescriptionValue = Conversions.ToString(mGridRow.Cells[mDescColumnName].Value);
			}
			else
			{
				mDescriptionValue = "";
			}
			Label1.Text = mDescriptionValue;
			Label2.Text = mDescriptionValue;
			mOtherValue = (DataRow)NewLateBinding.LateGet(mGridRow.DataBoundItem, null, "Row", new object[0], null, null, null);
			AfterLookupEventHandler afterLookupEvent2 = AfterLookup;
			if (afterLookupEvent2 != null)
			{
				afterLookupEvent2(!blnDataChanged);
			}
		}

		public void RefreshDescription()
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			mDescriptionValue = "";
			Label1.Text = mDescriptionValue;
			Label2.Text = mDescriptionValue;
			if (!ReadXMLSetting())
			{
				return;
			}
			cmd.CommandText = ConstructSQL(true);
			cmd.Connection = DB.GetDBConnection();
			adp.SelectCommand = cmd;
			adp.Fill(dt);
			if (dt.Rows.Count > 0)
			{
				if (Operators.CompareString(mDescColumnName, "", false) != 0)
				{
					mDescriptionValue = dt.Rows[0][mDescColumnName].ToString();
					Label1.Text = mDescriptionValue;
					Label2.Text = mDescriptionValue;
				}
			}
			else
			{
				mDescriptionValue = "";
				Label1.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(mKeyValue, "", false) != 0, "#Invalid code#", ""));
				Label2.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(mKeyValue, "", false) != 0, "#Invalid code#", ""));
			}
		}

		public bool IsValid()
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			if (!ReadXMLSetting())
			{
				return false;
			}
			if ((Operators.CompareString(TextBox1.Text.Trim(), "", false) == 0) & mAllowBlank)
			{
				return true;
			}
			cmd.CommandText = ConstructSQL(true);
			cmd.Connection = DB.GetDBConnection();
			adp.SelectCommand = cmd;
			adp.Fill(dt);
			if (dt.Rows.Count == 0)
			{
				return false;
			}
			return true;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			BeforeLookupEventHandler beforeLookupEvent = BeforeLookup;
			if (beforeLookupEvent != null)
			{
				beforeLookupEvent();
			}
			if (ReadXMLSetting())
			{
				LoadFormLookup();
			}
		}

		private void TextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			mKeyValue = TextBox1.Text;
			KeyDownEventHandler keyDownEvent = KeyDown;
			if (keyDownEvent != null)
			{
				keyDownEvent(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void TextBox1_Leave(object sender, EventArgs e)
		{
			if (TextBox1.Modified)
			{
				mKeyValue = TextBox1.Text;
				RefreshDescription();
				LeftWithModifiedEventHandler leftWithModifiedEvent = LeftWithModified;
				if (leftWithModifiedEvent != null)
				{
					leftWithModifiedEvent();
				}
			}
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
			switch (TextBox1.CharacterCasing)
			{
			case CharacterCasing.Normal:
				break;
			case CharacterCasing.Upper:
				mKeyValue = Strings.UCase(TextBox1.Text);
				TextBox1.Text = mKeyValue;
				break;
			case CharacterCasing.Lower:
				mKeyValue = Strings.LCase(TextBox1.Text);
				TextBox1.Text = mKeyValue;
				break;
			}
		}
	}
}
