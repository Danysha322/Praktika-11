using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Название не может быть пустым!");
                    return;
                }
                title = value;
            }
        }
        public int Pages { get; set; } = 1;

        public bool IsLong => Pages > 300;

        public Book(string title)
        {
            Title = title;
        }

        public void Info()
        {
            string longText = IsLong ? "да" : "нет";
            Console.WriteLine($"Книга: {Title}, страниц: {Pages}, длинная: {longText}");
        }
    }
}
