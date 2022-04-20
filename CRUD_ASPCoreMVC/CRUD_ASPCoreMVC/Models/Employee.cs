using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRUD_ASPCoreMVC.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string City { get; set; }
        [Required]

        public string Department { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]

        public string ContactNo { get; set; }
        [Required]

        public DateTime DOB { get; set; }
    }
}
