public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5.0, "Red");
        Console.WriteLine(circle.ToString());
        Console.WriteLine($"Circle Area: {Math.PI * Math.Pow(circle.Radius, 2)}");
        Cylinder cylinder = new Cylinder(5.0, "Blue", 10.0);
        Console.WriteLine(cylinder.ToString());
        Console.WriteLine($"Cylinder Volume: {cylinder.Volume()}");
    }    
}