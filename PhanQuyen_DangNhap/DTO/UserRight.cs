using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen_DangNhap.DTO
{
    class UserRight
    {
        private string userName;
        private int rightId;

        public UserRight()
        {

        }

        public UserRight(string userName, int rightId)
        {
            this.UserName = userName;
            this.RightId = rightId;
        }

        public string UserName { get => userName; set => userName = value; }
        public int RightId { get => rightId; set => rightId = value; }
    }
}
