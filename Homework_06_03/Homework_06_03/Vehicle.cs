using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicle : IMovable
{
    public int Wheels { get; set; }
    public int Speed { get; set; }

    public Vehicle(int wheels, int speed)
    {
        Wheels = wheels;
        Speed = speed;
    }

    public abstract void Move();
}