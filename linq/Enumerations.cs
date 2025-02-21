
namespace Linq
{
    public class Enumerations
    {
        // LINQ implements queries in a lazy way without materializing the resulting collection at once.
        // This negatively affects the performances if you need multiple iterations over the collection.
        // You can fix this materializing the query only once (e.g. using ToList).
        public static void MaterializeQuery()
        {
            Console.WriteLine($"Run {nameof(MaterializeQuery)}");
            var nums = Enumerable.Range(0, 100);
            // ToList materialize the query once for all loops
            var evenNums = nums.Where(element => element % 2 == 0).ToList();

            foreach (var num in evenNums) Console.WriteLine($"{num * 2}");

            foreach (var num in evenNums) Console.WriteLine($"{num * 3}");

            foreach (var num in evenNums) Console.WriteLine($"{num * 5}");

        }

        // The LINQ method Zip can combine 2 collections paired by their index values.
        // You can use it to pair data from the 2 collection into Tuple instances.
        // Or you can define a lambda specifying how the paired elements should be combined.
        public static void Zip()
        {
          Console.WriteLine($"Run {nameof(Zip)}");
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
