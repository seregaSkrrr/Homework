using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicle
{
    public int Doors { get; set; }

    public Car(int wheels, int speed, int doors) : base(wheels, speed)
    {
        Doors = doors;
    }

    public override void Move()
    {
        Console.WriteLine($"Car is driving with speed {Speed} km/h");
    }
}