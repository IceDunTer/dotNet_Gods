using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static int Task2()
        {
            int count = 0;
            Console.WriteLine("Введите числа через пробел:");
            string txt = Console.ReadLine();
            string[] words = txt.Split(' '); // разделение по пробелам
            int len = words.Length;
            for (int i = 0;  i < len; i++)
            {
                if (words[i].Length == 2)
                {
                    count++;
                }
            }
            Console.WriteLine($"В строке найдено двузначных чисел: {count}\n");
            return 1;
        }

        static int Task3()
        {
            int n, k;
            Console.WriteLine("Введите K и N (N>0):");
            k = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            while (n <= 0)
            {
                Console.WriteLine("Не соблюдено условие! (N>0)");
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("=== Вывод числа K ===");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("=== Вывод завершен! ===\n");
            return 1;
        }
        
        static int Task4()
        {
            Console.WriteLine("Введите последовательность чисел:");
            string txt = Console.ReadLine();
            while (txt.Contains("00")) // проверка, если есть "00" в большой строке
            {
                txt = txt.Replace("00", "0"); // заменяет "00" на "0", т.к. "00" по сути бесполезны и 0 не является частью числа.
            }
            while (txt.Contains("0")) 
            {
                txt = txt.Replace("0", "? ");
            }
            while (txt.Contains("?"))
            {
                txt = txt.Replace("?", "0");
            }
            string[] words = txt.Split(' ');
            int count = words.Length;
            Console.WriteLine($"Чисел в последовательности: {count}\n");
            return 1;
        }

        static int Task5()
        {
            Console.WriteLine("Введите точность eps (eps > 0)");
            double eps = Convert.ToDouble(Console.ReadLine());

            while (eps < 0)
            {
                Console.WriteLine("eps должна быть больше 0!");
                double e = Convert.ToDouble(Console.ReadLine());
                eps = e;
            }
            double sum = 0;
            double term = 1;
            double den = 1;
            int n = 1;

            while (true) {
                term = 1.0 / Math.Sqrt(den);
                if (term < eps) break;
                sum += term;
                n++;
                den *= n;
            }

            Console.WriteLine($"Сумма бесконечного ряда до точности: {sum}\n");
            return 1;
        }

        static double f(double x)
        {
            return Math.Sqrt(2 * Math.Pow((x - 2), 2) * (8 - x) - 1);
        }

        static double Task6()
        {
            int b = 6;
            int count = 0;
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine($"{f(i)}");
            }
            return 1;
        }

        static void Main(string[] args)
        {
            int a;
            do
            {
                Console.WriteLine("=== Введите номер для выполнения задания ===");
                Console.WriteLine("2 - Задание 2");
                Console.WriteLine("3 - Задание 3");
                Console.WriteLine("4 - Задание 4*");
                Console.WriteLine("5 - Задание 5");
                Console.WriteLine("0 - Завершить работу");
                int b = Convert.ToInt32(Console.ReadLine());
                a = b;
                switch(a)
                {
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                    case 5: Task5(); break;
                    case 0: Console.WriteLine("Завершение работы."); break;
                    default: Console.WriteLine("Введен неправильный номер!\n"); break;
                }
            } while (a != 0);
        }
    }
}
