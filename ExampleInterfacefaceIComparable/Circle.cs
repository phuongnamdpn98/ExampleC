public class Circle : Shape
{
    private double radius;

    public Circle()
    {

    }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle(double radius, string color, bool filled) : base(color, filled)
    {
        this.radius = radius;
    }

    public double GetRadius()
    {
        return radius;
    }

    public void SetRadius(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

}