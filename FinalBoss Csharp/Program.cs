using System;

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }

    public void CalculateSalary()
    {
        if (Age >= 50)
        {
            double allowance = 1000;
            Salary += allowance;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine($"Enter details for Employee {i + 1}:");
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine();
            employees[i] = new Employee(name, age, salary);
            employees[i].CalculateSalary();
        }

        Console.WriteLine("\nEmployee Details:");
        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Salary: ${employee.Salary}");
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}