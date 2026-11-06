using EmployeeManagement.Infrastructure.Data;
using EmployeeManagement.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public class EmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync( Employee employee, CancellationToken cancellationToken)
        {
            await _context.Employees.AddAsync(employee, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return employee.Id;
        }
    }
}
