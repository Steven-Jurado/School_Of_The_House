using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity
{
    public class Course
    {
        [Key]
        public string IdCourse { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Nombre Del Curso Muy Largo")]
        public string Name { get; set; }
        [Required]
        public int QuantityCourse { get; set; }

        //
        public ICollection<User> Users { get; set; }
    }
}
