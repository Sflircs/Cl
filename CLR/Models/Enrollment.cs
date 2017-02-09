using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int OrderState { get; set; }
        public bool IsComplete { get; set; }
        public decimal TimeStart { get; set; }
        public decimal LastActive { get; set; } 

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}