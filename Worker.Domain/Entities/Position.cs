using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Domain.ValueObjects;
using Worker.Shared.BaseEntities;

namespace Worker.Domain.Entities
{
    public class Position:AggregateRoot
    {
        public string? PositionName { get; set; }
        public Salary? Salary { get; set; }
    }
}
