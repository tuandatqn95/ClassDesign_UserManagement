using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DBConnection
    {
        private SqlConnection connection;
        //private string connString = @"Data Source=localhost;Initial Catalog=UserManagement;Integrated Security=True";
        private string connString = @"workstation id=UserManagement.mssql.somee.com;packet size=4096;user id=nguyentthai96_SQLLogin_1;pwd=t4b3uwkq6o;data source=UserManagement.mssql.somee.com;persist security info=False;initial catalog=UserManagement";


        public DBConnection()
        {
            connection = new SqlConnection();
        }

        protected SqlConnection Connection { get => connection; set => connection = value; }

        protected DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        protected int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        protected object ExecuteScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }
    }
}
