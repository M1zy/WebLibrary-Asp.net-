using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace course.user
{
    public partial class cart : System.Web.UI.Page
    {
       
        DataAccess.Db db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();
            if (Session["user"] != null) {

                SqlCommand command=  db.executecommand("select *  from [cart], [product] where cart.product=product.Id and cart.email='" + Session["user"] + "'");
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

        protected void d1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }
    }
    }