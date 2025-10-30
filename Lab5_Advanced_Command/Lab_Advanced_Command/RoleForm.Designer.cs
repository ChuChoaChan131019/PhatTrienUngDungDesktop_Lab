namespace Lab_Advanced_Command
{
    partial class RoleForm
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
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.clAssigned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clActived = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRole
            // 
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clAssigned,
            this.clID,
            this.clRoleName,
            this.clPath,
            this.clNotes,
            this.clActived});
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRole.Location = new System.Drawing.Point(0, 222);
            this.dgvRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.RowHeadersWidth = 51;
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(888, 295);
            this.dgvRole.TabIndex = 1;
            // 
            // clAssigned
            // 
            this.clAssigned.DataPropertyName = "Assigned";
            this.clAssigned.HeaderText = "Gán";
            this.clAssigned.MinimumWidth = 6;
            this.clAssigned.Name = "clAssigned";
            this.clAssigned.Width = 125;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "Mã vai trò";
            this.clID.MinimumWidth = 6;
            this.clID.Name = "clID";
            this.clID.Width = 125;
            // 
            // clRoleName
            // 
            this.clRoleName.DataPropertyName = "RoleName";
            this.clRoleName.HeaderText = "Vai trò";
            this.clRoleName.MinimumWidth = 6;
            this.clRoleName.Name = "clRoleName";
            this.clRoleName.Width = 125;
            // 
            // clPath
            // 
            this.clPath.DataPropertyName = "Path";
            this.clPath.HeaderText = "Path";
            this.clPath.MinimumWidth = 6;
            this.clPath.Name = "clPath";
            this.clPath.Width = 125;
            // 
            // clNotes
            // 
            this.clNotes.DataPropertyName = "Notes";
            this.clNotes.HeaderText = "Notes";
            this.clNotes.MinimumWidth = 6;
            this.clNotes.Name = "clNotes";
            this.clNotes.Width = 125;
            // 
            // clActived
            // 
            this.clActived.DataPropertyName = "Actived";
            this.clActived.HeaderText = "Hoạt động";
            this.clActived.MinimumWidth = 6;
            this.clActived.Name = "clActived";
            this.clActived.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clActived.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clActived.Width = 125;
            // 
            // btnAddRole
            // 
            this.btnAddRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.Location = new System.Drawing.Point(131, 70);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(141, 32);
            this.btnAddRole.TabIndex = 2;
            this.btnAddRole.Text = "Add Role";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(324, 70);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(553, 70);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 517);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddRole);
            this.Controls.Add(this.dgvRole);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoleForm";
            this.Text = "RoleForm";
            this.Load += new System.EventHandler(this.RoleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clAssigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNotes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clActived;
    }
}