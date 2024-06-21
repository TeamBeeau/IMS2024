using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using CryptoLibrary;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[StandardModule]
	internal sealed class Common
	{
		public static DateTime gfDateValue(string DateString, string DateFormat)
		{
			checked
			{
				DateTime gfDateValue;
				try
				{
					if ((Operators.CompareString(DateFormat, "DMY", false) != 0) & (Operators.CompareString(DateFormat, "MDY", false) != 0) & (Operators.CompareString(DateFormat, "YMD", false) != 0))
					{
						DateFormat = "DMY";
					}
					int mintDay;
					int mintMonth;
					int mintYear;
					switch (DateFormat)
					{
					case "DMY":
						mintDay = (int)Math.Round(Conversion.Val(Strings.Left(DateString, 2)));
						mintMonth = (int)Math.Round(Conversion.Val(Strings.Mid(DateString, 4, 2)));
						mintYear = (int)Math.Round(Conversion.Val(Strings.Right(DateString, 4)));
						break;
					case "MDY":
						mintMonth = Conversions.ToInteger(Strings.Left(DateString, 2));
						mintDay = Conversions.ToInteger(Strings.Mid(DateString, 4, 2));
						mintYear = Conversions.ToInteger(Strings.Right(DateString, 4));
						break;
					case "YMD":
						mintYear = Conversions.ToInteger(Strings.Left(DateString, 4));
						mintMonth = Conversions.ToInteger(Strings.Mid(DateString, 6, 2));
						mintDay = Conversions.ToInteger(Strings.Right(DateString, 2));
						break;
					default:
						mintYear = 1899;
						mintMonth = 12;
						mintDay = 30;
						break;
					}
					gfDateValue = DateAndTime.DateSerial(mintYear, mintMonth, mintDay);
					gfDateValue = gfDateValue;
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					gfDateValue = DateAndTime.DateSerial(1899, 12, 31);
					gfDateValue = gfDateValue;
					ProjectData.ClearProjectError();
				}
				return gfDateValue;
			}
		}

		public static bool SetCompany()
		{
			if (Operators.CompareString(PublicVar.gstrCompany, "", false) == 0)
			{
				MessageBox.Show("Company master not set!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				bool SetCompany = default(bool);
				return SetCompany;
			}
			return true;
		}

		public static void Disable_All_MenuItem(MDIParent mdiForm)
		{
			foreach (ToolStripMenuItem mnu in mdiForm.MenuStrip.Items)
			{
				mnu.Text = gfConvertLanguage(PublicVar.gstrLanguage, "", mnu.Text);
				if (mnu.HasDropDownItems)
				{
					Disable_MenuItem(mdiForm, mnu);
				}
			}
		}

		private static void Disable_MenuItem(MDIParent mdiForm, ToolStripMenuItem mnu)
		{
			int try0001_dispatch = -1;
			int num = default(int);
			IEnumerator enumerator = default(IEnumerator);
			int num2 = default(int);
			int num3 = default(int);
			ToolStripMenuItem ctl = default(ToolStripMenuItem);
			object obj = default(object);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						enumerator = mnu.DropDownItems.GetEnumerator();
						goto IL_014c;
					case 474:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0023;
							case 3:
								goto IL_0037;
							case 4:
								goto IL_0041;
							case 5:
								goto IL_0061;
							case 6:
								goto IL_0070;
							case 7:
							case 8:
								goto IL_007d;
							case 9:
								goto IL_0108;
							case 10:
								goto IL_0111;
							case 11:
								goto IL_011d;
							case 13:
								goto IL_0129;
							case 14:
								goto IL_0132;
							case 15:
								goto IL_013e;
							case 12:
							case 16:
							case 17:
							case 18:
								goto IL_0149;
							case 19:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 20:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0129:
						ProjectData.ClearProjectError();
						num3 = -3;
						goto IL_0132;
						IL_0132:
						num = 14;
						ctl.Enabled = false;
						goto IL_013e;
						IL_011d:
						ProjectData.ClearProjectError();
						num3 = 0;
						goto IL_0149;
						IL_013e:
						ProjectData.ClearProjectError();
						num3 = 0;
						goto IL_0149;
						IL_014c:
						if (!enumerator.MoveNext())
						{
							break;
						}
						obj = RuntimeHelpers.GetObjectValue(enumerator.Current);
						goto IL_0023;
						IL_0149:
						num = 18;
						goto IL_014c;
						IL_0023:
						num = 2;
						if (obj is ToolStripMenuItem)
						{
							goto IL_0037;
						}
						goto IL_0149;
						IL_0037:
						num = 3;
						ctl = (ToolStripMenuItem)obj;
						goto IL_0041;
						IL_0041:
						num = 4;
						ctl.Text = gfConvertLanguage(PublicVar.gstrLanguage, "", ctl.Text);
						goto IL_0061;
						IL_0061:
						num = 5;
						if (ctl.HasDropDownItems)
						{
							goto IL_0070;
						}
						goto IL_007d;
						IL_0070:
						num = 6;
						Disable_MenuItem(mdiForm, ctl);
						goto IL_007d;
						IL_007d:
						num = 8;
						if (LikeOperator.LikeString(ctl.Name.ToUpper(), "MNU*", CompareMethod.Binary) | (Operators.CompareString(ctl.Name.ToUpper(), "LOGOFF", false) == 0) | (Operators.CompareString(ctl.Name.ToUpper(), "QUIT", false) == 0) | (Operators.CompareString(ctl.Name.ToUpper(), "ABOUT", false) == 0) | (Operators.CompareString(ctl.Name.ToUpper(), "USERMANUAL", false) == 0))
						{
							goto IL_0108;
						}
						goto IL_0129;
						IL_0108:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0111;
						IL_0111:
						num = 10;
						ctl.Enabled = true;
						goto IL_011d;
						end_IL_0001_2:
						break;
					}
					num = 19;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					break;
					end_IL_0001:;
				}
				catch( Exception obj2 )// (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
				{
					if (num3 != 0 && num2 == 0)
					{
						ProjectData.SetProjectError((Exception)obj2);
						try0001_dispatch = 474;
						continue;
					}
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public static void Set_All_MenuItem(MDIParent mdiForm)
		{
			//LGRP_TBL
			string[] aryMenuItem = new string[0];
			string strSQL = "LXCS_GRPCD = LPGP_GRPCD AND LXCS_USRID = '" + gfValidSQLStr(PublicVar.gstrLogonID) + "'";
			DataTable dt = DB.GetTable("LPGP_PRGID", "LXCS_TBL, LPGP_TBL", strSQL, "LPGP_PRGID");
			if (dt.Rows.Count == 0)
			{
				return;
			}
			checked
			{
				int num = dt.Rows.Count - 1;
				int i;
				for (i = 0; i <= num; i++)
				{
					aryMenuItem = (string[])Utils.CopyArray(aryMenuItem, new string[i + 1 + 1]);
					aryMenuItem[i] = dt.Rows[i]["LPGP_PRGID"].ToString().ToUpper();
				}
				i++;
                //aryMenuItem = (string[])Utils.CopyArray(aryMenuItem, new string[i + 1 + 1]);
                //aryMenuItem[i] = "Q0ECPACKING";

                foreach (ToolStripMenuItem mnu in mdiForm.MenuStrip.Items)
				{
					if (mnu.HasDropDownItems)
					{
						Set_MenuItem(mdiForm, mnu, i, aryMenuItem);
					}
				}
			}
        }//QOECQO

        public static void Set_MenuItem(MDIParent mdiForm, ToolStripMenuItem mnu, int i, string[] aryMenuItem)
		{
            if (mnu.Name == "_Q0ECPACKING")
            {
                mnu.Enabled = true; return;
            }
            int try0001_dispatch = -1;
			int num = default(int);
			int intLastItem = default(int);
			int num2 = default(int);
			int num3 = default(int);
			ToolStripMenuItem ctl = default(ToolStripMenuItem);
         
            IEnumerator enumerator = default(IEnumerator);
			object obj = default(object);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						intLastItem = i;
						goto IL_0006;
					case 541:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0006;
							case 3:
								goto IL_0028;
							case 4:
								goto IL_003d;
							case 5:
								goto IL_0048;
							case 6:
								goto IL_0057;
							case 7:
							case 8:
								goto IL_0066;
							case 9:
								goto IL_006b;
							case 12:
								goto IL_0117;
							case 13:
								goto IL_013d;
							case 14:
								goto IL_0146;
							case 15:
								goto IL_0152;
							case 16:
								goto IL_0158;
							case 17:
							case 18:
								goto IL_0162;
							case 10:
							case 11:
							case 19:
								goto IL_016b;
							case 20:
							case 21:
							case 22:
								goto IL_017c;
							case 23:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 24:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_0152:
						num = 15;
						i = intLastItem;
						goto IL_0158;
						IL_0158:
						ProjectData.ClearProjectError();
						num3 = 0;
						goto IL_0162;
						IL_0146:
						num = 14;
						ctl.Enabled = true;
						goto IL_0152;
						IL_0162:
						num = 18;
						i = checked(i + 1);
						goto IL_016b;
						IL_0006:
						num = 2;
						enumerator = mnu.DropDownItems.GetEnumerator();
						goto IL_017f;
						IL_017f:
						if (!enumerator.MoveNext())
						{
							break;
						}
						obj = RuntimeHelpers.GetObjectValue(enumerator.Current);
						goto IL_0028;
						IL_017c:
						num = 22;
						goto IL_017f;
						IL_0028:
						num = 3;
						if (obj is ToolStripMenuItem)
						{
							goto IL_003d;
						}
						goto IL_017c;
						IL_003d:
						num = 4;
						ctl = (ToolStripMenuItem)obj;
						goto IL_0048;
						IL_0048:
						num = 5;
						if (ctl.HasDropDownItems)
						{
							goto IL_0057;
						}
						goto IL_0066;
						IL_0057:
						num = 6;
						Set_MenuItem(mdiForm, ctl, intLastItem, aryMenuItem);
						goto IL_0066;
						IL_0066:
						num = 8;
						i = 0;
						goto IL_006b;
						IL_006b:
						num = 9;
						if (!(LikeOperator.LikeString(ctl.Name.ToUpper(), "MNU*", CompareMethod.Binary) | (Operators.CompareString(ctl.Name.ToUpper(), "CASHMGMT", false) == 0) | (Operators.CompareString(ctl.Name.ToUpper(), "LOGOFF", false) == 0) | (Operators.CompareString(ctl.Name.ToUpper(), "QUIT", false) == 0) | (Operators.CompareString(ctl.Name.ToUpper(), "ABOUT", false) == 0) | (Operators.CompareString(ctl.Name.ToUpper(), "USERMANUAL", false) == 0)))
						{
							goto IL_016b;
						}
						goto IL_017c;
						IL_016b:
						num = 11;
						if (i < intLastItem)
						{
							goto IL_0117;
						}
						goto IL_017c;
						IL_0117:
						num = 12;
						if (Operators.CompareString(ctl.Name.ToUpper(), Strings.Trim(aryMenuItem[i]), false) == 0)
						{
							goto IL_013d;
						}
						goto IL_0162;
						IL_013d:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0146;
						end_IL_0001_2:
						break;
					}
					num = 23;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
					break;
					end_IL_0001:;
				}
				catch ( Exception obj2)
				{
                    if (num3 != 0 && num2 == 0)
                    {
                        ProjectData.SetProjectError((Exception)obj2);
                        try0001_dispatch = 541;
                        continue;
                    }
                  
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
		}

		public static void Set_FormLanguage(Control frm)
		{
			List<Control> allTxt = new List<Control>();
			foreach (Label txt6 in FindControlRecursive(allTxt, frm, typeof(Label)))
			{
				txt6.Text = gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(frm.Tag), txt6.Text);
			}
			allTxt = new List<Control>();
			foreach (CheckBox txt5 in FindControlRecursive(allTxt, frm, typeof(CheckBox)))
			{
				txt5.Text = gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(frm.Tag), txt5.Text);
			}
			allTxt = new List<Control>();
			foreach (Button txt4 in FindControlRecursive(allTxt, frm, typeof(Button)))
			{
				txt4.Text = gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(frm.Tag), txt4.Text);
			}
			allTxt = new List<Control>();
			foreach (GroupBox txt3 in FindControlRecursive(allTxt, frm, typeof(GroupBox)))
			{
				txt3.Text = gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(frm.Tag), txt3.Text);
			}
			allTxt = new List<Control>();
			checked
			{
				foreach (DataGridView txt2 in FindControlRecursive(allTxt, frm, typeof(DataGridView)))
				{
					int num = txt2.Columns.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						txt2.Columns[i].HeaderText = gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(frm.Tag), txt2.Columns[i].HeaderText);
					}
				}
				allTxt = new List<Control>();
				foreach (TabControl txt in FindControlRecursive(allTxt, frm, typeof(TabControl)))
				{
					int num2 = txt.TabCount - 1;
					for (int i = 0; i <= num2; i++)
					{
						txt.TabPages[i].Text = gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(frm.Tag), txt.TabPages[i].Text);
					}
				}
			}
		}

		private static List<Control> FindControlRecursive(List<Control> list, Control parent, Type ctrlType)
		{
			Type ctrllookup = typeof(LookupControl);
			if (parent == null)
			{
				return list;
			}
			if ((object)parent.GetType() == ctrlType)
			{
				list.Add(parent);
			}
			foreach (Control child in parent.Controls)
			{
				if ((object)parent.GetType() != ctrllookup)
				{
					FindControlRecursive(list, child, ctrlType);
				}
			}
			return list;
		}

		public static string gfValidSQLStr(string InputString)
		{
			for (int intPos = Strings.InStr(InputString, "'"); intPos != 0; intPos = Strings.InStr(checked(intPos + 2), InputString, "'"))
			{
				InputString = Strings.Left(InputString, intPos) + Strings.Mid(InputString, intPos);
			}
			return InputString;
		}

		public static string gfValidSQLNum(double Number)
		{
			string gfValidSQLNum = Conversions.ToString(Number);
			int intDecPos = Strings.InStr(gfValidSQLNum, Strings.Format(0, "."));
			if (intDecPos > 0)
			{
				StringType.MidStmtStr(ref gfValidSQLNum, intDecPos, int.MaxValue, ".");
			}
			return gfValidSQLNum;
		}

		public static string gfSQLDate(DateTime DateValue)
		{
			string strDate = Conversions.ToString(Interaction.Choose(DateValue.Month, "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"));
			strDate = ((DateValue.Day >= 10) ? (strDate + " " + Conversions.ToString(DateValue.Day)) : (strDate + "  " + Conversions.ToString(DateValue.Day)));
			return strDate + " " + Conversions.ToString(DateValue.Year) + " " + DateValue.ToString("HH:mm:ss")  ;
		}

		public static double gfGET_BALQT(string strLOCCD, string strITMCD)
		{
			double gfGET_BALQT;
			try
			{
				OleDbCommand cmd = new OleDbCommand
				{
					Connection = DB.GetDBConnection()
				};
				string strSQL = "GET_BALQT";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@RET", OleDbType.Integer).Direction = ParameterDirection.ReturnValue;
				cmd.Parameters.Add("@LOCCD", OleDbType.VarChar).Value = strLOCCD;
				cmd.Parameters.Add("@ITMCD", OleDbType.VarChar).Value = strITMCD;
				cmd.Parameters.Add("@BALQT", OleDbType.Double).Direction = ParameterDirection.Output;
				int iRowsAffected = cmd.ExecuteNonQuery();
				object value = cmd.Parameters["@RET"].Value;
				gfGET_BALQT = ((!Operators.ConditionalCompareObjectEqual(value, 0, false)) ? 0.0 : Conversions.ToDouble(cmd.Parameters["@BALQT"].Value));
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				gfGET_BALQT = 0.0;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				gfGET_BALQT = 0.0;
				ProjectData.ClearProjectError();
			}
			finally
			{
				OleDbCommand cmd = null;
			}
			return gfGET_BALQT;
		}

		public static string gfFormCaption(string strCaption)
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			string gfFormCaption = default(string);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000b;
					case 100:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000b;
							case 3:
								goto IL_001e;
							case 4:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 5:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_000b:
						num = 2;
						gfFormCaption = PublicVar.gstrSystemNm + " -> " + strCaption;
						goto IL_001e;
						IL_001e:
						num = 3;
						gfFormCaption = gfFormCaption + "   [" + PublicVar.gstrLogonID + "]";
						break;
						end_IL_0001_2:
						break;
					}
					ProjectData.ClearProjectError();
					num3 = 0;
					break;
					end_IL_0001:;
				}
				catch (Exception obj2)
				{
                    if (num3 != 0 && num2 == 0)
                    {
                        ProjectData.SetProjectError((Exception)obj2);
                        try0001_dispatch = 100;
                        continue;
                    }
                   
				}
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return gfFormCaption;
		}

		public static string gfClearFormCaption()
		{
			int try0001_dispatch = -1;
			int num3 = default(int);
			int num2 = default(int);
			int num = default(int);
			string gfClearFormCaption = default(string);
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0001_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000b;
					case 89:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = num2 + 1;
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_000b;
							case 3:
								goto IL_0013;
							case 4:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 5:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_000b:
						num = 2;
						gfClearFormCaption = PublicVar.gstrSystemNm;
						goto IL_0013;
						IL_0013:
						num = 3;
						gfClearFormCaption = gfClearFormCaption + "   [" + PublicVar.gstrLogonID + "]";
						break;
						end_IL_0001_2:
						break;
					}
					ProjectData.ClearProjectError();
					num3 = 0;
					break;
					end_IL_0001:;
				}
				catch (Exception obj2)
				{
                    if (num3 != 0 && num2 == 0)
                    {
                        ProjectData.SetProjectError((Exception)obj2);
                        try0001_dispatch = 100;
                        continue;
                    }
                }
				throw ProjectData.CreateProjectError(-2146828237);
				continue;
				end_IL_0001_3:
				break;
			}
			if (num2 != 0)
			{
				ProjectData.ClearProjectError();
			}
			return gfClearFormCaption;
		}

		public static object GetCompanyInfo(string strCOMCD, string strField)
		{
			string strSQL = "COMPANY_REFNO = '" + strCOMCD + "'";
			return RuntimeHelpers.GetObjectValue(DB.GetColumnValue(strField, "COMPANY", strSQL));
		}

		public static bool LoginHistory(string strUSRID, string strSTNID, DateTime dtLOGDT)
		{
			OleDbCommand cmd = new OleDbCommand();
			bool LoginHistory;
			try
			{
				string strSQL = "SELECT * FROM MLOG_HIS ";
				strSQL = strSQL + "WHERE MLOG_USRID = '" + strUSRID + "' ";
				strSQL = strSQL + "AND MLOG_STNID = '" + strSTNID + "' ";
				strSQL = strSQL + "AND MLOG_LOGDT = '" + gfSQLDate(dtLOGDT) + "' ";
				strSQL += "AND MLOG_OUT IS NULL";
				if (!DB.RecordExists(strSQL))
				{
					strSQL = "INSERT MLOG_HIS (";
					strSQL += "MLOG_USRID, MLOG_STNID, MLOG_LOGDT, MLOG_IN, MLOG_OUT) ";
					strSQL = strSQL + "VALUES ('" + strUSRID + "', '" + strSTNID + "', '" + gfSQLDate(dtLOGDT) + "', GETDATE(), NULL)";
					cmd.Connection = DB.GetDBConnection();
					cmd.CommandText = strSQL;
					int intAffected = cmd.ExecuteNonQuery();
				}
				LoginHistory = true;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				LoginHistory = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				LoginHistory = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
			}
			return LoginHistory;
		}

		public static bool LogoutHistory(string strUSRID, string strSTNID)
		{
			OleDbCommand cmd = new OleDbCommand();
			bool LogoutHistory;
			try
			{
				string strSQL = "UPDATE MLOG_HIS ";
				strSQL += "SET MLOG_OUT = GETDATE() ";
				strSQL = strSQL + "WHERE MLOG_USRID = '" + strUSRID + "' ";
				strSQL = strSQL + "AND MLOG_STNID = '" + strSTNID + "' ";
				strSQL += "AND MLOG_OUT IS NULL";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
				LogoutHistory = true;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				LogoutHistory = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				LogoutHistory = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
			}
			return LogoutHistory;
		}

		public static double gfRound(double dblNo, int intDec, bool blnTruncate = false)
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			double gfRound = default(double);
			try
			{
				string strSQL = ((!blnTruncate) ? ("SELECT ROUND(" + Conversions.ToString(dblNo) + "," + Conversions.ToString(intDec) + ",0)") : ("SELECT ROUND(" + Conversions.ToString(dblNo) + "," + Conversions.ToString(intDec) + ",1)"));
				cmd.CommandText = strSQL;
				cmd.Connection = DB.GetDBConnection();
				adp.SelectCommand = cmd;
				adp.Fill(dt);
				if (dt.Rows.Count > 0)
				{
					gfRound = Conversions.ToDouble(dt.Rows[0][0]);
				}
				gfRound = gfRound;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				gfRound = 0.0;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				gfRound = 0.0;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
				adp = null;
			}
			return gfRound;
		}

		public static bool gfAutoNum(string strPRGID, string strDOCID, ref string strNextNo)
		{
			bool gfAutoNum;
			try
			{
				OleDbCommand cmd = new OleDbCommand
				{
					Connection = DB.GetDBConnection()
				};
				string strSQL = "spAutoNum";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@PRGID", OleDbType.VarChar, 10).Value = strPRGID;
				cmd.Parameters.Add("@DOCID", OleDbType.VarChar, 10).Value = strDOCID;
				cmd.Parameters.Add("@NEXTNO", OleDbType.VarChar, 25).Direction = ParameterDirection.Output;
				int iRowsAffected = cmd.ExecuteNonQuery();
				strNextNo = Conversions.ToString(cmd.Parameters["@NEXTNO"].Value);
				gfAutoNum = true;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				gfAutoNum = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				gfAutoNum = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				OleDbCommand cmd = null;
			}
			return gfAutoNum;
		}

		public static void Get_Promo_Price(string strLOCCD, string strITMCD, DateTime dtTRNDT, ref double dblSLPRC, ref double dblDISCRT, ref double dblDISCPR)
		{
			try
			{
				OleDbCommand cmd = new OleDbCommand
				{
					Connection = DB.GetDBConnection()
				};
				string strSQL = "GET_PROMO_PRICE";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@LOCCD", OleDbType.VarChar).Value = strLOCCD;
				cmd.Parameters.Add("@ITMCD", OleDbType.VarChar).Value = strITMCD;
				cmd.Parameters.Add("@TRNDT", OleDbType.Date).Value = dtTRNDT;
				cmd.Parameters.Add("@SLPRC", OleDbType.Double).Direction = ParameterDirection.Output;
				cmd.Parameters.Add("@DISCRT", OleDbType.Double).Direction = ParameterDirection.Output;
				cmd.Parameters.Add("@DISCPR", OleDbType.Double).Direction = ParameterDirection.Output;
				int iRowsAffected = cmd.ExecuteNonQuery();
				dblSLPRC = Conversions.ToDouble(cmd.Parameters["@SLPRC"].Value);
				dblDISCRT = Conversions.ToDouble(cmd.Parameters["@DISCRT"].Value);
				dblDISCPR = Conversions.ToDouble(cmd.Parameters["@DISCPR"].Value);
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				OleDbCommand cmd = null;
			}
		}

		public static void gfControl_KeyDown(object sender, KeyEventArgs e)
		{
			if (Operators.CompareString(Versioned.TypeName(RuntimeHelpers.GetObjectValue(sender)).ToUpper(), "LOOKUP", false) == 0 || (sender is TextBox && Conversions.ToBoolean(Operators.AndObject(NewLateBinding.LateGet(sender, null, "MultiLine", new object[0], null, null, null), Operators.CompareObjectNotEqual(NewLateBinding.LateGet(sender, null, "ScrollBars", new object[0], null, null, null), ScrollBars.None, false)))))
			{
				return;
			}
			switch (e.KeyCode)
			{
			case Keys.Up:
				if (!(sender is ComboBox))
				{
					SendKeys.Send("+{TAB}");
				}
				break;
			case Keys.Down:
				if (!(sender is ComboBox))
				{
					SendKeys.Send("{TAB}");
				}
				break;
			case Keys.Return:
				SendKeys.Send("{TAB}");
				break;
			}
		}

		public static bool VerifySupervisor(string strSUPERID, string strSUPERPWD, [Optional][DefaultParameterValue(0)] ref int intRET)
		{
			Crypto oCrypto = new Crypto();
			string strSQL = "SELECT * FROM LUSR_TBL ";
			strSQL = strSQL + "WHERE LUSR_USRID = '" + strSUPERID + "' ";
			if (!DB.RecordExists(strSQL))
			{
				MessageBox.Show("Invalid Supervisor ID!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				intRET = -1;
			}
			else
			{
				string strPASWD = oCrypto.EncryptString128Bit(strSUPERPWD, "");
				strSQL = strSQL + "AND LUSR_PASWD = '" + strPASWD + "'";
				if (!DB.RecordExists(strSQL))
				{
					MessageBox.Show("Invalid Supervisor Password!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					intRET = -2;
				}
				else
				{
					strSQL = "SELECT * FROM LUSR_TBL ";
					strSQL = strSQL + "WHERE LUSR_USRID = '" + strSUPERID + "' ";
					strSQL += "AND LUSR_SUPER = -1";
					if (DB.RecordExists(strSQL))
					{
						intRET = 0;
						return true;
					}
					MessageBox.Show("Invalid Supervisor ID!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					intRET = -3;
				}
			}
			bool VerifySupervisor = default(bool);
			return VerifySupervisor;
		}

		public static DateTime gfGetServerDateTime()
		{
			DateTime gfGetServerDateTime;
			try
			{
				OleDbCommand cmd = new OleDbCommand
				{
					Connection = DB.GetDBConnection()
				};
				string strSQL = "SELECT GETDATE()";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.Text;
				DateTime dtDateTime = Conversions.ToDate(cmd.ExecuteScalar());
				gfGetServerDateTime = dtDateTime;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				gfGetServerDateTime = DateAndTime.Now;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				gfGetServerDateTime = DateAndTime.Now;
				ProjectData.ClearProjectError();
			}
			finally
			{
				OleDbCommand cmd = null;
			}
			return gfGetServerDateTime;
		}

		public static void LogLERR(string strSPID, string strTEXT, string strUSRID)
		{
			OleDbCommand cmd = new OleDbCommand();
			try
			{
				string strSQL = "INSERT LERR_TBL (";
				strSQL += "LERR_SPID, LERR_TEXT, ";
				strSQL += "LERR_USRID, LERR_LUPDT) ";
				strSQL += "VALUES (";
				strSQL = strSQL + "'" + strSPID + "', '" + strTEXT + "', ";
				strSQL = strSQL + "'" + strUSRID + "', GETDATE())";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
			}
		}

		public static int ReadLookupSetting(string strLKPCD)
		{
			DataSet ds = new DataSet();
			int iRecord = 300;
			int ReadLookupSetting = default(int);
			try
			{
				ds.ReadXml("C:\\Temp\\LookupSetting.xml");
				foreach (DataRow dr in ds.Tables["Lookup"].Rows)
				{
					if (Operators.CompareString(dr["LKPCD"].ToString().ToUpper(), strLKPCD, false) == 0)
					{
						iRecord = Conversions.ToInteger(dr["RECORDS"].ToString());
						break;
					}
				}
				ReadLookupSetting = iRecord;
				return ReadLookupSetting;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message, "ReadItemLookupXMLSetting", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				DataRow dr = null;
				ds = null;
			}
			return ReadLookupSetting;
		}

		public static void WriteLookupSetting(string mLKPCD, int mRecords)
		{
			XmlDocument mXMLDocument = new XmlDocument();
			bool blnFound = false;
			mXMLDocument.Load("C:\\Temp\\LookupSetting.xml");
			XmlNode node = mXMLDocument.DocumentElement;
			try
			{
				foreach (XmlNode node2 in node.ChildNodes)
				{
					if (Operators.CompareString(node2.ChildNodes[0].InnerText, mLKPCD, false) == 0)
					{
						blnFound = true;
						node2.ChildNodes[1].InnerText = mRecords.ToString();
						break;
					}
				}
				if (!blnFound)
				{
					XmlNode newNode = mXMLDocument.CreateNode(XmlNodeType.Element, "Lookup", "");
					XmlNode newLLKP = mXMLDocument.CreateElement("LKPCD");
					newLLKP.InnerText = mLKPCD;
					XmlNode newRecords = mXMLDocument.CreateElement("RECORDS");
					newRecords.InnerText = mRecords.ToString();
					newNode.AppendChild(newLLKP);
					newNode.AppendChild(newRecords);
					mXMLDocument.DocumentElement.AppendChild(newNode);
				}
				mXMLDocument.Save("C:\\Temp\\LookupSetting.xml");
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message, "WriteLookupXMLSetting", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
			}
		}

		public static string GETHDDSerialNo()
		{
			object fso = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Scripting.FileSystemObject"));
			object[] array = new object[1];
			object instance = fso;
			object[] array2 = new object[1];
			object obj = (array2[0] = Application.StartupPath);
			array[0] = NewLateBinding.LateGet(instance, null, "GetDriveName", array2, null, null, null);
			object[] array3 = array;
			bool[] obj2 = new bool[1] { true };
			bool[] array4 = obj2;
			object obj3 = NewLateBinding.LateGet(fso, null, "GetDrive", array, null, null, obj2);
			if (array4[0])
			{
				NewLateBinding.LateSetComplex(instance, null, "GetDriveName", new object[2]
				{
					obj,
					array3[0]
				}, null, null, true, false);
			}
			object Drv = RuntimeHelpers.GetObjectValue(obj3);
			object instance2 = Drv;
			int DriveSerial = ((!Conversions.ToBoolean(NewLateBinding.LateGet(instance2, null, "IsReady", new object[0], null, null, null))) ? (-1) : Conversions.ToInteger(NewLateBinding.LateGet(instance2, null, "SerialNumber", new object[0], null, null, null)));
			instance2 = null;
			return DriveSerial.ToString("X2");
		}

		public static void RetriveComboItembySQL(string strSQL, ComboBox oComboBox)
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			cmd.CommandText = strSQL;
			cmd.Connection = DB.GetDBConnection();
			adp.SelectCommand = cmd;
			adp.Fill(dt);
			oComboBox.DataSource = dt;
			dt = null;
			adp = null;
			cmd = null;
		}

		public static void ClearAllComboItems(ComboBox oComboBox)
		{
			if (oComboBox.DataSource == null)
			{
				oComboBox.Items.Clear();
			}
			else
			{
				oComboBox.DataSource = null;
			}
			if (oComboBox.Items.Count == 0)
			{
				oComboBox.Items.Add("x");
				oComboBox.Items.Clear();
			}
		}

		public static void RemoveAllRPTIMG(string strPRNID)
		{
			OleDbCommand cmd = new OleDbCommand();
			try
			{
				string strSQL = "DELETE RPTIMG_WRK ";
				strSQL = strSQL + "WHERE RPTIMG_PRNID = '" + strPRNID + "'";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int iRowsAffected = cmd.ExecuteNonQuery();
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
			}
		}

		public static void AddRPTIMG(string strPRNID, string strIMGPath)
		{
			MemoryStream mStream = new MemoryStream();
			try
			{
				Image img = Image.FromFile(strIMGPath);
				img.Save(mStream, img.RawFormat);
				byte[] byteData = mStream.ToArray();
				OleDbCommand cmd = new OleDbCommand
				{
					Connection = DB.GetDBConnection()
				};
				string strSQL = "spADDRPTIMG";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@PRNID", OleDbType.VarChar, 30).Value = strPRNID;
				cmd.Parameters.Add("@IMAGE", OleDbType.VarBinary, -1).Value = byteData;
				int iRowsAffected = cmd.ExecuteNonQuery();
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				Image img = null;
				mStream = null;
				OleDbCommand cmd = null;
			}
		}

		public static byte[] ImageToByte2(Image img)
		{
			byte[] byteArray = new byte[0];
			using (MemoryStream stream = new MemoryStream())
			{
				img.Save(stream, ImageFormat.Png);
				stream.Close();
				byteArray = stream.ToArray();
			}
			return byteArray;
		}

		public static string gfNumberFormat(PublicEnum.ControlTypeEnum enumCT, PublicEnum.NumberFormatEnum enumNF)
		{
			string strNumberFormat = string.Empty;
			double dblDecimal = default(double);
			switch (enumNF)
			{
			case PublicEnum.NumberFormatEnum.Quantity:
				dblDecimal = Conversions.ToDouble(DB.GetColumnValue("MACTL_QTYDS", "MACTL_TBL", ""));
				break;
			case PublicEnum.NumberFormatEnum.Price:
				dblDecimal = Conversions.ToDouble(DB.GetColumnValue("MACTL_PRCDS", "MACTL_TBL", ""));
				break;
			case PublicEnum.NumberFormatEnum.Amount:
				dblDecimal = Conversions.ToDouble(DB.GetColumnValue("MACTL_AMTDS", "MACTL_TBL", ""));
				break;
			case PublicEnum.NumberFormatEnum.XRate:
				dblDecimal = Conversions.ToDouble(DB.GetColumnValue("MACTL_XRTDS", "MACTL_TBL", ""));
				break;
			case PublicEnum.NumberFormatEnum.Weight:
				dblDecimal = Conversions.ToDouble(DB.GetColumnValue("MACTL_WGTDS", "MACTL_TBL", ""));
				break;
			}
			switch (enumCT)
			{
			case PublicEnum.ControlTypeEnum.NumControl:
				strNumberFormat = "12." + dblDecimal;
				break;
			case PublicEnum.ControlTypeEnum.DataGridView:
				strNumberFormat = "N" + dblDecimal;
				break;
			}
			return strNumberFormat;
		}

		public static bool gfAllowEdit(string strENTBY)
		{
			if (PublicVar.gintEDTBY == 1)
			{
				return true;
			}
			if (Operators.CompareString(PublicVar.gstrLogonID.ToUpper(), strENTBY.ToUpper(), false) != 0 && !PublicVar.gblnSupervisor)
			{
				return false;
			}
			return true;
		}

		public static string gfConvertLanguage(string strLGGID, string strPRGID, string strORIFLD)
		{
			string strWHERE = "MALGG_LGGID = '" + strLGGID + "' ";
			strWHERE = strWHERE + "AND MALGG_PRGID = '" + strPRGID + "' ";
			strWHERE = strWHERE + "AND MALGG_ORIFLD = '" + gfValidSQLStr(strORIFLD) + "' ";
			string strConverted = Conversions.ToString(DB.GetColumnValue("MALGG_LGGFLD", "MALGG_TBL", strWHERE));
			if (strConverted.Length > 0)
			{
				return strConverted;
			}
			strWHERE = "MALGG_LGGID = '" + strLGGID + "' ";
			strWHERE = strWHERE + "AND MALGG_ORIFLD = '" + gfValidSQLStr(strORIFLD) + "' ";
			strConverted = Conversions.ToString(DB.GetColumnValue("MALGG_LGGFLD", "MALGG_TBL", strWHERE));
			if (strConverted.Length == 0)
			{
				strConverted = strORIFLD;
			}
			return strConverted;
		}

		public static Color gfConvertINT2RGB(string intColour)
		{
			string HexColor = Convert.ToInt32(intColour).ToString("X6");
			string Red = Conversions.ToString(Conversion.Val("&H" + Strings.Mid(HexColor, 5, 2)));
			string Green = Conversions.ToString(Conversion.Val("&H" + Strings.Mid(HexColor, 3, 2)));
			string Blue = Conversions.ToString(Conversion.Val("&H" + Strings.Mid(HexColor, 1, 2)));
			return Color.FromArgb(Conversions.ToInteger(Red), Conversions.ToInteger(Green), Conversions.ToInteger(Blue));
		}

		public static int gfConvertRGB2INT(Color RGBColor)
		{
			string strhex = RGBColor.ToArgb().ToString("X8");
			string strRed = strhex.Substring(6, 2);
			string strGreen = strhex.Substring(4, 2);
			string strBlue = strhex.Substring(2, 2);
			string cstrolorint = strRed + strGreen + strBlue;
			return Convert.ToInt32(cstrolorint, 16);
		}

		public static double gfGetPCPRC(string strSUPID, string strITMCD, DateTime dtEFFDT)
		{
			double gfGetPCPRC = default(double);
			try
			{
				OleDbCommand cmd = new OleDbCommand
				{
					Connection = DB.GetDBConnection()
				};
				string strSQL = "spGET_PCPRC";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@SUPID", OleDbType.VarChar).Value = strSUPID;
				cmd.Parameters.Add("@ITMCD", OleDbType.VarChar).Value = strITMCD;
				cmd.Parameters.Add("@EFFDT", OleDbType.Date).Value = dtEFFDT;
				cmd.Parameters.Add("@PCPRC", OleDbType.Double).Direction = ParameterDirection.Output;
				int iRowsAffected = cmd.ExecuteNonQuery();
				double dblPCPRC = Conversions.ToDouble(cmd.Parameters["@PCPRC"].Value);
				gfGetPCPRC = dblPCPRC;
				return gfGetPCPRC;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				OleDbCommand cmd = null;
			}
			return gfGetPCPRC;
		}

		public static double gfGetSLPRC(string strCUSID, string strITMCD, DateTime dtEFFDT)
		{
			double gfGetSLPRC = default(double);
			try
			{
				OleDbCommand cmd = new OleDbCommand
				{
					Connection = DB.GetDBConnection()
				};
				string strSQL = "spGET_SLPRC";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@CUSID", OleDbType.VarChar).Value = strCUSID;
				cmd.Parameters.Add("@ITMCD", OleDbType.VarChar).Value = strITMCD;
				cmd.Parameters.Add("@EFFDT", OleDbType.Date).Value = dtEFFDT;
				cmd.Parameters.Add("@SLPRC", OleDbType.Double).Direction = ParameterDirection.Output;
				int iRowsAffected = cmd.ExecuteNonQuery();
				double dblPCPRC = Conversions.ToDouble(cmd.Parameters["@SLPRC"].Value);
				gfGetSLPRC = dblPCPRC;
				return gfGetSLPRC;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				OleDbCommand cmd = null;
			}
			return gfGetSLPRC;
		}

		public static double gfGetGRLBAL(string strLOCID, string strGRLNO)
		{
			double gfGetGRLBAL = default(double);
			try
			{
				OleDbCommand cmd = new OleDbCommand
				{
					Connection = DB.GetDBConnection()
				};
				string strSQL = "spGET_GRLBAL";
				cmd.CommandText = strSQL;
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.Add("@LOCID", OleDbType.VarChar).Value = strLOCID;
				cmd.Parameters.Add("@GRLNO", OleDbType.VarChar).Value = strGRLNO;
				cmd.Parameters.Add("@BALQT", OleDbType.Double).Direction = ParameterDirection.Output;
				int iRowsAffected = cmd.ExecuteNonQuery();
				double dblBALQT = Conversions.ToDouble(cmd.Parameters["@BALQT"].Value);
				gfGetGRLBAL = dblBALQT;
				return gfGetGRLBAL;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ProjectData.ClearProjectError();
			}
			finally
			{
				OleDbCommand cmd = null;
			}
			return gfGetGRLBAL;
		}

		public static int GetAccessLevel(string strPRGID)
		{
			string strWhere = "LPRGX_USRID = '" + PublicVar.gstrLogonID + "' AND LPRGX_PRGID = '" + strPRGID + "'";
			if (DB.RecordExists("SELECT * FROM LPRGX_TBL WHERE " + strWhere))
			{
				return Conversions.ToInteger(DB.GetColumnValue("LPRGX_LEVEL", "LPRGX_TBL", strWhere));
			}
			return 3;
		}
	}
}
