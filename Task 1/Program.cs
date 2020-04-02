
using System;

namespace Task_1
{
    class Program
    {
        static string ExecuteFirstTask(int elCount)
        {
            int maxEl = 0, minEl = 0, generalSum = 0;
            int[] arr = new int[elCount];
            string oddNumbersStr = "Нечетные числа: ";

            for (int i = 0; i < elCount; i++)
            {
                arr[i] = new Random().Next(0, 100);
            }

            Array.Sort(arr);
            maxEl = arr[arr.Length - 1];
            minEl = arr[0];

            Array.ForEach(arr, item => {
                generalSum += item;
                if(item % 2 == 1)
                {
                    oddNumbersStr += $"-| {item} |-";
                }
            });

            return $"Результат: Наибольшее значение массива: {maxEl}\n"+
            $"Наименьшее значение массива: {minEl}\n"+
            $"Общую сумму всех элементов: {generalSum}\n"+
            $"Среднее арифметическое всех элементов: {generalSum / 3}\n"+
            $"{oddNumbersStr}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1...");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(ExecuteFirstTask(N));
        }
    }
}
