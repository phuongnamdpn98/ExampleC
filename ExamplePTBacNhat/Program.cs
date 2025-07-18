// phuong trinh bac nhat ax + b = 0
public class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap gia tri a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double x;

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("phuong trinh vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            
        }
        else
        {
            x = -b / a;
            Console.WriteLine("Gia tri x la " + x);
        }
    }
}