using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using CryptoLibrary;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	public class ObjEmail
	{
		public struct objEmailProperty
		{
			public string SMTPServer;

			public string SMTPPort;

			public string SMTPEmailAddress;

			public string SMTPUserID;

			public string SMTPPassword;
		}

		public struct objSendEmail
		{
			public string SendTo;

			public string CC;

			public string Subject;

			public string Message;
		}

		public static objEmailProperty EmailProperty(DataTable dt)
		{
			objEmailProperty udtNew = default(objEmailProperty);
			if (dt.Rows.Count > 0)
			{
				DataRow dtr = dt.Rows[0];
				udtNew.SMTPServer = dtr["SAEMS_SMTPSERVER"].ToString();
				udtNew.SMTPPort = dtr["SAEMS_SMTPPORT"].ToString();
				udtNew.SMTPEmailAddress = dtr["SAEMS_SMTPEMAIL"].ToString();
				udtNew.SMTPUserID = dtr["SAEMS_SMTPID"].ToString();
				udtNew.SMTPPassword = dtr["SAEMS_SMTPPWD"].ToString();
				dtr = null;
			}
			else
			{
				udtNew.SMTPServer = "";
				udtNew.SMTPPort = "";
				udtNew.SMTPEmailAddress = "";
				udtNew.SMTPUserID = "";
				udtNew.SMTPPassword = "";
			}
			return udtNew;
		}

		public static bool SendEmail(objEmailProperty objEmail, string strTO, string strCC, string strTITLE, string strBODY, string strJobNo)
		{
			MailMessage mailMessage = new MailMessage();
			Crypto oCrypto = new Crypto();
			bool SendEmail;
			try
			{
				mailMessage.From = new MailAddress(objEmail.SMTPEmailAddress, "IMS Job Control");
				mailMessage.To.Add(strTO);
				mailMessage.CC.Add(strCC);
				mailMessage.Subject = strTITLE + ": " + strJobNo;
				mailMessage.IsBodyHtml = false;
				mailMessage.Body = strBODY;
				SmtpClient smtpClient = new SmtpClient();
				smtpClient.UseDefaultCredentials = false;
				string strPASWD = oCrypto.DecryptString128Bit(objEmail.SMTPPassword, "");
				smtpClient.Credentials = new NetworkCredential(objEmail.SMTPUserID, strPASWD);
				smtpClient.Port = Convert.ToInt32(objEmail.SMTPPort);
				smtpClient.EnableSsl = true;
				smtpClient.Host = objEmail.SMTPServer;
				smtpClient.Send(mailMessage);
				SendEmail = true;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2);
				Exception ex = ex2;
				MessageBox.Show("Subject: " + strTITLE + "\r\n" + ex.Message.ToString(), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				SendEmail = false;
				ProjectData.ClearProjectError();
			}
			finally
			{
				mailMessage.Dispose();
			}
			return SendEmail;
		}

		public static MailAddressCollection SetAddressCollection(string strAddress)
		{
			MailAddressCollection ToAddress = new MailAddressCollection();
			checked
			{
				if (strAddress.Trim(null).Length != 0)
				{
					char[] sep = new char[1] { ',' };
					Array a = strAddress.Split(sep);
					if (a.Length == 0)
					{
						ToAddress.Add(strAddress);
					}
					else
					{
						int num = a.Length - 1;
						for (int i = 0; i <= num; i++)
						{
							ToAddress.Add(a.GetValue(i).ToString());
						}
					}
				}
				return ToAddress;
			}
		}
	}
}
