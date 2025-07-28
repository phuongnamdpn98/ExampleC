public class Program
{
    public static void Main(string[] args)
    {
        int size;
        int[] array;
        do
        {
            Console.WriteLine("Enter a size:");
            size = Convert.ToInt32(Console.ReadLine());
            if (size > 20)
                Console.WriteLine("Size should not exceed 20");
        } while (size > 20);

        array = new int[size];
        int i = 0;
        while (i < array.Length)
        {
            Console.WriteLine("nhap gia tri" + (i + 1) + " : ");
            array[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }

        Console.WriteLine("Hien thi mang: ");
        for (int j = 0; j < array.Length; j++)
        {
            Console.WriteLine(array[j] + "\t");
        }

        int max = array[0];
        int index = 0;
        for (int j = 1; j < array.Length; j++)
        {
            if (array[j] > max)
            {
                max = array[j];
                index = j + 1;
            }
        }

        Console.WriteLine("Phan tu lon nhat trong mang la: " + max + " tai vi tri: " + index);
    }

}