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
    public partial class BillsFrom : Form
    {
        public BillsFrom()
        {
            InitializeComponent();
        }
        private void LoadBill()
        {
            string Connectsring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(Connectsring);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"select ID,TableID,Amount,Discount,Tax,CheckoutDate, 
                                        (Amount+Tax*Amount-Discount*Amount) as ThucThu from Bills";
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvBills.DataSource = table;
            sqlConnection.Close();
        }
        private void BillsFrom_Load(object sender, EventArgs e)
        {
            LoadBill();

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string ConnectString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @" select ID,TableID,Amount,Discount,Tax,CheckoutDate,(Amount+Tax*Amount-Discount*Amount) as ThucThu 
                                        from Bills
                                        where CheckoutDate>= @start and CheckoutDate<=@end";
            sqlCommand.Parameters.AddWithValue("@start",dtpNgayStart.Value.Date);
            sqlCommand.Parameters.AddWithValue("@end",dtpNgayEnd.Value.Date.AddDays(1));
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvBills.DataSource= table;
            sqlConnection.Close();
            TinhTong(table);
        }
        private void TinhTong(DataTable table)
        {
            decimal sumAmount = 0;
            decimal sumDis = 0;
            decimal sumThucThu = 0;
            foreach(DataRow row in table.Rows)
            {
                decimal amount = Convert.ToDecimal(row["Amount"]);
                decimal dis = Convert.ToDecimal(row["Discount"])*amount;
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
            BillDetailsForm frm = new BillDetailsForm();
            frm.LoadDetail(billId);
            frm.ShowDialog();
        }
       
    }
}
