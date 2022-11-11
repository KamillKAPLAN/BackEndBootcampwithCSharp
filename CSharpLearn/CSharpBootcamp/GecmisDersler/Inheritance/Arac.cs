using System;

namespace CSharpBootcamp.GecmisDersler.Inheritance
{
    public class Arac
    {
        public string marka = "YYY";
        public void KornaCal()
        {
            Console.WriteLine("korna korna");
        }
        static void MainZ(string[] names)
        {
            // sealed
            Arac arac = new Arac();
            Taksi taksi = new Taksi();
            Console.WriteLine(taksi.marka);
            taksi.KornaCal();
            Console.WriteLine($"{taksi.marka} - {taksi.model}");

            Arac tArac = new Taksi();
            Console.WriteLine($"{tArac.marka}");
            Arac kArac = new Kamyonet();
            Console.WriteLine($"{kArac.marka}");
            /* Taksi aTaksi = new Arac(); */

            arac.KornaCal();
            tArac.KornaCal();
            kArac.KornaCal();
        }
    }
}
