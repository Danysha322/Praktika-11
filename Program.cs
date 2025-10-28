using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1:Car");
            Car car = new Car("BMW", 100);
            car.Drive();
            car.Speed = 400;
            car.Speed = -50;

            Console.WriteLine("\nЗадание 2:Phone");
            Phone phone = new Phone("Samsung", 90);
            phone.Use();
            phone.Use();
            phone.Use();
            phone.BatteryLevel = 150;

            Console.WriteLine("\nЗадание 3:Book");
            Book book1 = new Book("Война и мир");
            book1.Pages = 1200;
            book1.Info();
            
            Book book2 = new Book("Краткая история");
            book2.Title = "";
            book2.Info();

            Console.WriteLine("\nЗадание 4:Player");
            Player player = new Player("Nikita", 9, 100);
            Console.WriteLine($"Игрок: {player.Name}, уровень: {player.Level}, здоровье: {player.Health}, жив: {(player.IsAlive ? "да" : "нет")}");
            player.TakeDamage(70);
            player.TakeDamage(30);
            player.Level = 0;

            Console.WriteLine("\nЗадание 5:Product");
            Product product = new Product(10000, 20);
            product.Name = "Ноутбук";
            product.Show();
            product.Discount = 10;
            product.Price = 10000;
            product.Show();
            product.Price = -100;

            Console.ReadLine();
        }
    }
}
