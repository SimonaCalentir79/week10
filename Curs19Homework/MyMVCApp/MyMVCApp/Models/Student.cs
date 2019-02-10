using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApp.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name="Name")]
        public string StudentName { get; set; }

        public int Age { get; set; }

        //public Standard standard { get; set; }
    }
}