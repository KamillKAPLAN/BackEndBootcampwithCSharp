using CSharpBootcamp.GecmisDersler.Abstraction;
using System;

namespace CSharpBootcamp.GecmisDersler.Interface
{
    public class Cat : Animal, IAnimal, ICat
    {
        public void Sound()
        {
            Console.WriteLine("Cat ses çıkardı");
        }

        public void Run()
        {
            Console.WriteLine("Cat koştu");
        }

        public override void AnimalSound()
        {
            
        }

        static void MainC(string[] names)
        {
            Cat cat = new Cat();
            cat.Sound();

            Bird bird = new Bird();
            bird.Sound();

            Fish fish = new Fish();
            fish.Sound();
        }
    }
}
