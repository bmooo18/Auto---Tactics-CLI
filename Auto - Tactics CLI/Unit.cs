public class Unit
{
    public string Name;
    public int Health;
    public int Damage;
    
    // El constructor recibe los valores iniciales y los guarda en los campos.
    // El orden no importa, pero por convencion
    public Unit(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
    
    // La unidad pierde tanta vida como el daño recibido.
    public void TakeDamage(int amount)
    {
        Health -= amount; // Health = Health - amount
    }
}