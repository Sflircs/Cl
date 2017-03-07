using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        public string Image { get; set; }

        public string LargeImage { get; set; }

        public string MediumImage { get; set; }

        [Required]
        public string Intro { get; set; }

        public bool IsPro { get; set; }

        [Required]
        public int InstructorId { get; set; }

        [Required]
        public int TechnologyId { get; set;}

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] LastUpdate { get; set; }

        public virtual Instructor Instructor { get; set; }
        public virtual Technology Technology { get; set; }
        public virtual List<Lession> Lessions { get; set; }
        public virtual List<Enrollment> Enrollments { get; set; }
    }
}