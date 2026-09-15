using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Domain.Entities;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IEmployeeRepository
    {
            Task<Employee?> GetByIdAsync(
        int id,
        CancellationToken cancellationToken);

    Task UpdateAsync(
        Employee employee,
        CancellationToken cancellationToken);

    Task<bool> SaveChangesAsync(
        CancellationToken cancellationToken);
    }
}