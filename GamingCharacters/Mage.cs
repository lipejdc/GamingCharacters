namespace GamingCharacters;

internal class Mage : Character
{
    public Mage(string? name, int health, int attack, int defense) : base(name, health, attack, defense)
    {

    }

    public void CastSpell(Character target)
    {
        int damage = AttackPower * 3 - target.DefensePower;
        if (damage > 0)
        {
            target.Health -= damage;
            Console.WriteLine($"{Name} casts a spell on {target.Name} for {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{Name}'s spell has no effect on {target.Name}.");
        }
    }

    public sealed override void Defend()
    {
        Console.WriteLine($"{Name} cannot defend!");
    }
}
