using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolWebAuth.Models
{
    public class Teacher
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name="Teacher Name")]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }
    }
}