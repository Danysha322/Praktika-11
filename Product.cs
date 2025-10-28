using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Product
    {
        private double price;
        private double discount;

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Цена не может быть отрицательной!");
                    return;
                }
                price = value;
            }
        }
        public double Discount
        {
            get { return discount; }
            set
            {
                if (value < 0)
                    discount = 0;
                else if (value > 100)
                    discount = 100;
                else
                    discount = value;
            }
        }
        public double FinalPrice => Price * (1 - Discount / 100);

        public string Name { get; set; } = "Без названия";

        public Product(double price, double discount)
        {
            Price = price;
            Discount = discount;
        }

        public void Show()
        {
            Console.WriteLine($"{Name}: {FinalPrice:F0} (скидка {Discount}%)");
        }
    }
}
