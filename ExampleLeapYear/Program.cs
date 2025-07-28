public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao nam: ");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeapYear = false;

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    isLeapYear = true;
                }
            }
            else
            {
                isLeapYear = true;
            }
        }
        if (isLeapYear)
        {
            Console.WriteLine($"{year} la nam nhuan");
        }
        else
        {
            Console.WriteLine($"{year} khong phai la nam nhuan");
        }
    }    
}