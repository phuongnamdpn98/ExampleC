public class Wall : Decoder
{
    public string color;
    public double height;
    public double width;
    public Wall(string input, string color, double height, double width) : base(input)
    {
        this.Input = input;
        this.color = color;
        this.height = height;
        this.width = width;
    }
    public override void DisplayDecodedInfo()
    {
        base.DisplayDecodedInfo();
        Console.WriteLine($"Wall Color: {color}, Height: {height}m, Width: {width}m");
    }
    public void DisplayWallInfo()
    {
        Console.WriteLine($"Wall Info - Color: {color}, Height: {height}m, Width: {width}m");
    }

    public override string Decode()
    {
        return $"Decoded Wall: {Input}, Color: {color}, Height: {height}m, Width: {width}m";
    }
}