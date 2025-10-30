namespace Lab_Advanced_Command
{
    partial class OrderForm
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
            this.lblSumThucThu = new System.Windows.Forms.Label();
            this.lblSumDis = new System.Windows.Forms.Label();
            this.lblSumAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lable7 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThucThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCheckoutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSumThucThu
            // 
            this.lblSumThucThu.AutoSize = true;
            this.lblSumThucThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumThucThu.Location = new System.Drawing.Point(231, 248);
            this.lblSumThucThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumThucThu.Name = "lblSumThucThu";
            this.lblSumThucThu.Size = new System.Drawing.Size(18, 20);
            this.lblSumThucThu.TabIndex = 27;
            this.lblSumThucThu.Text = "0";
            // 
            // lblSumDis
            // 
            this.lblSumDis.AutoSize = true;
            this.lblSumDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumDis.Location = new System.Drawing.Point(231, 209);
            this.lblSumDis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumDis.Name = "lblSumDis";
            this.lblSumDis.Size = new System.Drawing.Size(18, 20);
            this.lblSumDis.TabIndex = 26;
            this.lblSumDis.Text = "0";
            // 
            // lblSumAmount
            // 
            this.lblSumAmount.AutoSize = true;
            this.lblSumAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumAmount.Location = new System.Drawing.Point(231, 167);
            this.lblSumAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumAmount.Name = "lblSumAmount";
            this.lblSumAmount.Size = new System.Drawing.Size(18, 20);
            this.lblSumAmount.TabIndex = 25;
            this.lblSumAmount.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 248);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tổng tiền thực thu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tổng tiền giảm giá";
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable7.Location = new System.Drawing.Point(16, 167);
            this.lable7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(160, 20);
            this.lable7.TabIndex = 22;
            this.lable7.Text = "Tổng tiền chưa giảm";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Location = new System.Drawing.Point(488, 58);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(105, 37);
            this.btnLoc.TabIndex = 21;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
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
            this.dgvBills.Location = new System.Drawing.Point(0, 310);
            this.dgvBills.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersWidth = 51;
            this.dgvBills.Size = new System.Drawing.Size(1052, 298);
            this.dgvBills.TabIndex = 20;
            this.dgvBills.DoubleClick += new System.EventHandler(this.dgvBills_DoubleClick);
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "Mã hóa đơn";
            this.clID.MinimumWidth = 6;
            this.clID.Name = "clID";
            this.clID.Width = 125;
            // 
            // clTableID
            // 
            this.clTableID.DataPropertyName = "TableID";
            this.clTableID.HeaderText = "Mã bàn";
            this.clTableID.MinimumWidth = 6;
            this.clTableID.Name = "clTableID";
            this.clTableID.Width = 125;
            // 
            // clAmount
            // 
            this.clAmount.DataPropertyName = "Amount";
            this.clAmount.HeaderText = "Tổng tiền";
            this.clAmount.MinimumWidth = 6;
            this.clAmount.Name = "clAmount";
            this.clAmount.Width = 125;
            // 
            // clDis
            // 
            this.clDis.DataPropertyName = "Discount";
            this.clDis.HeaderText = "Giảm giá";
            this.clDis.MinimumWidth = 6;
            this.clDis.Name = "clDis";
            this.clDis.Width = 125;
            // 
            // clTax
            // 
            this.clTax.DataPropertyName = "Tax";
            this.clTax.HeaderText = "Thuế";
            this.clTax.MinimumWidth = 6;
            this.clTax.Name = "clTax";
            this.clTax.Width = 125;
            // 
            // clThucThu
            // 
            this.clThucThu.DataPropertyName = "ThucThu";
            this.clThucThu.HeaderText = "Thực thu";
            this.clThucThu.MinimumWidth = 6;
            this.clThucThu.Name = "clThucThu";
            this.clThucThu.Width = 125;
            // 
            // clCheckoutDate
            // 
            this.clCheckoutDate.DataPropertyName = "CheckoutDate";
            this.clCheckoutDate.HeaderText = "Ngày thanh toán";
            this.clCheckoutDate.MinimumWidth = 6;
            this.clCheckoutDate.Name = "clCheckoutDate";
            this.clCheckoutDate.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Chọn ngày tra cứu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 42);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // dtpNgayEnd
            // 
            this.dtpNgayEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayEnd.Location = new System.Drawing.Point(305, 113);
            this.dtpNgayEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayEnd.Name = "dtpNgayEnd";
            this.dtpNgayEnd.Size = new System.Drawing.Size(173, 22);
            this.dtpNgayEnd.TabIndex = 15;
            // 
            // dtpNgayStart
            // 
            this.dtpNgayStart.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayStart.Location = new System.Drawing.Point(305, 62);
            this.dtpNgayStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayStart.Name = "dtpNgayStart";
            this.dtpNgayStart.Size = new System.Drawing.Size(173, 22);
            this.dtpNgayStart.TabIndex = 14;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 608);
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
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSumThucThu;
        private System.Windows.Forms.Label lblSumDis;
        private System.Windows.Forms.Label lblSumAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable7;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView dgvBills;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTableID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThucThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCheckoutDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayEnd;
        private System.Windows.Forms.DateTimePicker dtpNgayStart;
    }
}