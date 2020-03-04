using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Question_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["Connstr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connect)) {
                SqlCommand cmd = new SqlCommand("Proc_1",con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("name", TextBox1.Text + "%");
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();



            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string str = TextBox1.Text;
        }
    }
}