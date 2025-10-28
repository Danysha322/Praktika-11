using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Car
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Скорость не может быть отрицательной!");
                    return;
                }
                if (value > 300)
                {
                    Console.WriteLine("Скорость не может превышать 300!");
                    return;
                }
                speed = value;
            }
        }
        public string Model { get; set; } = "Unknown";

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public void Drive()
        {
            Console.WriteLine($"{Model} едет со скоростью {Speed} км/ч.");
        }
    }

}
