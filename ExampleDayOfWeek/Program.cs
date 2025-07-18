public class MyClass
{
    public static void Main(string[] args)
    {
        string day = "monday";
        switch (day)
        {
            case "monday":
                Console.WriteLine("Thu 2");
                break;
            case "tuesday":
                Console.WriteLine("Thu 3");
                break;
            case "webnesday":
                Console.WriteLine("Thu 4");
                break;
            case "thurday":
                Console.WriteLine("Thu 5");
                break;
            case "friday":
                Console.WriteLine("Thu 6");
                break;
            case "saturday":
                Console.WriteLine("Thu 7");
                break;
            case "sunday":
                Console.WriteLine("Thu cn");
                break;
            default:
                Console.WriteLine("Thu ban nhap khong co");
                break;
        }
    }
}