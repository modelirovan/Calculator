using CalculationLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var listOfParameters = new List<List<int>>()
            {
                new List<int> { 1, 5, 6 },
                new List<int> { 2, 5, 6 },
                new List<int> { 3, 5, 6 },
                new List<int> { 4, 5, 6 }
            };

            List<int> arrayR = CalculationService.CalculateR(listOfParameters);

            foreach (var item in arrayR)
            {
                Console.WriteLine(item.ToString());
            }
            arrayR = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            var mediana = CalculationService.CalculateMediana(arrayR);

            Console.WriteLine($"Mediana = {mediana}");

            Console.ReadLine();
        }
    }
}
