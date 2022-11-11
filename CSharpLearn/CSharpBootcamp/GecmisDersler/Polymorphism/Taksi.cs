using System;

namespace CSharpBootcamp.GecmisDersler.Polymorphism
{
    public class Taksi :Arac
    {
        public override void KornaCal()
        {
            base.KornaCal();
            Console.WriteLine("taksi korna korna");
        }
    }
}
