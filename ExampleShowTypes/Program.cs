public class Program
{
    public static void Main(string[] args)
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. In hinh chu nhat");
            Console.WriteLine("2. In hinh tam giac vuong (bottom-left)");
            Console.WriteLine("3. In hinh tam giac vuong (top-left)");
            Console.WriteLine("0. Thoat");
            Console.Write("Hay nhap vao 1 so trong menu:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ve hinh chu nhat");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 2:
                    Console.WriteLine("Ve hinh tam giac (bottom-left)");
                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    Console.WriteLine("Ve hinh tam giac (top-left)");
                    for (int i = 7; i >= 1; i--)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }   
}