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
    public partial class OrderDetailsForm : Form
    {
        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        public void LoadDetail(int BillID)
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            lblTieuDe.Text = lblTieuDe.Text + " có mã " + BillID;
            cmd.CommandText = "exec GetBillByID @id";
            cmd.Parameters.Add("@id",SqlDbType.Int);
            cmd.Parameters["@id"].Value = BillID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvBillDetails.DataSource = dt;
            conn.Close();

        }
    }
}
