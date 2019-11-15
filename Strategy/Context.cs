using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Context
    {
        private Strategy sortStrategy;

        public void SetSortStrategy(Strategy strategy)
        {
            sortStrategy = strategy;
        }

        public void Sort(List<int> list)
        {
            sortStrategy.Sort(list);
        }
    }
}
