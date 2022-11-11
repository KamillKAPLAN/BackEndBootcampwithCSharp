using System;

namespace CSharpBootcamp.GecmisDersler.Polymorphism
{
    public class Kamyonet: Arac
    {
        public override void KornaCal()
        {
            base.KornaCal();
            Console.WriteLine("kampyonet korna korna");
        }
    }
}
