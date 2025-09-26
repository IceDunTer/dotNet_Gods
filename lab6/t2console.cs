using System;
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
            var humans = new List<Human>();
            Human Artem = new Human("Artem", 12);
            Human Kirill = new Human("Kirill", 52);
            humans.Add(Kirill);
            humans.Add(Artem);
            int end = 12;
            while (end != 0)
            {
                Console.WriteLine("1. add human\n2. try remove human\n3. remove letter human\n4. sort list\n5. binary search\n6. out list\n0. End\n");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter name human and age to add\n");
                        humans.Add(new Human(Console.ReadLine(), int.Parse(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("Enter human name to try remove\n");
                        string nameToRemove = Console.ReadLine();
                        Human humanToRemove = humans.Find(h => h.outname() == nameToRemove);

                        if (humanToRemove.outname() != null)
                        {
                            humans.Remove(humanToRemove);
                            Console.WriteLine("Remove successful");
                        }
                        else
                        {
                            Console.WriteLine("Human was not found");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter index to remove\n");
                        humans.RemoveAt(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        humans.Sort((x, y) => x.outname().CompareTo(y.outname()));
                        break;
                    case 5:
                        Console.WriteLine("Enter human to search\n");
                        string nametoSearch = Console.ReadLine();
                        int serch = humans.BinarySearch(new Human(nametoSearch, 0),
                            Comparer<Human>.Create((x, y) => x.outname().CompareTo(y.outname())));
                        Console.WriteLine("Human has index {0} (index -1 mean letter was not found)\n", serch);
                        break;
                    case 6:
                        foreach (var i in humans) { i.displayInfo(); }
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
