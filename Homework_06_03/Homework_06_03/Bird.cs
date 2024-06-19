using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bird : Animal
{
    public int Wings { get; set; }

    public Bird(int legs, int speed, int wings) : base(legs, speed)
    {
        Wings = wings;
    }

    public override void Move()
    {
        Console.WriteLine($"Bird is flying with speed {Speed} km/h");
    }
}