using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Phone
    {
        private int battery;

        public int BatteryLevel
        {
            get { return battery; }
            set
            {
                if (value < 0)
                {
                    battery = 0;
                    return;
                }
                if (value > 100)
                {
                    Console.WriteLine("Заряд не может превышать 100!");
                    return;
                }
                battery = value;
            }
        }

        public string Brand { get; set; }

        public Phone(string brand, int initialCharge)
        {
            Brand = brand;
            BatteryLevel = initialCharge;
        }
        public void Use()
        {
            BatteryLevel -= 10;
            Console.WriteLine($"{Brand}: заряд {BatteryLevel}%.");
        }
    }
}
