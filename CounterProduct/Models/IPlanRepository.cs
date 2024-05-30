﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProduct.Models
{
    public interface IPlanRepository
    {
        void Add(dynamic model);

        IEnumerable<PlanModel> GetAll();
        IEnumerable<PlanModel> GetCycle(TimeOnly model);
    }
}
