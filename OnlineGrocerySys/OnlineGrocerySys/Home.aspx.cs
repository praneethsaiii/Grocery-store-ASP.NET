using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineGrocerySys
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblwelcome.Text = Session["email"].ToString();
            
        }

        protected void btnBrowse_Click(object sender, EventArgs e)
        {
            Response.Redirect("products.aspx");
        }

        protected void btnAboutUs_Click(object sender, EventArgs e)
        {
            Response.Redirect("about.aspx");
        }

        protected void btnOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("myorders.aspx");
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            Response.Redirect("forgot.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            /*Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("login.aspx");*/
            if (Session["email"] != null )
            {
                Session.Remove("email");
                
                Response.Redirect("login.aspx");
            }
            else
            {
                 Console.WriteLine("there is no active session");
            }
        }

        protected void XmlDataSource1_Transforming(object sender, EventArgs e)
        {

        }

        protected void AdRotator1_AdCreated(object sender, AdCreatedEventArgs e)
        {

        }

        protected void AdRotator1_AdCreated1(object sender, AdCreatedEventArgs e)
        {

        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("products2.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("cart.aspx");
        }
    }
}