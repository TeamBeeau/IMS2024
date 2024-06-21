using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[StandardModule]
	internal sealed class Constant
	{
		public const string coSubKey = "Software\\LMS";

		public const string coEncryptionKey = "";

		public const string coRptPath = "\\Reports\\";

		public const string coMediaPath = "\\Media\\";

		public const string coXLPath = "\\XL\\";

		public const string coATTHPath = "\\Attachments\\";

		public const string gstrADMIN = "ADMIN";

		public const string gstrLowDate = "1899/12/31";

		public const string coDMYMask = "99/99/9999";

		public const string coMDYMask = "99/99/9999";

		public const string coYMDMask = "9999/99/99";

		public const string coMYMask = "99/9999";

		public const string coYMMask = "9999/99";

		public const string coEmptyMaskDateDMY = "__/__/____";

		public const string coEmptyMaskDateYMD = "____/__/__";

		public const string coDateFormatDMY = "DMY";

		public const string coDateFormatMDY = "MDY";

		public const string coDateFormatYMD = "YMD";

		public const string coDefaultDateFormat = "DMY";

		public const string coDateFormatDDMMYYYY = "DD/MM/YYYY";

		public const string coDateFormatMMDDYYYY = "MM/DD/YYYY";

		public const string coDateFormatYYYYMMDD = "YYYY/MM/DD";

		public const int coDlgOpen = 0;

		public const int coDlgSaveAs = 1;

		public const int coDlgPrintSetup = 2;

		public const int coSave = 0;

		public const int coCancel = 1;

		public const int coDelete = 2;

		public const int coClose = 3;

		public const int coConfirm = 4;

		public const int coPrint = 5;

		public const int cofraLeft = 60;

		public const int cofraTop = 10;

		public const int cofraHeight = 7770;

		public const int cofraWidth = 9870;

		public const int cofraButtonLeft = 30;

		public const int cofraButtonTop = 7800;

		public const int coBtnPrintLeft = 8790;

		public const int coBtnPrintTop = 6900;

		public const int coToScreen = 0;

		public const int coToPrinter = 1;

		public const string coMITM_COMMON_Y = "YES";

		public const string coMITM_COMMON_N = "NO";

		public const string coMITM_NEW = "NEW";

		public const string coMITM_OLD = "OLD";

		public const string coMITM_PART = "0";

		public const string coMITM_SERVICE = "0";

		public const string coMITM_PACKAGE = "1";

		public const string coCUSTY_CASH = "0";

		public const string coCUSTY_COMP = "1";

		public const string coSUPTY_Normal = "0";

		public const string coSUPTY_Consign = "1";

		public const string coPAYTY_CASH = "1";

		public const string coPAYTY_CHEQ = "2";

		public const string coPAYTY_CARD = "3";

		public const string coCOMBO_RACE = "RACE";

		public const string coCOMBO_SEX = "SEX";

		public const long DISP_CB_NOBLINK = 0L;

		public const long DISP_CB_BLINKALL = 1L;

		public const long DISP_CB_BLINKEACH = 2L;

		public const long DISP_CCS_NUMERIC = 0L;

		public const long DISP_CCS_ALPHA = 1L;

		public const long DISP_CCS_ASCII = 998L;

		public const long DISP_CCS_KANA = 10L;

		public const long DISP_CCS_KANJI = 11L;

		public const long DISP_CS_ASCII = 998L;

		public const long DISP_CS_WINDOWS = 999L;

		public const long DISP_MT_NONE = 0L;

		public const long DISP_MT_UP = 1L;

		public const long DISP_MT_DOWN = 2L;

		public const long DISP_MT_LEFT = 3L;

		public const long DISP_MT_RIGHT = 4L;

		public const long DISP_MT_INIT = 5L;

		public const long DISP_MF_WALK = 0L;

		public const long DISP_MF_PLACE = 1L;

		public const long DISP_DT_NORMAL = 0L;

		public const long DISP_DT_BLINK = 1L;

		public const long DISP_ST_UP = 1L;

		public const long DISP_ST_DOWN = 2L;

		public const long DISP_ST_LEFT = 3L;

		public const long DISP_ST_RIGHT = 4L;

		public const long DISP_SD_OFF = 0L;

		public const long DISP_SD_ON = 1L;

		public const long DISP_SD_BLINK = 2L;

		public const string coMSGBOX_TITLE = "Inovex Business Suites";

		public const string coMSG_ViewOnly = "This document is view only!\r\nOnly Supervisor user or document creator is allowed to amend.";
	}
}
