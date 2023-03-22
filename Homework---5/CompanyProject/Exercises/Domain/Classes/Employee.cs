using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public RoleEnum Role { get; set; }

        public Employee(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee()
        {
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}