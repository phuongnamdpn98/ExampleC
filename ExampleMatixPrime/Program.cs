public class Program
{
    public static void Main(string[] args)
    {
        int[,] a =
        {
            { 1, 2, 3, 4, 5, },
            {  6, 7, 8, 9, 10 },
            { 11, 12, 13, 14, 15 }
        };
        Console.WriteLine("Mang 2 chieu a:");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nCac so nguyen to trong mang 2 chieu a:");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (IsPrime(a[i, j]))
                {
                    Console.WriteLine($"\n{a[i, j]} la so nguyen to tai vi tri [{i}, {j}]");
                }
            }
        }

    }   

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    } 
}