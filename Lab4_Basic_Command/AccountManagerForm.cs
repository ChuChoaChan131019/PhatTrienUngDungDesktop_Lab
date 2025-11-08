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
    public partial class AccountManagerForm : Form
    {
        public AccountManagerForm()
        {
            InitializeComponent();
        }

        private void AccountManagerForm_Load(object sender, EventArgs e)
        {
            LoadRoles(clbRole);
            LoadActived();
            ApplyFilter();
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
        private void LoadRoles(CheckedListBox checkedList)
        {
            string connectString= ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection=new SqlConnection(connectString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "select ID,RoleName from Role";
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt= new DataTable();
            adapter.Fill(dt);
            checkedList.BeginUpdate();
            checkedList.DataSource = null;
            checkedList.DataSource = dt;
            checkedList.DisplayMember = "RoleName";
            checkedList.ValueMember = "ID";
            checkedList.CheckOnClick = false;
            checkedList.EndUpdate();
        }
        private void LoadActived()
        {
            var list = new[]
            {
                new {Text="Tất cả",Value=(bool?)null},
                new {Text="Đã kích hoạt",Value=(bool?)true},
                new {Text="Chưa kích hoạt",Value=(bool?)false},
            };
            cbActived.DisplayMember = "Text";
            cbActived.ValueMember = "Value";
            cbActived.DataSource = list;
        }
        private void LoadAccountByFilter(int? roleID,bool? actived)
        {
            string connectString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection=new SqlConnection(connectString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"select a.AccountName,Password,FullName,Email,Tell,DateCreated,RoleName, iif(c.Actived=1,N'Đã kích hoạt',N'Chưa kích hoạt') as Actived
                                    from Account a,Role b,RoleAccount c 
                                    where a.AccountName=c.AccountName 
                                            and b.ID=c.RoleID
                                            and (@roleId IS NULL OR c.RoleID = @roleId)
                                            and (@actived IS NULL OR c.Actived = @actived)
                                    order by FullName";
            sqlCommand.Parameters.Add("@roleId", SqlDbType.Int).Value = (object)roleID ?? DBNull.Value;
            sqlCommand.Parameters.Add("@actived", SqlDbType.Bit).Value = (object)actived ?? DBNull.Value;
            SqlDataAdapter adapter= new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvAccount.DataSource = dt;
        }
        private void ApplyFilter()
        {
            int? roleID = null;
            bool? actived = null;
            if(cbRole.SelectedValue != null && cbRole.SelectedValue!=DBNull.Value)
                roleID=(int?)cbRole.SelectedValue;
            if (cbActived.SelectedValue != null && cbActived.SelectedValue != DBNull.Value)
                actived = (bool?)cbActived.SelectedValue;
            LoadAccountByFilter(roleID,actived);

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbActived_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ThemAccount()
        {
            string connectString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectString);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = $@"
       insert into Account (AccountName, [Password], FullName, Email, Tell, DateCreated)
        values (N'{txtTenTK.Text}', N'{txtPass.Text}', N'{txtHoTen.Text}', 
                N'{txtEmail.Text}', N'{mtxtSDT.Text}', GETDATE());";
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

            foreach (DataRowView it in clbRole.CheckedItems)
            {
                int roleId = Convert.ToInt32(it["ID"]);   // clbRole đã bind ValueMember = ID:contentReference[oaicite:0]{index=0}
                using (var cmdRole = sqlConnection.CreateCommand())
                {
                    cmdRole.CommandText = $@"
                        insert into RoleAccount (RoleID, AccountName, Actived)
                        values ({roleId}, N'{txtTenTK.Text.Replace("'", "''")}', {(checkbActived.Checked ? 1 : 0)});";
                    cmdRole.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();
            MessageBox.Show("Thêm tài khoản thành công!");
            ApplyFilter();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string acc = txtTenTK.Text.Trim();
            if (string.IsNullOrWhiteSpace(acc))
            {
                MessageBox.Show("Nhập tên tài khoản trước khi lưu!");
                return;
            }
            if (AccountExists(acc)) 
                UpdateAccount();
            else                    
                ThemAccount();
            XoaTrang();
        }
        private void CheckRolesForAccount(string accountName)
        {
            for (int i = 0; i < clbRole.Items.Count; i++)
                clbRole.SetItemChecked(i, false);

            string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var ids = new HashSet<int>();
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = $"SELECT RoleID FROM RoleAccount WHERE AccountName = N'{txtTenTK.Text.Replace("'", "''")}';";
                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                        ids.Add(rd.GetInt32(0));
                }
            }

            for (int i = 0; i < clbRole.Items.Count; i++)
            {
                var drv = clbRole.Items[i] as DataRowView;   
                if (drv != null && ids.Contains(Convert.ToInt32(drv["ID"])))
                    clbRole.SetItemChecked(i, true);
            }
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return; 

            var row = dgvAccount.Rows[e.RowIndex];
            txtTenTK.Text = row.Cells["clNameAccount"].Value?.ToString();
            txtHoTen.Text = row.Cells["clFullName"].Value?.ToString();
            txtEmail.Text = row.Cells["clEmail"].Value?.ToString();
            mtxtSDT.Text = row.Cells["clTel"].Value?.ToString();
            txtPass.Text = row.Cells["clPass"].Value?.ToString();
            string roleName = row.Cells["clRole"].Value?.ToString();
            CheckRolesForAccount(txtTenTK.Text?.Trim());
            string actText = row.Cells["clActived"].Value?.ToString();
            checkbActived.Checked = actText != null &&
                                    (actText.Equals("Đã kích hoạt", StringComparison.OrdinalIgnoreCase));
        }
        private void SetComboByRoleName(ComboBox combo, string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName) || combo.DataSource == null)
            {
                combo.SelectedIndex = -1;
                return;
            }

            if (combo.DataSource is DataTable dt)
            {
                var found = dt.AsEnumerable()
                              .FirstOrDefault(r => string.Equals(
                                  r.Field<string>("RoleName") ?? "",
                                  roleName,
                                  StringComparison.OrdinalIgnoreCase));

                if (found != null)
                    combo.SelectedValue = found.Field<int>("ID");
                else
                    combo.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < combo.Items.Count; i++)
                {
                    var item = combo.Items[i];
                    var text = combo.GetItemText(item);
                    if (string.Equals(text, roleName, StringComparison.OrdinalIgnoreCase))
                    {
                        combo.SelectedIndex = i;
                        return;
                    }
                }
                combo.SelectedIndex = -1;
            }

        }
        private bool AccountExists(string acc)
        {
            string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(1) FROM Account WHERE AccountName=@acc";
                cmd.Parameters.Add("@acc", SqlDbType.NVarChar, 100).Value = acc;
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
        private void UpdateAccount()
        {
            string connectString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = $@"update Account
                                set [Password] = N'{txtPass.Text}', FullName = N'{txtHoTen.Text}',Email = N'{txtEmail.Text}',Tell= N'{mtxtSDT.Text}'
                                where AccountName = N'{txtTenTK.Text}'";
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();

            using (var cmdDel = sqlConnection.CreateCommand())
            {
                cmdDel.CommandText =
                    $"delete from RoleAccount where AccountName = N'{txtTenTK.Text.Replace("'", "''")}';";
                cmdDel.ExecuteNonQuery();
            }

            foreach (DataRowView it in clbRole.CheckedItems)
            {
                int roleId = Convert.ToInt32(it["ID"]);
                using (var cmdIns = sqlConnection.CreateCommand())
                {
                    cmdIns.CommandText = $@"
                                    insert into RoleAccount (RoleID, AccountName, Actived)
                                    values ({roleId}, N'{txtTenTK.Text.Replace("'", "''")}', {(checkbActived.Checked ? 1 : 0)});";
                    cmdIns.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();

            MessageBox.Show("Cập nhật tài khoản thành công!");
            ApplyFilter();
        }
        private void ResetPasswordToDefault(string accountName)
        {
            if (string.IsNullOrWhiteSpace(accountName))
            {
                MessageBox.Show("Chưa chọn tài khoản!");
                return;
            }

            string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (var conn = new SqlConnection(cs))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"UPDATE Account SET [Password] = @pwd WHERE AccountName = @acc;";
                cmd.Parameters.Add("@pwd", SqlDbType.NVarChar, 200).Value = "123456"; 
                cmd.Parameters.Add("@acc", SqlDbType.NVarChar, 100).Value = accountName;
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Đã reset mật khẩu về 123456.");
                else
                    MessageBox.Show("Không tìm thấy tài khoản.");
            }
        }

        private void resetMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetPasswordToDefault(txtTenTK.Text.Trim());
            ApplyFilter();
        }
        private void DeleteAccount(string accountName)
        {
            if (string.IsNullOrWhiteSpace(accountName))
            {
                MessageBox.Show("Chưa chọn tài khoản!");
                return;
            }

            string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (var conn = new SqlConnection(cs))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                using (var cmd = conn.CreateCommand())
                {
                    cmd.Transaction = tran;
                    cmd.CommandText = @"UPDATE RoleAccount
                                        SET Actived = 0
                                        WHERE AccountName = @acc;";

                    cmd.Parameters.Add("@acc", SqlDbType.NVarChar, 100).Value = accountName.Trim();

                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        tran.Commit();
                        MessageBox.Show("Đã tắt toàn bộ vai trò.");
                        ApplyFilter(); 
                    }
                    catch (SqlException ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Lỗi SQL: " + ex.Message);
                    }
                }
            }
        }

        private void xóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string acc = txtTenTK.Text.Trim();
            if (MessageBox.Show($"Tất cả vai trò của tài khoản '{acc}'sẽ bị tắt.","Xác nhận") == DialogResult.OK)
            {
                DeleteAccount(acc);
                XoaTrang();
            }
        }

        private void xemDanhSáchVaiTròToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string acc = txtTenTK.Text.Trim() ;
            var frm = new RoleForm
            {
                accName = acc
            };
            frm.ShowDialog();
        }
    }
}
