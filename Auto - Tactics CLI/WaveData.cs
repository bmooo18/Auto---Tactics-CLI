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
 
        // Oleada 2: G1 | A1 | M1
        Army wave2 = new Army(WaveCapacity);
        wave2.TryAdd(new Unit("Guerrero", 12, 4, 1));
        wave2.TryAdd(new Unit("Arquero", 6, 2, 1));
        wave2.TryAdd(new Unit("Mago", 4, 2, 1));
        waves.Add(wave2);

        // Oleada 3: G1 | A1 | A1 | A1
        Army wave3 = new Army(WaveCapacity);
        wave3.TryAdd(new Unit("Guerrero", 12, 4, 1));
        wave3.TryAdd(new Unit("Arquero", 6, 2, 1));
        wave3.TryAdd(new Unit("Arquero", 6, 2, 1));
        wave3.TryAdd(new Unit("Arquero", 6, 2, 1));
        waves.Add(wave3);

        // Oleada 4: G2 | A1 | M1
        Army wave4 = new Army(WaveCapacity);
        wave4.TryAdd(new Unit("Guerrero", 12, 4, 2));
        wave4.TryAdd(new Unit("Arquero", 6, 2, 1));
        wave4.TryAdd(new Unit("Mago", 4, 2, 1));
        waves.Add(wave4);

        // Oleada 5: G1 | M2 | A1 | M1
        Army wave5 = new Army(WaveCapacity);
        wave5.TryAdd(new Unit("Guerrero", 12, 4, 1));
        wave5.TryAdd(new Unit("Mago", 4, 2, 2));
        wave5.TryAdd(new Unit("Arquero", 6, 2, 1));
        wave5.TryAdd(new Unit("Mago", 4, 2, 1));
        waves.Add(wave5);

        return waves;
    }
}