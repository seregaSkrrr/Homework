using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Director director = new Director("Alex Volynov", Gender.Male, new DateTime(1970, 1, 1), "+79528121234", "alex@gmail.com", 100_000, new DateTime(2010, 1, 1));
        Teacher teacher = new Teacher("Andrey Prepod", Gender.Male, new DateTime(1975, 1, 1), "+79528121234", "Andrey@gmail.com", 70_000, new DateTime(2015, 1, 1));
        Group group = new Group("P22");
        Student student1 = new Student("Max Sholtoyanu", Gender.Male, new DateTime(2000, 1, 1), "+79528121234", "Max@gmail.com");
        Student student2 = new Student("Sonya Kopilot", Gender.Female, new DateTime(2000, 1, 1), "+79528121234", "alice.smith@mail.ru");

        director.AddTeacher(teacher);
        director.AddGroup(group);
        group.AddStudent(student1);
        group.AddStudent(student2);

        director.PrintTeachers();
        Console.WriteLine();
        director.PrintGroups();
        Console.WriteLine();
        director.PrintStudents();

    }
}