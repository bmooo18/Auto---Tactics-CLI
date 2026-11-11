public class Army
{
    private List<Unit> units = new List<Unit>();
 
    public int Capacity {get;}
    public int Count => units.Count;
    public bool IsFull => units.Count >= Capacity;
 
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
}