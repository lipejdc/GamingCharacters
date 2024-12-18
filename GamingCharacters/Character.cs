namespace GamingCharacters;

internal class Character
{
    public string? Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }
    public int DefensePower { get; set; }


    public Character(string? name, int health, int attack, int defense)
    {
        Name = name;
        Health = health;
        AttackPower = attack;
        DefensePower = defense;
    }

    public virtual void Attack(Character target) 
    {
        int damage = AttackPower - target.DefensePower;
        if (damage > 0) 
        {
            target.Health -= damage;
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        }

        else
        {
            Console.WriteLine($"{Name}'s attack has no effect on {target.Name}");
        }

    }

    public virtual void Defend()
    {
        Console.WriteLine($"{Name} defends.");
    }

}
