namespace CSharpBootcamp.GecmisDersler.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Konu { get; set; }
        public int Sira { get; set; }
    }

    public class UcretliKurslar : Course
    {
        public int Price { get; set; }
    }
    public class UcretsizKurslar : Course { }
}
