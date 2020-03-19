using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace course.DataAccess
{
    public class MemberDao:interfaces.IMember
    {
        private Db dbconnection;
        public MemberDao()
        {
            dbconnection = new Db();
        }
      public  void InsertMember(course.Business_Layer.Member member)
        {
            Db db = new Db();
            string insert = "insert into [registration](firstname, lastname, email, address,mobile,password) 		" +
    " values('" + member.firstname + "','" + member.lastname + "','" + member.email + "','" + member.address + "','" + member.mobile + "','" + member.password + "')";
            db.executecommand(insert);
        }

        public bool IsExistMember(course.Business_Layer.Member member)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\course\course\App_Data\Library.mdf;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= ("select count(*) from registration where email='" + member.email+"'" );
            int countrows = Convert.ToInt32(cmd.ExecuteScalar());
            if (countrows > 0) return true;
            return false;
        }
        public DataTable searchById(string _id)
        {
            string query = "select * from [registration] where Id '"+_id+"'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            dataTable = null;
            SqlCommand cmd= dbconnection.executecommand(query);
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}