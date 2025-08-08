public class Program
{
    public static double CelsiusToFahrenheit(double celsius)
    {
        double fahrenheit = (9 / 5) * celsius + 32;
        return fahrenheit;
    }

    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (5 / 9) * (fahrenheit - 32);
        return celsius;
    }

    public static void Main(string[] args)
    {
        double fahrenheit;
        double celsius;
        int choice = -1;

        do
        {
            Console.WriteLine("Menu.");
            Console.WriteLine("1. Chuyen Fahrenheit thanh Celsius");
            Console.WriteLine("2. Chuyen Celsius thanh Fahrenheit");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap vao so: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Nhap vao do Fahrenheit: ");
                    fahrenheit = Convert.ToDouble(Console.ReadLine());
                    celsius = FahrenheitToCelsius(fahrenheit);
                    Console.WriteLine($"Do Celsius la: {celsius}");
                    break;
                case 2:
                    Console.Write("Nhap vao do Celsius: ");
                    celsius = Convert.ToDouble(Console.ReadLine());
                    fahrenheit = CelsiusToFahrenheit(celsius);
                    Console.WriteLine($"Do Fahrenheit la: {fahrenheit}");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
        } while (choice != 0);
    }
}