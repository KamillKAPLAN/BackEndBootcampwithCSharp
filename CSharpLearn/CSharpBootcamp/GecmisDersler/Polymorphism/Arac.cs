using System;

namespace CSharpBootcamp.GecmisDersler.Polymorphism
{
    public class Arac
    {
        public virtual void KornaCal()
        {
            Console.WriteLine("korna korna");
        }

        static void MainA(string[] names)
        {
            Arac arac = new Arac();
            Arac tArac = new Taksi();
            Arac kArac = new Kamyonet();

            arac.KornaCal();
            tArac.KornaCal();
            kArac.KornaCal();
        }
    }
}
