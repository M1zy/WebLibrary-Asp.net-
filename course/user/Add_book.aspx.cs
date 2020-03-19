using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace course.user
{
    public partial class Add_book : System.Web.UI.Page
    {
        string a, b;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("login.aspx");

            }
        }

        protected void b1_Click(object sender, EventArgs e)
        {
            a = course.Business_Layer.Randomizer.GetRandomPassword(15);
            b = "images/default.png";
            string pdf = "";
            if (f1.FileName != "")
            {
                f1.SaveAs(Request.PhysicalApplicationPath + "/images/" + a + f1.FileName.ToString());
                b = "images/" + a + f1.FileName.ToString();
            }
            if (f2.FileName != "")
            {
                f2.SaveAs(Request.PhysicalApplicationPath + "user/pdfs/" + a + f2.FileName.ToString());
                pdf = "pdfs/" + a + f2.FileName.ToString();
            }

            string category = "Foreign literature";
            if (Radio2.Checked)
            {
                category = "native literature";
            }
            Business_Layer.product product = new Business_Layer.product(t1.Text, t4.Text, t3.Text, (t5.Text), b.ToString(), t2.Text, t6.Text, category, pdf.ToString(),0, Session["user"].ToString());
            if (product.error == "")
            {
                DataAccess.ProductDAO productDAO = new DataAccess.ProductDAO();
                productDAO.InsertProduct(product);
                Response.Redirect("Add_book.aspx");
            }

            else
            {
                Error.Text = product.error;
            }
        }
    }
}