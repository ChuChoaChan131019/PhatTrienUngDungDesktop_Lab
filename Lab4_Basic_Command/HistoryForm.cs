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
    public partial class HistoryForm : Form
    {
        public int id {  get; set; }
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void LoadHistory(int id)
        {
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select a.ID, Amount,Discount,Tax,CheckoutDate,FullName, (Amount-Discount*Amount+Tax*Amount) as TongCong
                                from Bills a, Account b
                                where a.Account=b.AccountName and TableID =@id ";
            cmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHistory.DataSource = dt;
            conn.Close();
            conn.Dispose();
            lblSoLuong.Text = $"{dt.AsEnumerable().Select(r => r["ID"]).Distinct().Count()}";
            lblSum.Text = $"{dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["TongCong"])):N0} đ";
            lblTax.Text = $"{dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["Amount"]) * Convert.ToDecimal(r["Tax"])):N0} đ";
            lblDis.Text = $"{dt.AsEnumerable().Sum(r =>Convert.ToDecimal(r["Amount"]) * Convert.ToDecimal(r["Discount"])):N0} đ";
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            LoadHistory(id);
            

        }
    }
}
