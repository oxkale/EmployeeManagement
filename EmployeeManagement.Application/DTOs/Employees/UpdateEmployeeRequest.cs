using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.Employees
{
    public class UpdateEmployeeRequest
    {
            public string Name { get; set; } = string.Empty;

            public string Department { get; set; } = string.Empty;

            public decimal Salary { get; set; }
    }
}