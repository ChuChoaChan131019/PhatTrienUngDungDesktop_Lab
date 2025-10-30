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
    public partial class InvoiceListForm : Form
    {
        public int id {  get; set; }
        public InvoiceListForm()
        {
            InitializeComponent();
        }


        private void LoadDates(int id)
        {
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select distinct cast(CheckoutDate as Date) as Ngay from Bills where TableID= @id order by Ngay desc ";
            cmd.Parameters.AddWithValue("@id",id);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            lbNgayLapHD.Items.Clear();
            while (reader.Read())
            {
                lbNgayLapHD.Items.Add(Convert.ToDateTime(reader["Ngay"]).ToString("dd/MM/yyyy"));

            }
            this.Text = "Các hóa đơn của bàn có id =" + id;
        }

        private void InvoiceListForm_Load(object sender, EventArgs e)
        {

            LoadDates(id);
        }

        private void lbNgayLapHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNgayLapHD.SelectedItem == null) return;
            if (!DateTime.TryParseExact(
                    lbNgayLapHD.SelectedItem.ToString(),
                    "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out var selectedDate))
            {
                return;
            }

            GetBillDetailsByDate(id, selectedDate.Date);
            if (dgvBillDetails.Columns["Price"] != null)
                dgvBillDetails.Columns["Price"].DefaultCellStyle.Format = "n0";
        }
        private void GetBillDetailsByDate(int tableID, DateTime date)
        {
            string connect = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select  bd.FoodID,f.Name,Unit,Price,c.Name,Quantity
                            from Food f, BillDetails bd,Bills b, [Table] t,Category c
                            where f.FoodCategoryID=c.ID and bd.InvoiceID=b.ID and bd.FoodID=f.ID and t.ID = b.TableID 
                            and b.TableID=@tableID 
                            and cast (b.CheckoutDate as date) =@Date";
            cmd.Parameters.AddWithValue("@tableID",tableID);
            cmd.Parameters.AddWithValue("@date",date);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvBillDetails.DataSource = dt;
            conn.Close();
            conn.Dispose();
        }
    }
}
