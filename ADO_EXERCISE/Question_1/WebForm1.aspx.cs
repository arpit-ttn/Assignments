using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Question_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //--Connection--//It is used to establish a connection to a specific data source.
            string connect = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connect))
            {
                con.Open();
                //--Command--//It is used to execute queries to perform database operations.
                SqlCommand cmd = new SqlCommand("select*from Emp;select * from Emp_Salaries",con);
                //--DataReader--//It is used to read data from data source. The DbDataReader is a base class for all DataReader objects.
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                    while(dr.NextResult())
                    {
                        GridView2.DataSource = dr;
                        GridView2.DataBind();
                        Label2.Text = "Implementation with Connected architecture";
                    }
                }

                //--DataAdapter--//It populates a DataSet and resolves updates with the data source.
                    //The base class for all DataAdapter objects is the DbDataAdapter class.
                //--Disconnected Architecture--
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Employees",con) ;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                GridView3.DataSource = dataSet;
                GridView3.DataBind();
                Label1.Text = "Implementation with Disconnected architecture";
                

            }



        }

        
    }
}