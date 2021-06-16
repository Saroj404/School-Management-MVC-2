using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolWebAuth.Models
{
    public class Course
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        [Display(Name ="Duration(months)")]
        public int Duration { get; set; }
    }
}