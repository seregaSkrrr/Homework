using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public abstract class Employee
{
    private string _name;
    private int _salary;
    public string Name { get { return _name; } }
    public EmployeeType Type { get; set; }
    public int Salary { get { return _salary; } }
    public List<string> Skills { get; set; }

    public Employee(string name, EmployeeType type, int salary, List<string> skills)
    {
        _name = name;
        Type = type;
        _salary = salary;
        Skills = skills;
    }

    public abstract void Work();

    public void Info()
    {
        Console.Write($"Hi, I'm {Name}, I got salary = {Salary}, I'm good at ");
        foreach (string skill in Skills)
            Console.Write($"{skill}; ");
        Console.WriteLine();
    }
}