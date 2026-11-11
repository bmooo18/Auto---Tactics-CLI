public class Player
{
    public int Gold { get; private set; }

    public bool TrySpend(int amount)
    {
        if (Gold < amount)
        {
            return false;
        }

        Gold = Gold - amount;
        return true;
    }
    
    public void Earn(int amount)
    {
        
        Gold += amount;
    }
    
}
