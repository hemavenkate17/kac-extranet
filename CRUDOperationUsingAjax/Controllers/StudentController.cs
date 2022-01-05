using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using CRUDOperationUsingAjax.Models;

namespace CRUDOperationUsingAjax.Controllers
{
    public class StudentController : Controller
    {
        Services.StudentService studentService = new Services.StudentService();
        // GET: Student
        public ActionResult Insert_Record()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Insert_Record(StudentModel studentModel)
        {
            string result = string.Empty;
            try
            {
                studentService.Add_Data(studentModel);
                result = "your data inserted successfully";
            }
            catch (Exception)
            {
                result = "Insertion Failed";
            }
            return Json( result,JsonRequestBehavior.AllowGet);
        }
        public ActionResult Display_Record()
        {
            return View();
        }

        public JsonResult Get_Data()
        {
            DataSet ds = studentService.GetAllData();
            List<StudentModel> StudentList = new List<StudentModel>();
            

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
               


                //DateTime datetime = DateTime.ParseExact(dr["DOB"], "dd/MM/yyyy", null);
                // DateTime? val = dr["DOB"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(datetime, System.Globalization.CultureInfo.GetCultureInfo("hi-IN").DateTimeFormat);
               string val = dr["DOB"] == DBNull.Value ? null  : Convert.ToDateTime(dr["DOB"]).ToString("dd/MM/yyyy");



                StudentList.Add(new StudentModel
                {

                    ID = Convert.ToInt32(dr["ID"]),
                    Name = dr["Name"].ToString(),
                    Age = Convert.ToInt32(dr["Age"]),
                    Address = dr["Address"].ToString(),
                    PhoneNumber = dr["PhoneNumber"].ToString(),
                    strDOB = val,
                    



                }) ;
            }
            return Json(StudentList, JsonRequestBehavior.AllowGet);
        }
      
        
        public JsonResult GetDataById(int id)
        {
            DataSet ds = studentService.GetDataById(id);
            List<StudentModel> StudentList = new List<StudentModel>();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                StudentList.Add(new StudentModel
                {

                    ID = Convert.ToInt32(dr["ID"]),
                    Name = dr["Name"].ToString(),
                    Age = Convert.ToInt32(dr["Age"]),
                    Address = dr["Address"].ToString(),
                    PhoneNumber = dr["PhoneNumber"].ToString(),
                    DOB = Convert.ToDateTime(dr["DOB"]),

                });
            }
            return Json(StudentList, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Update_Record(int id)
        {
            return View();
        }
        [HttpPost]
        public JsonResult update_Record(StudentModel studentModel)
        {
            string result = string.Empty;
            try
            {
                studentService.Update_Data(studentModel);
                result = "your data updated successfully";
            }
            catch (Exception)
            {
                result = "Updation Failed";
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
     
        public ActionResult Delete_Record(int id)
        {
            try
            {
                studentService.Delete_Data(id);
            }
            catch (Exception e)
            {
                throw e;
            }
            return View();
        }

    }
}