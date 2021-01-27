using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> names = new Dictionary<string, List<decimal>>();


            for (int i = 0; i < num; i++)
            {
                var students = Console.ReadLine().Split();
                var name = students[0];
                var grade = decimal.Parse(students[1]);

                if (!names.ContainsKey(name))
                {
                    names.Add(name, new List<decimal>());

                }
                names[name].Add(grade);
            }
            foreach (var students in names)
            {
                Console.Write($"{students.Key} -> ");

                foreach (var grade in students.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {students.Value.Average():F2})");
            }
        }
    }
}
