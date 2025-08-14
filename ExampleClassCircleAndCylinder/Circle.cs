public class Circle
{
    private double radius;
    private string color;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }
    public string Color
    {
        get { return color; }
        set { color = value; }
    }

    public Circle()
    {

    }

    public Circle(double radius, string color)
    {
        this.radius = radius;
        this.color = color;
    }
    
    public override string ToString()
    {
        return $"Circle: Radius = {radius}, Color = {color}";
    }
}