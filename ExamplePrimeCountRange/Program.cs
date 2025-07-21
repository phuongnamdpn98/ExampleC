﻿// In so nguyen to trong mot khoang xac dinh
public class MyClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Nhap so a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap so b");
        int b = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for (int i = a; i <= b; i++)
        {

            if (IsPrime(i))
            {
                Console.Write(" " + i);
                count++;
            }
        }
        Console.WriteLine($"so nguyen to gom {count} so");
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
}