using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RB3._2.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Class { get; set; }
        public StudentDetail studentdetails { get; set; }
    }
}