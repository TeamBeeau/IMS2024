namespace IMS
{
    partial class Quotation2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDESCTO = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tmRefresh = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHBRAND = new System.Windows.Forms.ComboBox();
            this.cbHGRPCD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCommission = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewColor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbHCUSID = new IMS.ComboboxControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(477, 541);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            this.dataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyUp);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(807, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Update \r\nCtrl+S)";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDESCTO
            // 
            this.txtDESCTO.Location = new System.Drawing.Point(180, 361);
            this.txtDESCTO.Name = "txtDESCTO";
            this.txtDESCTO.Size = new System.Drawing.Size(100, 20);
            this.txtDESCTO.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // tmRefresh
            // 
            this.tmRefresh.Interval = 10;
            this.tmRefresh.Tick += new System.EventHandler(this.tmRefresh_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbHBRAND);
            this.panel1.Controls.Add(this.cbHGRPCD);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSaveCommission);
            this.panel1.Controls.Add(this.cbHCUSID);
            this.panel1.Controls.Add(this.lb1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1579, 100);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbHBRAND
            // 
            this.cbHBRAND.FormattingEnabled = true;
            this.cbHBRAND.Location = new System.Drawing.Point(825, 68);
            this.cbHBRAND.Name = "cbHBRAND";
            this.cbHBRAND.Size = new System.Drawing.Size(121, 21);
            this.cbHBRAND.TabIndex = 9;
            this.cbHBRAND.SelectedIndexChanged += new System.EventHandler(this.cbHBRAND_SelectedIndexChanged);
            // 
            // cbHGRPCD
            // 
            this.cbHGRPCD.FormattingEnabled = true;
            this.cbHGRPCD.Location = new System.Drawing.Point(618, 69);
            this.cbHGRPCD.Name = "cbHGRPCD";
            this.cbHGRPCD.Size = new System.Drawing.Size(107, 21);
            this.cbHGRPCD.TabIndex = 8;
            this.cbHGRPCD.SelectedIndexChanged += new System.EventHandler(this.cbHGRPCD_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Visible = false;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Demo v .1.1.8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = " Custommer Code";
            // 
            // btnSaveCommission
            // 
            this.btnSaveCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCommission.Location = new System.Drawing.Point(334, 4);
            this.btnSaveCommission.Name = "btnSaveCommission";
            this.btnSaveCommission.Size = new System.Drawing.Size(139, 43);
            this.btnSaveCommission.TabIndex = 5;
            this.btnSaveCommission.Text = "Update\r\n(Ctrl+S)";
            this.btnSaveCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCommission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveCommission.UseVisualStyleBackColor = true;
            this.btnSaveCommission.Click += new System.EventHandler(this.btnSaveCommission_Click);
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(0, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(477, 100);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "\r\nQuotation Commission Setup";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(494, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1082, 100);
            this.label1.TabIndex = 3;
            this.label1.Text = "\r\nQuotation Cost Setup";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(477, 541);
            this.panel4.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.AliceBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(477, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(17, 541);
            this.panel5.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewColor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(494, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1085, 541);
            this.panel2.TabIndex = 11;
            // 
            // dataGridViewColor
            // 
            this.dataGridViewColor.AllowUserToAddRows = false;
            this.dataGridViewColor.BackgroundColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewColor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewColor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewColor.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewColor.Name = "dataGridViewColor";
            this.dataGridViewColor.Size = new System.Drawing.Size(1085, 541);
            this.dataGridViewColor.TabIndex = 4;
            this.dataGridViewColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewColor_KeyDown);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Group Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(745, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Brand";
            // 
            // cbHCUSID
            // 
            this.cbHCUSID.BlankValue = null;
            this.cbHCUSID.ComboboxWidth = 170;
            this.cbHCUSID.DataTable = null;
            this.cbHCUSID.DisplayMember = null;
            this.cbHCUSID.DropdownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbHCUSID.HasBlankValue = false;
            this.cbHCUSID.Location = new System.Drawing.Point(140, 64);
            this.cbHCUSID.Margin = new System.Windows.Forms.Padding(2);
            this.cbHCUSID.Name = "cbHCUSID";
            this.cbHCUSID.SelectedIndex = -1;
            this.cbHCUSID.SelectedItem = null;
            this.cbHCUSID.SelectedValue = null;
            this.cbHCUSID.Size = new System.Drawing.Size(244, 21);
            this.cbHCUSID.TabIndex = 4;
            this.cbHCUSID.TextMultiline = true;
            this.cbHCUSID.ValueMember = null;
            this.cbHCUSID.WhereClause = null;
            this.cbHCUSID.SelectedIndexChanged += new IMS.ComboboxControl.SelectedIndexChangedEventHandler(this.cbHCUSID_SelectedIndexChanged);
            // 
            // Quotation2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDESCTO);
            this.Name = "Quotation2";
            this.Text = "Master Quotation";
            this.Load += new System.EventHandler(this.Quotation2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDESCTO;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer tmRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel4;
        private ComboboxControl cbHCUSID;
        private System.Windows.Forms.Button btnSaveCommission;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHBRAND;
        private System.Windows.Forms.ComboBox cbHGRPCD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}