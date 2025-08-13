public class Player : Idamagable, IDestroy
{
    private int health;

    public Player(int initialHealth)
    {
        health = initialHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0) health = 0;
    }

    public void Dead()
    {
        if(health <= 0)
        {
            Console.WriteLine("Player is dead.");
        }
    }

    public void Destroy()
    {
        Console.WriteLine("Player destroyed.");
        health = 0; 
        
    }

    public void Burn()
    {
        throw new NotImplementedException();
    }

    public int Health => health;
}

public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player(100);
        player.TakeDamage(10);
        Console.WriteLine($"Player Health: {player.Health}");
        
        player.TakeDamage(20);
        Console.WriteLine($"Player Health after damage: {player.Health}");
        player.Dead();
        
        player.Destroy();
        Console.WriteLine($"Player Health after destroy: {player.Health}");
    }
}