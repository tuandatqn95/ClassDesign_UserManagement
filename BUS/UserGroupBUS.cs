using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class UserGroupBUS

    {
        UserGroupDAO userGroupDAO;

        public UserGroupBUS()
        {
            userGroupDAO = new UserGroupDAO();
        }
        public UserGroup GetGroupByUser(User user)
        {
            return userGroupDAO.GetGroupByUser(user);
        }
    }
}
