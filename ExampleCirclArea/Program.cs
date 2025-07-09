public class MyClass
{
    // Nhap ban phim ban kinh hinh tron va tinh dien tich chu vi   
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap ban kinh hinh tron: ");
        double r = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * r * r;
        double pre = 2 * Math.PI * r;
        Console.WriteLine("Dien tich la: " + area);
        Console.WriteLine($"Chu vi la: {pre}");
    }
}