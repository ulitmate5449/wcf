using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ui.ServiceReference1;

namespace Ui
{
    public partial class Customer : System.Web.UI.Page
    {
        customer cu = new customer();

        Service1Client c = new Service1Client();


        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = c.getemployee();
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = c.getcustomer();
            GridView1.DataBind();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

            cu.CustomerId = int.Parse(TextBox1.Text);
            cu.Address = TextBox2.Text;
            cu.CustorName = TextBox3.Text;
            cu.EmployeeId = int.Parse(TextBox4.Text);
            c.AddCustomerer(cu); ;
            Label2.Text = "Customer Added Sucessfully";
            Label2.ForeColor = System.Drawing.Color.DarkSeaGreen;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            cu.CustomerId = Convert.ToInt32(TextBox1.Text);


            cu.Address = TextBox2.Text;
            cu.CustorName = TextBox3.Text;
            cu.EmployeeId = int.Parse(TextBox4.Text);
            c.EditCustomerById(cu);
            Label2.Text = "Customer Edit Sucessful";
            Label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            cu.CustomerId = int.Parse(TextBox1.Text);
            c.DeleteCustomerById(cu.CustomerId);
            Label2.Text = "Customer Deleted Sucessfully";
            Label2.ForeColor = System.Drawing.Color.Red;
        }

       
    }
}
