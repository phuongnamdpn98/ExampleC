public class Program
{
    public static void Main(string[] args)
    {
        int[] arrays = { 1, 3, 4, 2, 6, 5, 8, 7, 10, 9 };
        var sortedArray = arrays.OrderByDescending(n => n);
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }
    }
    
}