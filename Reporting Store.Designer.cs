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
            this.dgvWH1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWH1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWH1
            // 
            this.dgvWH1.AllowUserToResizeColumns = false;
            this.dgvWH1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWH1.Location = new System.Drawing.Point(0, 0);
            this.dgvWH1.Name = "dgvWH1";
            this.dgvWH1.RowHeadersVisible = false;
            this.dgvWH1.RowHeadersWidth = 82;
            this.dgvWH1.RowTemplate.Height = 33;
            this.dgvWH1.Size = new System.Drawing.Size(1609, 973);
            this.dgvWH1.TabIndex = 0;
            // 
            // Reporting_Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 973);
            this.Controls.Add(this.dgvWH1);
            this.Name = "Reporting_Store";
            this.Text = "Reporting_Store";
            this.Load += new System.EventHandler(this.Reporting_Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWH1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWH1;
    }
}