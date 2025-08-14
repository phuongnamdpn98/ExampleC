public class Chicken : Animal, IEdible
{
    public string HowToEat()
    {
        return "could be fried";
    }

    public override string MakeSound()
    {
        return "Chicken: cluck-cluck!";
    }
}