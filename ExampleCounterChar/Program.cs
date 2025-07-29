public class Program
{
    static Dictionary<char, int> CountCharactere(string input)
    {
        Dictionary<char, int> characterCount = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (characterCount.ContainsKey(c))
            {
                characterCount[c]++;
            }
            else
            {
                characterCount[c] = 1;
            }
        }
        return characterCount;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Dictionary<char, int> characterCount = CountCharactere(input);
        Console.WriteLine("Character counts:");
        foreach (var pair in characterCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}