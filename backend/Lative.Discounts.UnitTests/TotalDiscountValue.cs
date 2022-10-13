using Lative.Discounts.Domain.Enums;
using Lative.Discounts.Infrastructure.Repositories;
using Lative.Discounts.Infrastructure.Services;
using NUnit.Framework;
using System;
using System.Linq;

namespace Lative.Discounts.UnitTests
{
    [TestFixture]
    public class TotalDiscountValue
    {
        private EmployeeRepository employeeRepository;
        private DiscountService discountService;
        private int testCoverage;

        [SetUp]
        public void Setup() 
        {
            employeeRepository = new EmployeeRepository();
            discountService = new DiscountService();
            testCoverage = 4;
        }

        [Test]
        public void Contractor_Employee_Has_Zero_Discount()
        {
            var date = DateTime.Now;
            foreach (var employee in employeeRepository.GetEmployees().Where(e => e.Type == EmployeeType.Contractor).Take(testCoverage))
            {
                var discount = discountService.TotalDiscount(employee, date);
                Assert.IsTrue(discount == 0);
            }
        }

        [Test]
        public void Intern_Employee_Has_Five_Discount()
        {
            var date = DateTime.Now;
            foreach (var employee in employeeRepository.GetEmployees().Where(e => e.Type == EmployeeType.Intern).Take(testCoverage))
            {
                var discount = discountService.TotalDiscount(employee, date);
                Assert.IsTrue(discount == 5);
            }
        }

        [Test]
        public void Employee_Initial_Discount()
        {
            var date = DateTime.Now;
            var employees = employeeRepository.GetEmployees();
            foreach (var employee in employees.Where(e => e.Type == EmployeeType.Permanent && (date - e.StartDate).TotalDays/365 < 3).Take(testCoverage))
            {
                var discount = discountService.TotalDiscount(employee, date);
                Assert.IsTrue(discount == 10);
            }

            foreach (var employee in employees.Where(e => e.Type == EmployeeType.PartTime && (date - e.StartDate).TotalDays / 365 < 5).Take(testCoverage))
            {
                var discount = discountService.TotalDiscount(employee, date);
                Assert.IsTrue(discount == 5);
            }
        }

        [Test]
        public void Employee_Extra_Discount()
        {
            var date = DateTime.Now;
            var employees = employeeRepository.GetEmployees();
            foreach (var employee in employees.Where(e => e.Type == EmployeeType.Permanent && (date - e.StartDate).TotalDays / 365 > 3).Take(testCoverage))
            {
                var discount = discountService.TotalDiscount(employee, date);
                Assert.IsTrue(discount == 15);
            }

            foreach (var employee in employees.Where(e => e.Type == EmployeeType.PartTime && (date - e.StartDate).TotalDays / 365 > 5).Take(testCoverage))
            {
                var discount = discountService.TotalDiscount(employee, date);
                Assert.IsTrue(discount == 8);
            }
        }
    }
}
