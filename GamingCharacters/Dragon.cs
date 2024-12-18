namespace GamingCharacters;

internal class Dragon : Character
{
    public Dragon(string? name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }

    public void BreatheFire(Character target)
    {
        int damage = AttackPower * 4 - target.DefensePower;
        if (damage > 0)
        {
            target.Health -= damage;
            Console.WriteLine($"{Name} breathes fire on {target.Name} for {damage} damage!");
        }

        else
        {
            Console.WriteLine($"{Name}'s fire has no effect on {target.Name}.");
        }
    }

    public override void Attack(Character target)
    {
        int damage = AttackPower * 2 - target.DefensePower;
        if (damage > 0) 
        {
            target.Health -= damage;
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        }

        else
        {
            Console.WriteLine($"{Name}'s attack has no effect on {target.Name}.");
        }
    }

    public override void Defend()
    {
        DefensePower += 10;
        Console.WriteLine($"{Name} defends and gains 10 defense.");
    }
}
