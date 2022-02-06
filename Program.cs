// See https://aka.ms/new-console-template for more information
using EmployeeWageComputation;

Employee employee = new Employee();
employee.AddCompanyEmpWage("Reliance",30,20,100);
employee.AddCompanyEmpWage("TCS",25,22,120);

employee.CalculateWage();
