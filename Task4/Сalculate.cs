using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal static class Сalculate
    {
        public static int GetDigitSum(int number) =>
            Math.Abs(number).ToString().Sum(c => c - '0');

        public static int[] SortBy(this int[] numbers, Func<int, int> predicate, bool ascending = true)
        {
            return ascending? numbers.OrderBy(predicate).ToArray()
                : numbers.OrderByDescending(predicate).ToArray();
        }
    }
}
