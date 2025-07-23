public class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5, 6 };
        for (int i = myArray.Length-1; i > 0 ; i--)
        {
            Console.WriteLine(myArray[i]);

        }
        Console.WriteLine("/////////////");
        foreach (var item in myArray)
        {
            Console.WriteLine(item);
        }
    }
}