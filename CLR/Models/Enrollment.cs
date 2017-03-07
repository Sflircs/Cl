using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public int OrderState { get; set; }

        public bool IsComplete { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] TimeStart { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Timestamp]
        public byte[] LastActive { get; set; } 

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}