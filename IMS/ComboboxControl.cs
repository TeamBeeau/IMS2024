using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.CompilerServices;
using Button = System.Windows.Forms.Button;
using DataTable = System.Data.DataTable;
using TextBox = System.Windows.Forms.TextBox;

namespace IMS
{
	[DesignerGenerated]
	public class ComboboxControl : UserControl
	{
		public delegate void SelectedIndexChangedEventHandler(object sender, EventArgs e);

		public delegate void SelectedValueChangedEventHandler(object sender, EventArgs e);

		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		private string mDisplayMember;

		private string mValueMember;

		private string mDataTable;

		public string mWhereClause;

		private int mComboboxWidth;

		private int mTextMultiline;

		private bool mHasBlankValue;

		private string mBlankValue;

		internal virtual ComboBox ComboBox1
		{
			[CompilerGenerated]
			get
			{
				return _ComboBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = ComboBox1_SelectedIndexChanged;
				EventHandler value3 = ComboBox1_SelectedValueChanged;
				ComboBox comboBox = _ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= value2;
					comboBox.SelectedValueChanged -= value3;
				}
				_ComboBox1 = value;
				comboBox = _ComboBox1;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += value2;
					comboBox.SelectedValueChanged += value3;
				}
			}
		}

		[field: AccessedThroughProperty("TextBox1")]
		internal virtual TextBox TextBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

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

		public string DisplayMember
		{
			get
			{
				return mDisplayMember;
			}
			set
			{
				mDisplayMember = value;
			}
		}

		public string ValueMember
		{
			get
			{
				return mValueMember;
			}
			set
			{
				mValueMember = value;
			}
		}

		public string DataTable
		{
			get
			{
				return mDataTable;
			}
			set
			{
				mDataTable = value;
			}
		}

		public string WhereClause
		{
			get
			{
				return mWhereClause;
			}
			set
			{
				mWhereClause = value;
			}
		}

		public int ComboboxWidth
		{
			get
			{
				return mComboboxWidth;
			}
			set
			{
				mComboboxWidth = value;
				Size aSize = ComboBox1.Size;
				aSize.Width = value;
				ComboBox1.Size = aSize;
			}
		}

		public bool TextMultiline
		{
			get
			{
				return mTextMultiline != 0;
			}
			set
			{
				mTextMultiline = 0 - (value ? 1 : 0);
				TextBox1.Multiline = value;
			}
		}

		public bool HasBlankValue
		{
			get
			{
				return mHasBlankValue;
			}
			set
			{
				mHasBlankValue = value;
			}
		}

		public string BlankValue
		{
			get
			{
				return mBlankValue;
			}
			set
			{
				mBlankValue = value;
			}
		}

		public ComboBoxStyle DropdownStyle
		{
			get
			{
				return ComboBox1.DropDownStyle;
			}
			set
			{
				ComboBox1.DropDownStyle = value;
			}
		}

		public int SelectedIndex
		{
			get
			{
				return ComboBox1.SelectedIndex;
			}
			set
			{
				ComboBox1.SelectedIndex = value;
			}
		}

		public object SelectedItem
		{
			get
			{
				return ComboBox1.SelectedItem;
			}
			set
			{
				ComboBox1.SelectedItem = RuntimeHelpers.GetObjectValue(value);
			}
		}

		public object SelectedValue
		{
			get
			{
				return ComboBox1.SelectedValue;
			}
			set
			{
				ComboBox1.SelectedValue = RuntimeHelpers.GetObjectValue(value);
			}
		}

		public event SelectedIndexChangedEventHandler SelectedIndexChanged;

		public event SelectedValueChangedEventHandler SelectedValueChanged;

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
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.Button1 = new System.Windows.Forms.Button();
			base.SuspendLayout();
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(73, 0);
			this.ComboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(170, 21);
			this.ComboBox1.TabIndex = 2;
			this.TextBox1.Location = new System.Drawing.Point(0, 0);
			this.TextBox1.Margin = new System.Windows.Forms.Padding(2);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(50, 21);
			this.TextBox1.TabIndex = 0;
			this.Button1.BackgroundImage = IMS.My.Resources.Resources.Filter;
			this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Button1.Location = new System.Drawing.Point(50, -1);
			this.Button1.Margin = new System.Windows.Forms.Padding(2);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(22, 22);
			this.Button1.TabIndex = 1;
			this.Button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.ComboBox1);
			base.Margin = new System.Windows.Forms.Padding(2);
			base.Name = "ComboboxControl";
			base.Size = new System.Drawing.Size(244, 21);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public ComboboxControl()
		{
			InitializeComponent();
			TextBox1.Text = "";
            TextBox1.KeyDown += TextBox1_KeyUp;
			ComboBox1.DataSource = null;
			mComboboxWidth = ComboBox1.Size.Width;
			mTextMultiline = 0 - (TextBox1.Multiline ? 1 : 0);
		}

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				LoadData();
                e.SuppressKeyPress = true;
            }
        }


		public DataTable dt;
        public void LoadData()
		{
            TextBox1.Text= TextBox1.Text.Replace("\r\n", "");

            string strSQL = string.Empty;
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			dt = new DataTable();
			ComboBox1.SelectedIndex = -1;
			ComboBox1.Text = string.Empty;
			if (Operators.CompareString(mValueMember, mDisplayMember, false) != 0)
			{
				if (mHasBlankValue)
				{
					strSQL = "SELECT '" + mBlankValue + "' AS " + mValueMember + ", ' " + mBlankValue + "' AS " + mDisplayMember + " UNION ";
				}
				strSQL = strSQL + "SELECT DISTINCT " + mValueMember + ", " + mDisplayMember + " ";
			}
			else
			{
				if (mHasBlankValue)
				{
					strSQL = "SELECT '" + mBlankValue + "' AS " + mDisplayMember + " UNION ";
				}
				strSQL = strSQL + "SELECT DISTINCT " + mDisplayMember + " ";
			}
			strSQL = strSQL + "FROM " + mDataTable + " ";
			strSQL = strSQL + "WHERE " + mDisplayMember + " LIKE '%" + TextBox1.Text + "%' ";
			if (Operators.CompareString(mWhereClause, string.Empty, false) != 0)
			{
				strSQL = strSQL + "AND " + mWhereClause + " ";
			}
			strSQL = strSQL + "ORDER BY " + mDisplayMember;
			cmd.CommandText = strSQL;
			cmd.Connection = DB.GetDBConnection();
			adp.SelectCommand = cmd;
			adp.Fill(dt);
		DataTable dt2 = new DataTable();
			dt2 = dt.Clone();

            dt2.Rows.Clear();
			
			int index = 0;
			
			if(dt.Rows.Count==0||index>= dt.Rows.Count)
			{
                ComboBox1.DisplayMember = mDisplayMember;
                ComboBox1.ValueMember = mValueMember;
                ComboBox1.DataSource = dt2;
				return ;
            }

		X: bool IsRight = false;
			for (int i = 0; i < dt.Rows.Count; i++)

            {
              
                DataRow dr = dt.Rows[i];
                if (dr[mDisplayMember].ToString().Trim() == "" && dt.Rows.Count == 1)
                {
                    goto Y;
                }
				if (!IsRight )
                if (dr[mDisplayMember].ToString().Length < index + TextBox1.Text.Trim().Length&&i == dt.Rows.Count-1)
                {
                    goto Y;
                }
                if (dr[mDisplayMember].ToString().Trim().Length < TextBox1.Text.Trim().Length)
				{
					continue;
				}	
			

                if (dr[mDisplayMember].ToString().Length < index + TextBox1.Text.Trim().Length)
				{
					continue;
				}
                string s = dr[mDisplayMember].ToString().Substring(index, TextBox1.Text.Trim().Length);
  
				if (s.ToLower()== TextBox1.Text.Trim().ToLower())
				{
					DataRow row = dt.Rows[i];

                    dt2.ImportRow(row);
					IsRight = true;
                    //dt.Rows[i].Delete();
                    // dt.AcceptChanges();

                }


            }
          if(dt2.Rows.Count ==0) { 
				index++;
				goto X;
			}
		  Y:
			ComboBox1.DisplayMember = mDisplayMember;
			ComboBox1.ValueMember = mValueMember;
			ComboBox1.DataSource = dt2;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			SelectedIndexChangedEventHandler selectedIndexChangedEvent = SelectedIndexChanged;
			if (selectedIndexChangedEvent != null)
			{
				selectedIndexChangedEvent(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			SelectedValueChangedEventHandler selectedValueChangedEvent = SelectedValueChanged;
			if (selectedValueChangedEvent != null)
			{
				selectedValueChangedEvent(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}
	}
}
