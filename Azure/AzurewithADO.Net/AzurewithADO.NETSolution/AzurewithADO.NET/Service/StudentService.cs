using AzurewithADO.NET.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace AzurewithADO.NET.Service
{
   public static class  StudentService
    {
        public static void create(StudentModel input, ILogger log)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(Environment.GetEnvironmentVariable(ApplicationConstant.DBConnectionString)))
                {
                    sqlConnection.Open();

                    var query = $"INSERT INTO Students (Name,Age,Address,PhoneNumber) VALUES('{input.Name}', '{input.Age}' , '{input.Address}' , '{input.PhoneNumber}')";
                    SqlCommand cmd = new SqlCommand(query, sqlConnection);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception e)
            {
                log.LogError(e.ToString());
               
            }
        }
        public static async Task<List<StudentModel>> GetStudent(ILogger log)
        {
            List<StudentModel> StudentList = new List<StudentModel>();
            try
            {
                using (SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable(ApplicationConstant.DBConnectionString)))
                {
                    connection.Open();
                    var query = @"Select * from Students";
                    SqlCommand command = new SqlCommand(query, connection);
                    var reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        StudentModel model = new StudentModel()
                       {
                            ID = (int)reader["ID"],
                            Name = (string)reader["Name"],
                            Age = (int)reader["Age"],
                            Address = (String)reader["Address"],
                            PhoneNumber = (string)reader["PhoneNumber"],


                        };
                        StudentList.Add(model);

                    }
                }
            }
            catch (Exception e)
            {
                log.LogError(e.ToString());

            }
            return StudentList;
           // StudentInfo.GetStudent(StudentList);
        }
      
        public static void update(StudentModel input, int ID, ILogger log)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable(ApplicationConstant.DBConnectionString)))
                {
                    connection.Open();
                    var query = @"Update Students Set Name = @Name , Age = @Age, Address = @Address, PhoneNumber = @PhoneNumber Where ID = @ID";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@Name", input.Name);
                    command.Parameters.AddWithValue("@Age", input.Age);
                    command.Parameters.AddWithValue("@Address", input.Address);
                    command.Parameters.AddWithValue("@PhoneNumber", input.PhoneNumber);
                    command.Parameters.AddWithValue("@ID", ID);


                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                log.LogError(e.ToString());
            }
        }
        public static void delete( int ID, ILogger log)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Environment.GetEnvironmentVariable(ApplicationConstant.DBConnectionString)))
                {
                    connection.Open();
                    var query = @"Delete from Students Where ID= @ID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                log.LogError(e.ToString());
            }
        }
      

    }
}
