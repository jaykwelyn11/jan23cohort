// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Enemy Dementor = new Enemy("Dementor");

MagicCaster Gandalf = new MagicCaster("Gandalf");
MagicCaster HP = new MagicCaster("Harry Potter");

MeleeFighter Rock = new MeleeFighter("the Rock");
MeleeFighter Chan = new MeleeFighter("Jackie Chan");

RangedFighter Legolas = new RangedFighter("Legolas");
RangedFighter Hawkeye = new RangedFighter("Hawkeye");


Rock.PerformAttack(Hawkeye, Rock.AllAttacks[1]);
Chan.PerformAttack(HP, Chan.Rage());

Legolas.PerformAttack(Rock, Legolas.AllAttacks[0]);

Legolas.Dash();

Legolas.PerformAttack(Rock, Legolas.AllAttacks[0]);

Gandalf.PerformAttack(Chan, Gandalf.AllAttacks[0]);

Gandalf.Heal(Hawkeye);
HP.Heal(HP);

Chan.RandomAttack();