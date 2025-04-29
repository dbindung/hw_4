using System;

class Task1
{
    public static void Run()
    {
        MeleeHero axe = new MeleeHero("Axe", 500, 100);
        RangedHero drow = new RangedHero("Drow Ranger", 400, 100);

        axe.Attack(drow);
        Console.WriteLine($"{drow.Name} здоровье: {drow.Health}");
        Console.WriteLine();

        drow.Attack(axe);
        Console.WriteLine($"{axe.Name} здоровье: {axe.Health}");
    }
}

class Hero
{
    public string Name;
    public int Health;
    public int Damage;

    public Hero(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public virtual void Attack(Hero target)
    {
        Console.WriteLine($"{Name} атакует {target.Name}, нанося {Damage} урона");
        target.TakeDamage(Damage);
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} получает {damage} урона");
    }
}

class MeleeHero : Hero
{
    public MeleeHero(string name, int health, int damage)
        : base(name, health, damage) { }

    public override void Attack(Hero target)
    {
        int boostedDamage = (int)(Damage * 1.2);
        Console.WriteLine($"{Name} атакует {target.Name}, нанося {boostedDamage} урона");
        target.TakeDamage(boostedDamage);
    }
}

class RangedHero : Hero
{
    public RangedHero(string name, int health, int damage)
        : base(name, health, damage) { }

    public override void TakeDamage(int damage)
    {
        int reducedDamage = (int)(damage * 0.7);
        Health -= reducedDamage;
        Console.WriteLine($"{Name} получает {reducedDamage} урона");
    }
}
