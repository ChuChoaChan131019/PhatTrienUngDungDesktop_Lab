using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AccountDA
    {
        public List<Account> GetAll()
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Account_GetAll;
            SqlDataReader reader = cmd.ExecuteReader();
            List<Account> result = new List<Account>();
            while (reader.Read())
            {
                Account account = new Account();
                account.AccountName = reader["AccountName"].ToString();
                account.Password = reader["Password"].ToString();
                account.FullName = reader["FullName"].ToString();
                account.Email = reader["Email"].ToString();
                account.Tell = reader["Tell"].ToString();
                account.DateCreated= Convert.ToDateTime( reader["Datecreated"]);
                result.Add(account);
            }
            conn.Close();
            return result;
        }
        public int Insert_Update_Delete(Account account,int action)
        {
            SqlConnection conn = new SqlConnection(Ultilities.ConnectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Ultilities.Account_InsertUpdateDelete;
            cmd.Parameters.Add("@accountName", SqlDbType.NVarChar, 100).Value = account.AccountName;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 200).Value = account.Password;
            cmd.Parameters.Add("@fullName", SqlDbType.NVarChar, 1000).Value = account.FullName;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 1000).Value = account.Email;
            cmd.Parameters.Add("@tell", SqlDbType.NVarChar, 200).Value = account.Tell;
            cmd.Parameters.Add("@dateCreated", SqlDbType.DateTime).Value = account.DateCreated;
            cmd.Parameters.Add("@action", SqlDbType.Int).Value = action;
            int result = cmd.ExecuteNonQuery();
            if(result>0)
            {
                return (int)cmd.Parameters["@accountName"].Value;
            }
            return 0;
        }

    }
}
