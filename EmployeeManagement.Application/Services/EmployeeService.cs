using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Application.DTOs.Employees;
using EmployeeManagement.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement.Application.Services;
public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _repository;
    private readonly ILogger<EmployeeService> _logger;

    public EmployeeService(
        IEmployeeRepository repository,
        ILogger<EmployeeService> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<EmployeeResponse> UpdateAsync(
        int id,
        UpdateEmployeeRequest request,
        CancellationToken cancellationToken)
    {
        _logger.LogInformation(
            "Updating employee {EmployeeId}",
            id);

        var employee =
            await _repository.GetByIdAsync(
                id,
                cancellationToken);

        if (employee is null)
        {
            throw new KeyNotFoundException(
                $"Employee {id} was not found.");
        }

        employee.Update(
            request.Name,
            request.Department,
            request.Salary);

        await _repository.UpdateAsync(
            employee,
            cancellationToken);

        await _repository.SaveChangesAsync(
            cancellationToken);

        return new EmployeeResponse
        {
            Id = employee.Id,
            Name = employee.Name,
            Department = employee.Department,
            Salary = employee.Salary,
            Active = employee.Active
        };
    }
}