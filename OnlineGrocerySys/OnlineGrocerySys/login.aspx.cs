using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineGrocerySys
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Accessing the cookie
            HttpCookie cookie = Request.Cookies["login"];
            //if cookie is not null restore the details in textbox
            if (cookie != null)
            {
                TextBox1.Text = cookie.Values["email"];
                TextBox2.Text = cookie.Values["pwd"];
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = null;
            OnlineGrocerySys.WebService1 og = new OnlineGrocerySys.WebService1();
            string email = TextBox1.Text;
            string pwd = TextBox2.Text;

            Session["email"] = email;
           
            string valid = og.login(email, pwd);
            if (valid.Equals("valid user"))
            {
                Response.Redirect("Home.aspx");

            }
            else
            {
                Response.Redirect("login.aspx");
            }
            if (CheckBox1.Checked)
            {
                //Create cookie to remember user id and password
                cookie = new HttpCookie("login");
                cookie.Values.Add("email", email);
                cookie.Values.Add("pwd", pwd);
                cookie.Expires = DateTime.Now.AddMinutes(60);
                Response.Cookies.Add(cookie);
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            OnlineGrocerySys.ValidationSoapHeader ob = new OnlineGrocerySys.ValidationSoapHeader();
            string s1 = TextBox3.Text;
            int s2 = int.Parse(TextBox4.Text);
            ob.DevToken = s1;
            ob.DevToken1 = s2;
            Session["email"] = s1;
            Session["pwd"] = s2;
            OnlineGrocerySys.WebService1 access = new OnlineGrocerySys.WebService1();
            access.Authentication = ob;
            string valid=access.HelloWorld();
            if(valid.Equals("logged in"))
            {
                Response.Redirect("admin.aspx");
            }
            else
            {
                Response.Redirect("login.aspx");
            }
          
        }
    }
}