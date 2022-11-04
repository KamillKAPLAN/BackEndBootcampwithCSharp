using System.Collections.Generic;

namespace BootcampAPI.Models
{
    public class Standard
    {
        public int Id { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
