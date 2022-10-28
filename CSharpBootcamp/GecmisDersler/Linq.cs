using CSharpBootcamp.GecmisDersler.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBootcamp.GecmisDersler
{
    class Linq
    {
        // LINQ : Language Integrated Query (Dile Entegre Edilmiş Sorgu)
        // Entity Framework - Ado.net
        // Query Syntax - Metod Syntax
        // select * from Hesaplar where ID = 63
        // LINQ - Query 
        void LinQ()
        {
            int[] numbers = { 1, 23, 3, 4, 5, 6, 7, 8, 9, 10 };
            /* WHERE */
            var kucukSayilar = from sayi in numbers
                               where sayi < 6
                               select sayi;
            foreach (var item in kucukSayilar)
                Console.Write($"{item} ");

            foreach (var item in kucukSayilar.ToList())
                Console.Write($"{item} ");

            // LINQ - Method
            var kucukSayilar2 = numbers.Where(x => x < 6);
            foreach (var item in kucukSayilar2)
                Console.Write($"{item} ");

            List<Course> courses = new List<Course>()
            {
                new Course() {Id=1, Konu="C#", Sira=1},
                new Course() {Id=2, Konu="Linq", Sira=3},
                new Course() {Id=3, Konu="Angular", Sira=2}
            };
            courses.Add(new Course() { Id = 5, Konu = "React", Sira = 5 });
            courses.Add(new Course() { Id = 4, Konu = "C# Linq", Sira = 6 });

            // Query
            var result = from course in courses
                         where course.Sira < 3
                         select course;
            foreach (var item in result)
                Console.WriteLine($"{item.Id}. {item.Konu} - {item.Sira}");
            var x = from course in courses where course.Konu == "C#" select course;
            foreach (var item in x)
                Console.WriteLine($"{item.Id}. {item.Konu} - {item.Sira}");

            // Method
            var result2 = courses.Where(x => x.Konu.Contains("C#"));
            foreach (var item in result2)
                Console.WriteLine($"{item.Id}. {item.Konu} - {item.Sira}");


            /* OfType : verilerin belirtilen tipte listelenmesi */
            object[] values = { "Türkiye", "Pakistan", "Endonezya", 5, 75, 16, 5.34f };
            var resulttt = values.OfType<string>();
            //foreach (var item in result2)
            //    Console.WriteLine(item);

            List<Course> courses2 = new List<Course>()
            {
                new Course() {Id=1, Konu="C#", Sira=1},
                new Course() {Id=2, Konu="Linq", Sira=3},
                new Course() {Id=3, Konu="Angular", Sira=2},

                new UcretliKurslar() {Id=4, Konu="React", Sira=4, Price = 500},
                new UcretliKurslar() {Id=5, Konu="Ado.Net", Sira=6, Price = 700},

                new UcretsizKurslar() {Id=6, Konu=".Net Core", Sira=5},
                new UcretsizKurslar() {Id=7, Konu="Blazor", Sira=7}
            };

            // QUERY
            var ucretlikurslar = from ucretliC in courses2.OfType<Course>()
                                 select ucretliC;

            // METOT
            var ucretsiKurslar = courses2.OfType<UcretsizKurslar>();

            foreach (var item in ucretlikurslar)
                Console.WriteLine($"{item.Id}. {item.Konu} - {item.Sira}");

            /* OrderBy */
            var students = GetStudents();
            // query
            var result3 = from s in students
                         orderby s.IsActive, s.Name
                         select s;

            foreach (var item in result3)
                Console.WriteLine($"{item.IsActive} - {item.Name} - {item.LastName}");

            //metot
            var result4 = students.OrderBy(x => x.IsActive).ThenBy(x => x.Name);
            foreach (var item in result4)
                Console.WriteLine($"{item.IsActive} - {item.Name} - {item.LastName}");

            var result5 = students.OrderByDescending(x => x.LastName);
            foreach (var item in result5)
                Console.WriteLine($"{item.IsActive} - {item.Name} - {item.LastName}");

            /* IQueryable  : sorgular direkt olarak SQL server'da yapılır.
             * IEnumerable : datayı önce belleğe atıp ardından koşulları bellekteki dataya uygular.
             */
            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> querySyntax = from i in intList
                                           where i > 5
                                           select i;
            foreach (var item in querySyntax)
                Console.WriteLine($"IEnumerable: {item}");

            IQueryable<int> querySyntax2 = from i in intList.AsQueryable()
                                           where i > 5
                                           select i;
            foreach (var item in querySyntax2)
                Console.WriteLine($"IQueryable: {item}");

            string[] kume1 = { "Pazartesi", "Salı", "Çarşamba" };
            string[] kume2 = { "Pazartesi", "Salı" };

            // Except : iki arrayda bulunan verilerin sadece ilk array'de olup ikinci arrayde olmayan kayıtlar.
            var sonuc1 = kume1.Except(kume2);
            foreach (var item in sonuc1)
                Console.WriteLine(item);

            // Union : iki arrayda bulunan verilerin tekrarları olmayan veriler
            var sonuc2 = kume1.Union(kume2);
            foreach (var item in sonuc2)
                Console.WriteLine(item);

            // Concat : iki arraydaki elemanların sırası ile birleştirir.

            // Distinct() : arrayda tekrarları engeller.

            // Any()
            if (kume1.Any())
                Console.WriteLine($"{kume1.Length} değer var");
            else
                Console.WriteLine($"{kume1.Length} değer yok");

            // All()
            if (kume1.All(x => x.Length > 0))
                Console.WriteLine($"{kume1.Length} değer var");
            else
                Console.WriteLine($"{kume1.Length} değer yok");

            // Contains()
            if (kume1.Contains("Pazartesi"))
                Console.WriteLine($"değer var");
            else
                Console.WriteLine($"değer yok");

            // select -metot
            var r = kume1.Select(x => x + " Günü");
            var r2 = from s in kume1
                     select (s + " Günü");
            foreach (var item in r)
                Console.WriteLine(item);

            // SelectMany
            string[] days = { "Pazartesi", "Salı", "Çarşamba" };
            int[] numbers2 = { 1, 2, 3 };

            var result6 = days.SelectMany(x => numbers2, (x, y) => new
            {
                day = x,
                number = y
            });

            foreach (var item in result6)
                Console.WriteLine($"Gün: {item.day} - Sayi: {item.number}");

            // Sum, Count, Min, Max, Average            
            var r1 = numbers.Sum();
            Console.WriteLine(r1);
            var r6 = numbers.Count();
            Console.WriteLine(r6);
            var r3 = numbers.Min();
            Console.WriteLine(r3);
            var r4 = numbers.Max();
            Console.WriteLine(r4);
            var r5 = numbers.Average();
            Console.WriteLine(r5);

            // Aggregate
            var r7 = numbers.Aggregate((x, y) => x + y);
            Console.WriteLine(r7);
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
