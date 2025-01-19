namespace LinqDemo;
public class Employee
{
    public required string Name { get; set; }
    public required Department Department { get; set; }
    public required double Salary { get; set; }
}

public enum Department
{
    HR,
    IT,
    Sales,
    Finance,
    Marketing
}
