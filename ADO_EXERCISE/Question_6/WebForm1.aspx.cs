using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Question_6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void DISPLAY()
        {
            string connect = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            SqlConnection sq = new SqlConnection(connect);
            sq.Open();

            SqlCommand cmd = new SqlCommand("select*from Emp", sq);
            SqlDataReader reader = cmd.ExecuteReader();
            GridView1.DataSource = reader;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connect = ConfigurationManager.ConnectionStrings["Connstr"].ConnectionString;
            SqlConnection sq = new SqlConnection(connect);
            sq.Open();
            SqlTransaction trans = sq.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("update Emp set Salary =Salary+100 where Emp_id=108 ",sq,trans);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("update Emp set Salary =Salary+100 where Emp_id=106", sq, trans);
                cmd.ExecuteNonQuery();
                trans.Commit();
                Label1.Text = "Transaction Committed.";
            }
            catch
            {
                trans.Rollback();
                Label1.Text = "Transaction Failed! and Rolled back to previous state";
            }
            finally
            {
                sq.Close();
            }
            DISPLAY();

        }
    }
}