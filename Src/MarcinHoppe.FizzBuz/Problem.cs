using System;
using System.Collections.Generic;
using System.Text;

namespace MarcinHoppe.FizzBuzz
{
    public static class Problem
    {
        private static bool IsEmpty(this StringBuilder builder)
        {
            return builder.Length == 0;
        }

        public static IEnumerable<string> SolveUpTo(int n)
        {
            for (int i = 1; i <= n; ++i)
            {
                StringBuilder result = new StringBuilder();
                if (i % 3 == 0)
                {
                    result.Append("Fizz");
                }
                if (i % 5 == 0)
                {
                    result.Append("Buzz");
                }
                // None of the above matched?
                if (result.IsEmpty())
                {
                    result.Append(i.ToString());
                }
                yield return result.ToString();
            }
        }
    }
}
