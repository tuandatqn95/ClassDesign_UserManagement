using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
   public class RightBUS
    {
        RightDAO rightDAO;

        public RightBUS()
        {
            rightDAO = new RightDAO();
        }
        public List<Right> GetAllRights()
        {
            return rightDAO.GetAllRight();
        }

        public List<Right> GetAllRightByUser(User user)
        {
            return rightDAO.GetAllRightByUserName(user.UserName);
        }
    }
}
