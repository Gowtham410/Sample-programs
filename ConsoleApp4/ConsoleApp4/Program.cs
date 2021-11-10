using System;
using System.Collections.Generic;
namespace ConsoleApp4
{
    class Program
    {
        public static void Main(string[] args)
        {
            var fibonacciNumbers = new List<int> { 1, 1 };
            while(fibonacciNumbers.Count <= 20)
            {
                var pervious = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var pervious2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(pervious + pervious2);
            }
            foreach (var item in fibonacciNumbers)
                Console.WriteLine(item);
        }
    }
}