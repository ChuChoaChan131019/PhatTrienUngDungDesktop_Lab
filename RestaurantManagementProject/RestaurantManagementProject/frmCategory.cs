using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;

namespace RestaurantManagementProject
{
    public partial class frmCategory : Form
    {
        List<Category> listCategory = new List<Category>();
        Category categoryCurrent = new Category();
        public frmCategory()
        {
            InitializeComponent();
        }

        #region phương thức
        private void LoadType()
        {
            CategoryBL categoryBL = new CategoryBL();
            listCategory = categoryBL.GetAll();
            var typeName = new List<object>
            {
                new {Type=1, Name="Đồ ăn"},
                new {Type=0, Name="Thức uống"}
            };
            cbType.DataSource = typeName;
            cbType.ValueMember = "Type";
            cbType.DisplayMember="Name";
        }
        private void LoadCategoryToListView()
        {
            CategoryBL categoryBL = new CategoryBL();
            //lấy dl
            listCategory=categoryBL.GetAll();
            int stt = 1;
            lsvCategory.Items.Clear();
            foreach(var cat in listCategory)
            {
                ListViewItem item = lsvCategory.Items.Add(stt.ToString());
                item.SubItems.Add(cat.Name);
                string typeName = cat.Type == 1 ? "Đồ ăn" : "Thức uống";
                item.SubItems.Add(typeName);
                stt++;

            }
        }

        public int InsertCategory()
        {
            Category category = new Category();
            category.ID = 0;
            if (txtName.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu");
            else
            {
                category.Name = txtName.Text;
                category.Type = int.Parse(cbType.SelectedValue.ToString());
                CategoryBL categoryBL = new CategoryBL();
                return categoryBL.Insert(category);
            }
            return -1;
        }
        public int UpdateCategory()
        {

            Category cat = categoryCurrent;
            if (txtName.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu");
            else
            {
                cat.Name = txtName.Text;
                cat.Type = int.Parse(cbType.SelectedValue.ToString());
                CategoryBL catBL = new CategoryBL();
                return catBL.Update(cat);
            }
            return -1;

        }
        #endregion

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadType();
            LoadCategoryToListView();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            if(cbType.Items.Count> 0)
                cbType.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lsvCategory_Click(object sender, EventArgs e)
        {
            for(int i =0; i<lsvCategory.Items.Count;i++)
            {
                if (lsvCategory.Items[i].Selected)
                {
                    categoryCurrent = listCategory[i];
                    txtName.Text = categoryCurrent.Name;
                    cbType.SelectedValue = categoryCurrent.Type;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = InsertCategory();
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadCategoryToListView();
            }
            else MessageBox.Show("Thêm thất bại");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateCategory();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadCategoryToListView();
            }
            else MessageBox.Show("Cập nhật thất bại");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CategoryBL categoryBL = new CategoryBL();
                if (categoryBL.Delete(categoryCurrent) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    LoadCategoryToListView();
                }
                else MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
