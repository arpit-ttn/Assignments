using Core_API.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Core_API.Data
{
    public class EmployeeData : IEmployee
    {
        private readonly IOptions<Connection> _connection;


        public EmployeeData(IOptions<Connection> connection)
        {
            _connection = connection;
        }

        public DataSet GetData()
        {
            string con = _connection.Value.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("select * from Model_Class", sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }
        public DataSet GetDataId(int id)
        {
            string con = _connection.Value.ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("select * from Model_Class where Id=" + id, sqlConnection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            return dataSet;
        }

        public bool InsertData(Employee employee)
        {
            string con = _connection.Value.ConnectionString;

            try
            {


                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("insert into Model_Class(Id,Months,Salary) values(@id,@m,@s)", sqlConnection);
                command.Parameters.AddWithValue("@id", employee.Id);
                command.Parameters.AddWithValue("@m", employee.Months);
                command.Parameters.AddWithValue("@s", employee.Salary);

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
            finally
            {

            }
        }

        public bool UpdateData(int id, Employee employee)
        {
            string con = _connection.Value.ConnectionString;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(con);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("update Model_Class set Salary=@s where Id=  " + id, sqlConnection);

                command.Parameters.AddWithValue("@id", employee.Id);
                command.Parameters.AddWithValue("@s", employee.Salary);


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
            finally
            {

            }
        }

        public bool DeleteData(int id)
        {
            string con = _connection.Value.ConnectionString;
            try
            {
                Employee employee = new Employee();
                SqlConnection sqlConnection = new SqlConnection(con);
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
