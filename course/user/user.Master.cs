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
    public partial class user : System.Web.UI.MasterPage
    {
        DataAccess.Db db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new DataAccess.Db();
            SqlCommand com = db.executecommand("select * from category");
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dataTable);
            dd.DataSource = dataTable;
            dd.DataBind();
        }
    }
}