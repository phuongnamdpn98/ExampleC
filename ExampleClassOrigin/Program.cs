public class Shap
{
    public string Name { get; set; }
    public double Area { get; set; }

    public Shap(string Name, double Area)
    {
        this.Name = Name;
        this.Area = Area;
    }


}

public class Circle : Shap
{
    public Circle(double Area) : base("Circle", Area) { }
}

public class Square : Shap
{
    public Square(double Area) : base("Square", Area) { }
}


public class Program
{
    public static void Main(string[] args)
    {
        Shap shap1 = new Shap("Circle", 78.54);
        Shap shap2 = new Shap("Square", 100.0);
        Shap triangle = new Shap("Triangle", 43.3);

        Console.WriteLine($"Shape: {shap1.Name}, Area: {shap1.Area}");
        Console.WriteLine($"Shape: {shap2.Name}, Area: {shap2.Area}");
        Console.WriteLine($"Shape: {triangle.Name}, Area: {triangle.Area}");

        Circle circle = new Circle(88.0);
        Console.WriteLine($"Shape: {circle.Name}, Area: {circle.Area}");
        Shap shap3 = new Circle(64.0);
        Console.WriteLine($"Shape: {shap3.Name}, Area: {shap3.Area}");
    }

}