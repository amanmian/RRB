using AutoMapper;
using RB3._2.Dtos;
using RB3._2.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections;

namespace RB3._2.Controllers
{
    public class StudentApiController : ApiController
    {


        private StudentContext context;

        public StudentApiController()
        {
            context = new StudentContext();
        }

        // GET /api/customers
        public IHttpActionResult GetCustomers(string query = null)
        {
            var customersQuery = context.students
            .Include(c => c.studentdetails);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.FName.Contains(query));

            var customerDtos = customersQuery
            .ToList()
            .Select(Mapper.Map<Student, StudentDto>);

            return Ok(customerDtos);
        }

        // GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var stud = context.students.SingleOrDefault(c => c.Id == id);

            if (stud == null)
                return NotFound();

            return Ok(Mapper.Map<Student, StudentDto>(stud));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var student = Mapper.Map<StudentDto, Student>(studentDto);
            context.students.Add(student);
            context.SaveChanges();

            studentDto.Id = student.Id;
            return Created(new Uri(Request.RequestUri + "/" + student.Id), studentDto);
        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, StudentDto studentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var studentInDb = context.students.SingleOrDefault(c => c.Id == id);

            if (studentInDb == null)
                return NotFound();

            Mapper.Map(studentDto, studentInDb);

            context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var studentInDb = context.students.SingleOrDefault(c => c.Id == id);

            if (studentInDb == null)
                return NotFound();

            context.students.Remove(studentInDb);
            context.SaveChanges();

            return Ok();
        }




    }
       
}

