﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Entities.Concrete
{
    public class Davines : IEntity
    {
        public int Id { get; set; }
        public string Picture { get; set; }
    }
}
