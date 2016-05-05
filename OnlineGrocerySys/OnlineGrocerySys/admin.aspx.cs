using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace OnlineGrocerySys
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            OnlineGrocerySys.WebService1 og = new OnlineGrocerySys.WebService1();
            DataSet ds1 = og.viewusers();

            GridView1.DataSource = ds1.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OnlineGrocerySys.WebService1 og = new OnlineGrocerySys.WebService1();
            string cat = DropDownList1.SelectedItem.Text;
            string pid = TextBox1.Text;
            string pname = TextBox2.Text;
            string quantity = TextBox3.Text;
          //  int qua = int.Parse(quantity);
            string price = TextBox4.Text;
           // int p = int.Parse(price)*qua;
            
           /* int d = (p * 15) / 100;
            string discount = d.ToString();*/
           og.admininsert(cat, pid, pname, quantity, price);
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (Session["email"] != null)
            {
                Session.Remove("email");

                Response.Redirect("login.aspx");
            }
            else
            {
                Console.WriteLine("there is no active session");
            }
        }
    }
}