using CRUDOperationUsingAjax.Models;
using CRUDOperationUsingAjax.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUDOperationUsingAjax.Services
{
    public class StudentService
    {
        public static string conStr = ConfigurationManager.ConnectionStrings[AppConstant.MyConnectionString].ConnectionString;

        //get all data 
        public DataSet GetAllData()
        {
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                SqlCommand command = new SqlCommand("Student_CRUD", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "SelectAll");
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception e)
            {

                throw e;
            }
         
        }

        // get data using ID
        public DataSet GetDataById(int id)
        {
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                SqlCommand command = new SqlCommand("Student_CRUD", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "SelectById");
                command.Parameters.AddWithValue("@ID", id);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        //inserting data

        public void Add_Data(StudentModel model)
        {
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                SqlCommand command = new SqlCommand("Student_CRUD", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "Create");
                command.Parameters.AddWithValue("@Name", model.Name);
                command.Parameters.AddWithValue("@Age", model.Age);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("@DOB", model.DOB);
                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }

        }
        public void Update_Data(StudentModel model)
        {
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                SqlCommand command = new SqlCommand("Student_CRUD", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "Update");
                command.Parameters.AddWithValue("@ID", model.ID);
                command.Parameters.AddWithValue("@Name", model.Name);
                command.Parameters.AddWithValue("@Age", model.Age);
                command.Parameters.AddWithValue("@Address", model.Address);
                command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                command.Parameters.AddWithValue("@DOB", model.DOB);
                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }
        }
        public void Delete_Data(int id)
        {
            SqlConnection con = new SqlConnection(conStr);
            try
            {
                SqlCommand command = new SqlCommand("Student_CRUD", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Action", "Delete");
                command.Parameters.AddWithValue("@ID", id);
                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();
            }
        }
    }
}