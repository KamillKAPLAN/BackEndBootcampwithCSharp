using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampAPI.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        [StringLength(100)]
        public string GradeName { get; set; }
        [StringLength(50)]
        public string Section { get; set; } /* Bölüm */

        public ICollection<Student> Students { get; set; }
    }
}
