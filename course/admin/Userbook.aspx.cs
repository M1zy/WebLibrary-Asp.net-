using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace course.admin
{
    public partial class Userbook : System.Web.UI.Page
    {
        int id;
        DataAccess.Db db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();
            if (Request.QueryString["id"] == null) { Response.Redirect("Home.aspx"); }
            else
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());

                string sql = "select * from product where Id='" + id.ToString() + "'";
                SqlCommand cmd = db.executecommand(sql);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();
            }
        }


        public string checkpdf(object myvalue, object id)
        {
            if (myvalue.ToString() == "")
            {
                return "Not available";
            }
            else
            {
                myvalue = "..\\user/" + myvalue.ToString();


                return "<a href='" + myvalue + "'style='color:green'>view pdf</a>";
            }
        }

        protected void d1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        protected void b1_Click(object sender, EventArgs e)
        {
            DataAccess.Db data = new DataAccess.Db();
            string sql = "UPDATE product SET product_added=1 where Id='" + id.ToString() + "'";
            data.executecommand(sql);
            Response.Redirect("BooksRequests.aspx");
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            DataAccess.Db data = new DataAccess.Db();
            string sql = "UPDATE product SET product_added=2 where Id='" + id.ToString() + "'";
            data.executecommand(sql);
            Response.Redirect("BooksRequests.aspx");
        }
    }
}