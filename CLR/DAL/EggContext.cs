using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CLR.Models;

namespace CLR.DAL
{
    public class EggContext : DbContext
    {
        public EggContext() : base("Eggdb")
        {

        }

        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lession> Lessions { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}