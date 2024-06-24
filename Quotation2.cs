using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;
namespace IMS
{
    public partial class Quotation2 : Form
    {
   

        public Quotation2()
        {
            InitializeComponent();
            G.quotation2 = this;
        }
        private void BindComboBox(string strOption)
        {
            string strSQL1 = "SELECT '' AS MACOD_CODID, '' AS MACOD_CODNM UNION SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
            if (Operators.CompareString(strOption, "HITMTY", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'ITMTY' ORDER BY MACOD_CODID";
               // cbHITMTY.ValueMember = "MACOD_CODID";
              //  cbHITMTY.DisplayMember = "MACOD_CODNM";
              //  Common.RetriveComboItembySQL(strSQL1, cbHITMTY);
            }
            if (Operators.CompareString(strOption, "HGRPCD", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'GRPCD' ";
                strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", "1"), "' ")));
                strSQL1 += "ORDER BY MACOD_CODID";
                cbHGRPCD.ValueMember = "MACOD_CODID";
                cbHGRPCD.DisplayMember = "MACOD_CODNM";
                Common.RetriveComboItembySQL(strSQL1, cbHGRPCD);
                cbHGRPCD.SelectedIndex = -1;
            }
            if (Operators.CompareString(strOption, "HBRAND", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'BRAND' ";
                strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHGRPCD.SelectedValue), "' ")));
                strSQL1 += "ORDER BY MACOD_CODID";
                cbHBRAND.ValueMember = "MACOD_CODID";
                cbHBRAND.DisplayMember = "MACOD_CODNM";
               Common.RetriveComboItembySQL(strSQL1, cbHBRAND);
            }
            if (Operators.CompareString(strOption, "HCATCD", false) == 0)
            {
                strSQL1 += "WHERE MACOD_CTYID = 'CATCD' ";
              //  strSQL1 = Conversions.ToString(Operators.ConcatenateObject(strSQL1, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbHBRAND.SelectedValue), "' ")));
                strSQL1 += "ORDER BY MACOD_CODID";
               // cbHCATCD.ValueMember = "MACOD_CODID";
               // cbHCATCD.DisplayMember = "MACOD_CODNM";
              //  Common.RetriveComboItembySQL(strSQL1, cbHCATCD);
            }
            string strSQL2 = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) ";
            if (Operators.CompareString(strOption, "ITMTY", false) == 0)
            {
                strSQL2 += "WHERE MACOD_CTYID = 'ITMTY' ORDER BY MACOD_CODID";
               // cbITMTY.ValueMember = "MACOD_CODID";
               // cbITMTY.DisplayMember = "MACOD_CODNM";
               // Common.RetriveComboItembySQL(strSQL2, cbITMTY);
            }
            if (Operators.CompareString(strOption, "GRPCD", false) == 0)
            {
                strSQL2 += "WHERE MACOD_CTYID = 'GRPCD' ";
               // strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbITMTY.SelectedValue), "' ")));
                strSQL2 += "ORDER BY MACOD_CODID";
              //  cbGRPCD.ValueMember = "MACOD_CODID";
              //  cbGRPCD.DisplayMember = "MACOD_CODNM";
               // Common.RetriveComboItembySQL(strSQL2, cbGRPCD);
            }
            if (Operators.CompareString(strOption, "BRAND", false) == 0)
            {
                strSQL2 += "WHERE MACOD_CTYID = 'BRAND' ";
              //  strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbGRPCD.SelectedValue), "' ")));
                strSQL2 += "ORDER BY MACOD_CODID";
               // cbBRAND.ValueMember = "MACOD_CODID";
              //  cbBRAND.DisplayMember = "MACOD_CODNM";
               // Common.RetriveComboItembySQL(strSQL2, cbBRAND);
            }
            if (Operators.CompareString(strOption, "CATCD", false) == 0)
            {
                strSQL2 += "WHERE MACOD_CTYID = 'CATCD' ";
               // strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbBRAND.SelectedValue), "' ")));
                strSQL2 += "ORDER BY MACOD_CODID";
               // cbCATCD.ValueMember = "MACOD_CODID";
               // cbCATCD.DisplayMember = "MACOD_CODNM";
               // Common.RetriveComboItembySQL(strSQL2, cbCATCD);
            }
            if (Operators.CompareString(strOption, "SUBCATCD", false) == 0)
            {
                strSQL2 += "WHERE MACOD_CTYID = 'SUBCATCD' ";
               // strSQL2 = Conversions.ToString(Operators.ConcatenateObject(strSQL2, Operators.ConcatenateObject(Operators.ConcatenateObject("AND MACOD_CFLD1 = '", cbCATCD.SelectedValue), "' ")));
                strSQL2 += "ORDER BY MACOD_CODID";
               // cbSUBCATCD.ValueMember = "MACOD_CODID";
              //  cbSUBCATCD.DisplayMember = "MACOD_CODNM";
                //Common.RetriveComboItembySQL(strSQL2, cbSUBCATCD);
            }
           // BindLabel();
        }
        public void LoaddtColor()
        {
            G.dtColor = new DataTable();
            string strSQL2 = "MAITM_GRPCD, MAITM_BRAND,MAITM_CATCD ";
            string sWhere = "MAITM_ITMTY ='1'";
            if (cbHGRPCD.SelectedValue!=null&&cbHGRPCD.SelectedValue.ToString().Trim()!="")
            {
                sWhere += " AND MAITM_GRPCD='"+ Common.gfValidSQLStr(Conversions.ToString(cbHGRPCD.SelectedValue)) + "'";
            }    
            else
            {
                cbHBRAND.SelectedIndex = -1;
            }
            if (cbHBRAND.SelectedValue != null)
             if ( cbHBRAND.SelectedValue.ToString().Trim() != "")
            {
                sWhere += " AND MAITM_BRAND='" + Common.gfValidSQLStr(Conversions.ToString(cbHBRAND.SelectedValue)) + "'";
                
            }    
            G.dtColor = DB.GetTable(strSQL2, "MAITM_TBL", sWhere, "MAITM_GRPCD");//+ Conversions.ToString(cbHCUSID.SelectedValue) + \"'
            if (G.dtColor == null) return;
            List<String> listSameName = new List<string>();

            for (int i = G.dtColor.Rows.Count - 1; i > -1; i--)
            {
                DataRow row = G.dtColor.Rows[i];
                if (row["MAITM_CATCD"] == null)
                {
                    G.dtColor.Rows.RemoveAt(i);
                }
            }
            for (int i = 0; i < G.dtColor.Rows.Count; i++)
            {
                DataRow row = G.dtColor.Rows[i];
                if (row["MAITM_CATCD"] == null) continue;
                String value = row["MAITM_CATCD"].ToString().Trim();
                if (value.Trim() != "")
                {

                    if (listSameName.Count > 0)
                    {
                        if (listSameName.FindIndex(a => a == value) != -1)
                        {
                            G.dtColor.Rows.RemoveAt(i);
                            i -= 1;

                        }
                        else
                            listSameName.Add(value);
                    }
                    else
                    {
                        listSameName.Add(value);
                    }
                    //row.re
                }
                else
                {
                    G.dtColor.Rows.RemoveAt(i);
                    i -= 1;

                }


            }
            DataColumn cols = new DataColumn();
            cols = new DataColumn();
            cols.DefaultValue = "0";

            cols.ColumnName = "VariableCost";
            cols.DataType = typeof(decimal);
            G.dtColor.Columns.AddRange(new DataColumn[] { cols });


            cols = new DataColumn();
            cols.DefaultValue = "0";
            cols.DataType = typeof(decimal);
            cols.ColumnName = "FixedCost";
            G.dtColor.Columns.AddRange(new DataColumn[] { cols });
            cols = new DataColumn();
            cols.DefaultValue = "0";
            cols.DataType = typeof(decimal);
            cols.ColumnName = "Transportation";
            G.dtColor.Columns.AddRange(new DataColumn[] { cols });
            cols = new DataColumn();
            cols.DefaultValue = "0";
            cols.DataType = typeof(decimal);
            cols.ColumnName = "OtherCost";
            G.dtColor.Columns.AddRange(new DataColumn[] { cols });



            foreach (DataRow row in G.dtColor.Rows)
            {
                if (row["MAITM_CATCD"] == null) continue;
                String Value = row["MAITM_CATCD"].ToString();
                int index = G.listColorCost.FindIndex(a => a.Color.Contains(Value));
                if (index > -1)
                {
                    row["VariableCost"] = G.listColorCost[index].VariableCost;
                    row["FixedCost"] = G.listColorCost[index].FixedCost;
                    row["Transportation"] = G.listColorCost[index].FixedCost;
                    row["OtherCost"] = G.listColorCost[index].OtherCost;
                }
            }
        }

        Font font = new System.Drawing.Font("Arial", 10, FontStyle.Regular);
        public void GetData()
        {
            string strSQL = "EXEC spMAITM '0', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("0") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("PACKING") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(txtDESCTO.Text.Length == 0, "zzzzz", Common.gfValidSQLStr(txtDESCTO.Text))), "' ")));
            G.dtPacking = DB.ExecProc(strSQL);

            
            strSQL = "EXEC spMAITM '0', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("1") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = strSQL + "'" + Common.gfValidSQLStr("") + "', ";
            strSQL = "EXEC spMAITM '0', '1', '', '', '', '', '', '', 'zzzzz'";// Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(txtDESCTO.Text.Length == 0, "zzzzz", Common.gfValidSQLStr(txtDESCTO.Text))), "' ")));

            LoaddtColor();
            this.btnSaveCommission.Image = IMS_Resources.Save;
            this.btnSave.Image = IMS_Resources.Save;

            //   G.dtColor = DB.ExecProc(strSQL);
            //
           
            //

            DataColumn cols = new DataColumn();
            cols.DefaultValue = "0";
            cols.ColumnName = "PackingCost";    
            G.dtPacking.Columns.AddRange(new DataColumn[] { cols });
            foreach (DataRow row in G.dtPacking.Rows)
            {
                if (row["MAITM_ITMCD"] == null) continue;
                String Value = row["MAITM_ITMCD"].ToString();
                int index = G.listPackingCost.FindIndex(a => a.codePacking.Contains(Value));
                if (index > -1)
                {
                    row["PackingCost"] = G.listPackingCost[index].PackCost;
                    //row["VariableCost"] = G.listPackingCost[index].VariableCost;

                }
            }

            RefreshCal();
            cbHCUSID.DataTable = "MACUS_TBL WITH (NOLOCK)";
            cbHCUSID.ValueMember = "MACUS_CUSID";
            cbHCUSID.DisplayMember = "MACUS_SHORT";
            cbHCUSID.LoadData();

        }
         public void LoadData()
        {
            
            dataGridView.DataSource = null;
            
            dataGridView.DataSource = G.dtPacking;
            dataGridView.Refresh();
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                col.Width = 150;
                col.DefaultCellStyle.Font = font;

                switch (col.Name)
                {
                    case "MAITM_ITMCD":
                        col.Visible = true;
                       
                        col.HeaderText = "Item Code";
                        col.ReadOnly = true;
                        break;
                    case "MAITM_DESC":
                        col.Visible = true;
                     
                        col.HeaderText = "Name Packing";
                        col.ReadOnly = true;
                        break;
                    case "MAITM_PUPRC":
                        col.Visible = true;
                       
                        col.HeaderText = "Purchase price";
                        col.ReadOnly = true;
                        break;
                    case "MAITM_STDWGT":
                        col.Visible = true;
                      
                        col.HeaderText = "Standard Weight";
                        col.ReadOnly = true;
                        break;
                    case "PackingCost":
                        col.Visible = true;
                      
                        col.HeaderText = "Packing Cost";
                        col.DefaultCellStyle.Format= "N2";
                        col.DefaultCellStyle.ForeColor = Color.Black;
                        col.DefaultCellStyle.NullValue = "0";
                        col.DefaultCellStyle.Font = font;
                        col.ReadOnly = true;
                        break;
                    case "VariableCost":
                        col.Visible = true;
                       
                        col.HeaderText = "Variable Cost";
                        col.DefaultCellStyle.Format = "N2";
                        col.DefaultCellStyle.ForeColor = Color.Blue;
                        col.DefaultCellStyle.NullValue = "0";
                        col.DefaultCellStyle.Font = font;

                        break;
                    default :
                        col.Visible = false;
                        break;
                }    
            }

            //dataGridView.Columns["PackingCost"].Visible = true;
            //dataGridView.Columns["PackingCost"].Width = 100;
            //dataGridView.Columns["PackingCost"].HeaderText = "Packing Cost";
            //dataGridView.Columns["PackingCost"].DefaultCellStyle.Format = "C0";

           
            dataGridView.Refresh();
            tmRefresh.Enabled = true;

        }
        private void clearGrid(DataGridView view) {
    for (int row = 0; row < view.Rows.Count; ++row) {
        bool isEmpty = true;
        for (int col = 0; col < view.Columns.Count; ++col) {
            object value = view.Rows[row].Cells[col].Value;
            if (value != null && value.ToString().Length > 0) {
                isEmpty = false;
                break;
            }
        }
        if (isEmpty) {
            // deincrement (after the call) since we are removing the row
            view.Rows.RemoveAt(row--);
        }
    }
}
        public void LoadDataColor()
        {
            dataGridViewColor.DataSource = null;
           
            dataGridViewColor.DataSource = G.dtColor;
            dataGridViewColor.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
            dataGridViewColor.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dataGridViewColor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridViewColor.AllowUserToAddRows = false;
            dataGridViewColor.AllowUserToDeleteRows = false;
            dataGridViewColor.AllowUserToResizeRows = false;
            dataGridViewColor.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewColor.EnableHeadersVisualStyles = false;
            dataGridViewColor.GridColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewColor.Location = new System.Drawing.Point(4, 143);
            dataGridViewColor.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewColor.MultiSelect = true;
           
            dataGridViewColor.RowHeadersVisible = false;
            dataGridViewColor.RowHeadersWidth = 10;
            dataGridViewColor.RowTemplate.Height = 24;
            dataGridViewColor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
   
        
            dataGridViewColor.Refresh();
            foreach (DataGridViewColumn col in dataGridViewColor.Columns)
            {
                col.Width = 150;
                col.DefaultCellStyle.Font = font;

                switch (col.Name)
                {
                    case "MAITM_GRPCD":
                        col.Visible = true;
                        col.DisplayIndex = 0;
                        col.HeaderText = "Group code";
                        col.ReadOnly = true;
                        break;
                    case "MAITM_BRAND":
                        col.Visible = true;
                        col.DisplayIndex = 1;
                        col.HeaderText = "Brand";
                        col.ReadOnly = true;
                        break;
                    case "MAITM_CATCD":
                        col.Visible = true;
                        col.DisplayIndex = 2;
                        col.HeaderText = "Category";
                        col.ReadOnly = true;
                        break;
                  
                        break;
                    case "VariableCost":
                        col.Visible = true;
                      
                        col.HeaderText = "Variable Cost";
                        col.DefaultCellStyle.Format = "0,##";
                        col.DefaultCellStyle.ForeColor = Color.Blue;
                        col.DefaultCellStyle.NullValue = "0";
                        col.DefaultCellStyle.Font = font;
                       // col.ValueType = typeof(string);
                        break;
                    case "FixedCost":
                        col.Visible = true;
                      
                        col.HeaderText = "Fixed Cost";
                        col.DefaultCellStyle.Format = "0,##";
                        col.DefaultCellStyle.ForeColor = Color.Blue;
                        col.DefaultCellStyle.NullValue = "0";
                        col.DefaultCellStyle.Font = font;
                     //   col.ValueType = typeof(string);
                        break;
                    case "Transportation":
                        col.Visible = true;
                        
                        col.HeaderText = "Transportation";
                        col.DefaultCellStyle.Format = "0,##";
                        col.DefaultCellStyle.ForeColor = Color.Blue;
                        col.DefaultCellStyle.NullValue = "0";
                        col.DefaultCellStyle.Font = font;
                      //  col.ValueType = typeof(string);
                        break;
                    case "OtherCost":
                        col.Visible = true;

                        col.HeaderText = "Other Cost";
                        col.DefaultCellStyle.Format = "0,##";
                        col.DefaultCellStyle.ForeColor = Color.Blue;
                        col.DefaultCellStyle.NullValue = "0";
                        col.DefaultCellStyle.Font = font;
                        //  col.ValueType = typeof(string);
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }


          
        
            dataGridViewColor.Columns[0].Visible = false;
            dataGridViewColor.Refresh();
            dataGridViewColor.EditingControlShowing += DataGridViewColor_EditingControlShowing;
            dataGridViewColor.CellEndEdit += DataGridViewColor_CellEndEdit;
        
        }

        private void DataGridViewColor_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewColor.CurrentCell.Style.ForeColor = Color.Green;
            dataGridViewColor.Refresh();
        }

        private void DataGridViewColor_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyUp -=   TbCommission_KeyUp;
            e.Control.KeyPress -= Control_KeyPress;
            String nameCol= dataGridViewColor.Columns[dataGridViewColor.CurrentCell.ColumnIndex].Name;
              if (nameCol == "VariableCost" ||
                nameCol == "FixedCost" ||
                nameCol == "Transportation"||
                 nameCol == "OtherCost")
            {
                e.Control.KeyUp += TbCommission_KeyUp;
                e.Control.KeyPress += Control_KeyPress;
               

            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        float valCommission = 0,valPacking=0;
        private void TbCommission_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox txt = sender as TextBox;
                //if (txt.Text.Trim() != "")
                //    if (txt.Text[0] == '0')
                //        txt.Text = txt.Text.Replace("0", "");
                if (txt.Text.Trim() != "")
                {
                    try
                    {
                        string sVal = txt.Text.Trim().Replace(",", "");
                        valPacking = Convert.ToSingle(sVal);

                        txt.Text = valPacking.ToString("#,##"); ;// val.ToString(val % 1 == 0 ? "N0" : "N2");
                        txt.SelectionStart = txt.Text.Length;
                        txt.SelectionLength = 0;
                        dataGridViewColor.CurrentCell.Value = valPacking;

                    }
                    catch (Exception ex)
                    {

                    }

                    // cell.Value = txt.Text;



                }
            }
        }

        private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyUp -= Tb_KeyUp;
            e.Control.KeyPress -= Tb_KeyPress;
            if (dataGridView.Columns[ dataGridView.CurrentCell.ColumnIndex].Name == "QOCQO_COMM")
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyUp += Tb_KeyUp;
                    tb.KeyPress += Tb_KeyPress;
                }
               
            }
          
        }

        private void Tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void Tb_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox)
            {
                TextBox txt = sender as TextBox;
                //if (txt.Text.Trim() != "")
                //    if (txt.Text[0] == '0')
                //        txt.Text = txt.Text.Replace("0", "");
                if (txt.Text.Trim() != "")
                {
                    try
                    {
                        string sVal = txt.Text.Trim().Replace(",", "");
                        valCommission = Convert.ToSingle(sVal);

                        txt.Text = valCommission.ToString("#,##"); ;// val.ToString(val % 1 == 0 ? "N0" : "N2");
                        txt.SelectionStart = txt.Text.Length;
                        txt.SelectionLength = 0;
                        dataGridView.CurrentCell.Value = valCommission;
                    }
                    catch (Exception ex)
                    {

                    }

                    // cell.Value = txt.Text;



                }
            }
        }



      

        private void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
         
            dataGridView.CurrentCell.Style.ForeColor = Color.Green;
            dataGridView.Refresh();
        }

     

        public void RefreshCal()
        {
            G.listPackingCost = new List<PackingCost>();
            G.listPackingCost.Add(new PackingCost("", 1, 1));
            DataTable dt = DB.ExecProc("EXEC spMACOD 'PACKING'");
            int num = dt.Rows.Count - 1;
            List<String> listcodID = new List<String>();
            List<double> listStardweight = new List<double>();
            foreach (DataRow row in dt.Rows)
            {
                listcodID.Add( row["MACOD_CODID"].ToString());
                listStardweight.Add(Conversions.ToDouble( row["MACOD_NFLD1"]));
               
            }
         
            foreach (DataRow row in G.dtPacking.Rows)
            {
                double STWG =Convert.ToSingle( row["MAITM_STDWGT"]);// listcodID.FindIndex(a => a.Contains(row["MAITM_STDWGT"].ToString().Trim()));
                //double dWeight = 1;
                //if (STWG > -1)
                //{
                //    dWeight = listStardweight[index];
                //}    
                double priceCost = Conversions.ToDouble(row["MAITM_PUPRC"]) / STWG;

                row["PackingCost"] = priceCost + "";
                if (row["MAITM_ITMCD"] == null) continue;
                G.listPackingCost.Add(new PackingCost(row["MAITM_ITMCD"].ToString(), priceCost, STWG));

            }
        }
        public void Cal()
        {
            bool IsNew = false;
            if (G.listColorCost.Count == 0)
            {
                IsNew = true;
                G.listColorCost = new List<ColorCost>();
            }
            else IsNew = false;


            foreach (DataGridViewRow row in dataGridViewColor.Rows)
            {


                //Transportation CommissionCost FixedCost
                double Variable = 0, FixedCost = 0, Transportation=0,OtherCost=0;
                if (row.Cells["VariableCost"].Value != null)
                    if (row.Cells["VariableCost"].Value.ToString().Trim() != "")
                    {
                        Variable = Conversions.ToDouble(row.Cells["VariableCost"].Value);
                    }
             
                if (row.Cells["FixedCost"].Value != null)
                    if (row.Cells["FixedCost"].Value.ToString().Trim() != "")
                    {
                        FixedCost = Conversions.ToDouble(row.Cells["FixedCost"].Value);
                    }
                if (row.Cells["Transportation"].Value != null)
                    if (row.Cells["Transportation"].Value.ToString().Trim() != "")
                    {
                        Transportation = Conversions.ToDouble(row.Cells["Transportation"].Value);
                    }
                if (row.Cells["OtherCost"].Value != null)
                    if (row.Cells["OtherCost"].Value.ToString().Trim() != "")
                    {
                        OtherCost = Conversions.ToDouble(row.Cells["OtherCost"].Value);
                    }
                if (row.Cells["MAITM_CATCD"].Value == null) continue;
                int index = G.listColorCost.FindIndex(a => a.Color == row.Cells["MAITM_CATCD"].Value.ToString());

                if (IsNew|| index==-1)
                {

                 
                    G.listColorCost.Add( new ColorCost(row.Cells["MAITM_CATCD"].Value.ToString(), Variable, FixedCost, Transportation, OtherCost));
                    String strSQL = "INSERT INTO CostSetup (Category, VariableCost,FixedCost, Transportation,OtherCost) ";
                    strSQL = strSQL + "VALUES ('" + row.Cells["MAITM_CATCD"].Value.ToString() + "', '" + Variable + "', '" + FixedCost + "', '" + Transportation + "', '" + OtherCost + "')";
                    DB.ExecProc(strSQL);
                }
                else
                {
                   
                     DB.RecordExists("UPDATE CostSetup SET VariableCost = '" + Variable + "' , FixedCost = '" + FixedCost + "' , Transportation = '" + Transportation + "'  , OtherCost = '" + OtherCost + "'  WHERE Category='" + row.Cells["MAITM_CATCD"].Value + "' ");
                   
                    G.listColorCost[index] = new ColorCost(row.Cells["MAITM_CATCD"].Value.ToString(), Variable, FixedCost, Transportation, OtherCost);

                }
            }

        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            Cal();
            if (File.Exists("PackingCost.conf"))
                File.Delete("PackingCost.conf");
            //if (File.Exists("ColorCost.conf"))
            //    File.Delete("ColorCost.conf");
           // Access.SaveColorCost(G.listColorCost);
           // Access.SavePackingCost(G.listPackingCost);
            dataGridView.Refresh();
            MessageBox.Show("Update Quotation Cost Complete!");
        }

        private void dataGridViewColor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Quotation2_Load_1(object sender, EventArgs e)
        {
          //  if (File.Exists("PackingCost.conf"))
              //  G.listPackingCost = Access.LoadPackingCost();
            //if (File.Exists("ColorCost.conf"))
            G.listColorCost = new List<ColorCost>();
          DataTable dt=  DB.GetTable("*","CostSetup","","");
            foreach(DataRow dr in dt.Rows)
            {
                G.listColorCost.Add(new ColorCost(dr["Category"].ToString(), Convert.ToDouble(dr["VariableCost"]), Convert.ToDouble(dr["FixedCost"]), Convert.ToDouble(dr["Transportation"]), Convert.ToDouble(dr["OtherCost"])));
            }
            GetData();
            //LoadData();
            LoadDataColor();
            Cal();
            cbHGRPCD.SelectedIndex = -1;
            BindComboBox("HGRPCD");
        }

        private void tmRefresh_Tick(object sender, EventArgs e)
        {
            RefreshCal();
            dataGridView.Refresh();
            dataGridView.Update();
            tmRefresh.Enabled = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RefreshGridDetails()
        {
            int i = 0;
            double dblTotal = 0.0;
            dataGridView.Columns.Clear();// = new DataGridView();
            dataGridView.DataSource = null;
            string strSQL = "QOCQO_MDLCD, QOCQO_CPTNO, QOCQO_COMM,QOCQO_CUSID";

            G.dtCommssion = DB.GetTable(strSQL, "QOCQO_WRK", "QOCQO_CUSID = '" + Conversions.ToString(cbHCUSID.SelectedValue) + "'",""); 
            checked
            {
                if (G.dtCommssion.Rows.Count == 0)
                {
                    G.dtCommssion = DB.GetTable(strSQL, "QOCQO_TBL", "QOCQO_CUSID = '" + Conversions.ToString(cbHCUSID.SelectedValue) + "'", "");
                    if (G.dtCommssion.Rows.Count == 0)
                    {

                        MessageBox.Show(Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "No data found!"), "Inovex Business Suites", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                        goto X;
                 }
            X:     if (G.dtCommssion.Rows.Count > 0)
                {


                    dataGridView.DataSource = G.dtCommssion;
                
                    dataGridView.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView.AllowUserToAddRows = false;
                    dataGridView.AllowUserToDeleteRows = false;
                    dataGridView.AllowUserToResizeRows = false;
                    dataGridView.BackgroundColor = System.Drawing.Color.Lavender;
                    dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.GridColor = System.Drawing.SystemColors.ActiveBorder;
                    dataGridView.Location = new System.Drawing.Point(4, 143);
                    dataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
                    dataGridView.MultiSelect = true;

                    dataGridView.RowHeadersVisible = false;
                    dataGridView.RowHeadersWidth = 10;
                    dataGridView.RowTemplate.Height = 24;
                    dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

                    dataGridView.Refresh();
                    if(dataGridView.DataSource==null)
                            return;
                    dataGridView.Columns["QOCQO_CPTNO"].Visible = true;
                    dataGridView.Columns["QOCQO_CPTNO"].Width = 120;
                    dataGridView.Columns["QOCQO_CPTNO"].HeaderText = "Customer part";
                    dataGridView.Columns["QOCQO_CPTNO"].ReadOnly = false;
                    dataGridView.Columns["QOCQO_CPTNO"].DefaultCellStyle.Font = font;
                  
                    i++;
                    dataGridView.Columns["QOCQO_MDLCD"].Visible = true;
                    dataGridView.Columns["QOCQO_MDLCD"].Width = 210;
                    dataGridView.Columns["QOCQO_MDLCD"].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Model Code");
                    dataGridView.Columns["QOCQO_MDLCD"].ReadOnly = true;
                  
                    dataGridView.Columns["QOCQO_MDLCD"].DefaultCellStyle.Font = font;

                    i++;
                    dataGridView.Columns["QOCQO_COMM"].Visible = true;
                    dataGridView.Columns["QOCQO_COMM"].Width = 130;
                    dataGridView.Columns["QOCQO_COMM"].HeaderText = Common.gfConvertLanguage(PublicVar.gstrLanguage, Conversions.ToString(base.Tag), "Commission");
                    dataGridView.Columns["QOCQO_COMM"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["QOCQO_COMM"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dataGridView.Columns["QOCQO_COMM"].DefaultCellStyle.Format = Common.gfNumberFormat(PublicEnum.ControlTypeEnum.DataGridView, PublicEnum.NumberFormatEnum.Price);
                    dataGridView.Columns["QOCQO_COMM"].ReadOnly = false;
                    dataGridView.Columns["QOCQO_COMM"].DefaultCellStyle.Font = font;
                    dataGridView.Columns["QOCQO_COMM"].DefaultCellStyle.ForeColor = Color.Blue;
                   // dataGridView.Columns["QOCQO_COMM"].ValueType = typeof(String);
                    dataGridView.Columns["QOCQO_COMM"].DefaultCellStyle.Format = "0,##";
                    i++;
                    dataGridView.Columns[i].Visible = false;
                    dataGridView.EditingControlShowing += DataGridView_EditingControlShowing;
                    dataGridView.CellEndEdit += DataGridView_CellEndEdit;
                    dataGridView.Refresh();
                  
                }
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void cbHCUSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridDetails();
        }

        private void btnSaveCommission_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
              if(  row.Cells["QOCQO_COMM"].Value!=null)
                {
                    double d = Conversions.ToDouble(row.Cells["QOCQO_COMM"].Value.ToString().Replace(",",""));
                    if(d!=0)
                    {
                        DB.RecordExists("UPDATE QOCQO_WRK SET QOCQO_COMM = '" + d+ "'   WHERE QOCQO_CUSID='"+ row.Cells["QOCQO_CUSID"].Value + "' AND  QOCQO_CPTNO  = '"+ row.Cells["QOCQO_CPTNO"].Value + "' ");
                        DB.RecordExists("UPDATE QOCQO_TBL SET QOCQO_COMM = '" + d + "'   WHERE QOCQO_CUSID='" + row.Cells["QOCQO_CUSID"].Value + "' AND  QOCQO_CPTNO  = '" + row.Cells["QOCQO_CPTNO"].Value + "' ");

                    }
                }    
            }
            MessageBox.Show("Update Quotation Commission Cost Complete!");
        }

        private void dataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.S)
            {
                btnSaveCommission.PerformClick();
              
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (dataGridView.SelectedRows.Count > 1)
                {
                    DataGridViewRow row1 = dataGridView.SelectedRows[dataGridView.SelectedRows.Count - 1];
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        if (row != row1)
                        {
                            try
                            {
                                row.Cells["QOCQO_COMM"].Value = row1.Cells["QOCQO_COMM"].Value;
                             
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                    }
                    dataGridView.Refresh();
                }


            }
        }
        bool IsLoad = false,IsLoad2;
        private void cbHGRPCD_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHBRAND.SelectedIndex = -1;


            if (!IsLoad)
            {
                IsLoad = true;
                return;
            }
            if (cbHGRPCD.SelectedIndex != -1)
            {
                LoaddtColor();
                LoadDataColor();
                IsLoad2=false;
                BindComboBox("HBRAND");
                cbHBRAND.SelectedIndex = -1;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbHBRAND_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsLoad2)
            {
                IsLoad2 = true;
                return;
            }
            if (cbHBRAND.SelectedIndex != -1)
            {
                LoaddtColor();
                LoadDataColor();
                
            }
        }

        private void dataGridViewColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
               
            }
            if ( e.KeyCode == Keys.Enter)
            {
              if(dataGridViewColor.SelectedRows.Count>1)
                {
                    DataGridViewRow row1 = dataGridViewColor.SelectedRows[dataGridViewColor.SelectedRows.Count-1];
                    foreach (DataGridViewRow row in  dataGridViewColor.SelectedRows)
                    {
                        if (row !=row1)
                        {
                            try
                            {
                                row.Cells["VariableCost"].Value = row1.Cells["VariableCost"].Value;
                                row.Cells["FixedCost"].Value = row1.Cells["FixedCost"].Value;
                                row.Cells["Transportation"].Value = row1.Cells["Transportation"].Value;
                                row.Cells["OtherCost"].Value = row1.Cells["OtherCost"].Value;

                            }
                            catch (Exception ex )
                            {

                            }
                            }
                    }
                    dataGridViewColor.Refresh();
                }
                    

            }
        }
    }
}
