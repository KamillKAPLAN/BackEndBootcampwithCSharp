using System;

namespace CSharpBootcamp.GecmisDersler
{
    public class OOP_Class
    {
        string color = "red";
        static void MainX(string[] names)
        {
            Car car = new Car("");
            car.Color = "Yellow";
            Console.WriteLine(car.Color);
        }
    }
    // metot vs function
    public class Car
    {
        private Car() { }
        public Car(string _color) { Color = _color; }

        private string color = "red";
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        void RtrnColor(string color)
        {
            Console.WriteLine(color);
        }
    }
}
