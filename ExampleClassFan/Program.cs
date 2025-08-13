public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;
    private int speed = SLOW;
    private bool on = false;
    private double radius = 5;
    private string color = "blue";

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public bool IsOn
    {
        get { return on; }
        set { on = value; }
    }
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

    public Fan()
    {
       
    }

    public void ToString()
    {
        if (IsOn)
        {
            Console.WriteLine($"Fan is on: Speed={Speed}, Color={Color}, Radius={Radius}");
        }
        else
        {
            Console.WriteLine($"Fan is off: Color={Color}, Radius={Radius}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Fan fan1 = new Fan();
        fan1.Speed = Fan.FAST;
        fan1.IsOn = true;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        fan1.ToString();

        Fan fan2 = new Fan();
        fan2.Speed = Fan.MEDIUM;
        fan2.IsOn = false;
        fan2.Radius = 5;
        fan2.Color = "blue";
        fan2.ToString();
    }
}