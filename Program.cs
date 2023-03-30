using System;
class employee
{
     public string Name{ get; set; }
    public double salary { get; set; }

    public virtual void getFullName()
    {
        Console.WriteLine("employee name:" + Name)
    }
    public virtual double getYearlySalary()
    {
        return salary;
    }
}
