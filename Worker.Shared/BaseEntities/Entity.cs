﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Shared.BaseEntities.Contract;

namespace Worker.Shared.BaseEntities
{
    public abstract class Entity : IEntity
    {
        protected Entity(Guid id) => Id = id;

        protected Entity()
        {
        }

        public Guid Id { get; protected set; }
    }
}
