namespace Lab4_Basic_Command
{
    partial class AccountManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.cbActived = new System.Windows.Forms.ComboBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.clFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNameAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clActived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmListRole = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.checkbActived = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxLoc = new System.Windows.Forms.GroupBox();
            this.clbRole = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBoxLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(205, 25);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(133, 24);
            this.cbRole.TabIndex = 2;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.cbRole_SelectedIndexChanged);
            // 
            // cbActived
            // 
            this.cbActived.FormattingEnabled = true;
            this.cbActived.Items.AddRange(new object[] {
            "Tất cả",
            "Đã kích hoạt",
            "Chưa kích hoạt"});
            this.cbActived.Location = new System.Drawing.Point(576, 25);
            this.cbActived.Margin = new System.Windows.Forms.Padding(4);
            this.cbActived.Name = "cbActived";
            this.cbActived.Size = new System.Drawing.Size(133, 24);
            this.cbActived.TabIndex = 3;
            this.cbActived.SelectedIndexChanged += new System.EventHandler(this.cbActived_SelectedIndexChanged);
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFullName,
            this.clEmail,
            this.clTel,
            this.clDateCreated,
            this.clRole,
            this.clNameAccount,
            this.clPass,
            this.clActived});
            this.dgvAccount.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAccount.Location = new System.Drawing.Point(0, 242);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.Size = new System.Drawing.Size(1067, 312);
            this.dgvAccount.TabIndex = 4;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // clFullName
            // 
            this.clFullName.DataPropertyName = "FullName";
            this.clFullName.HeaderText = "Họ và tên";
            this.clFullName.MinimumWidth = 6;
            this.clFullName.Name = "clFullName";
            this.clFullName.Width = 125;
            // 
            // clEmail
            // 
            this.clEmail.DataPropertyName = "Email";
            this.clEmail.HeaderText = "Email";
            this.clEmail.MinimumWidth = 6;
            this.clEmail.Name = "clEmail";
            this.clEmail.Width = 125;
            // 
            // clTel
            // 
            this.clTel.DataPropertyName = "Tell";
            this.clTel.HeaderText = "SĐT";
            this.clTel.MinimumWidth = 6;
            this.clTel.Name = "clTel";
            this.clTel.Width = 125;
            // 
            // clDateCreated
            // 
            this.clDateCreated.DataPropertyName = "DateCreated";
            this.clDateCreated.HeaderText = "Ngày tạo";
            this.clDateCreated.MinimumWidth = 6;
            this.clDateCreated.Name = "clDateCreated";
            this.clDateCreated.Width = 125;
            // 
            // clRole
            // 
            this.clRole.DataPropertyName = "RoleName";
            this.clRole.HeaderText = "Vai trò";
            this.clRole.MinimumWidth = 6;
            this.clRole.Name = "clRole";
            this.clRole.Width = 125;
            // 
            // clNameAccount
            // 
            this.clNameAccount.DataPropertyName = "AccountName";
            this.clNameAccount.HeaderText = "Tên tài khoản";
            this.clNameAccount.MinimumWidth = 6;
            this.clNameAccount.Name = "clNameAccount";
            this.clNameAccount.Width = 125;
            // 
            // clPass
            // 
            this.clPass.DataPropertyName = "Password";
            this.clPass.HeaderText = "Password";
            this.clPass.MinimumWidth = 6;
            this.clPass.Name = "clPass";
            this.clPass.Width = 125;
            // 
            // clActived
            // 
            this.clActived.DataPropertyName = "Actived";
            this.clActived.HeaderText = "Hoạt động";
            this.clActived.MinimumWidth = 6;
            this.clActived.Name = "clActived";
            this.clActived.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMậtKhẩuToolStripMenuItem,
            this.xóaTàiKhoảnToolStripMenuItem,
            this.tsmListRole});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 76);
            // 
            // resetMậtKhẩuToolStripMenuItem
            // 
            this.resetMậtKhẩuToolStripMenuItem.Name = "resetMậtKhẩuToolStripMenuItem";
            this.resetMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.resetMậtKhẩuToolStripMenuItem.Text = "Reset mật khẩu";
            this.resetMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.resetMậtKhẩuToolStripMenuItem_Click);
            // 
            // xóaTàiKhoảnToolStripMenuItem
            // 
            this.xóaTàiKhoảnToolStripMenuItem.Name = "xóaTàiKhoảnToolStripMenuItem";
            this.xóaTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.xóaTàiKhoảnToolStripMenuItem.Text = "Xóa tài khoản";
            this.xóaTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.xóaTàiKhoảnToolStripMenuItem_Click);
            // 
            // tsmListRole
            // 
            this.tsmListRole.Name = "tsmListRole";
            this.tsmListRole.Size = new System.Drawing.Size(224, 24);
            this.tsmListRole.Text = "Xem danh sách vai trò";
            this.tsmListRole.Click += new System.EventHandler(this.xemDanhSáchVaiTròToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "SĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(654, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vai trò";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(654, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên tài khoản";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(294, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mật khẩu";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(96, 12);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(175, 27);
            this.txtHoTen.TabIndex = 12;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(770, 12);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(175, 27);
            this.txtTenTK.TabIndex = 13;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(411, 63);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(175, 27);
            this.txtPass.TabIndex = 14;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSDT.Location = new System.Drawing.Point(411, 16);
            this.mtxtSDT.Mask = "0000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(175, 27);
            this.mtxtSDT.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(96, 63);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 27);
            this.txtEmail.TabIndex = 16;
            // 
            // checkbActived
            // 
            this.checkbActived.AutoSize = true;
            this.checkbActived.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbActived.Location = new System.Drawing.Point(12, 112);
            this.checkbActived.Name = "checkbActived";
            this.checkbActived.Size = new System.Drawing.Size(127, 24);
            this.checkbActived.TabIndex = 18;
            this.checkbActived.Text = "Kích hoạt TK";
            this.checkbActived.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(357, 112);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxLoc
            // 
            this.groupBoxLoc.Controls.Add(this.label2);
            this.groupBoxLoc.Controls.Add(this.label1);
            this.groupBoxLoc.Controls.Add(this.cbRole);
            this.groupBoxLoc.Controls.Add(this.cbActived);
            this.groupBoxLoc.Location = new System.Drawing.Point(33, 179);
            this.groupBoxLoc.Name = "groupBoxLoc";
            this.groupBoxLoc.Size = new System.Drawing.Size(827, 56);
            this.groupBoxLoc.TabIndex = 21;
            this.groupBoxLoc.TabStop = false;
            this.groupBoxLoc.Text = "Lọc";
            // 
            // clbRole
            // 
            this.clbRole.FormattingEnabled = true;
            this.clbRole.Location = new System.Drawing.Point(769, 68);
            this.clbRole.Name = "clbRole";
            this.clbRole.Size = new System.Drawing.Size(251, 89);
            this.clbRole.TabIndex = 22;
            // 
            // AccountManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.clbRole);
            this.Controls.Add(this.groupBoxLoc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkbActived);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAccount);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountManagerForm";
            this.Text = "AccountManagerForm";
            this.Load += new System.EventHandler(this.AccountManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBoxLoc.ResumeLayout(false);
            this.groupBoxLoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.ComboBox cbActived;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox checkbActived;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxLoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem resetMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmListRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNameAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn clActived;
        private System.Windows.Forms.CheckedListBox clbRole;
    }
}