using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	public class NumControl : TextBox
	{
		private bool m_AllowNegative;

		private bool m_ThousandSeperator;

		private string m_NumberFormat;

		private int mintIntSize;

		private int mintDecSize;

		private double m_Value;

		public double Value
		{
			get
			{
				return m_Value;
			}
			set
			{
				m_Value = value;
				Text = m_Value.ToString();
				FormatNumber();
			}
		}

		public bool DataChanged
		{
			get
			{
				return base.Modified;
			}
			set
			{
				base.Modified = value;
			}
		}

		public bool AllowNegative
		{
			get
			{
				return m_AllowNegative;
			}
			set
			{
				m_AllowNegative = value;
			}
		}

		public bool ThousandSeperator
		{
			get
			{
				return m_ThousandSeperator;
			}
			set
			{
				m_ThousandSeperator = value;
			}
		}

		public string NumberFormat
		{
			get
			{
				return m_NumberFormat;
			}
			set
			{
				m_NumberFormat = value;
				string strNumberFormat = m_NumberFormat;
				if (Operators.CompareString(strNumberFormat, "", false) == 0)
				{
					mintIntSize = 8;
					mintDecSize = 2;
					return;
				}
				checked
				{
					if (strNumberFormat.IndexOf(".") == -1)
					{
						mintIntSize = (int)Math.Round(Math.Abs(Conversion.Val(m_NumberFormat)));
						mintDecSize = 0;
						return;
					}
					string strIntPart = strNumberFormat.Substring(0, strNumberFormat.IndexOf("."));
					string strDecPart = strNumberFormat.Substring(strNumberFormat.IndexOf(".") + 1);
					mintIntSize = Math.Abs(Conversions.ToInteger(strIntPart));
					mintDecSize = Math.Abs(Conversions.ToInteger(strDecPart));
				}
			}
		}

		public NumControl()
		{
			m_NumberFormat = "8.2";
		}

		private void FormatNumber()
		{
			bool blnChanged = base.Modified;
			string strFormat = ((!m_ThousandSeperator) ? "#0" : "#,##0");
			if (mintDecSize > 0)
			{
				strFormat = strFormat + "." + new string('0', mintDecSize);
			}
			Text = Strings.Format(m_Value, strFormat);
			base.Modified = blnChanged;
		}

		private bool ValidDel()
		{
			bool ValidDel = true;
			int intDecPos = Text.IndexOf(".");
			intDecPos = Conversions.ToInteger(Interaction.IIf(intDecPos < 0, 0, intDecPos));
			bool blnDecInText = intDecPos != -1;
			bool blnDecInSelText = SelectedText.IndexOf(".") != -1;
			checked
			{
				if (SelectionLength == 0)
				{
					if (blnDecInText && ((base.SelectionStart == intDecPos) & (Text.Length > mintIntSize + 1)))
					{
						ValidDel = false;
					}
				}
				else if (blnDecInSelText && Text.Length - SelectionLength > mintIntSize)
				{
					ValidDel = false;
				}
				return ValidDel;
			}
		}

		private bool ValidValue(int KeyAscii)
		{
			bool ValidValue = true;
			int intDecPos = Text.IndexOf(".");
			intDecPos = Conversions.ToInteger(Interaction.IIf(intDecPos < 0, 0, intDecPos));
			bool blnDecInText = intDecPos != 0;
			bool blnDecInSelText = SelectedText.IndexOf(".") != -1;
			int intSignPos = Text.IndexOf("-");
			bool blnSignInText = intSignPos == 0;
			bool blnSignInSelText = SelectedText.IndexOf("-") != -1;
			char c = Strings.Chr(KeyAscii);
			checked
			{
				if (c >= '0' && c <= '9')
				{
					if (unchecked(blnSignInText && !blnSignInSelText) & (base.SelectionStart == 0))
					{
						ValidValue = false;
					}
					if (SelectionLength == 0)
					{
						if (blnDecInText)
						{
							if (base.SelectionStart <= intDecPos)
							{
								if (!blnSignInText)
								{
									if (Text.Substring(0, intDecPos).Length >= mintIntSize)
									{
										ValidValue = false;
									}
								}
								else if (Text.Substring(1, intDecPos - 1).Length >= mintIntSize)
								{
									ValidValue = false;
								}
							}
							else if (Text.Substring(intDecPos + 1).Length >= mintDecSize)
							{
								ValidValue = false;
							}
						}
						else if (blnSignInText)
						{
							if (Text.Length - 1 >= mintIntSize)
							{
								ValidValue = false;
							}
						}
						else if (Text.Length >= mintIntSize)
						{
							ValidValue = false;
						}
					}
					else if (blnDecInSelText)
					{
						if (Text.Length - SelectionLength - intSignPos >= mintIntSize)
						{
							ValidValue = false;
						}
					}
					else if (mintIntSize == 0 && (unchecked(!blnDecInText || blnDecInSelText) & (Operators.CompareString(Conversions.ToString(Strings.Chr(KeyAscii)), "0", false) != 0)))
					{
						ValidValue = false;
					}
				}
				else
				{
					switch (c)
					{
					case '-':
						if ((base.SelectionStart != 0) | !m_AllowNegative)
						{
							ValidValue = false;
						}
						else if (blnSignInText)
						{
							ValidValue = false;
						}
						break;
					case '.':
						if (unchecked(blnDecInText && !blnDecInSelText))
						{
							ValidValue = false;
						}
						if (SelectionLength == 0)
						{
							if (Text.Length - base.SelectionStart > mintDecSize)
							{
								ValidValue = false;
							}
						}
						else if (Text.Length - SelectionLength - base.SelectionStart > mintDecSize)
						{
							ValidValue = false;
						}
						break;
					default:
						if (KeyAscii != 8)
						{
							ValidValue = false;
						}
						else if (SelectionLength != 0 && blnDecInSelText && Text.Length - SelectionLength - intSignPos > mintIntSize)
						{
							ValidValue = false;
						}
						break;
					}
				}
				return ValidValue;
			}
		}

		protected override void OnGotFocus(EventArgs e)
		{
			bool blnChanged = base.Modified;
			Text = m_Value.ToString();
			base.Modified = blnChanged;
			SelectAll();
			base.OnGotFocus(e);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Delete && !ValidDel())
			{
				Interaction.Beep();
				e.Handled = true;
			}
			else
			{
				base.OnKeyDown(e);
			}
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
			case '\r':
				e.Handled = true;
				return;
			case '\b':
			{
				int intDecPos = Text.IndexOf(".");
				intDecPos = Conversions.ToInteger(Interaction.IIf(intDecPos < 0, 0, intDecPos));
				if (checked((base.SelectionStart == intDecPos + 1) & (Text.Length > mintIntSize + 1)))
				{
					Interaction.Beep();
					e.Handled = true;
					return;
				}
				break;
			}
			default:
				if (!ValidValue(Strings.Asc(e.KeyChar)))
				{
					Interaction.Beep();
					e.Handled = true;
					return;
				}
				break;
			}
			base.OnKeyPress(e);
		}

		protected override void OnLeave(EventArgs e)
		{
			FormatNumber();
			base.OnLeave(e);
		}

		protected override void OnTextChanged(EventArgs e)
		{
			if ((Operators.CompareString(Text.Trim(), "", false) == 0) | (Operators.CompareString(Text.Trim(), ".", false) == 0) | (Operators.CompareString(Text.Trim(), "-", false) == 0) | (Operators.CompareString(Text.Trim(), "-.", false) == 0))
			{
				m_Value = 0.0;
			}
			else
			{
				m_Value = Conversion.Val(Text);
			}
			base.OnTextChanged(e);
		}
	}
}
