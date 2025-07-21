public class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hien thi cac so nguyen to");
        for (int i = 2; i < 100; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(" " + i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
}