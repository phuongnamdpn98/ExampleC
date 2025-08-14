public class Program
{
    public static void Main(string[] args)
    {
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();
        animals[1] = new Chicken();

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.MakeSound());

            if (animal is Chicken)
            {
                IEdible edible = (Chicken)animal;
                Console.WriteLine(edible.HowToEat());
            }
        }

        Fruit[] fruits = new Fruit[2];
        fruits[0] = new Apple();
        fruits[1] = new Orange();

        foreach (Fruit fruit in fruits)
        {
            Console.WriteLine(fruit.HowToEat());
        }
    }    
}