
public class Vehicele
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Vehicele(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Name: {Name}, Speed: {Speed} km/h");
    }

    public virtual void StartEngine()
    {
        Console.WriteLine($"{Name} engine started.");
    }
}

public class Car : Vehicele
{
    public int NumberOfDoors { get; set; }

    public Car(string name, int speed, int numberOfDoors) : base(name, speed)
    {
        NumberOfDoors = numberOfDoors;
    }

    public void DisplayCarInfo()
    {
        DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }
    public override void StartEngine()
    {
        Console.WriteLine($"{Name} car engine started with a roar!");
    }
}

public class CarRed : Car
{
    public string Color { get; set; }
    public CarRed(string name, int speed, int numberOfDoors, string color) : base(name, speed, numberOfDoors)
    {
        Color = color;
    }

    public void DisplayCarRedInfo()
    {
        DisplayCarInfo();
        Console.WriteLine($"Color: {Color}");
    }

    public override void StartEngine()
    {
        Console.WriteLine($"{Name} red car engine started with a loud roar!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Vehicele myVehicle = new Vehicele("Generic Vehicle", 80);
        myVehicle.DisplayInfo();
        myVehicle.StartEngine();

        Console.WriteLine();
        Car myCar = new Car("Sports Car", 150, 2);
        myCar.DisplayCarInfo();
        myCar.StartEngine();
        Console.WriteLine();
        CarRed myCarRed = new CarRed("Ferrari", 200, 2, "Red");
        myCarRed.DisplayCarRedInfo();
        myCarRed.StartEngine();
        Console.WriteLine();

    }

}