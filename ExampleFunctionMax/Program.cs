public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int maxNumber = Max(numbers);
        Console.WriteLine($"The maximum number is: {maxNumber}");
    }   
    
    public static int Max(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            return 0;
        }

        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}