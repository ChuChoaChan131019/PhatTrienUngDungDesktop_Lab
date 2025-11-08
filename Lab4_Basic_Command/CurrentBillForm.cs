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
    public partial class CurrentBillForm : Form
    {
        public int TableID { get; set; }        
        public string TableName { get; set; }
        public CurrentBillForm()
        {
            InitializeComponent();
        }
        private void CurrentBill(int tableID)
        {
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select c.ID,c.Name,b.Quantity, c.Price,(b.Quantity*c.Price)as Total
                            from Bills a,BillDetails b,Food c
                               where a.ID=b.InvoiceID and b.FoodID=c.ID and a.TableID =@tableid and a.Status=0 ";
            cmd.Parameters.AddWithValue("@tableid", tableID);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCurrentBill.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"Bàn mã {tableID} hiện chưa có hóa đơn nào đang mở.");
                this.Close();
            }
            conn.Close();
            dgvCurrentBill.AutoGenerateColumns = false;
        }

        

        private void CurrentBillForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Hóa đơn {TableName}";
            label1.Text = $"Hóa đơn {TableName} (ID: {TableID})";
            CurrentBill(TableID);
        }
    }
}
