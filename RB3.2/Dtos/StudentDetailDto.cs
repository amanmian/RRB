﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RB3._2.Dtos
{
    public class StudentDetailDto
    {
        [Key]
        public int Id { get; set; }
        public string PermanentAddress { get; set; }
        public string CurrentAddress { get; set; }
        public string Phone { get; set; }
    }
}