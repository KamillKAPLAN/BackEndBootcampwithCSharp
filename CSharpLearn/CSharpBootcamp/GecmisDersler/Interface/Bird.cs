using System;

namespace CSharpBootcamp.GecmisDersler.Interface
{
    public class Bird : IAnimal, IBird
    {
        public void Sound()
        {
            Console.WriteLine("Bird ses çıkardı");
        }

        public void Fly()
        {
            Console.WriteLine("Bird uçtu");
        }
    }
}
