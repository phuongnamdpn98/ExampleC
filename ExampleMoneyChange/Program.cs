public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Nhap so tien USD: ");
        int moneyVND = 23000;
        int moneyUSD = Convert.ToInt32(Console.ReadLine());
        int change = moneyUSD * moneyVND;
        Console.WriteLine("So tien VND la: " + change);
    }    
}