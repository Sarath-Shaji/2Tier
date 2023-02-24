using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace _2tierArchitecture
{
    public partial class LoginConnectionClass : System.Web.UI.Page
    {
        Class1 obj = new Class1(); 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string log = "select count(Id) from TwoTier where Username ='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = obj.Fn_Scalar(log);

            if (cid == "1")
            {

                string selid = "select Id from Reg where Username='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'";
                string id = obj.Fn_Scalar(selid);
                Session["userid"] = id;
                Response.Redirect("Profile.aspx");
            }
            else
            {
                Label1.Text = "Invalid Username or Password";
            }
        }
    }
}