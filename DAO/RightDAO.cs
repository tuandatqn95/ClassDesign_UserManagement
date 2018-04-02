using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class RightDAO : DBConnection
    {
        public List<Right> GetAllRight()
        {
            List<Right> list = new List<Right>();
            string query = "SELECT * FROM Rights";
            foreach (DataRow row in ExecuteQuery(query).Rows)
            {
                list.Add(new Right(
                    (int)row["rightId"],
                    row["rightName"].ToString(),
                    row["description"].ToString()
                    ));
            }
            return list;
        }

        public List<Right> GetAllRightByUserName(string userName)
        {
            List<Right> list = new List<Right>();
            string query = "SELECT r.rightId,r.rightName,r.description FROM Users u " +
                            "join UserGroup ug on u.groupId = ug.groupId " +
                            "join GroupRight gr on ug.groupId = gr.groupId " +
                            "join Rights r on gr.rightId = r.rightId " +
                            "where u.userName = '{0}' " +
                            "union " +
                            "select r.rightId,r.rightName,r.description from Users u " +
                            "join UserRight ur on ur.userName = u.userName " +
                            "join Rights r on r.rightId = ur.rightId " +
                            "where u.userName = '{1}' ";
            foreach (DataRow row in ExecuteQuery(String.Format(query, userName, userName)).Rows)
            {
                list.Add(new Right(
                    (int)row["rightId"],
                    row["rightName"].ToString(),
                    row["description"].ToString()
                    ));
            }
            return list;
        }
    }
}
