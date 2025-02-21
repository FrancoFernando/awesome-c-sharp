public class PriorityQueue {
    public static void MinHeap()
    {
        Console.WriteLine($"Run {nameof(MinHeap)}");
        var minHeap = new PriorityQueue<string, int>();
        minHeap.Enqueue("Dybala", 1);
        minHeap.Enqueue("Cristante",5);
        minHeap.Enqueue("Hummels",3);
        minHeap.Enqueue("Paredes",2);

        Console.WriteLine($"minPriority: {minHeap.Peek()}");

        while (minHeap.Count > 0)
        {
            Console.WriteLine(minHeap.Dequeue());
        }
    }

    public static void MaxHeap()
    {
        Console.WriteLine($"Run {nameof(MaxHeap)}");
        // need custom comparer to create max heap
        var maxHeap = new PriorityQueue<string, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        maxHeap.Enqueue("Dybala", 1);
        maxHeap.Enqueue("Cristante",5);
        maxHeap.Enqueue("Hummels",3);
        maxHeap.Enqueue("Paredes",2);

        Console.WriteLine($"maxPriority: {maxHeap.Peek()}");

        while (maxHeap.Count > 0)
        {
            Console.WriteLine(maxHeap.Dequeue());
        }
    }
}