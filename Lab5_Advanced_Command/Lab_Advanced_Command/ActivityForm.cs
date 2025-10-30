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
    public partial class ActivityForm : Form
    {
        public string AccountName { get; set; }

        public ActivityForm()
        {
            InitializeComponent();
        }
        private void LoadDates()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "exec GetDateByAccount @accountName";
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 1000).Value = AccountName;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            lbNgayLapHD.Items.Clear();
            while (reader.Read())
            {
                lbNgayLapHD.Items.Add(Convert.ToDateTime(reader["Ngay"]).ToString("dd/MM/yyyy"));
            
            }
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Nhật ký hoạt động của tài khoản: {AccountName}";
            LoadDates();
        }

        private void lbNgayLapHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNgayLapHD.SelectedItem == null) return;

            string selectedDate = lbNgayLapHD.SelectedItem.ToString();
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "exec GetDetailsByAccountDate @accountName, @date";
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 1000).Value = AccountName;
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.ParseExact(selectedDate, "dd/MM/yyyy", null); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvBillDetails.DataSource = dt;
            lblSoLuong.Text = $"{dt.AsEnumerable().Select(r => r["BillID"]).Distinct().Count()}";
            lblTongTien.Text = $"{dt.AsEnumerable().Sum(r => Convert.ToDecimal(r["TongTienHD"])):N0} đ";

        }
    }
}
