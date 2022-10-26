using CSharpBootcamp.GecmisDersler.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBootcamp
{
    class Program
    {
        static void Main(string[] names)
        {
            /* OrderBy */
            var students = GetStudents();
            // query
            var result = from s in students
                         orderby s.IsActive, s.Name
                         select s;

            foreach (var item in result)
                Console.WriteLine($"{item.IsActive} - {item.Name} - {item.LastName}");

            //metot
            var result2 = students.OrderBy(x => x.IsActive).ThenBy(x => x.Name);
            foreach (var item in result2)
                Console.WriteLine($"{item.IsActive} - {item.Name} - {item.LastName}");

            var result3 = students.OrderByDescending(x => x.LastName);
            foreach (var item in result3)
                Console.WriteLine($"{item.IsActive} - {item.Name} - {item.LastName}");


            /* IQueryable - IEnumerable */
        }

        public static IList<Student> GetStudents()
        {
            /* Polymorphism */
            IList<Student> students = new List<Student>()
            {
                new Student{Id = 1, Name = "Melih", LastName="KAPLAN", IsActive = false},
                new Student{Id = 2, Name = "Kamil", LastName="KAPLAN", IsActive = true},
                new Student{Id = 3, Name = "Ceyda", LastName="Güleryüz", IsActive = true},
                new Student{Id = 4, Name = "Melike", LastName="Adaçoğlu", IsActive = false},
            };
            return students;
        }
    }
}
