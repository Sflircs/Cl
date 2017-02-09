using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Intro { get; set; }
        public bool IsPro { get; set; }
        public int InstructorId { get; set; }
        public int TechnologyId { get; set;}

        public virtual Instructor Instructor { get; set; }
        public virtual Technology Technology { get; set; }
        public virtual List<Lession> Lessions { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }
    }
}