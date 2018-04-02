using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen_DangNhap.DTO
{
    class GroupRight
    {
        private int groupId;
        private int rightId;

        public GroupRight()
        {

        }

        public GroupRight(int groupId, int rightId)
        {
            this.GroupId = groupId;
            this.RightId = rightId;
        }

        public int GroupId { get => groupId; set => groupId = value; }
        public int RightId { get => rightId; set => rightId = value; }
    }
}
