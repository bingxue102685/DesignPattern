﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    interface IAggregate
    {
        IMyIterator GetIterator();
    }
}
