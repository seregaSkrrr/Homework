using System;
using System.Collections.Generic;

public class Manager : Employee
{
    public Manager(string name, int salary, List<string> skills)
        : base(name, EmployeeType.Manager, salary, skills) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is managing the staff");
    }
}