﻿public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Nhap phan tu [{i},{j}]: ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Mang da nhap la: ");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Tong cac phan tu tren duong cheo chinh la: ");
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    sum += arr[i, j];
                }
            }
        }
        Console.WriteLine("Tong la " + sum);
    }
}