using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDOperationUsingAjax.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public int  Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; } 

        public DateTime?  DOB { get; set; }

        public string strDOB { get; set; }
    }
}