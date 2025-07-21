public class MyClass
{
    public static void Main(string[] args)
    {

        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Ve hinh tam giac");
            Console.WriteLine("2. Ve hinh vuong");
            Console.WriteLine("3. Ve hinh chu nhat");
            Console.WriteLine("0. Thoat");
            Console.Write("Hay nhap vao 1 so trong menu:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ve hinh tam giac");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    break;
                case 2:
                    Console.WriteLine("Ve hinh vuong");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 3:
                    Console.WriteLine("Ve hinh chu nhat");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
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