public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        dictionary.Add("key1", "Book");
        dictionary.Add("key2", "Phone");
        dictionary.Add("key3", "Tivi");
        dictionary.Add("key4", "Radio");

        foreach (var item in dictionary.Keys)
        {
            Console.WriteLine(item);
        }

        foreach (var item in dictionary.Values)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("value " + dictionary["key1"]);
    }   
}