using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Shared.BaseEntities;

namespace Worker.Domain.Entities
{
    public class Department:AggregateRoot
    {
        public string? DepartmentName { get; set; }
        public int PersonCount { get; set; }
    }
}
