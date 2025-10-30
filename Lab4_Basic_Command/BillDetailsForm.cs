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
    public partial class BillDetailsForm : Form
    {
        public BillDetailsForm()
        {
            InitializeComponent();
        }
        public void LoadDetail(int BillID)
        {
            string ConnectString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection= new SqlConnection(ConnectString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = @"select InvoiceID from BillDetails where InvoiceId= @id";
            sqlCommand.Parameters.AddWithValue("@id", BillID);
            sqlConnection.Open();
            string billName=sqlCommand.ExecuteScalar().ToString();
            lblTieuDe.Text = lblTieuDe.Text +" có mã "+ billName;
            sqlCommand.CommandText = @"select FoodID,Name,Quantity,Price,(Price*Quantity)as ThanhTien 
                                    from BillDetails a,Food b 
                                    where a.FoodID=b.ID and InvoiceID=" + BillID;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt= new DataTable();
            adapter.Fill(dt);
            dgvBillDetails.DataSource = dt;
            sqlConnection.Close();

        }
    }
}
