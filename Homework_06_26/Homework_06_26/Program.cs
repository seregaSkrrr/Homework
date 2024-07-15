using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Director("Sergey", 1000, new List<string> { "Management", "Leadership" }),
            new Accountant("Alex", 800, new List<string> { "Accounting", "Bookkeeping" }),
            new Manager("Maria", 900, new List<string> { "Management", "Communication" }),
            new Cook("Nikita", 700, new List<string> { "Cooking", "FoodSafety" }),
            new Cook("Martin", 700, new List<string> { "Cooking", "FoodSafety" }),
            new Waiter("Sonya", 600, new List<string> { "CustomerService", "Communication" }),
            new Waiter("Sergey", 600, new List<string> { "CustomerService", "Communication" }),
            new Cleaner("Anna", 500, new List<string> { "Cleaning", "Organization" }),
            new Loader("Igor", 400, new List<string> { "Loading", "Logistics" })
        };

        Console.WriteLine("Starting the workday");
        Console.WriteLine("========================================\n");

        foreach (var employee in employees)
        {
            employee.Work();
            Console.WriteLine($"Paying {employee.Name} ${employee.Salary} salary\n");
        }

        Console.WriteLine("\n========================================");
        Console.WriteLine("Workday is over!");


        Console.WriteLine("\n\n\n\n\n\n");
        foreach(var employee in employees)
        {
            employee.Info();
        }
    }
}