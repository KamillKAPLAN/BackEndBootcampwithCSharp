using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CSharpBootcamp
{
    class Program
    {
        static void Main(string[] names)
        {
            // Dapper - Ado.Net - Entity Framework ORM aracıdır.
            // Prosedür nedir? neden kullanılır?
            // Dapper: Execute - Query

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Server=KAMILKAPLAN;Database=DbBootcamp;User Id=sa;Password=1;";
                connection.Open();

                Console.WriteLine($"Connection State : {connection.State}");
                Console.WriteLine($"ConnectionString : {connection.ConnectionString}");

                //// isimsiz tip
                //connection.Execute("insert into Student(Name, LastName, BirthDate)" +
                //    "values(@Name, @LastName, @BirthDate)",
                //    new[] { new { Name = "Ayaz", LastName = "Destur", BirthDate = DateTime.Parse("10.28.2022") } });

                //// data model
                //connection.Execute("insert into Student(Name, LastName, BirthDate)" +
                //    "values(@Name, @LastName, @BirthDate)",
                //    new Student() { Name = "Beytullah", LastName = "Öztürk", BirthDate = DateTime.Parse("10.27.2022") });

                // isimsiz tip
                //var result = connection.Query("SELECT * FROM Student");
                //if (result.ToList().Count > 0)
                //{
                //    foreach (var item in result.ToList())
                //    {
                //        Console.WriteLine($"{item.Id}: {item.Name} {item.LastName}");
                //    }
                //}

                // data model
                List<Student> students = connection.Query<Student>("SELECT * FROM Student").ToList();
                if (students.Count > 0)
                {
                    foreach (var item in students)
                    {
                        Console.WriteLine($"{item.Id}: {item.Name} {item.LastName}");
                    }
                }

                connection.Close();
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }
            public DateTime BirthDate { get; set; }
        }
    }
}
