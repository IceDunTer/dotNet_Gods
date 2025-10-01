using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] test1 = new double[10];
            double max = -1000, min = 1000;
            for (int i = 0; i < test1.Length; i++)
            {
                test1[i] = rnd.Next(1, 100) + rnd.NextDouble();
            }
                 
            string path = @"C:\Users\User\source\repos\ConsoleApp2\task1.txt";
            try
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                {
                    foreach (double s in test1)
                    {
                        writer.Write(s + " ");
                    }
                }
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    while (reader.PeekChar() > -1)
                        {
                        double yo = double.Parse(reader.ReadString());
                        Console.Write(yo + "\n");
                        if (yo > max) { max = yo; }
                        if (yo < min) { min = yo; }
                        }
                    }
                }
            catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            Console.WriteLine("Сумма минимального ({1}) и максимального ({2}) чисел равна {0}", min + max, min, max);
        }
    }
}


