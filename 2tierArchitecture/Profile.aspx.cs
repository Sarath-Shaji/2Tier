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
    public partial class Profile : System.Web.UI.Page
    {
        Class1 obj = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select Name,Age,Address,Photo from TwoTier where Id=" + Session["userid"] + "";

            
      
          SqlDataReader dr = obj.Fn_Reader(sel);

            while (dr.Read())
            {
                TextBox1.Text = dr["Name"].ToString();
                TextBox2.Text = dr["Age"].ToString();
                TextBox3.Text = dr["Address"].ToString();
                Image1.ImageUrl = dr["Photo"].ToString();
            }

            //GridView using dataset
            DataSet ds = obj.Fn_Dataset(sel);
            GridView1.DataSource = ds;
            GridView1.DataBind();


            //Datalist using datatable
            DataTable dt = obj.Fn_Datatable(sel);
            DataList1.DataSource = dt;
            DataList1.DataBind();

        }
    }
}