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
    public partial class BooksRequests : System.Web.UI.Page
    {
        DataAccess.Db db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();

            SqlCommand command;

            command = db.executecommand("SELECT * FROM product WHERE product_added=0");



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
    }
}