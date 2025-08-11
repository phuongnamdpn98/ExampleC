
public abstract class Animal
{
    protected string Weight { get; set; }
    protected string Height { get; set; }

    public Animal(string weight, string height)
    {
        Weight = weight;
        Height = height;
    }

    public abstract void PrintInfo();
}

public class Cat : Animal
{
    private string Name { get; set; }
    public Cat(string weight, string height, string name) : base(weight, height)
    { 
        Name = name;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Cat - Weight: {Weight}, Height: {Height}, Name: {Name}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Cat cat = new Cat("20kg", "1.5", "kitty");
        cat.PrintInfo();
    }
}