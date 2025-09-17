using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7
{
    internal class Program
    {
        static double Volume(double a1, double b2)
        {
            return ((Math.Pow(a1, 2)) * b2) / 3;
        }
        static double sqare(double a1, double b2)
        {
            double z, s;
            z = Math.Sqrt(Math.Pow(a1/2, 2) + Math.Pow(b2, 2));
            s = (a1 * z) / 2;
            return s * 4 + (a1 * a1);

        }
        static void Main(string[] args)
        {
            double a1, b2, c1, d1;
            Console.WriteLine("введите сторону квадрата");
            string a2 = Console.ReadLine();
            a1 = Convert.ToDouble(a2);
            Console.WriteLine("введите высоту квадрата");
            string b1 = Console.ReadLine();
            b2 = Convert.ToDouble(b1);
            Console.WriteLine($"Объем правильной четырехугольной пирамиды = {Volume(a1,b2)}");
            Console.WriteLine($"Площадь поверхности четырехугольной пирамиды = {sqare(a1, b2)}");

        }
    }
}
