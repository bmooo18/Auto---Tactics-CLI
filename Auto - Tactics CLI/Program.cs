// Auto - Tactics

/* Primera parte
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
*/


//______________________________________________________

/* Segunda parte
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
*/


//______________________________________________________

ConsoleView view = new ConsoleView();
Player player = new Player();
 
player.Army.TryAdd(new Unit("Guerrero", 12, 4));
player.Army.TryAdd(new Unit("Arquero", 6, 2));
player.Army.TryAdd(new Unit("Mago", 4, 2));

// La fila ya tiene 3 unidades: la cuarta se rechaza.
if (!player.Army.TryAdd(new Unit("Guerrero", 12, 4)))
{
    view.ShowMessage("La fila está llena: el cuarto Guerrero no entra.");
}
view.ShowArmy("Fila inicial", player.Army);

//prueba swap,es irrelevante si es (2,0) o (0,2)
player.Army.Swap(0,2);
view.ShowArmy("\nFila despues del interacambio", player.Army);

//preuba de unidades si mueren
var mago = player.Army.GetUnit(0);
mago.TakeDamage(10);
view.ShowArmy("\nFila despues de recibir daño", player.Army);

var aliveUnits = player.Army.GetAliveUnits();
Console.WriteLine("\nUnidades vivas:");
foreach (var u in aliveUnits)
{
    Console.WriteLine(u.Name);
}