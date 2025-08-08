
public abstract class Circle
{
    double radius;

    public Circle(double r)
    {
        this.radius = r;
    }

    public abstract void Area();
    
}

public class Cylinder : Circle
{
    private double height;

    public Cylinder(double r, double h) : base(r)
    {
        this.height = h;
    }

    public override void Area()
    {
        Console.WriteLine("Calculating area of Cylinder");
    }

    
}

public class Cone : Circle
{
    public Cone(double r) : base(r)
    {

    }

    public override void Area()
    {
        Console.WriteLine("Calculating area of Cons");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Cylinder(5, 10);
        Circle cone = new Cone(5);
        circle.Area();
        cone.Area();
        PrintArea(5);
        PrintArea(5.0, 10.0);
    }

    static void PrintArea(int a)
    {
        Console.WriteLine("Area of Circle with radius: " + a);
    }

    static void PrintArea(double a, double b)
    {
        Console.WriteLine("Area of Circle with radius: " + a + " and height: " + b);
    }
}