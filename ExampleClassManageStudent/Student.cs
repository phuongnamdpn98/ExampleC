public class Student : IReaderBook
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
    }

    public void ReadBook(string bookTitle)
    {
        Console.WriteLine($"Reading book: {bookTitle}");
    }

    public void ReturnBook(string bookTitle)
    {
        Console.WriteLine($"Returning book: {bookTitle}");
    }
}