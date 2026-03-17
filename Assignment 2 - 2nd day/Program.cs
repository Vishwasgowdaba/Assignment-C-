using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double BaseSalary { get; set; }

    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }

    public virtual string GetEmployeeType()
    {
        return "Employee";
    }
}

class FullTimeEmployee : Employee
{
    public double Bonus { get; set; }

    public override double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override string GetEmployeeType()
    {
        return "Full-Time";
    }
}

class ContractEmployee : Employee
{
    public int HoursWorked { get; set; }
    public double HourlyRate { get; set; }

    public override double CalculateSalary()
    {
        return HoursWorked * HourlyRate;
    }

    public override string GetEmployeeType()
    {
        return "Contract";
    }
}

class Program
{
    private static List<Employee> employeeList = new List<Employee>();

    static void Main()
    {
        var menuActions = new Dictionary<int, Action>
        {
            {1, AddFullTimeEmployee},
            {2, AddContractEmployee},
            {3, DisplayAllEmployees},
            {4, SearchEmployeesByDepartment},
            {5, SortEmployeesBySalary},
            {6, RemoveEmployee},
            {7, ShowBonusFeatures}
        };

        while (true)
        {
            Console.WriteLine("\n===== Employee Management System =====");
            Console.WriteLine("1. Add Full-Time Employee");
            Console.WriteLine("2. Add Contract Employee");
            Console.WriteLine("3. View All Employees");
            Console.WriteLine("4. Search by Department");
            Console.WriteLine("5. Sort by Salary (High → Low)");
            Console.WriteLine("6. Delete Employee");
            Console.WriteLine("7. Bonus Features");
            Console.WriteLine("8. Exit");

            Console.Write("Enter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            if (choice == 8)
                break;

            if (menuActions.ContainsKey(choice))
                menuActions[choice]();
            else
                Console.WriteLine("Invalid choice!");
        }
    }

    static void AddFullTimeEmployee()
    {
        var employee = new FullTimeEmployee
        {
            Id = ReadInt("Enter Id: "),
            Name = ReadString("Enter Name: "),
            Department = ReadString("Enter Department: "),
            BaseSalary = ReadDouble("Enter Base Salary: "),
            Bonus = ReadDouble("Enter Bonus: ")
        };

        employeeList.Add(employee);
        Console.WriteLine("Full-Time Employee Added!");
    }

    static void AddContractEmployee()
    {
        var employee = new ContractEmployee
        {
            Id = ReadInt("Enter Id: "),
            Name = ReadString("Enter Name: "),
            Department = ReadString("Enter Department: "),
            HoursWorked = ReadInt("Enter Hours Worked: "),
            HourlyRate = ReadDouble("Enter Hourly Rate: ")
        };

        employeeList.Add(employee);
        Console.WriteLine("Contract Employee Added!");
    }

    static void DisplayAllEmployees()
    {
        if (!employeeList.Any())
        {
            Console.WriteLine("No employees found!");
            return;
        }

        foreach (var emp in employeeList)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"ID: {emp.Id}");
            Console.WriteLine($"Name: {emp.Name}");
            Console.WriteLine($"Department: {emp.Department}");
            Console.WriteLine($"Type: {emp.GetEmployeeType()}");
            Console.WriteLine($"Salary: {emp.CalculateSalary()}");
        }
    }

    static void SearchEmployeesByDepartment()
    {
        string department = ReadString("Enter Department: ");

        var results = employeeList
            .Where(e => e.Department.Equals(department, StringComparison.OrdinalIgnoreCase))
            .ToList();

        if (!results.Any())
        {
            Console.WriteLine("No employees found in this department!");
            return;
        }

        foreach (var emp in results)
        {
            Console.WriteLine($"{emp.Name} - {emp.CalculateSalary()}");
        }
    }

    static void SortEmployeesBySalary()
    {
        if (!employeeList.Any())
        {
            Console.WriteLine("No employees to sort!");
            return;
        }

        var sortedEmployees = employeeList
            .OrderByDescending(e => e.CalculateSalary());

        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"{emp.Name} - {emp.CalculateSalary()}");
        }
    }

    static void RemoveEmployee()
    {
        int id = ReadInt("Enter Employee ID to delete: ");

        int removedCount = employeeList.RemoveAll(e => e.Id == id);

        Console.WriteLine(removedCount == 0
            ? "Employee not found!"
            : "Employee deleted successfully!");
    }

    static void ShowBonusFeatures()
    {
        if (!employeeList.Any())
        {
            Console.WriteLine("No data available!");
            return;
        }

        Console.WriteLine("\n--- Bonus Features ---");

        var highestPaidEmployee = employeeList
            .OrderByDescending(e => e.CalculateSalary())
            .First();

        Console.WriteLine($"Highest Paid: {highestPaidEmployee.Name} - {highestPaidEmployee.CalculateSalary()}");

        double averageSalary = employeeList.Average(e => e.CalculateSalary());
        Console.WriteLine($"Average Salary: {averageSalary}");

        var groupedByDepartment = employeeList.GroupBy(e => e.Department);

        foreach (var group in groupedByDepartment)
        {
            Console.WriteLine($"\nDepartment: {group.Key}");
            foreach (var emp in group)
            {
                Console.WriteLine($"{emp.Name} - {emp.CalculateSalary()}");
            }
        }
    }

    static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int value))
                return value;

            Console.WriteLine("Invalid input!");
        }
    }

    static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out double value))
                return value;

            Console.WriteLine("Invalid input!");
        }
    }

    static string ReadString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
}