using Artsofte.Data;
using System.Web.Mvc.Html;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artsofte.Models
{
    public class Employee
    {
        [Key] public int Id { get; set; }

        [Required] [MinLength(2)] [MaxLength(20)]
        public string Name { get; set; }

        [Required] [MinLength(2)] [MaxLength(20)]
        public string Surname { get; set; }
      
        [Range(18,100)]
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }

    }
}
