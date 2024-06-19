using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        ExplosiveItem grenade = new ExplosiveItem("Grenade", 26);
        ExplosiveItem C4 = new ExplosiveItem("C4", 52);

        List<Enemy> enemies = new List<Enemy>();

        for (int i = 0; i < random.Next(5,7); i++)
        {
            enemies.Add(new Enemy($"Enemy{i + 1}", random.Next(50, 201)));
            Console.WriteLine($"{enemies[i].Name} health = {enemies[i].Health}");
        }

        foreach(Enemy enemy in enemies)
        {
            grenade.OnExplosion += enemy.GetDamage;
            C4.OnExplosion += enemy.GetDamage;
        }

        Console.WriteLine("====================================");
        grenade.Explode();

        Console.WriteLine("====================================");
        C4.Explode();

        Console.WriteLine("====================================");
        Console.WriteLine();

        Console.WriteLine("Remaining enemies:");
        foreach (Enemy enemy in enemies)
        {
            if (enemy.Health > 0)
                Console.WriteLine($"{enemy.Name} : {enemy.Health} HP");
        }
    }
}