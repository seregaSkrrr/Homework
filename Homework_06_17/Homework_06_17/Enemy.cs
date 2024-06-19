using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }

    public Enemy(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void GetDamage(int damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} was killed!");
        }
        else
        {
            Console.WriteLine($"{Name} took {damage} damage. Remaining health: {Health}");
        }
    }
}