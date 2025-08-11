
public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle()
    {

    }
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int GetArea()
    {
        return Width * Height;
    }

    public int GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    public void Display()
    {
        Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}");
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the width of the rectangle:");
        int width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the height of the rectangle:");
        int height = Convert.ToInt32(Console.ReadLine());

        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine("Your Rectangle:");
        rectangle.Display();
        Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
        Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
    }
}