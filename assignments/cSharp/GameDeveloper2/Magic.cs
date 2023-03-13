class MagicCaster : Enemy
{
    public MagicCaster(string theName) : base(theName)
    {
        Health = 80;
        AllAttacks = new List<Attack>() {
            new Attack("Fireball", 25),
            new Attack("Lightning", 20),
            new Attack("Staff Strike", 10)
        };
    }

    public void Heal(Enemy helpHeal)
    {
        Health += 40;
        Console.WriteLine($"{Name} has healed {helpHeal.Name} 40 health");
    }


}