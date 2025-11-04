namespace RestaurantManagementProject
{
    partial class frmFood
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
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.lsvFood = new System.Windows.Forms.ListView();
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clFoodCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.btnDelete);
            this.grpLeft.Controls.Add(this.btnUpdate);
            this.grpLeft.Controls.Add(this.btnAdd);
            this.grpLeft.Controls.Add(this.btnClear);
            this.grpLeft.Controls.Add(this.txtNotes);
            this.grpLeft.Controls.Add(this.cbCategory);
            this.grpLeft.Controls.Add(this.txtPrice);
            this.grpLeft.Controls.Add(this.txtUnit);
            this.grpLeft.Controls.Add(this.txtName);
            this.grpLeft.Controls.Add(this.label5);
            this.grpLeft.Controls.Add(this.label4);
            this.grpLeft.Controls.Add(this.label3);
            this.grpLeft.Controls.Add(this.label2);
            this.grpLeft.Controls.Add(this.label1);
            this.grpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpLeft.Location = new System.Drawing.Point(0, 0);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(458, 546);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Chức năng";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(343, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 41);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(236, 483);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 41);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(129, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(16, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 41);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(177, 271);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(258, 148);
            this.txtNotes.TabIndex = 10;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(177, 194);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(258, 28);
            this.cbCategory.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(177, 143);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(258, 27);
            this.txtPrice.TabIndex = 7;
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(177, 93);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(258, 27);
            this.txtUnit.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(177, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 27);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại thực phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thực phẩm";
            // 
            // grpRight
            // 
            this.grpRight.Controls.Add(this.lsvFood);
            this.grpRight.Location = new System.Drawing.Point(464, 0);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(629, 480);
            this.grpRight.TabIndex = 1;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Danh mục thức ăn";
            // 
            // lsvFood
            // 
            this.lsvFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSTT,
            this.clName,
            this.clUnit,
            this.clPrice,
            this.clFoodCategory,
            this.clNotes});
            this.lsvFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvFood.FullRowSelect = true;
            this.lsvFood.GridLines = true;
            this.lsvFood.HideSelection = false;
            this.lsvFood.Location = new System.Drawing.Point(3, 18);
            this.lsvFood.MultiSelect = false;
            this.lsvFood.Name = "lsvFood";
            this.lsvFood.Size = new System.Drawing.Size(623, 459);
            this.lsvFood.TabIndex = 0;
            this.lsvFood.UseCompatibleStateImageBehavior = false;
            this.lsvFood.View = System.Windows.Forms.View.Details;
            this.lsvFood.Click += new System.EventHandler(this.lsvFood_Click);
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            // 
            // clName
            // 
            this.clName.Text = "Tên thực phẩm";
            this.clName.Width = 118;
            // 
            // clUnit
            // 
            this.clUnit.Text = "ĐVT";
            // 
            // clPrice
            // 
            this.clPrice.Text = "Giá";
            this.clPrice.Width = 75;
            // 
            // clFoodCategory
            // 
            this.clFoodCategory.Text = "Loại thực phẩm";
            this.clFoodCategory.Width = 132;
            // 
            // clNotes
            // 
            this.clNotes.Text = "Notes";
            this.clNotes.Width = 228;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(989, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistic.Location = new System.Drawing.Point(473, 503);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(77, 20);
            this.lblStatistic.TabIndex = 14;
            this.lblStatistic.Text = "Thống kê";
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 546);
            this.Controls.Add(this.lblStatistic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Name = "frmFood";
            this.Text = "THÊM-XÓA-SỬA BẢNG FOOD";
            this.Load += new System.EventHandler(this.frmFood_Load);
            this.grpLeft.ResumeLayout(false);
            this.grpLeft.PerformLayout();
            this.grpRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListView lsvFood;
        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clUnit;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.ColumnHeader clFoodCategory;
        private System.Windows.Forms.ColumnHeader clNotes;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStatistic;
    }
}

