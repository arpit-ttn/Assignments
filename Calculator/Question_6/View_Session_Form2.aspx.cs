using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Question_6
{
    public partial class View_Form2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox3.Text = Session["UserName"].ToString();
            TextBox4.Text = Session["Password"].ToString();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["UserName"] = TextBox1.Text;
            ViewState["Password"] = TextBox2.Text;
            Session["UserName"] = TextBox3.Text;
            Session["Password"] = TextBox4.Text;
        }
    }
}