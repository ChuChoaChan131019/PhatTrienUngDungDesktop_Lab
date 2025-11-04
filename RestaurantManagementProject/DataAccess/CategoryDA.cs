using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDA
    {
        //phương thức GetAll theo thủ tục
        public List<Category> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Category_GetAll;
            conn.Open();
            //Doc dl, tra ve ds cac doi tuong Category
            SqlDataReader reader = cmd.ExecuteReader();
            List<Category> result = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.ID = Convert.ToInt32(reader["ID"]);
                category.Name = reader["Name"].ToString();
                category.Type = Convert.ToInt32(reader["Type"]);
                result.Add(category);
            }
            conn.Close();
            return result;
        }

        //Phương thức thêm, xóa, sửa theo thủ tục Category_InsertUpdateDelete
        public int Insert_Update_Delete(Category category, int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();

            //Khai báo đối tượng SqlCommand có kiểu xử lý là StoredProcedure
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Category_InsertUpdateDelete;

            // Thêm các tham số cho thủ tục; Các tham số này chính là các tham số trong thủ tục;
            // ID là tham số có giá trị lấy ra khi thêm và truyền vào khi xóa, sửa
            SqlParameter IDPara = new SqlParameter("@ID", SqlDbType.Int);
            IDPara.Direction = ParameterDirection.InputOutput; // Vừa vào vừa ra
            cmd.Parameters.Add(IDPara).Value = category.ID;
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 200).Value = category.Name;
            cmd.Parameters.Add("@Type", SqlDbType.Int).Value = category.Type;
            cmd.Parameters.Add("@Action", SqlDbType.Int).Value = action;

            // Thực thi lệnh
            int result = cmd.ExecuteNonQuery();
            if (result > 0) // Nếu thành công thì trả về ID đã thêm
                return (int)cmd.Parameters["@ID"].Value;
            return 0;
        }

    }
}
