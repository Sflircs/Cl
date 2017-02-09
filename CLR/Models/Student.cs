using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Google { get; set; }
        public string Twitter { get; set; }
        public string Facebook { get; set; }
        public string Blog { get; set; }
        public string Intro { get; set; }
        public string Email { get; set; }
        public string Passwd { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ExpiredProTime { get; set; }

        public virtual List<Enrollment> Enrollments { get; set; }

    }
}