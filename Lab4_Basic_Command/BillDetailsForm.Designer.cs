namespace Lab4_Basic_Command
{
    partial class BillDetailsForm
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dgvBillDetails = new System.Windows.Forms.DataGridView();
            this.clIDFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(159, 39);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(179, 25);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Chi tiết hóa đơn";
            // 
            // dgvBillDetails
            // 
            this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIDFood,
            this.clName,
            this.clQuantity,
            this.clPrice,
            this.clAmount});
            this.dgvBillDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBillDetails.Location = new System.Drawing.Point(0, 150);
            this.dgvBillDetails.Name = "dgvBillDetails";
            this.dgvBillDetails.Size = new System.Drawing.Size(542, 347);
            this.dgvBillDetails.TabIndex = 1;
            // 
            // clIDFood
            // 
            this.clIDFood.DataPropertyName = "FoodID";
            this.clIDFood.HeaderText = "Mã thức ăn";
            this.clIDFood.Name = "clIDFood";
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Tên thức ăn";
            this.clName.Name = "clName";
            // 
            // clQuantity
            // 
            this.clQuantity.DataPropertyName = "Quantity";
            this.clQuantity.HeaderText = "Số lượng";
            this.clQuantity.Name = "clQuantity";
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "Giá bán";
            this.clPrice.Name = "clPrice";
            // 
            // clAmount
            // 
            this.clAmount.DataPropertyName = "ThanhTien";
            this.clAmount.HeaderText = "Thành tiền";
            this.clAmount.Name = "clAmount";
            // 
            // BillDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 497);
            this.Controls.Add(this.dgvBillDetails);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "BillDetailsForm";
            this.Text = "BillDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvBillDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
    }
}