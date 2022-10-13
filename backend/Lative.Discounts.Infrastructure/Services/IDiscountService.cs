using System;
using Lative.Discounts.Domain.Entities;

namespace Lative.Discounts.Infrastructure.Services
{
    public interface IDiscountService
    {
        int TotalDiscount(Employee employee, DateTime date);
    }
}