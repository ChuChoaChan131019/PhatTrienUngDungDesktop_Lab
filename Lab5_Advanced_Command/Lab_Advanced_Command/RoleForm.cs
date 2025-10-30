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
        private void LoadRole()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "exec SelectRoleByNameAccount @accountName";
            cmd.Parameters.Add("@accountName",SqlDbType.NVarChar);
            cmd.Parameters["@accountName"].Value = accountName;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvRole.DataSource = dt;
            this.Text = "Vai trò cả tài khoản " + accountName;
            conn.Close();
        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            LoadRole();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var frm = new RoleInfoForm();
            frm.ShowDialog();
            LoadRole();
        }
        private (string selectedCsv, string activeCsv) GetChecckBox(DataGridView dgv)
        {
            var assign = new List<int>();
            var active = new List<int>();
            foreach(DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                bool assigned = Convert.ToBoolean(row.Cells["clAssigned"].Value ?? false);
                bool avtived = Convert.ToBoolean(row.Cells["clActived"].Value ?? false);
                int id = Convert.ToInt32(row.Cells["clID"].Value);

                if (assigned)
                {
                    assign.Add(id);
                    if(avtived)
                        active.Add(id);
                }
            }
            return (string.Join(",", assign), string.Join(",", active));
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn= new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            var (selectedCsv, activeCsv) = GetChecckBox(dgvRole);
            cmd.CommandText = "exec UpdateRoleForAccount @accountName, @selectedRoles,@actived";
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 1000);
            cmd.Parameters.Add("@selectedRoles", SqlDbType.NVarChar, 1000);
            cmd.Parameters.Add("@actived", SqlDbType.NVarChar, 1000);
            cmd.Parameters["@accountName"].Value = accountName;
            cmd.Parameters["@selectedRoles"].Value = (object)selectedCsv ?? DBNull.Value;
            cmd.Parameters["@actived"].Value = (object)activeCsv ?? DBNull.Value;
            conn.Open();
            var row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Cập nhật thành công");
                LoadRole();
            }
            else
                MessageBox.Show("Cập nhật thất bại");
            conn.Close();
            conn.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
