using System.Collections.Generic;
using Lative.Discounts.Domain.Entities;

namespace Lative.Discounts.Infrastructure.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}