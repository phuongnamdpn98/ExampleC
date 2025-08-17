public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Console.WriteLine("Nhap gia tri so nguyen a: ");
            // int a = Convert.ToInt16(Console.ReadLine());
            // Console.WriteLine("Nhap gia tri so nguyen b: ");
            // int b = Convert.ToInt16(Console.ReadLine());
            // Console.WriteLine($"Thuong la {a / b}");

            int x = int.Parse("abc");
        }
        catch (FormatException e)
        {
            //Console.WriteLine("Ban da nhap so 0");
            Console.WriteLine($"exception {e}");
        }

        try
        {
            int[] arr = new int[12];
            Console.WriteLine(arr[13]);
        }
        catch (IndexOutOfRangeException e)
        {

            Console.WriteLine($"exception out range {e}");
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine($"exception null {e}");

        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"exception out range {e}");
        }
        finally
        {
            Console.WriteLine("ket thuc");
        }
    }
}