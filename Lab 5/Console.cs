using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void t1()
        {
            string a, b;
            Console.WriteLine("Введите строки А и В через Enter:");
            a = Console.ReadLine();
            b = Console.ReadLine();

            if (a.Length > b.Length)
            {
                Console.WriteLine("Строка А больше строки В.");
            }
            else if (a.Length == b.Length) { Console.WriteLine("Обе строки одинаковой длины."); }
            else Console.WriteLine("Строка B больше строки A.");
        }

        static void t2() 
        {
            string a;
            Console.WriteLine("Введите последовательность через запятую:");
            a = Console.ReadLine();
            string[] b = a.Split(',');

            b[b.Length - 1] = b[b.Length - 1].TrimEnd('.');

            if (b.Length <= 30 && b.Length >= 1)
            {
                foreach (string word in b)
                {
                    if (word.Length > 6)
                    {
                        Console.WriteLine("В слове больше 5 букв!");
                        return;
                    }
                }

                Array.Reverse(b);

                Console.WriteLine("Последовательность в обратном порядке:");
                Console.WriteLine(string.Join(", ", b) + ".");
            }
            else
            {
                Console.WriteLine("Количество слов должно быть от 1 до 30!");
            }

        }

        static void t3()
        {
            Console.WriteLine("Введите слово");
            string a = Console.ReadLine();
            string cons = "бвгджзйклмнпрстфхцчшщ";
            StringBuilder b = new StringBuilder();
            
            foreach(char c in a)
            {
                if (cons.Contains(c))
                {
                    b.Append(c);
                    b.Append(c);
                }
                else b.Append(c);
            }
            Console.WriteLine($"Новое слово: {b.ToString()}");
        }

        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.WriteLine("=== Выберите номер задания: ===");
                Console.WriteLine("1 - Задание 1");
                Console.WriteLine("2 - Задание 2");
                Console.WriteLine("3 - Задание 3");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 0: Console.WriteLine("Завершение работы"); break;
                    case 1: t1(); break;
                    case 2: t2(); break;
                    case 3: t3(); break;
                    default: Console.WriteLine("Неправильно выбрано задание!\n"); break;
                }

            } while (n != 0);
        }
    }
}
