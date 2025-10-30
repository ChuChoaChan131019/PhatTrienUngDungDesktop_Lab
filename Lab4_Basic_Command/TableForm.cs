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
    public partial class TableForm : Form
    {
        public bool IsEditMode { get; set; } = false;
        public int EditingTableId { get; set; } = 0;
        public TableForm()
        {
            InitializeComponent();
        }

         private void AddTable()
        {
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO [Table] (Name, Status, Capacity) VALUES (@name, 0, @capacity)";
            cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@capacity", txtCapacity.Text);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();


            if (rows > 0) MessageBox.Show("Thêm bàn thành công!");
            conn.Close();
            
        }

        private void UpdateTabble()
        {
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "update [Table] set Name=@name,Capacity=@capacity where ID=@id ";
            cmd.Parameters.AddWithValue("@id", EditingTableId);
            cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
            cmd.Parameters.AddWithValue("@capacity", int.Parse(txtCapacity.Text.Trim()));
            conn.Open();
            int rows = cmd.ExecuteNonQuery();

            if (rows > 0) MessageBox.Show("Cập nhật bàn thành công!");
            conn.Close();
        }

        public void FillTextBox(int id, string name, int capacity)
        {
            txtID.Text = id.ToString();
            txtName.Text = name.ToString();
            txtCapacity.Text = capacity.ToString();
            IsEditMode = true;
            EditingTableId = id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || !int.TryParse(txtCapacity.Text, out _))
            {
                MessageBox.Show("Tên bàn và chỗ ngồi không hợp lệ!");
                return;
            }

            if (IsEditMode)
                UpdateTabble();
            else AddTable();
        }
    }
}
