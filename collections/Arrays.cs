namespace Collections
{
    public class Arrays
    {
        public static void Sorting()
        {
            Console.WriteLine($"Run {nameof(Sorting)}");
            var numbers = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            // sort in descending order
            Array.Sort(numbers, (x, y) => Comparer<int>.Default.Compare(y, x));
            //Array.Sort(numbers, (x, y) => y.CompareTo(x));
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
        }
    }
}

