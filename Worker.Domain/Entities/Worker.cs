using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Domain.ValueObjects;
using Worker.Shared.BaseEntities;
using Worker.Shared.Enums;

namespace Worker.Domain.Entities
{
    public class Worker:AggregateRoot
    {
        public string? Name { get; set; }
        public WorkerState State { get; set; }
        public Gender Gender { get; set; }
        public Salary? Salary { get; set; }
        public DateTime Hiredate { get; set; }
        public string? Phone { get; set; }
        public string? IDCard { get; set; }
        public Bank? Bank { get; set; }
        public Guid? DepartmentId { get; set; }
        public Guid? PostitionId { get; set; }
        public Guid? AvatarId { get; set; }

        public List<Clockin>? Clockins { get; set; }
        public WorkerClockinStatistics? ClockinStatistics { get; set; }

    }
}
