// Combate automático entre dos ejércitos, un turno a la vez.
public class Battle
{
    private List<BattleEvent> log = new List<BattleEvent>();
    // Índice de la última unidad que actuó en el bando del jugador. -1: todavía no actúa nadie.
    private int playerCursor = -1;
    
    
    // Índice de la última unidad que actuó en el bando enemigo.
    private int enemyCursor = -1;
    // Indica quién tiene el turno. true = jugador.
    private bool isPlayerTurn = true; 
    
    
    public Army PlayerArmy { get; }
    public Army EnemyArmy { get; }
 
    public int TurnCount => log.Count;
    
    public bool IsOver => PlayerArmy.IsDefeated || EnemyArmy.IsDefeated;

    public bool PlayerWon => EnemyArmy.IsDefeated && !PlayerArmy.IsDefeated;

    public int SurvivorCount => EnemyArmy.GetAliveUnits().Count ;
 
    public Battle(Army playerArmy, Army enemyArmy)
    {
        PlayerArmy = playerArmy;
        EnemyArmy = enemyArmy;
    }
 
    // Resuelve un turno del bando del jugador.
    public BattleEvent NextTurn()
    {
        Army attackers;
        Army defenders;
        int cursor;

        if (isPlayerTurn)
        {
            attackers = PlayerArmy;
            defenders = EnemyArmy;
            cursor = playerCursor;
        }
        else
        {
            attackers = EnemyArmy;
            defenders = PlayerArmy;
            cursor = enemyCursor;
        }

        // El proceso es igual para los dos bandos.
        cursor = FindNextAlive(attackers, cursor);

        Unit attacker = attackers.GetUnit(cursor);
        List<Unit> targets = attacker.Attack(defenders);

        BattleEvent battleEvent = new BattleEvent(attacker, targets, attacker.Damage);

        // Se guarda el cursor del bando que actuó.
        if (isPlayerTurn)
        {
            playerCursor = cursor;
        }
        else
        {
            enemyCursor = cursor;
        }

        // Se agrega el evento al registro.
        log.Add(battleEvent);

        // Se cambia el turno al otro bando.
        isPlayerTurn = !isPlayerTurn;
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