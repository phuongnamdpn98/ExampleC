public class Program
{
    public static void ReadTextFile(string filePath)
    {
        try
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException($"The file '{filePath}' does not exist.");
            }
            StreamReader reader = new StreamReader(fileInfo.FullName);
            string line = "";
            int sum = 0;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                sum += Int32.Parse(line);
            }
            reader.Close();
            Console.WriteLine("Total Sum: " + sum);
        }
        catch (System.Exception)
        {

            Console.Error.WriteLine("File not found or invalid content");
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Please input file path");
        string path = Console.ReadLine();
        Console.WriteLine("File path: " + path);
        ReadTextFile(path);
    }
}