using System;
using System.Collections.Generic;

public class Waiter : Employee
{
    public Waiter(string name, int salary, List<string> skills)
        : base(name, EmployeeType.Waiter, salary, skills) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is serving customers");
    }
}