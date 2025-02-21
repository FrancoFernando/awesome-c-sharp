/*
 
The LINQ method Zip can combine 2 collections paired by their index values.

You can use it to pair data from the 2 collection into Tuple instances.

Or you can define a lambda specifying how the paired elements should be combined.

----------------------------------------

*/


namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
          string[] firstNames = { "Ayrton", "Alain", "Nelson", "Lewis" };
          string[] lastNames = { "Senna", "Prost", "Piquet", "Hamilton" };

          // IEnumerable<string>
          var fullNames = firstNames.Zip(lastNames, (first, last) => first + " " + last);
          foreach (string name in fullNames)
          {
            Console.WriteLine(name);
          }
          // IEnumerable<(string First, string Second)> 
          var zippedNames = firstNames.Zip(lastNames);
          foreach (var tuple in zippedNames)
          {
            Console.WriteLine(tuple.Item1 + ' ' + tuple.Item2);
          }

        }
    }
}
