// Vista de consola: muestra el estado del juego y pide acciones.
// Es la única clase del juego que usa Console (además de ConsoleKit).
// Vista de consola: muestra el estado del juego y pide acciones.
// Es la única clase del juego que usa Console (además de ConsoleKit).
public class ConsoleView
{
    public ConsoleView()
    {
        // El primer uso de ConsoleKit configura la consola en UTF-8 (acentos, ★ y →).
        ConsoleKit.Clear();
    }
 
    // Bitácora de nivel 1: una línea por turno, impresa de corrido.
    public void ShowTurn(Battle battle, BattleEvent battleEvent)
    {
        Console.WriteLine($" {DescribeTurn(battle, battleEvent)}");
    }
 
    public void ShowMessage(string text)
    {
        Console.WriteLine($" {text}");
    }
 
    private string DescribeTurn(Battle battle, BattleEvent battleEvent)
    {
        string text = $"Turno {battle.TurnCount} | {Label(battle, battleEvent.Attacker)} ataca a ";
        for (int i = 0; i < battleEvent.Targets.Count; i++)
        {
            Unit target = battleEvent.Targets[i];
            if (i > 0)
            {
                text += " y a ";
            }
            text += $"{Label(battle, target)}: -{battleEvent.Damage} → {target.Health}/{target.MaxHealth}";
        }
        return text;
    }
 
    // Etiqueta de bitácora: J = jugador, E = enemigo, seguido del lugar en la fila (desde 1).
    private string Label(Battle battle, Unit unit)
    {
        int position = battle.PlayerArmy.GetPosition(unit);
        if (position >= 0)
        {
            return $"{unit.Name} (J{position + 1})";
        }
        return $"{unit.Name} (E{battle.EnemyArmy.GetPosition(unit) + 1})";
    }
}