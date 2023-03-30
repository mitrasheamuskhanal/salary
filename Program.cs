using System;
class execute
{
    static void Main(string[] args)
    {
        Console.Write("Who are You FTE OR PTE ? :");
        string uservalue = Console.ReadLine();
        if (uservalue == "FTE")
        {
            Console.Write("Your Full Name ? :");
            string name = Console.ReadLine();
            Console.Write("What is Your Salary : ");
            double fullTimeSalary = Convert.ToDouble(Console.ReadLine());
            FTE fullTimeEmployee = new FTE();
            fullTimeEmployee.Name = name;
            fullTimeEmployee.salary = fullTimeSalary;
            fullTimeEmployee.getFullName();
            Console.WriteLine("Yearly salary" + fullTimeEmployee.getYearlySalary());
        }
        else if (uservalue == "PTE")
        {
            Console.WriteLine("Your Full name ");
        }




    }
}
class employee
{
     public string Name{ get; set; }
    public double salary { get; set; }

    public virtual void getFullName()
    {
        Console.WriteLine("employee name:" + Name);
    }
    public virtual double getYearlySalary()
    {
        return salary;
    }
}
class FTE : employee
{
    public override double getYearlySalary()
    {
        return salary * 12;
    }
}
class PTE : employee
{
  public double workedHour { get; set; }
 public double hourlyRate { get; set;}

    public override double getYearlySalary()
    {
        return workedHour * hourlyRate;
    }
}

