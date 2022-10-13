using System;
using Lative.Discounts.Domain.Entities;
using Lative.Discounts.Domain.Enums;

namespace Lative.Discounts.Infrastructure.Services
{
    public class DiscountService : IDiscountService
    {
        public int TotalDiscount(Employee employee, DateTime date)
        {
            if (date <= employee.StartDate) throw new ArgumentException("Employee should work at least one day to get a discount.");
            var workedYears = (date - employee.StartDate).TotalDays/365;
            return employee.Type switch {
                EmployeeType.Permanent when workedYears < 3 => 10,
                EmployeeType.Permanent when workedYears >= 3 => 15,
                EmployeeType.PartTime when workedYears < 5 => 5,
                EmployeeType.PartTime when workedYears >= 5 => 8,
                EmployeeType.Intern => 5,
                EmployeeType.Contractor => 0,
                _ => throw new ArgumentOutOfRangeException($"Not expected Employee type: {employee.Type}.")
            };
        }
    }
}