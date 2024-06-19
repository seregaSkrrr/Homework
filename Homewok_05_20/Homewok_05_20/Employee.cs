using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal abstract class Employee : Person
{
    private float _salary;
    private DateTime _employmentDate;

    public Employee(string fullName, Gender gender, DateTime birthDate, string phone, string email, float salary, DateTime employmentDate) : base(fullName, gender, birthDate, phone, email)
    {
        _salary = salary;
        _employmentDate = employmentDate;
    }

    public float Salary { get { return _salary; } }
    public DateTime EmploymentDate { get { return _employmentDate; } }

    public override void Create()
    {
        Console.WriteLine($"Employee '{FullName}' created");
    }

    public override void Remove()
    {
        Console.WriteLine($"Employee '{FullName}' removed");
    }
    public override string ToString()
    {
        return $"Employee {base.ToString()} with salary {_salary}$ since {_employmentDate.ToShortDateString()}";
    }
}