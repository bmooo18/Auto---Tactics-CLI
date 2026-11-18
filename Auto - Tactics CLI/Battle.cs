// Combate automático entre dos ejércitos, un turno a la vez.
public class Battle
{
    private List<BattleEvent> log = new List<BattleEvent>();
    // Índice de la última unidad que actuó en el bando del jugador. -1: todavía no actúa nadie.
    private int playerCursor = -1;
 
    public Army PlayerArmy { get; }
    public Army EnemyArmy { get; }
 
    public int TurnCount => log.Count;
 
    public Battle(Army playerArmy, Army enemyArmy)
    {
        PlayerArmy = playerArmy;
        EnemyArmy = enemyArmy;
    }
 
    // Resuelve un turno del bando del jugador.
    public BattleEvent NextTurn()
    {
        int cursor = FindNextAlive(PlayerArmy, playerCursor);
        Unit attacker = PlayerArmy.GetUnit(cursor);
        List<Unit> targets = attacker.Attack(EnemyArmy);
        BattleEvent battleEvent = new BattleEvent(attacker, targets, attacker.Damage);
 
        // Se guarda el cursor del bando que actuó.
        playerCursor = cursor;
        log.Add(battleEvent);
        return battleEvent;
    }
 
    // Siguiente unidad viva después de lastIndex. Al llegar al final de la fila, vuelve al inicio.
    private int FindNextAlive(Army army, int lastIndex)
    {
        int index = (lastIndex + 1) % army.Count;
        while (!army.GetUnit(index).IsAlive)
        {
            index = (index + 1) % army.Count;
        }
        return index;
    }
}