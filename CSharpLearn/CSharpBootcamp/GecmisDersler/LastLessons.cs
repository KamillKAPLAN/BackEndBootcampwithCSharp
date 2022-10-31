using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp.GecmisDersler
{
    class LastLessons
    {
        /*
            int numberValue = 29;
            Console.WriteLine(numberValue);

            {
                int number = 19;
                Console.WriteLine(number);
            }
            {
                int number = 29;
                Console.WriteLine(number);
            }

            const int x= 5, y = 10;
            const int t = x + y;
            // t = 10;

            int x;
            Int64 y;
            double y;

            int a = 3, b;
            b = a;
            Console.WriteLine(b);

            a = new int();
            Console.WriteLine(a);

            string s = "";
            Console.WriteLine(s);
            if(!string.IsNullOrEmpty(s))

            float b = 3.21f;
            Console.WriteLine(b);

            bool b = new bool();
            byte byt = new byte();
            char c = new char();
            decimal d = new decimal();
            double d2 = new double();
            float f = new float();
            long l = new long();
            object o = new object();
            string s = new string("");
            Console.WriteLine(b);
            Console.WriteLine(byt);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(f);
            Console.WriteLine(l);

            string ss = new string("");
            String s1 = "Merhaba ";
            String s2 = ".NET";
            String s3 = s1 + s2;
            Console.WriteLine(s3);

            // C:\Users\KAMILKAPLAN\ 
            string path = "C:\\Users\\KAMILKAPLAN\\";
            Console.WriteLine(path);

            int s1 = 5;
            int s2 = 10;
            string xyz = new string(s1.ToString() + "+" + s2.ToString() + " = " + (s1 + s2));
            string tplm = $"{s1} + {s2} = {s1 + s2}";
            Console.WriteLine(xyz);
            Console.WriteLine(tplm);

            string s = new string('a', 4);
            object o = 5;
            Console.WriteLine (o);
            Console.WriteLine(o.GetType());
            o = "B";
            Console.WriteLine(o.GetType());
            o = 1.25F;
            Console.WriteLine(o.GetType());
            o = false;
            Console.WriteLine(o.GetType());
            o = 5.25;
            Console.WriteLine(o.GetType());
            Console.WriteLine(s);
            Console.WriteLine(s.Contains('a')); // true

            var x = 1;
            Console.WriteLine(x);
            Console.WriteLine(x.GetType());
            x = "";
            x = 1.25F;

            var vrDegisken = "string değer";
            vrDegisken = "Semih Sarı";
            Console.WriteLine(vrDegisken);

            // object, var(3.0), dynamic(4.0)
            dynamic str = "Kamil KAPLAN";
            dynamic i = 2;
            Console.WriteLine(str);
            Console.WriteLine(i);

            dynamic s = 2;
            Console.WriteLine(s);
            string str2 = s + " Bootcamp"; 
            Console.WriteLine(str2);

            dynamic d;
            object o;
            // object vs dynamic

            object o = "Kemal";
            int t = ((string)o).Length;
            Console.WriteLine(t);

            var v = "aa";
            Console.WriteLine(v);
            dynamic d = "Ramazan";
            Console.WriteLine(d);
            d = 2;
            Console.WriteLine(d);
            int t2 = d.Length;
            Console.WriteLine(t2);

            object Rakam = 10;
            var xx = (int)Rakam;
            Rakam = xx + 1;
            Console.WriteLine(Rakam);

            dynamic Rakam = 10;
            Rakam = Rakam + 1;
            Console.WriteLine(Rakam);

            var Rakam = 10;
            Rakam = Rakam + 1;
            Console.WriteLine(Rakam);

            dynamic Rakam = "10";
            Rakam = Convert.ToInt32(Rakam) + 1;
            Console.WriteLine(Rakam);

            dynamic sayi = 5;
            sayi = sayi + 5;
            Console.WriteLine(sayi);

            // bilinçli tür dönüşümü, bilinçsiz tür dönüşümü
            // bilinçsiz tür dönüşümü
              // - küçük büyük
              // - büyük küçük
            int x = 12;
            float f;
            f = x;
            Console.WriteLine(f);

            // küçük büyük : tür dönüşümünde herhangi bir veri kaybı olmaz.
            byte b = 12;
            int bb = b;
            Console.WriteLine(bb);

            float f2 = 20f;
            double d = f2;
            Console.WriteLine(d);

            char c = 'a';
            decimal m = c;
            Console.WriteLine(m);

            int aa;
            float bb2 = 32.32f;
            double cc;
            cc = bb2;
            Console.WriteLine(bb2 + " - " + cc);

            // büyük küçük
            float f = 32.32f;
            int i = (int)f;

            int a = 400;
            byte b = (byte)a;
            Console.WriteLine(b); // 145 

            double d1 = 5.0, d2 = 4.0;
            int i;
            byte b;
            char c;
            i = (int)(d1 / d2);
            Console.WriteLine("Double to int : " + i);

            i = 128;
            i = 258; // int to byte 

            // uint, short 
            uint u;
            short s;
            u = 32146;
            u = 35000;  // uint to short 

            i = 65;
            c = (char)i;
            Console.WriteLine(i + " sayısının char'a dönüştürürsek : " + c);

            // 65 - 90 olan sayıları listeler misin 
            string str;
            for (int i = 65; i <= 90; i++)
            {
                str = ((char)i).ToString().ToLower();
                // Console.Write(str);
                // Console.Write(((char)(i + 32)) + " ");
                Console.Write(((char)i).ToString().ToLower() + " ");
            }

            string s;
            for (int i = 97; i < 123; i++)
            {
                Console.Write($"{(char)i}");
                if (i % 2 == 0)
                    Console.WriteLine("");
            }

            // checked unchecked
            int i = 256;
            byte b;
            checked
            {
                b = (byte)i;
            }
            Console.WriteLine(b);

            checked
            {
                byte bb = (byte)i;
            }
            Console.WriteLine(bb);

            int i1 = 256, i2 = 500;
            byte b1, b2;
            checked
            {
                unchecked
                {
                    b2 = (byte)i2;
                }
                Console.WriteLine(b2);

                b1 = (byte)i1;
                Console.WriteLine(b1);
            }

            //object - toString()
            string str = 345.59f.ToString();
            Console.WriteLine(str.GetType());
            int a = 5;
            int b = 7;
            string str1 = a.ToString();
            string str2 = b.ToString();
            Console.WriteLine(str1.GetType());
            Console.WriteLine(a + b);
            Console.WriteLine(str1 + str2);

            string str = "";
            Convert.ToBoolean(str);
            Convert.ToByte(str);
            Convert.ToInt32(str);
            Convert.ToChar(str);

            int a = 50;
            byte b = (byte)Convert.ToInt32(a);

             int i = 4 + -6; //
            int a = 5;
            int b = 10;
            Console.WriteLine("1. " + a);
            a++;
            Console.WriteLine("2. " + a);
            ++a;
            Console.WriteLine("3. " + a);
            --b;
            b--;

            int a = 4;
            int b = a++;
            Console.WriteLine(a + " - " + b);

            a = 4;
            b = ++a;
            Console.WriteLine(a + " - " + b); // 4 5 - 5 5 -

            a = 4;
            b = a--; // önce ata sonra azalt
            Console.WriteLine(a + " - " + b); // 3 4 

            a = 4;
            b = --a; // önce azalt sonra ata
            Console.WriteLine(a + " - " + b); // 3 3

            // Karşılaştırma operatörleri - ==, !=, <, <=, >, >=
            int a = 10, b = 15;
            if (a == b)
                Console.WriteLine("a==b");
            if (a != b)
                Console.WriteLine("a!=b");
            if (a < b)
                Console.WriteLine("a<b");
            if (a <= b)
                Console.WriteLine("a<=b");
            if (a > b)
                Console.WriteLine("a>b");
            if (a >= b)
                Console.WriteLine("a>=b");

            if (a == b)
                Console.WriteLine("a==b");
            else if (a != b)
                Console.WriteLine("a!=b"); //
            else if (a < b)
                Console.WriteLine("a<b"); //
            else if (a <= b)
                Console.WriteLine("a<=b"); //
            else if (a > b)
                Console.WriteLine("a>b");
            else if (a >= b)
                Console.WriteLine("a>=b");
            else
                Console.WriteLine("hiç birşey yapamadım.");

            // operatörler - as, is
            string str = "Beytullah";
            object obj = str;
            string str2 = obj as string;
            Console.WriteLine(str2);

            object i = 50;
            string str3 = i as string;

            string str = "Beytullah";
            dynamic obj = str;
            string str2 = obj as string;
            Console.WriteLine(str2);

            int i = 20;
            if(i is bool)
                Console.WriteLine(i.GetType());
            if (i is int)
                Console.WriteLine(i.GetType());

            // && || ! 
            bool b1 = !(25 < 10);
            Console.WriteLine(b1);
            bool b2 = !(10 != 20);
            Console.WriteLine(b2);

            // =
            int x;
            int y;
            x = x + y; // x += y;
            x = x * y; // x *= y;

            int x = 5;
            int y = 10;
            if (x < y)
                Console.WriteLine(x);
            else
                Console.WriteLine(y);

            // ?
            Console.WriteLine(!(x < y) ? x : y);

            //new 
            A a = new A();
            class A { }
 
             * if, switch
             * 
             * for, foreach
             * while
             * do while
             * 
             * break, continue, goto, return 

            string s;
            int a, b, c;
            Console.WriteLine("1. sayısı");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);
            Console.WriteLine("2. sayısı");
            s = Console.ReadLine();
            b = Convert.ToInt32(s);
            Console.WriteLine("3. sayısı");
            s = Console.ReadLine();
            c = Convert.ToInt32(s);
            // Console.WriteLine($"{a} - {b} - {c}");
            // Console.WriteLine(((a > b) && (a > c)) ? ($"A : {a}") : (b > c) ? ($"B : {b}") : ($"C : {c}"));
            // Console.WriteLine((a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c));

             int a = 1, b = 2;
             if(a<b)
                 Console.WriteLine(a);
             else
                 Console.WriteLine(b);

             // switch
             string s;
             int a;
             Console.Write("Kaçinci Sınıf : ");
             s = Console.ReadLine();
             a = Convert.ToInt32(s);
             switch (a)
             {
                 case 1: Console.WriteLine("1.Sınıf"); break;
                 case 2: Console.WriteLine("2.Sınıf"); break;
                 case 3: Console.WriteLine("3.Sınıf"); break;
                 case 4: Console.WriteLine("4.Sınıf"); break;
                 default: Console.WriteLine("Okulu uzatmışsın"); goto case 1;
             }

             // C# 8.0
             var result = a switch
             {
                 1 => "1.Sınıf",
                 2 => "2.Sınıf",
                 3 => "3.Sınıf",
                 4 => "4.Sınıf",
                 _ => "Okulu uzatmışsın Kamil"
             };
             Console.WriteLine(result);

             var (a, b, operat) = (5, 10, "*");
             var result = operat switch
             {
                 "+" => a + b,
                 "-" => a - b,
                 "*" => a * b,
                 _ => 10 * a * b
             };
             Console.WriteLine(result);

             // loops
             for (; ; )
                 Console.Write(0);
             for (int i = 1; i <= 100; i++)
                 Console.Write(i);
             int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
             for (int i = 1; i < c.Length; i++)
                 Console.Write(c[i]);
             
             int[] c = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 55 };
             int sum = 0;
             for (int i = 0; i < c.Length; i++)
                 sum += c[i];
             
             Console.WriteLine(sum);
             // ödev : girilen sayıya kadar olan değerleri topla
             
             int i = 0, sum = 0;
             while (i < 10)
             {
                 i++;
                 sum += i;
             }
             Console.WriteLine(sum);
             
             do
             {
                 sum += i;
                 i++;
             } while (i < 10);
             Console.WriteLine(sum);
             
             int j = 11;
             do
             {
                 Console.WriteLine(j);
                 j++;
             } while (j < 10);
             
             //foreach
              List<User> users = new List<User>();
             users.Add(new User() { Id = 1, Name = "Kamil" });
             users.Add(new User() { Id = 2, Name = "Ramazan" });
             
             foreach (var item in users)
                 //Console.WriteLine(item.Id + " - " + item.Name + item.GetType().Name);
                 Console.WriteLine(JsonConvert.SerializeObject(item));
             class User
             {
                 public int Id { get; set; }
                 public string Name { get; set; }
             }
             
             string[] isimler = { "Kemal", "Elif", "Oğuzhan", "Semih" };
             for (int i = 0; i < isimler.Length; i++)
                 Console.WriteLine($"{i + 1}. {isimler[i]}");
             int j = 0;
             foreach (var item in isimler)
             {
                 Console.WriteLine($"{j + 1}. {item}");
                 if (j < isimler.Length)
                     j++;
             }
             foreach (var item in isimler.Select((name, index) => (name, index)))
                 Console.WriteLine($"{item.index}. {item.name}");
             
            string[] names =
            {
                "Resul",
                "Kemal Erdem",
                "Yağmur",
                "Aytin",
                "Mücahid",
                "Beytullah",
                "Yasin",
                "Ayaz",
                "Ahsen",
                "Halime",
                "Onur",
                "Yiğit",
                "Musa",
                "Alper Umur",
                "Emre",
                "Kemal",
                "Elif Nur",
                "Ebru",
                "Semih",
                "Eren",
                "Beytullah",
                "Can",
                "Berkcan",
                "Doğuş",
                "Ramazan Burak"
            };

            class User
            {
                public int Id { get; set; }
                public string Name { get; set; }
            }

            Random random = new Random();
            int rastgeleSayi = random.Next(1, 17);
            double rndSayi = random.NextDouble();
            Console.WriteLine(rastgeleSayi);

            // Arrays
            string[] str;
            int[] number = new int[19];
            object[] obj;

            Console.WriteLine("Dizinin Boyutu : ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            bool[] arr = new bool[boyut];
            for (int i = 0; i < boyut; i++)
                Console.Write($"{arr[i]} ");

            Random rnd = new Random();
            int[] dizi = new int[3];
            dizi[0] = rnd.Next(0, 2);
            dizi[1] = rnd.Next(0, 3);
            dizi[2] = rnd.Next(0, 4);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            Console.WriteLine(names.GetLength(0));
            foreach (var item in names.Reverse())
                Console.WriteLine(item);
            Console.WriteLine(names.GetValue(0));
            Console.WriteLine(names.IsReadOnly);

            int[] numbers = { 1, 23, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; i++)
            {
                // int i = 0; while(a[i]<6) i++;
                if (numbers[i] < 6)
                    Console.WriteLine(numbers[i]);
            }
            */
    }
}
