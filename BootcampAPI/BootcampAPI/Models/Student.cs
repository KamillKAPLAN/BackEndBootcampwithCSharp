using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootcampAPI.Models
{
    [Table("StudentInfo", Schema = "tbl")]

    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Column("DateOfBirth", TypeName = "date", Order = 1)]
        public DateTime? DateTimeIfBirth { get; set; }
        public decimal Height { get; set; }
        [NotMapped]
        public float Weight { get; set; }
        [Column(Order = 2)]
        public int CreatedAt { get; set; }
        public DateTime CreatedBy { get; set; }
        public int UpdatedAt { get; set; }
        public DateTime UpdatedBy { get; set; }
        public int DeletedAt { get; set; }
        public DateTime DeletedBy { get; set; }
        public bool IsDeleted { get; set; } = false;

        public int GradeId { get; set; }
        [ForeignKey("GradeId")]
        public Grade Grade { get; set; }


        public int StandardId { get; set; }
        public Standard Standard { get; set; }
        public ICollection<Notes> Notes { get; set; }
    }
}
