/*
LINQ implements queries in a lazy way without materializing the resulting collection at once.

This negatively affects the performances if you need multiple iterations over the collection.

You can fix this materializing the query only once (e.g. using ToList).
*/


using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Enumerable.Range(0, 10000);
            // ToList materialize the query once for all loops
            var evenNums = nums.Where(element => element % 2 == 0).ToList();

            foreach (var num in evenNums) Console.WriteLine($"{num * 2}");

            foreach (var num in evenNums) Console.WriteLine($"{num * 3}");

            foreach (var num in evenNums) Console.WriteLine($"{num * 5}");

        }
    }
}
