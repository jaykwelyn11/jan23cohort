class RangedFighter : Enemy
{
    public int Distance;
    public RangedFighter(string theName) : base(theName)
    {
        Distance = 5;
        AllAttacks = new List<Attack>() {
            new Attack("Arrow", 20),
            new Attack("Knife", 15)
        };
    }

    public override void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if (Distance < 10)
        {
            Console.WriteLine($"{Name} is too close to attack");
        }
        else
        {
            base.PerformAttack(target, chosenAttack);
        }
    }

    public int Dash()
    {
        Distance = 20;
        Console.WriteLine($"{Name} has moved to attack distance");
        return Distance;
    }

}