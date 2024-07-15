using System;
using System.Collections.Generic;

public class Accountant : Employee
{
    public Accountant(string name, int salary, List<string> skills)
        : base(name, EmployeeType.Accountant, salary, skills) { }

    public override void Work()
    {
        Console.WriteLine($"{Name} is accounting");
    }
}