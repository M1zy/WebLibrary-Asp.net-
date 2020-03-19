using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace course.DataAccess
{
    public class cartDao: interfaces.Icart
    {
        Db db;
        public void Addproduct(int id,string session)
        {
            db = new Db(); 
            string sql = "insert into [cart] (email,product) values ('" + session + "','" + id + "')";
            db.executecommand(sql);

        }
        public bool isExist(int id, string session)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\course\course\App_Data\Library.mdf;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
           cmd.CommandText = ("select count(*) from cart where email='" + session + "' and product='" + id + "'");
            int d = Convert.ToInt32(cmd.ExecuteScalar());
            
            connection.Close();
            
            
            if (d > 0) return true;
            return false;
        }
        public void Deleteproduct(int id, string session)
        {
            db = new Db();
            string sql = "delete from [cart] where email='" + session + "' and product='" + id + "'";
            db.executecommand(sql);
            
        }

        public void ChangingRate(string user,int book, int rate)
        {
            db = new Db();
            string sql = "update [cart] set c_Rate='"+rate+"' where email='" + user + "' and product='" + book + "'";
            db.executecommand(sql);
        }
    }
}