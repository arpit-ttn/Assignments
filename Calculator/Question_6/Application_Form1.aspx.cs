using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_6
{
    public partial class Application_Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Application["UserName"] = TextBox1.Text;
            Application["Password"] = TextBox2.Text;
            Response.Redirect("Application_Form2.aspx");
        }
    }
}