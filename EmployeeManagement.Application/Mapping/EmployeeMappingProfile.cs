using AutoMapper;
using EmployeeManagement.Application.Employees.Commands;
using EmployeeManagement.Application.Model.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Mapping
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<CreateEmployeeDTO, CreateEmployeeCommand>();
        }
    }
}
