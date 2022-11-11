using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBootcamp.GecmisDersler.Abstraction
{
    public abstract class Animal
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("Zzzz");
        }

        static void MainB(string[] names)
        {
            // Animal animal = new Animal();
            Animal cAnimal = new Cat();
            cAnimal.AnimalSound();
            cAnimal.Sleep();

            Animal eAnimal = new Elephant();
            eAnimal.AnimalSound();
            eAnimal.Sleep();
        }
    }
}
