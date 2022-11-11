using System;

namespace CSharpBootcamp.GecmisDersler.Interface
{
    public class Fish : IAnimal, IFish
    {
        public void Sound()
        {
            Console.WriteLine("Fish ses çıkardı");
        }

        public void Swim()
        {
            Console.WriteLine("Fish yüzdü");
        }
    }
}
