// Traduce a objetos las oleadas que el diseñador entregó en el Excel.
// Filas = oleadas; columnas = posiciones (P1 = frente).
public class WaveData
{
    private const int WaveCapacity = 4;
 
    public List<Army> CreateWaves()
    {
        List<Army> waves = new List<Army>();
 
        // Oleada 1: A1 | A1
        Army wave1 = new Army(WaveCapacity);
        wave1.TryAdd(new Unit("Arquero", 6, 2, 1));
        wave1.TryAdd(new Unit("Arquero", 6, 2, 1));
        waves.Add(wave1);
 
        return waves;
    }
}