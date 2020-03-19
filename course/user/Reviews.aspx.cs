using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace course.user
{
    public partial class Reviews : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess.Db db = new DataAccess.Db();
            
            if (Request.QueryString["id"] == null) { Response.Redirect("items.aspx"); }
            else
            {
                if (Session["user"] == null) finder.Text = "Unregistered user";
                else
                {
                    finder.Text = Session["user"].ToString();
                }
                id = Convert.ToInt32(Request.QueryString["id"]);
                SqlCommand command = db.executecommand("select *  from [comment] where book='" + id + "'");
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                r1.DataSource = dt;
                r1.DataBind();
               
            }

            }

        protected void b1_Click(object sender, EventArgs e)
        {
            if (Session["user"] == null) { Response.Redirect("login.aspx"); }
            else
            {
                if (Comm.Text.ToString() == "") Comm.Text = "Please, write something!";
                else
                {

                    string a;
                    a = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
                    SqlConnection con = new SqlConnection(a);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Comment" + "(book,username,comment_text,time) values (@" +
                        "book,@username,@comment_text,@time)", con);
                    cmd.Parameters.AddWithValue("book", id);
                    cmd.Parameters.AddWithValue("@username", Session["user"]);
                    cmd.Parameters.AddWithValue("@comment_text", Comm.Text);
                    cmd.Parameters.AddWithValue("@time", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("Reviews.aspx?id=" + id);
                }
            }
        }
    }
}