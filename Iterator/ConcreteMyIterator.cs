using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class ConcreteMyIterator : IMyIterator
    {
        private ConcreateAggragate aggragate;
        private int currentIndex = 0;
        public ConcreteMyIterator(ConcreateAggragate aggragate)
        {
            this.aggragate = aggragate;
            currentIndex = 0;
        }

        public object Frist()
        {
            return aggragate[0];
        }

        public bool HasNext()
        {
            if (currentIndex >= aggragate.Count)
            {
                return false;
            }
            return true;
        }

        public object Next()
        {
            return aggragate[currentIndex++];
        }
    }
}
