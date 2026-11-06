using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Employees.Commands
{
    public record CreateEmployeeCommand(string Name,string Email) : IRequest<int>;
}
