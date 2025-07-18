public class MyClass
{
    public static void Main(string[] args)
    {
        string gradle = "A";
        string result = gradle switch
        {
            "A" => "Xuat sac",
            "B" => "Gioi",
            "C" => "Trung Binh",
            "D" => "Yeu",
            _ => "loi roi",
        };
        Console.WriteLine("Xep loai "+ result);
    }
}