public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap can nang: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap chieu cao: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double bmi = weight / Math.Pow(height, 2);
        bmi = Math.Round(bmi,1);
        Console.Write("BMI la " + bmi);

        if (bmi < 18)
        {
            Console.WriteLine(" Thieu can");
        }
        else if (bmi < 25.0)
        {
            Console.WriteLine(" Binh thuong");
        }
        else if (bmi < 30.0)
        {
            Console.WriteLine(" Thua can");
        }
        else
        {
            Console.WriteLine(" Beo phi");
        }
    }   
}