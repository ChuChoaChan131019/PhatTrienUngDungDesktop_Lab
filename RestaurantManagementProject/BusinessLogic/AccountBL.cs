using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
    public class AccountBL
    {
        AccountDA AccountDA = new AccountDA();
        public List<Account> GetAll()
        {
            return AccountDA.GetAll();
        }
        public int Insert(Account account)
        {
            return AccountDA.Insert_Update_Delete(account, 0);
        }
        public int Update(Account account)
        {
            return AccountDA.Insert_Update_Delete(account, 1);
        }
        public int Delete(Account account)
        {
            return AccountDA.Insert_Update_Delete(account, 2);
        }
    }
}
