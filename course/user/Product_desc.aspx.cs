using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace course.user
{
    public partial class Product_desc : System.Web.UI.Page
    {
        DataAccess.Db db;
        SqlConnection SqlConnection;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();
            SqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\course\course\App_Data\Library.mdf;Integrated Security=True");
            if (Request.QueryString["id"] == null) { Response.Redirect("items.aspx"); }
            else
            {
                id = Convert.ToInt32(Request.QueryString["id"].ToString());

                string sql = "select * from product where Id='" + id + "'";
                SqlCommand cmd = db.executecommand(sql);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                d1.DataSource = dt;
                d1.DataBind();
            }

            course.Business_Layer.productBU productBU = new Business_Layer.productBU();
            Business_Layer.product p = productBU.GetProductbyID(id.ToString());
            Rating.Text = p.rate.ToString();
            
            
        }
   

        protected void b1_Click(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                SqlConnection.Open();
                DataAccess.cartDao cart = new DataAccess.cartDao();
                if (cart.isExist(id, Session["user"].ToString()))
                {
                    Label1.Text = "This product is already added"; SqlConnection.Close();
                }
                else
                {
                    cart.Addproduct(id, Session["user"].ToString());
                    SqlConnection.Close();
                    Response.Redirect("items.aspx");
                }
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }
        public string checkpdf(object myvalue,object id)
        {
            if (myvalue.ToString() == "")
            {
                return "Not available";
            }
            else
            {
                myvalue = "./" + myvalue.ToString();
               
                
                return "<a href='" +myvalue+ "'style='color:green'>view pdf</a>";
            }
        }

        protected void b2_Click(object sender, EventArgs e)
        {
            int rate=0;
            if (stars1.Checked) rate = 1;
            if (stars2.Checked) rate = 2;
            if (stars3.Checked) rate = 3;
            if (stars4.Checked) rate = 4;
            if (stars5.Checked) rate = 5;
            if (Session["user"] != null)
            {
                DataAccess.ProductDAO productDAO = new DataAccess.ProductDAO();
                productDAO.UpgradeRate(id, rate, Session["user"].ToString());

                DataAccess.cartDao cart = new DataAccess.cartDao();
                cart.ChangingRate(Session["user"].ToString(), id, rate);
                Response.Redirect("Product_desc.aspx?id=" + id);


            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }


    }
}