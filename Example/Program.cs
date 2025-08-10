// See https://aka.ms/new-console-template for more information

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //     Console.WriteLine("Hello, World!");
            //     Console.Write("Hay nhap mot so tren bàn phím: ");
            //     int so = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Số vừa nhập " + so);
            Console.Write("Hay nhap bán kính hình tròn: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double s = Math.PI * r * r;
            Console.WriteLine("Bán kính là: " + s);
            //ConsoleKey key = Console.ReadKey(true).Key;
            //Console.WriteLine(Console.ReadKey(false).Key);
        }
    }
}