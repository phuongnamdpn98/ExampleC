public class MyClass
{
    // nhap 3 so a,b,c kiem tra xem 3 so nhap co thoa man hinh tam gia khong
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.WriteLine("nhap canh a");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap canh b");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap canh c");
        c = Convert.ToInt32(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("la canh cua tam giac");
            }
            else
            {
                Console.WriteLine("khong phai canh cua tam giac");
            }
        }
        else
        {
            Console.WriteLine("Cac canh phai lon hon 0");
        }
    }   
}