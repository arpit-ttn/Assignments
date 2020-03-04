using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Question_7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("improve system performance with the use of database caching and disconnected architecure");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sc = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            if (Cache["Store"] == null)
            {
                using (SqlConnection sq = new SqlConnection(sc))
                {
                    SqlDataAdapter sa = new SqlDataAdapter("select * from Emp_Salaries", sq);
                    DataSet ds = new DataSet();
                    sa.Fill(ds);

                    GridView1.DataSource = ds;
                    GridView1.DataBind();

                    Cache["Store"] = ds;
                    Label1.Text = "data came from database";

                }
            }
            else
            {

                GridView2.DataSource = (DataSet)Cache["Store"];
                GridView2.DataBind();
                Label1.Text = "data came from cache";
            }
        }
    }
}