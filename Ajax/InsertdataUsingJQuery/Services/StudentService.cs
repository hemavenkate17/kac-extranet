using InsertdataUsingJQuery.Models;
using InsertdataUsingJQuery.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InsertdataUsingJQuery.Services
{

    public class StudentService
    {
       
        public static string conStr = ConfigurationManager.ConnectionStrings[AppConstant.MyConnectionString].ConnectionString;
        public static List<StudentModel> CreateStudentInfo(StudentModel model)
        {
            List<StudentModel> StudentList = new List<StudentModel>();

            SqlConnection con = new SqlConnection(conStr);
            try
            {
                SqlCommand cmd = new SqlCommand("Student_CRUD");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                con.Open();
                cmd.Parameters.AddWithValue("@Action", "Create");
                cmd.Parameters.AddWithValue("@Name", model.Name);
                cmd.Parameters.AddWithValue("@Age", model.Age);
                cmd.Parameters.AddWithValue("@Address", model.Address);
                cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                cmd.Parameters.AddWithValue("@DOB", model.DOB.Date);
                cmd.ExecuteNonQuery();

                StudentList.Add(model);
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                con.Close();

            }

            return StudentList;
        }

        public static List<StudentModel> SelectStudentInfo(StudentModel model)
        {
            List<StudentModel> ListOfStudents = new List<StudentModel>();

            SqlConnection con = new SqlConnection(conStr);

            try
            {
                SqlCommand cmd = new SqlCommand("Student_CRUD");
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Action", "Select");
                cmd.ExecuteNonQuery();
                //SqlDataAdapter dataAdapter = new SqlDataAdapter();
                //DataSet ds = new DataSet();
                //dataAdapter.Fill(ds);
                //return ds;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ListOfStudents.Add(new StudentModel
                    {
                        ID = Convert.ToInt32(rdr["ID"]),
                        Name = rdr["Name"].ToString(),
                        Age = Convert.ToInt32(rdr["Age"]),
                        Address = rdr["Address"].ToString(),
                        PhoneNumber = rdr["PhoneNumber"].ToString(),
                        DOB = Convert.ToDateTime(rdr["DOB"]),
                    });
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
            return ListOfStudents;
        }
    }
}