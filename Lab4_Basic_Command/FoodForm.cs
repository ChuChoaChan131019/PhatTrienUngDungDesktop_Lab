using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab4_Basic_Command
{
    public partial class FoodForm : Form
    {
        private int currentCategoryId;

        public FoodForm()
        {
            InitializeComponent();
        }
        

        
        public void LoadFood(int categoryID)
        {
            currentCategoryId = categoryID;                 
            txtIDCategory.Text = categoryID.ToString();
            string Connectstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(Connectstring);
            SqlCommand sqlCommand=sqlConnection.CreateCommand();
            sqlCommand.CommandText= "select Name from Category where ID= "+ categoryID;
            sqlConnection.Open();
            string catName =sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;
            sqlCommand.CommandText = "select * FROM Food where FoodCategoryID = " + categoryID;
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Food");
            da.Fill(dt);
            dgvFood.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();

        }

        public void XoaTrang()
        {
            txtIDFood.Clear();
            txtName.Clear();
            txtUnit.Clear();
            txtPrice.Clear();
            txtNotes.Clear();
            
        }

        private void dgvFood_Click(object sender, EventArgs e)
        {
            var row = dgvFood.CurrentRow;
            if (row == null)
                return;
            txtIDFood.Text = row.Cells["clIDFood"].Value.ToString();
            txtName.Text = row.Cells["clNameFood"].Value.ToString();
            txtUnit.Text = row.Cells["clUnit"].Value.ToString();
            txtIDCategory.Text = row.Cells["clIDType"].Value.ToString();
            txtPrice.Text = row.Cells["clPrice"].Value.ToString();
            txtNotes.Text = row.Cells["clNote"].Value.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int catId = string.IsNullOrWhiteSpace(txtIDCategory.Text)
               ? currentCategoryId
               : Convert.ToInt32(txtIDCategory.Text);
            string ConnectString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(ConnectString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlConnection.Open();
            if(string.IsNullOrEmpty(txtIDFood.Text))
            {
                sqlCommand.CommandText = "insert into food (Name,Unit,FoodCategoryID,Price,Notes) values(@name,@unit,@idCategory,@price,@notes)";
                sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@unit", txtUnit.Text);
                sqlCommand.Parameters.AddWithValue("@idCategory", string.IsNullOrWhiteSpace(txtIDCategory.Text) 
                                            ? currentCategoryId : Convert.ToInt32(txtIDCategory.Text));
                sqlCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                sqlCommand.Parameters.AddWithValue("@notes", txtNotes.Text);
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                int id = Convert.ToInt32(txtIDFood.Text);

                sqlCommand.CommandText =
                    "UPDATE Food SET Name=@name,Unit=@unit,Price=@price,Notes=@notes " +
                    "WHERE ID=@id";
                sqlCommand.Parameters.AddWithValue("@name", txtName.Text);
                sqlCommand.Parameters.AddWithValue("@unit", txtUnit.Text);
                sqlCommand.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                sqlCommand.Parameters.AddWithValue("@notes", txtNotes.Text);
                sqlCommand.Parameters.AddWithValue("@id", txtIDFood.Text);
                sqlCommand.ExecuteNonQuery();

            }
            LoadFood(catId);
            sqlConnection.Close();
            XoaTrang();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Connectstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(Connectstring); 
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "delete from food where ID= @id";
            sqlCommand.Parameters.AddWithValue("@id", txtIDFood.Text);
            sqlConnection.Open();
            sqlCommand.ExecuteNonQuery();
            dgvFood.Rows.Remove(dgvFood.CurrentRow);
            XoaTrang();
            sqlConnection.Close();


        }
    }
}
