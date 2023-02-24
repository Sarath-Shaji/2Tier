using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2tierArchitecture
{
    public partial class UserInsert : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/PCTRS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string str = "insert into TwoTier values('" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + path + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.Fn_Nonquery(str);
            if (i != 0)
            {
                Label1.Text = "Inserted";
            }
        }
    }
}