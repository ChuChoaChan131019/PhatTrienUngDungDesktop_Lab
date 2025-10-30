using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

namespace Lab_Advanced_Command
{
    public partial class FoodForm : Form
    {
        private DataTable foodTable;
        public FoodForm()
        {
            InitializeComponent();
            dgvFoodList.AutoGenerateColumns = false;
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            

        }
        private void LoadCategory()
        {
            string conn = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(conn);
            SqlCommand cmd= sqlConn.CreateCommand();
            cmd.CommandText = "select ID,Name from Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            sqlConn.Open();
            adapter.Fill(dt);
            sqlConn.Close();
            sqlConn.Dispose();
            DataRow allRow = dt.NewRow();
            allRow["ID"] = 0;
            allRow["Name"] = "Tất cả";
            dt.Rows.InsertAt(allRow, 0);
            cbbCategory.DataSource = dt;
            cbbCategory.DisplayMember = "Name";
            cbbCategory.ValueMember = "ID";

        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCategory.SelectedIndex == -1)
                return;
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn= new SqlConnection(connect);
            SqlCommand cmd= conn.CreateCommand();
            cmd.Parameters.Add("@categoryID", SqlDbType.Int);
            if (cbbCategory.SelectedIndex == 0)
                cmd.CommandText = "select * from Food";
            else
            {
                cmd.CommandText = "select * from Food Where FoodCategoryID=@categoryID";
            }
            
            if(cbbCategory.SelectedValue is DataRowView)
            {
                DataRowView rowview = cbbCategory.SelectedValue as DataRowView;
                cmd.Parameters["@categoryID"].Value = rowview["ID"];
            }
            else
                cmd.Parameters["@categoryID"].Value=cbbCategory.SelectedValue;
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            foodTable= new DataTable();
            adapter.Fill(foodTable);
            conn.Close();
            conn.Dispose();
            dgvFoodList.DataSource = foodTable;
            lblQuantity.Text=foodTable.Rows.Count.ToString();
            lblCatName.Text=cbbCategory.Text;
        }

        private void tsmCalculateQuantity_Click(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd= conn.CreateCommand();
            cmd.CommandText = "select @numSaleFood=isnull(sum(Quantity),0) from BillDetails where FoodID=@foodID";
            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                cmd.Parameters.Add("@foodID", SqlDbType.Int);
                cmd.Parameters["@foodID"].Value = rowView["ID"];
                cmd.Parameters.Add("@numSaleFood", SqlDbType.Int);
                cmd.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;
                conn.Open();
                cmd.ExecuteNonQuery();
                string kq = cmd.Parameters["@numSaleFood"].Value.ToString();
                MessageBox.Show($"Tổng số lượng món {rowView["Name"]} đã bán là {kq} {rowView["Unit"]}",
                                "Thống kê", MessageBoxButtons.OK);
                conn.Close();

            }
            cmd.Dispose();
            conn.Dispose();
        }

        private void tsmAddFood_Click(object sender, EventArgs e)
        {
            FoodInfoForm frm = new FoodInfoForm();
            frm.FormClosed += new FormClosedEventHandler(FoodForm_FormClosed);
            frm.Show(this);
        }
        private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            int index = cbbCategory.SelectedIndex;
            cbbCategory.SelectedIndex = -1;
            cbbCategory.SelectedIndex = index;

        }
        private void tsmUpdateFood_Click(object sender, EventArgs e)
        {
            if(dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;
                FoodInfoForm foodfrm= new FoodInfoForm();
                foodfrm.FormClosed += new FormClosedEventHandler(FoodForm_FormClosed);
                foodfrm.Show(this);
                foodfrm.DisplayFoodInfo(rowView);

            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (foodTable == null) return;
            string filterExpression = "Name like '%" + txtSearchByName.Text + "%'";
            string sortExpression = "Price DESC";
            DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;
            DataView foodview = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);
            dgvFoodList.DataSource = foodview;
        }
    }
}
