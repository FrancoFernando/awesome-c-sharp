/*
 
💜 C#: nameof  💜

You can use nameof to put a named item name into a string.

➤ avoid silly mistakes and problems caused when renaming a symbol

➤ work with arguments, variables, properties, methods

➤ handy with ArgumentException and its derivatives

----------------------------------------

*/


using System;
using System.IO;
using System.Linq;

namespace Exceptions
{

    class Program
    {
        public static int CountVowels(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            return text.Count(c => "aeiou".Contains(Char.ToLower(c)));
        }
        static void Main(string[] args)
        {
            try {
                Console.WriteLine(CountVowels(null));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed with message: {ex.Message}.");
            }

        }
    }
}
