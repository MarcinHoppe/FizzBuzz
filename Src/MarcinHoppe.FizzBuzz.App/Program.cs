using System;

namespace MarcinHoppe.FizzBuzz.App
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 100;
            var results = Problem.SolveUpTo(N);
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
