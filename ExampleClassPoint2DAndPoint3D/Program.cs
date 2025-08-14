public class Program
{
    public static void Main(string[] args)
    {
        Point2D point2D = new Point2D(3.0f, 4.0f);
        Console.WriteLine(point2D.ToString());
        point2D.SetXY(5.0f, 6.0f);
        Console.WriteLine(point2D.ToString());
        float[] coords2D = point2D.GetXY();
        Console.WriteLine($"Coordinates: {coords2D[0]}, {coords2D[1]}");
        Console.WriteLine();
        Point3D point3D = new Point3D(1.0f, 2.0f, 3.0f);
        Console.WriteLine(point3D.ToString());
        point3D.SetXYZ(7.0f, 8.0f, 9.0f);
        Console.WriteLine(point3D.ToString());
        float[] coords3D = point3D.GetXYZ();
        Console.WriteLine($"Coordinates: {coords3D[0]}, {coords3D[1]}, {coords3D[2]}");
    }    
}