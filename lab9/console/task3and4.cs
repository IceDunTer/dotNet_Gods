using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double[] add = new double[11];
            double[] test1 = new double[10];
            double max = -1000, min = 1000;
            for (int i = 0; i < test1.Length; i++)
            {
                test1[i] = rnd.Next(1, 100) + rnd.NextDouble();
            }
            int vibor = 12;
            string path = @"C:\Users\User\source\repos\ConsoleApp2\task1.txt", logi;
            Console.WriteLine("Введите файл для логов");
            logi = Console.ReadLine();
            File.Create(logi).Close();

            while (true)
            {
                Console.WriteLine("1. Записать случайные числа в файл\n2. Добавить число на случайную позицию\n" +
                    "3. Копировать выбранный файл в текущий каталог\n4. Информацию о файле и записать её\n0. Exit\n");
                switch (int.Parse(Console.ReadLine())) {
                    case 1:
                        try
                        {
                            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                            {
                                foreach (double s in test1)
                                {
                                    writer.Write(s);
                                }
                            }
                            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                            {
                                while (reader.BaseStream.Position < reader.BaseStream.Length)
                                {
                                    double yo = reader.ReadDouble();
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
                        break;
                    case 2:
                            Console.WriteLine("Введите число");
                            int addd, y, b = rnd.Next(0, add.Length);
                            while (true)
                            {
                                try
                                {
                                    addd = int.Parse(Console.ReadLine());
                                    break;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }
                            for (int i = 0; i < add.Length; i++)
                            {
                                if (i < b) { add[i] = test1[i]; }
                                else if (i == b) { add[i] = addd; }
                                else { add[i] = test1[i - 1]; }
                            }
                            try
                            {
                                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
                                {
                                    foreach (double s in add)
                                    {
                                        writer.Write(s);
                                    }
                                }
                                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                                {
                                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                                    {
                                        double yo = reader.ReadDouble();
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
                        break;
                    case 3:
                        Console.WriteLine("Введите путь к исходному файлу:");
                        string sourceFile = Console.ReadLine();

                        Console.WriteLine("Введите путь к целевому каталогу:");
                        string targetDirectory = Console.ReadLine();

                        try
                        {
                            if (!File.Exists(sourceFile))
                            {
                                Console.WriteLine("Исходный файл не существует!");
                                break;
                            }

                            
                            string fileName = Path.GetFileName(sourceFile);
                            string destinationFile = Path.Combine(targetDirectory, fileName);

                            File.Copy(sourceFile, destinationFile, true);
                            Console.WriteLine($"Файл успешно скопирован в: {destinationFile}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка при копировании: " + e.Message);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите имя для искомого файла\n");
                        string target = Console.ReadLine();
                        if (File.Exists(target))
                        {
                            string log = string.Format("Файл {0} существует. Время создания: {1}\nВремя последнего доступа: {2}\nВремя последнего изменения: {3}\n",
                                Path.GetFileName(target),
                                File.GetCreationTime(target),
                                File.GetLastAccessTime(target),
                                File.GetLastWriteTime(target));
                            Console.WriteLine(log);
                            try
                            {   
                                if (!File.Exists(logi)){
                                    File.Create(logi).Close();
                                }

                                using (BinaryWriter writer = 
                                    new BinaryWriter(File.Open(logi, FileMode.Append)))
                                {
                                    writer.Write(log);
                                }
                                using (BinaryReader reader = 
                                    new BinaryReader(File.Open(logi, FileMode.Open)))
                                {
                                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                                    {
                                        Console.Write(reader.ReadString()+"\n");
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        else Console.WriteLine("Файл не найден\n");
                        break;
                    case 0:
                        Console.WriteLine("Завершение работы");
                        return;
                    default: 
                        Console.WriteLine("Нет такой функции или неправильный номер");
                        break;

            }
            }
        }
    }
}

