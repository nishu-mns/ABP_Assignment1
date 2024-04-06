using Assigment.Dtos;
using Assigment.Entity;
using Assigment.IServices;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;

namespace Assigment.Services
{
    [Authorize]
    public class EmployeeService : CrudAppService<Employee,
            EmployeeDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateEmployeeDto,
            UpdateEmployeeDto
            >,
        IEmployeeService
    {
        public EmployeeService(IRepository<Employee, Guid> repository) :
            base(repository)
        {
        }

        public async Task<EmployeeDto> GetEmployeeByName(string name)
        {
            var entity = await Repository.FirstOrDefaultAsync(x=>x.Name == name);
            if(entity== null)
            {
                throw new EntityNotFoundException();
            }
            return ObjectMapper.Map<Employee, EmployeeDto>(entity);
        }

        public async Task<List<EmployeeDto>> GetEmployeeByDepartment(string name)
        {
            IQueryable<Employee> employeelist = await Repository.GetQueryableAsync();
            var d= employeelist.Where(x => x.Department == name);
            await Console.Out.WriteLineAsync(d.Count().ToString());

            var query= from employees in employeelist where employees.Department == name select employees;
            var list = query.ToList();
            return list.Select(item => new EmployeeDto
            {
                Id = item.Id,
                Name = item.Name,
                Department = item.Department,
                Location = item.Location,
            }).ToList();

        }
    }
}
