using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    [Table("Instructor")]
    public class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(4)]
        public string Iid { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        public string Google { get; set; }

        public string Twitter { get; set; }

        public string Facebook { get; set; }

        public string Blog { get; set; }

        public string Intro { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Passwd { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        
        public string Avatar { get; set; }

        [Timestamp]
        public byte[] LastUpdate { get; set; }

        public virtual List<Course> Courses { get; set; }
    }
}