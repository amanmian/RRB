using AutoMapper;
using RB3._2.Dtos;
using RB3._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RB3._2.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            CreateMap<Student, StudentDto>();

            CreateMap<StudentDetail, StudentDetailDto>();



            // Dto to Domain
            CreateMap<StudentDto, Student>()
                .ForMember(c => c.Id, opt => opt.Ignore());

        }
    }
}
