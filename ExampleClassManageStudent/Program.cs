public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Alice", 20, "A");
        student1.DisplayInfo();
        Student student2 = new Student("Bob", 22, "B");
        student2.DisplayInfo();
    }    
}