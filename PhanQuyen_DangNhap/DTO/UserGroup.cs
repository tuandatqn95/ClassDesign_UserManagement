using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyen_DangNhap.DTO
{
    class UserGroup
    {
        private int groupId;
        private string groupName;
        private string description;

        public UserGroup()
        {

        }

        public UserGroup(int groupId, string groupName, string description)
        {
            this.GroupId = groupId;
            this.GroupName = groupName;
            this.Description = description;
        }

        public int GroupId { get => groupId; set => groupId = value; }
        public string GroupName { get => groupName; set => groupName = value; }
        public string Description { get => description; set => description = value; }
    }
}
