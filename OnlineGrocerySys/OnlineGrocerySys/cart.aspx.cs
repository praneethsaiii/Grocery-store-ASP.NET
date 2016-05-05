using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace OnlineGrocerySys
{
    public partial class cart : System.Web.UI.Page
    {
        OnlineGrocerySys.WebService1 og = new OnlineGrocerySys.WebService1();
       // string sel, productid;
      
        protected void Page_Load(object sender, EventArgs e)
        {

            
            email.Text = Session["email"].ToString();
            
            string cid =Session["select"].ToString();
            string pid = Session["productid"].ToString();

              DataSet ds;

              int cm;

              if (pid != null)
              {
                   ds = og.getdetails(pid);

                  GridView1.DataSource = ds.Tables[0].DefaultView;
                  GridView1.DataBind();
                  cm = Convert.ToInt32(ds.Tables[0].Rows[0]["price"]);
                  Session["pc"] = cm;
              }
             int price = Convert.ToInt32(Session["pc"]);

            

              Label3.Text = price.ToString();
              if (GridView1.Rows.Count < 1)
              {

                  Button1.Visible = false;

                  Label2.Text = "No Active Cart Found";
                  Label3.Visible = false;
              }
              else
              {


                  Label2.Visible = false;
              }
              




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*
           if (Session["productid"] != null)
            {
                Session.Remove("productid");

                Session.Clear();
            }
            else
            {
                Console.WriteLine("there is no active cart");
            }*/
            Response.Redirect("payment.html");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
        
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
           /* foreach (GridViewRow row in GridView1.Rows)
            {
               

                CheckBox chkRow = (CheckBox)row.FindControl("RemovedProducts");

                if (chkRow.Checked && chkRow != null)
                {

                    sel = row.Cells[0].Text;
                    productid = row.Cells[2].Text;
                    

                    Response.Write("<script>alert('ITEMS ADDED SUCCESSFULLY');</script>");

                }
                Session["select1"] = sel;
                Session["productid"] = productid;

            }
        

            if (Session["productid"] != null )
              {
                  Session.Remove("productid");
                  Session.Remove("select1");

                  Response.Redirect("cart.aspx");
                Label2.Text = "PRODUCT REMOVED FROM THE CART SUCCESSFULLY";
              }
              else
              {
                  Console.WriteLine("there is no active cart");
              }
              */
            
        }
    
        

        

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}