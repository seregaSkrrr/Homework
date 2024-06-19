using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HealSpell : Spell
{
    public int HealthRestored { get; set; }

    public HealSpell(string name, int power, int healthRestored) : base(name, power)
    {
        HealthRestored = healthRestored;
    }

    public override void Cast()
    {
        Console.WriteLine($"Casting {Name} for {Power} power, restoring {HealthRestored} health");
    }
}