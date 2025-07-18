public class MyClass
{
    public static void Main(string[] args)
    {
        double a, b, c, x;
        Console.WriteLine("nhap gia tri a");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("nhap gia tri b");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("nhap gia tri c");
        c = Convert.ToDouble(Console.ReadLine());

        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("vo so nghiem");
                }
                else
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                }
            }
            else
            {
                x = -c / b;
                Console.WriteLine("co nghiem la x la " + x);
            }
        }
        else
        {
            double delta = (b * b - 4 * a * c);
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)/2 *a);
                double x2 = (-b - Math.Sqrt(delta)/2 *a);

                Console.WriteLine("nghiem co x1 la " + x1);
                Console.WriteLine("nghiem co x2 la " + x2);

            }
            else if (delta == 0)
            {
                x = -b / (2*a);
                Console.WriteLine("nghiem kep la " + x);

            }
            else
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
        }
    }
}