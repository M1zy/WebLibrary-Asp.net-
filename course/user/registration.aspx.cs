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
    public partial class registration : System.Web.UI.Page
    {
        DataAccess.MemberDao db;
        Business_Layer.Member member;
        protected void Page_Load(object sender, EventArgs e)
        {
             db = new DataAccess.MemberDao();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            member = new Business_Layer.Member(TextBox1.Text.ToString(), TextBox3.Text.ToString(), TextBox4.Text.ToString(), TextBox5.Text.ToString(), TextBox6.Text.ToString(), TextBox7.Text.ToString());
            if (member.error == "")
            {
                if (db.IsExistMember(member)) { Label1.Text = "This email is already used; "; }
                else
                {
                    if (member.password.Length < 6)
                    {
                        if (Label1.Text.ToString() == "Invalid password") Label1.Text = "";
                        Label1.Text += "Invalid password";
                    }
                    else
                    {
                        db.InsertMember(member);
                        TextBox1.Text = ""; TextBox5.Text = ""; TextBox3.Text = ""; TextBox4.Text = "";
                        TextBox6.Text = ""; TextBox7.Text = "";
                        Label1.Text = "Registration successfully!";
                    }
                }
            }
            
            else Label1.Text = member.error;
            
        }
    }
}