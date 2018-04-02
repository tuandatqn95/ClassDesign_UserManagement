using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class UserBUS
    {
        UserDAO userDAO;

        public UserBUS()
        {
            userDAO = new UserDAO();
        }
        public bool ExistUsername(string username)
        {
            return userDAO.ExistUsername(username);
        }

        public bool Authenticate(string username, string password)
        {
            return userDAO.Authenticate(username, password);
        }

        public User GetUserByUserNameAndPassword(string username, string password)
        {
            return userDAO.GetUserByUserNameAndPassword(username, password);
        }
    }
}
