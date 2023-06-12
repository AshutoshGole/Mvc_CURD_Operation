using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Mvc_CURD_Operation.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [DisplayName("EMP ID")]
        public int ID { get; set; }
        [Required]
        [DisplayName("MEDICINE NAME")]
        public String Name { get; set; }
        [Required]
        [DisplayName("MEDICINE TYPE")]
        public String Department { get; set; }
        [Required]
        [DisplayName ("MEDICINE AS PER DAY")]
        public int Salary { get; set; }
    } 
}