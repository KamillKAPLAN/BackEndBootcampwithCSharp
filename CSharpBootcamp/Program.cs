using System;
using System.Collections.Generic;

namespace CSharpBootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region C#Example
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
            */
            #endregion

        }
    }
}
