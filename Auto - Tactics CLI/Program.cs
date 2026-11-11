// Auto - Tactics


Unit archer = new Unit("Arquero", 6, 2);
Unit warrior = new Unit("Guerrero", 12, 4);// vida 6

archer.TakeDamage(4);
archer.TakeDamage(4);
Console.WriteLine(archer.Health);
Console.WriteLine(archer.IsAlive);

Player player = new Player();
Console.WriteLine(player.Gold);
player.Earn(100);
Console.WriteLine(player.Gold);

bool pudoGastar = player.TrySpend(180);
Console.WriteLine(pudoGastar);
Console.WriteLine(player.Gold);
