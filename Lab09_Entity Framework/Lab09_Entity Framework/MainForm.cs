using Lab09_Entity_Framework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Entity_Framework
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        #region phương thức
        private List<Category> GetCategories()
        {
            var dbContext = new RestaurentContext();
            return dbContext.Categories.OrderBy(x => x.Name).ToList();
        }
        private void ShowCategories()
        {
            tvwCategory.Nodes.Clear();
            //tạo ds loại nhóm thức ăn đồ uống
            //tên các loại này đc hiển thị ở các nút mức 2
            var cateMap = new Dictionary<CategoryType, string>()
            {
                [CategoryType.Food] = "Đồ ăn",
                [CategoryType.Drink] = "Thức uống"
            };
            var rootNode = tvwCategory.Nodes.Add("Tất cả");//Tạo nút gốc
            var categories = GetCategories();//lấy ds nhóm đồ ăn, thức uống
            foreach(var cateType in cateMap)
            {
                var childNode = rootNode.Nodes.Add(cateType.Key.ToString(), cateType.Value);
                childNode.Tag = cateType.Key;
                foreach(var category in categories)
                {
                    if (category.Type != cateType.Key)
                        continue;//nếu nhóm đang xét k cùng loại thì bỏ qua
                    var grantChildNode= childNode.Nodes.Add(category.ID.ToString(), category.Name);
                    grantChildNode.Tag = category;
                }
            }
            //Mở rộng các nhánh để thấy tất cả các nhóm
            tvwCategory.ExpandAll();
            //Đánh dấu nút gốc đang đc chọn
            tvwCategory.SelectedNode = rootNode;
        }
        // lấy ds món ăn theo mã danh mục, nếu mã null thì lấy tất cả
        private List<FoodModel> GetFoodByCategory(int? categoryId)
        {
            var dbContext = new RestaurentContext();//khởi tạo đối tượng
            var foods = dbContext.Foods.AsQueryable();//tạo truy vấn lấy ds món ăn
            if (categoryId != null && categoryId > 0)//nếu mã khác null và hợp lệ thì tìm theo mã số nhóm thức ăn
                foods = foods.Where(x => x.FoodCategoryID == categoryId);
            //sắp xếp đồ ăn thức uống theo têv và trả về
            //ds chứa đầy đủ thông tin về món ăn
            return foods
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                }).ToList();
        }
        //lấy ds món ăn , đồ uống theo laoị danh mục
        private List<FoodModel> GetFoodByCategoryType(CategoryType cateType)
        {
            var dbContext = new RestaurentContext();
            //tìm các món theo loại nhóm(Category type)
            return dbContext.Foods
                .Where(x => x.Category.Type == cateType)
                .OrderBy(x => x.Name)
                .Select(x => new FoodModel()
                {
                    ID = x.ID,
                    Name = x.Name,
                    Unit = x.Unit,
                    Price = x.Price,
                    Notes = x.Notes,
                    CategoryName = x.Category.Name
                }).ToList();
        }
        //kiểm tra mức ở nút
        private void ShowFoodsForNode(TreeNode node)
        {
            lvwFood.Items.Clear();
            if (node == null) return;
            List<FoodModel> foods = null;//tạo ds chưa món ăn tìm được
            if(node.Level==1)//nếu nút đc chọn tương ứng với loại nhóm thức ăn(categỏy type)(mức2 trên cây
            {
                //thì lấy ds món ăn theo loại nhóm
                var categoryType=(CategoryType)node.Tag;
                foods = GetFoodByCategoryType(categoryType);
            }
            else
            {
                //ngược lại lấy danh sách theo thể loại
                //nếu nút đc chọn là tất cả thì lấy hết
                var category = node.Tag as Category;
                foods = GetFoodByCategory(category?.ID);
            }
            ShowFoodsOnListView(foods);
        }
        private void ShowFoodsOnListView(List<FoodModel> foods)
        {
            foreach(var foodItem in foods)
            {
                var item = lvwFood.Items.Add(foodItem.ID.ToString());
                item.SubItems.Add(foodItem.Name);
                item.SubItems.Add(foodItem.Unit);
                item.SubItems.Add(foodItem.Price.ToString());
                item.SubItems.Add(foodItem.CategoryName);
                item.SubItems.Add(foodItem.Notes);

            }
        }
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowCategories();
        }

        private void btnReloadCategory_Click(object sender, EventArgs e)
        {
            ShowCategories();

        }

        private void tvwCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ShowFoodsForNode(e.Node);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var dialog = new UpdateCategoryForm();
            if(dialog.ShowDialog()== DialogResult.OK)
            {
                ShowCategories();
            }
        }

        private void tvwCategory_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Level < 2 || e.Node.Tag == null) return;
            var category = e.Node.Tag as Category;
            var dialog= new UpdateCategoryForm(category?.ID);
            if (dialog.ShowDialog(this) == DialogResult.OK)
                ShowCategories();
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            ShowFoodsForNode(tvwCategory.SelectedNode);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;
            var dbContext = new RestaurentContext();
            var selectedFoodID = int.Parse(lvwFood.SelectedItems[0].Text);
            var selectedFood = dbContext.Foods.Find(selectedFoodID);
            if(selectedFood!= null)
            {
                dbContext.Foods.Remove(selectedFood);
                dbContext.SaveChanges();
                lvwFood.Items.Remove(lvwFood.SelectedItems[0]);
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            var food = new UpdateFoodForrm();
            if (food.ShowDialog(this) == DialogResult.OK)
                ShowFoodsForNode(tvwCategory.SelectedNode);
                
        }

        private void lvwFood_DoubleClick(object sender, EventArgs e)
        {
            if (lvwFood.SelectedItems.Count == 0) return;
            var foodID = int.Parse(lvwFood.SelectedItems[0].Text);
            var dialog = new UpdateFoodForrm();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                ShowFoodsForNode(tvwCategory.SelectedNode);
        }
    }
}
