using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	public class clsUsers
	{
		private PublicEnum.UPD_MODE mMode;

		private string mUSRID;

		private string mUSRNM;

		private string mPASWD;

		private string mCOMMSFG;

		private double mCOMMS;

		private string mAUDIT;

		private string mLGGID;

		private int mSYSUSR;

		private int mSPVFG;

		private DateTime mLUPDT;

		public PublicEnum.UPD_MODE MODE
		{
			get
			{
				return mMode;
			}
			set
			{
				mMode = value;
			}
		}

		public string USRID
		{
			get
			{
				return mUSRID;
			}
			set
			{
				mUSRID = value;
			}
		}

		public string USRNM
		{
			get
			{
				return mUSRNM;
			}
			set
			{
				mUSRNM = value;
			}
		}

		public string PASWD
		{
			get
			{
				return mPASWD;
			}
			set
			{
				mPASWD = value;
			}
		}

		public string COMMSFG
		{
			get
			{
				return mCOMMSFG;
			}
			set
			{
				mCOMMSFG = value;
			}
		}

		public double COMMS
		{
			get
			{
				return mCOMMS;
			}
			set
			{
				mCOMMS = value;
			}
		}

		public string AUDIT
		{
			get
			{
				return mAUDIT;
			}
			set
			{
				mAUDIT = value;
			}
		}

		public string LGGID
		{
			get
			{
				return mLGGID;
			}
			set
			{
				mLGGID = value;
			}
		}

		public int SYSUSR
		{
			get
			{
				return mSYSUSR;
			}
			set
			{
				mSYSUSR = value;
			}
		}

		public int SPVFG
		{
			get
			{
				return mSPVFG;
			}
			set
			{
				mSPVFG = value;
			}
		}

		public DateTime LUPDT
		{
			get
			{
				return mLUPDT;
			}
			set
			{
				mLUPDT = value;
			}
		}

		private void InitProperty()
		{
			mMode = PublicEnum.UPD_MODE.coADD;
			mUSRNM = "";
			mPASWD = "";
			mCOMMSFG = "";
			mCOMMS = 0.0;
			mAUDIT = "";
			mLGGID = "";
			mSYSUSR = 0;
			mSPVFG = 0;
			mLUPDT = Conversions.ToDate("1899/12/31");
		}

		public bool LoadRecord()
		{
			bool LoadRecord = default(bool);
			try
			{
				InitProperty();
				DataTable dt = DB.GetTable("*", "LUSR_TBL", "LUSR_USRID = '" + mUSRID + "'", "");
				if (dt.Rows.Count != 0)
				{
					DataTable dataTable = dt;
					mUSRNM = dataTable.Rows[0]["LUSR_USRNM"].ToString();
					mPASWD = dataTable.Rows[0]["LUSR_PASWD"].ToString();
					mCOMMSFG = dataTable.Rows[0]["LUSR_COMMSFG"].ToString();
					mCOMMS = Conversions.ToDouble(dataTable.Rows[0]["LUSR_COMMS"].ToString());
					mAUDIT = dataTable.Rows[0]["LUSR_AUDIT"].ToString();
					mLGGID = dataTable.Rows[0]["LUSR_LGGID"].ToString();
					mSYSUSR = Conversions.ToInteger(dataTable.Rows[0]["LUSR_SYSUSR"].ToString());
					mSPVFG = Conversions.ToInteger(dataTable.Rows[0]["LUSR_SPVFG"].ToString());
					mLUPDT = Conversions.ToDate(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["LUSR_LUPDT"])), "1899/12/31", RuntimeHelpers.GetObjectValue(dataTable.Rows[0]["LUSR_LUPDT"])));
					dataTable = null;
					LoadRecord = true;
					return LoadRecord;
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message + "\r\nUnable to save company information! Please contact your software vendor.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
				ProjectData.ClearProjectError();
			}
			finally
			{
				DataTable dt = null;
			}
			return LoadRecord;
		}

		public bool SaveRecord()
		{
			OleDbCommand cmd = new OleDbCommand();
			bool SaveRecord;
			try
			{
				DataTable dt = DB.GetTable("*", "LUSR_TBL", "LUSR_USRID = '" + mUSRID + "'", "");
				string strSQL;
				if (dt.Rows.Count == 0)
				{
					strSQL = "INSERT LUSR_TBL(";
					strSQL += "LUSR_USRID, LUSR_USRNM, LUSR_PASWD, ";
					strSQL += "LUSR_COMMSFG, LUSR_COMMS, LUSR_AUDIT, LUSR_LGGID, LUSR_SYSUSR, LUSR_SPVFG, LUSR_LUPDT) ";
					strSQL += "VALUES (";
					strSQL = strSQL + "'" + mUSRID + "','" + mUSRNM + "', '" + mPASWD + "',";
					strSQL = strSQL + "'" + mCOMMSFG + "', " + Conversions.ToString(mCOMMS) + ", '" + mAUDIT + "', '" + mLGGID + "', " + Conversions.ToString(mSYSUSR) + ", " + Conversions.ToString(mSPVFG) + ", '" + mLUPDT.ToString("dd MMM yyyy HH:mm:ss") + "')";
				}
				else
				{
					strSQL = "UPDATE LUSR_TBL SET ";
					strSQL = strSQL + "LUSR_USRID = '" + mUSRID + "', ";
					strSQL = strSQL + "LUSR_USRNM = '" + mUSRNM + "', ";
					strSQL = strSQL + "LUSR_PASWD = '" + mPASWD + "', ";
					strSQL = strSQL + "LUSR_COMMSFG = '" + mCOMMSFG + "', ";
					strSQL = strSQL + "LUSR_COMMS = " + Conversions.ToString(mCOMMS) + ", ";
					strSQL = strSQL + "LUSR_AUDIT = '" + mAUDIT + "', ";
					strSQL = strSQL + "LUSR_LGGID = '" + mLGGID + "', ";
					strSQL = strSQL + "LUSR_SYSUSR = " + Conversions.ToString(mSYSUSR) + ", ";
					strSQL = strSQL + "LUSR_SPVFG = " + Conversions.ToString(mSPVFG) + ", ";
					strSQL = strSQL + "LUSR_LUPDT = '" + mLUPDT.ToString("dd MMM yyyy HH:mm:ss") + "' ";
					strSQL = strSQL + "WHERE LUSR_USRID = '" + mUSRID + "'";
				}
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
				SaveRecord = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message + "\r\nUnable to save company information! Please contact your software vendor.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				SaveRecord = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				DataTable dt = null;
				cmd = null;
			}
			return SaveRecord;
		}

		public bool DeleteRecord()
		{
			OleDbCommand cmd = new OleDbCommand();
			bool DeleteRecord;
			try
			{
				string strSQL = "DELETE LUSR_TBL ";
				strSQL = strSQL + "WHERE LUSR_USRID = '" + mUSRID + "'";
				cmd.Connection = DB.GetDBConnection();
				cmd.CommandText = strSQL;
				int intAffected = cmd.ExecuteNonQuery();
				DeleteRecord = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show(ex.Message + "\r\nUnable to save company information! Please contact your software vendor.", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				DeleteRecord = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				cmd = null;
			}
			return DeleteRecord;
		}

		public bool ValidUSRID()
		{
			PublicEnum.UPD_MODE uPD_MODE = mMode;
			if (uPD_MODE != 0)
			{
				if ((uint)(uPD_MODE - 1) > 1u || RecordExists())
				{
					goto IL_005f;
				}
				MessageBox.Show("Record not exists!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				if (!RecordExists())
				{
					goto IL_005f;
				}
				MessageBox.Show("Record already exists!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			bool ValidUSRID = default(bool);
			return ValidUSRID;
			IL_005f:
			return true;
		}

		public bool ValidPASWD()
		{
			if (Operators.ConditionalCompareObjectNotEqual(mPASWD, DB.GetColumnValue("LUSR_PASWD", "LUSR_TBL", "LUSR_USRID = '" + mUSRID + "'"), false))
			{
				MessageBox.Show("Old password not match!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				bool ValidPASWD = default(bool);
				return ValidPASWD;
			}
			return true;
		}

		public bool RecordExists()
		{
			DataTable dt = DB.GetTable("*", "LUSR_TBL", "UPPER(LUSR_USRID) = '" + mUSRID.ToUpper() + "'", "");
			bool RecordExists = dt.Rows.Count != 0;
			dt = null;
			return RecordExists;
		}

		public bool Login(ref int intRet)
		{
			try
			{
				if (!RecordExists())
				{
					intRet = 1;
					return false;
				}
				string strSQL = "UPPER(LUSR_USRID) = '" + mUSRID.ToUpper() + "' ";
				strSQL = strSQL + "AND LUSR_PASWD = '" + mPASWD + "'";
				DataTable dt = DB.GetTable("*", "LUSR_TBL", strSQL, "");
				if (dt.Rows.Count == 0)
				{
					intRet = 2;
					return false;
				}
				intRet = 0;
				return true;
			}
			finally
			{
				DataTable dt = null;
			}
		}
	}
}
