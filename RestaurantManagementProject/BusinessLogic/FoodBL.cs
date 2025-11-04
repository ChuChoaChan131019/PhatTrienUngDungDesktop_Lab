using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    //Lớp FoodBL có các phương thức xử lý của bảng Food
    public class FoodBL
    {
        //Đối tượng FoodDA
        FoodDA foodDA = new FoodDA();
        public List<Food> Get_All()
        {
            return foodDA.GetAll();
        }
        //Phương thức lấy về đối tượng Food theo khóa chinh 
        public Food GetByID(int ID)
        {
            //Lấy hết
            List<Food> list = new List<Food>();
            //Duyệt để tìm kiếm
            foreach (var item in list)
            {
                if (item.ID == ID)//Nếu gặp khóa chính thì về kết quả
                    return item;
            }
            return null;

        }
        //Phương thức tìm kiếm theo khóa
        public List<Food> Find(string key)
        {
            List<Food> list = Get_All();
            List<Food> result = new List<Food>();
            foreach (var item in list)
            {
                //Nếu từng trường chứa từ khóa
                if (item.ID.ToString().Contains(key)
                    || item.Name.Contains(key)
                    || item.Unit.Contains(key)
                    || item.Price.ToString().Contains(key)
                    || item.Notes.Contains(key))
                    result.Add(item);//Thì thêm vào ds kết quả
            }
            return result;

        }
        public int Insert(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 0);
        }
        public int Update(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 1);
        }
        public int Delete(Food food)
        {
            return foodDA.Insert_Update_Delete(food, 2);
        }
    }
}
