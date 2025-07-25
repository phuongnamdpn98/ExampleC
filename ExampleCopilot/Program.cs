using System;

public class Program
{
    public static void Main(string[] args)
    {
        int rows = 4;
        int cols = 3;
        int[,] array = new int[rows, cols];
        Random rand = new Random();

        // Khởi tạo mảng với giá trị ngẫu nhiên từ 0 đến 100
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rand.Next(0, 101);
            }
        }

        // Hiển thị mảng ra console
        Console.WriteLine("Mảng 2 chiều:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Tính tổng các phần tử trong mảng
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }
        }

        Console.WriteLine("Tổng các phần tử trong mảng: " + sum);
    }   
}