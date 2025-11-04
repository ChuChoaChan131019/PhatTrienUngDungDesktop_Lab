using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Ultilities
    {
        //Lấy chuỗi kết nối từ appconfig
        public static string StrName = "ConnectionStringName";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings[StrName].ConnectionString;
        //biến trong bảng food
        public static string Food_GetAll = "Food_GetAll";
        public static string Food_InsertUpdateDelete = "Food_InsertUpdateDelete";
        //biến trong bảng Category
        public static string Category_GetAll = "Category_GetAll";
        public static string Category_InsertUpdateDelete = "Category_InsertUpdateDelete";
        //biến trong bảng Account
        public static string Account_GetAll = "Account_GetAll";
        public static string Account_InsertUpdateDelete = "Account_InsertUpdateDelete";
    }
}
