// Vista de consola: muestra el estado del juego y pide acciones.
// Es la única clase del juego que usa Console (además de ConsoleKit).
public class ConsoleView
{
    public ConsoleView()
    {
        // El primer uso de ConsoleKit configura la consola en UTF-8.
        ConsoleKit.Clear();
    }

    public void ShowArmy(string title, Army army)
    {
        Console.WriteLine($" {title} ({army.Count}/{army.Capacity})");
        for (int i = 0; i < army.Count; i++)
        {
            Unit unit = army.GetUnit(i);
            // La interfaz numera desde 1; el código, desde 0.
            Console.WriteLine($"  {i + 1}    {ConsoleKit.PadRight(unit.Name, 13)}{unit.Health}/{unit.MaxHealth}");
        }
    }

    public void ShowMessage(string text)
    {
        Console.WriteLine($" {text}");
    }
}