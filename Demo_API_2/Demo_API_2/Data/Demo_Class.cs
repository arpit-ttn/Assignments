using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Demo_API_2.Models;

namespace Demo_API_2.Data
{
    public class Demo_Class
    {
        string Connect = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
       
        public DataSet GetData()
        {
            
            using (SqlConnection con = new SqlConnection(Connect))
            {
                SqlCommand sqlcmd = new SqlCommand("select *from Model_Class", con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlcmd);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                return dataset;

            }

        }
        public DataSet GetData(int id)
        {
            Model_Class model = new Model_Class();
            using (SqlConnection sqlConnection = new SqlConnection(Connect))
            {
                SqlCommand command = new SqlCommand("select * from Model_Class where Id=" + id + " ", sqlConnection);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;

            }
        }

       

        public bool InsertData(Model_Class model_Class)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Connect);
                SqlCommand command = new SqlCommand("insert into model_Class(Id,Months,Salary) values (@id,@m,@s)", sqlConnection);
                command.Parameters.AddWithValue("@id", model_Class.Id);
                command.Parameters.AddWithValue("@m", model_Class.Months);
                command.Parameters.AddWithValue("@s", model_Class.Salary);
                sqlConnection.Open();
                int result = command.ExecuteNonQuery();
                if (result > 0)
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool UpdateData(int id, Model_Class model_Class)
        {
            try
            {

                SqlConnection sqlConnection = new SqlConnection(Connect);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("update model_Class set Months=@m where Id="+id, sqlConnection);
                command.Parameters.AddWithValue("@id", model_Class.Id);
                command.Parameters.AddWithValue("@m", model_Class.Months);
                //command.Parameters.AddWithValue("@marks",student.MARKS);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteData(int id)
        {
            try
            {
                Model_Class model_Class = new Model_Class();
                SqlConnection sqlConnection = new SqlConnection(Connect);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("delete from Model_Class where Id=" + id + " ", sqlConnection);

                int result = command.ExecuteNonQuery();
                sqlConnection.Close();
                if (result > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}