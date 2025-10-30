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
    public partial class RoleInfoForm : Form
    {
        public RoleInfoForm()
        {
            InitializeComponent();
        }
        private void AddRole()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "exec InsertRole @id,@roleName,@path,@notes";
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters.Add("@roleName", SqlDbType.NVarChar);
            cmd.Parameters.Add("@path", SqlDbType.NVarChar);
            cmd.Parameters.Add("@notes", SqlDbType.NVarChar);
            cmd.Parameters["@id"].Direction = ParameterDirection.Output;
            cmd.Parameters["@roleName"].Value=txtName.Text;
            cmd.Parameters["@path"].Value=txtPath.Text;
            cmd.Parameters["@notes"].Value=txtNotes.Text;
            conn.Open();
            var row=cmd.ExecuteNonQuery();
            if (row > 0)
            {
                string roleName = cmd.Parameters["@roleName"].Value.ToString();
                MessageBox.Show($"Đã thêm vai trò {roleName} ");
            }
            else
                MessageBox.Show("Thêm thất bại");


        }

       
        private void btmSave_Click(object sender, EventArgs e)
        {
            AddRole();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
