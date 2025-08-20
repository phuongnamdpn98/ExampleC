public class Program
{
    private static void CopyFileUsingFileInfo(FileInfo source, FileInfo dest)
    {
        Console.WriteLine("Start copy using FileInfo");
        source.CopyTo(dest.FullName, true);
        Console.WriteLine("File copied successfully.");
    }

    private static void CopyFileUsingStream(FileInfo source, FileInfo dest)
    {
        Console.WriteLine("Start copy using Stream");
        StreamReader reader = null;
        StreamWriter writer = null;
        try
        {
            reader = new StreamReader(source.FullName);
            writer = new StreamWriter(dest.FullName);
            char[] buffer = new char[1024];
            int lenght;
            while ((lenght = reader.Read(buffer)) > 0)
            {
                writer.Write(buffer, 0, lenght);
            }
        }
        finally
        {
            reader.Close();
            reader.Dispose();
            writer.Close();
            writer.Dispose();
        }

    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter source file: ");
        string sourcePath = Console.ReadLine();
        Console.WriteLine("Enter destination file: ");
        string destinationPath = Console.ReadLine();

        FileInfo source = new FileInfo(sourcePath);
        FileInfo des = new FileInfo(destinationPath);
        try
        {
            CopyFileUsingFileInfo(source, des);
            Console.WriteLine("Copy Completed");
        }
        catch (IOException e)
        {
            Console.WriteLine("Cannot Copy");
            Console.Error.WriteLine(e.Message);
        }
    }
}