using System.Drawing;
using System.Windows.Forms;

namespace IMS
{
    partial class Reporting_Store
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.lb1 = new System.Windows.Forms.Label();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbHCATCD = new System.Windows.Forms.ComboBox();
            this.cbHGRPCD = new System.Windows.Forms.ComboBox();
            this.cbHBRAND = new System.Windows.Forms.ComboBox();
            this.cbHITMTY = new System.Windows.Forms.ComboBox();
            this.dgvWH1 = new System.Windows.Forms.DataGridView();
            this.col9 = new System.Windows.Forms.DataGridViewColumn();
            this.workRefresh = new System.ComponentModel.BackgroundWorker();
            this.cbITMTY = new IMS.ComboboxControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWH1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numMin);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.numMax);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbITMTY);
            this.panel1.Controls.Add(this.btnSEARCH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbHCATCD);
            this.panel1.Controls.Add(this.cbHGRPCD);
            this.panel1.Controls.Add(this.cbHBRAND);
            this.panel1.Controls.Add(this.cbHITMTY);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1609, 341);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(858, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "Min Level";
            // 
            // numMin
            // 
            this.numMin.Location = new System.Drawing.Point(1012, 87);
            this.numMin.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(156, 38);
            this.numMin.TabIndex = 18;
            this.numMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(858, 30);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(136, 31);
            this.lb1.TabIndex = 17;
            this.lb1.Text = "Max Level";
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(1012, 22);
            this.numMax.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(156, 38);
            this.numMax.TabIndex = 16;
            this.numMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numMax.ValueChanged += new System.EventHandler(this.numMax_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "Item Code";
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Image = global::IMS_Resources.Refresh;
            this.btnSEARCH.Location = new System.Drawing.Point(12, 227);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(281, 95);
            this.btnSEARCH.TabIndex = 12;
            this.btnSEARCH.Text = "SEARCH";
            this.btnSEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEARCH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSEARCH.UseVisualStyleBackColor = true;
            this.btnSEARCH.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(414, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Group Code ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item Type";
            // 
            // cbHCATCD
            // 
            this.cbHCATCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHCATCD.FormattingEnabled = true;
            this.cbHCATCD.Location = new System.Drawing.Point(605, 87);
            this.cbHCATCD.Name = "cbHCATCD";
            this.cbHCATCD.Size = new System.Drawing.Size(209, 39);
            this.cbHCATCD.TabIndex = 4;
            this.cbHCATCD.SelectedIndexChanged += new System.EventHandler(this.CbHCATCD_SelectedIndexChanged);
            // 
            // cbHGRPCD
            // 
            this.cbHGRPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHGRPCD.FormattingEnabled = true;
            this.cbHGRPCD.Location = new System.Drawing.Point(604, 22);
            this.cbHGRPCD.Name = "cbHGRPCD";
            this.cbHGRPCD.Size = new System.Drawing.Size(209, 39);
            this.cbHGRPCD.TabIndex = 3;
            this.cbHGRPCD.SelectedIndexChanged += new System.EventHandler(this.cbHGRPCD_SelectedIndexChanged);
            // 
            // cbHBRAND
            // 
            this.cbHBRAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHBRAND.FormattingEnabled = true;
            this.cbHBRAND.Location = new System.Drawing.Point(172, 87);
            this.cbHBRAND.Name = "cbHBRAND";
            this.cbHBRAND.Size = new System.Drawing.Size(209, 39);
            this.cbHBRAND.TabIndex = 2;
            this.cbHBRAND.SelectedIndexChanged += new System.EventHandler(this.cbHBRAND_SelectedIndexChanged);
            // 
            // cbHITMTY
            // 
            this.cbHITMTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHITMTY.FormattingEnabled = true;
            this.cbHITMTY.Location = new System.Drawing.Point(171, 22);
            this.cbHITMTY.Name = "cbHITMTY";
            this.cbHITMTY.Size = new System.Drawing.Size(209, 39);
            this.cbHITMTY.TabIndex = 0;
            this.cbHITMTY.SelectedIndexChanged += new System.EventHandler(this.cbHITMTY_SelectedIndexChanged);
            // 
            // dgvWH1
            // 
            this.dgvWH1.AllowUserToAddRows = false;
            this.dgvWH1.AllowUserToDeleteRows = false;
            this.dgvWH1.AllowUserToResizeRows = false;
            this.dgvWH1.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWH1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWH1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWH1.EnableHeadersVisualStyles = false;
            this.dgvWH1.Location = new System.Drawing.Point(0, 341);
            this.dgvWH1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvWH1.MultiSelect = false;
            this.dgvWH1.Name = "dgvWH1";
            this.dgvWH1.ReadOnly = true;
            this.dgvWH1.RowHeadersVisible = false;
            this.dgvWH1.RowHeadersWidth = 51;
            this.dgvWH1.Size = new System.Drawing.Size(1609, 632);
            this.dgvWH1.TabIndex = 0;
            // 
            // col9
            // 
            this.col9.HeaderText = "BALANCE";
            this.col9.MinimumWidth = 10;
            this.col9.Name = "col9";
            this.col9.ReadOnly = true;
            this.col9.Width = 200;
            // 
            // workRefresh
            // 
            this.workRefresh.WorkerReportsProgress = true;
            this.workRefresh.WorkerSupportsCancellation = true;
            this.workRefresh.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workRefresh_DoWork);
            this.workRefresh.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workRefresh_RunWorkerCompleted);
            // 
            // cbITMTY
            // 
            this.cbITMTY.BlankValue = null;
            this.cbITMTY.ComboboxWidth = 336;
            this.cbITMTY.DataTable = null;
            this.cbITMTY.DisplayMember = null;
            this.cbITMTY.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbITMTY.HasBlankValue = false;
            this.cbITMTY.Location = new System.Drawing.Point(171, 155);
            this.cbITMTY.Margin = new System.Windows.Forms.Padding(5);
            this.cbITMTY.Name = "cbITMTY";
            this.cbITMTY.SelectedIndex = -1;
            this.cbITMTY.SelectedItem = null;
            this.cbITMTY.SelectedValue = null;
            this.cbITMTY.Size = new System.Drawing.Size(944, 64);
            this.cbITMTY.TabIndex = 13;
            this.cbITMTY.TextMultiline = true;
            this.cbITMTY.ValueMember = null;
            this.cbITMTY.WhereClause = null;
            // 
            // Reporting_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 973);
            this.Controls.Add(this.dgvWH1);
            this.Controls.Add(this.panel1);
            this.Name = "Reporting_Store";
            this.Text = "Reporting_Store";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reporting_Store_FormClosing);
            this.Load += new System.EventHandler(this.Reporting_Store_Load);
            this.Shown += new System.EventHandler(this.Reporting_Store_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWH1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbHCATCD;
        private System.Windows.Forms.ComboBox cbHGRPCD;
        private System.Windows.Forms.ComboBox cbHBRAND;
        private System.Windows.Forms.ComboBox cbHITMTY;
        private System.Windows.Forms.DataGridView dgvWH1;
        private DataGridViewColumn col9;
        private Label label3;
        private ComboboxControl cbITMTY;
        private NumericUpDown numMax;
        private Label lb1;
        private Label label6;
        private NumericUpDown numMin;
        public System.ComponentModel.BackgroundWorker workRefresh;
    }
}