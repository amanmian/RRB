using RB3._2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RB3._2.Dtos
{
    public class StudentDto
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Class { get; set; }
        public StudentDetailDto studentdetails { get; set; }
    }
}