public interface Idamagable
{
    void TakeDamage(int amount);
    int Health { get; }
    void Burn();
}