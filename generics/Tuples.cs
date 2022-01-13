/*
 
💜 C#: named tuples 💜

You can make your code more readable using named tuples.

➤ tuple elements are named by default Item1, Item2, ...

➤ custom names can be assigned when declaring the tuple

➤ iterating through a list of named tuples increase readability
----------------------------------------

*/


using System;
using System.Collections.Generic;

namespace Tuples
{
    class Program
    {
        static void Main()
        {
            var namedTuple = (Color: "Red", Shape: "Triangle");
            Console.WriteLine(namedTuple.Color, namedTuple.Shape);

            var namedTuples = new List<(string Color, string Shape)>
            {
                ("Red", "Triangle"),
                ("Green", "Square")
            };

            foreach (var myTuple in namedTuples)
            {
                Console.WriteLine(myTuple.Color, myTuple.Shape);
            }
        }
    }
}
