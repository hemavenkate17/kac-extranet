using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Collections.Generic;
using AzurewithADO.NET.Utility;
using AzurewithADO.NET.Service;

namespace AzurewithADO.NET
{
    public static class StudentInfo
    {
        [FunctionName("CreateStudent")]
        public static async Task<IActionResult> CreateStudent(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "CreateStudent")] HttpRequest req,
            ILogger log)
        {

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var input = JsonConvert.DeserializeObject<StudentModel>(requestBody);
            StudentService.create(input,log);
            return new OkResult();

        }

        [FunctionName("GetStudent")]
        public static async Task<IActionResult> GetStudent(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "getStudent")] HttpRequest req, ILogger log)
        {

            //List<StudentModel> StudentList = new List<StudentModel>();
            //StudentList= await StudentService.GetStudent(log);
            List<StudentModel> StudentList = await StudentService.GetStudent(log);

            return new OkObjectResult(StudentList);

        }


        [FunctionName("UpdateStudent")]
        public static async Task<IActionResult> UpdateStudent(
        [HttpTrigger(AuthorizationLevel.Function, "put", Route = "UpdateStudent/{ID}")] HttpRequest req, ILogger log, int ID)
        {
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var input = JsonConvert.DeserializeObject<StudentModel>(requestBody);
            StudentService.update(input, ID, log);
            return new OkResult();

        }
        [FunctionName("DeleteStudent")]
        public static IActionResult DeleteStudent(
        [HttpTrigger(AuthorizationLevel.Function, "delete", Route = "DeleteStudent/{ID}")] HttpRequest req, ILogger log, int ID)
        {
            StudentService.delete( ID, log);
            return new OkResult();
        }
    }
}
