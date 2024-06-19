using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Teacher : Employee
{
    private List<Group> _groups;

    public Teacher(string fullName, Gender gender, DateTime birthDate, string phone, string email, float salary, DateTime employmentDate) : base(fullName, gender, birthDate, phone, email, salary, employmentDate)
    {
        _groups = new List<Group>();
    }

    public void AddGroup(Group group)
    {
        _groups.Add(group);
    }

    public void RemoveGroup(Group group)
    {
        _groups.Remove(group);
    }

    public void PrintGroups()
    {
        Console.WriteLine("Groups:");
        foreach (var group in _groups)
        {
            Console.WriteLine(group.ToString());
        }
    }

    public override void Create()
    {
        Console.WriteLine($"Teacher '{FullName}' created");
    }

    public override void Remove()
    {
        Console.WriteLine($"Teacher '{FullName}' removed");
    }
    public override string ToString()
    {
        return $"Teacher {base.ToString()}";
    }
}