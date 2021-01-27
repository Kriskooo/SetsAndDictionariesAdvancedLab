using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<double, int> times = new Dictionary<double, int>();
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();


            foreach (var item in numbers)
            {

                if (!times.ContainsKey(item))
                {
                    times.Add(item, 0);
                }
                times[item]++;
            }
                     
            foreach (var time in times)
            {
                Console.WriteLine($"{time.Key} - {time.Value} times");
            }
        }
    }
}
