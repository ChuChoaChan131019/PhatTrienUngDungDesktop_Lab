using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Configuration;

namespace Lab4_Basic_Command
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string Connectstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString ;
            SqlConnection sqlconnection = new SqlConnection(Connectstring);
            SqlCommand sqlcommand = sqlconnection.CreateCommand();
            string query = "select * from Category";
            sqlcommand.CommandText = query; ;
            sqlconnection.Open();
            SqlDataReader sqlDatareader = sqlcommand.ExecuteReader();
            this.Displaycategory(sqlDatareader);
            sqlconnection.Close();
        }
       private void Displaycategory(SqlDataReader reader)
        {
            lvCategory.Items.Clear();   
            while(reader.Read())
            {
                ListViewItem lvitem= new ListViewItem(reader["ID"].ToString());
                lvCategory.Items.Add(lvitem);
                lvitem.SubItems.Add(reader["Name"].ToString());
                lvitem.SubItems.Add(reader["Type"].ToString());

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Connectstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlconnection = new SqlConnection(Connectstring);
            SqlCommand sqlCommand = sqlconnection.CreateCommand();
            sqlCommand.CommandText = "insert into category(Name, [Type])" + "values (N'" + txtName.Text + "'," + txtType.Text + ")";
            sqlconnection.Open();
            int numOfRowEffected = sqlCommand.ExecuteNonQuery();
            sqlconnection.Close();
            if(numOfRowEffected ==1 )
            {
                MessageBox.Show("Thêm món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                btnLoad.PerformClick();
                txtName.Text = "";
                txtType.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Connectstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlconnection = new SqlConnection(Connectstring);
            SqlCommand sqlcommand = sqlconnection.CreateCommand();
            sqlcommand.CommandText = "delete from Category where ID = @id" + txtID.Text;
            sqlconnection.Open();
            int  numOfRowEffected= sqlcommand.ExecuteNonQuery();
            sqlconnection.Close();
            if(numOfRowEffected ==1 )
            {
                ListViewItem lviem = lvCategory.SelectedItems[0];
                lvCategory.Items.Remove(lviem);
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Xóa nhóm món ăn thành công", "Thông báo", MessageBoxButtons.OK);
                
            }
            else
            {
                MessageBox.Show("Đã có lỗi. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Connectstring = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(Connectstring);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            int typeInt=txtType.Text=="Thức uống" ? 0:1;
            sqlCommand.CommandText="update Category set Name = N'"+txtName.Text+"',[Type] = N'"+typeInt+ "' where ID = "+txtID.Text;
            sqlConnection.Open();
            int numOfRowsEffected = sqlCommand.ExecuteNonQuery();                                                            
            sqlConnection.Close();
            if(numOfRowsEffected ==1 )
            {
                ListViewItem lvitem= lvCategory.SelectedItems[0];
                lvitem.SubItems[1].Text = txtName.Text;
                lvitem.SubItems[2].Text = typeInt.ToString() ;
                txtID.Text = "";
                txtName.Text = "";
                txtType.Text = "";
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Cập nhật nhóm món ăn thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Đã có lỗi. Vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvCategory_Click(object sender, EventArgs e)
        {
            ListViewItem item= lvCategory.SelectedItems[0];
            txtID.Text = item.Text; 
            txtName.Text= item.SubItems[1].Text;
            txtType.Text= item.SubItems[2].Text=="0"?"Thức uống":"Đồ ăn";
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
                btnDelete.PerformClick();
        }

        private void tsmViewFood_Click(object sender, EventArgs e)
        {
            if(txtID.Text !="")
            {
                FoodForm ff= new FoodForm();
                ff.Show(this);
                ff.LoadFood(Convert.ToInt32(txtID.Text));
            }    
        }
    }
}
