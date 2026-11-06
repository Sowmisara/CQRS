using EmployeeManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Employees.IRepository
{
    public interface IEmployeeRepository
    {
        Task<int> CreateAsync(Employee employee,CancellationToken cancellationToken);
    }
}
