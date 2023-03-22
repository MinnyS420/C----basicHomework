using Domain.Classes;
using Domain.Enums;
using System;

namespace Domain.Classes
{
    public class CEO : Employee
    {
        private double _sharesPrice;
        private Employee[] _employees;
        public int Shares { get; set; }

        public CEO(string firstName, string lastName, double salary, Employee[] company, int shares) : base(firstName, lastName, salary)
        {
            Salary = salary;
            _employees = company;
            Shares = shares;
        }

        public void AddSharesPrice(double price)
        {
            _sharesPrice = price;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in _employees)
            {
                Console.WriteLine(employee.GetInfo());
            }
        }

        public override double GetSalary()
        {
            return Salary + Shares * _sharesPrice;
        }
    }
}
