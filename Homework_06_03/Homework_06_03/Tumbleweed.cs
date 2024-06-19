using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tumbleweed : IMovable
{
    public int Size { get; set; }
    public int Speed { get; set; }

    public Tumbleweed(int size, int speed)
    {
        Size = size;
        Speed = speed;
    }

    public void Move()
    {
        Console.WriteLine($"Tumbleweed is rolling with speed {Speed} km/h");
    }
}