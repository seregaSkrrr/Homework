using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Animal : IMovable
{
    public int Legs { get; set; }
    public int Speed { get; set; }

    public Animal(int legs, int speed)
    {
        Legs = legs;
        Speed = speed;
    }

    public abstract void Move();
}