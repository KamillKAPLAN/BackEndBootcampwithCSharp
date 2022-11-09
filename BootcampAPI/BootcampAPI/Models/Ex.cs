using System;

namespace BootcampAPI.Models
{
    public abstract class Oyun
    {
        public abstract void Platform();
    }

    class Atari : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun ATARİ platformunda çalışmaktadır.");
        }
    }

    class PC : Oyun
    {
        public override void Platform()
        {
            Console.WriteLine("Bu oyun PC platformunda çalışmaktadır.");
        }
    }

    public enum Oyunlar
    {
        Atari,
        PC
    }

    public class Creater
    {
        public Oyun FactoryMetot(Oyunlar OyunTipi)
        {
            Oyun oyun = null;

            switch (OyunTipi)
            {
                case Oyunlar.Atari:
                    oyun = new Atari();
                    break;
                case Oyunlar.PC:
                    oyun = new PC();
                    break;
            }
            return oyun;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            Oyun atariOyun = creater.FactoryMetot(Oyunlar.Atari);
            Oyun pcOyun = creater.FactoryMetot(Oyunlar.PC);

            atariOyun.Platform();
            pcOyun.Platform();
        }
    }

    public interface IPCUse
    {
        void PCUse();
    }
    public interface IPencilUse
    {
        void PencilUse();
    }

    public class CSharp : IPCUse
    {
        public void PCUse()
        {
            Console.WriteLine("PC USE");
        }
    }
    public class Math : IPencilUse
    {
        public void PencilUse()
        {
            Console.WriteLine("Pencil USE");
        }
    }
}
