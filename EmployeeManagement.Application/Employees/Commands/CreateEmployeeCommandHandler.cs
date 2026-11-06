using EmployeeManagement.Application.Employees.IRepository;
using EmployeeManagement.Infrastructure.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Employees.Commands
{
    public class CreateEmployeeCommandHandler  : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository  _repo;

        public CreateEmployeeCommandHandler(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public async Task<int> Handle( CreateEmployeeCommand request,CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                Name = request.Name,
                Email = request.Email
            };

            return await _repo.CreateAsync( employee,cancellationToken);
        }
    }
}
