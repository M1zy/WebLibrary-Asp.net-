using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace course.user
{
    public partial class YourBooks : System.Web.UI.Page
    {
        DataAccess.Db db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();
            if (Session["user"] != null)
            {

                SqlCommand command = db.executecommand("select *  from  [product] where product_developer='" + Session["user"] + "'");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();


            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
    }
}