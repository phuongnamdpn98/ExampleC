// See https://aka.ms/new-console-template for more information

namespace Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Hay nhap mot so tren bàn phím: ");
            int so = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Số vừa nhập " + so);
        }
    }
}