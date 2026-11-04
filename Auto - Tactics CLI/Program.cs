// Auto - Tactics

Unit warrior = new Unit("Guerrero", 12, 4);
Unit archer = new Unit("Arquero", 6, 2);
 
archer.TakeDamage(warrior.Damage);
archer.TakeDamage(warrior.Damage);
 
Console.WriteLine($"{warrior.Name}: {warrior.Health} de vida");
Console.WriteLine($"{archer.Name}: {archer.Health} de vida");
    

