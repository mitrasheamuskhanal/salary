using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public virtual void GetFullName()
    {
        Console.WriteLine("Employee name: " + Name);
    }

    public virtual double GetYearlySalary()
    {
        return Salary;
    }
}

class FullTimeEmployee : Employee
{
    public override double GetYearlySalary()
    {
        return Salary * 12;
    }
}

class PartTimeEmployee : Employee
{
    public double WorkedHourly { get; set; }
    public double HourlyRate { get; set; }

    public override double GetYearlySalary()
    {
        return WorkedHourly * HourlyRate;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the full name of the full-time employee: ");
        string fullTimeName = Console.ReadLine();
        Console.WriteLine("Enter the monthly salary of the full-time employee: ");
        double fullTimeSalary = Convert.ToDouble(Console.ReadLine());
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        fullTimeEmployee.Name = fullTimeName;
        fullTimeEmployee.Salary = fullTimeSalary;
        fullTimeEmployee.GetFullName();
        Console.WriteLine("Yearly salary: " + fullTimeEmployee.GetYearlySalary());

        Console.WriteLine("Enter the full name of the part-time employee: ");
        string partTimeName = Console.ReadLine();
        Console.WriteLine("Enter the hourly rate of the part-time employee: ");
        double hourlyRate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the worked hours of the part-time employee: ");
        double workedHours = Convert.ToDouble(Console.ReadLine());
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        partTimeEmployee.Name = partTimeName;
        partTimeEmployee.HourlyRate = hourlyRate;
        partTimeEmployee.WorkedHourly = workedHours;
        partTimeEmployee.GetFullName();
        Console.WriteLine("Yearly salary: " + partTimeEmployee.GetYearlySalary());
    }
}
