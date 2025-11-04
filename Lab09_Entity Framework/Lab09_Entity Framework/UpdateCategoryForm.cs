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
    public partial class UpdateCategoryForm : Form
    {
        private RestaurentContext _dbContext;
        private int _categoryId;
        public UpdateCategoryForm(int? categoryID=null)
        {
            InitializeComponent();
            _dbContext = new RestaurentContext();
            _categoryId = categoryID ?? 0;
        }
        #region phương thức
        private Category GetCategoryByID(int categoryID)
        {
            //Nếu id đc truyền vào là hợp lệ, ta tìm thôgn tin theo ID
            //Ngược lại chỉ đươn giản ttả về null, cho biết không thấy
            return categoryID > 0 ? _dbContext.Categories.Find(categoryID) : null;
        }
        private void ShowCategory()
        {
            //lấy thôgn tin nhóm thức ăn
            var category = GetCategoryByID(_categoryId);
            //nếu k tìm thấy thông tin k cần lm j
            if (category == null) return;
            //ngược lại thì hiện lên form
            txtCategoryID.Text = category.ID.ToString();
            txtCategoryName.Text = category.Name;
            cbbCategoryType.Text = category.Type == CategoryType.Food ? "Đồ ăn" : "Thức uống";

        }
        private Category GetUpdatedCategory()
        {
            //tạo đối tượng Category vs thông tin đã nhập
            var category = new Category()
            {
                Name = txtCategoryName.Text.Trim(),
            };
            string selectedText = cbbCategoryType.Text.Trim();
            if (selectedText == "Đồ ăn")
                category.Type = CategoryType.Food;
            else if (selectedText == "Thức uống")
                category.Type = CategoryType.Drink;
            //gán gt của ID ban đầu(nếu đang cập nhật)
            if (_categoryId>0)
            {
                category.ID = _categoryId;
            }
            return category;
        }
        private bool ValidateUserInput()
        {
            //kiểm tra tên nhóm thức ăn đã đc cập nhật hay chưa
            if(string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Tên nhóm thức ăn không được để trống");
                return false;
            }    
            //kt loại nhsom thức ăn đã đc chọn hay chưa
            if(cbbCategoryType.SelectedIndex<0)
            {
                MessageBox.Show("Bạn chưa chọn loại nhóm thức ăn");
                return false;
            }
            return true;
        }
        #endregion

        private void UpdateCategoryForm_Load(object sender, EventArgs e)
        {
            ShowCategory();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateUserInput())//kt dl nhập là hợp lệ
            {
                var newCategory = GetUpdatedCategory();//thì lấy thông tin người dùng nhập vào
                var oldCategory = GetCategoryByID(_categoryId);//và thử tìm xem đã có nhóm thức ăn trong csdl chưa
                if (oldCategory == null)
                    _dbContext.Categories.Add(newCategory);//nếu chưa có thì thêm
                else
                {//ngược lại chỉ cập nhật
                    oldCategory.Name = newCategory.Name;
                    oldCategory.Type = newCategory.Type;
                }
                _dbContext.SaveChanges();//lưu thay đổi xuốngcsdl
                DialogResult = DialogResult.OK;
            }
        }
    }
}
