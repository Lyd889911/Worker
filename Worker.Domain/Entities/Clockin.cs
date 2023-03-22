using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Domain.ValueObjects;
using Worker.Shared.BaseEntities;
using Worker.Shared.BaseEntities.Contract;

namespace Worker.Domain.Entities
{
    public class Clockin : Entity, IHasCreationCreator, IHasModificationCreator
    {
        public Guid? CreatorId { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime? ModificationTime { get; set; }

        public Guid? ModifierId { get; set; }

        public bool Morning { get; set; }
        public bool Afternoon { get; set; }
        public decimal Overtime { get; set; }
        public string? Remark { get; set; }
        public Guid? WorkerId { get; set; }
        public Salary? CurrentSalary { get; set; }
    }
}
