using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class User
    {
        private string userName;
        private string userPassword;
        private string fullName;
        private int groupId;

        public User()
        {

        }

        public User(string userName, string userPassword, string fullName, int groupId)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.fullName = fullName;
            this.groupId = groupId;
        }

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int GroupId { get => groupId; set => groupId = value; }
    }
}
