using Microsoft.Extensions.Configuration;
using StudentDetailsWithMVC.Models;
using StudentDetailsWithMVC.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetailsWithMVC.Service
{
    public class StudentManager
    {
        private IConfiguration Configuration;
        public StudentManager(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public  List<StudentModel> CreateStudent(StudentModel model)
        {
            List<StudentModel> StudentList = new List<StudentModel>();

            try
            {
                string conString = this.Configuration.GetConnectionString(ApplicationConstant.DBConnectionString);
                 
                using (SqlConnection con = new SqlConnection(conString))
                {

                    string query = "INSERT INTO Students (Name,Age,Address,PhoneNumber) VALUES(@Name, @Age, @Address, @PhoneNumber)";
                    using (SqlCommand cmd = new SqlCommand(query))
                    {
                        cmd.Connection = con;
                        con.Open();
                        cmd.Parameters.AddWithValue("@Name", model.Name);
                        cmd.Parameters.AddWithValue("@Age", model.Age);
                        cmd.Parameters.AddWithValue("@Address", model.Address);
                        cmd.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        StudentList.Add(model);
                    }
                }

            }
            catch (Exception e)
            {

                throw e;    
            }
            
            return StudentList;
        }
    }
  
}
