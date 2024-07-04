using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using CrystalDecisions.CrystalReports.Engine;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using System.Runtime;
using System.Runtime.InteropServices;
using OfficeOpenXml;

namespace IMS
{
    public partial class Reporting_Store : Form
    {

        public Reporting_Store()
        {
            InitializeComponent();
            this.cbITMTY.HasBlankValue = true;
            dtRP = new DataTable();
            DataColumn newCol1 = new DataColumn();
            newCol1.ColumnName = "col1";
            dtRP.Columns.Add(newCol1);

            newCol1 = new DataColumn();
            newCol1.ColumnName = "col2";
            dtRP.Columns.Add(newCol1);

            newCol1 = new DataColumn();
            newCol1.ColumnName = "col3";
            dtRP.Columns.Add(newCol1);

            newCol1 = new DataColumn();
            newCol1.ColumnName = "col4";
            dtRP.Columns.Add(newCol1);

            newCol1 = new DataColumn();
            newCol1.ColumnName = "col5";
            dtRP.Columns.Add(newCol1);

            newCol1 = new DataColumn();
            newCol1.ColumnName = "col6";
            dtRP.Columns.Add(newCol1);

            newCol1 = new DataColumn();
            newCol1.ColumnName = "col7";
            dtRP.Columns.Add(newCol1);

            newCol1 = new DataColumn();
            newCol1.ColumnName = "col8";
            dtRP.Columns.Add(newCol1);

            newCol1 = new DataColumn();
            newCol1.DataType = typeof(double);
            newCol1.ColumnName = "col9";
            dtRP.Columns.Add(newCol1);


        }

        private void CbHCATCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbITMTY.SelectedIndex = -1;
            BindComboBox("ITMCD");
        }
        private void Reporting_Store_Load(object sender, EventArgs e)
        {
            Common.Set_FormLanguage(this);
            // BindComboBox("HITMTY");
            BindComboBox("ITMTY");


            //dgvWH1.Rows[0].Selected = true;

        }
        DataTable dtRP = new System.Data.DataTable();
        private void Header()
        {


            System.Data.DataTable dt2 = DB.ExecProc(strSQL);

            List<string> list = dt2.Rows.OfType<DataRow>().Select(dr => (string)dr["MAITM_ITMCD"]).ToList();

            System.Data.DataTable dt = DB.ExecProc("SELECT INTRN_ITMCD,INTRN_LOCID,INTRN_BALQT FROM vwItemBalanceByGRLNO WHERE INTRN_ITMCD BETWEEN '" + list[0] + "' AND '" + list[list.Count - 1] + "' ORDER BY INTRN_ITMCD ASC");
            if (dt.Rows.Count > 200000)
            {
                MessageBox.Show("Data exceeds display limit!");
                return;
            }
            if (dt.Rows.Count > 0)
            {

                string item;
                double num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0;
                string loc;
                item = dt.Rows[0]["INTRN_ITMCD"].ToString();
                loc = dt.Rows[0]["INTRN_LOCID"].ToString();
                double bal = 0;

                foreach (DataRow dr in dt.Rows)
                {
                    if (list.FindIndex(a => a.Contains(dr["INTRN_ITMCD"].ToString())) == -1)
                        continue;
                    bal = Convert.ToDouble(dr["INTRN_BALQT"]);

                    if (item == dr["INTRN_ITMCD"].ToString())
                    {
                        if (loc == dr["INTRN_LOCID"].ToString())
                        {
                            if (bal > 0)
                            {
                                switch (loc)
                                {
                                    case "RESIN":
                                        num1 += bal;
                                        break;
                                    case "BLENDING":
                                        num2 += bal;
                                        break;
                                    case "WB-WIP":
                                        num3 += bal;
                                        break;
                                    case "SP-WIP":
                                        num4 += bal;
                                        break;
                                    case "FG":
                                        num5 += bal;
                                        break;
                                    case "WH1":
                                        num6 += bal;
                                        break;
                                    case "WH2":
                                        num7 += bal;
                                        break;
                                }
                            }

                        }
                        else
                        {
                            loc = dr["INTRN_LOCID"].ToString();
                            if (bal > 0)
                            {
                                switch (loc)
                                {
                                    case "RESIN":
                                        num1 += bal;
                                        break;
                                    case "BLENDING":
                                        num2 += bal;
                                        break;
                                    case "WB-WIP":
                                        num3 += bal;
                                        break;
                                    case "SP-WIP":
                                        num4 += bal;
                                        break;
                                    case "FG":
                                        num5 += bal;
                                        break;
                                    case "WH1":
                                        num6 += bal;
                                        break;
                                    case "WH2":
                                        num7 += bal;
                                        break;
                                }
                            }
                        }


                    }
                    else
                    {
                        double balanceValue = num1 + num2 + num3 + num4 + num5 + num6 + num7;
                        balanceValue = Math.Round(balanceValue, 2);
                        item = dr["INTRN_ITMCD"].ToString();
                        dtRP.Rows.Add(item, num1, num2, num3, num4, num5, num6, num7, balanceValue);
                        num1 = 0; num2 = 0; num3 = 0; num4 = 0; num5 = 0; num6 = 0; num7 = 0;

                        //if (balanceValue >(double) numMax.Value)
                        //{

                        //    dgvWH1.Rows[dgvWH1.Rows.Count-1].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;

                        //}
                        //else if (balanceValue < (double)numMin.Value)
                        //{
                        //    dgvWH1.Rows[dgvWH1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.PaleVioletRed;                         
                        //}
                        //else 
                        //{
                        //    dgvWH1.Rows[dgvWH1.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;

                        //}

                    };
                }
                if (item == dt.Rows[0]["INTRN_ITMCD"].ToString())
                {
                    double balanceValue = num1 + num2 + num3 + num4 + num5 + num6 + num7;
                    balanceValue = Math.Round(balanceValue, 2);
                    dtRP.Rows.Add(item, num1, num2, num3, num4, num5, num6, num7, balanceValue);
                    num1 = 0; num2 = 0; num3 = 0; num4 = 0; num5 = 0; num6 = 0; num7 = 0;

                }
            }
        }

        string strSQL = "";
        private void button1_Click(object sender, EventArgs e)
        {
            btnSEARCH.Enabled = false;
            btnSEARCH.Text = "SEARCHING..";
            dtRP.Clear();
            strSQL = "EXEC spMAITM '0', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHITMTY.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHCATCD.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHGRPCD.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHBRAND.SelectedValue)) + "', ";

            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMTY.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMTY.SelectedValue)) + "', ";
            strSQL = strSQL + "'', ";
            strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, "'zzzzz'"));

            //         dgvWH1.Rows.Clear();
            if (!workRefresh.IsBusy)
                workRefresh.RunWorkerAsync();
        }

        private void cbHITMTY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHGRPCD.SelectedIndex = -1;
            cbHBRAND.SelectedIndex = -1;
            cbHCATCD.SelectedIndex = -1;
            cbITMTY.SelectedIndex = -1;
            BindComboBox("HGRPCD");
        }

        private void cbHGRPCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHBRAND.SelectedIndex = -1;
            cbHCATCD.SelectedIndex = -1;
            cbITMTY.SelectedIndex = -1;
            BindComboBox("HBRAND");
        }

        private void cbHBRAND_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHCATCD.SelectedIndex = -1;
            cbITMTY.SelectedIndex = -1;
            BindComboBox("HCATCD");
        }
        private void BindComboBox(string strOption)
        {
            string strSQL1 = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
            if (Operators.CompareString(strOption, "HITMTY", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'ITMTY' ORDER BY MACOD_CODID";
                cbHITMTY.ValueMember = "MACOD_CODID";
                cbHITMTY.DisplayMember = "MACOD_CODNM";
                Common.RetriveComboItembySQL(strSQL1, cbHITMTY);
            }
            if (Operators.CompareString(strOption, "HGRPCD", false) == 0)
            {
                strSQL1 += " WHERE MACOD_CTYID = 'GRPCD' ";
                strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHITMTY.SelectedValue), "' ")));
                strSQL1 += "ORDER BY MACOD_CODID";
                cbHGRPCD.ValueMember = "MACOD_CODID";
                cbHGRPCD.DisplayMember = "MACOD_CODNM";
                Common.RetriveComboItembySQL(strSQL1, cbHGRPCD);
            }
            if (Operators.CompareString(strOption, "HBRAND", false) == 0)
            {
                strSQL1 += " WHERE MACOD_CTYID = 'BRAND' ";
                strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHGRPCD.SelectedValue), "' ")));
                strSQL1 += "ORDER BY MACOD_CODID";
                cbHBRAND.ValueMember = "MACOD_CODID";
                cbHBRAND.DisplayMember = "MACOD_CODNM";
                Common.RetriveComboItembySQL(strSQL1, cbHBRAND);
            }
            if (Operators.CompareString(strOption, "HCATCD", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'CATCD' ";
                strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHBRAND.SelectedValue), "' ")));
                strSQL1 += "ORDER BY MACOD_CODID";
                cbHCATCD.ValueMember = "MACOD_CODID";
                cbHCATCD.DisplayMember = "MACOD_CODNM";
                Common.RetriveComboItembySQL(strSQL1, cbHCATCD);
            }
            if (Operators.CompareString(strOption, "ITMCD", false) == 0)
            {
                cbITMTY.DataTable = "MAITM_TBL WITH (NOLOCK) ";
                cbITMTY.WhereClause = "MAITM_ITMTY LIKE '%" + Conversions.ToString(cbHITMTY.SelectedValue) + "%' AND MAITM_CATCD LIKE '%" + Conversions.ToString(cbHCATCD.SelectedValue) + "%' AND MAITM_GRPCD LIKE '%" + Conversions.ToString(cbHGRPCD.SelectedValue) + "' AND MAITM_BRAND LIKE '%" + Conversions.ToString(cbHBRAND.SelectedValue) + "%'";
                cbITMTY.ValueMember = "MAITM_ITMCD";
                cbITMTY.DisplayMember = "MAITM_ITMCD";
                cbITMTY.LoadData();
            }

        }

        private void Reporting_Store_Shown(object sender, EventArgs e)
        {
            Common.Set_FormLanguage(this);
            BindComboBox("HITMTY");
            BindComboBox("ITMTY");
        }

        private void cbITMTY_SelectedIndexChanged(object sender, EventArgs e)
        {
            //BindComboBox("GRPCD");
        }
        private void numMax_ValueChanged(object sender, EventArgs e)
        {
            if (numMax.Value < numMin.Value) numMax.Value = numMin.Value;
        }

        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            if (numMin.Value > numMax.Value) numMin.Value = numMax.Value;

        }

        private void workRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            Header();
        }

        private void workRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvWH1.DataSource = dtRP;
            dgvWH1.Columns[0].HeaderText = "Item Code";
            dgvWH1.Columns[1].HeaderText = "RESIN";
            dgvWH1.Columns[2].HeaderText = "BLENDING";
            dgvWH1.Columns[3].HeaderText = "WB-WIB";
            dgvWH1.Columns[4].HeaderText = "SB-WIP";
            dgvWH1.Columns[5].HeaderText = "FG";
            dgvWH1.Columns[6].HeaderText = "WH1";
            dgvWH1.Columns[7].HeaderText = "WH2";
            dgvWH1.Columns[8].HeaderText = "BALANCE";
            dgvWH1.Columns[0].Width = 150;
            dgvWH1.Columns[8].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
            dgvWH1.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dgvWH1.Columns[1].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dgvWH1.Columns[2].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dgvWH1.Columns[3].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dgvWH1.Columns[4].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dgvWH1.Columns[5].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dgvWH1.Columns[6].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dgvWH1.Columns[7].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dgvWH1.Columns[8].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
            dgvWH1.Columns[8].DefaultCellStyle.Format = "0,##.000";
            dgvWH1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvWH1.Columns[7].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
            dgvWH1.Columns[7].DefaultCellStyle.Format = "0,##.000";
            dgvWH1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvWH1.Columns[6].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
            dgvWH1.Columns[6].DefaultCellStyle.Format = "0,##.000";
            dgvWH1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvWH1.Columns[5].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
            dgvWH1.Columns[5].DefaultCellStyle.Format = "0,##.000";
            dgvWH1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvWH1.Columns[4].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
            dgvWH1.Columns[4].DefaultCellStyle.Format = "0,##.000";
            dgvWH1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvWH1.Columns[3].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
            dgvWH1.Columns[3].DefaultCellStyle.Format = "0,##.000";
            dgvWH1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvWH1.Columns[2].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
            dgvWH1.Columns[2].DefaultCellStyle.Format = "0,##.000";
            dgvWH1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvWH1.Columns[1].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
            dgvWH1.Columns[1].DefaultCellStyle.Format = "0,##.000";
            dgvWH1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvWH1.Sort(dgvWH1.Columns["Col9"], ListSortDirection.Ascending);//NEWDB
            dgvWH1.Refresh();

            foreach (DataGridViewRow dr in dgvWH1.Rows)
            {
                Double balanceValue = Convert.ToDouble(dr.Cells["Col9"].Value);
                if (balanceValue > (double)numMax.Value)
                {

                    dr.DefaultCellStyle.ForeColor = Color.FromArgb(0, 100, 100);//green

                }
                else if (balanceValue < (double)numMin.Value)
                {
                    dr.DefaultCellStyle.ForeColor = Color.FromArgb(165, 42, 42);//red
                    dr.Cells[8].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                    dr.Cells[0].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                    dr.Cells[1].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                    dr.Cells[2].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                    dr.Cells[3].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                    dr.Cells[4].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                    dr.Cells[5].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                    dr.Cells[6].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                    dr.Cells[7].Style.Font = new System.Drawing.Font("Arial", 11, FontStyle.Bold);
                }
                else
                {
                    dr.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);//black
                }

            }
            btnSEARCH.Text = "SEARCH";
            btnSEARCH.Enabled = true;
        }
        
    }
}



   