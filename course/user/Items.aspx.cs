using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace course.user
{
    public partial class Items : System.Web.UI.Page
    {
        DataAccess.Db db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();

            SqlCommand command;
            if (Request.QueryString["category"] == null)
            {
                command = db.executecommand("select * from product where product_added=1");
            }
            else
            {
                command = db.executecommand("select * from product where product_added=1 and product_category='" + Request.QueryString["category"].ToString()+"'");
            }
            if (Request.QueryString["category"] == null&&Request.QueryString["search"] != null)
            {
                command = db.executecommand("select * from product where product_added=1 and product_name like('%" + Request.QueryString["search"].ToString() + "%')");
            }


            /*if (Request.QueryString["search"] != null)
            {
                command.CommandText="select * from product where product_name"
            }*/
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            d1.DataSource = dt;
            d1.DataBind();
        }
    }
}