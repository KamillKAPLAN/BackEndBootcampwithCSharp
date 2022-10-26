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
        }
    }
}
