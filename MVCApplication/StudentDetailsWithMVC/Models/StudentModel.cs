﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentDetailsWithMVC.Models
{
    public class StudentModel
    {

        public int ID { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Age is required.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required.")]
        public string PhoneNumber { get; set; }

    }
}
