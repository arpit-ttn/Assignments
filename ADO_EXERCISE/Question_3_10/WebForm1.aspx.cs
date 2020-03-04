using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Question_3_10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        //Q-10) Handle the connection properly and descibe the various ways to handle the database connection.
        //One way is to use try catch and other is using. 
            try
            {
                string connect = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connect))
                {
                    con.Open();
                    //Execute Reader
                    SqlCommand cmd = new SqlCommand("select*from Emp", con);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        GridView1.DataSource = dr;
                        GridView1.DataBind();

                    }
                    //Execute Scalar
                    SqlCommand command = new SqlCommand("Select count(Emp_ID) from Emp", con);
                    int res = (int)command.ExecuteScalar();
                    Response.Write("Total Number of employees are" + res);
                    Response.Write("<br/><br/><br/>");

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string connect = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connect))
                {
                    //Execute NonQuery
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into Emp_Salaries(Emp_id,Months,Salaries)values (@id,@m,@s)", con);
                    sqlCommand.Parameters.AddWithValue("@id", TextBox1.Text);
                    sqlCommand.Parameters.AddWithValue("@m", TextBox3.Text);
                    sqlCommand.Parameters.AddWithValue("@s", TextBox2.Text);
                    sqlCommand.ExecuteNonQuery();
                    Label3.Text = "Values Inserted";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Response.Write("Connection string not found!!!!");
            }
        }
    }
}