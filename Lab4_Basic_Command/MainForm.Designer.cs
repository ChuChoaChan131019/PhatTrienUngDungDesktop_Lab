namespace Lab4_Basic_Command
{
    partial class MainForm
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
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTable = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewInvoiceList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.qLTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBills = new System.Windows.Forms.ToolStripMenuItem();
            this.flpTables.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTables
            // 
            this.flpTables.AutoScroll = true;
            this.flpTables.Controls.Add(this.btnTable);
            this.flpTables.Location = new System.Drawing.Point(0, 67);
            this.flpTables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(746, 526);
            this.flpTables.TabIndex = 0;
            // 
            // btnTable
            // 
            this.btnTable.ContextMenuStrip = this.contextMenuStrip1;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTable.Location = new System.Drawing.Point(2, 2);
            this.btnTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(122, 147);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "button1";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmUpdate,
            this.tsmDelete,
            this.tsmViewInvoiceList,
            this.tsmHistory});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(203, 92);
            // 
            // tsmUpdate
            // 
            this.tsmUpdate.Name = "tsmUpdate";
            this.tsmUpdate.Size = new System.Drawing.Size(202, 22);
            this.tsmUpdate.Text = "Cập nhật ";
            this.tsmUpdate.Click += new System.EventHandler(this.tsmUpdate_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(202, 22);
            this.tsmDelete.Text = "Xóa";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmViewInvoiceList
            // 
            this.tsmViewInvoiceList.Name = "tsmViewInvoiceList";
            this.tsmViewInvoiceList.Size = new System.Drawing.Size(202, 22);
            this.tsmViewInvoiceList.Text = "Xem danh mục hóa đơn";
            this.tsmViewInvoiceList.Click += new System.EventHandler(this.tsmViewInvoiceList_Click);
            // 
            // tsmHistory
            // 
            this.tsmHistory.Name = "tsmHistory";
            this.tsmHistory.Size = new System.Drawing.Size(202, 22);
            this.tsmHistory.Text = "Xem nhật ký hóa đơn";
            this.tsmHistory.Click += new System.EventHandler(this.tsmHistory_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(766, 67);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách bàn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qLTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // qLTàiKhoảnToolStripMenuItem
            // 
            this.qLTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAccount,
            this.tsmCategory,
            this.tsmBills});
            this.qLTàiKhoảnToolStripMenuItem.Name = "qLTàiKhoảnToolStripMenuItem";
            this.qLTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.qLTàiKhoảnToolStripMenuItem.Text = "Menu";
            // 
            // tsmAccount
            // 
            this.tsmAccount.Name = "tsmAccount";
            this.tsmAccount.Size = new System.Drawing.Size(167, 22);
            this.tsmAccount.Text = "QL tài khoản";
            this.tsmAccount.Click += new System.EventHandler(this.tsmAccount_Click);
            // 
            // tsmCategory
            // 
            this.tsmCategory.Name = "tsmCategory";
            this.tsmCategory.Size = new System.Drawing.Size(167, 22);
            this.tsmCategory.Text = "QL nhóm thức ăn";
            this.tsmCategory.Click += new System.EventHandler(this.tsmCategory_Click);
            // 
            // tsmBills
            // 
            this.tsmBills.Name = "tsmBills";
            this.tsmBills.Size = new System.Drawing.Size(167, 22);
            this.tsmBills.Text = "QL hóa đơn";
            this.tsmBills.Click += new System.EventHandler(this.tsmBills_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 596);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpTables);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flpTables.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdate;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmViewInvoiceList;
        private System.Windows.Forms.ToolStripMenuItem tsmHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem qLTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAccount;
        private System.Windows.Forms.ToolStripMenuItem tsmCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmBills;
    }
}