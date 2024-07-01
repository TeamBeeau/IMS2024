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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbITMTY = new IMS.ComboboxControl();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWH1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
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
            this.cbITMTY.Size = new System.Drawing.Size(936, 64);
            this.cbITMTY.TabIndex = 13;
            this.cbITMTY.TextMultiline = true;
            this.cbITMTY.ValueMember = null;
            this.cbITMTY.WhereClause = null;
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Image = global::IMS_Resources.Refresh;
            this.btnSEARCH.Location = new System.Drawing.Point(19, 227);
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
            this.label5.Location = new System.Drawing.Point(685, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 25);
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
            this.cbHCATCD.Location = new System.Drawing.Point(886, 87);
            this.cbHCATCD.Name = "cbHCATCD";
            this.cbHCATCD.Size = new System.Drawing.Size(209, 39);
            this.cbHCATCD.TabIndex = 4;
            cbHCATCD.SelectedIndexChanged += CbHCATCD_SelectedIndexChanged;
            // 
            // cbHGRPCD
            // 
            this.cbHGRPCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHGRPCD.FormattingEnabled = true;
            this.cbHGRPCD.Location = new System.Drawing.Point(885, 22);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.dgvWH1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWH1.RowTemplate.Height = 24;
            this.dgvWH1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // Reporting_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 973);
            this.Controls.Add(this.dgvWH1);
            this.Controls.Add(this.panel1);
            this.Name = "Reporting_Store";
            this.Text = "Reporting_Store";
            this.Load += new System.EventHandler(this.Reporting_Store_Load);
            this.Shown += new System.EventHandler(this.Reporting_Store_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}