public class Army
{
    private List<Unit> units = new List<Unit>();
 
    public int Capacity {get;}
    public int Count => units.Count;
    public bool IsFull => units.Count >= Capacity;
    public bool IsDefeated => GetAliveUnits().Count == 0;
 
    public Army(int capacity)
    {
        Capacity = capacity;
    }
    
    public bool TryAdd(Unit unit)
    {
        if (IsFull) return false;
        
        units.Add(unit);
        return true;
    }
    
    public Unit GetUnit(int position)
    {
        return units[position];
    }
    
    // Lugar de la unidad en la fila, contando también a las derrotadas. -1 si no pertenece.
    public int GetPosition(Unit unit)
    {
        return units.IndexOf(unit);
    }

    public void Swap(int first, int second)
    {
        Unit tmp = units[first];
        units[first] = units[second];
        units[second] = tmp;
    }
    
    public List<Unit> GetAliveUnits()
    {
        List<Unit> aliveUnits = new List<Unit>();

        foreach (Unit u in units)
        {
            if (u.IsAlive)
            {
                aliveUnits.Add(u);
            }
        }
        
        return aliveUnits;
    }
}