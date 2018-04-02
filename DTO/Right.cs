using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Right
    {
        private int rightId;
        private string rightName;
        private string description;

        public Right()
        {

        }

        public Right(int rightId, string rightName, string description)
        {
            this.rightId = rightId;
            this.rightName = rightName;
            this.description = description;
        }

        public int RightId { get => rightId; set => rightId = value; }
        public string RightName { get => rightName; set => rightName = value; }
        public string Description { get => description; set => description = value; }
    }
}
