using System;
using System.Collections.Generic;

public class Loader : Employee
{
    public Loader(string name, int salary, List<string> skills)
        : base(name, EmployeeType.Loader, salary, skills) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is loading supplies");
    }
}