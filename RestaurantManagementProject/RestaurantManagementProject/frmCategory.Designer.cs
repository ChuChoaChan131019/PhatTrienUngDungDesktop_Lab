namespace RestaurantManagementProject
{
    partial class frmCategory
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
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.clType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtName = new System.Windows.Forms.TextBox();
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.lsvCategory = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.grpRight.SuspendLayout();
            this.grpLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(341, 492);
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
            this.btnUpdate.Location = new System.Drawing.Point(234, 492);
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
            this.btnAdd.Location = new System.Drawing.Point(127, 492);
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
            this.btnClear.Location = new System.Drawing.Point(14, 492);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 41);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(184, 133);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(258, 28);
            this.cbType.TabIndex = 8;
            // 
            // clType
            // 
            this.clType.Text = "Loại";
            this.clType.Width = 89;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(184, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 27);
            this.txtName.TabIndex = 5;
            // 
            // clName
            // 
            this.clName.Text = "Tên thực phẩm";
            this.clName.Width = 131;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Loại ";
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatistic.Location = new System.Drawing.Point(475, 503);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(77, 20);
            this.lblStatistic.TabIndex = 18;
            this.lblStatistic.Text = "Thống kê";
            // 
            // grpRight
            // 
            this.grpRight.Controls.Add(this.lsvCategory);
            this.grpRight.Location = new System.Drawing.Point(466, 0);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(348, 480);
            this.grpRight.TabIndex = 16;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Danh mục loại thức ăn";
            // 
            // lsvCategory
            // 
            this.lsvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSTT,
            this.clName,
            this.clType});
            this.lsvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvCategory.FullRowSelect = true;
            this.lsvCategory.GridLines = true;
            this.lsvCategory.HideSelection = false;
            this.lsvCategory.Location = new System.Drawing.Point(3, 18);
            this.lsvCategory.MultiSelect = false;
            this.lsvCategory.Name = "lsvCategory";
            this.lsvCategory.Size = new System.Drawing.Size(342, 459);
            this.lsvCategory.TabIndex = 0;
            this.lsvCategory.UseCompatibleStateImageBehavior = false;
            this.lsvCategory.View = System.Windows.Forms.View.Details;
            this.lsvCategory.Click += new System.EventHandler(this.lsvCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại thực phẩm";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(606, 493);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 41);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.btnDelete);
            this.grpLeft.Controls.Add(this.btnUpdate);
            this.grpLeft.Controls.Add(this.btnAdd);
            this.grpLeft.Controls.Add(this.btnClear);
            this.grpLeft.Controls.Add(this.cbType);
            this.grpLeft.Controls.Add(this.txtName);
            this.grpLeft.Controls.Add(this.label4);
            this.grpLeft.Controls.Add(this.label1);
            this.grpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpLeft.Location = new System.Drawing.Point(0, 0);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(458, 545);
            this.grpLeft.TabIndex = 15;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Chức năng";
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 545);
            this.Controls.Add(this.lblStatistic);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpLeft);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.grpRight.ResumeLayout(false);
            this.grpLeft.ResumeLayout(false);
            this.grpLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ColumnHeader clType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.ListView lsvCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpLeft;
    }
}