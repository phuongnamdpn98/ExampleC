class Program
{
    public static void Main(string[] args)
    {
        float width;
        float height;
        Console.WriteLine("Nhap gia tri cua chieu rong: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap gia tri cua chieu dai: ");
        height = Convert.ToInt32(Console.ReadLine());
        float area = width * height;
        Console.WriteLine($"gia tri cua dien tich la: {area}");
    }
}