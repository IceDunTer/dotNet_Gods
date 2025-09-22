using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string[] stud = new string[5] {"abakumov", "anoxin", "boev", "xarebin", "syrkov"};
            string[] nomera = new string[5] {"a111a", "b222b", "c333c", "d444d", "e555e"};
            Console.WriteLine("Vvedite nomer\n");
            string poisk = Console.ReadLine();
            int cnt = 0;
            for (int i = 0; i<stud.Length; i++)
            {
                if (nomera[i] == poisk) { Console.WriteLine(stud[i]);
                    cnt++;
                    break;
                }
            }
            if (cnt==0) { Console.WriteLine("Номер не найден"); }
        }
    }
}
