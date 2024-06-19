using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Explosion(int damage);

public class ExplosiveItem
{
    private Explosion onExplosion;

    public string Name { get; set; }
    public int Damage { get; set; }
    public Explosion OnExplosion { get; set; }

    public ExplosiveItem(string name, int damage)
    {
        Name = name;
        Damage = damage;
    }

    public void Explode()
    {
        OnExplosion?.Invoke(Damage);
    }
}