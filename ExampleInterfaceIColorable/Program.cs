public class Program
{
    public static void Main(string[] args)
    {
        object[] shapes =
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Square(7)
        };

        foreach (var shape in shapes)
        {
            if (shape is IColorable colorable)
            {
                colorable.HowToColor();
            }
        }
    }    
}