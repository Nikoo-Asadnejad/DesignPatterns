namespace DesignPatterns;

using System;
using System.Collections.Generic;

public interface IEmployee
{
    void Accept(IVisitor visitor);
}

public class PermanentEmployee : IEmployee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public PermanentEmployee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class ContractEmployee : IEmployee
{
    public string Name { get; set; }
    public double HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public ContractEmployee(string name, double hourlyRate, int hoursWorked)
    {
        Name = name;
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public interface IVisitor
{
    void Visit(PermanentEmployee permanentEmployee);
    void Visit(ContractEmployee contractEmployee);
}

public class SalaryCalculatorVisitor : IVisitor
{
    public void Visit(PermanentEmployee permanentEmployee)
    {
        Console.WriteLine($"Calculating salary for permanent employee: {permanentEmployee.Name}");
        double salary = permanentEmployee.Salary;
        Console.WriteLine($"Salary: {salary}");
    }

    public void Visit(ContractEmployee contractEmployee)
    {
        Console.WriteLine($"Calculating salary for contract employee: {contractEmployee.Name}");
        double salary = contractEmployee.HourlyRate * contractEmployee.HoursWorked;
        Console.WriteLine($"Salary: {salary}");
    }
}

public class EmployeeDetailsPrinterVisitor : IVisitor
{
    public void Visit(PermanentEmployee permanentEmployee)
    {
        Console.WriteLine($"Permanent Employee: {permanentEmployee.Name}, Salary: {permanentEmployee.Salary}");
    }

    public void Visit(ContractEmployee contractEmployee)
    {
        Console.WriteLine($"Contract Employee: {contractEmployee.Name}, Hourly Rate: {contractEmployee.HourlyRate}, Hours Worked: {contractEmployee.HoursWorked}");
    }
}

class VisitorSample
{
    static void Usage()
    {
        // Create employees
        var employees = new List<IEmployee>
        {
            new PermanentEmployee("Alice", 50000),
            new ContractEmployee("Bob", 40, 160)
        };

        // Create visitors
        var salaryCalculator = new SalaryCalculatorVisitor();
        var detailsPrinter = new EmployeeDetailsPrinterVisitor();

        // Apply visitors to employees
        foreach (var employee in employees)
        {
            employee.Accept(salaryCalculator);
            employee.Accept(detailsPrinter);
        }
    }
}