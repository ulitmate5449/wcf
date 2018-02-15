using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

using Ui.ServiceReference1;

namespace Ui
{
    public partial class Login : System.Web.UI.Page
    {
        Service1Client c = new Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        //private bool Aunthenticate(string uname,int pswd)
        //{
        //    bool status = false;
        //    SqlConnection cn = new SqlConnection(@"Server=DESKTOP-04UFPDD\SQLEXPRESS;Trusted_Connection=True;Database=MyProjectDB");
        //    cn.Open();
        //    string query = "select * from customers where  CustorName=@uname and CustomerId=@pswd";
        //    SqlCommand cmd = new SqlCommand(query, cn);
        //    cmd.Parameters.Add(new SqlParameter("@uname", TextBox1.Text));
        //    cmd.Parameters.Add(new SqlParameter("@pswd", TextBox2.Text));
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if(dr.HasRows)
        //    {
        //        status = true;
        //    }
        //    return status;



        

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (c.authenticate(TextBox1.Text,int.Parse(TextBox2.Text)))
            {
                Session["uname"] = TextBox1.Text;
                Session["pswd"] = TextBox2.Text;
                Response.Redirect("Dashboard.aspx");

            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}