using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class UserGroupDAO : DBConnection
    {
        public UserGroup GetGroupByUser(User user)
        {

            UserGroup userGroup = null;
            string query = @"SELECT * FROM UserGroup WHERE groupId = {0}";
            DataRow dataRow = ExecuteQuery(String.Format(query, user.GroupId)).Rows[0];
            userGroup = new UserGroup(
                (int)dataRow["groupId"],
                dataRow["groupName"].ToString(),
                dataRow["description"].ToString());
            return userGroup;
        }
    }
}
