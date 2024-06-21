using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[StandardModule]
	public sealed class PublicEnum
	{
		public enum DateFmtEnum
		{
			DMY,
			MDY,
			YMD
		}

		public enum BlankValueEnum
		{
			bvLow,
			bvHigh,
			bvNull
		}

		public enum MsgBoxIconEnum
		{
			coInformation = 64,
			coExclamation = 48,
			coQuestion = 32,
			coCritical = 16
		}

		public enum UPD_MODE
		{
			coADD,
			coEDIT,
			coDEL
		}

		public enum Dest
		{
			Screen,
			Printer
		}

		public struct SYSTEMTIME
		{
			public int wYear;

			public int wMonth;

			public int wDayOfWeek;

			public int wDay;

			public int wHour;

			public int wMinute;

			public int wSecond;

			public int wMilliseconds;
		}

		public enum NumberFormatEnum
		{
			Quantity,
			Price,
			Amount,
			XRate,
			Weight
		}

		public enum ControlTypeEnum
		{
			NumControl,
			DataGridView
		}

		public enum AccessLevel
		{
			AllowRead,
			AllowAdd,
			AllowEdit,
			AllowDelete
		}
	}
}
