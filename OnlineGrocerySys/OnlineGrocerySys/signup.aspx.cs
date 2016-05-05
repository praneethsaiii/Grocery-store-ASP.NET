using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineGrocerySys
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OnlineGrocerySys.WebService1 og = new OnlineGrocerySys.WebService1();
            string name = TextBox1.Text;
            string email = TextBox2.Text;
            string pwd = TextBox3.Text;
            string cpwd = TextBox4.Text;
            string pan = TextBox5.Text;
            if (pwd == cpwd)
            {
                og.signup(name, email, pwd, cpwd, pan);
                Response.Redirect("login.aspx");
                
               
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('password and confirm password is not same')", true);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}