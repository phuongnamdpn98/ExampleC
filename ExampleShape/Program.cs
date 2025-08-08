
public abstract class Shape
{
    string name;
    int id;

    public Shape(string name)
    {
        this.name = name;
    }

    public Shape(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
}


public class Circle : Shape
{
    double radius;
    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    public Circle(string name, int id, double radius) : base(name, id)
    {
        this.radius = radius;
    }
}

public class Square : Shape
{
    double sideLength;
    public Square(string name, double sideLength) : base(name)
    {
        this.sideLength = sideLength;
    }

    public Square(string name, int id, double sideLength) : base(name, id)
    {
        this.sideLength = sideLength;
    }
}


public class Program
{
    public static void Main(string[] args)
    {

    }

}