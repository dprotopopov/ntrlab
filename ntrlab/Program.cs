using System;
using System.Collections.Generic;

namespace ntrlab
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var list = new List<int>();
            Console.WriteLine("Введите число элементов массива:");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Вводите построчно элементы массива:");
            for (var i = 0; i < n; i++) list.Add(Convert.ToInt32(Console.ReadLine()));
            list.Sort();
            Console.WriteLine("Введите искомое число:");
            var value = Convert.ToInt32(Console.ReadLine());
            var index = BinarySearch.search(list.ToArray(), value);
            Console.WriteLine("Индес элемента:");
            Console.WriteLine(index);
        }
    }
}
