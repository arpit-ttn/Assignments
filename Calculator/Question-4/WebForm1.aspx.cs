using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = "it is the first request to the server";
            }
            else 
            {
                Label1.Text = "It is a post back request";
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}