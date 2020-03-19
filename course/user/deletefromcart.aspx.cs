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
    public partial class deletefromcart : System.Web.UI.Page
    {
        int id;
        DataAccess.Db db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();
            if (Request.QueryString["id"] == null) { Response.Redirect("items.aspx"); }
            else
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());

                string sql = "select * from [product] where product.Id='" + id.ToString() + "'";
                SqlCommand cmd = db.executecommand(sql);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();
                sql = "select * from cart where cart.product='" + id.ToString() + "' and cart.email='" + Session["user"]+"'";
                 cmd = db.executecommand(sql);
                 dt = new DataTable();
                 da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                d2.DataSource = dt;
                d2.DataBind();

            }

       
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            DataAccess.cartDao cart = new DataAccess.cartDao();
            cart.Deleteproduct(id, (Session["user"].ToString()));
            Response.Redirect("cart.aspx");
        }
    }
}