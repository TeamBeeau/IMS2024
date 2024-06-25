using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[StandardModule]
	internal sealed class DB
	{
		private static OleDbConnection oleDMS = new OleDbConnection();

		public static OleDbConnection GetDBConnection()
		{
			OleDbConnection GetDBConnection;
			try
			{
				if (oleDMS.State != ConnectionState.Open)
				{
					string s = GetConnectionString();
					oleDMS.ConnectionString = s;
                   

                    oleDMS.Open();
				}
				GetDBConnection = oleDMS;
			}
			catch (OleDbException ex2)
			{
				ProjectData.SetProjectError(ex2);
				OleDbException ex = ex2;
                MessageBox.Show(ex.Message);
    //            switch (ex.ErrorCode)
				//{


				

    ////            case -2147217843:
				////	MessageBox.Show("System failed to login! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				////	break;
				////case -2147467259:
				////	MessageBox.Show("System can not locate database! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				////	break;
				////default:
				////	MessageBox.Show("System message: " + Conversions.ToString(ex.ErrorCode) + "-" + ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				////	break;
				//}
				oleDMS = null;
				Environment.Exit(0);
				GetDBConnection = null;
				ProjectData.ClearProjectError();
			}
			return GetDBConnection;
		}

		public static string GetConnectionString()
		{
			string s = "";
			string GetConnectionString;
			try
			{
				string strProvider = "SQLOLEDB.1";
				string strUserID = PublicVar.gstrUserID;
				string strPassword = PublicVar.gstrPassword;
				string strDBName = PublicVar.gstrDBName;
				string strServerName = PublicVar.gstrServerName;
				s = "Provider=" + strProvider + ";";
				s += "Persist Security Info=False;";
				s = s + "User ID=" + strUserID + ";";
				s = s + "Password=" + strPassword + ";";
				s = s + "Initial Catalog=" + strDBName + ";";
				s = s + "Data Source=" + strServerName;
				GetConnectionString = s;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message + "\r\nDatabase connection info. not properly setup! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GetConnectionString = null;
				ProjectData.ClearProjectError();
			}
			return GetConnectionString;
		}

		public static DataTable GetTable(string strFields, string strTable, string strWhere, string strOrderBy,string DESC="DESC")
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			DataTable GetTable;
			try
			{
				string strSQL = "SELECT ";
				strSQL = strSQL + strFields + " ";
				if (Operators.CompareString(strTable, "", false) != 0)
				{
					strSQL = strSQL + "FROM " + strTable + " ";
				}
				if (Operators.CompareString(strWhere, "", false) != 0)
				{
					strSQL = strSQL + "WHERE " + strWhere + " ";
				}
				if (Operators.CompareString(strOrderBy, "", false) != 0)
				{
					strSQL = strSQL + "ORDER BY " + strOrderBy +" "+ DESC;
				}
				cmd.CommandText = strSQL;
				cmd.Connection = GetDBConnection();
				adp.SelectCommand = cmd;
				adp.Fill(dt);
				GetTable = dt;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message + "\r\nUnable to create table object! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GetTable = null;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GetTable = null;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
				adp = null;
			}
			return GetTable;
		}

		public static object GetColumnValue(string strField, string strTable, string strWhere)
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			object GetColumnValue;
			try
			{
				GetColumnValue = null;
				string strSQL = "SELECT ";
				strSQL = strSQL + strField + " ";
				strSQL = strSQL + "FROM " + strTable + " ";
				if (Operators.CompareString(strWhere, "", false) != 0)
				{
					strSQL = strSQL + "WHERE " + strWhere + " ";
				}
				cmd.CommandText = strSQL;
				cmd.Connection = GetDBConnection();
				adp.SelectCommand = cmd;
				adp.Fill(dt);
				DataTable dataTable = dt;
				if (dataTable.Rows.Count == 0)
				{
					switch (dataTable.Columns[0].DataType.FullName)
					{
					case "System.String":
					case "System.Char":
						GetColumnValue = "";
						break;
					case "System.Int16":
					case "System.Int32":
					case "System.Int64":
					case "System.UInt16":
					case "System.UInt32":
					case "System.UInt64":
						GetColumnValue = 0;
						break;
					case "System.Decimal":
					case "System.Single":
					case "System.Double":
						GetColumnValue = 0;
						break;
					case "System.DateTime":
						GetColumnValue = DateTime.MinValue;
						break;
					case "System.Boolean":
						GetColumnValue = false;
						break;
					}
				}
				else
				{
					switch (dataTable.Columns[0].DataType.FullName)
					{
					case "System.String":
					case "System.Char":
						GetColumnValue = dataTable.Rows[0][0].ToString();
						break;
					case "System.Int16":
					case "System.Int32":
					case "System.Int64":
					case "System.UInt16":
					case "System.UInt32":
					case "System.UInt64":
						GetColumnValue = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataTable.Rows[0][0]));
						break;
					case "System.Decimal":
					case "System.Single":
					case "System.Double":
						GetColumnValue = Convert.ToDouble(RuntimeHelpers.GetObjectValue(dataTable.Rows[0][0]));
						break;
					case "System.DateTime":
						GetColumnValue = ((!dataTable.Rows[0][0].Equals(DBNull.Value)) ? ((object)Convert.ToDateTime(RuntimeHelpers.GetObjectValue(dataTable.Rows[0][0]))) : ((object)DateTime.MinValue));
						break;
					case "System.Boolean":
						GetColumnValue = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataTable.Rows[0][0]));
						break;
					}
				}
				dataTable = null;
				GetColumnValue = GetColumnValue;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message + "\r\nUnable to create table object! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GetColumnValue = null;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				GetColumnValue = null;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
				adp = null;
				dt = null;
			}
			return GetColumnValue;
		}

		public static int CharColumnMaxLength(string strTable, string strField)
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			int CharColumnMaxLength;
			try
			{
				string strSQL = "SELECT ";
				strSQL = strSQL + strField + " ";
				strSQL = strSQL + "FROM " + strTable + " ";
				cmd.CommandText = strSQL;
				cmd.Connection = GetDBConnection();
				adp.SelectCommand = cmd;
				adp.FillSchema(dt, SchemaType.Source);
				CharColumnMaxLength = dt.Columns[strField].MaxLength;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message + "\r\nUnable to create column object! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				CharColumnMaxLength = 0;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				CharColumnMaxLength = 0;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
				adp = null;
				dt = null;
			}
			return CharColumnMaxLength;
		}

		public static bool DBExecute(string strSQL, int intTimeout = 30)
		{
			OleDbCommand cmd = new OleDbCommand();
			bool DBExecute;
			try
			{
				cmd.Connection = GetDBConnection();
				cmd.CommandText = strSQL;
				cmd.CommandTimeout = intTimeout;
				int intAffected = cmd.ExecuteNonQuery();
				DBExecute = true;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				DBExecute = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "IMS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				DBExecute = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
			}
			return DBExecute;
		}

		public static bool RecordExists(string strSQL)
		{
			OleDbCommand cmd = new OleDbCommand();
			bool RecordExists;
			try
			{
				cmd.Connection = GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
				RecordExists = intAffected != 0;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				RecordExists = false;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				RecordExists = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
			}
			return RecordExists;
		}

		public static DataTable ExecProc(string strSQL, int intTimeout = 30)
		{
			OleDbCommand cmd = new OleDbCommand();
			OleDbDataAdapter adp = new OleDbDataAdapter();
			DataTable dt = new DataTable();
			DataTable ExecProc;
			try
			{
				cmd.Connection = GetDBConnection();
				cmd.CommandText = strSQL;
				cmd.CommandTimeout = intTimeout;
				adp.SelectCommand = cmd;
				adp.Fill(dt);
				
                String name=oleDMS.DataSource;
               ExecProc = dt;
			}
			catch (OleDbException ex3)
			{
				ProjectData.SetProjectError(ex3);
				OleDbException ex2 = ex3;
				//MessageBox.Show(Conversions.ToString(ex2.ErrorCode) + "-" + ex2.Message + "\r\nUnable to create table object! Please contact system administrator.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ExecProc = null;
				ProjectData.ClearProjectError();
			}
			catch (Exception ex4)
			{
				ProjectData.SetProjectError(ex4);
				Exception ex = ex4;
				//MessageBox.Show(ex.Message, "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				ExecProc = null;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
				adp = null;
			}
			return ExecProc;
		}
	}
}
