using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using CryptoLibrary;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Spire.Barcode;

namespace IMS
{
    [StandardModule]
	internal sealed class MainM
	{
		private const string coDateFormatDMY = "DMY";

		private const string coDateFormatMDY = "MDY";

		private const string coDateFormatYMD = "YMD";

		public static void Main()
		{
			Crypto oCrypto = new Crypto();
			string constDBSetting = Application.StartupPath + "\\dbsetting.xml";
			XmlReader document = new XmlTextReader(constDBSetting);
			BarcodeSettings.ApplyKey("GUP2L-0ZYHD-TXUZB-76QWA-24C13");
			PublicVar.gstrCompanyCode = "INVX";
			while (document.Read())
			{
				object type = document.NodeType;
				if (Operators.ConditionalCompareObjectEqual(type, XmlNodeType.Element, false))
				{
					if (Operators.CompareString(document.Name, "ServerName", false) == 0)
					{
						PublicVar.gstrServerName = document.ReadInnerXml().ToString();
					}
					if (Operators.CompareString(document.Name, "DatabaseName", false) == 0)
					{
						PublicVar.gstrDBName = document.ReadInnerXml().ToString();
					}
					if (Operators.CompareString(document.Name, "UserID", false) == 0)
					{
						PublicVar.gstrUserID = document.ReadInnerXml().ToString();
					}
					if (Operators.CompareString(document.Name, "Password", false) == 0)
					{
						PublicVar.gstrPassword = oCrypto.DecryptString128Bit(document.ReadInnerXml().ToString(), "");
					}
				}
			}
			PublicVar.gstrRptPath = Application.StartupPath + "\\Reports\\";
			PublicVar.gstrMediaPath = Application.StartupPath + "\\Media\\";
			if (!MyProject.Computer.FileSystem.DirectoryExists(PublicVar.gstrMediaPath))
			{
				MyProject.Computer.FileSystem.CreateDirectory(PublicVar.gstrMediaPath);
			}
			PublicVar.gstrXLPath = Application.StartupPath + "\\XL\\";
			if (!MyProject.Computer.FileSystem.DirectoryExists(PublicVar.gstrXLPath))
			{
				MyProject.Computer.FileSystem.CreateDirectory(PublicVar.gstrXLPath);
			}
			PublicVar.gstrATTHPath = Application.StartupPath + "\\Attachments\\";
			if (!MyProject.Computer.FileSystem.DirectoryExists(PublicVar.gstrATTHPath))
			{
				MyProject.Computer.FileSystem.CreateDirectory(PublicVar.gstrATTHPath);
			}
			if (!MyProject.Computer.FileSystem.DirectoryExists("C:\\Temp"))
			{
				MyProject.Computer.FileSystem.CreateDirectory("C:\\Temp");
			}
			if (!MyProject.Computer.FileSystem.FileExists("C:\\Temp\\LookupSetting.xml"))
			{
				MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\\LookupSetting.xml", "C:\\Temp\\LookupSetting.xml", true);
			}
			else if (DateAndTime.DateDiff(DateInterval.Second, GetFileTimeStamp("C:\\Temp\\LookupSetting.xml"), GetFileTimeStamp(Application.StartupPath + "\\LookupSetting.xml")) > 0)
			{
				MyProject.Computer.FileSystem.CopyFile(Application.StartupPath + "\\LookupSetting.xml", "C:\\Temp\\LookupSetting.xml", true);
			}
			PublicVar.gblnToUpperCase = true;
			PublicVar.gstrSTNID = Environment.MachineName.ToString();
			PublicVar.gstrCompany = Conversions.ToString(DB.GetColumnValue("LMSYS_COMNM", "LMSYS_TBL", ""));
			PublicVar.gstrSystemNm = Application.ProductName;
			PublicVar.gintCYEAR = Conversions.ToInteger(DB.GetColumnValue("MACTL_CYEAR", "MACTL_TBL", ""));
			PublicVar.gintCMTH = Conversions.ToInteger(DB.GetColumnValue("MACTL_CMTH", "MACTL_TBL", ""));
			PublicVar.gstrDTFMT = Conversions.ToString(DB.GetColumnValue("MACTL_DTFMT", "MACTL_TBL", ""));
			PublicVar.gintAMTDS = Conversions.ToString(DB.GetColumnValue("MACTL_AMTDS", "MACTL_TBL", ""));
			PublicVar.gstrAmtFmt = "8." + PublicVar.gintAMTDS.ToString();
			PublicVar.gintQTYDS = Conversions.ToString(DB.GetColumnValue("MACTL_QTYDS", "MACTL_TBL", ""));
			PublicVar.gstrQtyFmt = "8." + PublicVar.gintQTYDS.ToString();
			PublicVar.gintPRCDS = Conversions.ToString(DB.GetColumnValue("MACTL_PRCDS", "MACTL_TBL", ""));
			PublicVar.gstrPrcFmt = "8." + PublicVar.gintPRCDS.ToString();
			PublicVar.gintXRTDS = Conversions.ToString(DB.GetColumnValue("MACTL_XRTDS", "MACTL_TBL", ""));
			PublicVar.gstrXrtFmt = "8." + PublicVar.gintXRTDS.ToString();
			PublicVar.gintWGTDS = Conversions.ToString(DB.GetColumnValue("MACTL_WGTDS", "MACTL_TBL", ""));
			PublicVar.gstrWgtFmt = "8." + PublicVar.gintWGTDS.ToString();
			switch (PublicVar.gstrDTFMT)
			{
			case "DMY":
				PublicVar.gstrDateFormat = "DD/MM/YYYY";
				PublicVar.gintRptDateFmt = 1;
				PublicVar.gintCtlDateFmt = PublicEnum.DateFmtEnum.DMY;
				break;
			case "MDY":
				PublicVar.gstrDateFormat = "MM/DD/YYYY";
				PublicVar.gintRptDateFmt = 2;
				PublicVar.gintCtlDateFmt = PublicEnum.DateFmtEnum.MDY;
				break;
			case "YMD":
				PublicVar.gstrDateFormat = "YYYY/MM/DD";
				PublicVar.gintRptDateFmt = 0;
				PublicVar.gintCtlDateFmt = PublicEnum.DateFmtEnum.YMD;
				break;
			}
			DataTable dt = DB.ExecProc("SELECT GETDATE()");
			PublicVar.gdtLOGDT = Conversions.ToDate(dt.Rows[0][0]);
			MyProject.Forms.MDIParent.Text = PublicVar.gstrSystemNm;
			PublicVar.frmLogin = new Login();
			PublicVar.frmLogin.ShowDialog(MyProject.Forms.MDIParent);
		}

		private static DateTime GetFileTimeStamp(string strFileNm)
		{
			return File.GetLastWriteTime(strFileNm);
		}
	}
}
