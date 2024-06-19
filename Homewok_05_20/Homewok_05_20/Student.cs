using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Student : Person
{
    /*Random rand = new Random();
    private string _firstname;
    private string _secondname;
    private string _surname;
    private string _group;
    private int _age;
    private List<int[]> _marks = new List<int[]>();
    private string[] _list = { "ООП", "UML" };
    public Student()
    {
        _firstname = "Кравцов";
        _secondname = "Сергей";
        _surname = "Алексеевич";
        _group = "П22";
        _age = 17;
        for (int i = 0; i < _list.Length; i++)
        {
            _marks.Add(new int[rand.Next(1, 10)]);
            for (int j = 0; j < _marks[i].Length; j++)
                _marks[i][j] = rand.Next(1, 5);
        }
    }
    public Student(string name, string secondname, string surname)
    {
        _firstname = name;
        _secondname = secondname;
        _surname = surname;
        _group = "П22";
        _age = 17;
        for (int i = 0; i < _list.Length; i++)
        {
            _marks.Add(new int[rand.Next(1, 10)]);
            for (int j = 0; j < _marks[i].Length; j++)
                _marks[i][j] = rand.Next(1, 5);
        }
    }
    public Student(string name, string secondname, string surename, string group)
    {
        _firstname = name;
        _secondname = secondname;
        _surname = surename;
        _group = group;
        _age = 17;
        for (int i = 0; i < _list.Length; i++)
        {
            _marks.Add(new int[rand.Next(1, 10)]);
            for (int j = 0; j < _marks[i].Length; j++)
                _marks[i][j] = rand.Next(1, 5);
        }
    }
    public Student(string name, string secondname, string surename, string group, int age)
    {
        _firstname = name;
        _secondname = secondname;
        _surname = surename;
        _group = group;
        _age = age;
        for (int i = 0; i < _list.Length; i++)
        {
            _marks.Add(new int[rand.Next(1, 10)]);
            for (int j = 0; j < _marks[i].Length; j++)
                _marks[i][j] = rand.Next(1, 5);
        }
    }
    public Student(string name, string secondname, string surename, int age, string group, string[] list)
    {
        _firstname = name;
        _secondname = secondname;
        _surname = surename;
        _group = group;
        _age = age;
        _list = list;
        for (int i = 0; i < _list.Length; i++)
        {
            _marks.Add(new int[rand.Next(1, 10)]);
            for (int j = 0; j < _marks[i].Length; j++)
                _marks[i][j] = rand.Next(1, 5);
        }
    }
    public void Get_GPA(int row)
    {
        if (row < 0 || row >= _list.Length) return;
        Console.WriteLine($"Средний балл по {_list[row]}: {GPA(row)}");
    }
    public void CreateMarks(int index)
    {
        if (index < 0 || index >= _marks.Count) { return; }

        for (int i = 0; i < _marks[index].Length; i++)
        {
            _marks[index][i] = rand.Next(1, 5);
        }

    }
    public void RemoveObject(int index)
    {
        if (index < 0 || index > _list.Length) { return; }
        string[] list = new string[_list.Length - 1];
        for (int i = 0; i < index; i++)
        {
            list[i] = _list[i];
        }
        for (int i = index; i < list.Length; i++)
        {
            list[i] = _list[i + 1];
        }
        _list = list;
        _marks.Remove(_marks[index]);
    }
    public void RemoveObject()
    {
        string[] newlist = new string[_list.Length - 1];
        for (int i = 0; i < newlist.Length; i++)
        {
            newlist[i] = _list[i];
        }
        _list = newlist;
        _marks.Remove(_marks[_marks.Count - 1]);
    }
    public void ChangeMark(int row, int col, int mark)
    {
        if (row < 0 || row >= _marks.Count) return;
        if (col < 0 || col >= _marks[row].Length) return;
        if (mark < 1) mark = 1;
        if (mark > 5) mark = 5;
        _marks[row][col] = mark;
    }
    public void AddObject(string name)
    {
        string[] list = new string[_list.Length + 1];
        for (int i = 0; i < list.Length - 1; i++)
        {
            list[i] = _list[i];
        }
        list[list.Length - 1] = name;
        _list = list;
        int[] marks1 = new int[0];
        _marks.Add(marks1);
    }
    public void AddMark(int index, int mark)
    {
        if (index < 0 || index >= _marks.Count) return;
        if (mark < 1) mark = 1;
        if (mark > 5) mark = 5;

        int[] marks = new int[_marks[index].Length + 1];
        for (int i = 0; i < marks.Length - 1; i++)
        {
            marks[i] = _marks[index][i];
        }
        marks[marks.Length - 1] = mark;
        _marks[index] = marks;
    }
    public void ShowObject()
    {
        for (int i = 0; i < _list.Length; i++)
        {
            Console.WriteLine($"{_list[i]}:");
            ShowMarks(i);
        }

        Console.WriteLine();
    }
    public void Info()
    {
        Console.WriteLine($"Фамилия: {_firstname}\nИмя: {_secondname}\nОтчество: {_surname}\nГруппа: {_group}\nВозвраст: {_age}");
        ShowObject();
        Console.WriteLine("\n");
    }
    private void ShowMarks(int mark)
    {
        if (mark < 0 || mark >= _marks.Count) return;
        for (int i = 0; i < _marks[mark].Length; i++)
            Console.Write($"{_marks[mark][i]} ");
        Console.WriteLine();
    }
    private float GPA(int row)
    {
        if (row < 0 || row >= _marks.Count)
            return 0;
        float gpa = 0;
        for (int i = 0; i < _marks[row].Length; i++)
            gpa += _marks[row][i];
        gpa = gpa / _marks[row].Length;
        return gpa;
    }*/

    public Student(string fullName, Gender gender, DateTime birthDate, string phone, string email) : base(fullName, gender, birthDate, phone, email){}

    public override void Create()
    {
        Console.WriteLine($"Student '{FullName}' created");
    }

    public override void Remove()
    {
        Console.WriteLine($"Student '{FullName}' removed");
    }
    public override string ToString()
    {
        return $"Student {base.ToString()}";
    }
}