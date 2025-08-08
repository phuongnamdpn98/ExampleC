public class Program
{
    public static int CountChar(string str, char c)
    {
        int count = 0;
        foreach (char ch in str)
        {
            if (ch == c)
            {
                count++;
            }
        }

        return count;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap chuoi:");
        string str = Console.ReadLine();
        Console.WriteLine("Nhap ky tu can dem: ");
        char c = Console.ReadKey().KeyChar;
        Console.WriteLine();
        int count = CountChar(str, c);
        Console.WriteLine($"So lan xuat hien cua '{c}' trong chuoi '{str}' la: {count}");
        
    }    
}