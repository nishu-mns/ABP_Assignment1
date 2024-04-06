using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Assigment.Entity
{
    public class Employee: BasicAggregateRoot<Guid>
    {
            public string Name { get; set; }
            public string Location { get; set; }
            public string Department { get; set; }
    }
}
