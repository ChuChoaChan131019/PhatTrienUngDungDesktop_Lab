namespace Lab4_Basic_Command
{
    partial class InvoiceListForm
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
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.lbNgayLapHD = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvBillDetails.Location = new System.Drawing.Point(193, 0);
            this.dgvBillDetails.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.RowHeadersWidth = 51;
            this.dgvBillDetails.Size = new System.Drawing.Size(847, 544);
            this.dgvBillDetails.TabIndex = 3;
            // 
            // lbNgayLapHD
            // 
            this.lbNgayLapHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNgayLapHD.FormattingEnabled = true;
            this.lbNgayLapHD.ItemHeight = 16;
            this.lbNgayLapHD.Location = new System.Drawing.Point(0, 0);
            this.lbNgayLapHD.Margin = new System.Windows.Forms.Padding(4);
            this.lbNgayLapHD.Name = "lbNgayLapHD";
            this.lbNgayLapHD.Size = new System.Drawing.Size(193, 544);
            this.lbNgayLapHD.TabIndex = 2;
            this.lbNgayLapHD.SelectedIndexChanged += new System.EventHandler(this.lbNgayLapHD_SelectedIndexChanged);
            // 
            // InvoiceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 544);
            this.Controls.Add(this.dgvBillDetails);
            this.Controls.Add(this.lbNgayLapHD);
            this.Name = "InvoiceListForm";
            this.Text = "InvoiceListForm";
            this.Load += new System.EventHandler(this.InvoiceListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.ListBox lbNgayLapHD;
    }
}