using Assigment.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Assigment.IServices
{
    public interface IEmployeeService:IApplicationService
    {

        Task<EmployeeDto> GetEmployeeByName(string name);
        Task<List<EmployeeDto>> GetEmployeeByDepartment(string name);

    }
}
