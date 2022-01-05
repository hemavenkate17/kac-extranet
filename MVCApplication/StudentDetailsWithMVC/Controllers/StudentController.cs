using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using StudentDetailsWithMVC.Models;
using StudentDetailsWithMVC.Service;
using StudentDetailsWithMVC.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetailsWithMVC.Controllers
{
    public class StudentController : Controller
    {

        private IConfiguration Configuration;

        public StudentController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }
        public IActionResult AddStudent()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddStudent(StudentModel model)
        {
            StudentManager studentManager = new StudentManager(Configuration);
            List<StudentModel> StudentList = studentManager.CreateStudent(model);

            if (StudentList.Count > 0)
            {
                ViewBag.message = "Your details are updated successfully";
            }
            StudentModel modeldata = new StudentModel();
            foreach (var item in StudentList)
            {
                modeldata.Name = item.Name;
                modeldata.Age = item.Age;
                modeldata.Address = item.Address;
                modeldata.PhoneNumber = item.PhoneNumber;
            }
            return View(modeldata);
        }

    }
}
