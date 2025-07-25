﻿public class Program
{
    public static void Main(string[] args)
    {
        int[,] matrix = new int[4, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
        }

        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[i, j];
            }
        }
        Console.WriteLine("\nTong la " + sum);

        int sum2 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    sum2 += matrix[i, j];
                }
            }
        }
        Console.WriteLine("Tong la " + sum2);
        
        int max = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] > max)
                {
                    max = matrix[i, j];
                }
                
            }
        }
        Console.WriteLine("Max cua mang la " + max);
    }
}