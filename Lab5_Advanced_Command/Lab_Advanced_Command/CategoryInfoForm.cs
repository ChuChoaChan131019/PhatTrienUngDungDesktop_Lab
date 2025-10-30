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
    public partial class CategoryInfoForm : Form
    {
        public CategoryInfoForm()
        {
            InitializeComponent();
        }
        private void LoadCategory_Type()
        {
            var dt = new DataTable();
            dt.Columns.Add("Value", typeof(int));
            dt.Columns.Add("Text", typeof(string));

            dt.Rows.Add(1, "Thức ăn");
            dt.Rows.Add(0, "Đồ uống");
            cbbType.DataSource = dt;
            cbbType.DisplayMember = "Text";   
            cbbType.ValueMember = "Value";    
            cbbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbType.SelectedValue = 1;

        }
       
        private void CategoryInfoForm_Load(object sender, EventArgs e)
        {
            LoadCategory_Type();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                string connect = ConfigurationManager.ConnectionStrings["connect"].ConnectionString;
                SqlConnection conn = new SqlConnection(connect);
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "execute InsertCategory @id output, @name, @type";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
                cmd.Parameters.Add("@type", SqlDbType.Int);
                cmd.Parameters["@id"].Direction = ParameterDirection.Output; 
                cmd.Parameters["@name"].Value = txtName.Text;
                cmd.Parameters["@type"].Value = cbbType.SelectedValue;
                conn.Open();
                int numRowEffect = cmd.ExecuteNonQuery();
                if (numRowEffect > 0)
                {
                    string categoryID = cmd.Parameters["@id"].Value.ToString();
                    string categoryName = cmd.Parameters["@name"].Value.ToString();
                    MessageBox.Show($"Đã thêm thành công nhóm {categoryName} với mã {categoryID}", "Thông báo", MessageBoxButtons.OK);
                    this.ResetText();
                }
                else
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK);
                conn.Close();
                conn.Dispose();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message,"SQL error");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");

            }


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
