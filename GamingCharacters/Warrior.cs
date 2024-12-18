namespace GamingCharacters;

internal class Warrior : Character
{
    public Warrior(string? name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }

    public void Charge(Character target)
    {
        int damage = AttackPower * 2 - target.DefensePower;

        if (damage > 0)
        {
            target.Health -= damage;
            Console.WriteLine($"{Name} charges {target.Name} for {damage} damage!");
        }

        else
        {
            Console.WriteLine($"{Name}'s charge has no effect on {target.Name}.");
        }
    }

    public override void Defend()
    {
        DefensePower += 5;
        Console.WriteLine($"{Name} defends and gains 5 defense.");
    }
}
