using InsertdataUsingJQuery.Models;
using InsertdataUsingJQuery.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsertdataUsingJQuery.Controllers
{
    public class StudentController : Controller
    {

        // GET: Student
        public ActionResult InsertStudentDetails()
        {
            return View();
        }
        [HttpPost]
        public ActionResult InsertStudentDetails(StudentModel model)
        {
            List<StudentModel> StudentList = StudentService.CreateStudentInfo(model);

            
            StudentModel modeldata = new StudentModel();
            foreach (var item in StudentList)
            {
                modeldata.Name = item.Name;
                modeldata.Age = item.Age;
                modeldata.Address = item.Address;
                modeldata.PhoneNumber = item.PhoneNumber;
                modeldata.DOB = item.DOB;

            }
            return View(modeldata);
        }
        [HttpGet]
        public ActionResult DisplayStudentDetails(StudentModel model)
        {
            List<StudentModel> StudentList = StudentService.SelectStudentInfo(model);


            StudentModel modeldata = new StudentModel();
            foreach (var item in StudentList)
            {
                modeldata.Name = item.Name;
                modeldata.Age = item.Age;
                modeldata.Address = item.Address;
                modeldata.PhoneNumber = item.PhoneNumber;
                modeldata.DOB = item.DOB;

            }
            return View(modeldata);
        }
    }
}