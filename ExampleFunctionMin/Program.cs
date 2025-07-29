public class Program
{
    // Hàm tìm giá trị nhỏ nhất của mảng
    public static int FindMin(int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3 };
        int minValue = FindMin(numbers);
        System.Console.WriteLine("Giá trị nhỏ nhất của mảng là: " + minValue);
    }
}