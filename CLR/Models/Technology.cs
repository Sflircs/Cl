using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Intro { get; set; }

        public virtual List<Course> Courses { get; set; }

    }
}