using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace _2tierArchitecture
{
    public partial class Ajax : System.Web.UI.Page
    {
        Class1 ob = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLocalTime().ToLongTimeString();
            if (!IsPostBack)
            {
                string sel = "select Id,Name from Reg";
                DataSet ds = ob.Fn_Dataset(sel);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Id";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, "-select-");
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = "select * from Reg where Id = " + DropDownList1.SelectedItem.Value + "";
            DataSet ds = ob.Fn_Dataset(str);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}