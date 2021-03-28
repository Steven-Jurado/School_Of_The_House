using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class User
    {
        [Key]
        public string IdUser { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Nombre Muy Largo")]
        public string Name { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "Nombre Muy Largo")]
        public string LastName { get; set; }

        public string CourseId { get; set; }
        public Course Course { get; set; }
    }
}
