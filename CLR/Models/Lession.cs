using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    [Table("Lession")]
    public class Lession
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public int CourseId { get; set; }

        public int Order { get; set; }
        [Required]
        public int Time { get; set; }

        public int Video { get; set; }

        public bool Ispro { get; set; }
        [Timestamp]
        public byte[] LastUpdate { get; set; }

        public virtual Course Course { get; set; }
    }
}