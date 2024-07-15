using System;
using System.Collections.Generic;

public class Cleaner : Employee
{
    public Cleaner(string name, int salary, List<string> skills)
        : base(name, EmployeeType.Janitor, salary, skills) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is cleaning");
    }
}