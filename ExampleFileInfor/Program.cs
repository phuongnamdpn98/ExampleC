public class Program
{
    public static void Main(string[] args)
    {
        // string sourceFilePath = "D:\\Unity\\Source.txt";
        // string destinationFilePath = "D:\\Unity\\Destination.txt";
        // FileInfo sourceFile = new FileInfo(sourceFilePath);
        // sourceFile.CopyTo(destinationFilePath, true);
        // long fileSize = sourceFile.Length;
        // Console.WriteLine($"File copied successfully Size {fileSize}");
        // bool doesFileExist = File.Exists(destinationFilePath);
        // File.Copy(sourceFilePath, destinationFilePath, true);
        // Console.WriteLine($"File copy is {sourceFilePath} to {destinationFilePath} File exist: {doesFileExist}");

        string filePath = "D:\\Unity\\FileNew";
        //Directory.CreateDirectory(filePath);
        DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
        directoryInfo.Create();
    }    
}