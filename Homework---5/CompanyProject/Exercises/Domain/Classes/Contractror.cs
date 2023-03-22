using Domain.Enums;

namespace Domain.Classes
{
    public class Contractor : Employee
    {
        private double _workHours;
        private int _payPerHour;
        private Manager _responsible;

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager responsible)
            : base(firstName, lastName, 0)
        {
            _workHours = workHours;
            _payPerHour = payPerHour;
            _responsible = responsible;
            Role = RoleEnum.Other;
        }

        public override double GetSalary()
        {
            double salary = _workHours * _payPerHour;
            Salary = salary;
            return salary;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}: {_workHours} hours, ${_payPerHour} per hour";
        }

        public string GetCurrentPosition()
        {
            return _responsible.Department.ToString();
        }
    }
}

