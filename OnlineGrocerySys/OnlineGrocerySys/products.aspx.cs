using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineGrocerySys
{
    
    public partial class products1 : System.Web.UI.Page
    {
        OnlineGrocerySys.WebService1 og = new OnlineGrocerySys.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("cart.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string c1 = CheckBox1.Text;
                
            string c2 = CheckBox2.Text;
            string c3 = CheckBox3.Text;
            string c4 = CheckBox4.Text;
            string c5 = CheckBox5.Text;
            string c6 = CheckBox6.Text;
            string c7 = CheckBox7.Text;
            string c8 = CheckBox8.Text;
            Session["c1"] = c1;
            Session["c2"] = c2;
            Session["c3"] = c3;
            Session["c4"] = c4;
            Session["c5"] = c5;
            Session["c6"] = c6;
            Session["c7"] = c7;
            Session["c8"] = c8;

            Response.Write("<script>alert('ITEMS ADDED SUCCESSFULLY');</script>");
        }
    }
}