using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RB3._2.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("name=MyConnectionString")
        {

        }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentDetail> studentDetails { get; set; }

        
        public static StudentContext Create()
        {
            return new StudentContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("am");
            base.OnModelCreating(modelBuilder);
        }
    }
}