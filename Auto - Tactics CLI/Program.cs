// Auto - Tactics

Unit warrior = new Unit("Guerrero", 12, 4);
Unit archer = new Unit("Arquero", 6, 2);
Unit mago = new Unit("Mago", 5, 6);
 
Console.WriteLine($"{warrior.Name}: {warrior.Health} de vida");
Console.WriteLine($"{archer.Name}: {archer.Health} de vida");
Console.WriteLine($"{mago.Name}: {mago.Health} de vida");
Console.WriteLine("\n");

archer.TakeDamage(warrior.Damage);
archer.TakeDamage(warrior.Damage);
warrior.TakeDamage(mago.Damage);
 
Console.WriteLine($"{warrior.Name}: {warrior.Health} de vida");
Console.WriteLine($"{archer.Name}: {archer.Health} de vida");
Console.WriteLine($"{mago.Name}: {mago.Health} de vida");
    

