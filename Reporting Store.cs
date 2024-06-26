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

namespace IMS
{
    public partial class Reporting_Store : Form
    {
        public Reporting_Store()
        {
            InitializeComponent();
        }
        private void LoadBlanceTotal()
        {

         
            DataTable dt = DB.ExecProc("SELECT INTRN_ITMCD,INTRN_LOCID,INTRN_BALQT FROM vwItemBalanceByGRLNO ORDER BY INTRN_ITMCD ");
            if (dt.Rows.Count > 0)
            {
                string item;
                double num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0;
                string loc;
                item = dt.Rows[0]["INTRN_ITMCD"].ToString();
                loc = dt.Rows[0]["INTRN_LOCID"].ToString();
                double bal = 0;
                dgvWH1.Columns.Clear();
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

                foreach (DataRow dr in dt.Rows)
                {
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
            }
        }
        private void Reporting_Store_Load(object sender, EventArgs e)
        {
            LoadBlanceTotal();

        }
    }
}
