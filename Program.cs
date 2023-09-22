using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Array_5_5
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Random random = new Random();

                int[,] array = new int[5, 5];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        array[i, j] = random.Next(-100, 101);
                    }
                }

                Console.WriteLine("Двумерный массив:");

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }

                int min = array[0, 0];
                int max = array[0, 0];

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (array[i, j] < min)
                        {
                            min = array[i, j];
                        }
                        if (array[i, j] > max)
                        {
                            max = array[i, j];
                        }
                    }
                }

                Console.WriteLine($"Минимальный элемент: {min}");
                Console.WriteLine($"Максимальный элемент: {max}");

                int sum = 0;
                bool betweenMinMax = false;

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (array[i, j] == min)
                        {
                            betweenMinMax = !betweenMinMax;
                        }
                        else if (array[i, j] == max)
                        {
                            betweenMinMax = !betweenMinMax;
                        }
                        else if (betweenMinMax)
                        {
                            sum += array[i, j];
                        }
                    }
                }

                Console.WriteLine($"Сумма элементов между минимальным и максимальным элементами: {sum}");

                Console.Write("Желаете продолжить (да/нет)? ");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "да")
                {
                    break; 
                }
            }
        }
    }
}
