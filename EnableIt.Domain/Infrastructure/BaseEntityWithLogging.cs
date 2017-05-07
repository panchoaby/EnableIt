﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnableIt.Domain.Infrastructure
{
    public class BaseEntityWithLogging : BaseEntity
    {
        public DateTime InsertedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
