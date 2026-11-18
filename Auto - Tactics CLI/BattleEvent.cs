// Registro de un turno de combate. Solo guarda datos; no imprime nada.
public class BattleEvent
{
    public Unit Attacker { get; }
    public List<Unit> Targets { get; }
    public int Damage { get; }
 
    public BattleEvent(Unit attacker, List<Unit> targets, int damage)
    {
        Attacker = attacker;
        Targets = targets;
        Damage = damage;
    }
}