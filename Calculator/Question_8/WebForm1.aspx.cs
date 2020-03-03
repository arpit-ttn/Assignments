using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
namespace Question_8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegisterUser(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("insert into Employee(Emp_Name,Emp_Age,Emp_Password,Emp_Email,Emp_Salary) values(@user,@age,@pass,@email,@salary)", con);
                cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                cmd.Parameters.AddWithValue("@age", txtage.Text);
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@salary",TextBox6.Text);

                //asp.net functionality depeciting proper use of nested try catch with multiple catch block
                try
                {
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        Label1.Text = "Data inserted successfully.!";
                        con.Close();
                    }
                    catch (SqlException)
                    {
                        Console.WriteLine("SQL exception");

                    }

                }
                catch (Exception)
                {
                    Console.WriteLine( "exception");

                }
            }
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Button1":
                    Label2.Text = "1st button clicked";
                    break;
                case "Button2":
                    Label3.Text = "2nd button clicked";
                    break;

            }
        }
    }
}