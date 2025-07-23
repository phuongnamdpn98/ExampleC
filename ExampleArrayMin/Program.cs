public class Program
{
    public static void Main(string[] args)
    {
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int min = myArray[0];
        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] < min)
            {
                min = myArray[i];
            }
        }
        Console.WriteLine("Gia tri nho nhat la "+ min);
    }    
}