public class Program
{
    public static void Main(string[] args)
    {
        string[,] myArray = {
            {"Ha Noi", "HCM", "Thai Nguyen"},
            {"Cao Bang", "Bac Can", "Hon Gai"},
            {"Lam Dong", "An Giang", "Vung Tau"},
        };
        Console.WriteLine("Array length " + myArray.GetLength(0));
        Console.WriteLine("Array length " + myArray.GetLength(1));
        
    }
}