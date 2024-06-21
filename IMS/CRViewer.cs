using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PaperSize = CrystalDecisions.Shared.PaperSize;

namespace IMS
{
	[DesignerGenerated]
	public class CRViewer : Form
	{
		private IContainer components;

		private ReportDocument cryRpt;

		private ReportDocument crySubRpt;

		private string mServerName;

		private string mDatabaseName;

		private string mUserID;

		private string mPassword;

		private string mReportName;

		private string mReportFile;

		private string mCOMPNM;

		private string mCustomPaperSize;

		private string mParams;

		private string mFormulas;

		private bool mShowPrintButton;

		private bool mShowExportButton;

		private bool mShowCopyButton;

		private int mNCopy;

		private PublicEnum.Dest mDest;

		[field: AccessedThroughProperty("CrystalReportViewer1")]
		internal virtual CrystalReportViewer CrystalReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public string ServerName
		{
			set
			{
				mServerName = value;
			}
		}

		public string DatabaseName
		{
			set
			{
				mDatabaseName = value;
			}
		}

		public string UserID
		{
			set
			{
				mUserID = value;
			}
		}

		public string Password
		{
			set
			{
				mPassword = value;
			}
		}

		public string ReportName
		{
			set
			{
				mReportName = value;
			}
		}

		public string ReportFile
		{
			set
			{
				mReportFile = value;
			}
		}

		public string ComputerName
		{
			set
			{
				mCOMPNM = value;
			}
		}

		public string CustomPaperSize
		{
			set
			{
				mCustomPaperSize = value;
			}
		}

		public string Params
		{
			set
			{
				mParams = value;
			}
		}

		public string Formulas
		{
			set
			{
				mFormulas = value;
			}
		}

		public bool ShowPrintButton
		{
			set
			{
				mShowPrintButton = value;
			}
		}

		public bool ShowExportButton
		{
			set
			{
				mShowExportButton = value;
			}
		}

		public bool ShowCopyButton
		{
			set
			{
				mShowCopyButton = value;
			}
		}

		public int NCopy
		{
			set
			{
				mNCopy = value;
			}
		}

		public PublicEnum.Dest Destination
		{
			set
			{
				mDest = value;
			}
		}

		public CRViewer()
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected O, but got Unknown
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			base.FormClosed += CRViewer_FormClosed;
			base.Shown += CRViewer_Shown;
			cryRpt = new ReportDocument();
			crySubRpt = new ReportDocument();
			mServerName = "";
			mDatabaseName = "";
			mUserID = "";
			mPassword = "";
			mShowPrintButton = true;
			mShowExportButton = true;
			mShowCopyButton = true;
			mNCopy = 1;
			InitializeComponent();
		}

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
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			this.CrystalReportViewer1 = new CrystalReportViewer();
			base.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = -1;
			((System.Windows.Forms.UserControl)(object)this.CrystalReportViewer1).BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			((System.Windows.Forms.Control)(object)this.CrystalReportViewer1).Dock = System.Windows.Forms.DockStyle.Fill;
			((System.Windows.Forms.Control)(object)this.CrystalReportViewer1).Location = new System.Drawing.Point(0, 0);
			((System.Windows.Forms.Control)(object)this.CrystalReportViewer1).Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.SelectionFormula = "";
			((System.Windows.Forms.Control)(object)this.CrystalReportViewer1).Size = new System.Drawing.Size(664, 549);
			((System.Windows.Forms.Control)(object)this.CrystalReportViewer1).TabIndex = 0;
			this.CrystalReportViewer1.ViewTimeSelectionFormula = "";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(664, 549);
			base.Controls.Add((System.Windows.Forms.Control)(object)this.CrystalReportViewer1);
			base.Name = "ReportSample";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report Name";
			base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			base.ResumeLayout(false);
		}

		private void CRViewer_FormClosed(object sender, FormClosedEventArgs e)
		{
			crySubRpt.Close();
			((Component)(object)crySubRpt).Dispose();
			cryRpt.Close();
			((Component)(object)cryRpt).Dispose();
			GC.Collect();
		}

		private void CRViewer_Shown(object sender, EventArgs e)
		{
			Text = mReportName;
		}

		public void ViewReport(string strPrinterName = "")
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Expected O, but got Unknown
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected O, but got Unknown
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Expected O, but got Unknown
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Expected O, but got Unknown
			ParameterValues crParameterValues = new ParameterValues();
			ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
			checked
			{
				try
				{
					if (!File.Exists(mReportFile))
					{
						throw new Exception("Report file not exists: \r\n" + mReportFile);
					}
					cryRpt.Load(mReportFile);
					cryRpt.PrintOptions.PrinterName = GetPrinterName(strPrinterName);
					if (Operators.CompareString(mCustomPaperSize, "", false) != 0)
					{
						cryRpt.PrintOptions.PaperSize = (PaperSize)GetCustomPaperSizeID(GetComputerPrinterName(), mCustomPaperSize);
					}
					foreach (IConnectionInfo item in (CollectionBase)(object)cryRpt.DataSourceConnections)
					{
						IConnectionInfo crConnection = item;
						crConnection.SetConnection(mServerName, mDatabaseName, mUserID, mPassword);
					}
					foreach (Table item2 in (SCRCollection)cryRpt.Database.Tables)
					{
						Table crTable = item2;
						crTable.Location = mDatabaseName + ".dbo." + crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1);
					}
					foreach (ReportDocument item3 in (ReadOnlyCollectionBase)(object)cryRpt.Subreports)
					{
						crySubRpt = item3;
						foreach (IConnectionInfo item4 in (CollectionBase)(object)crySubRpt.DataSourceConnections)
						{
							IConnectionInfo crConnection = item4;
							crConnection.SetConnection(mServerName, mDatabaseName, mUserID, mPassword);
						}
						foreach (Table item5 in (SCRCollection)crySubRpt.Database.Tables)
						{
							Table crTable = item5;
							crTable.Location = mDatabaseName + ".dbo." + crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1);
						}
					}
					string[] strParams = mParams.Split(',');
					int num = Information.UBound(strParams);
					for (int i = 0; i <= num; i++)
					{
						string[] strParam = strParams[i].Split('=');
						string strParamName = strParam[0];
						string strParamValue = strParam[1];
						crParameterDiscreteValue.Value = strParamValue;
						crParameterValues = cryRpt.DataDefinition.ParameterFields[strParamName].CurrentValues;
						crParameterValues.Clear();
						crParameterValues.Add((ParameterValue)(object)crParameterDiscreteValue);
						cryRpt.DataDefinition.ParameterFields[strParamName].ApplyCurrentValues(crParameterValues);
					}
					string[] strFormulas = mFormulas.Split(',');
					int num2 = Information.UBound(strFormulas);
					for (int i = 0; i <= num2; i++)
					{
						string[] strFormula = strFormulas[i].Split('=');
						if (Information.UBound(strFormula) > 0)
						{
							string strFormulaName = strFormula[0];
							string strFormulaValue = strFormula[1];
							cryRpt.DataDefinition.FormulaFields[strFormulaName].Text = strFormulaValue;
						}
					}
					if (mDest == PublicEnum.Dest.Screen)
					{
						CrystalReportViewer1.ReportSource = cryRpt;
						CrystalReportViewer1.ShowRefreshButton = false;
						CrystalReportViewer1.ShowPrintButton = mShowPrintButton;
						CrystalReportViewer1.ShowExportButton = mShowExportButton;
						//CrystalReportViewer1.ShowCopyButton = mShowCopyButton;
						Show();
					}
					else
					{
						cryRpt.PrintToPrinter(mNCopy, true, 0, 0);
						Close();
						crySubRpt.Close();
						((Component)(object)crySubRpt).Dispose();
						cryRpt.Close();
						((Component)(object)cryRpt).Dispose();
						GC.Collect();
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, mReportName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
			}
		}

		public void ViewReportbyComputerName()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Expected O, but got Unknown
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Expected O, but got Unknown
			ParameterValues crParameterValues = new ParameterValues();
			ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
			checked
			{
				try
				{
					if (!File.Exists(mReportFile))
					{
						throw new Exception("Report file not exists: \r\n" + mReportFile);
					}
					cryRpt.Load(mReportFile);
					cryRpt.PrintOptions.PrinterName = GetComputerPrinterName();
					if (Operators.CompareString(mCustomPaperSize, "", false) != 0)
					{
						cryRpt.PrintOptions.PaperSize = (PaperSize)GetCustomPaperSizeID(GetComputerPrinterName(), mCustomPaperSize);
					}
					foreach (IConnectionInfo item in (CollectionBase)(object)cryRpt.DataSourceConnections)
					{
						IConnectionInfo crConnection = item;
						crConnection.SetConnection(mServerName, mDatabaseName, mUserID, mPassword);
					}
					foreach (Table item2 in (SCRCollection)cryRpt.Database.Tables)
					{
						Table crTable = item2;
						crTable.Location = mDatabaseName + ".dbo." + crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1);
					}
					foreach (ReportDocument item3 in (ReadOnlyCollectionBase)(object)cryRpt.Subreports)
					{
						crySubRpt = item3;
						foreach (IConnectionInfo item4 in (CollectionBase)(object)crySubRpt.DataSourceConnections)
						{
							IConnectionInfo crConnection = item4;
							crConnection.SetConnection(mServerName, mDatabaseName, mUserID, mPassword);
						}
						foreach (Table item5 in (SCRCollection)crySubRpt.Database.Tables)
						{
							Table crTable = item5;
							crTable.Location = mDatabaseName + ".dbo." + crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1);
						}
					}
					string[] strParams = mParams.Split(',');
					int num = Information.UBound(strParams);
					for (int i = 0; i <= num; i++)
					{
						string[] strParam = strParams[i].Split('=');
						string strParamName = strParam[0];
						string strParamValue = strParam[1];
						crParameterDiscreteValue.Value = strParamValue;
						crParameterValues = cryRpt.DataDefinition.ParameterFields[strParamName].CurrentValues;
						crParameterValues.Clear();
						crParameterValues.Add((ParameterValue)(object)crParameterDiscreteValue);
						cryRpt.DataDefinition.ParameterFields[strParamName].ApplyCurrentValues(crParameterValues);
					}
					string[] strFormulas = mFormulas.Split(',');
					int num2 = Information.UBound(strFormulas);
					for (int i = 0; i <= num2; i++)
					{
						string[] strFormula = strFormulas[i].Split('=');
						if (Information.UBound(strFormula) > 0)
						{
							string strFormulaName = strFormula[0];
							string strFormulaValue = strFormula[1];
							cryRpt.DataDefinition.FormulaFields[strFormulaName].Text = strFormulaValue;
						}
					}
					if (mDest == PublicEnum.Dest.Screen)
					{
						CrystalReportViewer1.ReportSource = cryRpt;
						CrystalReportViewer1.ShowRefreshButton = false;
						CrystalReportViewer1.ShowPrintButton = mShowPrintButton;
						CrystalReportViewer1.ShowExportButton = mShowExportButton;
						//CrystalReportViewer1.ShowCopyButton = mShowCopyButton;
						Show();
					}
					else
					{
						cryRpt.PrintToPrinter(mNCopy, true, 0, 0);
						Close();
						crySubRpt.Close();
						((Component)(object)crySubRpt).Dispose();
						cryRpt.Close();
						((Component)(object)cryRpt).Dispose();
						GC.Collect();
					}
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message, mReportName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
					ProjectData.ClearProjectError();
				}
			}
		}

		private int GetCustomPaperSizeID(string strPrinterName, string strCustomPaperSize)
		{
			PrintDocument printDoc = new PrintDocument();
			printDoc.PrinterSettings.PrinterName = strPrinterName;
			checked
			{
				int num = printDoc.PrinterSettings.PaperSizes.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(printDoc.PrinterSettings.PaperSizes[i].PaperName, strCustomPaperSize, false) == 0)
					{
						return Conversions.ToInteger(printDoc.PrinterSettings.PaperSizes[i].GetType().GetField("kind", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(printDoc.PrinterSettings.PaperSizes[i]));
					}
				}
				return 0;
			}
		}

		private string GetPrinterName(string strPRTNM)
		{
			PrinterSettings def = new PrinterSettings();
			foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
			{
				string prnt = Conversions.ToString(installedPrinter);
				if (Operators.CompareString(prnt, strPRTNM, false) == 0)
				{
					return prnt;
				}
			}
			return def.PrinterName;
		}

		private string GetComputerPrinterName()
		{
			PrinterSettings def = new PrinterSettings();
			string strPRTNM = Conversions.ToString(DB.GetColumnValue("SAPCPRT_PRTNM", "SAPCPRT_TBL", "SAPCPRT_COMPNM = '" + mCOMPNM + "'"));
			foreach (object installedPrinter in PrinterSettings.InstalledPrinters)
			{
				string prnt = Conversions.ToString(installedPrinter);
				if (Operators.CompareString(prnt, strPRTNM, false) == 0)
				{
					return prnt;
				}
			}
			return def.PrinterName;
		}
	}
}
