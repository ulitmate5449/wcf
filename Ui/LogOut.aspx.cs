using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ui
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string uname = string.Empty;
            if (Session["uname"] !=null)
            {
                uname = Session["uname"].ToString();
                Session.Abandon();
                Label1.Text = uname+" logout sucesfully";
                Label1.ForeColor = System.Drawing.Color.GreenYellow;

            }
            else
            {
                Label1.Text = "invalid entry";
                Label1.ForeColor = System.Drawing.Color.Red;

            }
        }
    }
}