using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Spell
{
    public string Name { get; set; }
    public int Power { get; set; }

    public Spell(string name, int power)
    {
        Name = name;
        Power = power;
    }

    public abstract void Cast();
}