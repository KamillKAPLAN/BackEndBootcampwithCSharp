using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp.GecmisDersler
{
    class _26
    {
        void Ders()
        {
            int[] number = { 1, 2, 3, 4, 5 };
            int[] b = number;
            Console.WriteLine(b[0]);
            b[0] = 5;
            number[1] = 7;
            Console.WriteLine(b[0]);
            Console.WriteLine(number[0]);
            Console.WriteLine(b[1]);
            Console.WriteLine(number[1]);

            // arraylist
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ayaz");
            arrayList.Add(34);
            arrayList.Add('C');
            foreach (var item in arrayList)
                Console.WriteLine(item);
            arrayList.Remove(34);
            foreach (var item in arrayList)
                Console.WriteLine(item);
            Console.WriteLine(arrayList[1]);
        }

        void PalindronikKelime()
        {
            // Palindronik Kelimeler : XOX - EFE - ADA
            string value, reverse = "";
            Console.WriteLine("String değeri giriniz : ");
            value = Console.ReadLine();
            for (int i = 0; i < value.Length; i++)
                Console.Write($"{value[value.Length - i - 1]} \n");

            for (int i = value.Length - 1; i >= 0; i--)
                //reverse = reverse + value[i];
                reverse += value[i];
            if (reverse == value)
                Console.WriteLine($"\n{value} bir palindronik kelimedir.");
            else
                Console.WriteLine($"\n{value} bir palindronik kelime değildir.");

            Program pr = new Program();
            //pr.Topla(1, 2);

            string[] names = { "Beytullah", "Yasin", "Kemal" };
            //Program.Main(names);            
        }

        public static void Mainn(string[] names)
        {
            Console.WriteLine(names);
            Program program = new Program();
            //program.GetEmployee(1, "Kamil");
            int a = Topla(1, 2);
        }

        void GetEmployee(int id, string name)
        {
            Console.WriteLine($"{id} : {name}");
        }
        // public, private, protected, internal
        public static int Topla(int a, int b)
        {
            return a + b;
        }

        public static void metotlar(int a = 2, int b = 3, int c = 4)
        {
            Console.WriteLine($"a: {a} b: {b} c: {c}");
        }
        public static void metotlar2(int a, int b = 2, int c = 3)
        { }

        static void Yaz(int[] dizi)
        {
            foreach (var item in dizi)
                Console.Write(item);
        }

        static void Yaz2(Array dizi)
        {
            foreach (var item in dizi)
                Console.Write(item);
        }

        int[] number = { 1, 2, 3, 4, 5 };
        //Yaz(number);
        //Yaz2(number);

        /*
         * çalışma zamanında hangi metodun çağrıldığını belirleyebilmek için 
         * "metodun imzasına" bakılır.
         */
        static void Metot(int x, int y)
        { Console.WriteLine("1. metot"); }
        static void Metot(float x, float y)
        { Console.WriteLine("2. metot"); }
        static void Metot(string x, string y)
        { Console.WriteLine("3. metot"); }

        int[] numbers = { 1, 2, 3, 4, 5 };
        //Console.WriteLine(Topla(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14));
          //  Console.WriteLine(Topla(numbers));
        public static int Topla(params int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            int toplam = 0;
            foreach (var item in numbers)
                toplam += item;
            return toplam;
        }
    }
}
