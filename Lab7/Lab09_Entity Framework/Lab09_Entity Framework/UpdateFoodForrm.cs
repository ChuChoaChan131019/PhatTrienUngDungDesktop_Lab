using Lab09_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class UpdateFoodForrm : Form
    {
        private RestaurentContext _dbContext;
        private int _foodId;

        public UpdateFoodForrm(int? foodId = null)
        {
            InitializeComponent();
            //khới tạo 2 biến
            _dbContext = new RestaurentContext();
            _foodId = foodId ?? 0;
        }
        #region phương thức
        private void LoadCategoriesToCombobox()
        {
            //lấy tất cả danh mục thức ăn, sắp tăng theo tên
            var cartegories = _dbContext.Categories.OrderBy(x=>x.Name).ToList();
            //nạp danh mục vào combobox, hiển thị tên cho ng dùng xem nhưng khi chọn thì lấy ID
            cbbFoodCategory.DisplayMember = "Name";
            cbbFoodCategory.ValueMember = "ID";
            cbbFoodCategory.DataSource = cartegories;
        }
        private Food GetFoodByID(int foodId)
        {
            return foodId > 0 ? _dbContext.Foods.Find(foodId) : null;//Tìm món theo mã số
        }
        private void ShowFoodInfo()
        {
            //tìm món ăn theo mã số đc truyền vào form
            var food = GetFoodByID(_foodId);
            if (food == null) return;
            //tìm thấy thì hiện lên form
            txtFoodID.Text = food.ID.ToString();
            txtFoodName.Text = food.Name;
            cbbFoodCategory.SelectedValue = food.FoodCategoryID;
            txtFoodUnit.Text = food.Unit;
            nudFoodPrice.Value = food.Price;
            txtFoodNotes.Text = food.Notes;
        }
        //kt dư liệu nhập
        private bool ValidateUserInput()
        {
            if(string.IsNullOrWhiteSpace(txtFoodName.Text))
            {
                MessageBox.Show("Tên món ăn, đồ uống không được để trống");
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtFoodUnit.Text))
            {
                MessageBox.Show("Đơn vị tính không được để trống");
                return false;
            }
            if(nudFoodPrice.Value.Equals(0))
            {
                MessageBox.Show("Giá của thức ăn phải lớn hơn 0");
                return false;
            }    
            if(cbbFoodCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhóm thức ăn");
                return false;
            }
            return true;
        }
        private Food GetUpdateFood()
        {
            var food = new Food()
            {
                Name = txtFoodName.Text.Trim(),
                FoodCategoryID = (int)cbbFoodCategory.SelectedValue,
                Unit = txtFoodUnit.Text.Trim(),
                Price = (int)nudFoodPrice.Value,
                Notes = txtFoodNotes.Text.Trim()
            };
            if (_foodId > 0)
                food.ID = _foodId;
            return food;
        }
        #endregion

        private void UpdateFoodForrm_Load(object sender, EventArgs e)
        {
            LoadCategoriesToCombobox();
            ShowFoodInfo();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateUserInput())
            {
                //kiểm tra thông tin hợp lệ thì lấy thoong tin ng dùng
                var newFood = GetUpdateFood();
                //tìm xem đã có món này trong db chưa
                var oldFood = GetFoodByID(_foodId);
                if (oldFood == null)
                    _dbContext.Foods.Add(newFood);
                else
                {
                    oldFood.Name = newFood.Name;
                    oldFood.FoodCategoryID = newFood.FoodCategoryID;
                    oldFood.Unit = newFood.Unit;
                    oldFood.Price = newFood.Price;
                    oldFood.Notes = newFood.Notes;
                }
                _dbContext.SaveChanges();//lưu thay đổi xuống db
                DialogResult = DialogResult.OK;
            }
        }
    }
}
