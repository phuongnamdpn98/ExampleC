public class Cylinder : Circle
{
    public double Height { get; set; }

    public Cylinder() : base()
    {
        Height = 1.0; // Default height
    }

    public Cylinder(double radius, string color, double height) : base(radius, color)
    {
        Height = height;
    }

    public double Volume()
    {
        return Math.PI * Math.Pow(Radius, 2) * Height;
    }
    
    public override string ToString()
    {
        return $"Cylinder: Radius = {Radius}, Color = {Color}, Height = {Height}";
    }
}