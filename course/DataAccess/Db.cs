using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace course.DataAccess
{
    public class Db
    {

        public SqlConnection connection;
        public Db()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\course\course\App_Data\Library.mdf;Integrated Security=True");
        }
        public void OpenConnection()
        {
            connection.Open();
        }

        public SqlCommand executecommand(string sql)
        {
            OpenConnection();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            connection.Close();
            return cmd;
        }
    }
}