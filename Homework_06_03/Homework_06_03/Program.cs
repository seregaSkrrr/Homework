using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        List<IMovable> movables = new List<IMovable>
        {
            new Airplane(12, 800, 20),
            new Car(4, 120, 4),
            new Bird(2, 50, 2),
            new Cat(4, 20, 10),
            new Tumbleweed(5, 10)
        };

        foreach (IMovable movable in movables)
        {
            Console.WriteLine($"Type: {movable.GetType().Name}");
            Console.WriteLine($"Unique properties:");

            if (movable is Vehicle vehicle)
            {
                Console.WriteLine($"Wheels: {vehicle.Wheels}");
                if (movable is Airplane airplane)
                    Console.WriteLine($"Wingspan: {airplane.Wingspan}");
                else if (movable is Car car)
                    Console.WriteLine($"Doors: {car.Doors}");
            }

            else if (movable is Animal animal)
            {
                Console.WriteLine($"Legs: {animal.Legs}");
                if (movable is Bird bird)
                    Console.WriteLine($"Wings: {bird.Wings}");
                else if (movable is Cat cat)
                    Console.WriteLine($"Whiskers: {cat.Whiskers}");
            }

            else if (movable is Tumbleweed tumbleweed)
                Console.WriteLine($"Size: {tumbleweed.Size}");

            movable.Move();
            Console.WriteLine();
        }
    }
}