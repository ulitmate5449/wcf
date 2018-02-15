using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ui.ServiceReference1;


namespace Ui.Connected_Services
{
    public partial class Employee : System.Web.UI.Page
    {
        customer cu = new customer();
        /*ServiceReference1.*/
        Service1Client c = new Service1Client();

        /*ServiceReference1.*/
       
        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = c.getemployee();
            GridView2.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = c.getcustomer();
            GridView2.DataBind();
        }



        protected void Button4_Click(object sender, EventArgs e)
        {
            
            cu.CustomerId = int.Parse(TextBox1.Text);
            c.DeleteCustomerById(cu.CustomerId);
            Label1.Text = "Customer Deleted Sucessfully";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            

            cu.CustomerId = Convert.ToInt32(TextBox1.Text);
        
            
                cu.Address = TextBox2.Text;
                cu.CustorName = TextBox3.Text;
                cu.EmployeeId = int.Parse(TextBox4.Text);
                c.EditCustomerById(cu);
            Label1.Text = "Customer Edit Sucessful";
         
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
          
            cu.CustomerId = int.Parse(TextBox1.Text);
            cu.Address = TextBox2.Text;
            cu.CustorName = TextBox3.Text;
            cu.EmployeeId = int.Parse(TextBox4.Text);
            c.AddCustomerer(cu); ;
            Label1.Text = "Customer Added Sucessfully";

        }
    }
}