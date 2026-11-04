// Auto - Tactics

Unit warrior = new Unit("Guerrero", 12, 4);
Unit archer = new Unit("Arquero", 6, 2);
 
archer.TakeDamage(warrior.Damage);
 
Console.WriteLine(warrior.Health);
Console.WriteLine(archer.Health);
    

