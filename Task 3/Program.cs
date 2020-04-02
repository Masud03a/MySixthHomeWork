
using System;

namespace Task_3
{
    class Program
    {
        static void ExecuteThirdTask(int elseCount)
        {
            int[] arr = new int[elseCount];
            for (int i = 0; i < elseCount; i++)
            {
                arr[i] = new Random().Next(50, 100);
            }

            Array.ForEach(arr, item => {
                Console.WriteLine(item);
            });

            Console.Write("Введите (count): ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Введите (index): ");
            int index = int.Parse(Console.ReadLine());
            
            int[] arr1 = new int[count];
            for(int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 1;
            }
            for(int i = index, j = 0; j <= count; i++, j++)
            {
                try
                {
                    arr1[j] = arr[i];
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
                    
            }
            
            Array.ForEach(arr1, item => {
                Console.WriteLine(item);
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Задача 2...");
            Console.Write("Введите размер массива: ");
            int elseCount = int.Parse(Console.ReadLine());
            ExecuteThirdTask(elseCount);
        }
    }
}
