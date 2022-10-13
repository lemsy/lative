using System;
using Lative.Discounts.Domain.Enums;

namespace Lative.Discounts.Domain.Entities
{
    public class Employee{

        public Guid Identifier {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime StartDate {get; set;}
        public EmployeeType Type {get; set;}
    }
}