using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolStudent.Models
{
    public class Division
    {
        [Key]
        public int DivisionId { get; set; }
        public string Name { get; set; }

        public ICollection<Student> student { get; set; }
    }

    
}
