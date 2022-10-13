using System;

namespace Lative.Discounts.Domain.Enums
{
    public enum EmployeeType
    {
        Permanent,
        PartTime,
        Intern,
        Contractor
    }

    public static class EmployeeTypeHelpers {
        public static string GetReadableName(this EmployeeType employeeType) => (employeeType) switch { 
            EmployeeType.Permanent => "Permanent",
            EmployeeType.PartTime => "Part-time",
            EmployeeType.Intern => "Intern",
            EmployeeType.Contractor => "Contractor",
            _ => throw new ArgumentOutOfRangeException()
        };

        public static EmployeeType? GetEmployeeTypeByNameOrDefault(string name)
        {
            foreach (EmployeeType t in Enum.GetValues(typeof(EmployeeType)))
            {
                if (t.GetReadableName() == name)
                {
                    return t;
                }

            }
            return null;
        }
    }
}