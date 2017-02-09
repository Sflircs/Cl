using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    public class Lession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public int Order { get; set; }
        public int Time { get; set; }
        public int Video { get; set; }
        public bool Ispro { get; set; }

        public virtual Course Course { get; set; }
    }
}