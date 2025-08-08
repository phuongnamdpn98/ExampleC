using System.Linq;
public class Program
{
    public static void Main(string[] args)
    {
        char[] characters = {
            'x', 'g', 'c', 'b', 'e', 'd', 'i', 'z', 'h'
        };

        var sortedChars = characters.OrderBy(c => c);
        foreach (var c in sortedChars)
        {
            Console.Write(c + " ");
        }
    }
}