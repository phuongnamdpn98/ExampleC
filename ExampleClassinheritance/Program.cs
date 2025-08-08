public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double MathScore { get; set; }

    public double EnglishScore { get; set; }

    public Student(string Name, int Age, double MathScore, double EnglishScore)
    {
        this.Name = Name;
        this.Age = Age;
        this.MathScore = MathScore;
        this.EnglishScore = EnglishScore;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Math Score: {MathScore}, English Score: {EnglishScore}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Alice", 20, 85.5, 90.0);
        Student student2 = new Student("Bob", 22, 78.0, 82.5);
        //Console.WriteLine($"Student 1: {student1.Name}, Age: {student1.Age}, Math Score: {student1.MathScore}, English Score: {student1.EnglishScore}");
        //Console.WriteLine($"Student 2: {student2.Name}, Age: {student2.Name}, Math Score: {student2.MathScore}, English Score: {student2.EnglishScore}");
        student1.DisplayInfo();
        student2.DisplayInfo();
    }
}