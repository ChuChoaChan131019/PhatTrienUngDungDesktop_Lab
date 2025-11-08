namespace Lab09_Entity_Framework
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
            this.tvwCategory = new System.Windows.Forms.TreeView();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnReloadCategory = new System.Windows.Forms.Button();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.btnReloadFood = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.lvwFood = new System.Windows.Forms.ListView();
            this.clID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUnit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clCateName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwCategory
            // 
            this.tvwCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tvwCategory.Location = new System.Drawing.Point(4, 69);
            this.tvwCategory.Margin = new System.Windows.Forms.Padding(4);
            this.tvwCategory.Name = "tvwCategory";
            this.tvwCategory.Size = new System.Drawing.Size(433, 562);
            this.tvwCategory.TabIndex = 0;
            this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
            this.tvwCategory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwCategory_NodeMouseDoubleClick);
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.btnAddCategory);
            this.grpLeft.Controls.Add(this.btnReloadCategory);
            this.grpLeft.Controls.Add(this.tvwCategory);
            this.grpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpLeft.Location = new System.Drawing.Point(0, 0);
            this.grpLeft.Margin = new System.Windows.Forms.Padding(4);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Padding = new System.Windows.Forms.Padding(4);
            this.grpLeft.Size = new System.Drawing.Size(441, 635);
            this.grpLeft.TabIndex = 1;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Danh mục";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(369, 23);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(64, 33);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddCategory, "Thêm danh mục mới");
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnReloadCategory
            // 
            this.btnReloadCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadCategory.Location = new System.Drawing.Point(297, 23);
            this.btnReloadCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadCategory.Name = "btnReloadCategory";
            this.btnReloadCategory.Size = new System.Drawing.Size(64, 33);
            this.btnReloadCategory.TabIndex = 1;
            this.btnReloadCategory.Text = "R";
            this.toolTip1.SetToolTip(this.btnReloadCategory, "Tải lại danh mục");
            this.btnReloadCategory.UseVisualStyleBackColor = true;
            this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
            // 
            // grpRight
            // 
            this.grpRight.Controls.Add(this.btnReloadFood);
            this.grpRight.Controls.Add(this.btnDelete);
            this.grpRight.Controls.Add(this.btnAddFood);
            this.grpRight.Controls.Add(this.lvwFood);
            this.grpRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpRight.Location = new System.Drawing.Point(450, 0);
            this.grpRight.Margin = new System.Windows.Forms.Padding(4);
            this.grpRight.Name = "grpRight";
            this.grpRight.Padding = new System.Windows.Forms.Padding(4);
            this.grpRight.Size = new System.Drawing.Size(785, 635);
            this.grpRight.TabIndex = 2;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Thực đơn";
            // 
            // btnReloadFood
            // 
            this.btnReloadFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadFood.Location = new System.Drawing.Point(561, 23);
            this.btnReloadFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnReloadFood.Name = "btnReloadFood";
            this.btnReloadFood.Size = new System.Drawing.Size(64, 33);
            this.btnReloadFood.TabIndex = 5;
            this.btnReloadFood.Text = "R";
            this.toolTip1.SetToolTip(this.btnReloadFood, "Tải lại danh sách món");
            this.btnReloadFood.UseVisualStyleBackColor = true;
            this.btnReloadFood.Click += new System.EventHandler(this.btnReloadFood_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(633, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 33);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "-";
            this.toolTip1.SetToolTip(this.btnDelete, "Xóa món ăn được chọn");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(705, 23);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(64, 33);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddFood, "Thêm món ăn mới");
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lvwFood
            // 
            this.lvwFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clID,
            this.clName,
            this.clUnit,
            this.clPrice,
            this.clCateName,
            this.clNotes});
            this.lvwFood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwFood.FullRowSelect = true;
            this.lvwFood.GridLines = true;
            this.lvwFood.HideSelection = false;
            this.lvwFood.Location = new System.Drawing.Point(4, 69);
            this.lvwFood.Margin = new System.Windows.Forms.Padding(4);
            this.lvwFood.MultiSelect = false;
            this.lvwFood.Name = "lvwFood";
            this.lvwFood.Size = new System.Drawing.Size(777, 562);
            this.lvwFood.TabIndex = 0;
            this.lvwFood.UseCompatibleStateImageBehavior = false;
            this.lvwFood.View = System.Windows.Forms.View.Details;
            this.lvwFood.DoubleClick += new System.EventHandler(this.lvwFood_DoubleClick);
            // 
            // clID
            // 
            this.clID.Text = "Mã số";
            // 
            // clName
            // 
            this.clName.Text = "Tên";
            // 
            // clUnit
            // 
            this.clUnit.Text = "Đơn vị tính";
            // 
            // clPrice
            // 
            this.clPrice.Text = "Giá";
            // 
            // clCateName
            // 
            this.clCateName.Text = "Nhóm món ăn";
            // 
            // clNotes
            // 
            this.clNotes.Text = "Notes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 635);
            this.Controls.Add(this.grpRight);
            this.Controls.Add(this.grpLeft);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhà hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpLeft.ResumeLayout(false);
            this.grpRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwCategory;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnReloadCategory;
        private System.Windows.Forms.Button btnReloadFood;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ListView lvwFood;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader clID;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clUnit;
        private System.Windows.Forms.ColumnHeader clPrice;
        private System.Windows.Forms.ColumnHeader clCateName;
        private System.Windows.Forms.ColumnHeader clNotes;
    }
}

