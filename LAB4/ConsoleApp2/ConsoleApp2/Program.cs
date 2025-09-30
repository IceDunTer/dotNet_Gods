using System.Drawing;
using System.Linq.Expressions;

Console.WriteLine("Hello, World!\n");

int a;
double func(int k, int n)
{
    return Math.Sqrt((Math.Pow(n, k)) / (Math.Pow(n + 1, k)));
}
do
{
    Console.WriteLine("Выберите задание\n");
    a = Convert.ToInt32(Console.ReadLine());
    switch (a)
    {
        case 1:
            {
                Console.WriteLine("Введите n, k, m ");


                int n = Convert.ToInt32(Console.ReadLine()), k = Convert.ToInt32(Console.ReadLine()), m = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"n = {n}");
                Console.WriteLine($"k = {k}");
                Console.WriteLine($"m = {m}");

                double[] arr1 = new double[n];
                double[,] arr2 = new double[m, n];

                for (int i = 0; i < n; i++)
                {
                    arr1[i] = func(k, i);
                }

                Console.WriteLine("Одномерный массив: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{arr1[i]} ");
                }
                Console.WriteLine();

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr2[i, j] = func(k, i);
                    }
                }

                Console.WriteLine("Двумерный массив: ");
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{arr2[i, j]} ");
                    }
                    Console.WriteLine();
                }

                break;
            }
        case 2:
            {
                Console.WriteLine("Введите длинну массива A");
                int asd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длинну массива b");
                int dsa = Convert.ToInt32(Console.ReadLine());

                int[] A = new int[asd];
                int[] B = new int[dsa];

                Console.WriteLine("Введите элементы массива A");

                for (int z = 0; z < A.Length; z++)
                {
                    A[z] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Введите элементы массива B");

                for (int z = 0; z < B.Length; z++)
                {
                    B[z] = Convert.ToInt32(Console.ReadLine());
                }

                int q = A.Sum();
                int r = B.Sum();
                if (q > r)
                {
                    Console.WriteLine("B: ");
                    for (int z = 0; z < B.Length; z++)
                    {
                        Console.WriteLine($"{B[z]}");
                    }
                    Console.WriteLine($"\n");
                    Console.WriteLine("A: ");
                    for (int z = 0; z < A.Length; z++)
                    {
                        Console.WriteLine($"{A[z]}");
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("A: ");
                    for (int z = 0; z < A.Length; z++)
                    {
                        Console.WriteLine($"{A[z]}");
                    }
                    Console.WriteLine($"\n");
                    Console.WriteLine("B: ");
                    for (int z = 0; z < B.Length; z++)
                    {
                        Console.WriteLine($"{B[z]}");
                    }

                    break;
                }
            }
        case 3:
            {
                Console.WriteLine("Введите размер массива n:");
                int n = Convert.ToInt32(Console.ReadLine());

                int[,] arr = new int[n, n];
                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = rnd.Next(0, 20);
                    }
                }

                Console.WriteLine("Массив:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }
                    Console.WriteLine();
                }

                int sum = 0;


                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        sum += arr[i, j];
                    }
                }

                Console.WriteLine($"Сумма элементов выше главной диагонали равна {sum}");

                break;
            }
        case 4:
            {
                Console.WriteLine("Введите массив");
                string numsw = Console.ReadLine();

                string[] arrf = numsw.Split(" ");
                int[] AMD = new int[arrf.Length];
                
                for (int i = 0; i < arrf.Length; i++)
                {
                    if (arrf[i] != "") // защита от Антона
                    {
                        AMD[i] = Convert.ToInt32(arrf[i]);
                    }
                }


                for (int l = 0; l < AMD.Length; l++)
                {
                    for (int i = 0; i < AMD.Length - 1; i++)
                    {
                        if (AMD[i + 1] < AMD[i])
                        {
                            int y = AMD[i];
                            AMD[i] = AMD[i + 1];
                            AMD[i + 1] = y;
                        }
                    }
                }

                for (int z = 0; z < AMD.Length; z++)
                {
                    Console.Write($"{AMD[z]}\n");
                }
                break;
            }

    }
} while (a != 0);