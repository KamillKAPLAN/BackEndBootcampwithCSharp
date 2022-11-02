using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampAPI.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; } /* Bölüm */

        public ICollection<Student> Students { get; set; }
    }
}
