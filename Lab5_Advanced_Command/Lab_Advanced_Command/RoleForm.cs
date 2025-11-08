using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Advanced_Command
{
    public partial class RoleForm : Form
    {
        public string accountName { get; set; } = string.Empty;
        public RoleForm()
        {
            InitializeComponent();
        }
        private void LoadRoles(string accountName)
        {
            string cs = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = conn.CreateCommand();
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            var dt = new DataTable();

            cmd.CommandText = "exec SelectRolesAccount @accountName";
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value =
            string.IsNullOrWhiteSpace(accountName) ? (object)DBNull.Value : accountName;
            da.Fill(dt);

            clbRoleAccount.BeginUpdate();
            try
            {
                clbRoleAccount.DataSource = null;
                clbRoleAccount.Items.Clear();

                clbRoleAccount.DataSource = dt;
                clbRoleAccount.DisplayMember = "RoleName";
                clbRoleAccount.ValueMember = "ID";
                clbRoleAccount.CheckOnClick = true; 

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    bool assigned = false;
                    var v = dt.Rows[i]["Assigned"];
                    if (v != DBNull.Value) assigned = Convert.ToBoolean(v);
                    clbRoleAccount.SetItemChecked(i, assigned);
                }
            }
            finally
            {
                clbRoleAccount.EndUpdate();
            }
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            LoadRoles(accountName);
        }
        private List<int> GetSelectedRoles(CheckedListBox checklist)
        {
            var ids = new List<int>();
            foreach (var item in checklist.CheckedItems)
            {
                var row = item as DataRowView;
                if (row == null) continue;
                if (row["ID"] == DBNull.Value) continue;
                ids.Add(Convert.ToInt32(row["ID"]));
            }
            return ids;
        }
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var frm = new RoleInfoForm();
            frm.ShowDialog();
            LoadRoles(accountName);
        }
       
        
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(accountName))
            {
                MessageBox.Show("Chưa có AccountName.");
                return;
            }
            var selectedIds = GetSelectedRoles(clbRoleAccount);
            var activedIds = selectedIds;
            string cs = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "exec UpdateRoleForAccount @accountName, @selectedRoles, @activedRoles";
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value = accountName;
            cmd.Parameters.Add("@selectedRoles", SqlDbType.NVarChar, -1).Value = string.Join(",", selectedIds);
            cmd.Parameters.Add("@activedRoles", SqlDbType.NVarChar, -1).Value = string.Join(",", activedIds);
            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã lưu vai trò cho tài khoản.");
            LoadRoles(accountName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
