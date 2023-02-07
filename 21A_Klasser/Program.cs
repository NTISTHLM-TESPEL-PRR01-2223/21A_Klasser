
Enemy e = new Enemy() {name = "Goomba"};
Enemy e2 = new Enemy() {name = "Fireplant"};

List<Enemy> enemies = new();

enemies.Add(new Enemy() {name = "Dr Robotnik"});
enemies.Add(new Enemy() {name = "Koopa"});
enemies.Add(new Enemy() {name = "Dr Wily"});
enemies.Add(new Enemy() {name = "Sephiroth"});

foreach (Enemy en in enemies)
{
  Console.WriteLine(en.name);
  en.hp -= 25;
}



// Console.WriteLine(enemies[1].name);
// Hero h = new();

// h.hp -= enemies[1].Attack();

// e.name = "Goomba";
// e2.name = "Fireplant";

// e.hp -= 10;

// Hero h = new Hero();

// h.hp -= e.Attack();

// Console.WriteLine(h.hp);

Console.ReadLine();
