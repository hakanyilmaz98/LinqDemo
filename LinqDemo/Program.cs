using Dumpify;
using LinqDemo;

List<Employee> employees = [
    new() { Name = "John", Department = Department.HR, Salary = 50000 },
    new() { Name = "Jane", Department = Department.IT, Salary = 75000 },
    new() { Name = "Emily", Department = Department.Finance, Salary = 65000 },
    new() { Name = "Michael", Department = Department.IT, Salary = 80000 },
    new() { Name = "Chris", Department = Department.HR, Salary = 45000 },
    new() { Name = "Sarah", Department = Department.Marketing, Salary = 55000 },
    new() { Name = "James", Department = Department.Sales, Salary = 70000 },
    new() { Name = "Patricia", Department = Department.Finance, Salary = 67000 },
    new() { Name = "Robert", Department = Department.IT, Salary = 82000 },
    new() { Name = "Linda", Department = Department.Marketing, Salary = 60000 },
    ];

var names = employees.Select(x => x.Name);

names.Dump();