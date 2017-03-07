using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        public string Uid { get; set; }

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

        public string LargeAvatar { get; set; }

        public string MediumAvatar { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] ExpiredProTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] LastUpdate { get; set; }

        public virtual List<Enrollment> Enrollments { get; set; }

    }
}