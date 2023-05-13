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
            double extra = 1000;
            Salary=Salary+extra;
        }
    }

public class Program
{
    public static void Main(string[] args)
    {
        Employee[] employees = new Employee[4];

        employees[0] = new Employee("Ahmad", 35, 2500);
        employees[1] = new Employee("Mahmoud", 42, 3500);
        employees[2] = new Employee("Sara", 55, 4000);
        employees[3] = new Employee("Mohammad", 51, 2500);
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Console.WriteLine("Employee Salaries:");

        for (int i = 0; i < employees.Length; i++)
        {
            employees[i].CalculateSalary();
            Console.WriteLine($"Name: {employees[i].Name}");
            Console.WriteLine($"Salary: ${employees[i].Salary}");

            if (employees[i].Age > 50)
            {
                Console.WriteLine($"Age: {employees[i].Age}");
            }

            Console.WriteLine();
        }
    }
 }
}


