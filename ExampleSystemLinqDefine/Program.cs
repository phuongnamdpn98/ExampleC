using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Score { get; set; }
}

    

public class Program
{
    public static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20, Score = 7 },
            new Student { Name = "Bob", Age = 22, Score = 8 },
            new Student { Name = "Charlie", Age = 21, Score = 9 },
            new Student { Name = "David", Age = 23, Score = 6 },
            new Student { Name = "Nam", Age = 20, Score = 10 },
            new Student { Name = "Vinh", Age = 22, Score = 5 },
            new Student { Name = "Thao", Age = 21, Score = 8 },
            new Student { Name = "Thuy", Age = 23, Score = 10 }
        };

        var groups = students.GroupBy(s =>
        {
            if (s.Score >= 8)
                return "A";
            else if (s.Score >= 6.5)
                return "B";
            else
                return "C";
        });
        foreach (var group in groups)
        {
            Console.WriteLine($"Group {group.Key}:");
            foreach (var student in group)
            {
                Console.WriteLine($"- {student.Name}, Age: {student.Age}, Score: {student.Score}");
            }
        }
        // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        //                      11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        // var evenNumbers = numbers.Where(n => n % 2 == 0);
        // foreach (var number in evenNumbers)
        // {
        //     Console.WriteLine(number);
        // }

        // bool hasEvenNumbers = numbers.Any(n => n % 2 == 0); // xac định xem có số chẵn nào trong mảng hay không
        // Console.WriteLine($"Has even numbers: {hasEvenNumbers}");
    }

}