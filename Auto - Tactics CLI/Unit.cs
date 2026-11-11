public class Unit
{
    // Se asignan una sola vez, en el constructor.
    public string Name { get; }
    public int MaxHealth { get; }
    public int Damage { get; }

    // Cualquiera puede leer la vida, pero solo la clase puede cambiarla.
    public int Health { get; private set; }

    // Propiedad calculada: se evalúa cada vez que se consulta.
    public bool IsAlive => Health > 0;

    public Unit(string name, int maxHealth, int damage)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Damage = damage;
    }

    public void TakeDamage(int amount)
    {
        // La vida nunca baja de 0.
        Health = Math.Max(Health - amount, 0);
    }
}