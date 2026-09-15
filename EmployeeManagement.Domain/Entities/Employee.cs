using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Entities
{
    public class Employee
    {
        public int Id { get; private set;}
        public string Name { get; private set;}
        public string Department { get; private set;}
        public decimal Salary { get; private set;}
        public bool Active { get; private set;}

     private Employee()
    {
    }

    public Employee(
        string name,
        string department,
        decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
        Active = true;
    }

    public void Update(
        string name,
        string department,
        decimal salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
    }
        
    }
}