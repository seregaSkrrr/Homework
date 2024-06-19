using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DamageSpell : Spell
{
    public int DamageDealt { get; set; }

    public DamageSpell(string name, int power, int damageDealt) : base(name, power)
    {
        DamageDealt = damageDealt;
    }

    public override void Cast()
    {
        Console.WriteLine($"Casting {Name} for {Power} power, dealing {DamageDealt} damage");
    }
}
