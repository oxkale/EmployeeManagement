using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Application.DTOs.Employees;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IEmployeeService
    {

         Task<EmployeeResponse> UpdateAsync(
        int id,
        UpdateEmployeeRequest request,
        CancellationToken cancellationToken);
        
    }
}