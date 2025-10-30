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

namespace Lab4_Basic_Command
{
    public partial class RoleForm : Form
    {
        public string accName {  get; set; }
        public RoleForm()
        {
            InitializeComponent();
        }
        private void LoadRole(string accountName)
        {
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
                                select ID,RoleName,Actived,Path,a.Notes 
                                from  Role a, RoleAccount b
                                where ID=RoleID and AccountName=@accountName";
            cmd.Parameters.AddWithValue("@accountName", accountName);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvRole.DataSource = dt;
            conn.Close();
            conn.Dispose();
            lblHeader.Text = $"Vai trò của tài khoản {accountName}";

        }

        private void RoleForm_Load(object sender, EventArgs e)
        {
            LoadRole(accName);
        }
    }
}
