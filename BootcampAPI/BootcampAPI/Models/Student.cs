using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampAPI.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime? DateTimeIfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public int CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public int UpdatedAt { get; set; }
        public DateTime UpdatedBy { get; set; }
        public int DeletedAt { get; set; }
        public DateTime DeletedBy { get; set; }
        public bool IsDeleted { get; set; } = false;

        public int GradeId { get; set; }
        public Grade Grade { get; set; }
                
        public List<Notes> Notes { get; set; }
    }
}
