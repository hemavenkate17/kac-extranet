using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctionApp
{
    
    
    public static class HttpTriggerFunction
    {
        [FunctionName("HttpTriggerFunction")]




        public static async Task<IActionResult> Run(
                [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
                ILogger log)
        {
           
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            PostData myClass = JsonConvert.DeserializeObject<PostData>(requestBody);
            return new OkObjectResult(myClass);

            //string name = req.Query["name"];
            //string Age = req.Query["Age"];


            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            //dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;
            //Age = Age ?? data?.Age;




            //string responseMessage = string.IsNullOrEmpty(name)
            //  ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            //  : $"Welcome to AzureFunction App, {name} " +
            //   $"your age is {Age}" +
            //   $" You are verified";

            // return new OkObjectResult(responseMessage);

            //string num = req.Query["num"];


            //string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            ////dynamic data = JsonConvert.DeserializeObject(requestBody);
            ////name = name ?? data?.name;
            //int radius = Int32.Parse(num);
            //double area = 3.14 * radius;


            ////string responseMessage = string.IsNullOrEmpty(area)
            ////    ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
            ////    : $"Hello, {area}. This HTTP triggered function executed successfully.";
            //string responseMessage = $"Area of the circle for the given radius is {area}. This HTTP triggered function executed successfully.";

            //  return new OkObjectResult(responseMessage);
        }


    }
    }
//[Route("HttpTriggerFunction/{ID}/{Name}")]


//public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "HttpTriggerFunction/{ID}/{Name}")] HttpRequestMessage req, string ID, string Name, TraceWriter log)
//{
//    log.Info("C# HTTP trigger function processed a request.");
//    var msg = $"ID: {ID}, Name: {Name}";
//    // Fetching the name from the path parameter in the request URL
//    return req.CreateResponse(HttpStatusCode.OK, msg);
//}


//string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
//PostData myClass = JsonConvert.DeserializeObject<PostData>(requestBody);
//return new OkObjectResult(myClass);