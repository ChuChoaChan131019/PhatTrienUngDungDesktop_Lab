using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;

namespace RestaurantManagementProject
{
    public partial class frmFood : Form
    {
        //Khai báo đối tượng
        List<Category> listCategory = new List<Category>();
        List<Food> listFood = new List<Food>();
        Food foodCurrent= new Food();


        //
        public frmFood()
        {
            InitializeComponent();
        }
        #region phương thức
        private void LoadCategory()
        {
            CategoryBL categoryBL= new CategoryBL();
            //Lấy dữ liệu gán cho biến toàn cục listCategory
            listCategory = categoryBL.GetAll();
            cbCategory.DataSource=listCategory;
            cbCategory.ValueMember = "ID";
            cbCategory.DisplayMember = "Name";
        }
        public void LoadFoodDatatoListView()
        {
            FoodBL foodBL = new FoodBL();
            //Lấy dl
            listFood = foodBL.Get_All();
            int count = 1;//Biến STT
            lsvFood.Items.Clear();//Xóa dl trong lv
            //duyệt mảng để đưa vào lv
            foreach(var food in listFood)
            {
                ListViewItem item = lsvFood.Items.Add(count.ToString());//STT
                //Đưa dl vào các cột tiếp theo
                item.SubItems.Add(food.Name);
                item.SubItems.Add(food.Unit);
                item.SubItems.Add(food.Price.ToString());
                //theo dl của bảng Category ID, lấy Name để hiển thị
                string foodName = listCategory.Find(x => x.ID == food.FoodCategoryID).Name;
                item.SubItems.Add(foodName);
                //Đưa notes vào cột cuối
                item.SubItems.Add(food.Notes);
                count++;

            }
        }

        private int InsertFood()
        {
            Food food= new Food();
            food.ID = 0;
            //Kiểm tra rỗng
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập");
            else
            {
                //nhận dl ng dùng nhập
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes= txtNotes.Text;
                //price là kiểu số nên cẫn bắt lỗi
                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price=price;
                food.FoodCategoryID = int.Parse(cbCategory.SelectedValue.ToString());
                FoodBL foodBL = new FoodBL();
                //chèn dl vào bảng
                return foodBL.Insert(food);
            }
            return -1;
        }

        private int UpdateFood()
        {
            Food food = foodCurrent;
            if (txtName.Text == "" || txtUnit.Text == "" || txtPrice.Text == "")
                MessageBox.Show("Chưa nhập dữ liệu cho các ô, vui lòng nhập");
            else
            {
                //nhận dl ng dùng nhập
                food.Name = txtName.Text;
                food.Unit = txtUnit.Text;
                food.Notes = txtNotes.Text;
                //price là kiểu số nên cẫn bắt lỗi
                int price = 0;
                try
                {
                    price = int.Parse(txtPrice.Text);
                }
                catch
                {
                    price = 0;
                }
                food.Price = price;
                food.FoodCategoryID = int.Parse(cbCategory.SelectedValue.ToString());
                FoodBL foodBL = new FoodBL();
                //chèn dl vào bảng
                return foodBL.Update(food);
            }
            return -1;

        }
        #endregion



        #region sự kiện
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPrice.Text = "0";
            txtUnit.Text = "";
            txtNotes.Text = "";
            if (cbCategory.Items.Count > 0)
                cbCategory.SelectedIndex = 0;
        }

        private void frmFood_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadFoodDatatoListView();
        }


        //Lấy dl gán vào biến của đối tượng và vào ô nhập
        private void lsvFood_Click(object sender, EventArgs e)
        {
            //Duyệt dl trong lv
            for (int i = 0; i < lsvFood.Items.Count; i++)
            {
                //Lấy dòng đc chọn
                if (lsvFood.Items[i].Selected)
                {
                    foodCurrent = listFood[i];
                    txtName.Text = foodCurrent.Name;
                    txtUnit.Text = foodCurrent.Unit;
                    txtPrice.Text = foodCurrent.Price.ToString();
                    txtNotes.Text = foodCurrent.Notes;
                    //Lấy index của combobox theo FoodVCategoryID
                    cbCategory.SelectedIndex = listCategory.FindIndex(x => x.ID == foodCurrent.FoodCategoryID);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int result = InsertFood();
            if (result > 0)
            {
                MessageBox.Show("Thêm dữ liệu thành công");
                LoadFoodDatatoListView();
            }
            else MessageBox.Show("Thêm dữ liệu không thành công.Vui lòng kiểm tra lại");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FoodBL foodBl = new FoodBL();
                if (foodBl.Delete(foodCurrent) > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công");
                    LoadFoodDatatoListView();
                }
                else MessageBox.Show("Xóa dữ liệu không thành công");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int result = UpdateFood();
            if (result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadFoodDatatoListView();
            }
            else MessageBox.Show("Cập nhật dữ liệu không thành công");
        }
        #endregion

    }
}
