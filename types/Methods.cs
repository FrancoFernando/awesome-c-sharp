/*
 
💜 C#: discard variable 💜

If you have no use for some returned values, you can ignored them with the discard variable,

➤ write only variable
➤ denoted by an underscore
➤ useful to ignore an out argument
➤ useful to ignore a returned value from a Tuple

----------------------------------------

*/


using System;

namespace Methods
{

    class Program
    {
       
        static void Main()
        {
            Random random = new Random();
            (int, int, int) Get3DPoint() => (
                random.Next(),
                random.Next(),
                random.Next()
                );

            // Use only coordinates on the 2D plane
            var (x, y, _) = Get3DPoint();
            // Check only if is an integer
            bool isInt = int.TryParse("1927", out _);

            Console.WriteLine($"{x}, {y}");
            Console.WriteLine(isInt);
        }
    }
}
