using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using System.Web.Services.Protocols;

namespace OnlineGrocerySys
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ValidationSoapHeader : SoapHeader
    {
        private string _devtoken;
        private int _devtoken1;

        public ValidationSoapHeader()
        {

        }
        public ValidationSoapHeader(string devtoken)
        {
            this._devtoken = devtoken;
        }
        public ValidationSoapHeader(int devtoken1)
        {

            this._devtoken1 = devtoken1;
        }
        public string DevToken
        {
            get { return this._devtoken; }
            set { this._devtoken = value; }

        }
        public int DevToken1
        {

            get { return this._devtoken1; }
            set { this._devtoken1 = value; }
        }




    }
    public class WebService1 : System.Web.Services.WebService
    {

        public ValidationSoapHeader Authentication;
        private const string DEV_TOKEN = "praneeth@gmail.com";
        private const int DEV1_TOKEN = 18290;


        [SoapHeader("Authentication")]

        [WebMethod]
        public string HelloWorld()
        {
            if (Authentication != null && Authentication.DevToken == DEV_TOKEN && Authentication.DevToken1 == DEV1_TOKEN)
            {

                return "logged in";
            }
            else
            {
                return "YOU ARE NOT ADMIN!!";

            }

        }
        [WebMethod]
        public DataSet signup(string name, string email, string pwd, string cpwd, string pan)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\sai\\Documents\\ogs.mdb");

            OleDbDataAdapter da = new OleDbDataAdapter("insert into signup values('" + name + "', '" + email + "', '" + pwd + "','" + cpwd + "','" + pan + "')", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        [WebMethod]
        public string login(string email, string pwd)
        {


            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\\Users\\sai\\Documents\\ogs.mdb");
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from signup where email='" + email + "' and pwd='" + pwd + "'", con);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return ("valid user");
            else
                return ("not  a valid user");
            
        }
        [WebMethod]
        public DataSet viewusers()
        {


            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\\Users\\sai\\Documents\\ogs.mdb");
            OleDbDataAdapter dr = new OleDbDataAdapter("select uname,email,pan from signup", con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            return ds;
        }
        [WebMethod]
        public DataSet admininsert(string cat,string pid,string pname,string quan,string price)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\sai\\Documents\\ogs.mdb");

            OleDbDataAdapter da = new OleDbDataAdapter("insert into products values('" + cat + "', '" + pid + "', '" + pname + "','" + quan + "','" + price + "')", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }
        [WebMethod]
        public DataSet getdetails(string pid)
        {


            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\\Users\\sai\\Documents\\ogs.mdb");
           
            OleDbDataAdapter cmd = new OleDbDataAdapter("select price,productid,productname,category from products where productid='"+pid+"'", con);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            return ds;
          
        }
        [WebMethod]
        public DataSet products()
        {


            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =C:\\Users\\sai\\Documents\\ogs.mdb");
            OleDbDataAdapter dr = new OleDbDataAdapter("select category,productid,productname,price from products", con);
            DataSet ds = new DataSet();
            dr.Fill(ds);
            return ds;
        }
        [WebMethod]
        public DataSet addcart(string product)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\sai\\Documents\\ogs.mdb");

            OleDbDataAdapter da = new OleDbDataAdapter("insert into cart values('" + product + "')", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;


        }

    }
}
