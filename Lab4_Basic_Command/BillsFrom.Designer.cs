namespace Lab4_Basic_Command
{
    partial class BillsFrom
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
            this.dtpNgayStart = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThucThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoc = new System.Windows.Forms.Button();
            this.lable7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSumAmount = new System.Windows.Forms.Label();
            this.lblSumDis = new System.Windows.Forms.Label();
            this.lblSumThucThu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpNgayStart
            // 
            this.dtpNgayStart.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayStart.Location = new System.Drawing.Point(229, 61);
            this.dtpNgayStart.Name = "dtpNgayStart";
            this.dtpNgayStart.Size = new System.Drawing.Size(131, 20);
            this.dtpNgayStart.TabIndex = 0;
            // 
            // dtpNgayEnd
            // 
            this.dtpNgayEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayEnd.Location = new System.Drawing.Point(229, 102);
            this.dtpNgayEnd.Name = "dtpNgayEnd";
            this.dtpNgayEnd.Size = new System.Drawing.Size(131, 20);
            this.dtpNgayEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn ngày tra cứu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày kết thúc";
            // 
            // dgvBills
            // 
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clTableID,
            this.clAmount,
            this.clDis,
            this.clTax,
            this.clThucThu,
            this.clCheckoutDate});
            this.dgvBills.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBills.Location = new System.Drawing.Point(0, 245);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.Size = new System.Drawing.Size(800, 205);
            this.dgvBills.TabIndex = 6;
            this.dgvBills.DoubleClick += new System.EventHandler(this.dgvBills_DoubleClick);
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "Mã hóa đơn";
            this.clID.Name = "clID";
            // 
            // clTableID
            // 
            this.clTableID.DataPropertyName = "TableID";
            this.clTableID.HeaderText = "Mã bàn";
            this.clTableID.Name = "clTableID";
            // 
            // clAmount
            // 
            this.clAmount.DataPropertyName = "Amount";
            this.clAmount.HeaderText = "Tổng tiền";
            this.clAmount.Name = "clAmount";
            // 
            // clDis
            // 
            this.clDis.DataPropertyName = "Discount";
            this.clDis.HeaderText = "Giảm giá";
            this.clDis.Name = "clDis";
            // 
            // clTax
            // 
            this.clTax.DataPropertyName = "Tax";
            this.clTax.HeaderText = "Thuế";
            this.clTax.Name = "clTax";
            // 
            // clThucThu
            // 
            this.clThucThu.DataPropertyName = "ThucThu";
            this.clThucThu.HeaderText = "Thực thu";
            this.clThucThu.Name = "clThucThu";
            // 
            // clCheckoutDate
            // 
            this.clCheckoutDate.DataPropertyName = "CheckoutDate";
            this.clCheckoutDate.HeaderText = "Ngày thanh toán";
            this.clCheckoutDate.Name = "clCheckoutDate";
            this.clCheckoutDate.Width = 150;
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(366, 58);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(79, 30);
            this.btnLoc.TabIndex = 7;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable7.Location = new System.Drawing.Point(12, 146);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(128, 16);
            this.lable7.TabIndex = 8;
            this.lable7.Text = "Tổng tiền chưa giảm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tổng tiền giảm giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tổng tiền thực thu";
            // 
            // lblSumAmount
            // 
            this.lblSumAmount.AutoSize = true;
            this.lblSumAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumAmount.Location = new System.Drawing.Point(173, 146);
            this.lblSumAmount.Name = "lblSumAmount";
            this.lblSumAmount.Size = new System.Drawing.Size(14, 16);
            this.lblSumAmount.TabIndex = 11;
            this.lblSumAmount.Text = "0";
            // 
            // lblSumDis
            // 
            this.lblSumDis.AutoSize = true;
            this.lblSumDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumDis.Location = new System.Drawing.Point(173, 180);
            this.lblSumDis.Name = "lblSumDis";
            this.lblSumDis.Size = new System.Drawing.Size(14, 16);
            this.lblSumDis.TabIndex = 12;
            this.lblSumDis.Text = "0";
            // 
            // lblSumThucThu
            // 
            this.lblSumThucThu.AutoSize = true;
            this.lblSumThucThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumThucThu.Location = new System.Drawing.Point(173, 212);
            this.lblSumThucThu.Name = "lblSumThucThu";
            this.lblSumThucThu.Size = new System.Drawing.Size(14, 16);
            this.lblSumThucThu.TabIndex = 13;
            this.lblSumThucThu.Text = "0";
            // 
            // BillsFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSumThucThu);
            this.Controls.Add(this.lblSumDis);
            this.Controls.Add(this.lblSumAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lable7);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.dgvBills);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayEnd);
            this.Controls.Add(this.dtpNgayStart);
            this.Name = "BillsFrom";
            this.Text = "BillsFrom";
            this.Load += new System.EventHandler(this.BillsFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpNgayStart;
        private System.Windows.Forms.DateTimePicker dtpNgayEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThucThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckoutDate;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label lable7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSumAmount;
        private System.Windows.Forms.Label lblSumDis;
        private System.Windows.Forms.Label lblSumThucThu;
    }
}