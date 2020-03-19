using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace course.admin
{
    public partial class AllUsers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClientDBDataContext db = new ClientDBDataContext();

            registration table = new registration();
            
            table.firstname = TextBox1.Text;
            table.lastname = TextBox2.Text;
            table.address = TextBox3.Text;
            table.email = TextBox4.Text;
            table.mobile = TextBox5.Text;
            table.password = TextBox6.Text;
            if (TextBox1.Text.Length <= 4 || TextBox6.Text.Length <= 5 || TextBox4.Text.Length <= 5 || !TextBox4.Text.Contains("@"))
            {
                Error.Text = "Data seems invalid";
            }
            else
            {
                db.registrations.InsertOnSubmit(table);
                db.SubmitChanges();
                Response.Redirect("/admin/AllUsers.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}