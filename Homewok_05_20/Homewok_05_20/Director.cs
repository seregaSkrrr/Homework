using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Director : Employee
{
    private List<Teacher> _teachers;
    private List<Group> _groups;

    public Director(string fullName, Gender gender, DateTime birthDate, string phone, string email, float salary, DateTime employmentDate)
        : base(fullName, gender, birthDate, phone, email, salary, employmentDate)
    {
        _teachers = new List<Teacher>();
        _groups = new List<Group>();
    }

    public void AddTeacher(Teacher teacher)
    {
        _teachers.Add(teacher);
    }

    public void AddGroup(Group group)
    {
        _groups.Add(group);
    }

    public void RemoveTeacher(Teacher teacher)
    {
        _teachers.Remove(teacher);
    }

    public void RemoveGroup(Group group)
    {
        _groups.Remove(group);
    }

    public void PrintTeachers()
    {
        Console.WriteLine("Teachers:");
        foreach (var teacher in _teachers)
        {
            Console.WriteLine(teacher.ToString());
        }
    }

    public void PrintGroups()
    {
        Console.WriteLine("Groups:");
        foreach (var group in _groups)
        {
            Console.WriteLine(group.ToString());
        }
    }

    public void PrintStudents()
    {
        Console.WriteLine("Students:");
        foreach (Group group in _groups)
        {
            foreach (Student student in group._students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    public override void Create()
    {
        Console.WriteLine($"Director '{FullName}' created");
    }

    public override void Remove()
    {
        Console.WriteLine($"Director '{FullName}' removed");
    }
    public override string ToString()
    {
        return $"Director {base.ToString()}";
    }
}