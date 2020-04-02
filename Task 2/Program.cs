
using System;

namespace Task_2
{
    class Program
    {
        static int[] ArrayReverser(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = arr.Length - 1, j = 0; i >= 0 && j < arr.Length ; i--, j++)
            {
                reversed[j] = arr[i];
            }
            return reversed;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2...");
            int[] arr = new int[10];
            for(int i = 0; i < 10; i++)
            {
                arr[i] = new Random().Next(0, 10);
            }
            Console.WriteLine("Элементы Массива:");
            Array.ForEach(arr, item1 => {
                Console.WriteLine(item1);
            });
            arr = ArrayReverser(arr);
            Console.WriteLine("Инвертированный массив:");
            Array.ForEach(arr, item2 => {
                Console.WriteLine(item2);
            });
        }
    }
}
