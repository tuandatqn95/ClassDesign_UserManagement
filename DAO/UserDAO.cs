using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class UserDAO : DBConnection
    {
        public bool ExistUsername(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE userName = N'{0}'";
            if ((int)ExecuteScalar(String.Format(query, username)) > 0)
            {
                return true;
            }
            return false;
        }

        public bool Authenticate(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE userName = '{0}' and userPassword = CONVERT(VARBINARY, '{1}')";
            if ((int)ExecuteScalar(String.Format(query, username, password)) > 0)
            {
                return true;
            }
            return false;
        }

        public User GetUserByUserNameAndPassword(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE userName = '{0}' and userPassword = CONVERT(VARBINARY, '{1}')";
            DataTable dataTable = ExecuteQuery(String.Format(query, username, password));
            if (dataTable.Rows.Count > 0)
            {
                DataRow dataRow = dataTable.Rows[0];
                User user = new User(
                    dataRow["userName"].ToString(),
                    dataRow["userPassword"].ToString(),
                    dataRow["fullName"].ToString(),
                    (int)dataRow["groupId"]);
                return user;
            }
            return null;
        }
    }
}
