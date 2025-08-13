public class StudentIT : Student, IEnglishComputer
{
    public string Computer { get; set; }
    public StudentIT(string name, int age, string grade, string computer)
        : base(name, age, grade)
    {
        Computer = computer;
    }

    public void ReadBookEnglish(string bookTitle)
    {
        Console.WriteLine($"Reading English book: {bookTitle}");
    }

    public void ReturnBookEnglish(string bookTitle)
    {
        Console.WriteLine($"Returning English book: {bookTitle}");
    }
}