using System;
using System.Collections.Generic;
using Lative.Discounts.Domain.Entities;
using Lative.Discounts.Domain.Enums;

namespace Lative.Discounts.Infrastructure.Repositories
{
    
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>(){

                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "James",
                        LastName = "Smith",
                        StartDate = new DateTime(2022, 8, 12),
                        Type =  EmployeeType.Permanent 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Robert",
                        LastName = "Jones",
                        StartDate = new DateTime(2020, 8, 12),
                        Type =  EmployeeType.Permanent 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Thomas",
                        LastName = "Peterson",
                        StartDate = new DateTime(2019, 8, 12),
                        Type =  EmployeeType.Permanent 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Michael",
                        LastName = "Brown",
                        StartDate = new DateTime(2019, 8, 12),
                        Type =  EmployeeType.Permanent 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "David",
                        LastName = "Wilson",
                        StartDate = new DateTime(2018, 8, 12),
                        Type =  EmployeeType.Permanent 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "William",
                        LastName = "Taylor",
                        StartDate = new DateTime(2021, 8, 12),
                        Type =  EmployeeType.PartTime 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Richard",
                        LastName = "Morton",
                        StartDate = new DateTime(2022, 8, 12),
                        Type =  EmployeeType.PartTime 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Stefany",
                        LastName = "Jhonson",
                        StartDate = new DateTime(2019, 8, 12),
                        Type =  EmployeeType.PartTime 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Kimberly",
                        LastName = "Sarandon",
                        StartDate = new DateTime(2010, 8, 12),
                        Type =  EmployeeType.PartTime 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Jhon",
                        LastName = "Doe",
                        StartDate = new DateTime(2020, 8, 12),
                        Type =  EmployeeType.PartTime 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Stuart",
                        LastName = "Little",
                        StartDate = new DateTime(2018, 8, 12),
                        Type =  EmployeeType.Intern 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Jenry",
                        LastName = "James",
                        StartDate = new DateTime(2020, 8, 12),
                        Type =  EmployeeType.Intern 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Priscilla",
                        LastName = "Donwell",
                        StartDate = new DateTime(2019, 8, 12),
                        Type =  EmployeeType.Intern 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Laurie",
                        LastName = "Maxwell",
                        StartDate = new DateTime(2022, 8, 12),
                        Type =  EmployeeType.Intern 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Harrison",
                        LastName = "Huegh",
                        StartDate = new DateTime(2019, 8, 12),
                        Type =  EmployeeType.Intern 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Charles",
                        LastName = "Steward",
                        StartDate = new DateTime(2018, 8, 12),
                        Type =  EmployeeType.Contractor 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Merry",
                        LastName = "Percival",
                        StartDate = new DateTime(2022, 8, 12),
                        Type =  EmployeeType.Contractor 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Harry",
                        LastName = "Wilson",
                        StartDate = new DateTime(2019, 8, 12),
                        Type =  EmployeeType.Contractor 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Guewn",
                        LastName = "Laurence",
                        StartDate = new DateTime(2021, 8, 12),
                        Type =  EmployeeType.Contractor 
                    },
                    new Employee(){ 
                        Identifier = Guid.NewGuid(),
                        FirstName = "Golween",
                        LastName = "Meyer",
                        StartDate = new DateTime(2022, 8, 12),
                        Type =  EmployeeType.Contractor 
                    }
                };
        }
    }
}