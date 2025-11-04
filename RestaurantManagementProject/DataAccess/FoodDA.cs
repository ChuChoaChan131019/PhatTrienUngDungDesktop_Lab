using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FoodDA
    {
        public List<Food> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Food_GetAll;
            //đọc dl
            SqlDataReader reader = cmd.ExecuteReader();
            List<Food> result = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.ID = Convert.ToInt32(reader["ID"]);
                food.Name = reader["Name"].ToString();
                food.Unit = reader["Unit"].ToString();
                food.FoodCategoryID = Convert.ToInt32(reader["FoodCategoryID"]);
                food.Price = Convert.ToInt32(reader["Price"]);
                food.Notes = reader["Notes"].ToString();
                result.Add(food);

            }
            conn.Close();
            return result;
        }
        public int Insert_Update_Delete(Food food, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Food_InsertUpdateDelete;
            conn.Open();
            //Thêm tham số
            //ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xóa sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add(IDPara).Value = food.ID;
            //các biến còn lại chỉ truyền vào
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 1000).Value = food.Name;
            cmd.Parameters.Add("@Unit", SqlDbType.NVarChar, 100).Value = food.Unit;
            cmd.Parameters.Add("@FoodCategoryID", SqlDbType.Int).Value = food.FoodCategoryID;
            cmd.Parameters.Add("@Price", SqlDbType.Int).Value = food.Price;
            cmd.Parameters.Add("@Notes", SqlDbType.NVarChar, 3000).Value = food.Notes;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;
            int result = cmd.ExecuteNonQuery();
            //Thực thi lệnh
            if (result > 0)
                return (int)cmd.Parameters["@ID"].Value;
            return 0;
        }
    }
}
