using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Airplane : Vehicle
{
    public int Wingspan { get; set; }

    public Airplane(int wheels, int speed, int wingspan) : base(wheels, speed)
    {
        Wingspan = wingspan;
    }

    public override void Move()
    {
        Console.WriteLine($"Airplane is flying with speed {Speed} km/h");
    }
}