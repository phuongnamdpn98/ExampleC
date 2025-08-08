using System.Linq;  

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var sortedNumbers = numbers.OrderBy(n => n);
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}