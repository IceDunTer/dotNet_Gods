using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    internal class Program
    {
        static double CountA(double x, double y, double z)
        {
            return (Math.Sqrt(Math.Abs(x - 1)) - Math.Sqrt(Math.Abs(y))) / 1 + (x * x / 2) + (y * y / 4);
        }

        static double CountB(double x, double y, double z)
        {
            return (x * (Math.Atan(z)+Math.E));
        }

        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Введите Х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Z:");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"А = {CountA(x, y, z)}");
            Console.WriteLine($"B = {CountB(x, y, z)}");
        }
    }
}

