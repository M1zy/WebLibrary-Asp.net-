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
    public partial class login : System.Web.UI.Page
    {
        DataAccess.Db db;
        int tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
           SqlCommand t= db.executecommand("select * from registration where email='" + TextBox1.Text + "'AND password='" + TextBox2.Text + "'AND status IS NULL");
            db.OpenConnection();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(t);
            da.Fill(dt);
            tot = Convert.ToInt32(dt.Rows.Count.ToString());
            db.connection.Close();

                if (tot > 0)
                {
                    Session["user"] = TextBox1.Text;
                    Response.Redirect("items.aspx");
                }

                else
                {
                    Label1.Text = "invalid email or password";
                }
            DataAccess.Db data = new DataAccess.Db();
            
            SqlCommand sql = data.executecommand("select status from registration where email='" +
                TextBox1.Text + "'AND password='" + TextBox2.Text + "'");
            data.connection.Open();
            object result = sql.ExecuteScalar();
            string res = Convert.ToString(result);
            res = res.Trim();
            if (res != null) { Label1.Text = "Error. " + res; data.connection.Close(); }
        }
    }
}