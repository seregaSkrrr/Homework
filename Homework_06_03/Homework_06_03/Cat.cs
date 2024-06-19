using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cat : Animal
{
    public int Whiskers { get; set; }

    public Cat(int legs, int speed, int whiskers) : base(legs, speed)
    {
        Whiskers = whiskers;
    }

    public override void Move()
    {
        Console.WriteLine($"Cat is running wtih speed {Speed} km/h");
    }
}