using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCAJAX.Models
{
    public class StudentModel
    {
        public int studentID { get; set; }
        public string studentName { get; set; }
        public string studentLastName { get; set; }
        public int studentCode { get; set; }
        public string studentAdress { get; set; }
    }
}