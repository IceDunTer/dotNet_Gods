using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static double minim(double a, double b)
        {
            if (a == b) return a;
            if (a < b) return a;
            else return b;
        }
        static double maxim(double a, double b)
        {
            if (a == b) return a;
            if (a > b) return a;
            else return b;
        }
        static void Main(string[] args)
        {
            double a, b, c, min, min1, min2;
            string a1, b1, c1;
            Console.WriteLine("Vvedite a b c");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            c1 = Console.ReadLine();
            a = Convert.ToDouble(a1);
            b = Convert.ToDouble(b1);
            c = Convert.ToDouble(c1);
            Console.WriteLine("Число 1 = {0} Число 1 = {1} Число 1 = {2}\n", a, b, c);
            min = minim(a, minim(b, c));
            if (min == a) { min1 = minim(b, c);
                min2 = maxim(b, c);
            }
            else if (min == b) {  min1 = minim(a, c);
            min2 = maxim(a, c);}
            else { min1 = minim(a, b);
            min2 = maxim(a, b);}
            Console.WriteLine("Порядок убывания {0} {1} {2}\n", min2, min1, min);
        }
    }
}
