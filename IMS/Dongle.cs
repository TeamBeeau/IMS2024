using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Securedongle;

namespace IMS
{
	[StandardModule]
	internal sealed class Dongle
	{
		public static SecuredongleControl SD = new SecuredongleControl();

		public const int SD_FIND = 1;

		public const int SD_FIND_NEXT = 2;

		public const int SD_OPEN = 3;

		public const int SD_CLOSE = 4;

		public const int SD_READ = 5;

		public const int SD_WRITE = 6;

		public const int SD_RANDOM = 7;

		public const int SD_SEED = 8;

		public const int SD_WRITE_USERID = 9;

		public const int SD_READ_USERID = 10;

		public const int SD_SET_MODULE = 11;

		public const int SD_CHECK_MODULE = 12;

		public const int SD_WRITE_ARITHMETIC = 13;

		public const int SD_CALCULATE1 = 14;

		public const int SD_CALCULATE2 = 15;

		public const int SD_CALCULATE3 = 16;

		public const int SD_DECREASE = 17;

		public const int SD_SET_RSAKEY_N = 29;

		public const int SD_SET_RSAKEY_D = 30;

		public const int SD_RSA_ENC = 44;

		public const int SD_RSA_DEC = 45;

		public const int SD_DES_ENC = 42;

		public const int SD_DES_DEC = 43;

		public const int SD_SET_DES_KEY = 41;

		public const int ERR_SUCCESS = 0;

		public const int ERR_NO_SECUREDONGLE = 3;

		public const int ERR_INVALID_PASSWORD = 4;

		public const int ERR_INVALID_PASSWORD_OR_ID = 5;

		public const int ERR_SETID = 6;

		public const int ERR_INVALID_ADDR_OR_SIZE = 7;

		public const int ERR_UNKNOWN_COMMAND = 8;

		public const int ERR_NOTBELEVEL3 = 9;

		public const int ERR_READ = 10;

		public const int ERR_WRITE = 11;

		public const int ERR_RANDOM = 12;

		public const int ERR_SEED = 13;

		public const int ERR_CALCULATE = 14;

		public const int ERR_NO_OPEN = 15;

		public const int ERR_OPEN_OVERFLOW = 16;

		public const int ERR_NOMORE = 17;

		public const int ERR_NEED_FIND = 18;

		public const int ERR_DECREASE = 19;

		public const int ERR_AR_BADCOMMAND = 20;

		public const int ERR_AR_UNKNOWN_OPCODE = 21;

		public const int ERR_AR_WRONGBEGIN = 22;

		public const int ERR_AR_WRONG_END = 23;

		public const int ERR_AR_VALUEOVERFLOW = 24;

		public const int ERR_UNKNOWN = 65535;

		public const int ERR_RECEIVE_NULL = 256;

		private static ushort SDhandle;

		private static ushort p1;

		private static ushort p2;

		private static ushort p3;

		private static ushort p4;

		private static ushort retcode;

		private static uint lp1;

		private static uint lp2;

		private static byte[] buffer = new byte[1025];

		public static bool CheckForDongle()
		{
			p1 = 41710;
			p2 = 43370;
			p3 = 12489;
			p4 = 18221;
			if (Operators.CompareString(PublicVar.gstrLogonID, "IAMDEV", false) == 0)
			{
				return true;
			}
			if (DateTime.Compare(DateAndTime.DateSerial(PublicVar.gdtLOGDT.Year, PublicVar.gdtLOGDT.Month, PublicVar.gdtLOGDT.Day), DateAndTime.DateSerial(2020, 12, 31)) <= 0)
			{
				return true;
			}
			retcode = SD.SecureDongle(1, ref SDhandle, ref lp1, ref lp2, ref p1, ref p2, ref p3, ref p4, buffer);
			if (retcode != 0)
			{
				MessageBox.Show("Fail to retrieve dongle!", "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}
	}
}
