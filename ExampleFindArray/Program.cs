public class Program
{
    public static void Main(string[] args)
    {
        string[] students = { "Chrismast", "Micheanl", "Camilia", "Sienna" };
        Console.Write("Nhap vao mot cai ten: ");
        string inputName = Console.ReadLine();
        bool isExit = false;
        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].Equals(inputName))
            {
                Console.WriteLine("co ten do trong mang co vi tri la " + i);
                isExit = true;
                break;
            }
        }
        if (!isExit)
        {
            Console.WriteLine("Khong tim thay ten nhu vay");
        }
    }    
}