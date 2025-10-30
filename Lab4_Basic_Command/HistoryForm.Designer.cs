namespace Lab4_Basic_Command
{
    partial class HistoryForm
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
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDis = new System.Windows.Forms.Label();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThucThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistory
            // 
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clDateCheckOut,
            this.clFullName,
            this.clAmount,
            this.clTax,
            this.clDis,
            this.clThucThu});
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHistory.Location = new System.Drawing.Point(0, 179);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.RowTemplate.Height = 24;
            this.dgvHistory.Size = new System.Drawing.Size(800, 271);
            this.dgvHistory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số lượng hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng tiền thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tổng tiền thuế";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền giảm giá";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(193, 23);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(18, 20);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "0";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(193, 66);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(18, 20);
            this.lblSum.TabIndex = 6;
            this.lblSum.Text = "0";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(193, 105);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(18, 20);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "0";
            // 
            // lblDis
            // 
            this.lblDis.AutoSize = true;
            this.lblDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDis.Location = new System.Drawing.Point(193, 142);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(18, 20);
            this.lblDis.TabIndex = 8;
            this.lblDis.Text = "0";
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "Mã hóa đơn";
            this.clID.MinimumWidth = 6;
            this.clID.Name = "clID";
            this.clID.Width = 125;
            // 
            // clDateCheckOut
            // 
            this.clDateCheckOut.DataPropertyName = "CheckoutDate";
            this.clDateCheckOut.HeaderText = "Ngày lập";
            this.clDateCheckOut.MinimumWidth = 6;
            this.clDateCheckOut.Name = "clDateCheckOut";
            this.clDateCheckOut.Width = 125;
            // 
            // clFullName
            // 
            this.clFullName.DataPropertyName = "FullName";
            this.clFullName.HeaderText = "Tên nhân viên";
            this.clFullName.MinimumWidth = 6;
            this.clFullName.Name = "clFullName";
            this.clFullName.Width = 125;
            // 
            // clAmount
            // 
            this.clAmount.DataPropertyName = "Amount";
            this.clAmount.HeaderText = "Thành tiền";
            this.clAmount.MinimumWidth = 6;
            this.clAmount.Name = "clAmount";
            this.clAmount.Width = 125;
            // 
            // clTax
            // 
            this.clTax.DataPropertyName = "Tax";
            this.clTax.HeaderText = "Thuế";
            this.clTax.MinimumWidth = 6;
            this.clTax.Name = "clTax";
            this.clTax.Width = 125;
            // 
            // clDis
            // 
            this.clDis.DataPropertyName = "Discount";
            this.clDis.HeaderText = "Giảm giá";
            this.clDis.MinimumWidth = 6;
            this.clDis.Name = "clDis";
            this.clDis.Width = 125;
            // 
            // clThucThu
            // 
            this.clThucThu.DataPropertyName = "TongCong";
            this.clThucThu.HeaderText = "Tổng cộng";
            this.clThucThu.MinimumWidth = 6;
            this.clThucThu.Name = "clThucThu";
            this.clThucThu.Width = 125;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDis);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHistory);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThucThu;
    }
}