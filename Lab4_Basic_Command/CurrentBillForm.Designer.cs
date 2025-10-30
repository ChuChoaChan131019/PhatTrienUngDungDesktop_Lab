namespace Lab4_Basic_Command
{
    partial class CurrentBillForm
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
            this.dgvCurrentBill = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.clIDFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCurrentBill
            // 
            this.dgvCurrentBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIDFood,
            this.ClName,
            this.clSoLuong,
            this.clPrice,
            this.clTotal});
            this.dgvCurrentBill.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCurrentBill.Location = new System.Drawing.Point(0, 125);
            this.dgvCurrentBill.Name = "dgvCurrentBill";
            this.dgvCurrentBill.RowHeadersWidth = 51;
            this.dgvCurrentBill.RowTemplate.Height = 24;
            this.dgvCurrentBill.Size = new System.Drawing.Size(877, 333);
            this.dgvCurrentBill.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn bàn ";
            // 
            // clIDFood
            // 
            this.clIDFood.DataPropertyName = "ID";
            this.clIDFood.HeaderText = "Mã món";
            this.clIDFood.MinimumWidth = 6;
            this.clIDFood.Name = "clIDFood";
            this.clIDFood.Width = 125;
            // 
            // ClName
            // 
            this.ClName.DataPropertyName = "Name";
            this.ClName.HeaderText = "Món";
            this.ClName.MinimumWidth = 6;
            this.ClName.Name = "ClName";
            this.ClName.Width = 125;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "Quantity";
            this.clSoLuong.HeaderText = "Số lượng";
            this.clSoLuong.MinimumWidth = 6;
            this.clSoLuong.Name = "clSoLuong";
            this.clSoLuong.Width = 125;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "Giá";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.Width = 125;
            // 
            // clTotal
            // 
            this.clTotal.DataPropertyName = "Total";
            this.clTotal.HeaderText = "Thành tiền";
            this.clTotal.MinimumWidth = 6;
            this.clTotal.Name = "clTotal";
            this.clTotal.Width = 125;
            // 
            // CurrentBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCurrentBill);
            this.Name = "CurrentBillForm";
            this.Text = "CurrentBillForm";
            this.Load += new System.EventHandler(this.CurrentBillForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrentBill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIDFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTotal;
    }
}