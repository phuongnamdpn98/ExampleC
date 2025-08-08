public class Program
{
    public static void PrintArray(int[] arrays)
    {
        foreach (int i in arrays)
        {
            Console.Write(" " + i);
        }
    }

    public static void RemoveElementArray(int[] arr, int position)
    {
        if (position < 0 || position >= arr.Length) return;

        int[] newArr = new int[arr.Length - 1];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != position)
            {
                newArr[j] = arr[i];
                j++;
            }
        }
        Console.WriteLine("Mang sau khi xoa phan tu tai vi tri " + position + " la:");
        PrintArray(newArr);
    }

    public static void Main(string[] args)
    {
        int[] arr = { 10, 4, 6, 7, 8, 6, 9 };
        Console.WriteLine("Mang ban dau la:");
        PrintArray(arr);
        Console.WriteLine("\nNhap vi tri can xoa:");
        int position = Convert.ToInt32(Console.ReadLine());
        RemoveElementArray(arr, position);
    }
}