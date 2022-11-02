using System.Collections.Generic;

namespace BootcampAPI.Models
{
    public record Notes
    {
        public int Id { get; set; }
        public int Note1 { get; set; }
        public int Note2 { get; set; }
        public double Average => (Note1 * 0.4) + (Note2 * 0.6);

        //public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
