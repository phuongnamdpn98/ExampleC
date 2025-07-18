public class MyClass
{
    public static void Main(string[] args)
    {
        double money = 1;
        double month = 1;
        double interset_rate = 1.0;
        Console.WriteLine("Nhap gia tri tien: ");
        money = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap thang; ");
        month = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap ty gia: ");
        interset_rate = Convert.ToDouble(Console.ReadLine());

        double total_interset = 0;
        for (int i = 0; i < month; i++)
        {
            total_interset = money * (interset_rate / 100) / 12 * 3;
        }
        Console.WriteLine("tong la: " + total_interset);
    }
}