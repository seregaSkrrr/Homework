using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Person : SchoolObject
{
    private string _fullName;
    private Gender _gender;
    private DateTime _birthDate;
    private string _phone;
    private string _email;

    public Person(string fullName, Gender gender, DateTime birthDate, string phone, string email)
    {
        _fullName = fullName;
        _gender = gender;
        _birthDate = birthDate;
        _phone = phone;
        _email = email;
    }

    public string FullName { get { return _fullName; } }
    public Gender Gender { get { return _gender; } }
    public DateTime BirthDate { get { return _birthDate; } }
    public string Phone { get { return _phone; } }
    public string Email { get { return _email; } }

    public override string ToString()
    {
        return $"{_fullName} ({_gender}) born on {_birthDate.ToShortDateString()}";
    }
}

public enum Gender
{
    Male,
    Female
}