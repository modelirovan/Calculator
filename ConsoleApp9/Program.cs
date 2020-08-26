using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    public abstract class Device
    {
        public abstract int CalculateR(List<int> parameters);
    }

    class Device1 : Device
    {
        public override int CalculateR(List<int> parameters)
        {
            var res = parameters.Sum(x => x);
            return res % 255;
        }
    }
    public class Device2 : Device
    {
        public override int CalculateR(List<int> parameters)
        {
            var res = parameters.Aggregate((x, y) => x * y);
            return res % 255;
        }
    }

    public class Device3 : Device
    {
        public override int CalculateR(List<int> parameters)
        {
            var res = parameters.Max();
            return res;
        }
    }

    public class Device4 : Device
    {
        public override int CalculateR(List<int> parameters)
        {
            var res = parameters.Min();
            return res;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            var listOfParameters = new List<List<int>>()
            {
                new List<int> { 1, 5, 6 },
                new List<int> { 2, 5, 6 },
                new List<int> { 3, 5, 6 },
                new List<int> { 4, 5, 6 }
            };

            List<int> arrayR = CalculationService.Calculate(listOfParameters);

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
