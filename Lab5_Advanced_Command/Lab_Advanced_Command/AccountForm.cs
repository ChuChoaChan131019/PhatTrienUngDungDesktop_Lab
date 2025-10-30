using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab_Advanced_Command
{
    public partial class AccountForm : Form
    {
        private string oldAccountName = null;

        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            LoadRoles(cbRole,true);
            LoadAccount();
            XoaTrang();

        }
        private void LoadRoles(ComboBox combo, bool allRole = true)
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ID,RoleName from Role";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (allRole)
            {
                var all = dt.NewRow();
                all["ID"] = DBNull.Value;
                all["RoleName"] = "Tất cả";
                dt.Rows.InsertAt(all, 0);
            }
            combo.DisplayMember = "RoleName";
            combo.ValueMember = "ID";
            combo.DataSource = dt;
        }
        private void LoadAccount()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select a.AccountName,a.[Password],a.FullName,a.Email,a.Tell,a.DateCreated,b.RoleName, iif(c.Actived = 1, N'Đã kích hoạt', N'Chưa kích hoạt') as Actived
                                    from Account a,Role b, RoleAccount c
                                    where a.AccountName = c.AccountName
                                            and b.ID = c.RoleID";
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAccount.DataSource = dt;


        }
        private void AddAcount()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "exec InsertAccount  @accountName , @password,  @fullName, @email,  @tell, @roleID, @actived ";
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 255);
            cmd.Parameters.Add("@fullName", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@roleID", SqlDbType.Int);
            cmd.Parameters.Add("@actived", SqlDbType.Bit);
            cmd.Parameters["@accountName"].Value = txtTenTK.Text.Trim();
            cmd.Parameters["@password"].Value = txtPass.Text.Trim();
            cmd.Parameters["@fullName"].Value = txtHoTen.Text.Trim();
            cmd.Parameters["@email"].Value = txtEmail.Text.Trim();
            cmd.Parameters["@tell"].Value = mtxtSDT.Text.Trim();
            cmd.Parameters["@roleID"].Value = Convert.ToInt32(cbRole.SelectedValue); 
            cmd.Parameters["@actived"].Value = checkbActived.Checked;
            conn.Open();
            var rows = cmd.ExecuteNonQuery();          
            if (rows > 0)
            {
                MessageBox.Show("Thêm tài khoản thành công!");
                LoadAccount();

            }
            else
                MessageBox.Show("Không thêm tài khoản đc.");
            conn.Close();
            conn.Dispose();

        }
       
        public void XoaTrang()
        {
            txtEmail.Clear();
            txtHoTen.Clear();
            txtPass.Clear();
            txtTenTK.Clear();
            mtxtSDT.Clear();
            checkbActived.Checked = false;
        }
      

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccount.CurrentRow == null || dgvAccount.CurrentRow.Index < 0) return;

            var row = dgvAccount.CurrentRow;
            txtHoTen.Text = row.Cells["clFullName"].Value?.ToString();
            txtEmail.Text = row.Cells["clEmail"].Value?.ToString();
            mtxtSDT.Text = row.Cells["clTel"].Value?.ToString();
            txtTenTK.Text = row.Cells["clNameAccount"].Value?.ToString();
            txtPass.Text = row.Cells["clPass"].Value?.ToString();
            checkbActived.Checked = string.Equals(row.Cells["clActived"].Value?.ToString(), "Đã kích hoạt", StringComparison.OrdinalIgnoreCase);
            oldAccountName = txtTenTK.Text;
            cbRole.SelectedIndex = cbRole.FindStringExact(row.Cells["clRole"].Value?.ToString());
        }
        private void UpdateAccount()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "exec UpdateAccount @OldAccountName,@NewAccountName,@Password,@FullName,@Email,@Tell,@RoleID,@Actived";
            cmd.Parameters.Add("@OldAccountName", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@NewAccountName", SqlDbType.NVarChar, 100);
            cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 200);
            cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 1000);
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar, 1000);
            cmd.Parameters.Add("@Tell", SqlDbType.NVarChar, 200);
            cmd.Parameters.Add("@RoleID", SqlDbType.Int);
            cmd.Parameters.Add("@Actived", SqlDbType.Bit);
            cmd.Parameters["@OldAccountName"].Value = oldAccountName; 
            cmd.Parameters["@NewAccountName"].Value = txtTenTK.Text.Trim();
            cmd.Parameters["@Password"].Value = txtPass.Text.Trim();
            cmd.Parameters["@FullName"].Value = txtHoTen.Text.Trim() ;
            cmd.Parameters["@Email"].Value = txtEmail.Text.Trim();   // null → DBNull
            cmd.Parameters["@Tell"].Value =mtxtSDT.Text.Trim();   // null → DBNull
            cmd.Parameters["@RoleID"].Value = Convert.ToInt32(cbRole.SelectedValue);
            cmd.Parameters["@Actived"].Value = checkbActived.Checked;

            try
            {
                conn.Open();
                var rows = cmd.ExecuteNonQuery();
                LoadAccount();

                if (rows !=0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadAccount();
                }
                else MessageBox.Show("Không cập nhật được");
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601 || ex.Number == 50002)
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Chọn tên khác!");
            }
            finally
            {
                conn.Close();
            }


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (oldAccountName != null)
                UpdateAccount();
            else
                AddAcount();
            XoaTrang();
        }
        private void ResetPass()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "exec ResetPass @accountName";
            cmd.Parameters.Add("@accountName",SqlDbType.NVarChar);
            cmd.Parameters["@accountName"].Value=txtTenTK.Text.Trim();
            conn.Open();
            var row=cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Đã reset mật khẩu về 123456");
                LoadAccount();
            }
            else
                MessageBox.Show("Lỗi");
            XoaTrang();
        }

        private void tsmReset_Click(object sender, EventArgs e)
        {
            ResetPass();
        }

        private void tsmViewRole_Click(object sender, EventArgs e)
        {
            if(dgvAccount.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn tài khoản");
                return;
            }
            var frm = new RoleForm();
            frm.accountName = dgvAccount.CurrentRow.Cells["clNameAccount"].Value.ToString();
            frm.ShowDialog();
        }

        private void tsmViewActivity_Click(object sender, EventArgs e)
        {
            if (dgvAccount.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn tài khoản");
                return;
            }
            var frm = new ActivityForm();
            frm.AccountName = dgvAccount.CurrentRow.Cells["clNameAccount"].Value.ToString();
            frm.ShowDialog();
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var role=new RoleInfoForm();
            role.ShowDialog();
            LoadRoles(cbRole,true);
        }
    }
}
