using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsertdataUsingJQuery.Models
{
    public class StudentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public DateTime DOB { get; set; }
    }
}