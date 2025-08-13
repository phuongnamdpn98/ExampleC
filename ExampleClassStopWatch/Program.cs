public class StopWatch
{
    private long _startTime;
    private long _endTime;

    public long StartTime
    {
        get { return _startTime; }
        set { _startTime = value; }
    }

    public long EndTime
    {
        get { return _endTime; }
        set { _endTime = value; }
    }

    public StopWatch()
    {
        _startTime = 0;
        _endTime = 0;
    }

    public void Start()
    {
        _startTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }

    public void Stop()
    {
        _endTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }

    public long ElapsedMilliseconds()
    {
        if (_endTime > _startTime)
        {
            return _endTime - _startTime;
        }
        else
        {
            return 0;
        }
    }
}

public class Program
{
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    
    public static void PrintArray(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public static void SelectionSort(int[] arr, int n)
    {
        if (arr == null || n <= 0) return;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex]) minIndex = j;
            }

            if (minIndex != i)
            {
                Swap(ref arr[i], ref arr[minIndex]);
            }
        }

    }

    public static void Main(string[] args)
    {
        StopWatch stopWatch = new StopWatch();
        stopWatch.Start();

        int[] arr = { 57, 183, 299, 6, 250, 143, 58, 212, 91, 37,
        276, 119, 22, 147, 280, 134, 65, 295, 11, 223,
        150, 5, 204, 121, 78, 256, 34, 198, 289, 112,
        90, 165, 274, 49, 185, 271, 132, 59, 236, 18,
        63, 294, 207, 101, 39, 220, 132, 56, 243, 173,
        27, 198, 7, 190, 158, 82, 300, 14, 249, 131,
        76, 263, 88, 203, 45, 179, 275, 96, 254, 167,
        142, 248, 114, 30, 218, 6, 192, 161, 89, 267,
        154, 51, 287, 33, 227, 124, 68, 16, 281, 99,
        125, 260, 43, 171, 91, 55, 216, 36, 229, 138,
        19, 293, 107, 166, 80, 240, 65, 52, 230, 174,
        12, 268, 102, 139, 77, 256, 44, 221, 9, 185,
        53, 278, 118, 2, 262, 130, 95, 157, 38, 227,
        17, 244, 74, 208, 60, 213, 35, 196, 84, 277,
        29, 183, 111, 201, 47, 270, 129, 71, 234, 153,
        15, 191, 118, 39, 205, 67, 246, 20, 199, 105,
        83, 289, 54, 222, 100, 249, 26, 168, 57, 214,
        127, 204, 41, 233, 79, 272, 115, 32, 189, 98,
        23, 202, 70, 239, 140, 65, 162, 46, 231, 88,
        13, 255, 81, 243, 58, 219, 28, 175, 108, 264};

        int n = 200;
        Console.WriteLine("Original array:");
        PrintArray(arr, n);
        SelectionSort(arr, n);
        stopWatch.Stop();
        long elapsed = stopWatch.ElapsedMilliseconds();
        Console.WriteLine("Sorted array:");
        PrintArray(arr, n);
        Console.WriteLine("\nElapsed time: " + elapsed + " milliseconds");
    }   
}