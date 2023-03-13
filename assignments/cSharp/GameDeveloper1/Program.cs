// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Enemy Dementor = new Enemy("Dementor");

Attack Fireball = new Attack("Fireball", 20);
Attack Lightning = new Attack("Lightning", 25);
Attack Push = new Attack("Push", 10);

List<string> AllAttacks = new List<string>();

Dementor.AllAttacks.Add(Fireball);
Dementor.AllAttacks.Add(Lightning);
Dementor.AllAttacks.Add(Push);

Dementor.RandomAttack();