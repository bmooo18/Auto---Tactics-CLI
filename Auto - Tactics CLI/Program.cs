// Auto - Tactics

/* Primera paarte
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
*/

//______________________________________________________
Console.WriteLine("\n\n");

Unit archer = new Unit("Arquero", 6, 2);
Unit warrior = new Unit("Guerrero", 12, 4);// vida 6

Unit attacker = warrior;
Unit defender = archer;

int turn = 1;

while (attacker.IsAlive && defender.IsAlive)
{
    defender.TakeDamage(attacker.Damage);
    
    Console.WriteLine(
        "Turno " + turn + " | " +
        attacker.Name + " ataca a " + defender.Name +
        ": -" + attacker.Damage +
        ", queda en " + defender.Health + "/" + defender.MaxHealth
    );
    turn++;

    Unit tmp = attacker;
    attacker = defender;
    defender = tmp;
}

if (attacker.IsAlive == true)
{
    Console.WriteLine("Gana " + attacker.Name);
}
else
{
    Console.WriteLine("Gana " + defender.Name);
}

Console.Write("\n");


Player player = new Player();
Console.Write("Oro: ");
player.Earn(3);

Console.WriteLine(player.Gold);

bool pudoGastar = player.TrySpend(2);
Console.Write("Gastar 2: " + pudoGastar);
Console.WriteLine(",oro restante " + player.Gold);

bool pudoGastar2 = player.TrySpend(2);
Console.Write("Gastar 2: " + pudoGastar2);
Console.WriteLine(", oro restante " + player.Gold);