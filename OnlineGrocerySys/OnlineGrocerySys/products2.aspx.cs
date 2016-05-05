using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;


namespace OnlineGrocerySys
{
    public partial class products2 : System.Web.UI.Page
    {

        OnlineGrocerySys.WebService1 og = new OnlineGrocerySys.WebService1();
       string sel, category, productid, productname, price;

       



        public object CheckBox1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {






        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            DataSet ds1 = og.products();

            GridView1.DataSource = ds1.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("cart.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string data = string.Empty;

            foreach (GridViewRow row in GridView1.Rows)
            {


                CheckBox chkRow = (CheckBox)row.FindControl("CheckBox1");

                if (chkRow.Checked && chkRow != null)
                {


                    sel = row.Cells[0].Text;
                    price = row.Cells[1].Text;

                    productid = row.Cells[2].Text;
                    productname = row.Cells[3].Text;
                    category = row.Cells[4].Text;
                   data = data + category + "," + productid + "," + productname + "," + price + ",";
                    
                }
               Label4.Text = data;

                
            }
            Response.Write("<script>alert('ITEMS ADDED SUCCESSFULLY');</script>");
            Session["select"] = sel;
            Session["productid"] = productid;

            /*   string[] ids = this.GridView1.Rows
 .OfType<GridViewRow>()
 .Where(r => r.RowType == DataControlRowType.DataRow)
 .Select(r => ((CheckBox)r.FindControl("CheckBox1")).Text)
 .ToArray();
               if (ids != null)
               {

                       sel = row.Cells[0].ToString();
                       price = row.Cells[1].ToString();
                       productid = row.Cells[2].ToString();
                       productname = row.Cells[3].ToString();
                       category = row.Cells[4].ToString();
                       data = data + category + "," + productid + "," + productname + "," + price + ",";

               }

              */


            /*      ArrayList categoryIDList = new ArrayList();
                  int index = -1;
                  string ind;
                  foreach (GridViewRow row in GridView1.Rows)
                  {
                      ind = index.ToString();
                      ind = GridView1.DataKeys[row.RowIndex].Value.ToString();


                      bool result = ((CheckBox)row.FindControl("CheckBox1")).Checked;
                      if(result==true)
                      {
                          sel = row.Cells[0].ToString();
                          price = row.Cells[1].ToString();
                          productid = row.Cells[2].ToString();
                          productname = row.Cells[3].ToString();
                          category = row.Cells[4].ToString();
                      }
                      Session["select"] = sel;
                      Session["productid"] = productid;

                     // Check in the Session
                      if (Session["select"] != null)
                          categoryIDList = (ArrayList)Session["select"];

                      if (result)
                      {
                          if (!categoryIDList.Contains(ind))
                              categoryIDList.Add(ind);
                      }
                      else
                          categoryIDList.Remove(ind);
                  }
                  if (categoryIDList != null && categoryIDList.Count > 0)

                  Session["productid"] = categoryIDList;
                  */
        }
        
    }
}
             

           
        
    




