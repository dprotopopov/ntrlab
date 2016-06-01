using System;
using System.Collections.Generic;

namespace ntrlab1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<int>();
            Console.WriteLine("Введите число элементов массива:");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите построчно элементы массива:");
            for (var i = 0; i < n; i++) list.Add(Convert.ToInt32(Console.ReadLine()));
            var sum = LargestSum.find(list.ToArray());
            Console.WriteLine("Наибольшая сумма:");
            Console.WriteLine(sum);
        }
    }
}