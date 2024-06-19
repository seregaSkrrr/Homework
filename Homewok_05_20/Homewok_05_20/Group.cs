using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Group : SchoolObject
{
    private string _groupName;
    internal List<Student> _students;

    public Group(string name)
    {
        _groupName = name;
        _students = new List<Student>();
    }

    public string Name { get { return _groupName; } }

    internal void AddStudent(Student student)
    {
        _students.Add(student);
        _students.Sort((a, b) => a.FullName.CompareTo(b.FullName));
    }

    public void RemoveStudent()
    {
        _students.Remove(_students[_students.Count-1]);
    }

    public override void Create()
    {
        Console.WriteLine($"Group '{_groupName}' created");
    }
    public override void Remove()
    {
        Console.WriteLine($"Group '{_groupName}' removed");
    }
    public override string ToString()
    {
        return $"Group '{_groupName}' with {_students.Count} students";
    }
}