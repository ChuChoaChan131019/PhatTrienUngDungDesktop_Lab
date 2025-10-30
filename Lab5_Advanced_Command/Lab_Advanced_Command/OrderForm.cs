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
    public partial class OrderForm : Form
    {
        private DataTable orderTable;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadBill();
            TinhTong(orderTable);
        }
        private void LoadBill()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select ID,TableID,Amount,Discount,Tax,CheckoutDate, 
                                        (Amount+Tax*Amount-Discount*Amount) as ThucThu from Bills";
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            orderTable = new DataTable();
            adapter.Fill(orderTable);
            dgvBills.DataSource = orderTable;
            conn.Close();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "execute GetBillByDateRange @DateStart,@DateEnd";
            cmd.Parameters.Add("@DateStart", SqlDbType.DateTime);
            cmd.Parameters.Add("@DateEnd", SqlDbType.DateTime);
            cmd.Parameters["@DateStart"].Value=dtpNgayStart.Value.Date;
            cmd.Parameters["@DateEnd"].Value=dtpNgayEnd.Value.Date.AddDays(1);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            orderTable = new DataTable(); 
            adapter.Fill(orderTable);
            dgvBills.DataSource = orderTable;

        }
        private void TinhTong(DataTable table)
        {
            decimal sumAmount = 0;
            decimal sumDis = 0;
            decimal sumThucThu = 0;
            foreach (DataRow row in table.Rows)
            {
                decimal amount = Convert.ToDecimal(row["Amount"]);
                decimal dis = Convert.ToDecimal(row["Discount"]) * amount;
                decimal thucThu = Convert.ToDecimal(row["ThucThu"]);
                sumAmount += amount;
                sumDis += dis;
                sumThucThu += thucThu;
            }
            lblSumAmount.Text = sumAmount.ToString("N0");
            lblSumDis.Text = sumDis.ToString("N0");
            lblSumThucThu.Text = sumThucThu.ToString("N0");
        }

        private void dgvBills_DoubleClick(object sender, EventArgs e)
        {
            var cellValue = dgvBills.CurrentRow.Cells["clID"].Value;
            int billId = Convert.ToInt32(cellValue);
            OrderDetailsForm frm = new OrderDetailsForm();
            frm.LoadDetail(billId);
            frm.ShowDialog();
        }
    }
}
