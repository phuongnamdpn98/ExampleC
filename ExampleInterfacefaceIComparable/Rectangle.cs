public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle()
    {

    }

    public Rectangle(double height, double width)
    {
        this.height = height;
        this.width = width;
    }

    public Rectangle(double height, double width, string color, bool filled) : base(color, filled)
    {
        this.height = height;
        this.width = width;
    }

    public double GetHeight()
    {
        return height;
    }

    public virtual void SetHeight(double height)
    {
        this.height = height;
    }

    public double GetWidth()
    {
        return width;
    }

    public virtual void SetWidth(double width)
    {
        this.width = width;
    }

    public double GetArea()
    {
        return height * width;
    }

    public double GetPerimeter()
    {
        return 2 * (height + width);
    }

    
}