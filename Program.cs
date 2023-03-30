using System;
class execute
{
    static void Main(string[] args)
    {
        Console.Write("Your Full Name ? :");
        string name = Console.ReadLine();
        Console.Write("What is Your Salary : ");
        double fullTimeSalary = Convert.ToDouble(Console.ReadLine()) ;
        

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

