using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Model.Employees
{
    public class CreateEmployeeDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
