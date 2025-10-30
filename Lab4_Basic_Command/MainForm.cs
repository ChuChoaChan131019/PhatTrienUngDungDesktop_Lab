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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region phương thức
        private void LoadTables()
        {
            flpTables.Controls.Clear();
            btnTable.Visible = false;
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"
            select ID, Name, Status, Capacity
            from [Table]
            where IsDeleted = 0 
            order by Name";
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                int id = Convert.ToInt32(row["ID"]);
                string name = row["Name"]?.ToString();
                string status = row["Status"]?.ToString() == "0" ? "Trống" : "Có khách";
                string capacity = row["Capacity"]?.ToString();
                Button btn = new Button();
                btn.Size = btnTable.Size;
                btn.BackColor = btnTable.BackColor;
                btn.ForeColor = btnTable.ForeColor;
                btn.Font = btnTable.Font;
                btn.Text = $"Bàn {name} \n{status} \nSố chỗ: {capacity}  ";
                btn.Tag = row["ID"];
                btn.ImageAlign = btnTable.ImageAlign;
                btn.TextAlign = btnTable.TextAlign;
                btn.FlatStyle = FlatStyle.Flat;//nút phẳng
                btn.UseVisualStyleBackColor = false;//bỏ màu mặc định của window
                btn.Image = (status == "Trống") ? Properties.Resources.table_black_ : Properties.Resources.table_color_;

                btn.ContextMenuStrip = btnTable.ContextMenuStrip;

                flpTables.Controls.Add(btn);
                btn.Click += btnTable_Click;

            }
            conn.Close();
            conn.Dispose();

        }


        private void DeleteOrHideTable(int tableId)
        {
            string cs = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            using (var conn = new SqlConnection(cs))
            {
                conn.Open();
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Bills WHERE TableID=@id AND Status=0", conn))
                {
                    cmd.Parameters.AddWithValue("@id", tableId);
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Bàn đang có hóa đơn chưa thanh toán. Không thể xóa!",
                                        "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                bool hasHistory;
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Bills WHERE TableID=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", tableId);
                    hasHistory = (int)cmd.ExecuteScalar() > 0;
                }

                if (hasHistory)
                {
                    using (var cmd = new SqlCommand(
                        "UPDATE [Table] SET IsDeleted = 1 WHERE ID=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", tableId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Bàn đã có lịch sử (đã ẩn bàn).",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    using (var cmd = new SqlCommand(
                        "DELETE FROM [Table] WHERE ID=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", tableId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Đã xóa bàn.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadTables();
        }


        #endregion


        #region event
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int tableId = Convert.ToInt32(btn.Tag);
            string tableName = (btn.Text ?? "").Split('\n')[0];

            var f = new CurrentBillForm
            {
                TableID = tableId,
                TableName = tableName
            };
            f.ShowDialog(this);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f = new TableForm();
            f.ShowDialog(this);
            LoadTables();
        }

        private void tsmUpdate_Click(object sender, EventArgs e)
        {
            var btn = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl as Button;
            if (btn == null) return;

            int id = Convert.ToInt32(btn.Tag);
            string name = "";
            int capacity = 0;
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select Name, Capacity from [Table] where ID=@id";
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                name = reader["Name"].ToString();
                capacity = Convert.ToInt32(reader["Capacity"]);
            }
            var f = new TableForm();
            f.FillTextBox(id, name, capacity);
            LoadTables();
        }
        #endregion

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            var cms = (sender as ToolStripItem)?.Owner as ContextMenuStrip;
            var btn = cms?.SourceControl as Button;
            if (btn?.Tag == null) return;

            if (!int.TryParse(btn.Tag.ToString(), out int tableId)) return;

            if (MessageBox.Show($"Xóa/Ẩn bàn ID = {tableId}?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                DeleteOrHideTable(tableId); 
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmViewInvoiceList_Click(object sender, EventArgs e)
        {
            var btn = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl as Button;
            if (btn == null) return;

            int id = Convert.ToInt32(btn.Tag);
            var frm = new InvoiceListForm
            {
                id = id   
            };
            frm.ShowDialog(this);
        }

        private void tsmHistory_Click(object sender, EventArgs e)
        {
            var btn = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl as Button;
            if (btn == null) return;

            int id = Convert.ToInt32(btn.Tag);
            var frm = new HistoryForm
            {
                id = id
            };
            frm.ShowDialog(this);
        }

        private void tsmAccount_Click(object sender, EventArgs e)
        {
            var frm = new AccountManagerForm();
            frm.ShowDialog(this);
        }


        private void tsmCategory_Click(object sender, EventArgs e)
        {
            var frm = new CategoryForm();
            frm.ShowDialog(this);
        }

        private void tsmBills_Click(object sender, EventArgs e)
        {
            var frm = new BillsFrom();
            frm.ShowDialog(this);
        }
    }
}
