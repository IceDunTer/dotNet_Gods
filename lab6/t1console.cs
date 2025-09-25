using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var letters = new List<string>();
            letters.Add("A");
            letters.Add("B");
            letters.Add("C");
            int end = 12;
            while (end != 0)
            {
                Console.WriteLine("1. add letter\n2. try remove letter\n3. remove letter index\n4. sort list\n5. binary search\n6. out list\n0. End\n");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter letter to add\n");
                        letters.Add(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Enter letter to try remove\n");
                        if (letters.Remove(Console.ReadLine()) == true)
                            Console.WriteLine("Remove successful");
                        else Console.WriteLine("Letter was not found");
                        break;
                    case 3:
                        Console.WriteLine("Enter index to remove\n");
                        letters.RemoveAt(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        letters.Sort();
                        break;
                    case 5:
                        Console.WriteLine("Enter letter to search\n");
                        Console.WriteLine("Letter has index {0} (index -1 mean letter was not found)\n", letters.BinarySearch(Console.ReadLine()));
                        break;
                    case 6:
                        foreach (var i in letters) { Console.WriteLine(i + " "); }
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
