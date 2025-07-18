public class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao so: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 10 && number >= 0)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("khong");
                    break;
                case 1:
                    Console.WriteLine("mot");
                    break;
                case 2:
                    Console.WriteLine("hai");
                    break;
                case 3:
                    Console.WriteLine("ba");
                    break;
                case 4:
                    Console.WriteLine("bon");
                    break;
                case 5:
                    Console.WriteLine("nam");
                    break;
                case 6:
                    Console.WriteLine("sau");
                    break;
                case 7:
                    Console.WriteLine("bay");
                    break;
                case 8:
                    Console.WriteLine("tam");
                    break;
                case 9:
                    Console.WriteLine("chin");
                    break;
                default:
                    Console.WriteLine("loi roi");
                    break;
            }
        }
        else if (number < 20 && number >= 10)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("muoi");
                    break;
                case 11:
                    Console.WriteLine("muoi mot");
                    break;
                case 12:
                    Console.WriteLine("muoi hai");
                    break;
                case 13:
                    Console.WriteLine("muoi ba");
                    break;
                case 14:
                    Console.WriteLine("muoi bon");
                    break;
                case 15:
                    Console.WriteLine("muoi nam");
                    break;
                case 16:
                    Console.WriteLine("muoi sau");
                    break;
                case 17:
                    Console.WriteLine("muoi bay");
                    break;
                case 18:
                    Console.WriteLine("muoi tam");
                    break;
                case 19:
                    Console.WriteLine("muoi chin");
                    break;
                default:
                    Console.WriteLine("loi roi");
                    break;
            }
        }
        else if (number >= 20 && number <= 99)
        {
            int chuc = number / 10;
            int donVi = number % 10;
            switch (chuc)
            {

                case 2:
                    Console.Write("hai");
                    break;
                case 3:
                    Console.Write("ba");
                    break;
                case 4:
                    Console.Write("bon");
                    break;
                case 5:
                    Console.Write("nam");
                    break;
                case 6:
                    Console.Write("sau");
                    break;
                case 7:
                    Console.Write("bay");
                    break;
                case 8:
                    Console.Write("tam");
                    break;
                case 9:
                    Console.Write("chin");
                    break;
                default:
                    Console.Write("loi roi");
                    break;
            }
            switch (donVi)
            {
                case 0:
                    Console.Write(" khong");
                    break;
                case 1:
                    Console.Write(" mot");
                    break;
                case 2:
                    Console.Write(" hai");
                    break;
                case 3:
                    Console.Write(" ba");
                    break;
                case 4:
                    Console.Write(" bon");
                    break;
                case 5:
                    Console.Write(" nam");
                    break;
                case 6:
                    Console.Write(" sau");
                    break;
                case 7:
                    Console.Write(" bay");
                    break;
                case 8:
                    Console.Write(" tam");
                    break;
                case 9:
                    Console.Write(" chin");
                    break;
                default:
                    Console.Write("loi roi");
                    break;
            }
        }
        else
        {

        }
    }

}