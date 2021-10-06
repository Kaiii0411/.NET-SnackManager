using SnackManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackManager.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "Snack_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{ userName, passWord});
            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdateAccount @userName , @didplayName , @password , @newPassword ", new object[] { userName, displayName, pass, newPass});
            return result > 0;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName , DisplayName, Type FROM Account");
        }
        public Account GetAccountByUsername(string userName)
        {
           DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE UserName = '" + userName + "'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);

            }
            return null;
        }
        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName , DisplayName , Type )VALUES ( N'{0}' , N'{1}' , {2} )", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET  DisplayName = N'{1}'  , Type = {2} WHERE UserName = N'{0}' ", name, displayName, type );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string name )
        {
            string query = string.Format("DELETE Account WHERE UserName = N'{0}' ", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE dbo.Account SET Password = N'0' WHERE UserName = N'{0}' ", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
