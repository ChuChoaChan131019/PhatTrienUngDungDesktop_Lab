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
    public partial class FoodInfoForm : Form
    {
        public FoodInfoForm()
        {
            InitializeComponent();
        }

        private void FoodInfoForm_Load(object sender, EventArgs e)
        {
            InitValue();
        }
        private void InitValue()
        {
            string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
            SqlConnection conn = new SqlConnection(connect);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select ID,Name from Category";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            conn.Open();
            adapter.Fill(ds,"Category");
            cbbCatName.DataSource = ds.Tables["Category"];
            cbbCatName.DisplayMember = "Name";
            cbbCatName.ValueMember = "ID";
            conn.Close();
            conn.Dispose();
        }
        private void RestText()
        {
            txtAddNew.ResetText();
            txtFoodID.ResetText();
            txtName.ResetText();
            txtNotes.ResetText();
            txtUnit.ResetText();
            cbbCatName.ResetText();
            nudPrice.ResetText();

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "execute InsertFood @id output,@name,@unit,@foodCategoryID,@price,@notes";
                cmd.Parameters.Add("@id",SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();
                if(numRowAffected > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Thêm món ăn thành công - Mã món = " + foodID, "Thông báo", MessageBoxButtons.OK);
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Thêm món thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                conn.Close();
                conn.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
        public void DisplayFoodInfo(DataRowView rowView)
        {
            try
            {
                txtFoodID.Text = rowView["ID"].ToString();
                txtName.Text = rowView["Name"].ToString();
                txtUnit.Text = rowView["Unit"].ToString();
                txtNotes.Text = rowView["Notes"].ToString();
                nudPrice.Text = rowView["Price"].ToString();
                cbbCatName.SelectedIndex = -1;
                for(int index=0;index<cbbCatName.Items.Count;index++)
                {
                    DataRowView cat = cbbCatName.Items[index] as DataRowView;
                    if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
                    {
                        cbbCatName.SelectedIndex = index;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                this.Close();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "execute UpdateFood @id,@name,@unit,@foodCategoryID,@price,@notes";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
                cmd.Parameters.Add("@foodCategoryID", SqlDbType.Int);
                cmd.Parameters.Add("@price", SqlDbType.Int);
                cmd.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);
                cmd.Parameters["@id"].Value=int.Parse(txtFoodID.Text);
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@unit"].Value = txtUnit.Text;
                cmd.Parameters["@foodCategoryID"].Value = cbbCatName.SelectedValue;
                cmd.Parameters["@price"].Value = nudPrice.Value;
                cmd.Parameters["@notes"].Value = txtNotes.Text;
                conn.Open();
                int numRowAffected = cmd.ExecuteNonQuery();
                if (numRowAffected > 0)
                {
                    string foodID = cmd.Parameters["@id"].Value.ToString();
                    MessageBox.Show("Cập nhật món ăn thành công - Mã món = " + foodID, "Thông báo", MessageBoxButtons.OK);
                    this.ResetText();
                }
                else
                {
                    MessageBox.Show("Cập nhật món thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conn.Close();
                conn.Dispose();

            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Sql error");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddNew_Click(object sender, EventArgs e)
        {
            CategoryInfoForm catForm= new CategoryInfoForm();
            catForm.FormClosed += new FormClosedEventHandler(Form_FormClosed);
            catForm.Show(this);
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            InitValue();

        }
    }
}
