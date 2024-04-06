using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Assigment.Dtos
{
    public class EmployeeDto:IEntityDto<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Department { get; set; }
    }
}
