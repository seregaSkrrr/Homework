using System;
using System.Collections.Generic;

public class Director : Employee
{
    public Director(string name, int salary, List<string> skills)
        : base(name, EmployeeType.Director, salary, skills) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is managing the cafe");
    }
}