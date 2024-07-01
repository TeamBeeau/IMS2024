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
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using IMS.My.Resources;
using Microsoft.VisualBasic.CompilerServices;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace IMS
{
    public partial class Reporting_Store : Form
    {

        public Reporting_Store()
        {
            InitializeComponent();
            this.cbITMTY.HasBlankValue = true;
            DataGridViewColumn newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();
            newCol.Name = "col1";
            newCol.HeaderText = "Item Code";
            newCol.Visible = true;
            newCol.Width = 200;
            dgvWH1.Columns.Add(newCol);
            newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();
            newCol.HeaderText = "RESIN";
            newCol.Name = "col2";
            newCol.Visible = true;
            newCol.Width = 80;
            dgvWH1.Columns.Add(newCol);
            newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();
            newCol.HeaderText = "BLENDING";
            newCol.Visible = true;
            newCol.Width = 80;
            newCol.Name = "col3";
            dgvWH1.Columns.Add(newCol);
            newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();// add a column to the grid
            newCol.HeaderText = "WB-WIB";
            newCol.Visible = true;
            newCol.Name = "col4";
            newCol.Width = 80;
            dgvWH1.Columns.Add(newCol);
            newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();// add a column to the grid
            newCol.HeaderText = "SB-WIP";
            newCol.Visible = true;
            newCol.Width = 80;
            newCol.Name = "col5";
            dgvWH1.Columns.Add(newCol);
            newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();// add a column to the grid
            newCol.HeaderText = "FG";
            newCol.Visible = true;
            newCol.Width = 80;
            newCol.Name = "col6";
            dgvWH1.Columns.Add(newCol);
            newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();// add a column to the grid
            newCol.HeaderText = "WH1";
            newCol.Visible = true;
            newCol.Width = 80;
            newCol.Name = "col7";
            dgvWH1.Columns.Add(newCol);
            newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();// add a column to the grid
            newCol.HeaderText = "WH2";
            newCol.Visible = true;
            newCol.Width = 80;
            newCol.Name = "col8";
            dgvWH1.Columns.Add(newCol);
            newCol = new DataGridViewColumn();
            newCol.CellTemplate = new DataGridViewTextBoxCell();// add a column to the grid
            newCol.HeaderText = "BALANCE";
            newCol.Visible = true;
            newCol.Width = 200;
            newCol.Name = "col9";
            dgvWH1.Columns.Add(newCol);
        }

        private void CbHCATCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbITMTY.SelectedIndex = -1;
            BindComboBox("ITMCD");
        }

        private void LoadBlanceTotal()
        {
          
        }
        private void Reporting_Store_Load(object sender, EventArgs e)
        {
            Common.Set_FormLanguage(this);
           // BindComboBox("HITMTY");
           BindComboBox("ITMTY");
           
         
            //dgvWH1.Rows[0].Selected = true;

        }
        private void Header()
        {
            string strSQL = "EXEC spMAITM '0', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHITMTY.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHCATCD.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHGRPCD.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbHBRAND.SelectedValue)) + "', ";
        
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMTY.SelectedValue)) + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr(Conversions.ToString(cbITMTY.SelectedValue)) + "', ";
            strSQL = strSQL + "'', ";
            strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, "'zzzzz'"));
            dgvWH1.Rows.Clear();
         
   
                
            
            DataTable dt2 = DB.ExecProc(strSQL);
         
            List<string> list = dt2.Rows.OfType<DataRow>().Select(dr => (string)dr["MAITM_ITMCD"]).ToList();
            
            DataTable dt = DB.ExecProc("SELECT INTRN_ITMCD,INTRN_LOCID,INTRN_BALQT FROM vwItemBalanceByGRLNO WHERE INTRN_ITMCD BETWEEN '" + list[0] + "' AND '" + list[list.Count-1] +"' ORDER BY INTRN_ITMCD ASC");
            if (dt.Rows.Count > 80000)
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
                        double sum = num1 + num2 + num3 + num4 + num5 + num6 + num7;
                        item = dr["INTRN_ITMCD"].ToString();
                        dgvWH1.Rows.Add(item, num1, num2, num3, num4, num5, num6, num7, sum);
                        num1 = 0; num2 = 0; num3 = 0; num4 = 0; num5 = 0; num6 = 0; num7 = 0;
                    };
                }
                if (item == dt.Rows[0]["INTRN_ITMCD"].ToString())
                {
                    double sum = num1 + num2 + num3 + num4 + num5 + num6 + num7;
                   
                    dgvWH1.Rows.Add(item, num1, num2, num3, num4, num5, num6, num7, sum);
                    num1 = 0; num2 = 0; num3 = 0; num4 = 0; num5 = 0; num6 = 0; num7 = 0;

                }

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Header();
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
    }
}
   