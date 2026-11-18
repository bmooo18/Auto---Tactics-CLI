public class Unit
{
    // Se asignan una sola vez, en el constructor.
    public string Name { get; }
    public int MaxHealth { get; }
    public int Damage { get; }
    
    public int Stars { get; }

    // Cualquiera puede leer la vida, pero solo la clase puede cambiarla.
    public int Health { get; private set; }

    // Propiedad calculada: se evalúa cada vez que se consulta.
    public bool IsAlive => Health > 0;

    public Unit(string name, int baseHealth, int baseDamage, int stars)
    {
        Name = name;
        Stars = stars;
        // Las estrellas escalan la vida y el daño una sola vez, al crear la unidad.
        MaxHealth = ApplyStars(baseHealth);
        Damage = ApplyStars(baseDamage);
        Health = MaxHealth;
    }

    public void TakeDamage(int amount)
    {
        // La vida nunca baja de 0.
        Health = Math.Max(Health - amount, 0);
    }
    
    public List<Unit> Attack(Army enemies)
    {
        // Toda unidad golpea al enemigo vivo más cercano (el que está al frente).
        List<Unit> targets = new List<Unit>();
        List<Unit> aliveEnemies = enemies.GetAliveUnits();
        if (aliveEnemies.Count > 0)
        {
            targets.Add(aliveEnemies[0]);
        }
 
        foreach (Unit target in targets)
        {
            target.TakeDamage(Damage);
        }
        return targets;
    }
 
    private int ApplyStars(int baseValue)
    {
        // Una unidad de 2★ tiene ×1.5 de vida y daño, truncado a entero.
        if (Stars == 2)
        {
            return (int)(baseValue * 1.5);
        }
        return baseValue;
    }
}