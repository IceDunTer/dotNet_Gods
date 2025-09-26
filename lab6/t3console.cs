using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        struct Human
        {
            private string name;
            private int age;

            public Human(string n, int a)
            {
                name = n;
                age = a;
            }
            public string outname()
            {
                return name;
            }
            public void displayInfo()
            {
                Console.WriteLine($"Имя: {name} Возраст: {age}");
            }
        }
            static void Main(string[] args)
        {
            Hashtable humans = new Hashtable();
            humans.Add("Kirill", 52);
            humans.Add("Artem", 12);
            int end = 12;
            while (end != 0)
            {
                Console.WriteLine("1. add human\n2. remove human by name\n3. remove human by age\n4. do key list and out list\n5. search (only after 4)\n0. End\n");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter name human and age to add\n");
                        humans.Add(Console.ReadLine(), int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("Enter name human\n");
                        humans.Remove(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter age human\n");
                        humans.Remove(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        ICollection c = humans.Keys;
                        Console.WriteLine("Successfull\n");
                        foreach (string str in c)
                        {
                            Console.WriteLine(str + " " + humans[str]);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter key\n");
                        string nametoSearch = Console.ReadLine();
                        if (humans[nametoSearch] != null)
                        {
                            Console.WriteLine("Name {0} Age {1}", nametoSearch, humans[nametoSearch]);
                        }
                        break;
                    case 0:
                        end = 0;
                        break;
                    default: Console.WriteLine("The selected option is missing\n"); break;
                }
            }
            }
        }
}
