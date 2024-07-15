using System;
using System.Collections.Generic;

public class Cook : Employee
{
    public Cook(string name, int salary, List<string> skills)
        : base(name, EmployeeType.Cook, salary, skills) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is cooking");
    }
}