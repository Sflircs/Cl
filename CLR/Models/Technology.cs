using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CLR.Models
{
    [Table("Technology")]
    public class Technology
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        public string Image { get; set; }

        public string LargeImage { get; set; }

        public string MediumImage { get; set; }

        [Required]
        public string Intro { get; set; }
        [Timestamp]
        public byte[] LastUpdate { get; set; }

        public virtual List<Course> Courses { get; set; }

    }
}