public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao so a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap vao so b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        a = Math.Abs(a);
        b = Math.Abs(b);

        if (a == 0 || b == 0)
        {
            Console.WriteLine("Khong co uoc chung lon nhat");
            return;
        }

        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }
        Console.WriteLine("Uoc chung lon nhat la " + a);
    }
}
