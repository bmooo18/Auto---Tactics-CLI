public class Player
{
    private const int ArmyCapacity = 3;
    public int Gold { get; private set; }

    public Army Army { get; }
 
    public Player()
    {
        Gold = 0;
        Army = new Army(ArmyCapacity);
    }
    
    public bool TrySpend(int amount)
    {
        if (Gold < amount)
        {
            return false;
        }

        Gold -= amount;
        return true;
    }
    
    public void Earn(int amount)
    {
        
        Gold += amount;
    }
    
}
