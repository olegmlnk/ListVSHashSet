using System.Diagnostics;

class Program
{
    static void Main()
    {
        const int n = 100_000;
        var list = new List<int>();
        var set = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            list.Add(i);
            set.Add(i);
        }

        // REMOVE from List
        var swList = Stopwatch.StartNew();
        for (int i = 0; i < n; i++)
        {
            list.Remove(i);
        }
        swList.Stop();
        Console.WriteLine($"List.Remove(item): {swList.ElapsedMilliseconds} ms");

        // REMOVE from HashSet
        var swSet = Stopwatch.StartNew();
        for (int i = 0; i < n; i++)
        {
            set.Remove(i);
        }
        swSet.Stop();
        Console.WriteLine($"HashSet.Remove(item): {swSet.ElapsedMilliseconds} ms");
    }
}
