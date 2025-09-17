using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        struct Human
        {
            public string name;
            public int age;

            public void displayInfo()
            {
                Console.WriteLine($"Имя: {name}\nВозраст: {age}");
            }
            static void Main(string[] args)
            {
                Human bogdan;
                Console.WriteLine("Введите имя:");
                bogdan.name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите возраст:");
                bogdan.age = Convert.ToInt32(Console.ReadLine());
                bogdan.displayInfo();

                Console.ReadKey();



            }
        }
    }
}
