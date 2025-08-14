public class Program
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(10);
        circle.Resize(20);

        Rectangle rectangle = new Rectangle(4, 6);
        rectangle.Resize(50);

        Square square = new Square(5);
        square.Resize(60);
    }    
}